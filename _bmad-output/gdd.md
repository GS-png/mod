---
stepsCompleted: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]
inputDocuments:
  - game-brief.md
documentCounts:
  briefs: 1
  research: 0
  brainstorming: 0
  projectDocs: 0
workflowType: 'gdd'
lastStep: 0
project_name: '纪元之轮'
user_name: '吴旭'
date: '2026-01-17'
game_type: 'simulation'
game_name: '纪元之轮：魔王轮回'
---

# 纪元之轮：魔王轮回 - Game Design Document

**Author:** 吴旭
**Game Type:** Simulation
**Target Platform(s):** PC (WorldBox MOD)

---

## Executive Summary

### Game Name

纪元之轮：魔王轮回 (Era Wheel: Demon Lord Reincarnation)

### Core Concept

《纪元之轮：魔王轮回》是一款基于WorldBox的AI协作叙事MOD，将上帝模拟游戏与LLM驱动的动态叙事相结合。玩家可以与AI进行自然语言对话，让AI作为"智能上帝"操控世界演化，而玩家则作为"观察者上帝"进行指导、提问或纯粹欣赏这场独一无二的文明史诗。

游戏核心围绕"轮回"机制展开：文明与十大魔王在一次次的苏醒-入侵-封印循环中不断对抗。每次轮回结束后，魔王会学习新策略变得更强，而文明则继承纪元遗产获得永久强化。这种双向进化机制确保了无限的重玩价值——每一局都是独一无二的史诗。

### Game Type

**Type:** Simulation（模拟）
**Framework:** 此GDD使用Simulation模板，包含系统设计、沙盒机制、AI行为、事件触发器等专项章节

### Key Features

- **AI协作叙事** - LLM接入实现自然语言交互，AI演绎动态剧情
- **轮回进化系统** - 魔王与文明双向成长，每局不同
- **十大魔王机制库** - 虚无、瘟疫、机械、时空等独特机制
- **高度可配置** - 从轻松观影到硬核挑战

### Target Audience

WorldBox沙盒爱好者 + AI技术好奇者（18-35岁）

### Unique Selling Points (USPs)

1. 首款LLM接入的WorldBox MOD
2. 轮回进化系统提供无限重玩价值
3. AI上帝模式 - 创新的人机协作体验

---

## Target Platform(s)

### Primary Platform

PC (Windows) - WorldBox MOD

### Platform Considerations

- **依赖环境：** WorldBox 0.51.2+ + NeoModLoader
- **分发渠道：** MOD社区 / Steam创意工坊
- **性能目标：** 与WorldBox原版保持一致，大地图需优化
- **网络需求：** LLM API调用需要网络连接（可离线使用后备事件池）

### Control Scheme

- **主要输入：** 鼠标点击/拖拽 + 键盘快捷键
- **UI交互：** 控制面板、参数配置、AI对话窗口
- **无障碍：** 支持字体缩放、高对比度模式

---

## Target Audience

### Demographics

- **年龄范围：** 18-35岁
- **地域：** 中文优先，后续扩展英文
- **游戏偏好：** 沙盒/模拟/策略类游戏爱好者

### Gaming Experience

**中等到硬核** - 熟悉MOD安装和使用，对复杂系统有耐心

### Genre Familiarity

熟悉WorldBox或类似沙盒游戏（Rimworld、Dwarf Fortress、文明系列），对AI/LLM技术有好奇心

### Session Length

**30分钟-2小时** - 观察一个完整纪元阶段或一次轮回

### Player Motivations

**四类核心玩家：**
1. **沙盒观众** - 享受"看世界自己跑"的悠闲体验
2. **挑战玩家** - 追求与AI魔王的策略对抗
3. **剧情党** - 沉浸于每轮回独特的史诗叙事
4. **整活玩家** - 探索各种玩法边界和黑暗路线

---

## Goals and Context

### Project Goals

1. **创意目标** - 创造一个会"自己讲故事"的世界，让玩家见证独一无二的文明史诗
2. **技术目标** - 成功集成LLM API，实现稳定的轮回系统和后备事件池
3. **社区目标** - 成为WorldBox社区最受欢迎的叙事MOD
4. **验证目标** - 证明AI+沙盒游戏结合的可行性和吸引力

### Background and Rationale

**灵感来源：**
WorldBox提供了优秀的上帝模拟基础，AI Dungeon证明了LLM叙事的魅力。将两者结合，可以创造一种全新的游戏体验——可视化的AI协作叙事。

**市场空白：**
目前没有LLM接入的WorldBox MOD，也没有将沙盒模拟与AI叙事结合的产品。这是一个独特的定位。

**时机：**
AI游戏赛道正在爆发，LLM技术成熟且API成本下降，玩家对AI内容的接受度提高。

---

## Competitive Positioning

**竞争优势：**
- 不是与WorldBox竞争，而是扩展其生态
- LLM交互是杀手级差异化特性
- 轮回+遗产系统提供无限重玩价值

**独特价值主张：**
"首款让你与AI一起创造史诗的WorldBox MOD——你对话，AI演绎，世界自己写故事。"

---

## Core Gameplay

### Game Pillars

1. **动态叙事 (Emergent Narrative)** - 世界自己"起承转合"，AI驱动的史诗自然涌现
2. **轮回进化 (Cycle Evolution)** - 每次轮回双方都变强，无限重玩价值
3. **AI协作 (AI Collaboration)** - LLM接入实现自然语言交互
4. **可配置深度 (Configurable Depth)** - 大量参数可调，适配所有玩家

**支柱优先级：** 动态叙事 > 轮回进化 > AI协作 > 可配置深度

### Core Gameplay Loop

**核心循环：**
```
观察演化 → 发现有趣/危机时刻 → 对话/干预 → 观察结果 → 轮回结算 → 纪元遗产继承 → 下一轮回
```

**循环时长：** 一个完整轮回约30分钟-2小时

**循环变化：**
- 每轮回不同魔王组合
- AI生成的事件和叙事独一无二
- 文明发展路径随机
- 遗产系统让每轮回起点不同

### Win/Loss Conditions

#### Victory Conditions

- **轮回胜利：** 成功封印当前魔王
- **纪元胜利：** 文明存续并繁荣发展
- **终极胜利：** 达成诸神黄昏或永恒守护结局

#### Failure Conditions

- **轮回失败：** 文明被魔王完全摧毁
- **软失败：** 文明严重削弱但未灭绝

#### Failure Recovery

- 失败后进入下一轮回，保留遗产记忆
- 魔王也会从失败中学习，变得更强
- 没有绝对的"通关"，追求更好的轮回表现

---

## Game Mechanics

### Primary Mechanics

| 机制 | 描述 | 服务支柱 |
|------|------|----------|
| **观察** | 观看世界自动演化、文明兴衰、魔王入侵 | 动态叙事 |
| **对话** | 与LLM交互，下达指令、询问状态、请求解说 | AI协作 |
| **干预** | 触发事件、加速魔王苏醒、帮助文明建立联盟 | 轮回进化 |
| **配置** | 调整参数、启用/禁用魔王和系统模块 | 可配置深度 |

### Mechanic Interactions

- **观察+对话：** 看到有趣场景时询问AI背景故事
- **对话+干预：** 通过对话指导AI执行特定干预
- **配置+观察：** 调整参数后观察世界变化

### Controls and Input

**控制方案（PC）：**

| 操作 | 输入 |
|------|------|
| 视角移动 | WASD / 鼠标拖拽 |
| 缩放 | 滚轮 |
| 选择/交互 | 左键点击 |
| 打开菜单 | 右键 / ESC |
| AI对话 | Tab打开对话框 |
| 时间控制 | 空格暂停、1-3加速 |

**输入感受：**
- 视角操作平滑、反应迅速
- 点击反馈明确（高亮、音效）
- 对话框支持中文输入

**无障碈选项：**
- 字体缩放
- 高对比度模式
- 可重绑按键

---

## Simulation Specific Design

### Core Simulation Systems

**模拟核心：** 文明演化 + 魔王入侵 + 轮回系统

**系统互联：**
```
文明繁荣 → 封印松动 → 魔王苏醒 → 对抗阶段 → 封印/毁灭 → 遗产继承 → 下一轮回
```

**涌现行为：**
- 文明自主发展、战争、联盟
- 魔王根据世界状态选择策略
- AI叙事引擎生成独特事件

### Management Mechanics

**管理方式：** 观察者上帝模式（非RTS微操）

**决策系统：**
- 通过AI对话下达指令
- 直接干预触发事件
- 参数配置影响世界规则

**自动化vs手动：**
- 默认世界自动演化
- 玩家可选择干预程度（观察者/引导者/操控者）

### Economic and Resource Loops

**文明经济：**
- 资源积累：人口、科技、军事、文化
- 威胁消耗：魔王入侵、自然灾害、内部冲突

**Meta经济：**
- 遗产点：轮回表现转化为永久强化
- 解锁条件：特定成就解锁新内容

### Progression and Unlocks

**轮回内进度：**
- 文明发展阶段：蒙昧→发展→繁荣→危机
- 魔王威胁阶段：沉睡→预兆→苏醒→入侵→封印战

**轮回间进度：**
- 魔王进化：学习新策略、获得新能力
- 文明遗产：继承科技、英雄记忆、结盟传统

### Sandbox vs. Scenario

**游戏模式：**
1. **标准模式** - 完整轮回体验，默认设置
2. **观察者模式** - AI完全操控，玩家纯观看
3. **挑战模式** - 特定魔王组合，难度加大
4. **自定义模式** - 玩家配置所有参数
5. **整活模式** - 解锁黑暗路线（帮助魔王）

---

## Progression and Balance

### Player Progression

**进度类型：**
- **技能进度** - 玩家学会更好的干预时机和策略
- **内容进度** - 解锁新魔王、新事件、新模式
- **Meta进度** - 轮回遗产点积累、永久强化
- **叙事进度** - 每轮回独特的故事展开

**进度节奏：**
- 单轮回30分钟-2小时可体验完整循环
- 每3-5轮回解锁新内容
- 遗产系统让每次重玩都有意义

### Difficulty Curve

**曲线模式：** 玩家可控 + 动态调整

**轮回内曲线：**
发展期（简单）→ 预兆期（警告）→ 苏醒期（紧张）→ 入侵期（高潮）→ 封印战（决战）

**轮回间曲线：**
- 魔王进化让后续轮回更难
- 文明遗产让玩家更强
- 保持动态平衡

**难度选项：**
- 标准模式：默认平衡
- 观察者模式：无压力观看
- 挑战模式：魔王更强
- 自定义：所有参数可调

### Economy and Resources

**轮回内资源（文明维度）：**
- 人口：基础生产力和军事潜力
- 科技：影响发展速度和对抗能力
- 军事：直接对抗魔王的力量
- 文化：影响封印力量和遗产继承

**Meta资源：**
- **遗产点** - 轮回表现转化，用于永久强化
- **解锁进度** - 成就解锁新内容

---

## Level Design Framework

### Structure Type

**类型：** 程序生成 + 持续世界（沙盒模拟）

- 不是传统关卡制
- WorldBox提供的沙盒地图
- 每轮回在同一世界持续演化

### Level Types

| 传统概念 | 本游戏对应 |
|----------|------------|
| 关卡 | 轮回（一次完整循环） |
| 区域 | 纪元阶段（发展→预兆→苏醒→入侵→封印战→重建） |
| Boss关 | 魔王入侵高潮期 |
| 教程 | 首轮回引导 + AI解说 |

### Level Progression

**解锁模式：** 成就/轮回次数触发

- 完成首轮回 → 解锁更多魔王
- 特定成就 → 解锁挑战模式
- 累计遗产 → 解锁整活路线

**重玩性：** 每轮回都是独特体验，鼓励无限重玩

### Level Design Principles

- **涌现优先：** 让世界自己产生故事
- **渐进引导：** 通过AI解说教学，而非强制教程
- **可配置：** 玩家可调整体验节奏

---

## Art and Audio Direction

### Art Style

**风格：** 复用WorldBox像素美学

**扩展资源：**
- 魔王/将领Sprite
- 特效（毒雾/火焰/虚空/时空裂隙）
- UI面板（控制台、AI对话框、状态显示）

**视角：** 俯视/等距（WorldBox原版）

**调色：** 保持WorldBox风格，魔王添加特色配色
- 虚无之主：紫黑色
- 瘟疫母神：毒绿色
- 炽炎大公：火焰橙红

### Audio and Music

**策略：** 依赖WorldBox原版音频

**可选扩展：**
- 魔王主题BGM（入侵高潮时播放）
- 关键事件音效（魔王苏醒、封印成功）

**语音：** 无语音，文字+AI生成叙事

### Aesthetic Goals

- **最小化美术需求：** 专注系统设计和AI集成
- **资源复用：** 最大化利用原版资源
- **渐进式扩展：** 核心功能优先，美术后续迭代

---

## Technical Specifications

### Performance Requirements

**帧率目标：** 与WorldBox原版保持一致
**优化重点：** 大地图+多单位+AI计算负载
**加载时间：** LLM调用异步处理，不阻塞主游戏

### Platform-Specific Details

**引擎/框架：** Unity（WorldBox基础）+ NeoModLoader
**语言：** C#
**依赖：** WorldBox 0.51.2+
**分发：** MOD社区/Steam创意工坊

**PC特定需求：**
- MOD支持：NeoModLoader兼容
- 存档：本地存储 + 导出/导入
- 网络：LLM API需要联网（可离线使用后备事件池）

### Asset Requirements

**美术资源：**
- 魔王 Sprite（10个）
- 将领/英雄 Sprite（可扩展）
- 特效动画（毒雾、火焰、虚空等）
- UI面板素材

**音频资源：**
- 依赖原版 + 可选魔王BGM

**外部资源：**
- 最大化复用WorldBox原有资源

### Technical Constraints

- **LLM集成：** 外部API调用，需后备事件池
- **性能保护：** 毒雾/火焰等效果上限
- **存档兼容：** 版本升级时保护玩家数据
- **容错设计：** 参数异常自动回退默认值

---

## Development Epics

### Epic Overview

| # | Epic名称 | 范围 | 依赖 | 预估Stories |
|---|----------|------|------|-------------|
| 1 | 核心框架 | MOD基础架构、配置系统 | 无 | 8-10 |
| 2 | 轮回系统 | 纪元阶段、轮回循环、遗产机制 | Epic 1 | 12-15 |
| 3 | 魔王系统MVP | 虚无之主+瘟疫母神 | Epic 2 | 10-12 |
| 4 | AI集成 | LLM API、对话系统、后备事件池 | Epic 1 | 15-18 |
| 5 | UI/UX | 控制面板、状态显示、配置界面 | Epic 1 | 8-10 |
| 6 | 扩展魔王 | 其余8个魔王 | Epic 3 | 20-25 |
| 7 | 打磨优化 | 性能、平衡、Bug修复 | All | 10-15 |

### Recommended Sequence

```
Epic 1 (核心框架) → Epic 2 (轮回系统) → Epic 3 (魔王MVP) + Epic 4 (AI集成) → Epic 5 (UI) → MVP发布 → Epic 6 (扩展) → Epic 7 (打磨)
```

### Vertical Slice (MVP)

**首个可玩里程碑：** Epic 1-5 完成后
- 完整轮回循环
- 1-2个魔王（虚无之主+瘟疫母神）
- 基础AI对话 + 后备事件池
- 核心UI面板

---

## Success Metrics

### Technical Metrics

| 指标 | 目标 | 测量方法 |
|------|------|----------|
| 帧率稳定性 | 与WorldBox原版一致 | 性能监控 |
| LLM响应时间 | <5秒（95%） | API日志 |
| 崩溃率 | <1% | 错误报告 |
| 加载时间 | <10秒 | 计时器 |

### Gameplay Metrics

| 指标 | 目标 | 测量方法 |
|------|------|----------|
| MOD下载量 | 首月1000+ | 平台统计 |
| 社区反馈 | 80%+好评 | 评论分析 |
| 平均轮回次数 | 3+轮回/玩家 | 游戏内统计 |
| Bug报告响应 | 48小时内 | Issue追踪 |

### Qualitative Success Criteria

- 玩家描述体验时使用"独特"、"AI真的很聪明"等词汇
- 社区自发分享有趣的轮回故事
- 玩家主动推荐给其他WorldBox玩家
- 评论提及LLM交互和轮回系统

### Metric Review Cadence

- **周度：** 检查崩溃率和Bug报告
- **月度：** 分析下载量和社区反馈趋势
- **版本发布后：** 全面指标回顾

---

## Out of Scope

**v1.0 不包含：**
- 其余8个魔王（MVP仅含虚无之主+瘟疫母神）
- 移动端/主机端
- 多语言支持（首发仅中文）
- 多人游戏模式
- 自定义魔王编辑器

### Deferred to Post-Launch

- 剩余8个魔王的实现
- 英文本地化
- Steam创意工坊集成
- 高级AI交互模式

---

## Assumptions and Dependencies

### Key Assumptions

- WorldBox保持NeoModLoader兼容性
- LLM API（OpenAI/Claude等）保持可用且成本可控
- Solo开发者业余时间可维护
- 玩家愿意配置API密钥

### External Dependencies

- **WorldBox 0.51.2+** - 基础游戏
- **NeoModLoader** - MOD加载框架
- **LLM API服务** - 玩家自备密钥
- **C#/.NET运行时** - Unity环境

### Risk Factors

- WorldBox版本更新可能破坏MOD兼容性
- LLM API成本变化影响玩家体验
- 单人开发进度风险

---

## Document Information

**Document:** 纪元之轮：魔王轮回 - Game Design Document
**Version:** 1.0
**Created:** 2026-01-17
**Author:** 吴旭
**Status:** Complete

### Change Log

| Version | Date | Changes |
|---------|------|----------|
| 1.0 | 2026-01-17 | Initial GDD complete |
