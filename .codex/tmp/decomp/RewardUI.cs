using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardUI : MonoBehaviour
{
	public Image powerSprite;

	public Text text;

	public Text text_description;

	public Text window_title;

	public Text free_power_unlocked;

	public List<PowerButton> rewardPowers;

	public RewardAnimation rewardAnimation;

	internal void setRewardInfo(List<PowerButton> pButtons)
	{
		rewardPowers = pButtons;
		nextReward();
	}

	internal bool hasRewards()
	{
		if (rewardPowers != null)
		{
			return rewardPowers.Count > 0;
		}
		return false;
	}

	internal PowerButton popLowestReward()
	{
		int num = 10000;
		int index = 0;
		int num2 = 0;
		foreach (PowerButton rewardPower in rewardPowers)
		{
			if ((int)rewardPower.godPower.rank < num)
			{
				index = num2;
				num = (int)rewardPower.godPower.rank;
			}
			num2++;
		}
		PowerButton result = rewardPowers[index];
		rewardPowers.RemoveAt(index);
		return result;
	}

	internal void nextReward()
	{
		if (hasRewards())
		{
			PowerButton powerButton = popLowestReward();
			powerSprite.sprite = powerButton.icon.sprite;
			text.GetComponent<LocalizedText>().setKeyAndUpdate(powerButton.godPower.getLocaleID());
			text_description.gameObject.SetActive(value: true);
			text_description.GetComponent<LocalizedText>().setKeyAndUpdate(powerButton.godPower.getDescriptionID());
			if (powerButton.godPower.id == "clock")
			{
				window_title.GetComponent<LocalizedText>().key = "free_hourglass_title";
				free_power_unlocked.GetComponent<LocalizedText>().key = "free_hourglass_unlocked";
				rewardAnimation.quickReward = true;
			}
			else
			{
				window_title.GetComponent<LocalizedText>().key = "free_power";
				free_power_unlocked.GetComponent<LocalizedText>().key = "free_power_unlocked";
				rewardAnimation.quickReward = false;
			}
			PlayerConfig.instance.data.lastReward = powerButton.godPower.id;
			window_title.GetComponent<LocalizedText>().updateText();
			free_power_unlocked.GetComponent<LocalizedText>().updateText();
		}
	}

	public void bottomButtonClick()
	{
		if (rewardAnimation.state == RewardAnimationState.Open)
		{
			if (hasRewards())
			{
				rewardAnimation.resetAnim();
				nextReward();
			}
			else
			{
				GetComponent<ButtonEvent>().hideRewardWindowAndHighlightPower();
			}
		}
		else if (rewardAnimation.state == RewardAnimationState.Idle)
		{
			rewardAnimation.clickAnimation();
		}
	}

	internal void setRewardInfo(string pSpritePath, string pText)
	{
		powerSprite.sprite = SpriteTextureLoader.getSprite("ui/Icons/" + pSpritePath);
		text.GetComponent<LocalizedText>().key = pText;
		text.GetComponent<LocalizedText>().updateText();
		text_description.gameObject.SetActive(value: false);
		window_title.GetComponent<LocalizedText>().key = "free_saveslots_title";
		window_title.GetComponent<LocalizedText>().updateText();
		free_power_unlocked.GetComponent<LocalizedText>().key = "free_saveslots_unlocked";
		free_power_unlocked.GetComponent<LocalizedText>().updateText();
		rewardAnimation.quickReward = true;
	}
}
