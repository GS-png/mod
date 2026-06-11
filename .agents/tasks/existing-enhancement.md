# Task：既有能力增强

## 1. 触发条件

当任务是在已有 feature / module 的当前职责范围内添加小行为，且 feature 边界保持不变时使用。

如果引入新的业务概念、workflow、entry point、data model、permission boundary、external integration 或 independent lifecycle，改用或同时使用 `.agents/tasks/new-capability.md`。

总是同时读取：

- `.agents/engineering/architecture-boundaries.md`
- `.agents/engineering/testing-verification.md`
- `.agents/engineering/workspace-command-safety.md`

按触达领域额外读取 correctness、data、security、performance、dependency、docs 规则。

# 既有能力增强

## 任务本质
在既有责任边界内增强现有能力。
目标不是另起一套，而是在不破坏既有正确性的前提下，把现有能力做强。
要求复用既有路径、保持兼容、可验证、可回退。

## 必读规范
- 先明确要增强的是哪项既有能力，以及它当前的 owner、入口、契约、数据边界。
- 优先在现有实现上增量演进；禁止无必要地平行重做、外围包一层、复制一套相似能力。
- 默认保持向后兼容；旧调用方、旧数据、旧行为不能被无意破坏。
- 新增能力应优先复用既有抽象、模块、配置、发布链路与监控面。
- 只有在新旧语义明显不兼容时，才引入适配层；适配层必须有明确边界和退场条件。
- 改动应小步推进，避免一次性大改穿透多个边界。
- 高风险增强默认使用特性开关、灰度、金丝雀或分阶段发布。
- 必须验证既有能力未退化，同时验证新增能力确实生效。
- 同步补齐测试、监控、文档和必要的兼容策略。
- 完成以“能力增强后仍稳定可用”为准，不以“新逻辑已接入”算完成。

## 完成定义
- 既有能力的原有契约仍成立，兼容性未被破坏。
- 新能力已在正确责任点落地，不是旁路拼接。
- 相关调用链、数据链、配置链、发布链已打通并验证通过。
- 既有场景无回退，新场景可用且结果正确。
- 风险控制、监控观测、回滚路径齐备。
- 未留下重复实现、临时桥接、脏开关或无主代码。