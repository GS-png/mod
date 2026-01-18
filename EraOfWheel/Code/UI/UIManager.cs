using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.Cycle;
using EraOfWheel.DemonLords;
using EraOfWheel.UI.Panels;
using Logger = EraOfWheel.Core.Logger;

namespace EraOfWheel.UI
{
    public class EraOfWheelGuiBehaviour : MonoBehaviour
    {
        public UIManager Manager;

        private void OnGUI()
        {
            if (Manager == null) return;
            Manager.RenderGui();
        }
    }

    public class UIManager : IModSystem
    {
        public static UIManager Instance { get; private set; }
        
        public string SystemName => "UIManager";
        public bool IsInitialized { get; private set; }
        
        public bool IsPanelVisible { get; private set; } = false;
        
        private UIConfig _config;
        private KeyCode _hotkey = KeyCode.F8;
        private GameObject _mainPanel;
        private EraOfWheelGuiBehaviour _gui;

        private Rect _windowRect = new Rect(40, 40, 520, 640);
        private Vector2 _scrollPos;
        private int _tabIndex = 0;
        private string _selectedDemonId = "";

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            _config = ConfigManager.Instance?.Config?.ui ?? new UIConfig();
            
            ParseHotkey(_config.hotkey);
            CreateUI();
            
            IsInitialized = true;
            Logger.Info(SystemName, $"UIManager initialized, hotkey: {_hotkey}");
        }

        private void ParseHotkey(string keyName)
        {
            if (Enum.TryParse<KeyCode>(keyName, true, out var key))
            {
                _hotkey = key;
            }
        }

        private void CreateUI()
        {
            if (!_config.enabled) return;
            
            // Note: Full implementation would create NeoModLoader UI elements
            if (_mainPanel != null) return;

            _mainPanel = new GameObject("EraOfWheel_UI");
            var parent = ModMain.Instance?.GetGameObject();
            if (parent != null)
            {
                _mainPanel.transform.SetParent(parent.transform, false);
            }
            UnityEngine.Object.DontDestroyOnLoad(_mainPanel);

            _gui = _mainPanel.AddComponent<EraOfWheelGuiBehaviour>();
            _gui.Manager = this;

            _mainPanel.SetActive(false);
            Logger.Debug(SystemName, "UI elements created");
        }

        public void Update()
        {
            if (!IsInitialized || !_config.enabled) return;
            
            if (Input.GetKeyDown(_hotkey))
            {
                TogglePanel();
            }
        }

        public void TogglePanel()
        {
            IsPanelVisible = !IsPanelVisible;
            
            if (_mainPanel != null)
            {
                _mainPanel.SetActive(IsPanelVisible);
            }

            if (IsPanelVisible)
            {
                OverviewPanel.Instance?.Show();
                DemonPanel.Instance?.Show();
            }
            else
            {
                OverviewPanel.Instance?.Hide();
                DemonPanel.Instance?.Hide();
            }
            
            Logger.Debug(SystemName, $"Panel visibility: {IsPanelVisible}");
        }

        public void ShowPanel()
        {
            IsPanelVisible = true;
            if (_mainPanel != null)
            {
                _mainPanel.SetActive(true);
            }
            OverviewPanel.Instance?.Show();
            DemonPanel.Instance?.Show();
        }

        public void HidePanel()
        {
            IsPanelVisible = false;
            if (_mainPanel != null)
            {
                _mainPanel.SetActive(false);
            }
            OverviewPanel.Instance?.Hide();
            DemonPanel.Instance?.Hide();
        }

        internal void RenderGui()
        {
            if (!IsInitialized || !_config.enabled) return;
            if (!IsPanelVisible) return;

            _windowRect = GUILayout.Window(891337, _windowRect, DrawWindow, "EraOfWheel");
        }

        private void DrawWindow(int id)
        {
            GUILayout.BeginHorizontal();
            if (GUILayout.Toggle(_tabIndex == 0, "总览", GUI.skin.button)) _tabIndex = 0;
            if (GUILayout.Toggle(_tabIndex == 1, "魔王", GUI.skin.button)) _tabIndex = 1;
            if (GUILayout.Toggle(_tabIndex == 2, "调试", GUI.skin.button)) _tabIndex = 2;
            GUILayout.EndHorizontal();

            _scrollPos = GUILayout.BeginScrollView(_scrollPos);

            if (_tabIndex == 0)
            {
                var text = OverviewPanel.Instance?.GetSummaryText() ?? "(总览不可用)";
                GUILayout.TextArea(text);
            }
            else if (_tabIndex == 1)
            {
                DrawDemonsTab();
            }
            else
            {
                DrawDebugTab();
            }

            GUILayout.EndScrollView();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("刷新"))
            {
                OverviewPanel.Instance?.Refresh();
                DemonPanel.Instance?.Refresh();
            }
            if (GUILayout.Button("关闭"))
            {
                TogglePanel();
            }
            GUILayout.EndHorizontal();

            GUI.DragWindow(new Rect(0, 0, 10000, 24));
        }

        private void DrawDemonsTab()
        {
            var demonPanel = DemonPanel.Instance;
            if (demonPanel == null)
            {
                GUILayout.Label("(DemonPanel未初始化)");
                return;
            }

            List<DemonData> demons = demonPanel.GetAllDemonData();
            if (demons == null || demons.Count == 0)
            {
                GUILayout.Label("(当前没有魔王数据)");
                return;
            }

            GUILayout.Label("魔王列表:");
            foreach (var d in demons)
            {
                string label = d.IsActive ? $"[活跃] {d.Name}" : d.Name;
                if (GUILayout.Button(label))
                {
                    _selectedDemonId = d.Id;
                }
            }

            GUILayout.Space(8);
            var detailText = demonPanel.GetDemonDetailText(string.IsNullOrEmpty(_selectedDemonId) ? null : _selectedDemonId);
            GUILayout.TextArea(detailText);

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("强制苏醒") && !string.IsNullOrEmpty(_selectedDemonId))
            {
                demonPanel.ForceAwaken(_selectedDemonId);
            }
            if (GUILayout.Button("启用/禁用") && !string.IsNullOrEmpty(_selectedDemonId))
            {
                demonPanel.ToggleEnabled(_selectedDemonId);
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("触发能力"))
            {
                DemonLordManager.Instance?.ActiveDemonLord?.ApplyUniqueAbility();
            }
            if (GUILayout.Button("下一阶段"))
            {
                ModMain.Instance?.ForceNextPhase();
            }
            GUILayout.EndHorizontal();
        }

        private void DrawDebugTab()
        {
            var cycle = CycleManager.Instance?.State;
            string phase = cycle?.CurrentPhase.ToString() ?? "(无)";
            int year = cycle?.WorldAgeYears ?? 0;
            GUILayout.Label($"世界年份(估算): {year}");
            GUILayout.Label($"当前阶段: {phase}");

            var active = DemonLordManager.Instance?.ActiveDemonLord;
            GUILayout.Label($"活跃魔王: {(active?.Name ?? "(无)")}");

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("打印魔王Actor状态"))
            {
                PrintActiveDemonActorStatus();
            }
            if (GUILayout.Button("测试击杀魔王(巨额伤害)"))
            {
                var demon = DemonLordManager.Instance?.ActiveDemonLord;
                if (demon != null)
                {
                    demon.ApplyDamage(99999999f);
                }
                else
                {
                    Logger.Warn(SystemName, "No active demon lord for kill test");
                    NotificationSystem.Instance?.Show("调试", "当前没有活跃魔王", NotificationType.Warning);
                }
            }
            GUILayout.EndHorizontal();

            if (GUILayout.Button("下一阶段"))
            {
                ModMain.Instance?.ForceNextPhase();
            }

            var notifications = NotificationSystem.Instance?.ActiveNotifications;
            if (notifications != null)
            {
                GUILayout.Space(8);
                GUILayout.Label("通知(仅日志版):");
                foreach (var n in notifications)
                {
                    GUILayout.Label($"[{n.Type}] {n.Title}: {n.Message}");
                }
            }
        }

        private void PrintActiveDemonActorStatus()
        {
            var demon = DemonLordManager.Instance?.ActiveDemonLord;
            if (demon == null)
            {
                Logger.Warn(SystemName, "No active demon lord");
                NotificationSystem.Instance?.Show("调试", "当前没有活跃魔王", NotificationType.Warning);
                return;
            }

            bool hasActor = TryGetDemonActor(demon, out var actor) && actor != null;
            bool owns = TryGetOwnsDemonActor(demon, out var ownsFlag) && ownsFlag;
            float actorHealth = -1f;
            bool hasHealth = hasActor && TryGetActorHealth(actor, out actorHealth);

            string statsHp = demon.Stats != null ? $"{demon.Stats.CurrentHealth:0}/{demon.Stats.MaxHealth:0} ({demon.Stats.HealthPercent:0.0}%)" : "(无Stats)";
            string msg = $"id={demon.Id}, state={demon.State}, actor={(hasActor ? "OK" : "NULL")}, owns={(owns ? "Y" : "N")}, actorHp={(hasHealth ? actorHealth.ToString("0") : "?")}, statsHp={statsHp}, dead={(demon.Stats?.IsDead == true ? "Y" : "N")}";

            Logger.Info(SystemName, msg);
            NotificationSystem.Instance?.Show("魔王Actor状态", msg, NotificationType.Info);
        }

        private static bool TryGetDemonActor(BaseDemonLord demon, out Actor actor)
        {
            actor = null;
            if (demon == null) return false;

            try
            {
                var t = demon.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

                var prop = t.GetProperty("DemonActor", flags);
                if (prop != null)
                {
                    actor = prop.GetValue(demon, null) as Actor;
                    if (actor != null) return true;
                }

                var field = t.GetField("DemonActor", flags);
                if (field != null)
                {
                    actor = field.GetValue(demon) as Actor;
                    if (actor != null) return true;
                }

                field = t.GetField("<DemonActor>k__BackingField", flags);
                if (field != null)
                {
                    actor = field.GetValue(demon) as Actor;
                    if (actor != null) return true;
                }
            }
            catch
            {
            }

            return actor != null;
        }

        private static bool TryGetOwnsDemonActor(BaseDemonLord demon, out bool owns)
        {
            owns = false;
            if (demon == null) return false;

            try
            {
                var t = demon.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

                var prop = t.GetProperty("OwnsDemonActor", flags);
                if (prop != null && prop.PropertyType == typeof(bool))
                {
                    owns = (bool)prop.GetValue(demon, null);
                    return true;
                }

                var field = t.GetField("OwnsDemonActor", flags);
                if (field != null && field.FieldType == typeof(bool))
                {
                    owns = (bool)field.GetValue(demon);
                    return true;
                }

                field = t.GetField("<OwnsDemonActor>k__BackingField", flags);
                if (field != null && field.FieldType == typeof(bool))
                {
                    owns = (bool)field.GetValue(demon);
                    return true;
                }
            }
            catch
            {
            }

            return false;
        }

        private static bool TryGetActorHealth(Actor actor, out float health)
        {
            health = -1f;
            if (actor == null) return false;

            try
            {
                var dataField = actor.GetType().GetField("data", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                var data = dataField != null ? dataField.GetValue(actor) : null;
                if (data == null)
                {
                    var dataProp = actor.GetType().GetProperty("data", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    data = dataProp != null ? dataProp.GetValue(actor, null) : null;
                }

                if (data == null) return false;

                var v = GetMemberValue(data, "health");
                if (v == null) return false;

                health = Convert.ToSingle(v);
                return true;
            }
            catch
            {
                health = -1f;
                return false;
            }
        }

        private static object GetMemberValue(object obj, string name)
        {
            if (obj == null || string.IsNullOrEmpty(name)) return null;

            try
            {
                var t = obj.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

                var field = t.GetField(name, flags);
                if (field != null) return field.GetValue(obj);

                var prop = t.GetProperty(name, flags);
                if (prop != null) return prop.GetValue(obj, null);

                var method = t.GetMethod(name, flags, null, Type.EmptyTypes, null);
                if (method != null) return method.Invoke(obj, null);

                return null;
            }
            catch
            {
                return null;
            }
        }

        public void Dispose()
        {
            if (_mainPanel != null)
            {
                UnityEngine.Object.Destroy(_mainPanel);
                _mainPanel = null;
            }
            _gui = null;
            
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "UIManager disposed");
        }
    }
}
