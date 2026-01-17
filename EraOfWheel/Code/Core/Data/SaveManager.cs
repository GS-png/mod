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

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            Data = new ModSaveData();
            
            IsInitialized = true;
            Logger.Info(SystemName, "SaveManager initialized");
        }

        public void LoadFromWorld()
        {
            try
            {
                var savePath = GetSavePath();
                if (!File.Exists(savePath))
                {
                    Logger.Info(SystemName, "No save file found, using new data");
                    Data = new ModSaveData();
                    return;
                }
                
                var json = File.ReadAllText(savePath);
                Data = JsonUtility.FromJson<ModSaveData>(json);
                Logger.Info(SystemName, $"Loaded save: Cycle {Data.current_cycle}, Phase {Data.current_phase}");
            }
            catch (Exception ex)
            {
                Logger.Error(SystemName, "Error loading save", ex);
                Data = new ModSaveData();
            }
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
                    LoadFromWorld();
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

        public void Dispose()
        {
            SaveToWorld();
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "SaveManager disposed");
        }
    }
}
