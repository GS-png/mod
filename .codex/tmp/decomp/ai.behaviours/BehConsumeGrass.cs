namespace ai.behaviours;

public class BehConsumeGrass : BehaviourActionActor
{
	protected override void setupErrorChecks()
	{
		base.setupErrorChecks();
		null_check_tile_target = true;
	}

	public override BehResult execute(Actor pActor)
	{
		WorldTile beh_tile_target = pActor.beh_tile_target;
		if (!beh_tile_target.Type.grass)
		{
			return BehResult.Stop;
		}
		pActor.punchTargetAnimation(beh_tile_target.posV3, pFlip: false);
		pActor.consumeTopTile(beh_tile_target);
		return BehResult.Continue;
	}
}
