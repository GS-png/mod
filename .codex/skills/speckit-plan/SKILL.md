---
name: speckit-plan
description: Wrap the repo-local Spec Kit planning workflow. Use when the user wants to turn an approved feature spec into an implementation plan, 生成技术方案, or create research, data-model, contracts, and quickstart artifacts before task generation.
---

# SpecKit Plan

## 概要

这个技能把项目里的 `speckit.plan` prompt 包成了技能入口。唯一权威流程文件是 `../../prompts/speckit.plan.md`。

## 什么时候用

- 当前功能规格已经成型，准备转成技术实现方案。
- 用户想产出 `plan.md`、`research.md`、`data-model.md`、`contracts/`、`quickstart.md`。
- 用户希望先做研究和设计，再拆任务。

## 工作流

1. 打开 `../../prompts/speckit.plan.md`，按原计划流程执行。
2. 把当前请求当成 `/speckit.plan` 的输入。
3. 产出规划阶段需要的设计文档，并更新 agent context。
4. 如果本技能说明和原 prompt 有冲突，以原 prompt 为准。

## 注意

- 这个技能一般在 `speckit-specify` 或 `speckit-clarify` 之后使用。
- 如果 feature spec 缺失，先按原 prompt 的要求补前置步骤。
