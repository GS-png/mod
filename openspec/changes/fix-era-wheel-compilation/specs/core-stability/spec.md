# Core Stability Specification (Delta)

## ADDED Requirements

### Requirement: Mod compilation succeeds under NeoModLoader
The system SHALL compile successfully when loaded by NeoModLoader, without any C# compilation errors.

#### Scenario: Successful compile and load
- **WHEN** WorldBox starts with NeoModLoader and the EraOfWheel mod enabled
- **THEN** the mod compiles without `error CS` entries
- **AND** the log does not contain `Failed to compile mod Era Wheel - Demon Lord Reincarnation`
