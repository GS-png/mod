# Engineering：架构边界与模块职责

## 1. 目的

防止职责污染、大文件继续膨胀、跨层捷径、重复权威、循环依赖、公共 API 泄露和新功能堆进旧文件。

## 2. 何时加载

触达以下任一情况时加载：

- 新建、移动、拆分、合并文件或模块。
- 修改目录职责、模块边界、分层、调用方向或公共 API。
- 新增 feature、endpoint、page、job、command、integration、service、schema、permission、config 或 shared utility。
- 需要判断“改已有文件还是新建 owner”。

## 3. 核心规则

实现前先决定变更属于哪个 owner。不得因为文件最近、最大、最熟悉、当前打开或改动行数更少，就把代码放进去。

每个有意义的概念只能有一个清晰 owner：

- 业务规则 owner。
- 数据 schema owner。
- 校验 owner。
- 权限 owner。
- 配置 owner。
- 错误与日志 owner。
- 外部集成 owner。
- 生成代码源头 owner。

如果没有 owner，创建清晰 owner；不要把逻辑散落到多个调用点。

采用最小充分设计：

- 优先选择能解决当前真实问题的最小清晰实现。
- 一次性逻辑、单一调用方或没有真实复用收益的代码，不新增公共工具、adapter、manager、framework layer 或提前抽象。
- 简单逻辑不得被包装成复杂结构；如果实现因为抽象显著变长或更难理解，应先回到具体 owner 内直接表达。
- 新增抽象必须有真实调用方、清晰 owner、可验证收益或明确失败场景支撑。

## 4. 修改已有文件还是新建文件

可以修改已有文件，仅当全部成立：

- 变更属于该文件当前职责。
- 变更后文件名仍准确描述全部内容。
- 没有引入新的独立生命周期、状态、数据模型、权限边界、入口或测试对象。
- 不会让文件同时拥有多个无关概念。
- 文件可读性不会明显下降。

应新建文件 / 模块，当任一成立：

- 出现新的领域概念、流程、集成、job、command、endpoint、page 或可复用服务。
- 行为会被多个入口调用。
- 行为需要自己的测试、schema、config、permission、logs、errors 或 troubleshooting。
- 加入已有模块会让它变成 `utils`、`helpers`、`manager`、`service`、`misc` 等含混容器。
- 现有文件名已不能准确描述新增职责。

## 5. Import、包边界与公共 API

- 不得通过 deep import 绕过模块公开入口，除非项目惯例允许且说明原因。
- 不得引入新的循环依赖；移动代码后必须检查 import 方向。
- `index` / barrel export 只暴露稳定公共 API，不得为了方便把内部实现导出。
- Monorepo 中不得跨 package 读取对方内部目录；应通过公开 API、workspace dependency 或既有边界调用。
- 新增 shared 模块前，必须确认至少两个真实调用方或一个明确 owner；否则放在具体领域内。
- 公共类型、schema、client、validator、permission、config 不得在多个层重复定义。

## 6. 分层规则

使用项目真实分层；未知时先从目录结构、调用链和测试中推断。

常见期望：

- UI 不直接拥有持久化、权限决策或密钥处理。
- Controller / route 负责传输层协调，不拥有深层业务规则。
- 业务逻辑不依赖 UI 或框架细节，除非项目明确这样设计。
- 数据访问走项目已有 repository / client 边界。
- 配置走项目 config / env 模块，不在各处随意读环境变量。
- 权限走 auth / authorization authority。
- 日志和错误走项目共享机制。

## 7. 单一权威

不得创建：

- 重复 schema。
- 重复 validator。
- 重复 API client。
- 重复 permission check。
- 重复 parser。
- 重复 cache。
- shadow state。
- 没有迁移计划的旧 / 新并行实现。

需要共享逻辑时，把逻辑移到正确 authority 并更新调用方，不要复制。

## 8. 旧路径收口

当新路径替代旧路径：

- 移除旧 imports 和 callers。
- 安全时删除过时文件。
- 移除 stale tests、mocks、docs、config、flags、generated artifacts。
- 如果不能删除，标记 deprecated，并写清删除条件。
- 确保只有一条 authority path。

## 9. 兼容路径

如果旧路径和新路径必须短期共存，必须说明：

- 当前 authority path。
- 旧路径触发条件。
- 新路径触发条件。
- 如何检测 divergence。
- 数据兼容如何保持。
- 旧路径何时删除。

兼容层必须隔离且容易删除，不得永久化。

## 10. 反模式

避免：

- 为方便把完整新功能塞进无关旧文件。
- 用 `utils` / `helpers` 承载领域逻辑。
- 加一个永久 flag 在两个实现之间路由但没有删除计划。
- 创建只为掩盖设计冲突的 wrapper。
- 为了小 feature 做大范围重构。
- 把简单逻辑包装成复杂框架、通用 manager、过度 helper 或没有真实复用收益的 shared utility。
- 让生成产物成为手工维护的 source of truth。
- 为了少改几行绕过既有层级、权限、配置或日志入口。

## 11. 交付补充

架构敏感任务交付中加入：

```text
架构落点：<module/path>
原因：<为什么这个 owner 正确>
新文件：<文件及职责>
修改旧文件：<每个旧文件为什么属于改动范围>
禁止捷径：<避免的跨层调用、deep import 或重复权威>
旧路径收口：<delete / deprecate / migrate / none>
```
