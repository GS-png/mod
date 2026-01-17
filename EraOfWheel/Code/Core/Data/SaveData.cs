using System;
using System.Collections.Generic;

namespace EraOfWheel.Core.Data
{
    /// <summary>
    /// 存档数据结构
    /// </summary>
    [Serializable]
    public class SaveData
    {
        public string version = "1.0.0";
        public DateTime saveTime;
        public int slotIndex;
        
        // 轮回状态
        public CycleSaveData cycle = new CycleSaveData();
        
        // 魔王状态
        public DemonLordSaveData demonLord = new DemonLordSaveData();
    }

    [Serializable]
    public class CycleSaveData
    {
        public int cycleCount = 0;
        public int currentPhase = 0; // 0=萌芽, 1=成长, 2=鼎盛, 3=衰落, 4=灭绝
        public float phaseProgress = 0f;
        public int totalLegacyPoints = 0;
    }

    [Serializable]
    public class DemonLordSaveData
    {
        public string activeDemonLordId = "";
        public float awakeningLevel = 0f;
        public List<string> unlockedAbilities = new List<string>();
    }

    /// <summary>
    /// 遗产数据（跨存档持久化）
    /// </summary>
    [Serializable]
    public class LegacyData
    {
        public string version = "1.0.0";
        public int totalCyclesCompleted = 0;
        public int permanentLegacyPoints = 0;
        public List<string> unlockedEnhancements = new List<string>();
        public Dictionary<string, int> demonLordDefeats = new Dictionary<string, int>();
    }
}
