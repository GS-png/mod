---
name: speckit-tasks
description: Wrap the repo-local Spec Kit task generation workflow. Use when the user wants to turn plan artifacts into dependency-ordered tasks.md, 拆开发任务, or prepare a story-based execution list before implementation.
---

# SpecKit Tasks

## 概要

这个技能把项目里的 `speckit.tasks` prompt 包成了技能入口。唯一权威流程文件是 `../../prompts/speckit.tasks.md`。

## 什么时候用

- 用户已经有 `spec.md` 和 `plan.md`，现在要拆成可执行任务。
- 用户想按用户故事、依赖关系和阶段来组织开发。
- 用户要在实现前拿到一份清晰的 `tasks.md`。

## 工作流

1. 打开 `../../prompts/speckit.tasks.md`，按原流程执行。
2. 把当前用户请求当成 `/speckit.tasks` 的输入。
3. 生成依赖有序、可独立测试的 `tasks.md`。
4. 如果本技能说明和原 prompt 有冲突，以原 prompt 为准。

## 注意

- 这个技能通常在 `speckit-plan` 之后使用。
- 如果存在扩展 hooks，按原 prompt 的规则处理，不要自己发明额外流程。
