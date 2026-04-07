---
name: speckit-clarify
description: Wrap the repo-local Spec Kit clarify workflow. Use when the user wants to find and resolve underspecified areas in the active feature spec, 补需求澄清, or turn open questions into concrete updates in spec.md before planning.
---

# SpecKit Clarify

## 概要

这个技能把项目里的 `speckit.clarify` prompt 包成了技能入口。唯一权威流程文件是 `../../prompts/speckit.clarify.md`。

## 什么时候用

- 当前 `spec.md` 里还有模糊点、缺失决策或开放问题。
- 用户想在技术规划前，先把需求边界说清楚。
- 用户需要把澄清结果直接写回规格文档。

## 工作流

1. 打开 `../../prompts/speckit.clarify.md`，严格跟随原工作流。
2. 把当前用户请求当成 `/speckit.clarify` 的输入。
3. 优先提出少量高价值澄清问题，并把回答回填到 `spec.md`。
4. 如果本技能说明和原 prompt 不一致，以原 prompt 为准。

## 注意

- 这个技能一般在 `speckit-specify` 之后、`speckit-plan` 之前使用。
- 如果当前 feature spec 不存在，按原 prompt 要求提醒用户先跑写规格流程。
