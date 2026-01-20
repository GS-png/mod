using EraWheel.Config;
using EraWheel.Core;
using EraWheel.DemonLord;
using EraWheel.Civilization;
using EraWheel.Data;

namespace EraWheel.UI.Tabs
{
    public class CivStatusTab : ITab
    {
        private UnityEngine.Vector2 _scrollPos;

        public void Draw(
            ModConfig cfg,
            CycleManager cycle,
            DemonLordRegistry registry,
            CivilizationTracker civTracker,
            AllianceSystem alliance)
        {
            _scrollPos = UnityEngine.GUILayout.BeginScrollView(_scrollPos);

            DrawCSISection(civTracker, cfg);
            UnityEngine.GUILayout.Space(10);

            DrawAntiDemonSection(civTracker, cfg);
            UnityEngine.GUILayout.Space(10);

            DrawAllianceSection(alliance, cfg);

            UnityEngine.GUILayout.EndScrollView();
        }

        private void DrawCSISection(CivilizationTracker civTracker, ModConfig cfg)
        {
            UnityEngine.GUILayout.Label("=== 文明强度指数 (CSI) ===", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(5);

            var csi = civTracker?.CSI ?? 0f;

            UnityEngine.GUILayout.BeginVertical("box");

            UnityEngine.GUILayout.Label($"综合评分: {csi:F1} / 100");

            DrawProgressBar(csi / 100f);

            UnityEngine.GUILayout.Space(5);
            UnityEngine.GUILayout.Label("权重配置:");

            if (cfg?.civilization?.csi != null)
            {
                var csiCfg = cfg.civilization.csi;
                UnityEngine.GUILayout.Label($"  人口权重: {csiCfg.population_weight:P0}");
                UnityEngine.GUILayout.Label($"  城市权重: {csiCfg.cities_weight:P0}");
                UnityEngine.GUILayout.Label($"  科技权重: {csiCfg.tech_weight:P0}");
                UnityEngine.GUILayout.Label($"  抗魔权重: {csiCfg.anti_demon_weight:P0}");
                UnityEngine.GUILayout.Label($"  英雄权重: {csiCfg.heroes_weight:P0}");
            }

            UnityEngine.GUILayout.EndVertical();
        }

        private void DrawAntiDemonSection(CivilizationTracker civTracker, ModConfig cfg)
        {
            UnityEngine.GUILayout.Label("=== 抗魔等级 ===", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(5);

            var level = civTracker?.AntiDemonLevel ?? 0;
            var kills = civTracker?.DemonKillCount ?? 0;

            UnityEngine.GUILayout.BeginVertical("box");

            UnityEngine.GUILayout.Label($"当前等级: {level} / 10");
            UnityEngine.GUILayout.Label($"魔物击杀: {kills}");

            if (cfg?.civilization?.anti_demon != null)
            {
                var anti = cfg.civilization.anti_demon;
                var nextThreshold = level < 10 && anti.kill_thresholds != null && level < anti.kill_thresholds.Length
                    ? anti.kill_thresholds[level]
                    : -1;

                if (nextThreshold > 0)
                {
                    UnityEngine.GUILayout.Label($"下一等级需击杀: {nextThreshold}");
                    var progress = (float)kills / nextThreshold;
                    DrawProgressBar(progress > 1f ? 1f : progress);
                }

                UnityEngine.GUILayout.Space(5);
                UnityEngine.GUILayout.Label($"伤害减免/等级: {anti.damage_reduction_per_level:P0}");
                UnityEngine.GUILayout.Label($"伤害加成/等级: {anti.damage_bonus_per_level:P0}");

                var totalReduction = level * anti.damage_reduction_per_level;
                var totalBonus = level * anti.damage_bonus_per_level;
                UnityEngine.GUILayout.Label($"当前总减免: {totalReduction:P0}");
                UnityEngine.GUILayout.Label($"当前总加成: {totalBonus:P0}");
            }

            UnityEngine.GUILayout.EndVertical();
        }

        private void DrawAllianceSection(AllianceSystem alliance, ModConfig cfg)
        {
            UnityEngine.GUILayout.Label("=== 反魔联盟 ===", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(5);

            UnityEngine.GUILayout.BeginVertical("box");

            var state = alliance?.State;
            var formed = state?.Formed ?? false;

            UnityEngine.GUILayout.Label($"联盟状态: {(formed ? "已组建" : "未组建")}");

            if (formed)
            {
                UnityEngine.GUILayout.Label($"组建时间: 年 {state.FormWorldAge}");
                UnityEngine.GUILayout.Label($"议会次数: {state.CouncilCount}");
                UnityEngine.GUILayout.Label($"封印进度: {state.SealProgress:F1}%");

                DrawProgressBar(state.SealProgress / 100f);
            }
            else
            {
                if (cfg?.civilization?.alliance != null)
                {
                    var threshold = cfg.civilization.alliance.auto_form_threshold;
                    UnityEngine.GUILayout.Label($"组建条件: 城市损毁 ≥ {threshold:P0}");
                }
            }

            UnityEngine.GUILayout.EndVertical();
        }

        private void DrawProgressBar(float progress)
        {
            if (progress < 0f) progress = 0f;
            if (progress > 1f) progress = 1f;

            var barWidth = 200f;
            var barHeight = 20f;

            var bgRect = UnityEngine.GUILayoutUtility.GetRect(barWidth, barHeight);

            UnityEngine.GUI.Box(bgRect, "");

            var fillRect = new UnityEngine.Rect(bgRect.x, bgRect.y, bgRect.width * progress, bgRect.height);
            var color = UnityEngine.GUI.color;
            UnityEngine.GUI.color = new UnityEngine.Color(0.2f, 0.8f, 0.2f);
            UnityEngine.GUI.DrawTexture(fillRect, UnityEngine.Texture2D.whiteTexture);
            UnityEngine.GUI.color = color;
        }
    }
}
