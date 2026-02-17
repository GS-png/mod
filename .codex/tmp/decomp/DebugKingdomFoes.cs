using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugKingdomFoes : MonoBehaviour
{
	[SerializeField]
	private DebugKingdomButton _prefab_button;

	[SerializeField]
	private Image _selector;

	[SerializeField]
	private GridLayoutGroup _grid_main;

	[SerializeField]
	private GridLayoutGroup _grid_civs;

	[SerializeField]
	private GridLayoutGroup _grid_minicivs;

	[SerializeField]
	private GridLayoutGroup _grid_minicivs_special;

	[SerializeField]
	private GridLayoutGroup _grid_concepts;

	[SerializeField]
	private GridLayoutGroup _grid_mobs;

	[SerializeField]
	private GridLayoutGroup _grid_creeps;

	[SerializeField]
	private GridLayoutGroup _grid_others;

	private List<DebugKingdomButton> _buttons = new List<DebugKingdomButton>();

	private KingdomAsset _current_selected;

	private bool _initialized;

	private void Awake()
	{
		create();
	}

	private void create()
	{
		if (_initialized)
		{
			return;
		}
		_initialized = true;
		AssetManager.kingdoms.checkForMissingTags();
		foreach (KingdomAsset item in AssetManager.kingdoms.list)
		{
			if (!item.isTemplateAsset())
			{
				DebugKingdomButton tNewButton = Object.Instantiate(parent: item.group_main ? _grid_main.transform : (item.group_creeps ? _grid_creeps.transform : (item.concept ? _grid_concepts.transform : (item.is_forced_by_trait ? _grid_others.transform : (item.group_minicivs_cool ? _grid_minicivs_special.transform : (item.group_miniciv ? _grid_minicivs.transform : (item.civ ? _grid_civs.transform : ((!item.mobs) ? _grid_others.transform : _grid_mobs.transform))))))), original: _prefab_button);
				tNewButton.setAsset(item);
				_buttons.Add(tNewButton);
				tNewButton.GetComponent<Button>().onClick.AddListener(delegate
				{
					select(tNewButton);
				});
			}
		}
		select(_buttons.GetRandom());
	}

	private void select(DebugKingdomButton pButton)
	{
		_current_selected = pButton.kingdom_asset;
		_selector.transform.position = pButton.transform.position;
		updateButtons();
	}

	private void updateButtons()
	{
		foreach (DebugKingdomButton button in _buttons)
		{
			button.checkSelected(_current_selected);
		}
	}
}
