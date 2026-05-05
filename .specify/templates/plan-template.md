# Implementation Plan: [FEATURE]

**Branch**: `[###-feature-name]` | **Date**: [DATE] | **Spec**: [link]
**Input**: Feature specification from `/specs/[###-feature-name]/spec.md`

**Note**: This template is filled in by the `/speckit.plan` command. See `.specify/templates/plan-template.md` for the execution workflow.

## Summary

[Extract from feature spec: primary requirement + technical approach from research]

**Release Target**: [Describe the full first playable release scope; do not describe an MVP or partial launch]  
**Design Coverage**: [List the `设计/` files, annexes, and resource folders covered by this plan]  
**Full-Scope Roadmap Position**: [If this plan is one execution slice, state which part of the full first playable release it covers and which approved `设计/` items remain mapped to later specs/plans]  
**Approved Exclusions**: [Default `None`; if any approved design item is excluded or deferred, cite the explicit approval source]  
**Rewrite Intent**: [State whether this feature is additive, partial refactor, or full rewrite]  
**Replacement Map Scope**: [If rewriting, list which old modules/hooks/save keys/resources are being replaced and which are kept as-is]  
**Implementation Target Roots**: [List the official mod roots this plan will create or extend, e.g., `EraWheel/mod.json`, `EraWheel/src/`, approved release output directories]  
**Read-only Reference Boundaries**: [List directories that are authority/reference only and MUST NOT host shipping business logic, e.g., `设计/`, `api/`, `tools/WorldBox.Managed/`, `.codex/tmp/`]  
**Runtime Reuse Strategy**: [For each major behavior, state whether it is `原版直接复用`, `原版修改复用 + MOD 自定义`, or `MOD 自定义`, and list the exact seam being reused]  
**Runtime Reuse Exceptions**: [Default `None`; list only the evidence-backed gaps where direct original/runtime reuse is impossible, plus the minimal custom segment being added]

## Authoritative Context

**Primary Authority Docs**: [e.g., `设计/EraWheel_Redesign.md`, `api/Assembly-CSharp.md`, feature annex docs]  
**Verified Runtime References**: [e.g., decompiled DLL methods, engine call chains, or N/A]  
**Existing Mod Integration Seams**: [List the current `EraWheel/src/` entry files, hooks, save/load bridges, UI routes, resource loaders, release gates, and the original/runtime seams that this work must preserve or extend]  
**Impacted Artifacts**: [e.g., `EraWheel/src/...`, `EraWheel/mod.json`, `设计/...`, `api/...`, `specs/...`, tests, templates]

## Technical Context

<!--
  ACTION REQUIRED: Replace the content in this section with the technical details
  for the project. The structure here is presented in advisory capacity to guide
  the iteration process.
-->

**Language/Version**: [e.g., Python 3.11, Swift 5.9, Rust 1.75 or NEEDS CLARIFICATION]  
**Primary Dependencies**: [e.g., FastAPI, UIKit, LLVM or NEEDS CLARIFICATION]  
**Storage**: [if applicable, e.g., PostgreSQL, CoreData, files or N/A]  
**Testing**: [e.g., pytest, XCTest, cargo test or NEEDS CLARIFICATION]  
**Target Platform**: [e.g., Linux server, iOS 15+, WASM or NEEDS CLARIFICATION]
**Project Type**: [e.g., library/cli/web-service/mobile-app/compiler/desktop-app or NEEDS CLARIFICATION]  
**Performance Goals**: [domain-specific, e.g., 1000 req/s, 10k lines/sec, 60 fps or NEEDS CLARIFICATION]  
**Constraints**: [domain-specific, e.g., <200ms p95, <100MB memory, offline-capable or NEEDS CLARIFICATION]  
**Scale/Scope**: [domain-specific, e.g., 10k users, 1M LOC, 50 screens or NEEDS CLARIFICATION]

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

- [ ] 已覆盖本次涉及的 `设计/` 主文档、附属文档和资源目录，并映射到计划产物
- [ ] 若本计划只是完整首版中的一个执行切片，已写清路线图位置，且没有借切片之名缩减批准范围
- [ ] `Approved Exclusions` 为 `None`，或已附上明确批准依据；不存在私自延期的设计内容
- [ ] 已记录唯一权威来源，并写明本功能依赖的设计文档、`api/` 文档或 DLL 证据路径
- [ ] 已记录正式源码落点与只读参考边界，确认业务逻辑不会落进 `设计/`、工具、生成或反编译目录
- [ ] 已记录当前 MOD 的真实接缝：现有入口文件、游戏钩子、存档键、配置项、资源目录和发布闸门
- [ ] 已逐块写明本功能走 `原版直接复用`、`原版修改复用 + MOD 自定义` 或 `MOD 自定义`，并标明真实接缝位置
- [ ] 任何非直接复用项都已附上 `api/`、DLL 或运行结果证据，证明原版主链存在明确缺口
- [ ] 若属于彻底重构或大规模删旧，已写替换映射表，说明“旧线接哪里、新线接哪里、何时可以删旧”
- [ ] 已证明不会平行重写与原版语义重叠的单位生成、战斗、施法、命中、死亡、存档、UI/HUD、装备或成长链路
- [ ] 已确认规则变更会同步到对应权威文档，未同步的内容已明确标记为超出范围
- [ ] 已列出所有受影响产物，包括代码、文档、模板、测试和配置
- [ ] 计划交付目标是完整首版，不含占位逻辑、占位资源、空条目、TODO 或“以后补做”
- [ ] 已写验证方案：优先自动化测试；若不适合自动化，已写手动验证步骤和预期结果
- [ ] 已写跨模块联调、回归和可游玩验收步骤，而不是只验证单个局部功能
- [ ] 已检查是否影响存档兼容、阶段推进、参数口径或其他高风险边界；如有影响，已在计划中说明

## Project Structure

### Documentation (this feature)

```text
specs/[###-feature]/
├── plan.md              # This file (/speckit.plan command output)
├── research.md          # Phase 0 output (/speckit.plan command)
├── data-model.md        # Phase 1 output (/speckit.plan command)
├── quickstart.md        # Phase 1 output (/speckit.plan command)
├── contracts/           # Phase 1 output (/speckit.plan command)
└── tasks.md             # Phase 2 output (/speckit.tasks command - NOT created by /speckit.plan)
```

### Source Code (repository root)
```text
EraWheel/
├── mod.json                # 模组身份与加载契约
├── src/                    # 正式 MOD 业务实现
└── [approved release files]

tests/                      # 自动化验证（若当前为空，需在计划里写明原因）
specs/                      # Spec Kit 规格与计划
设计/                       # 权威设计文档与资源范围，只读参考边界
api/                        # 参考/生成产物，优先重新生成
tools/WorldBox.Managed/     # 只读 DLL 快照
.codex/tmp/                 # 临时分析目录，不承载发布态业务逻辑
```

**Structure Decision**: [Document the selected official mod roots, any missing directories that must be created, and which paths remain reference-only]

## Complexity Tracking

> **Fill ONLY if Constitution Check has violations that must be justified**

| Violation | Why Needed | Simpler Alternative Rejected Because |
|-----------|------------|-------------------------------------|
| [e.g., 4th project] | [current need] | [why 3 projects insufficient] |
| [e.g., Repository pattern] | [specific problem] | [why direct DB access insufficient] |
