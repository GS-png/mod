# Implementation Plan: 纪元之轮：魔王轮回 MOD

**Branch**: `002-era-wheel-demon-mod` | **Date**: 2026-01-19 | **Spec**: [spec.md](./spec.md)
**Input**: Feature specification from `/specs/002-era-wheel-demon-mod/spec.md`

## Summary

**核心目标**: 将 WorldBox 变为自我演化的史诗叙事引擎，通过轮回系统实现魔王与文明的多次对抗循环。

**主要功能**:
- 完整轮回闭环：封印→预兆→苏醒→降临→全盛→衰弱→再封印
- 10个差异化魔王（MVP阶段2个：虚无、瘟疫），每个有独特机制、将领、军团
- 纪元遗产系统：每次轮回结算后双方获得永久增强
- 自适应难度：通过CSI（文明强度指数）动态调整挑战性
- AI叙事引擎（可选）：LLM集成生成动态剧情，无LLM时使用200+后备事件池
- 完整控制面板：8个标签页提供绝对控制权

**技术方案**: 基于 NeoModLoader 框架开发 C# Unity MOD，使用 JSON 配置系统，通过 AssetManager API 实现单位/特性创建。

## Technical Context

**Language/Version**: C# (Unity) - 基于 NeoModLoader 框架  
**Primary Dependencies**: NeoModLoader, Unity UI (ScrollWindow), AssetManager API  
**Storage**: JSON 配置文件（热重载）、游戏存档系统集成  
**Testing**: Unity Test Framework + 手动游戏内测试（至少2次完整轮回）  
**Target Platform**: WorldBox 0.51.2+ (Windows/Mac/Linux)  
**Project Type**: 单一 MOD 项目（Unity C# DLL）  
**Performance Goals**: 单帧处理增量 <5ms，1000+单位战斗保持 30fps+  
**Constraints**: 内存增量 <100MB，存档大小增量 <10MB  
**Scale/Scope**: 10个魔王 + 50个将领 + 200+事件池 + 8个UI标签页

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

### 不可协商原则检查

| 原则 | 状态 | 说明 |
|------|------|------|
| I. 闭环完整性 | ✅ PASS | spec定义7状态完整流转，保底规则已定义（封印胜利/轮回触发） |
| II. 数值边界保护 | ✅ PASS | spec含FR-035/060-069定义所有魔王机制保护上下限 |
| III. 降级容错 | ✅ PASS | LLM降级到后备事件池、配置降级到默认值已定义 |

### 其他原则检查

| 原则 | 状态 | 说明 |
|------|------|------|
| IV. 失败保护与可恢复性 | ✅ PASS | 重启轮回选项、保底英雄/仪式机制已定义 |
| V. 可追溯性 | ✅ PASS | 轮回结算记录、AI操作日志、状态转换日志已定义 |
| VI. 自适应平衡 | ✅ PASS | CSI计算、自适应倍率0.85-1.25、防抖动机制已定义 |
| VII. 模块化与可配置性 | ✅ PASS | 三层配置优先级、导入导出、个体开关已定义 |
| VIII. 兼容性优先 | ✅ PASS | NeoModLoader遵循、非侵入式设计、存档版本迁移已定义 |

### 质量门控检查

- [x] 编译通过要求已知
- [x] 边界检查规范已定义
- [x] 降级测试场景已识别
- [x] 闭环测试标准已定义（至少2次封印）
- [x] 存档兼容要求已定义

**Constitution Check Result**: ✅ ALL GATES PASSED

## Project Structure

### Documentation (this feature)

```text
specs/002-era-wheel-demon-mod/
├── plan.md              # 本文件 - 实施规划
├── research.md          # Phase 0 - 技术研究与决策
├── data-model.md        # Phase 1 - 数据模型设计
├── quickstart.md        # Phase 1 - 快速开始指南
├── contracts/           # Phase 1 - API/事件契约
│   ├── state-machine.md # 状态机定义
│   ├── events.md        # 事件系统契约
│   └── config-schema.json # 配置文件schema
└── tasks.md             # Phase 2 - 任务分解（由 /speckit.tasks 生成）
```

### Source Code (Unity MOD 项目结构)

```text
EraWheel/
├── Main.cs                    # MOD入口点，NeoModLoader注册
├── Config/
│   ├── ConfigManager.cs       # 配置管理器（三层优先级）
│   ├── DefaultConfig.json     # 内置默认配置
│   └── ConfigSchema.cs        # 配置校验逻辑
├── Core/
│   ├── CycleManager.cs        # 轮回系统核心
│   ├── EraStateMachine.cs     # 纪元阶段状态机
│   ├── SealSystem.cs          # 封印系统
│   └── LegacySystem.cs        # 纪元遗产系统
├── DemonLord/
│   ├── DemonLordBase.cs       # 魔王基类
│   ├── DemonLordFactory.cs    # 魔王工厂
│   ├── Lords/                 # 10个魔王实现
│   │   ├── VoidLord.cs
│   │   └── PlagueLord.cs
│   ├── GeneralSystem.cs       # 将领系统
│   └── LegionWaveSystem.cs    # 军团波次系统
├── Civilization/
│   ├── CSICalculator.cs       # 文明强度指数计算
│   ├── AntiDemonLevel.cs      # 抗魔等级
│   ├── AllianceSystem.cs      # 反魔联盟
│   └── HeroSystem.cs          # 英雄系统
├── Narrative/
│   ├── EventPool.cs           # 后备事件池（200+事件）
│   ├── AIStoryEngine.cs       # AI叙事引擎
│   └── ChronicleSystem.cs     # 世界编年史
├── UI/
│   ├── ControlPanel.cs        # 控制面板主窗口
│   ├── Tabs/                  # 8个标签页
│   │   ├── OverviewTab.cs
│   │   ├── DemonManageTab.cs
│   │   ├── CivStatusTab.cs
│   │   ├── AIControlTab.cs
│   │   ├── EventManageTab.cs
│   │   ├── CycleHistoryTab.cs
│   │   ├── SettingsTab.cs
│   │   └── DebugTab.cs
│   └── Components/            # 可复用UI组件
├── Data/
│   ├── SaveManager.cs         # 存档管理
│   └── MigrationManager.cs    # 版本迁移
├── Localization/
│   ├── zh_CN.json             # 简体中文
│   └── en.json                # 英文
└── Resources/
    ├── sprites/               # 魔王/将领/单位精灵图
    └── events/                # 事件池JSON文件
```

**Structure Decision**: 采用 Unity MOD 单项目结构，按功能模块划分目录。Core/ 包含轮回核心逻辑，DemonLord/ 包含魔王相关系统，UI/ 包含控制面板，Narrative/ 包含叙事系统。

## Complexity Tracking

> **Fill ONLY if Constitution Check has violations that must be justified**

| Violation | Why Needed | Simpler Alternative Rejected Because |
|-----------|------------|-------------------------------------|
| [e.g., 4th project] | [current need] | [why 3 projects insufficient] |
| [e.g., Repository pattern] | [specific problem] | [why direct DB access insufficient] |
