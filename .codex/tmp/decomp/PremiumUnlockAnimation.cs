using DG.Tweening;
using UnityEngine;

public class PremiumUnlockAnimation : MonoBehaviour
{
	public float time;

	public GameObject circleFX;

	public GameObject shineFX;

	public GameObject aye;

	private CanvasGroup canvasGroup;

	public float fadeDelay;

	private int index;

	public Vector3 scaleAdd;

	public static float scaleTime = 1f;

	public static float delayTime = 0.5f;

	private void Awake()
	{
		aye.transform.localScale = new Vector3(1f, 0f, 1f);
	}

	private void Start()
	{
		canvasGroup = shineFX.GetComponent<CanvasGroup>();
		circleFX.SetActive(value: true);
		circleFX.transform.DOScale(Vector3.one, scaleTime).SetLoops(-1, LoopType.Yoyo);
		aye.transform.DOScale(Vector3.one, scaleTime).SetEase(Ease.OutElastic).SetDelay(delayTime);
	}

	private void Update()
	{
		canvasGroup.alpha += Time.deltaTime / fadeDelay;
		shineFX.transform.Rotate(new Vector3(0f, 0f, 1f));
	}

	public void clickClose()
	{
		circleFX.gameObject.SetActive(value: false);
		shineFX.gameObject.SetActive(value: false);
	}
}
