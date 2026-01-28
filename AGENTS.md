# Repository Guidelines

## 项目结构与模块组织
`EraWheel/` 为 MOD 源码目录，核心模块有 `Core/`、`DemonLord/`、`Civilization/`、`Narrative/`、`UI/`、`Config/`、`Data/`。事件与资源在 `EraWheel/Resources/`（如 `Resources/events/*.json`），本地化在 `EraWheel/Localization/`。工具集中在 `tools/`，包括 `tools/EraWheel.SelfTest/`（逻辑自检）与 `tools/EraWheel.ApiDoc/`（API 文档）。设计资料在 `specs/002-era-wheel-demon-mod/`，生成文档在 `docs/api/`。

## 构建、测试与开发命令
- `dotnet build EraWheel/EraWheel.csproj`：构建 MOD（目标 `net48`），产出 `EraWheel.dll`。
- `dotnet run --project tools/EraWheel.SelfTest/EraWheel.SelfTest.csproj`：运行轻量自检，不依赖游戏环境。
- `dotnet run --project tools/EraWheel.ApiDoc/EraWheel.ApiDoc.csproj`：生成本地 API 文档到 `docs/api/`（可选）。

## 编码风格与命名约定
C# 9，4 空格缩进，Allman 大括号。类型与公有成员用 `PascalCase`，局部变量与参数用 `camelCase`。文件名与类型一致（如 `CycleManager.cs`），JSON 键使用 `snake_case`。项目未强制格式化工具，请保持与邻近文件一致。

## 测试指引
暂无正式单元测试框架。新增核心逻辑时，请扩展 `tools/EraWheel.SelfTest/Program.cs`，并运行自检命令尽早发现回归。

## 提交与 PR 指引
提交信息为简短单行中文摘要。PR 需包含变更说明、已运行测试（或未运行原因），并注明配置/本地化/玩法影响；UI 变更尽量附截图。

## 安全与配置提示
不要提交 `EraWheel/lib/` 下的游戏 DLL。新增功能或选项时，请同步更新 `EraWheel/mod.json` 与 `EraWheel/Config/DefaultConfig.json`，确保元数据与默认配置一致。

## 协作与沟通要求
> **语言要求（必须）**：使用中文，并在对话中通俗易懂地讲述；面向新手，避免过于专业的表述。  
> **必须使用 context7 MCP**：当不知道如何编写代码，或代码需要修复 bug 时，先调用 context7 MCP 查询权威资料再继续。  
> **特别注意（必须）**：修改或优化内容前必须查看目录树和项目架构，检查所有可能关联的地方，必要时同步更新相关文件或文档，确保整体一致性与可维护性，避免引入新 bug 或出现描述不一致。

## 开发与验证原则
- 编写代码时，优先查 `docs/api/` 中的 DLL API/类/方法/字段名，避免靠猜测堆叠降级与兜底逻辑，保持代码干净、简单、可维护。
- 当文档信息不足、需要了解更底层行为时，可通过反编译相关 DLL 理解内部逻辑，再据此编写正确实现。
- 遇到复杂问题要做充分推演与自检：明确假设、验证结论、反思边界，必要时进行 debug，目标是“可上线”的稳定品质。
- 不能直接运行游戏时，尽量用 `tools/EraWheel.SelfTest/` 增加可执行的自检覆盖。
