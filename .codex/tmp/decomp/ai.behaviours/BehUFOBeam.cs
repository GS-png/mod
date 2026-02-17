namespace ai.behaviours;

public class BehUFOBeam : BehaviourActionActor
{
	private bool enabled;

	public BehUFOBeam(bool pEnabled = false)
	{
		enabled = pEnabled;
	}

	public override BehResult execute(Actor pActor)
	{
		UFO actorComponent = pActor.getActorComponent<UFO>();
		if (!enabled)
		{
			actorComponent.hideBeam();
			return BehResult.Continue;
		}
		if (actorComponent.beamAnim.isOn)
		{
			if (actorComponent.beamAnim.currentFrameIndex == 4)
			{
				for (int i = 0; i < 8; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						WorldTile tile = BehaviourActionBase<Actor>.world.GetTile(pActor.current_tile.pos.x + j - 4, pActor.current_tile.pos.y + i - 4);
						if (tile != null && !(Toolbox.Dist(pActor.current_tile.pos.x, pActor.current_tile.pos.y, tile.pos.x, tile.pos.y) > 4f))
						{
							MapAction.damageWorld(tile, 0, AssetManager.terraform.get("ufo_attack"), pActor);
						}
					}
				}
			}
			if (actorComponent.beamAnim.currentFrameIndex == actorComponent.beamAnim.frames.Length - 1)
			{
				actorComponent.hideBeam();
				return BehResult.Continue;
			}
			return BehResult.RepeatStep;
		}
		actorComponent.startBeam();
		return BehResult.RepeatStep;
	}
}
