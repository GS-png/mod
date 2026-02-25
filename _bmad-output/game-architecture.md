---
title: 'Game Architecture'
project: 'mod-1'
date: '2026-02-24'
author: 'Wuxu'
version: '1.0'
stepsCompleted: [1, 2, 3, 4, 5, 6, 7, 8, 9]
status: 'complete'
engine: 'WorldBox + NeoModLoader'
platform: 'PC'

# Source Documents
gdd: '_bmad-output/gdd.md'
epics: '_bmad-output/epics.md'
brief: null
narrative: null
---

# Game Architecture

## Document Status

This architecture document has been completed through the GDS Architecture Workflow.

**Steps Completed:** 9 of 9 (Complete)

---

## Executive Summary

**纪元之轮：魔王轮回** 的架构基于 **WorldBox + NeoModLoader**，目标平台为 **PC**。  
核心方案是“主状态机 + 子状态机”驱动轮回阶段，配合“命令同步 + 事件异步”的通信模型。  
文档已定义跨模块规则、目录边界、实现模式和验证清单，可直接用于 Epic 实施。

**Key Architectural Decisions:**

- 双路径胜利统一由 `VictoryCoordinator` 裁决，保证一次轮回只结算一次。
- 存档采用 JSON 版本化模型，配合迁移器和原子写入，保障升级与恢复稳定性。
- 项目按 `Core/Systems/Features/Infrastructure/UI` 分层，降低并行开发冲突。

**Project Structure:** 领域分层组织，覆盖 6 个核心系统模块。  
**Implementation Patterns:** 9 组模式/规则，确保 AI 代理实现一致性。  
**Ready for:** Epic implementation phase

## Project Context

### Game Overview

**纪元之轮：魔王轮回** 是一个基于 WorldBox 的模拟向重构 MOD。  
核心体验是“观察 AI 自主演化 + 轮回对抗压力”。  
玩家主要通过调参与策略判断影响长期战局。

### Technical Scope

**Platform:** PC  
**Genre:** Simulation / Sandbox MOD  
**Project Level:** High（系统联动多、跨轮回状态复杂）

### Core Systems

| System | Complexity | GDD Reference |
| --- | --- | --- |
| 轮回核心骨架（阶段状态机/双封印/结算/恢复） | High | Technical Specifications / Development Epics |
| 魔王战线（魔王-将领-军团波次） | High | Core Gameplay / Development Epics |
| 遗迹与封印战（争夺、仪式推进、中断） | High | Game Mechanics / Development Epics |
| 传承与长期成长（档位、抗魔、英雄继承） | High | Progression and Balance / Development Epics |
| 事件与复盘（时间线、关键事件、失败定位） | Medium-High | Success Metrics / Development Epics |
| 配置与稳定性（参数分层、迁移、性能护栏） | High | Technical Constraints / Development Epics |

### Platform Requirements

- Primary platform: PC
- Secondary platforms: 暂无
- Cross-platform considerations: 当前不做主机/移动端适配

### Performance Constraints

- Frame rate target: 无硬指标，目标“基本流畅”
- Resolution support: 无硬指标，沿用原版显示体系
- Memory constraints: 未给出硬指标
- Load time requirements: 无秒级硬指标，避免明显卡死

### Networking Requirements

- Multiplayer type: None（v1.0 不做联机）
- Network architecture: N/A
- Sync requirements: N/A

### Complexity Drivers

**High Complexity:**

- 多系统同周期联动（阶段、军团、遗迹、传承、复盘）
- 跨轮回状态持久化与读档恢复一致性
- 中后期大规模战局下的调度与性能稳定

**Novel Concepts:**

- “击杀胜利 + 仪式胜利”双路径并存
- 世界档位与王国档位的跨轮回成长联动
- 以事件时间线做可追溯复盘闭环

**Technical Risks:**

- 上游版本更新导致 API 行为变化
- 中后期性能抖动影响体验
- 事件量增大后的信息过载与维护成本上升

## Engine & Framework

### Selected Engine

**WorldBox + NeoModLoader**

- WorldBox 版本基线：`0.51.2`（公开更新日期：2025-09-12）
- NeoModLoader 版本基线：`1.2.0.1`（发布：2025-09-11）

**Rationale:**  
项目目标是 WorldBox 模拟向重构 MOD，不是独立游戏重做。  
选择 NeoModLoader 能直接复用现有 MOD 生态与 API 习惯，整体实现风险最低。

### Project Initialization

使用 `WorldBoxOpenMods/ModTemplate` 作为起手模板。

```bash
git clone https://github.com/WorldBoxOpenMods/ModTemplate.git EraWheelMod
cd EraWheelMod
```

初始化后第一步要改：

- `mod.json`：`name` / `author` / `description` / `RepoURL`
- `ModClass.cs`：把默认命名空间改成项目命名空间
- 项目名与程序集名：改成项目实际名称

### Engine-Provided Architecture

| Component | Solution | Notes |
| --- | --- | --- |
| Runtime | WorldBox (Unity runtime) | 游戏主循环由原游戏驱动 |
| Mod lifecycle | NeoModLoader | 负责模组发现、加载、依赖关系 |
| Language | C# | 与现有 WorldBox MOD 生态一致 |
| Project base | ModTemplate | 提供基础目录和示例入口 |
| Metadata | mod.json | 模组展示与依赖声明入口 |
| Build | .NET / csproj | 使用标准 C# 项目编译流程 |

### Remaining Architectural Decisions

后续还需要明确：

- 状态机与阶段调度结构（轮回/魔王/封印）
- 存档模型与版本迁移策略
- 事件总线与日志格式规范
- 性能护栏（低频调度、禁止高频全图扫描）
- 模块边界与命名规范（避免多 Agent 实现冲突）
- API 兼容策略（随 WorldBox/NeoModLoader 版本变化）

### AI Tooling (MCP)

当前决策：不在本轮架构中加入 MCP（可后续再加）。

## Architectural Decisions

### Decision Summary

| Category | Decision | Version | Rationale |
| --- | --- | --- | --- |
| 运行时基线 | WorldBox + NeoModLoader | WorldBox 0.51.2 / NeoModLoader 1.2.0.1 | 与当前项目目标和生态完全一致，减少迁移风险 |
| 状态管理 | 主状态机 + 子状态机 | N/A | 既能表达轮回大阶段，也能处理魔王战等子阶段细节 |
| 系统通信 | 强类型事件总线 | N/A | 降低模块耦合，减少多 Agent 并行开发冲突 |
| 存档与迁移 | JSON + schemaVersion + 迁移器 + 原子写入 | N/A | 兼顾可读性、可调试、可升级和崩溃安全 |
| 配置体系 | default_config + 用户覆盖 + 运行时快照 | N/A | 支持默认稳定、玩家自定义和问题复现 |
| 资源加载 | 分阶段预热 + 按需懒加载 | N/A | 平衡启动速度与运行期流畅度 |
| 代码组织 | Core/Systems/Features/Infrastructure/UI 分层 | N/A | 模块边界清晰，便于分工和长期维护 |
| 测试策略 | EraWheel.SelfTest 自检优先 + 回归脚本 | N/A | 在无法直接跑游戏时仍可持续验证核心逻辑 |
| 版本兼容策略 | 版本门控 + 能力检测 + 软失败 | N/A | 上游变动时可控降级，避免整包失效 |

### State Management

**Approach:** 主状态机 + 子状态机  
主状态机管理轮回阶段（预兆/苏醒/降临/封印战/重建），子状态机管理各阶段内部流程。  
这样可以保证流程清晰，同时不把所有逻辑堆在一个大状态机里。

### Data Persistence

**Save System:** JSON + schemaVersion + 迁移器 + 原子写入  
每份存档都带 `schemaVersion`，读取时按版本执行迁移。  
写入采用临时文件后替换，避免写一半导致坏档。

### Asset Management

**Loading Strategy:** 分阶段预热 + 按需懒加载  
开局只预热核心资源，阶段切换前预热下一阶段关键资源。  
非关键资源按需加载，减少一次性加载压力。

### Architecture Decision Records

- ADR-01: 采用“主状态机 + 子状态机”，用于控制轮回与战斗子流程。
- ADR-02: 采用“强类型事件总线”，统一跨模块通信协议。
- ADR-03: 采用“JSON 版本化存档 + 迁移器 + 原子写入”。
- ADR-04: 采用“分层配置模型（默认/用户/运行时）”。
- ADR-05: 采用“分阶段预热 + 懒加载”资源策略。
- ADR-06: 采用“领域分层目录结构”作为代码组织规范。
- ADR-07: 采用“SelfTest 优先”的回归验证策略。
- ADR-08: 采用“版本门控 + 能力检测 + 软失败”兼容策略。

## Cross-cutting Concerns

这些规则对所有系统都生效，后续实现必须统一遵守。

### Error Handling

**Strategy:** `Result<T>` + 关键异常抛出 + 全局兜底

**规则：**

- 可预期失败（参数不合法、资源不存在）返回 `Result<T>`。
- 不可恢复故障（状态损坏、核心依赖失效）抛异常。
- 顶层统一捕获未处理异常，记录日志并触发玩家提示。

**Example:**

```csharp
public Result<SealProgress> TryAdvanceSeal(SealContext ctx) {
    if (ctx == null) return Result.Fail<SealProgress>("seal.ctx.null");
    if (!ctx.CanAdvance) return Result.Fail<SealProgress>("seal.cannot_advance");
    return Result.Ok(ctx.Advance());
}
```

### Logging

**Format:** 纯文本日志  
**Destination:** 控制台 + 本地滚动日志文件

**日志级别约定：**

- ERROR：影响流程继续
- WARN：异常但可恢复
- INFO：关键流程节点
- DEBUG：调试细节（开发模式）

**Example:**

```csharp
logger.Info("[SealSystem] ritual_started world={0} cycle={1}", worldId, cycleId);
```

### Configuration

**Approach:** 启动加载默认配置 + 用户覆盖；运行时只读

**规则：**

- 默认配置文件：`default_config.json`
- 用户配置文件：`user_config.json`（不存在则自动生成）
- 启动时合并后生成运行时快照，运行期间不热更新

### Event System

**Pattern:** 混合模型（命令同步、通知异步）

**规则：**

- 命令类事件（会改变核心状态）走同步链路，保证顺序和一致性。
- 通知类事件（UI 刷新、日志补充、统计）走异步队列，降低阻塞风险。
- 事件命名格式：`domain.action`，例如 `seal.ritual_started`。

**Example:**

```csharp
commandBus.PublishSync(new StartSealRitualCommand(worldId));
eventBus.PublishAsync(new SealRitualStartedEvent(worldId, cycleId));
```

### Debug Tools

**Available Tools:**

- 基础调试面板（阶段状态、关键计数器、封印进度）
- 关键状态可视化（当前阶段、魔王子态、遗迹占领状态）
- 自检命令入口（触发 `EraWheel.SelfTest` 关键用例）

**Activation:**

- `F8`：开关调试面板
- 控制台命令：`/erawheel selftest core`

### Player-facing Error Policy

关键错误会弹窗提示玩家（同时写日志），避免“静默失败”。

## Project Structure

### Organization Pattern

**Pattern:** 领域分层（Core / Systems / Features / Infrastructure / UI）  
**Rationale:** 用清晰边界避免多 Agent 写到同一块逻辑，降低耦合。

### Directory Structure

```text
EraWheelMod/
├── mod.json
├── default_config.json
├── icon.png
├── Locales/
│   ├── en.json
│   └── zh.json
├── Data/
│   ├── rules/
│   ├── balance/
│   └── migrations/
├── Assets/
│   └── ui/
├── src/
│   ├── Core/
│   │   ├── StateMachine/
│   │   ├── EventBus/
│   │   ├── Result/
│   │   └── Contracts/
│   ├── Systems/
│   │   ├── Reincarnation/
│   │   ├── DemonFront/
│   │   ├── RelicSeal/
│   │   ├── Inheritance/
│   │   ├── TimelineReview/
│   │   └── ConfigStability/
│   ├── Features/
│   │   ├── DebugPanel/
│   │   ├── RuntimeCommands/
│   │   └── ValidationGuards/
│   ├── Infrastructure/
│   │   ├── Persistence/
│   │   ├── Config/
│   │   ├── Logging/
│   │   ├── ResourceLoading/
│   │   ├── Compatibility/
│   │   └── Serialization/
│   └── UI/
│       ├── Panels/
│       ├── Timeline/
│       └── Notifications/
├── tests/
│   ├── SelfTestBridge/
│   ├── Regression/
│   └── Fixtures/
└── docs/
    ├── architecture/
    ├── api-notes/
    └── migration-guides/
```

### System Location Mapping

| System | Location | Responsibility |
| --- | --- | --- |
| 轮回核心骨架 | `src/Systems/Reincarnation` + `src/Core/StateMachine` | 阶段推进、胜负结算、状态流转 |
| 魔王战线系统 | `src/Systems/DemonFront` | 魔王/将领/军团生成与节奏 |
| 遗迹与封印战 | `src/Systems/RelicSeal` | 遗迹生命周期、仪式推进与中断 |
| 传承与长期成长 | `src/Systems/Inheritance` | 档位、抗魔、继承结算 |
| 事件与复盘体验 | `src/Systems/TimelineReview` + `src/UI/Timeline` | 事件采集、时间线、复盘展示 |
| 配置与稳定性 | `src/Systems/ConfigStability` + `src/Infrastructure/Compatibility` | 参数分层、迁移、兼容护栏 |

### Epic to Architecture Mapping

| Epic | Primary Module | Supporting Modules |
| --- | --- | --- |
| Epic 1 轮回核心骨架 | `Systems/Reincarnation` | `Core/StateMachine`, `Infrastructure/Persistence` |
| Epic 2 魔王战线系统 | `Systems/DemonFront` | `Core/EventBus`, `Infrastructure/ResourceLoading` |
| Epic 3 遗迹与封印战 | `Systems/RelicSeal` | `Core/Result`, `UI/Notifications` |
| Epic 4 传承与长期成长 | `Systems/Inheritance` | `Infrastructure/Serialization`, `Data/rules` |
| Epic 5 事件与复盘体验 | `Systems/TimelineReview` | `UI/Timeline`, `Infrastructure/Logging` |
| Epic 6 配置与稳定性 | `Systems/ConfigStability` | `Infrastructure/Config`, `tests/Regression` |

### Naming Conventions

#### Files

- C# 文件名与主类同名：`SealRitualSystem.cs`
- 接口以 `I` 开头：`ISealProgressRepository.cs`
- 测试文件以 `Tests` 结尾：`SealRitualSystemTests.cs`

#### Code Elements

| Element | Convention | Example |
| --- | --- | --- |
| Class | PascalCase | `ReincarnationStateMachine` |
| Method | PascalCase | `AdvanceStage` |
| Private field | `_camelCase` | `_currentStage` |
| Local variable | camelCase | `nextStage` |
| Constant | UPPER_SNAKE_CASE | `MAX_SEAL_PROGRESS` |
| Event name | `domain.action` | `seal.ritual_started` |

### Architectural Boundaries

- `Core` 只放通用机制，不依赖具体玩法模块。
- `Systems` 只依赖 `Core` 和 `Infrastructure` 抽象，不直接互相硬耦合。
- `UI` 不直接改核心状态，只通过命令/事件交互。
- `Infrastructure` 提供技术能力，不承载玩法规则。
- `Data` 只放可配置数据与迁移定义，不放执行逻辑。

## Implementation Patterns

这些模式用于保证多个 AI 代理实现时风格一致、行为一致、边界一致。

### Novel Patterns

#### 1) 双路径胜利协调模式（Dual Victory Arbitration）

**Purpose:**  
同时支持“击杀胜利”和“仪式胜利”，并保证一轮只结算一次。

**Components:**

- `VictoryCoordinator`：唯一裁决入口
- `VictorySignalCollector`：接收击杀/仪式信号
- `SettlementGuard`：一次性结算锁
- `PostSettlementDispatcher`：结算后广播与收尾

**Data Flow:**

1. 子系统上报胜利信号（击杀或仪式）
2. 协调器读取当前轮回状态
3. 通过一次性锁判定是否已结算
4. 首个有效信号触发结算
5. 其余重复信号只记录，不重复执行
6. 广播结算完成事件

**Implementation Guide:**

```csharp
public sealed class VictoryCoordinator {
    private int _settled = 0; // 0=未结算,1=已结算
    public bool TrySettle(VictoryReason reason, CycleContext ctx) {
        if (System.Threading.Interlocked.CompareExchange(ref _settled, 1, 0) != 0)
            return false; // 已结算，拒绝重复执行
        SettlementService.Run(reason, ctx);
        EventBus.PublishAsync(new CycleSettledEvent(ctx.CycleId, reason));
        return true;
    }
}
```

#### 2) 跨轮回传承流水线模式（Inheritance Pipeline）

**Purpose:**  
把“结算 -> 传承计算 -> 迁移 -> 发放 -> 下轮加载”固定成稳定流水线。

**Components:**

- `SettlementSnapshotBuilder`
- `InheritanceCalculator`
- `SchemaMigrator`
- `InheritanceWriter`
- `NextCycleBootstrapper`

**Data Flow:**

1. 结算时生成快照
2. 用快照计算传承结果
3. 按 `schemaVersion` 做数据迁移
4. 原子写入传承数据
5. 下一轮启动时加载并校验

**Implementation Guide:**

```csharp
public Result ApplyInheritance(CycleResult result) {
    var snapshot = _snapshotBuilder.Build(result);
    var inheritance = _calculator.Calculate(snapshot);
    var migrated = _migrator.ToCurrent(inheritance);
    return _writer.WriteAtomically(migrated); // 成功后供下一轮读取
}
```

#### 3) 事件时间线复盘模式（Timeline Replay）

**Purpose:**  
把关键战局过程转成可追溯、可定位问题的时间线。

**Components:**

- `EventEnvelope`（统一事件结构）
- `TimelineAppender`（追加写入）
- `TimelineIndexer`（按轮回/年份/类型索引）
- `ReplayQueryService`（复盘查询）

**Data Flow:**

1. 各系统发结构化事件
2. 统一封装后追加写入日志
3. 异步构建索引
4. UI 按条件查询并展示
5. 失败复盘按“关键事件链”回放

**Implementation Guide:**

```csharp
public record EventEnvelope(
    string EventId,
    string Domain,
    string Action,
    long Tick,
    int CycleId,
    string Severity,
    string PayloadJson
);
```

### Communication Patterns

**Pattern:** 命令总线同步 + 事件总线异步

```csharp
commandBus.PublishSync(new StartSealRitualCommand(worldId));
eventBus.PublishAsync(new SealRitualStartedEvent(worldId, cycleId));
```

### Entity Patterns

**Creation:** 工厂 + 生成器 + 对象池

```csharp
var demon = demonFactory.CreateFromTemplate(templateId);
objectPool.Track(demon);
spawnGenerator.AttachInitialState(demon, context);
```

### State Patterns

**Pattern:** 分层状态机（主状态机 + 子状态机）

```csharp
mainStateMachine.TransitTo(MainStage.SealBattle);
sealSubStateMachine.TransitTo(SealStage.Channeling);
```

### Data Patterns

**Access:** Repository + 快照缓存 + JSON 持久化

```csharp
var state = cycleRepository.Get(cycleId);      // 优先缓存
state.Apply(delta);
cycleRepository.SaveAtomic(state);             // 原子写入
```

### Consistency Rules

| Pattern | Convention | Enforcement |
| --- | --- | --- |
| 事件命名 | `domain.action` | PR 检查 + 自检脚本 |
| 命令处理 | 同步、幂等 | `CommandHandler` 基类约束 |
| 通知事件 | 异步、可丢弃低优先级事件 | 事件队列策略 |
| 结算流程 | 只允许一次结算 | `SettlementGuard` |
| 存档写入 | 原子写入 + 版本字段 | `Repository` 统一入口 |
| 模块依赖 | `Systems` 不直接互调 | 架构规则检查 |

## Architecture Validation

### Validation Summary

| Check | Result | Notes |
| --- | --- | --- |
| Decision Compatibility | PASS | 关键决策之间无明显冲突（状态机、事件、存档、加载策略一致） |
| GDD Coverage | PASS | GDD 核心系统均已映射到架构模块与目录 |
| Pattern Completeness | PASS | 通信、实体创建、状态切换、数据访问、错误处理、事件处理均有模式定义 |
| Epic Mapping | PASS | Epic 1-6 均已映射到主模块与支撑模块 |
| Document Completeness | PASS | 关键章节齐全，未发现占位符（`{{ }}` / `TODO` / `TBD`） |

### Coverage Report

**Systems Covered:** 6/6  
**Patterns Defined:** 9（3 个创新模式 + 6 个标准模式/规则组）  
**Decisions Made:** 9（Step 4 决策项）

### Issues Resolved

- 无阻断级问题。
- 无占位符残留。
- 当前文档可进入最终收口步骤（Step 9）。

### Validation Date

2026-02-24

## Development Environment

### Prerequisites

- WorldBox `0.51.2`（PC）
- NeoModLoader `1.2.0.1`
- 可编译 `net48` 的 C# 构建环境（支持 C# 11）
- Git（用于拉取模板和版本管理）

### AI Tooling (MCP Servers)

当前架构决策：不启用引擎 MCP。  
后续如需补充，可在实现阶段再接入通用文档检索型 MCP。

### Setup Commands

```bash
# 1) 拉起模板工程
git clone https://github.com/WorldBoxOpenMods/ModTemplate.git EraWheelMod
cd EraWheelMod

# 2) 修改模板占位信息（name/author/description/RepoUrl）
#    并把 ModClass.cs 的命名空间从 CHANGEME 改成实际命名空间

# 3) 还原依赖并编译（按本机 net48 构建链配置）
dotnet restore
dotnet build ModTemplate.csproj -c Release
```

### First Steps

1. 完成 `mod.json` 与 `ModClass.cs` 的项目标识替换。  
2. 先实现 Epic 1 的状态机骨架与结算锁，再接入事件总线。  
3. 建立基础回归脚本，优先覆盖存档迁移和双路径胜利裁决。  
4. 按本文档目录边界拆分模块，避免跨层直连。
