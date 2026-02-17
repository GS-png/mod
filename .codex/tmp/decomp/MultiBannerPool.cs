using System.Collections.Generic;
using UnityEngine;

public class MultiBannerPool
{
	private Dictionary<string, ObjectPoolGenericMono<MonoBehaviour>> _pool_banners;

	private Transform _pool_container;

	private Transform _prefab_area;

	public MultiBannerPool(Transform pPoolContainer)
	{
		_pool_banners = new Dictionary<string, ObjectPoolGenericMono<MonoBehaviour>>();
		_pool_container = pPoolContainer;
		GameObject gameObject = new GameObject("PrefabArea", typeof(RectTransform));
		gameObject.transform.SetParent(_pool_container);
		_prefab_area = gameObject.transform;
		_prefab_area.gameObject.SetActive(value: false);
	}

	public IBanner getNext(NanoObject pObject)
	{
		string type = pObject.getType();
		MetaCustomizationAsset metaCustomizationAsset = AssetManager.meta_customization_library.get(type);
		if (!_pool_banners.TryGetValue(type, out var value))
		{
			GameObject gameObject = new GameObject("BannerArea " + type, typeof(RectTransform));
			gameObject.transform.SetParent(_pool_container, worldPositionStays: false);
			MonoBehaviour monoBehaviour = (MonoBehaviour)metaCustomizationAsset.get_banner(metaCustomizationAsset, pObject, _prefab_area);
			monoBehaviour.gameObject.name = type;
			_pool_banners.Add(type, new ObjectPoolGenericMono<MonoBehaviour>(monoBehaviour, gameObject.transform));
			value = _pool_banners[type];
		}
		return value.getNext() as IBanner;
	}

	public void release(IBanner pItem)
	{
		getItemPool(pItem).release(pItem as MonoBehaviour);
	}

	public void resetParent(IBanner pItem)
	{
		getItemPool(pItem).resetParent(pItem as MonoBehaviour);
	}

	private ObjectPoolGenericMono<MonoBehaviour> getItemPool(IBanner pItem)
	{
		MetaCustomizationAsset meta_asset = pItem.meta_asset;
		if (_pool_banners.TryGetValue(meta_asset.id, out var value))
		{
			return value;
		}
		return null;
	}

	public void clear()
	{
		foreach (ObjectPoolGenericMono<MonoBehaviour> value in _pool_banners.Values)
		{
			value.clear();
			value.resetParent();
		}
	}
}
