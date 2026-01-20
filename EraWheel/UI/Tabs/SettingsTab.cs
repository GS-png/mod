using EraWheel.Config;
using EraWheel.Core;
using EraWheel.DemonLord;
using EraWheel.Civilization;
using EraWheel.Data;

namespace EraWheel.UI.Tabs
{
    public class SettingsTab : ITab
    {
        private UnityEngine.Vector2 _scrollPos;
        private bool _showCycleSettings = true;
        private bool _showDemonSettings = true;
        private bool _showCivSettings = true;

        public void Draw(
            ModConfig cfg,
            CycleManager cycle,
            DemonLordRegistry registry,
            CivilizationTracker civTracker,
            AllianceSystem alliance)
        {
            if (cfg == null)
            {
                UnityEngine.GUILayout.Label("配置未加载");
                return;
            }

            _scrollPos = UnityEngine.GUILayout.BeginScrollView(_scrollPos);

            DrawCycleSettings(cfg);
            UnityEngine.GUILayout.Space(5);

            DrawDemonSettings(cfg);
            UnityEngine.GUILayout.Space(5);

            DrawCivilizationSettings(cfg);
            UnityEngine.GUILayout.Space(10);

            DrawConfigActions(cfg);

            UnityEngine.GUILayout.EndScrollView();
        }

        private void DrawCycleSettings(ModConfig cfg)
        {
            _showCycleSettings = DrawFoldout("轮回设置", _showCycleSettings);

            if (!_showCycleSettings) return;

            UnityEngine.GUILayout.BeginVertical("box");

            if (cfg.cycle != null)
            {
                if (cfg.cycle.trigger != null)
                {
                    UnityEngine.GUILayout.Label($"首轮回触发模式: {cfg.cycle.trigger.first_cycle_mode}");
                    UnityEngine.GUILayout.Label($"固定年数: {cfg.cycle.trigger.fixed_age_years}");
                }

                if (cfg.cycle.seal != null)
                {
                    UnityEngine.GUILayout.Label($"初始封印强度: {cfg.cycle.seal.initial_strength}");
                    UnityEngine.GUILayout.Label($"封印衰减率/年: {cfg.cycle.seal.decay_rate_per_year}");
                }

                if (cfg.cycle.phases != null)
                {
                    UnityEngine.GUILayout.Label($"入侵超时: {cfg.cycle.phases.invasion_timeout} 年");
                }
            }

            UnityEngine.GUILayout.EndVertical();
        }

        private void DrawDemonSettings(ModConfig cfg)
        {
            _showDemonSettings = DrawFoldout("魔王设置", _showDemonSettings);

            if (!_showDemonSettings) return;

            UnityEngine.GUILayout.BeginVertical("box");

            if (cfg.demon_lord != null)
            {
                UnityEngine.GUILayout.Label($"苏醒模式: {cfg.demon_lord.awakening_mode}");

                if (cfg.demon_lord.growth != null)
                {
                    UnityEngine.GUILayout.Label($"轮回成长倍率: {cfg.demon_lord.growth.cycle_multiplier:P0}");
                    UnityEngine.GUILayout.Label($"强度范围: {cfg.demon_lord.growth.strength_min} - {cfg.demon_lord.growth.strength_max}");
                }

                if (cfg.demon_lord.generals != null)
                {
                    UnityEngine.GUILayout.Label($"初始将领数: {cfg.demon_lord.generals.initial_count}");
                    UnityEngine.GUILayout.Label($"每轮回增加: {cfg.demon_lord.generals.per_cycle_increase}");
                    UnityEngine.GUILayout.Label($"最大将领数: {cfg.demon_lord.generals.max_count}");
                }

                if (cfg.demon_lord.legion != null)
                {
                    UnityEngine.GUILayout.Label($"军团波次间隔: {cfg.demon_lord.legion.wave_interval_years} 年");
                    UnityEngine.GUILayout.Label($"最大存活单位: {cfg.demon_lord.legion.max_alive_units}");
                }
            }

            UnityEngine.GUILayout.EndVertical();
        }

        private void DrawCivilizationSettings(ModConfig cfg)
        {
            _showCivSettings = DrawFoldout("文明设置", _showCivSettings);

            if (!_showCivSettings) return;

            UnityEngine.GUILayout.BeginVertical("box");

            if (cfg.civilization != null)
            {
                if (cfg.civilization.alliance != null)
                {
                    UnityEngine.GUILayout.Label($"联盟自动组建阈值: {cfg.civilization.alliance.auto_form_threshold:P0}");
                    UnityEngine.GUILayout.Label($"议会间隔: {cfg.civilization.alliance.council_interval_years} 年");
                }

                if (cfg.civilization.hero != null)
                {
                    UnityEngine.GUILayout.Label($"命定英雄概率: {cfg.civilization.hero.destined_chance:P0}");
                    UnityEngine.GUILayout.Label($"继承概率: {cfg.civilization.hero.inheritance_chance:P0}");
                }
            }

            UnityEngine.GUILayout.EndVertical();
        }

        private void DrawConfigActions(ModConfig cfg)
        {
            UnityEngine.GUILayout.Label("=== 配置操作 ===", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(5);

            UnityEngine.GUILayout.BeginHorizontal();

            if (UnityEngine.GUILayout.Button("重新加载配置"))
            {
                Main.Instance?.ConfigManager?.Load();
                Log.Info("[EraWheel] Config reloaded");
            }

            if (UnityEngine.GUILayout.Button("保存当前配置"))
            {
                Main.Instance?.ConfigManager?.SaveUserConfig();
                Log.Info("[EraWheel] Config saved");
            }

            if (UnityEngine.GUILayout.Button("重置为默认"))
            {
                Main.Instance?.ConfigManager?.ResetToDefault();
                Log.Info("[EraWheel] Config reset to default");
            }

            UnityEngine.GUILayout.EndHorizontal();
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
