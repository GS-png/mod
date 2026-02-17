using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class AchievementPopup : MonoBehaviour
{
	private static AchievementPopup _instance;

	[SerializeField]
	private Image _icon_left;

	[SerializeField]
	private Image _icon_right;

	[SerializeField]
	private Text _popup_text;

	[SerializeField]
	private Text _popup_description;

	[SerializeField]
	private AchievementGoodie _goodie_prefab;

	[SerializeField]
	private Transform _goodies_parent;

	private ObjectPoolGenericMono<AchievementGoodie> _goodie_pool;

	private Tweener _tween;

	private void Awake()
	{
		_instance = this;
		hide();
	}

	internal static void show(string pAchievementID)
	{
		_instance.showByID(pAchievementID);
	}

	internal static void show(Achievement pAchievement)
	{
		_instance.showByID(pAchievement.id);
	}

	private void Update()
	{
		World.world.spawnCongratulationFireworks();
	}

	internal void showByID(string pAchievementID)
	{
		if (_tween != null && _tween.active)
		{
			return;
		}
		base.gameObject.SetActive(value: true);
		checkPool();
		Achievement achievement = AssetManager.achievements.get(pAchievementID);
		Sprite icon = achievement.getIcon();
		if (icon != null)
		{
			_icon_left.sprite = icon;
			_icon_right.sprite = icon;
		}
		_popup_text.GetComponent<LocalizedText>().setKeyAndUpdate(achievement.getLocaleID());
		_popup_description.GetComponent<LocalizedText>().setKeyAndUpdate(achievement.getDescriptionID());
		float num = ((float)Screen.height - Screen.safeArea.height) / CanvasMain.instance.canvas_ui.scaleFactor;
		_tween = base.transform.DOLocalMoveY(0f - num, 1f).SetEase(Ease.OutBack).SetDelay(0.2f)
			.OnComplete(tweenHide);
		if (!achievement.unlocks_something)
		{
			return;
		}
		foreach (BaseUnlockableAsset unlock_asset in achievement.unlock_assets)
		{
			if (unlock_asset.show_for_unlockables_ui)
			{
				_goodie_pool.getNext().load(unlock_asset, pUnlocked: true);
			}
		}
	}

	public void forceHide()
	{
		if (_tween != null)
		{
			_tween.Kill();
		}
		_tween = base.transform.DOLocalMoveY(200f, 0.5f).SetEase(Ease.OutBack).OnComplete(hide);
	}

	private void tweenHide()
	{
		_tween = base.transform.DOLocalMoveY(200f, 1f).SetDelay(4f).SetEase(Ease.OutBack)
			.OnComplete(hide);
	}

	private void hide()
	{
		base.gameObject.SetActive(value: false);
		_goodie_pool?.clear();
	}

	private void checkPool()
	{
		if (_goodie_pool == null)
		{
			_goodie_pool = new ObjectPoolGenericMono<AchievementGoodie>(_goodie_prefab, _goodies_parent);
		}
	}
}
