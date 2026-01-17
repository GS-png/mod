# Story 1.1: MOD入口与初始化

Status: review

## Story

As a **MOD开发者**,
I want **创建ModMain.cs作为MOD入口点，实现NeoModLoader接口**,
so that **WorldBox可以正确加载、初始化和卸载我的MOD**。

## Acceptance Criteria

1. **AC1**: ModMain类正确实现NeoModLoader的ModEntry接口
2. **AC2**: MOD可被WorldBox正确识别和加载
3. **AC3**: 初始化时输出日志确认MOD已加载
4. **AC4**: 卸载时正确清理所有资源和事件订阅
5. **AC5**: mod.json元数据文件正确配置

## Tasks / Subtasks

- [x] Task 1: 创建项目基础结构 (AC: 1, 5)
  - [x] 创建`EraOfWheel/`目录结构
  - [x] 创建`mod.json`元数据文件
  - [x] 创建`Code/Core/`目录

- [x] Task 2: 实现ModMain类 (AC: 1, 2, 3)
  - [x] 创建`ModMain.cs`继承NeoModLoader基类
  - [x] 实现`OnModLoad()`方法
  - [x] 实现`OnModUnload()`方法
  - [x] 添加初始化日志输出

- [x] Task 3: 资源清理机制 (AC: 4)
  - [x] 实现`Dispose()`模式
  - [x] 注册需要清理的资源列表
  - [x] 确保事件订阅正确取消

- [ ] Task 4: 验证加载流程 (AC: 2, 3) - 待用户在游戏中验证
  - [ ] 在WorldBox中测试MOD加载
  - [ ] 确认日志输出正常
  - [ ] 确认卸载后无残留

## Dev Notes

### 架构约束
- 必须遵循NeoModLoader的MOD生命周期
- 日志使用统一格式: `[INFO] [ModMain] 消息内容`
- 所有初始化应在`OnModLoad()`中完成

### 项目结构
```
EraOfWheel/
├── Code/
│   └── Core/
│       └── ModMain.cs
└── mod.json
```

### 命名约定
- 命名空间: `EraOfWheel.Core`
- 类名: PascalCase
- 方法名: PascalCase

### References

- [Source: game-architecture.md#Project Structure]
- [Source: game-architecture.md#Cross-cutting Concerns]
- [Source: epics.md#Story 1.1]

## Dev Agent Record

### Agent Model Used

Claude (Cascade)

### Debug Log References

无

### Completion Notes List

- 2026-01-17: 创建项目基础结构
- 2026-01-17: 实现ModMain类，包含OnModLoad/OnModUnload
- 2026-01-17: 实现IDisposable资源清理机制
- 2026-01-17: 创建配置文件和README
- Task 4待用户在WorldBox中验证

### File List

- `EraOfWheel/mod.json` - MOD元数据
- `EraOfWheel/README.md` - 说明文档
- `EraOfWheel/Code/Core/ModMain.cs` - MOD入口类
- `EraOfWheel/Code/Core/IModSystem.cs` - 系统接口
- `EraOfWheel/Resources/Config/config.json` - 配置文件
