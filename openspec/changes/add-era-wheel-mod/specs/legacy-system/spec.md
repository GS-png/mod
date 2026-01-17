# Legacy System Specification

## ADDED Requirements

### Requirement: Era Legacy Types
The system SHALL provide four legacy categories: Military, Economic, Technology, and Legendary, each with distinct effects.

#### Scenario: Military legacy grant
- **WHEN** demon is sealed successfully
- **THEN** civilization receives military legacy (e.g., Hero's Proof: +10% all stats)
- **AND** legacy is permanently stored

#### Scenario: Economic legacy grant
- **WHEN** demon is sealed with minimal city damage
- **THEN** civilization receives economic legacy (e.g., Post-War Prosperity: +30% population growth for 50 years)

#### Scenario: Technology legacy grant
- **WHEN** demon is sealed using ritual method
- **THEN** civilization may receive technology legacy (e.g., Forbidden Knowledge: skip 1 tech prerequisite)

### Requirement: Legacy Stacking with Diminishing Returns
The system SHALL allow legacy stacking but apply diminishing returns to prevent power inflation.

#### Scenario: First legacy of type
- **WHEN** first Hero's Proof is obtained
- **THEN** full bonus (+10%) is applied

#### Scenario: Subsequent legacy stacking
- **WHEN** second Hero's Proof is obtained
- **THEN** reduced bonus (+8%) is applied
- **AND** third gives +6%, etc.

#### Scenario: Hard cap protection
- **WHEN** total legacy bonus exceeds configured maximum (default 100%)
- **THEN** bonus is clamped to maximum
- **AND** player is notified of cap

### Requirement: Legendary Legacy
The system SHALL provide rare legendary legacies with powerful effects and associated risks.

#### Scenario: Demon Slayer title
- **WHEN** hero delivers killing blow to demon lord
- **THEN** hero receives permanent +1000 all stats
- **AND** title is recorded in world chronicle

#### Scenario: Seal Relic acquisition
- **WHEN** legendary legacy triggers seal relic
- **THEN** player can manually trigger demon awakening
- **AND** risk warning is displayed

### Requirement: Curse Legacy
The system SHALL apply curse legacies when sealing is achieved with heavy losses.

#### Scenario: Curse trigger condition
- **WHEN** city destruction exceeds 50% OR hero deaths exceed 3 during sealing
- **THEN** curse legacy may be applied
- **AND** curse provides mixed effects (buff + debuff)

#### Scenario: Curse purification
- **WHEN** purification path is enabled in config
- **THEN** player can remove curse through specific actions
- **AND** purification difficulty follows configuration

### Requirement: Legacy Persistence
The system SHALL persist legacies across game sessions and cycle restarts.

#### Scenario: Save and load
- **WHEN** game is saved
- **THEN** all legacy data is serialized
- **AND** loads correctly on game resume

#### Scenario: Cycle restart retention
- **WHEN** player restarts cycle after failure
- **THEN** legacy_keep_ratio determines retained legacies
- **AND** some legacies may be converted to weaker versions

### Requirement: Legacy Configuration
The system SHALL allow UI configuration of legacy system parameters.

#### Scenario: Disable legacy system
- **WHEN** legacy system is disabled in config
- **THEN** no legacies are granted on seal
- **AND** existing legacies remain but inactive

#### Scenario: Adjust legendary probability
- **WHEN** legendary_probability is set to 0.1
- **THEN** 10% chance of legendary legacy on seal
- **AND** probability is validated within 0-1 range
