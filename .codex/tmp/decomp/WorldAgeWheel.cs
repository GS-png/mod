using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class WorldAgeWheel : MonoBehaviour
{
	private const int ANGLE_PER_PIECE = 45;

	[SerializeField]
	private Sprite _sprite_arrow;

	[SerializeField]
	private Sprite _sprite_arrow_pause;

	[SerializeField]
	private Image _image_arrow_main;

	[SerializeField]
	private Image _image_arrow_secondary;

	[SerializeField]
	private Transform _arrow_container_main;

	[SerializeField]
	private Transform _arrow_container_secondary;

	[SerializeField]
	private Transform _dimming_container;

	private WorldAgeWheelPiece[] _pieces;

	private Tweener _floating_tween;

	private bool _initialized;

	private float _target_arrow_angle_main;

	private float _target_arrow_angle_secondary;

	private float _current_arrow_angle_main;

	private float _current_arrow_angle_secondary;

	private WorldAgeManager _era_manager => World.world.era_manager;

	private MapStats _map_stats => World.world.map_stats;

	private void Awake()
	{
		_floating_tween = base.transform.DOLocalMoveY(base.transform.localPosition.y - 4f, 2.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
	}

	public void init(WorldAgeElementAction pOnClickAction)
	{
		_initialized = true;
		_pieces = GetComponentsInChildren<WorldAgeWheelPiece>();
		for (int i = 0; i < _pieces.Length; i++)
		{
			WorldAgeWheelPiece obj = _pieces[i];
			obj.mask.alphaHitTestMinimumThreshold = 0.5f;
			obj.init(i);
			obj.setAge(_era_manager.getAgeFromSlot(i));
			obj.addClickCallback(pOnClickAction);
		}
		updateElements();
	}

	private void Update()
	{
		updateArrowAnimation();
	}

	private void updateArrowAnimation()
	{
		setArrowPosition(_arrow_container_main, ref _current_arrow_angle_main, ref _target_arrow_angle_main);
	}

	private void setArrowPosition(Transform pContainer, ref float pCurrentAngle, ref float pTargetAngle)
	{
		pCurrentAngle = Mathf.LerpAngle(pCurrentAngle, pTargetAngle, Time.deltaTime * 5f);
		if (Mathf.Approximately(pCurrentAngle, pTargetAngle))
		{
			pCurrentAngle = pTargetAngle;
		}
		setRotation(pContainer, pCurrentAngle);
	}

	private void finishArrowAnimation()
	{
		_current_arrow_angle_main = _target_arrow_angle_main;
		_current_arrow_angle_secondary = _target_arrow_angle_secondary;
	}

	private void OnEnable()
	{
		_floating_tween.Play();
		if (_initialized)
		{
			updateElements();
		}
		finishArrowAnimation();
		updateArrowAnimation();
	}

	public void updateElements()
	{
		updateArrows();
		updateDimming();
		if (_era_manager.isPaused())
		{
			_image_arrow_main.sprite = _sprite_arrow_pause;
		}
		else
		{
			_image_arrow_main.sprite = _sprite_arrow;
		}
	}

	private void updateArrows()
	{
		float initialAngle = getInitialAngle();
		_target_arrow_angle_main = initialAngle + 22f;
	}

	private void updateDimming()
	{
	}

	private float getInitialAngle()
	{
		return 45 * _era_manager.getCurrentSlotIndex();
	}

	private void setRotation(Transform pElement, float pAngle)
	{
		Quaternion localRotation = Quaternion.AngleAxis(pAngle, Vector3.back);
		pElement.localRotation = localRotation;
	}

	private void OnDisable()
	{
		_floating_tween.Pause();
	}

	public IReadOnlyCollection<WorldAgeWheelPiece> getPieces()
	{
		return (IReadOnlyCollection<WorldAgeWheelPiece>)(object)_pieces;
	}

	public WorldAgeWheelPiece getPiece(int pIndex)
	{
		return _pieces[pIndex];
	}
}
