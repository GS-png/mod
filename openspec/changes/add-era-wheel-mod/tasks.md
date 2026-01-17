# Tasks: 纪元之轮 MOD 实现清单

## Phase 1: MVP - 核心闭环

### 1.1 基础设施
- [x] 1.1.1 创建 `EraOfWheel/mod.json` MOD元信息文件
- [x] 1.1.2 创建 `EraOfWheel/README.md` 安装说明
- [x] 1.1.3 实现 `Code/Core/ModMain.cs` MOD入口
- [x] 1.1.4 实现 `Code/Core/IModSystem.cs` 子系统接口
- [x] 1.1.5 实现 `Code/Core/EventBus.cs` 事件总线
- [x] 1.1.6 实现 `Code/Core/Logger.cs` 日志系统
- [x] 1.1.7 实现 `Code/Core/ErrorHandler.cs` 错误处理
- [x] 1.1.8 实现 `Code/Core/Config/ConfigManager.cs` 配置管理
- [x] 1.1.9 实现 `Code/Core/Config/ModConfig.cs` 配置结构
- [x] 1.1.10 创建 `Resources/Config/config.json` 默认配置

### 1.2 轮回系统
- [x] 1.2.1 实现 `Code/Cycle/CyclePhase.cs` 阶段枚举（Sealed/Omen/Awakening/Invasion/Peak/Weakening/Resealed）
- [x] 1.2.2 实现 `Code/Cycle/CycleState.cs` 轮回状态数据
- [x] 1.2.3 实现 `Code/Cycle/CycleManager.cs` 轮回管理器（阶段推进、事件触发）
- [x] 1.2.4 实现轮回触发条件检测（人口/城市/年龄/英雄）
- [x] 1.2.5 实现封印强度衰减机制

### 1.3 魔王系统 - 基础
- [x] 1.3.1 实现 `Code/DemonLords/BaseDemonLord.cs` 魔王基类
- [x] 1.3.2 实现 `Code/DemonLords/DemonLordState.cs` 魔王状态机
- [x] 1.3.3 实现 `Code/DemonLords/DemonLordManager.cs` 魔王管理器
- [x] 1.3.4 实现 `Code/DemonLords/VoidLord.cs` 虚无之主（第1个魔王）
- [x] 1.3.5 实现 `Code/DemonLords/PlagueMother.cs` 瘟疫母神（第2个魔王）

### 1.4 军团系统
- [x] 1.4.1 实现 `Code/DemonLords/Legion/LegionManager.cs` 军团管理
- [x] 1.4.2 实现 `Code/DemonLords/Legion/LegionWave.cs` 波次生成
- [x] 1.4.3 实现军团单位类型（先锋/主力/攻城/终极）
- [x] 1.4.4 实现波次强度递增公式

### 1.5 封印系统
- [x] 1.5.1 实现 `Code/Cycle/SealSystem.cs` 封印系统
- [x] 1.5.2 实现击杀封印条件
- [x] 1.5.3 实现简化仪式封印（封印遗迹 + 进度条）
- [x] 1.5.4 实现封印战窗口触发
- [x] 1.5.5 实现轮回结算逻辑

### 1.6 遗产系统
- [x] 1.6.1 实现 `Code/Cycle/LegacySystem.cs` 遗产管理
- [x] 1.6.2 实现军事遗产（英雄之证等）
- [x] 1.6.3 实现经济遗产（战后繁荣等）
- [x] 1.6.4 实现科技遗产（禁忌知识等）
- [x] 1.6.5 实现遗产叠加与上限保护

### 1.7 失败保护
- [x] 1.7.1 实现失败条件检测
- [x] 1.7.2 实现"终末余波"分支
- [x] 1.7.3 实现"重启轮回"功能
- [x] 1.7.4 实现遗产保留比例配置

### 1.8 存档系统
- [x] 1.8.1 实现 `Code/Core/Data/SaveManager.cs` 存档管理
- [x] 1.8.2 实现MOD数据序列化
- [x] 1.8.3 实现存档备份与恢复

### 1.9 基础UI
- [x] 1.9.1 实现 `Code/UI/UIManager.cs` UI管理器
- [x] 1.9.2 实现 `Code/UI/Panels/OverviewPanel.cs` 总览面板
- [x] 1.9.3 实现 `Code/UI/Panels/DemonPanel.cs` 魔王面板（简化版）
- [x] 1.9.4 实现 `Code/UI/NotificationSystem.cs` 通知系统

### 1.10 MVP验证
- [ ] 1.10.1 测试：完整轮回闭环（从封印到再封印）
- [ ] 1.10.2 测试：连续2次轮回，计数正确
- [ ] 1.10.3 测试：配置错误回退默认
- [ ] 1.10.4 测试：失败后可重启轮回

---

## Phase 2: V1 - 可发布版本

### 2.1 魔王扩展
- [ ] 2.1.1 实现混沌炎魔·伊弗利特
- [ ] 2.1.2 实现死亡君王·阿努比斯
- [ ] 2.1.3 实现机械暴君·欧米茄
- [ ] 2.1.4 实现灵魂编织者·墨菲斯托
- [ ] 2.1.5 实现轮回解锁节奏配置

### 2.2 将领系统
- [ ] 2.2.1 实现 `Code/DemonLords/General/BaseGeneral.cs` 将领基类
- [ ] 2.2.2 实现将领AI行为树
- [ ] 2.2.3 实现将领技能系统
- [ ] 2.2.4 实现将领背叛机制

### 2.3 自适应难度
- [ ] 2.3.1 实现CSI（文明强度指数）计算
- [ ] 2.3.2 实现自适应倍率系统
- [ ] 2.3.3 实现平滑处理与防抖动
- [ ] 2.3.4 实现保底机制（世界濒危时降低难度）

### 2.4 完整封印战
- [ ] 2.4.1 实现收集封印（遗物收集）
- [ ] 2.4.2 实现时间窗口封印
- [ ] 2.4.3 实现多条件混合封印
- [ ] 2.4.4 实现封印遗迹系统

### 2.5 反魔联盟
- [ ] 2.5.1 实现联盟触发条件
- [ ] 2.5.2 实现联盟阵营系统
- [ ] 2.5.3 实现联盟军团
- [ ] 2.5.4 实现联盟终结条件

### 2.6 事件库扩充
- [ ] 2.6.1 实现30+魔王预兆事件
- [ ] 2.6.2 实现30+英雄成长事件
- [ ] 2.6.3 实现30+文明转折事件
- [ ] 2.6.4 实现事件触发系统

### 2.7 完整UI
- [ ] 2.7.1 实现魔王详情界面
- [ ] 2.7.2 实现配置编辑器
- [ ] 2.7.3 实现调试工具面板
- [ ] 2.7.4 实现导入/导出配置

---

## Phase 3: V2 - 史诗版本

### 3.1 LLM集成
- [ ] 3.1.1 实现 `Code/LLM/LLMClient.cs` API客户端
- [ ] 3.1.2 实现 `Code/LLM/RequestQueue.cs` 请求队列
- [ ] 3.1.3 实现 `Code/LLM/ContextManager.cs` 上下文管理
- [ ] 3.1.4 实现 `Code/LLM/PromptTemplates.cs` 提示词模板
- [ ] 3.1.5 实现 `Code/LLM/NarrativeEngine.cs` 叙事引擎
- [ ] 3.1.6 实现 `Code/LLM/FallbackEventPool.cs` 后备事件池
- [ ] 3.1.7 实现 `Code/LLM/CostMonitor.cs` 成本监控
- [ ] 3.1.8 实现AI权限等级系统

### 3.2 扩展魔王
- [ ] 3.2.1 实现时空扭曲者·卡洛诺斯
- [ ] 3.2.2 实现深渊邪神·克苏鲁
- [ ] 3.2.3 实现自然之怒·盖亚
- [ ] 3.2.4 实现终焉审判者·拉格纳

### 3.3 扩展模式
- [ ] 3.3.1 实现魔王内战模式
- [ ] 3.3.2 实现魔王合作模式
- [ ] 3.3.3 实现终极危机模式

### 3.4 诸神黄昏
- [ ] 3.4.1 实现光明神系（奥罗拉/阿瑞斯/雅典娜）
- [ ] 3.4.2 实现神祇降临机制
- [ ] 3.4.3 实现神战任务线

### 3.5 本地化
- [ ] 3.5.1 创建 `Locales/en.json`
- [ ] 3.5.2 创建 `Locales/zh_CN.json`
- [ ] 3.5.3 实现语言切换系统

### 3.6 MOD兼容
- [ ] 3.6.1 实现种族注册API
- [ ] 3.6.2 实现修仙MOD联动
- [ ] 3.6.3 实现现代MOD联动
- [ ] 3.6.4 实现圣骑士MOD联动
