using UnityEngine;
using ai.behaviours;

public class BehActorRandomJump : BehaviourActionActor
{
	public override BehResult execute(Actor pActor)
	{
		float num = Randy.randomFloat(1f, 5f);
		float pForceHeight = Randy.randomFloat(1f, 2f);
		Vector2 current_position = pActor.current_position;
		float degrees = Randy.randomFloat(-180f, 180f);
		Vector2 pVec = current_position + Toolbox.rotateVector(current_position, degrees) * num;
		pActor.calculateForce(current_position.x, current_position.y, pVec.x, pVec.y, num, pForceHeight);
		pActor.punchTargetAnimation(current_position, pFlip: false, pReverse: false, -60f);
		if (pActor.is_visible)
		{
			Vector2 current_position2 = pActor.current_position;
			BaseEffect baseEffect = EffectsLibrary.spawnAt("fx_dodge", current_position2, pActor.actor_scale);
			if (baseEffect != null)
			{
				baseEffect.transform.rotation = Toolbox.getEulerAngle(current_position, pVec);
			}
		}
		return BehResult.Continue;
	}
}
