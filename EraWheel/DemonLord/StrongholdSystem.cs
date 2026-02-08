using EraWheel.Core;

namespace EraWheel.DemonLord
{
    public class StrongholdSystem
    {
        public StrongholdData CreateStronghold(string demonId)
        {
            return CreateStronghold(demonId, 0, 0);
        }

        public StrongholdData CreateStronghold(string demonId, int tileX, int tileY)
        {
            return new StrongholdData
            {
                Id = demonId + "_stronghold",
                CreatedAtWorldAge = WorldCompat.GetWorldAge(),
                TileX = tileX,
                TileY = tileY
            };
        }
    }
}
