using UnityEngine;

namespace ai.behaviours;

public class BehThrowResourceAnimation : BehCityActor
{
	private string _resource_id;

	public BehThrowResourceAnimation(string pResourceId)
	{
		_resource_id = pResourceId;
	}

	protected override void setupErrorChecks()
	{
		base.setupErrorChecks();
		check_building_target_non_usable = true;
		null_check_building_target = true;
	}

	public override BehResult execute(Actor pActor)
	{
		Building beh_building_target = pActor.beh_building_target;
		float a = Toolbox.DistTile(pActor.current_tile, beh_building_target.current_tile);
		a = Mathf.Max(a, 1f);
		if (a > 1.5f)
		{
			a = 1.5f;
		}
		if (pActor.is_visible)
		{
			float pDuration = a;
			Vector2 pStart = pActor.getThrowStartPosition();
			Vector2 pEnd = beh_building_target.current_position + beh_building_target.asset.stockpile_center_offset;
			pEnd.x += Randy.randomFloat(-0.1f, 0.1f);
			pEnd.y += Randy.randomFloat(-0.1f, 0.1f);
			BehaviourActionBase<Actor>.world.resource_throw_manager.addNew(pStart, pEnd, pDuration, _resource_id, 1, 2f, beh_building_target);
		}
		return BehResult.Continue;
	}
}
