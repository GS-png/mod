using System;
using EraWheel.Config;

namespace EraWheel.Core
{
    public class EraStateMachine
    {
        public bool TryTransition(CycleManager ctx, ModConfig cfg, bool prosperityReached, bool prosperityDataReady, float demonHealthPercent, bool demonSpawned)
        {
            if (ctx == null) return false;

            var worldAge = ctx.WorldAge;
            var phaseDuration = worldAge - ctx.PhaseStartWorldAge;

            var firstCycleMode = cfg?.cycle?.trigger?.first_cycle_mode ?? "prosperity";
            var fixedAgeYears = cfg?.cycle?.trigger != null ? cfg.cycle.trigger.fixed_age_years : 600;

            switch (ctx.CurrentPhase)
            {
                case EraPhase.Sealed:
                    if (ctx.CycleCount == 0)
                    {
                        if (IsMode(firstCycleMode, "prosperity"))
                        {
                            if (prosperityReached)
                            {
                                return ctx.TransitionTo(EraPhase.Omen, "第1轮回繁荣度触发预兆");
                            }

                            if (!prosperityDataReady && worldAge >= fixedAgeYears)
                            {
                                return ctx.TransitionTo(EraPhase.Omen, "第1轮回无繁荣数据，固定年数保底触发预兆");
                            }

                            return false;
                        }

                        if (IsMode(firstCycleMode, "fixed_age"))
                        {
                            if (worldAge >= fixedAgeYears)
                            {
                                return ctx.TransitionTo(EraPhase.Omen, "第1轮回固定年数触发预兆");
                            }

                            return false;
                        }

                        if (IsMode(firstCycleMode, "manual"))
                        {
                            return false;
                        }
                    }

                    if (ctx.SealSystem != null && ctx.SealSystem.IsSealWeakened())
                    {
                        return ctx.TransitionTo(EraPhase.Omen, "封印强度低于30%触发预兆");
                    }

                    return false;

                case EraPhase.Omen:
                    if (phaseDuration >= ctx.OmenTargetYears)
                    {
                        return ctx.TransitionTo(EraPhase.Awakening, "预兆阶段持续时间达到阈值");
                    }

                    return false;

                case EraPhase.Awakening:
                    if (demonSpawned)
                    {
                        return ctx.TransitionTo(EraPhase.Invasion, "魔王生成完成，进入降临");
                    }

                    if (phaseDuration >= ctx.AwakeningTargetYears)
                    {
                        return ctx.TransitionTo(EraPhase.Invasion, "苏醒阶段超时进入降临（保底）");
                    }

                    return false;

                case EraPhase.Invasion:
                    if (demonHealthPercent < 30f)
                    {
                        return ctx.TransitionTo(EraPhase.Weakening, "魔王生命值过低进入衰弱");
                    }

                    if (cfg != null && cfg.cycle != null && cfg.cycle.phases != null)
                    {
                        if (phaseDuration >= cfg.cycle.phases.invasion_timeout)
                        {
                            return ctx.TransitionTo(EraPhase.Weakening, "入侵阶段超时进入衰弱（保底）");
                        }
                    }

                    if (demonHealthPercent > 70f)
                    {
                        return ctx.TransitionTo(EraPhase.Peak, "魔王生命值较高进入全盛");
                    }

                    return false;

                case EraPhase.Peak:
                    if (demonHealthPercent < 30f)
                    {
                        return ctx.TransitionTo(EraPhase.Weakening, "魔王生命值过低进入衰弱");
                    }

                    return false;

                case EraPhase.Weakening:
                    if (ctx.SealSystem != null && ctx.SealSystem.CheckSealSuccess(cfg, worldAge, demonHealthPercent))
                    {
                        return ctx.TransitionTo(EraPhase.Resealed, "封印成功");
                    }

                    return false;

                case EraPhase.Resealed:
                    return ctx.TransitionTo(EraPhase.Sealed, "轮回结算完成，进入封印状态");

                default:
                    return false;
            }
        }

        private static bool IsMode(string value, string expected)
        {
            return string.Equals(value, expected, StringComparison.OrdinalIgnoreCase);
        }
    }
}
