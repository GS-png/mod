using UnityEngine;
using UnityEngine.UI;

public class BaseAssetElementPlace<TAsset, TAssetElement> : MonoBehaviour where TAsset : Asset where TAssetElement : BaseDebugAssetElement<TAsset>
{
	public GameObject game_object_cache;

	public RectTransform rect_transform;

	public LayoutElement layout_element;

	public bool has_element;

	public TAssetElement element;

	public GameObject element_game_object_cache;

	public bool allowed_for_search = true;

	public void clear()
	{
		if (has_element)
		{
			layout_element.minHeight = element.rect_transform.rect.height;
			Object.Destroy(element_game_object_cache);
			element_game_object_cache = null;
			element = null;
			has_element = false;
		}
	}

	public void setData(TAsset pAsset, TAssetElement pPrefab)
	{
		if (has_element)
		{
			clear();
		}
		layout_element.minHeight = -1f;
		TAssetElement val = Object.Instantiate(pPrefab, rect_transform);
		val.setData(pAsset);
		val.rect_transform.localScale = Vector3.one;
		element = val;
		element_game_object_cache = val.gameObject;
		has_element = true;
	}
}
