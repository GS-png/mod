using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.UI;
using Logger = EraOfWheel.Core.Logger;

namespace EraOfWheel.DemonLords
{
    public class VoidLord : BaseDemonLord
    {
        public override string Id => "void_lord";
        public override string Name => "虚无之主·伊格尔";
        public override string Title => "存在的终结者";
        public override string Description => "代表虚无概念的原初魔王，能够抹除万物的存在痕迹";
        public override int UnlockCycle => 1;

        private VoidLordConfig _config;
        private int _voidDomainRadius;
        private float _voidDomainDamagePercent;
        private int _worldContractionKillThreshold;
        private float _worldContractionPercent;
        private float _minHabitablePercent;
        
        private int _lastContractionKillCount = 0;
        private int _lastContractionTriggerYear = int.MinValue;

        public VoidLord()
        {
            Stats.BaseHealth = 100000f;
            Stats.BaseDamage = 1000f;
            Stats.BaseDefense = 500f;
            Stats.BaseSpeed = 12f;
            Stats.HealthGrowthPerCycle = 0.5f;
            Stats.DamageGrowthPerCycle = 0.33f;
        }

        public override void Initialize(int cycleCount)
        {
            base.Initialize(cycleCount);
            
            _config = ConfigManager.Instance?.Config?.demon_lords?.void_lord;
            if (_config != null)
            {
                ApplyConfigOverrides(_config.enabled, _config.unlock_cycle);
                _voidDomainRadius = _config.void_domain_radius;
                _voidDomainDamagePercent = _config.void_domain_damage_percent;
                _worldContractionKillThreshold = _config.world_contraction_kill_threshold;
                _worldContractionPercent = _config.world_contraction_percent;
                _minHabitablePercent = _config.min_habitable_percent;
            }
            else
            {
                _voidDomainRadius = 1000;
                _voidDomainDamagePercent = 1f;
                _worldContractionKillThreshold = 100;
                _worldContractionPercent = 5f;
                _minHabitablePercent = 40f;
            }
        }

        protected override void UpdateInvasion(int currentYear)
        {
            base.UpdateInvasion(currentYear);
            
            ApplyVoidDomain();
            CheckWorldContraction(currentYear);
        }

        public override void ApplyUniqueAbility()
        {
            ApplyVoidDomain();
        }

        private void ApplyVoidDomain()
        {
            if (DemonActor == null) return;
            
            try
            {
                var units = World.world?.units;
                if (units == null) return;

                Vector2 demonPos;
                if (!TryGetActorPosition2D(DemonActor, out demonPos)) return;

                foreach (var unit in units)
                {
                    if (unit == null || unit == DemonActor) continue;

                    bool isDemon = false;
                    try { isDemon = unit.hasTrait("dlm_demon_faction"); } catch { isDemon = false; }
                    if (isDemon) continue;

                    Vector2 unitPos;
                    if (!TryGetActorPosition2D(unit, out unitPos)) continue;

                    float distance = Vector2.Distance(demonPos, unitPos);
                    if (distance <= _voidDomainRadius)
                    {
                        float baseHealth = unit.data != null ? unit.data.health : 0f;
                        if (baseHealth <= 0f) continue;

                        float damage = baseHealth * (_voidDomainDamagePercent / 100f);
                        unit.getHit(damage, true, (AttackType)0, null, true, false, false);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"DemonLord.{Id}", $"Error applying void domain", ex);
            }
        }

        private void CheckWorldContraction(int currentYear)
        {
            if (currentYear == _lastContractionTriggerYear) return;

            int killsSinceLastContraction = TotalKills - _lastContractionKillCount;
            
            if (killsSinceLastContraction >= _worldContractionKillThreshold)
            {
                _lastContractionTriggerYear = currentYear;

                bool ok = TriggerWorldContraction();
                _lastContractionKillCount = TotalKills;

                if (!ok)
                {
                    NotificationSystem.Instance?.Show("世界收缩", "世界收缩触发，但未能找到可用的地形转换接口（已记录日志）", NotificationType.Warning);
                }
            }
        }

        private bool TriggerWorldContraction()
        {
            float percent = Mathf.Clamp(_worldContractionPercent, 0f, 100f);
            float minHabitable = Mathf.Clamp(_minHabitablePercent, 0f, 100f);

            if (percent <= 0f) return false;

            if (!TryCollectWorldTiles(out var allTiles) || allTiles == null || allTiles.Count == 0)
            {
                Logger.Warn($"DemonLord.{Id}", "World Contraction triggered but could not collect world tiles");
                return false;
            }

            int total = allTiles.Count;
            int habitable = 0;

            int minX = int.MaxValue;
            int minY = int.MaxValue;
            int maxX = int.MinValue;
            int maxY = int.MinValue;
            bool hasBounds = false;

            for (int i = 0; i < allTiles.Count; i++)
            {
                var t = allTiles[i];
                if (t == null) continue;

                if (TryGetTileXY(t, out var x, out var y))
                {
                    if (x < minX) minX = x;
                    if (y < minY) minY = y;
                    if (x > maxX) maxX = x;
                    if (y > maxY) maxY = y;
                    hasBounds = true;
                }

                if (IsTileHabitable(t)) habitable++;
            }

            int minHabitableCount = Mathf.CeilToInt(total * (minHabitable / 100f));
            int desired = Mathf.FloorToInt(total * (percent / 100f));
            int maxConvertible = Math.Max(0, habitable - minHabitableCount);
            int toConvert = Math.Min(desired, maxConvertible);

            Logger.Info($"DemonLord.{Id}", $"World Contraction: total={total}, habitable={habitable}, minHabitable={minHabitableCount}, desired={desired}, convert={toConvert}");

            if (toConvert <= 0)
            {
                Logger.Warn($"DemonLord.{Id}", "World Contraction blocked by min habitable percent");
                NotificationSystem.Instance?.Show("世界收缩", "世界收缩被最低可居住比例保护拦截（不会继续减少可用面积）", NotificationType.Info);
                return true;
            }

            var candidates = hasBounds
                ? CollectEdgeHabitableTiles(allTiles, minX, minY, maxX, maxY)
                : new List<object>();

            if (candidates.Count < toConvert)
            {
                candidates = CollectHabitableTiles(allTiles);
            }

            if (candidates.Count == 0)
            {
                Logger.Warn($"DemonLord.{Id}", "World Contraction: no candidate tiles");
                return false;
            }

            int converted = 0;
            int safety = Math.Min(candidates.Count, Math.Max(toConvert * 3, toConvert + 10));

            for (int i = 0; i < safety && converted < toConvert; i++)
            {
                int idx = UnityEngine.Random.Range(0, candidates.Count);
                var tile = candidates[idx];
                candidates.RemoveAt(idx);
                if (tile == null) continue;

                if (TryConvertTileToVoid(tile))
                {
                    converted++;
                }
            }

            if (converted <= 0)
            {
                Logger.Warn($"DemonLord.{Id}", "World Contraction attempted but no tiles were converted");
                return false;
            }

            NotificationSystem.Instance?.Show("世界收缩", $"虚无侵蚀了世界边缘（{converted}格）", NotificationType.Warning);
            return true;
        }

        private static List<object> CollectHabitableTiles(List<object> allTiles)
        {
            var list = new List<object>();
            if (allTiles == null) return list;

            for (int i = 0; i < allTiles.Count; i++)
            {
                var t = allTiles[i];
                if (t == null) continue;
                if (!IsTileHabitable(t)) continue;
                list.Add(t);
            }

            return list;
        }

        private static List<object> CollectEdgeHabitableTiles(List<object> allTiles, int minX, int minY, int maxX, int maxY)
        {
            var list = new List<object>();
            if (allTiles == null) return list;

            int width = maxX - minX + 1;
            int height = maxY - minY + 1;
            int edgeBand = Mathf.Clamp((int)(Math.Min(width, height) * 0.08f), 8, 60);

            for (int i = 0; i < allTiles.Count; i++)
            {
                var t = allTiles[i];
                if (t == null) continue;
                if (!IsTileHabitable(t)) continue;
                if (!TryGetTileXY(t, out var x, out var y)) continue;

                int d = Math.Min(Math.Min(x - minX, maxX - x), Math.Min(y - minY, maxY - y));
                if (d <= edgeBand)
                {
                    list.Add(t);
                }
            }

            return list;
        }

        private static bool TryCollectWorldTiles(out List<object> tiles)
        {
            tiles = new List<object>();
            var world = World.world;
            if (world == null) return false;

            object candidate = GetMemberValue(world, "tiles")
                               ?? GetMemberValue(world, "tilesList")
                               ?? GetMemberValue(world, "allTiles")
                               ?? GetMemberValue(world, "worldTiles")
                               ?? GetMemberValue(world, "map")
                               ?? GetMemberValue(world, "tileMap")
                               ?? GetMemberValue(world, "mapBox")
                               ?? GetMemberValue(world, "grid");

            if (candidate != null)
            {
                if (TryAddTilesFromCandidate(candidate, tiles) && tiles.Count > 0)
                {
                    return true;
                }

                var inner = GetMemberValue(candidate, "tiles")
                            ?? GetMemberValue(candidate, "tilesList")
                            ?? GetMemberValue(candidate, "allTiles")
                            ?? GetMemberValue(candidate, "worldTiles")
                            ?? GetMemberValue(candidate, "grid")
                            ?? GetMemberValue(candidate, "map");

                if (inner != null && TryAddTilesFromCandidate(inner, tiles) && tiles.Count > 0)
                {
                    return true;
                }
            }

            var units = World.world?.units;
            if (units != null)
            {
                var set = new HashSet<object>();
                foreach (var u in units)
                {
                    if (u == null) continue;
                    var tile = GetMemberValue(u, "currentTile") ?? GetMemberValue(u, "tile") ?? GetMemberValue(u, "current_tile");
                    if (tile == null) continue;
                    if (set.Add(tile)) tiles.Add(tile);
                }
            }

            return tiles.Count > 0;
        }

        private static bool TryAddTilesFromCandidate(object candidate, List<object> tiles)
        {
            if (candidate == null || tiles == null) return false;

            try
            {
                if (candidate is IEnumerable e)
                {
                    foreach (var item in e)
                    {
                        if (item != null) tiles.Add(item);
                    }
                    return tiles.Count > 0;
                }
            }
            catch
            {
                return false;
            }

            return false;
        }

        private static bool IsTileHabitable(object tile)
        {
            if (tile == null) return false;

            try
            {
                var biome = GetMemberValue(tile, "biome") ?? GetMemberValue(tile, "biomeType") ?? GetMemberValue(tile, "type") ?? GetMemberValue(tile, "tileType");
                if (biome != null)
                {
                    string s = biome.ToString() ?? "";
                    if (s.IndexOf("void", StringComparison.OrdinalIgnoreCase) >= 0) return false;
                    if (s.IndexOf("ocean", StringComparison.OrdinalIgnoreCase) >= 0) return false;
                    if (s.IndexOf("water", StringComparison.OrdinalIgnoreCase) >= 0) return false;
                    if (s.IndexOf("lava", StringComparison.OrdinalIgnoreCase) >= 0) return false;
                }

                var isVoid = GetMemberValue(tile, "isVoid") ?? GetMemberValue(tile, "void") ?? GetMemberValue(tile, "is_void");
                if (isVoid is bool b && b) return false;

                var isWater = GetMemberValue(tile, "isWater") ?? GetMemberValue(tile, "water") ?? GetMemberValue(tile, "is_water");
                if (isWater is bool bw && bw) return false;
            }
            catch
            {
            }

            return true;
        }

        private static bool TryConvertTileToVoid(object tile)
        {
            if (tile == null) return false;

            if (TryInvokeVoidMethod(tile)) return true;
            if (TrySetEnumMemberContaining(tile, "biome", "void")) return true;
            if (TrySetEnumMemberContaining(tile, "biomeType", "void")) return true;
            if (TrySetEnumMemberContaining(tile, "type", "void")) return true;
            if (TrySetEnumMemberContaining(tile, "tileType", "void")) return true;
            if (TrySetBoolMember(tile, "isVoid", true)) return true;
            if (TrySetBoolMember(tile, "void", true)) return true;

            return false;
        }

        private static bool TryInvokeVoidMethod(object tile)
        {
            try
            {
                var t = tile.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

                var methods = t.GetMethods(flags);
                for (int i = 0; i < methods.Length; i++)
                {
                    var m = methods[i];
                    if (m == null) continue;
                    var n = m.Name ?? "";
                    if (n.IndexOf("void", StringComparison.OrdinalIgnoreCase) < 0) continue;
                    if (n.IndexOf("set", StringComparison.OrdinalIgnoreCase) < 0 && n.IndexOf("make", StringComparison.OrdinalIgnoreCase) < 0 && n.IndexOf("convert", StringComparison.OrdinalIgnoreCase) < 0) continue;
                    if (m.GetParameters().Length != 0) continue;

                    m.Invoke(tile, null);
                    return true;
                }
            }
            catch
            {
            }

            return false;
        }

        private static bool TrySetEnumMemberContaining(object obj, string memberName, string enumNamePart)
        {
            if (obj == null || string.IsNullOrEmpty(memberName)) return false;

            try
            {
                var t = obj.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

                var field = t.GetField(memberName, flags);
                if (field != null && field.FieldType.IsEnum)
                {
                    var val = FindEnumValueContaining(field.FieldType, enumNamePart);
                    if (val != null)
                    {
                        field.SetValue(obj, val);
                        return true;
                    }
                }

                var prop = t.GetProperty(memberName, flags);
                if (prop != null && prop.CanWrite && prop.PropertyType.IsEnum)
                {
                    var val = FindEnumValueContaining(prop.PropertyType, enumNamePart);
                    if (val != null)
                    {
                        prop.SetValue(obj, val, null);
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }

            return false;
        }

        private static object FindEnumValueContaining(Type enumType, string namePart)
        {
            if (enumType == null || !enumType.IsEnum) return null;

            try
            {
                var names = Enum.GetNames(enumType);
                for (int i = 0; i < names.Length; i++)
                {
                    var n = names[i];
                    if (n != null && n.IndexOf(namePart, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        return Enum.Parse(enumType, n);
                    }
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        private static bool TrySetBoolMember(object obj, string memberName, bool value)
        {
            if (obj == null || string.IsNullOrEmpty(memberName)) return false;

            try
            {
                var t = obj.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

                var field = t.GetField(memberName, flags);
                if (field != null && field.FieldType == typeof(bool))
                {
                    field.SetValue(obj, value);
                    return true;
                }

                var prop = t.GetProperty(memberName, flags);
                if (prop != null && prop.CanWrite && prop.PropertyType == typeof(bool))
                {
                    prop.SetValue(obj, value, null);
                    return true;
                }
            }
            catch
            {
                return false;
            }

            return false;
        }

        private static bool TryGetTileXY(object tile, out int x, out int y)
        {
            x = 0;
            y = 0;
            if (tile == null) return false;

            try
            {
                var xObj = GetMemberValue(tile, "x");
                var yObj = GetMemberValue(tile, "y");
                if (xObj == null || yObj == null) return false;

                x = Convert.ToInt32(xObj);
                y = Convert.ToInt32(yObj);
                return true;
            }
            catch
            {
                x = 0;
                y = 0;
                return false;
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
                _voidDomainRadius = (int)(_voidDomainRadius * 1.1f);
            }
            
            if (newCycleCount >= 3)
            {
                _voidDomainDamagePercent *= 1.2f;
            }
        }

        protected override void ResetForNextCycle()
        {
            base.ResetForNextCycle();
            _lastContractionKillCount = 0;
            _lastContractionTriggerYear = int.MinValue;
        }
    }
}
