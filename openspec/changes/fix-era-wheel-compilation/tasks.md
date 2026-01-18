# Tasks: 修复 EraOfWheel 编译失败（NeoModLoader）

## 1. 修复编译错误（必须先过编译）
- [x] 1.1 修复 `EraOfWheel/Code/DemonLords/Legion/LegionManager.cs`：`Logger` 命名冲突（`CS0104`）
- [x] 1.2 修复 `EraOfWheel/Code/DemonLords/PlagueMother.cs`：城市 id 类型不匹配（`CS0266`）

## 2. 回归验证（以 Player.log 为准）
- [ ] 2.1 启动 WorldBox（NeoModLoader 环境）
- [ ] 2.2 打开 `C:/Users/14745/AppData/LocalLow/mkarpenko/WorldBox/Player.log`（WSL 路径：`/mnt/c/Users/14745/AppData/LocalLow/mkarpenko/WorldBox/Player.log`）
- [ ] 2.3 确认不再出现 `error CS0104` / `error CS0266` / `Failed to compile mod Era Wheel - Demon Lord Reincarnation`
- [ ] 2.4 确认能看到 MOD 的初始化成功日志（例如 `initialized successfully`）

## 3. 继续优化（放到下一阶段做）
- [ ] 3.1 在 MOD 正常加载后，再基于真实运行报错/性能表现做优化清单
