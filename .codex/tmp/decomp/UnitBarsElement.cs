using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UnitBarsElement : UnitElement
{
	[SerializeField]
	private StatBar _hunger;

	[SerializeField]
	private StatBar _happiness;

	[SerializeField]
	private StatBar _stamina;

	[SerializeField]
	private StatBar _mana;

	[SerializeField]
	private Image _favorite_food_sprite;

	[SerializeField]
	private Image _favorite_food_bg;

	protected override IEnumerator showContent()
	{
		showHappiness();
		showHunger();
		showStamina();
		showMana();
		yield break;
	}

	private void showMana()
	{
		if (!actor.asset.force_hide_mana)
		{
			_mana.gameObject.SetActive(value: true);
			int maxMana = actor.getMaxMana();
			int num = Mathf.Clamp(actor.getMana(), 0, maxMana);
			_mana.setBar(num, maxMana, "/" + maxMana.ToText(4));
		}
	}

	private void showStamina()
	{
		if (!actor.asset.force_hide_stamina)
		{
			_stamina.gameObject.SetActive(value: true);
			int maxStamina = actor.getMaxStamina();
			int num = Mathf.Clamp(actor.getStamina(), 0, maxStamina);
			_stamina.setBar(num, maxStamina, "/" + maxStamina.ToText(4));
		}
	}

	private void showHappiness()
	{
		if (actor.hasEmotions())
		{
			_happiness.GetComponentInChildren<HappinessBarIcon>().load(actor);
			_happiness.gameObject.SetActive(value: true);
			int happinessPercent = actor.getHappinessPercent();
			_happiness.setBar(happinessPercent, 100f, "%");
		}
	}

	private void showHunger()
	{
		if (actor.needsFood())
		{
			_hunger.gameObject.SetActive(value: true);
			int num = (int)((float)actor.getNutrition() / (float)actor.getMaxNutrition() * 100f);
			_hunger.setBar(num, 100f, "%");
			if (actor.hasFavoriteFood())
			{
				_favorite_food_bg.gameObject.SetActive(value: true);
				_favorite_food_sprite.gameObject.SetActive(value: true);
				_favorite_food_sprite.sprite = actor.favorite_food_asset.getSpriteIcon();
			}
		}
	}

	protected override void clear()
	{
		_mana.gameObject.SetActive(value: false);
		_stamina.gameObject.SetActive(value: false);
		_hunger.gameObject.SetActive(value: false);
		_happiness.gameObject.SetActive(value: false);
		_favorite_food_bg.gameObject.SetActive(value: false);
		_favorite_food_sprite.gameObject.SetActive(value: false);
		base.clear();
	}
}
