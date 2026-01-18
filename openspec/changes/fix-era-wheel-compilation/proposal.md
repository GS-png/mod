# Change: 修复 EraOfWheel 在 NeoModLoader 下编译失败

## Why
当前 MOD 在 NeoModLoader 加载阶段会触发脚本编译错误，导致 MOD **无法加载/无法运行**。从 Windows 侧 `Player.log` 可以看到主要是两类 C# 编译错误：
- `CS0104`：`Logger` 名称在 `EraOfWheel.Core.Logger` 与 `UnityEngine.Logger` 之间产生歧义
- `CS0266`：`PlagueMother.cs` 中把 `long` 当作 `int` 使用导致隐式转换失败

## What Changes
- 修复 `LegionManager.cs` 的 `Logger` 命名冲突（使用别名或显式限定命名空间，保证全文件一致）。
- 修复 `PlagueMother.cs` 的城市 id 类型兼容问题（确保 `city.data.id` 的类型在本 MOD 的数据结构中能安全使用）。
- 增加最小化的“回归验证步骤”（以 `Player.log` 中不再出现 `error CS` 为准）。

## Impact
- **Affected code**:
  - `EraOfWheel/Code/DemonLords/Legion/LegionManager.cs`
  - `EraOfWheel/Code/DemonLords/PlagueMother.cs`
- **Expected player-visible impact**:
  - MOD 能正常通过 NeoModLoader 的编译/加载流程（从“无法加载”恢复到“可加载”）。
  - 该变更不引入新的玩法内容，仅为恢复可用性与基础健壮性。
