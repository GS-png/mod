# Story 1.3: 配置管理器

Status: review

## Story

As a **玩家**,
I want **通过配置文件自定义MOD的各项参数**,
so that **我可以根据自己的偏好调整游戏体验，包括API设置和游戏参数**。

## Acceptance Criteria

1. **AC1**: 正确读取config.json配置文件
2. **AC2**: 支持运行时修改配置
3. **AC3**: 配置变更时触发事件通知
4. **AC4**: 支持配置热重载（不需重启）
5. **AC5**: 配置值有类型安全的访问方法

## Tasks / Subtasks

- [x] Task 1: 定义配置数据结构 (AC: 5)
  - [x] 创建`ModConfig`类定义所有配置项
  - [x] 创建`LLMConfig`子配置类
  - [x] 创建`GameplayConfig`子配置类

- [x] Task 2: 实现ConfigManager核心 (AC: 1, 2)
  - [x] 创建`ConfigManager`单例类
  - [x] 实现JSON文件读取
  - [x] 实现配置值的Get/Set方法
  - [x] 处理配置文件不存在的情况

- [x] Task 3: 配置变更通知 (AC: 3)
  - [x] 配置修改时发布`ConfigChangedEvent`
  - [x] 支持监听特定配置项变更

- [x] Task 4: 热重载支持 (AC: 4)
  - [x] 实现`Reload()`方法
  - [x] 实现`HasFileChanged()`检测

- [x] Task 5: 集成到ModMain (AC: 1)
  - [x] 在ModMain中初始化ConfigManager
  - [x] 在卸载时保存配置

## Dev Notes

### 架构约束
- 必须通过`ConfigManager`访问配置
- 配置文件路径: `Resources/Config/config.json`

### References

- [Source: game-architecture.md#Configuration]
- [Source: epics.md#Story 1.3]

## Dev Agent Record

### Agent Model Used

Claude (Cascade)

### Debug Log References

无

### Completion Notes List

- 2026-01-17: 创建ModConfig和子配置类
- 2026-01-17: 实现ConfigManager核心功能
- 2026-01-17: 集成到ModMain

### File List

- `EraOfWheel/Code/Core/Config/ModConfig.cs` - 配置数据结构
- `EraOfWheel/Code/Core/Config/ConfigManager.cs` - 配置管理器
- `EraOfWheel/Code/Core/ModMain.cs` - 更新集成ConfigManager
