using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Assets;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Triggers;
using EraWheel.Core.Constants;
using EraWheel.Core.Logging;
using EraWheel.Core.Time;
using EraWheel.Localization;
using EraWheel.Reflection;
using NeoModLoader.General;

namespace EraWheel.Combat.Demons;

public sealed partial class EraDemonSkillRuntimeService
{
    private const string FinalJudgeId = "demon_final_judge";
    private const string FinalJudgeAngelAssetId = "ew_final_judge_angel";
    private const string FinalJudgeAngelGroupKey = "魔王与将领图片/终焉审判者/召唤物：天使军团";
    private const string FinalJudgeAngelIconPath = "Assets/Art/注册生物单位图片/魔王与将领图片/终焉审判者/召唤物：天使军团/icon.png";
    private const string FinalJudgeS3InnocentKey = "ew_final_judge_s3_innocent";
    private const string FinalJudgeS3LightKey = "ew_final_judge_s3_light";
    private const string FinalJudgeS3HeavyKey = "ew_final_judge_s3_heavy";
    private const string FinalJudgeS5AngelKey = "ew_final_judge_s5_angel";
    private const string FinalJudgeS6ShieldKey = "ew_final_judge_s6_shield";
    private const string FinalJudgeS6LightKey = "ew_final_judge_s6_light";

    private enum FinalJudgeSinTier
    {
        Innocent = 0,
        Light = 1,
        Heavy = 2,
    }

    private void RegisterFinalJudge()
    {
        EnsureFinalJudgeAngelAssetRegistered();
        RegisterFinalJudgePassive();

        RegisterTickSkill(
            "demon_final_judge#s1",
            FinalJudgeId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 10f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 10f);
                if (target == null)
                {
                    return;
                }

                switch (GetFinalJudgeSinTier(target))
                {
                    case FinalJudgeSinTier.Innocent:
                        _effects.ApplyDamage(context, target, flatDamage: 50);
                        break;
                    case FinalJudgeSinTier.Light:
                        _effects.ApplyDamage(context, target, damageMultiplier: 0.1f);
                        break;
                    case FinalJudgeSinTier.Heavy:
                        _effects.ApplyDamage(context, target, damageMultiplier: 1f);
                        break;
                }
            }
        );

        RegisterTickSkill(
            "demon_final_judge#s2",
            FinalJudgeId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                foreach (Actor target in _effects.FindActors(actor.current_tile, 10f, actor, EraEffectTargetRule.Foes))
                {
                    int sin = GetFinalJudgeSinValue(target);
                    if (sin < 50)
                    {
                        continue;
                    }

                    _effects.ApplyDamage(context, target, flatDamage: sin * 10);
                }
            }
        );

        RegisterTickSkill(
            "demon_final_judge#s3",
            FinalJudgeId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                foreach (Actor target in _effects.FindActors(actor.current_tile, 10f, actor, EraEffectTargetRule.Foes))
                {
                    switch (GetFinalJudgeSinTier(target))
                    {
                        case FinalJudgeSinTier.Heavy:
                            _statuses.ApplyTimedDebuff(
                                target,
                                15f,
                                new Dictionary<string, float>
                                {
                                    [EraAttributeIds.MultiplierDamage] = -40f,
                                    [EraAttributeIds.MultiplierAttackSpeed] = -40f,
                                    [EraAttributeIds.MultiplierSpeed] = -40f,
                                    [EraAttributeIds.Armor] = -40f,
                                },
                                runtimeKey: BuildFinalJudgeRuntimeKey(FinalJudgeS3HeavyKey, target.getID())
                            );
                            break;
                        case FinalJudgeSinTier.Light:
                            _statuses.ApplyTimedDebuff(
                                target,
                                10f,
                                new Dictionary<string, float>
                                {
                                    [EraAttributeIds.MultiplierDamage] = -20f,
                                    [EraAttributeIds.Armor] = -20f,
                                },
                                runtimeKey: BuildFinalJudgeRuntimeKey(FinalJudgeS3LightKey, target.getID())
                            );
                            break;
                        case FinalJudgeSinTier.Innocent:
                            _statuses.ApplyTimedBuff(
                                target,
                                10f,
                                new Dictionary<string, float>
                                {
                                    [EraAttributeIds.Armor] = 30f,
                                    [EraAttributeIds.MultiplierSpeed] = 30f,
                                },
                                runtimeKey: BuildFinalJudgeRuntimeKey(FinalJudgeS3InnocentKey, target.getID())
                            );
                            break;
                    }
                }
            }
        );

        RegisterTickSkill(
            "demon_final_judge#s4",
            FinalJudgeId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                Actor? target = SelectFinalJudgeHeavyTarget(actor, 20f);
                if (target?.current_tile == null)
                {
                    return;
                }

                WorldTile? exileTile = ResolveFinalJudgeExileTile(target.current_tile, 64);
                if (exileTile != null)
                {
                    WorldboxReflectionAdapter.TryTeleportActor(target, exileTile);
                }
            }
        );

        RegisterTickSkill(
            "demon_final_judge#s5",
            FinalJudgeId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                IReadOnlyList<Actor> angels = _effects.SummonUnits(
                    context,
                    FinalJudgeAngelAssetId,
                    actor.current_tile,
                    count: 4,
                    joinSourceKingdom: true
                );

                foreach (Actor angel in angels)
                {
                    _statuses.ApplyTimedBuff(
                        angel,
                        EraWorldTime.YearsToWorldTime(1000f),
                        new Dictionary<string, float>
                        {
                            [EraAttributeIds.Health] = 10000f,
                            [EraAttributeIds.Damage] = 100f,
                            [EraAttributeIds.MultiplierSpeed] = 30f,
                        },
                        runtimeKey: BuildFinalJudgeRuntimeKey(FinalJudgeS5AngelKey, angel.getID())
                    );
                    angel.changeHealth(10000);
                }
            }
        );

        RegisterTickSkill(
            "demon_final_judge#s6",
            FinalJudgeId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(10f),
            manaCost: 15,
            requiresAdvent: true,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                foreach (Actor target in _effects.FindActors(actor.current_tile, 20f, actor, EraEffectTargetRule.Foes))
                {
                    switch (GetFinalJudgeSinTier(target))
                    {
                        case FinalJudgeSinTier.Heavy:
                            _effects.ApplyCurrentHealthDamage(context, target, percent: 0.1f);
                            break;
                        case FinalJudgeSinTier.Light:
                            _effects.ApplyDamage(context, target, damageMultiplier: 0.5f);
                            _statuses.ApplyTimedDebuff(
                                target,
                                30f,
                                new Dictionary<string, float>
                                {
                                    [EraAttributeIds.MultiplierDamage] = -30f,
                                    [EraAttributeIds.MultiplierAttackSpeed] = -30f,
                                    [EraAttributeIds.MultiplierSpeed] = -30f,
                                    [EraAttributeIds.Armor] = -30f,
                                },
                                runtimeKey: BuildFinalJudgeRuntimeKey(FinalJudgeS6LightKey, target.getID())
                            );
                            break;
                        case FinalJudgeSinTier.Innocent:
                            _statuses.ApplyShield(
                                target,
                                target.getMaxHealth(),
                                30f,
                                runtimeKey: BuildFinalJudgeRuntimeKey(FinalJudgeS6ShieldKey, target.getID())
                            );
                            break;
                    }
                }
            }
        );
    }

    private void RegisterFinalJudgePassive()
    {
        _triggers.Register(
            new EraTriggerDefinition(
                "demon_final_judge#p0_damage_mod",
                FinalJudgeId,
                EraTriggerType.OnGetHit,
                context =>
                {
                    Actor? source = context.SourceActor;
                    Actor? target = context.TargetActor;
                    if (source?.asset?.id != FinalJudgeId || target == null || !IsFinalJudgeSinCandidate(target))
                    {
                        return;
                    }

                    EraEffectContext effectContext = context.ToEffectContext();
                    switch (GetFinalJudgeSinTier(target))
                    {
                        case FinalJudgeSinTier.Heavy:
                            _effects.ApplyDamage(
                                effectContext,
                                target,
                                flatDamage: Math.Max(1, (int)MathF.Round(context.Damage * 0.3f))
                            );
                            break;
                        case FinalJudgeSinTier.Innocent:
                            _effects.ApplyHealing(
                                effectContext,
                                target,
                                flatAmount: Math.Max(1, (int)MathF.Round(context.Damage * 0.8f))
                            );
                            break;
                    }
                }
            )
        );
    }

    private static bool IsFinalJudgeSinCandidate(Actor actor)
    {
        return actor.asset != null && !actor.asset.id.StartsWith("demon_", StringComparison.OrdinalIgnoreCase);
    }

    private static int GetFinalJudgeSinValue(Actor actor)
    {
        if (!IsFinalJudgeSinCandidate(actor))
        {
            return 0;
        }

        int ageScore = Math.Max(0, actor.getAge()) / 10;
        int killScore = 0;
        if (actor.getData() is ActorData data)
        {
            killScore = Math.Max(0, data.kills) * 5;
        }

        return ageScore + killScore;
    }

    private static FinalJudgeSinTier GetFinalJudgeSinTier(Actor actor)
    {
        int sin = GetFinalJudgeSinValue(actor);
        if (sin >= 100)
        {
            return FinalJudgeSinTier.Heavy;
        }

        if (sin >= 20)
        {
            return FinalJudgeSinTier.Light;
        }

        return FinalJudgeSinTier.Innocent;
    }

    private Actor? SelectFinalJudgeHeavyTarget(Actor actor, float radius)
    {
        if (actor.current_tile == null)
        {
            return null;
        }

        return _effects.FindActors(actor.current_tile, radius, actor, EraEffectTargetRule.Foes)
            .Where(candidate => GetFinalJudgeSinTier(candidate) == FinalJudgeSinTier.Heavy)
            .OrderByDescending(GetFinalJudgeSinValue)
            .FirstOrDefault();
    }

    private static WorldTile? ResolveFinalJudgeExileTile(WorldTile origin, int searchRadius)
    {
        if (World.world == null)
        {
            return null;
        }

        for (int attempt = 0; attempt < 64; attempt++)
        {
            int offsetX = RandomGen.Next(-searchRadius, searchRadius + 1);
            int offsetY = RandomGen.Next(-searchRadius, searchRadius + 1);
            if ((offsetX * offsetX) + (offsetY * offsetY) < 400)
            {
                continue;
            }

            WorldTile? tile = World.world.GetTile(origin.x + offsetX, origin.y + offsetY);
            if (tile != null && !tile.is_liquid && !tile.hasBuilding())
            {
                return tile;
            }
        }

        return ResolveRandomWalkableTile(origin, searchRadius);
    }

    private static string BuildFinalJudgeRuntimeKey(string prefix, long actorId)
    {
        return $"{prefix}:{actorId}";
    }

    private void EnsureFinalJudgeAngelAssetRegistered()
    {
        if (AssetManager.actor_library.has(FinalJudgeAngelAssetId))
        {
            return;
        }

        ActorAsset? template = AssetManager.actor_library.get(EraWorldboxAssetIds.MobNoGenesTemplate);
        if (template == null)
        {
            EraLog.Warning(EraLogCategory.Combat, "无法注册终焉审判者天使军团：缺少基础模板。");
            return;
        }

        AssetManager.actor_library.clone(out ActorAsset cloned, template);
        cloned.id = FinalJudgeAngelAssetId;
        cloned.name_locale = FinalJudgeAngelAssetId;
        cloned.icon = FinalJudgeAngelIconPath;
        cloned.kingdom_id_wild = string.Empty;
        cloned.flying = true;
        cloned.hovering = true;
        cloned.can_be_favorited = false;
        cloned.hide_favorite_icon = true;
        cloned.can_edit_equipment = false;
        cloned.can_edit_traits = false;
        cloned.can_receive_traits = false;
        cloned.use_items = false;
        cloned.take_items = false;
        cloned.force_hide_mana = true;
        cloned.shadow = false;
        if (cloned.texture_asset != null)
        {
            cloned.texture_asset.shadow = false;
        }
        cloned.special = true;
        cloned.unit_other = true;
        cloned.skip_save = true;

        IReadOnlyList<EraSpriteResource> walkFrames = ResolveUnitGroupWalkFrames(FinalJudgeAngelGroupKey);
        if (!EnsureRuntimeTemplateTextures(cloned, template, FinalJudgeAngelAssetId, "终焉审判者天使军团", walkFrames))
        {
            return;
        }

        ActorAsset asset = AssetManager.actor_library.add(cloned);
        RegisterFinalJudgeAngelLocale(asset);
        if (LocalizedTextManager.instance != null)
        {
            LM.ApplyLocale(false);
        }
    }

    private static void RegisterFinalJudgeAngelLocale(ActorAsset asset)
    {
        string nameKey = string.IsNullOrWhiteSpace(asset?.getLocaleID()) ? FinalJudgeAngelAssetId : asset.getLocaleID();
        string descriptionKey = string.IsNullOrWhiteSpace(asset?.getDescriptionID()) ? $"{nameKey}_description" : asset.getDescriptionID();

        if (!string.IsNullOrWhiteSpace(nameKey))
        {
            EraLocaleRegistrar.AddZhEn(nameKey, "天使战士", "Judgement Angel");
        }

        if (!string.IsNullOrWhiteSpace(descriptionKey))
        {
            EraLocaleRegistrar.AddZhEn(descriptionKey, "终焉审判者召来的飞行天使军团。", "A flying angel summoned by the Final Judge.");
        }
    }
}
