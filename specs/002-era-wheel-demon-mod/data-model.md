# Data Model: 纪元之轮：魔王轮回 MOD

**Feature Branch**: `002-era-wheel-demon-mod`  
**Date**: 2026-01-19  
**Status**: Complete

---

## Entity Overview

```
┌─────────────────────────────────────────────────────────────────┐
│                        MOD 核心数据模型                          │
├─────────────────────────────────────────────────────────────────┤
│  CycleManager (轮回管理器)                                       │
│  ├── CycleCount: int                                            │
│  ├── CurrentPhase: EraPhase                                     │
│  ├── SealStrength: float                                        │
│  └── CycleHistory: List<CycleSummary>                          │
├─────────────────────────────────────────────────────────────────┤
│  DemonLordRegistry (魔王注册表)                                  │
│  ├── DemonLords: Dictionary<string, DemonLord>                  │
│  └── ActiveDemonLord: DemonLord                                 │
├─────────────────────────────────────────────────────────────────┤
│  CivilizationTracker (文明追踪器)                                │
│  ├── Civilizations: Dictionary<Kingdom, CivData>                │
│  ├── Alliance: AntiDemonAlliance                                │
│  └── Heroes: List<Hero>                                         │
├─────────────────────────────────────────────────────────────────┤
│  NarrativeEngine (叙事引擎)                                      │
│  ├── EventPool: EventPool                                       │
│  ├── Chronicle: WorldChronicle                                  │
│  └── AIEngine: AIStoryEngine                                    │
└─────────────────────────────────────────────────────────────────┘
```

---

## Core Entities

### 1. Cycle (轮回)

轮回是从"魔王被再封印"到"下一次魔王被再封印"的完整周期。

```csharp
public class CycleData
{
    // === 标识 ===
    public int CycleNumber;                    // 轮回编号 (1-based)
    public long StartWorldAge;                 // 开始时的世界年龄
    public long EndWorldAge;                   // 结束时的世界年龄（进行中为-1）
    
    // === 状态 ===
    public EraPhase CurrentPhase;              // 当前纪元阶段
    public float SealStrength;                 // 封印强度 (0-100)
    public CycleStatus Status;                 // 进行中/已完成
    
    // === 魔王信息 ===
    public string ActiveDemonLordId;           // 活跃魔王ID
    public DemonLordState DemonLordState;      // 魔王状态
    
    // === 结算数据（完成时填充） ===
    public CycleSummary Summary;               // 轮回结算摘要
}

public enum CycleStatus
{
    InProgress,   // 进行中
    Completed     // 已完成
}
```

### 2. EraPhase (纪元阶段)

纪元阶段是轮回内部的进程状态。

```csharp
public enum EraPhase
{
    Sealed,      // 封印状态 - 魔王被封印，世界和平发展
    Omen,        // 预兆阶段 - 不祥征兆出现，世界开始警觉
    Awakening,   // 苏醒准备 - 魔王30%强度实体化，试探性入侵
    Invasion,    // 正式降临 - 魔王完全苏醒，全面入侵开始
    Peak,        // 全盛期   - 魔王最强状态，所有技能/将领激活
    Weakening,   // 衰弱期   - 魔王受创，封印战窗口开启
    Resealed     // 被再封印 - 封印成功，触发轮回计数+1
}

public class PhaseTransition
{
    public EraPhase FromPhase;
    public EraPhase ToPhase;
    public long TransitionTime;      // 世界年龄
    public string TriggerReason;     // 触发原因描述
}
```

### 3. DemonLord (魔王)

魔王是末世概念的实体化，是轮回系统的核心对抗目标。

```csharp
public class DemonLord
{
    // === 基础信息 ===
    public string Id;                          // 唯一ID (e.g., "void_lord")
    public string NameKey;                     // 本地化名称键
    public string TitleKey;                    // 称号本地化键
    public DemonLordType Type;                 // 魔王类型
    public int DangerLevel;                    // 危险等级 (1-5)
    
    // === 配置（只读） ===
    public DemonLordConfig Config;             // 基础配置
    
    // === 运行时状态（可变） ===
    public bool Enabled;                       // 是否启用
    public DemonLordState State;               // 当前状态
    public float CurrentHealth;                // 当前生命值
    public float MaxHealth;                    // 最大生命值（含轮回加成）
    
    // === 战斗数据 ===
    public int TotalKills;                     // 累计击杀数
    public int CitiesDestroyed;                // 摧毁城市数
    public int HeroesKilled;                   // 击杀英雄数
    
    // === 将领与军团 ===
    public List<General> Generals;             // 将领列表
    public LegionWaveState LegionState;        // 军团波次状态
    
    // === 据点 ===
    public StrongholdData Stronghold;          // 据点数据
}

public enum DemonLordType
{
    Void,       // 虚无之主
    Plague,     // 瘟疫母神
    Machine,    // 机械暴君
    Time,       // 时空扭曲者
    Flame,      // 混沌炎魔
    Abyss,      // 深渊邪神
    Death,      // 死亡君王
    Soul,       // 灵魂编织者
    Nature,     // 自然之怒
    Judgment    // 终焉审判者
}

public enum DemonLordState
{
    Disabled,       // 禁用
    Sealed,         // 封印中
    Awakening,      // 苏醒中
    Active,         // 活跃（降临）
    Peak,           // 全盛期
    Weakened,       // 衰弱
    Defeated        // 被封印
}
```

### 4. DemonLordConfig (魔王配置)

```csharp
public class DemonLordConfig
{
    // === 基础属性 ===
    public float BaseHealth = 10000f;
    public float BaseDamage = 500f;
    public float BaseArmor = 200f;
    public float BaseSpeed = 30f;
    public float Scale = 0.3f;                 // 单位缩放
    
    // === 成长配置 ===
    public float CycleGrowthRate = 0.25f;      // 每轮回属性增长率
    public float GrowthCap = 2.0f;             // 成长上限 (+200%)
    
    // === 技能 ===
    public List<SkillConfig> Skills;           // 技能配置列表
    
    // === 将领模板 ===
    public List<GeneralTemplate> GeneralTemplates; // 5个将领模板
    
    // === 军团配置 ===
    public LegionConfig LegionConfig;          // 军团波次配置
    
    // === 独特机制 ===
    public string UniqueMechanicId;            // 独特机制ID
    public Dictionary<string, float> MechanicParams; // 机制参数
    
    // === 资源 ===
    public string SpritePath;                  // 精灵图路径
    public string IconPath;                    // 图标路径
}
```

### 5. General (将领)

```csharp
public class General
{
    // === 基础信息 ===
    public string Id;
    public string NameKey;
    public GeneralRole Role;                   // 先锋/坦克/输出/辅助/精英
    public string DemonLordId;                 // 所属魔王
    
    // === 属性（基于模板 × 轮回倍率） ===
    public float Health;
    public float MaxHealth;
    public float Damage;
    public float Armor;
    public float Speed;
    
    // === 状态 ===
    public GeneralState State;
    public int DefeatCount;                    // 被击败次数（影响背叛概率）
    public bool HasBetrayed;                   // 是否已背叛
    
    // === 技能 ===
    public List<SkillState> Skills;
    
    // === 游戏内引用 ===
    public Actor GameActor;                    // WorldBox Actor 引用
}

public enum GeneralRole
{
    Vanguard,   // 先锋型 - 高速低防
    Tank,       // 坦克型 - 高防高血
    DPS,        // 输出型 - 高攻低血
    Support,    // 辅助型 - Buff/召唤
    Elite       // 精英型 - 均衡多技能
}

public enum GeneralState
{
    Inactive,   // 未激活
    Active,     // 活跃
    Retreating, // 撤退中
    Defeated,   // 被击败
    Betrayed    // 已背叛
}
```

### 6. LegionWave (军团波次)

```csharp
public class LegionWaveState
{
    public int CurrentWave;                    // 当前波次
    public long LastWaveTime;                  // 上次生成时间
    public int TotalUnitsSpawned;              // 累计生成单位数
    public int AliveUnits;                     // 存活单位数
    
    public List<LegionUnit> ActiveUnits;       // 活跃单位列表
}

public class LegionConfig
{
    public int WaveInterval = 10;              // 波次间隔（年）
    public int BaseUnitsPerWave = 30;          // 基础每波单位数
    public float WaveGrowthRate = 0.15f;       // 每波增长率
    public int MaxUnitsPerWave = 100;          // 单波上限
    public int MaxAliveUnits = 200;            // 同时存活上限
    
    public List<LegionUnitTemplate> UnitTemplates; // 4类单位模板
}

public class LegionUnitTemplate
{
    public string Id;
    public LegionTier Tier;                    // 先锋/主力/精锐/终极
    public int MinWave;                        // 最小出现波次
    public float SpawnWeight;                  // 生成权重
    
    public float BaseHealth;
    public float BaseDamage;
    public float BaseArmor;
    public float Speed;
    
    public List<string> Traits;                // 默认特性
}

public enum LegionTier
{
    Vanguard,   // 先锋 (1-3波)
    Main,       // 主力 (4-6波)
    Elite,      // 精锐 (7-9波)
    Ultimate    // 终极 (10+波)
}
```

### 7. Civilization Data (文明数据)

```csharp
public class CivData
{
    // === 引用 ===
    public Kingdom Kingdom;                    // WorldBox Kingdom 引用
    
    // === MOD 扩展数据 ===
    public int AntiDemonLevel;                 // 抗魔等级 (0-10)
    public int DemonKillCount;                 // 魔物击杀数
    public float CSI;                          // 文明强度指数 (0-100)
    
    // === 遗产 ===
    public Dictionary<string, int> Legacies;   // 遗产ID -> 层数
    
    // === 联盟状态 ===
    public bool InAlliance;                    // 是否在反魔联盟中
    public int AllianceContribution;           // 联盟贡献度
}

public class AntiDemonAlliance
{
    public bool Formed;                        // 是否已组建
    public long FormTime;                      // 组建时间
    public List<Kingdom> Members;              // 成员列表
    public Kingdom Leader;                     // 盟主
    
    public int TotalKills;                     // 联盟总击杀
    public int AidSent;                        // 援军派遣次数
    public List<AllianceCouncil> Councils;     // 议会记录
}
```

### 8. Hero (英雄)

```csharp
public class Hero
{
    // === 引用 ===
    public Actor Actor;                        // WorldBox Actor 引用
    public Kingdom Kingdom;                    // 所属文明
    
    // === MOD 扩展数据 ===
    public bool IsDestined;                    // 是否为命定英雄
    public HeroState State;
    public int DemonLordDamageDealt;           // 对魔王造成的伤害
    public int GeneralsDefeated;               // 击败将领数
    
    // === 家族 ===
    public string FamilyId;                    // 家族ID
    public List<string> InheritedTraits;       // 继承的特性
    
    // === 传记 ===
    public List<HeroEvent> Biography;          // 传记事件
}

public enum HeroState
{
    Alive,
    Dead,
    Legendary                                  // 已成为传奇
}
```

### 9. Legacy (纪元遗产)

```csharp
public class Legacy
{
    public string Id;
    public string NameKey;
    public string DescriptionKey;
    public LegacyType Type;
    public LegacyPolarity Polarity;            // 正面/负面
    
    public string TraitId;                     // 对应的 Trait ID
    public float EffectValue;                  // 效果值
    public int MaxStacks;                      // 最大叠加层数
    public float StackDiminish;                // 叠加递减系数
    
    public LegacyScope Scope;                  // 应用范围
}

public enum LegacyType
{
    Military,   // 军事遗产
    Economic,   // 经济遗产
    Tech,       // 科技遗产
    Legendary,  // 传奇遗产
    Curse       // 诅咒遗产
}

public enum LegacyPolarity
{
    Positive,
    Negative
}

public enum LegacyScope
{
    Civilization,  // 文明范围（新生单位）
    Hero,          // 仅英雄
    Global         // 全局
}
```

### 10. Event (事件)

```csharp
public class NarrativeEvent
{
    public string Id;
    public string NameKey;
    public EventCategory Category;
    public int Priority;                       // 优先级 (越高越先触发)
    
    // === 触发条件 ===
    public List<EventCondition> Conditions;
    
    // === 内容 ===
    public string DescriptionKey;              // 描述文本键
    public List<EventChoice> Choices;          // 选择分支
    
    // === 效果 ===
    public List<EventEffect> Effects;
    
    // === 控制 ===
    public int Cooldown;                       // 冷却时间（年）
    public bool Repeatable;                    // 是否可重复
    public long LastTriggered;                 // 上次触发时间
}

public enum EventCategory
{
    Omen,       // 预兆事件
    Hero,       // 英雄事件
    Civilization, // 文明事件
    Mystery,    // 神秘事件
    Battle,     // 战斗事件
    System      // 系统事件
}

public class EventCondition
{
    public ConditionType Type;
    public string Target;                      // 目标（魔王ID/文明ID等）
    public CompareOp Operator;                 // 比较操作
    public float Value;                        // 比较值
}

public class EventEffect
{
    public EffectType Type;
    public string Target;
    public float Value;
    public int Duration;                       // 持续时间（年），0=永久
}
```

### 11. CycleSummary (轮回结算摘要)

```csharp
public class CycleSummary
{
    public int CycleNumber;
    public long StartTime;
    public long EndTime;
    public int Duration;                       // 持续年数
    
    // === 魔王信息 ===
    public string DemonLordId;
    public SealMethod SealMethod;              // 封印方式
    public float DemonLordFinalHealth;         // 封印时生命值
    
    // === 战斗统计 ===
    public int TotalDeaths;                    // 总死亡数
    public int CitiesLost;                     // 失去城市数
    public int HeroesLost;                     // 牺牲英雄数
    public int GeneralsDefeated;               // 击败将领数
    
    // === 参与文明 ===
    public List<CivCycleSummary> Civilizations;
    
    // === 发放遗产 ===
    public List<LegacyGrant> LegaciesGranted;
    
    // === 关键事件 ===
    public List<string> KeyEvents;
}

public enum SealMethod
{
    Execution,   // 击杀封印
    Ritual,      // 仪式封印
    TimeWindow,  // 时间窗口封印
    Alliance     // 联盟封印
}
```

---

## Relationships

```
CycleManager 1 ──── * CycleSummary        (历史记录)
CycleManager 1 ──── 1 DemonLord           (当前活跃)
DemonLord    1 ──── * General             (将领团队)
DemonLord    1 ──── 1 LegionWaveState     (军团状态)
DemonLord    1 ──── 1 StrongholdData      (据点)
Kingdom      1 ──── 1 CivData             (MOD扩展数据)
Kingdom      1 ──── * Hero                (英雄)
CivData      1 ──── * Legacy              (已获得遗产)
Alliance     1 ──── * Kingdom             (联盟成员)
EventPool    1 ──── * NarrativeEvent      (事件库)
```

---

## Validation Rules

### 数值边界（Constitution 第 II 条）

| 字段 | 最小值 | 最大值 | 默认值 |
|------|--------|--------|--------|
| CycleCount | 0 | 999 | 0 |
| SealStrength | 0 | 100 | 100 |
| DemonLord.StrengthMultiplier | 0.6 | 3.0 | 1.0 |
| General.Count | 0 | 6 | 2 |
| Legion.EliteRate | 0% | 30% | 10% |
| AntiDemonLevel | 0 | 10 | 0 |
| CSI | 0 | 100 | 50 |
| Legacy.Stacks | 1 | 5 | 1 |

### 状态转换规则（Constitution 第 I 条）

```
Sealed → Omen:       SealStrength < 30% OR 繁荣度触发（第1轮回）
Omen → Awakening:    预兆持续 >= 配置时间
Awakening → Invasion: 苏醒完成条件满足
Invasion → Peak:     DemonLord.Health > 70%
Peak → Weakening:    DemonLord.Health < 30% OR 入侵超时
Weakening → Resealed: 任意封印条件满足
Resealed → Sealed:   轮回结算完成后自动转换
```

### 保底规则（Constitution 第 I 条）

1. **封印胜利保底**: 如果所有封印条件关闭，强制启用 `Execution`
2. **轮回触发保底**: 如果触发条件全为0，强制使用 `WorldAge >= 600`
3. **入侵超时保底**: 入侵持续 >= 200年，强制进入 Weakening

---

## State Transitions

### EraPhase 状态机

```
        ┌──────────────────────────────────────────────────┐
        │                                                  │
        ▼                                                  │
    ┌───────┐    ┌──────┐    ┌──────────┐    ┌─────────┐  │
    │Sealed │───▶│ Omen │───▶│Awakening │───▶│Invasion │  │
    └───────┘    └──────┘    └──────────┘    └────┬────┘  │
        ▲                                         │       │
        │                                         ▼       │
    ┌────────┐   ┌──────────┐                ┌───────┐   │
    │Resealed│◀──│Weakening │◀───────────────│ Peak  │   │
    └────┬───┘   └──────────┘                └───────┘   │
         │                                               │
         └───────────────────────────────────────────────┘
              (轮回计数+1, 发放遗产后回到Sealed)
```

### DemonLordState 状态机

```
    ┌──────────┐
    │ Disabled │ (玩家禁用)
    └──────────┘
         │ 启用
         ▼
    ┌──────────┐
    │  Sealed  │◀─────────────────────────────┐
    └────┬─────┘                              │
         │ 封印强度<30%                        │
         ▼                                    │
    ┌──────────┐                              │
    │Awakening │                              │
    └────┬─────┘                              │
         │ 苏醒完成                            │
         ▼                                    │
    ┌──────────┐                              │
    │  Active  │                              │
    └────┬─────┘                              │
         │ HP>70%                             │
         ▼                                    │
    ┌──────────┐                              │
    │   Peak   │                              │
    └────┬─────┘                              │
         │ HP<30%                             │
         ▼                                    │
    ┌──────────┐                              │
    │ Weakened │                              │
    └────┬─────┘                              │
         │ 封印成功                            │
         ▼                                    │
    ┌──────────┐                              │
    │ Defeated │──────────────────────────────┘
    └──────────┘   (下一轮回开始时重置)
```

---

## Persistence Schema

### ModSaveData (顶层存档结构)

```json
{
  "modVersion": "1.0.0",
  "savedAt": "2026-01-19T12:00:00Z",
  
  "cycle": {
    "cycleCount": 3,
    "currentPhase": "Invasion",
    "sealStrength": 45.5,
    "phaseStartTime": 1250
  },
  
  "demonLords": {
    "void_lord": {
      "enabled": true,
      "state": "Active",
      "currentHealth": 8500,
      "totalKills": 342,
      "generals": [...]
    }
  },
  
  "civilizations": {
    "kingdom_1": {
      "antiDemonLevel": 6,
      "legacies": {
        "legacy_warrior": 2,
        "legacy_armor": 1
      }
    }
  },
  
  "cycleHistory": [...],
  "chronicle": [...],
  "aiOperationLog": [...]
}
```
