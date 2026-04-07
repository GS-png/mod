---
name: speckit-specify
description: Wrap the repo-local Spec Kit specify workflow. Use when the user wants to create or update a feature specification from a natural-language request, 开新功能规格, or generate spec.md and its requirement checklist before technical planning.
---

# SpecKit Specify

## 概要

这个技能把项目里的 `speckit.specify` prompt 包成了技能入口。唯一权威流程文件是 `../../prompts/speckit.specify.md`。

## 什么时候用

- 用户用自然语言描述一个新功能，想先写成正式规格。
- 用户要给现有想法补 `spec.md`。
- 项目准备进入 Spec Kit 流程，但还没有 feature spec。

## 工作流

1. 打开 `../../prompts/speckit.specify.md`，把它当成唯一执行标准。
2. 把当前用户请求视作 `/speckit.specify` 的参数。
3. 严格按原 prompt 生成 feature branch、`spec.md` 和 requirements checklist。
4. 如果包装说明和原 prompt 不一致，以原 prompt 为准。

## 注意

- 如果用户没给出明确功能描述，要先引导出一句可执行的需求描述。
- 通常下一步会衔接 `speckit-clarify` 或 `speckit-plan`。
