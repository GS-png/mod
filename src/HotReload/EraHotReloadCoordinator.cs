using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using EraWheel.Assets;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Core.Logging;
using EraWheel.Data.Definitions;
using EraWheel.Debug;
using EraWheel.Reflection;
using EraWheel.Save.Models;
using EraWheel.UI;
using NeoModLoader.api;
using Newtonsoft.Json;

namespace EraWheel.HotReload;

public static class EraHotReloadCoordinator
{
    public static EraReloadResult Execute(EraWheelMod mod)
    {
        EraReloadResult result = new EraReloadResult();
        Stopwatch totalWatch = Stopwatch.StartNew();
        ModDeclare declaration = mod.GetDeclaration();
        Assembly runtimeAssembly = mod.GetType().Assembly;
        EraReloadSnapshot snapshot = EraReloadSnapshot.Capture();
        EraCompiledReloadAssembly? compiled = null;
        List<string> patchedMethodKeys = new List<string>();
        bool methodPatchStageStarted = false;

        try
        {
            RunStage(
                result,
                EraReloadStage.Preflight,
                () =>
                {
                    if (!EraHotReloadSelfCheck.Run(out string checkMessage))
                    {
                        throw new InvalidOperationException(checkMessage);
                    }

                    return checkMessage;
                }
            );

            RunStage(
                result,
                EraReloadStage.Compile,
                () =>
                {
                    if (!EraNmlHotReloadGateway.TryPrepareAndCompile(mod, declaration, out compiled, out string compileMessage) ||
                        compiled == null)
                    {
                        throw new InvalidOperationException(compileMessage);
                    }

                    return compileMessage;
                }
            );

            RunStage(
                result,
                EraReloadStage.CompatibilityScan,
                () =>
                {
                    if (compiled == null)
                    {
                        throw new InvalidOperationException("兼容扫描失败：编译产物为空。");
                    }

                    if (!EraNmlHotReloadGateway.TryScanCompatibility(
                            runtimeAssembly,
                            compiled,
                            out EraCompatibilityReport compatibilityReport,
                            out string compatibilityMessage))
                    {
                        result.Stats.CompatibilityIssues = compatibilityReport.Issues.Count;
                        throw new EraReloadRestartRequiredException(compatibilityMessage, compatibilityReport);
                    }

                    result.Stats.CompatibilityIssues = compatibilityReport.Issues.Count;
                    if (compatibilityReport.RequiresRestart)
                    {
                        throw new EraReloadRestartRequiredException(compatibilityMessage, compatibilityReport);
                    }

                    return compatibilityMessage;
                }
            );

            RunStage(
                result,
                EraReloadStage.MethodPatch,
                () =>
                {
                    if (compiled == null)
                    {
                        throw new InvalidOperationException("方法体补丁失败：编译产物为空。");
                    }

                    methodPatchStageStarted = true;
                    if (!EraNmlHotReloadGateway.TryPatchChangedMethods(
                            runtimeAssembly,
                            compiled,
                            out EraMethodPatchReport patchReport,
                            out string patchMessage))
                    {
                        result.Stats.MethodsPatched = patchReport.Patched;
                        result.Stats.MethodsSkipped = patchReport.Skipped;
                        result.Stats.MethodsFailed = patchReport.Failed;
                        patchedMethodKeys.AddRange(patchReport.PatchedMethodKeys);
                        throw new InvalidOperationException(patchMessage);
                    }

                    result.Stats.MethodsPatched = patchReport.Patched;
                    result.Stats.MethodsSkipped = patchReport.Skipped;
                    result.Stats.MethodsFailed = patchReport.Failed;
                    patchedMethodKeys.AddRange(patchReport.PatchedMethodKeys);
                    return patchMessage;
                }
            );

            RunStage(
                result,
                EraReloadStage.ResourcesAndLocales,
                () =>
                {
                    if (!EraNmlHotReloadGateway.TryReloadResources(mod, out string resourceMessage))
                    {
                        throw new InvalidOperationException(resourceMessage);
                    }

                    EraNmlHotReloadGateway.ReloadLocales(mod, out int localeFiles);
                    result.Stats.LocaleFilesReloaded = localeFiles;
                    return $"{resourceMessage} 文本文件={localeFiles}。";
                }
            );

            RunStage(
                result,
                EraReloadStage.RuntimeRebuild,
                () =>
                {
                    EraConfig.Initialize(declaration, mod.GetConfig());
                    WorldboxReflectionAdapter.ResetForReload();
                    WorldboxReflectionAdapter.Initialize();

                    EraContentCatalog previousCatalog = snapshot.PreviousContentCatalog;
                    EraSpriteHotReloadService.ReconcileCatalog(snapshot.PreviousSpriteCatalog);
                    EraRuntimeBootstrap.Reload(declaration, EraConfig.ParameterRegistry);
                    EraSpriteHotReloadService.ReconcileCatalog(EraRuntimeBootstrap.SpriteCatalog);
                    EraSpriteHotReloadService.DrainSessionStats(out int updatedSprites, out int removedSprites);
                    int removedAssets = EraAssetReconciliationService.RemoveStaleAssets(previousCatalog, EraRuntimeBootstrap.ContentCatalog);
                    int removedStatuses = EraAssetReconciliationService.RemoveStaleStatuses(snapshot.PreviousEraStatusIds);
                    result.Stats.ResourcesUpdated += updatedSprites;
                    result.Stats.ResourcesRemoved += removedSprites;
                    result.Stats.AssetsRemoved += removedAssets + removedStatuses;

                    return
                        $"运行态重建完成：sprite_upsert={updatedSprites} sprite_remove={removedSprites} " +
                        $"stale_asset_remove={removedAssets} stale_status_remove={removedStatuses}。";
                }
            );

            RunStage(
                result,
                EraReloadStage.WorldRebind,
                () =>
                {
                    EraWorldRebindReport rebindReport = EraWorldEntityRebindService.RebindCurrentWorld(
                        EraRuntimeBootstrap.ContentCatalog,
                        snapshot.PreviousContentCatalog
                    );
                    result.Stats.WorldActorsRebound = rebindReport.ActorsRebound;
                    result.Stats.WorldBuildingsRebound = rebindReport.BuildingsRebound;
                    result.Stats.WorldItemsRebound = rebindReport.ItemsRebound;
                    result.Stats.WorldCustomDataMappingsApplied = rebindReport.CustomDataMappingsApplied;
                    foreach (string warning in rebindReport.Warnings)
                    {
                        result.Issues.Add(
                            new EraReloadIssue
                            {
                                Kind = EraReloadIssueKind.WorldRebind,
                                Stage = EraReloadStage.WorldRebind,
                                Message = warning,
                            }
                        );
                    }

                    return rebindReport.CreateSummary();
                }
            );

            RunStage(
                result,
                EraReloadStage.UiRebind,
                () =>
                {
                    EraHudOverlay.ResetForReload();
                    EraUiBootstrap.Reload();
                    EraDebugPanelService.ResetForReload();
                    EraDebugPanelService.Initialize();
                    EraHudOverlay.SetVisible(snapshot.HudVisible);
                    EraDebugWindow.Instance?.RefreshView();
                    return "UI/HUD 重新绑定完成。";
                }
            );

            RunStage(
                result,
                EraReloadStage.Commit,
                () =>
                {
                    EraRuntimeBootstrap.RuntimeSave?.PersistIfPossible();
                    return "提交完成：当前世界状态已写回。";
                }
            );

            result.Success = true;
            result.Outcome = EraReloadOutcome.Succeeded;
            result.ErrorCode = EraReloadErrorCode.None;
            return result;
        }
        catch (EraReloadRestartRequiredException exception)
        {
            result.Success = false;
            result.RestartRequired = true;
            result.Outcome = EraReloadOutcome.RestartRequired;
            result.ErrorCode = EraReloadErrorCode.RestartRequired;
            result.Summary = $"热加载已安全停止，需要重启游戏：{exception.Message}";
            foreach (EraCompatibilityIssue compatibilityIssue in exception.Report.Issues)
            {
                result.Issues.Add(
                    new EraReloadIssue
                    {
                        Kind = EraReloadIssueKind.Compatibility,
                        Stage = EraReloadStage.CompatibilityScan,
                        Message = compatibilityIssue.Message,
                        Detail = compatibilityIssue.Member,
                    }
                );
            }

            EraLog.Warning(EraLogCategory.Startup, result.Summary);
            return result;
        }
        catch (Exception exception)
        {
            result.Success = false;
            result.Outcome = EraReloadOutcome.Failed;
            result.Summary = $"整模组热加载失败：{exception.Message}";
            EraLog.Exception(EraLogCategory.Startup, "热加载事务执行失败。", exception);
            TryRollback(snapshot, result, runtimeAssembly, compiled, patchedMethodKeys, methodPatchStageStarted);
            return result;
        }
        finally
        {
            totalWatch.Stop();
            result.TotalDurationMs = totalWatch.ElapsedMilliseconds;
            result.FinishedAt = DateTimeOffset.Now;
            if (result.Outcome == EraReloadOutcome.Succeeded)
            {
                result.Summary = result.CreateDebugReport();
            }
            else if (result.Outcome == EraReloadOutcome.RestartRequired)
            {
                result.Summary = $"{result.Summary} {result.CreateDebugReport()}";
            }
            else if (result.RollbackAttempted)
            {
                result.Summary = $"{result.Summary} {(result.RollbackSucceeded ? "已回滚到上一个内存状态。" : "回滚失败，请尽快备份并重启。")}";
            }
        }
    }

    private static void RunStage(EraReloadResult result, EraReloadStage stage, Func<string> action)
    {
        Stopwatch watch = Stopwatch.StartNew();
        result.LastStage = stage;
        try
        {
            string message = action();
            watch.Stop();
            result.StageReports.Add(
                new EraReloadStageReport
                {
                    Stage = stage,
                    Success = true,
                    DurationMs = watch.ElapsedMilliseconds,
                    Message = message,
                }
            );
            EraLog.Info(EraLogCategory.Startup, $"[热加载/{stage}] {message}");
        }
        catch (Exception exception)
        {
            watch.Stop();
            string message = exception.InnerException?.Message ?? exception.Message;
            result.StageReports.Add(
                new EraReloadStageReport
                {
                    Stage = stage,
                    Success = false,
                    DurationMs = watch.ElapsedMilliseconds,
                    Message = message,
                }
            );
            result.Issues.Add(
                new EraReloadIssue
                {
                    Kind = ToIssueKind(stage),
                    Stage = stage,
                    Message = message,
                    Detail = exception.StackTrace,
                }
            );
            result.ErrorCode = ToErrorCode(stage);
            throw;
        }
    }

    private static void TryRollback(
        EraReloadSnapshot snapshot,
        EraReloadResult result,
        Assembly runtimeAssembly,
        EraCompiledReloadAssembly? compiled,
        IReadOnlyList<string> patchedMethodKeys,
        bool methodPatchStageStarted
    )
    {
        result.RollbackAttempted = true;
        bool rollbackSucceeded = true;
        try
        {
            if (methodPatchStageStarted && compiled != null)
            {
                bool methodRollback = EraNmlHotReloadGateway.TryRollbackPatchedMethods(
                    runtimeAssembly,
                    compiled,
                    patchedMethodKeys,
                    out string rollbackMessage
                );
                rollbackSucceeded &= methodRollback;
                if (!methodRollback)
                {
                    result.Issues.Add(
                        new EraReloadIssue
                        {
                            Kind = EraReloadIssueKind.Rollback,
                            Stage = result.LastStage,
                            Message = rollbackMessage,
                        }
                    );
                }
            }

            if (snapshot.RuntimeState != null && EraRuntimeBootstrap.RuntimeSave != null)
            {
                EraRuntimeBootstrap.RuntimeSave.RestoreState(CloneState(snapshot.RuntimeState), loadedFromSave: true);
                EraRuntimeBootstrap.RefreshWorldBinding();
            }

            EraUiBootstrap.Reload();
            EraDebugPanelService.ResetForReload();
            EraDebugPanelService.Initialize();
            EraHudOverlay.SetVisible(snapshot.HudVisible);
            EraDebugWindow.Instance?.RefreshView();

            result.RollbackSucceeded = rollbackSucceeded;
            if (!rollbackSucceeded)
            {
                result.ErrorCode = EraReloadErrorCode.RollbackFailed;
            }
        }
        catch (Exception exception)
        {
            result.RollbackSucceeded = false;
            result.Issues.Add(
                new EraReloadIssue
                {
                    Kind = EraReloadIssueKind.Rollback,
                    Stage = result.LastStage,
                    Message = "回滚失败。",
                    Detail = exception.Message,
                }
            );
            result.ErrorCode = EraReloadErrorCode.RollbackFailed;
            EraLog.Exception(EraLogCategory.Startup, "热加载回滚失败。", exception);
        }
    }

    private static EraReloadIssueKind ToIssueKind(EraReloadStage stage)
    {
        return stage switch
        {
            EraReloadStage.Preflight => EraReloadIssueKind.Unknown,
            EraReloadStage.Compile => EraReloadIssueKind.Compile,
            EraReloadStage.CompatibilityScan => EraReloadIssueKind.Compatibility,
            EraReloadStage.MethodPatch => EraReloadIssueKind.Patch,
            EraReloadStage.ResourcesAndLocales => EraReloadIssueKind.Resource,
            EraReloadStage.RuntimeRebuild => EraReloadIssueKind.Runtime,
            EraReloadStage.WorldRebind => EraReloadIssueKind.WorldRebind,
            EraReloadStage.UiRebind => EraReloadIssueKind.UI,
            _ => EraReloadIssueKind.Unknown,
        };
    }

    private static EraReloadErrorCode ToErrorCode(EraReloadStage stage)
    {
        return stage switch
        {
            EraReloadStage.Preflight => EraReloadErrorCode.PreflightFailed,
            EraReloadStage.Compile => EraReloadErrorCode.CompileFailed,
            EraReloadStage.CompatibilityScan => EraReloadErrorCode.CompatibilityRestartRequired,
            EraReloadStage.MethodPatch => EraReloadErrorCode.MethodPatchFailed,
            EraReloadStage.ResourcesAndLocales => EraReloadErrorCode.ResourcesFailed,
            EraReloadStage.RuntimeRebuild => EraReloadErrorCode.RuntimeRebuildFailed,
            EraReloadStage.WorldRebind => EraReloadErrorCode.WorldRebindFailed,
            EraReloadStage.UiRebind => EraReloadErrorCode.UiRebindFailed,
            EraReloadStage.Commit => EraReloadErrorCode.CommitFailed,
            _ => EraReloadErrorCode.None,
        };
    }

    private static EraWorldRuntimeState CloneState(EraWorldRuntimeState state)
    {
        string json = JsonConvert.SerializeObject(state);
        return JsonConvert.DeserializeObject<EraWorldRuntimeState>(json) ?? new EraWorldRuntimeState();
    }

    private sealed class EraReloadRestartRequiredException : Exception
    {
        public EraCompatibilityReport Report { get; }

        public EraReloadRestartRequiredException(string message, EraCompatibilityReport report)
            : base(message)
        {
            Report = report;
        }
    }

    private sealed class EraReloadSnapshot
    {
        public EraWorldRuntimeState? RuntimeState { get; private set; }
        public bool HudVisible { get; private set; }
        public EraContentCatalog PreviousContentCatalog { get; private set; } = EraContentCatalog.Empty;
        public EraSpriteCatalog PreviousSpriteCatalog { get; private set; } = EraSpriteCatalog.Empty;
        public HashSet<string> PreviousEraStatusIds { get; private set; } = new HashSet<string>(StringComparer.Ordinal);

        public static EraReloadSnapshot Capture()
        {
            EraReloadSnapshot snapshot = new EraReloadSnapshot
            {
                HudVisible = EraHudOverlay.IsVisible,
                PreviousContentCatalog = EraRuntimeBootstrap.ContentCatalog,
                PreviousSpriteCatalog = EraRuntimeBootstrap.SpriteCatalog,
                PreviousEraStatusIds = EraAssetReconciliationService.CaptureEraStatusIdsFromLibrary(),
            };

            EraWorldRuntimeState? state = EraRuntimeBootstrap.RuntimeSave?.CurrentState;
            if (state != null)
            {
                snapshot.RuntimeState = CloneState(state);
            }

            return snapshot;
        }
    }
}
