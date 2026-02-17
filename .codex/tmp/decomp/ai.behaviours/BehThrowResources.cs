using System.Collections.Generic;
using UnityEngine;

namespace ai.behaviours;

public class BehThrowResources : BehCityActor
{
	protected override void setupErrorChecks()
	{
		base.setupErrorChecks();
		check_building_target_non_usable = true;
		null_check_building_target = true;
	}

	public override BehResult execute(Actor pActor)
	{
		if (!pActor.isCarryingResources())
		{
			return BehResult.Continue;
		}
		Building beh_building_target = pActor.beh_building_target;
		float a = Toolbox.DistTile(pActor.current_tile, beh_building_target.current_tile);
		a = Mathf.Max(a, 1f);
		if (a > 1.5f)
		{
			a = 1.5f;
		}
		using (Dictionary<string, ResourceContainer>.Enumerator enumerator = pActor.inventory.getResources().GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				KeyValuePair<string, ResourceContainer> current = enumerator.Current;
				string key = current.Key;
				ResourceAsset resourceAsset = AssetManager.resources.get(key);
				if (pActor.is_visible)
				{
					int amount = current.Value.amount;
					float pDuration = a;
					Vector2 pStart = pActor.getThrowStartPosition();
					Vector2 pEnd = beh_building_target.current_position + beh_building_target.asset.stockpile_center_offset;
					pEnd.x += Randy.randomFloat(-0.1f, 0.1f);
					pEnd.y += Randy.randomFloat(-0.1f, 0.1f);
					BehaviourActionBase<Actor>.world.resource_throw_manager.addNew(pStart, pEnd, pDuration, key, amount, 4f, beh_building_target);
				}
				pActor.takeFromInventory(key, 1);
				beh_building_target.addResources(key, 1);
				pActor.addLoot(resourceAsset.loot_value);
				pActor.makeWait(0.2f);
				if (pActor.isCarryingResources())
				{
					return BehResult.StepBack;
				}
			}
		}
		return BehResult.Continue;
	}
}
