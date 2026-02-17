using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ToolbarButtons : MonoBehaviour, IShakable
{
	public static ToolbarButtons instance;

	public Image main_background;

	public Sprite button_sprite_normal;

	public Sprite button_sprite_unit_exists;

	public float shake_duration { get; } = 0.5f;

	public float shake_strength { get; } = 4f;

	public Tweener shake_tween { get; set; }

	public static Sprite getSpriteButtonNormal()
	{
		if (instance == null)
		{
			return null;
		}
		return instance.button_sprite_normal;
	}

	public static Sprite getSpriteButtonUnitExists()
	{
		if (instance == null)
		{
			return null;
		}
		return instance.button_sprite_unit_exists;
	}

	private void Awake()
	{
		instance = this;
	}

	public void resetBar()
	{
		base.gameObject.SetActive(value: false);
		base.gameObject.SetActive(value: true);
	}

	private void Update()
	{
		if (Time.frameCount % 30 == 0)
		{
			PowerButton.checkActorSpawnButtons();
		}
	}

	public Vector3 getPowerBarLeftCornerViewportPos()
	{
		RectTransform rectTransform = main_background.rectTransform;
		Vector3[] array = new Vector3[4];
		rectTransform.GetWorldCorners(array);
		return array[1];
	}

	Transform IShakable.get_transform()
	{
		return base.transform;
	}
}
