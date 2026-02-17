using System.Collections.Generic;
using UnityEngine;

public class EffectInfinityCoin : BaseEffect
{
	private static List<Actor> _temp_list = new List<Actor>();

	private bool used;

	internal override void create()
	{
		base.create();
	}

	internal override void spawnOnTile(WorldTile pTile)
	{
		prepare(new Vector3(pTile.posV3.x, pTile.posV3.y - 1f), 0.25f);
	}

	internal override void prepare(Vector2 pVector, float pScale = 1f)
	{
		base.prepare(pVector, pScale);
		Vector3 localPosition = base.transform.localPosition;
		localPosition.z = -2f;
		current_position = localPosition;
		base.transform.localPosition = localPosition;
		used = false;
		World.world.startShake(0.1f, 0.02f, 3f);
	}

	private void Update()
	{
		if (sprite_animation.currentFrameIndex >= 32 && !used)
		{
			World.world.startShake(0.2f, 0.01f, 3f);
			used = true;
			Vector3 localPosition = base.transform.localPosition;
			localPosition.y += 2f;
			BaseEffect baseEffect = EffectsLibrary.spawnAt("fx_boulder_impact", localPosition, base.transform.localScale.x);
			if (baseEffect != null)
			{
				localPosition = baseEffect.transform.localPosition;
				localPosition.z = -1f;
				baseEffect.transform.localPosition = localPosition;
			}
			EffectsLibrary.spawnExplosionWave(localPosition, 5f);
			doAction();
		}
	}

	private void doAction()
	{
		int num = 0;
		int num2 = 0;
		List<Actor> simpleList = World.world.units.getSimpleList();
		for (int i = 0; i < simpleList.Count; i++)
		{
			Actor actor = simpleList[i];
			if (actor.isAlive() && !actor.isFavorite() && !actor.asset.ignored_by_infinity_coin)
			{
				num++;
			}
		}
		num2 = ((num % 2 != 0) ? (num / 2 + 1) : (num / 2));
		int num3 = 0;
		_temp_list.AddRange(World.world.units);
		for (int j = 0; j < _temp_list.Count; j++)
		{
			_temp_list.ShuffleOne(j);
			Actor actor2 = _temp_list[j];
			if (num2 == 0)
			{
				break;
			}
			if (actor2.isAlive() && !actor2.isFavorite() && !actor2.asset.ignored_by_infinity_coin && !actor2.is_invincible)
			{
				num3++;
				num2--;
				actor2.getHitFullHealth(AttackType.Divine);
			}
		}
		WorldTip.addWordReplacement("$removed$", num3.ToString());
		WorldTip.showNow("infinity_coin_used", pTranslate: true, "top");
		_temp_list.Clear();
	}
}
