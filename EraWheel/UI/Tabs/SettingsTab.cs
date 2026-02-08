using System;
using System.Globalization;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.DemonLord;
using EraWheel.Civilization;

namespace EraWheel.UI.Tabs
{
    public class SettingsTab : ITab
    {
        private UnityEngine.Vector2 _scrollPos;
        private bool _showCycleSettings = true;
        private bool _showDemonSettings = true;
        private bool _showUnitStats = true;
        private bool _showCivSettings = true;
        private bool _showExpansionSettings = true;
        private bool _showImportExport = true;

        private string _importPath;
        private string _exportPath;
        private string _ioStatus;

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
            if (cfg == null)
            {
                UnityEngine.GUILayout.Label("配置未加载");
                return;
            }

            EnsurePaths();

            _scrollPos = UnityEngine.GUILayout.BeginScrollView(_scrollPos);

            UnityEngine.GUILayout.Label("修改参数后点击“应用并保存”生效", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(5);

            DrawCycleSettings(cfg);
            UnityEngine.GUILayout.Space(5);

            DrawDemonSettings(cfg);
            UnityEngine.GUILayout.Space(5);

            DrawUnitStats(cfg);
            UnityEngine.GUILayout.Space(5);

            DrawCivilizationSettings(cfg);
            UnityEngine.GUILayout.Space(10);

            DrawExpansionSettings(cfg);
            UnityEngine.GUILayout.Space(10);

            DrawConfigActions(cfg, registry, civTracker);
            UnityEngine.GUILayout.Space(10);

            DrawImportExport(cfg);

            UnityEngine.GUILayout.EndScrollView();
        }

        private void EnsurePaths()
        {
            var configPath = Main.Instance?.ConfigManager?.UserConfigPath;
            if (!string.IsNullOrEmpty(configPath))
            {
                if (string.IsNullOrEmpty(_importPath)) _importPath = configPath;
                if (string.IsNullOrEmpty(_exportPath)) _exportPath = configPath;
            }
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
                    cfg.cycle.trigger.first_cycle_mode = DrawOptionToolbar(
                        "首轮回触发模式",
                        cfg.cycle.trigger.first_cycle_mode,
                        new[] { "prosperity", "fixed_age", "manual" });

                    cfg.cycle.trigger.prosperity_mode = DrawOptionToolbar(
                        "繁荣判定模式",
                        cfg.cycle.trigger.prosperity_mode,
                        new[] { "any", "all" },
                        new[] { "任一满足(OR)", "全部满足(AND)" });

                    cfg.cycle.trigger.fixed_age_years = DrawIntField("固定年数", cfg.cycle.trigger.fixed_age_years);

                    if (cfg.cycle.trigger.prosperity_thresholds != null)
                    {
                        cfg.cycle.trigger.prosperity_thresholds.population = DrawIntField(
                            "繁荣阈值-人口", cfg.cycle.trigger.prosperity_thresholds.population);
                        cfg.cycle.trigger.prosperity_thresholds.cities = DrawIntField(
                            "繁荣阈值-城市", cfg.cycle.trigger.prosperity_thresholds.cities);
                        cfg.cycle.trigger.prosperity_thresholds.heroes = DrawIntField(
                            "繁荣阈值-英雄", cfg.cycle.trigger.prosperity_thresholds.heroes);
                        cfg.cycle.trigger.prosperity_thresholds.tech_level = DrawIntField(
                            "繁荣阈值-科技", cfg.cycle.trigger.prosperity_thresholds.tech_level);
                    }
                }

                if (cfg.cycle.seal != null)
                {
                    cfg.cycle.seal.initial_strength = DrawFloatField("初始封印强度", cfg.cycle.seal.initial_strength);
                    cfg.cycle.seal.decay_rate_per_year = DrawFloatField("封印衰减率/年", cfg.cycle.seal.decay_rate_per_year);

                    if (cfg.cycle.seal.victory_conditions != null)
                    {
                        UnityEngine.GUILayout.Label("封印胜利条件:");
                        cfg.cycle.seal.victory_conditions.execution = DrawToggleField("击杀封印", cfg.cycle.seal.victory_conditions.execution);
                        cfg.cycle.seal.victory_conditions.ritual = DrawToggleField("仪式封印", cfg.cycle.seal.victory_conditions.ritual);
                        cfg.cycle.seal.victory_conditions.time_window = DrawToggleField("时间窗口", cfg.cycle.seal.victory_conditions.time_window);
                        cfg.cycle.seal.victory_conditions.alliance = DrawToggleField("联盟封印", cfg.cycle.seal.victory_conditions.alliance);
                    }
                }

                if (cfg.cycle.phases != null)
                {
                    if (cfg.cycle.phases.omen_duration != null)
                    {
                        cfg.cycle.phases.omen_duration.min = DrawIntField("预兆最短年", cfg.cycle.phases.omen_duration.min);
                        cfg.cycle.phases.omen_duration.max = DrawIntField("预兆最长年", cfg.cycle.phases.omen_duration.max);
                    }

                    if (cfg.cycle.phases.awakening_duration != null)
                    {
                        cfg.cycle.phases.awakening_duration.min = DrawIntField("苏醒最短年", cfg.cycle.phases.awakening_duration.min);
                        cfg.cycle.phases.awakening_duration.max = DrawIntField("苏醒最长年", cfg.cycle.phases.awakening_duration.max);
                    }

                    cfg.cycle.phases.invasion_timeout = DrawIntField("入侵超时年", cfg.cycle.phases.invasion_timeout);
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
                cfg.demon_lord.awakening_mode = DrawOptionToolbar(
                    "苏醒模式",
                    cfg.demon_lord.awakening_mode,
                    new[] { "random", "specified" });

                cfg.demon_lord.random_count = DrawIntField("随机苏醒数量", cfg.demon_lord.random_count);
                cfg.demon_lord.multi_lord_mode = DrawOptionToolbar(
                    "多魔王互动模式",
                    cfg.demon_lord.multi_lord_mode,
                    new[] { "independent", "alliance", "civil_war", "auto_judge" },
                    new[] { "各自征战", "魔王联盟", "魔王内战", "随机判断" });

                if (cfg.demon_lord.growth != null)
                {
                    cfg.demon_lord.growth.cycle_multiplier = DrawFloatField("轮回成长倍率", cfg.demon_lord.growth.cycle_multiplier);
                    cfg.demon_lord.growth.strength_min = DrawFloatField("强度下限", cfg.demon_lord.growth.strength_min);
                    cfg.demon_lord.growth.strength_max = DrawFloatField("强度上限", cfg.demon_lord.growth.strength_max);
                }

                if (cfg.demon_lord.generals != null)
                {
                    cfg.demon_lord.generals.initial_count = DrawIntField("初始将领数", cfg.demon_lord.generals.initial_count);
                    cfg.demon_lord.generals.per_cycle_increase = DrawIntField("每轮回增加", cfg.demon_lord.generals.per_cycle_increase);
                    cfg.demon_lord.generals.max_count = DrawIntField("最大将领数", cfg.demon_lord.generals.max_count);
                }

                if (cfg.demon_lord.legion != null)
                {
                    cfg.demon_lord.legion.wave_interval_years = DrawIntField("军团波次间隔", cfg.demon_lord.legion.wave_interval_years);
                    cfg.demon_lord.legion.max_alive_units = DrawIntField("最大存活单位", cfg.demon_lord.legion.max_alive_units);
                }
            }

            UnityEngine.GUILayout.EndVertical();
        }

        private void DrawUnitStats(ModConfig cfg)
        {
            _showUnitStats = DrawFoldout("单位数值倍率", _showUnitStats);

            if (!_showUnitStats) return;

            UnityEngine.GUILayout.BeginVertical("box");
            UnityEngine.GUILayout.Label("倍率=基础属性×倍率（改完点“应用并保存”生效）");

            var stats = cfg != null && cfg.demon_lord != null ? cfg.demon_lord.stats : null;
            if (stats == null)
            {
                UnityEngine.GUILayout.Label("数值配置未初始化");
                UnityEngine.GUILayout.EndVertical();
                return;
            }

            UnityEngine.GUILayout.Space(5);
            UnityEngine.GUILayout.Label("魔王倍率");
            DrawUnitStatBox("void_lord", stats.lords != null ? stats.lords.void_lord : null);
            DrawUnitStatBox("plague_lord", stats.lords != null ? stats.lords.plague_lord : null);
            DrawUnitStatBox("machine_lord", stats.lords != null ? stats.lords.machine_lord : null);
            DrawUnitStatBox("time_lord", stats.lords != null ? stats.lords.time_lord : null);
            DrawUnitStatBox("flame_lord", stats.lords != null ? stats.lords.flame_lord : null);
            DrawUnitStatBox("abyss_lord", stats.lords != null ? stats.lords.abyss_lord : null);
            DrawUnitStatBox("death_lord", stats.lords != null ? stats.lords.death_lord : null);
            DrawUnitStatBox("soul_lord", stats.lords != null ? stats.lords.soul_lord : null);
            DrawUnitStatBox("nature_lord", stats.lords != null ? stats.lords.nature_lord : null);
            DrawUnitStatBox("judgment_lord", stats.lords != null ? stats.lords.judgment_lord : null);

            UnityEngine.GUILayout.Space(5);
            UnityEngine.GUILayout.Label("将领倍率");
            DrawUnitStatBox("vanguard", stats.general_roles != null ? stats.general_roles.vanguard : null);
            DrawUnitStatBox("tank", stats.general_roles != null ? stats.general_roles.tank : null);
            DrawUnitStatBox("dps", stats.general_roles != null ? stats.general_roles.dps : null);
            DrawUnitStatBox("support", stats.general_roles != null ? stats.general_roles.support : null);
            DrawUnitStatBox("elite", stats.general_roles != null ? stats.general_roles.elite : null);

            UnityEngine.GUILayout.Space(5);
            UnityEngine.GUILayout.Label("军团倍率");
            DrawUnitStatBox("legion_vanguard", stats.legion_units != null ? stats.legion_units.legion_vanguard : null);
            DrawUnitStatBox("legion_main", stats.legion_units != null ? stats.legion_units.legion_main : null);
            DrawUnitStatBox("legion_elite", stats.legion_units != null ? stats.legion_units.legion_elite : null);
            DrawUnitStatBox("legion_ultimate", stats.legion_units != null ? stats.legion_units.legion_ultimate : null);

            UnityEngine.GUILayout.EndVertical();
        }

        private static void DrawUnitStatBox(string title, UnitStatMultiplierConfig stats)
        {
            if (stats == null) return;

            UnityEngine.GUILayout.BeginVertical("box");
            UnityEngine.GUILayout.Label(title);
            stats.health = DrawFloatField("生命倍率", stats.health);
            stats.damage = DrawFloatField("伤害倍率", stats.damage);
            stats.armor = DrawFloatField("护甲倍率", stats.armor);
            stats.speed = DrawFloatField("速度倍率", stats.speed);
            UnityEngine.GUILayout.EndVertical();
        }

        private void DrawExpansionSettings(ModConfig cfg)
        {
            _showExpansionSettings = DrawFoldout("扩展模块", _showExpansionSettings);

            if (!_showExpansionSettings) return;

            UnityEngine.GUILayout.BeginVertical("box");

            if (cfg.expansion != null)
            {
                if (cfg.expansion.ragnarok != null)
                {
                    UnityEngine.GUILayout.Label("诸神黄昏");
                    cfg.expansion.ragnarok.enabled = DrawToggleField("启用诸神黄昏", cfg.expansion.ragnarok.enabled);
                    cfg.expansion.ragnarok.required_civilizations = DrawIntField(
                        "触发文明数量", cfg.expansion.ragnarok.required_civilizations);
                    cfg.expansion.ragnarok.duration_years = DrawIntField(
                        "持续年数", cfg.expansion.ragnarok.duration_years);
                }

                UnityEngine.GUILayout.Space(5);

                if (cfg.expansion.multi_lord != null)
                {
                    UnityEngine.GUILayout.Label("多魔王苏醒");
                    cfg.expansion.multi_lord.enabled = DrawToggleField("启用多魔王", cfg.expansion.multi_lord.enabled);
                    cfg.expansion.multi_lord.min_awaken_count = DrawIntField(
                        "最少苏醒数", cfg.expansion.multi_lord.min_awaken_count);
                    cfg.expansion.multi_lord.max_awaken_count = DrawIntField(
                        "最多苏醒数", cfg.expansion.multi_lord.max_awaken_count);
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
                    cfg.civilization.alliance.auto_form_threshold = DrawFloatField(
                        "联盟自动组建阈值", cfg.civilization.alliance.auto_form_threshold);
                    cfg.civilization.alliance.council_interval_years = DrawIntField(
                        "议会间隔(年)", cfg.civilization.alliance.council_interval_years);
                }

                if (cfg.civilization.hero != null)
                {
                    cfg.civilization.hero.destined_chance = DrawFloatField(
                        "命定英雄概率", cfg.civilization.hero.destined_chance);
                    cfg.civilization.hero.inheritance_chance = DrawFloatField(
                        "继承概率", cfg.civilization.hero.inheritance_chance);
                }
            }

            UnityEngine.GUILayout.EndVertical();
        }

        private void DrawConfigActions(ModConfig cfg, DemonLordRegistry registry, CivilizationTracker civTracker)
        {
            UnityEngine.GUILayout.Label("=== 配置操作 ===", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(5);

            UnityEngine.GUILayout.BeginHorizontal();

            if (UnityEngine.GUILayout.Button("应用并保存"))
            {
                ConfigSchema.ValidateAndClamp(cfg);
                Main.Instance?.ConfigManager?.SaveUserConfig();
                ApplyRuntimeStats(cfg, registry, civTracker);
                Log.Info("[EraWheel] Config saved");
                _ioStatus = "已保存当前配置";
            }

            if (UnityEngine.GUILayout.Button("重新加载配置"))
            {
                Main.Instance?.ConfigManager?.Load();
                var newCfg = Main.Instance?.ConfigManager?.Config;
                ApplyRuntimeStats(newCfg, registry, civTracker);
                Log.Info("[EraWheel] Config reloaded");
                _ioStatus = "已重新加载配置";
            }

            if (UnityEngine.GUILayout.Button("重置为默认"))
            {
                Main.Instance?.ConfigManager?.ResetToDefault();
                var newCfg = Main.Instance?.ConfigManager?.Config;
                ApplyRuntimeStats(newCfg, registry, civTracker);
                Log.Info("[EraWheel] Config reset to default");
                _ioStatus = "已重置为默认";
            }

            UnityEngine.GUILayout.EndHorizontal();

            if (!string.IsNullOrEmpty(_ioStatus))
            {
                UnityEngine.GUILayout.Space(5);
                UnityEngine.GUILayout.Label(_ioStatus);
            }
        }

        private static void ApplyRuntimeStats(ModConfig cfg, DemonLordRegistry registry, CivilizationTracker civTracker)
        {
            if (cfg == null) return;

            if (ActorAssetRegistry.ApplyConfigStats(cfg))
            {
                registry?.ApplyStatOverrides(cfg);
                CombatModifiers.ResetDemonBaseStats();

                if (civTracker != null)
                {
                    CombatModifiers.ApplyToDemonAssets(cfg, civTracker.AntiDemonLevel);
                }
            }
        }

        private void DrawImportExport(ModConfig cfg)
        {
            _showImportExport = DrawFoldout("导入/导出", _showImportExport);
            if (!_showImportExport) return;

            UnityEngine.GUILayout.BeginVertical("box");

            _exportPath = DrawPathField("导出路径", _exportPath);
            if (UnityEngine.GUILayout.Button("导出配置"))
            {
                var ok = Main.Instance?.ConfigManager?.ExportUserConfig(_exportPath) == true;
                _ioStatus = ok ? "已导出配置" : "导出失败";
            }

            UnityEngine.GUILayout.Space(5);

            _importPath = DrawPathField("导入路径", _importPath);
            if (UnityEngine.GUILayout.Button("导入配置"))
            {
                var ok = Main.Instance?.ConfigManager?.ImportUserConfig(_importPath) == true;
                _ioStatus = ok ? "已导入配置" : "导入失败";
            }

            UnityEngine.GUILayout.EndVertical();
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

        private static string DrawOptionToolbar(string label, string current, string[] options)
        {
            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUILayout.Label(label, UnityEngine.GUILayout.Width(150));

            var index = Array.IndexOf(options, current);
            if (index < 0) index = 0;
            var newIndex = UnityEngine.GUILayout.Toolbar(index, options);

            UnityEngine.GUILayout.EndHorizontal();
            return options[newIndex];
        }

        private static string DrawOptionToolbar(string label, string current, string[] values, string[] labels)
        {
            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUILayout.Label(label, UnityEngine.GUILayout.Width(150));

            var index = Array.IndexOf(values, current);
            if (index < 0) index = 0;
            var newIndex = UnityEngine.GUILayout.Toolbar(index, labels);

            UnityEngine.GUILayout.EndHorizontal();
            return values[newIndex];
        }

        private static int DrawIntField(string label, int value)
        {
            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUILayout.Label(label, UnityEngine.GUILayout.Width(150));
            var text = UnityEngine.GUILayout.TextField(value.ToString(CultureInfo.InvariantCulture));
            if (int.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
            {
                value = parsed;
            }
            UnityEngine.GUILayout.EndHorizontal();
            return value;
        }

        private static float DrawFloatField(string label, float value)
        {
            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUILayout.Label(label, UnityEngine.GUILayout.Width(150));
            var text = UnityEngine.GUILayout.TextField(value.ToString("0.###", CultureInfo.InvariantCulture));
            if (float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out var parsed))
            {
                value = parsed;
            }
            UnityEngine.GUILayout.EndHorizontal();
            return value;
        }

        private static bool DrawToggleField(string label, bool value)
        {
            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUILayout.Label(label, UnityEngine.GUILayout.Width(150));
            value = UnityEngine.GUILayout.Toggle(value, "");
            UnityEngine.GUILayout.EndHorizontal();
            return value;
        }

        private static string DrawPathField(string label, string value)
        {
            UnityEngine.GUILayout.BeginHorizontal();
            UnityEngine.GUILayout.Label(label, UnityEngine.GUILayout.Width(150));
            value = UnityEngine.GUILayout.TextField(value ?? "");
            UnityEngine.GUILayout.EndHorizontal();
            return value;
        }
    }
}
