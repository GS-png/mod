using EraWheel.Core;

namespace EraWheel.DemonLord
{
    public class StrongholdSystem
    {
        public StrongholdData CreateStronghold(string demonId)
        {
            return new StrongholdData
            {
                Id = demonId + "_stronghold",
                CreatedAtWorldAge = WorldCompat.GetWorldAge(),
                TileX = 0,
                TileY = 0
            };
        }
    }
}
