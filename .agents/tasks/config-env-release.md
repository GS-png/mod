# Task：配置、环境、依赖、构建或发布变更

## 1. 触发条件

当任务改变 dependencies、package manager behavior、lockfiles、runtime version、build config、CI、Docker、deployment、environment variables、release flow、generated artifacts 或基础设施相关设置时使用。

总是同时读取：

- `.agents/engineering/dependencies-env-release.md`
- `.agents/engineering/testing-verification.md`
- `.agents/engineering/workspace-command-safety.md`

按触达领域额外读取 data、security、performance、docs 规则。

# 配置环境发布

## 任务本质
把目标环境与运行配置安全发布到指定环境。
要求结果可重复、可追溯、可回滚、可验证。
目标不是“发上去”，而是“稳定生效并可控接管”。

## 必读规范
- 先明确目标环境、发布边界、环境差异。
- 配置与代码分离；环境差异不得硬编码。
- 非敏感配置参数化；敏感配置只走 Secret/密钥系统。
- 禁止把密钥写进代码、镜像、普通配置或日志。
- 环境定义、配置、发布入口必须版本化、可审计。
- 发布必须自动化、可重复；禁止依赖生产手工临场修改。
- 以声明式/IaC/GitOps 为主；目标是消除环境漂移。
- 发布前确认网络、权限、依赖、外部服务契约一致。
- 涉及数据库、缓存、消息队列、对象存储等变更时，必须一并评估兼容性与顺序。
- 默认采用低风险发布：滚动、金丝雀、蓝绿择一。
- 默认先小范围验证，再逐步放量；禁止一次性全量硬切。
- 发布必须带验证：健康检查、关键链路、错误率、延迟、核心业务指标。
- 异常先回滚或止损，再排查原因；禁止带故障继续放量。
- 发布后必须确认配置已生效，而不是只确认命令执行成功。
- 完成标准不是“流水线跑完”，而是“目标环境达到期望状态且服务稳定”。

## 完成定义
- 目标环境与期望状态一致。
- 配置已正确生效，敏感信息管理合规。
- 发布过程有记录，可追溯到版本与变更。
- 监控、告警、日志可用于判断发布是否成功。
- 回滚路径明确且可执行。
- 未留下临时手工改动、漂移配置或未收口风险。