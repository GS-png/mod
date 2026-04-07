---
name: code-health-fix
description: "交互式代码健康治理技能。用于文件、模块或仓库范围的技术债清理、结构优化、重复代码治理和旧代码整顿。"
---

# Code Health Fix

## 核心规则

- 先检查，再建议，停在用户选择前
- 第一次回复必须同时完成第 1 步和第 2 步，并给出 `1-13` 建议表 + 四档方向分桶快照
- 能按固定格式归一化用户回复时，不额外追问；确实无法安全归一化时，才补一句澄清

## 固定两步

1. 检查用户给的文件、模块或仓库范围
2. 输出 `1-13` 方向建议表 + 四档分桶快照
### 第 1 步检查

1. 定清本次范围和边界
2. 查看用户点名内容和强相关文件
3. 补齐调用方、被调用方、测试、配置、类型
4. 建立初检台账，记录“看过哪里、看到什么、还没看哪里”
5. 汇总初检发现，准备进入 `1-13` 方向建议表

### 第 2 步建议表

- 初检完成后，读 /references/review-dimensions.md 组织第一次回复

1. 对 `1-13` 全部方向逐项评级
2. 每个方向写清证据入口和一句理由
3. 输出四档方向分桶快照，供用户直接复用
4. 给用户固定回复格式，让用户选方向或授权口令

### 用户回复后的处理边界

1. 收到用户选择后，只做方向归一化并回显最终方向清单
2. 如果用户要求继续实施，明确提示该技能流程已结束，需要切换到实现流程
3. 不创建计划目录，不生成 `tasks.md`
4. 不做代码修改，不做执行态验证

## 单一来源

- 第 2 步建议表、四档分桶快照、固定引导语：只看 /references/review-dimensions.md

## 方向文件

- `13` 个方向的索引、评级规则和建议表骨架在 [review-dimensions.md](./references/review-dimensions.md)
- 方向细则直达入口（真正深查时只读取被选中的方向）：
  - [01 Bug 与逻辑问题](./references/directions/01-bugs-and-logic.md)
  - [02 安全隐患](./references/directions/02-security-risks.md)
  - [03 错误处理与异常管理](./references/directions/03-error-handling.md)
  - [04 并发与线程安全](./references/directions/04-concurrency-thread-safety.md)
  - [05 性能瓶颈](./references/directions/05-performance-bottlenecks.md)
  - [06 测试覆盖与质量](./references/directions/06-test-coverage-quality.md)
  - [07 日志与可观测性](./references/directions/07-logging-observability.md)
  - [08 代码结构重构](./references/directions/08-structure-refactor.md)
  - [09 重复代码清理](./references/directions/09-duplicate-code-cleanup.md)
  - [10 屎山代码清理](./references/directions/10-legacy-mess-cleanup.md)
  - [11 依赖管理](./references/directions/11-dependency-management.md)
  - [12 文档与注释质量](./references/directions/12-docs-comments-quality.md)
  - [13 代码风格与一致性](./references/directions/13-style-consistency.md)
- 真正深查时，只读取被选中的方向文件
