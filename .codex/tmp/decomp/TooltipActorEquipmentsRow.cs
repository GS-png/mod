public class TooltipActorEquipmentsRow : TooltipItemsRow<TooltipOutlineItem>
{
	protected override void loadItems()
	{
		items_pool.clear();
		Actor actor = tooltip_data.actor;
		if (!actor.canUseItems() || actor.equipment == null || !actor.equipment.hasItems())
		{
			base.gameObject.SetActive(value: false);
			return;
		}
		bool active = false;
		foreach (ActorEquipmentSlot item2 in actor.equipment)
		{
			Item item = item2.getItem();
			if (item != null)
			{
				active = true;
				TooltipOutlineItem next = items_pool.getNext();
				next.image.sprite = item.getSprite();
				if (item.getQuality() == Rarity.R3_Legendary)
				{
					next.outline.show(RarityLibrary.legendary.color_container);
				}
				else
				{
					next.outline.gameObject.SetActive(value: false);
				}
			}
		}
		base.gameObject.SetActive(active);
	}
}
