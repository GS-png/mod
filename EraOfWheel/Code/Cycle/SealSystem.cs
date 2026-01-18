using System;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.Core.Events;
using EraOfWheel.Core.Data;
using EraOfWheel.DemonLords;
using ModSaveManager = EraOfWheel.Core.Data.SaveManager;

namespace EraOfWheel.Cycle
{
    public class SealSystem : IModSystem
    {
        public static SealSystem Instance { get; private set; }
        
        public string SystemName => "SealSystem";
        public bool IsInitialized { get; private set; }
        
        public float RitualProgress { get; private set; } = 0f;
        public bool SealWarWindowActive { get; private set; } = false;
        
        private SealConfig _config;
        private int _failureStartYear = -1;
        private bool _executionAchieved = false;
        private bool _ritualAchieved = false;
        private int _lastRitualUpdateYear = -1;

        private SealSite _primarySite;
        private readonly System.Collections.Generic.List<SealSite> _subSites = new System.Collections.Generic.List<SealSite>();

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            _config = ConfigManager.Instance?.Config?.seal ?? new SealConfig();

            LoadFromSave();
            
            SubscribeToEvents();
            
            IsInitialized = true;
            Logger.Info(SystemName, "SealSystem initialized");
        }

        private void LoadFromSave()
        {
            var save = ModSaveManager.Instance?.Data;
            if (save == null) return;

            SealWarWindowActive = save.seal_war_active;
            RitualProgress = Math.Max(0f, save.ritual_progress);

            _executionAchieved = false;
            _ritualAchieved = false;

            if (_config?.victory_conditions?.ritual == true)
            {
                if (RitualProgress >= _config.victory_conditions.ritual_progress_required)
                {
                    _ritualAchieved = true;
                }
            }
        }

        private void SubscribeToEvents()
        {
            EventBus.Instance?.Subscribe<DemonStateChangedEvent>(OnDemonStateChanged);
            EventBus.Instance?.Subscribe<PhaseChangedEvent>(OnPhaseChanged);
        }

        private void OnDemonStateChanged(DemonStateChangedEvent e)
        {
            if (e.CurrentState == DemonState.Weakening.ToString())
            {
                ActivateSealWarWindow();
            }
        }

        private void OnPhaseChanged(PhaseChangedEvent e)
        {
            if (e.CurrentPhase == CyclePhase.Resealed.ToString())
            {
                DeactivateSealWarWindow();
            }
        }

        public void Update(int currentYear)
        {
            if (!IsInitialized) return;
            
            var phase = CycleManager.Instance?.State?.CurrentPhase;
            if (phase == null) return;
            
            if (phase == CyclePhase.Invasion || phase == CyclePhase.Peak)
            {
                CheckFailureConditions(currentYear);
                CheckInvasionTimeout(currentYear);
            }

            CheckExecutionCondition();
            
            if (SealWarWindowActive)
            {
                UpdateRitualProgress(currentYear);
            }

            ModSaveManager.Instance?.UpdateSealSystemData(SealWarWindowActive, RitualProgress);
        }

        private void CheckExecutionCondition()
        {
            if (_config == null || !_config.victory_conditions.execution) return;

            var demon = DemonLordManager.Instance?.ActiveDemonLord;
            if (demon == null) return;

            if (demon.Stats.IsDead)
            {
                _executionAchieved = true;
                if (!SealWarWindowActive)
                {
                    ActivateSealWarWindow();
                }
                EvaluateVictory();
            }
        }

        private void CheckInvasionTimeout(int currentYear)
        {
            var invasionYears = CycleManager.Instance?.State?.YearsInInvasion ?? 0;
            if (invasionYears >= _config.invasion_window_years.max)
            {
                Logger.Warn(SystemName, "Invasion timeout - forcing seal war window");
                ActivateSealWarWindow();
            }
        }

        private void ActivateSealWarWindow()
        {
            if (SealWarWindowActive) return;
            
            SealWarWindowActive = true;
            if (!_ritualAchieved)
            {
                RitualProgress = 0f;
            }
            _lastRitualUpdateYear = -1;

            SpawnSealSites();
            
            Logger.Info(SystemName, "Seal War Window activated!");
        }

        private void DeactivateSealWarWindow()
        {
            SealWarWindowActive = false;
            RitualProgress = 0f;
            _failureStartYear = -1;
            _executionAchieved = false;
            _ritualAchieved = false;
            _lastRitualUpdateYear = -1;

            _primarySite = null;
            _subSites.Clear();
        }

        private void UpdateRitualProgress(int currentYear)
        {
            if (!_config.victory_conditions.ritual) return;

            if (_primarySite == null)
            {
                SpawnSealSites();
            }
            
            if (_lastRitualUpdateYear < 0)
            {
                _lastRitualUpdateYear = currentYear;
                return;
            }

            int deltaYears = Math.Max(0, currentYear - _lastRitualUpdateYear);
            if (deltaYears <= 0) return;

            int required = _config.victory_conditions.ritual_progress_required;

            const float progressPerYear = 1f;
            const float decayPerYear = 0.5f;

            bool controlled = IsSiteControlledByMortals(_primarySite);
            if (controlled)
            {
                RitualProgress = Math.Min(required, RitualProgress + deltaYears * progressPerYear);
            }
            else
            {
                RitualProgress = Math.Max(0f, RitualProgress - deltaYears * decayPerYear);
            }
            _lastRitualUpdateYear = currentYear;

            if (RitualProgress >= required)
            {
                _ritualAchieved = true;
                EvaluateVictory();
            }
        }

        private void SpawnSealSites()
        {
            _primarySite = new SealSite
            {
                Radius = 120f
            };

            if (!TryResolveDemonPosition(out var demonPos))
            {
                demonPos = UnityEngine.Vector2.zero;
            }

            _primarySite.Position = demonPos;
            _primarySite.IsSpawned = true;
        }

        private bool IsSiteControlledByMortals(SealSite site)
        {
            if (site == null || !site.IsSpawned) return false;

            try
            {
                var units = World.world?.units;
                if (units == null) return false;

                int mortal = 0;
                int demon = 0;
                foreach (var u in units)
                {
                    if (u == null) continue;
                    if (!TryGetActorPosition2D(u, out var pos)) continue;
                    if (UnityEngine.Vector2.Distance(pos, site.Position) > site.Radius) continue;

                    bool isDemon = false;
                    try
                    {
                        isDemon = u.hasTrait("dlm_demon_faction");
                    }
                    catch
                    {
                    }

                    if (isDemon) demon++; else mortal++;

                    if (mortal >= 40 && mortal >= demon + 10)
                    {
                        return true;
                    }
                }

                return mortal > demon;
            }
            catch
            {
                return false;
            }
        }

        private bool TryResolveDemonPosition(out UnityEngine.Vector2 pos)
        {
            pos = default(UnityEngine.Vector2);

            try
            {
                var demon = DemonLordManager.Instance?.ActiveDemonLord;
                if (demon == null) return false;

                demon.EnsureActorSpawned();
                if (!TryGetDemonActor(demon, out var actor) || actor == null) return false;
                return TryGetActorPosition2D(actor, out pos);
            }
            catch
            {
                return false;
            }
        }

        private static bool TryGetDemonActor(BaseDemonLord demon, out Actor actor)
        {
            actor = null;
            if (demon == null) return false;

            try
            {
                var t = demon.GetType();
                const System.Reflection.BindingFlags flags = System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance;

                var prop = t.GetProperty("DemonActor", flags);
                if (prop != null)
                {
                    actor = prop.GetValue(demon, null) as Actor;
                    if (actor != null) return true;
                }

                var field = t.GetField("DemonActor", flags);
                if (field != null)
                {
                    actor = field.GetValue(demon) as Actor;
                    if (actor != null) return true;
                }

                field = t.GetField("<DemonActor>k__BackingField", flags);
                if (field != null)
                {
                    actor = field.GetValue(demon) as Actor;
                    if (actor != null) return true;
                }
            }
            catch
            {
            }

            return actor != null;
        }

        private static bool TryGetActorPosition2D(Actor actor, out UnityEngine.Vector2 pos)
        {
            pos = default(UnityEngine.Vector2);
            if (actor == null) return false;

            object posObj = GetMemberValue(actor, "currentPosition")
                           ?? GetMemberValue(actor, "position")
                           ?? GetMemberValue(actor, "pos");
            if (TryConvertToVector2(posObj, out pos)) return true;

            object tileObj = GetMemberValue(actor, "currentTile")
                            ?? GetMemberValue(actor, "tile")
                            ?? GetMemberValue(actor, "current_tile");

            if (tileObj != null)
            {
                var xObj = GetMemberValue(tileObj, "x");
                var yObj = GetMemberValue(tileObj, "y");
                if (xObj != null && yObj != null)
                {
                    try
                    {
                        pos = new UnityEngine.Vector2(Convert.ToSingle(xObj), Convert.ToSingle(yObj));
                        return true;
                    }
                    catch
                    {
                    }
                }
            }

            return false;
        }

        private static bool TryConvertToVector2(object value, out UnityEngine.Vector2 pos)
        {
            pos = default(UnityEngine.Vector2);
            if (value == null) return false;

            try
            {
                if (value is UnityEngine.Vector2 v2)
                {
                    pos = v2;
                    return true;
                }

                if (value is UnityEngine.Vector3 v3)
                {
                    pos = new UnityEngine.Vector2(v3.x, v3.y);
                    return true;
                }

                if (value is UnityEngine.Vector2Int v2i)
                {
                    pos = new UnityEngine.Vector2(v2i.x, v2i.y);
                    return true;
                }

                if (value is UnityEngine.Vector3Int v3i)
                {
                    pos = new UnityEngine.Vector2(v3i.x, v3i.y);
                    return true;
                }
            }
            catch
            {
            }

            return false;
        }

        private static object GetMemberValue(object obj, string name)
        {
            if (obj == null || string.IsNullOrEmpty(name)) return null;

            try
            {
                var t = obj.GetType();
                const System.Reflection.BindingFlags flags = System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static;

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

        private class SealSite
        {
            public UnityEngine.Vector2 Position;
            public float Radius;
            public bool IsSpawned;
        }

        private void EvaluateVictory()
        {
            if (_config == null) return;

            bool executionEnabled = _config.victory_conditions.execution;
            bool ritualEnabled = _config.victory_conditions.ritual;

            if (!executionEnabled && !ritualEnabled)
            {
                return;
            }

            string mode = (_config.victory_conditions.mode ?? "ANY").ToUpperInvariant();
            bool win;
            if (mode == "ALL")
            {
                win = (!executionEnabled || _executionAchieved) && (!ritualEnabled || _ritualAchieved);
            }
            else
            {
                win = (executionEnabled && _executionAchieved) || (ritualEnabled && _ritualAchieved);
            }

            if (!win) return;

            string method = _ritualAchieved ? "ritual" : "execution";
            CompleteSeal(method);
        }

        private void CheckFailureConditions(int currentYear)
        {
            if (!CanCheckFailure()) return;
            
            float controlledRatio = CalculateDemonControlRatio();
            
            if (controlledRatio >= _config.failure_conditions.cities_controlled_ratio)
            {
                if (_failureStartYear < 0)
                {
                    _failureStartYear = currentYear;
                }
                else if (currentYear - _failureStartYear >= _config.failure_conditions.cities_controlled_duration_years)
                {
                    TriggerFailure("Demon controls too many cities");
                }
            }
            else
            {
                _failureStartYear = -1;
            }
            
            int aliveKingdoms = CountAliveKingdoms();
            if (aliveKingdoms <= _config.failure_conditions.min_kingdoms)
            {
                TriggerFailure("Too few kingdoms remain");
            }
        }

        private bool CanCheckFailure()
        {
            var phase = CycleManager.Instance?.State?.CurrentPhase;
            return phase == CyclePhase.Invasion || phase == CyclePhase.Peak;
        }

        private float CalculateDemonControlRatio()
        {
            try
            {
                var cities = World.world?.cities;
                if (cities == null) return 0f;
                
                int demonCities = 0;
                int totalCities = 0;
                foreach (var city in cities)
                {
                    totalCities++;
                    var kingdomId = city?.kingdom?.data?.id.ToString() ?? "";
                    if (kingdomId.Contains("demon"))
                    {
                        demonCities++;
                    }
                }
                
                return totalCities > 0 ? (float)demonCities / totalCities : 0f;
            }
            catch
            {
                return 0f;
            }
        }

        private int CountAliveKingdoms()
        {
            try
            {
                var kingdoms = World.world?.kingdoms;
                if (kingdoms == null) return 0;
                
                int count = 0;
                foreach (var kingdom in kingdoms)
                {
                    var kingdomId = kingdom?.data?.id.ToString() ?? "";
                    int cityCount = 0;
                    if (kingdom?.cities != null)
                    {
                        foreach (var c in kingdom.cities) cityCount++;
                    }
                    if (cityCount > 0 && !kingdomId.Contains("demon"))
                    {
                        count++;
                    }
                }
                return count;
            }
            catch
            {
                return 1;
            }
        }

        public void TriggerExecutionSeal()
        {
            if (!_config.victory_conditions.execution)
            {
                Logger.Warn(SystemName, "Execution seal not enabled");
                return;
            }
            
            var demon = DemonLordManager.Instance?.ActiveDemonLord;
            if (demon == null || !demon.Stats.IsDead)
            {
                Logger.Warn(SystemName, "Demon lord not defeated");
                return;
            }

            _executionAchieved = true;
            EvaluateVictory();
        }

        private void CompleteSeal(string method)
        {
            Logger.Info(SystemName, $"Seal completed via {method}!");

            CycleManager.Instance?.SetPendingSealMethod(method);
            DemonLordManager.Instance?.SealActiveDemonLord(method);
            
            DeactivateSealWarWindow();
        }

        private void TriggerFailure(string reason)
        {
            Logger.Warn(SystemName, $"Failure condition met: {reason}");
            
            if (_config.restart_cycle.enabled)
            {
                ForceRestart();
            }
            else
            {
                Logger.Error(SystemName, "No recovery option available - Terminal Aftermath");
            }
        }

        private void OfferCycleRestart()
        {
            Logger.Info(SystemName, "Offering cycle restart option");
            // Note: Full implementation would show UI dialog
        }

        public void ForceRestart()
        {
            CycleManager.Instance?.ForceRestartCycle();
            DemonLordManager.Instance?.ForceResetAllDemonsToSealed();
            DeactivateSealWarWindow();
        }

        public void AddRitualProgress(float amount)
        {
            if (!SealWarWindowActive) return;
            
            RitualProgress = Math.Min(
                _config.victory_conditions.ritual_progress_required,
                RitualProgress + amount
            );

            if (_config != null && _config.victory_conditions.ritual)
            {
                if (RitualProgress >= _config.victory_conditions.ritual_progress_required)
                {
                    _ritualAchieved = true;
                    EvaluateVictory();
                }
            }
        }

        public void Dispose()
        {
            EventBus.Instance?.Unsubscribe<DemonStateChangedEvent>(OnDemonStateChanged);
            EventBus.Instance?.Unsubscribe<PhaseChangedEvent>(OnPhaseChanged);
            
            DeactivateSealWarWindow();
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "SealSystem disposed");
        }
    }
}
