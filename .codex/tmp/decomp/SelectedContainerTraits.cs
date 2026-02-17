using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedContainerTraits<TTrait, TTraitButton, TTraitContainer, TTraitEditor> : SelectedElementBase<TTraitButton>, ISelectedContainerTrait where TTrait : BaseTrait<TTrait> where TTraitButton : TraitButton<TTrait> where TTraitContainer : ITraitsContainer<TTrait, TTraitButton> where TTraitEditor : ITraitsEditor<TTrait>
{
	[SerializeField]
	private TTraitButton _prefab_trait;

	protected virtual MetaType meta_type { get; }

	protected string window_id => AssetManager.meta_type_library.getAsset(meta_type).window_name;

	private void Awake()
	{
		_pool = new ObjectPoolGenericMono<TTraitButton>(_prefab_trait, _grid);
		_grid.gameObject.AddOrGetComponent<TraitsGrid>();
	}

	public void update(NanoObject pNano)
	{
		refresh(pNano);
	}

	protected override void refresh(NanoObject pNano)
	{
		clear();
		foreach (TTrait trait in getTraits())
		{
			addButton(trait);
		}
	}

	private void addButton(TTrait pObject)
	{
		TTraitButton next = _pool.getNext();
		next.load(pObject);
		next.removeClickAction(showTraitsTabAndScroll);
		next.addClickAction(showTraitsTabAndScroll);
	}

	private void showTraitsTabAndScroll(GameObject pButton)
	{
		if (canEditTraits())
		{
			TTraitButton component = pButton.GetComponent<TTraitButton>();
			if (InputHelpers.mouseSupported || Tooltip.isShowingFor(component))
			{
				ScrollWindow.showWindow(window_id);
				World.world.StartCoroutine(showTraitsTabAndScrollRoutine(component));
			}
		}
	}

	private IEnumerator showTraitsTabAndScrollRoutine(TTraitButton pTraitButton)
	{
		ScrollWindow tWindow = ScrollWindow.getCurrentWindow();
		TTraitEditor tEditor = tWindow.GetComponentInChildren<TTraitEditor>(includeInactive: true);
		WindowMetaTab editorTab = tEditor.getEditorTab();
		if (editorTab.container.getActiveTab() != editorTab)
		{
			editorTab.container.showTab(editorTab);
			yield return new WaitForSeconds(Config.getScrollToGroupDelay());
		}
		foreach (TTraitButton traitButton in tWindow.GetComponentInChildren<TTraitContainer>().getTraitButtons())
		{
			if (traitButton.getElementAsset() == pTraitButton.getElementAsset())
			{
				GameObject pTraitButton2 = traitButton.gameObject;
				tEditor.scrollToGroupStarter(pTraitButton2, pIgnoreTooltipCheck: true);
				break;
			}
		}
	}

	protected virtual IReadOnlyCollection<TTrait> getTraits()
	{
		throw new NotImplementedException();
	}

	protected virtual bool canEditTraits()
	{
		throw new NotImplementedException();
	}

	Transform ISelectedContainerTrait.get_transform()
	{
		return base.transform;
	}
}
