using System.Collections.Generic;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.DemonLord;
using EraWheel.Civilization;

namespace EraWheel.UI.Tabs
{
    public class DemonManageTab : ITab
    {
        private UnityEngine.Vector2 _scrollPos;
        private bool _confirmPending;
        private string _pendingAction;
        private string _pendingLordId;

        public void Draw(
            ModConfig cfg,
            CycleManager cycle,
            DemonLordRegistry registry,
            CivilizationTracker civTracker,
            AllianceSystem alliance)
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

            if (_confirmPending)
            {
                DrawConfirmDialog(registry, cycle);
            }
        }

        private void DrawLordEntry(DemonLordBase lord, DemonLordRegistry registry, CycleManager cycle)
        {
            UnityEngine.GUILayout.BeginVertical("box");

            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUILayout.Label($"{lord.NameKey}", UnityEngine.GUILayout.Width(150));
            UnityEngine.GUILayout.Label($"状态: {lord.State}", UnityEngine.GUILayout.Width(100));
            UnityEngine.GUILayout.Label($"HP: {lord.CurrentHealth:F0}/{lord.MaxHealth:F0}");
            UnityEngine.GUILayout.EndHorizontal();

            UnityEngine.GUILayout.BeginHorizontal();

            var isEnabled = lord.Enabled;
            var newEnabled = UnityEngine.GUILayout.Toggle(isEnabled, "启用");
            if (newEnabled != isEnabled)
            {
                lord.Enabled = newEnabled;
                Log.Info("[EraWheel] DemonLord " + lord.Id + " enabled=" + newEnabled);
            }

            if (UnityEngine.GUILayout.Button("强制苏醒", UnityEngine.GUILayout.Width(80)))
            {
                RequestConfirm("force_awaken", lord.Id);
            }

            if (UnityEngine.GUILayout.Button("强制击败", UnityEngine.GUILayout.Width(80)))
            {
                RequestConfirm("force_defeat", lord.Id);
            }

            UnityEngine.GUILayout.EndHorizontal();

            UnityEngine.GUILayout.EndVertical();
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
                    lord.Enabled = true;
                }
                Log.Info("[EraWheel] All demon lords enabled");
            }

            if (UnityEngine.GUILayout.Button("全部禁用"))
            {
                foreach (var lord in registry.GetAllLords())
                {
                    lord.Enabled = false;
                }
                Log.Info("[EraWheel] All demon lords disabled");
            }

            UnityEngine.GUILayout.EndHorizontal();
        }

        private void RequestConfirm(string action, string lordId)
        {
            _confirmPending = true;
            _pendingAction = action;
            _pendingLordId = lordId;
        }

        private void DrawConfirmDialog(DemonLordRegistry registry, CycleManager cycle)
        {
            UnityEngine.GUILayout.Space(10);
            UnityEngine.GUILayout.BeginVertical("box");

            UnityEngine.GUILayout.Label("⚠️ 危险操作确认", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Label($"操作: {_pendingAction}");
            UnityEngine.GUILayout.Label($"目标: {_pendingLordId}");

            UnityEngine.GUILayout.BeginHorizontal();

            if (UnityEngine.GUILayout.Button("确认执行"))
            {
                ExecutePendingAction(registry, cycle);
                _confirmPending = false;
            }

            if (UnityEngine.GUILayout.Button("取消"))
            {
                _confirmPending = false;
            }

            UnityEngine.GUILayout.EndHorizontal();

            UnityEngine.GUILayout.EndVertical();
        }

        private void ExecutePendingAction(DemonLordRegistry registry, CycleManager cycle)
        {
            if (string.IsNullOrEmpty(_pendingAction) || string.IsNullOrEmpty(_pendingLordId)) return;

            var lord = registry.GetLord(_pendingLordId);
            if (lord == null) return;

            switch (_pendingAction)
            {
                case "force_awaken":
                    lord.ForceState(DemonLordState.Active);
                    Log.Info("[EraWheel] Force awakened: " + _pendingLordId);
                    break;

                case "force_defeat":
                    lord.ForceState(DemonLordState.Defeated);
                    Log.Info("[EraWheel] Force defeated: " + _pendingLordId);
                    break;
            }
        }
    }
}
