using EraWheel.Combat.Effects;
using EraWheel.Combat.Equipment;
using EraWheel.Combat.Demons;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Terrain;
using EraWheel.Combat.Traits;
using EraWheel.Combat.Triggers;
using EraWheel.Core.Logging;
using EraWheel.Core.Random;
using EraWheel.Reflection;

namespace EraWheel.Combat;

public sealed class EraCombatRuntimeService
{
    private readonly EraStableRandomService _stableRandom;

    public EraTriggerService Triggers { get; }
    public EraStatusRuntimeService Statuses { get; }
    public EraEffectService Effects { get; }
    public EraTerrainAreaService TerrainAreas { get; }
    public EraTraitRuntimeService Traits { get; }
    public EraEquipmentRuntimeService Equipment { get; }
    public EraDemonSkillRuntimeService DemonSkills { get; }

    public EraCombatRuntimeService(EraStableRandomService stableRandom)
    {
        _stableRandom = stableRandom;
        EraCombatPatchInstaller.EnsurePatched();
        Statuses = new EraStatusRuntimeService();
        Effects = new EraEffectService(Statuses);
        TerrainAreas = new EraTerrainAreaService();
        Triggers = new EraTriggerService(_stableRandom, Effects, Statuses);
        Traits = new EraTraitRuntimeService(_stableRandom, Triggers, Effects, Statuses, TerrainAreas);
        Equipment = new EraEquipmentRuntimeService(_stableRandom, Triggers, Effects, Statuses, TerrainAreas);
        DemonSkills = new EraDemonSkillRuntimeService(Triggers, Effects, Statuses, TerrainAreas);
    }

    public void Update()
    {
        if (!WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) || mapStats == null)
        {
            return;
        }

        Triggers.DrainQueued();
        Statuses.Update((float)mapStats.world_time);
        TerrainAreas.Update((float)mapStats.world_time);
        Traits.Update((float)mapStats.world_time);
        Equipment.Update((float)mapStats.world_time);
    }

    public string CreateStatusReport()
    {
        return $"触发={Triggers.CreateStatusReport()}；状态={Statuses.CreateStatusReport()}；效果={Effects.CreateStatusReport()}；区域地形={TerrainAreas.CreateStatusReport()}；特质运行时={Traits.CreateStatusReport()}；装备运行时={Equipment.CreateStatusReport()}；魔王技能={DemonSkills.CreateStatusReport()}";
    }

    public void Bind()
    {
        EraCombatRuntimeBridge.Bind(this);
        EraLog.Info(EraLogCategory.Combat, $"战斗原语运行时已初始化：{CreateStatusReport()}");
    }
}
