using System;
using System.Collections.Generic;
using UnityEngine;
using NeoModLoader.api;
using NeoModLoader.services;
using EraOfWheel.Core.Config;
using EraOfWheel.Core.Data;
using System.Reflection;
using EraOfWheel.Cycle;
using ModSaveManager = EraOfWheel.Core.Data.SaveManager;
using EraOfWheel.DemonLords;
using EraOfWheel.DemonLords.Legion;
using EraOfWheel.UI;
using EraOfWheel.UI.Panels;

namespace EraOfWheel.Core
{
    public class ModMain : MonoBehaviour, IMod
    {
        public static ModMain Instance { get; private set; }
        
        private const string ModVersion = "0.1.0";
        private const string ModName = "Era of Wheel";
        
        private ModDeclare _declare;
        private GameObject _gameObject;
        private List<IModSystem> _systems = new List<IModSystem>();
        private bool _isInitialized = false;
        private int _lastWorldYear = -1;

        public ModDeclare GetDeclaration() => _declare;
        public GameObject GetGameObject() => _gameObject;
        public string GetUrl() => "https://github.com/EraOfWheel/WorldBoxMod";

        public void OnLoad(ModDeclare pModDecl, GameObject pGameObject)
        {
            Instance = this;
            _declare = pModDecl;
            _gameObject = pGameObject;
            
            LogService.LogInfo($"[{ModName}]: v{ModVersion} loading...");
            
            try
            {
                InitializeSystems();
                _isInitialized = true;
                LogService.LogInfo($"[{ModName}]: v{ModVersion} initialized successfully!");
            }
            catch (Exception ex)
            {
                LogService.LogError($"[{ModName}]: Failed to initialize - {ex.Message}");
                _isInitialized = false;
            }
        }

        private void InitializeSystems()
        {
            // Order matters - dependencies first
            RegisterSystem(new EventBus());
            RegisterSystem(new ConfigManager());
            RegisterSystem(new ModSaveManager());
            RegisterSystem(new CycleManager());
            RegisterSystem(new DemonLordManager());
            RegisterSystem(new LegionManager());
            RegisterSystem(new SealSystem());
            RegisterSystem(new LegacySystem());
            RegisterSystem(new NotificationSystem());
            RegisterSystem(new OverviewPanel());
            RegisterSystem(new DemonPanel());
            RegisterSystem(new UIManager());
            
            foreach (var system in _systems)
            {
                try
                {
                    system.Initialize();
                }
                catch (Exception ex)
                {
                    Logger.Error("ModMain", $"Failed to initialize {system.SystemName}", ex);
                }
            }
            
            // Load save after all systems initialized
            ModSaveManager.Instance?.LoadFromWorld();
        }

        private void RegisterSystem(IModSystem system)
        {
            _systems.Add(system);
        }

        private void Update()
        {
            if (!_isInitialized) return;
            
            try
            {
                int currentYear = GetCurrentWorldYear();
                
                // Year-based updates
                if (currentYear != _lastWorldYear)
                {
                    _lastWorldYear = currentYear;
                    OnYearChanged(currentYear);
                }
                
                // Frame updates
                EventBus.Instance?.ProcessQueue();
                UIManager.Instance?.Update();
                NotificationSystem.Instance?.Update(Time.deltaTime);
            }
            catch (Exception ex)
            {
                Logger.Error("ModMain", "Error in Update", ex);
            }
        }

        private int GetCurrentWorldYear()
        {
            try
            {
                var worldObj = World.world;
                if (worldObj == null) return 0;

                int year;
                if (TryReadYear(worldObj, out year)) return year;

                var mapStatsObj = GetMemberValue(worldObj, "mapStats");
                if (TryReadYear(mapStatsObj, out year)) return year;

                var worldLawsObj = GetMemberValue(worldObj, "worldLaws");
                if (TryReadYear(worldLawsObj, out year)) return year;

                var eraObj = GetMemberValue(worldLawsObj, "world_era") ?? GetMemberValue(worldLawsObj, "worldEra");
                if (TryReadYear(eraObj, out year)) return year;

                return 0;
            }
            catch
            {
                return 0;
            }
        }

        private static bool TryReadYear(object obj, out int year)
        {
            year = 0;
            if (obj == null) return false;

            var value = GetMemberValue(obj, "year") ?? GetMemberValue(obj, "years") ?? GetMemberValue(obj, "current_year");
            if (value == null) return false;

            try
            {
                year = Convert.ToInt32(value);
                return true;
            }
            catch
            {
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

        private void OnYearChanged(int currentYear)
        {
            CycleManager.Instance?.Update(currentYear);
            DemonLordManager.Instance?.Update(currentYear);
            LegionManager.Instance?.Update(currentYear);
            SealSystem.Instance?.Update(currentYear);
        }

        private void OnDestroy()
        {
            Shutdown();
        }

        private void OnApplicationQuit()
        {
            Shutdown();
        }

        private void Shutdown()
        {
            if (!_isInitialized) return;
            
            Logger.Info("ModMain", "Shutting down...");
            
            // Dispose in reverse order
            for (int i = _systems.Count - 1; i >= 0; i--)
            {
                try
                {
                    _systems[i].Dispose();
                }
                catch (Exception ex)
                {
                    Logger.Error("ModMain", $"Error disposing {_systems[i].SystemName}", ex);
                }
            }
            
            _systems.Clear();
            _isInitialized = false;
            Instance = null;
            
            Logger.Info("ModMain", "Shutdown complete");
        }

        // Public API for debugging
        public void ForceNextPhase()
        {
            var currentPhase = CycleManager.Instance?.State?.CurrentPhase;
            if (currentPhase == null) return;
            
            CyclePhase nextPhase = currentPhase.Value switch
            {
                CyclePhase.Sealed => CyclePhase.Omen,
                CyclePhase.Omen => CyclePhase.Awakening,
                CyclePhase.Awakening => CyclePhase.Invasion,
                CyclePhase.Invasion => CyclePhase.Weakening,
                CyclePhase.Peak => CyclePhase.Weakening,
                CyclePhase.Weakening => CyclePhase.Resealed,
                CyclePhase.Resealed => CyclePhase.Sealed,
                _ => CyclePhase.Sealed
            };
            
            CycleManager.Instance?.TransitionToPhase(nextPhase);
        }

        public void ForceSealDemon()
        {
            SealSystem.Instance?.TriggerExecutionSeal();
        }

        public string GetStatusSummary()
        {
            var cycle = CycleManager.Instance?.State;
            var demon = DemonLordManager.Instance?.ActiveDemonLord;
            
            return $"Cycle: {cycle?.CycleCount ?? 0}, Phase: {cycle?.CurrentPhase.ToString() ?? "Unknown"}, " +
                   $"Demon: {demon?.Name ?? "None"}, " +
                   $"Seal Progress: {SealSystem.Instance?.RitualProgress ?? 0:F0}%";
        }
    }
}
