using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PopulationPyramidItem : MonoBehaviour
{
	[SerializeField]
	private RectTransform _mask;

	[SerializeField]
	private RectTransform _bar;

	[SerializeField]
	private Image _bar_image;

	[SerializeField]
	private Text _count_text;

	[SerializeField]
	private float _bar_width = 80f;

	[SerializeField]
	private int _count;

	[SerializeField]
	private int _max_count;

	[SerializeField]
	private float _percent;

	[SerializeField]
	private float _calc_percent;

	private Tweener _cur_tween;

	private void Awake()
	{
		resetBar();
	}

	private void Start()
	{
		base.gameObject.AddOrGetComponent<Button>().onClick.AddListener(animateBar);
	}

	internal void setCount(int pCount, int pMax)
	{
		_count_text.text = pCount.ToString();
		Color color = _count_text.color;
		if (pCount == 0)
		{
			color.a = 0.5f;
		}
		else
		{
			color.a = 1f;
		}
		_count_text.color = color;
		_count = pCount;
		_max_count = pMax;
		animateBar();
	}

	internal int getCount()
	{
		return _count;
	}

	private void resetBar()
	{
		checkDestroyTween();
		_bar.sizeDelta = new Vector2(0.1f, _bar.sizeDelta.y);
	}

	internal void setOpacity(float pOpacity)
	{
		Color color = _bar_image.color;
		color.a = pOpacity;
		_bar_image.color = color;
	}

	internal void animateBar()
	{
		resetBar();
		_percent = (float)_count / (float)_max_count;
		if (_count > 0)
		{
			_calc_percent = 4f + Mathf.Floor(_percent * _bar_width);
		}
		else
		{
			_calc_percent = 0f;
		}
		_cur_tween = _bar.DOSizeDelta(new Vector2(_calc_percent, _bar.sizeDelta.y), 0.3f);
	}

	private void OnDisable()
	{
		checkDestroyTween();
	}

	private void checkDestroyTween()
	{
		if (_cur_tween.IsActive())
		{
			_cur_tween.Complete(withCallbacks: false);
			_cur_tween.Kill();
		}
		_cur_tween = null;
	}
}
