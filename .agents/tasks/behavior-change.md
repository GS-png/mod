# Task：行为变更

## 1. 触发条件

当任务有意改变外部行为或契约时使用。

行为变更是叠加分类，不是互斥分类。只要以下任一内容改变，即使主任务是 Bug 修复、增强、替换、配置或新能力，也必须额外读取本文件：

- API request / response。
- Error code、error message、error semantics、CLI exit code。
- Permission result、auth scope、visibility。
- UI workflow、默认流程、用户可见文案。
- Data meaning、schema meaning、排序、分页、默认值。
- Default config、环境变量语义。
- 兼容性被缩小或破坏。
- SDK、package、公共 API、event、webhook、message contract。

总是同时读取：

- `.agents/engineering/testing-verification.md`
- `.agents/engineering/workspace-command-safety.md`

按触达领域额外读取 architecture、data、security、dependency、release、docs 规则。

## 2. 目标

把行为变化显式化，必要时保持兼容，并验证所有受影响调用方。

## 3. 必查项

变更前识别：

- 当前行为和定义位置。
- 请求的新行为。
- 所有 public / internal callers。
- tests、docs、examples、clients、SDKs、schema、generated code、contracts 中编码的旧行为。
- 数据兼容和迁移需求。
- 权限、安全、日志、可观测性影响。
- 是否需要兼容期、版本化、feature flag、fallback 或 release note。

## 4. 设计规则

- 区分有意行为变更和偶然实现变更。
- 不把行为变更藏在 refactor 内。
- 除非任务明确允许 breaking change，否则保持兼容。
- 需要兼容时，设计 versioning、feature flag、fallback 或 migration path。
- Breaking change 必须更新 contracts、docs、tests、release notes where applicable。
- 默认行为必须明确。
- package、SDK、公共 API 要考虑 semver、下游客户端和迁移说明。

## 5. 实现规则

- 更新所有受影响 contract definitions、types、schemas、validation、tests、docs。
- Producer 和 consumer 在同仓库时必须同步更新。
- 旧新行为共存时必须隔离。
- 不在同一 patch 中改变无关行为。

## 6. 验证

验证：

- 新行为成立。
- 旧行为按设计保留或明确拒绝。
- 受影响 callers 已更新。
- error、permission、data cases 正确。
- contract tests 或 schema checks pass where available。

## 7. 交付

```text
当前行为：<current>
新行为：<new>
兼容状态：<compatible / migration period / breaking>
受影响调用方和契约：<callers/contracts>
验证：<commands/results>
回滚 / feature flag：<notes>
```
