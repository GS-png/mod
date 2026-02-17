using UnityEngine;
using UnityEngine.UI;

public class PopulationPyramidRow : MonoBehaviour
{
	[SerializeField]
	private Image _left_icon;

	[SerializeField]
	private Image _right_icon;

	[SerializeField]
	private PopulationPyramidItem _left_item;

	[SerializeField]
	private PopulationPyramidItem _right_item;

	[SerializeField]
	private Text _text;

	private int _age_group_min;

	private int _age_group_max;

	private void Start()
	{
		base.gameObject.AddOrGetComponent<Button>().onClick.AddListener(animateBars);
		setupTooltip();
	}

	private void setupTooltip()
	{
		if (TryGetComponent<TipButton>(out var component))
		{
			component.setHoverAction(showTooltip, pAddAnimation: false);
		}
	}

	private void showTooltip()
	{
		CustomDataContainer<string> customDataContainer = new CustomDataContainer<string>();
		customDataContainer["age_range"] = _age_group_min + " - " + _age_group_max;
		CustomDataContainer<int> customDataContainer2 = new CustomDataContainer<int>();
		customDataContainer2["males"] = _left_item.getCount();
		customDataContainer2["females"] = _right_item.getCount();
		Tooltip.show(base.gameObject, "gender_data", new TooltipData
		{
			custom_data_string = customDataContainer,
			custom_data_int = customDataContainer2
		});
	}

	private void animateBars()
	{
		_left_item.animateBar();
		_right_item.animateBar();
	}

	internal void setAgeGroup(int pAgeGroup, int pAgeGroupMax)
	{
		_age_group_min = pAgeGroup;
		_age_group_max = pAgeGroupMax;
		_text.text = pAgeGroup.ToString();
		float value = 0.75f + (float)pAgeGroup / 400f;
		value = Mathf.Clamp(value, 0.75f, 1f);
		_left_item.setOpacity(value);
		_right_item.setOpacity(value);
	}

	internal void setColorTextBasedOnAmount(int pAmount)
	{
		if (pAmount == 0)
		{
			_text.color = new Color(1f, 1f, 1f, 0.3f);
		}
		else
		{
			_text.color = new Color(1f, 1f, 1f, 1f);
		}
	}

	internal void setMaleCount(int pCount, int pMax)
	{
		_left_item.setCount(pCount, pMax);
		if (pCount == 0)
		{
			_left_icon.color = new Color(1f, 1f, 1f, 0.3f);
		}
		else
		{
			_left_icon.color = new Color(1f, 1f, 1f, 1f);
		}
	}

	internal void setFemaleCount(int pCount, int pMax)
	{
		_right_item.setCount(pCount, pMax);
		if (pCount == 0)
		{
			_right_icon.color = new Color(1f, 1f, 1f, 0.3f);
		}
		else
		{
			_right_icon.color = new Color(1f, 1f, 1f, 1f);
		}
	}
}
