# AGENTS
本文件不是建议，而是执行协议。执行任务时，agent 必须先完成“必要确认”“实现前确认门禁”，获得用户确认后再实现；实现时必须遵守“实现中约束门禁”；实现完成之后必须完成“交付检查门禁”。按照输出模板输出，缺任一环节视为任务未完成。

## 1.必要确认

先确认必要边界；规则冲突时优先具体、贴近任务且更安全的规则；触及安全、用户改动、不可逆数据或权限边界时优先保护，无法调和则停止并说明原因。
- **保护用户改动**：动代码前先确认工作区状态，禁止覆盖、回退、删除或清理任何未授权改动；发现已有改动时必须先区分用户改动与当前任务改动，再继续操作。
- **先明边界，再动代码**：任务开始前先确认范围、入口、影响和必要上下文；风险越高，检查、实现和验证越严格。
- **显式假设，歧义停问**：不确定时先说明假设、歧义和取舍；不能确认边界或意图时停止实现并请求澄清，不得默默选择一种解释继续执行。
- **证据优先，源头可追溯**：判断、结论、改动和验证结果必须有可追溯证据；证据不足标未知，不猜测、不编造、不伪造。
- **按需命中，精准读取**：根据任务本质和影响范围读取第6节任务与工程规范路由文件；命中什么读什么，命中多项全部读，不做无关扩展。
- **语言**：所有内容输出和描述必须以用户能感知视角，用用户能理解的大白话中文；不得用术语堆叠、抽象黑话或含糊表达替代具体说明。

## 2.实现前确认门禁

1. 影响面必须清楚；受影响的文件、符号、调用方、入口、配置、测试、文档不清，不得改动。
2. 使用 GitNexus mcp 定位入口、调用链和影响面；结论必须以源码、测试、配置和命令输出为准；未使用时说明原因。
3. 任务类型必须清楚；不清时，只允许提出最小阻塞澄清，不得带着不确定性实现。
4. 改动性质必须先定；新增、修复、重构与替换、统一、移除、收敛必须区分清楚。
5. 能通过收敛既有结构解决，就不得新增包装层、兼容层、分支、旁路或并行实现。
6. 涉及替换、统一、移除、收敛，必须先定权威路径和旧路径收口方案，并明确旧路径删除、废弃或保留策略。
7. 同一业务事实、状态、规则、流程只能有一个权威来源；不得引入影子状态、重复判断、并行实现或冲突逻辑。
8. 变更必须落在正确 owner、模块、领域；是否新建文件、目录、模块，以语义归属和职责边界为准，不以少建文件为准。
9. 复用必须让结构更收敛；不能收敛的复用，不得采用。
10. 已有稳定实现可承接，且增强后仍语义一致、归属清晰、职责不混杂时，优先在原体系内增强。
11. 出现两个及以上明确复用点，且边界稳定、语义稳定、owner 清晰、提取后复杂度下降时，必须提取公共能力。
12. 公共能力只在当前任务范围内已能明确证明成立时提取；不得为未来假设提前抽象。
13. 强行复用会导致包装增加、依赖扭曲、职责混杂或边界污染时，必须拆到独立文件或模块。
14. 形成独立领域概念、独立流程、独立状态或独立测试边界时，必须拆分。
15. 实现必须减少复杂度，不得把问题从核心逻辑转移到包装层、调用侧、配置侧、兼容分支或辅助代码。
16. 需求意图、用户可感知行为、触发条件、预期结果、验收标准和验证方式必须明确；正确性以行为满足验收为准。
17. 涉及关键流程、状态变化、异常处理、外部调用、异步任务或数据写入时，先明确是否需要日志；日志点、级别、关键字段和脱敏规则不清，不得实现。
18. 思考是否需要 TDD，需要时，先写失败测试，再用最小实现通过；重构不得破坏既有行为。
19. 输入、权限、资源访问、数据修改、副作用、并发、一致性、失败影响和恢复边界不清，不得实现。

## 3.实现中约束门禁

1. 安全是默认约束，不是可选增强；未满足输入校验、权限控制、副作用边界、失败一致性和敏感数据保护的实现，不得采用。
2. 性能是默认约束，不是事后优化；不得引入明显不必要的时间复杂度、空间占用、重复计算、无界扫描、无界并发或额外 I/O。
3. 只允许最小正确解；代码只解决当前明确需求，必须直接、必要、可验证。
4. 不得加入未确认能力、提前抽象、无必要配置、扩展点、兼容层、容错分支或复杂流程。
5. 能在权威路径解决，就不得包外层。
6. 不得用补丁、包装、兼容层、旁路、叠加、特殊分支或并行实现转移问题。
7. 修改必须让结构更收敛，而不是层次更多、路径更多、状态更多。
8. 同一业务事实、状态、规则、流程只允许一个权威来源；禁止影子状态、重复判断、循环依赖、隐式状态和冲突分支。
9. 相关逻辑必须落在明确职责边界内；模块之间只通过必要、稳定、清晰的接口协作。
10. 不得职责混杂、跨层依赖、跨领域泄漏、隐式共享状态或引发修改连锁扩散。
11. 只允许采用能让结构更收敛的复用；不得通过包装、适配层或桥接层伪复用。
12. 已有稳定实现可承接时，必须优先在原体系内增强；不得重写同义影子实现。
13. 出现两个及以上明确复用点，且语义与边界稳定、提取后复杂度下降时，必须提取公共能力。
14. 形成独立领域概念、独立流程、独立状态或独立测试对象时，必须拆分，不得继续堆进旧文件。
15. 复用导致层次增加、路径增加、状态增加或依赖更乱，默认视为实现退化。
16. 新增包装、额外兼容、特殊分支、重复流程、辅助桥接、影子状态、旁路兜底，默认视为退化；无明确证据证明其为唯一合理方案时，不得采用；diff 一旦漂成包装、分支、兼容层、覆盖层或并行实现，必须立即停止并重设方案。
17. 只做手术式变更；只改当前任务所必需内容，不得顺手重构、格式化、改写或清理无关代码。
18. 手术式变更不等于只改主代码；凡属受影响的契约、配置、测试、文档，必须同步收口。
19. 默认外部输入、权限、资源访问和副作用都可能被滥用；必须显式校验、最小权限、默认拒绝、敏感数据不泄露。
20. 不得静默吞异常，不得留下状态不明的半成功结果。
21. 重试、回滚、降级或补偿只用于业务或可靠性所需，不得作为规避核心修正的外层补丁。
22. 关键代码必须明确职责边界、输入输出边界、数据修改边界和失败影响范围；重复执行结果必须可预期；并发执行时状态必须一致。
23. 接口契约、数据结构、状态流转、业务规则必须清晰、稳定、可追踪；数据在模块、接口、存储、缓存、消息和前后端之间含义必须一致。
24. 关键路径必须可观测；该有日志的地方不得缺日志，默认结构化。只记关键节点，不记流水账；必须能定位问题。严禁记录敏感数据；输出前必须脱敏。
25. 注释只写代码无法清楚表达的意图、约束和关键原因，并随代码同步更新。
26. 所有说明、规则和文档默认用中文；表达必须短句、直接、可执行。

## 4.交付检查门禁

1. 实现前后的改动性质必须一致。
2. 凡涉及替换、移除、统一、收敛，必须真实完成旧路径收口，不得伪装成兼容或并行实现。
3. 若 diff 主要表现为新增包装、增加分支、保留旧逻辑、添加辅助层，而不是权威路径收敛和旧路径处理，必须重审实现方式。
4. 新增代码若未带来明确边界、职责收敛或旧路径清理，默认不是好实现。
5. 实现必须回到权威路径；新路径替代旧路径时，必须完成迁移闭环。
6. 旧路径未删除、废弃或给出保留证据，不得交付；该删的删，该废弃的废弃；必须保留的，给出明确证据和原因。
7. 相关代码、依赖、配置、测试、文档和调试残留必须同步清理。
8. 新增逻辑必须仍在正确 owner、模块、领域内。
9. 受影响的权威来源、依赖关系和验证入口必须全部同步修改。
10. 代码、契约、数据、配置、测试、文档、注释必须一致；不得留下新旧逻辑并存、状态不一致或验证断裂。
11. 入口、调用方、约束、配置、文档、测试和验证链路必须回查完整；不得留下遗漏引用、失效路径或行为回归。
12. 交付不只看能跑，还要看是否更短、更直、更少层、更少路径、更少状态源。
13. 若只是把复杂度外移，而不是消除复杂度，不得视为完成。
14. 安全敏感路径不得无证据交付；涉及输入处理、权限、数据写入、外部调用、认证鉴权、敏感数据或副作用操作时，必须给出安全依据、验证结果或无法验证原因。
15. 性能敏感路径不得无证据退化；涉及热路径、大数据量、高频调用或额外 I/O 时，必须给出性能依据、验证结果或无法验证原因。
16. 实现必须让职责更清晰、归属更清楚、复用更自然、维护成本更低；能用但更乱、更绕、更难维护，不得交付。
17. 必须验证关键日志真实可见、字段正确、级别合理。关键路径缺日志、日志无法定位问题、无法关联请求或未脱敏，不得交付。
18. 必须运行与风险匹配的测试、类型检查、lint、构建或手动验证；验证未通过不得交付。
19. 验证未通过，或无法说明为什么不能验证，不得交付；无法验证时，必须说明原因、未验证范围和剩余风险；交付时必须给出简洁证据和剩余风险。

## 5.输出模板

实现前确认模板：
1. 我理解的需求：用大白话复述用户想要的最终状态。
2. 我不会做的内容：明确不会顺手修改、扩展、重构或清理的范围。
3. 我准备怎么做：只写必要步骤，不写长篇理论。
4. 怎么判断完成：用用户能检查的方式列出验收标准。
5. 影响面：文件、符号、入口、同步项。
6. 定位与证据：GitNexus 结果和权威依据。
7. 实现路径：权威路径<本次必须落回的权威路径>；旧路径策略<删除 / 废弃 / 保留，及原因>；架构落点<继续修改现有 owner / 新建文件、文件夹、模块，及原因>；复用判断<沿用既有实现 / 小幅增强 / 提取公共能力 / 必须拆分，及原因>。
8. 中阶段约束：收敛要求、安全要求、性能要求。
9. 验证计划：是否需要 TDD/BDD/回归测试，验证方式和覆盖范围。
10. 不确定点：不能确认的内容必须直接标出，不得猜测执行。

交付输出模板：
1. 结论：一句话说明是否完成
2. 命中的规范：第6节命中的任务与工程规范
3. 实现摘要：改动性质、实现路径、复用与拆分
4. 实现与收口：已修改、已收口、已同步、未处理
5. 验证：已运行、未运行、安全验证、性能验证、验证结论
6. 剩余风险：未知项、风险和后续建议

## 6.任务规范与工程规范路由

任务本质与必读规范：
- 缺陷修复`.agents/tasks/bugfix.md`
- 既有能力增强`.agents/tasks/existing-enhancement.md`
- 实现替换`.agents/tasks/implementation-replacement.md`
- 行为变更`.agents/tasks/behavior-change.md`
- 新增能力`.agents/tasks/new-capability.md`
- 架构迁移`.agents/tasks/architecture-migration.md`
- 配置环境发布`.agents/tasks/config-env-release.md`
- 重构清理`.agents/tasks/refactor-cleanup.md`
- 纯文档修改`.agents/tasks/docs-only.md`
- 审查评估`.agents/tasks/review.md`

工程影响领域与必读规范：
- 边界划分`.agents/engineering/architecture-boundaries.md`
- 正确性与失败处理`.agents/engineering/correctness-failure-handling.md`
- 数据契约与迁移`.agents/engineering/data-schema-migration.md`
- 隐私与权限`.agents/engineering/privacy-permissions.md`
- 安全防护`.agents/engineering/security-protection.md`
- 性能资源并发`.agents/engineering/performance-resource-concurrency.md`
- 测试验证`.agents/engineering/testing-verification.md`
- 依赖环境发布`.agents/engineering/dependencies-env-release.md`
- 文档可观测性`.agents/engineering/docs-comments-observability.md`
- 日志与可观测性`.agents/engineering/logging-observability.md`
- 工作区命令安全`.agents/engineering/workspace-command-safety.md`

## 7.项目事实模板

| 项目 | 内容 |
|---|---|
| 项目名称 | `<填写真实名称>` |
| 项目类型 | `<填写真实类型>` |
| 主要语言/运行时 | `<填写真实版本>` |
| 包管理器 | `<填写>` |
| 数据存储 | `<填写或 None>` |
| 部署环境 | `<填写或未知>` |
| 代码生成来源 | `<填写或 None>` |

<!-- gitnexus:start -->
# GitNexus — Code Intelligence

This project is indexed by GitNexus as **游戏ui设计** (721 symbols, 1277 relationships, 60 execution flows). Use the GitNexus MCP tools to understand code, assess impact, and navigate safely.

> If any GitNexus tool warns the index is stale, run `npx gitnexus analyze` in terminal first.

## Always Do

- **MUST run impact analysis before editing any symbol.** Before modifying a function, class, or method, run `gitnexus_impact({target: "symbolName", direction: "upstream"})` and report the blast radius (direct callers, affected processes, risk level) to the user.
- **MUST run `gitnexus_detect_changes()` before committing** to verify your changes only affect expected symbols and execution flows.
- **MUST warn the user** if impact analysis returns HIGH or CRITICAL risk before proceeding with edits.
- When exploring unfamiliar code, use `gitnexus_query({query: "concept"})` to find execution flows instead of grepping. It returns process-grouped results ranked by relevance.
- When you need full context on a specific symbol — callers, callees, which execution flows it participates in — use `gitnexus_context({name: "symbolName"})`.

## Never Do

- NEVER edit a function, class, or method without first running `gitnexus_impact` on it.
- NEVER ignore HIGH or CRITICAL risk warnings from impact analysis.
- NEVER rename symbols with find-and-replace — use `gitnexus_rename` which understands the call graph.
- NEVER commit changes without running `gitnexus_detect_changes()` to check affected scope.

## Resources

| Resource | Use for |
|----------|---------|
| `gitnexus://repo/游戏ui设计/context` | Codebase overview, check index freshness |
| `gitnexus://repo/游戏ui设计/clusters` | All functional areas |
| `gitnexus://repo/游戏ui设计/processes` | All execution flows |
| `gitnexus://repo/游戏ui设计/process/{name}` | Step-by-step execution trace |

## CLI

| Task | Read this skill file |
|------|---------------------|
| Understand architecture / "How does X work?" | `.claude/skills/gitnexus/gitnexus-exploring/SKILL.md` |
| Blast radius / "What breaks if I change X?" | `.claude/skills/gitnexus/gitnexus-impact-analysis/SKILL.md` |
| Trace bugs / "Why is X failing?" | `.claude/skills/gitnexus/gitnexus-debugging/SKILL.md` |
| Rename / extract / split / refactor | `.claude/skills/gitnexus/gitnexus-refactoring/SKILL.md` |
| Tools, resources, schema reference | `.claude/skills/gitnexus/gitnexus-guide/SKILL.md` |
| Index, status, clean, wiki CLI commands | `.claude/skills/gitnexus/gitnexus-cli/SKILL.md` |

<!-- gitnexus:end -->
