using System.Collections;
using UnityEngine;

public class KingdomAlliesContainer : KingdomDiplomacyContainer<KingdomBanner, Kingdom, KingdomData>
{
	protected override IEnumerator showContent()
	{
		using ListPool<Kingdom> tList = World.world.wars.getNeutralKingdoms(base.kingdom);
		if (base.kingdom.hasAlliance())
		{
			foreach (Kingdom item in base.kingdom.getAlliance().kingdoms_list)
			{
				if (item != base.kingdom && !item.isRekt())
				{
					tList.Add(item);
				}
			}
		}
		track_objects.AddRange(tList);
		if (tList.Count == 0)
		{
			yield break;
		}
		yield return new WaitForSecondsRealtime(0.025f);
		Vector3 vector = new Vector3(0.5f, 0.5f, 1f);
		foreach (ref Kingdom item2 in tList)
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
				next.GetComponent<UiButtonHoverAnimation>().enabled = false;
				next.GetComponent<UiButtonHoverAnimation>().scale_size = 1f;
				next.GetComponent<UiButtonHoverAnimation>().default_scale = vector;
				next.GetComponent<TipButton>().setDefaultScale(vector);
				RectTransform component = next.GetComponent<RectTransform>();
				component.SetAnchor(AnchorPresets.MiddleCenter);
				component.localScale = vector;
				component.anchoredPosition = new Vector2(0f, 0f);
			}
		}
	}
}
