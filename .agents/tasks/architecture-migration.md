# Task：架构迁移

## 1. 触发条件

当任务从旧架构、模块、API、数据格式、依赖或执行路径迁移到新方案时使用。

示例：

- 业务逻辑从 controller 迁到 service / use case。
- 拆分大文件为多个模块。
- 迁移 storage、client、scheduler、job runner、auth model、API version。
- 引入新架构并退役旧架构。

总是同时读取：

- `.agents/engineering/architecture-boundaries.md`
- `.agents/engineering/testing-verification.md`
- `.agents/engineering/workspace-command-safety.md`

按触达领域额外读取 data、security、dependency、release、performance、docs 规则。

## 2. 目标

迁到新架构，同时避免永久双路径、行为漂移、owner 不清、旧路径残留和不可回滚迁移。

## 3. 必查项

迁移前识别：

- 旧架构和旧 authority path。
- 目标新 authority path。
- 所有 callers、imports、routes、jobs、tests、mocks、docs、config、generated artifacts、data paths。
- 兼容要求和 rollout 限制。
- 迁移是 atomic 还是 staged。
- rollback plan。

## 4. 迁移类型

必须声明一种：

1. Atomic migration：所有 callers 一次迁移，旧路径同改动中删除。
2. Staged migration：旧新路径临时共存。
3. Compatibility adapter：旧接口委托到新 authority，直到 callers 迁完。
4. Experimental path：新路径隔离存在，尚非 authority。

Staged migration 必须定义：

- Authority path。
- Caller migration order。
- Compatibility layer owner。
- Divergence prevention。
- Deletion condition。
- Verification at each stage。

## 5. 设计规则

- 不创建两个永久 source of truth。
- 不留下未说明的可达旧路径。
- 不只迁移可见入口，而让 tests、mocks、docs、config 仍基于旧假设。
- Compatibility code 必须隔离且易删除。
- 优先带测试迁移行为，再做大结构移动。
- 不把无关 refactor 混入迁移。
- Feature flag、adapter、compat layer 必须有 owner、触发条件和删除条件。

## 6. 实现规则

- 有计划地迁移 callers。
- 同步更新 imports、tests、mocks、docs、generated sources、config。
- 安全时删除 obsolete files。
- 不能删除时，标记 deprecated 并写删除条件。
- 除非显式行为变更，否则保留 error behavior、data semantics、logging、permission checks、retry behavior。

## 7. 验证

验证：

- 旧预期行为在新路径上成立。
- 所有迁移 callers。
- Compatibility path if present。
- 没有意外 import retired modules。
- 有测试能发现旧新路径 divergence。

## 8. 交付

```text
迁移类型：<atomic / staged / adapter / experimental>
旧路径：<old authority>
新 authority：<new authority>
调用方迁移：<summary>
旧路径收口：<deleted / deprecated / pending and why>
兼容计划：<if any>
验证：<commands/results>
回滚：<rollback notes>
```
