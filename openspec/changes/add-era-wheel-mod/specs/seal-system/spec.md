# Seal System Specification

## ADDED Requirements

### Requirement: Seal War Window
The system SHALL trigger Seal War Window when any of these conditions are met: demon enters Weakening state, invasion duration exceeds max years, or civilization seal preparation reaches threshold.

#### Scenario: Weakening state trigger
- **WHEN** demon health drops below 30%
- **THEN** Seal War Window activates
- **AND** seal sites become interactable

#### Scenario: Invasion timeout trigger
- **WHEN** invasion lasts 200+ years without resolution
- **THEN** Seal War Window forcibly activates
- **AND** time-based seal conditions become available

### Requirement: Multiple Seal Victory Conditions
The system SHALL support multiple seal victory conditions (Ritual, Execution, Collection, TimeWindow) configurable in ANY or ALL mode.

#### Scenario: Execution seal
- **WHEN** demon lord health reaches 0
- **THEN** seal is triggered
- **AND** cycle concludes with demon resealed

#### Scenario: Ritual seal
- **WHEN** seal site is controlled and seal_progress reaches 100
- **THEN** seal is triggered
- **AND** seal progress resets for next cycle

#### Scenario: Fallback to execution
- **WHEN** victory_conditions configuration is empty
- **THEN** system enables execution seal as fallback
- **AND** logs warning about missing configuration

### Requirement: Seal Site Management
The system SHALL spawn and manage seal sites during Seal War Window with progress tracking and interruption handling.

#### Scenario: Seal site spawn
- **WHEN** Seal War Window activates
- **THEN** primary seal site spawns near demon location
- **AND** optional sub-sites spawn for acceleration

#### Scenario: Seal progress interruption
- **WHEN** seal site loses control during ritual
- **THEN** progress stops
- **AND** may slowly decay based on configuration

#### Scenario: Seal site destruction
- **WHEN** seal site is destroyed
- **THEN** seal backlash event triggers
- **AND** demon-themed disaster affects nearby area

### Requirement: Failure Conditions
The system SHALL detect failure conditions and trigger "Terminal Aftermath" instead of game over.

#### Scenario: City control failure
- **WHEN** demon controls 60%+ cities for 20+ years
- **THEN** failure condition is met
- **AND** Terminal Aftermath phase begins

#### Scenario: Civilization extinction
- **WHEN** alive kingdoms drop to 1 or fewer
- **THEN** failure condition is met
- **AND** restart cycle option is offered

### Requirement: Cycle Restart
The system SHALL allow players to restart cycle after failure while preserving cycle count and partial legacy.

#### Scenario: Restart cycle selection
- **WHEN** player selects "Restart Cycle" after failure
- **THEN** world state partially resets
- **AND** legacy_keep_ratio determines retained progress

#### Scenario: Disaster intensity cap
- **WHEN** restart occurs
- **THEN** ongoing disasters are capped at configured intensity
- **AND** world remains playable

### Requirement: Seal Condition Configuration
The system SHALL validate seal condition configuration and apply safe defaults for invalid values.

#### Scenario: Invalid threshold protection
- **WHEN** seal threshold is set to negative value
- **THEN** system uses default threshold
- **AND** logs configuration error

#### Scenario: Mutually exclusive conditions
- **WHEN** configuration creates impossible seal conditions
- **THEN** system enables execution seal as fallback
- **AND** notifies player of configuration issue
