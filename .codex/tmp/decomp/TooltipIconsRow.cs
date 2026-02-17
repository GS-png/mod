using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TooltipIconsRow : TooltipItemsRow<Image>
{
	private List<(Sprite, Color)> _icons = new List<(Sprite, Color)>();

	protected override void loadItems()
	{
		items_pool.clear();
		if (_icons.Count == 0)
		{
			base.gameObject.SetActive(value: false);
			return;
		}
		base.gameObject.SetActive(value: true);
		foreach (var icon in _icons)
		{
			Image next = items_pool.getNext();
			(next.sprite, next.color) = icon;
		}
		clearIcons();
	}

	public void addIcon(Sprite pIcon, string pColor = "#FFFFFF")
	{
		Color item = Toolbox.makeColor(pColor);
		_icons.Add((pIcon, item));
	}

	private void clearIcons()
	{
		_icons.Clear();
	}
}
