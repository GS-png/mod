# Task：纯文档变更

## 1. 触发条件

当任务只修改 documentation、comments、examples、README、AGENTS rules、developer guides 或 instructions 时使用。

如果修改 code、config、tests、generated files 或 runtime behavior，则不是 docs-only，必须重新分类。

总是同时读取：

- `.agents/engineering/workspace-command-safety.md`

如 examples、commands、generated docs、links 需要验证，也读取：

- `.agents/engineering/testing-verification.md`

修改日志、runbook、API docs、可观测性文档时，读取：

- `.agents/engineering/docs-comments-observability.md`

# 纯文档修改

## 任务本质
在不改变代码、配置、接口、数据和运行行为的前提下，修正文档。
目标不是“改了文字”，而是“文档更准确、更清楚、更一致、更可用”。
要求事实不变、类型正确、表达收敛、可验证。

## 必读规范
- 只改文档，不借文档修改之名隐式改变产品语义、默认值、接口约定或操作结果。
- 先判断文档类型：教程、操作指南、参考、解释；不得混写错位。
- 文档内容必须与当前事实一致；不确定的内容不得臆写。
- 优先修正错误事实、过期信息、歧义表达、结构混乱、命名不一致、链接失效和示例失真。
- 表达必须简洁、直接、易扫读；删除无信息增量的废话。
- 操作型文档以完成任务为导向；参考型文档以准确、完整、可靠为导向。
- 文档应纳入版本控制、评审和必要检查，与代码同样可追溯。
- 纯文档修改默认不引入行为变更；若发现必须改行为定义，应升级任务类型，不继续伪装为文档修改。
- 完成以“文档更正确、更清楚、更一致”为准，不以“字面改过”算完成。

## 完成定义
- 文档事实与当前实现、当前流程、当前命名一致。
- 文档类型正确，结构与读者目标匹配。
- 歧义、重复、过期、失效链接和错误示例已清理。
- 表达更简洁、更易找、更易执行。
- 全程未引入代码、配置、接口、数据或行为变更。
- 修改可追溯、可评审，必要检查通过。
