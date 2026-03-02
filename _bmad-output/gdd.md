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
inputDocuments:
  - '/home/wuxu/mod-1/_bmad-output/game-brief.md'
  - '/home/wuxu/mod-1/设计/EraWheel_Redesign.md'
  - '/home/wuxu/mod-1/设计/ERRE附属文档/公共特质表.md'
  - '/home/wuxu/mod-1/设计/ERRE附属文档/属性字段速查.md'
  - '/home/wuxu/mod-1/设计/ERRE附属文档/游戏原版特质与效果清单.md'
  - '/home/wuxu/mod-1/设计/ERRE附属文档/轮回阶位详表.md'
  - '/home/wuxu/mod-1/设计/ERRE附属文档/魔王名册与技能表.md'
documentCounts:
  briefs: 1
  research: 0
  brainstorming: 0
  projectDocs: 6
workflowType: 'gdd'
lastStep: 11
project_name: 'mod-1'
user_name: 'Wuxu'
date: '2026-02-27 08:41:19 -0800'
game_type: 'strategy'
game_name: '世纪轮回•魔王'
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

## Strategy Specific Design

### Resource Systems

《世纪轮回•魔王》的资源系统以“阶段推进资源”替代传统金币经济。
核心资源是：世界人口阈值、将领/魔王双封印进度、遗迹占领与仪式进度、王国军力与城市规模、轮回/王国生效档位。
玩家的核心资源管理行为是：识别当前阶段最关键瓶颈，优先把调度和战力投入到封印推进与战局稳态上。

### Unit Types and Stats

单位采用分层结构：魔王（核心 BOSS）、将领（精英层）、军团（波次压制层）、王国单位（含命定英雄）与技能召唤单位。
战斗数值由“模板基础值 + 随机区间 + 档位/抗魔/英雄强化”共同决定。
系统通过角色分层保证战场职责清晰：魔王负责机制压力，将领负责战术节点，军团负责持续消耗，王国单位负责防线与反推。

### Technology and Progression

本项目不采用传统科技树，而采用轮回型长期成长框架。
核心 progression 由三条线组成：轮回进阶（装备/特质/军事增幅）、王国抗魔等级、命定英雄晋升与家族继承。
成长结果在轮回结算后进入下一轮，持续扩大玩家的构筑深度和容错空间。

### Map and Terrain

战略空间围绕据点、封印遗迹、王国城市三类关键点构成。
据点承担魔王阵营生成与集结，遗迹承担封印争夺与仪式推进，城市承担王国侧生产与对抗承载。
地形在战斗中可被技能和状态阶段性改变（如火焰、岩浆、冻结、腐化），并直接影响推进路线与区域控制。

### AI Opponent

魔王侧 AI 压力由“阶段状态 + 多层单位协同”驱动。
在预兆、苏醒、降临、封印战不同阶段，军团频率、技能强度和攻防节奏会动态变化。
难度主要通过可配置参数控制，包括波次间隔、数量上限、封印衰减、遗迹调度规模和阶段阈值。

### Victory Conditions

系统支持多条件胜利，玩家可勾选击杀封印与仪式封印，命中任一条件即可触发轮回结算。
失败不是立即结束，而是阶段回退到降临并承受持续高压，形成“可逆但高成本”的失败状态。
该设计保证了策略回旋空间：失败会惩罚节奏，但不会直接切断长期成长主线。

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

世纪轮回•魔王

### Core Concept

《世纪轮回•魔王》是一个基于 WorldBox 原版玩法扩展的轮回对抗 MOD。玩家仍按原版方式发展和观察文明，但世界会周期进入“魔王入侵-文明反抗-封印决战”的高压循环，形成持续推进的长期目标。

游戏围绕六阶段闭环推进：预发展、预兆、苏醒、降临、封印战、战后重建。双封印（将领封印/魔王封印）驱动将领、军团、遗迹与外交联动，玩家通过阶段判断与参数配置影响战局走向，并在胜负结算后进入下一轮回。

本作强调“原版不改、扩展增强”。在保持原版可读性与兼容性的前提下，引入轮回进阶、王国抗魔、命定英雄和家族继承等跨轮回成长系统，让每一轮都能积累长期收益并产生新的战略选择。

### Game Type

**Type:** Strategy
**Framework:** This GDD uses the `strategy` template with type-specific sections for resource systems, unit tactics, long-term progression, map/terrain control, AI pressure, and multi-condition victory design.

## Target Platform(s)

### Primary Platform

PC（WorldBox + NeoModLoader）

### Platform Considerations

当前只做 PC，不做次平台移植。
控制方式固定为键鼠，不做手柄适配。
性能目标暂不单独设硬性指标，优先保证在目标版本下稳定运行与长局可持续性。

### Control Scheme

键盘 + 鼠标。
核心操作围绕观察、参数配置、阶段判断与战局调度设计。

---

## Target Audience

### Demographics

16-40 岁，熟悉或长期游玩 WorldBox 的玩家群体。

### Gaming Experience

休闲到核心玩家。
能接受中高强度危机事件、阶段推进和跨轮回成长系统。

### Genre Familiarity

默认玩家对沙盒演化和策略对抗有基础认知。
新玩家可通过默认参数逐步进入完整轮回玩法。

### Session Length

支持双节奏：短时观察（碎片化）和长局推进（深度游玩）都可成立。

### Player Motivations

追求“魔王入侵压迫感 + 关键节点反击 + 跨轮回成长”的长期可玩体验。

## Goals and Context

### Project Goals

1. 完整实现 `设计/` 目录下 6 份文档中定义的全部必做内容，并保持各系统规则一致。
2. 在目标版本下稳定跑通多轮完整闭环（预发展 -> 预兆 -> 苏醒 -> 降临 -> 封印战 -> 战后重建）。
3. 坚持“原版不改、扩展增强”，优先保证兼容性、可维护性和可验证性。
4. 通过小范围玩家测试验证核心体验，目标反馈集中在“好玩、刺激、有代入感”。

### Background and Rationale

《世纪轮回•魔王》的立项动机是补齐原版 WorldBox 缺少的长期危机主线与跨轮回目标。
项目在不推翻原版沙盒体验的前提下，构建“魔王入侵-文明反抗-封印结算-再次轮回”的持续闭环，让每一局都具备明确阶段目标与长期成长价值。
当前启动时机来自既有完整设计沉淀（主文档 + 5 份附属文档）与社区玩家对高压长线玩法的需求，具备直接落地与快速验证条件。

---

## Unique Selling Points (USPs)

1. 六阶段轮回闭环：从预发展到战后重建形成完整循环，不是单次事件型玩法。
2. 双封印驱动多系统联动：将领、军团、遗迹、外交围绕封印进度同步变化。
3. 跨轮回成长体系：轮回阶位、王国抗魔、命定英雄与家族继承共同构成长线成长。
4. 原版兼容导向：保留 WorldBox 原生玩法逻辑，通过扩展实现危机与目标升级。
5. 十魔王差异化技能体系：每位魔王具备独立机制与技能组合，形成可识别的战场压力与对策差异。

### Competitive Positioning

与原版及常见功能型 MOD 相比，本项目核心竞争点不是单一机制强化，而是“阶段推进 + 双封印 + 多魔王差异化 + 跨轮回成长”的整套可循环系统。
玩家在每轮都会面对不同魔王机制和战场节奏，并把本轮结果转化为下一轮可见成长，形成持续复玩动机。
该定位直接服务目标人群对“长期目标、危机压迫、策略反制、文明叙事”的复合需求。

## Core Gameplay

### Game Pillars

1. 轮回危机：所有核心系统都服务于“魔王入侵-文明反抗-封印结算”的持续危机体验。
2. 原版不改：不推翻 WorldBox 原生玩法链路，以扩展方式叠加新目标和新压力。
3. 长线成长：通过轮回进阶、王国抗魔、英雄继承让每轮结果能传递到下一轮。
4. 史诗叙事：用阶段事件、战局反转和历史沉淀构建文明兴衰的长期叙事感。

**Pillar Prioritization:** When pillars conflict, prioritize in this order:
轮回危机 > 原版不改 > 长线成长 > 史诗叙事

### Core Gameplay Loop

玩家在大多数时间会执行同一条高压循环：观察世界状态，判断当前阶段风险，调整配置与战局策略，对抗魔王阵营并推进封印战，完成结算后进入下一轮更高压对抗。

**Loop Diagram:**
观察世界状态 -> 识别阶段风险 -> 调整参数与调度 -> 推进对抗与封印 -> 轮回结算与进阶成长 -> 下一轮回

**Loop Timing:**
单次微循环为“观察-判断-调整”短周期；完整闭环跨越“预发展 -> 战后重建”一整轮中长周期。

**Loop Variation:**
每轮会因魔王类型、将领组合、军团压力、遗迹争夺和王国成长差异产生不同战局，不会完全重复。

### Win/Loss Conditions

#### Victory Conditions

- 命中已勾选胜利条件之一即判胜并进入轮回结算（击杀魔王 / 仪式封印，可多选）。
- 同一检查周期命中多个条件时记录全部原因，但只执行一次结算。

#### Failure Conditions

- 封印战被压制导致阶段回退到降临，形成持续失败压力。
- 若长期无法稳定推进封印目标，世界会进入高压崩盘态并持续恶化战局。

#### Failure Recovery

- 失败不采用“直接终局清档”，而是通过阶段回退继续对抗。
- 玩家可通过下一轮配置调整、王国成长和系统联动逐步扳回局势。

## Game Mechanics

### Primary Mechanics

1. 阶段监控与策略调度
玩家持续观察阶段、封印进度、人口与战况，并通过参数配置与调度策略影响战局走向。
主要服务支柱：轮回危机、原版不改。

2. 双封印推进与封印战切换
将领封印与魔王封印共同驱动苏醒、降临、封印战等关键节点，HP 阈值负责阶段切换与回退。
主要服务支柱：轮回危机、长线成长。

3. 魔王-将领-军团对抗链
魔王技能、将领精英层、军团波次协同施压，玩家围绕多线战场做节奏管理与优先级判断。
主要服务支柱：轮回危机、史诗叙事。

4. 遗迹争夺与仪式封印
玩家围绕遗迹占领、中断与推进进行拉扯，形成“击杀封印/仪式封印”双路径胜利结构。
主要服务支柱：轮回危机、长线成长。

5. 轮回结算与跨轮回构筑
每轮结算后进入轮回进阶、王国抗魔、英雄继承，再以更高压力进入下一轮。
主要服务支柱：长线成长、史诗叙事。

### Mechanic Interactions

阶段系统是总调度层，双封印负责关键状态切换；魔王-将领-军团是压力来源；遗迹争夺提供逆转路径；轮回结算把本轮结果转化为下轮成长。
各机制不是并列独立关系，而是“阶段驱动 -> 对抗施压 -> 封印决胜 -> 结算成长 -> 再开新轮回”的闭环耦合。

### Mechanic Progression

机制进化主要体现在轮回间的构筑变化，而不是单轮内一次性解锁。
随着轮回推进，玩家在装备、特质、军事增幅、王国抗魔与英雄继承上持续积累，进而改变下一轮的决策空间和容错能力。

---

## Controls and Input

### Control Scheme (PC)

确认沿用 WorldBox 原版键鼠操作习惯，不新增强制改键前提。
MOD 交互主要通过参数面板、状态 HUD、日志与列表页面完成。

### Input Feel

输入反馈目标是“低学习成本、信息优先、决策直接”：玩家能快速看清阶段状态并立即调整策略。
交互不追求复杂连招或高操作门槛，优先保证观察、判断、配置三步流畅衔接。

### Accessibility Controls

默认沿用原版可用交互与显示逻辑，保证老玩家无迁移成本。
关键状态信息采用显式文本与数值展示，减少只靠视觉特效判断的负担。

## Progression and Balance

### Player Progression

《世纪轮回•魔王》采用跨轮回并行成长结构，玩家成长不是单轮内一次性数值膨胀，而是每轮结算后把战果转为下一轮可用的长期能力。
成长主线由三条系统并行构成：轮回进阶（装备/特质/军事增幅）、王国抗魔等级、命定英雄晋升与家族继承。
该结构直接服务核心循环，让“本轮决策结果 -> 下轮战力形态”形成持续反馈。

#### Progression Types

- Power Progression：轮回进阶、抗魔等级、英雄强化带来可量化战力提升。
- Skill Progression：玩家对阶段节奏、封印窗口、调度优先级的判断能力持续提升。
- Content/State Progression：阶段状态、阵营压力和战局结构随轮回演进不断变化。

#### Progression Pacing

玩家在单轮内通过阶段推进获得即时反馈，在轮回结算处获得明显“长期成长反馈”。
短周期反馈来自阶段切换和战局控制，长周期反馈来自档位提升与构筑变化。
节奏目标是“每轮都能感到有进展，但不会在前几轮快速失衡”。

### Difficulty Curve

主曲线采用锯齿上升：每轮和每阶段总体压力提高，封印战胜利后短暂回落，再进入更高压力轮次。
这种曲线保证了高压与恢复交替，既维持挑战，又给玩家调整配置与策略复盘的窗口。

#### Challenge Scaling

挑战主要通过阶段状态和参数系统联合抬升：军团节奏、封印衰减、魔王技能压力、遗迹争夺强度随轮回推进逐步增强。
在单轮内，预兆 -> 苏醒 -> 降临 -> 封印战形成明显强度爬坡；战后重建作为短暂恢复段。
失败后阶段回退到降临，形成“可逆但高成本”的惩罚。

#### Difficulty Options

难度不采用传统档位按钮，而采用参数化调控。
可调项包括但不限于波次间隔、同时上限、封印衰减速率、遗迹调度规模、阶段阈值与胜利条件组合。
该方式同时覆盖新手容错和核心玩家挑战需求。

### Economy and Resources

本项目不使用传统货币经济系统。
资源设计采用战略资源模型，核心资源为人口阈值、双封印进度、遗迹仪式进度、王国军力/城市规模与世界/王国档位。
资源流转不是“赚币-花币”，而是“识别阶段瓶颈 -> 投入调度与战力 -> 推进封印与结算 -> 转化为下轮成长”。

## Level Design Framework

### Structure Type

《世纪轮回•魔王》采用“开放世界 + 阶段驱动”结构。
游戏不是传统离散关卡制，而是在连续世界中通过阶段切换形成关卡节奏与内容组织。
玩家的空间体验核心是“同一世界，不同阶段，不同战场压力”。

### Level Types

1. 预发展稳态区：用于文明扩展、资源积累和前置准备。
2. 预兆/苏醒过渡区：用于建立危机感、完成阵营切换与战前布局。
3. 降临高压对抗区：魔王阵营全面施压，战场进入高频冲突。
4. 封印战决胜区：围绕遗迹激活与封印条件推进形成决胜窗口。
5. 战后重建恢复区：战局降压，执行结算与下一轮前置重整。
6. 特殊热点区：遗迹争夺点、据点周边战场、王城防线等高价值空间节点。

#### Tutorial Integration

教程不采用独立教学关，而是通过预发展与预兆阶段的低压窗口完成“自然教学”。
玩家在真实战局中逐步理解阶段目标、封印机制与调度逻辑。

#### Special Levels

封印战可视为阶段性“Boss 关”结构，承担本轮最强压力与最高决策密度。
遗迹争夺点和据点周边战场是高频特殊遭遇区，提供阶段内反转机会和风险集中点。

### Level Progression

内容推进采用“阈值驱动解锁”模型，而非固定线性关卡顺序。
核心推进链路是：人口阈值 -> 双封印衰减 -> HP 阈值触发封印战 -> 胜利结算 -> 下一轮回。

#### Unlock System

新阶段由系统阈值与战局状态共同解锁。
玩家不能跳过主阶段，但可通过策略与配置影响阶段停留时长、推进速度与风险等级。
胜利条件支持击杀封印与仪式封印多选，命中任一即触发结算。

#### Replayability

轮回机制天然提供重开价值：每轮魔王压力、将领组合、军团节奏、遗迹争夺态和成长构筑都会变化。
系统允许“回退降临再冲刺”，失败不会直接终局，玩家可在同轮继续争取翻盘。
跨轮回成长会改变后续轮次的策略空间，形成长期复玩动力。

### Level Design Principles

1. 先读阶段状态再行动：信息优先于操作，保证玩家先判断再调度。
2. 每个阶段只强调一个主冲突：降低信息噪音，突出阶段目标。
3. 封印窗口可逆但代价明显：失败允许回退重试，但必须承担节奏与战力成本。

## Art and Audio Direction

### Art Style

整体视觉方向延续 WorldBox 原版像素风，不改变原版核心识别逻辑。
美术重点放在“阶段状态可读性”和“魔王阵营辨识度”两条主线，确保玩家在高压战局中能快速读懂局势。
风格目标是“原版一致性 + 危机表达增强”，而不是重做视觉体系。

#### Visual References

主参考是 WorldBox 原版的地形、单位和信息表达方式。
扩展参考是危机期高对比警示表达，用于突出入侵阶段与封印战阶段的风险变化。
所有新增视觉保持像素风一致，不引入风格冲突资产。

#### Color Palette

常态阶段采用自然文明色调，保持原版沙盒观感。
入侵和封印战阶段提升红、橙、紫等警示色占比，用于表达风险升级与关键事件。
颜色策略优先服务信息层级，不以装饰性渐变为目标。

#### Camera and Perspective

镜头与视角完全沿用 WorldBox 原版俯视观察方式。
不新增相机系统，不改变基础观察交互路径。
视觉增强仅在现有视角框架内完成。

### Audio and Music

音频方向采用“原版复用 + 关键事件强化提示”。
项目不新增独立音乐和配音资源，重点通过节奏、提示和反馈强化阶段压迫感与关键节点感知。
音频设计目标是低成本可维护，同时不破坏玩家对原版声音语义的熟悉度。

#### Music Style

音乐延续原版风格，不新增独立 BGM 曲目。
情绪变化主要通过阶段事件密度和战局节奏体现，而非重配乐切换。
该策略与单人开发和兼容优先目标保持一致。

#### Sound Design

音效重点强化四类关键反馈：阶段切换、封印推进、遗迹争夺、胜负结算。
普通状态维持原版音效基线，避免提示噪音过高。
高优先级事件采用更明确的提示层级，保证玩家能在混战中抓住关键信息。

#### Voice/Dialogue

不新增语音与角色配音系统。
叙事反馈主要通过事件文本、历史记录与阶段提示完成。

### Aesthetic Goals

美术与音频共同目标是服务四大支柱：轮回危机、原版不改、长线成长、史诗叙事。
视觉负责“看得清阶段与风险”，音频负责“听得见关键节点”，两者合并提升高压战局中的决策效率。
最终体验应保持原版熟悉感，同时让玩家明确感受到轮回危机的层层升级。

## Technical Specifications

### Performance Requirements

技术目标以稳定性优先，保证核心轮回闭环可长局持续运行。
性能策略强调“可维护 + 可验证”，避免为追求极限指标引入高风险实现。
重点关注读档恢复一致性、阶段切换稳定性和多系统联动下的帧率波动控制。

#### Frame Rate Target

目标帧率为 `60 FPS`（1080p 常见游玩场景）。
在高压战局和大规模单位并发时，优先保证逻辑稳定与战局连续性。
性能优化策略以低频调度和关键链路降载为主。

#### Resolution Support

主目标分辨率为 `1920x1080`。
在更高分辨率下保持 UI 可读性与信息层级清晰，不强制追求额外视觉开销。
分辨率适配以实用显示清晰度优先。

#### Load Times

不以极限秒开为目标，优先保证加载后状态正确与可恢复。
读档/初始化必须正确恢复阶段、封印进度、计时器和核心阵营状态。
可接受范围内优化加载耗时，但不牺牲一致性校验。

### Platform-Specific Details

项目平台固定为 PC，运行依赖 WorldBox 与 NeoModLoader。
输入方式固定为键鼠，交互逻辑沿用原版操作习惯。
平台策略优先兼容和稳定，不引入额外在线服务依赖。

#### PC Requirements

- 平台范围：PC（WorldBox `0.51.2+` + NeoModLoader）。
- 输入方式：键盘 + 鼠标（沿用原版交互）。
- 运行策略：单机本地运行，不依赖联机或云服务。
- 兼容目标：优先保证与原版链路及常见 MOD 共存，不破坏基础玩法流程。

### Asset Requirements

资产策略是“原版复用为主，新增最小化，表达关键信息优先”。
新增内容聚焦在阶段提示、阵营辨识、关键事件反馈，不做大规模美术重建。
资产规模控制服务于单人开发可维护性与版本迭代稳定性。

#### Art Assets

视觉资源延续原版像素风。
新增资产以 UI 标识、图标、状态提示和必要特效反馈为主。
目标是强化阶段可读性与魔王阵营辨识度，而非替换原版视觉体系。

#### Audio Assets

音频以复用原版资源为主，不新增独立 BGM 和配音。
重点强化关键事件提示（阶段切换、封印推进、遗迹争夺、胜负结算）。
音频设计目标是“提示清晰 + 成本可控 + 兼容稳定”。

#### External Assets

原则上减少外部资产依赖，优先自研与原版复用。
如需引入第三方资源，必须先评估兼容风险、维护成本和版权边界。
外部资产不应成为核心系统可运行的硬依赖。

### Technical Constraints

- 禁止高频全图扫描，核心系统使用低频调度与分层更新。
- 状态数据存储遵循既定 `custom_data_int/long/float` 口径。
- 多系统联动必须保证存档写入、读档恢复与回档复现一致。
- 性能优化优先保障稳定和可验证，不引入难维护的复杂旁路逻辑。
- 技术实现必须与“原版不改、扩展增强”支柱保持一致。
