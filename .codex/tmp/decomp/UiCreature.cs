using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UiCreature : MonoBehaviour
{
	public bool doFall;

	public bool doRotate;

	public bool doScale = true;

	public bool doFly;

	public bool doPlayPunch;

	public bool changeParent = true;

	public string doSfx = "none";

	private Tweener tweener_scale;

	private Tweener tweener_rotation;

	private Tweener tweener_move;

	private Vector3 _init_scale = Vector3.one;

	internal bool dropped;

	public string achievement = "";

	private Vector3 _initial_pos;

	private Quaternion _initial_rotation;

	private Transform _original_parent;

	private bool _forced_complete;

	private void Awake()
	{
		_original_parent = base.transform.parent;
		_init_scale = base.transform.localScale;
		_initial_pos = base.transform.localPosition;
		_initial_rotation = base.transform.rotation;
	}

	private void Start()
	{
		if (!base.gameObject.HasComponent<Button>())
		{
			base.gameObject.AddComponent<Button>().onClick.AddListener(click);
		}
	}

	private void killTweens(bool pComplete = false)
	{
		if (pComplete)
		{
			_forced_complete = true;
		}
		tweener_scale.Kill(pComplete);
		tweener_rotation.Kill(pComplete);
		tweener_move.Kill(pComplete);
		_forced_complete = false;
	}

	internal void resetPosition()
	{
		killTweens();
		dropped = false;
		base.transform.rotation = _initial_rotation;
		base.transform.localPosition = _initial_pos;
		base.transform.localScale = _init_scale;
		base.gameObject.SetActive(value: true);
	}

	public void click()
	{
		if (dropped)
		{
			return;
		}
		killTweens();
		if (this.HasComponent<HoveringIcon>())
		{
			GetComponent<HoveringIcon>().clear();
		}
		if (this.HasComponent<LivingIcon>())
		{
			GetComponent<LivingIcon>().kill();
		}
		if (!string.IsNullOrEmpty(achievement))
		{
			AchievementLibrary.unlock(achievement);
		}
		if (doPlayPunch)
		{
			MusicBox.playSound("event:/SFX/OTHER/Punch");
		}
		if (doSfx != "none" && !string.IsNullOrEmpty(doSfx) && doSfx.Contains("event:"))
		{
			MusicBox.playSound(doSfx);
		}
		if (doScale)
		{
			Vector3 localScale = _init_scale * 1.2f;
			base.transform.localScale = localScale;
			tweener_scale = base.transform.DOScale(_init_scale, 0.3f).SetEase(Ease.OutBack);
		}
		if (doFall)
		{
			fall();
		}
		if (doFly)
		{
			flyAway();
		}
		if (doRotate)
		{
			if (Randy.randomBool())
			{
				tweener_rotation = base.transform.DORotate(new Vector3(0f, 0f, Randy.randomFloat(90f, 180f)), 1f).SetEase(Ease.OutCubic);
			}
			else
			{
				tweener_rotation = base.transform.DORotate(new Vector3(0f, 0f, Randy.randomFloat(-180f, -90f)), 1f).SetEase(Ease.OutCubic);
			}
		}
	}

	private void flyAway()
	{
		dropped = true;
		if (changeParent)
		{
			base.transform.parent = CanvasMain.instance.canvas_tooltip.transform;
		}
		tweener_move = ShortcutExtensions.DOMove(endValue: new Vector3(base.transform.position.x + Randy.randomFloat(-200f, 200f), 1000f, 0f), target: base.transform, duration: 0.6f).SetEase(Ease.InQuad).OnComplete(completeFly);
	}

	private void fall()
	{
		dropped = true;
		if (changeParent)
		{
			base.transform.SetParent(CanvasMain.instance.canvas_tooltip.transform);
		}
		tweener_move = ShortcutExtensions.DOMove(endValue: new Vector3(base.transform.position.x + Randy.randomFloat(-4f, 4f), base.transform.position.y - (float)Screen.height, 0f), target: base.transform, duration: 0.6f).SetEase(Ease.InQuad).OnComplete(completeFall);
	}

	private void completeFly()
	{
		base.transform.SetParent(_original_parent);
		base.gameObject.SetActive(value: false);
	}

	private void completeFall()
	{
		if (_forced_complete)
		{
			base.gameObject.SetActive(value: false);
			return;
		}
		base.transform.SetParent(_original_parent);
		MusicBox.playSound("event:/SFX/HIT/HitStone");
		base.gameObject.SetActive(value: false);
	}

	private void OnEnable()
	{
		resetPosition();
	}

	private void OnDisable()
	{
		killTweens(pComplete: true);
	}
}
