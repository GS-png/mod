using System;
using System.Collections.Generic;
using UnityEngine;
using EraOfWheel.Core.Config;
using EraOfWheel.Core.Data;
using EraOfWheel.Cycle;
using EraOfWheel.DemonLords;
using EraOfWheel.DemonLords.Legion;
using EraOfWheel.UI;
using EraOfWheel.UI.Panels;

namespace EraOfWheel.Core
{
    public class ModMain : MonoBehaviour
    {
        public static ModMain Instance { get; private set; }
        
        private const string ModVersion = "0.1.0";
        private const string ModName = "Era of Wheel";
        
        private List<IModSystem> _systems = new List<IModSystem>();
        private bool _isInitialized = false;
        private int _lastWorldYear = -1;

        public static void Init()
        {
            if (Instance != null) return;
            
            var go = new GameObject("EraOfWheelMod");
            Instance = go.AddComponent<ModMain>();
            DontDestroyOnLoad(go);
            
            Logger.Info("ModMain", $"{ModName} v{ModVersion} loading...");
        }

        private void Awake()
        {
            try
            {
                InitializeSystems();
                _isInitialized = true;
                Logger.Info("ModMain", $"{ModName} v{ModVersion} initialized successfully!");
            }
            catch (Exception ex)
            {
                Logger.Error("ModMain", "Failed to initialize mod", ex);
                _isInitialized = false;
            }
        }

        private void InitializeSystems()
        {
            // Order matters - dependencies first
            RegisterSystem(new EventBus());
            RegisterSystem(new ConfigManager());
            RegisterSystem(new SaveManager());
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
            SaveManager.Instance?.LoadFromWorld();
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
                return (int)(World.world?.worldLaws?.world_era?.years ?? 0);
            }
            catch
            {
                return 0;
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
