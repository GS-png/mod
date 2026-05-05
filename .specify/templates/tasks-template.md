---

description: "Task list template for feature implementation"
---

# Tasks: [FEATURE NAME]

**Input**: Design documents from `/specs/[###-feature-name]/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md, contracts/

**Tests**: Every story MUST include validation work. Add automated tests when behavior or integration can be checked reliably. If automation is not practical, add explicit manual verification tasks with concrete steps and expected results. Rewrite work MUST also include tasks that prove old integration seams are replaced cleanly before old code is deleted.

**Organization**: Tasks are grouped by user story to enable independent implementation, verification, and documentation sync for each story. Priority only controls execution order. It MUST NOT be used to silently cut approved scope from the first playable release.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

## Path Conventions

- **Official MOD roots**: `EraWheel/mod.json`, `EraWheel/src/`, approved release output directories
- **Spec & planning docs**: `specs/[###-feature-name]/`
- **Reference-only paths**: `设计/`, `api/`, `tools/WorldBox.Managed/`, `.codex/tmp/`
- Tasks MUST place shipping business logic in the official MOD roots, not in reference-only paths

<!-- 
  ============================================================================
  IMPORTANT: The tasks below are SAMPLE TASKS for illustration purposes only.
  
  The /speckit.tasks command MUST replace these with actual tasks based on:
  - User stories from spec.md (with their priorities P1, P2, P3...)
  - Feature requirements from plan.md
  - Entities from data-model.md
  - Endpoints from contracts/
  
  Tasks MUST be organized by user story so each story can be:
  - Implemented independently
  - Validated independently
  - Integrated into the final full-scope release
  
  DO NOT keep these sample tasks in the generated tasks.md file.
  ============================================================================
-->

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Project initialization and basic structure

- [ ] T001 Record authority docs, `api/` evidence, and verified runtime references in `specs/[###-feature-name]/plan.md`
- [ ] T002 List impacted code, docs, templates, tests, configs, resource folders, official MOD roots, and reference-only paths that must stay in sync
- [ ] T003 Record per-behavior runtime reuse decisions in `specs/[###-feature-name]/spec.md` and `specs/[###-feature-name]/plan.md` (`原版直接复用` / `原版修改复用 + MOD 自定义` / `MOD 自定义`)
- [ ] T004 If rewriting or using any non-direct reuse path, create a replacement map and exception evidence for old hooks/files/save keys/resources in `specs/[###-feature-name]/plan.md` or `research.md`
- [ ] T005 Create the official MOD roots per implementation plan and keep shipping logic out of `设计/`, `api/`, `tools/`, and `.codex/tmp/`
- [ ] T006 [P] Configure linting and formatting tools

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Core infrastructure that MUST be complete before ANY user story can be implemented

**⚠️ CRITICAL**: No user story work can begin until this phase is complete

Examples of foundational tasks (adjust based on your project):

- [ ] T007 Confirm current MOD entry points, world hooks, save/load bridges, UI routes, release gates, and original/runtime seams touched by this feature
- [ ] T008 [P] Build or update shared data/models/contracts required by all stories
- [ ] T009 [P] Create common runtime integration helpers or adapters required by all stories without bypassing the reused original/runtime chain
- [ ] T010 Define migration, compatibility, or explicit reset handling for saves/configs affected by the rewrite
- [ ] T011 Configure validation/logging infrastructure needed to prove runtime equivalence, seam reuse, correct official source-root placement, and absence of a parallel private system
- [ ] T012 Mark which old files can only be deleted after each replacement check passes

**Checkpoint**: Foundation ready - user story implementation can now begin in parallel

---

## Phase 3: User Story 1 - [Title] (Priority: P1)

**Goal**: [Brief description of what this story delivers]

**Independent Test**: [How to verify this story works on its own]

### Validation for User Story 1 (MANDATORY) ⚠️

> **NOTE: Validation is mandatory. Prefer automated checks first. If automation is not practical, write manual verification before implementation.**

- [ ] T013 [P] [US1] Add automated validation for [behavior] in tests/[type]/[test-name] when feasible
- [ ] T014 [US1] Write manual verification steps and expected results for [user journey] in `specs/[###-feature-name]/quickstart.md` when needed
- [ ] T015 [US1] Record this story's reused original/runtime seam and, if needed, evidence-backed exception before implementation
- [ ] T016 [US1] If replacing old code, add equivalence or seam-replacement checks for this story before deleting the old implementation

### Implementation for User Story 1

- [ ] T017 [P] [US1] Create [Entity1] or shared data definition in `EraWheel/src/[module]/[entity1]`
- [ ] T018 [P] [US1] Create [Entity2] or shared data definition in `EraWheel/src/[module]/[entity2]`
- [ ] T019 [US1] Implement [Service] in `EraWheel/src/[module]/[service]` (depends on T017, T018)
- [ ] T020 [US1] Implement [feature entry/hook] in `EraWheel/src/[location]/[file]`
- [ ] T021 [US1] Add validation and error handling
- [ ] T022 [US1] Add logging for user story 1 operations
- [ ] T023 [US1] Delete or retire replaced code only after the mapped checks pass
- [ ] T024 [US1] Sync affected docs/comments/parameter tables for user story 1 and confirm no parallel private system remains

**Checkpoint**: At this point, User Story 1 should be fully functional and independently verifiable, but the release is not complete until all approved scope is finished

---

## Phase 4: User Story 2 - [Title] (Priority: P2)

**Goal**: [Brief description of what this story delivers]

**Independent Test**: [How to verify this story works on its own]

### Validation for User Story 2 (MANDATORY) ⚠️

> **NOTE: Validation is mandatory. Prefer automated checks first. If automation is not practical, write manual verification before implementation.**

- [ ] T025 [P] [US2] Add automated validation for [behavior] in tests/[type]/[test-name] when feasible
- [ ] T026 [US2] Write manual verification steps and expected results for [user journey] in `specs/[###-feature-name]/quickstart.md` when needed
- [ ] T027 [US2] Record this story's reused original/runtime seam and, if needed, evidence-backed exception before implementation
- [ ] T028 [US2] If replacing old code, add equivalence or seam-replacement checks for this story before deleting the old implementation

### Implementation for User Story 2

- [ ] T029 [P] [US2] Create [Entity] or shared data definition in `EraWheel/src/[module]/[entity]`
- [ ] T030 [US2] Implement [Service] in `EraWheel/src/[module]/[service]`
- [ ] T031 [US2] Implement [feature entry/hook] in `EraWheel/src/[location]/[file]`
- [ ] T032 [US2] Integrate with User Story 1 components (if needed)
- [ ] T033 [US2] Delete or retire replaced code only after the mapped checks pass
- [ ] T034 [US2] Sync affected docs/comments/parameter tables for user story 2 and confirm no parallel private system remains

**Checkpoint**: At this point, User Stories 1 AND 2 should both work independently, but remaining approved scope is still required for release

---

## Phase 5: User Story 3 - [Title] (Priority: P3)

**Goal**: [Brief description of what this story delivers]

**Independent Test**: [How to verify this story works on its own]

### Validation for User Story 3 (MANDATORY) ⚠️

> **NOTE: Validation is mandatory. Prefer automated checks first. If automation is not practical, write manual verification before implementation.**

- [ ] T035 [P] [US3] Add automated validation for [behavior] in tests/[type]/[test-name] when feasible
- [ ] T036 [US3] Write manual verification steps and expected results for [user journey] in `specs/[###-feature-name]/quickstart.md` when needed
- [ ] T037 [US3] Record this story's reused original/runtime seam and, if needed, evidence-backed exception before implementation
- [ ] T038 [US3] If replacing old code, add equivalence or seam-replacement checks for this story before deleting the old implementation

### Implementation for User Story 3

- [ ] T039 [P] [US3] Create [Entity] or shared data definition in `EraWheel/src/[module]/[entity]`
- [ ] T040 [US3] Implement [Service] in `EraWheel/src/[module]/[service]`
- [ ] T041 [US3] Implement [feature entry/hook] in `EraWheel/src/[location]/[file]`
- [ ] T042 [US3] Delete or retire replaced code only after the mapped checks pass
- [ ] T043 [US3] Sync affected docs/comments/parameter tables for user story 3 and confirm no parallel private system remains

**Checkpoint**: All user stories should now be independently functional and ready for full integration and release validation

---

[Add more user story phases as needed, following the same pattern]

---

## Phase N: Polish & Cross-Cutting Concerns

**Purpose**: Improvements that affect multiple user stories

- [ ] TXXX [P] Documentation updates in docs/
- [ ] TXXX Code cleanup and refactoring
- [ ] TXXX Performance optimization across all stories
- [ ] TXXX [P] Additional automated checks in tests/unit/ or tests/integration/
- [ ] TXXX Security hardening
- [ ] TXXX Sync authority docs, templates, and comments touched by this feature
- [ ] TXXX Verify the replacement map is fully closed: no live hook/save key/resource path still depends on deleted old code
- [ ] TXXX Verify every major behavior still runs through the planned original/runtime seam or its approved minimal exception
- [ ] TXXX Verify no approved design item remains as placeholder, stub, empty entry, or deferred follow-up
- [ ] TXXX Verify no parallel private system remains for battle, spellcasting, save/load, unit spawning, UI/HUD, equipment, or growth logic
- [ ] TXXX Run planned automated/manual validation and record results
- [ ] TXXX Package and validate the release candidate against full playable-release criteria

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies - can start immediately
- **Foundational (Phase 2)**: Depends on Setup completion - BLOCKS all user stories
- **User Stories (Phase 3+)**: All depend on Foundational phase completion
  - User stories can then proceed in parallel (if staffed)
  - Or sequentially in priority order (P1 → P2 → P3)
- **Polish (Final Phase)**: Depends on all approved user stories and content slices being complete

### User Story Dependencies

- **User Story 1 (P1)**: Can start after Foundational (Phase 2) - No dependencies on other stories
- **User Story 2 (P2)**: Can start after Foundational (Phase 2) - May integrate with US1 but should be independently testable
- **User Story 3 (P3)**: Can start after Foundational (Phase 2) - May integrate with US1/US2 but should be independently testable

### Within Each User Story

- Validation tasks MUST exist for every story
- Each story MUST record its reused original/runtime seam and any evidence-backed exception before implementation
- Rewrite stories MUST record which old seam is being replaced and when deletion becomes safe
- Automated tests SHOULD be written and fail before implementation when feasible
- When automation is not practical, manual verification steps MUST be written before implementation
- Models before services
- Services before endpoints
- Core implementation before integration
- Documentation sync before story sign-off
- Story complete before moving to next priority

### Parallel Opportunities

- All Setup tasks marked [P] can run in parallel
- All Foundational tasks marked [P] can run in parallel (within Phase 2)
- Once Foundational phase completes, all user stories can start in parallel (if team capacity allows)
- Automated validation tasks for a user story marked [P] can run in parallel
- Models within a story marked [P] can run in parallel
- Different user stories can be worked on in parallel by different team members

---

## Parallel Example: User Story 1

```bash
# Launch validation for User Story 1 together:
Task: "Add automated validation for [behavior] in tests/[type]/[test-name]"
Task: "Write manual verification steps for [user journey] in specs/[###-feature-name]/quickstart.md"

# Launch all models for User Story 1 together:
Task: "Create [Entity1] or shared data definition in EraWheel/src/[module]/[entity1]"
Task: "Create [Entity2] or shared data definition in EraWheel/src/[module]/[entity2]"
```

---

## Implementation Strategy

### Full Release Delivery

1. Complete Phase 1: Setup
2. Complete Phase 2: Foundational
3. Finish every approved user story and design slice in priority order or safe parallel order
4. Complete cross-story integration, resource hookup, data registration, and release-polish tasks
5. Run release validation and confirm no approved design item remains as placeholder, stub, or deferred follow-up

### Parallel Team Strategy

With multiple developers:

1. Team completes Setup + Foundational together
2. Once Foundational is done:
   - Developer A: User Story 1
   - Developer B: User Story 2
   - Developer C: User Story 3
3. Stories complete and integrate independently

---

## Notes

- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
- Each user story should be independently completable and testable
- 优先级只帮助排执行顺序，不代表可以砍掉低优先级范围
- Verify automated tests fail before implementing when they exist
- Record manual verification results when automation is not practical
- Commit after each task or logical group
- Stop at any checkpoint to validate story independently
- Avoid: vague tasks, same file conflicts, cross-story dependencies that break independence, and any “后续补做”型任务留到首版之后
