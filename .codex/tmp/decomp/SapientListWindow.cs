using UnityEngine;
using UnityEngine.UI;

public class SapientListWindow : ListWindow
{
	[SerializeField]
	private WindowMetaTab _tab_sapients;

	[SerializeField]
	private WindowMetaTab _tab_non_sapients;

	[SerializeField]
	private Text _sapient_counter;

	[SerializeField]
	private Text _non_sapient_counter;

	protected override void initComponent(IComponentList pComponent)
	{
		base.initComponent(pComponent);
		ISapientListComponent obj = (ISapientListComponent)pComponent;
		obj.setSapientCounter(_sapient_counter);
		obj.setNonSapientCounter(_non_sapient_counter);
	}

	protected override void initTabsCallbacks(IComponentList pComponent)
	{
		base.initTabsCallbacks(pComponent);
		ISapientListComponent sapientListComponent = (ISapientListComponent)pComponent;
		LocalizedText tNoItems = getNoItems();
		setTabCallbacks(_tab_sapients, sapientListComponent.setShowSapientOnly);
		_tab_sapients.tab_action.AddListener(delegate
		{
			tNoItems.setKeyAndUpdate("empty_sapient_list");
		});
		setTabCallbacks(_tab_non_sapients, sapientListComponent.setShowNonSapientOnly);
		_tab_non_sapients.tab_action.AddListener(delegate
		{
			tNoItems.setKeyAndUpdate("empty_non_sapient_list");
		});
	}
}
