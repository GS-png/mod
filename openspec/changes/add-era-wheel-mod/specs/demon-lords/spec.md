# Demon Lords Specification

## ADDED Requirements

### Requirement: Demon Lord State Machine
The system SHALL implement a state machine for each demon lord with states: Sealed, Omen, Awakening, Invasion, Peak, Weakening, and Resealed.

#### Scenario: State transition to Awakening
- **WHEN** demon is in Omen phase and seal strength drops below 20%
- **THEN** demon transitions to Awakening state
- **AND** spawns with 30% of base stats

#### Scenario: State transition to Peak
- **WHEN** demon health is above 70% during Invasion
- **THEN** demon enters Peak state
- **AND** skill cooldowns reduce by 50%

#### Scenario: State transition to Weakening
- **WHEN** demon health drops below 30%
- **THEN** demon enters Weakening state
- **AND** seal ritual success rate increases by 50%

### Requirement: Demon Lord Base Class
The system SHALL provide a BaseDemonLord class that defines common lifecycle methods: OnAwaken, OnInvade, OnSeal, OnEvolve.

#### Scenario: Demon awakening
- **WHEN** demon transitions to Awakening state
- **THEN** OnAwaken is called
- **AND** demon entity is spawned with current cycle multiplier applied

#### Scenario: Demon sealing
- **WHEN** seal conditions are met
- **THEN** OnSeal is called
- **AND** demon entity is removed from world

### Requirement: Void Lord Implementation
The system SHALL implement Void Lord with unique mechanics: Void Domain (AOE damage), Existence Erasure (no resurrection), and World Contraction (terrain destruction).

#### Scenario: Void Domain damage
- **WHEN** units are within 1000 tiles of Void Lord
- **THEN** they lose 1% max HP per second
- **AND** effect applies continuously while in range

#### Scenario: World Contraction trigger
- **WHEN** Void Lord faction kills reach configured threshold (default 100)
- **THEN** 5% of world tiles convert to void terrain
- **AND** minimum habitable area protection is enforced

### Requirement: Plague Mother Implementation
The system SHALL implement Plague Mother with unique mechanics: Infection Conversion, Toxic Fog, and Dormant Pathogens.

#### Scenario: Infection spread
- **WHEN** infected unit contacts healthy unit
- **THEN** infection spreads with configured probability
- **AND** infected unit converts after incubation period

#### Scenario: Global plague outbreak
- **WHEN** configured interval passes
- **THEN** random city experiences plague outbreak
- **AND** infection intensity follows configuration

### Requirement: Demon Lord Power Scaling
The system SHALL scale demon lord stats based on cycle count using formula: final_power = base_power * (1 + cycle_count * growth_rate).

#### Scenario: Power scaling on awakening
- **WHEN** demon awakens in cycle 3 with growth_rate 0.25
- **THEN** demon stats are multiplied by 1.75
- **AND** power multiplier is clamped to configured max

#### Scenario: Adaptive scaling based on CSI
- **WHEN** CSI indicates weak civilization (below 30)
- **THEN** adaptive multiplier reduces demon power
- **AND** minimum power threshold is maintained

### Requirement: Legion Wave System
The system SHALL spawn demon legion waves at configurable intervals with increasing strength.

#### Scenario: Wave generation
- **WHEN** 5 years pass during Invasion phase
- **THEN** new legion wave spawns
- **AND** wave strength follows formula: base * wave_multiplier * cycle_multiplier

#### Scenario: Elite unit spawn
- **WHEN** wave number exceeds 7
- **THEN** elite units have 20% spawn chance
- **AND** elite units have +2 level bonus

### Requirement: General System
The system SHALL support demon generals with independent AI, unique skills, and betrayal mechanics.

#### Scenario: General betrayal
- **WHEN** general defeat count exceeds 3 by holy paladin
- **THEN** betrayal event may trigger with configured probability
- **AND** general may join mortal faction

#### Scenario: General AI behavior
- **WHEN** general health drops below 20%
- **THEN** general retreats to nearest demon legion
- **AND** prioritizes self-preservation

### Requirement: Demon Evolution
The system SHALL allow demons to evolve after each cycle, gaining new abilities and resistances.

#### Scenario: Skill unlock on cycle
- **WHEN** demon reawakens in cycle 2+
- **THEN** ultimate skill unlocks
- **AND** skill is available during Invasion phase

#### Scenario: Memory resistance
- **WHEN** demon was sealed by specific tactic in previous cycle
- **THEN** demon gains partial resistance to that tactic
- **AND** resistance value follows configured gain rate
