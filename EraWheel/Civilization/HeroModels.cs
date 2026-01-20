using System;

namespace EraWheel.Civilization
{
    public enum HeroState
    {
        Alive,
        Dead,
        Legendary
    }

    [Serializable]
    public class HeroData
    {
        public string Id;
        public string Name;
        public bool IsDestined;
        public HeroState State = HeroState.Alive;

        public int DemonLordDamageDealt;
        public int GeneralsDefeated;

        public string FamilyId;
        public string[] InheritedTraits = new string[0];

        public long BornWorldAge;
        public long DeathWorldAge = -1;

        public string[] Biography = new string[0];
    }

    [Serializable]
    public class HeroSaveData
    {
        public HeroData[] Heroes = new HeroData[0];
        public int TotalDestinedHeroesBorn;
        public int TotalHeroDeaths;
        public int TotalInheritances;
    }

    [Serializable]
    public struct HeroBornEvent
    {
        public string HeroId;
        public bool IsDestined;
        public long WorldTime;
    }

    [Serializable]
    public struct HeroDeathEvent
    {
        public string HeroId;
        public bool WasDestined;
        public long WorldTime;
        public string Cause;
    }

    [Serializable]
    public struct HeroInheritanceEvent
    {
        public string ParentHeroId;
        public string ChildHeroId;
        public string[] InheritedTraits;
        public long WorldTime;
    }
}
