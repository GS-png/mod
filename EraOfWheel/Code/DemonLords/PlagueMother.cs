using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.DemonLords.Legion;
using EraOfWheel.Cycle;
using Logger = EraOfWheel.Core.Logger;

namespace EraOfWheel.DemonLords
{
    public class PlagueMother : BaseDemonLord
    {
        public override string Id => "plague_mother";
        public override string Name => "瘟疫母神·娜迦蒂";
        public override string Title => "腐烂的爱抚者";
        public override string Description => "掌控疾病与腐朽的魔王，她的爱意表现为致命的瘟疫";
        public override int UnlockCycle => 1;

        private float _infectionSpreadChance;
        private int _incubationYears;
        private int _toxicFogDurationYears;
        private int _plagueLordSummonThreshold;
        
        private readonly Dictionary<string, int> _infectedSinceYear = new Dictionary<string, int>();
        private int _totalInfected = 0;
        private int _lastPlagueYear = int.MinValue;

        private readonly List<ToxicFogZone> _toxicFogZones = new List<ToxicFogZone>();
        private readonly HashSet<string> _mutatedUnits = new HashSet<string>();
        private int _totalMutations = 0;
        private readonly Dictionary<int, int> _cityLastOutbreakYear = new Dictionary<int, int>();
        private int _convertedSinceLastPlagueLord = 0;
        private int _lastPlagueLordYear = int.MinValue;

        private static bool _spawnApiSearched;
        private static MethodInfo _spawnApiMethod;
        private static object _spawnApiTarget;

        private const string InfectedTraitId = "plague_infected";
        private const float InfectionRadius = 50f;
        private const int MaxFogZones = 8;
        private const float FogRadius = 120f;
        private const float FogMergeDistance = 120f;
        private const float MutationChancePerYear = 0.01f;

        public PlagueMother()
        {
            Stats.BaseHealth = 80000f;
            Stats.BaseDamage = 600f;
            Stats.BaseDefense = 400f;
            Stats.BaseSpeed = 8f;
            Stats.HealthGrowthPerCycle = 0.4f;
            Stats.DamageGrowthPerCycle = 0.25f;
        }

        public override void Initialize(int cycleCount)
        {
            base.Initialize(cycleCount);
            
            var config = ConfigManager.Instance?.Config?.demon_lords?.plague_mother;
            if (config != null)
            {
                _infectionSpreadChance = config.infection_spread_chance;
                _incubationYears = config.incubation_years;
                _toxicFogDurationYears = config.toxic_fog_duration_years;
                _plagueLordSummonThreshold = config.plague_lord_summon_threshold;
                IsEnabled = config.enabled;
            }
            else
            {
                _infectionSpreadChance = 0.3f;
                _incubationYears = 5;
                _toxicFogDurationYears = 10;
                _plagueLordSummonThreshold = 100;
            }
        }

        protected override void UpdateInvasion(int currentYear)
        {
            base.UpdateInvasion(currentYear);

            LegionActorRegistry.EnsureRegistered();

            SpreadInfection(currentYear);
            ProcessIncubation(currentYear);
            ApplyMutations(currentYear);
            UpdateToxicFog(currentYear);
            CheckPlagueLordSummon(currentYear);
        }

        public override void ApplyUniqueAbility()
        {
            TriggerGlobalPlague();
        }

        private void SpreadInfection(int currentYear)
        {
            try
            {
                var units = World.world?.units;
                if (units == null) return;

                var infectedGrid = new Dictionary<long, List<Vector2>>();
                var seenInfected = new HashSet<string>();

                int totalUnits = 0;
                foreach (var unit in units)
                {
                    if (unit == null) continue;
                    totalUnits++;

                    if (IsDemonFaction(unit)) continue;

                    string unitId = GetUnitId(unit);
                    if (string.IsNullOrEmpty(unitId)) continue;

                    bool infected = _infectedSinceYear.ContainsKey(unitId);
                    if (!infected)
                    {
                        try { infected = unit.hasTrait(InfectedTraitId); } catch { infected = false; }

                        if (infected)
                        {
                            _infectedSinceYear[unitId] = currentYear;
                        }
                    }

                    if (!infected) continue;
                    seenInfected.Add(unitId);

                    if (TryGetActorPosition2D(unit, out var pos))
                    {
                        long key = GetGridKey(pos, InfectionRadius);
                        if (!infectedGrid.TryGetValue(key, out var list))
                        {
                            list = new List<Vector2>(8);
                            infectedGrid[key] = list;
                        }
                        list.Add(pos);
                    }
                }

                if (_infectedSinceYear.Count != seenInfected.Count)
                {
                    var toRemove = new List<string>();
                    foreach (var kv in _infectedSinceYear)
                    {
                        if (!seenInfected.Contains(kv.Key))
                        {
                            toRemove.Add(kv.Key);
                        }
                    }
                    for (int i = 0; i < toRemove.Count; i++)
                    {
                        _infectedSinceYear.Remove(toRemove[i]);
                    }
                }

                _totalInfected = _infectedSinceYear.Count;

                if (totalUnits <= 0) return;

                int maxTotalInfected = Math.Max(200, (int)(totalUnits * 0.2f));
                if (_totalInfected >= maxTotalInfected) return;

                int maxNewInfectionsThisYear = Math.Max(25, totalUnits / 400);
                int newInfections = 0;

                foreach (var unit in units)
                {
                    if (unit == null) continue;
                    if (newInfections >= maxNewInfectionsThisYear) break;
                    if (_totalInfected >= maxTotalInfected) break;

                    if (IsDemonFaction(unit)) continue;

                    string unitId = GetUnitId(unit);
                    if (string.IsNullOrEmpty(unitId)) continue;
                    if (_infectedSinceYear.ContainsKey(unitId)) continue;

                    if (!TryGetActorPosition2D(unit, out var pos)) continue;
                    if (!IsNearInfected(pos, infectedGrid, InfectionRadius)) continue;

                    if (UnityEngine.Random.value >= _infectionSpreadChance) continue;

                    TryAddTrait(unit, InfectedTraitId);

                    _infectedSinceYear[unitId] = currentYear;
                    _totalInfected++;
                    newInfections++;
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"DemonLord.{Id}", "Error spreading infection", ex);
            }
        }

        private string GetUnitId(Actor unit)
        {
            try
            {
                return unit?.data?.id.ToString() ?? "";
            }
            catch
            {
                return "";
            }
        }

        private static long GetGridKey(Vector2 pos, float cellSize)
        {
            int cx = Mathf.FloorToInt(pos.x / cellSize);
            int cy = Mathf.FloorToInt(pos.y / cellSize);
            return ((long)cx << 32) ^ (uint)cy;
        }

        private static bool IsNearInfected(Vector2 pos, Dictionary<long, List<Vector2>> grid, float radius)
        {
            if (grid == null || grid.Count == 0) return false;

            int cx = Mathf.FloorToInt(pos.x / radius);
            int cy = Mathf.FloorToInt(pos.y / radius);

            float r2 = radius * radius;
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    long key = ((long)(cx + dx) << 32) ^ (uint)(cy + dy);
                    if (!grid.TryGetValue(key, out var list) || list == null) continue;

                    for (int i = 0; i < list.Count; i++)
                    {
                        var p = list[i];
                        float ddx = pos.x - p.x;
                        float ddy = pos.y - p.y;
                        if (ddx * ddx + ddy * ddy <= r2)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private static bool IsDemonFaction(Actor unit)
        {
            if (unit == null) return false;
            try
            {
                return unit.hasTrait("dlm_demon_faction");
            }
            catch
            {
                return false;
            }
        }

        private static bool IsHeroUnit(Actor unit)
        {
            if (unit == null) return false;
            try
            {
                if (unit.hasTrait("hero")) return true;
                if (unit.hasTrait("legendary")) return true;
            }
            catch
            {
            }

            try
            {
                var data = unit.data;
                if (data != null)
                {
                    var t = data.GetType();
                    var field = t.GetField("isHero");
                    if (field != null && field.FieldType == typeof(bool))
                    {
                        return (bool)field.GetValue(data);
                    }
                    var prop = t.GetProperty("isHero");
                    if (prop != null && prop.PropertyType == typeof(bool))
                    {
                        return (bool)prop.GetValue(data, null);
                    }
                }
            }
            catch
            {
            }

            return false;
        }

        private void ProcessIncubation(int currentYear)
        {
            try
            {
                var units = World.world?.units;
                if (units == null) return;

                var toConvert = new List<Actor>();
                var toRemove = new List<string>();

                foreach (var unit in units)
                {
                    if (unit == null) continue;
                    
                    string unitId = GetUnitId(unit);
                    if (string.IsNullOrEmpty(unitId)) continue;

                    bool infected = _infectedSinceYear.TryGetValue(unitId, out var infectedSince);
                    if (!infected)
                    {
                        try
                        {
                            infected = unit.hasTrait(InfectedTraitId);
                        }
                        catch
                        {
                            infected = false;
                        }

                        if (infected)
                        {
                            infectedSince = currentYear;
                            _infectedSinceYear[unitId] = infectedSince;
                        }
                    }

                    if (!infected) continue;

                    if (IsDemonFaction(unit))
                    {
                        toRemove.Add(unitId);
                        continue;
                    }

                    if (IsHeroUnit(unit))
                    {
                        continue;
                    }

                    int yearsInfected = Math.Max(0, currentYear - infectedSince);
                    if (yearsInfected >= _incubationYears)
                    {
                        toConvert.Add(unit);
                        toRemove.Add(unitId);
                        continue;
                    }
                    
                    float baseHealth = unit.data != null ? unit.data.health : 0f;
                    if (baseHealth > 0f)
                    {
                        float damage = baseHealth * 0.03f;
                        unit.getHit(damage, true, (AttackType)0, null, true, false, false);
                    }
                    
                    if (unit.data.health <= 0)
                    {
                        RecordKill();
                        try
                        {
                            if (TryGetActorPosition2D(unit, out var pos))
                            {
                                TryAddOrMergeFogZone(pos, FogRadius * 0.65f, currentYear);
                            }
                        }
                        catch
                        {
                        }
                        toRemove.Add(unitId);
                    }
                }

                for (int i = 0; i < toConvert.Count; i++)
                {
                    ConvertToPlagueThrall(toConvert[i]);
                }

                for (int i = 0; i < toRemove.Count; i++)
                {
                    _infectedSinceYear.Remove(toRemove[i]);
                }

                _totalInfected = _infectedSinceYear.Count;
            }
            catch (Exception ex)
            {
                Logger.Error($"DemonLord.{Id}", "Error processing incubation", ex);
            }
        }

        private void ConvertToPlagueThrall(Actor unit)
        {
            if (unit == null) return;

            TryRemoveTrait(unit, InfectedTraitId);
            TryAddTrait(unit, "dlm_demon_faction");
            TryAddTrait(unit, "evil");
            TryAddTrait(unit, "madness");

            try
            {
                LegionActorRegistry.TryApplyLegionActorAsset(unit);
            }
            catch
            {
            }

            _convertedSinceLastPlagueLord++;
        }

        private void TriggerGlobalPlague()
        {
            Logger.Info($"DemonLord.{Id}", "Global plague outbreak triggered!");

            int currentYear = CycleManager.Instance?.State?.WorldAgeYears ?? 0;
            int cooldown = Math.Max(10, _incubationYears);
            if (_lastPlagueYear != int.MinValue && currentYear - _lastPlagueYear < cooldown)
            {
                Logger.Warn($"DemonLord.{Id}", $"Global plague on cooldown ({cooldown}y)");
                return;
            }
            _lastPlagueYear = currentYear;
            
            try
            {
                var cities = World.world?.cities;
                if (cities == null) return;

                City targetCity = null;
                int seen = 0;
                foreach (var c in cities)
                {
                    seen++;
                    if (UnityEngine.Random.Range(0, seen) == 0)
                    {
                        targetCity = c;
                    }
                }
                if (seen == 0) return;
                
                if (targetCity != null)
                {
                    Logger.Info($"DemonLord.{Id}", $"Plague outbreak at {targetCity.data.name}");
                    InfectCity(targetCity, currentYear);
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"DemonLord.{Id}", "Error triggering global plague", ex);
            }
        }

        private void InfectCity(City city, int currentYear)
        {
            if (city?.units == null) return;

            int cityId = GetCityId(city);
            int cityCooldown = Math.Max(10, _incubationYears);
            if (cityId != 0)
            {
                if (_cityLastOutbreakYear.TryGetValue(cityId, out var lastYear))
                {
                    if (currentYear - lastYear < cityCooldown)
                    {
                        return;
                    }
                }
                _cityLastOutbreakYear[cityId] = currentYear;
            }

            TryCreateFogAtCity(city, currentYear);

            int maxNew = 250;
            int added = 0;
            
            foreach (var unit in city.units)
            {
                if (unit == null) continue;
                if (added >= maxNew) break;
                if (IsDemonFaction(unit)) continue;
                
                string unitId = GetUnitId(unit);
                if (string.IsNullOrEmpty(unitId)) continue;

                if (_infectedSinceYear.ContainsKey(unitId)) continue;
                
                if (UnityEngine.Random.value < 0.5f)
                {
                    TryAddTrait(unit, InfectedTraitId);

                    _infectedSinceYear[unitId] = currentYear;
                    _totalInfected++;
                    added++;
                }
            }
        }

        private void TryCreateFogAtCity(City city, int currentYear)
        {
            if (city == null) return;
            if (_toxicFogZones.Count >= MaxFogZones) return;

            Vector2 pos = Vector2.zero;
            bool hasPos = false;

            try
            {
                if (city.units != null)
                {
                    foreach (var u in city.units)
                    {
                        if (u == null) continue;
                        if (TryGetActorPosition2D(u, out pos))
                        {
                            hasPos = true;
                            break;
                        }
                    }
                }
            }
            catch
            {
                hasPos = false;
            }

            if (!hasPos) return;

            TryAddOrMergeFogZone(pos, FogRadius, currentYear);
        }

        private void UpdateToxicFog(int currentYear)
        {
            if (_toxicFogZones.Count == 0) return;

            for (int i = _toxicFogZones.Count - 1; i >= 0; i--)
            {
                if (_toxicFogZones[i].ExpireYear <= currentYear)
                {
                    _toxicFogZones.RemoveAt(i);
                }
            }

            if (_toxicFogZones.Count == 0) return;

            var units = World.world?.units;
            if (units == null) return;

            var deadPositions = new List<Vector2>();

            for (int z = 0; z < _toxicFogZones.Count; z++)
            {
                var zone = _toxicFogZones[z];
                float r2 = zone.Radius * zone.Radius;

                foreach (var u in units)
                {
                    if (u == null) continue;
                    if (IsDemonFaction(u)) continue;

                    if (!TryGetActorPosition2D(u, out var pos)) continue;
                    float dx = pos.x - zone.Center.x;
                    float dy = pos.y - zone.Center.y;
                    if (dx * dx + dy * dy > r2) continue;

                    float hp = u.data?.health ?? 0f;
                    if (hp <= 0f) continue;

                    float damage = hp * 0.02f;
                    u.getHit(damage, true, (AttackType)0, null, true, false, false);

                    if (u.data.health <= 0)
                    {
                        RecordKill();
                        deadPositions.Add(pos);
                    }
                }
            }

            for (int i = 0; i < deadPositions.Count; i++)
            {
                TryAddOrMergeFogZone(deadPositions[i], FogRadius * 0.65f, currentYear);
            }
        }

        private void CheckPlagueLordSummon(int currentYear)
        {
            if (_convertedSinceLastPlagueLord < _plagueLordSummonThreshold) return;
            if (currentYear == _lastPlagueLordYear) return;

            _lastPlagueLordYear = currentYear;

            int times = Math.Max(1, _convertedSinceLastPlagueLord / Math.Max(1, _plagueLordSummonThreshold));
            times = Math.Min(times, 1);

            for (int i = 0; i < times; i++)
            {
                SummonPlagueLord();
            }

            _convertedSinceLastPlagueLord = Math.Max(0, _convertedSinceLastPlagueLord - _plagueLordSummonThreshold * times);
        }

        private void SummonPlagueLord()
        {
            Logger.Info($"DemonLord.{Id}", "Plague Lord summoned from the accumulated suffering!");

            try
            {
                EnsureSpawnApiResolved();
                if (_spawnApiMethod == null || _spawnApiTarget == null)
                {
                    Logger.Warn($"DemonLord.{Id}", "Plague Lord summon failed: spawn API not resolved");
                    return;
                }

                object tile = TryPickSpawnTileNearDemon();

                var candidates = new[] { LegionActorRegistry.LegionActorId, "unit_human", "unit_orc" };
                Actor spawned = null;
                for (int i = 0; i < candidates.Length; i++)
                {
                    if (TrySpawnActor(candidates[i], tile, out spawned) && spawned != null)
                    {
                        break;
                    }
                }

                if (spawned == null)
                {
                    Logger.Warn($"DemonLord.{Id}", "Plague Lord summon failed: could not spawn actor");
                    return;
                }

                TryAddTrait(spawned, "dlm_demon_faction");
                TryAddTrait(spawned, "evil");
                TryAddTrait(spawned, "madness");
                TryAddTrait(spawned, "plague_lord");

                try
                {
                    LegionActorRegistry.TryApplyLegionActorAsset(spawned);
                }
                catch
                {
                }

                float targetHealth = Math.Max(2000f, Stats.MaxHealth * 0.05f);
                TryBoostActorHealth(spawned, targetHealth);
            }
            catch (Exception ex)
            {
                Logger.Error($"DemonLord.{Id}", "Error summoning plague lord", ex);
            }
        }

        private void ApplyMutations(int currentYear)
        {
            try
            {
                var units = World.world?.units;
                if (units == null) return;

                int totalUnits = 0;
                foreach (var u in units) { if (u != null) totalUnits++; }

                int maxTotalMutations = Math.Max(30, totalUnits / 900);
                if (_totalMutations >= maxTotalMutations) return;

                var traits = new[] { "strong", "fast", "regeneration", "lucky" };

                int attempts = 0;
                foreach (var unit in units)
                {
                    if (_totalMutations >= maxTotalMutations) break;
                    if (attempts++ > 2000) break;

                    if (unit == null) continue;
                    if (IsDemonFaction(unit)) continue;
                    if (IsHeroUnit(unit)) continue;

                    string unitId = GetUnitId(unit);
                    if (string.IsNullOrEmpty(unitId)) continue;
                    if (_mutatedUnits.Contains(unitId)) continue;

                    bool infected = _infectedSinceYear.ContainsKey(unitId);
                    if (!infected)
                    {
                        try { infected = unit.hasTrait(InfectedTraitId); } catch { infected = false; }
                    }
                    if (!infected) continue;

                    if (UnityEngine.Random.value >= MutationChancePerYear) continue;

                    string trait = traits[UnityEngine.Random.Range(0, traits.Length)];
                    TryAddTrait(unit, trait);
                    _mutatedUnits.Add(unitId);
                    _totalMutations++;
                }
            }
            catch
            {
            }
        }

        private void TryAddOrMergeFogZone(Vector2 center, float radius, int currentYear)
        {
            if (radius <= 1f) return;

            for (int i = _toxicFogZones.Count - 1; i >= 0; i--)
            {
                var z = _toxicFogZones[i];
                float dist = Vector2.Distance(center, z.Center);
                if (dist <= FogMergeDistance)
                {
                    Vector2 mergedCenter = (z.Center + center) * 0.5f;
                    float mergedRadius = Mathf.Max(z.Radius, radius);
                    int mergedExpire = Math.Max(z.ExpireYear, currentYear + Math.Max(1, _toxicFogDurationYears));

                    _toxicFogZones[i] = new ToxicFogZone
                    {
                        Center = mergedCenter,
                        Radius = mergedRadius,
                        ExpireYear = mergedExpire
                    };
                    return;
                }
            }

            if (_toxicFogZones.Count >= MaxFogZones)
            {
                int oldestIndex = -1;
                int oldestYear = int.MaxValue;
                for (int i = 0; i < _toxicFogZones.Count; i++)
                {
                    if (_toxicFogZones[i].ExpireYear < oldestYear)
                    {
                        oldestYear = _toxicFogZones[i].ExpireYear;
                        oldestIndex = i;
                    }
                }

                if (oldestIndex >= 0)
                {
                    var z = _toxicFogZones[oldestIndex];
                    Vector2 mergedCenter = (z.Center + center) * 0.5f;
                    float mergedRadius = Mathf.Max(z.Radius, radius);
                    int mergedExpire = Math.Max(z.ExpireYear, currentYear + Math.Max(1, _toxicFogDurationYears));

                    _toxicFogZones[oldestIndex] = new ToxicFogZone
                    {
                        Center = mergedCenter,
                        Radius = mergedRadius,
                        ExpireYear = mergedExpire
                    };
                }
                return;
            }

            _toxicFogZones.Add(new ToxicFogZone
            {
                Center = center,
                Radius = radius,
                ExpireYear = currentYear + Math.Max(1, _toxicFogDurationYears)
            });
        }

        private int GetCityId(City city)
        {
            try
            {
                if (city?.data == null) return 0;
                return city.data.id;
            }
            catch
            {
                return 0;
            }
        }

        private void EnsureSpawnApiResolved()
        {
            if (_spawnApiSearched) return;
            _spawnApiSearched = true;

            try
            {
                var world = World.world;
                if (world == null) return;

                var unitManager = world.units;
                if (unitManager != null && TryFindSpawnMethod(unitManager, out var m))
                {
                    _spawnApiTarget = unitManager;
                    _spawnApiMethod = m;
                    return;
                }

                if (TryFindSpawnMethod(world, out m))
                {
                    _spawnApiTarget = world;
                    _spawnApiMethod = m;
                }
            }
            catch
            {
            }
        }

        private bool TryFindSpawnMethod(object target, out MethodInfo method)
        {
            method = null;
            if (target == null) return false;

            try
            {
                var methods = target.GetType().GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                MethodInfo best = null;
                int bestScore = int.MinValue;
                foreach (var m in methods)
                {
                    if (m == null) continue;
                    var name = m.Name;
                    if (string.IsNullOrEmpty(name)) continue;

                    if (name.IndexOf("spawn", StringComparison.OrdinalIgnoreCase) < 0 &&
                        name.IndexOf("create", StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        continue;
                    }

                    var ps = m.GetParameters();
                    if (ps.Length < 1 || ps.Length > 6) continue;
                    if (ps[0].ParameterType != typeof(string)) continue;
                    if (m.ReturnType == null) continue;
                    if (!typeof(Actor).IsAssignableFrom(m.ReturnType)) continue;

                    int score = 0;
                    if (name.IndexOf("spawn", StringComparison.OrdinalIgnoreCase) >= 0) score += 3;
                    if (name.IndexOf("create", StringComparison.OrdinalIgnoreCase) >= 0) score += 1;
                    if (ps.Length == 2) score += 1;

                    bool hasTile = false;
                    for (int i = 0; i < ps.Length; i++)
                    {
                        var ptName = ps[i].ParameterType?.Name ?? "";
                        if (ptName.IndexOf("WorldTile", StringComparison.OrdinalIgnoreCase) >= 0 ||
                            ptName.IndexOf("Tile", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            hasTile = true;
                            break;
                        }
                    }
                    if (hasTile) score += 4;

                    if (score > bestScore)
                    {
                        bestScore = score;
                        best = m;
                    }
                }

                if (best != null)
                {
                    method = best;
                    return true;
                }
            }
            catch
            {
                method = null;
                return false;
            }

            return false;
        }

        private bool TrySpawnActor(string actorId, object tile, out Actor actor)
        {
            actor = null;
            if (string.IsNullOrEmpty(actorId)) return false;
            if (_spawnApiTarget == null || _spawnApiMethod == null) return false;

            try
            {
                var ps = _spawnApiMethod.GetParameters();
                var args = new object[ps.Length];

                for (int i = 0; i < ps.Length; i++)
                {
                    var pt = ps[i].ParameterType;
                    if (pt == typeof(string))
                    {
                        args[i] = actorId;
                        continue;
                    }

                    if (tile != null && pt.IsInstanceOfType(tile))
                    {
                        args[i] = tile;
                        continue;
                    }

                    if (pt == typeof(int))
                    {
                        args[i] = 0;
                        continue;
                    }

                    if (pt == typeof(float))
                    {
                        args[i] = 0f;
                        continue;
                    }

                    args[i] = null;
                }

                var result = _spawnApiMethod.Invoke(_spawnApiTarget, args);
                actor = result as Actor;
                return actor != null;
            }
            catch
            {
                actor = null;
                return false;
            }
        }

        private object TryPickSpawnTileNearDemon()
        {
            try
            {
                if (DemonActor != null)
                {
                    var tile = GetMemberValue(DemonActor, "currentTile")
                               ?? GetMemberValue(DemonActor, "tile")
                               ?? GetMemberValue(DemonActor, "current_tile");
                    if (tile != null) return tile;
                }

                var units = World.world?.units;
                if (units == null) return null;

                Actor selected = null;
                int seen = 0;
                foreach (var u in units)
                {
                    if (u == null) continue;
                    seen++;
                    if (UnityEngine.Random.Range(0, seen) == 0)
                    {
                        selected = u;
                    }
                }

                if (selected == null) return null;
                return GetMemberValue(selected, "currentTile")
                       ?? GetMemberValue(selected, "tile")
                       ?? GetMemberValue(selected, "current_tile");
            }
            catch
            {
                return null;
            }
        }

        private void TryBoostActorHealth(Actor actor, float targetHealth)
        {
            if (actor == null) return;
            if (targetHealth <= 0f) return;

            try
            {
                var data = GetMemberValue(actor, "data");
                if (data == null) return;

                var currentObj = GetMemberValue(data, "health");
                float current = 0f;
                try { current = Convert.ToSingle(currentObj); } catch { current = 0f; }
                if (current >= targetHealth) return;

                var t = data.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

                var field = t.GetField("health", flags);
                if (field != null)
                {
                    if (field.FieldType == typeof(float))
                    {
                        field.SetValue(data, targetHealth);
                        return;
                    }
                    if (field.FieldType == typeof(int))
                    {
                        field.SetValue(data, (int)targetHealth);
                        return;
                    }
                }

                var prop = t.GetProperty("health", flags);
                if (prop != null && prop.CanWrite)
                {
                    if (prop.PropertyType == typeof(float))
                    {
                        prop.SetValue(data, targetHealth, null);
                        return;
                    }
                    if (prop.PropertyType == typeof(int))
                    {
                        prop.SetValue(data, (int)targetHealth, null);
                    }
                }
            }
            catch
            {
            }
        }

        private static object GetMemberValue(object obj, string name)
        {
            if (obj == null || string.IsNullOrEmpty(name)) return null;

            try
            {
                var t = obj.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

                var field = t.GetField(name, flags);
                if (field != null) return field.GetValue(obj);

                var prop = t.GetProperty(name, flags);
                if (prop != null) return prop.GetValue(obj, null);

                var method = t.GetMethod(name, flags, null, Type.EmptyTypes, null);
                if (method != null) return method.Invoke(obj, null);

                return null;
            }
            catch
            {
                return null;
            }
        }

        private float CalculateDistance(WorldTile a, WorldTile b)
        {
            if (a == null || b == null) return float.MaxValue;
            
            float dx = a.x - b.x;
            float dy = a.y - b.y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        public override void OnCycleEvolution(int newCycleCount)
        {
            Logger.Info($"DemonLord.{Id}", $"Evolving for cycle {newCycleCount}");
            
            if (newCycleCount >= 2)
            {
                _infectionSpreadChance = Math.Min(0.6f, _infectionSpreadChance * 1.2f);
            }
            
            if (newCycleCount >= 3)
            {
                _incubationYears = Math.Max(2, _incubationYears - 1);
            }
        }

        protected override void ResetForNextCycle()
        {
            base.ResetForNextCycle();
            _infectedSinceYear.Clear();
            _totalInfected = 0;
            _lastPlagueYear = int.MinValue;
            _toxicFogZones.Clear();
            _mutatedUnits.Clear();
            _totalMutations = 0;
            _cityLastOutbreakYear.Clear();
            _convertedSinceLastPlagueLord = 0;
            _lastPlagueLordYear = int.MinValue;
        }

        private class ToxicFogZone
        {
            public Vector2 Center;
            public float Radius;
            public int ExpireYear;
        }
    }
}
