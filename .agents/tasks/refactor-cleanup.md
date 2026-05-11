# Task：重构或清理

## 1. 触发条件

当任务目标是改善结构、可读性、模块化、命名、重复或清理，且不应改变外部行为时使用。

如果行为改变，也读取 `.agents/tasks/behavior-change.md`。
如果替换实现，也读取 `.agents/tasks/implementation-replacement.md`。
如果迁移架构，也读取 `.agents/tasks/architecture-migration.md`。

总是同时读取：

- `.agents/engineering/architecture-boundaries.md`
- `.agents/engineering/testing-verification.md`
- `.agents/engineering/workspace-command-safety.md`

按触达领域额外读取 correctness、data、security、performance、dependency、docs 规则。

## 2. 目标

在保持外部行为不变的前提下改善内部结构，并降低未来维护风险。

## 3. 必查项

变更前识别：

- 必须保持的当前行为。
- 保护行为的现有 tests。
- 实际要解决的 duplication、responsibility mixing 或 complexity。
- module boundaries 和 authority paths。
- 受影响 imports、callers、tests、docs、generated artifacts。

## 4. 设计规则

- Refactor 必须有明确目的。
- 不把无关 cleanup 混入 feature work，除非 feature 必须。
- 不无必要地大范围 rename、move、format。
- Preserve public contracts。
- Shared logic 保持单一 authority。
- 优先 incremental refactor，保证 tests 仍有意义。
- 没有真实当前调用方和清晰 owner 时，不新增抽象。
- 大规模格式化、codemod、批量 rename 应单独成任务或明确隔离。

## 5. 实现规则

- 只做 behavior-preserving changes。
- 随被移动代码一起移动 tests 或更新 imports。
- 删除 dead code 必须有证据：code search、tests 或项目约定。
- 只在必要时保留 compatibility exports，并写 deletion conditions。
- 避免 large diff noise。
- 不顺手改变错误文案、日志字段、排序、默认值、权限结果或响应结构。

## 6. 验证

验证：

- Affected area existing tests。
- imports / types 改动后的 build / typecheck / lint。
- 测试不足时 manual behavior check。
- cleanup 目标相关的 old imports 或 duplicate authorities 已移除。

## 7. 交付

```text
重构目的：<purpose>
行为保持：<what preserved>
移动 / 重命名 / 删除：<files and why>
验证：<tests/checks>
未做清理：<remaining cleanup>
回滚：<notes>
```
