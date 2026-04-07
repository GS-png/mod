<!--
Sync Impact Report
- Version change: 1.1.0 -> 1.2.0
- Modified principles:
  - II. API & DLL First -> II. Real Runtime First
  - III. Plan Against Full Scope -> III. Plan Against Full Scope & Rewrite Map
- Added sections:
  - Principle VII. Rewrite by Seam Map, Not Blind Demolition
- Removed sections:
  - None
- Templates requiring updates:
  - ✅ .specify/templates/plan-template.md
  - ✅ .specify/templates/spec-template.md
  - ✅ .specify/templates/tasks-template.md
  - ✅ .specify/templates/checklist-template.md
  - ✅ .specify/templates/constitution-template.md
  - ✅ AGENTS.md reviewed; no textual update required
  - ✅ .specify/templates/commands/ not present; no action required
- Follow-up Items:
  - None
-->
# EraWheel Constitution

## Core Principles

### I. Design Directory Is Source of Truth
- `设计/` 目录是本项目已批准内容的总权威来源。`设计/EraWheel_Redesign.md`、`设计/ERRE附属文档/*.md` 和 `设计/美术资源/` 一起定义玩法、数据、字段口径和资源范围。
- 只要内容已经写进 `设计/`，就默认属于首版交付范围。`spec.md`、`plan.md`、`tasks.md` 只能把这些内容拆成可执行工作，MUST NOT 私自删减、弱化或改成“以后再做”。
- 如果确实要排除、延期或改写 `设计/` 里的内容，贡献者 MUST 先修改对应设计文档并留下批准依据，然后才能改实现计划。
- 理由：这就像施工图已经盖章，现场施工可以分工，但不能擅自把客厅砌没了。

### II. Real Runtime First
- 改玩法代码前，贡献者 MUST 同时查看三类证据：`api/` 文档、当前 `EraWheel/src/` 里的现有接入点、以及必要时的 DLL/反编译结果。禁止只看设计稿就直接改实现。
- 只要设计涉及生成单位、挂王国、战斗、施法、命中、死亡、轮询特效、存档、UI 路由或资源加载，计划里 MUST 写出真实入口和调用链路径。
- 当前仓库至少已验证以下游戏链路可作为权威锚点：`MapBox.spawnNewUnit`、`Actor.joinKingdom`、`Actor.setKingdom`、`Actor.tryToAttack`、`CombatActionLibrary.tryToCastSpell`、`MapBox.applyAttack`、`Actor.checkCallbacksOnDeath`、`Actor.checkActionsFromAllMetas`。
- 如果 `api/` 文字说明和真实运行结果冲突，贡献者 MUST 继续追到当前游戏版本对应的 DLL 或可复现运行结果，再更新设计或计划，不能靠猜测加兜底。
- 理由：重构 MOD 不是重新发明游戏规则，而是重新接线。先找到总闸、分线盒和回路图，才不会一通拆墙把整屋电都剪断。

### III. Plan Against Full Scope & Rewrite Map
- 任务只要满足以下任一条件就 MUST 先写执行计划：步骤不少于 3 个、需要改多个文件、涉及结构调整、需求不清楚、或需要定位根因。
- 改文件前，贡献者 MUST 先查看目录树，并把本次涉及的 `设计/` 主文档、附属文档、资源目录、代码、模板、测试和配置全部列出来，再说明波及范围。
- 计划里 MUST 明确写出完整交付范围、实现顺序、权威来源、验证证据，以及哪些模块之间需要联调。执行顺序可以分先后，但交付目标不能缩水成半成品。
- 只要属于“彻底重构”“推倒重来”或大规模删旧代码，计划里 MUST 额外附上替换映射表，至少写清旧入口文件、对应游戏钩子、存档键、配置项、资源目录和新归属模块。
- 理由：先看整套装修图再排工序，才不会只装好了厨房就说房子能住了。

### IV. Newbie-Friendly Docs & Comments
- 面向仓库协作的说明、规格、计划和交付总结 MUST 使用中文，表达要直白，第一次出现的专业词必须顺手解释清楚。
- 每个函数或方法的注释 MUST 说明“做什么、传入什么、返回什么”。复杂逻辑 MUST 分步解释目的。配置注释 MUST 说明参数含义和可选值。
- 文档段落 MUST 短而具体，避免空话和套话。同一概念第一次出现时就要说完整，不能把关键定义拆散到多个章节。
- 理由：这套仓库不是只给熟手看的，写清楚就是把脑子里的隐性经验变成别人能直接接手的明牌。

### V. Verification, Sync, and Release Gates
- 每次行为改动 MUST 在编码前写验证方案，在完成前补验证结果。能稳定自动验证的内容优先补自动化测试；不适合自动化时，MUST 写可执行的手动验证步骤和预期结果。
- 每次改动 MUST 在同一轮里同步所有受影响产物，包括代码、规格、设计文档、模板、注释、资源登记和测试。留下过期文档、漏接资源或漏改配置，视为评审不通过。
- Bug 修复和功能实现都 MUST 给出集成验证，不只证明单点能跑，还要证明它和现有阶段推进、存档、资源、数据表不会互相打架。
- 理由：只单测一个零件像只试车门把手，整车能不能上路还得看发动机、刹车和线路有没有一起装对。

### VI. Full Release, No Placeholders
- 第一版可游玩发布 MUST 覆盖 `设计/` 中已批准的完整内容，包括玩法流程、名册条目、数值表、资源、交互表现和必要的验收文档。
- 首版验收 MUST NOT 接受占位逻辑、占位资源、空条目、临时猜测数值、`TODO`、`以后补做`、`二期再加`、或“先能跑再说”的临时方案。
- 内部实现可以按模块分步推进，但对外宣称完成、可上架、可游玩之前，所有已批准范围都 MUST 已集成、联调、验证并可实际游玩。
- 理由：端上桌的菜要是全菜，不是先上一盘半熟食材再告诉玩家下次补炒。

### VII. Rewrite by Seam Map, Not Blind Demolition
- 当现有结构已经挡住正确实现时，贡献者 MAY 发起彻底重构，甚至删除旧模块重做；但删除前 MUST 先列出“这段旧代码到底接着游戏哪条线”。
- 替换映射至少要覆盖：启动入口、Harmony/世界钩子、运行时服务、UI 窗口与 HUD、存档读写、配置导入导出、本地化、资源目录、测试和发布闸门。
- 未找到真实接缝、未确认新旧语义等价、或未说明破坏兼容的影响前，贡献者 MUST NOT 批量删除旧实现。
- 重构完成的标准不是“旧文件删干净了”，而是“游戏底层接线已重新接好，设计范围已重新落地，验证结果说明新结构比旧结构更清楚、更稳”。
- 理由：旧房翻修可以整屋重来，但也得先摸清承重墙和水电走向，不然拆得越猛，返工越大。

## Engineering Constraints
- 项目当前目标平台是 `WorldBox 0.51.2+` 与 `NeoModLoader`。除非经过明确批准的规格变更，否则新设计 MUST 保持这个兼容范围。
- 玩法字段名、方法名、触发链路和模板假设 MUST 对齐 `api/` 文档或已验证的 DLL 行为。若实现包含 MOD 自定义扩展，改动 MUST 明确区分“原版复用”和“MOD 新增”。
- 涉及单位生成、敌我判定和战斗回调的实现，默认 MUST 先对照 `MapBox.spawnNewUnit`、`Actor.joinKingdom`/`setKingdom`、`Actor.tryToAttack`、`CombatActionLibrary.tryToCastSpell`、`MapBox.applyAttack`、`Actor.checkCallbacksOnDeath`、`Actor.checkActionsFromAllMetas` 这些已核对路径；若改走别的入口，必须给出证据。
- 设计规则、参数定义、名册条目和玩法边界 MUST 与 `设计/` 下对应权威文档保持一致。若某个主题要移动到新的权威文件，贡献者 MUST 在同一次改动里更新归属表和实际内容。
- `设计/美术资源/` 中已列出的资源视为实现范围的一部分。若实现暂未接入某个资源，状态必须是“未完成”，而不是把首版标准降成允许占位图。
- 涉及存档状态、阶段推进、参数口径的改动都视为兼容性敏感改动。若必须破坏兼容，`spec.md`、`plan.md` 和验证步骤 MUST 明确写出影响。
- 彻底重构时，`EraWheel/mod.json` 的模组身份、`NeoModLoader` 加载契约、发布目录结构和 README 中声明的构建/验证闸门，默认视为稳定外部接口；若要调整，必须先在规格和计划里说明影响。

## Workflow & Quality Gates
1. 规则、参数或范围发生变化时，先更新对应的权威设计文档，再开始实现。
2. 如果任务属于重构或删旧重做，先整理运行接缝清单，再决定哪些旧文件能删、哪些必须先保留作对照。
3. 改动影响用户可见行为、玩法规则或验收边界时，MUST 先创建或更新 `spec.md`，并把相关 `设计/` 文档、附属文档、资源目录映射到需求里。
4. `spec.md` 默认 MUST 以完整首版为目标。若存在不做项，必须写明批准依据；未写依据时，`Out of Scope` 必须为 `None`。
5. 多步骤实现 MUST 先写 `plan.md`，并在 `Constitution Check` 里填清楚完整范围、权威来源、受影响产物、替换映射、联调风险和验证方案。
6. 只有当方案已经具体、边界已经明确、且不存在“以后补”的灰区时，才能生成 `tasks.md`。任务列表 MUST 覆盖代码、数据、资源接入、删旧迁移、文档同步、验证和上架前检查。
7. 提交前或交接前，执行计划中的验证步骤，并确认每个被修改的概念仍然只有一个权威位置，且没有遗留占位项。

## Governance
- 本宪章高于仓库中与 Spec Kit、设计更新、实现评审相冲突的临时习惯。
- 任何修订都需要在同一次改动里完成三件事：更新本文件、同步所有受影响模板或指导文件、并在本文件顶部的 Sync Impact Report 解释版本号变化。
- 版本号遵循语义化规则：MAJOR 用于删除或重定义原则，MINOR 用于新增原则或明显扩展规则，PATCH 用于不改变执行要求的澄清和措辞修订。
- 每次规格、计划、任务清单和实现交付都 MUST 做合规检查。检查项至少包括：`设计/` 覆盖完整性、权威来源、波及范围同步、验证证据、文档清晰度、无占位交付。

**Version**: 1.2.0 | **Ratified**: 2026-03-17 | **Last Amended**: 2026-04-05
