using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ToolbarArrow : MonoBehaviour
{
	protected const float POSITION_SCROLL_BOUND_BEGIN = 0.1f;

	protected const float POSITION_SCROLL_BOUND_END = 0.98f;

	protected const float POSITION_SCROLL_END = 1f;

	protected const float POSITION_SCROLL_MIN = 0.5f;

	private const float POSITION_UPDATE_SPEED = 2f;

	private const float TWEEN_DURATION = 0.3f;

	[SerializeField]
	private Image arrow;

	[SerializeField]
	protected Vector3 hide_position;

	[SerializeField]
	protected ScrollRectExtended scroll_rect;

	protected float timer;

	protected bool should_show = true;

	protected Transform arrow_transform;

	private Button _button;

	private Tweener _tweener;

	private void Awake()
	{
		arrow_transform = arrow.transform;
		scroll_rect.onValueChanged.AddListener(onScroll);
		_button = arrow.GetComponent<Button>();
		_button.onClick.AddListener(scrollTab);
	}

	protected virtual void onScroll(Vector2 pVal)
	{
		throw new NotImplementedException();
	}

	protected virtual float getEndPosition()
	{
		throw new NotImplementedException();
	}

	protected virtual float getScrollPosition()
	{
		throw new NotImplementedException();
	}

	protected virtual void setScrollPosition(float pValue)
	{
		throw new NotImplementedException();
	}

	protected virtual void Update()
	{
		if (!should_show)
		{
			timer += Time.deltaTime * 2f;
		}
		else
		{
			timer -= Time.deltaTime * 2f;
		}
		timer = Mathf.Clamp(timer, 0f, 1f);
	}

	private void scrollTab()
	{
		float endPosition = getEndPosition();
		_tweener.Kill();
		_tweener = DOTween.To(() => getScrollPosition(), delegate(float pPos)
		{
			setScrollPosition(pPos);
		}, endPosition, 0.3f).SetEase(Ease.InOutCirc);
	}

	private void OnDisable()
	{
		_tweener.Kill(complete: true);
	}
}
