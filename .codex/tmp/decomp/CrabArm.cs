using System.Collections.Generic;
using UnityEngine;

public class CrabArm : MonoBehaviour
{
	internal Crabzilla crabzilla;

	public SpriteRenderer laser;

	public Transform laserPoint;

	public GameObject joint;

	public List<Sprite> laserSprites;

	public bool mirrored;

	private const float LASER_INTERVAL = 0.07f;

	private float _laser_timer = 0.07f;

	private int _laser_frame_index;

	private void Start()
	{
		laser.enabled = false;
	}

	internal void update(float pElapsed)
	{
		Vector3 vector = World.world.camera.WorldToScreenPoint(crabzilla.armTarget.transform.position);
		vector.z = 5.23f;
		Vector3 vector2 = World.world.camera.WorldToScreenPoint(joint.transform.position);
		vector.x -= vector2.x;
		vector.y -= vector2.y;
		float num = Mathf.Atan2(vector.y, vector.x) * 57.29578f + 90f;
		if (mirrored)
		{
			num += 180f;
		}
		joint.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, num));
		updateLaser(pElapsed);
		if (crabzilla.isBeamEnabled())
		{
			float x = laserPoint.transform.position.x;
			float y = laserPoint.transform.position.y;
			MusicBox.inst.playDrawingSound("event:/SFX/UNIQUE/Crabzilla/CrabzillaLazer", x, y);
			World.world.stack_effects.light_blobs.Add(new LightBlobData
			{
				position = new Vector2(laser.transform.position.x, laser.transform.position.y),
				radius = 1.5f
			});
			if (_laser_frame_index > 6 && _laser_frame_index < 10)
			{
				damageWorld();
			}
		}
	}

	private void damageWorld()
	{
		float x = laserPoint.transform.position.x;
		float y = laserPoint.transform.position.y;
		WorldTile tile = World.world.GetTile((int)x, (int)y);
		if (tile != null)
		{
			MapAction.damageWorld(tile, 4, AssetManager.terraform.get("crab_laser"));
		}
	}

	private void updateLaser(float pTime)
	{
		_laser_timer -= pTime;
		if (crabzilla.isBeamEnabled())
		{
			if (_laser_timer <= 0f)
			{
				_laser_frame_index++;
				if (_laser_frame_index >= 10)
				{
					_laser_frame_index = 6;
				}
			}
		}
		else if (_laser_frame_index != 0)
		{
			_laser_frame_index++;
			if (_laser_frame_index > 13)
			{
				_laser_frame_index = 0;
			}
		}
		if (_laser_timer <= 0f)
		{
			_laser_timer = 0.07f;
		}
		if (laser.sprite.name != laserSprites[_laser_frame_index].name)
		{
			laser.sprite = laserSprites[_laser_frame_index];
		}
		laser.enabled = _laser_frame_index != 0 || crabzilla.isBeamEnabled();
	}
}
