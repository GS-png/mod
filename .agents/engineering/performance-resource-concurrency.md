# Engineering：性能、资源与并发

## 1. 目的

控制运行成本、延迟、内存、IO、并发、异步处理、资源释放、缓存和高频路径风险。

## 2. 何时加载

触达以下任一情况时加载：

- 高频请求路径。
- 无界或大数据循环。
- 大对象、文件、stream、upload、download、export。
- 数据库查询、外部网络调用、cache、queue、lock、subscription、timer、worker、scheduler。
- shared mutable state、async tasks、retry、backoff、cancellation、timeout、rate limiting。
- 声称性能提升或并发安全。

## 3. 必查项

实现前识别：

- 调用频率和预期数据规模。
- 当前算法成本和 IO 模式。
- 是否存在 N+1 query、重复 IO、重复计算。
- 现有 caching、pagination、batching、streaming、timeout、retry 行为。
- 资源 owner 和释放点。
- 现有并发模型和共享状态。
- 负载、超时、取消、重试下的失败行为。

## 4. 性能规则

- 没有证据不得宣称性能提升。
- 高频路径、大循环、大对象、大数据处理必须说明复杂度和资源影响。
- 避免重复 IO、重复查询、重复计算和无界缓存。
- 对可能出现 N+1 query 的代码，必须检查调用位置和数据规模。
- 只有在真实需要且符合项目风格时，才引入 pagination、batching、streaming、indexing、memoization 或 cache reuse。
- 不做让架构更难理解的过早优化。
- 不把性能成本隐藏在 helper 或抽象后。

## 5. 资源规则

- files、network connections、database connections、streams、subscriptions、locks、handles、timers、temporary files 必须释放。
- 使用项目语言惯用机制释放资源，例如 `finally`、defer、context manager、try-with-resources、cleanup hook。
- temporary files / dirs 必须有生命周期和清理点。
- long-running process 应按项目支持方式处理 cancellation / shutdown。
- 大数据处理避免一次性全部载入内存，除非有明确边界和理由。

## 6. 并发规则

- 没有证据不得宣称并发安全。
- shared mutable state 必须有明确 owner 和同步策略。
- 避免 race condition、lost update、duplicate execution、stale read。
- locks 必须范围有限且释放清晰。
- async work 必须考虑 cancellation、timeout、error propagation、orphaned tasks。

## 7. Retry、Timeout 与 Backpressure

- retry 必须有上限和控制。
- 适用时使用 backoff、jitter、rate limit。
- 不造成 retry storm。
- 外部调用在项目模式支持时必须有明确 timeout。
- queue / worker 改动必须考虑 backpressure、dead letter、poison message、重复消费和幂等。

## 8. Benchmark / Profile 证据

- 声称性能提升时，必须说明证据来源：benchmark、profile、query count、load test、复杂度分析或实际命令输出。
- benchmark 必须尽量控制输入规模、重复次数和环境差异。
- 无法验证性能时，只能说“理论上减少了 X”，不得声称实际提升。

## 9. 验证

按需包括：

- batching / pagination / retry / timeout / cancellation 行为测试。
- 大输入处理检查。
- 资源释放证据。
- query count 或重复 IO 检查。
- build、lint、typecheck、targeted tests。

## 10. 交付补充

```text
性能 / 资源影响：<impact>
并发假设：<assumptions>
Retry / timeout / backpressure：<decisions>
证据：<benchmark/profile/query count/tests or not run>
```
