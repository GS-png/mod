# Feature Specification: [FEATURE NAME]

**Feature Branch**: `[###-feature-name]`  
**Created**: [DATE]  
**Status**: Draft  
**Input**: User description: "$ARGUMENTS"

## Source of Truth & Scope *(mandatory)*

**Primary Authority Docs**: [List the single-source documents that define this feature, with file paths]  
**Technical Contracts**: [List `api/` docs, DLL/decompiled references, or N/A]  
**Existing Mod / Runtime Seams**: [List the current EraWheel files, hooks, save keys, config paths, UI routes, and resource directories this feature must preserve or replace]  
**Implementation Target Roots**: [List the official mod roots this feature must land in, e.g., `EraWheel/mod.json`, `EraWheel/src/`, approved release directories]  
**Read-only Reference Boundaries**: [List authority/reference-only directories that MUST NOT host shipping business logic, e.g., `设计/`, `api/`, `tools/WorldBox.Managed/`, `.codex/tmp/`]  
**Runtime Reuse Decision**: [For each major behavior, state whether it is `原版直接复用`, `原版修改复用 + MOD 自定义`, or `MOD 自定义`; cite the exact runtime seam or original entry]  
**Runtime Reuse Exceptions**: [Default `None`; if any major behavior cannot directly reuse the original/runtime chain, cite the evidence proving the gap and describe the minimal custom segment to add]  
**Design Coverage**: [List the relevant files/sections under `设计/` and what each one contributes to this feature]  
**Full-Scope Roadmap Position**: [If this spec is one execution slice of the complete first playable release, state which approved `设计/` content it covers now and where the remaining content is mapped]  
**Impacted Artifacts**: [List code, design docs, templates, tests, configs, and comments likely to change]  
**Out of Scope / Approved Exclusions**: [Default `None`; if any approved design item is excluded or deferred, cite the explicit approval source]  
**Release Standard**: [Define what counts as a complete first playable release for this scope; placeholders and deferred content are not acceptable]

## User Scenarios & Testing *(mandatory)*

<!--
  IMPORTANT: User stories should be PRIORITIZED as user journeys ordered by importance.
  Each user story/journey must be INDEPENDENTLY TESTABLE so the team can verify progress safely.
  In this repository, user stories are execution slices, NOT permission to ship partial scope.
  A release is complete only when all approved design content tied to this spec has been implemented,
  integrated, and verified.
  
  Assign priorities (P1, P2, P3, etc.) to each story, where P1 is the most critical.
  Think of each story as a standalone slice of functionality that can be:
  - Developed independently
  - Tested independently
  - Integrated into the final release independently
  - Demonstrated during development without reducing final scope
-->

### User Story 1 - [Brief Title] (Priority: P1)

[Describe this user journey in plain language]

**Why this priority**: [Explain the value and why it has this priority level]

**Independent Test**: [Describe how this can be tested independently - e.g., "Can be fully tested by [specific action] and delivers [specific value]"]

**Acceptance Scenarios**:

1. **Given** [initial state], **When** [action], **Then** [expected outcome]
2. **Given** [initial state], **When** [action], **Then** [expected outcome]

---

### User Story 2 - [Brief Title] (Priority: P2)

[Describe this user journey in plain language]

**Why this priority**: [Explain the value and why it has this priority level]

**Independent Test**: [Describe how this can be tested independently]

**Acceptance Scenarios**:

1. **Given** [initial state], **When** [action], **Then** [expected outcome]

---

### User Story 3 - [Brief Title] (Priority: P3)

[Describe this user journey in plain language]

**Why this priority**: [Explain the value and why it has this priority level]

**Independent Test**: [Describe how this can be tested independently]

**Acceptance Scenarios**:

1. **Given** [initial state], **When** [action], **Then** [expected outcome]

---

[Add more user stories as needed, each with an assigned priority]

### Edge Cases

<!--
  ACTION REQUIRED: The content in this section is template guidance.
  Fill them out with the right edge cases.
-->

- What happens when [boundary condition]?
- How does system handle [error scenario]?
- If the official MOD roots do not exist yet, where will this feature land first, and how will reference-only directories stay read-only?
- What happens to existing saves, staged progress, or persisted state after this change?
- Which current MOD hook, entry file, save key, or resource path is being replaced, and how will equivalence be proven before deleting the old implementation?
- If the plan cannot directly reuse the original/runtime chain for [behavior], what exact evidence proves the gap, and where is the minimal custom segment inserted?
- How will this feature prove it did not create a parallel private system for battle, spellcasting, save/load, unit spawning, UI/HUD, equipment, or growth logic?
- Which authoritative document or parameter table MUST be updated when this feature ships?
- Which item from `设计/` is easiest to accidentally漏做, and how does this spec prevent that omission?

## Requirements *(mandatory)*

<!--
  ACTION REQUIRED: The content in this section is template guidance.
  Fill them out with the right functional requirements.
-->

### Functional Requirements

- **FR-001**: System MUST [specific capability, e.g., "allow users to create accounts"]
- **FR-002**: System MUST [specific capability, e.g., "validate email addresses"]  
- **FR-003**: Users MUST be able to [key interaction, e.g., "reset their password"]
- **FR-004**: System MUST [data requirement, e.g., "persist user preferences"]
- **FR-005**: System MUST [behavior, e.g., "log all security events"]

*Example of marking unclear requirements:*

- **FR-006**: System MUST authenticate users via [NEEDS CLARIFICATION: auth method not specified - email/password, SSO, OAuth?]
- **FR-007**: System MUST retain user data for [NEEDS CLARIFICATION: retention period not specified]

### Key Entities *(include if feature involves data)*

- **[Entity 1]**: [What it represents, key attributes without implementation]
- **[Entity 2]**: [What it represents, relationships to other entities]

## Validation Plan *(mandatory)*

**Automated Checks**: [List automated tests to add/run, or write N/A with a concrete reason]  
**Manual Checks**: [List step-by-step manual validation with expected results]  
**Integration Checks**: [List cross-system validation, save/load checks, replacement-map checks, resource hookup checks, regression checks, and proof that reused original/runtime seams still carry the flow end-to-end]  
**Runtime Equivalence Checks**: [List how you will prove there is no parallel private system replacing an original/runtime chain, and how each exception remains minimal and evidence-backed]  
**Doc Sync**: [List the authority docs, templates, comments, and guides that must stay in sync]  
**Release Readiness**: [State how you will prove this scope is complete, playable, and free of placeholder/deferred content]

## Success Criteria *(mandatory)*

<!--
  ACTION REQUIRED: Define measurable success criteria.
  These must be technology-agnostic and measurable.
-->

### Measurable Outcomes

- **SC-001**: [Measurable metric, e.g., "Users can complete account creation in under 2 minutes"]
- **SC-002**: [Measurable metric, e.g., "System handles 1000 concurrent users without degradation"]
- **SC-003**: [User satisfaction metric, e.g., "90% of users successfully complete primary task on first attempt"]
- **SC-004**: [Business metric, e.g., "Reduce support tickets related to [X] by 50%"]
