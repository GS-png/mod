using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class RewardAnimation : MonoBehaviour
{
	public Image boxSprite;

	public GameObject rewardTexts;

	public Text Text_free_power_unlocked;

	public Text Text_free_power_tap_to_unlock;

	private IconRotationAnimation _rotation_animation;

	public GameObject rewardedPowerIcon;

	private SpriteAnimation _sprite_animation;

	internal RewardAnimationState state;

	public LocalizedText bottomButtonText;

	private Vector3 _original_pos = Vector3.zero;

	public bool quickReward;

	private Tweener _icon_move_tween;

	private Tweener _icon_scale_tween;

	private Tweener _text_tween;

	public float rewardedPowerScaleTime = 0.45f;

	public float moveTime1 = 0.25f;

	public float moveTime2 = 0.25f;

	public float moveTime3 = 1.5f;

	public float moveTime4 = 1.5f;

	private Transform _icon_transform;

	private Transform _text_transform;

	private void Awake()
	{
		_icon_transform = rewardedPowerIcon.transform;
		_text_transform = rewardTexts.transform;
		_rotation_animation = boxSprite.GetComponent<IconRotationAnimation>();
		_sprite_animation = boxSprite.GetComponent<SpriteAnimation>();
		_sprite_animation.Awake();
		if (_original_pos == Vector3.zero)
		{
			_original_pos = _icon_transform.localPosition;
		}
	}

	public void OnEnable()
	{
		if (_original_pos == Vector3.zero)
		{
			_original_pos = _icon_transform.localPosition;
		}
		bottomButtonText.key = "free_power_button_open_in";
		bottomButtonText.updateText();
		resetAnim();
	}

	private void OnDisable()
	{
		_icon_scale_tween.Kill();
		_icon_move_tween.Kill();
		_text_tween.Kill();
	}

	public void resetAnim()
	{
		state = RewardAnimationState.Idle;
		_sprite_animation.resetAnim(3);
		_rotation_animation.enabled = true;
		_icon_transform.DOKill();
		rewardedPowerIcon.SetActive(value: false);
		rewardTexts.SetActive(value: false);
		Text_free_power_unlocked.gameObject.SetActive(value: false);
		Text_free_power_tap_to_unlock.gameObject.SetActive(value: true);
	}

	private void Update()
	{
		if (quickReward && _sprite_animation.currentFrameIndex < 7)
		{
			_sprite_animation.currentFrameIndex = 7;
			showRewards(pStart: false);
			moveStageThree();
		}
		if (state == RewardAnimationState.Play || state == RewardAnimationState.Open)
		{
			_sprite_animation.update(Time.deltaTime);
			if (_sprite_animation.currentFrameIndex > 6 && state != RewardAnimationState.Open)
			{
				showRewards();
			}
		}
	}

	private void showRewards(bool pStart = true)
	{
		state = RewardAnimationState.Open;
		rewardedPowerIcon.SetActive(value: true);
		_text_tween.Kill();
		_text_transform.localScale = new Vector3(0.5f, 0.5f);
		_text_tween = _text_transform.DOScale(new Vector3(1f, 1f, 1f), 0.3f).SetEase(Ease.OutBack);
		rewardTexts.gameObject.SetActive(value: true);
		Text_free_power_unlocked.gameObject.SetActive(value: true);
		Text_free_power_tap_to_unlock.gameObject.SetActive(value: false);
		bottomButtonText.key = "get_it";
		bottomButtonText.updateText();
		_icon_transform.DOKill();
		_icon_transform.localPosition = _original_pos;
		_icon_transform.localScale = new Vector3(0.02f, 0.1f, 1f);
		if (pStart)
		{
			Vector3 endValue = new Vector3(_original_pos.x, _original_pos.y, 0f);
			endValue.y += 22f;
			_icon_move_tween = _icon_transform.DOLocalMove(endValue, moveTime1).SetEase(Ease.OutCirc).OnComplete(moveStageTwo);
		}
		_icon_scale_tween = _icon_transform.DOScale(new Vector3(0.75f, 0.75f, 1f), rewardedPowerScaleTime).SetEase(Ease.Flash).OnComplete(scaleStageTwo);
	}

	private void moveStageTwo()
	{
		_icon_move_tween.Kill();
		_icon_move_tween = _icon_transform.DOLocalMove(_original_pos, moveTime2).SetEase(Ease.InOutQuad).OnComplete(moveStageThree);
	}

	private void moveStageThree()
	{
		_icon_move_tween.Kill();
		Vector3 endValue = new Vector3(_original_pos.x, _original_pos.y, 1f);
		endValue.y += 3f;
		_icon_move_tween = _icon_transform.DOLocalMove(endValue, moveTime3).SetEase(Ease.InOutQuad).OnComplete(moveStageFour);
	}

	private void moveStageFour()
	{
		_icon_move_tween.Kill();
		_icon_move_tween = _icon_transform.DOLocalMove(_original_pos, moveTime4).SetEase(Ease.InOutQuad).OnComplete(moveStageThree);
	}

	private void scaleStageTwo()
	{
	}

	public void clickAnimation()
	{
		if (_sprite_animation.currentFrameIndex <= 5)
		{
			_sprite_animation.resetAnim();
			_rotation_animation.enabled = false;
			_rotation_animation.transform.localScale = new Vector3(1f, 1f, 1f);
			if (state != RewardAnimationState.Idle)
			{
				resetAnim();
			}
			state = RewardAnimationState.Play;
		}
	}
}
