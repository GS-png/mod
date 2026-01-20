using EraWheel.Config;
using EraWheel.Core;
using EraWheel.DemonLord;
using EraWheel.Civilization;
using EraWheel.Data;

namespace EraWheel.UI.Tabs
{
    public class DebugTab : ITab
    {
        private UnityEngine.Vector2 _scrollPos;
        private bool _showInternalVars = true;
        private bool _showQuickActions = true;
        private bool _confirmPending;
        private string _pendingAction;

        public void Draw(
            ModConfig cfg,
            CycleManager cycle,
            DemonLordRegistry registry,
            CivilizationTracker civTracker,
            AllianceSystem alliance)
        {
            _scrollPos = UnityEngine.GUILayout.BeginScrollView(_scrollPos);

            if (cfg?.debug?.enabled != true)
            {
                UnityEngine.GUILayout.Label("调试模式已禁用");
                UnityEngine.GUILayout.Label("在配置中设置 debug.enabled = true 以启用");

                if (UnityEngine.GUILayout.Button("强制启用调试模式"))
                {
                    if (cfg != null && cfg.debug != null)
                    {
                        cfg.debug.enabled = true;
                    }
                }

                UnityEngine.GUILayout.EndScrollView();
                return;
            }

            DrawInternalVars(cycle, registry, civTracker, alliance);
            UnityEngine.GUILayout.Space(10);

            DrawQuickActions(cycle, registry);

            if (_confirmPending)
            {
                DrawConfirmDialog(cycle, registry);
            }

            UnityEngine.GUILayout.EndScrollView();
        }

        private void DrawInternalVars(CycleManager cycle, DemonLordRegistry registry,
            CivilizationTracker civTracker, AllianceSystem alliance)
        {
            _showInternalVars = DrawFoldout("内部变量", _showInternalVars);

            if (!_showInternalVars) return;

            UnityEngine.GUILayout.BeginVertical("box");

            UnityEngine.GUILayout.Label("--- 轮回系统 ---");
            UnityEngine.GUILayout.Label($"CycleCount: {cycle?.CycleCount ?? 0}");
            UnityEngine.GUILayout.Label($"CurrentPhase: {cycle?.CurrentPhase}");
            UnityEngine.GUILayout.Label($"SealStrength: {cycle?.SealStrength ?? 0f:F2}");
            UnityEngine.GUILayout.Label($"WorldAge: {cycle?.WorldAge ?? 0}");
            UnityEngine.GUILayout.Label($"PhaseStartAge: {cycle?.PhaseStartWorldAge ?? 0}");

            UnityEngine.GUILayout.Space(5);
            UnityEngine.GUILayout.Label("--- 魔王系统 ---");
            var active = registry?.ActiveDemonLord;
            UnityEngine.GUILayout.Label($"ActiveLord: {active?.Id ?? "null"}");
            UnityEngine.GUILayout.Label($"LordState: {active?.State}");
            UnityEngine.GUILayout.Label($"LordHP: {active?.CurrentHealth ?? 0f:F0} / {active?.MaxHealth ?? 0f:F0}");
            UnityEngine.GUILayout.Label($"TotalKills: {active?.TotalKills ?? 0}");

            UnityEngine.GUILayout.Space(5);
            UnityEngine.GUILayout.Label("--- 文明系统 ---");
            UnityEngine.GUILayout.Label($"CSI: {civTracker?.CSI ?? 0f:F2}");
            UnityEngine.GUILayout.Label($"AntiDemonLevel: {civTracker?.AntiDemonLevel ?? 0}");
            UnityEngine.GUILayout.Label($"DemonKillCount: {civTracker?.DemonKillCount ?? 0}");

            UnityEngine.GUILayout.Space(5);
            UnityEngine.GUILayout.Label("--- 联盟系统 ---");
            var allianceState = alliance?.State;
            UnityEngine.GUILayout.Label($"AllianceFormed: {allianceState?.Formed ?? false}");
            UnityEngine.GUILayout.Label($"CouncilCount: {allianceState?.CouncilCount ?? 0}");
            UnityEngine.GUILayout.Label($"SealProgress: {allianceState?.SealProgress ?? 0f:F2}");

            UnityEngine.GUILayout.EndVertical();
        }

        private void DrawQuickActions(CycleManager cycle, DemonLordRegistry registry)
        {
            _showQuickActions = DrawFoldout("快捷操作", _showQuickActions);

            if (!_showQuickActions) return;

            UnityEngine.GUILayout.BeginVertical("box");

            UnityEngine.GUILayout.Label("⚠️ 危险操作 - 可能破坏游戏状态");
            UnityEngine.GUILayout.Space(5);

            UnityEngine.GUILayout.BeginHorizontal();

            if (UnityEngine.GUILayout.Button("跳过到下一阶段"))
            {
                RequestConfirm("skip_phase");
            }

            if (UnityEngine.GUILayout.Button("强制触发轮回"))
            {
                RequestConfirm("force_cycle");
            }

            UnityEngine.GUILayout.EndHorizontal();

            UnityEngine.GUILayout.BeginHorizontal();

            if (UnityEngine.GUILayout.Button("重置封印强度"))
            {
                RequestConfirm("reset_seal");
            }

            if (UnityEngine.GUILayout.Button("模拟击杀魔物 x100"))
            {
                EventBus.Publish(new DemonKillEvent { Count = 100, WorldTime = cycle?.WorldAge ?? 0 });
                Log.Info("[EraWheel] Debug: Published 100 demon kills");
            }

            UnityEngine.GUILayout.EndHorizontal();

            UnityEngine.GUILayout.EndVertical();
        }

        private void RequestConfirm(string action)
        {
            _confirmPending = true;
            _pendingAction = action;
        }

        private void DrawConfirmDialog(CycleManager cycle, DemonLordRegistry registry)
        {
            UnityEngine.GUILayout.Space(10);
            UnityEngine.GUILayout.BeginVertical("box");

            UnityEngine.GUILayout.Label("⚠️ 确认执行危险操作?", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Label($"操作: {_pendingAction}");

            UnityEngine.GUILayout.BeginHorizontal();

            if (UnityEngine.GUILayout.Button("确认"))
            {
                ExecutePendingAction(cycle, registry);
                _confirmPending = false;
            }

            if (UnityEngine.GUILayout.Button("取消"))
            {
                _confirmPending = false;
            }

            UnityEngine.GUILayout.EndHorizontal();

            UnityEngine.GUILayout.EndVertical();
        }

        private void ExecutePendingAction(CycleManager cycle, DemonLordRegistry registry)
        {
            if (string.IsNullOrEmpty(_pendingAction)) return;

            switch (_pendingAction)
            {
                case "skip_phase":
                    cycle?.ForceNextPhase();
                    Log.Info("[EraWheel] Debug: Forced phase transition");
                    break;

                case "force_cycle":
                    cycle?.ForceCompleteCycle();
                    Log.Info("[EraWheel] Debug: Forced cycle completion");
                    break;

                case "reset_seal":
                    cycle?.ResetSealStrength();
                    Log.Info("[EraWheel] Debug: Reset seal strength");
                    break;
            }
        }

        private bool DrawFoldout(string label, bool current)
        {
            var icon = current ? "▼" : "▶";
            if (UnityEngine.GUILayout.Button($"{icon} {label}", "Label"))
            {
                return !current;
            }
            return current;
        }
    }
}
