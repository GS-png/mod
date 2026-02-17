using DG.Tweening;
using UnityEngine;

public class CornerAye : MonoBehaviour
{
	public static CornerAye instance;

	public Transform sprite;

	private RectTransform _rect;

	private void Awake()
	{
		_rect = sprite.GetComponent<RectTransform>();
		reset();
	}

	private void reset()
	{
		_rect.anchoredPosition = new Vector2(100f, 0f);
		sprite.transform.DOKill();
	}

	private void Start()
	{
		instance = this;
	}

	public void startAye()
	{
		reset();
		float duration = 0.3f;
		sprite.transform.DOLocalMove(default(Vector3), duration).SetEase(Ease.OutBack).onComplete = moveBack;
	}

	private void moveBack()
	{
		Vector3 endValue = new Vector3(100f, 0f);
		float duration = 0.3f;
		sprite.transform.DOLocalMove(endValue, duration).SetEase(Ease.InOutQuad).SetDelay(0.1f);
	}
}
