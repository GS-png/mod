# Design: 纪元之轮 MOD 技术设计

## Context
本MOD基于NeoModLoader开发，目标游戏版本WorldBox 0.51.2+。需要在Unity/Mono环境下运行，必须保证性能稳定、配置安全、失败可恢复。

## Goals / Non-Goals

### Goals
- 实现完整轮回闭环（从魔王封印到再封印）
- 魔王系统可扩展（新魔王只需继承基类）
- LLM集成可选（无API也能正常运行）
- 配置可调（玩家可通过UI调整难度）
- 失败不死档（总有重启/恢复路径）

### Non-Goals
- 完整RPG装备系统（只做遗物/称号轻量系统）
- 关卡式主线任务（沙盒叙事引擎优先）
- 多人联机支持

## Architecture Decisions

### 1. 子系统生命周期管理
- 所有子系统实现 `IModSystem` 接口（`Initialize/Dispose/IsInitialized`）
- `ModMain.cs` 统一初始化与卸载清理
- 单例模式使用空条件访问：`Xxx.Instance?.Method()`

### 2. 事件驱动解耦
- 使用 `EventBus` 发布/订阅 `IGameEvent`
- 魔王状态变化、轮回阶段切换等通过事件通知
- UI层订阅事件更新显示，避免直接强引用

### 3. 魔王状态机
```
封印状态(Sealed) → 预兆阶段(Omen) → 苏醒准备(Awakening) 
    → 正式降临(Invasion) → 全盛期(Peak) → 衰弱期(Weakening) → 被封印(Re-sealed)
                                                                      ↓
                                                               轮回计数+1
```

### 4. 难度自适应系统
- 文明强度指数（CSI）每10年计算一次
- 魔王倍率 = 轮回基础倍率 × 自适应倍率
- 平滑处理（30%逐步靠近）+ 硬上下限保护

### 5. LLM集成策略
- 权限分级（等级1-5，默认等级2）
- 请求队列单并发，避免费用失控
- 失败自动降级到后备事件池
- API Key不写入可导出配置

## Risks / Trade-offs

| 风险 | 缓解措施 |
|------|----------|
| 魔王过强导致无解 | 自适应难度 + 失败保护 + 重启轮回 |
| LLM费用失控 | token上限 + CostMonitor + 冷却限制 |
| 配置错误导致崩溃 | 参数校验 + 默认回退 + 日志提示 |
| 性能问题 | 分层更新 + 实体池 + 上限保护 |
| 存档兼容 | config_version + 迁移脚本 |

## Key Technical Patterns

### 配置系统
- 三层优先级：UI实时 > 文件覆盖 > 内置默认
- 所有数值有clamp保护
- 配置备份 + 一键恢复

### 存档结构
```json
{
  "mod_version": "1.0.0",
  "current_cycle": 3,
  "demon_lords": [...],
  "civilizations": [...],
  "ai_story_log": [...]
}
```

### 本地化
- `/Locales/{lang}.json` 结构
- 支持 en/zh_CN/ja

## Open Questions
- 是否需要支持多魔王同时苏醒（MVP先不做）
- 神祇系统与魔王系统如何共存（V2再考虑）
