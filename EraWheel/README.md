# EraWheel

## 这是什么
EraWheel 是一个面向 `WorldBox 0.51.2+` 与 `NeoModLoader` 的魔王轮回 MOD。
它把“魔王来袭 -> 世界应战 -> 战后成长 -> 下一轮再战”串成长期循环。
如果你是第一次看这个仓库，可以先把它理解成一套会不断重开的世界大战系统。

## 当前仓库里已经有什么
- `Assets/Art/`：MOD 运行时直接读取的美术资源。
- `src/`：当前实现源码。
- `docs/`：启动自检、轮回脚本、存档回归、成长回归、压力测试、发布说明和发布前检查表。
- `Locales/`：中英文文本键。
- `default_config.json`：默认玩法参数。
- `mod.json`：模组身份和基础元数据。

## 推荐阅读顺序
1. 先看 `设计/EraWheel_Redesign.md`。它负责讲玩法总览。
2. 再看 `设计/EraWheel_实现口径.md`。它负责讲系统边界和实现口径。
3. 想查具体参数时，再看 `设计/ERRE附属文档/系统参数总表.md`。
4. 准备联调时，直接进 `EraWheel/docs/` 按 `EW-114` 到 `EW-121` 的顺序走。

## 当前目录结构
```text
EraWheel/
  mod.json
  README.md
  default_config.json
  icon.png
  Assets/
    Art/
  Locales/
  docs/
  src/
```

## 构建与验证
1. 先跑源码级编译冒烟：`dotnet build .codex/tmp/neomod_smoke/EraWheel.NeomodSmoke.csproj`。
2. 这一步只能证明“代码还能编”。它不能替代真实游戏联调。
3. 进实机前，先看 `docs/EW-114_启动自检清单.md`。
4. 真正的轮回、存档、成长和压力验证，要按 `EW-115` 到 `EW-119` 的手工脚本逐项回填。

## 兼容口径
- 当前设计目标平台：`WorldBox 0.51.2+`。
- 当前模组入口：`NeoModLoader.api.BasicMod<T>`。
- 当前仓库内已确认的是源码级编译链路，不是完整实机兼容矩阵。

## 当前边界
- 仓库里还没有正式的产物打包工程，也没有一键发布脚本。
- 仓库里也没有可直接启动的本地 WorldBox 实机环境。
- 所以当前最可靠的交付方式，是把文档、构建闸门和实机脚本写清楚，再把真实结果逐次回填。
