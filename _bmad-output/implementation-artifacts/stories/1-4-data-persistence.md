# Story 1.4: 数据持久化

Status: review

## Story

As a **玩家**,
I want **我的游戏进度能够被保存和恢复**,
so that **我可以在任何时候继续之前的游戏，并且我的遗产数据能够跨存档保留**。

## Acceptance Criteria

1. **AC1**: 存档文件正确序列化/反序列化
2. **AC2**: 支持版本号和数据迁移机制
3. **AC3**: 存档损坏时有恢复策略
4. **AC4**: 遗产数据独立于存档持久化
5. **AC5**: 支持多个存档槽位

## Tasks / Subtasks

- [x] Task 1: 定义存档数据结构 (AC: 1)
  - [x] 创建`SaveData`类
  - [x] 创建`LegacyData`类（跨存档）

- [x] Task 2: 实现SaveManager核心 (AC: 1, 5)
  - [x] 创建`SaveManager`单例类
  - [x] 实现Save/Load方法
  - [x] 支持多存档槽位 (3个)

- [x] Task 3: 版本迁移机制 (AC: 2)
  - [x] 存档包含版本号
  - [x] 实现MigrateIfNeeded()方法

- [x] Task 4: 错误恢复 (AC: 3)
  - [x] 备份机制 (.backup文件)
  - [x] TryRecoverFromBackup()恢复

- [x] Task 5: 集成到ModMain (AC: 1)

## Dev Notes

### 文件结构
- `saves/save_{slot}.json` - 存档文件
- `legacy.json` - 遗产数据（跨存档）

### References
- [Source: game-architecture.md#Data Persistence]

## Dev Agent Record

### Agent Model Used

Claude (Cascade)

### Debug Log References

无

### Completion Notes List

- 2026-01-17: 创建SaveData和LegacyData数据结构
- 2026-01-17: 实现SaveManager核心功能
- 2026-01-17: 实现备份和恢复机制
- 2026-01-17: 集成到ModMain

### File List

- `EraOfWheel/Code/Core/Data/SaveData.cs` - 存档数据结构
- `EraOfWheel/Code/Core/Data/SaveManager.cs` - 存档管理器
- `EraOfWheel/Code/Core/ModMain.cs` - 更新集成SaveManager
