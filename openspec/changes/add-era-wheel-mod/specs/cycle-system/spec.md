# Cycle System Specification

## ADDED Requirements

### Requirement: Cycle Phase State Machine
The system SHALL manage world progression through 6 distinct phases: Sealed, Omen, Awakening, Invasion, Weakening, and Resealed.

#### Scenario: Normal phase progression
- **WHEN** seal strength drops below 50%
- **THEN** the system transitions from Sealed to Omen phase
- **AND** triggers OmenPhaseStartedEvent

#### Scenario: Phase transition on demon defeat
- **WHEN** demon lord health drops to 0 during Invasion phase
- **THEN** the system transitions to Resealed phase
- **AND** increments cycle count by 1

### Requirement: Cycle Trigger Conditions
The system SHALL support configurable cycle trigger conditions using OR/AND logic with thresholds for population, cities, world age, and legendary heroes.

#### Scenario: OR condition trigger
- **WHEN** trigger method is "OR" and world age exceeds 600 years
- **THEN** the system begins cycle phase progression
- **AND** logs trigger reason

#### Scenario: Invalid configuration fallback
- **WHEN** all trigger conditions are set to 0 or empty
- **THEN** the system falls back to default (world_age_years >= 600)
- **AND** displays warning notification

### Requirement: Seal Strength Decay
The system SHALL decrease seal strength by a configurable amount every 10 years while in Sealed phase.

#### Scenario: Periodic seal decay
- **WHEN** 10 years pass in Sealed phase
- **THEN** seal strength decreases by configured amount (default 5%)
- **AND** emits SealStrengthChangedEvent

#### Scenario: Seal strength reaches zero
- **WHEN** seal strength drops to 0
- **THEN** the system forces transition to Awakening phase

### Requirement: Cycle Count Persistence
The system SHALL persist cycle count across game sessions and only increment it when a demon lord is successfully resealed.

#### Scenario: Cycle count increment
- **WHEN** demon lord enters Resealed state
- **THEN** cycle count increases by exactly 1
- **AND** saves to game data

#### Scenario: Cycle count on restart
- **WHEN** player chooses "restart cycle" after failure
- **THEN** cycle count is preserved
- **AND** legacy retention ratio is applied

### Requirement: World Age Phase Mapping
The system SHALL map world age to era phases for the first cycle to ensure natural world development before demon invasion.

#### Scenario: First cycle world age mapping
- **WHEN** current cycle is 1 and world age is 0-100 years
- **THEN** demons remain in deep sleep
- **AND** civilization growth rate increases by 50%

#### Scenario: Subsequent cycles use seal-based progression
- **WHEN** current cycle is greater than 1
- **THEN** phase progression is driven by seal strength decay
- **AND** world age mapping is ignored
