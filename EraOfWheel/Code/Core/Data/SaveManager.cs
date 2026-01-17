using System;
using System.IO;
using UnityEngine;

namespace EraOfWheel.Core.Data
{
    /// <summary>
    /// 存档管理器 - 负责游戏存档和遗产数据的持久化
    /// </summary>
    public class SaveManager : IModSystem
    {
        public static SaveManager Instance { get; private set; }
        
        public string SystemName => "SaveManager";
        public bool IsInitialized { get; private set; }

        private string _savePath;
        private string _legacyPath;
        private const int MAX_SLOTS = 3;
        private const string BACKUP_SUFFIX = ".backup";

        public SaveData CurrentSave { get; private set; }
        public LegacyData Legacy { get; private set; }

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            
            var modPath = Path.GetDirectoryName(typeof(SaveManager).Assembly.Location);
            _savePath = Path.Combine(modPath, "saves");
            _legacyPath = Path.Combine(modPath, "legacy.json");

            if (!Directory.Exists(_savePath))
            {
                Directory.CreateDirectory(_savePath);
            }

            LoadLegacy();
            IsInitialized = true;
            ModMain.Log($"[{SystemName}] 初始化完成");
        }

        /// <summary>
        /// 保存游戏到指定槽位
        /// </summary>
        public bool Save(int slot, SaveData data)
        {
            if (slot < 0 || slot >= MAX_SLOTS)
            {
                ModMain.Log($"[{SystemName}] 无效的存档槽位: {slot}", ModMain.LogLevel.Error);
                return false;
            }

            try
            {
                data.slotIndex = slot;
                data.saveTime = DateTime.UtcNow;
                
                var filePath = GetSavePath(slot);
                
                // 创建备份
                if (File.Exists(filePath))
                {
                    File.Copy(filePath, filePath + BACKUP_SUFFIX, true);
                }

                var json = JsonUtility.ToJson(data, true);
                File.WriteAllText(filePath, json);
                
                CurrentSave = data;
                ModMain.Log($"[{SystemName}] 存档已保存: 槽位 {slot}");
                return true;
            }
            catch (Exception ex)
            {
                ModMain.Log($"[{SystemName}] 保存失败: {ex.Message}", ModMain.LogLevel.Error);
                return false;
            }
        }

        /// <summary>
        /// 从指定槽位加载游戏
        /// </summary>
        public SaveData Load(int slot)
        {
            if (slot < 0 || slot >= MAX_SLOTS)
            {
                ModMain.Log($"[{SystemName}] 无效的存档槽位: {slot}", ModMain.LogLevel.Error);
                return null;
            }

            var filePath = GetSavePath(slot);

            try
            {
                if (!File.Exists(filePath))
                {
                    // 尝试从备份恢复
                    if (File.Exists(filePath + BACKUP_SUFFIX))
                    {
                        ModMain.Log($"[{SystemName}] 从备份恢复存档", ModMain.LogLevel.Warning);
                        File.Copy(filePath + BACKUP_SUFFIX, filePath);
                    }
                    else
                    {
                        return null;
                    }
                }

                var json = File.ReadAllText(filePath);
                var data = JsonUtility.FromJson<SaveData>(json);
                
                // 版本检查和迁移
                data = MigrateIfNeeded(data);
                
                CurrentSave = data;
                ModMain.Log($"[{SystemName}] 存档已加载: 槽位 {slot}");
                return data;
            }
            catch (Exception ex)
            {
                ModMain.Log($"[{SystemName}] 加载失败: {ex.Message}", ModMain.LogLevel.Error);
                return TryRecoverFromBackup(slot);
            }
        }

        /// <summary>
        /// 检查槽位是否有存档
        /// </summary>
        public bool HasSave(int slot)
        {
            return File.Exists(GetSavePath(slot));
        }

        /// <summary>
        /// 删除指定槽位的存档
        /// </summary>
        public void Delete(int slot)
        {
            var filePath = GetSavePath(slot);
            if (File.Exists(filePath)) File.Delete(filePath);
            if (File.Exists(filePath + BACKUP_SUFFIX)) File.Delete(filePath + BACKUP_SUFFIX);
            ModMain.Log($"[{SystemName}] 存档已删除: 槽位 {slot}");
        }

        /// <summary>
        /// 加载遗产数据
        /// </summary>
        public void LoadLegacy()
        {
            try
            {
                if (File.Exists(_legacyPath))
                {
                    var json = File.ReadAllText(_legacyPath);
                    Legacy = JsonUtility.FromJson<LegacyData>(json);
                }
                else
                {
                    Legacy = new LegacyData();
                }
            }
            catch
            {
                Legacy = new LegacyData();
            }
        }

        /// <summary>
        /// 保存遗产数据
        /// </summary>
        public void SaveLegacy()
        {
            try
            {
                var json = JsonUtility.ToJson(Legacy, true);
                File.WriteAllText(_legacyPath, json);
            }
            catch (Exception ex)
            {
                ModMain.Log($"[{SystemName}] 保存遗产数据失败: {ex.Message}", ModMain.LogLevel.Error);
            }
        }

        private string GetSavePath(int slot) => Path.Combine(_savePath, $"save_{slot}.json");

        private SaveData MigrateIfNeeded(SaveData data)
        {
            // 版本迁移逻辑
            if (data.version != "1.0.0")
            {
                ModMain.Log($"[{SystemName}] 迁移存档: {data.version} → 1.0.0");
                data.version = "1.0.0";
            }
            return data;
        }

        private SaveData TryRecoverFromBackup(int slot)
        {
            var backupPath = GetSavePath(slot) + BACKUP_SUFFIX;
            if (!File.Exists(backupPath)) return null;

            try
            {
                var json = File.ReadAllText(backupPath);
                var data = JsonUtility.FromJson<SaveData>(json);
                ModMain.Log($"[{SystemName}] 从备份恢复成功", ModMain.LogLevel.Warning);
                return data;
            }
            catch
            {
                return null;
            }
        }

        public void Dispose()
        {
            SaveLegacy();
            Instance = null;
            IsInitialized = false;
        }
    }
}
