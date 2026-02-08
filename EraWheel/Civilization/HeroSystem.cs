using System;
using System.Collections.Generic;
using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.Civilization
{
    public class HeroSystem
    {
        private bool _bound;
        private ModConfig _lastConfig;
        private readonly Random _rng = new Random();

        private readonly List<HeroData> _heroes = new List<HeroData>();
        private int _nextHeroId = 1;
        private readonly HashSet<long> _knownActorIds = new HashSet<long>();
        private readonly HashSet<long> _hookedActorIds = new HashSet<long>();
#if !ERAWHEEL_SELFTEST
        private bool _knownActorsInitialized;
        private bool _pendingActorBind;
        private long _lastWorldAge = -1;
#endif

        public int TotalDestinedHeroesBorn { get; private set; }
        public int TotalHeroDeaths { get; private set; }
        public int TotalInheritances { get; private set; }

        public IReadOnlyList<HeroData> Heroes => _heroes;
        public int AliveHeroCount
        {
            get
            {
                var count = 0;
                for (var i = 0; i < _heroes.Count; i++)
                {
                    if (_heroes[i].State == HeroState.Alive && _heroes[i].ActorId > 0)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public int DestinedHeroCount
        {
            get
            {
                var count = 0;
                for (var i = 0; i < _heroes.Count; i++)
                {
                    var hero = _heroes[i];
                    if (hero.State == HeroState.Alive && hero.IsDestined && hero.ActorId > 0)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public bool HasDestinedHero => DestinedHeroCount > 0;

        public void Initialize(ModConfig cfg)
        {
            _lastConfig = cfg;
            BindEvents();
            ResetActorTracking();
#if !ERAWHEEL_SELFTEST
            HeroTraitFactory.EnsureRegistered();
#endif
        }

        private void BindEvents()
        {
            if (_bound) return;
            _bound = true;

            EventBus.Subscribe<PhaseChangedEvent>(OnPhaseChanged);
        }

        private void ResetActorTracking()
        {
            _knownActorIds.Clear();
            _hookedActorIds.Clear();
#if !ERAWHEEL_SELFTEST
            _knownActorsInitialized = false;
            _pendingActorBind = true;
            _lastWorldAge = -1;
#endif
        }

        private void OnPhaseChanged(PhaseChangedEvent evt)
        {
            if (evt.NewPhase == EraPhase.Invasion || evt.NewPhase == EraPhase.Peak)
            {
                if (HasDestinedHero) return;
                TrySpawnDestinedHero(evt.WorldTime);
            }
        }

        public void Update(ModConfig cfg, CycleManager cycle)
        {
            if (cfg != null) _lastConfig = cfg;
            if (cycle == null) return;

#if !ERAWHEEL_SELFTEST
            UpdateActorTracking(cfg, cycle);
#endif

            var phase = cycle.CurrentPhase;
            if (phase == EraPhase.Invasion || phase == EraPhase.Peak || phase == EraPhase.Weakening)
            {
                UpdateHeroAI(cfg, cycle);
            }
        }

        private void TrySpawnDestinedHero(long worldTime)
        {
            var chance = GetDestinedChance();

            if (_rng.NextDouble() > chance) return;

            object actor = null;
#if !ERAWHEEL_SELFTEST
            actor = TryPickHeroActor();
            if (actor == null)
            {
                Log.Info("[EraWheel] No valid hero actor found for destined hero.");
                return;
            }
#endif
            CreateDestinedHero(worldTime, "命定英雄", actor, allowUnbound: false);
        }

        private float GetDestinedChance()
        {
            var chance = 0.05f;
            if (_lastConfig != null && _lastConfig.civilization != null && _lastConfig.civilization.hero != null)
            {
                chance = _lastConfig.civilization.hero.destined_chance;
            }

            if (chance < 0f) chance = 0f;
            if (chance > 1f) chance = 1f;
            return chance;
        }

        private void UpdateHeroAI(ModConfig cfg, CycleManager cycle)
        {
            for (var i = _heroes.Count - 1; i >= 0; i--)
            {
                var hero = _heroes[i];
                if (hero.State != HeroState.Alive) continue;
                if (!hero.IsDestined) continue;
                if (hero.ActorId <= 0) continue;

                float? healthRatio = null;
#if !ERAWHEEL_SELFTEST
                var actor = TryResolveActor(hero.ActorId);
                if (actor != null)
                {
                    try
                    {
                        healthRatio = actor.getHealthRatio();
                    }
                    catch
                    {
                    }
                }
                else
                {
                    continue;
                }
#endif
                var priority = HeroAI.GetCurrentPriority(hero, cycle, cfg, healthRatio);
                HeroAI.ExecutePriority(hero, priority, cycle);
            }
        }

        public void OnHeroDeath(string heroId, long worldTime, string cause)
        {
            var hero = FindHero(heroId);
            if (hero == null) return;
            MarkHeroDead(hero, worldTime, cause, true);
        }

        private void TryInheritance(HeroData parent, long worldTime)
        {
            var inheritChance = 0.3f;
            if (_lastConfig != null && _lastConfig.civilization != null && _lastConfig.civilization.hero != null)
            {
                inheritChance = _lastConfig.civilization.hero.inheritance_chance;
            }

            if (inheritChance < 0f) inheritChance = 0f;
            if (inheritChance > 1f) inheritChance = 1f;

            if (_rng.NextDouble() > inheritChance) return;
            CreateInheritedHero(parent, worldTime, allowUnbound: false);
        }

        internal HeroData ForceSpawnDestinedHero(long worldTime)
        {
#if ERAWHEEL_SELFTEST
            return CreateDestinedHero(worldTime, "验证英雄", null, allowUnbound: true);
#else
            var actor = TryPickHeroActor();
            if (actor == null)
            {
                Log.Warning("[EraWheel] ForceSpawnDestinedHero failed: no valid actor.");
                return null;
            }
            return CreateDestinedHero(worldTime, "验证英雄", actor, allowUnbound: false);
#endif
        }

        internal bool ForceHeroDeathWithInheritance(string heroId, long worldTime, string cause)
        {
            var hero = FindHero(heroId);
            if (hero == null) return false;
            if (!hero.IsDestined) return false;

            if (!MarkHeroDead(hero, worldTime, cause, false)) return false;
#if ERAWHEEL_SELFTEST
            CreateInheritedHero(hero, worldTime, allowUnbound: true);
            return true;
#else
            var child = CreateInheritedHero(hero, worldTime, allowUnbound: false);
            if (child == null)
            {
                Log.Warning("[EraWheel] ForceHeroDeathWithInheritance failed: no valid actor.");
                return false;
            }
            return true;
#endif
        }

        private HeroData CreateDestinedHero(long worldTime, string namePrefix, object actor, bool allowUnbound)
        {
            var id = _nextHeroId++;
            var hero = new HeroData
            {
                Id = "hero_" + id,
                Name = namePrefix + " #" + id,
                IsDestined = true,
                State = HeroState.Alive,
                InheritedTraits = (string[])HeroConstants.DefaultHeroTraits.Clone(),
                BornWorldAge = worldTime
            };

#if !ERAWHEEL_SELFTEST
            var typed = actor as Actor;
            if (typed == null && !allowUnbound)
            {
                return null;
            }
            if (typed != null)
            {
                var actorName = SafeGetActorName(typed);
                if (!string.IsNullOrEmpty(actorName))
                {
                    hero.Name = actorName;
                }
                BindHeroActor(hero, typed);
            }
#endif

            _heroes.Add(hero);
            TotalDestinedHeroesBorn++;

            try
            {
                EventBus.Publish(new HeroBornEvent
                {
                    HeroId = hero.Id,
                    IsDestined = true,
                    WorldTime = worldTime
                });
            }
            catch { }

            Log.Info("[EraWheel] Destined hero born: " + hero.Id);
            return hero;
        }

        private HeroData CreateInheritedHero(HeroData parent, long worldTime, bool allowUnbound)
        {
            EnsureHeroTraits(parent);
            var inheritedTraits = new List<string>();
            if (parent.InheritedTraits != null)
            {
                inheritedTraits.AddRange(parent.InheritedTraits);
            }

            if (!inheritedTraits.Contains(HeroConstants.BloodlineTraitId))
            {
                inheritedTraits.Add(HeroConstants.BloodlineTraitId);
            }

            var child = new HeroData
            {
                Id = "hero_" + (_nextHeroId++),
                Name = parent.Name + " 继承者",
                IsDestined = true,
                State = HeroState.Alive,
                FamilyId = string.IsNullOrEmpty(parent.FamilyId) ? parent.Id : parent.FamilyId,
                InheritedTraits = inheritedTraits.ToArray(),
                BornWorldAge = worldTime
            };

#if !ERAWHEEL_SELFTEST
            var actor = TryPickHeroActor();
            if (actor == null && !allowUnbound)
            {
                return null;
            }
            if (actor != null)
            {
                var actorName = SafeGetActorName(actor);
                if (!string.IsNullOrEmpty(actorName))
                {
                    child.Name = actorName;
                }
                BindHeroActor(child, actor);
            }
#endif

            _heroes.Add(child);
            TotalInheritances++;

            try
            {
                EventBus.Publish(new HeroInheritanceEvent
                {
                    ParentHeroId = parent.Id,
                    ChildHeroId = child.Id,
                    InheritedTraits = child.InheritedTraits,
                    WorldTime = worldTime
                });
            }
            catch { }

            Log.Info("[EraWheel] Hero inheritance: " + parent.Id + " -> " + child.Id);
            return child;
        }

        private HeroData FindHero(string heroId)
        {
            if (string.IsNullOrEmpty(heroId)) return null;
            for (var i = 0; i < _heroes.Count; i++)
            {
                if (_heroes[i].Id == heroId) return _heroes[i];
            }
            return null;
        }

        private HeroData FindHeroByActorId(long actorId)
        {
            if (actorId <= 0) return null;
            for (var i = 0; i < _heroes.Count; i++)
            {
                if (_heroes[i].ActorId == actorId) return _heroes[i];
            }
            return null;
        }

        private static void EnsureHeroTraits(HeroData hero)
        {
            if (hero == null) return;
            if (hero.InheritedTraits != null && hero.InheritedTraits.Length > 0) return;
            hero.InheritedTraits = (string[])HeroConstants.DefaultHeroTraits.Clone();
        }

        private bool MarkHeroDead(HeroData hero, long worldTime, string cause, bool allowInheritance)
        {
            if (hero == null) return false;
            if (hero.State == HeroState.Dead) return false;

            var wasDestined = hero.IsDestined;
            hero.State = HeroState.Dead;
            hero.DeathWorldAge = worldTime;
            TotalHeroDeaths++;
            if (hero.ActorId > 0)
            {
                _hookedActorIds.Remove(hero.ActorId);
            }

            try
            {
                EventBus.Publish(new HeroDeathEvent
                {
                    HeroId = hero.Id,
                    WasDestined = wasDestined,
                    WorldTime = worldTime,
                    Cause = cause
                });
            }
            catch
            {
            }

            Log.Info("[EraWheel] Hero died: " + hero.Id + " cause=" + cause);

            if (wasDestined && allowInheritance)
            {
                TryInheritance(hero, worldTime);
            }

            return true;
        }

#if !ERAWHEEL_SELFTEST
        private void UpdateActorTracking(ModConfig cfg, CycleManager cycle)
        {
            var worldAge = cycle.WorldAge;
            if (_lastWorldAge >= 0 && worldAge < _lastWorldAge)
            {
                ResetActorTracking();
            }
            _lastWorldAge = worldAge;

            if (!_knownActorsInitialized)
            {
                if (!InitializeKnownActors()) return;
            }
            else
            {
                ScanForNewActors(cfg, cycle);
            }

            if (_pendingActorBind)
            {
                RebindHeroActors();
                _pendingActorBind = false;
            }
        }

        private bool InitializeKnownActors()
        {
            var actors = TryGetCivActors();
            if (actors == null) return false;

            _knownActorIds.Clear();
            for (var i = 0; i < actors.Count; i++)
            {
                var actor = actors[i];
                if (actor == null) continue;
                var id = actor.getID();
                if (id <= 0) continue;
                _knownActorIds.Add(id);
            }

            _knownActorsInitialized = true;
            _pendingActorBind = true;
            return true;
        }

        private void ScanForNewActors(ModConfig cfg, CycleManager cycle)
        {
            var actors = TryGetCivActors();
            if (actors == null) return;

            var chance = GetDestinedChance();
            for (var i = 0; i < actors.Count; i++)
            {
                var actor = actors[i];
                if (actor == null) continue;
                var id = actor.getID();
                if (id <= 0) continue;
                if (!_knownActorIds.Add(id)) continue;

                if (!IsHeroCandidate(actor)) continue;
                if (_rng.NextDouble() > chance) continue;

                CreateDestinedHero(cycle.WorldAge, "命定英雄", actor, allowUnbound: false);
            }
        }

        private Actor TryPickHeroActor()
        {
            var actors = TryGetCivActors();
            if (actors == null || actors.Count == 0) return null;

            var tries = Math.Min(actors.Count, 8);
            for (var i = 0; i < tries; i++)
            {
                var candidate = actors[_rng.Next(actors.Count)];
                if (IsHeroCandidate(candidate)) return candidate;
            }

            for (var i = 0; i < actors.Count; i++)
            {
                var candidate = actors[i];
                if (IsHeroCandidate(candidate)) return candidate;
            }

            return null;
        }

        private bool IsHeroCandidate(Actor actor)
        {
            if (actor == null) return false;
            var id = actor.getID();
            if (id <= 0) return false;
            if (FindHeroByActorId(id) != null) return false;

            try
            {
                if (!actor.isAlive()) return false;
                if (actor.getAge() > 1) return false;
                if (actor.hasTrait(HeroConstants.BloodlineTraitId)) return false;
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void BindHeroActor(HeroData hero, Actor actor)
        {
            if (hero == null || actor == null) return;
            var id = actor.getID();
            if (id <= 0) return;

            HeroTraitFactory.EnsureRegistered();
            EnsureHeroTraits(hero);
            hero.ActorId = id;

            if (hero.InheritedTraits != null)
            {
                for (var i = 0; i < hero.InheritedTraits.Length; i++)
                {
                    var traitId = hero.InheritedTraits[i];
                    if (string.IsNullOrEmpty(traitId)) continue;
                    try
                    {
                        actor.addTrait(traitId);
                    }
                    catch
                    {
                    }
                }
            }

            if (_hookedActorIds.Add(id))
            {
                actor.callbacks_on_death += OnHeroActorDeath;
            }
        }

        private static string SafeGetActorName(Actor actor)
        {
            if (actor == null) return null;
            try
            {
                return actor.getName();
            }
            catch
            {
                return null;
            }
        }

        private Actor TryResolveActor(long actorId)
        {
            if (actorId <= 0) return null;

            var mapBox = MapBox.instance;
            if (mapBox == null || mapBox.units == null) return null;

            var list = mapBox.units.units_only_alive;
            if (list == null) return null;

            for (var i = 0; i < list.Count; i++)
            {
                var actor = list[i];
                if (actor == null) continue;
                if (actor.getID() == actorId) return actor;
            }

            return null;
        }

        private static List<Actor> TryGetCivActors()
        {
            var mapBox = MapBox.instance;
            if (mapBox == null || mapBox.units == null) return null;
            return mapBox.units.units_only_civ;
        }

        private void RebindHeroActors()
        {
            for (var i = 0; i < _heroes.Count; i++)
            {
                var hero = _heroes[i];
                if (hero == null || hero.State != HeroState.Alive) continue;
                if (hero.ActorId <= 0) continue;
                var actor = TryResolveActor(hero.ActorId);
                if (actor != null)
                {
                    BindHeroActor(hero, actor);
                }
            }
        }

        private void OnHeroActorDeath(Actor deadActor)
        {
            if (deadActor == null) return;
            var actorId = deadActor.getID();
            if (actorId <= 0) return;

            var hero = FindHeroByActorId(actorId);
            if (hero == null) return;

            OnHeroDeath(hero.Id, WorldCompat.GetWorldAge(), "actor_death");
        }
#endif

        public HeroSaveData ExportToSave()
        {
            return new HeroSaveData
            {
                Heroes = _heroes.ToArray(),
                TotalDestinedHeroesBorn = TotalDestinedHeroesBorn,
                TotalHeroDeaths = TotalHeroDeaths,
                TotalInheritances = TotalInheritances
            };
        }

        public void LoadFromSave(HeroSaveData data)
        {
            if (data == null) return;

            _heroes.Clear();
            if (data.Heroes != null)
            {
                _heroes.AddRange(data.Heroes);
            }

            TotalDestinedHeroesBorn = data.TotalDestinedHeroesBorn;
            TotalHeroDeaths = data.TotalHeroDeaths;
            TotalInheritances = data.TotalInheritances;

            var maxId = 0;
            for (var i = 0; i < _heroes.Count; i++)
            {
                var h = _heroes[i];
                EnsureHeroTraits(h);
                if (string.IsNullOrEmpty(h.Id)) continue;
                if (h.Id.StartsWith("hero_"))
                {
                    if (int.TryParse(h.Id.Substring(5), out var id))
                    {
                        if (id > maxId) maxId = id;
                    }
                }
            }
            _nextHeroId = maxId + 1;
            ResetActorTracking();
        }
    }
}
