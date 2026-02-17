using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnowledgeElement : MonoBehaviour
{
	[SerializeField]
	private LocalizedText _localized_text;

	[SerializeField]
	private Image _icon_left;

	[SerializeField]
	private Image _icon_right;

	[SerializeField]
	private EasterEggBanner _icon_easter_left;

	[SerializeField]
	private EasterEggBanner _icon_easter_right;

	[SerializeField]
	private StatBar _progress_bar;

	[SerializeField]
	private RunningIcons _running_icons;

	private CubeOverview _cube_overview_big;

	private WindowMetaTab _cube_tab;

	private KnowledgeAsset _asset;

	private int _running_icon_latest_index;

	private ILibraryWithUnlockables _library;

	private List<BaseUnlockableAsset> _assets_list = new List<BaseUnlockableAsset>();

	private int _items;

	private bool _initialized;

	private void OnEnable()
	{
		if (_initialized)
		{
			resetBar();
		}
	}

	private void Start()
	{
		init(_asset);
		resetBar();
	}

	public void setAsset(KnowledgeAsset pAsset)
	{
		_asset = pAsset;
	}

	public void setCube(CubeOverview pBigCube, WindowMetaTab pCubeTab)
	{
		_cube_overview_big = pBigCube;
		_cube_tab = pCubeTab;
	}

	private void init(KnowledgeAsset pAsset)
	{
		if (_initialized)
		{
			return;
		}
		_initialized = true;
		_asset = pAsset;
		_localized_text.setKeyAndUpdate(_asset.getLocaleID());
		Sprite icon = _asset.getIcon();
		_icon_left.sprite = icon;
		_icon_left.GetComponentInParent<Button>().onClick.AddListener(delegate
		{
			_asset.click_icon_action(_asset);
		});
		_icon_right.GetComponentInParent<Button>().onClick.AddListener(delegate
		{
			_cube_overview_big.setFilterAsset(_asset);
			_cube_tab.tab_action.Invoke(_cube_tab);
		});
		_library = _asset.get_library();
		foreach (BaseUnlockableAsset item in _library.elements_list)
		{
			if (item.show_in_knowledge_window)
			{
				_assets_list.Add(item);
			}
		}
		_assets_list.Shuffle();
		_running_icons.init(prevItem, nextItem);
		using ListPool<Vector3> listPool = new ListPool<Vector3>(_running_icons.transform.childCount);
		foreach (Transform item2 in _running_icons.transform)
		{
			listPool.Add(item2.localPosition);
			Object.Destroy(item2.gameObject);
		}
		Transform original = Resources.Load<Transform>(pAsset.button_prefab_path);
		foreach (ref Vector3 item3 in listPool)
		{
			Vector3 current2 = item3;
			Transform transform2 = Object.Instantiate(original, _running_icons.transform);
			transform2.transform.localPosition = current2;
			transform2.SetSiblingIndex(_items++);
			if (!transform2.HasComponent<RunningIcon>())
			{
				transform2.AddComponent<RunningIcon>();
			}
			_running_icons.addIcon(transform2.GetComponent<RunningIcon>());
			Button componentInChildren = transform2.GetComponentInChildren<Button>();
			componentInChildren.enabled = false;
			componentInChildren.OnHover(delegate
			{
				_running_icons.toggle(pState: false);
			});
			componentInChildren.OnHoverOut(delegate
			{
				_running_icons.toggle(pState: true);
			});
			if (transform2.TryGetComponent<DraggableLayoutElement>(out var component))
			{
				component.enabled = false;
			}
			BaseUnlockableAsset nextAsset = getNextAsset();
			_asset.load_button(transform2, nextAsset);
			_asset.tip_button_loader?.Invoke(transform2, nextAsset);
		}
		checkEasterEggsSprite();
	}

	private void checkEasterEggsSprite()
	{
		if (string.IsNullOrEmpty(_asset.path_icon_easter_egg))
		{
			_icon_easter_left.gameObject.SetActive(value: false);
			_icon_easter_right.gameObject.SetActive(value: false);
		}
		else
		{
			Sprite sprite = SpriteTextureLoader.getSprite(_asset.path_icon_easter_egg);
			_icon_easter_left.main_image.sprite = sprite;
			_icon_easter_right.main_image.sprite = sprite;
		}
	}

	private void resetBar()
	{
		int num = _asset.countUnlockedByPlayer();
		int num2 = _asset.countTotal();
		_progress_bar.setBar(num, num2, "/" + num2.ToText());
	}

	private void nextItem(Transform pButton)
	{
		BaseUnlockableAsset nextAsset = getNextAsset();
		_asset.load_button(pButton, nextAsset);
		_asset.tip_button_loader?.Invoke(pButton, nextAsset);
	}

	private BaseUnlockableAsset getNextAsset()
	{
		_running_icon_latest_index++;
		int index = (_running_icon_latest_index = Toolbox.loopIndex(_running_icon_latest_index, _assets_list.Count));
		return _assets_list[index];
	}

	private void prevItem(Transform pButton)
	{
		BaseUnlockableAsset prevAsset = getPrevAsset();
		_asset.load_button(pButton, prevAsset);
		_asset.tip_button_loader?.Invoke(pButton, prevAsset);
	}

	private BaseUnlockableAsset getPrevAsset()
	{
		_running_icon_latest_index--;
		int index = Toolbox.loopIndex((_running_icon_latest_index = Toolbox.loopIndex(_running_icon_latest_index, _assets_list.Count)) - _items + 1, _assets_list.Count);
		return _assets_list[index];
	}
}
