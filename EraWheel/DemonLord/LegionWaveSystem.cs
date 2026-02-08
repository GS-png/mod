using System;
using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord
{
    public class LegionWaveSystem
    {
        private readonly LegionWaveState _state = new LegionWaveState();
        private readonly Random _rng = new Random();
        private readonly SpawnSystem _spawn = new SpawnSystem();

#if !ERAWHEEL_SELFTEST
        private struct LegionUnitHandle
        {
            public Actor Actor;
            public string UnitId;
        }

        private readonly System.Collections.Generic.Dictionary<long, LegionUnitHandle> _trackedUnits =
            new System.Collections.Generic.Dictionary<long, LegionUnitHandle>();
#endif

        private EraPhase _lastPhase = EraPhase.Sealed;
        private long _lastWorldAge = -1;

        public LegionWaveState State => _state;

        public void Reset()
        {
            _state.Reset();
            _lastPhase = EraPhase.Sealed;
            _lastWorldAge = -1;
#if !ERAWHEEL_SELFTEST
            ClearTrackedUnits();
            _trackedUnits.Clear();
#endif
        }

        public void Update(ModConfig cfg, CycleManager cycle)
        {
            if (cycle == null) return;

            var phase = cycle.CurrentPhase;
            var worldAge = cycle.WorldAge;

            var inInvasionWindow = phase == EraPhase.Invasion || phase == EraPhase.Peak;

            if (_lastWorldAge < 0) _lastWorldAge = worldAge;

            if (_lastPhase != phase)
            {
                var lastInInvasionWindow = _lastPhase == EraPhase.Invasion || _lastPhase == EraPhase.Peak;
                if (inInvasionWindow && !lastInInvasionWindow)
                {
                    _state.Reset();
                    _state.LastWaveWorldAge = worldAge;
#if !ERAWHEEL_SELFTEST
                    SyncActiveUnitsFromTracked();
#endif
                }

                _lastPhase = phase;
            }

            if (!inInvasionWindow)
            {
                _lastWorldAge = worldAge;
                return;
            }

            var deltaYears = worldAge - _lastWorldAge;
            if (deltaYears > 0)
            {
                _lastWorldAge = worldAge;
                if (WorldCompat.MockEnabled)
                {
                    ApplyAttritionPerYear(worldAge, (int)deltaYears);
                }
            }

            var conf = ReadConfig(cfg);

            if (_state.LastWaveWorldAge < 0)
            {
                _state.LastWaveWorldAge = worldAge;
            }

            var interval = GetEffectiveWaveInterval(conf, phase);
            var sinceLastWave = worldAge - _state.LastWaveWorldAge;
            if (sinceLastWave < interval) return;

            var strengthMultiplier = cycle.GetDemonStrengthMultiplier(cfg);
            SpawnWave(conf, worldAge, strengthMultiplier);
        }

        private static LegionConfig ReadConfig(ModConfig cfg)
        {
            var c = new LegionConfig();
            if (cfg == null || cfg.demon_lord == null || cfg.demon_lord.legion == null) return c;

            c.WaveIntervalYears = cfg.demon_lord.legion.wave_interval_years;
            c.BaseUnitsPerWave = cfg.demon_lord.legion.base_units_per_wave;
            c.WaveGrowthRate = cfg.demon_lord.legion.wave_growth_rate;
            c.MaxUnitsPerWave = cfg.demon_lord.legion.max_units_per_wave;
            c.MaxAliveUnits = cfg.demon_lord.legion.max_alive_units;
            c.EliteRate = cfg.demon_lord.legion.elite_rate;

            if (c.WaveIntervalYears < 1) c.WaveIntervalYears = 1;
            if (c.BaseUnitsPerWave < 1) c.BaseUnitsPerWave = 1;
            if (c.MaxUnitsPerWave < 1) c.MaxUnitsPerWave = 1;
            if (c.MaxAliveUnits < 1) c.MaxAliveUnits = 1;
            if (c.EliteRate < 0f) c.EliteRate = 0f;
            if (c.EliteRate > 0.3f) c.EliteRate = 0.3f;

            return c;
        }

        private static int GetEffectiveWaveInterval(LegionConfig conf, EraPhase phase)
        {
            if (conf == null) return 1;

            var interval = conf.WaveIntervalYears;
            if (interval < 1) interval = 1;

            if (phase == EraPhase.Peak && interval > 1)
            {
                interval = (int)Math.Round(interval * 0.5f, MidpointRounding.AwayFromZero);
                if (interval < 1) interval = 1;
            }

            return interval;
        }

        private void SpawnWave(LegionConfig conf, long worldAge, float strengthMultiplier)
        {
            _state.CurrentWave++;
            _state.LastWaveWorldAge = worldAge;

            var growth = 1f + conf.WaveGrowthRate * (_state.CurrentWave - 1);
            if (growth < 1f) growth = 1f;

            if (strengthMultiplier <= 0f) strengthMultiplier = 1f;
            var desired = (int)Math.Round(conf.BaseUnitsPerWave * growth * strengthMultiplier);
            if (desired < 1) desired = 1;
            if (desired > conf.MaxUnitsPerWave) desired = conf.MaxUnitsPerWave;

            var canSpawn = conf.MaxAliveUnits - _state.AliveUnits;
            if (canSpawn <= 0)
            {
                Log.Info("[EraWheel] Legion wave skipped (alive cap reached): wave=" + _state.CurrentWave + " alive=" + _state.AliveUnits + "/" + conf.MaxAliveUnits);
                return;
            }

            var spawnCount = desired;
            if (spawnCount > canSpawn) spawnCount = canSpawn;

#if ERAWHEEL_SELFTEST
            for (var i = 0; i < spawnCount; i++)
            {
                var unitId = LegionUnitFactory.PickUnitIdForWave(_state.CurrentWave, conf.EliteRate, _rng);
                _state.ActiveUnitIds.Add(unitId);

                if (string.Equals(unitId, "legion_ultimate", StringComparison.Ordinal))
                {
                    _state.EverSpawnedUltimate = true;
                }
            }

            _state.TotalUnitsSpawned += spawnCount;
            _state.AliveUnits += spawnCount;

            Log.Info("[EraWheel] Legion wave spawned: wave=" + _state.CurrentWave + " spawn=" + spawnCount + " desired=" + desired + " alive=" + _state.AliveUnits + "/" + conf.MaxAliveUnits);
#else
            var success = SpawnUnitsInWorld(conf, spawnCount);
            if (success <= 0)
            {
                Log.Warning("[EraWheel] Legion wave spawn failed: wave=" + _state.CurrentWave + " desired=" + desired);
                return;
            }

            _state.TotalUnitsSpawned += success;
            _state.AliveUnits += success;

            Log.Info("[EraWheel] Legion wave spawned: wave=" + _state.CurrentWave + " spawn=" + success + " desired=" + desired + " alive=" + _state.AliveUnits + "/" + conf.MaxAliveUnits);
#endif
        }

        private void ApplyAttritionPerYear(long worldAge, int years)
        {
            if (years <= 0) return;

            for (var y = 0; y < years; y++)
            {
                if (_state.AliveUnits <= 0) break;

                var reduce = Math.Max(1, _state.AliveUnits / 10);
                if (reduce > _state.AliveUnits) reduce = _state.AliveUnits;

                _state.AliveUnits -= reduce;

                if (WorldCompat.MockEnabled)
                {
                    try
                    {
                        EventBus.Publish(new DemonKillEvent
                        {
                            Count = reduce,
                            WorldTime = worldAge
                        });
                    }
                    catch
                    {
                    }
                }

                if (_state.ActiveUnitIds != null && _state.ActiveUnitIds.Count > 0)
                {
                    var remove = Math.Min(reduce, _state.ActiveUnitIds.Count);
                    _state.ActiveUnitIds.RemoveRange(0, remove);
                }
            }
        }

#if !ERAWHEEL_SELFTEST
        private int SpawnUnitsInWorld(LegionConfig conf, int spawnCount)
        {
            if (spawnCount <= 0) return 0;

            var anchorActor = global::EraWheel.Main.Instance?.DemonLordRegistry?.Active?.Actor;
            var success = 0;

            for (var i = 0; i < spawnCount; i++)
            {
                var unitId = LegionUnitFactory.PickUnitIdForWave(_state.CurrentWave, conf.EliteRate, _rng);
                var tile = _spawn.TryPickSpawnTile(anchorActor, 6) as WorldTile;
                if (tile == null) continue;

                var actor = _spawn.TrySpawnUnit(unitId, tile) as Actor;
                if (actor == null) continue;

                success++;
                _state.ActiveUnitIds.Add(unitId);
                TrackUnit(actor, unitId);

                if (string.Equals(unitId, "legion_ultimate", StringComparison.Ordinal))
                {
                    _state.EverSpawnedUltimate = true;
                }
            }

            return success;
        }

        private void TrackUnit(Actor actor, string unitId)
        {
            if (actor == null || string.IsNullOrEmpty(unitId)) return;
            var id = actor.getID();
            if (id <= 0 || _trackedUnits.ContainsKey(id)) return;

            _trackedUnits[id] = new LegionUnitHandle
            {
                Actor = actor,
                UnitId = unitId
            };
            DemonActorRegistry.Register(actor);
            actor.callbacks_on_death += OnLegionUnitDeath;
        }

        private void OnLegionUnitDeath(Actor deadActor)
        {
            if (deadActor == null) return;
            var id = deadActor.getID();
            if (!_trackedUnits.TryGetValue(id, out var handle)) return;

            _trackedUnits.Remove(id);
            deadActor.callbacks_on_death -= OnLegionUnitDeath;
            DemonActorRegistry.Unregister(deadActor);

            _state.AliveUnits = Math.Max(0, _state.AliveUnits - 1);
            RemoveActiveUnitId(handle.UnitId);

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

        private void RemoveActiveUnitId(string unitId)
        {
            if (string.IsNullOrEmpty(unitId) || _state.ActiveUnitIds == null) return;
            var idx = _state.ActiveUnitIds.IndexOf(unitId);
            if (idx >= 0) _state.ActiveUnitIds.RemoveAt(idx);
        }

        private void ClearTrackedUnits()
        {
            foreach (var handle in _trackedUnits.Values)
            {
                var actor = handle.Actor;
                if (actor == null) continue;
                actor.callbacks_on_death -= OnLegionUnitDeath;
                DemonActorRegistry.Unregister(actor);
            }
        }

        private void SyncActiveUnitsFromTracked()
        {
            _state.AliveUnits = 0;
            _state.ActiveUnitIds.Clear();
            _state.EverSpawnedUltimate = false;

            foreach (var handle in _trackedUnits.Values)
            {
                var unitId = handle.UnitId;
                if (string.IsNullOrEmpty(unitId)) continue;
                _state.ActiveUnitIds.Add(unitId);
                _state.AliveUnits++;

                if (string.Equals(unitId, "legion_ultimate", StringComparison.Ordinal))
                {
                    _state.EverSpawnedUltimate = true;
                }
            }
        }
#endif
    }
}
