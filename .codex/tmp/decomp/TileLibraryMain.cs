using System.Collections.Generic;

public class TileLibraryMain<T> : AssetLibrary<T> where T : TileTypeBase
{
	public override void linkAssets()
	{
		base.linkAssets();
		foreach (T item in list)
		{
			HashSet<BiomeTag> biome_tags = item.biome_tags;
			item.has_biome_tags = biome_tags != null && biome_tags.Count > 0;
			if (item.color_hex != null)
			{
				item.color = Toolbox.makeColor(item.color_hex);
			}
			if (item.edge_color_hex != null)
			{
				item.edge_color = Toolbox.makeColor(item.edge_color_hex);
			}
		}
	}
}
