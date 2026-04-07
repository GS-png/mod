# Implementation Plan: [FEATURE]

**Branch**: `[###-feature-name]` | **Date**: [DATE] | **Spec**: [link]
**Input**: Feature specification from `/specs/[###-feature-name]/spec.md`

**Note**: This template is filled in by the `/speckit.plan` command. See `.specify/templates/plan-template.md` for the execution workflow.

## Summary

[Extract from feature spec: primary requirement + technical approach from research]

**Release Target**: [Describe the full first playable release scope; do not describe an MVP or partial launch]  
**Design Coverage**: [List the `设计/` files, annexes, and resource folders covered by this plan]  
**Approved Exclusions**: [Default `None`; if any approved design item is excluded or deferred, cite the explicit approval source]  
**Rewrite Intent**: [State whether this feature is additive, partial refactor, or full rewrite]  
**Replacement Map Scope**: [If rewriting, list which old modules/hooks/save keys/resources are being replaced and which are kept as-is]

## Authoritative Context

**Primary Authority Docs**: [e.g., `设计/EraWheel_Redesign.md`, `api/Assembly-CSharp.md`, feature annex docs]  
**Verified Runtime References**: [e.g., decompiled DLL methods, engine call chains, or N/A]  
**Existing Mod Integration Seams**: [List the current `EraWheel/src/` entry files, hooks, save/load bridges, UI routes, resource loaders, and release gates touched by this work]  
**Impacted Artifacts**: [e.g., `src/...`, `设计/...`, `api/...`, `specs/...`, tests, templates]

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
- [ ] `Approved Exclusions` 为 `None`，或已附上明确批准依据；不存在私自延期的设计内容
- [ ] 已记录唯一权威来源，并写明本功能依赖的设计文档、`api/` 文档或 DLL 证据路径
- [ ] 已记录当前 MOD 的真实接缝：现有入口文件、游戏钩子、存档键、配置项、资源目录和发布闸门
- [ ] 若属于彻底重构或大规模删旧，已写替换映射表，说明“旧线接哪里、新线接哪里、何时可以删旧”
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
<!--
  ACTION REQUIRED: Replace the sample structure tree below with the concrete layout
  for this feature. Delete unused options and expand the chosen structure with
  real paths (e.g., apps/admin, packages/something). The delivered plan must
  not include Option labels.
-->

```text
# [REMOVE IF UNUSED] Option 1: Single project (DEFAULT)
src/
├── models/
├── services/
├── cli/
└── lib/

tests/
├── contract/
├── integration/
└── unit/

# [REMOVE IF UNUSED] Option 2: Web application (when "frontend" + "backend" detected)
backend/
├── src/
│   ├── models/
│   ├── services/
│   └── api/
└── tests/

frontend/
├── src/
│   ├── components/
│   ├── pages/
│   └── services/
└── tests/

# [REMOVE IF UNUSED] Option 3: Mobile + API (when "iOS/Android" detected)
api/
└── [same as backend above]

ios/ or android/
└── [platform-specific structure: feature modules, UI flows, platform tests]
```

**Structure Decision**: [Document the selected structure and reference the real
directories captured above]

## Complexity Tracking

> **Fill ONLY if Constitution Check has violations that must be justified**

| Violation | Why Needed | Simpler Alternative Rejected Because |
|-----------|------------|-------------------------------------|
| [e.g., 4th project] | [current need] | [why 3 projects insufficient] |
| [e.g., Repository pattern] | [specific problem] | [why direct DB access insufficient] |
