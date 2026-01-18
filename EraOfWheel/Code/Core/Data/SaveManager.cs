using System;
using System.IO;
using UnityEngine;
using Logger = EraOfWheel.Core.Logger;

namespace EraOfWheel.Core.Data
{
    [Serializable]
    public class ModSaveData
    {
        public string mod_version = "0.1.0";
        public int current_cycle = 1;
        public int world_age_years = 0;
        public string current_phase = "Sealed";
        public int phase_start_year = 0;
        public int invasion_start_year = 0;
        public string active_demon_lord_id = "";
        public float current_seal_strength = 100f;
        public bool seal_decay_started = false;
        public int last_seal_decay_year = -1;
        public bool seal_war_active = false;
        public float ritual_progress = 0f;
        public DemonLordSaveData[] demon_lords = new DemonLordSaveData[0];
        public LegacySaveData legacy = new LegacySaveData();
    }

    [Serializable]
    public class DemonLordSaveData
    {
        public string id;
        public string state = "Sealed";
        public float seal_strength = 100f;
        public float health_percent = 100f;
        public int total_kills = 0;
        public CycleHistory[] history = new CycleHistory[0];
    }

    [Serializable]
    public class CycleHistory
    {
        public int cycle;
        public int cities_destroyed;
        public int heroes_killed;
        public string seal_method;
    }

    [Serializable]
    public class LegacySaveData
    {
        public string[] military_legacies = new string[0];
        public string[] economic_legacies = new string[0];
        public string[] tech_legacies = new string[0];
        public string[] legendary_legacies = new string[0];
        public string[] curse_legacies = new string[0];
    }

    public class SaveManager : IModSystem
    {
        public static SaveManager Instance { get; private set; }
        
        public string SystemName => "SaveManager";
        public bool IsInitialized { get; private set; }
        
        public ModSaveData Data { get; private set; }
        
        private const string SaveFileName = "era_of_wheel_save.json";
        private bool _loadedFromDisk = false;

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            Data = new ModSaveData();
            LoadFromWorld();
            
            IsInitialized = true;
            Logger.Info(SystemName, "SaveManager initialized");
        }

        public void LoadFromWorld()
        {
            try
            {
                if (_loadedFromDisk) return;
                var savePath = GetSavePath();
                if (!File.Exists(savePath))
                {
                    Logger.Info(SystemName, "No save file found, using new data");
                    Data = new ModSaveData();
                    _loadedFromDisk = true;
                    return;
                }
                
                var json = File.ReadAllText(savePath);
                Data = JsonUtility.FromJson<ModSaveData>(json) ?? new ModSaveData();
                Logger.Info(SystemName, $"Loaded save: Cycle {Data.current_cycle}, Phase {Data.current_phase}");
                _loadedFromDisk = true;
            }
            catch (Exception ex)
            {
                Logger.Error(SystemName, "Error loading save", ex);
                Data = new ModSaveData();
                _loadedFromDisk = true;
            }
        }

        public void ReloadFromWorld()
        {
            _loadedFromDisk = false;
            LoadFromWorld();
        }

        public void UpdateWorldAgeYears(int worldAgeYears)
        {
            if (Data == null) return;
            Data.world_age_years = worldAgeYears;
        }

        public void UpdateSealSystemData(bool sealWarActive, float ritualProgress)
        {
            if (Data == null) return;
            Data.seal_war_active = sealWarActive;
            Data.ritual_progress = ritualProgress;
        }

        public void SaveToWorld()
        {
            try
            {
                var savePath = GetSavePath();
                var directory = Path.GetDirectoryName(savePath);
                
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                
                BackupSave(savePath);
                
                var json = JsonUtility.ToJson(Data, true);
                File.WriteAllText(savePath, json);
                Logger.Info(SystemName, "Save completed");
            }
            catch (Exception ex)
            {
                Logger.Error(SystemName, "Error saving", ex);
            }
        }

        private void BackupSave(string savePath)
        {
            try
            {
                if (File.Exists(savePath))
                {
                    var backupPath = savePath + ".backup";
                    File.Copy(savePath, backupPath, true);
                }
            }
            catch (Exception ex)
            {
                Logger.Warn(SystemName, $"Backup failed: {ex.Message}");
            }
        }

        public void RestoreBackup()
        {
            try
            {
                var savePath = GetSavePath();
                var backupPath = savePath + ".backup";
                
                if (File.Exists(backupPath))
                {
                    File.Copy(backupPath, savePath, true);
                    ReloadFromWorld();
                    Logger.Info(SystemName, "Backup restored");
                }
            }
            catch (Exception ex)
            {
                Logger.Error(SystemName, "Error restoring backup", ex);
            }
        }

        private string GetSavePath()
        {
            var worldPath = Application.persistentDataPath;
            return Path.Combine(worldPath, SaveFileName);
        }

        public void UpdateCycleData(int cycle, string phase)
        {
            Data.current_cycle = cycle;
            Data.current_phase = phase;
        }

        public void UpdateCycleData(int cycle, string phase, int phaseStartYear, int invasionStartYear, string activeDemonLordId, float sealStrength)
        {
            if (Data == null) return;

            Data.current_cycle = cycle;
            Data.current_phase = phase;
            Data.phase_start_year = phaseStartYear;
            Data.invasion_start_year = invasionStartYear;
            Data.active_demon_lord_id = activeDemonLordId ?? "";
            Data.current_seal_strength = sealStrength;
        }

        public void UpdateCycleData(int cycle, string phase, int phaseStartYear, int invasionStartYear, string activeDemonLordId, float sealStrength, bool sealDecayStarted, int lastSealDecayYear)
        {
            if (Data == null) return;

            Data.current_cycle = cycle;
            Data.current_phase = phase;
            Data.phase_start_year = phaseStartYear;
            Data.invasion_start_year = invasionStartYear;
            Data.active_demon_lord_id = activeDemonLordId ?? "";
            Data.current_seal_strength = sealStrength;
            Data.seal_decay_started = sealDecayStarted;
            Data.last_seal_decay_year = lastSealDecayYear;
        }

        public void UpdateDemonLordData(string id, string state, float sealStrength, float healthPercent)
        {
            for (int i = 0; i < Data.demon_lords.Length; i++)
            {
                if (Data.demon_lords[i].id == id)
                {
                    Data.demon_lords[i].state = state;
                    Data.demon_lords[i].seal_strength = sealStrength;
                    Data.demon_lords[i].health_percent = healthPercent;
                    return;
                }
            }
            
            var list = new System.Collections.Generic.List<DemonLordSaveData>(Data.demon_lords);
            list.Add(new DemonLordSaveData
            {
                id = id,
                state = state,
                seal_strength = sealStrength,
                health_percent = healthPercent
            });
            Data.demon_lords = list.ToArray();
        }

        public void UpdateDemonLordData(string id, string state, float sealStrength, float healthPercent, int totalKills)
        {
            if (Data == null) return;

            for (int i = 0; i < Data.demon_lords.Length; i++)
            {
                if (Data.demon_lords[i].id == id)
                {
                    Data.demon_lords[i].state = state;
                    Data.demon_lords[i].seal_strength = sealStrength;
                    Data.demon_lords[i].health_percent = healthPercent;
                    Data.demon_lords[i].total_kills = totalKills;
                    return;
                }
            }

            var list = new System.Collections.Generic.List<DemonLordSaveData>(Data.demon_lords);
            list.Add(new DemonLordSaveData
            {
                id = id,
                state = state,
                seal_strength = sealStrength,
                health_percent = healthPercent,
                total_kills = totalKills
            });
            Data.demon_lords = list.ToArray();
        }

        public void Dispose()
        {
            SaveToWorld();
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "SaveManager disposed");
        }
    }
}
