using UnityEngine;
using UnityEngine.UI;

public class AchievementGoodie : MonoBehaviour
{
	[SerializeField]
	private Image _icon;

	[SerializeField]
	private Text _name;

	public void load(BaseUnlockableAsset pAsset, bool pUnlocked)
	{
		if (pUnlocked)
		{
			loadUnlocked(pAsset);
		}
		else
		{
			loadLocked(pAsset);
		}
	}

	private void loadLocked(BaseUnlockableAsset pAsset)
	{
		_icon.sprite = pAsset.getSprite();
		_icon.color = Toolbox.color_black;
	}

	private void loadUnlocked(BaseUnlockableAsset pAssets)
	{
		_icon.sprite = pAssets.getSprite();
		_name.GetComponent<LocalizedText>().setKeyAndUpdate(pAssets.getLocaleID());
		if (!(pAssets is ActorAsset actorAsset))
		{
			if (pAssets is BaseAugmentationAsset baseAugmentationAsset)
			{
				BaseCategoryAsset baseCategoryAsset = baseAugmentationAsset.getGroup();
				_name.color = baseCategoryAsset?.getColor() ?? Toolbox.color_white;
			}
			else
			{
				_name.color = Toolbox.color_white;
			}
		}
		else
		{
			KingdomAsset kingdomAsset = AssetManager.kingdoms.get(actorAsset.kingdom_id_wild);
			_name.color = kingdomAsset.default_kingdom_color.getColorText();
		}
	}
}
