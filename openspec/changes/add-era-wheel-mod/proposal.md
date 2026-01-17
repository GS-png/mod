# Change: 实现「纪元之轮：魔王轮回」WorldBox MOD

## Why
WorldBox缺乏长期叙事引擎，玩家在沙盒模式下容易失去目标。本MOD通过"轮回系统"让世界产生史诗级的魔王入侵-封印循环，每次轮回双方都会变强，形成可持续的长期游戏体验。

## What Changes
- **轮回系统（Cycle System）**：实现6阶段循环（发展→预兆→苏醒→入侵→封印战→重建）
- **魔王系统（Demon Lords）**：10个主题魔王，含状态机、将领、军团波次
- **封印系统（Seal System）**：多种封印胜利条件（击杀/仪式/收集/时间窗口）
- **遗产系统（Legacy System）**：跨轮回永久强化（军事/经济/科技/传奇遗产）
- **AI叙事引擎（Narrative Engine）**：LLM集成 + 200+后备事件池
- **玩家控制面板（UI Panel）**：总览/魔王管理/AI控制/设置界面

## Impact
- **Affected specs**: cycle-system, demon-lords, legacy-system, seal-system, narrative-engine, ui-panel
- **Affected code**: 
  - `EraOfWheel/Code/Core/` - MOD入口与基础设施
  - `EraOfWheel/Code/Cycle/` - 轮回与遗产
  - `EraOfWheel/Code/DemonLords/` - 魔王体系
  - `EraOfWheel/Code/LLM/` - AI叙事
  - `EraOfWheel/Code/UI/` - 界面

## Scope & Phasing
按版本规划分阶段实现：

### MVP（最小可行版本）
- 轮回状态机（6阶段闭环）
- 2个魔王（虚无之主、瘟疫母神）
- 军团波次系统（简化版）
- 击杀封印 + 简化仪式封印
- 遗产系统（简化版）
- 失败不死档机制
- 基础UI面板

### V1（可发布版本）
- 扩展到4-6个魔王
- 将领系统
- 自适应难度（CSI）
- 完整封印战机制
- 反魔联盟系统
- 事件库扩充（90+条）

### V2（史诗版本）
- LLM集成（可开关）
- 魔王内战/合作模式
- 诸神黄昏扩展
- 完整10魔王
