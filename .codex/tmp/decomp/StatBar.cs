using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class StatBar : MonoBehaviour
{
	public Text textField;

	public RectTransform mask;

	public RectTransform bar;

	private Tweener _bar_tween;

	private Tweener _text_tween;

	private float _val;

	private float _max = 100f;

	private string _ending;

	private bool _float;

	public StatBarUpdated _bar_updated_action;

	private void OnEnable()
	{
		restartBar();
	}

	private void Start()
	{
		restartBar();
		base.gameObject.AddOrGetComponent<Button>().onClick.AddListener(restartBar);
	}

	private void restartBar()
	{
		setBar(_val, _max, _ending, pReset: true, _float);
	}

	private void resetSize()
	{
		float x = Mathf.Floor(0.01f * mask.rect.width);
		bar.sizeDelta = new Vector2(x, bar.sizeDelta.y);
		textField.text = "0";
	}

	public void resetTween()
	{
		checkDestroyTween(pComplete: false);
		_val = 0f;
		resetSize();
	}

	private void OnRectTransformDimensionsChange()
	{
		restartBar();
	}

	public void setBar(float pVal, float pMax, string pEnding, bool pReset = true, bool pFloat = false, bool pUpdateText = true, float pSpeed = 0.3f)
	{
		if (pMax == 0f)
		{
			resetTween();
			textField.text = "-";
		}
		else
		{
			if (!pReset && pVal == _val && pMax == _max && pEnding == _ending)
			{
				return;
			}
			if (pReset)
			{
				resetTween();
			}
			_max = pMax;
			_ending = pEnding;
			_float = pFloat;
			checkDestroyTween(pComplete: false);
			if (pReset)
			{
				_bar_tween = bar.DOSizeDelta(new Vector2(0f, bar.sizeDelta.y), 0.005f).OnComplete(delegate
				{
					float x2 = Mathf.Floor(pVal / pMax * mask.rect.width);
					_bar_tween = bar.DOSizeDelta(new Vector2(x2, bar.sizeDelta.y), pSpeed);
				});
			}
			else
			{
				float x = Mathf.Floor(pVal / pMax * mask.rect.width);
				_bar_tween = bar.DOSizeDelta(new Vector2(x, bar.sizeDelta.y), pSpeed);
			}
			if (pUpdateText)
			{
				if (pFloat)
				{
					_text_tween = textField.DOUpCounter(_val, pVal, pSpeed, pEnding);
				}
				else
				{
					_text_tween = textField.DOUpCounter((int)_val, (int)pVal, pSpeed, pEnding);
				}
			}
			_val = pVal;
			_bar_updated_action?.Invoke(pVal, pMax);
		}
	}

	private void OnDisable()
	{
		checkDestroyTween();
	}

	private void checkDestroyTween(bool pComplete = true)
	{
		if (_bar_tween.IsActive())
		{
			_bar_tween.Complete(pComplete);
			_bar_tween.Kill(pComplete);
			_bar_tween = null;
		}
		if (_text_tween.IsActive())
		{
			_text_tween.Complete(pComplete);
			_text_tween.Kill(pComplete);
			_text_tween = null;
		}
	}

	public void addCallback(StatBarUpdated pAction)
	{
		_bar_updated_action = (StatBarUpdated)Delegate.Combine(_bar_updated_action, pAction);
	}

	public void removeCallback(StatBarUpdated pAction)
	{
		_bar_updated_action = (StatBarUpdated)Delegate.Remove(_bar_updated_action, pAction);
	}
}
