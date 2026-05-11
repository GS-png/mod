# Engineering：测试与验证

## 1. 目的

确保变更由相关证据证明，而不是仅靠代码阅读、类型推断或假设。

## 2. 核心规则

除非通过相关测试、构建、lint、typecheck、静态检查、命令输出或手动复现验证，否则不得声称“可用”“通过”“已修复”或“没有问题”。

所有结论必须基于已观察证据，并区分：

- 已观察事实：来自已读取源码、配置、文档、测试、日志、命令输出或实际运行结果。
- 合理推断：基于已观察事实推导，但尚未被直接验证。
- 假设：当前缺少证据，只能作为待确认前提。
- 未知项：仓库和命令输出无法确认的信息，必须明确标记为“未知”。

没有对应证据时，不得宣称性能提升、并发安全、兼容性改善、风险已消除或行为正常。

## 3. 测试选择

先选择最小有意义检查，再按风险扩大：

Bug 修复、行为变更和关键逻辑改动，优先建立失败测试（failing test）、契约测试（contract test）或可重复复现步骤，再实现修复。

1. 具体 failing test 或 reproduction。
2. 被触达 owner module 的 unit tests。
3. 被触达 entry point 的 integration tests。
4. public interface 的 contract / API tests。
5. auth-sensitive 变更的 permission / security tests。
6. schema 变更的 migration / data tests。
7. import、type、dependency、structure 变更的 lint / typecheck / build。
8. 自动化测试覆盖不到时的 manual verification。

## 4. 各类变更最低验证

| 变更类型 | 最低验证 |
|---|---|
| 纯文档 | 检查 paths、links、commands、examples 是否匹配仓库事实 |
| Bug 修复 | 失败用例或复现 + regression check |
| 既有增强 | 新行为 + 相邻旧行为 |
| 实现替换 | 兼容行为 + 新实现路径 + 失败路径 |
| 行为变更 | 新契约 + 受影响调用方 + 旧行为处理 |
| 新能力 | 主路径 + 边界路径 + 失败路径 + 集成点 |
| 架构迁移 | 已迁移调用方 + 旧路径收口 + stale import 检查 |
| 数据 / schema | migration / compatibility + readers / writers + rollback or recovery review |
| 配置 / 环境 / 发布 | install / build / typecheck 或 CI-equivalent + startup / smoke where relevant |

## 5. 好测试标准

- 好测试应在实现坏掉时失败。
- 不要只断言 mock 被调用而不检查行为。
- snapshot-only 不能替代真实行为断言。
- 新测试应尽量靠近 owner，匹配项目测试风格。
- 不为覆盖率数字添加无意义测试。

## 6. 没有测试时

如果没有现成测试：

- 项目结构支持时，添加 focused test。
- 否则提供 manual verification path。
- 说明为什么没有添加自动化测试。
- 不宣称 full confidence。

### Bug 无法复现时

Bug 无法复现或缺少失败用例时，只能交付为“基于推断修复”，不得宣称“已修复”。

交付必须说明：

- 尝试过的复现方式或检查路径。
- 支撑推断的源码、日志、报告、配置或调用链证据。
- 修改如何对应推断出的根因。
- 剩余风险和建议回归验证方式。

## 7. 命令执行规则

- 命令未知时，检查 package scripts、Makefile、CI、README、pyproject、package.json、go.mod、Cargo.toml 或等效文件。
- 运行能提供证据的最小相关命令。
- 不运行破坏性命令，除非用户明确批准。

## 8. 既有失败与无关失败

- 验证命令失败时，必须分类：与本次改动相关、疑似无关、无法判断。
- 不得顺手修复无关失败，除非用户要求，或该失败阻塞本次验证且修复范围很小并说明原因。
- 如果失败在修改前已存在，应说明依据，例如修改前命令结果、已有 CI 状态或未触达文件。
- 不得因存在无关失败而宣称本次改动通过；只能说明相关检查是否通过。

## 9. 报告命令结果

报告：

- 执行的 command / check。
- 结果：passed、failed、not run。
- 失败时的相关摘要。
- 失败是否看起来与本次改动相关。

不要粘贴巨大日志；摘要必须足够定位。

## 10. 无法运行验证时

使用以下措辞：

```text
已修改但未验证。
原因：<为什么不能运行验证>
风险：<可能出错的地方>
建议验证：<命令或手动步骤>
```

## 11. 交付补充

```text
已运行验证：
- <command/check>: <result>
未运行：
- <command/check>: <reason>
失败分类：<related / likely unrelated / unknown>
```
