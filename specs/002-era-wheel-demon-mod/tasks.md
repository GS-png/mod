# Tasks: 纪元之轮：魔王轮回 MOD

**Input**: Design documents from `/specs/002-era-wheel-demon-mod/`
**Prerequisites**: plan.md (required), spec.md (required), research.md, data-model.md, contracts/

**Tests**: 本任务列表默认不安排自动化测试任务（spec 未明确要求 TDD/自动化测试）；以 `spec.md` 的 Independent Test + `quickstart.md` 的手动验收清单为主。

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2)
- 每条任务都包含明确文件路径

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Project initialization and basic structure

- [x] T001 Create MOD folder structure in `EraWheel/` (Config/, Core/, DemonLord/, Civilization/, Narrative/, UI/, Data/, Localization/, Resources/)
- [x] T002 Create C# project file `EraWheel/EraWheel.csproj` targeting `net472` and referencing required DLLs in `EraWheel/lib/`
- [x] T003 [P] Create mod metadata file `EraWheel/mod.json`
- [x] T004 [P] Create default config file `EraWheel/Config/DefaultConfig.json` aligned with `specs/002-era-wheel-demon-mod/contracts/config-schema.json`
- [x] T005 [P] Create localization stubs `EraWheel/Localization/zh_CN.json` and `EraWheel/Localization/en.json`
- [x] T006 [P] Create resource folders `EraWheel/Resources/sprites/` and `EraWheel/Resources/events/`
- [x] T007 [P] Create dependency placeholder folder `EraWheel/lib/` (for `Assembly-CSharp.dll`, `UnityEngine*.dll`, `NeoModLoader.dll`)

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Core infrastructure that MUST be complete before ANY user story can be implemented

 **⚠️ CRITICAL**: No user story work can begin until this phase is complete

- [x] T008 Implement MOD entrypoint `EraWheel/Main.cs` (NeoModLoader `BasicMod`, init systems, register UI button, subscribe update + save/load)
- [x] T009 [P] Define core shared types in `EraWheel/Core/Types.cs` (EraPhase/DemonLordState/GeneralState enums + event payload structs per `contracts/state-machine.md`)
- [x] T010 [P] Implement config models in `EraWheel/Config/ConfigModels.cs` matching `contracts/config-schema.json`
- [x] T011 Implement config loader/merge in `EraWheel/Config/ConfigManager.cs` (priority: runtime > user file > default)
- [x] T012 [P] Implement config validation/clamping in `EraWheel/Config/ConfigSchema.cs` (numeric bounds + fallback rules)
- [x] T013 Implement update scheduler `EraWheel/Core/UpdateScheduler.cs` using frame intervals from config (`performance.update_intervals.*`)
- [x] T014 Implement save models `EraWheel/Data/SaveModels.cs` (ModSaveData/CycleData/DemonLordSaveData/Legacy data)
- [x] T015 Implement save/load integration `EraWheel/Data/SaveManager.cs` (hook NeoModLoader save events used in `Main.cs`)
- [x] T016 [P] Implement migration support `EraWheel/Data/MigrationManager.cs` (versioned save data)
- [x] T017 [P] Implement lightweight event bus wrapper `EraWheel/Core/EventBus.cs` (publish/subscribe for internal systems)

**Checkpoint**: Foundation ready - user story implementation can now begin in parallel

---

## Phase 3: User Story 1 - 完整轮回体验 (Priority: P1) 🎯 MVP

**Goal**: 世界可自动经历完整轮回闭环，并能在单个存档中稳定跑通至少 2 次轮回。

**Independent Test**: 按 `specs/002-era-wheel-demon-mod/spec.md` 的 US1 Independent Test：单存档运行 2 次“再封印”，轮回计数正确 +1 且不崩溃。

### Implementation for User Story 1

- [x] T018 [P] [US1] Implement prosperity trigger tracking in `EraWheel/Civilization/ProsperityTracker.cs` (population/cities/heroes/tech)
- [x] T019 [US1] Implement cycle core loop in `EraWheel/Core/CycleManager.cs` (cycleCount/currentPhase/sealStrength + update entry)
- [x] T020 [US1] Implement phase state machine in `EraWheel/Core/EraStateMachine.cs` following `specs/002-era-wheel-demon-mod/contracts/state-machine.md`
- [x] T021 [US1] Implement seal strength logic in `EraWheel/Core/SealSystem.cs` (decay/reset/clamp + victory fallback enable-execution)
- [x] T022 [US1] Implement cycle history record structures in `EraWheel/Core/CycleHistory.cs` (CycleSummary, key events list)
- [x] T023 [US1] Wire scheduler to update cycle systems in `EraWheel/Core/UpdateScheduler.cs` (call CycleManager + publish PhaseChangedEvent)
- [x] T024 [US1] Add minimal “omen entered” narrative trigger in `EraWheel/Narrative/NarrativeDispatcher.cs` (send notification/log + request EventPool)
- [x] T025 [US1] Manual validation: run 2 full cycles using `specs/002-era-wheel-demon-mod/quickstart.md` MVP checklist

**Checkpoint**: User Story 1 can run a full loop and be validated independently

---

## Phase 4: User Story 2 - 魔王状态机与战斗 (Priority: P1)

**Goal**: 魔王具备清晰 7 状态并能在不同阶段表现不同威胁节奏；支持调试强制切换状态验证行为。

**Independent Test**: 通过调试面板/代码接口强制切换魔王状态，观察状态行为是否符合 `spec.md` US2。

### Implementation for User Story 2

- [x] T026 [P] [US2] Create demon lord domain models in `EraWheel/DemonLord/DemonLordModels.cs`
- [x] T027 [US2] Implement base class `EraWheel/DemonLord/DemonLordBase.cs` (runtime state + hooks: OnAwaken/OnKill/UpdateUniqueMechanic)
- [x] T028 [US2] Implement registry/selection in `EraWheel/DemonLord/DemonLordRegistry.cs` (enabled list + select active demon)
- [x] T029 [US2] Implement factory in `EraWheel/DemonLord/DemonLordFactory.cs` registering MVP lords (`EraWheel/DemonLord/Lords/VoidLord.cs`, `EraWheel/DemonLord/Lords/PlagueLord.cs`)
- [x] T030 [US2] Implement demon state transitions in `EraWheel/DemonLord/DemonLordStateMachine.cs` per `contracts/state-machine.md`
- [x] T031 [US2] Implement spawn integration in `EraWheel/DemonLord/SpawnSystem.cs` using `AssetManager.unitStats.clone/add` (MVP可先用占位模板 + 日志确认)
- [x] T032 [US2] Implement stronghold skeleton in `EraWheel/DemonLord/StrongholdSystem.cs` + data in `EraWheel/DemonLord/StrongholdModels.cs`
- [x] T033 [US2] Manual validation: force demon states via debug hooks (in `EraWheel/UI/Tabs/DebugTab.cs` later) and verify behaviors per `spec.md`

---

## Phase 5: User Story 3 - 纪元遗产与成长 (Priority: P1)

**Goal**: 每次“再封印”后文明与魔王获得可追溯的永久成长（含诅咒遗产判定）。

**Independent Test**: 完成一次封印后检查遗产发放与下一轮回成长倍率是否生效。

### Implementation for User Story 3

- [x] T034 [P] [US3] Define legacy domain models in `EraWheel/Core/LegacyModels.cs` (Legacy/LegacyGrant/LegacyType)
- [x] T035 [US3] Implement legacy trait registration in `EraWheel/Core/LegacyTraitFactory.cs` (register a minimal set from `research.md` mapping)
- [x] T036 [US3] Implement legacy granting in `EraWheel/Core/LegacySystem.cs` triggered on `EraPhase.Resealed` entry
- [x] T037 [US3] Implement curse legacy rules in `EraWheel/Core/LegacySystem.cs` using config `legacy.curse_threshold.*`
- [x] T038 [US3] Persist legacies in save data by updating `EraWheel/Data/SaveModels.cs` + `EraWheel/Data/SaveManager.cs`
- [x] T039 [US3] Manual validation: complete 1 seal, verify legacy logs + next-cycle demon growth per `demon_lord.growth.cycle_multiplier`

---

## Phase 6: User Story 4 - 军团波次系统 (Priority: P2)

**Goal**: 入侵期间按波次生成军团，波次强度递进且受性能上限保护。

**Independent Test**: 在 Invasion 后观察每 N 年生成一波（默认 10 年/可配置），并验证 10+ 波出现终极单位。

### Implementation for User Story 4

- [x] T040 [P] [US4] Create legion models in `EraWheel/DemonLord/LegionModels.cs` (LegionWaveState/LegionConfig/LegionTier)
- [x] T041 [US4] Implement wave scheduler in `EraWheel/DemonLord/LegionWaveSystem.cs` (interval + growth + tier selection)
- [x] T042 [US4] Implement legion unit registration in `EraWheel/DemonLord/LegionUnitFactory.cs` (template-based)
- [x] T043 [US4] Add performance caps in `EraWheel/DemonLord/LegionWaveSystem.cs` using config `demon_lord.legion.max_alive_units`
- [x] T044 [US4] Manual validation: run invasion for 50+ years and confirm waves per `spec.md` US4

---

## Phase 7: User Story 5 - 将领系统 (Priority: P2)

**Goal**: 将领可按轮回进度激活，具备撤退/复活/背叛机制。

**Independent Test**: 魔王降临后将领激活数量随轮回增长；击败 3 次后可触发背叛事件。

### Implementation for User Story 5

- [x] T045 [P] [US5] Create general models/templates in `EraWheel/DemonLord/GeneralModels.cs`
- [x] T046 [US5] Implement general lifecycle/state machine in `EraWheel/DemonLord/GeneralSystem.cs` (Inactive/Active/Retreating/Defeated/Betrayed)
- [x] T047 [US5] Implement betrayal rules in `EraWheel/DemonLord/GeneralSystem.cs` using config `demon_lord.generals.betrayal_*`
- [x] T048 [US5] Implement general registration in `EraWheel/DemonLord/GeneralFactory.cs` (MVP: 2-3 generals per lord)
- [x] T049 [US5] Manual validation: simulate defeats and verify betrayal event published to `EraWheel/Core/EventBus.cs`

---

## Phase 8: User Story 6 - 文明抗魔成长 (Priority: P2)

**Goal**: 文明抗魔等级随击杀/封印成长，并影响对魔物的伤害加成/减免。

**Independent Test**: 达到击杀阈值后抗魔等级提升，并在战斗中体现倍率变化。

### Implementation for User Story 6

- [x] T050 [P] [US6] Implement civilization tracking in `EraWheel/Civilization/CivilizationTracker.cs` (CivData mapping)
- [x] T051 [US6] Implement anti-demon level progression in `EraWheel/Civilization/AntiDemonLevel.cs` using config `civilization.anti_demon.kill_thresholds`
- [x] T052 [US6] Hook demon kill counting in `EraWheel/Civilization/CivilizationTracker.cs` (listen to kill/death events)
- [x] T053 [US6] Apply combat modifiers in `EraWheel/Civilization/CombatModifiers.cs` using config `damage_reduction_per_level` and `damage_bonus_per_level`
- [x] T054 [US6] Manual validation: reach AntiDemonLevel 1 and verify modifiers apply in logs

---

## Phase 9: User Story 7 - 反魔联盟系统 (Priority: P2)

**Goal**: 当魔王威胁足够大时自动组建联盟，并定期召开议会（MVP 可先做“组建+记录+基础共享效果”）。

**Independent Test**: 城市损毁比例超过阈值后自动组建联盟，联盟状态可见且可记录。

### Implementation for User Story 7

- [x] T055 [P] [US7] Define alliance models in `EraWheel/Civilization/AllianceModels.cs` (AntiDemonAlliance/AllianceCouncil)
- [x] T056 [US7] Implement auto-form logic in `EraWheel/Civilization/AllianceSystem.cs` using config `civilization.alliance.auto_form_threshold`
- [x] T057 [US7] Implement council timer/logging in `EraWheel/Civilization/AllianceSystem.cs` using config `council_interval_years`
- [x] T058 [US7] Integrate optional alliance seal condition flag in `EraWheel/Core/SealSystem.cs` (if enabled, allow alliance progress)
- [x] T059 [US7] Manual validation: force threshold reached and confirm alliance formed + events logged

---

## Phase 10: User Story 8 - 英雄系统深化 (Priority: P2)

**Goal**: 命定英雄诞生、AI 优先级行为、死亡继承机制。

**Independent Test**: 验证命定英雄概率、挑战逻辑优先级，以及继承概率。

### Implementation for User Story 8

- [x] T060 [P] [US8] Define hero models in `EraWheel/Civilization/HeroModels.cs`
- [x] T061 [US8] Implement destined hero birth & tracking in `EraWheel/Civilization/HeroSystem.cs` using config `civilization.hero.destined_chance`
- [x] T062 [US8] Implement hero AI priorities in `EraWheel/Civilization/HeroAI.cs` (self-preserve → challenge demon → hunt generals)
- [x] T063 [US8] Implement inheritance on hero death in `EraWheel/Civilization/HeroSystem.cs` using config `inheritance_chance`
- [x] T064 [US8] Manual validation: run with higher destined chance and verify behaviors via logs

---

## Phase 11: User Story 9 - 玩家控制面板 (Priority: P2)

**Goal**: 提供统一面板查看轮回/魔王/文明，并能手动调整参数和触发危险操作（带二次确认）。

**Independent Test**: 打开面板，至少能正常显示“总览/魔王管理/文明状态/设置/调试”并可操作。

### Implementation for User Story 9

- [x] T065 [P] [US9] Implement main UI window in `EraWheel/UI/ControlPanel.cs` (ScrollWindow + tab routing)
- [x] T066 [P] [US9] Implement overview tab in `EraWheel/UI/Tabs/OverviewTab.cs`
- [x] T067 [P] [US9] Implement demon management tab in `EraWheel/UI/Tabs/DemonManageTab.cs` (enable/disable + force state + adjust strength)
- [x] T068 [P] [US9] Implement civilization status tab in `EraWheel/UI/Tabs/CivStatusTab.cs` (CSI/anti-demon/alliance summary)
- [x] T069 [P] [US9] Implement settings tab in `EraWheel/UI/Tabs/SettingsTab.cs` (edit config + import/export)
- [x] T070 [US9] Implement confirmation dialog helper in `EraWheel/UI/Components/ConfirmDialog.cs` for dangerous operations
- [x] T071 [US9] Wire UI open entrypoints in `EraWheel/Main.cs` (PowerButton + optional hotkey)
- [x] T072 [US9] Manual validation: verify each tab opens and operations apply without crash

---

## Phase 12: User Story 10 - 后备事件池 (Priority: P2)

**Goal**: 无 LLM 时也能通过事件池提供叙事内容，支持条件、冷却、去重、加权选择与本地化。

**Independent Test**: 关闭 AI，事件仍会按条件触发且不会短时间重复同一事件。

### Implementation for User Story 10

- [x] T073 [P] [US10] Define event schema models in `EraWheel/Narrative/NarrativeEventModels.cs` (conditions/effects/choices)
- [x] T074 [US10] Implement JSON loading in `EraWheel/Narrative/EventPool.cs` from `EraWheel/Resources/events/`
- [x] T075 [US10] Implement condition evaluation in `EraWheel/Narrative/EventConditionEvaluator.cs` (WorldContext mapping)
- [x] T076 [US10] Implement selection algorithm in `EraWheel/Narrative/EventPool.cs` (priority sort + weighted random + cooldown + duplicate prevention)
- [x] T077 [P] [US10] Add starter event JSON files in `EraWheel/Resources/events/` (omen/hero/battle/system samples)
- [x] T078 [P] [US10] Add localization keys for starter events in `EraWheel/Localization/zh_CN.json` and `EraWheel/Localization/en.json`
- [x] T079 [US10] Implement dispatcher to show notifications/log in `EraWheel/Narrative/NarrativeDispatcher.cs`
- [x] T080 [US10] Manual validation: run with AI disabled and confirm events trigger + cooldown works

---

## Phase 13: User Story 11 - AI叙事引擎 (Priority: P3)

**Goal**: 可选集成 LLM，增强事件描述，并支持权限等级与操作日志（不可用时自动降级）。

**Independent Test**: 配置 LLM 后可生成描述；失败时自动回退到事件池文本。

### Implementation for User Story 11

- [x] T081 [P] [US11] Define provider interface `EraWheel/Narrative/AI/ILLMProvider.cs` and provider stubs in `EraWheel/Narrative/AI/Providers/`
- [x] T082 [US11] Implement AI story engine in `EraWheel/Narrative/AI/AIStoryEngine.cs` (timeout/retry + fallback to EventPool)
- [x] T083 [US11] Implement permission & confirmation handling in `EraWheel/Narrative/AI/AIPermissionManager.cs` (levels 1-5)
- [x] T084 [US11] Implement operation log + undo skeleton in `EraWheel/Narrative/AI/AIOperationLog.cs` and persist in `EraWheel/Data/SaveModels.cs`
- [x] T085 [US11] Implement AI control UI in `EraWheel/UI/Tabs/AIControlTab.cs` (enable/provider/url/model/permission/test)
- [x] T086 [US11] Manual validation: set a test endpoint and verify fallback works on failure

---

## Phase 14: User Story 12 - 十大魔王完整实现 (Priority: P3)

**Goal**: 从 MVP（2 个魔王）扩展到 10 个魔王，每个有独特机制入口与资源占位。

**Independent Test**: 逐个启用魔王并验证核心机制回调被触发（MVP 可先用日志确认）。

### Implementation for User Story 12

- [x] T087 [P] [US12] Extend enabled-lords config in `EraWheel/Config/DefaultConfig.json` + `EraWheel/Config/ConfigModels.cs`
- [x] T088 [P] [US12] Implement remaining 8 demon lord classes in `EraWheel/DemonLord/Lords/` (Machine/Time/Flame/Abyss/Death/Soul/Nature/Judgment)
- [x] T089 [US12] Register all lords in `EraWheel/DemonLord/DemonLordFactory.cs` and ensure selection respects enabled flags
- [x] T090 [US12] Implement unique mechanic hooks for each lord in corresponding `EraWheel/DemonLord/Lords/*.cs` (at least one mechanic trigger)
- [x] T091 [P] [US12] Add sprite/icon placeholders in `EraWheel/Resources/sprites/` and localization names in `EraWheel/Localization/*.json`
- [x] T092 [US12] Manual validation: enable each lord one-by-one and confirm awakening/spawn path executes

---

## Phase 15: User Story 13 - 扩展模块（诸神黄昏/魔王内战） (Priority: P4)

**Goal**: 提供扩展玩法的框架与开关（实现可逐步推进）。

**Independent Test**: 开关开启后可进入对应模式并不崩溃（MVP 先做框架与日志）。

### Implementation for User Story 13

- [ ] T093 [P] [US13] Add expansion flags in `EraWheel/Config/DefaultConfig.json` + `EraWheel/Config/ConfigModels.cs`
- [ ] T094 [US13] Implement multi-lord interaction skeleton in `EraWheel/DemonLord/MultiLordSystem.cs` (independent/alliance/civil_war/auto_judge)
- [ ] T095 [US13] Create extension module stub `EraWheel/Core/ExtensionModules/RagnarokModule.cs`
- [ ] T096 [US13] Manual validation: enable multi-lord mode and confirm system selects behavior mode without errors

---

## Phase 16: Polish & Cross-Cutting Concerns

**Purpose**: Improvements that affect multiple user stories

- [ ] T097 [P] Implement debug tab basics in `EraWheel/UI/Tabs/DebugTab.cs` (show internal vars + quick actions)
- [ ] T098 [P] Implement additional UI tabs skeletons in `EraWheel/UI/Tabs/` (EventManageTab.cs, CycleHistoryTab.cs)
- [ ] T099 Performance pass for scheduler in `EraWheel/Core/UpdateScheduler.cs` (avoid per-frame allocations, respect intervals)
- [ ] T100 Save/load robustness pass in `EraWheel/Data/MigrationManager.cs` (migrate missing fields to defaults)
- [ ] T101 Manual end-to-end validation using `specs/002-era-wheel-demon-mod/spec.md` acceptance scenarios (US1-3 at minimum)
- [ ] T102 Build/deploy dry run using steps in `specs/002-era-wheel-demon-mod/quickstart.md` (dotnet build + copy to mods folder)

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies
- **Foundational (Phase 2)**: Depends on Setup; blocks all user stories
- **User Stories (Phase 3+)**: Depend on Foundational completion
- **Polish (Final Phase)**: After the desired user stories are complete

### User Story Completion Order (by priority)

- **P1**: US1 → US2 → US3 (MVP建议先做到这里)
- **P2**: US4, US5, US6, US7, US8, US9, US10
- **P3**: US11, US12
- **P4**: US13

---

## Parallel Example: User Story 1

- Task: `T018 [P] [US1] Implement prosperity trigger tracking in EraWheel/Civilization/ProsperityTracker.cs`
- Task: `T022 [P?] (not marked P) Record cycle history in EraWheel/Core/CycleHistory.cs` (若拆分为独立文件实现，可并行)

## Parallel Example: UI Tasks (User Story 9)

- Task: `T066 [P] [US9] OverviewTab in EraWheel/UI/Tabs/OverviewTab.cs`
- Task: `T067 [P] [US9] DemonManageTab in EraWheel/UI/Tabs/DemonManageTab.cs`
- Task: `T068 [P] [US9] CivStatusTab in EraWheel/UI/Tabs/CivStatusTab.cs`
- Task: `T069 [P] [US9] SettingsTab in EraWheel/UI/Tabs/SettingsTab.cs`

---

## Implementation Strategy

### MVP First (P1 Only)

1. Phase 1 + Phase 2 先把项目跑起来（能加载、不崩溃、能保存/读档）
2. 完成 **US1**：轮回闭环能跑通
3. 完成 **US2**：至少 2 个魔王（虚无/瘟疫）能随阶段行动
4. 完成 **US3**：封印结算与遗产成长生效
5. **停止并验证**：按 `spec.md` 的 Independent Test 跑 2 次轮回
