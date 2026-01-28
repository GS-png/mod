using EraWheel.Config;
using EraWheel.Core;
using EraWheel.DemonLord;
using EraWheel.Civilization;
using EraWheel.Data;

namespace EraWheel.UI.Tabs
{
    public class OverviewTab : ITab
    {
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
            UnityEngine.GUILayout.Label("=== 轮回状态 ===", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(5);

            var cycleCount = cycle?.CycleCount ?? 0;
            var phase = cycle?.CurrentPhase ?? EraPhase.Sealed;
            var sealStrength = cycle?.SealStrength ?? 100f;

            UnityEngine.GUILayout.Label($"当前轮回: 第 {cycleCount} 轮回");
            UnityEngine.GUILayout.Label($"纪元阶段: {GetPhaseName(phase)}");
            UnityEngine.GUILayout.Label($"封印强度: {sealStrength:F1}%");

            UnityEngine.GUILayout.Space(10);
            UnityEngine.GUILayout.Label("=== 魔王状态 ===", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(5);

            var activeLord = registry?.ActiveDemonLord;
            if (activeLord != null)
            {
                UnityEngine.GUILayout.Label($"活跃魔王: {activeLord.NameKey}");
                UnityEngine.GUILayout.Label($"魔王状态: {activeLord.State}");
                UnityEngine.GUILayout.Label($"生命值: {activeLord.CurrentHealth:F0} / {activeLord.MaxHealth:F0}");
            }
            else
            {
                UnityEngine.GUILayout.Label("活跃魔王: 无");
            }

            UnityEngine.GUILayout.Space(10);
            UnityEngine.GUILayout.Label("=== 文明状态 ===", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(5);

            var csi = civTracker?.CSI ?? 0f;
            var antiLevel = civTracker?.AntiDemonLevel ?? 0;
            var kills = civTracker?.DemonKillCount ?? 0;

            UnityEngine.GUILayout.Label($"文明强度指数(CSI): {csi:F1}");
            UnityEngine.GUILayout.Label($"抗魔等级: {antiLevel}");
            UnityEngine.GUILayout.Label($"魔物击杀: {kills}");

            UnityEngine.GUILayout.Space(10);
            UnityEngine.GUILayout.Label("=== 联盟状态 ===", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(5);

            var allianceFormed = alliance?.State?.Formed ?? false;
            var councilCount = alliance?.State?.CouncilCount ?? 0;

            UnityEngine.GUILayout.Label($"反魔联盟: {(allianceFormed ? "已组建" : "未组建")}");
            if (allianceFormed)
            {
                UnityEngine.GUILayout.Label($"议会次数: {councilCount}");
                UnityEngine.GUILayout.Label($"封印进度: {alliance?.State?.SealProgress ?? 0f:F1}%");
            }
        }

        private static string GetPhaseName(EraPhase phase)
        {
            switch (phase)
            {
                case EraPhase.Sealed: return "封印状态";
                case EraPhase.Omen: return "预兆阶段";
                case EraPhase.Awakening: return "苏醒准备";
                case EraPhase.Invasion: return "正式降临";
                case EraPhase.Peak: return "全盛期";
                case EraPhase.Weakening: return "衰弱期";
                case EraPhase.Resealed: return "被再封印";
                default: return phase.ToString();
            }
        }
    }
}
