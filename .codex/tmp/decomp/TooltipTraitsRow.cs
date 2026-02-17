using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class TooltipTraitsRow<TTrait> : TooltipItemsRow<Image> where TTrait : BaseTrait<TTrait>
{
	protected virtual IReadOnlyCollection<TTrait> traits_hashset
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	protected override void loadItems()
	{
		items_pool.clear();
		IReadOnlyCollection<TTrait> readOnlyCollection = traits_hashset;
		if (readOnlyCollection == null || readOnlyCollection.Count == 0)
		{
			base.gameObject.SetActive(value: false);
			return;
		}
		base.gameObject.SetActive(value: true);
		foreach (TTrait item in traits_hashset)
		{
			items_pool.getNext().sprite = item.getSprite();
		}
	}
}
