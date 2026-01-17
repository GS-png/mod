# UI Panel Specification

## ADDED Requirements

### Requirement: Main Control Panel
The system SHALL provide a main control panel with tabs for Overview, Demon Management, Civilization Status, AI Control, and Settings.

#### Scenario: Panel toggle
- **WHEN** player presses configured hotkey
- **THEN** main panel toggles visibility
- **AND** remembers last active tab

#### Scenario: Tab navigation
- **WHEN** player clicks tab header
- **THEN** corresponding panel content is displayed
- **AND** other tabs are hidden

### Requirement: Overview Panel
The system SHALL display current cycle, world age, phase, enabled demons, civilization strength, and legendary heroes.

#### Scenario: Cycle information display
- **WHEN** overview panel is active
- **THEN** current cycle count and phase are displayed
- **AND** time until next phase transition is shown

#### Scenario: Demon status summary
- **WHEN** overview panel is active
- **THEN** enabled demons show seal strength and estimated awakening time
- **AND** disabled demons show as inactive

### Requirement: Demon Management Panel
The system SHALL allow viewing and configuring individual demon lords.

#### Scenario: Demon detail view
- **WHEN** player selects a demon
- **THEN** stats, abilities, generals, and history are displayed
- **AND** configuration options are available

#### Scenario: Manual demon control
- **WHEN** player clicks "Force Awaken" button
- **THEN** confirmation dialog appears
- **AND** demon awakens on confirmation

### Requirement: AI Control Panel
The system SHALL display LLM connection status, permission level, and operation history.

#### Scenario: Connection status display
- **WHEN** AI panel is active
- **THEN** current connection status is shown
- **AND** model name and remaining tokens are displayed

#### Scenario: Operation history
- **WHEN** AI performs operations
- **THEN** operations are logged in history list
- **AND** undo option is available for recent operations

### Requirement: Settings Panel
The system SHALL provide configurable settings for core gameplay, difficulty, and debug tools.

#### Scenario: Difficulty adjustment
- **WHEN** player adjusts demon power multiplier slider
- **THEN** value updates in real-time
- **AND** change takes effect immediately or on next cycle

#### Scenario: Configuration export
- **WHEN** player clicks "Export Config"
- **THEN** current settings are saved to JSON file
- **AND** API key is excluded from export

### Requirement: Notification System
The system SHALL display notifications for important events with queue management.

#### Scenario: Event notification
- **WHEN** significant event occurs (demon awakening, hero death, etc.)
- **THEN** notification appears on screen
- **AND** notification auto-dismisses after configured duration

#### Scenario: Notification history
- **WHEN** player opens notification history
- **THEN** recent notifications are listed
- **AND** player can click to view details

### Requirement: Debug Tools Panel
The system SHALL provide debug tools in developer mode for testing and troubleshooting.

#### Scenario: Debug mode access
- **WHEN** debug mode is enabled in config
- **THEN** debug tools tab appears in settings
- **AND** dangerous operations show warning

#### Scenario: Force cycle trigger
- **WHEN** player clicks "Force Next Cycle" in debug
- **THEN** confirmation with warning appears
- **AND** cycle advances on confirmation

### Requirement: Configuration Validation
The system SHALL validate all UI inputs and provide safe defaults for invalid values.

#### Scenario: Range validation
- **WHEN** player enters value outside valid range
- **THEN** value is clamped to valid range
- **AND** warning message is shown

#### Scenario: Configuration backup
- **WHEN** configuration is modified
- **THEN** previous configuration is backed up
- **AND** restore option is available

### Requirement: Localization Support
The system SHALL support multiple languages with runtime switching.

#### Scenario: Language selection
- **WHEN** player selects different language
- **THEN** UI text updates to selected language
- **AND** preference is saved

#### Scenario: Missing translation fallback
- **WHEN** translation key is missing for current language
- **THEN** English fallback is used
- **AND** missing key is logged
