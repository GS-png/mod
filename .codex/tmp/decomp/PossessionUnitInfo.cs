using UnityEngine;
using UnityEngine.UI;

public class PossessionUnitInfo : MonoBehaviour
{
	[SerializeField]
	private Text _name_field;

	[SerializeField]
	private Image _icon_species;

	[SerializeField]
	private Image _icon_sex;

	[SerializeField]
	private KingdomBanner _banner_kingdom;

	[SerializeField]
	private Text _text_age;

	[SerializeField]
	private Text _text_kills;

	[SerializeField]
	private Text _text_level;

	[SerializeField]
	private StatBar _bar_health;

	private void OnEnable()
	{
		Actor controllableUnit = ControllableUnit.getControllableUnit();
		if (controllableUnit != null)
		{
			showForUnit(controllableUnit);
		}
	}

	private void Update()
	{
		Actor controllableUnit = ControllableUnit.getControllableUnit();
		if (controllableUnit != null)
		{
			showForUnit(controllableUnit);
		}
	}

	private void showForUnit(Actor pActor)
	{
		if (pActor.isSexMale())
		{
			_icon_sex.sprite = SpriteTextureLoader.getSprite("ui/icons/IconMale");
		}
		else
		{
			_icon_sex.sprite = SpriteTextureLoader.getSprite("ui/icons/IconFemale");
		}
		_icon_species.sprite = pActor.asset.getSpriteIcon();
		if (pActor.kingdom.isCiv())
		{
			_banner_kingdom.gameObject.SetActive(value: true);
			_banner_kingdom.load(pActor.kingdom);
		}
		else
		{
			_banner_kingdom.gameObject.SetActive(value: false);
		}
		float pVal = pActor.getHealth();
		float num = pActor.getMaxHealth();
		_bar_health.setBar(pVal, num, "/" + ((int)num).ToText(4), pReset: false, pFloat: false, pUpdateText: true, 0.25f);
		_name_field.text = pActor.getName();
		_name_field.color = pActor.kingdom.getColor().getColorText();
		_text_age.text = pActor.getAge().ToString();
		_text_kills.text = pActor.data.kills.ToString();
		_text_level.text = pActor.level.ToString();
	}
}
