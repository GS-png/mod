## ADDED Requirements

### Requirement: Anchors and references are consistent
文档内的锚点 ID MUST 全局唯一，所有内部引用链接 MUST 指向存在的锚点；目录 MUST 包含所有附录（A-I）。

#### Scenario: Anchor and link validation
- **WHEN** 对文档执行锚点与链接校验
- **THEN** 不存在重复锚点或缺失引用

### Requirement: Rules, implementation, and defaults are separated
规则内容 MUST 归于第 2 部分，实现口径 MUST 归于第 5 部分，默认参数 MUST 归于第 7 部分；第 2 部分 MUST 仅保留“参数入口表（无数值）”。

#### Scenario: Section scope check
- **WHEN** 检查第 2/5/7 部分的内容范围
- **THEN** 规则、实现与默认值互不混写且边界清晰

### Requirement: Single authoritative statements
同一规则或口径 MUST 仅保留一处权威描述，其他位置 MUST 仅保留引用或一句话摘要。

#### Scenario: Duplicate rule detection
- **WHEN** 出现同义规则的多处描述
- **THEN** 只保留一处完整描述，其余改为引用

### Requirement: Appendices are data-only
附录 MUST 只包含数据表、列表或索引，不得夹带实现示例或规则性解释。

#### Scenario: Appendix content validation
- **WHEN** 浏览任意附录章节
- **THEN** 仅看到数据条目或索引信息
