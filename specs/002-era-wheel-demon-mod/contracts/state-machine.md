# State Machine Contract: 纪元之轮状态机

**Version**: 1.0.0  
**Date**: 2026-01-19

---

## EraPhase State Machine

### States

| State | 中文名 | 描述 | 典型持续时间 |
|-------|--------|------|-------------|
| `Sealed` | 封印状态 | 魔王被封印，世界和平发展 | 直到触发条件满足 |
| `Omen` | 预兆阶段 | 不祥征兆出现，世界开始警觉 | 20-50年 |
| `Awakening` | 苏醒准备 | 魔王30%强度实体化，试探性入侵 | 10-30年 |
| `Invasion` | 正式降临 | 魔王完全苏醒，全面入侵开始 | 50-100年 |
| `Peak` | 全盛期 | 魔王最强状态，所有技能/将领激活 | 20-50年 |
| `Weakening` | 衰弱期 | 魔王受创，封印战窗口开启 | 直到封印成功 |
| `Resealed` | 被再封印 | 封印成功，触发轮回计数+1 | 瞬时（结算后） |

### Transitions

```yaml
transitions:
  - from: Sealed
    to: Omen
    trigger: seal_weakened
    conditions:
      - type: seal_strength
        operator: lt
        value: 30
    # 第1轮回特殊规则
    alt_conditions:
      - type: cycle_count
        operator: eq
        value: 0
      - type: prosperity_reached  # 繁荣度触发
        operator: eq
        value: true

  - from: Omen
    to: Awakening
    trigger: omen_complete
    conditions:
      - type: phase_duration
        operator: gte
        value: 20  # 年

  - from: Awakening
    to: Invasion
    trigger: awakening_complete
    conditions:
      - type: demon_spawn_complete
        operator: eq
        value: true

  - from: Invasion
    to: Peak
    trigger: demon_peak
    conditions:
      - type: demon_health_percent
        operator: gt
        value: 70

  - from: Invasion
    to: Weakening
    trigger: invasion_timeout
    conditions:
      - type: phase_duration
        operator: gte
        value: 200  # 年 (保底超时)

  - from: Peak
    to: Weakening
    trigger: demon_weakened
    conditions:
      - type: demon_health_percent
        operator: lt
        value: 30

  - from: Weakening
    to: Resealed
    trigger: seal_success
    conditions:
      - type: any_seal_condition
        operator: eq
        value: true

  - from: Resealed
    to: Sealed
    trigger: cycle_complete
    conditions:
      - type: settlement_complete
        operator: eq
        value: true
    actions:
      - type: increment_cycle_count
      - type: grant_legacies
      - type: reset_demon_lord
```

### Entry/Exit Actions

```yaml
state_actions:
  Sealed:
    on_enter:
      - reset_seal_strength: 100
      - stop_demon_activity
      - enable_prosperity_tracking
    on_exit:
      - disable_prosperity_tracking

  Omen:
    on_enter:
      - trigger_omen_events
      - show_warning_ui
      - start_omen_timer
    on_exit:
      - clear_omen_events

  Awakening:
    on_enter:
      - select_demon_lord
      - spawn_demon_at_30_percent
      - create_stronghold
    on_exit:
      - log_awakening_complete

  Invasion:
    on_enter:
      - demon_full_power
      - start_legion_waves
      - activate_initial_generals: 2
    on_exit:
      - stop_legion_spawn

  Peak:
    on_enter:
      - activate_all_generals
      - reduce_skill_cooldowns: 50%
      - double_legion_spawn_rate
    on_exit:
      - restore_normal_rates

  Weakening:
    on_enter:
      - open_seal_window
      - spawn_seal_sites
      - enable_betrayal_chance
    on_exit:
      - close_seal_window

  Resealed:
    on_enter:
      - calculate_settlement
      - grant_legacies
      - record_cycle_history
      - increment_cycle_count
    on_exit:
      - reset_demon_state
      - cleanup_legion_units
```

---

## DemonLordState State Machine

### States

| State | 描述 | HP 条件 |
|-------|------|---------|
| `Disabled` | 玩家禁用此魔王 | N/A |
| `Sealed` | 魔王被封印，不活跃 | N/A |
| `Awakening` | 正在苏醒，30%强度 | N/A |
| `Active` | 完全苏醒，正常战斗 | HP > 30% |
| `Peak` | 全盛状态，强化 | HP > 70% |
| `Weakened` | 衰弱状态，可被封印 | HP < 30% |
| `Defeated` | 被封印，等待下一轮回 | HP = 0 or 封印成功 |

### Transitions

```yaml
demon_lord_transitions:
  - from: Disabled
    to: Sealed
    trigger: player_enable
    
  - from: Sealed
    to: Disabled
    trigger: player_disable
    
  - from: Sealed
    to: Awakening
    trigger: era_awakening
    conditions:
      - type: era_phase
        operator: eq
        value: Awakening
      - type: is_selected_demon
        operator: eq
        value: true
        
  - from: Awakening
    to: Active
    trigger: awakening_complete
    actions:
      - set_health_percent: 100
      
  - from: Active
    to: Peak
    trigger: health_high
    conditions:
      - type: health_percent
        operator: gt
        value: 70
        
  - from: Active
    to: Weakened
    trigger: health_low
    conditions:
      - type: health_percent
        operator: lt
        value: 30
        
  - from: Peak
    to: Active
    trigger: health_drop
    conditions:
      - type: health_percent
        operator: lte
        value: 70
        
  - from: Peak
    to: Weakened
    trigger: health_critical
    conditions:
      - type: health_percent
        operator: lt
        value: 30
        
  - from: Weakened
    to: Defeated
    trigger: seal_success
    
  - from: Defeated
    to: Sealed
    trigger: next_cycle
```

---

## General State Machine

### States

| State | 描述 |
|-------|------|
| `Inactive` | 未激活，等待召唤 |
| `Active` | 活跃战斗中 |
| `Retreating` | 撤退中（HP < 20%） |
| `Defeated` | 被击败，冷却中 |
| `Betrayed` | 已背叛，加入文明 |

### Transitions

```yaml
general_transitions:
  - from: Inactive
    to: Active
    trigger: activated
    conditions:
      - type: demon_lord_state
        operator: in
        value: [Active, Peak]
      - type: activation_slot_available
        operator: eq
        value: true
        
  - from: Active
    to: Retreating
    trigger: low_health
    conditions:
      - type: health_percent
        operator: lt
        value: 20
        
  - from: Retreating
    to: Active
    trigger: healed
    conditions:
      - type: health_percent
        operator: gt
        value: 50
        
  - from: [Active, Retreating]
    to: Defeated
    trigger: killed
    actions:
      - increment_defeat_count
      - start_respawn_timer
      
  - from: Defeated
    to: Active
    trigger: respawned
    conditions:
      - type: respawn_timer_complete
        operator: eq
        value: true
      - type: demon_lord_active
        operator: eq
        value: true
        
  - from: [Active, Retreating, Defeated]
    to: Betrayed
    trigger: betrayal
    conditions:
      - type: defeat_count
        operator: gte
        value: 3
      - type: random_chance
        operator: success
        value: 0.02  # 2% base
    actions:
      - switch_faction: civilization
      - notify_betrayal_event
```

---

## Seal Conditions

### Victory Conditions (至少一个为 true 时封印成功)

```yaml
seal_conditions:
  execution:
    name: "击杀封印"
    description: "将魔王生命值降至0"
    condition:
      type: demon_health
      operator: lte
      value: 0
    enabled: true  # 默认启用
    is_fallback: true  # 保底条件

  ritual:
    name: "仪式封印"
    description: "在封印遗迹完成封印仪式"
    condition:
      type: seal_ritual_progress
      operator: gte
      value: 100
    enabled: true
    requirements:
      - seal_site_controlled
      - ritual_participants: 3

  time_window:
    name: "时间窗口封印"
    description: "在封印战窗口内存活足够时间"
    condition:
      type: seal_window_duration
      operator: gte
      value: 50  # 年
    enabled: true
    requirements:
      - civilization_survive

  alliance:
    name: "联盟封印"
    description: "反魔联盟联合封印"
    condition:
      type: alliance_seal_progress
      operator: gte
      value: 100
    enabled: false  # 默认关闭
    requirements:
      - alliance_formed
      - alliance_members: 3
```

### Fallback Rule (Constitution 第 I 条)

```yaml
fallback_rule:
  trigger: all_conditions_disabled
  action: force_enable_execution
  message: "封印胜利条件全部关闭，已自动启用击杀封印作为保底"
```

---

## Events (状态机事件)

### Phase Change Events

```csharp
public class PhaseChangedEvent
{
    public EraPhase PreviousPhase;
    public EraPhase NewPhase;
    public long WorldTime;
    public string TriggerReason;
}

public class DemonLordStateChangedEvent
{
    public string DemonLordId;
    public DemonLordState PreviousState;
    public DemonLordState NewState;
    public long WorldTime;
}

public class CycleCompletedEvent
{
    public int CycleNumber;
    public CycleSummary Summary;
}
```

### Event Bus Usage

```csharp
// 订阅
EventBus.Subscribe<PhaseChangedEvent>(OnPhaseChanged);

// 发布
EventBus.Publish(new PhaseChangedEvent
{
    PreviousPhase = EraPhase.Omen,
    NewPhase = EraPhase.Awakening,
    WorldTime = World.world.worldAge,
    TriggerReason = "预兆阶段持续时间达到阈值"
});
```
