using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class WorldLawsTextInsult : MonoBehaviour
{
	[SerializeField]
	private Transform _follow_object;

	[SerializeField]
	private RectTransform _size_parent;

	[SerializeField]
	private Text _text;

	private static float _global_wait_timeout;

	private const float RARE_INSULT_CHANCE = 0.005f;

	private float _wait_time;

	private Tweener _text_tweener;

	private string[] _insults_rare = new string[14]
	{
		"UPDATE?", "WHEN", "GEB", "BRE", "REBR", "MODERN?", "HELP", "CAKE", "BRURSE", "MAXIM",
		"MASTEF", "HUGO", "NIKON", "JECO"
	};

	public static void removeInsultTimeout()
	{
		_global_wait_timeout = 0f;
	}

	public void Update()
	{
		if (shouldInsultNow())
		{
			if (_wait_time > 0f)
			{
				_wait_time -= Time.deltaTime;
			}
			else if (_global_wait_timeout > 0f && !isTweening())
			{
				_global_wait_timeout -= Time.deltaTime;
			}
			else if (!isTweening())
			{
				startNewTween();
			}
		}
	}

	private void startNewTween()
	{
		killTweens();
		if (WorldLawLibrary.world_law_cursed_world.isEnabled())
		{
			_global_wait_timeout = 0.6f + Randy.randomFloat(0f, 2f);
		}
		else
		{
			_global_wait_timeout = 2f + Randy.randomFloat(0f, 3f);
		}
		Vector3 euler = new Vector3(0f, 0f, Randy.randomFloat(-30f, 30f));
		_size_parent.localRotation = Quaternion.Euler(euler);
		_text.text = getInsultText();
		_text.transform.position = _follow_object.position + new Vector3(0f, Randy.randomInt(8, 12), 0f);
		_text.fontSize = Randy.randomInt(7, 9);
		Vector3 endValue = _text.transform.position + new Vector3(0f, Randy.randomFloat(30f, 60f), 0f);
		_text_tweener = _text.transform.DOMove(endValue, 6f).SetEase(Ease.OutCubic);
		_text.DOColor(Color.white, 2f).onComplete = doTextFade;
	}

	private string getInsultText()
	{
		if (Randy.randomChance(0.005f))
		{
			return _insults_rare.GetRandom();
		}
		return InsultStringGenerator.getRandomText();
	}

	private void doTextFade()
	{
		_text.DOFade(0f, 2f).onComplete = doWait;
	}

	private bool shouldInsultNow()
	{
		if (!CursedSacrifice.isWorldReadyForCURSE())
		{
			return WorldLawLibrary.world_law_cursed_world.isEnabled();
		}
		return true;
	}

	private bool isTweening()
	{
		return _text_tweener.IsActive();
	}

	private void OnEnable()
	{
		doWait();
	}

	private void doWait()
	{
		killTweens();
		_wait_time = Randy.randomFloat(0f, 7f);
		_text.color = Toolbox.color_white_transparent;
	}

	private void killTweens()
	{
		_text_tweener?.Kill();
		_text.DOKill();
	}
}
