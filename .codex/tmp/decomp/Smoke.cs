using UnityEngine;

public class Smoke : BaseEffect
{
	private float timer_scale;

	private void Update()
	{
		if (timer_scale > 0f)
		{
			timer_scale -= World.world.elapsed;
			return;
		}
		timer_scale = 0.01f;
		setAlpha(alpha - 0.01f);
		if (alpha <= 0f)
		{
			controller.killObject(this);
			return;
		}
		if (base.transform.localScale.x < 4f)
		{
			base.transform.localScale = new Vector3(base.transform.localScale.x + 0.03f, base.transform.localScale.y + 0.03f);
		}
		base.transform.localPosition = new Vector3(base.transform.localPosition.x + World.world.wind_direction.x * 0.5f, base.transform.localPosition.y + World.world.wind_direction.y * 0.5f);
	}
}
