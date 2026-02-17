using UnityEngine;

public class StatusParticle : BaseEffect
{
	public void spawnParticle(Vector3 pVector, Color pColor, float pScale = 0.25f)
	{
		base.prepare(pVector, pScale);
		GetComponent<SpriteRenderer>().color = pColor;
	}

	public override void update(float pElapsed)
	{
		base.update(pElapsed);
		setScale(scale - pElapsed * 0.2f);
		if (scale <= 0f)
		{
			kill();
		}
	}
}
