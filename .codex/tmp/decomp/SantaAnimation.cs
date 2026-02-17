using DG.Tweening;
using UnityEngine;

public class SantaAnimation : BaseMapObject
{
	public float shakeX = 2f;

	public float shakeY = 0.3f;

	private Tween shakeTween;

	private Vector3 tStr;

	private Santa santa;

	private SpriteRenderer spriteRenderer;

	internal override void create()
	{
		base.create();
		tStr = new Vector3(shakeX, shakeY);
		shakeTween = base.transform.DOShakePosition(0.5f, tStr, 10, 90f, snapping: false, fadeOut: false);
		santa = base.transform.parent.GetComponent<Santa>();
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		if (santa.alive)
		{
			spriteRenderer.sharedMaterial = santa.current_material;
		}
		else
		{
			spriteRenderer.sharedMaterial = LibraryMaterials.instance.mat_world_object;
		}
		if (!World.world.isPaused() && !shakeTween.active)
		{
			shakeTween = base.transform.DOShakePosition(0.5f, tStr, 10, 90f, snapping: false, fadeOut: false);
		}
	}
}
