using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UnitTextPhrases : MonoBehaviour
{
	[SerializeField]
	private RectTransform _size_parent;

	[SerializeField]
	private Text _text;

	private Tweener _text_tweener;

	private void Awake()
	{
		finish();
	}

	public void startNewTween(string pText, Transform pFollowObject)
	{
		base.gameObject.SetActive(value: true);
		killTweens();
		Vector3 euler = new Vector3(0f, 0f, Randy.randomFloat(-30f, 30f));
		_size_parent.localRotation = Quaternion.Euler(euler);
		_text.text = pText;
		Vector3 vector = new Vector3(0f, Randy.randomInt(8, 12), 0f);
		if (pFollowObject == null)
		{
			_text.transform.localPosition = vector;
		}
		else
		{
			_text.transform.position = pFollowObject.position + vector;
		}
		_text.fontSize = Randy.randomInt(7, 9);
		Vector3 vector2 = new Vector3(0f, Randy.randomFloat(30f, 60f), 0f);
		_text_tweener.Kill();
		if (pFollowObject == null)
		{
			_text_tweener = _text.transform.DOLocalMove(vector2, 3f);
		}
		else
		{
			_text_tweener = _text.transform.DOMove(vector2 + pFollowObject.position, 3f);
		}
		_text_tweener.SetEase(Ease.OutCubic);
		_text.DOColor(Color.white, 1.25f).onComplete = doTextFade;
	}

	private void doTextFade()
	{
		_text.DOFade(0f, 2f).onComplete = finish;
	}

	public bool isTweening()
	{
		return _text_tweener.IsActive();
	}

	private void finish()
	{
		killTweens();
		_text.color = Toolbox.color_white_transparent;
		base.gameObject.SetActive(value: false);
	}

	private void killTweens()
	{
		_text_tweener?.Kill();
		_text.DOKill();
	}
}
