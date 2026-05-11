# Task：Bug 修复

## 1. 触发条件

当任务是修复错误行为、崩溃、回归、失败测试、错误结果、flaky behavior、集成故障或生产错误时使用。

总是同时读取：

- `.agents/engineering/testing-verification.md`
- `.agents/engineering/workspace-command-safety.md`

按触达领域额外读取 architecture、correctness、data、security、performance、dependency、docs 规则。

## 2. 目标

用最小安全改动修复已观察缺陷，同时保持既有预期行为。

## 3. 必查项

变更前识别：

- 实际观察到的失败。
- 期望行为。
- 暴露 bug 的入口。
- 最接近的 failing test、log、stack trace、issue 或 manual reproduction path。
- 从入口到失败行为的代码路径。
- 可见的近期相关变更。
- 不应改变的相邻行为。
- 如果是 flaky bug，说明复现稳定性和触发条件。

如果无法复现或无法从证据证明，只能说明“基于推断修复”。未验证前不得声称 bug 已修复。

## 4. 设计规则

- 优先 root-cause fix，不做表层补丁。
- 不添加掩盖真实问题的 broad fallback。
- 不改变修复缺陷以外的 public behavior。
- 除非正确行为就是忽略错误，否则不吞异常。
- 保持兼容，除非用户要求行为变更。
- 如果 bug 暴露重复逻辑，修复 authority path，并更新本次触达的重复逻辑。
- 不把 Bug 修复扩大成重构、优化或行为变更，除非根因需要；扩大时必须加载对应任务规范。

## 5. 实现规则

- Patch 保持窄。
- 可行时添加或更新 regression test。
- 无法添加测试时，记录 manual reproduction 和 verification path。
- 对未来诊断有帮助时，添加上下文错误信息。
- 避免无关格式、命名、依赖或架构变动。

## 6. 验证

最低验证：运行最具体 failing test 或 reproduction path；随后运行最小相关周边测试。

覆盖：

- 失败用例现在通过。
- 相邻正常行为仍工作。
- 相关边界 / 非法输入。
- 触达时的权限、数据、迁移路径。

## 7. 交付

```text
失败证据：<test/log/stack/repro/inference>
根因：<summary>
变更：<what changed>
回归验证：<test/manual result>
未验证：<what and why>
剩余风险 / 回滚：<notes>
```
