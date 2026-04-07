---
name: speckit-constitution
description: Wrap the repo-local Spec Kit constitution workflow. Use when the user wants to create or update the project constitution, 调整项目原则, or propagate governance changes into Spec Kit templates and downstream artifacts.
---

# SpecKit Constitution

## 概要

这个技能把项目里的 `speckit.constitution` prompt 包成了技能入口。唯一权威流程文件是 `../../prompts/speckit.constitution.md`。

## 什么时候用

- 用户想定义或更新项目原则、治理规则、验收底线。
- 用户要把新的开发原则同步到 Spec Kit 模板里。
- 项目想先定“什么能做、什么不能做”，再继续规格和实现。

## 工作流

1. 打开 `../../prompts/speckit.constitution.md`，按原流程执行。
2. 读取并更新 `.specify/memory/constitution.md`。
3. 按原 prompt 要求同步受影响模板和下游产物。
4. 如果包装说明和原 prompt 有冲突，以原 prompt 为准。

## 注意

- 这个技能会影响整个项目的 Spec Kit 流程，不只是单个功能。
- 修改后通常要继续跑 `speckit-specify`、`speckit-plan` 等后续流程。
