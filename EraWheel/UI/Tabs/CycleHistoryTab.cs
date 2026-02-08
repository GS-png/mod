using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Civilization;
using EraWheel.DemonLord;

namespace EraWheel.UI.Tabs
{
    public class CycleHistoryTab : ITab
    {
        private UnityEngine.Vector2 _scrollPos;

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
            _scrollPos = UnityEngine.GUILayout.BeginScrollView(_scrollPos);

            UnityEngine.GUILayout.Label("轮回历史（骨架）", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(5);

            var entries = cycle?.History?.Entries;
            if (entries == null || entries.Count == 0)
            {
                UnityEngine.GUILayout.Label("暂无轮回记录");
                UnityEngine.GUILayout.EndScrollView();
                return;
            }

            for (var i = entries.Count - 1; i >= 0; i--)
            {
                var entry = entries[i];
                UnityEngine.GUILayout.BeginVertical("box");

                UnityEngine.GUILayout.Label($"第 {entry.CycleNumber} 轮回");
                UnityEngine.GUILayout.Label($"结束阶段: {entry.EndPhase}");
                UnityEngine.GUILayout.Label($"世界时间: {entry.WorldTime}");

                if (entry.KeyEvents != null && entry.KeyEvents.Length > 0)
                {
                    UnityEngine.GUILayout.Label("关键事件:");
                    for (var k = 0; k < entry.KeyEvents.Length; k++)
                    {
                        UnityEngine.GUILayout.Label("- " + entry.KeyEvents[k]);
                    }
                }
                else
                {
                    UnityEngine.GUILayout.Label("关键事件: 无");
                }

                UnityEngine.GUILayout.EndVertical();
                UnityEngine.GUILayout.Space(5);
            }

            UnityEngine.GUILayout.EndScrollView();
        }
    }
}
