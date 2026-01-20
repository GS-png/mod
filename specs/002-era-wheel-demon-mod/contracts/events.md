# Events Contract: 纪元之轮事件系统

**Version**: 1.0.0  
**Date**: 2026-01-19

---

## Event Categories

| Category | 中文名 | 描述 | 数量要求 |
|----------|--------|------|---------|
| `Omen` | 预兆事件 | 魔王苏醒前的征兆 | 30+ |
| `Hero` | 英雄事件 | 英雄诞生、成长、陨落 | 40+ |
| `Civilization` | 文明事件 | 文明兴衰转折 | 40+ |
| `Mystery` | 神秘事件 | 神秘现象、远古遗迹 | 30+ |
| `Battle` | 战斗事件 | 战斗关键时刻 | 30+ |
| `System` | 系统事件 | 轮回/阶段转换 | 30+ |

**Total**: 200+ 事件（满足 FR-024）

---

## Event Schema

```typescript
interface NarrativeEvent {
  // === 标识 ===
  id: string;                    // 唯一ID，格式: {category}_{number}
  nameKey: string;               // 本地化名称键
  category: EventCategory;
  priority: number;              // 1-100，越高越先触发
  
  // === 触发条件 ===
  conditions: EventCondition[];  // AND 关系
  conditionMode?: "AND" | "OR";  // 默认 AND
  
  // === 内容 ===
  descriptionKey: string;        // 描述文本键
  imageKey?: string;             // 可选图片
  
  // === 选择分支（可选） ===
  choices?: EventChoice[];
  
  // === 效果 ===
  effects: EventEffect[];
  
  // === 控制 ===
  cooldown: number;              // 冷却时间（年），0=无冷却
  repeatable: boolean;           // 是否可重复
  maxTriggers?: number;          // 最大触发次数，null=无限
}
```

---

## Condition Types

```typescript
type ConditionType =
  // === 轮回系统 ===
  | "cycle_count"           // 轮回次数
  | "era_phase"             // 当前阶段
  | "seal_strength"         // 封印强度
  | "phase_duration"        // 当前阶段持续时间
  
  // === 魔王系统 ===
  | "demon_lord_active"     // 魔王是否活跃
  | "demon_lord_type"       // 魔王类型
  | "demon_health_percent"  // 魔王生命值百分比
  | "demon_kill_count"      // 魔王击杀数
  | "generals_active"       // 活跃将领数
  
  // === 文明系统 ===
  | "total_population"      // 总人口
  | "city_count"            // 城市数量
  | "civ_count"             // 存活文明数
  | "anti_demon_level"      // 抗魔等级
  | "csi"                   // 文明强度指数
  | "alliance_formed"       // 联盟是否组建
  
  // === 英雄系统 ===
  | "hero_count"            // 英雄数量
  | "destined_hero_exists"  // 是否有命定英雄
  | "hero_level"            // 英雄等级
  
  // === 世界状态 ===
  | "world_age"             // 世界年龄
  | "random_chance"         // 随机概率
  | "event_triggered"       // 某事件是否已触发
  
  // === 特殊 ===
  | "npc_exists"            // 特定NPC是否存在
  | "building_exists"       // 特定建筑是否存在

type CompareOp = "eq" | "ne" | "lt" | "lte" | "gt" | "gte" | "in" | "not_in";
```

---

## Effect Types

```typescript
type EffectType =
  // === 单位效果 ===
  | "spawn_unit"            // 生成单位
  | "buff_unit"             // 给单位添加buff
  | "damage_unit"           // 对单位造成伤害
  | "heal_unit"             // 治愈单位
  
  // === 文明效果 ===
  | "modify_population"     // 修改人口
  | "modify_resources"      // 修改资源
  | "modify_anti_demon"     // 修改抗魔等级
  | "form_alliance"         // 组建联盟
  
  // === 魔王效果 ===
  | "modify_demon_health"   // 修改魔王生命
  | "modify_seal_strength"  // 修改封印强度
  | "spawn_general"         // 生成将领
  | "spawn_legion"          // 生成军团
  
  // === 系统效果 ===
  | "trigger_event"         // 触发另一事件
  | "show_notification"     // 显示通知
  | "add_chronicle"         // 添加编年史记录
  | "grant_legacy"          // 发放遗产
  
  // === 叙事效果 ===
  | "set_flag"              // 设置标记
  | "clear_flag"            // 清除标记
  | "start_quest"           // 开始任务线
```

---

## Sample Events

### Omen Events (预兆事件)

```json
{
  "id": "omen_prophet_warning",
  "nameKey": "event.omen.prophet_warning.name",
  "category": "Omen",
  "priority": 80,
  "conditions": [
    { "type": "era_phase", "operator": "eq", "value": "Omen" },
    { "type": "npc_exists", "operator": "eq", "value": "prophet" },
    { "type": "seal_strength", "operator": "lt", "value": 30 }
  ],
  "descriptionKey": "event.omen.prophet_warning.desc",
  "choices": [
    {
      "textKey": "event.omen.prophet_warning.choice1",
      "effects": [
        { "type": "modify_anti_demon", "target": "all", "value": 1 }
      ]
    },
    {
      "textKey": "event.omen.prophet_warning.choice2",
      "effects": [
        { "type": "show_notification", "value": "prophecy_ignored" }
      ]
    }
  ],
  "effects": [
    { "type": "add_chronicle", "value": "prophet_spoke" }
  ],
  "cooldown": 100,
  "repeatable": false
}
```

### Hero Events (英雄事件)

```json
{
  "id": "hero_destined_birth",
  "nameKey": "event.hero.destined_birth.name",
  "category": "Hero",
  "priority": 90,
  "conditions": [
    { "type": "demon_lord_active", "operator": "eq", "value": true },
    { "type": "destined_hero_exists", "operator": "eq", "value": false },
    { "type": "random_chance", "operator": "success", "value": 0.05 }
  ],
  "descriptionKey": "event.hero.destined_birth.desc",
  "effects": [
    { "type": "spawn_unit", "value": "destined_hero", "traits": ["legendary", "demon_slayer"] },
    { "type": "add_chronicle", "value": "hero_born" },
    { "type": "show_notification", "value": "destined_hero_appeared" }
  ],
  "cooldown": 200,
  "repeatable": true,
  "maxTriggers": 3
}
```

### Battle Events (战斗事件)

```json
{
  "id": "battle_last_stand",
  "nameKey": "event.battle.last_stand.name",
  "category": "Battle",
  "priority": 95,
  "conditions": [
    { "type": "era_phase", "operator": "eq", "value": "Invasion" },
    { "type": "city_count", "operator": "lte", "value": 3 },
    { "type": "civ_count", "operator": "gte", "value": 1 }
  ],
  "descriptionKey": "event.battle.last_stand.desc",
  "effects": [
    { "type": "buff_unit", "target": "all_defenders", "buff": "last_stand", "duration": 50 },
    { "type": "form_alliance", "value": "auto" },
    { "type": "add_chronicle", "value": "last_stand_declared" }
  ],
  "cooldown": 0,
  "repeatable": false
}
```

### System Events (系统事件)

```json
{
  "id": "system_cycle_complete",
  "nameKey": "event.system.cycle_complete.name",
  "category": "System",
  "priority": 100,
  "conditions": [
    { "type": "era_phase", "operator": "eq", "value": "Resealed" }
  ],
  "descriptionKey": "event.system.cycle_complete.desc",
  "effects": [
    { "type": "show_notification", "value": "cycle_complete" },
    { "type": "grant_legacy", "value": "auto" },
    { "type": "add_chronicle", "value": "demon_sealed" }
  ],
  "cooldown": 0,
  "repeatable": true
}
```

---

## Event Pool Management

### Selection Algorithm

```csharp
public NarrativeEvent SelectEvent(WorldContext context)
{
    // 1. 过滤满足条件的事件
    var candidates = _events
        .Where(e => e.IsEnabled)
        .Where(e => !IsOnCooldown(e))
        .Where(e => EvaluateConditions(e.Conditions, context))
        .ToList();
    
    // 2. 按优先级排序
    candidates.Sort((a, b) => b.Priority.CompareTo(a.Priority));
    
    // 3. 避免重复（同类事件间隔）
    candidates = FilterRecentDuplicates(candidates, context.RecentEvents);
    
    // 4. 加权随机选择（高优先级有更高概率）
    return WeightedRandomSelect(candidates);
}
```

### Cooldown Management

```csharp
public bool IsOnCooldown(NarrativeEvent e)
{
    if (e.Cooldown <= 0) return false;
    
    var lastTrigger = GetLastTriggerTime(e.Id);
    var currentTime = World.world.worldAge;
    
    return (currentTime - lastTrigger) < e.Cooldown;
}
```

### Duplicate Prevention

```csharp
public List<NarrativeEvent> FilterRecentDuplicates(
    List<NarrativeEvent> candidates, 
    List<string> recentEventIds)
{
    // 同类事件最近10次内不重复
    const int RECENT_WINDOW = 10;
    var recentSet = new HashSet<string>(recentEventIds.TakeLast(RECENT_WINDOW));
    
    return candidates
        .Where(e => e.Repeatable || !recentSet.Contains(e.Id))
        .ToList();
}
```

---

## Localization Keys

### Naming Convention

```
event.{category}.{event_name}.name    - 事件名称
event.{category}.{event_name}.desc    - 事件描述
event.{category}.{event_name}.choice{n} - 选择分支文本
event.{category}.{event_name}.result{n} - 选择结果文本
```

### Example (zh_CN.json)

```json
{
  "event.omen.prophet_warning.name": "先知的警告",
  "event.omen.prophet_warning.desc": "城中的老先知突然开始疯狂预言，他的眼睛泛着诡异的光芒：「封印正在瓦解...远古的恐惧即将苏醒...」",
  "event.omen.prophet_warning.choice1": "召集城主商议对策",
  "event.omen.prophet_warning.choice2": "将先知视为疯子驱逐",
  "event.omen.prophet_warning.result1": "各文明开始加强防御准备",
  "event.omen.prophet_warning.result2": "警告被忽视，人们继续享乐"
}
```

---

## Integration with AI Story Engine

### AI Enhancement Flow

```
1. EventPool.SelectEvent() → 基础事件
2. AIStoryEngine.EnhanceDescription(event, context) → 润色描述
3. Display to player
```

### AI Prompt Template

```
你是一个史诗故事叙述者。基于以下事件和世界状态，生成一段生动的描述（100-200字）：

事件类型：{event.category}
事件名称：{event.name}
当前轮回：第{cycleCount}轮回
活跃魔王：{demonLord.name}
世界年龄：{worldAge}年

基础描述：{event.description}

要求：
- 保持史诗感和紧张感
- 引用具体的地名、人名（如果存在）
- 不要编造不存在的角色或事件
- 符合当前世界状态
```

### Fallback (无 LLM 时)

直接使用 `event.descriptionKey` 对应的本地化文本。
