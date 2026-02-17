using System.Collections;
using UnityEngine;

public class KingdomWarsContainer : KingdomDiplomacyContainer<WarBanner, War, WarData>
{
	protected override IEnumerator showContent()
	{
		if (!base.kingdom.hasEnemies())
		{
			yield break;
		}
		using ListPool<War> tList = new ListPool<War>(base.kingdom.getWars());
		track_objects.AddRange(tList);
		yield return new WaitForSecondsRealtime(0.025f);
		Vector3 vector = new Vector3(0.8f, 0.8f, 1f);
		foreach (ref War item in tList)
		{
			War current = item;
			if (!current.isRekt())
			{
				WarBanner next = pool_elements.getNext();
				TipButton component = next.GetComponent<TipButton>();
				if (!next.HasComponent<DraggableLayoutElement>())
				{
					next.AddComponent<DraggableLayoutElement>();
				}
				component.showOnClick = true;
				component.setDefaultScale(vector);
				next.buttons_enabled = true;
				next.load(current);
				UiButtonHoverAnimation component2 = next.GetComponent<UiButtonHoverAnimation>();
				component2.enabled = false;
				component2.scale_size = 1f;
				component2.default_scale = vector;
				RectTransform component3 = next.GetComponent<RectTransform>();
				component3.SetAnchor(AnchorPresets.MiddleCenter);
				component3.localScale = vector;
				component3.anchoredPosition = new Vector2(0f, 0f);
			}
		}
	}
}
