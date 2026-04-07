---
name: speckit-taskstoissues
description: Wrap the repo-local Spec Kit tasks-to-issues workflow. Use when the user wants to convert the active tasks.md into GitHub issues, 批量建 Issue, or mirror Spec Kit tasks into a GitHub repository that matches the current remote.
---

# SpecKit Tasks To Issues

## 概要

这个技能把项目里的 `speckit.taskstoissues` prompt 包成了技能入口。唯一权威流程文件是 `../../prompts/speckit.taskstoissues.md`。

## 什么时候用

- 用户要把当前 feature 的 `tasks.md` 批量转成 GitHub Issues。
- 用户想让任务清单和 GitHub 仓库里的 Issue 对齐。
- 当前仓库已经配置了 GitHub remote，而且允许写 Issue。

## 工作流

1. 打开 `../../prompts/speckit.taskstoissues.md`，按原流程执行。
2. 把当前用户请求当成 `/speckit.taskstoissues` 的参数。
3. 严格校验远程仓库是否为 GitHub，且创建 Issue 的目标仓库必须和当前 remote 一致。
4. 如果本技能说明和原 prompt 不一致，以原 prompt 为准。

## 注意

- 这个技能依赖 GitHub MCP 或等效写 Issue 能力。
- 如果 remote 不是 GitHub，按原 prompt 直接停止，不要越权创建 Issue。
