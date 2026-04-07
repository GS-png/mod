---
name: speckit-checklist
description: Wrap the repo-local Spec Kit checklist workflow. Use when the user wants to generate a requirements-quality checklist for the current feature, 写规格检查清单, or review whether a spec is complete and unambiguous before planning or implementation.
---

# SpecKit Checklist

## 概要

这个技能把项目里的 `speckit.checklist` prompt 包成了技能入口。唯一权威流程文件是 `../../prompts/speckit.checklist.md`。

## 什么时候用

- 用户想为当前功能生成“规格质量检查清单”。
- 用户要检查需求是否完整、清楚、无歧义。
- 用户想在实现前先补一套针对某个领域的 spec checklist。

## 工作流

1. 打开 `../../prompts/speckit.checklist.md`，按里面的步骤执行。
2. 把用户当前需求当成原来 `/speckit.checklist` 的参数。
3. 生成的是“需求写作质量”的检查清单，不是代码测试清单。
4. 如果包装说明和原 prompt 不一致，以原 prompt 为准。

## 注意

- 这个技能检查的是“需求写得好不好”，不是“实现是否正确”。
- 适合在 `speckit-specify` 或 `speckit-plan` 前后补强规格质量。
