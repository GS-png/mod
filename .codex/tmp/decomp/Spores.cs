using UnityEngine;

public class Spores : BaseEffect
{
	private const float WALL_CHECKER_MOD_DISTANCE = 0.5f;

	private float _speed_x;

	private float _speed_y;

	private float _life_time;

	private long _actor_parent_id;

	public void setActorParent(Actor pActor)
	{
		_actor_parent_id = pActor.getID();
		PhenotypeAsset randomPhenotypeAsset = pActor.subspecies.getRandomPhenotypeAsset();
		if (randomPhenotypeAsset != null)
		{
			sprite_animation.phenotype = randomPhenotypeAsset;
		}
		else
		{
			PhenotypeAsset default_green = PhenotypeLibrary.default_green;
			sprite_animation.phenotype = default_green;
		}
		sprite_animation.forceUpdateFrame();
		current_position = pActor.current_tile.posV3;
		prepare(pActor.current_position, pActor.actor_scale);
		float pMaxExclusive = pActor.subspecies.base_stats["speed"] / 2f;
		float pMaxExclusive2 = pActor.subspecies.base_stats["lifespan"];
		float num = Mathf.Clamp(Randy.randomFloat(0f, pMaxExclusive), 0f, 10f);
		_speed_x = Randy.randomFloat(0f - num, num);
		_speed_y = Randy.randomFloat(0f - num, num);
		_life_time = Mathf.Clamp(Randy.randomFloat(1f, pMaxExclusive2), 1f, 120f);
	}

	public override void update(float pElapsed)
	{
		base.update(pElapsed);
		if (!World.world.isPaused())
		{
			updateMovement(pElapsed);
			updatePosition();
			updateLifetime(pElapsed);
			if (_life_time <= 0f)
			{
				kill();
			}
		}
	}

	private void updateLifetime(float pElapsed)
	{
		_life_time -= pElapsed;
	}

	public override void kill()
	{
		base.kill();
		Actor actor = World.world.units.get(_actor_parent_id);
		if (actor != null)
		{
			BabyMaker.spawnBabyFromSpore(actor, current_position);
		}
	}

	private void updatePosition()
	{
		base.transform.localPosition = new Vector3(current_position.x, current_position.y, 0f);
	}

	private void updateMovement(float pElapsed)
	{
		float num = _speed_x * pElapsed;
		float num2 = _speed_y * pElapsed;
		Vector3 vector = new Vector3(current_position.x + _speed_x * 0.5f, current_position.y + _speed_y * 0.5f, 0f);
		if (isBlockedByTile(vector))
		{
			_life_time = 0f;
			return;
		}
		current_position.x += num;
		current_position.y += num2;
		vector.x = current_position.x;
		vector.y = current_position.y;
		base.transform.localPosition = vector;
	}

	private bool isBlockedByTile(Vector2 pPos)
	{
		WorldTile worldTile = World.world.GetTile((int)pPos.x, (int)pPos.y);
		if (worldTile == null)
		{
			return false;
		}
		if (worldTile.Type.block)
		{
			return true;
		}
		return false;
	}
}
