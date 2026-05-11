# Task：配置、环境、依赖、构建或发布变更

## 1. 触发条件

当任务改变 dependencies、package manager behavior、lockfiles、runtime version、build config、CI、Docker、deployment、environment variables、release flow、generated artifacts 或基础设施相关设置时使用。

总是同时读取：

- `.agents/engineering/dependencies-env-release.md`
- `.agents/engineering/testing-verification.md`
- `.agents/engineering/workspace-command-safety.md`

按触达领域额外读取 data、security、performance、docs 规则。

## 2. 目标

以明确兼容性、校验方式、验证方式和回滚方案修改环境或发布相关行为。

## 3. 必查项

变更前检查：

- package manager 和 lockfiles。
- runtime version files。
- Dockerfile、compose files、CI、deployment scripts、release docs。
- environment variable definitions、validation、examples、docs。
- build and test commands。
- generated code source 和 generation commands if touched。
- 可见的 deployment assumptions 和 rollback path。

## 4. 设计规则

- 不静默升级 core dependencies、language versions、build tools、runtime 或 release chain。
- 新依赖必须有明确必要性。
- 不为简单逻辑引入重依赖。
- 安全、协议、crypto、解析、序列化优先使用成熟且项目已有依赖。
- Config 变更必须包含 validation 和 documentation。
- Environment variables 必须有 required/optional、default、validation 和 failure behavior。
- Release / deployment 变更必须有 impact 和 rollback。

## 5. 实现规则

- lockfile 只通过正确 package manager 更新。
- package manager 与仓库保持一致。
- env var 变化时更新 `.env.example` 等示例。
- 命令变化时更新 CI / build / deploy docs。
- 不编辑 generated output 而不更新 generation source。
- 不改变无关依赖。

## 6. 验证

按需验证：

- install 或 lockfile consistency check。
- lint / typecheck / build。
- 受影响 unit / integration tests。
- startup / smoke test if runtime changed。
- CI-equivalent commands if CI changed。
- migration 或 generation command if relevant。

## 7. 交付

```text
变更面：<dependency/env/build/CI/Docker/deploy/release/generated>
必要性：<why>
兼容性：<impact>
回滚：<steps or notes>
验证：<commands/results>
未验证部署风险：<if deployment could not be exercised>
```
