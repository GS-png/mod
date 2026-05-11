# Engineering：依赖、环境、构建与发布

## 1. 目的

防止依赖漂移、构建失败、环境不一致、CI 破坏、部署风险和不安全发布变更。

## 2. 何时加载

触达以下任一情况时加载：

- dependencies、lockfiles、package manager files。
- runtime / language version。
- Docker、compose、CI、build config、bundler config。
- environment variables。
- deployment scripts、release docs。
- generated code commands 或 source specs。

## 3. 必查文件

按项目实际检查：

- `package.json`、lockfiles、workspace config。
- `pyproject.toml`、`requirements.txt`、lockfiles。
- `go.mod`、`go.sum`。
- `Cargo.toml`、`Cargo.lock`。
- Dockerfile、compose、CI workflows、Makefile、scripts。
- `.env.example`、config modules、deployment docs。
- language / runtime version files。

使用真实项目文件，不基于猜测。

## 4. 依赖规则

- 只在必要时新增依赖。
- 修改依赖版本、核心框架、语言版本、构建工具或运行时，必须依据项目 manifest、lockfile、目标环境约束、官方文档、release notes 或安全公告；没有依据时不修改。
- 安全、协议、加密、解析、序列化等高风险领域，优先使用项目已有成熟依赖。
- 不为少量简单逻辑引入重依赖。
- 不改变 package manager。
- 不更新无关依赖。
- 不静默升级核心框架、语言版本、构建工具或运行时。
- lockfile 变更必须由正确 package manager 产生。

## 5. Monorepo 与包管理一致性

- Monorepo 中新增依赖必须放在实际消费该依赖的 package，而不是默认放根目录。
- 遵守项目已声明的 package manager、workspace、engine、runtime 和 lockfile 规则。
- 不混用 npm / pnpm / yarn / bun 生成多个锁文件。
- 不把 dev dependency 放进 production dependency，反之亦然。
- 不能为了本地方便修改全局工具版本或系统级配置。

## 6. 环境变量规则

每个新增或修改的 env var 必须定义：

- 名称。
- required / optional。
- 默认行为。
- 校验规则。
- 安全的示例值。
- 消费位置。
- 缺失或非法时的行为。

相关位置必须同步：config validation、`.env.example`、docs、CI、deployment、tests。

## 7. 构建与 CI 规则

- 本地命令和 CI 命令保持一致。
- 不删除检查，除非说明替代覆盖。
- 变更 build output 时识别消费者。
- 变更 generated code 时更新 source spec 和 generation command。
- 变更 Docker / runtime 时验证启动，或说明未验证原因。

## 8. 发布与回滚

发布相关变更必须识别：

- 影响环境。
- rollout 顺序。
- 向后兼容。
- rollback 步骤。
- 数据或配置前置条件。
- 失败检测的 observability。

## 9. 验证

按需使用：

- package manager install 或 lockfile check。
- lint / typecheck / build。
- unit / integration tests。
- startup / smoke test。
- Docker build 或 CI-equivalent check。
- generation command 和 diff review。

## 10. 交付补充

```text
依赖 / 环境面：<what changed>
原因：<why needed>
兼容性：<impact>
验证：<commands/results>
回滚：<steps or notes>
```
