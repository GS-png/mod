using DG.Tweening;
using UnityEngine;

public class TopPremiumButtonMover : MonoBehaviour
{
	public LocalizedText button_text;

	private float target_pos = -1f;

	private float pos_hide;

	private float pos_show = -45f;

	private DOTween _tween;

	private void Update()
	{
		if (shouldShow())
		{
			if (target_pos != pos_show)
			{
				target_pos = pos_show;
				updateRandomText();
				base.transform.GetComponentInChildren<LocalizedTextPrice>().updateText();
				base.transform.DOLocalMoveY(target_pos, 0.5f);
			}
		}
		else if (target_pos != pos_hide)
		{
			target_pos = pos_hide;
			base.transform.DOLocalMoveY(target_pos, 0.5f);
		}
	}

	private void updateRandomText()
	{
		int num = Randy.randomInt(1, 5);
		if (num > 1)
		{
			button_text.key = "premium_get_it_" + num;
		}
		button_text.updateText();
	}

	private bool shouldShow()
	{
		bool result = false;
		if (Config.hasPremium)
		{
			return false;
		}
		string selectedPowerID = World.world.getSelectedPowerID();
		if (!string.IsNullOrEmpty(selectedPowerID) && AssetManager.powers.get(selectedPowerID).requires_premium)
		{
			result = true;
		}
		return result;
	}
}
