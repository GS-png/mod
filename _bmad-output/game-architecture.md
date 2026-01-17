---
title: 'Game Architecture'
project: '纪元之轮：魔王轮回'
date: '2026-01-17'
author: '吴旭'
version: '1.0'
stepsCompleted: [1, 2, 3, 4, 5, 6, 7, 8, 9]
status: 'complete'
engine: 'Unity (WorldBox MOD)'
platform: 'PC (Windows)'

# Source Documents
gdd: 'gdd.md'
brief: 'game-brief.md'
---

# 纪元之轮：魔王轮回 - Game Architecture

## Executive Summary

**纪元之轮：魔王轮回** 架构基于 Unity (WorldBox MOD) 平台设计。

**关键架构决策：**
- LLM集成采用异步队列+协程模式，确保不阻塞游戏
- 分层状态管理（轮回/魔王/文明/遗产/UI）
- JSON持久化方案，便于调试和社区修改
- 事件总线+事件池系统，支持AI生成和后备机制

**项目结构：** 按功能组织，6个核心系统模块

**实现模式：** 7个模式定义，确保AI Agent实现一致性

**状态：** 已完成，可进入Epic实现阶段

---

## Document Status

**Status:** Complete
**Steps Completed:** 9 of 9

---

## Project Context

### Game Overview

**纪元之轮：魔王轮回** - WorldBox AI协作叙事MOD

### Technical Scope

| 维度 | 内容 |
|------|------|
| **平台** | PC (Windows) - WorldBox MOD |
| **引擎** | Unity (WorldBox基础) + NeoModLoader |
| **语言** | C# |
| **类型** | Simulation / Sandbox |
| **复杂度** | 高 |

### Core Systems

| 系统 | 复杂度 | 说明 |
|------|--------|------|
| **轮回系统** | 高 | 纪元阶段、遗产继承、双向进化 |
| **魔王系统** | 高 | 10个魔王独特机制、AI行为 |
| **LLM集成** | 高 | 外部API调用、异步处理、后备事件池 |
| **配置系统** | 中 | 大量可调参数、持久化 |
| **UI系统** | 中 | 控制面板、对话框、状态显示 |
| **事件系统** | 中 | 触发器、事件池、AI叙事 |

### Technical Constraints

- **依赖WorldBox API** - 必须通过NeoModLoader接口
- **LLM异步调用** - 不能阻塞主游戏循环
- **后备机制** - 离线/API失败时的事件池
- **性能保护** - 效果上限、大地图优化
- **存档兼容** - 版本升级保护玩家数据

### Complexity Drivers

**高复杂度项：**
- LLM API集成与异步处理
- 轮回系统的状态管理
- 魔王机制的多样性和可扩展性

**新颖元素：**
- LLM集成到游戏MOD
- 轮回进化系统

### Technical Risks

- WorldBox版本更新可能破坏MOD兼容性
- LLM API成本和可用性
- 大地图性能问题

---

## Engine & Framework

### Selected Engine

**Unity** (WorldBox基础) + **NeoModLoader**

**Rationale:** 这是MOD开发，必须使用WorldBox的技术栈

### Engine-Provided Architecture

| 组件 | 解决方案 | 来源 |
|------|----------|------|
| 渲染 | Unity 2D渲染管线 | WorldBox |
| 物理 | Unity Physics | WorldBox |
| 音频 | Unity Audio | WorldBox |
| 输入 | Unity Input System | WorldBox |
| 场景管理 | WorldBox场景系统 | WorldBox |
| 实体系统 | WorldBox Actor系统 | WorldBox |

### Remaining Architectural Decisions

以下决策需要明确制定：

1. **LLM集成架构** - API客户端、异步处理、后备机制
2. **MOD数据结构** - 轮回状态、魔王配置、遗产数据
3. **事件系统设计** - 触发器、事件池、AI叙事引擎
4. **UI框架** - 控制面板、对话窗口、状态显示
5. **持久化方案** - 存档、配置存储、版本迁移

---

## Architectural Decisions

### Decision Summary

| 类别 | 决策 | 理由 |
|------|------|------|
| LLM集成 | 异步队列+协程 | 不阻塞游戏、可批量处理 |
| 状态管理 | 分层状态 | 模块化、可扩展 |
| 持久化 | JSON文件 | 可读、调试友好、社区可修改 |
| 事件系统 | 事件总线+事件池 | 解耦、灵活、支持AI生成 |

### LLM Integration Architecture

**方案：** 异步队列模式 + Unity协程

```
玩家输入 → 请求队列 → 异步API调用 → 响应队列 → 事件分发
                    ↓
              超时/失败 → 后备事件池
```

**关键组件：**
- `LLMClient` - API调用封装
- `RequestQueue` - 请求队列管理
- `FallbackEventPool` - 后备事件库
- `ResponseParser` - 响应解析器

### State Management

**方案：** 分层状态管理

**状态层次：**
- `CycleState` - 轮回状态（纪元阶段、轮回计数）
- `DemonLordState` - 魔王状态（苏醒度、能力、策略）
- `CivilizationState` - 文明状态（资源、科技、军事）
- `LegacyState` - 遗产状态（永久强化、解锁进度）
- `UIState` - UI状态（面板、对话、配置）

### Data Persistence

**方案：** JSON文件

**文件结构：**
- `config.json` - 玩家配置（API密钥、参数）
- `save_{slot}.json` - 存档文件
- `legacy.json` - 遗产数据（跨存档）

**版本迁移：**
- 每个JSON包含`version`字段
- 加载时检查版本，自动迁移

### Event System

**方案：** 事件总线 + 事件池

**事件类型：**
- `SystemEvent` - 系统事件（轮回开始/结束）
- `DemonEvent` - 魔王事件（苏醒、入侵、封印）
- `NarrativeEvent` - 叙事事件（AI生成/后备池）
- `UIEvent` - UI事件（通知、对话）

---

## Cross-cutting Concerns

这些模式应用于所有系统，确保AI Agent实现一致性。

### Error Handling

**策略：** 全局处理器 + 分级响应

| 错误级别 | 处理方式 |
|----------|----------|
| CRITICAL | 记录日志、安全降级、通知玩家 |
| ERROR | 记录日志、尝试恢复 |
| WARNING | 记录日志、继续执行 |

**LLM特殊处理：** 超时/失败 → 自动切换后备事件池

### Logging

**格式：** 结构化文本
**输出：** Unity Console + 可选文件日志

```
[INFO] [CycleSystem] 轮回开始: 第3轮
[ERROR] [LLMClient] API调用失败: timeout
[WARN] [DemonLord] 参数异常，使用默认值
```

### Configuration

**方案：** JSON配置文件 + 运行时缓存

| 配置类型 | 位置 |
|----------|------|
| 玩家设置 | `config.json` |
| 平衡数值 | `balance.json` |
| 魔王配置 | `demon_lords/*.json` |

### Debug Tools

**可用工具：**
- 控制台命令（开发模式）
- 状态检查器
- 强制触发事件
- 跳过轮回阶段

**激活：** `config.json` 中 `debug_mode: true`

---

## Project Structure

### Organization Pattern

**模式：** 按功能组织（Feature-based）

### Directory Structure

```
EraOfWheel/                          # MOD根目录
├── Code/                            # 源代码
│   ├── Core/                        # 核心系统
│   │   ├── ModMain.cs              # MOD入口
│   │   ├── CycleManager.cs         # 轮回管理器
│   │   └── EventBus.cs             # 事件总线
│   ├── DemonLords/                  # 魔王系统
│   │   ├── BaseDemonLord.cs        # 魔王基类
│   │   ├── VoidLord.cs             # 虚无之主
│   │   └── PlagueMother.cs         # 瘟疫母神
│   ├── LLM/                         # AI集成
│   │   ├── LLMClient.cs            # API客户端
│   │   ├── RequestQueue.cs         # 请求队列
│   │   └── FallbackPool.cs         # 后备事件池
│   ├── UI/                          # 用户界面
│   │   ├── ControlPanel.cs         # 控制面板
│   │   └── DialogWindow.cs         # 对话窗口
│   └── Data/                        # 数据模型
│       ├── CycleState.cs           # 轮回状态
│       └── LegacyData.cs           # 遗产数据
├── Resources/                       # 资源文件
│   ├── Sprites/                     # 图像资源
│   ├── Config/                      # 配置文件
│   └── Events/                      # 后备事件池
├── Localization/                    # 本地化
└── mod.json                         # MOD元数据
```

### System Location Mapping

| 系统 | 位置 | 职责 |
|------|------|------|
| 轮回系统 | `Code/Core/` | 纪元阶段、轮回循环 |
| 魔王系统 | `Code/DemonLords/` | 魔王行为、能力、AI |
| LLM集成 | `Code/LLM/` | API调用、后备机制 |
| UI系统 | `Code/UI/` | 面板、对话、状态 |
| 数据模型 | `Code/Data/` | 状态、配置、存档 |

### Naming Conventions

| 元素 | 约定 | 示例 |
|------|------|------|
| 类 | PascalCase | `CycleManager` |
| 方法 | PascalCase | `StartCycle()` |
| 变量 | camelCase | `currentPhase` |
| 常量 | UPPER_SNAKE | `MAX_DEMON_LORDS` |
| 配置文件 | snake_case | `demon_lords.json` |

---

## Implementation Patterns

这些模式确保所有AI Agent实现一致性。

### Novel Patterns

#### Cycle Evolution Pattern（轮回进化模式）

**用途：** 处理魔王和文明的双向进化

```csharp
public void OnCycleEnd(CycleResult result) {
    // 1. 计算遗产点
    var legacy = LegacyCalculator.Calculate(result);
    
    // 2. 魔王进化（学习本轮策略）
    activeDemonLord.Evolve(result.PlayerActions);
    
    // 3. 文明遗产继承
    CivilizationLegacy.Apply(legacy);
    
    // 4. 触发下一轮回
    EventBus.Emit(new CycleStartEvent());
}
```

### Standard Patterns

| 模式 | 选择 | 理由 |
|------|------|------|
| 组件通信 | 事件总线 | 解耦、支持AI生成事件 |
| 实体创建 | 工厂模式 | 魔王创建集中管理 |
| 状态转换 | 状态机 | 纪元阶段清晰转换 |
| 数据访问 | 数据管理器 | JSON配置集中加载 |

### Consistency Rules

| 场景 | 约定 |
|------|------|
| 魔王创建 | 必须通过`DemonLordFactory` |
| 事件发送 | 必须通过`EventBus.Emit()` |
| 配置读取 | 必须通过`ConfigManager` |
| 状态修改 | 必须通过状态管理器方法 |

---

## Architecture Validation

### Validation Summary

| 检查项 | 状态 | 备注 |
|--------|------|------|
| 决策兼容性 | ✅ PASS | Unity/NeoModLoader + 选定模式兼容 |
| GDD覆盖 | ✅ PASS | 所有核心系统已有架构支持 |
| 模式完整性 | ✅ PASS | 6个标准模式 + 1个新颖模式 |
| Epic映射 | ✅ PASS | 所有功能可定位到结构 |
| 文档完整性 | ✅ PASS | 无占位符、无TODO |

### Coverage Report

| 维度 | 数量 |
|------|------|
| 系统覆盖 | 6/6 |
| 模式定义 | 7个 |
| 决策记录 | 4个 |

### System-Architecture Mapping

| GDD系统 | 架构位置 | 状态 |
|---------|----------|------|
| 轮回系统 | `Code/Core/CycleManager.cs` | ✅ |
| 魔王系统 | `Code/DemonLords/` | ✅ |
| LLM集成 | `Code/LLM/` | ✅ |
| 事件系统 | `Code/Core/EventBus.cs` | ✅ |
| UI系统 | `Code/UI/` | ✅ |
| 持久化 | `Code/Data/` + `Resources/Config/` | ✅ |

### Validation Date

2026-01-17
