# Quick Start Guide: 纪元之轮：魔王轮回 MOD

**Version**: 1.0.3  
**Date**: 2026-01-19

---

## 开发环境准备

### 1. 必要软件

| 软件 | 版本要求 | 用途 |
|------|---------|------|
| WorldBox | 0.51.2+ | 目标游戏 |
| NeoModLoader | 最新版 | MOD 加载框架 |
| Visual Studio / Rider | 2022+ | C# IDE |
| .NET SDK | 4.7.2+ | 编译目标 |
| dnSpy | 任意版本 | 反编译工具（可选） |

### 2. 获取 WorldBox 程序集

```bash
# WorldBox 安装目录下
# Windows: C:\Program Files (x86)\Steam\steamapps\common\worldbox\
# Mac: ~/Library/Application Support/Steam/steamapps/common/worldbox/

# 复制以下文件到项目 lib/ 目录
cp worldbox_Data/Managed/Assembly-CSharp.dll ./lib/
cp worldbox_Data/Managed/UnityEngine.dll ./lib/
cp worldbox_Data/Managed/UnityEngine.CoreModule.dll ./lib/
cp worldbox_Data/Managed/UnityEngine.UI.dll ./lib/
cp worldbox_Data/Managed/UnityEngine.JSONSerializeModule.dll ./lib/
```

### 3. NeoModLoader 依赖

```bash
# 从 NeoModLoader 发布页获取
# https://github.com/WorldBoxOpenMods/ModLoader

cp NeoModLoader.dll ./lib/
```

---

## 项目初始化

### 1. 创建项目结构

```bash
mkdir EraWheel
cd EraWheel

# 创建目录结构
mkdir -p Config Core DemonLord Civilization Narrative UI Data Localization Resources/sprites Resources/events
```

### 2. 创建 .csproj 文件

```xml
<!-- EraWheel.csproj -->
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net48</TargetFramework>
    <AssemblyName>EraWheel</AssemblyName>
    <OutputType>Library</OutputType>
    <LangVersion>9.0</LangVersion>
  </PropertyGroup>

  <ItemGroup>
    <Reference Include="Assembly-CSharp">
      <HintPath>lib/Assembly-CSharp.dll</HintPath>
      <Private>false</Private>
    </Reference>
    <Reference Include="UnityEngine">
      <HintPath>lib/UnityEngine.dll</HintPath>
      <Private>false</Private>
    </Reference>
    <Reference Include="UnityEngine.CoreModule">
      <HintPath>lib/UnityEngine.CoreModule.dll</HintPath>
      <Private>false</Private>
    </Reference>
    <Reference Include="UnityEngine.UI">
      <HintPath>lib/UnityEngine.UI.dll</HintPath>
      <Private>false</Private>
    </Reference>
    <Reference Include="UnityEngine.JSONSerializeModule">
      <HintPath>lib/UnityEngine.JSONSerializeModule.dll</HintPath>
      <Private>false</Private>
    </Reference>
    <Reference Include="UnityEngine.IMGUIModule" Condition="Exists('lib/UnityEngine.IMGUIModule.dll')">
      <HintPath>lib/UnityEngine.IMGUIModule.dll</HintPath>
      <Private>false</Private>
    </Reference>
    <Reference Include="NeoModLoader">
      <HintPath>lib/NeoModLoader.dll</HintPath>
      <Private>false</Private>
    </Reference>
  </ItemGroup>

  <ItemGroup>
    <None Update="mod.json">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
    <None Update="Config/**">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
    <None Update="Resources/**">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
    <None Update="Localization/**">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
  </ItemGroup>
</Project>
```

### 3. 创建 mod.json

```json
{
  "name": "Era Wheel - Demon Lord Reincarnation",
  "author": "Your Name",
  "version": "1.0.3",
  "description": "纪元之轮：魔王轮回 - 将WorldBox变为自我演化的史诗叙事引擎",
  "iconPath": "icon.png",
  "targetGameVersion": "0.51.2",
  "dependencies": []
}
```

---

## 核心代码模板

### 1. MOD 入口点 (Main.cs)

```csharp
using NeoModLoader.api;
using NeoModLoader.General;
using UnityEngine;

namespace EraWheel
{
    public class Main : BasicMod<Main>
    {
        // MOD 实例
        public static Main Instance { get; private set; }
        
        // 核心系统
        public CycleManager CycleManager { get; private set; }
        public DemonLordRegistry DemonLordRegistry { get; private set; }
        public ConfigManager ConfigManager { get; private set; }
        public EventPool EventPool { get; private set; }
        
        protected override void OnModLoad()
        {
            Instance = this;
            LogInfo("Era Wheel MOD 正在加载...");
            
            // 1. 初始化配置
            ConfigManager = new ConfigManager();
            ConfigManager.Load();
            
            // 2. 注册自定义资源
            RegisterTraits();
            RegisterUnits();
            
            // 3. 初始化核心系统
            CycleManager = new CycleManager();
            DemonLordRegistry = new DemonLordRegistry();
            EventPool = new EventPool();
            
            // 4. 注册UI
            RegisterUI();
            
            // 5. 订阅游戏事件
            SubscribeGameEvents();
            
            LogInfo("Era Wheel MOD 加载完成!");
        }
        
        private void RegisterTraits()
        {
            // 注册遗产特性
            LegacyTraitFactory.RegisterLegacyTraits();
            // 注册魔王专属特性
            DemonTraitFactory.RegisterDemonTraits();
        }
        
        private void RegisterUnits()
        {
            // 注册魔王单位模板
            DemonLordFactory.RegisterAllDemonLords();
            // 注册将领单位模板
            GeneralFactory.RegisterAllGenerals();
            // 注册军团单位模板
            LegionUnitFactory.RegisterAllLegionUnits();
        }
        
        private void RegisterUI()
        {
            // 添加控制面板按钮
            PowerButtons.CreateButton(
                "era_wheel_panel",
                ToolBox.LoadSprite("mods/EraWheel/icon.png"),
                "打开纪元之轮控制面板",
                () => ControlPanel.Show()
            );
        }
        
        private void SubscribeGameEvents()
        {
            // 每帧更新
            WorldBehaviourUpdateManager.addUpdateCallback(OnUpdate);
            
            // 存档事件
            SaveManager.OnSave += OnGameSave;
            SaveManager.OnLoad += OnGameLoad;
        }
        
        private void OnUpdate()
        {
            // 分层更新调度
            UpdateScheduler.Update();
        }
        
        private void OnGameSave()
        {
            var saveData = new ModSaveData
            {
                ModVersion = Version,
                CycleData = CycleManager.GetSaveData(),
                DemonLordData = DemonLordRegistry.GetSaveData()
            };
            SaveManager.SaveModData("era_wheel", saveData);
        }
        
        private void OnGameLoad()
        {
            var saveData = SaveManager.LoadModData<ModSaveData>("era_wheel");
            if (saveData != null)
            {
                CycleManager.LoadSaveData(saveData.CycleData);
                DemonLordRegistry.LoadSaveData(saveData.DemonLordData);
            }
        }
    }
}
```

---

### 2. 轮回管理器骨架 (Core/CycleManager.cs)

```csharp
namespace EraWheel.Core
{
    public class CycleManager
    {
        public int CycleCount { get; private set; }
        public EraPhase CurrentPhase { get; private set; }
        public float SealStrength { get; private set; }
        
        private EraStateMachine _stateMachine;
        private List<CycleSummary> _cycleHistory;
        
        public event Action<EraPhase, EraPhase> OnPhaseChanged;
        public event Action<int> OnCycleCompleted;
        
        public CycleManager()
        {
            _stateMachine = new EraStateMachine();
            _cycleHistory = new List<CycleSummary>();
            
            _stateMachine.OnPhaseChanged += HandlePhaseChanged;
            
            Reset();
        }
        
        public void Reset()
        {
            CycleCount = 0;
            CurrentPhase = EraPhase.Sealed;
            SealStrength = 100f;
        }
        
        public void Update()
        {
            // 更新封印强度衰减
            if (CurrentPhase == EraPhase.Sealed)
            {
                UpdateSealDecay();
            }
            
            // 检查状态转换
            _stateMachine.TryTransition(this);
        }
        
        private void UpdateSealDecay()
        {
            var config = Main.Instance.ConfigManager.Config;
            var decayRate = config.Cycle.Seal.DecayRatePerYear;
            
            // 每游戏年衰减
            SealStrength = Mathf.Max(0, SealStrength - decayRate);
        }
        
        private void HandlePhaseChanged(EraPhase from, EraPhase to)
        {
            CurrentPhase = to;
            
            // 轮回完成特殊处理
            if (from == EraPhase.Resealed && to == EraPhase.Sealed)
            {
                CycleCount++;
                OnCycleCompleted?.Invoke(CycleCount);
            }
            
            OnPhaseChanged?.Invoke(from, to);
        }
        
        // 调试方法
        public void ForcePhase(EraPhase phase)
        {
            var from = CurrentPhase;
            CurrentPhase = phase;
            OnPhaseChanged?.Invoke(from, phase);
        }
        
        public void ForceCycleCount(int count)
        {
            CycleCount = Mathf.Clamp(count, 0, 999);
        }
        
        public void ForceSealStrength(float strength)
        {
            SealStrength = Mathf.Clamp(strength, 0, 100);
        }
    }
}
```

### 3. 魔王基类骨架 (DemonLord/DemonLordBase.cs)

```csharp
namespace EraWheel.DemonLord
{
    public abstract class DemonLordBase
    {
        public string Id { get; protected set; }
        public string NameKey { get; protected set; }
        public DemonLordType Type { get; protected set; }
        public DemonLordConfig Config { get; protected set; }
        
        public bool Enabled { get; set; }
        public DemonLordState State { get; protected set; }
        public float CurrentHealth { get; protected set; }
        public float MaxHealth { get; protected set; }
        
        public List<General> Generals { get; protected set; }
        public LegionWaveState LegionState { get; protected set; }
        
        public Actor GameActor { get; protected set; }
        
        protected DemonLordBase(string id, DemonLordConfig config)
        {
            Id = id;
            Config = config;
            Generals = new List<General>();
            LegionState = new LegionWaveState();
            Reset();
        }
        
        public virtual void Reset()
        {
            State = DemonLordState.Sealed;
            CurrentHealth = Config.BaseHealth;
            MaxHealth = Config.BaseHealth;
            Generals.Clear();
            LegionState.Reset();
        }
        
        public virtual void OnAwaken(int cycleCount)
        {
            // 计算轮回成长
            var growthMultiplier = CalculateGrowthMultiplier(cycleCount);
            MaxHealth = Config.BaseHealth * growthMultiplier;
            CurrentHealth = MaxHealth;
            
            State = DemonLordState.Awakening;
            
            // 生成魔王实体
            SpawnGameActor();
            
            // 创建据点
            CreateStronghold();
        }
        
        protected virtual float CalculateGrowthMultiplier(int cycleCount)
        {
            // 对数增长: 1 + 0.15 * ln(cycle + 1)
            var growth = 1f + Config.CycleGrowthRate * Mathf.Log(cycleCount + 1);
            return Mathf.Clamp(growth, 1f, 1f + Config.GrowthCap);
        }
        
        protected abstract void SpawnGameActor();
        protected abstract void CreateStronghold();
        
        // 独特机制接口
        public abstract void OnKill(Actor victim);
        public abstract void OnDamageDealt(Actor target, float damage);
        public abstract void OnDamageTaken(Actor attacker, float damage);
        public abstract void UpdateUniqueMechanic();
    }
}
```

---

## 构建与测试

### 1. 编译

```bash
dotnet build -c Release
```

### 2. 部署到游戏

```bash
# 复制到 MOD 目录
# Windows
cp -r bin/Release/net48/* "%APPDATA%/LocalLow/maxim/worldbox/mods/EraWheel/"

# Mac
cp -r bin/Release/net48/* ~/Library/Application\ Support/maxim/worldbox/mods/EraWheel/
```

### 3. 测试清单

#### MVP 验收测试

- [ ] 启动游戏，MOD 正常加载无报错
- [ ] 控制面板按钮可见且可点击
- [ ] 总览页面正确显示轮回数、阶段、封印强度
- [ ] 魔王管理页面可启用/禁用魔王
- [ ] 第1轮回繁荣度触发正常工作
- [ ] 封印强度自动衰减
- [ ] 预兆阶段事件正常触发
- [ ] 魔王苏醒并生成实体
- [ ] 军团波次按配置生成
- [ ] 封印战窗口正常开启
- [ ] 击杀封印成功触发轮回+1
- [ ] 遗产正确发放
- [ ] 第2轮回正常开始
- [ ] 存档/读档后状态保持

#### 边界测试

- [ ] 所有魔王禁用时显示警告
- [ ] 配置文件格式错误时回退默认
- [ ] 封印条件全部关闭时启用保底
- [ ] 人口极低时保底模式生效

---

## 常见问题

### Q: 编译报错找不到 Assembly-CSharp

确保 lib/ 目录包含正确版本的 DLL，并在 .csproj 中正确引用。

### Q: MOD 加载后游戏崩溃

检查 `worldbox_Data/output_log.txt` 或 `Player.log` 获取错误信息。

### Q: 自定义单位不显示

确保精灵图路径正确，且调用了 `AssetManager.unitStats.add()`。

### Q: 配置修改不生效

检查配置优先级：UI > 文件 > 默认。文件配置需要重启游戏或手动重载。

---

## 下一步

1. 阅读 `data-model.md` 了解完整数据结构
2. 阅读 `contracts/state-machine.md` 了解状态转换规则
3. 阅读 `contracts/events.md` 了解事件系统
4. 运行 `/speckit.tasks` 生成开发任务列表
