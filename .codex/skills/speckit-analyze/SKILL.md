---
name: speckit-analyze
description: Wrap the repo-local Spec Kit analyze workflow. Use when the user wants to review spec.md, plan.md, and tasks.md for consistency after task generation, 做实现前的一致性检查, or get a read-only analysis report without changing files.
---

# SpecKit Analyze

## 概要

这个技能把项目里的 `speckit.analyze` prompt 包成了技能入口，方便像普通技能一样调用。唯一权威流程文件是 `../../prompts/speckit.analyze.md`。

## 什么时候用

- 用户想在实现前检查 `spec.md`、`plan.md`、`tasks.md` 是否互相打架。
- 用户明确要“只分析，不改文件”。
- 用户已经跑过任务生成，希望先做一次一致性体检。

## 工作流

1. 打开 `../../prompts/speckit.analyze.md`，把它当成唯一执行标准。
2. 把当前用户请求当成原来 `/speckit.analyze` 后面的参数。
3. 严格按原 prompt 的只读约束执行，不修改任何文件。
4. 如果技能包装说明和原 prompt 有冲突，以原 prompt 为准。

## 注意

- 这个技能通常在 `speckit-tasks` 之后使用。
- 如果缺少 `spec.md`、`plan.md` 或 `tasks.md`，按原 prompt 的要求提示用户先补前置步骤。
