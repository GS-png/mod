# 纪元之轮：魔王轮回 (Era Wheel - Demon Lord Reincarnation Cycle)

WorldBox MOD - 将沙盒世界变为史诗叙事引擎

## 核心特性

- **轮回系统**: 6阶段循环（封印→预兆→苏醒→降临→全盛→衰弱）
- **魔王体系**: 10个独特魔王，各具特色的入侵机制
- **遗产继承**: 跨轮回的文明成长与积累
- **动态叙事**: AI驱动的事件生成（可选）

## 安装方法

### 方法1: 源码安装（推荐）
1. 确保已安装 NeoModLoader
2. 将整个 `EraOfWheel` 文件夹复制到：
   - Windows: `C:\Program Files (x86)\Steam\steamapps\common\worldbox\Mods\`
   - Linux: `~/.local/share/Steam/steamapps/common/worldbox/Mods/`
3. 启动游戏，NeoModLoader会自动编译加载

### 方法2: DLL安装
1. 使用Visual Studio或dotnet CLI编译项目
2. 将生成的 `EraOfWheel.dll` 和 `mod.json` 复制到Mods目录
3. 同时复制 `Resources` 和 `Locales` 文件夹

## 目录结构
```
Mods/
└── EraOfWheel/
    ├── mod.json          # MOD元信息（必需）
    ├── Code/             # C#源代码
    │   ├── Core/         # 核心系统
    │   ├── Cycle/        # 轮回系统
    │   ├── DemonLords/   # 魔王系统
    │   └── UI/           # 界面系统
    ├── Resources/
    │   └── Config/
    │       └── config.json  # 配置文件
    └── Locales/          # 本地化文件
```

## 配置

编辑 `Resources/Config/config.json` 自定义游戏参数：
- 轮回触发条件
- 魔王强度
- 遗产效果
- LLM API设置（可选）

## 快捷键

- `F8`: 打开/关闭MOD控制面板

## 版本

- 当前版本: 0.1.0 (MVP)
- 目标游戏版本: WorldBox 0.51.2

## 兼容性

- 需要 NeoModLoader
- 支持 Windows / Linux / macOS

## 故障排除

如果MOD无法加载：
1. 检查NeoModLoader是否正确安装
2. 确认mod.json文件存在且格式正确
3. 查看游戏日志中的`[EraOfWheel]`相关信息

## 许可

MIT License
