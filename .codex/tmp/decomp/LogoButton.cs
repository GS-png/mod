using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LogoButton : MonoBehaviour
{
	private List<UiCreature> listLetters;

	private float initScale = 1f;

	private Tweener tweener;

	private void Awake()
	{
		initScale = base.transform.localScale.x;
		loadLetters();
	}

	private void loadLetters()
	{
		listLetters = new List<UiCreature>();
		Transform transform = base.transform.FindRecursive("Letters").transform;
		int childCount = transform.childCount;
		for (int i = 0; i < childCount; i++)
		{
			UiCreature component = transform.GetChild(i).GetComponent<UiCreature>();
			if (component.dropped)
			{
				component.resetPosition();
			}
			listLetters.Add(component);
		}
	}

	private void letterFall()
	{
		if (listLetters.Count == 0)
		{
			loadLetters();
			AchievementLibrary.destroy_worldbox.check();
			return;
		}
		listLetters.ShuffleOne();
		UiCreature uiCreature = listLetters[0];
		listLetters.RemoveAt(0);
		uiCreature.click();
	}

	public void clickLogo()
	{
		MusicBox.playSound("event:/SFX/EXPLOSIONS/ExplosionHuge");
		if (tweener != null && tweener.active)
		{
			tweener.Kill();
		}
		float num = initScale * 1.2f;
		if (listLetters.Count == 0)
		{
			num = 1.6f;
			base.transform.localScale = new Vector3(num, num, num);
			tweener = base.transform.DOScale(new Vector3(initScale, initScale, initScale), 0.3f).SetEase(Ease.OutBack);
		}
		else
		{
			base.transform.localScale = new Vector3(num, num, num);
			tweener = base.transform.DOScale(new Vector3(initScale, initScale, initScale), 0.3f).SetEase(Ease.OutBack);
		}
		letterFall();
	}
}
