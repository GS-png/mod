using UnityEngine;
using UnityEngine.UI;

public class WarTooltipBannersContainer : MonoBehaviour
{
	[SerializeField]
	private KingdomBanner _banner_left;

	[SerializeField]
	private KingdomBanner _banner_right;

	[SerializeField]
	private Image _total_war;

	public void load(War pWar)
	{
		_banner_right.gameObject.SetActive(value: false);
		_banner_left.gameObject.SetActive(value: false);
		_total_war.gameObject.SetActive(value: false);
		Kingdom main_attacker = pWar.main_attacker;
		if (!main_attacker.isRekt())
		{
			_banner_left.gameObject.SetActive(value: true);
			_banner_left.load(main_attacker);
		}
		if (pWar.isTotalWar())
		{
			_total_war.gameObject.SetActive(value: true);
			return;
		}
		Kingdom mainDefender = pWar.getMainDefender();
		if (!mainDefender.isRekt())
		{
			_banner_right.gameObject.SetActive(value: true);
			_banner_right.load(mainDefender);
		}
	}
}
