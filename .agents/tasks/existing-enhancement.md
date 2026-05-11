# Task：既有能力增强

## 1. 触发条件

当任务是在已有 feature / module 的当前职责范围内添加小行为，且 feature 边界保持不变时使用。

如果引入新的业务概念、workflow、entry point、data model、permission boundary、external integration 或 independent lifecycle，改用或同时使用 `.agents/tasks/new-capability.md`。

总是同时读取：

- `.agents/engineering/architecture-boundaries.md`
- `.agents/engineering/testing-verification.md`
- `.agents/engineering/workspace-command-safety.md`

按触达领域额外读取 correctness、data、security、performance、dependency、docs 规则。

## 2. 目标

扩展既有能力，同时不污染职责、不复制 authority、不把小增强变成隐藏新能力。

## 3. 必查项

确认：

- 该能力的现有 owner module。
- 当前行为和 public contract。
- 新行为是否属于同一职责。
- 类似行为的现有 tests 和 examples。
- 现有 validation、error handling、logging、config、permission patterns。
- 是否触达 data、schema、external IO、security、release concerns。

## 4. Fit Check

只有全部为真时，才安全修改已有文件：

- 文件当前名称和职责能准确描述新行为。
- 新行为是同一概念的小扩展。
- 文件不会成为多个无关概念的 owner。
- 没有新增 independent lifecycle、data model、permission boundary 或 entry point。
- 结果代码仍清晰，不制造大杂烩文件。

任一为假，切换到 new capability 或 architecture-boundary design。

## 5. 增强 vs 新能力边界

- 只改变已有入口中的一个已有职责，且不新增 lifecycle、state、permission、data model、external integration 或独立测试对象：既有能力增强。
- 新 endpoint、page、command、job、integration、business concept、data model、permission boundary 或独立 lifecycle：新增能力，即使改动很小。
- Public contract 改变时，额外读取 `.agents/tasks/behavior-change.md`。

## 6. 设计规则

- 仅在 extension point 是正确 authority 时复用它。
- 不把相似逻辑 copy 到第二处。
- 没有真实重复使用和明确 owner 时，不新增 generic helper。
- Validation 和 errors 与邻近代码保持一致。
- 不借增强之名做无关 cleanup。

## 7. 实现规则

- 修改最小正确 owner module。
- 新文件只在能澄清 ownership 或分离真实职责时新增。
- 命名使用项目已有 domain language。
- docs、examples、config、tests 只更新直接受影响处。

## 8. 验证

验证：

- 既有行为仍工作。
- 新行为正常路径。
- 边界和 invalid input。
- 触达的 permission、data、external IO、config path。

## 9. 交付

```text
分类理由：<为什么是增强而不是新能力>
Owner：<chosen files and why>
验证：<tests/manual checks>
影响 / 风险 / 回滚：<notes>
```
