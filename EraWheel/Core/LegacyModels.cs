using System;

namespace EraWheel.Core
{
    public enum LegacyType
    {
        Military,
        Economic,
        Tech,
        Legendary,
        Curse
    }

    [Serializable]
    public class Legacy
    {
        public string Id;
        public LegacyType Type;
        public bool IsCurse;
    }

    [Serializable]
    public struct LegacyGrant
    {
        public string LegacyId;
        public int StackDelta;
        public int NewStack;
    }
}
