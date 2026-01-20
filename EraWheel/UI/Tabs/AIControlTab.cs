using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Civilization;
using EraWheel.DemonLord;
using EraWheel.Narrative;
using EraWheel.Narrative.AI;
using UnityEngine;

namespace EraWheel.UI.Tabs
{
    public class AIControlTab : UI.ITab
    {
        private ModConfig _config;
        private Vector2 _scrollPosition;
        private string _testResult = "";
        private bool _testInProgress;

        private string _apiUrl = "";
        private string _model = "";
        private string _apiKey = "";
        private int _permissionLevel = 2;
        private bool _aiEnabled;
        private string _selectedProvider = "openai";

        public void Draw(
            ModConfig cfg,
            CycleManager cycle,
            DemonLordRegistry registry,
            CivilizationTracker civTracker,
            AllianceSystem alliance)
        {
            _config = cfg;
            if (_config?.narrative?.ai_engine != null && !_aiEnabled)
            {
                LoadFromConfig();
            }
            DrawContent();
        }

        private void LoadFromConfig()
        {
            if (_config?.narrative?.ai_engine == null) return;

            var aiCfg = _config.narrative.ai_engine;
            _aiEnabled = aiCfg.enabled;
            _selectedProvider = aiCfg.provider ?? "openai";
            _apiUrl = aiCfg.api_url ?? "";
            _model = aiCfg.model ?? "gpt-4";
            _permissionLevel = aiCfg.permission_level;
        }

        private void DrawContent()
        {
            _scrollPosition = UnityEngine.GUILayout.BeginScrollView(_scrollPosition);

            DrawHeader();
            UnityEngine.GUILayout.Space(10);
            DrawProviderSettings();
            UnityEngine.GUILayout.Space(10);
            DrawPermissionSettings();
            UnityEngine.GUILayout.Space(10);
            DrawConnectionTest();
            UnityEngine.GUILayout.Space(10);
            DrawOperationLog();
            UnityEngine.GUILayout.Space(10);
            DrawActions();

            UnityEngine.GUILayout.EndScrollView();
        }

        private void DrawHeader()
        {
            UnityEngine.GUILayout.Label("AI叙事引擎控制", UIStyles.HeaderStyle);

            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUILayout.Label("启用AI:", UnityEngine.GUILayout.Width(80));
            var newEnabled = UnityEngine.GUILayout.Toggle(_aiEnabled, _aiEnabled ? "已启用" : "已禁用");
            if (newEnabled != _aiEnabled)
            {
                _aiEnabled = newEnabled;
                AIStoryEngine.Instance.Enabled = newEnabled;
                NarrativeDispatcher.Instance.AIEnabled = newEnabled;
            }
            UnityEngine.GUILayout.EndHorizontal();

            var statusColor = AIStoryEngine.Instance.IsAvailable ? UnityEngine.Color.green : UnityEngine.Color.yellow;
            var statusText = AIStoryEngine.Instance.IsAvailable ? "可用" : "未配置";
            UnityEngine.GUI.color = statusColor;
            UnityEngine.GUILayout.Label($"状态: {statusText}");
            UnityEngine.GUI.color = UnityEngine.Color.white;
        }

        private void DrawProviderSettings()
        {
            UIStyles.DrawSubHeader("提供者设置");

            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUILayout.Label("提供者:", UnityEngine.GUILayout.Width(80));
            var providers = new[] { "openai", "claude", "ollama" };
            var currentIndex = System.Array.IndexOf(providers, _selectedProvider);
            if (currentIndex < 0) currentIndex = 0;

            for (var i = 0; i < providers.Length; i++)
            {
                if (UnityEngine.GUILayout.Toggle(currentIndex == i, providers[i], "Button", UnityEngine.GUILayout.Width(80)))
                {
                    if (currentIndex != i)
                    {
                        currentIndex = i;
                        _selectedProvider = providers[i];
                    }
                }
            }
            UnityEngine.GUILayout.EndHorizontal();

            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUILayout.Label("API URL:", UnityEngine.GUILayout.Width(80));
            _apiUrl = UnityEngine.GUILayout.TextField(_apiUrl, UnityEngine.GUILayout.MinWidth(200));
            UnityEngine.GUILayout.EndHorizontal();

            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUILayout.Label("模型:", UnityEngine.GUILayout.Width(80));
            _model = UnityEngine.GUILayout.TextField(_model, UnityEngine.GUILayout.MinWidth(200));
            UnityEngine.GUILayout.EndHorizontal();

            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUILayout.Label("API Key:", UnityEngine.GUILayout.Width(80));
            _apiKey = UnityEngine.GUILayout.PasswordField(_apiKey, '*', UnityEngine.GUILayout.MinWidth(200));
            UnityEngine.GUILayout.EndHorizontal();

            if (UnityEngine.GUILayout.Button("应用设置", UnityEngine.GUILayout.Width(100)))
            {
                ApplyProviderSettings();
            }
        }

        private void ApplyProviderSettings()
        {
            AIStoryEngine.Instance.SetProvider(_selectedProvider, _apiUrl, _model, _apiKey);

            if (_config?.narrative?.ai_engine != null)
            {
                _config.narrative.ai_engine.enabled = _aiEnabled;
                _config.narrative.ai_engine.provider = _selectedProvider;
                _config.narrative.ai_engine.api_url = _apiUrl;
                _config.narrative.ai_engine.model = _model;
            }

            Log.Info("[AIControlTab] AI设置已应用");
        }

        private void DrawPermissionSettings()
        {
            UnityEngine.GUILayout.Label("权限等级", UIStyles.SubHeaderStyle);

            var pm = AIStoryEngine.Instance.PermissionManager;
            var levels = new[] { "观察者(1)", "记录者(2)", "叙事者(3)", "编剧(4)", "造物主(5)" };

            UnityEngine.GUILayout.BeginHorizontal();
            for (var i = 0; i < 5; i++)
            {
                var isSelected = _permissionLevel == (i + 1);
                if (UnityEngine.GUILayout.Toggle(isSelected, levels[i], "Button", UnityEngine.GUILayout.Width(80)))
                {
                    if (_permissionLevel != (i + 1))
                    {
                        _permissionLevel = i + 1;
                        pm.SetLevel(_permissionLevel);
                    }
                }
            }
            UnityEngine.GUILayout.EndHorizontal();

            var level = (AIPermissionLevel)_permissionLevel;
            UnityEngine.GUILayout.Label($"说明: {pm.GetLevelDescription(level)}", UIStyles.InfoStyle);
        }

        private void DrawConnectionTest()
        {
            UnityEngine.GUILayout.Label("连接测试", UIStyles.SubHeaderStyle);

            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUI.enabled = !_testInProgress;
            if (UnityEngine.GUILayout.Button("测试连接", UnityEngine.GUILayout.Width(100)))
            {
                TestConnection();
            }
            UnityEngine.GUI.enabled = true;

            if (_testInProgress)
            {
                UnityEngine.GUILayout.Label("测试中...");
            }
            UnityEngine.GUILayout.EndHorizontal();

            if (!string.IsNullOrEmpty(_testResult))
            {
                UnityEngine.GUILayout.Label($"结果: {_testResult}", UIStyles.InfoStyle);
            }
        }

        private void TestConnection()
        {
            _testInProgress = true;
            _testResult = "";

            AIStoryEngine.Instance.TestConnection((success, message) =>
            {
                _testInProgress = false;
                _testResult = success ? $"成功: {message}" : $"失败: {message}";
            });
        }

        private void DrawOperationLog()
        {
            UnityEngine.GUILayout.Label("操作日志", UIStyles.SubHeaderStyle);

            var log = AIStoryEngine.Instance.OperationLog;
            UnityEngine.GUILayout.Label($"总操作: {log.Count} | 成功: {log.SuccessCount} | 失败: {log.FailureCount} | Token消耗: {log.TotalTokensUsed}");

            var recent = log.GetRecent(5);
            foreach (var op in recent)
            {
                var statusIcon = op.Success ? "✓" : "✗";
                UnityEngine.GUILayout.Label($"  {statusIcon} [{op.RequestType}] {op.Content?.Substring(0, System.Math.Min(50, op.Content?.Length ?? 0))}...");
            }

            if (UnityEngine.GUILayout.Button("清空日志", UnityEngine.GUILayout.Width(100)))
            {
                log.Clear();
            }
        }

        private void DrawActions()
        {
            UIStyles.DrawSubHeader("快速操作");

            UnityEngine.GUILayout.BeginHorizontal();
            if (UnityEngine.GUILayout.Button("生成测试叙事", UnityEngine.GUILayout.Width(120)))
            {
                var ctx = WorldContext.Capture();
                AIStoryEngine.Instance.GenerateNarrative(ctx, "test", content =>
                {
                    Log.Info($"[AIControlTab] 生成结果: {content}");
                });
            }

            if (UnityEngine.GUILayout.Button("重置AI引擎", UnityEngine.GUILayout.Width(120)))
            {
                AIStoryEngine.Instance.Reset();
                Log.Info("[AIControlTab] AI引擎已重置");
            }
            UnityEngine.GUILayout.EndHorizontal();
        }

        public void Update(ModConfig cfg)
        {
            _config = cfg;
        }
    }

    public static class UIStyles
    {
        public static object HeaderStyle => null;
        public static object SubHeaderStyle => null;
        public static object InfoStyle => null;

        public static void DrawHeader(string text)
        {
            UnityEngine.GUILayout.Label($"【{text}】");
        }

        public static void DrawSubHeader(string text)
        {
            UnityEngine.GUILayout.Label($"■ {text}");
        }

        public static void DrawInfo(string text)
        {
            UnityEngine.GUILayout.Label(text);
        }
    }
}
