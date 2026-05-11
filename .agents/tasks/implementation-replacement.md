# Task：既有实现替换

## 1. 触发条件

当任务替换内部实现方式，而预期外部行为基本不变时使用。

示例：

- 替换一个库。
- 替换 parser、cache、API client、storage layer、renderer、scheduler、algorithm、adapter。
- 从旧内部实现迁到新内部实现，但不改变用户可见行为。

总是同时读取：

- `.agents/engineering/architecture-boundaries.md`
- `.agents/engineering/testing-verification.md`
- `.agents/engineering/workspace-command-safety.md`

按触达领域额外读取 correctness、data、security、performance、dependency、release、docs 规则。

## 2. 目标

替换内部实现，同时避免旧新双权威、兼容缺口和未验证行为漂移。

## 3. 必查项

变更前识别：

- 当前 implementation owner。
- 必须保持稳定的 public contract。
- 所有 direct / indirect callers。
- 定义当前行为的 tests。
- 旧实现使用的数据、config、cache、generated code 或 external systems。
- error types、log fields、metrics、permission checks、retry behavior。
- performance、resource、concurrency assumptions。
- 旧新实现是否需要临时共存。

## 4. 替换类型

必须声明一种：

1. Drop-in replacement：同改动删除旧路径。
2. Adapter replacement：接口不变，内部依赖替换。
3. Compatibility migration：旧新路径短期共存。
4. Behavior-changing replacement：额外读取 `.agents/tasks/behavior-change.md`。

## 5. 实现替换 vs 架构迁移

- 只替换一个 owner 内部实现，调用方和 authority 基本不变：实现替换。
- 变更 authority path、模块边界、调用方向、目录职责，或需要迁移调用方 / 删除旧路径：架构迁移。
- 替换导致旧路径收口或调用方迁移时，同时读取 `.agents/tasks/architecture-migration.md`。

## 6. 设计规则

- 除非明确行为变更，否则保持 external contract。
- 保持单一 authority path。
- 旧新共存时必须定义 authority path、trigger conditions、data/cache compatibility、divergence detection、deletion condition。
- 不留下意外可达的旧实现。
- 不创建只掩盖设计冲突的 wrapper。
- 不静默改变 error semantics、retry behavior、permissions、data format。
- 替换依赖时，必须加载配置 / 依赖相关规范并更新 lockfiles。

## 7. 实现规则

- 更新所有 callers，或让它们通过选择的 authority 调用。
- 删除或明确废弃旧路径相关 stale files、flags、imports、tests、mocks、docs、config。
- Adapter boundary 保持窄。
- 涉及 generated code 时，更新 source specification 并 regenerate。
- 旧新短期共存时，尽量增加输出对比或 divergence 检测。

## 8. 验证

验证：

- Existing behavior compatibility。
- New implementation normal path。
- Old edge cases and failure cases。
- Error、logging、metrics、retry、timeout、permission behavior if touched。
- Migration / fallback path if coexist。
- 高风险替换时，用 representative fixtures 比较旧新输出。

## 9. 交付

```text
替换类型：<drop-in / adapter / compatibility / behavior-changing>
旧 authority：<old>
新 authority：<new>
调用方迁移：<summary>
旧路径清理 / 共存计划：<status>
兼容验证：<commands/results>
行为漂移风险：<remaining risk>
回滚：<notes>
```
