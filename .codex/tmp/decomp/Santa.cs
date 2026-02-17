using UnityEngine;

public class Santa : BaseEffect
{
	private float _timer_bomb = 1f;

	private float _timer_smoke;

	internal bool alive = true;

	internal Material current_material;

	private float current_height;

	public void spawnOn(WorldTile pTile)
	{
		alive = true;
		current_height = Randy.randomFloat(30f, 50f);
		current_position.Set(pTile.x, (float)pTile.y - current_height);
		current_material = LibraryMaterials.instance.mat_world_object;
		_timer_bomb = 2f + Randy.randomFloat(0f, 2f);
	}

	private void updateSanta(float pElapsed)
	{
		if (current_position.x > (float)(MapBox.width * 2))
		{
			kill();
		}
		else if (alive)
		{
			if (!World.world.isPaused())
			{
				updateSantaMovement();
				updateBombDropTimer(pElapsed);
			}
		}
		else
		{
			updateSantaDeadFall();
			if (current_height == 0f)
			{
				fallDeathEvent();
			}
		}
	}

	public override void update(float pElapsed)
	{
		base.update(pElapsed);
		updateSanta(pElapsed);
		updatePosition();
	}

	public void updatePosition()
	{
		Vector3 localPosition = new Vector3(current_position.x, current_position.y + current_height, current_height);
		base.transform.localPosition = localPosition;
	}

	private void updateBombDropTimer(float pElapsed)
	{
		if (_timer_bomb > 0f)
		{
			_timer_bomb -= pElapsed;
			return;
		}
		_timer_bomb = 2f + Randy.randomFloat(0f, 2f);
		dropSantaBomb();
	}

	private void fallDeathEvent()
	{
		kill();
		EffectsLibrary.spawnAt("fx_land_explosion_old", base.transform.localPosition, 0.6f);
		WorldTile worldTile = World.world.GetTile((int)current_position.x, (int)current_position.y);
		if (worldTile != null)
		{
			MapAction.damageWorld(worldTile, 5, AssetManager.terraform.get("grenade"));
		}
	}

	private void updateSantaDeadFall()
	{
		if (_timer_smoke > 0f)
		{
			_timer_smoke -= World.world.elapsed;
		}
		else
		{
			_timer_smoke = 0.1f;
			EffectsLibrary.spawnAt("fx_fire_smoke", base.transform.position, 0.6f);
		}
		current_position += new Vector2(4f, Randy.randomFloat(-1f, 1f)) * World.world.elapsed;
		current_height -= 20f * World.world.elapsed;
		if (current_height < 0f)
		{
			current_height = 0f;
		}
	}

	private void updateSantaMovement()
	{
		current_position += new Vector2(5f, Randy.randomFloat(-1f, 1f)) * World.world.elapsed;
	}

	private void dropSantaBomb()
	{
		WorldTile worldTile = World.world.GetTile((int)current_position.x, (int)current_position.y);
		if (worldTile != null)
		{
			World.world.drop_manager.spawn(worldTile, "santa_bomb", current_height, -1f, -1L).soundOn = true;
			if (Randy.randomBool())
			{
				MusicBox.playSound("event:/SFX/OTHER/RoboSanta/RoboSantaVoice", current_position.x, current_position.y - current_height);
			}
		}
	}
}
