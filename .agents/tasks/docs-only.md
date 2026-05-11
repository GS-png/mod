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

## 2. 目标

让文档准确、简洁、可执行，并与真实仓库行为一致。

## 3. 必查项

编辑文档前，检查定义所述行为的代码、配置、脚本、测试或现有文档。

不得把 aspirational behavior 写成 already implemented behavior。

## 4. 写作规则

- 用精确指令代替模糊原则。
- 保持文档短到可读，同时完整到能防止关键错误。
- 区分 mandatory rules 和 recommendations。
- 已知时使用具体 file paths 和 commands。
- 避免重复章节造成漂移。
- 不包含 secrets、tokens、private URLs 或 production-only values。
- examples 匹配项目语言、包管理器和目录结构。

## 5. AGENTS.md 专用规则

- 常驻必需规则放根 `AGENTS.md`。
- workflow-specific 细节放 `.agents/tasks/`。
- cross-cutting engineering 规则放 `.agents/engineering/`。
- 如果期望读取子文档，根 `AGENTS.md` 必须显式路由。
- 不依赖普通 Markdown 自动加载，除非 Codex discovery / config 明确支持。
- 根文件应保持轻量，避免把所有子规范内容重复塞进去。

## 6. 发现代码 / 配置不一致时

如果文档审查发现代码或配置与文档不一致，不要默默改代码。

只能二选一：

- 保持 docs-only，只修文档并报告不一致。
- 重新分类任务，读取相关 task / engineering 文件后，再修改代码或配置。

## 7. 验证

至少检查：

- 内部 links 和 paths 是否合理。
- Commands 是否匹配 package manager 和 scripts。
- Examples 使用真实名称或明确 placeholder。
- 没有引入 obsolete references。
- AGENTS 路由路径存在且命名一致。

命令无法验证时，交付说明。

## 8. 交付

```text
文档变更：<docs changed>
依据来源：<code/config/scripts/tests/docs inspected>
检查结果：<links/commands/examples checked>
剩余占位：<project-specific placeholders>
未验证项：<if any>
```
