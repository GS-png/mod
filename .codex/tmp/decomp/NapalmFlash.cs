using UnityEngine;

public class NapalmFlash : BaseEffect
{
	private bool killing;

	private bool bombSpawned;

	internal void spawnFlash(WorldTile pTile)
	{
		tile = pTile;
		bombSpawned = false;
		killing = false;
		prepare(pTile, 0.1f);
	}

	public static bool napalmEffect(WorldTile pTile, string pPowerID)
	{
		pTile.startFire(pForce: true);
		return true;
	}

	private void Update()
	{
		if (base.transform.localScale.x < 1f && !killing)
		{
			Vector3 localScale = base.transform.localScale;
			localScale.x += World.world.elapsed * 0.7f;
			if (localScale.x >= 0.6f && !bombSpawned)
			{
				bombSpawned = true;
				World.world.loopWithBrush(tile, Brush.get(12), napalmEffect);
			}
			if (localScale.x >= 0.7f)
			{
				localScale.x = 0.7f;
				killing = true;
			}
			localScale.y = localScale.x;
			base.transform.localScale = localScale;
		}
		else if (killing)
		{
			Vector3 localScale2 = base.transform.localScale;
			localScale2.x -= World.world.elapsed * 1.5f;
			localScale2.y = localScale2.x;
			if (localScale2.x <= 0f)
			{
				localScale2.x = 0f;
				kill();
			}
			base.transform.localScale = localScale2;
		}
	}
}
