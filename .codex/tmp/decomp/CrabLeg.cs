using UnityEngine;

public class CrabLeg : MonoBehaviour
{
	public CrabLegLimbPoint limbPoint;

	internal Crabzilla crabzilla;

	private Vector3 _current_position;

	private Vector3 _target_position;

	private Vector3 _random_pos = Vector3.zero;

	public CrabLegJoint legJoint;

	private Vector3 _target_pos;

	internal void create()
	{
		_target_position = limbPoint.transform.position;
		_target_position.z = 0f;
		_current_position = _target_position;
		base.transform.position = new Vector3(_target_position.x, _target_position.y, 0f);
		GetComponent<SpriteRenderer>().enabled = false;
	}

	internal void update(float pElapsed)
	{
		float num = Toolbox.DistVec3(_current_position, _target_position);
		_current_position = Vector3.MoveTowards(_current_position, _target_position, 1.5f + num / 5f);
		base.transform.position = new Vector3(_current_position.x, _current_position.y, 0f);
		_target_pos = limbPoint.transform.position + _random_pos;
		if (!legJoint.isAngleOk(-20f, 30f))
		{
			moveLeg();
		}
	}

	public void moveLeg()
	{
		_target_pos = limbPoint.transform.position + _random_pos;
		_target_pos.z = 0f;
		_target_position = _target_pos;
		_random_pos.x = Randy.randomFloat(-1f, 1f);
		_random_pos.y = Randy.randomFloat(-1f, 1f);
		Vector2 vector = ControllableUnit.getMovementVector();
		if (!ControllableUnit.isMovementActionActive())
		{
			vector = Vector2.zero;
		}
		if (vector.x != 0f)
		{
			if (vector.x > 0f)
			{
				_random_pos.x += 2f;
			}
			else
			{
				_random_pos.x -= 2f;
			}
		}
		if (vector.y != 0f)
		{
			if (vector.y > 0f)
			{
				_random_pos.y += 2f;
			}
			else
			{
				_random_pos.y -= 2f;
			}
		}
		crabzilla.legMoved();
		WorldTile tile = World.world.GetTile((int)_target_pos.x, (int)_target_pos.y);
		if (tile != null)
		{
			MapAction.damageWorld(tile, 3, AssetManager.terraform.get("crab_step"));
			MusicBox.playSound("event:/SFX/UNIQUE/Crabzilla/CrabzillaFootsteps", tile);
		}
	}
}
