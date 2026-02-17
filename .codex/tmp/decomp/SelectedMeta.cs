using UnityEngine;

public class SelectedMeta<TMeta, TMetaData> : SelectedNano<TMeta> where TMeta : MetaObject<TMetaData>, IFavoriteable where TMetaData : MetaObjectData
{
	[SerializeField]
	protected BannerGeneric<TMeta, TMetaData> banner;

	protected virtual MetaType meta_type { get; }

	protected string window_id => AssetManager.meta_type_library.getAsset(meta_type).window_name;

	protected override void updateElements(TMeta pNano)
	{
		if (!pNano.isRekt())
		{
			base.updateElements(pNano);
			checkShowBanner();
		}
	}

	protected override void showStatsGeneral(TMeta pMeta)
	{
		setName(pMeta);
		setTitleIcons(pMeta);
		showGeneralIcons(pMeta);
	}

	protected virtual void setName(TMeta pMeta)
	{
		name_field.text = pMeta.name;
		name_field.color = pMeta.getColor().getColorText();
	}

	protected virtual void setTitleIcons(TMeta pMeta)
	{
		Sprite spriteIcon = pMeta.getSpriteIcon();
		icon_right.sprite = spriteIcon;
	}

	protected virtual void checkShowBanner()
	{
		banner.load(nano_object);
	}

	protected void showGeneralIcons(TMeta pMeta)
	{
		StatsIconContainer[] array = stats_icons;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].showGeneralIcons<TMeta, TMetaData>(pMeta);
		}
	}

	public void openInfoTab()
	{
		ScrollWindow.showWindow(window_id);
		ScrollWindow.getCurrentWindow().tabs.showTab("Info");
	}

	public void openTraitsEditorTab()
	{
		ScrollWindow.showWindow(window_id);
		ScrollWindow.getCurrentWindow().tabs.showTab("Traits");
	}

	public void openFamiliesTab()
	{
		ScrollWindow.showWindow(window_id);
		ScrollWindow.getCurrentWindow().tabs.showTab("Families");
	}

	public void openInterestingPeopleTab()
	{
		ScrollWindow.showWindow(window_id);
		ScrollWindow.getCurrentWindow().tabs.showTab("Interesting People");
	}

	public void openPyramidTab()
	{
		ScrollWindow.showWindow(window_id);
		ScrollWindow.getCurrentWindow().tabs.showTab("Pyramid");
	}

	public void openStatisticsTab()
	{
		ScrollWindow.showWindow(window_id);
		ScrollWindow.getCurrentWindow().tabs.showTab("Statistics");
	}
}
