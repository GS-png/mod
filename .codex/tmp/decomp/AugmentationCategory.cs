using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AugmentationCategory<TAugmentation, TAugmentationButton, TAugmentationEditorButton> : MonoBehaviour where TAugmentation : BaseAugmentationAsset where TAugmentationButton : AugmentationButton<TAugmentation> where TAugmentationEditorButton : AugmentationEditorButton<TAugmentationButton, TAugmentation>
{
	public Text title;

	public Text counter;

	public RectTransform height;

	public Transform augmentation_buttons_transform;

	public BaseCategoryAsset asset;

	public List<TAugmentationEditorButton> augmentation_buttons = new List<TAugmentationEditorButton>();

	public void clearDebug()
	{
		for (int i = 0; i < augmentation_buttons_transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(augmentation_buttons_transform.GetChild(i).gameObject);
		}
	}

	public void hideCounter()
	{
		counter.text = "";
		counter.gameObject.SetActive(value: false);
	}

	public void updateCounter()
	{
		int num = 0;
		foreach (TAugmentationEditorButton augmentation_button in augmentation_buttons)
		{
			if (augmentation_button.augmentation_button.isSelected())
			{
				num++;
			}
		}
		string arg = augmentation_buttons.Count.ToString();
		counter.text = $"{num}/{arg}";
	}

	protected virtual bool isUnlocked(TAugmentationButton pButton)
	{
		throw new NotImplementedException();
	}

	private void LateUpdate()
	{
		updateValues();
	}

	private void updateValues()
	{
		Vector2 sizeDelta = height.sizeDelta;
		sizeDelta.y = augmentation_buttons_transform.GetComponent<RectTransform>().sizeDelta.y + 15f;
		height.sizeDelta = sizeDelta;
	}

	public int countActiveButtons()
	{
		int num = 0;
		foreach (TAugmentationEditorButton augmentation_button in augmentation_buttons)
		{
			if (augmentation_button.gameObject.activeSelf)
			{
				num++;
			}
		}
		return num;
	}

	public bool hasAugmentation(TAugmentation pTrait)
	{
		foreach (TAugmentationEditorButton augmentation_button in augmentation_buttons)
		{
			if (augmentation_button.augmentation_button.getElementAsset() == pTrait)
			{
				return true;
			}
		}
		return false;
	}
}
