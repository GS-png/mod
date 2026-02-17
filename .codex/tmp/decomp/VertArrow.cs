using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class VertArrow : MonoBehaviour
{
	public Image arrow;

	private Transform _arrow_transform;

	public Vector3 hidPos;

	public bool isLeft = true;

	public ScrollRectExtended scrollRect;

	public RectTransform contentContainer;

	private float timer;

	private bool shouldShow = true;

	private Button button;

	private Tweener _tweener;

	private void Awake()
	{
		_arrow_transform = arrow.transform;
		scrollRect.onValueChanged.AddListener(onScroll);
		button = arrow.GetComponent<Button>();
		button.onClick.AddListener(scrollTab);
	}

	private void onScroll(Vector2 pVal)
	{
		shouldShow = true;
		if (contentContainer.rect.width < scrollRect.rectTransform.rect.width)
		{
			shouldShow = false;
		}
		else if (isLeft)
		{
			if (scrollRect.horizontalNormalizedPosition > 0.1f)
			{
				shouldShow = true;
			}
			else
			{
				shouldShow = false;
			}
		}
		else if (scrollRect.horizontalNormalizedPosition == 1f)
		{
			shouldShow = false;
		}
		else if (scrollRect.horizontalNormalizedPosition < 0.98f)
		{
			shouldShow = true;
		}
		else
		{
			shouldShow = false;
		}
	}

	private void Update()
	{
		if (!shouldShow)
		{
			timer += Time.deltaTime * 2f;
		}
		else
		{
			timer -= Time.deltaTime * 2f;
		}
		timer = Mathf.Clamp(timer, 0f, 1f);
		float num = iTween.easeInOutCirc(0f, hidPos.x, timer);
		if (_arrow_transform.localPosition.x != num)
		{
			_arrow_transform.localPosition = new Vector3(num, 0f);
		}
	}

	private void scrollTab()
	{
		float horizontalNormalizedPosition = scrollRect.horizontalNormalizedPosition;
		float a = scrollRect.rectTransform.rect.width / scrollRect.content.rect.width;
		horizontalNormalizedPosition = ((!isLeft) ? (horizontalNormalizedPosition + Mathf.Min(a, 0.5f)) : (horizontalNormalizedPosition - Mathf.Min(a, 0.5f)));
		_tweener.Kill();
		_tweener = DOTween.To(() => scrollRect.horizontalNormalizedPosition, delegate(float pPos)
		{
			scrollRect.horizontalNormalizedPosition = pPos;
		}, horizontalNormalizedPosition, 0.3f).SetEase(Ease.InOutCirc);
	}

	private void OnDisable()
	{
		_tweener.Kill(complete: true);
	}
}
