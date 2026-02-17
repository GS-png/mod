using UnityEngine;

public class SpriteShadow : MonoBehaviour
{
	public Vector2 offset = new Vector2(-3f, 3f);

	internal int z_height;

	private SpriteRenderer sprRndCaster;

	private SpriteRenderer sprRndShadow;

	private Transform transCaster;

	private Transform transShadow;

	public Color shadowColor;

	private BaseMapObject baseMapObject;

	private void Start()
	{
		baseMapObject = GetComponent<BaseMapObject>();
		transCaster = base.transform;
		transShadow = new GameObject().transform;
		transShadow.parent = transCaster;
		transShadow.gameObject.name = "Shadow";
		transShadow.localRotation = Quaternion.identity;
		transShadow.localScale = new Vector3(1f, 0.5f);
		sprRndCaster = GetComponent<SpriteRenderer>();
		sprRndShadow = transShadow.gameObject.AddComponent<SpriteRenderer>();
		sprRndShadow.sharedMaterial = LibraryMaterials.instance.mat_world_object;
		sprRndShadow.color = shadowColor;
		sprRndShadow.sortingLayerName = sprRndCaster.sortingLayerName;
		sprRndShadow.sortingOrder = sprRndCaster.sortingOrder - 1;
	}

	private void LateUpdate()
	{
		transShadow.position = new Vector2(transCaster.position.x + offset.x, transCaster.position.y + offset.y);
		Color color = shadowColor;
		color.a = sprRndCaster.color.a * 0.5f;
		sprRndShadow.color = color;
		sprRndShadow.sprite = sprRndCaster.sprite;
		sprRndShadow.flipX = sprRndCaster.flipX;
	}
}
