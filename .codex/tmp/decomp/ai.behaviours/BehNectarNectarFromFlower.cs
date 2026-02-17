namespace ai.behaviours;

public class BehNectarNectarFromFlower : BehActorUsableBuildingTarget
{
	public override BehResult execute(Actor pActor)
	{
		if (pActor.beh_building_target.asset.type != "type_flower")
		{
			return BehResult.Stop;
		}
		if (pActor.beh_building_target.isAlive())
		{
			int pVal = (int)((float)pActor.beh_building_target.asset.nutrition_restore * 0.5f);
			pActor.addNutritionFromEating(pVal, pSetMaxNutrition: false, pSetJustAte: true);
			pActor.countConsumed();
		}
		WorldTile current_tile = pActor.beh_building_target.current_tile;
		pActor.punchTargetAnimation(current_tile.posV3, pFlip: false);
		return BehResult.Continue;
	}
}
