using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UiGameStat : MonoBehaviour
{
	public Text nameText;

	public Text valueText;

	private LocalizedText _localized_text;

	internal long lastStat;

	internal Tweener curTween;

	private StatisticsAsset _asset;

	private float _timeout;

	private void Awake()
	{
		_localized_text = nameText.GetComponent<LocalizedText>();
	}

	public void setAsset(StatisticsAsset pAsset)
	{
		_asset = pAsset;
	}

	private void Update()
	{
		if (_timeout > 0f)
		{
			_timeout -= Time.deltaTime;
			return;
		}
		_timeout = 1f;
		updateText();
	}

	internal void updateText()
	{
		if (!Config.game_loaded || LocalizedTextManager.instance == null || _asset == null)
		{
			return;
		}
		if (StatsHelper.getStat(_asset.id) > 0)
		{
			long stat = StatsHelper.getStat(_asset.id);
			if (stat != lastStat)
			{
				checkDestroyTween();
				float duration = 0.95f;
				curTween = valueText.DORandomCounter(lastStat, stat, duration);
				lastStat = stat;
			}
		}
		else
		{
			valueText.text = StatsHelper.getStatistic(_asset.id);
		}
		_localized_text.setKeyAndUpdate(_asset.getLocaleID());
		if (LocalizedTextManager.current_language.isRTL())
		{
			nameText.alignment = TextAnchor.MiddleRight;
			valueText.alignment = TextAnchor.MiddleLeft;
		}
		else
		{
			nameText.alignment = TextAnchor.MiddleLeft;
			valueText.alignment = TextAnchor.MiddleRight;
		}
	}

	private void OnEnable()
	{
		updateText();
	}

	private void OnDisable()
	{
		checkDestroyTween();
		lastStat = 0L;
	}

	private void checkDestroyTween()
	{
		if (curTween != null && curTween.active)
		{
			curTween.Complete(withCallbacks: false);
			curTween.Kill();
			curTween = null;
		}
	}
}
