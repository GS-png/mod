<!--
=== SYNC IMPACT REPORT ===
Version change: N/A → 1.0.0 (Initial creation - Production Grade)
Modified principles: N/A (new document)
Added sections: 
  - Core Principles (8)
  - Numerical Boundary Protection
  - State Machine Integrity
  - Configuration Safety System
  - AI/Event Safety Boundaries
  - Save System & Migration
  - Performance Architecture
  - Player Operation Protection
  - Technical Constraints
  - Development Workflow
  - Governance
Removed sections: N/A
Templates requiring updates:
  - .specify/templates/plan-template.md ✅ (Constitution Check section compatible)
  - .specify/templates/spec-template.md ✅ (no changes needed)
  - .specify/templates/tasks-template.md ✅ (no changes needed)
Follow-up TODOs: None
===========================
-->

# 纪元之轮：魔王轮回 MOD Constitution (Production Grade)

> **核心理念**: 将 WorldBox 变为自我演化的史诗叙事引擎，通过 AI 驱动的动态剧情系统，让每次游戏都产生独特的文明兴衰史诗。

---

## Core Principles

### I. 闭环完整性 (Loop Integrity) — 不可协商

轮回系统 MUST 形成完整闭环，任何情况下都不能卡死：

- **状态流转强制闭环**: `封印状态 → 预兆阶段 → 苏醒准备 → 正式降临 → 全盛期 → 衰弱期 → 被封印`，每个状态 MUST 有明确的进入/退出条件
- **轮回计数唯一触发点**: 轮回计数只在"魔王被再封印"时+1，禁止任何其他方式递增
- **封印胜利条件保底**: 如果 `victory_conditions.conditions` 为空或全部关闭，MUST 强制回退到 `execution`（击杀封印）
- **轮回触发条件保底**: 如果 `cycle_trigger_conditions.conditions` 为空或阈值全为0，MUST 强制回退到 `world_age_years >= 600`
- **入侵窗口期强制结束**: 入侵持续时间达到配置上限（默认200年）时，MUST 强制进入封印战窗口

**Rationale**: 沙盒游戏最大的体验破坏是"卡死"，闭环完整性是 MOD 能持续产生史诗的根基。

### II. 数值边界保护 (Numerical Boundary Protection) — 不可协商

所有数值参数 MUST 有硬上限和硬下限，防止数值膨胀导致无解或性能崩溃：

**魔王系统边界**:
- 魔王强度倍率: `clamp(0.6, 3.0)`
- 将领最大数量: 上限 6 个
- 军团精英率: 上限 30%
- 单位最大复活次数: MUST 有配置上限
- 技能/领域范围: MUST 有配置上限（避免全图覆盖）
- 终极技冷却: MUST 有配置下限（避免连发）

**文明系统边界**:
- 遗产增益叠加: MUST 有递减收益且有硬上限（例如：全属性最多+100%）
- 英雄属性成长: MUST 有硬上限
- 同时存在的传奇英雄数量: MUST 有上限
- 联盟成员/军团规模: MUST 有上限

**世界系统边界**:
- 世界可居住面积: MUST 保留下限（默认40%），禁止完全收缩
- 地形改造覆盖比例: MUST 有上限（例如：地狱火地形最大50%）
- 同时存在的特效实体数量: MUST 有上限（火焰漩涡、毒雾、亡灵等）

**Rationale**: 设计文档中每个魔王章节都强调"生产级保护"和"避免无解"，数值边界是实现这一目标的技术手段。

### III. 降级容错 (Graceful Degradation) — 不可协商

外部依赖失败时系统 MUST 保持核心功能可用：

- **LLM 降级**: API 超时/失败/未配置时，MUST 在 `timeout`（默认30秒）+ `retry_count`（默认3次）后自动切换到内置后备事件池（200+事件）
- **配置降级**: 配置文件缺失/格式错误时，MUST 回退到内置默认配置并记录警告日志
- **数据降级**: CSI 计算所需数据缺失时，按0处理并保持上一次有效值
- **单点故障隔离**: 任何单个系统崩溃 MUST NOT 导致整个 MOD 崩溃，需捕获异常并降级运行

**Rationale**: 玩家环境多样，网络/配置/数据任何一环出问题都不能让游戏崩溃。

### IV. 失败保护与可恢复性 (Failure Protection & Recoverability)

游戏失败 MUST NOT 等于死档，玩家 MUST 始终有继续游玩的路径：

- **终末后果分支**: 魔王取得阶段性胜利时，进入"终末后果"而非直接结束
- **重启轮回选项**: 任何失败状态 MUST 提供"重启轮回"选项，保留：轮回次数、世界编年史、遗产保留比例（可配置，默认50%）
- **灾厄强度封顶**: 即使连续失败，灾厄强度 MUST 有上限（默认60%），避免恶性循环
- **保底英雄机制**: 如果世界长期无传奇英雄（无法组织封印），MUST 提升命定英雄诞生概率
- **保底仪式机制**: 如果世界长期无法组织封印，MUST 触发"保底仪式"（更慢、代价更高但可行）

**Rationale**: 设计文档 2.3 节明确要求"不会无解死档"，这是面向挑战玩家和剧情党的核心承诺。

### V. 可追溯性 (Traceability)

所有游戏状态变化 MUST 可追溯和记录：

- **轮回结算记录**: MUST 记录触发原因、参与文明、关键战役、封印方式、遗产发放
- **魔王历史战绩**: 每个魔王 MUST 记录每轮回的城市摧毁数、英雄击杀数、封印方式
- **AI 操作日志**: 所有 AI 生成的实体/事件 MUST 记录到日志，支持玩家查看和撤销
- **配置变更日志**: 玩家通过 UI 修改配置 MUST 记录，支持导出分析
- **状态转换日志**: 魔王状态机每次状态转换 MUST 记录原因和时间

**Rationale**: 玩家需要理解"为什么会这样"，可追溯性是叙事引擎的核心价值，也是调试问题的关键。

### VI. 自适应平衡 (Adaptive Balance)

难度 MUST 根据世界实际状态动态调整，确保"有挑战但永远有解法"：

- **CSI（文明强度指数）计算**: 每10年更新一次，综合人口/城市/科技/抗魔等级/英雄计算（0-100）
- **自适应倍率范围**: `adaptive_multiplier = map(CSI, 0..100 → 0.85..1.25)`，只做温和调节
- **防抖动机制**: 
  - 新倍率不立刻生效，使用平滑系数（默认30%）逐步靠近
  - 单次更新的 `adaptive_multiplier` 变化幅度上限 ±0.05
- **保底机制**: 如果世界已接近灭绝（人口<500 或 文明数≤1），自适应倍率 MUST 强制下调到下限
- **魔王成长冻结**: 如果世界已接近灭绝，魔王成长 MUST 进入"冻结模式"（不再变强）

**Rationale**: 设计文档 7.1 节详细定义了自适应难度机制，这是避免"碾压没意思"和"直接死档"的核心。

### VII. 模块化与可配置性 (Modular & Configurable)

所有系统 MUST 支持独立启用/禁用和参数配置：

- **核心模块开关**: 轮回系统、魔王将领、纪元遗产、反魔联盟、AI叙事引擎等 MUST 可独立开关
- **魔王个体开关**: 每个魔王 MUST 可单独启用/禁用
- **配置分层优先级**: `UI实时配置 > 文件覆盖配置 > 内置默认配置`
- **配置导入导出**: UI MUST 提供一键导入/导出配置（JSON格式，带版本号）
- **恢复默认**: 任意模块 MUST 能一键恢复默认配置

**配置校验规则**:
- 数值参数缺失 → 使用默认值
- 数值参数非法/越界 → clamp 到安全范围并记录日志
- 结构缺字段 → 用默认值填充
- 结构多字段 → 忽略但保留
- 规则互斥/矛盾 → 自动启用保底规则并提示玩家

**Rationale**: 设计文档 14.4 节详细定义了配置系统规范，这是让普通玩家和高级玩家都能舒适使用的基础。

### VIII. 兼容性优先 (Compatibility First)

代码 MUST 最大化与基础游戏和其他 MOD 的兼容：

- **框架遵循**: 基于 NeoModLoader 框架，遵循其 API 规范
- **非侵入式**: 不直接修改游戏核心类，优先使用钩子和事件系统
- **种族自动注册**: 自动扫描其他 MOD 注册的种族并添加抗魔数据
- **生物标签系统**: 为所有单位添加标签（`dlm_demon_faction` / `dlm_mortal_faction`）便于识别
- **联动 API**: 提供钩子让其他 MOD（修仙/现代/圣骑士）可以注入自定义行为

**存档兼容规则**:
- 存档 MUST 包含 `mod_version`
- 版本更新 MUST 提供迁移脚本或向后兼容
- 迁移失败时 MUST 回退默认并提示，不得崩溃

**Rationale**: WorldBox MOD 生态需要互操作性，用户可能同时使用多个 MOD。

---

## AI/Event Safety Boundaries

### AI 权限分级系统

| 等级 | 名称 | 允许操作 | 默认 |
|-----|------|---------|-----|
| 1 | 观察者 | 只生成故事描述，不修改实体 | - |
| 2 | 记录者 | 记录事件、生成NPC对话、命名实体 | ✓ 默认 |
| 3 | 编导者 | 创建随机事件（从预设池）、调整小概率参数(<10%)、生成支线任务 | - |
| 4 | 造物主 | 生成魔王将领、创建英雄、修改文明关系 | 需授权 |
| 5 | 上帝模式 | 完全控制游戏状态（危险！） | 每次确认 |

### AI 操作安全规则

- **频率限制**: AI 生成实体/事件 MUST 有冷却时间（UI可调）
- **回滚支持**: AI 操作 MUST 记录到日志，支持玩家撤销最近 N 次操作（可配置）
- **Token 消耗上限**: 单次 AI 调用的 token 消耗 MUST 有上限，避免费用失控
- **内容过滤**: AI 生成的文本 MUST 经过基础过滤（可配置敏感词列表）

### 敏感信息处理

- **API Key 脱敏**: 导出配置时 MUST 自动脱敏 API Key
- **安全存储**: API Key 建议存到本地安全存储/单独文件
- **示例占位**: 文档与示例中永远使用占位符（`YOUR_API_KEY`）

---

## Performance Architecture

### 分层更新系统

不同系统使用不同更新频率，避免每帧全量计算：

| 系统 | 更新间隔 | 说明 |
|-----|---------|-----|
| DemonLord | 每帧 | 战斗核心逻辑 |
| Legion | 每5帧 | 军团AI和移动 |
| Hero | 每10帧 | 英雄AI行为树 |
| Civilization | 每30帧 | 文明状态计算 |
| AIStoryEngine | 每300帧(~10秒) | AI叙事分析 |
| CSI | 每年(游戏内) | 自适应难度计算 |

### 实体池管理

- 魔王军团单位 MUST 使用对象池，避免频繁创建/销毁
- 预创建容量建议: 1000+ 单位
- 单位回收时 MUST 重置状态后入池

### 性能监控

- 控制面板 MUST 显示当前 MOD 性能消耗（CPU/内存）
- 超过阈值时 MUST 提示玩家
- 提供性能警告阈值配置

---

## Player Operation Protection

### 危险操作确认

以下操作 MUST 弹出二次确认：
- 立即苏醒魔王
- 强制触发轮回
- 重置世界状态
- 清空所有魔王
- 启用上帝模式 AI 权限

### 配置安全

- **自动备份**: 修改配置前 MUST 自动保存备份
- **一键恢复**: 支持从备份恢复配置
- **范围校验**: 所有 UI 输入 MUST 有合法范围校验，超出范围自动回退默认值并提示

---

## Technical Constraints

### 技术栈要求

- **目标平台**: WorldBox 0.51.2+ (基于 NeoModLoader)
- **编程语言**: C# (Unity)
- **配置格式**: JSON，支持热重载，MUST 包含 `config_version`
- **日志系统**: 结构化日志，支持分级输出（Debug/Info/Warning/Error）
- **本地化**: 支持多语言（zh_CN/en/ja），文本与代码分离

### 性能标准

- 单帧处理时间增量 MUST < 5ms（不影响游戏流畅度）
- 内存占用增量 MUST < 100MB
- 大规模战斗场景（1000+单位）MUST 保持 30fps+
- 存档大小增量 SHOULD < 10MB

### 数据要求

- 所有持久化数据 MUST 支持 JSON 序列化
- 存档 MUST 包含完整的轮回历史和魔王战绩
- 配置文件 MUST 有 schema 验证和默认值回退

---

## Development Workflow

### 质量门控

1. **编译通过**: 代码 MUST 无编译错误和警告
2. **边界检查**: 所有数值参数 MUST 验证边界保护
3. **降级测试**: 关键外部依赖 MUST 有降级场景验证
4. **闭环测试**: 轮回系统 MUST 验证完整闭环可运行（至少2次封印）
5. **存档兼容**: 版本更新 MUST 验证旧存档可加载或提供迁移

### 版本发布

- 版本号遵循语义化版本 (MAJOR.MINOR.PATCH)
- **MAJOR**: 破坏性变更（存档不兼容、核心机制重构）
- **MINOR**: 新功能、新魔王、新系统
- **PATCH**: Bug 修复、平衡调整、文案修正

### MVP 验收标准

根据设计文档 15.1 节，MVP MUST 满足：
- 连续运行：同一存档里至少触发 2 次"被再封印"，轮回计数正确+1
- 可解释：UI 总览能说明"为什么进入预兆/苏醒/封印战"
- 可恢复：关闭/开启某个魔王、配置写错，游戏不会崩溃

---

## Governance

本 Constitution 是项目开发的最高准则：

- 所有开发决策 MUST 符合 Core Principles
- **不可协商原则**（标记为"不可协商"的）MUST NOT 被任何理由绕过
- Constitution 修改需要：
  1. 书面提案说明变更理由
  2. 评估对现有系统的影响
  3. 更新版本号和修改日期
  4. 同步检查依赖模板是否需要更新
- 当代码实现与 Constitution 冲突时，Constitution 优先
- 运行时开发指南参见设计文档各章节

---

**Version**: 1.0.0 | **Ratified**: 2026-01-19 | **Last Amended**: 2026-01-19
