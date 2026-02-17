using UnityEngine;

namespace ai.behaviours;

public class BehSpawnHeartsFromBuilding : BehaviourActionActor
{
	private float _amount;

	public BehSpawnHeartsFromBuilding(float pAmount = 1f)
	{
		_amount = pAmount;
	}

	protected override void setupErrorChecks()
	{
		base.setupErrorChecks();
		check_building_target_non_usable = true;
		null_check_building_target = true;
	}

	public override BehResult execute(Actor pActor)
	{
		if (pActor.hasLover())
		{
			pActor.addAfterglowStatus();
			pActor.lover.addAfterglowStatus();
			spawnHearts(pActor);
			return BehResult.Continue;
		}
		return BehResult.Stop;
	}

	private void spawnHearts(Actor pActor)
	{
		Building beh_building_target = pActor.beh_building_target;
		for (int i = 0; (float)i < _amount; i++)
		{
			float x = (float)beh_building_target.current_tile.x + Randy.randomFloat(-1f, 1f);
			float y = (float)beh_building_target.current_tile.y + Randy.randomFloat(0f, 1f) + 2f;
			Vector3 pPos = new Vector3(x, y);
			EffectsLibrary.spawnAt("fx_hearts", pPos, 0.15f);
		}
	}
}
