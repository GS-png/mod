using System;
using System.Collections.Generic;
using System.Globalization;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.DemonLord;
using EraWheel.Narrative;
using EraWheel.Civilization;
using EraWheel.UI.Components;

namespace EraWheel.UI.Tabs
{
    public class DemonManageTab : ITab
    {
        private UnityEngine.Vector2 _scrollPos;
        private readonly Dictionary<string, string> _healthInputs = new Dictionary<string, string>(StringComparer.Ordinal);

        public void Draw(
            ModConfig cfg,
            CycleManager cycle,
            DemonLordRegistry registry,
            CivilizationTracker civTracker,
            AllianceSystem alliance,
            LegionWaveSystem legion,
            GeneralSystem generals,
            HeroSystem heroes)
        {
            UnityEngine.GUILayout.Label("=== 魔王管理 ===", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(5);

            if (registry == null)
            {
                UnityEngine.GUILayout.Label("魔王注册表未初始化");
                return;
            }

            _scrollPos = UnityEngine.GUILayout.BeginScrollView(_scrollPos);

            var lords = registry.GetAllLords();
            if (lords == null || lords.Count == 0)
            {
                UnityEngine.GUILayout.Label("没有注册的魔王");
            }
            else
            {
                foreach (var lord in lords)
                {
                    DrawLordEntry(lord, registry, cycle);
                    UnityEngine.GUILayout.Space(5);
                }
            }

            UnityEngine.GUILayout.EndScrollView();

            UnityEngine.GUILayout.Space(10);

            DrawQuickActions(registry, cycle);
        }

        private void DrawLordEntry(DemonLordBase lord, DemonLordRegistry registry, CycleManager cycle)
        {
            UnityEngine.GUILayout.BeginVertical("box");

            UnityEngine.GUILayout.BeginHorizontal();
            var displayName = Localization.Get(lord.NameKey, lord.NameKey);
            UnityEngine.GUILayout.Label(displayName, UnityEngine.GUILayout.Width(150));
            var forcedTag = lord.IsStateForced ? " (强制)" : "";
            UnityEngine.GUILayout.Label($"状态: {lord.State}{forcedTag}", UnityEngine.GUILayout.Width(120));
            UnityEngine.GUILayout.Label($"HP: {lord.CurrentHealth:F0}/{lord.MaxHealth:F0}");
            UnityEngine.GUILayout.EndHorizontal();

            DrawHealthControl(lord, registry, cycle);

            UnityEngine.GUILayout.BeginHorizontal();

            var isEnabled = lord.Enabled;
            var newEnabled = UnityEngine.GUILayout.Toggle(isEnabled, "启用");
            if (newEnabled != isEnabled)
            {
                lord.SetEnabled(newEnabled);
                Log.Info("[EraWheel] DemonLord " + lord.Id + " enabled=" + newEnabled);
            }

            if (UnityEngine.GUILayout.Button("强制苏醒", UnityEngine.GUILayout.Width(80)))
            {
                ConfirmDialog.Instance.Show(
                    "危险操作确认",
                    $"确定强制苏醒 {lord.NameKey} ?",
                    () => ForceAwaken(lord, registry, cycle));
            }

            if (UnityEngine.GUILayout.Button("强制击败", UnityEngine.GUILayout.Width(80)))
            {
                ConfirmDialog.Instance.Show(
                    "危险操作确认",
                    $"确定强制击败 {lord.NameKey} ?",
                    () => ForceDefeat(lord, registry, cycle));
            }

            if (lord.IsStateForced && UnityEngine.GUILayout.Button("恢复自动", UnityEngine.GUILayout.Width(80)))
            {
                lord.ClearForcedState();
                Log.Info("[EraWheel] Cleared forced state: " + lord.Id);
            }

            UnityEngine.GUILayout.EndHorizontal();

            UnityEngine.GUILayout.EndVertical();
        }

        private void DrawHealthControl(DemonLordBase lord, DemonLordRegistry registry, CycleManager cycle)
        {
            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUILayout.Label("强度%", UnityEngine.GUILayout.Width(50));

            var current = lord.CurrentHealthPercent;
            var next = UnityEngine.GUILayout.HorizontalSlider(current, 0f, 100f, UnityEngine.GUILayout.Width(120));
            var key = lord.Id ?? "";
            if (!_healthInputs.TryGetValue(key, out var text))
            {
                text = current.ToString("F0", CultureInfo.InvariantCulture);
            }

            text = UnityEngine.GUILayout.TextField(text, UnityEngine.GUILayout.Width(50));
            if (float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out var parsed))
            {
                next = parsed;
            }

            if (Math.Abs(next - current) > 0.1f)
            {
                lord.SetHealthPercent(next);
                if (registry != null && registry.ActiveDemonLord == lord && cycle != null)
                {
                    cycle.SetExternalDemonHealthPercent(next);
                }

                _healthInputs[key] = next.ToString("F0", CultureInfo.InvariantCulture);
            }
            else
            {
                _healthInputs[key] = text;
            }

            UnityEngine.GUILayout.EndHorizontal();
        }

        private void DrawQuickActions(DemonLordRegistry registry, CycleManager cycle)
        {
            UnityEngine.GUILayout.Label("=== 快捷操作 ===", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(5);

            UnityEngine.GUILayout.BeginHorizontal();

            if (UnityEngine.GUILayout.Button("全部启用"))
            {
                foreach (var lord in registry.GetAllLords())
                {
                    lord.SetEnabled(true);
                }
                Log.Info("[EraWheel] All demon lords enabled");
            }

            if (UnityEngine.GUILayout.Button("全部禁用"))
            {
                foreach (var lord in registry.GetAllLords())
                {
                    lord.SetEnabled(false);
                }
                Log.Info("[EraWheel] All demon lords disabled");
            }

            UnityEngine.GUILayout.EndHorizontal();
        }

        private static void ForceAwaken(DemonLordBase lord, DemonLordRegistry registry, CycleManager cycle)
        {
            if (lord == null || registry == null) return;

            if (!lord.Enabled)
            {
                WorldCompat.ShowNotification("该魔王已被禁用，请先勾选“启用”。");
                Log.Warning("[EraWheel] Force awaken skipped. Demon lord is disabled: " + lord.Id);
                return;
            }

            var cycleCount = cycle != null ? cycle.CycleCount : 0;
            var shouldAwaken = lord.State == DemonLordState.Sealed || lord.State == DemonLordState.Disabled || !lord.HasActor;

            registry.ForceSetActive(lord.Id);
            lord.ClearForcedState();
            lord.UpdateStateFromSystem(DemonLordState.Awakening);
            var cfg = global::EraWheel.Main.Instance?.ConfigManager?.Config;
            lord.ApplyGrowth(DemonGrowthCalculator.ComputeStrengthMultiplier(cfg, cycleCount));

            if (cycle != null)
            {
                cycle.ForcePhase(EraPhase.Awakening);
                cycle.ForceDemonHealthPercent(30f);
            }

            if (shouldAwaken)
            {
                lord.OnAwaken(cycleCount);
            }

            if (!lord.HasActor)
            {
                WorldCompat.ShowNotification("魔王生成失败：单位资源未就绪或地图无可用位置。");
            }

            Log.Info("[EraWheel] Force awakened: " + lord.Id);
        }

        private static void ForceDefeat(DemonLordBase lord, DemonLordRegistry registry, CycleManager cycle)
        {
            if (lord == null) return;

            if (cycle != null)
            {
                cycle.ForcePhase(EraPhase.Weakening);
                cycle.ForceDemonHealthPercent(0f);
            }

            registry?.ForceSetActive(lord.Id);
            lord.ForceState(DemonLordState.Defeated);
            Log.Info("[EraWheel] Force defeated: " + lord.Id);
        }
    }
}
