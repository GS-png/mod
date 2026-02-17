public class KingdomSelectedAlliesContainer : KingdomDiplomacyContainer<KingdomBanner, Kingdom, KingdomData>
{
	protected override void OnEnable()
	{
	}

	public void update(Kingdom pKingdom)
	{
		meta_object = pKingdom;
		clear();
		using ListPool<Kingdom> listPool = World.world.wars.getNeutralKingdoms(base.kingdom);
		if (base.kingdom.hasAlliance())
		{
			foreach (Kingdom item in base.kingdom.getAlliance().kingdoms_list)
			{
				if (item != base.kingdom && !item.isRekt())
				{
					listPool.Add(item);
				}
			}
		}
		track_objects.AddRange(listPool);
		if (listPool.Count == 0)
		{
			return;
		}
		foreach (ref Kingdom item2 in listPool)
		{
			Kingdom current2 = item2;
			if (!current2.isRekt())
			{
				KingdomBanner next = pool_elements.getNext();
				next.diplo_banner = true;
				next.GetComponent<TipButton>().showOnClick = true;
				next.GetComponentInChildren<RotateOnHover>().enabled = true;
				if (!next.HasComponent<DraggableLayoutElement>())
				{
					next.AddComponent<DraggableLayoutElement>();
				}
				next.load(current2);
			}
		}
	}
}
