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

        public int TotalDestinedHeroesBorn { get; private set; }
        public int TotalHeroDeaths { get; private set; }
        public int TotalInheritances { get; private set; }

        public IReadOnlyList<HeroData> Heroes => _heroes;

        public void Initialize(ModConfig cfg)
        {
            _lastConfig = cfg;
            BindEvents();
        }

        private void BindEvents()
        {
            if (_bound) return;
            _bound = true;

            EventBus.Subscribe<PhaseChangedEvent>(OnPhaseChanged);
        }

        private void OnPhaseChanged(PhaseChangedEvent evt)
        {
            if (evt.NewPhase == EraPhase.Invasion || evt.NewPhase == EraPhase.Peak)
            {
                TrySpawnDestinedHero(evt.WorldTime);
            }
        }

        public void Update(ModConfig cfg, CycleManager cycle)
        {
            if (cfg != null) _lastConfig = cfg;
            if (cycle == null) return;

            var phase = cycle.CurrentPhase;
            if (phase == EraPhase.Invasion || phase == EraPhase.Peak || phase == EraPhase.Weakening)
            {
                UpdateHeroAI(cfg, cycle);
            }
        }

        private void TrySpawnDestinedHero(long worldTime)
        {
            var chance = 0.05f;
            if (_lastConfig != null && _lastConfig.civilization != null && _lastConfig.civilization.hero != null)
            {
                chance = _lastConfig.civilization.hero.destined_chance;
            }

            if (chance < 0f) chance = 0f;
            if (chance > 1f) chance = 1f;

            if (_rng.NextDouble() > chance) return;

            var hero = new HeroData
            {
                Id = "hero_" + (_nextHeroId++),
                Name = "命定英雄 #" + _nextHeroId,
                IsDestined = true,
                State = HeroState.Alive,
                BornWorldAge = worldTime
            };

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
        }

        private void UpdateHeroAI(ModConfig cfg, CycleManager cycle)
        {
            for (var i = _heroes.Count - 1; i >= 0; i--)
            {
                var hero = _heroes[i];
                if (hero.State != HeroState.Alive) continue;

                ExecuteHeroPriorities(hero, cycle);
            }
        }

        private void ExecuteHeroPriorities(HeroData hero, CycleManager cycle)
        {
            if (!hero.IsDestined) return;

            var phase = cycle.CurrentPhase;

            if (phase == EraPhase.Weakening)
            {
                hero.DemonLordDamageDealt += 100;
            }
            else if (phase == EraPhase.Peak || phase == EraPhase.Invasion)
            {
                hero.GeneralsDefeated += (hero.DemonLordDamageDealt > 500 ? 1 : 0);
            }
        }

        public void OnHeroDeath(string heroId, long worldTime, string cause)
        {
            var hero = FindHero(heroId);
            if (hero == null) return;
            if (hero.State == HeroState.Dead) return;

            var wasDestined = hero.IsDestined;
            hero.State = HeroState.Dead;
            hero.DeathWorldAge = worldTime;
            TotalHeroDeaths++;

            try
            {
                EventBus.Publish(new HeroDeathEvent
                {
                    HeroId = heroId,
                    WasDestined = wasDestined,
                    WorldTime = worldTime,
                    Cause = cause
                });
            }
            catch { }

            Log.Info("[EraWheel] Hero died: " + heroId + " cause=" + cause);

            if (wasDestined)
            {
                TryInheritance(hero, worldTime);
            }
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

            var inheritedTraits = new List<string>();
            if (parent.InheritedTraits != null)
            {
                inheritedTraits.AddRange(parent.InheritedTraits);
            }

            inheritedTraits.Add("legacy_hero_blood");

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
        }
    }
}
