# Task：新增能力

## 1. 触发条件

当任务新增独立 feature、module、page、endpoint、CLI command、background job、integration、domain concept、workflow 或 reusable capability 时使用。

这是防止“把新功能堆进已有文件”的关键任务文档。

总是同时读取：

- `.agents/engineering/architecture-boundaries.md`
- `.agents/engineering/testing-verification.md`
- `.agents/engineering/workspace-command-safety.md`

按触达领域额外读取 correctness、data、security、performance、dependency、docs 规则。

# 新增能力

## 任务本质
为系统新增一个清晰、可用、可演进的能力单元。
目标不是“接入一段新逻辑”，而是“让新能力在正确边界内稳定成立”。
要求边界清楚、owner 清楚、契约清楚、可验证、可发布、可回退。

## 必读规范
- 先明确新增的是什么能力，而不是只描述要改哪些文件。
- 新能力必须落在明确的业务能力边界和 owner 上，禁止散落式拼接实现。
- 优先复用既有抽象、模块、配置、发布链路与监控面；无必要不平行造轮子。
- 新能力入口、契约、数据边界、依赖关系必须清楚，避免隐式耦合。
- 涉及外部接口、事件、数据结构时，默认考虑兼容性和演进策略。
- 高风险新增默认使用特性开关、灰度、金丝雀或分阶段发布。
- 必须同时验证两件事：新能力可用，既有能力未退化。
- 新能力上线后必须可观测、可定位、可回退。
- 过渡性开关、临时桥接、试验性兼容层必须可收口，不得长期残留。
- 完成以“能力真实成立并稳定可用”为准，不以“代码已合入”算完成。

## 完成定义
- 新能力有明确 owner、入口、契约、数据边界和责任落点。
- 目标场景已打通，关键链路验证通过。
- 既有能力未被破坏，兼容性结论明确。
- 发布、监控、告警、回退路径齐备且可执行。
- 无重复实现、无无主开关、无长期过渡胶水残留。
- 系统新增的是一个正式能力，不是一组临时补丁。