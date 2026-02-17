using UnityEngine;
using ai.behaviours;

public class BehSpawnPlotProgressEffect : BehaviourActionActor
{
	private int _amount;

	public BehSpawnPlotProgressEffect(int pAmount = 1)
	{
		_amount = pAmount;
	}

	public override BehResult execute(Actor pActor)
	{
		_ = pActor.current_tile.zone;
		for (int i = 0; i < _amount; i++)
		{
			Vector3 pPos = pActor.current_position;
			pPos.y += 5f * pActor.actor_scale;
			pPos.y += Randy.randomFloat((0f - pActor.actor_scale) * 3f, pActor.actor_scale * 3f);
			pPos.x += Randy.randomFloat((0f - pActor.actor_scale) * 2f, pActor.actor_scale * 2f);
			_ = EffectsLibrary.spawnAt("fx_plot_progress", pPos, pActor.actor_scale * 0.8f) == null;
		}
		return BehResult.Continue;
	}
}
