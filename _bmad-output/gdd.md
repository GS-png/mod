---
stepsCompleted:
  - 1
  - 2
  - 3
  - 4
  - 5
  - 6
  - 7
  - 8
  - 9
  - 10
  - 11
  - 12
  - 13
  - 14
inputDocuments:
  - '设计/EraWheel_Redesign.md'
  - '设计/ERRE附属文档/传承档位详表.md'
  - '设计/ERRE附属文档/公共特质表.md'
  - '设计/ERRE附属文档/属性字段速查.md'
  - '设计/ERRE附属文档/游戏原版特质与效果清单.md'
  - '设计/ERRE附属文档/魔王名册与技能表.md'
documentCounts:
  briefs: 0
  research: 0
  brainstorming: 0
  projectDocs: 6
workflowType: 'gdd'
lastStep: 14
project_name: 'mod-1'
user_name: 'Wuxu'
date: '2026-02-24T04:22:15-08:00'
game_type: 'simulation'
game_name: '纪元之轮：魔王轮回'
---

# {{game_name}} - Game Design Document

**Author:** {{user_name}}
**Game Type:** {{game_type}}
**Target Platform(s):** {{platforms}}

---

## Executive Summary

### Core Concept

{{description}}

### Target Audience

{{target_audience}}

### Unique Selling Points (USPs)

{{unique_selling_points}}

---

## Goals and Context

### Project Goals

{{goals}}

### Background and Rationale

{{context}}

---

## Core Gameplay

### Game Pillars

{{game_pillars}}

### Core Gameplay Loop

{{gameplay_loop}}

### Win/Loss Conditions

{{win_loss_conditions}}

---

## Game Mechanics

### Primary Mechanics

{{primary_mechanics}}

### Controls and Input

{{controls}}

---

{{GAME_TYPE_SPECIFIC_SECTIONS}}

---

## Progression and Balance

### Player Progression

{{player_progression}}

### Difficulty Curve

{{difficulty_curve}}

### Economy and Resources

{{economy_resources}}

---

## Level Design Framework

### Level Types

{{level_types}}

### Level Progression

{{level_progression}}

---

## Art and Audio Direction

### Art Style

{{art_style}}

### Audio and Music

{{audio_music}}

---

## Technical Specifications

### Performance Requirements

{{performance_requirements}}

### Platform-Specific Details

{{platform_details}}

### Asset Requirements

{{asset_requirements}}

---

## Development Epics

### Epic Structure

{{epics}}

---

## Success Metrics

### Technical Metrics

{{technical_metrics}}

### Gameplay Metrics

{{gameplay_metrics}}

---

## Out of Scope

{{out_of_scope}}

---

## Assumptions and Dependencies

{{assumptions_and_dependencies}}

## Executive Summary

### Game Name

纪元之轮：魔王轮回

### Core Concept

这是一个基于 WorldBox 的模拟向重构 MOD。玩家的核心行为不改，依然是观察世界里的 AI 生物、王国和战争自己发展，但底层循环会从“自然演化”升级成“轮回对抗”。系统会围绕魔王苏醒、军团压制、封印争夺和战后重建，持续推动世界进入高压状态。

玩法重点不是手动微操，而是看多个系统互相影响后产生结果：王国成长、英雄晋升、传承叠加、世界外交停战、叙事事件回放。玩家主要通过参数配置、节奏观察和策略判断来影响世界走向，让每次轮回都形成不同的战局与故事轨迹。

整体体验目标是“紧张 + 爽快 + 策略 + 叙事沉浸”同时成立：战斗节奏要有压迫感，封印与反攻要有翻盘爽点，传承与档位要有长期策略深度，历史事件与轮回记录要能沉淀可回看的故事感。

### Game Type

**Type:** Simulation  
**Framework:** This GDD uses the simulation template with type-specific sections for simulation, management, sandbox, systems.

## Target Platform(s)

### Primary Platform

PC（首发平台：PC）

### Platform Considerations

本项目基于 WorldBox + NeoModLoader，平台定位为 PC。  
性能目标暂不设硬指标，以“基本流畅”为准。  
当前阶段不绑定 Steam 成就、云存档、创意工坊等平台功能，后续按发布节奏再决定。

### Control Scheme

键鼠为主。

---

## Target Audience

### Demographics

16-35 岁玩家为主。

### Gaming Experience

休闲 / 核心 / 硬核混合玩家。  
重点面向有 WorldBox 经验和老玩家。

### Genre Familiarity

默认玩家对沙盒模拟和系统演化玩法有一定理解，不按纯新手路径设计。

### Session Length

不设固定时长。  
支持短时观察，也支持长时间连续游玩。

### Player Motivations

玩家主要追求紧张战局、系统联动、成长策略和叙事沉浸。

## Goals and Context

### Project Goals

1. 建立完整轮回闭环，确保同一存档可稳定运行 5 轮，并保持阶段推进和结算一致。  
2. 提升重复可玩性，让每轮战局在魔王、军团、传承和王国演化上都出现可感知差异。  
3. 构建可读可追溯的事件叙事链路，让玩家能回看关键战局与轮回过程。  
4. 在普通 PC 环境下保持“基本流畅”，避免中后期系统联动导致明显卡顿。  
5. 面向有经验与老玩家提供长期挑战，支持持续投入而非一次性体验。

### Background and Rationale

本项目的核心动机是提升 WorldBox 的长期可玩性和故事性。  
当前体验在长局里容易进入重复观察，缺少稳定的高压循环和可追踪的叙事沉淀。  
“纪元之轮：魔王轮回”通过阶段推进、封印对抗和轮回成长，把单次演化体验扩展成可持续推进的长期战局体验。

---

## Unique Selling Points (USPs)

1. 在保留 WorldBox 原有“观察 AI 自主演化”核心乐趣的前提下，叠加轮回压力与策略深度。  
2. 采用“魔王-将领-军团”三层威胁结构，并通过“预兆→苏醒→降临→封印战”形成清晰阶段节奏。  
3. 采用跨轮回传承成长体系，让王国、英雄与魔王在多轮中持续变化，强化长期目标。  
4. 提供可追溯的事件叙事输出，把战局结果转成可回看、可解释的轮回故事记录。

### Competitive Positioning

相比常见一次性强化或单系统扩展 MOD，本项目强调“多系统联动 + 长周期闭环”。  
它不依赖玩家高频微操，而是通过可观察、可配置、可追溯的系统演化提供策略与叙事价值。  
在目标玩家群体中，它定位为“保留原味观察体验，但显著增强中后期张力与长期成长”的模拟向重构 MOD。

## Core Gameplay

### Game Pillars

1. 高压阶段节奏：以“预兆→苏醒→降临→封印战”驱动核心体验。  
2. 长期成长反馈：通过跨轮回传承与强化形成持续目标。  
3. 叙事可追溯：关键事件可回看、可解释、可复盘。  
4. 配置驱动策略：玩家通过参数和策略调整影响长期战局。

**Pillar Prioritization:** When pillars conflict, prioritize in this order:  
高压阶段节奏 > 长期成长反馈 > 叙事可追溯 > 配置驱动策略

### Core Gameplay Loop

玩家主要循环为：观察世界态势 -> 调整参数/策略 -> 进入阶段对抗 -> 结算传承 -> 进入下一轮。

**Loop Diagram:**  
观察世界态势 -> 调整参数/策略 -> 触发阶段战斗（预兆/苏醒/降临/封印战） -> 轮回结算与传承发放 -> 下一轮观察与策略调整

**Loop Timing:** 不固定，按局势变化决定。  
**Loop Variation:** 每轮由魔王构成、军团节奏、王国成长、传承结果和事件链条共同形成差异。

### Win/Loss Conditions

#### Victory Conditions

- 击杀魔王可触发胜利。  
- 封印仪式达成可触发胜利。  
- 只判定已勾选条件，命中任一已勾选条件即进入结算。

#### Failure Conditions

- 不设置传统硬性 Game Over。  
- 当轮未达成封印目标视为阶段性失败，战局压力持续存在。

#### Failure Recovery

- 失败后通过下一轮的传承、配置调整和策略优化继续推进。  
- 设计目标是“可复盘、可翻盘”，而不是“一次失败即终局”。

## Game Mechanics

### Primary Mechanics

1. 观察世界态势  
- 使用时机：全程高频。  
- 主要考验：信息判断、节奏感知、优先级识别。  
- 对应支柱：高压阶段节奏、叙事可追溯。  

2. 参数调控  
- 使用时机：阶段切换前后和战后复盘后。  
- 主要考验：系统理解、策略配置、风险控制。  
- 对应支柱：配置驱动策略、长期成长反馈。  

3. 遗迹争夺调度  
- 使用时机：封印战相关窗口。  
- 主要考验：时机选择、资源分配、战场判断。  
- 对应支柱：高压阶段节奏、配置驱动策略。  

4. 轮回结算与传承分配  
- 使用时机：每轮结束后。  
- 主要考验：长期规划、成长取舍、路线管理。  
- 对应支柱：长期成长反馈。  

5. 事件回看与复盘  
- 使用时机：关键战局后、失败后、版本调参后。  
- 主要考验：因果分析、策略修正。  
- 对应支柱：叙事可追溯、配置驱动策略。

### Mechanic Interactions

观察世界态势提供战局信息，驱动参数调控决策。  
参数调控会直接影响遗迹争夺与阶段战斗结果。  
战后通过轮回结算与传承分配形成长期成长，再通过事件回看复盘反向优化下一轮参数策略。  
五个机制构成“观察 -> 调整 -> 对抗 -> 结算 -> 复盘”的闭环。

### Mechanic Progression

前期以基础观察和基础调参为主。  
中期进入多系统联动，玩家需要同步处理阶段节奏、遗迹争夺和王国成长。  
后期通过传承累积与复盘经验形成稳定策略框架，但每轮仍保留变化与不确定性。

---

## Controls and Input

### Control Scheme (PC)

- 输入设备：键鼠。  
- 控制策略：支持可改键，优先保障高频操作易触达。  
- 推荐映射：  
  - `Space`：暂停/继续  
  - `1/2/3`：速度切换  
  - `Tab`：打开/关闭 MOD 面板  
  - `F`：聚焦关键事件或目标对象

### Input Feel

整体手感目标为“信息清晰、操作直接、反馈明确”。  
阶段切换和关键事件应提供明显反馈，保证紧张感和可读性同时成立。  
高频操作避免复杂组合键，减少操作负担。

### Accessibility Controls

- 支持按键重绑定。  
- 支持 UI 缩放。  
- 支持色彩对比增强。  
- 支持关键事件弹窗开关。

## Simulation Specific Design

### Core Simulation Systems

本项目模拟对象为“王国-魔王-军团-遗迹-轮回传承”的多系统联动。  
模拟深度定位为中高，重点是阶段推进和系统耦合带来的涌现战局。  
系统运行以低频调度和关键节点计算为主，兼顾长期演化与基本流畅。

### Management Mechanics

玩家核心管理行为是“观察态势、调整参数、执行调度、战后复盘”。  
管理重点包括封印进度、军团压力、王国成长和传承分配。  
系统执行偏自动化，玩家负责策略决策与节奏把控。

### Building and Construction

不新增重建造主循环，沿用 WorldBox 原生城市发展。  
MOD 侧只扩展遗迹类对象及相关交互，不引入复杂手动建造链。  
设计目标是降低操作负担，保持观察与策略导向。

### Economic and Resource Loops

核心资源维度为人口、城市、军力、遗迹控制权与传承档位。  
资源循环路径为“战局结果 -> 轮回结算 -> 成长变化 -> 下一轮压力变化”。  
该循环用于驱动长期挑战和可复盘的策略选择。

### Progression and Unlocks

成长主线包括世界档位推进、王国抗魔等级、英雄成长和传承条目解锁。  
随着轮回推进，系统复杂度和策略深度逐步提升。  
解锁目标聚焦长期可玩性，而不是一次性通关。

### Sandbox vs. Scenario

主模式为沙盒长局，不设置固定剧情关卡。  
通过参数预设支持挑战化玩法，比如高压开局或极限封印窗口。  
整体保持“自由观察 + 策略调控”的核心体验。

## Progression and Balance

### Player Progression

玩家成长由技能成长、强度成长、内容成长、叙事成长共同组成。  
核心目标是“每轮都有可感知进步”，让玩家在观察、调参、复盘中持续获得正反馈。  
成长系统服务于轮回闭环，而不是一次性通关节奏。

#### Progression Types

- 技能成长：玩家更擅长读局势、抓时机、做参数取舍。  
- 强度成长：传承、抗魔、英雄和档位带来跨轮回强化。  
- 内容成长：轮回推进引入更高压力和更复杂联动。  
- 叙事成长：事件记录持续累积，形成可回看历史。

#### Progression Pacing

默认每轮都应给出明显成长反馈。  
反馈形式包括：传承生效、抗魔变化、战局压力可控度提升、复盘效率提升。  
节奏上强调“短期可见、长期可叠加”。

### Difficulty Curve

难度采用“锯齿型 + 玩家可调”组合。  
高压阶段提供挑战峰值，战后与过渡阶段提供调整窗口。  
玩家可通过参数体系主动控制整体难度强度。

#### Challenge Scaling

挑战随轮回和阶段推进上升，但不做单向直线加压。  
典型节奏是“上升 -> 爆发 -> 缓冲 -> 再上升”，保证紧张感与可恢复性并存。  
系统通过魔王、军团、遗迹、传承联动形成可复盘的难度变化。

#### Difficulty Options

- 提供关键参数调节入口，支持玩家主动控难。  
- 提供“保守预设/激进预设”快速切换。  
- 失败后提供复盘建议，指向关键事件链与主要失误点。

### Economy and Resources

本项目采用“系统资源循环”，不采用传统货币商店经济。

#### Resources

- 人口：影响阶段触发与王国承压能力。  
- 城市：影响王国运行能力和中长期恢复力。  
- 军力：影响对抗与守势质量。  
- 遗迹控制权：影响封印推进与战局主动权。  
- 传承档位：影响跨轮回成长上限与策略空间。

#### Economy Flow

资源循环主路径为：战局结果 -> 轮回结算 -> 资源状态变化 -> 下一轮策略与压力变化。  
该循环以“资源状态变化”替代“货币买卖”，强调长期策略经营。  
通过资源消长与阶段联动形成稳定的平衡约束。

## Level Design Framework

### Structure Type

本项目采用“开放世界沙盒 + 程序化变化 + 无尽轮回”结构。  
玩家在同一世界中持续观察和调控，不通过传统线性选关推进。  
每轮因魔王构成、王国态势和系统联动不同，形成可重复但不重复的内容体验。

### Level Types

本项目将“关卡类型”映射为阶段化战局类型：

1. 教学期（预发展/预兆）  
2. 压力爬升期（苏醒/降临）  
3. 决战期（封印战）  
4. 结算重建期（战后重建）

#### Tutorial Integration

教学内容通过前期阶段自然融入，不采用独立教学关。  
玩家在预发展和预兆阶段理解核心规则、阈值触发和调参影响。  
设计上采用“边玩边学”，降低割裂感。

#### Special Levels

封印战作为阶段性“高潮关卡”承担决战压力。  
战后重建作为“恢复与再布局窗口”承担节奏缓冲。  
不设置传统隐藏关，特殊内容通过事件链与局势演化触发。

### Level Progression

推进模型采用“阶段触发推进 + 世界状态自然流转”。  
核心触发依据人口阈值、封印进度和魔王 HP 阈值。  
整体不使用传统关卡选择地图。

#### Unlock System

新阶段通过系统阈值命中自动解锁。  
轮回推进后，传承和档位变化会改变后续阶段压力与可行策略。  
解锁核心是“系统状态达标”，不是手动选关。

#### Replayability

支持通过事件日志回放和复盘关键阶段。  
玩家可基于复盘调整参数和策略，进入下一轮验证。  
重玩价值来自系统联动变化和长期成长差异。

### Level Design Principles

1. 每个阶段只突出一个主要压力点。  
2. 每次阶段切换都提供明确反馈。  
3. 失败后必须提供可执行的复盘线索。

## Art and Audio Direction

### Art Style

整体视觉以 WorldBox 原版像素风为基础，MOD 内容保持风格一致。  
在此基础上，仅对关键事件增加更强可读性的视觉提示，不做全面风格重制。  
目标是在“低改动成本”下提升阶段识别度和战局反馈强度。

#### Visual References

- WorldBox 原版视觉表现（主参考）  
- `EraWheel_Redesign.md` 中的阶段节奏与事件特效方向（补充参考）

#### Color Palette

常态画面延续原版配色。  
在封印战和关键事件节点使用高对比提示色进行强调。  
配色目标是“先可读，再风格化”。

#### Camera and Perspective

沿用 WorldBox 原版视角与镜头逻辑。  
MOD 不引入新的摄像机模式，仅在事件聚焦时提供必要视觉引导。

### Audio and Music

音频策略遵循“原版复用为主，关键反馈补强”。  
不做大规模音频资产重构，优先保证提示有效和实现成本可控。  
整体要求与原版听感一致，不破坏基础沉浸。

#### Music Style

以原版 BGM 为主，不新增独立曲库。  
通过阶段与事件节奏控制，提升关键时刻的情绪张力。  
音乐设计目标是“兼容原版 + 强化节奏感”。

#### Sound Design

以原版音效为主。  
仅补充关键反馈音：阶段切换、封印推进、胜负结算等节点。  
音效优先级为“信息反馈优先于装饰性表现”。

#### Voice/Dialogue

不使用完整配音。  
主要通过事件文本和提示音传达信息。  
语音相关内容默认不纳入首期范围。

### Aesthetic Goals

美术与音频共同服务四个目标：阶段可读、节奏清晰、复盘友好、成本可控。  
在不破坏原版体验的前提下，强化高压阶段和关键节点的识别反馈。  
最终效果是“看得懂局势、听得出转折、改动量可落地”。

## Technical Specifications

### Performance Requirements

本项目性能目标以“基本流畅”为主，不设置硬性帧率与分辨率门槛。  
技术策略优先保障长期运行稳定，避免中后期明显卡顿。  
性能优化重点放在调度频率、状态持久化和关键节点计算效率。

#### Frame Rate Target

不设硬指标。  
目标是在常见 PC 环境下保持体感流畅和可操作反馈稳定。

#### Resolution Support

不设分辨率硬指标。  
沿用原版显示体系，保证常见桌面分辨率下 UI 与信息可读。

#### Load Times

不设具体秒数指标。  
要求无明显卡死，阶段切换和关键流程提供明确反馈。

### Platform-Specific Details

平台定位为 PC（WorldBox + NeoModLoader 生态）。  
技术边界以兼容现有 MOD 运行方式和本地存档流程为主。  
不把 Steam 专属能力作为首发硬依赖。

#### PC Requirements

- 输入：键鼠，支持可改键。  
- 平台依赖：不强依赖 Steam 专属功能。  
- 生态兼容：首发按 NeoModLoader 生态，兼容本地存档读写。  
- 平台功能：暂不承诺云存档和创意工坊深度联动。

### Asset Requirements

资产策略采用“原版复用优先，增量补强关键反馈”。  
在可读性和实现成本之间优先可落地性。  
新增资产规模控制在首期可维护范围内。

#### Art Assets

沿用原版像素风。  
新增资产以关键事件提示特效为主，不做大规模美术重做。

#### Audio Assets

以原版音频复用为主。  
仅补关键反馈音（阶段切换、封印推进、胜负结算）。

#### External Assets

允许少量开源或商店资源接入。  
前提是授权与许可关系清晰，满足发布合规要求。

### Technical Constraints

- 不做大规模全图高频扫描。  
- 轮回、统计、调度逻辑采用低频执行策略。  
- 兼容性和稳定性优先，不追求重度视觉升级。

## Development Epics

### Epic Overview

| # | Epic Name | Scope | Dependencies | Est. Stories |
|---|---|---|---|---|
| 1 | 轮回核心骨架 | 阶段状态机、双封印、胜负结算、存读档恢复 | 无 | 8 |
| 2 | 魔王战线系统 | 魔王/将领/军团生成、行为节奏、波次压力 | 1 | 9 |
| 3 | 遗迹与封印战 | 遗迹生命周期、争夺规则、仪式推进与打断 | 1,2 | 8 |
| 4 | 传承与长期成长 | 传承档位、王国抗魔、英雄成长与继承 | 1,2,3 | 10 |
| 5 | 事件与复盘体验 | 事件采集、时间线、复盘提示、可追溯叙事 | 1,2,3,4 | 7 |
| 6 | 配置与稳定性 | 参数面板、预设导入导出、迁移、性能与兼容保障 | 1,2,3,4,5 | 9 |

### Recommended Sequence

推荐顺序：`1 -> 2 -> 3 -> 4 -> 5 -> 6`。  
先打通轮回核心，再补战线压力与封印胜利，再接长期成长，最后做复盘体验和发布级稳定性收尾。

### Vertical Slice

**The first playable milestone:** 完成 Epic 1-3 后，玩家可以从预发展推进到封印战，并通过击杀或仪式触发结算，形成可完整游玩的首个轮回闭环。

## Success Metrics

### Technical Metrics

技术成功以“稳定运行、基本流畅、可恢复、可验证”四个方向衡量。

#### Key Technical KPIs

| Metric | Target | Measurement Method |
|---|---|---|
| 长时稳定性 | 连续运行 2 小时无崩溃 | 长时自动化跑图 + 崩溃日志统计 |
| 运行流畅性 | 中后期基本流畅，无明显卡死 | 中后期场景巡检 + 帧时间波动记录 |
| 存档恢复正确性 | 读档后阶段/封印/计时器恢复正确 | 存读档回归用例比对 |
| 回归质量 | 核心自检用例通过率 >=95% | `tools/EraWheel.SelfTest` 执行结果统计 |

### Gameplay Metrics

玩法成功以“闭环可跑、路径可达、成长可感知”衡量。

#### Key Gameplay KPIs

| Metric | Target | Measurement Method |
|---|---|---|
| 轮回闭环可达性 | 测试存档可稳定完成 5 轮 | 固定种子多轮回放与日志验证 |
| 多路径胜利可用性 | 击杀胜利与仪式胜利都可稳定触发 | 双路径专项测试 |
| 成长反馈可感知 | 玩家每轮都有可见进步反馈 | 多轮游玩观察 + 结算对比记录 |

### Qualitative Success Criteria

- 玩家会主动用“紧张、爽快、策略、沉浸”描述核心体验。  
- 玩家能解释“本轮为什么输/赢”，并指出关键事件。  
- 玩家愿意连续开启新轮回，而不是一轮后流失。

### Metric Review Cadence

采用双层复盘节奏：  
1. 每完成一个 Epic 复盘一次。  
2. 每个版本发版前再做一次全量复盘。  
复盘输出统一写入版本记录与测试报告。

## Out of Scope

- 联机/多人模式不在 v1.0 范围内。  
- 主机端与移动端移植不在 v1.0 范围内。  
- 完整配音与大规模新音乐资产不在 v1.0 范围内。  
- 重做原版美术风格不在 v1.0 范围内。  
- 大型剧情战役模式（固定关卡流程）不在 v1.0 范围内。  
- 深度 Steam 专属功能（云存档/创意工坊强绑定）不在 v1.0 范围内。

### Deferred to Post-Launch

- 更丰富挑战预设包。  
- 更多魔王与将领扩展包。  
- 更多叙事事件模板与文本润色。

---

## Assumptions and Dependencies

### Key Assumptions

- WorldBox 与 NeoModLoader 的主体兼容关系保持稳定。  
- 目标玩家设备以中端 PC 为主。  
- 目标玩家群体以有经验和老玩家为主。  
- `EraWheel_Redesign.md` 作为实现口径与验收基准。

### External Dependencies

- NeoModLoader API 可用且兼容。  
- WorldBox 现有 API/DLL 行为与文档口径一致。  
- 少量第三方资源许可合规。  
- 本地存档读写机制稳定。

### Risk Factors

- 上游版本更新导致 API 行为变化，可能触发功能回归。  
- 中后期大规模战局下性能波动，可能影响“基本流畅”目标。  
- 叙事和复盘内容规模增长后，信息过载风险上升。  
- 外部资源许可或更新变化，可能影响发布节奏。

---

## Document Information

**Document:** 纪元之轮：魔王轮回 - Game Design Document  
**Version:** 1.0  
**Created:** 2026-02-24  
**Author:** Wuxu  
**Status:** Complete

### Change Log

| Version | Date       | Changes              |
| ------- | ---------- | -------------------- |
| 1.0     | 2026-02-24 | Initial GDD complete |
