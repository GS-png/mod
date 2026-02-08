using System;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Civilization;
using EraWheel.DemonLord;
using EraWheel.Narrative;

namespace EraWheel.UI.Tabs
{
    public class EventManageTab : ITab
    {
        private UnityEngine.Vector2 _scrollPos;
        private string _eventId = "omen_started";
        private string _status;

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

            UnityEngine.GUILayout.Label("事件池管理（骨架）", UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(5);

            var pool = NarrativeDispatcher.Instance.EventPool;
            UnityEngine.GUILayout.Label($"事件数量: {pool?.EventCount ?? 0}");

            if (UnityEngine.GUILayout.Button("重载事件池"))
            {
                ReloadEventPool();
            }

            UnityEngine.GUILayout.Space(10);
            UnityEngine.GUILayout.Label("手动触发事件ID:");
            _eventId = UnityEngine.GUILayout.TextField(_eventId ?? string.Empty);

            if (UnityEngine.GUILayout.Button("触发事件"))
            {
                TriggerEventById(cfg, cycle, registry, civTracker, alliance, generals, heroes);
            }

            if (!string.IsNullOrEmpty(_status))
            {
                UnityEngine.GUILayout.Space(5);
                UnityEngine.GUILayout.Label(_status);
            }

            UnityEngine.GUILayout.EndScrollView();
        }

        private void ReloadEventPool()
        {
            try
            {
                var root = Main.Instance?.ConfigManager?.ModRootPath;
                if (string.IsNullOrEmpty(root))
                {
                    _status = "事件池路径不可用";
                    return;
                }

                var eventsPath = System.IO.Path.Combine(root, "Resources", "events");
                NarrativeDispatcher.Instance.EventPool.LoadFromDirectory(eventsPath);
                _status = "事件池已重载";
            }
            catch (Exception ex)
            {
                _status = "事件池重载失败: " + ex.Message;
            }
        }

        private void TriggerEventById(
            ModConfig cfg,
            CycleManager cycle,
            DemonLordRegistry registry,
            CivilizationTracker civTracker,
            AllianceSystem alliance,
            GeneralSystem generals,
            HeroSystem heroes)
        {
            if (string.IsNullOrEmpty(_eventId))
            {
                _status = "请输入事件ID";
                return;
            }

            var pool = NarrativeDispatcher.Instance.EventPool;
            var evt = pool?.GetById(_eventId);
            if (evt == null)
            {
                _status = "未找到事件: " + _eventId;
                return;
            }

            var ctx = WorldContext.Capture();
            ctx.CurrentPhase = cycle?.CurrentPhase ?? EraPhase.Sealed;
            ctx.CycleCount = cycle?.CycleCount ?? 0;
            ctx.SealStrength = cycle?.SealStrength ?? 100f;
            ctx.DemonHealthPercent = cycle?.DemonHealthPercent ?? 100f;
            ctx.PhaseDuration = cycle != null ? (int)Math.Max(0, cycle.WorldAge - cycle.PhaseStartWorldAge) : 0;

            var activeDemon = registry?.ActiveDemonLord;
            ctx.DemonLordActive = activeDemon != null && activeDemon.Enabled;
            ctx.ActiveDemonLordId = activeDemon?.Id;
            ctx.ActiveDemonLordType = activeDemon?.Definition?.Type.ToString();

            ctx.DemonKillCount = civTracker?.DemonKillCount ?? 0;
            ctx.GeneralsActive = generals != null ? generals.ActiveCount : 0;

            ctx.Csi = civTracker?.CSI ?? 0f;
            ctx.AntiDemonLevel = civTracker?.AntiDemonLevel ?? 0;
            ctx.AllianceFormed = alliance?.State?.Formed ?? false;
            ctx.HeroCount = heroes != null ? heroes.AliveHeroCount : 0;
            ctx.DestinedHeroExists = heroes != null && heroes.HasDestinedHero;

            NarrativeDispatcher.Instance.DispatchEvent(evt, ctx);
            pool.MarkTriggered(evt, ctx);

            _status = "事件已触发: " + _eventId;
        }
    }
}
