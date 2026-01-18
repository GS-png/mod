using System;
using System.Collections.Generic;
using System.Reflection;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.Core.Events;
using EraOfWheel.Cycle;
using EraOfWheel.UI;
using EraOfWheel.DemonLords.General.AI;
using EraOfWheel.DemonLords.General.Skills;
using Logger = EraOfWheel.Core.Logger;

namespace EraOfWheel.DemonLords.General
{
    public class GeneralManager : IModSystem
    {
        public static GeneralManager Instance { get; private set; }

        public string SystemName => "GeneralManager";
        public bool IsInitialized { get; private set; }

        private GeneralSystemConfig _config;

        private readonly Blackboard _bb = new Blackboard();
        private IBehaviorNode _root;

        private readonly List<IGeneralSkill> _skills = new List<IGeneralSkill>();

        private BaseGeneral _activeGeneral;
        private string _activeGeneralForDemonId = "";

        private int _lastSkillTickYear = int.MinValue;

        public BaseGeneral ActiveGeneral => _activeGeneral;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            _config = ConfigManager.Instance?.Config?.generals ?? new GeneralSystemConfig();

            BuildBehaviorTree();
            BuildSkills();
            SubscribeToEvents();

            IsInitialized = true;
            Logger.Info(SystemName, "GeneralManager initialized");
        }

        private void SubscribeToEvents()
        {
            EventBus.Instance?.Subscribe<DemonStateChangedEvent>(OnDemonStateChanged);
            EventBus.Instance?.Subscribe<CycleCompletedEvent>(OnCycleCompleted);
        }

        private void OnCycleCompleted(CycleCompletedEvent e)
        {
            Reset();
        }

        private void OnDemonStateChanged(DemonStateChangedEvent e)
        {
            if (e == null) return;

            if (e.CurrentState == DemonState.Invasion.ToString() || e.CurrentState == DemonState.Peak.ToString())
            {
                EnsureGeneralForActiveDemon();
            }

            if (e.CurrentState == DemonState.Sealed.ToString() || e.CurrentState == DemonState.Resealed.ToString())
            {
                Reset();
            }
        }

        public void Update(int currentYear)
        {
            if (!IsInitialized) return;
            _config = ConfigManager.Instance?.Config?.generals ?? _config ?? new GeneralSystemConfig();
            if (_config == null || !_config.enabled) return;

            var phase = CycleManager.Instance?.State?.CurrentPhase;
            if (phase != CyclePhase.Invasion && phase != CyclePhase.Peak) return;

            EnsureGeneralForActiveDemon();

            if (_activeGeneral == null) return;

            _activeGeneral.Update(currentYear);

            if (_activeGeneral.Betrayed)
            {
                return;
            }

            if (TryHandleGeneralDefeat(currentYear))
            {
                return;
            }

            if (TryShouldBetray(_activeGeneral) && UnityEngine.Random.value < _config.betray_probability)
            {
                TriggerBetrayal(_activeGeneral);
                return;
            }

            if (_activeGeneral.TryGetHealthPercent(out var hp) && hp <= _config.retreat_health_percent)
            {
                DoRetreat(_activeGeneral);
                return;
            }

            if (_root != null)
            {
                int interval = Math.Max(1, _config.skill_check_interval_years);
                if (_lastSkillTickYear == int.MinValue || currentYear - _lastSkillTickYear >= interval)
                {
                    _lastSkillTickYear = currentYear;
                    _bb.Set("year", currentYear);
                    _bb.Set("general", _activeGeneral);
                    _root.Tick(_bb);
                }
            }
        }

        private bool TryHandleGeneralDefeat(int currentYear)
        {
            if (_activeGeneral == null) return false;

            // 1) Actor 丢失：如果曾经有过 actor，则判定为败北一次并尝试重生
            if (_activeGeneral.HasHadActor && _activeGeneral.Actor == null)
            {
                _activeGeneral.RecordDefeat();
                NotificationSystem.Instance?.Show("将领败北", $"{_activeGeneral.Name}败北（累计{_activeGeneral.DefeatCount}次）", NotificationType.Warning);
                RespawnGeneral();
                return true;
            }

            // 2) Actor 仍在但血量极低：判定为败北并清理 actor，让后续重生
            if (_activeGeneral.TryGetHealthPercent(out var hp) && hp <= 0.1f)
            {
                _activeGeneral.RecordDefeat();
                _activeGeneral.ClearActor();
                NotificationSystem.Instance?.Show("将领败北", $"{_activeGeneral.Name}败北（累计{_activeGeneral.DefeatCount}次）", NotificationType.Warning);
                RespawnGeneral();
                return true;
            }

            return false;
        }

        private void RespawnGeneral()
        {
            var demon = DemonLordManager.Instance?.ActiveDemonLord;
            if (demon == null) return;
            if (_activeGeneral == null) return;

            if (TryGetDemonActorTile(demon, out var tile))
            {
                _activeGeneral.EnsureActorSpawned("unit_demon", tile);
            }
            else
            {
                _activeGeneral.EnsureActorSpawned("unit_demon", null);
            }
        }

        private void BuildSkills()
        {
            _skills.Clear();
            _skills.Add(new RallyLegionSkill());
            _skills.Add(new CorruptEnemySkill());
        }

        private void BuildBehaviorTree()
        {
            _root = new SelectorNode(new List<IBehaviorNode>
            {
                new ActionNode(TryUseAnySkill)
            });
        }

        private NodeStatus TryUseAnySkill(Blackboard bb)
        {
            if (bb == null) return NodeStatus.Failure;
            if (!bb.TryGet("general", out BaseGeneral general) || general == null) return NodeStatus.Failure;
            if (!bb.TryGet("year", out int year)) return NodeStatus.Failure;

            for (int i = 0; i < _skills.Count; i++)
            {
                var s = _skills[i];
                if (s == null) continue;

                if (s.TryUse(general, year))
                {
                    return NodeStatus.Success;
                }
            }

            return NodeStatus.Failure;
        }

        private void EnsureGeneralForActiveDemon()
        {
            var demon = DemonLordManager.Instance?.ActiveDemonLord;
            if (demon == null) return;

            string demonId = demon.Id ?? "";
            if (string.IsNullOrEmpty(demonId)) return;

            if (_activeGeneral != null && _activeGeneralForDemonId == demonId) return;

            _activeGeneralForDemonId = demonId;
            _activeGeneral = new DemonGeneral($"general_{demonId}", $"{demon.Name}的将领");
            _activeGeneral.Initialize(demonId);

            if (TryGetDemonActorTile(demon, out var tile))
            {
                _activeGeneral.EnsureActorSpawned("unit_demon", tile);
            }
            else
            {
                _activeGeneral.EnsureActorSpawned("unit_demon", null);
            }
        }

        private static bool TryGetDemonActorTile(BaseDemonLord demon, out object tile)
        {
            tile = null;
            if (demon == null) return false;

            try
            {
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
                var t = demon.GetType();

                var prop = t.GetProperty("DemonActor", flags);
                var actor = prop?.GetValue(demon, null) as Actor;
                if (actor == null)
                {
                    var field = t.GetField("DemonActor", flags);
                    actor = field?.GetValue(demon) as Actor;
                }
                if (actor == null)
                {
                    var field = t.GetField("<DemonActor>k__BackingField", flags);
                    actor = field?.GetValue(demon) as Actor;
                }

                if (actor == null) return false;

                tile = ActorUtils.GetMemberValue(actor, "currentTile")
                       ?? ActorUtils.GetMemberValue(actor, "tile")
                       ?? ActorUtils.GetMemberValue(actor, "current_tile");

                return tile != null;
             }
             catch
             {
                 tile = null;
                 return false;
             }
         }

        private static bool TryShouldBetray(BaseGeneral general)
        {
            if (general == null) return false;

            int threshold = ConfigManager.Instance?.Config?.generals?.defeat_threshold ?? 3;
            return !general.Betrayed && general.DefeatCount >= threshold;
        }

        private static void TriggerBetrayal(BaseGeneral general)
        {
            if (general == null) return;

            general.SetBetrayed(true);

            try
            {
                general.TryRemoveTrait("dlm_demon_faction");
            }
            catch
            {
            }

            NotificationSystem.Instance?.Show("将领背叛", $"{general.Name}背叛了魔王阵营！", NotificationType.Critical);
            Logger.Warn("GeneralManager", $"General betrayed: {general.Id}");
        }

        private static void DoRetreat(BaseGeneral general)
        {
            if (general == null) return;

            general.TryHealToPercent(60f);
            NotificationSystem.Instance?.Show("将领撤退", $"{general.Name}撤退并暂时保存实力", NotificationType.Warning);
        }

        private void Reset()
        {
            _activeGeneral = null;
            _activeGeneralForDemonId = "";
            _lastSkillTickYear = int.MinValue;
        }

        public void Dispose()
        {
            EventBus.Instance?.Unsubscribe<DemonStateChangedEvent>(OnDemonStateChanged);
            EventBus.Instance?.Unsubscribe<CycleCompletedEvent>(OnCycleCompleted);

            Reset();

            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "GeneralManager disposed");
        }

        private class DemonGeneral : BaseGeneral
        {
            private readonly string _id;
            private readonly string _name;

            public DemonGeneral(string id, string name)
            {
                _id = id ?? "";
                _name = string.IsNullOrEmpty(name) ? "魔王将领" : name;
            }

            public override string Id => _id;
            public override string Name => _name;
        }
    }
}
