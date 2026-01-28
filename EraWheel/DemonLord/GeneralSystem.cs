using System;
using System.Collections.Generic;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Data;

namespace EraWheel.DemonLord
{
    public class GeneralSystem
    {
        private readonly List<GeneralRuntime> _generals = new List<GeneralRuntime>();
        private readonly Random _rng = new Random();
        private readonly SpawnSystem _spawn = new SpawnSystem();

#if !ERAWHEEL_SELFTEST
        private readonly Dictionary<long, string> _actorToGeneralId = new Dictionary<long, string>();
#endif

        private string _activeDemonId;
        private long _lastWorldAge = -1;

        public GeneralRuntime[] Generals
        {
            get { return _generals.ToArray(); }
        }

        public int ActiveCount
        {
            get
            {
                var count = 0;
                for (var i = 0; i < _generals.Count; i++)
                {
                    var g = _generals[i];
                    if (g != null && g.IsActive) count++;
                }
                return count;
            }
        }

        public void Reset()
        {
#if !ERAWHEEL_SELFTEST
            ClearTrackedActors();
            _actorToGeneralId.Clear();
#endif
            _generals.Clear();
            _activeDemonId = null;
            _lastWorldAge = -1;
        }

        public void Update(ModConfig cfg, CycleManager cycle, DemonLordRegistry demons)
        {
            if (cycle == null || demons == null) return;

            var worldAge = cycle.WorldAge;
            if (_lastWorldAge < 0) _lastWorldAge = worldAge;
            var deltaYears = worldAge - _lastWorldAge;
            if (deltaYears < 0) deltaYears = 0;
            _lastWorldAge = worldAge;

            var active = demons.Active;
            if (active == null)
            {
                Reset();
                return;
            }

            if (!string.Equals(_activeDemonId, active.Id, StringComparison.Ordinal))
            {
                _activeDemonId = active.Id;
                InitializeForDemon(cfg, active.Id, cycle.CycleCount);
            }

            UpdateRespawns(cfg, cycle, demons, deltaYears);

            var desiredActive = GetDesiredActiveCount(cfg, cycle);
            EnsureActiveSlots(cfg, cycle, demons, desiredActive);

            UpdateGeneralHealth(cfg, cycle, demons);

            TryBetrayals(cfg, cycle, deltaYears);
        }

        private void InitializeForDemon(ModConfig cfg, string demonId, int cycleCount)
        {
#if !ERAWHEEL_SELFTEST
            ClearTrackedActors();
            _actorToGeneralId.Clear();
#endif
            _generals.Clear();
            var templates = GeneralFactory.CreateTemplates(demonId);
            for (var i = 0; i < templates.Length; i++)
            {
                var t = templates[i];
                if (t == null) continue;
                if (cycleCount < t.MinCycle) continue;

                _generals.Add(new GeneralRuntime
                {
                    DemonLordId = demonId,
                    Id = t.Id,
                    Role = t.Role,
                    State = GeneralState.Inactive,
                    DefeatCount = 0,
                    NextRespawnWorldAge = -1,
                    LastSpawnAttemptWorldAge = -1,
                    Actor = null
                });
            }
        }

        private int GetDesiredActiveCount(ModConfig cfg, CycleManager cycle)
        {
            if (cfg == null || cfg.demon_lord == null || cfg.demon_lord.generals == null) return 0;

            var g = cfg.demon_lord.generals;
            var count = g.initial_count + cycle.CycleCount * g.per_cycle_increase;
            if (count < 0) count = 0;
            if (count > g.max_count) count = g.max_count;

            if (cycle.CurrentPhase == EraPhase.Peak)
            {
                count = g.max_count;
            }

            if (count < 0) count = 0;
            return count;
        }

        private void EnsureActiveSlots(ModConfig cfg, CycleManager cycle, DemonLordRegistry demons, int desiredActive)
        {
            if (desiredActive <= 0) return;

            var canActivate = cycle.CurrentPhase == EraPhase.Invasion || cycle.CurrentPhase == EraPhase.Peak;
            if (!canActivate) return;

            var activeCount = 0;
            for (var i = 0; i < _generals.Count; i++)
            {
                if (_generals[i] != null && _generals[i].IsActive) activeCount++;
            }

            if (activeCount >= desiredActive) return;

            for (var i = 0; i < _generals.Count && activeCount < desiredActive; i++)
            {
                var gr = _generals[i];
                if (gr == null) continue;
                if (gr.State != GeneralState.Inactive) continue;

                if (TryActivateGeneral(cfg, cycle, demons, gr))
                {
                    gr.State = GeneralState.Active;
                    _generals[i] = gr;
                    activeCount++;
                }
            }
        }

        private void UpdateRespawns(ModConfig cfg, CycleManager cycle, DemonLordRegistry demons, long deltaYears)
        {
            if (deltaYears <= 0) return;

            var demonActive = cycle.CurrentPhase == EraPhase.Invasion || cycle.CurrentPhase == EraPhase.Peak || cycle.CurrentPhase == EraPhase.Weakening;
            if (!demonActive) return;

            for (var i = 0; i < _generals.Count; i++)
            {
                var g = _generals[i];
                if (g == null) continue;
                if (g.State != GeneralState.Defeated) continue;

                if (g.NextRespawnWorldAge >= 0 && cycle.WorldAge >= g.NextRespawnWorldAge)
                {
                    if (TryActivateGeneral(cfg, cycle, demons, g))
                    {
                        g.State = GeneralState.Active;
                        g.NextRespawnWorldAge = -1;
                        _generals[i] = g;
                    }
                }
            }
        }

        private void UpdateGeneralHealth(ModConfig cfg, CycleManager cycle, DemonLordRegistry demons)
        {
            for (var i = 0; i < _generals.Count; i++)
            {
                var g = _generals[i];
                if (g == null) continue;

                if (g.State == GeneralState.Active || g.State == GeneralState.Retreating)
                {
                    if (g.Actor == null)
                    {
                        TryActivateGeneral(cfg, cycle, demons, g);
                        continue;
                    }

                    if (WorldCompat.TryGetActorHealthPercent(g.Actor, out var hp))
                    {
                        if (hp <= 0f)
                        {
                            ReportGeneralDefeated(g.Id, cycle.WorldAge);
                            continue;
                        }

                        if (g.State == GeneralState.Active && hp < 20f)
                        {
                            g.State = GeneralState.Retreating;
                        }
                        else if (g.State == GeneralState.Retreating && hp > 50f)
                        {
                            g.State = GeneralState.Active;
                        }
                    }
                }
            }
        }

        private bool TryActivateGeneral(ModConfig cfg, CycleManager cycle, DemonLordRegistry demons, GeneralRuntime g)
        {
            if (g == null) return false;

            if (cycle != null && g.LastSpawnAttemptWorldAge == cycle.WorldAge)
            {
                return false;
            }

            if (cycle != null)
            {
                g.LastSpawnAttemptWorldAge = cycle.WorldAge;
            }

#if ERAWHEEL_SELFTEST
            g.Actor = null;
            return true;
#else
            var anchorActor = demons != null ? demons.Active?.Actor : null;
            if (anchorActor == null && global::EraWheel.Main.Instance != null)
            {
                anchorActor = global::EraWheel.Main.Instance.DemonLordRegistry?.Active?.Actor;
            }

            var tile = _spawn.TryPickSpawnTile(anchorActor, 6) as WorldTile;
            if (tile == null) return false;

            var actor = _spawn.TrySpawnUnit(g.Id, tile) as Actor;
            if (actor == null) return false;

            g.Actor = actor;
            RegisterGeneralActor(actor, g.Id);
            return true;
#endif
        }

        public void ReportGeneralDefeated(string generalId, long worldAge)
        {
            if (string.IsNullOrEmpty(generalId)) return;

            for (var i = 0; i < _generals.Count; i++)
            {
                var g = _generals[i];
                if (g == null) continue;
                if (!string.Equals(g.Id, generalId, StringComparison.Ordinal)) continue;

                if (g.State == GeneralState.Betrayed) return;

                g.DefeatCount++;
                g.State = GeneralState.Defeated;
                g.NextRespawnWorldAge = worldAge + 20;
#if !ERAWHEEL_SELFTEST
                if (g.Actor is Actor actor)
                {
                    UnregisterGeneralActor(actor);
                }
#endif
                g.Actor = null;
                _generals[i] = g;
                return;
            }
        }

        private void TryBetrayals(ModConfig cfg, CycleManager cycle, long deltaYears)
        {
            if (cfg == null || cfg.demon_lord == null || cfg.demon_lord.generals == null) return;

            if (cycle.CurrentPhase != EraPhase.Weakening) return;
            if (deltaYears <= 0) return;

            var chance = cfg.demon_lord.generals.betrayal_base_chance;
            if (WorldCompat.MockEnabled)
            {
                chance = 1f;
            }
            if (chance <= 0f) return;

            var threshold = Math.Max(1, cfg.demon_lord.generals.betrayal_defeat_threshold);

            for (var i = 0; i < _generals.Count; i++)
            {
                var g = _generals[i];
                if (g == null) continue;
                if (g.State == GeneralState.Betrayed) continue;
                if (g.DefeatCount < threshold) continue;

                var roll = _rng.NextDouble();
                if (roll > chance) continue;

                g.State = GeneralState.Betrayed;
                _generals[i] = g;

#if !ERAWHEEL_SELFTEST
                if (g.Actor is Actor actor)
                {
                    TryJoinRandomKingdom(actor);
                    UnregisterGeneralActor(actor);
                    g.Actor = null;
                }
#endif

                try
                {
                    EventBus.Publish(new GeneralBetrayedEvent
                    {
                        DemonLordId = g.DemonLordId,
                        GeneralId = g.Id,
                        DefeatCount = g.DefeatCount,
                        WorldTime = cycle.WorldAge
                    });
                }
                catch
                {
                }

                Log.Info("[EraWheel] General betrayed: demon=" + g.DemonLordId + " general=" + g.Id + " defeats=" + g.DefeatCount);
            }
        }

        public GeneralSaveData[] ExportToSave()
        {
            var arr = new GeneralSaveData[_generals.Count];
            for (var i = 0; i < _generals.Count; i++)
            {
                var g = _generals[i];
                arr[i] = g == null ? new GeneralSaveData() : new GeneralSaveData
                {
                    DemonLordId = g.DemonLordId,
                    Id = g.Id,
                    Role = g.Role,
                    State = g.State,
                    DefeatCount = g.DefeatCount,
                    NextRespawnWorldAge = g.NextRespawnWorldAge
                };
            }
            return arr;
        }

        public void LoadFromSave(GeneralSaveData[] arr)
        {
            _generals.Clear();
            if (arr == null) return;

            for (var i = 0; i < arr.Length; i++)
            {
                var s = arr[i];
                if (s == null || string.IsNullOrEmpty(s.Id)) continue;

                _generals.Add(new GeneralRuntime
                {
                    DemonLordId = s.DemonLordId,
                    Id = s.Id,
                    Role = s.Role,
                    State = s.State,
                    DefeatCount = s.DefeatCount,
                    NextRespawnWorldAge = s.NextRespawnWorldAge,
                    LastSpawnAttemptWorldAge = -1,
                    Actor = null
                });
            }

            if (_generals.Count > 0)
            {
                _activeDemonId = _generals[0].DemonLordId;
            }
        }

#if !ERAWHEEL_SELFTEST
        private void RegisterGeneralActor(Actor actor, string generalId)
        {
            if (actor == null || string.IsNullOrEmpty(generalId)) return;

            var id = actor.getID();
            if (id <= 0) return;

            if (_actorToGeneralId.ContainsKey(id)) return;

            _actorToGeneralId[id] = generalId;
            DemonActorRegistry.Register(actor);
            actor.callbacks_on_death += OnGeneralDeath;
        }

        private void UnregisterGeneralActor(Actor actor)
        {
            if (actor == null) return;
            var id = actor.getID();
            if (id <= 0) return;
            actor.callbacks_on_death -= OnGeneralDeath;
            _actorToGeneralId.Remove(id);
            DemonActorRegistry.Unregister(actor);
        }

        private void OnGeneralDeath(Actor deadActor)
        {
            if (deadActor == null) return;

            var id = deadActor.getID();
            if (!_actorToGeneralId.TryGetValue(id, out var generalId)) return;

            _actorToGeneralId.Remove(id);
            DemonActorRegistry.Unregister(deadActor);

            var general = FindGeneral(generalId);
            if (general != null)
            {
                general.Actor = null;
                if (general.State != GeneralState.Betrayed)
                {
                    ReportGeneralDefeated(generalId, WorldCompat.GetWorldAge());
                    PublishDemonKill();
                }
            }
        }

        private GeneralRuntime FindGeneral(string generalId)
        {
            if (string.IsNullOrEmpty(generalId)) return null;
            for (var i = 0; i < _generals.Count; i++)
            {
                var g = _generals[i];
                if (g == null) continue;
                if (string.Equals(g.Id, generalId, StringComparison.Ordinal)) return g;
            }
            return null;
        }

        private void PublishDemonKill()
        {
            try
            {
                EventBus.Publish(new DemonKillEvent
                {
                    Count = 1,
                    WorldTime = WorldCompat.GetWorldAge()
                });
            }
            catch
            {
            }
        }

        private void TryJoinRandomKingdom(Actor actor)
        {
            var mapBox = MapBox.instance;
            if (mapBox == null || mapBox.kingdoms == null) return;

            var candidates = new List<Kingdom>();
            foreach (var kingdom in mapBox.kingdoms)
            {
                if (kingdom == null) continue;
                if (kingdom.wild) continue;
                candidates.Add(kingdom);
            }

            if (candidates.Count == 0) return;

            var pick = candidates[_rng.Next(0, candidates.Count)];
            actor.joinKingdom(pick);
        }

        private void ClearTrackedActors()
        {
            for (var i = 0; i < _generals.Count; i++)
            {
                var g = _generals[i];
                if (g == null) continue;
                if (g.Actor is Actor actor)
                {
                    UnregisterGeneralActor(actor);
                }
            }
        }
#endif
    }
}
