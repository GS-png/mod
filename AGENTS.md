# AGENTS 任务执行规范

## 1 最小必要确认

先确认必要边界；规则冲突时优先具体、贴近任务且更安全的规则；触及安全、用户改动、不可逆数据或权限边界时优先保护，无法调和则停止并说明原因。

- **保护用户改动**：动代码前先确认工作区状态，禁止覆盖、回退、删除或清理任何未授权改动；发现已有改动时必须先区分用户改动与当前任务改动，再继续操作。
- **先明边界，再动代码**：任务开始前先确认范围、入口、影响和必要上下文；风险越高，检查、实现和验证越严格。
- **显式假设，歧义停问**：不确定时先说明假设、歧义和取舍；不能确认边界或意图时停止实现并请求澄清，不得默默选择一种解释继续执行。
- **证据优先，源头可追溯**：判断、结论、改动和验证结果必须有可追溯证据；证据不足标未知，不猜测、不编造、不伪造。
- **按需命中，精准读取**：根据任务本质和影响范围读取相关任务、工程规范；命中什么读什么，命中多项全部读，不做无关扩展。

## 2 实现前门禁

- owner、调用路径、跨模块关系和影响面使用 Graphify 定位线索，先看 `graphify-out/GRAPH_REPORT.md`，有 wiki 优先看 wiki；跨模块关系优先用 `graphify query "<question>"`、`graphify path "<A>" "<B>"`、`graphify explain "<concept>"`，会遍历图谱中的 EXTRACTED 和 INFERRED 边。
- 使用GitNexus mcp工具分析代码影响面，查询代码图谱，查看概念、符号上下文、上下游影响、调用方和相关执行流，只能作为定位线索，最终判断必须回到源码、测试、配置和命令输出确认。
- **DDD 领域归属建模**：代码应按业务领域归属组织，让业务概念、规则和状态变化有明确边界，围绕真实业务概念组织代码，避免职责混杂、跨领域泄漏和贫血式过程代码。
- **高内聚、低耦合**：相关逻辑应集中在明确职责边界内，模块之间只通过必要、稳定、清晰的接口协作，避免职责混杂、跨层依赖、隐式共享状态和修改连锁扩散。
- **沿用权威路径，谨慎复用抽象**：实现前先确认既有实现的领域归属、职责边界和契约是否适配；适配时优先在既有体系内小范围复用或扩展，不适配时不得强行沿用；只有稳定复用需求、清晰契约和低耦合维护边界成立时，才提取公共能力，没有明确时，不提前抽象。
- **保持单一真相与单一路径**：同一业务事实、状态、规则和流程必须有明确权威来源，避免产生影子状态、并行实现、重复判断、循环依赖、隐式状态和相互冲突的逻辑分支，确保行为一致、边界清楚、维护可控。
- **PDD 提示驱动开发**：实现前先明确需求意图、任务边界、上下文证据、约束条件和验收标准；再拆解执行步骤，按规格执行，实现结果必须能被规格和验证结果确认。。
- **BDD 行为驱动开发**：实现前先明确用户可感知的业务行为、触发条件和预期结果；代码必须围绕行为完成，正确性以行为是否满足验收为准，并通过测试或可执行规格验证。
- **TDD 测试驱动开发**：实现或修改代码前，先明确可验证行为并编写能失败的测试；再用最小实现让测试通过；重构必须保持测试通过，避免无验证实现、过度实现和改坏既有行为。

## 3 实现与收口

- **简洁优先**：代码只解决当前明确需求，采用直接、必要、可验证的实现；不添加未确认能力，不提前抽象，不引入无必要的配置、扩展点、容错分支或复杂流程；实现复杂度必须匹配问题规模，发现过度设计时必须简化，避免臃肿。
- **手术式变更**：只修改完成当前任务所必需的内容；不得顺手重构、格式化、改写或清理无关代码；发现无关问题可以说明，但不得擅自处理。
- **同步修改**：变更必须覆盖所有受影响的权威来源、依赖关系和验证入口，确保代码、契约、数据、配置、测试和文档保持一致；不得只改局部而留下新旧逻辑并存、状态不一致或验证断裂。
- **收口同步**：新路径替代旧路径时必须完成迁移闭环，及时删除、废弃旧路径；并同步清理所有受影响的代码、依赖、配置、测试、文档和调试残留，避免新旧路径并存、重复逻辑和孤儿内容继续污染系统。
- **引用复查**：改动完成后必须回查受影响的引用、依赖和验证链路，确认相关入口、调用方、约束、配置、文档和测试保持一致，不留下遗漏引用、失效路径或行为回归。
- **验证收口**：运行与风险匹配的测试、类型检查、lint 或构建；无法运行时说明原因和剩余风险。

## 4 交付说明

- 命中的任务规范和工程规范；owner、边界和权威路径；主要变更或审查结论；已运行的验证；未验证项、剩余风险、回滚方式和未知项。

## 5. 执行底线

- **代码安全优先**：写代码时默认外部输入、权限边界、资源访问和副作用操作都可能被滥用，必须以纵深防御、显式校验、最小权限、默认拒绝、敏感数据不泄露、依赖受约束、错误不扩散、变更有测试为基本原则。
- **失败显式可恢复**：关键流程失败时不得静默吞掉异常、不得留下状态不明的半成功结果；必须明确返回错误、保留必要上下文、保持状态一致，并在可恢复场景提供重试、回滚、降级或补偿路径。
- **边界、幂等、并发明确**：关键代码必须明确职责边界、输入输出边界、数据修改边界和失败影响范围；重复执行时结果应可预期；并发执行时状态必须一致，避免职责失控、重复副作用和并发状态错乱。
- **契约与数据一致**：代码必须维护清晰稳定的接口契约、数据结构、状态流转和业务规则，确保数据在模块、接口、存储、缓存、消息和前后端之间含义一致、状态一致、变更可追踪。
- **中文优先，简洁高效**：所有说明、规则和文档默认用中文；表达要短句、直白、可执行，明确“何时触发、做什么、在哪做、怎么验证、例外如何处理”；删除空话、口号、重复和模糊描述，保留必要边界，不因简短牺牲准确性。
- **必要注释，代码同步**：注释补充代码本身无法清楚表达的意图、约束和关键原因；必须准确、简洁、可验证，并随代码同步更新；不得用注释替代清晰代码，也不得保留过时、未实现或误导性说明。

## 6. 任务规范路由

| 任务本质 | 必读规范 |
|---|---|
| 缺陷修复 | `.agents/tasks/bugfix.md` |
| 既有能力增强 | `.agents/tasks/existing-enhancement.md` |
| 实现替换 | `.agents/tasks/implementation-replacement.md` |
| 行为变更 | `.agents/tasks/behavior-change.md` |
| 新增能力 | `.agents/tasks/new-capability.md` |
| 架构迁移 | `.agents/tasks/architecture-migration.md` |
| 配置环境发布 | `.agents/tasks/config-env-release.md` |
| 重构清理 | `.agents/tasks/refactor-cleanup.md` |
| 纯文档修改 | `.agents/tasks/docs-only.md` |
| 审查评估 | `.agents/tasks/review.md` |

## 7. 工程规范路由

| 影响领域 | 必读规范 |
|---|---|
| 架构边界 | `.agents/engineering/architecture-boundaries.md` |
| 正确性与失败处理 | `.agents/engineering/correctness-failure-handling.md` |
| 数据契约与迁移 | `.agents/engineering/data-schema-migration.md` |
| 安全隐私权限 | `.agents/engineering/security-privacy-permissions.md` |
| 性能资源并发 | `.agents/engineering/performance-resource-concurrency.md` |
| 测试验证 | `.agents/engineering/testing-verification.md` |
| 依赖环境发布 | `.agents/engineering/dependencies-env-release.md` |
| 文档可观测性 | `.agents/engineering/docs-comments-observability.md` |
| 工作区命令安全 | `.agents/engineering/workspace-command-safety.md` |

## 8. 项目事实模板

项目事实未填写视为“未知”，不得猜测。

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

This project is indexed by GitNexus as **mod** (5383 symbols, 17341 relationships, 300 execution flows). Use the GitNexus MCP tools to understand code, assess impact, and navigate safely.

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
| `gitnexus://repo/mod/context` | Codebase overview, check index freshness |
| `gitnexus://repo/mod/clusters` | All functional areas |
| `gitnexus://repo/mod/processes` | All execution flows |
| `gitnexus://repo/mod/process/{name}` | Step-by-step execution trace |

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
