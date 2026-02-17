using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementGroup : MonoBehaviour
{
	public AchievementButton achievementButtonPrefab;

	private List<AchievementButton> _elements = new List<AchievementButton>();

	public Text title;

	public Text counter;

	public Transform transformContent;

	public void showGroup(AchievementGroupAsset pAchievementGroup)
	{
		title.GetComponent<LocalizedText>().setKeyAndUpdate(pAchievementGroup.getLocaleID());
		title.color = pAchievementGroup.getColor();
		if (pAchievementGroup.achievements_list.Count <= 0)
		{
			return;
		}
		int num = 0;
		foreach (Achievement item in pAchievementGroup.achievements_list)
		{
			AchievementButton achievementButton = Object.Instantiate(achievementButtonPrefab, transformContent);
			achievementButton.Load(item);
			if (AchievementLibrary.isUnlocked(item))
			{
				num++;
			}
			_elements.Add(achievementButton);
		}
		counter.text = num + " / " + pAchievementGroup.achievements_list.Count;
	}
}
