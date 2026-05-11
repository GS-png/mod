# Engineering：数据、Schema 与迁移

## 1. 目的

保护持久化数据、schema 契约、API payload、消息格式、缓存格式和迁移流程，避免不兼容或不可恢复变更。

## 2. 何时加载

触达以下任一情况时加载：

- Database schema、ORM model、migration、seed data。
- API request / response schema 或字段含义。
- 持久化文件格式。
- Cache key 或 cache value 格式。
- Queue message、event、webhook、serialized payload。
- Config format。
- OpenAPI、GraphQL、Prisma、Protobuf 等生成源。

## 3. 必查项

变更前识别：

- 当前 source of truth。
- 所有 readers 和 writers。
- 现有数据形态。
- 新数据形态。
- 兼容要求。
- 校验和默认值。
- 迁移工具与命令。
- 回滚路径。
- 部分失败行为。
- 环境差异。

## 4. Schema 规则

- 不静默改变字段含义。
- 没有兼容或迁移计划时，不删除字段、enum value、config key 或 payload member。
- 没有默认值或 staged rollout 时，不新增 required field，除非所有 writer 能原子更新。
- 不在多个层重复 schema 定义。
- schema source 变化时，更新源头并重新生成产物。
- validators、types、docs、tests、examples 必须同步。
- 对外 API schema、message schema、DB schema 的 source of truth 必须唯一；生成产物不得成为手工维护源头。

## 5. 迁移规则

迁移必须考虑：

- 重复执行。
- 部分成功。
- rollback 或 forward-fix。
- 生产既有数据。
- 混合版本部署。
- 长时间运行影响。
- locks、indexes、timeouts、大表成本。
- 可观测性和失败报告。

删除代码兼容能力不等于迁移了旧数据。

## 6. 在线迁移与 Backfill

大表、线上数据或高风险迁移必须评估：

- 是否会锁表、锁行或阻塞写入。
- index 创建方式和耗时。
- batch size、rate limit、timeout、retry。
- 断点续跑和幂等重跑。
- 进度观测、失败记录、恢复命令。
- rollback 代价和 forward-fix 方案。
- 迁移期间新旧版本读写兼容。

Backfill 应支持分批、断点续跑、幂等重跑和进度观测。

## 7. 推荐兼容模式

风险数据变更优先 staged change：

1. 增加新的 optional field / path，旧 reader 仍可工作。
2. 更新 writer 写入新格式。
3. 更新 reader 读取双格式或优先新格式。
4. Backfill / migrate 现有数据。
5. 验证旧格式已无依赖。
6. 兼容期后删除旧 field / path。

删除字段、enum、配置 key 或旧格式前，必须确认线上没有旧 reader / writer 和旧数据依赖。

## 8. 数据完整性

- 多写必须一起成功或一起失败时，使用 transaction。
- retry 必须幂等或 duplicate-safe。
- 在信任边界校验数据。
- 不把未知或部分状态写成完整状态。
- 不记录敏感 payload。
- 保留必要 audit fields。

## 9. 验证

按需使用：

- migration up/down 或等效验证。
- model / schema validation tests。
- API contract tests。
- 旧数据 fixture 的 reader 兼容测试。
- 新数据 writer 测试。
- backfill dry run 或 sample run。
- rollback / recovery procedure review。

## 10. 交付补充

```text
数据变更：<schema/field/format>
Source of truth：<权威定义位置>
Readers：<受影响 readers>
Writers：<受影响 writers>
兼容性：<compatible / staged / breaking>
迁移：<none / up-down / backfill / manual>
回滚：<如何恢复>
验证：<commands and results>
```
