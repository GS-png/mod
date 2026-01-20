using System;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.DemonLord;
using EraWheel.Civilization;
using EraWheel.UI.Tabs;

namespace EraWheel.UI
{
    public class ControlPanel
    {
        private static ControlPanel _instance;
        public static ControlPanel Instance => _instance ?? (_instance = new ControlPanel());

        private bool _isOpen;
        private int _currentTab;

        private readonly string[] _tabNames = {
            "总览", "魔王管理", "文明状态", "参数设置", "调试工具"
        };

        private readonly ITab[] _tabs;

        public bool IsOpen => _isOpen;
        public int CurrentTab => _currentTab;

        private ControlPanel()
        {
            _tabs = new ITab[]
            {
                new OverviewTab(),
                new DemonManageTab(),
                new CivStatusTab(),
                new SettingsTab(),
                new DebugTab()
            };
        }

        public void Open()
        {
            _isOpen = true;
            Log.Info("[EraWheel] Control panel opened");
        }

        public void Close()
        {
            _isOpen = false;
            Log.Info("[EraWheel] Control panel closed");
        }

        public void Toggle()
        {
            if (_isOpen) Close();
            else Open();
        }

        public void SetTab(int index)
        {
            if (index < 0) index = 0;
            if (index >= _tabNames.Length) index = _tabNames.Length - 1;
            _currentTab = index;
        }

        public void OnGUI()
        {
            if (!_isOpen) return;

            try
            {
                DrawWindow();
            }
            catch (Exception ex)
            {
                Log.Error("[EraWheel] ControlPanel.OnGUI error: " + ex.Message);
            }
        }

        private void DrawWindow()
        {
            var windowWidth = 600f;
            var windowHeight = 500f;
            var screenWidth = UnityCompat.GetScreenWidth();
            var screenHeight = UnityCompat.GetScreenHeight();

            var x = (screenWidth - windowWidth) / 2f;
            var y = (screenHeight - windowHeight) / 2f;

            var windowRect = new UnityEngine.Rect(x, y, windowWidth, windowHeight);

            UnityEngine.GUI.Box(windowRect, "");

            UnityEngine.GUILayout.BeginArea(windowRect);
            DrawContent();
            UnityEngine.GUILayout.EndArea();
        }

        private void DrawContent()
        {
            UnityEngine.GUILayout.BeginVertical();

            DrawHeader();
            DrawTabBar();
            DrawTabContent();
            DrawFooter();

            UnityEngine.GUILayout.EndVertical();
        }

        private void DrawHeader()
        {
            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUILayout.Label("纪元之轮 控制面板", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.FlexibleSpace();

            if (UnityEngine.GUILayout.Button("X", UnityEngine.GUILayout.Width(30)))
            {
                Close();
            }

            UnityEngine.GUILayout.EndHorizontal();

            UnityEngine.GUILayout.Space(5);
        }

        private void DrawTabBar()
        {
            UnityEngine.GUILayout.BeginHorizontal();

            for (var i = 0; i < _tabNames.Length; i++)
            {
                var style = _currentTab == i ? "Button" : "Button";
                if (UnityEngine.GUILayout.Button(_tabNames[i]))
                {
                    _currentTab = i;
                }
            }

            UnityEngine.GUILayout.EndHorizontal();

            UnityEngine.GUILayout.Space(10);
        }

        private void DrawTabContent()
        {
            UnityEngine.GUILayout.BeginVertical("box", UnityEngine.GUILayout.ExpandHeight(true));

            if (_currentTab >= 0 && _currentTab < _tabs.Length)
            {
                var main = Main.Instance;
                _tabs[_currentTab].Draw(
                    main?.ConfigManager?.Config,
                    main?.CycleManager,
                    main?.DemonLordRegistry,
                    main?.CivilizationTracker,
                    main?.AllianceSystem
                );
            }

            UnityEngine.GUILayout.EndVertical();
        }

        private void DrawFooter()
        {
            UnityEngine.GUILayout.Space(5);
            UnityEngine.GUILayout.BeginHorizontal();

            var main = Main.Instance;
            var cycle = main?.CycleManager;
            var phase = cycle?.CurrentPhase ?? EraPhase.Sealed;
            var cycleCount = cycle?.CycleCount ?? 0;

            UnityEngine.GUILayout.Label($"轮回: {cycleCount} | 阶段: {phase}");

            UnityEngine.GUILayout.FlexibleSpace();
            UnityEngine.GUILayout.Label("v1.0.0");

            UnityEngine.GUILayout.EndHorizontal();
        }
    }

    public interface ITab
    {
        void Draw(
            ModConfig cfg,
            CycleManager cycle,
            DemonLord.DemonLordRegistry registry,
            Civilization.CivilizationTracker civTracker,
            Civilization.AllianceSystem alliance
        );
    }
}
