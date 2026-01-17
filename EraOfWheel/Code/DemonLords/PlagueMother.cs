using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.DemonLords
{
    /// <summary>
    /// 瘟疫母神 - 万疫之源
    /// </summary>
    public class PlagueMother : BaseDemonLord
    {
        public override string Id => "plague_mother";
        public override string Name => "瘟疫母神";
        public override string Title => "万疫之源";
        public override string Description => "腐烂与疾病的化身，其子嗣遍布世界每个角落。她的呼吸带来瘟疫，她的触碰带来死亡。";
        public override DemonLordType Type => DemonLordType.Plague;

        private List<string> _activePlagues = new List<string>();
        private int _mutationLevel = 0;

        protected override void InitializeStats()
        {
            Stats["infection_rate"] = 1.0f;
            Stats["mutation_chance"] = 0.1f;
            Stats["plague_duration"] = 50f;
        }

        protected override void InitializeAbilities()
        {
            UnlockedAbilities.Add("minor_plague");
        }

        public override void ExecuteInvasion()
        {
            if (!IsAwakened) return;

            var threatLevel = GetThreatLevel();
            
            if (threatLevel >= 4)
            {
                ExecutePandemic();
            }
            else if (threatLevel >= 2)
            {
                ExecuteMutation();
            }
            else
            {
                SpreadPlague();
            }
        }

        private void SpreadPlague()
        {
            var plagueId = $"plague_{_activePlagues.Count + 1}";
            _activePlagues.Add(plagueId);
            
            Logger.Info("PlagueMother", $"瘟疫母神释放【疫病】: {plagueId}");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "plague"));
        }

        private void ExecuteMutation()
        {
            _mutationLevel++;
            Stats["infection_rate"] += 0.2f;
            
            // 随机变异现有瘟疫
            if (_activePlagues.Count > 0)
            {
                Logger.Info("PlagueMother", $"瘟疫母神发动【变异】等级: {_mutationLevel}");
            }
            
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "mutation"));
        }

        private void ExecutePandemic()
        {
            Logger.Info("PlagueMother", "⚠️ 瘟疫母神发动【大瘟疫】！");
            
            // 所有瘟疫同时加强
            Stats["infection_rate"] *= 1.5f;
            
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "pandemic"));
        }

        public override void Evolve(PlayerActionData actions)
        {
            // 学习玩家的治疗模式
            if (actions.ActionCounts.TryGetValue("heal", out int healCount))
            {
                if (healCount > 3)
                {
                    Stats["mutation_chance"] += 0.05f;
                    Logger.Debug("PlagueMother", "瘟疫母神进化: 增强变异能力");
                }
            }
            
            // 解锁新能力
            if (_mutationLevel >= 5 && !UnlockedAbilities.Contains("super_mutation"))
            {
                UnlockedAbilities.Add("super_mutation");
                Logger.Info("PlagueMother", "瘟疫母神解锁新能力: 【超级变异】");
            }
        }

        public override int GetThreatLevel()
        {
            var baseThreat = base.GetThreatLevel();
            return baseThreat + _activePlagues.Count + (_mutationLevel / 2);
        }

        public override void Seal()
        {
            base.Seal();
            _activePlagues.Clear();
            _mutationLevel = 0;
        }
    }
}
