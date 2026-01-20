using EraWheel.Config;

namespace EraWheel.Core
{
    public class EraStateMachine
    {
        public bool TryTransition(CycleManager ctx, ModConfig cfg, bool prosperityReached, float demonHealthPercent)
        {
            if (ctx == null) return false;

            var worldAge = ctx.WorldAge;
            var phaseDuration = worldAge - ctx.PhaseStartWorldAge;

            switch (ctx.CurrentPhase)
            {
                case EraPhase.Sealed:
                    if (ctx.SealSystem != null && ctx.SealSystem.IsSealWeakened())
                    {
                        return ctx.TransitionTo(EraPhase.Omen, "封印强度低于30%触发预兆");
                    }

                    if (ctx.CycleCount == 0 && prosperityReached)
                    {
                        return ctx.TransitionTo(EraPhase.Omen, "第1轮回繁荣度触发预兆");
                    }

                    if (cfg != null && cfg.cycle != null && cfg.cycle.trigger != null && cfg.cycle.trigger.first_cycle_mode == "fixed_age")
                    {
                        if (ctx.CycleCount == 0 && worldAge >= cfg.cycle.trigger.fixed_age_years)
                        {
                            return ctx.TransitionTo(EraPhase.Omen, "第1轮回固定年数触发预兆");
                        }
                    }

                    return false;

                case EraPhase.Omen:
                    if (phaseDuration >= ctx.OmenTargetYears)
                    {
                        return ctx.TransitionTo(EraPhase.Awakening, "预兆阶段持续时间达到阈值");
                    }

                    return false;

                case EraPhase.Awakening:
                    if (phaseDuration >= ctx.AwakeningTargetYears)
                    {
                        return ctx.TransitionTo(EraPhase.Invasion, "苏醒阶段持续时间达到阈值");
                    }

                    return false;

                case EraPhase.Invasion:
                    if (cfg != null && cfg.cycle != null && cfg.cycle.phases != null)
                    {
                        if (phaseDuration >= cfg.cycle.phases.invasion_timeout)
                        {
                            return ctx.TransitionTo(EraPhase.Weakening, "入侵阶段超时进入衰弱（保底）");
                        }
                    }

                    if (phaseDuration >= 1 && demonHealthPercent > 70f)
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
    }
}
