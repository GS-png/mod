# Narrative Engine Specification

## ADDED Requirements

### Requirement: LLM Integration
The system SHALL integrate with OpenAI-compatible LLM APIs for dynamic narrative generation.

#### Scenario: Successful API call
- **WHEN** LLM is enabled and API key is configured
- **THEN** system sends narrative request with world context
- **AND** receives JSON response with operations

#### Scenario: API failure fallback
- **WHEN** API call fails or times out
- **THEN** system switches to fallback event pool
- **AND** logs failure reason

#### Scenario: No API key configured
- **WHEN** api_key is empty or missing
- **THEN** system uses fallback event pool only
- **AND** no API calls are attempted

### Requirement: AI Permission Levels
The system SHALL enforce 5 permission levels controlling what AI can modify.

#### Scenario: Level 1 Observer
- **WHEN** AI permission is level 1
- **THEN** AI can only generate story descriptions
- **AND** cannot modify game entities

#### Scenario: Level 4 Creator
- **WHEN** AI permission is level 4 and player authorizes
- **THEN** AI can spawn heroes and demon generals
- **AND** each operation requires confirmation

#### Scenario: Level 5 God Mode
- **WHEN** AI permission is level 5
- **THEN** AI can directly modify game state
- **AND** every action requires manual confirmation

### Requirement: Fallback Event Pool
The system SHALL maintain 200+ pre-defined events for offline/fallback operation.

#### Scenario: Event selection
- **WHEN** fallback mode is active
- **THEN** system selects event matching current trigger conditions
- **AND** applies weight-based random selection

#### Scenario: Event categories
- **WHEN** demon seal strength is below 30%
- **THEN** omen events become eligible for selection
- **AND** event effects are applied to world

### Requirement: Request Queue Management
The system SHALL queue LLM requests with single concurrency and rate limiting.

#### Scenario: Request queuing
- **WHEN** multiple narrative requests occur simultaneously
- **THEN** requests are queued and processed sequentially
- **AND** queue length is limited

#### Scenario: Cost monitoring
- **WHEN** token usage approaches configured limit
- **THEN** warning is displayed to player
- **AND** optional auto-disable triggers

### Requirement: Context Management
The system SHALL manage conversation context for LLM with compression and summarization.

#### Scenario: Context building
- **WHEN** narrative request is made
- **THEN** world state is summarized into context
- **AND** context size is optimized for token efficiency

#### Scenario: Context overflow
- **WHEN** context exceeds token limit
- **THEN** older context is compressed or removed
- **AND** essential state is preserved

### Requirement: Prompt Templates
The system SHALL use configurable prompt templates for different narrative scenarios.

#### Scenario: Demon awakening prompt
- **WHEN** demon enters awakening phase
- **THEN** awakening prompt template is used
- **AND** demon-specific variables are substituted

#### Scenario: Player dialog prompt
- **WHEN** player initiates oracle dialog
- **THEN** dialog prompt template is used
- **AND** player request is incorporated

### Requirement: Operation Execution
The system SHALL parse and execute AI-generated operations within permission bounds.

#### Scenario: Valid operation execution
- **WHEN** AI returns spawn_hero operation and permission allows
- **THEN** hero is spawned with specified parameters
- **AND** operation is logged

#### Scenario: Invalid operation rejection
- **WHEN** AI returns operation exceeding permission level
- **THEN** operation is rejected
- **AND** error is logged

### Requirement: Content Safety
The system SHALL filter AI-generated content for safety and appropriateness.

#### Scenario: Content filtering
- **WHEN** AI generates narrative text
- **THEN** text is checked against configured filter list
- **AND** flagged content is replaced or rejected

#### Scenario: Operation rate limiting
- **WHEN** AI operations exceed configured cooldown
- **THEN** excess operations are rejected
- **AND** cooldown remaining is logged
