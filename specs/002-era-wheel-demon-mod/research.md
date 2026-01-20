# Technical Research: 纪元之轮：魔王轮回 MOD

**Feature Branch**: `002-era-wheel-demon-mod`  
**Date**: 2026-01-19  
**Status**: Complete

---

## Research Tasks Summary

| 领域 | 研究问题 | 状态 |
|------|---------|------|
| 状态机实现 | 如何在 Unity MOD 中实现7状态轮回状态机 | ✅ 已解决 |
| 单位系统 | 如何使用 AssetManager 创建自定义魔王/将领/军团 | ✅ 已解决 |
| 特性系统 | 如何创建和应用自定义 Traits 实现遗产效果 | ✅ 已解决 |
| UI集成 | 如何在 WorldBox 中创建控制面板 UI | ✅ 已解决 |
| 配置系统 | 如何实现三层优先级配置和热重载 | ✅ 已解决 |
| 存档集成 | 如何保存和加载 MOD 状态 | ✅ 已解决 |
| LLM集成 | 如何在 C# 中调用外部 LLM API | ✅ 已解决 |
| 性能优化 | 如何实现分层更新和对象池 | ✅ 已解决 |

---

## Decision 1: 状态机实现方案

### 决策
采用**枚举+委托模式**实现纪元阶段状态机，不引入第三方状态机库。

### 理由
1. WorldBox MOD 环境对外部依赖有限制，NeoModLoader 不保证所有库兼容
2. 状态数量固定（7个），转换规则明确，无需复杂状态机框架
3. 枚举模式代码简洁，调试友好，符合 MOD 开发习惯

### 替代方案评估
- **UniState 库**: 功能强大但需要 UniTask 依赖，可能与 WorldBox 冲突
- **ScriptableObject 状态机**: 过于复杂，不适合 MOD 场景
- **行为树**: 过度设计，状态转换逻辑简单不需要

### 实现示例

```csharp
public enum EraPhase
{
    Sealed,      // 封印状态
    Omen,        // 预兆阶段
    Awakening,   // 苏醒准备
    Invasion,    // 正式降临
    Peak,        // 全盛期
    Weakening,   // 衰弱期
    Resealed     // 被再封印（触发轮回计数+1后回到Sealed）
}

public class EraStateMachine
{
    public EraPhase CurrentPhase { get; private set; } = EraPhase.Sealed;
    
    private Dictionary<EraPhase, Func<bool>> _transitionConditions;
    private Dictionary<EraPhase, EraPhase> _nextPhaseMap;
    
    public void Initialize()
    {
        _nextPhaseMap = new Dictionary<EraPhase, EraPhase>
        {
            { EraPhase.Sealed, EraPhase.Omen },
            { EraPhase.Omen, EraPhase.Awakening },
            { EraPhase.Awakening, EraPhase.Invasion },
            { EraPhase.Invasion, EraPhase.Peak },
            { EraPhase.Peak, EraPhase.Weakening },
            { EraPhase.Weakening, EraPhase.Resealed },
            { EraPhase.Resealed, EraPhase.Sealed }
        };
    }
    
    public bool TryTransition()
    {
        if (_transitionConditions[CurrentPhase]())
        {
            var previousPhase = CurrentPhase;
            CurrentPhase = _nextPhaseMap[CurrentPhase];
            OnPhaseChanged?.Invoke(previousPhase, CurrentPhase);
            return true;
        }
        return false;
    }
    
    public event Action<EraPhase, EraPhase> OnPhaseChanged;
}
```

---

## Decision 2: 自定义单位创建方案

### 决策
使用 **AssetManager.unitStats.clone()** 克隆现有单位模板，修改属性后注册为新单位。

### 理由
1. WorldBox Wiki 明确记录此 API，CollectionMod 等已验证可行
2. 克隆方式继承基础行为，只需修改差异属性
3. 支持自定义精灵图加载

### API 确认状态

| API | 用途 | 确认来源 |
|-----|------|---------|
| `AssetManager.unitStats.get(id)` | 获取单位模板 | Wiki 文档 ✅ |
| `AssetManager.unitStats.clone(id)` | 克隆单位模板 | Wiki 文档 ✅ |
| `AssetManager.unitStats.add(stat)` | 注册新单位 | Wiki 文档 ✅ |
| `ToolBox.LoadSprite(path)` | 加载自定义图片 | Wiki 文档 ✅ |
| `baseStats.*` | 修改基础属性 | Wiki 文档 ✅ |

### 实现示例

```csharp
public static class DemonLordFactory
{
    public static ActorStats CreateDemonLord(string baseUnit, string id, string name, DemonLordConfig config)
    {
        // 1. 克隆基础模板（推荐使用 dragon 或 demon 作为基础）
        var stats = AssetManager.unitStats.clone(baseUnit);
        stats.id = id;
        stats.nameLocale = name;
        
        // 2. 设置魔王属性
        stats.baseStats.health = config.BaseHealth;
        stats.baseStats.damage = config.BaseDamage;
        stats.baseStats.armor = config.BaseArmor;
        stats.baseStats.speed = config.BaseSpeed;
        stats.baseStats.scale = config.Scale; // 大型单位
        
        // 3. 添加魔王专属特性
        stats.traits.Add("demon_immortal");
        stats.traits.Add(config.UniqueTraitId);
        
        // 4. 注册到 AssetManager
        AssetManager.unitStats.add(stats);
        
        // 5. 加载自定义精灵图（可选）
        if (!string.IsNullOrEmpty(config.SpritePath))
        {
            var sprite = ToolBox.LoadSprite(config.SpritePath);
            // 精灵图绑定逻辑
        }
        
        return stats;
    }
}
```

---

## Decision 3: 特性系统实现（纪元遗产）

### 决策
通过 **AssetManager.traits** 创建自定义特性，每个遗产对应一个 trait，通过 `unit.data.addTrait()` 应用。

### 理由
1. WorldBox 原生特性系统成熟稳定，直接影响 baseStats
2. 特性支持 buff/debuff 效果，完美匹配遗产需求
3. 特性自动序列化到存档，无需额外保存逻辑

### 遗产-特性映射

| 遗产类型 | Trait ID | 效果 |
|---------|----------|------|
| 军事遗产·战士之魂 | `legacy_warrior` | damage +10% |
| 军事遗产·铁甲守护 | `legacy_armor` | armor +15% |
| 经济遗产·丰收祝福 | `legacy_harvest` | 资源产出 +20% |
| 科技遗产·学者智慧 | `legacy_scholar` | 科技速度 +15% |
| 传奇遗产·英雄血脉 | `legacy_hero` | 英雄诞生率 +5% |
| 诅咒遗产·瘟疫印记 | `legacy_curse` | health -10% |

### 实现示例

```csharp
public static class LegacyTraitFactory
{
    public static void RegisterLegacyTraits()
    {
        // 军事遗产
        var warriorLegacy = new ActorTrait();
        warriorLegacy.id = "legacy_warrior";
        warriorLegacy.nameLocale = "战士之魂";
        warriorLegacy.descriptionLocale = "先祖的战斗智慧流淌在血液中";
        warriorLegacy.baseStats.damage = 1.10f; // +10%
        warriorLegacy.group = TraitGroup.Positive;
        AssetManager.traits.add(warriorLegacy);
        
        // 诅咒遗产
        var curseLegacy = new ActorTrait();
        curseLegacy.id = "legacy_curse";
        curseLegacy.nameLocale = "瘟疫印记";
        curseLegacy.descriptionLocale = "魔王的诅咒永远不会消散";
        curseLegacy.baseStats.health = 0.90f; // -10%
        curseLegacy.group = TraitGroup.Negative;
        AssetManager.traits.add(curseLegacy);
    }
    
    public static void ApplyLegacy(Actor unit, string legacyTraitId)
    {
        unit.data.addTrait(legacyTraitId);
    }
}
```

---

## Decision 4: UI 控制面板实现

### 决策
使用 **Unity IMGUI + ScrollWindow** 模式创建控制面板，这是 WorldBox MOD 的标准 UI 方案。

### 理由
1. NeoModLoader 提供 ScrollWindow 基类，简化窗口管理
2. IMGUI 模式无需额外资源文件，纯代码实现
3. 现有 MOD（如 PowerBox）已验证此方案可行

### 替代方案评估
- **Unity UI (uGUI)**: 需要 Prefab 资源，MOD 环境难以管理
- **UIElements**: Unity 新 UI 系统，WorldBox 版本可能不支持

### 实现示例

```csharp
public class ControlPanelWindow : ScrollWindow
{
    private int _currentTab = 0;
    private string[] _tabNames = { "总览", "魔王管理", "文明状态", "AI控制", 
                                    "事件管理", "轮回历史", "参数设置", "调试工具" };
    
    public override void OnGUI()
    {
        base.OnGUI();
        
        // 顶部标签栏
        GUILayout.BeginHorizontal();
        for (int i = 0; i < _tabNames.Length; i++)
        {
            if (GUILayout.Toggle(_currentTab == i, _tabNames[i], "Button"))
            {
                _currentTab = i;
            }
        }
        GUILayout.EndHorizontal();
        
        // 内容区域
        GUILayout.BeginVertical("box");
        switch (_currentTab)
        {
            case 0: DrawOverviewTab(); break;
            case 1: DrawDemonManageTab(); break;
            case 2: DrawCivStatusTab(); break;
            // ... 其他标签页
        }
        GUILayout.EndVertical();
    }
    
    private void DrawOverviewTab()
    {
        GUILayout.Label($"当前轮回: 第{CycleManager.CycleCount}轮回", "Header");
        GUILayout.Label($"纪元阶段: {EraStateMachine.CurrentPhase}");
        GUILayout.Label($"封印强度: {SealSystem.Strength:P0}");
        // ...
    }
}
```

---

## Decision 5: 配置系统设计

### 决策
采用 **三层配置优先级**：UI实时配置 > 文件覆盖配置 > 内置默认配置，使用 JSON 格式。

### 理由
1. 符合 Constitution 第 VII 条（模块化与可配置性）要求
2. JSON 格式人类可读，支持社区编辑
3. 三层优先级允许灵活覆盖而不丢失默认值

### 实现架构

```
ConfigManager
├── DefaultConfig (内置 JSON, 只读)
├── UserConfig (用户文件 JSON, 可写)
└── RuntimeConfig (运行时修改, 不持久化)

读取时: RuntimeConfig ?? UserConfig ?? DefaultConfig
保存时: 只保存 UserConfig
```

### 配置校验规则

```csharp
public class ConfigValidator
{
    public static T Clamp<T>(T value, T min, T max) where T : IComparable<T>
    {
        if (value.CompareTo(min) < 0) return min;
        if (value.CompareTo(max) > 0) return max;
        return value;
    }
    
    public static void ValidateConfig(ModConfig config)
    {
        // 数值边界保护（Constitution 第 II 条）
        config.DemonLord.StrengthMultiplier = Clamp(config.DemonLord.StrengthMultiplier, 0.6f, 3.0f);
        config.DemonLord.MaxGenerals = Clamp(config.DemonLord.MaxGenerals, 1, 6);
        config.Legion.EliteRate = Clamp(config.Legion.EliteRate, 0f, 0.3f);
        
        // 保底规则检查
        if (config.Victory.Conditions.Count == 0)
        {
            config.Victory.Conditions.Add(VictoryCondition.Execution);
            LogWarning("封印胜利条件为空，已启用保底规则（击杀封印）");
        }
    }
}
```

---

## Decision 6: 存档系统集成

### 决策
MOD 状态通过 **JSON 序列化**保存到独立文件，与游戏存档同步保存/加载。

### 理由
1. 独立文件避免污染游戏存档格式
2. JSON 格式支持版本迁移
3. NeoModLoader 提供存档事件钩子

### 存档数据结构

```csharp
[Serializable]
public class ModSaveData
{
    public string ModVersion = "1.0.0";
    public int CycleCount;
    public EraPhase CurrentPhase;
    public float SealStrength;
    public List<DemonLordSaveData> DemonLords;
    public List<CycleSummary> CycleHistory;
    public Dictionary<string, int> CivilizationLegacies;
    public AIOperationLog[] RecentAIOperations;
}

[Serializable]
public class DemonLordSaveData
{
    public string Id;
    public bool Enabled;
    public DemonLordState State;
    public float CurrentHealth;
    public int KillCount;
    public List<string> ActiveGenerals;
}
```

### 版本迁移

```csharp
public class MigrationManager
{
    public static ModSaveData Migrate(ModSaveData data, string targetVersion)
    {
        var fromVersion = new Version(data.ModVersion);
        var toVersion = new Version(targetVersion);
        
        // 1.0.0 -> 1.1.0 迁移示例
        if (fromVersion < new Version("1.1.0"))
        {
            // 添加新字段默认值
            data.CivilizationLegacies ??= new Dictionary<string, int>();
        }
        
        data.ModVersion = targetVersion;
        return data;
    }
}
```

---

## Decision 7: LLM 集成方案

### 决策
使用 **C# HttpClient** 调用 LLM API，支持 OpenAI/Claude/本地 Ollama，统一接口抽象。

### 理由
1. HttpClient 是 .NET 标准库，无额外依赖
2. 抽象接口支持多提供商切换
3. 异步调用避免阻塞游戏主线程

### 接口设计

```csharp
public interface ILLMProvider
{
    Task<string> GenerateAsync(string prompt, CancellationToken ct);
    bool IsAvailable { get; }
}

public class OpenAIProvider : ILLMProvider
{
    private readonly HttpClient _client;
    private readonly string _apiKey;
    private readonly string _model;
    
    public async Task<string> GenerateAsync(string prompt, CancellationToken ct)
    {
        var request = new
        {
            model = _model,
            messages = new[] { new { role = "user", content = prompt } },
            max_tokens = 500
        };
        
        var response = await _client.PostAsJsonAsync(_endpoint, request, ct);
        // 解析响应...
    }
}

public class FallbackEventPool : ILLMProvider
{
    // LLM 不可用时的后备方案
    public Task<string> GenerateAsync(string prompt, CancellationToken ct)
    {
        var event = EventPool.SelectRandomEvent(prompt);
        return Task.FromResult(event.Description);
    }
    
    public bool IsAvailable => true; // 始终可用
}
```

### 降级策略（Constitution 第 III 条）

```csharp
public class AIStoryEngine
{
    private ILLMProvider _primaryProvider;
    private ILLMProvider _fallbackProvider = new FallbackEventPool();
    
    public async Task<string> GenerateNarrativeAsync(WorldContext context)
    {
        try
        {
            if (_primaryProvider?.IsAvailable == true)
            {
                return await _primaryProvider.GenerateAsync(
                    BuildPrompt(context), 
                    new CancellationTokenSource(TimeSpan.FromSeconds(30)).Token
                );
            }
        }
        catch (Exception ex)
        {
            LogWarning($"LLM 调用失败: {ex.Message}，切换到后备事件池");
        }
        
        // 降级到后备事件池
        return await _fallbackProvider.GenerateAsync(BuildPrompt(context), CancellationToken.None);
    }
}
```

---

## Decision 8: 性能优化策略

### 决策
实现**分层更新系统**和**对象池**，符合 Constitution 性能架构要求。

### 分层更新频率

| 系统 | 更新间隔 | 实现方式 |
|-----|---------|---------|
| DemonLord 战斗 | 每帧 | Update() |
| Legion AI | 每5帧 | 帧计数器 |
| Hero AI | 每10帧 | 帧计数器 |
| Civilization | 每30帧 | 帧计数器 |
| AI Story | 每300帧 (~10秒) | 定时器 |
| CSI 计算 | 每年（游戏内） | 游戏事件 |

### 实现示例

```csharp
public class UpdateScheduler
{
    private int _frameCount = 0;
    
    public void OnUpdate()
    {
        _frameCount++;
        
        // 魔王战斗 - 每帧
        DemonLordSystem.UpdateCombat();
        
        // 军团AI - 每5帧
        if (_frameCount % 5 == 0)
        {
            LegionSystem.UpdateAI();
        }
        
        // 英雄AI - 每10帧
        if (_frameCount % 10 == 0)
        {
            HeroSystem.UpdateAI();
        }
        
        // 文明状态 - 每30帧
        if (_frameCount % 30 == 0)
        {
            CivilizationSystem.UpdateStatus();
        }
        
        // AI叙事 - 每300帧
        if (_frameCount % 300 == 0)
        {
            AIStoryEngine.TryGenerateNarrative();
        }
    }
}
```

### 对象池

```csharp
public class LegionUnitPool
{
    private Queue<GameObject> _pool = new Queue<GameObject>();
    private const int INITIAL_SIZE = 1000;
    
    public void Initialize()
    {
        for (int i = 0; i < INITIAL_SIZE; i++)
        {
            var unit = CreateUnit();
            unit.SetActive(false);
            _pool.Enqueue(unit);
        }
    }
    
    public GameObject Get()
    {
        if (_pool.Count > 0)
        {
            var unit = _pool.Dequeue();
            unit.SetActive(true);
            return unit;
        }
        return CreateUnit(); // 池空时新建
    }
    
    public void Return(GameObject unit)
    {
        unit.SetActive(false);
        ResetUnit(unit);
        _pool.Enqueue(unit);
    }
}
```

---

## Unconfirmed Items (需开发时验证)

以下 API 在设计文档中提及但需要通过反编译 `Assembly-CSharp.dll` 确认：

| API | 用途 | 验证方式 |
|-----|------|---------|
| 单位生成 API | 在指定位置生成魔王/军团 | 参考 CollectionMod 实现 |
| 城市资源 API | 修改城市资源/科技 | 参考 CollectionMod 实现 |
| 王国关系 API | 设置文明联盟/敌对 | 反编译确认 |
| 地形修改 API | 污染扩散效果 | 反编译确认，可能不可行 |

**处理策略**: MVP 阶段避免依赖未确认 API，使用已确认 API 实现核心功能。地形修改等高级功能延后到 V1/V2 版本。

---

## Summary

所有关键技术决策已完成，无需进一步澄清。技术方案符合：

- ✅ Constitution 8 条核心原则
- ✅ spec.md 功能需求
- ✅ WorldBox MOD 开发最佳实践
- ✅ 性能和兼容性约束

可以进入 Phase 1：设计阶段。
