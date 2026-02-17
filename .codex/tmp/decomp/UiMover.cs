using DG.Tweening;
using UnityEngine;

public class UiMover : MonoBehaviour
{
	public bool onVisible;

	public Vector3 initPos;

	public Vector3 hidePos;

	public bool visible;

	public bool initInitPos = true;

	private Tweener _tweener;

	private void Awake()
	{
		if (initInitPos)
		{
			initPos = base.gameObject.transform.localPosition;
		}
	}

	public void setVisible(bool pVisible, bool pNow = false, TweenCallback pCompleteCallback = null)
	{
		visible = pVisible;
		if (pNow)
		{
			if (pVisible)
			{
				base.gameObject.transform.localPosition = initPos;
			}
			else
			{
				base.gameObject.transform.localPosition = hidePos;
			}
		}
		else if (visible)
		{
			if (!onVisible)
			{
				onVisible = true;
				moveTween(initPos, pCompleteCallback);
			}
		}
		else if (onVisible)
		{
			onVisible = false;
			moveTween(hidePos, pCompleteCallback);
		}
	}

	protected void moveTween(Vector3 pVecPos, TweenCallback pCompleteCallback = null)
	{
		float duration = 0.35f;
		_tweener.Kill(complete: true);
		_tweener = base.transform.DOLocalMove(pVecPos, duration).SetDelay(0.02f).SetEase(Ease.InOutCubic)
			.OnComplete(pCompleteCallback);
	}
}
