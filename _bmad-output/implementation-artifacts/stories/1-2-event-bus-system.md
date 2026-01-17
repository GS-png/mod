# Story 1.2: 事件总线系统

Status: review

## Story

As a **MOD开发者**,
I want **实现一个解耦的事件总线系统**,
so that **各个系统可以通过事件进行通信，而不需要直接引用彼此**。

## Acceptance Criteria

1. **AC1**: EventBus支持泛型事件类型的订阅和发布
2. **AC2**: 支持同步事件处理
3. **AC3**: 支持异步事件处理（协程友好）
4. **AC4**: 订阅者可以正确取消订阅
5. **AC5**: 无内存泄漏（弱引用或手动清理）
6. **AC6**: 提供便捷的事件基类

## Tasks / Subtasks

- [x] Task 1: 定义事件基类 (AC: 6)
  - [x] 创建`IGameEvent`接口
  - [x] 创建`GameEvent`基类，包含时间戳和事件ID
  - [x] 创建示例事件类型（SystemEvent, CycleEvent）

- [x] Task 2: 实现EventBus核心 (AC: 1, 2)
  - [x] 创建`EventBus`单例类
  - [x] 实现`Subscribe<T>(Action<T>)`方法
  - [x] 实现`Publish<T>(T event)`方法
  - [x] 使用字典管理事件类型到处理器的映射

- [x] Task 3: 实现取消订阅 (AC: 4, 5)
  - [x] 实现`Unsubscribe<T>(Action<T>)`方法
  - [x] 返回`IDisposable`用于自动取消订阅
  - [x] 实现`ClearAll()`清理所有订阅

- [x] Task 4: 异步事件支持 (AC: 3)
  - [x] 实现`PublishAsync<T>(T event)`方法
  - [x] 实现`ProcessQueue()`处理队列
  - [x] 添加事件队列用于延迟处理

- [x] Task 5: 集成到ModMain (AC: 1)
  - [x] 在ModMain中初始化EventBus
  - [x] 在卸载时清理所有订阅
  - [x] 添加示例事件发布

## Dev Notes

### 架构约束
- 必须通过`EventBus.Emit()`发送事件
- 事件处理器不应阻塞主线程
- 异常处理：单个处理器失败不影响其他处理器

### 设计模式
- 观察者模式
- 单例模式（EventBus实例）

### 项目结构
```
EraOfWheel/Code/Core/
├── EventBus.cs           # 事件总线核心
├── Events/
│   ├── IGameEvent.cs     # 事件接口
│   ├── GameEvent.cs      # 事件基类
│   └── SystemEvents.cs   # 系统事件定义
```

### 命名约定
- 事件类名后缀`Event`
- 处理器方法前缀`On`

### References

- [Source: game-architecture.md#Event System]
- [Source: game-architecture.md#Implementation Patterns]
- [Source: epics.md#Story 1.2]

## Dev Agent Record

### Agent Model Used

Claude (Cascade)

### Debug Log References

无

### Completion Notes List

- 2026-01-17: 创建IGameEvent接口和GameEvent基类
- 2026-01-17: 实现EventBus核心功能（订阅/发布/取消）
- 2026-01-17: 实现异步事件队列
- 2026-01-17: 创建系统事件定义
- 2026-01-17: 集成到ModMain

### File List

- `EraOfWheel/Code/Core/EventBus.cs` - 事件总线核心
- `EraOfWheel/Code/Core/Events/IGameEvent.cs` - 事件接口
- `EraOfWheel/Code/Core/Events/GameEvent.cs` - 事件基类
- `EraOfWheel/Code/Core/Events/SystemEvents.cs` - 系统事件定义
- `EraOfWheel/Code/Core/ModMain.cs` - 更新集成EventBus
