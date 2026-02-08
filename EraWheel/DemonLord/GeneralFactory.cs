namespace EraWheel.DemonLord
{
    public static class GeneralFactory
    {
        public static GeneralTemplate[] CreateTemplates(string demonLordId)
        {
            if (string.IsNullOrEmpty(demonLordId)) return new GeneralTemplate[0];

            switch (demonLordId)
            {
                case "void_lord":
                    return new[]
                    {
                        new GeneralTemplate { DemonLordId = demonLordId, Id = "void_general_1", Role = GeneralRole.Elite, MinCycle = 0 },
                        new GeneralTemplate { DemonLordId = demonLordId, Id = "void_general_2", Role = GeneralRole.DPS, MinCycle = 0 },
                        new GeneralTemplate { DemonLordId = demonLordId, Id = "void_general_3", Role = GeneralRole.Tank, MinCycle = 1 }
                    };

                case "plague_lord":
                    return new[]
                    {
                        new GeneralTemplate { DemonLordId = demonLordId, Id = "plague_general_1", Role = GeneralRole.Support, MinCycle = 0 },
                        new GeneralTemplate { DemonLordId = demonLordId, Id = "plague_general_2", Role = GeneralRole.Elite, MinCycle = 0 },
                        new GeneralTemplate { DemonLordId = demonLordId, Id = "plague_general_3", Role = GeneralRole.Vanguard, MinCycle = 1 }
                    };

                default:
                    return new[]
                    {
                        new GeneralTemplate { DemonLordId = demonLordId, Id = demonLordId + "_general_1", Role = GeneralRole.Elite, MinCycle = 0 },
                        new GeneralTemplate { DemonLordId = demonLordId, Id = demonLordId + "_general_2", Role = GeneralRole.Elite, MinCycle = 0 }
                    };
            }
        }
    }
}
