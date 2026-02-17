using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class HoveringBgIconManager : MonoBehaviour
{
	[SerializeField]
	private HoveringIcon _icon_prefab;

	private ObjectPoolGenericMono<HoveringIcon> _pool_icons;

	private CanvasGroup _canvas_group;

	private RectTransform _rect;

	private List<RectTransform> _places = new List<RectTransform>();

	[SerializeField]
	public bool _random_scale = true;

	[SerializeField]
	private Transform _icon_pool;

	[SerializeField]
	private Transform _icons;

	private static HoveringBgIconManager _instance;

	private void Awake()
	{
		if (_pool_icons == null)
		{
			_instance = this;
			_rect = GetComponent<RectTransform>();
			_canvas_group = GetComponent<CanvasGroup>();
			_pool_icons = new ObjectPoolGenericMono<HoveringIcon>(_icon_prefab, _icon_pool);
			for (int i = 0; i < _icons.childCount; i++)
			{
				RectTransform rectTransform = _icons.GetChild(i) as RectTransform;
				_places.Add(rectTransform);
				rectTransform.gameObject.name = "Placing " + i;
			}
		}
	}

	private void OnDisable()
	{
		_pool_icons.clear();
	}

	public void fadeIn()
	{
		_icons.gameObject.SetActive(value: true);
		_canvas_group.DOFade(1f, 0.2f);
		_canvas_group.interactable = true;
		_canvas_group.blocksRaycasts = true;
	}

	public void fadeOut()
	{
		_canvas_group.interactable = false;
		_canvas_group.blocksRaycasts = false;
		_canvas_group.DOFade(0f, 0.2f);
		clear();
		resetPlaces();
		_icons.gameObject.SetActive(value: false);
	}

	private void resetPlaces()
	{
		if (!Randy.randomBool())
		{
			float x = _rect.rect.width / 2f;
			float y = _rect.rect.height / 2f;
			Vector3 vector = new Vector3(x, y, 0f);
			for (int i = 0; i < _places.Count; i++)
			{
				RectTransform rectTransform = _places[i];
				rectTransform.DOKill();
				rectTransform.anchoredPosition = vector;
			}
		}
	}

	private void shufflePlaces()
	{
		resetPlaces();
		float width = _rect.rect.width;
		float height = _rect.rect.height;
		for (int i = 0; i < _places.Count; i++)
		{
			_places[i].DOAnchorPos(duration: Randy.randomFloat(0.15f, 0.35f), endValue: new Vector3(Randy.randomFloat(0f, width), Randy.randomFloat(0f, height), 0f));
		}
	}

	public void animate(WindowAsset pWindowAsset)
	{
		clear();
		shufflePlaces();
		float num = Randy.randomFloat(0f, 360f);
		string text = "ui/Icons/";
		using ListPool<string> listPool = new ListPool<string>(16);
		Delegate[] invocationList = pWindowAsset.get_hovering_icons.GetInvocationList();
		for (int i = 0; i < invocationList.Length; i++)
		{
			foreach (string item3 in ((HoveringBGIconsGetter)invocationList[i])(pWindowAsset))
			{
				if (item3.EndsWith("/"))
				{
					Sprite[] spriteList = SpriteTextureLoader.getSpriteList(text + item3);
					for (int j = 0; j < spriteList.Length; j++)
					{
						string item = text + item3 + spriteList[j].name;
						listPool.Add(item);
					}
				}
				else
				{
					string item2 = text + item3;
					listPool.Add(item2);
				}
			}
		}
		foreach (RectTransform place in _places)
		{
			string random = listPool.GetRandom();
			HoveringIcon next = _pool_icons.getNext();
			next.clear();
			next.transform.SetParent(place, worldPositionStays: false);
			next.rect.anchoredPosition = Vector3.zero;
			next.transform.rotation = Quaternion.identity;
			next.image.sprite = SpriteTextureLoader.getSprite(random);
			if (_random_scale)
			{
				float num2 = Randy.randomFloat(0.4f, 1f);
				next.transform.localScale = new Vector3(num2, num2, num2);
			}
			else
			{
				next.transform.localScale = place.localScale;
			}
			Vector3 localScale = next.transform.localScale;
			next.image.color = new Color(localScale.x, localScale.x, localScale.x, 1f);
			num += Randy.randomFloat(20f, 130f);
			next.transform.eulerAngles = new Vector3(0f, 0f, num);
			next.init();
		}
	}

	public static void show()
	{
		_instance.fadeIn();
	}

	public static void hide()
	{
		_instance.fadeOut();
	}

	public static void showWindow(WindowAsset pWindowAsset)
	{
		_instance.animate(pWindowAsset);
	}

	public static void dropAll()
	{
		foreach (HoveringIcon item in _instance._pool_icons.getListTotal())
		{
			if (item.gameObject.activeSelf)
			{
				UiCreature component = item.GetComponent<UiCreature>();
				if (!component.dropped)
				{
					component.click();
				}
			}
		}
	}

	public static void randomDrop()
	{
		using ListPool<UiCreature> listPool = new ListPool<UiCreature>(_instance._pool_icons.countActive());
		foreach (HoveringIcon item in _instance._pool_icons.getListTotal())
		{
			if (item.gameObject.activeSelf)
			{
				UiCreature component = item.GetComponent<UiCreature>();
				if (!component.dropped)
				{
					listPool.Add(component);
				}
			}
		}
		if (listPool.Count != 0)
		{
			listPool.GetRandom().click();
		}
	}

	private void clear()
	{
		_pool_icons.clear();
		_pool_icons.resetParent();
	}
}
