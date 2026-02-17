using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TweenedColoredText : MonoBehaviour
{
	public Color color1 = Color.blue;

	public Color color2 = Color.red;

	public float duration = 1f;

	private Text _text;

	private void Awake()
	{
		_text = GetComponent<Text>();
	}

	private void OnEnable()
	{
		_text.DOKill(complete: true);
		_text.color = color1;
		_text.DOColor(color2, duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
	}
}
