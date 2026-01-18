using System;
using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.Core.Events;
using EraOfWheel.Core.Data;
using ModSaveManager = EraOfWheel.Core.Data.SaveManager;

namespace EraOfWheel.Cycle
{
    public enum LegacyType
    {
        Military,
        Economic,
        Technology,
        Legendary,
        Curse
    }

    [Serializable]
    public class Legacy
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public LegacyType Type { get; set; }
        public float BonusValue { get; set; }
        public int StackCount { get; set; } = 1;
        public int AcquiredCycle { get; set; }
    }

    public class LegacySystem : IModSystem
    {
        public static LegacySystem Instance { get; private set; }
        
        public string SystemName => "LegacySystem";
        public bool IsInitialized { get; private set; }
        
        private Dictionary<string, Legacy> _militaryLegacies = new Dictionary<string, Legacy>();
        private Dictionary<string, Legacy> _economicLegacies = new Dictionary<string, Legacy>();
        private Dictionary<string, Legacy> _techLegacies = new Dictionary<string, Legacy>();
        private Dictionary<string, Legacy> _legendaryLegacies = new Dictionary<string, Legacy>();
        private Dictionary<string, Legacy> _curseLegacies = new Dictionary<string, Legacy>();
        
        private LegacyConfig _config;

        public float TotalMilitaryBonus { get; private set; } = 0f;
        public float TotalEconomicBonus { get; private set; } = 0f;
        public float TotalTechBonus { get; private set; } = 0f;

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            _config = ConfigManager.Instance?.Config?.legacy ?? new LegacyConfig();
            
            LoadLegacies();
            SubscribeToEvents();
            
            IsInitialized = true;
            Logger.Info(SystemName, "LegacySystem initialized");
        }

        private void LoadLegacies()
        {
            var saveData = ModSaveManager.Instance?.Data?.legacy;
            if (saveData == null) return;

            _militaryLegacies.Clear();
            _economicLegacies.Clear();
            _techLegacies.Clear();
            _legendaryLegacies.Clear();
            _curseLegacies.Clear();

            LoadLegacyArray(saveData.military_legacies, LegacyType.Military);
            LoadLegacyArray(saveData.economic_legacies, LegacyType.Economic);
            LoadLegacyArray(saveData.tech_legacies, LegacyType.Technology);
            LoadLegacyArray(saveData.legendary_legacies, LegacyType.Legendary);
            LoadLegacyArray(saveData.curse_legacies, LegacyType.Curse);

            RecalculateBonuses();
        }

        private void LoadLegacyArray(string[] ids, LegacyType type)
        {
            if (ids == null) return;

            int currentCycle = CycleManager.Instance?.State?.CycleCount ?? 1;
            foreach (var id in ids)
            {
                if (string.IsNullOrEmpty(id)) continue;

                var legacy = CreateLegacyFromId(type, id, currentCycle);
                if (legacy == null) continue;
                GrantLegacy(legacy);
            }
        }

        private void SubscribeToEvents()
        {
            EventBus.Instance?.Subscribe<CycleCompletedEvent>(OnCycleCompleted);
        }

        private void OnCycleCompleted(CycleCompletedEvent e)
        {
            if (!_config.enabled) return;
            
            GrantCycleLegacies(e.CycleCount, e.SealMethod);
        }

        private void GrantCycleLegacies(int cycleCount, string sealMethod)
        {
            // Grant military legacy
            for (int i = 0; i < _config.base_military_count; i++)
            {
                GrantLegacy(CreateRandomLegacy(LegacyType.Military, cycleCount));
            }
            
            // Grant economic legacy
            for (int i = 0; i < _config.base_economic_count; i++)
            {
                GrantLegacy(CreateRandomLegacy(LegacyType.Economic, cycleCount));
            }
            
            // Grant tech legacy if ritual seal
            if (sealMethod == "ritual")
            {
                for (int i = 0; i < _config.base_tech_count; i++)
                {
                    GrantLegacy(CreateRandomLegacy(LegacyType.Technology, cycleCount));
                }
            }
            
            // Chance for legendary
            if (UnityEngine.Random.value < _config.legendary_probability)
            {
                GrantLegacy(CreateRandomLegacy(LegacyType.Legendary, cycleCount));
            }
            
            // Check for curse
            if (_config.curse_enabled && ShouldGrantCurse())
            {
                GrantLegacy(CreateRandomLegacy(LegacyType.Curse, cycleCount));
            }
            
            RecalculateBonuses();
            PersistToSave();
            Logger.Info(SystemName, $"Legacies granted for cycle {cycleCount}");
        }

        private bool ShouldGrantCurse()
        {
            // Simplified: check if significant losses occurred
            return false;
        }

        private Legacy CreateRandomLegacy(LegacyType type, int cycleCount)
        {
            var legacy = new Legacy
            {
                Type = type,
                AcquiredCycle = cycleCount,
                StackCount = 1
            };

            switch (type)
            {
                case LegacyType.Military:
                    legacy.Id = "hero_proof";
                    legacy.Name = "英雄之证";
                    legacy.BonusValue = 10f;
                    break;
                case LegacyType.Economic:
                    legacy.Id = "post_war_prosperity";
                    legacy.Name = "战后繁荣";
                    legacy.BonusValue = 30f;
                    break;
                case LegacyType.Technology:
                    legacy.Id = "forbidden_knowledge";
                    legacy.Name = "禁忌知识";
                    legacy.BonusValue = 20f;
                    break;
                case LegacyType.Legendary:
                    legacy.Id = "demon_slayer_title";
                    legacy.Name = "屠魔者称号";
                    legacy.BonusValue = 50f;
                    break;
                case LegacyType.Curse:
                    legacy.Id = "demonic_taint";
                    legacy.Name = "魔气侵染";
                    legacy.BonusValue = -10f;
                    break;
            }

            return legacy;
        }

        private Legacy CreateLegacyFromId(LegacyType type, string id, int cycleCount)
        {
            if (string.IsNullOrEmpty(id)) return null;

            var legacy = new Legacy
            {
                Type = type,
                AcquiredCycle = cycleCount,
                StackCount = 1,
                Id = id
            };

            if (type == LegacyType.Military)
            {
                legacy.Name = id == "hero_proof" ? "英雄之证" : id;
                legacy.BonusValue = id == "hero_proof" ? 10f : 0f;
                return legacy;
            }
            if (type == LegacyType.Economic)
            {
                legacy.Name = id == "post_war_prosperity" ? "战后繁荣" : id;
                legacy.BonusValue = id == "post_war_prosperity" ? 30f : 0f;
                return legacy;
            }
            if (type == LegacyType.Technology)
            {
                legacy.Name = id == "forbidden_knowledge" ? "禁忌知识" : id;
                legacy.BonusValue = id == "forbidden_knowledge" ? 20f : 0f;
                return legacy;
            }
            if (type == LegacyType.Legendary)
            {
                legacy.Name = id == "demon_slayer_title" ? "屠魔者称号" : id;
                legacy.BonusValue = id == "demon_slayer_title" ? 50f : 0f;
                return legacy;
            }
            if (type == LegacyType.Curse)
            {
                legacy.Name = id == "demonic_taint" ? "魔气侵染" : id;
                legacy.BonusValue = id == "demonic_taint" ? -10f : 0f;
                return legacy;
            }

            return null;
        }

        private void GrantLegacy(Legacy legacy)
        {
            if (legacy == null) return;
            var dict = GetDictionaryForType(legacy.Type);
            
            if (dict.ContainsKey(legacy.Id))
            {
                // Stack with diminishing returns
                var existing = dict[legacy.Id];
                float diminish = 1f - (_config.stacking_diminish_rate * existing.StackCount);
                diminish = Math.Max(0.1f, diminish);
                
                existing.BonusValue += legacy.BonusValue * diminish;
                existing.StackCount++;
                
                Logger.Info(SystemName, $"Stacked legacy {legacy.Name} (x{existing.StackCount})");
            }
            else
            {
                dict[legacy.Id] = legacy;
                Logger.Info(SystemName, $"Granted new legacy: {legacy.Name}");
            }
        }

        private void PersistToSave()
        {
            var save = ModSaveManager.Instance?.Data;
            if (save == null) return;
            if (save.legacy == null) save.legacy = new LegacySaveData();

            save.legacy.military_legacies = ExpandIds(_militaryLegacies);
            save.legacy.economic_legacies = ExpandIds(_economicLegacies);
            save.legacy.tech_legacies = ExpandIds(_techLegacies);
            save.legacy.legendary_legacies = ExpandIds(_legendaryLegacies);
            save.legacy.curse_legacies = ExpandIds(_curseLegacies);
        }

        private static string[] ExpandIds(Dictionary<string, Legacy> dict)
        {
            if (dict == null || dict.Count == 0) return new string[0];

            var result = new List<string>();
            foreach (var kv in dict)
            {
                var legacy = kv.Value;
                if (legacy == null) continue;
                int count = Math.Max(1, legacy.StackCount);
                for (int i = 0; i < count; i++)
                {
                    result.Add(legacy.Id);
                }
            }
            return result.ToArray();
        }

        private Dictionary<string, Legacy> GetDictionaryForType(LegacyType type)
        {
            return type switch
            {
                LegacyType.Military => _militaryLegacies,
                LegacyType.Economic => _economicLegacies,
                LegacyType.Technology => _techLegacies,
                LegacyType.Legendary => _legendaryLegacies,
                LegacyType.Curse => _curseLegacies,
                _ => _militaryLegacies
            };
        }

        private void RecalculateBonuses()
        {
            TotalMilitaryBonus = CalculateTypeBonus(_militaryLegacies);
            TotalEconomicBonus = CalculateTypeBonus(_economicLegacies);
            TotalTechBonus = CalculateTypeBonus(_techLegacies);
            
            // Add legendary bonuses
            foreach (var legacy in _legendaryLegacies.Values)
            {
                TotalMilitaryBonus += legacy.BonusValue * 0.5f;
            }
            
            // Apply curses
            foreach (var curse in _curseLegacies.Values)
            {
                TotalMilitaryBonus += curse.BonusValue;
            }
            
            // Apply caps
            TotalMilitaryBonus = Math.Min(TotalMilitaryBonus, _config.max_bonus_percent);
            TotalEconomicBonus = Math.Min(TotalEconomicBonus, _config.max_bonus_percent);
            TotalTechBonus = Math.Min(TotalTechBonus, _config.max_bonus_percent);
        }

        private float CalculateTypeBonus(Dictionary<string, Legacy> legacies)
        {
            float total = 0f;
            foreach (var legacy in legacies.Values)
            {
                total += legacy.BonusValue;
            }
            return total;
        }

        public void ApplyRestartPenalty(float keepRatio)
        {
            ScaleLegacies(_militaryLegacies, keepRatio);
            ScaleLegacies(_economicLegacies, keepRatio);
            ScaleLegacies(_techLegacies, keepRatio);
            // Legendary legacies are preserved
            // Curses are removed on restart
            _curseLegacies.Clear();
            
            RecalculateBonuses();
            PersistToSave();
            Logger.Info(SystemName, $"Legacies scaled by {keepRatio * 100}% after restart");
        }

        private void ScaleLegacies(Dictionary<string, Legacy> legacies, float ratio)
        {
            foreach (var legacy in legacies.Values)
            {
                legacy.BonusValue *= ratio;
            }
        }

        public IEnumerable<Legacy> GetAllLegacies()
        {
            var all = new List<Legacy>();
            all.AddRange(_militaryLegacies.Values);
            all.AddRange(_economicLegacies.Values);
            all.AddRange(_techLegacies.Values);
            all.AddRange(_legendaryLegacies.Values);
            all.AddRange(_curseLegacies.Values);
            return all;
        }

        public void Dispose()
        {
            EventBus.Instance?.Unsubscribe<CycleCompletedEvent>(OnCycleCompleted);
            
            _militaryLegacies.Clear();
            _economicLegacies.Clear();
            _techLegacies.Clear();
            _legendaryLegacies.Clear();
            _curseLegacies.Clear();
            
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "LegacySystem disposed");
        }
    }
}
