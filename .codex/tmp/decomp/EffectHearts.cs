using UnityEngine;

public class EffectHearts : BaseEffect
{
	internal override void spawnOnTile(WorldTile pTile)
	{
		float pScale = Randy.randomFloat(0.3f, 0.5f);
		prepare(pTile, pScale);
	}

	public override void update(float pElapsed)
	{
		base.update(pElapsed);
		float x = base.transform.position.x;
		float y = base.transform.position.y + pElapsed * 3f / Config.time_scale_asset.multiplier;
		base.transform.position = new Vector3(x, y);
	}
}
