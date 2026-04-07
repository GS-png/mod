---
name: speckit-implement
description: Wrap the repo-local Spec Kit implement workflow. Use when the user wants to execute tasks.md, 按 Spec Kit 任务开始开发, or continue implementation phase-by-phase while marking completed tasks back into the task list.
---

# SpecKit Implement

## 概要

这个技能把项目里的 `speckit.implement` prompt 包成了技能入口。唯一权威流程文件是 `../../prompts/speckit.implement.md`。

## 什么时候用

- 用户已经有 `tasks.md`，现在要真正开始落代码。
- 用户想按任务阶段推进实现，而不是自由发挥。
- 用户希望边做边把已完成任务勾回任务清单。

## 工作流

1. 打开 `../../prompts/speckit.implement.md`，把它当成唯一执行标准。
2. 把当前用户请求视作 `/speckit.implement` 的参数。
3. 按原 prompt 的阶段顺序执行，并同步更新任务完成状态。
4. 如果本技能说明和原 prompt 不一致，以原 prompt 为准。

## 注意

- 这个技能依赖当前 feature 目录下已经存在 `tasks.md`。
- 如果检查清单未完成，要按原 prompt 先停下来征求用户确认。
