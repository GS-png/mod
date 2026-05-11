# Task：新增能力

## 1. 触发条件

当任务新增独立 feature、module、page、endpoint、CLI command、background job、integration、domain concept、workflow 或 reusable capability 时使用。

这是防止“把新功能堆进已有文件”的关键任务文档。

总是同时读取：

- `.agents/engineering/architecture-boundaries.md`
- `.agents/engineering/testing-verification.md`
- `.agents/engineering/workspace-command-safety.md`

按触达领域额外读取 correctness、data、security、performance、dependency、docs 规则。

## 2. 目标

用清晰的 architecture landing、owner、public surface、tests 和 integration path 添加能力，不污染已有模块。

## 3. 必查项

编码前检查：

- 现有目录树和模块边界。
- 类似 features 的结构。
- UI、API、jobs、commands、integrations、services 的现有入口模式。
- 现有 domain vocabulary 和 ownership。
- 当前 shared utilities 是否是真实 authority。
- 现有 tests 和 fixtures。
- config、schema、permission、data、logging、deployment patterns。

## 4. 新模块信号

任一成立时，优先新建 file / module / directory：

- 有独立 business concept。
- 有自己的 lifecycle、state、workflow 或 side effects。
- 引入新的 entry point、page、endpoint、command、job、queue consumer 或 integration。
- 有自己的 data model、schema、permission、config 或 error handling。
- 可能被多个 entry points 使用。
- 现有文件名无法准确描述新职责。
- 加入已有文件会让其拥有多个业务概念。
- 需要独立 tests、fixtures、docs、metrics 或 troubleshooting。
- 会把大量 types、validators、adapters、side-effect handlers 塞入旧模块。

只有当新行为只是已有文件当前职责的一小部分时，才直接修改已有文件。

## 5. 架构落点决策

实现前声明：

- 哪个 domain 或 technical layer 拥有该能力。
- 是否存在 existing owner module。
- 为什么选定 module / new module 是正确落点。
- 新能力暴露什么 public surface。
- 哪些 callers 可以调用。
- 哪些 layers 不得调用。
- 是否需要 new schema、type、config、permission、route、test、doc 或 migration。

不要因为方便、相邻、已有文件很大或 diff 更小而选择位置。小 diff 不等于正确架构。

## 6. 设计规则

- 写 internals 前先定义 public surface。
- 在项目架构支持时，domain logic 与 transport、UI、framework、storage、external API details 分离。
- 使用项目已有 routes、services、repositories、hooks、components、jobs、commands、tests 模式。
- 至少两个真实调用方且 authority 清晰时，才提取 generic shared utility。
- 不重复 schema、validation、permission 或 data access logic。
- 不绕过已有 config、auth、logging、error modules。

## 7. 实现规则

- ownership 更清晰时新建文件。
- 文件按职责命名并保持 cohesive。
- 通过既有 architecture boundaries 接入。
- tests 靠近 owner 或按项目约定放置。
- docs、examples、config、generated sources 只在直接受影响时更新。
- 删除实现过程中的临时 scaffolding。

## 8. 验证

验证：

- Main success path。
- Boundary and invalid input paths。
- Failure paths and error reporting。
- Permission paths if applicable。
- Data persistence or migration if applicable。
- Integration points and affected existing behavior。

## 9. 交付

```text
分类理由：<为什么是新能力>
架构落点：<owner/layer/path>
新文件 / 模块：<responsibilities>
调用图：<entry point -> core logic>
Public surface：<API/command/component/job/etc>
禁止调用方：<forbidden callers/layers>
验证：<tests/checks>
未验证区域：<known gaps>
回滚：<notes>
```
