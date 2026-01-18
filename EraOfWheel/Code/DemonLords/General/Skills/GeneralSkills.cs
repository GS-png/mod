using System;
using System.Collections.Generic;
using UnityEngine;
using EraOfWheel.Core;
using EraOfWheel.UI;
using Logger = EraOfWheel.Core.Logger;

namespace EraOfWheel.DemonLords.General.Skills
{
    public interface IGeneralSkill
    {
        string Id { get; }
        string Name { get; }
        int CooldownYears { get; }
        bool TryUse(BaseGeneral general, int currentYear);
    }

    public abstract class GeneralSkillBase : IGeneralSkill
    {
        public abstract string Id { get; }
        public abstract string Name { get; }
        public virtual int CooldownYears => 10;

        private int _lastUsedYear = int.MinValue;

        public bool TryUse(BaseGeneral general, int currentYear)
        {
            if (general == null) return false;
            if (_lastUsedYear != int.MinValue && currentYear - _lastUsedYear < Math.Max(1, CooldownYears)) return false;

            bool ok = false;
            try
            {
                ok = DoUse(general, currentYear);
            }
            catch (Exception ex)
            {
                Logger.Error("GeneralSkill", $"Skill {Id} failed", ex);
                ok = false;
            }

            if (ok)
            {
                _lastUsedYear = currentYear;
            }

            return ok;
        }

        protected abstract bool DoUse(BaseGeneral general, int currentYear);
    }

    public class RallyLegionSkill : GeneralSkillBase
    {
        public override string Id => "rally_legion";
        public override string Name => "军团号令";
        public override int CooldownYears => 12;

        protected override bool DoUse(BaseGeneral general, int currentYear)
        {
            var actor = general.Actor;
            if (actor == null) return false;

            if (!ActorUtils.TryGetActorPosition2D(actor, out var center)) return false;

            var units = World.world?.units;
            if (units == null) return false;

            const float radius = 180f;
            const int maxTargets = 40;
            int affected = 0;

            var candidates = new List<Actor>(256);
            foreach (var u in units)
            {
                if (u == null) continue;
                if (!ActorUtils.TryHasTrait(u, "dlm_demon_faction")) continue;

                if (!ActorUtils.TryGetActorPosition2D(u, out var pos)) continue;
                if (Vector2.Distance(pos, center) > radius) continue;

                candidates.Add(u);
            }

            if (candidates.Count == 0) return false;

            int max = Math.Min(maxTargets, candidates.Count);
            for (int i = 0; i < max; i++)
            {
                var target = candidates[i];
                if (target == null) continue;

                try { target.addTrait("strong"); } catch { }
                try { target.addTrait("fast"); } catch { }
                affected++;
            }

            if (affected <= 0) return false;

            NotificationSystem.Instance?.Show("将领技能", $"{general.Name}发动{ Name }，强化了{affected}个军团单位", NotificationType.Info);
            return true;
        }
    }

    public class CorruptEnemySkill : GeneralSkillBase
    {
        public override string Id => "corrupt_enemy";
        public override string Name => "腐化低语";
        public override int CooldownYears => 15;

        protected override bool DoUse(BaseGeneral general, int currentYear)
        {
            var actor = general.Actor;
            if (actor == null) return false;

            if (!ActorUtils.TryGetActorPosition2D(actor, out var center)) return false;

            var units = World.world?.units;
            if (units == null) return false;

            const float radius = 160f;
            const int maxTargets = 25;
            int affected = 0;

            var candidates = new List<Actor>(256);
            foreach (var u in units)
            {
                if (u == null) continue;
                if (ActorUtils.TryHasTrait(u, "dlm_demon_faction")) continue;

                if (!ActorUtils.TryGetActorPosition2D(u, out var pos)) continue;
                if (Vector2.Distance(pos, center) > radius) continue;

                candidates.Add(u);
            }

            if (candidates.Count == 0) return false;

            int max = Math.Min(maxTargets, candidates.Count);
            for (int i = 0; i < max; i++)
            {
                var target = candidates[i];
                if (target == null) continue;

                try { target.addTrait("madness"); } catch { }
                try { target.addTrait("evil"); } catch { }
                affected++;
            }

            if (affected <= 0) return false;

            NotificationSystem.Instance?.Show("将领技能", $"{general.Name}发动{ Name }，腐化了{affected}个凡人单位", NotificationType.Warning);
            return true;
        }
    }
}
