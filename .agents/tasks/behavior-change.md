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

# 行为变更

## 任务本质
有意识地改变系统对外可观察的行为。
目标不是“代码不同”，而是“目标语义被正确替换且影响受控”。
要求行为定义清楚、兼容性清楚、可验证、可回退、可沟通。

## 必读规范
- 先明确旧行为、新行为、触发条件、影响对象、影响范围。
- 只要结果语义、默认值、校验规则、副作用、错误语义或返回内容发生变化，就按行为变更处理，不按纯内部重构处理。
- 先判断这是兼容变更还是破坏性变更；破坏性变更不得伪装成普通修改。
- 优先稳住既有契约；必须破坏契约时，显式做版本、弃用、迁移或通知策略。
- 影响评估以真实调用方/消费者为准，不只看本模块自测是否通过。
- 高风险行为变更默认用特性开关、灰度、金丝雀或分阶段发布承接。
- 同时验证两件事：新行为符合目标，未改行为未被连带破坏。
- 发布必须可观测、可比较、可回退；异常先止损，再排查。
- 行为变更完成后，应清理临时开关、过渡逻辑和过期兼容层。
- 完成以“目标行为稳定成立且外部影响已被控制”为准，不以“代码已合入”算完成。

## 完成定义
- 旧行为与新行为边界清楚，目标语义已落地。
- 兼容性结论明确，并已执行对应版本/弃用/迁移策略。
- 关键消费者、关键链路、关键场景验证通过。
- 灰度或生产观测证明新行为稳定，无异常扩散。
- 回退路径有效，必要时可快速恢复旧行为。
- 未留下无主开关、隐式 breaking change 或未说明的外部影响。
