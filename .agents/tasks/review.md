# Task：审查

## 1. 触发条件

当任务是审查 code、diff、PR、architecture、tests、design、AGENTS rules 或风险，而不直接实现变更时使用。

按审查对象加载相关 engineering files。

## 2. 目标

基于证据发现 correctness、architecture、security、data、testing、maintainability 和 release 风险。

## 3. 必查项

审查：

- 请求范围内的 changed files 或目标文件。
- 相关 callers 和 tests。
- Architecture boundaries 和 source of truth。
- Data 和 compatibility impact。
- Security、permission、privacy impact。
- Test coverage 和 verification quality。
- Unintended behavior changes。
- Workspace / generated / dependency / release risks if relevant。

## 4. 审查规则

- 优先真实风险，不输出纯风格意见。
- 尽量引用具体 file、function、behavior 或 command。
- 区分 blocking issues 和 suggestions。
- 没有 failure path 不声称存在 bug。
- 不要求大范围重写，除非指出具体风险。
- 建议必须可执行。
- 证据不足时明确说明。

## 5. 严重程度

- Critical：data loss、security issue、production outage、broken public contract、irreversible migration risk。
- High：likely correctness bug、permission gap、incompatible behavior、missing migration、unverified release risk。
- Medium：maintainability problem likely to cause defects、incomplete tests、unclear ownership。
- Low：readability、naming、local cleanup、non-blocking documentation。

## 6. AGENTS / 规则文档审查附加项

审查 AGENTS、rules、developer docs 时额外检查：

- 根文件是否过大、是否重复子规范内容。
- 子规范是否被根文件显式路由。
- 任务分类 trigger 是否可判定。
- 是否存在互相冲突或会漂移的重复规则。
- 是否缺少失败处理、验证、回滚、权限、数据、命令安全规则。
- 指令是否可被 agent 执行，而不是只表达抽象理念。
- 交付格式是否按实现 / 审查 / 纯文档区分。
- 缺失子规范或无法读取时是否有处理规则。

## 7. 输出格式

```text
Summary: <overall judgment and reviewed scope>
Blocking issues:
- <issue, evidence, why it matters, suggested fix>
Non-blocking suggestions:
- <suggestion>
Verification gaps:
- <missing test/check/evidence>
Questions:
- <only questions that cannot be answered from repository inspection>
```

如果没有发现问题，说明审查范围和支持该结论的证据。不要只写“looks good”。
