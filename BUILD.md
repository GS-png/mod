# 纪元之轮 MOD 编译指南

## 编译环境要求

### 必需的 Unity DLL 文件

项目编译需要以下 Unity DLL 文件，请从 WorldBox 游戏目录复制到 `EraWheel/lib/` 目录：

**游戏目录路径**: `<WorldBox安装目录>/WorldBox_Data/Managed/`

| DLL 文件 | 说明 | 是否必需 |
|----------|------|----------|
| `Assembly-CSharp.dll` | 游戏核心逻辑 | ✅ 必需 |
| `UnityEngine.dll` | Unity 核心 | ✅ 必需 |
| `UnityEngine.CoreModule.dll` | Unity 核心模块 | ✅ 必需 |
| `UnityEngine.UI.dll` | Unity UI 系统 | ✅ 必需 |
| `UnityEngine.IMGUIModule.dll` | Unity IMGUI 模块 | ✅ 必需 |
| `NeoModLoader.dll` | MOD 加载器 | ✅ 必需 |

### 复制 DLL 步骤

```bash
# Windows PowerShell 示例
$worldboxPath = "C:\Program Files (x86)\Steam\steamapps\common\worldbox"
$libPath = "EraWheel\lib"

Copy-Item "$worldboxPath\WorldBox_Data\Managed\Assembly-CSharp.dll" $libPath
Copy-Item "$worldboxPath\WorldBox_Data\Managed\UnityEngine.dll" $libPath
Copy-Item "$worldboxPath\WorldBox_Data\Managed\UnityEngine.CoreModule.dll" $libPath
Copy-Item "$worldboxPath\WorldBox_Data\Managed\UnityEngine.UI.dll" $libPath
Copy-Item "$worldboxPath\WorldBox_Data\Managed\UnityEngine.IMGUIModule.dll" $libPath
Copy-Item "$worldboxPath\Mods\NeoModLoader\NeoModLoader.dll" $libPath
```

## 编译命令

```bash
cd /mnt/c/Users/14745/Desktop/mod
dotnet build EraWheel/EraWheel.csproj
```

## 部署到游戏

编译成功后，将以下文件/目录复制到游戏 Mods 目录：

```
WorldBox/Mods/EraWheel/
├── EraWheel.dll          # 编译输出
├── mod.json              # MOD 元数据
├── Config/               # 配置文件
├── Localization/         # 本地化文件
└── Resources/            # 资源文件
    ├── events/           # 事件池 JSON
    └── sprites/          # 精灵图（占位）
```

## 常见问题

### Q: 编译报 "GUIStyle" 或 "GUILayout" 找不到
**A**: 需要复制 `UnityEngine.IMGUIModule.dll` 到 lib 目录

### Q: 编译报 "NeoModLoader" 找不到
**A**: 需要从游戏的 Mods/NeoModLoader 目录复制 `NeoModLoader.dll`

### Q: 运行时 MOD 没有加载
**A**: 检查 mod.json 文件格式是否正确，确保放置在正确的 Mods 目录下

## 版本兼容性

- **WorldBox**: 0.51.2+
- **.NET Framework**: 4.8
- **NeoModLoader**: 最新版本

## 测试验证

1. 启动游戏，确认控制面板按钮出现
2. 打开控制面板，检查所有标签页正常显示
3. 创建新世界，等待繁荣度触发第一次轮回
4. 完成至少2次完整轮回验证闭环

---
*最后更新: 2026-01-20*
