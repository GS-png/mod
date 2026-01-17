# Project Context

## Purpose
本项目是《WorldBox》的 MOD：**《纪元之轮：魔王轮回》**，目标是让沙盒世界模拟具备“轮回叙事”的长期演化体验。

主要目标：
- 轮回系统：纪元阶段循环推进，产生可继承的遗产（Legacy）。
- 魔王系统：10 个魔王根据玩家行为与世界状态苏醒/行动/进化。
- AI 叙事：通过 LLM 生成动态事件、神谕对话等内容，并能在 API 不可用时降级。

## Tech Stack
- C#（Unity/Mono 环境）
- WorldBox MOD 生态：NeoModLoader
- Unity API：`UnityEngine`、`UnityEngine.Networking`（HTTP 请求）、`JsonUtility`（配置序列化）
- OpenAI 风格 Chat Completions 接口（默认 `https://api.openai.com/v1/chat/completions`，可通过配置切换到兼容服务）
- 配置文件：`EraOfWheel/Resources/Config/config.json`

## Project Conventions

### Directory Structure
- `EraOfWheel/`
  - `README.md`：面向玩家/使用者的安装与功能简介。
  - `mod.json`：MOD 元信息（名称、版本、作者、目标游戏版本）。
  - `Resources/Config/config.json`：运行配置（LLM Key、模型、UI 时长、玩法参数等）。
  - `Code/`：全部 C# 逻辑代码。

- `EraOfWheel/Code/Core/`（基础设施与通用能力）
  - `ModMain.cs`：MOD 入口，负责系统初始化与卸载清理。
  - `IModSystem.cs`：子系统统一接口（`Initialize/Dispose/IsInitialized`）。
  - `EventBus.cs`：事件发布/订阅（解耦各模块）。
  - `Logger.cs`：统一日志输出。
  - `ErrorHandler.cs`：全局异常捕获与安全降级入口。
  - `Config/ConfigManager.cs` + `Config/ModConfig.cs`：配置加载/保存、LLM/玩法/UI 配置结构。
  - `Data/SaveManager.cs`：存档与遗产数据持久化（含备份恢复）。
  - `Events/`：基础事件类型（`IGameEvent`、`GameEvent`、系统事件等）。

- `EraOfWheel/Code/Cycle/`（轮回与遗产）
  - `CycleManager.cs`：轮回阶段推进与阶段事件（`PhaseChangedEvent` 等）。
  - `CycleState.cs`/`CyclePhase.cs`：轮回状态与阶段枚举/配置。
  - `LegacySystem.cs`：跨轮回永久进度（遗产点结算、解锁强化）。

- `EraOfWheel/Code/DemonLords/`（魔王体系）
  - `BaseDemonLord.cs`：魔王通用生命周期与行为接口（苏醒、封印、入侵、进化）。
  - `DemonLordFactory.cs`：注册与创建魔王实例，管理当前活跃魔王。
  - `FamineKing.cs`、`SilenceEmperor.cs` 等：各魔王的差异化行为实现。

- `EraOfWheel/Code/LLM/`（AI 叙事与对话）
  - `LLMClient.cs`：OpenAI 兼容接口调用（`/chat/completions`）。
  - `RequestQueue.cs`：请求队列（异步、默认单并发）。
  - `ContextManager.cs`：对话上下文管理与压缩。
  - `PromptTemplates.cs`：Prompt 模板与变量渲染（例如 `oracle_dialog`、`event_generation`）。
  - `NarrativeEngine.cs`：将 LLM 输出转为游戏叙事事件，失败时走 `FallbackEventPool`。
  - `OracleDialog.cs`：玩家与“神谕”的直接对话入口与快捷指令。
  - `CostMonitor.cs`：token 使用量估算/告警（成本控制）。
  - `FallbackEventPool.cs`：LLM 不可用时的后备事件库。

- `EraOfWheel/Code/UI/`（界面与提示）
  - `UIManager.cs`：创建 Canvas、注册面板、统一显示/隐藏。
  - `Panels.cs`：主要面板（轮回状态/魔王信息/设置等）。
  - `DialogWindow.cs`：对话窗口（用于神谕/角色对话展示）。
  - `NotificationSystem.cs`：通知队列与历史（订阅关键事件后弹出提示）。
  - `TutorialSystem.cs`：新手教程步骤与触发。

### Code Style
- **命名**
  - 类型/方法/属性使用 `PascalCase`。
  - 私有字段使用 `_camelCase`（例如 `_isInitialized`、`_eventQueue`）。
  - 常量/字面量优先集中在配置或模板里，避免散落在多处。
- **单例模式（约定）**
  - 绝大多数系统采用 `public static <Type> Instance { get; private set; }`。
  - 在 `Initialize()` 中设置 `Instance`，在 `Dispose()` 中清理并置空。
  - 调用侧使用空条件访问：`Xxx.Instance?.Method()`，避免初始化顺序导致崩溃。
- **日志（约定）**
  - 统一使用 `Logger.Debug/Info/Warn/Error(system, message)`。
  - `system` 字段使用子系统名（例如 `"LLMClient"`、`"EventBus"`）。
  - 重要行为需要可追踪（魔王入侵、关键事件、LLM 请求失败/降级等）。
- **代码组织**
  - 业务逻辑尽量通过事件解耦，避免 UI/LLM/玩法之间直接强引用。
  - 不在热路径（每帧/高频）中做大量分配/反射/大字符串拼接。

### Architecture Patterns
- **子系统生命周期：`IModSystem`**
  - 子系统实现 `IModSystem : IDisposable`，对外暴露 `SystemName`、`IsInitialized`、`Initialize()`。
  - `Core/ModMain.cs` 作为入口，在 `OnModLoad()` 中统一初始化核心系统，并在卸载时统一 `Dispose()`。
- **事件驱动：`EventBus`**
  - 用 `EventBus` 发布/订阅 `IGameEvent`（位于 `Core/Events`）。
  - 对外优先使用同步 `Publish`；需要解耦帧时序的使用 `PublishAsync` + `ProcessQueue`。
- **配置：`ConfigManager`**
  - 从 MOD 目录的 `Resources/Config/config.json` 加载（不存在会生成默认配置）。
  - LLM 相关配置在 `ModConfig.llm`，支持 `api_key`、`model`、`timeout_seconds`、`max_retries`、`api_base_url`。
- **LLM 请求管线**
  - `RequestQueue` 管理异步队列，默认单并发（`_maxConcurrent = 1`）。
  - `LLMClient` 使用 `UnityWebRequest` 访问 OpenAI 兼容接口。
  - 失败时允许降级（例如后备事件池/默认回复），保证游戏可继续运行。

### Testing Strategy
当前以**手动测试（游戏内验证）**为主，要求每次改动至少做以下检查：
- 启动/卸载：MOD 能正常加载、卸载无异常。
- 核心流程：轮回推进、阶段切换事件能正常触发（并能看到日志/通知）。
- 魔王流程：魔王苏醒、入侵行为、进化逻辑可触发且不报错。
- LLM 流程：
  - 配置了 `api_key` 时，能发起请求并收到回复。
  - 未配置/请求失败时，能够降级（不应卡死或反复刷错误）。

建议做法（后续可选）：对纯逻辑模块抽出可测层，增加最小化的单元测试或模拟运行脚本。

### Git Workflow
本项目采用**强制规范**（建议后续所有协作都按此执行）：

- **分支模型**
  - `main`：稳定可发布版本。
  - `develop`：日常集成分支（所有功能合入先到这里）。
  - `feature/<topic>`：新功能分支。
  - `fix/<topic>`：修复分支。
  - `chore/<topic>`：杂项（重构、格式、依赖、文档）。
- **提交信息（Conventional Commits）**
  - 格式：`<type>(<scope>): <message>`
  - `type`：`feat`/`fix`/`refactor`/`perf`/`chore`/`docs`/`test`
  - `scope`：`core`/`cycle`/`demon`/`llm`/`ui`/`config`
  - 示例：`feat(llm): add request queue backoff`
- **合并要求**
  - 禁止直接向 `main` 提交。
  - PR/MR 描述里必须包含：改动点、手动验证步骤、风险与回滚方式。

## Domain Context
- **轮回（Cycle）**：世界按阶段推进（见 `Code/Cycle`），阶段变化会触发事件与 UI 通知。
- **遗产（Legacy）**：跨轮回继承的资源/点数体系（例如 `LegacySystem`），用于长期成长。
- **魔王（Demon Lords）**：
  - 基类为 `BaseDemonLord`，包含苏醒度、封印、入侵、进化等通用逻辑。
  - 各魔王在 `Code/DemonLords` 目录下实现不同的入侵与进化规则。
- **AI 叙事（LLM）**：
  - `OracleDialog` 提供玩家与“神谕”的对话入口。
  - LLM 相关系统必须支持：超时/失败/无 Key 的稳定降级。

## Important Constraints
- **目标游戏版本**：`mod.json` 指定 `targetGameVersion: 0.51.2`，升级游戏版本可能导致 API/行为不兼容。
- **性能约束**：运行在游戏环境内，避免在每帧逻辑中执行阻塞 IO；LLM 调用必须异步（协程/队列）。
- **稳定性优先**：任何子系统失败都不应导致游戏崩溃，应记录日志并尽量降级。
- **密钥安全**：`Resources/Config/config.json` 中的 `llm.api_key` 属于敏感信息，不应提交到公共仓库；示例配置可保留空值。
- **成本控制**：LLM 调用有费用与速率限制，`CostMonitor` 用于监控 token 使用并在接近上限时告警。

## External Dependencies
- NeoModLoader（WorldBox MOD Loader）
- WorldBox 本体（目标版本 0.51.2）
- LLM 服务（OpenAI 或任意兼容 Chat Completions 的服务）
