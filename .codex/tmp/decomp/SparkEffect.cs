using System.Collections.Generic;
using UnityEngine;

public class SparkEffect : BaseEffect
{
	private const float BASE_ALPHA = 1f;

	private const float BASE_SPEED = 10f;

	private const float RANDOM_OFFSET = 5f;

	[SerializeField]
	private List<SpriteSet> _sprite_sets;

	private float _speed = 10f;

	internal override void prepare(Vector2 pVector, float pScale = 1f)
	{
		base.prepare(pVector, pScale);
		setAlpha(1f);
		sprite_animation.setFrames(_sprite_sets.GetRandom().sprites);
		_speed = 10f + Randy.randomFloat(-5f, 5f);
	}

	public override void update(float pElapsed)
	{
		base.update(pElapsed);
		base.transform.position += new Vector3(0f, _speed * Time.deltaTime, 0f);
	}
}
