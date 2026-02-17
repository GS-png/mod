using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class UiButtonHoverAnimation : MonoBehaviour
{
	private Button button;

	public Vector3 default_scale;

	public float scale_size = 1.1f;

	public static float scaleTime = 0.1f;

	private void Awake()
	{
		button = GetComponent<Button>();
		default_scale = base.gameObject.transform.localScale;
	}

	private void Start()
	{
		button.OnHover(startAnim);
	}

	private void startAnim()
	{
		float num = default_scale.x * scale_size;
		base.transform.localScale = new Vector3(num, num, num);
		base.transform.DOKill();
		base.transform.DOScale(default_scale, scaleTime).SetEase(Ease.InBack);
	}

	private void OnDestroy()
	{
		base.transform.DOKill();
	}
}
