using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WindowListElementBase<TMetaObject, TData> : MonoBehaviour, IPointerMoveHandler, IEventSystemHandler where TMetaObject : CoreSystemObject<TData> where TData : BaseSystemData
{
	[HideInInspector]
	public TMetaObject meta_object;

	[SerializeField]
	private BannerGeneric<TMetaObject, TData> _main_banner;

	[SerializeField]
	private GameObject _icon_favorite;

	[SerializeField]
	private Image _icon_species;

	private void Awake()
	{
		create();
	}

	private void create()
	{
		initMonoFields();
		initTooltip();
	}

	protected virtual void initMonoFields()
	{
		if (_main_banner == null)
		{
			BannerGeneric<TMetaObject, TData>[] array = base.gameObject.transform.FindAllRecursive<BannerGeneric<TMetaObject, TData>>((Transform p) => p.gameObject.activeInHierarchy);
			if (array.Length == 1)
			{
				_main_banner = array[0];
			}
			else
			{
				Debug.LogError("WindowListElementBase: Failed to auto-find main banner. Assign manually. Found : " + array.Length + " of type " + typeof(BannerGeneric<TMetaObject, TData>));
			}
		}
	}

	private void initTooltip()
	{
		GetComponent<Button>().OnHoverOut(delegate
		{
			Tooltip.hideTooltip();
		});
	}

	public void click()
	{
		if (!InputHelpers.mouseSupported && !Tooltip.isShowingFor(this))
		{
			tooltipAction();
			return;
		}
		MetaType metaType = meta_object.getMetaType();
		MetaTypeAsset asset = AssetManager.meta_type_library.getAsset(metaType);
		asset.set_selected(meta_object);
		if (asset.get_selected() != null)
		{
			ScrollWindow.showWindow(asset.window_name);
		}
	}

	internal virtual void show(TMetaObject pObject)
	{
		meta_object = pObject;
		loadBanner();
		toggleFavorited(meta_object.isFavorite());
		if (_icon_species != null)
		{
			_icon_species.sprite = getActorAsset().getSpriteIcon();
		}
	}

	protected virtual void loadBanner()
	{
		_main_banner.load(meta_object);
	}

	protected virtual void tooltipAction()
	{
		throw new NotImplementedException();
	}

	public void toggleFavorited(bool pState)
	{
		if (_icon_favorite != null)
		{
			_icon_favorite.SetActive(pState);
		}
	}

	protected virtual void OnDisable()
	{
		meta_object = null;
	}

	public void OnPointerMove(PointerEventData pData)
	{
		if (InputHelpers.mouseSupported && !Tooltip.anyActive())
		{
			tooltipAction();
		}
	}

	protected virtual ActorAsset getActorAsset()
	{
		throw new NotImplementedException();
	}
}
