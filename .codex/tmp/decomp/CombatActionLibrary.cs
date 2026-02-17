using System;
using UnityEngine;
using ai;

public class CombatActionLibrary : AssetLibrary<CombatActionAsset>
{
	public static CombatActionAsset combat_attack_melee;

	public static CombatActionAsset combat_attack_range;

	public static CombatActionAsset combat_cast_spell;

	public static CombatActionAsset combat_action_deflect;

	public static CombatActionAsset combat_action_dash;

	public static CombatActionAsset combat_action_backstep;

	public override void init()
	{
		base.init();
		combat_attack_melee = add(new CombatActionAsset
		{
			id = "combat_attack_melee",
			play_unit_attack_sounds = true,
			rate = 6,
			action = attackMeleeAction,
			basic = true
		});
		combat_attack_range = add(new CombatActionAsset
		{
			id = "combat_attack_range",
			play_unit_attack_sounds = true,
			rate = 6,
			action = attackRangeAction,
			basic = true
		});
		combat_cast_spell = add(new CombatActionAsset
		{
			id = "combat_cast_spell",
			play_unit_attack_sounds = true,
			cost_stamina = 5,
			is_spell_use = true,
			rate = 3,
			action = tryToCastSpell
		});
		combat_action_deflect = add(new CombatActionAsset
		{
			id = "combat_deflect_projectile",
			cost_stamina = 5,
			chance = 0.2f,
			pools = new CombatActionPool[1],
			action_actor = doDeflect
		});
		add(new CombatActionAsset
		{
			id = "combat_dodge",
			chance = 0.2f,
			cost_stamina = 5,
			action_actor = doDodgeAction,
			pools = AssetLibrary<CombatActionAsset>.a<CombatActionPool>(CombatActionPool.BEFORE_HIT)
		});
		add(new CombatActionAsset
		{
			id = "combat_block",
			chance = 0.2f,
			cost_stamina = 5,
			cooldown = 0.5f,
			action_actor = doBlockAction,
			pools = AssetLibrary<CombatActionAsset>.a<CombatActionPool>(CombatActionPool.BEFORE_HIT_BLOCK)
		});
		add(new CombatActionAsset
		{
			id = "combat_random_jump",
			cost_stamina = 5,
			cooldown = 2f
		});
		combat_action_dash = add(new CombatActionAsset
		{
			id = "combat_dash",
			cost_stamina = 10,
			chance = 0.2f,
			cooldown = 2f,
			action_actor_target_position = doDashAction,
			pools = AssetLibrary<CombatActionAsset>.a<CombatActionPool>(CombatActionPool.BEFORE_ATTACK_MELEE)
		});
		combat_action_backstep = add(new CombatActionAsset
		{
			id = "combat_backstep",
			cost_stamina = 10,
			chance = 0.2f,
			cooldown = 1f,
			can_do_action = delegate(Actor pSelf, BaseSimObject pAttackTarget)
			{
				if (pSelf.current_tile.Type.block)
				{
					return false;
				}
				float num = Toolbox.SquaredDistVec2Float(pSelf.current_position, pAttackTarget.current_position);
				float num2 = pSelf.getAttackRangeSquared() * 0.5f;
				return (num < num2) ? true : false;
			},
			action_actor_target_position = doBackstepAction,
			pools = AssetLibrary<CombatActionAsset>.a<CombatActionPool>(CombatActionPool.BEFORE_ATTACK_RANGE)
		});
		add(new CombatActionAsset
		{
			id = "combat_throw_bomb",
			cost_stamina = 5,
			chance = 0.2f,
			cooldown = 8f,
			action_actor_target_position = doThrowBombAction,
			can_do_action = delegate(Actor pSelf, BaseSimObject pAttackTarget)
			{
				float num = Toolbox.SquaredDistVec2Float(pSelf.current_position, pAttackTarget.current_position);
				return num > 36f && num < 2500f;
			},
			pools = AssetLibrary<CombatActionAsset>.a<CombatActionPool>(CombatActionPool.BEFORE_ATTACK_MELEE, CombatActionPool.BEFORE_ATTACK_RANGE)
		});
		add(new CombatActionAsset
		{
			id = "combat_throw_torch",
			cost_stamina = 30,
			chance = 0.2f,
			cooldown = 8f,
			action_actor_target_position = doThrowTorchAction,
			can_do_action = delegate(Actor pSelf, BaseSimObject pAttackTarget)
			{
				float num = Toolbox.SquaredDistVec2Float(pSelf.current_position, pAttackTarget.current_position);
				return num > 36f && num < 2500f;
			},
			pools = AssetLibrary<CombatActionAsset>.a<CombatActionPool>(CombatActionPool.BEFORE_ATTACK_MELEE, CombatActionPool.BEFORE_ATTACK_RANGE)
		});
	}

	private bool doThrowBombAction(Actor pSelf, Vector2 pTarget, WorldTile pTile = null)
	{
		ActionLibrary.throwBombAtTile(pSelf, pTile);
		pSelf.punchTargetAnimation(pTarget, pFlip: true, pReverse: false, 45f);
		return true;
	}

	private bool doThrowTorchAction(Actor pSelf, Vector2 pTarget, WorldTile pTile = null)
	{
		ActionLibrary.throwTorchAtTile(pSelf, pTile);
		pSelf.punchTargetAnimation(pTarget, pFlip: true, pReverse: false, 45f);
		return true;
	}

	private bool doBackstepAction(Actor pActor, Vector2 pTarget, WorldTile pTile = null)
	{
		float pForceAmountDirection = 5f;
		float pForceHeight = 1.2f;
		Vector2 current_position = pActor.current_position;
		pActor.punchTargetAnimation(pTarget, pFlip: false, pReverse: false, -20f);
		pActor.calculateForce(current_position.x, current_position.y, pTarget.x, pTarget.y, pForceAmountDirection, pForceHeight);
		Vector2 current_position2 = pActor.current_position;
		current_position2.y += pActor.getHeight();
		BaseEffect baseEffect = EffectsLibrary.spawnAt("fx_dodge", current_position2, pActor.actor_scale);
		if (baseEffect != null)
		{
			baseEffect.transform.rotation = Toolbox.getEulerAngle(current_position, pTarget);
		}
		return true;
	}

	private bool doDashAction(Actor pActor, Vector2 pTarget, WorldTile pTile = null)
	{
		float pForceAmountDirection = 5f;
		float pForceHeight = 1.2f;
		Vector2 current_position = pActor.current_position;
		pActor.punchTargetAnimation(pTarget, pFlip: true, pReverse: false, 50f);
		pActor.addStatusEffect("dash", 0f, pColorEffect: false);
		pActor.calculateForce(pTarget.x, pTarget.y, current_position.x, current_position.y, pForceAmountDirection, pForceHeight);
		Vector2 current_position2 = pActor.current_position;
		current_position2.y += pActor.getHeight();
		BaseEffect baseEffect = EffectsLibrary.spawnAt("fx_dodge", current_position2, pActor.actor_scale);
		if (baseEffect != null)
		{
			baseEffect.transform.rotation = Toolbox.getEulerAngle(current_position, pTarget);
		}
		return true;
	}

	private bool doBlockAction(Actor pActor, AttackData pData, float pTargetX = 0f, float pTargetY = 0f)
	{
		ActorTool.applyForceToUnit(pData, pActor, 0.1f);
		if (!pActor.is_visible)
		{
			return true;
		}
		Vector2 current_position = pActor.current_position;
		Vector2 vector = pData.hit_position;
		pActor.punchTargetAnimation(vector, pFlip: false, pReverse: false, -40f);
		BaseEffect baseEffect = EffectsLibrary.spawnAt("fx_block", vector, pActor.a.actor_scale);
		if (baseEffect == null)
		{
			return true;
		}
		baseEffect.transform.rotation = Toolbox.getEulerAngle(current_position.x, current_position.y, vector.x, vector.y);
		return true;
	}

	private bool doDeflect(Actor pActor, AttackData pData, float pTargetX = 0f, float pTargetY = 0f)
	{
		Vector2 vector = pData.initiator_position;
		pActor.spawnSlashPunch(vector);
		pActor.stopMovement();
		pActor.punchTargetAnimation(vector, pFlip: true, pActor.hasRangeAttack());
		pActor.startAttackCooldown();
		return true;
	}

	private bool doDodgeAction(Actor pActor, AttackData pData, float pTargetX = 0f, float pTargetY = 0f)
	{
		float num = 3f;
		float pForceHeight = 1.5f;
		Vector2 vector = pActor.cur_transform_position;
		Vector2 vector2 = pData.initiator_position;
		Vector2 pVector = vector - vector2;
		Vector2 pVec = ((!Randy.randomBool()) ? (vector + Toolbox.rotateVector(pVector, -90f) * num) : (vector + Toolbox.rotateVector(pVector, 90f) * num));
		pActor.calculateForce(vector.x, vector.y, pVec.x, pVec.y, num, pForceHeight);
		pActor.addStatusEffect("dodge", 0f, pColorEffect: false);
		pActor.punchTargetAnimation(vector, pFlip: false, pReverse: false, -60f);
		Vector2 current_position = pActor.current_position;
		current_position.y += pActor.getHeight();
		BaseEffect baseEffect = EffectsLibrary.spawnAt("fx_dodge", current_position, pActor.actor_scale);
		if (baseEffect != null)
		{
			baseEffect.transform.rotation = Toolbox.getEulerAngle(vector, pVec);
		}
		return true;
	}

	public bool attackRangeAction(AttackData pData)
	{
		Actor actor = pData.initiator.a;
		BaseSimObject target = pData.target;
		string projectile_id = pData.projectile_id;
		_ = actor.actor_scale;
		float scaleMod = actor.getScaleMod();
		float num = actor.stats["size"];
		int num2 = (int)actor.stats["projectiles"];
		Vector2 vector;
		if (target == null)
		{
			vector = pData.hit_position;
		}
		else
		{
			vector = getAttackTargetPosition(pData);
			vector.y += 0.2f * scaleMod;
		}
		float num3 = actor.stats["accuracy"];
		float pMaxExclusive = Toolbox.DistVec2Float(actor.current_position, vector) / num3 * 0.25f;
		pMaxExclusive = Randy.randomFloat(0f, pMaxExclusive);
		pMaxExclusive = Mathf.Clamp(pMaxExclusive, 0f, 2f);
		float pStartPosZ = 0.6f * scaleMod;
		float pTargetZ = 0f;
		float value = 0f;
		for (int i = 0; i < num2; i++)
		{
			Vector2 vector2 = new Vector2(vector.x, vector.y);
			if (num3 < 10f)
			{
				Vector2 innacuracyVector = getInnacuracyVector(num3);
				innacuracyVector *= pMaxExclusive;
				vector2 += innacuracyVector;
			}
			Vector3 newPoint = Toolbox.getNewPoint(actor.current_position.x, actor.current_position.y, vector2.x, vector2.y, num * scaleMod);
			newPoint.y += actor.getHeight();
			if (target != null && target.isInAir())
			{
				pTargetZ = target.getHeight();
			}
			value = World.world.projectiles.spawn(actor, target, projectile_id, newPoint, vector2, pTargetZ, pStartPosZ, pData.kill_action, pData.kingdom).getLaunchAngle();
		}
		actor.spawnSlash(vector, null, 2f, pTargetZ, 0f, value);
		return true;
	}

	public Vector2 getInnacuracyVector(float pAccuracyStat)
	{
		float num = 1f * (10f - pAccuracyStat) / 10f;
		float num2 = (float)((double)(Randy.random() * 2f) * Math.PI);
		return new Vector2(num * (float)Math.Cos(num2), num * (float)Math.Sin(num2));
	}

	public static bool tryToCastSpell(AttackData pData)
	{
		Actor actor = pData.initiator.a;
		BaseSimObject baseSimObject = pData.target;
		SpellAsset randomSpell = actor.getRandomSpell();
		if (!actor.hasEnoughMana(randomSpell.cost_mana))
		{
			return false;
		}
		if (!Randy.randomChance(randomSpell.chance + randomSpell.chance * actor.stats["skill_spell"]))
		{
			return false;
		}
		if (randomSpell.cast_target == CastTarget.Himself)
		{
			baseSimObject = actor;
		}
		if (randomSpell.cast_entity == CastEntity.BuildingsOnly)
		{
			if (baseSimObject.isActor())
			{
				return false;
			}
		}
		else if (randomSpell.cast_entity == CastEntity.UnitsOnly && baseSimObject.isBuilding())
		{
			return false;
		}
		if (randomSpell.health_ratio > 0f)
		{
			float healthRatio = actor.getHealthRatio();
			if (randomSpell.health_ratio <= healthRatio)
			{
				return false;
			}
		}
		if (randomSpell.min_distance > 0f && (float)Toolbox.SquaredDistTile(actor.current_tile, baseSimObject.current_tile) < randomSpell.min_distance * randomSpell.min_distance)
		{
			return false;
		}
		bool flag = false;
		if (randomSpell.action != null)
		{
			flag = randomSpell.action.RunAnyTrue(actor, baseSimObject, baseSimObject.current_tile);
		}
		if (flag)
		{
			actor.doCastAnimation();
			actor.addStatusEffect("recovery_spell");
		}
		return flag;
	}

	public bool attackMeleeAction(AttackData pData)
	{
		AttackDataResult attackDataResult = MapBox.newAttack(pData);
		if (pData.initiator.a.is_visible && EffectsLibrary.canShowSlashEffect())
		{
			showMeleeSlashAttack(pData);
		}
		pData.kill_action?.Invoke();
		return attackDataResult.state == ApplyAttackState.Hit;
	}

	public void showMeleeSlashAttack(AttackData pData)
	{
		pData.initiator.a.spawnSlash(pData.hit_position);
	}

	public Vector2 getAttackTargetPosition(AttackData pData)
	{
		BaseSimObject target = pData.target;
		Vector2 vector = new Vector2(pData.hit_position.x, pData.hit_position.y);
		if (target == null)
		{
			return vector;
		}
		float num = target.stats["size"];
		if (target.isActor() && target.a.is_moving && target.isFlying())
		{
			return Vector2.MoveTowards(vector, target.a.next_step_position, num * 3f);
		}
		return vector;
	}
}
