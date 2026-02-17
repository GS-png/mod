public readonly struct TooltipModContainerInfo
{
	public readonly ItemAsset asset;

	public readonly int pluses;

	public readonly string string_pluses;

	public TooltipModContainerInfo(ItemAsset pAsset, int pPluses, string pStringPluses)
	{
		asset = pAsset;
		pluses = pPluses;
		string_pluses = pStringPluses;
	}
}
