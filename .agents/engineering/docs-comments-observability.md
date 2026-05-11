# Engineering：文档、注释与可观测性

## 1. 目的

保证文档描述真实行为，注释解释必要约束，日志 / 指标 / trace / 告警帮助排障且不泄露敏感信息。

## 2. 何时加载

触达以下任一情况时加载：

- README、AGENTS.md、docs、examples、API docs、migration notes、changelogs、comments、runbooks。
- logs、error messages、metrics、alerts、traces、audit records、monitoring config。
- public interfaces、configuration、environment variables、setup steps、deployment steps、troubleshooting behavior。

## 3. 文档规则

- 文档必须描述真实行为，不得把“计划实现”写成“已经支持”。
- 文档应覆盖接口契约、配置变化、迁移步骤、限制和排障步骤。
- examples、commands、paths、options、env vars 必须与真实项目一致。
- 不写 fake test results、fake support status、fake compatibility 或 unverified behavior。
- 项目事实、目录职责、架构边界、常用命令、运行方式和配置来源必须来自已读取的仓库文件或命令输出；无法确认时写“未知”，不要用经验或猜测补齐。
- 结论类文字必须能追溯到证据来源，并区分已观察事实、合理推断、假设和未知项。
- 兼容性改善、风险已消除、限制不存在等声明必须有测试、检查、变更记录或明确依据支撑；证据不足时写剩余风险或未验证项。
- 只更新与本次改动直接相关的文档，除非任务要求更大范围清理。
- 发现文档与代码不一致时，先确认 source of truth，再决定改文档还是重分类为代码任务。

## 4. 注释规则

- 注释解释为什么存在、保护什么不明显约束、适用什么兼容 / 安全 / 迁移规则。
- 不添加只复述代码的注释。
- 复杂逻辑、兼容逻辑、安全边界、迁移行为和不明显错误处理需要注释时，应简短说明原因。
- 因改动变 stale 的注释必须删除或更新。

## 5. 可观测性规则

- 重要失败路径应可观测，不只记录成功路径。
- 日志结构和字段风格必须匹配项目约定。
- 日志应包含稳定 ID、错误码、stage、operation、安全状态摘要。
- 不记录 secrets、tokens、passwords、personal data 或 sensitive business data。
- metrics、alerts、traces 应反映可行动状态，不制造噪声。
- 新增 critical path 时，评估是否需要 logs、metrics、trace spans、audit records 或 runbook。

## 6. 日志纪律

- 不留下临时 `console.log`、debug print、verbose tracing、本地路径或机器特定信息，除非项目约定允许且属于正式可观测性。
- 新增日志必须选择合适级别；错误日志应可定位，成功日志应避免噪声。
- 关键请求链路优先使用已有 request id / correlation id / trace id。
- 错误日志不应向外部用户暴露内部堆栈、SQL、路径、密钥或供应商细节。

## 7. 验证

按需检查：

- links、commands、examples、paths。
- 文档是否匹配代码和配置。
- 重要失败路径是否有日志或错误信息。
- 敏感数据是否未进入日志。
- 项目已有 docs / lint / spelling 检查。

## 8. 交付补充

```text
文档更新：<updated docs>
可观测性变更：<logs/metrics/traces/alerts/audit>
敏感日志检查：<result>
剩余缺口：<intentionally unchanged gaps>
```
