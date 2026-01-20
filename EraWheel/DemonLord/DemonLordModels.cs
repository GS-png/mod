using System;

namespace EraWheel.DemonLord
{
    public enum DemonLordType
    {
        Void,
        Plague,
        Machine,
        Time,
        Flame,
        Abyss,
        Death,
        Soul,
        Nature,
        Judgment
    }

    [Serializable]
    public class DemonLordDefinition
    {
        public string Id;
        public DemonLordType Type;
        public string NameKey;
        public int DangerLevel;

        public float BaseHealth = 100f;
    }
}
