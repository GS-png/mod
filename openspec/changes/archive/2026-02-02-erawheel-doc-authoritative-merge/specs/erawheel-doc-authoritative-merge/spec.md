## ADDED Requirements

### Requirement: Doc is single source of truth
整理后的《EraWheel_Redesign.md》 MUST 建立“唯一权威”结构：术语、默认值、实现口径、技能/名册/字段大表各自只出现于一个指定位置，其它位置仅允许链接引用。

#### Scenario: Unique authority locations exist
- **WHEN** 读者查找术语、默认值、实现口径或大表
- **THEN** 只能在各自的唯一权威章节找到完整内容，其它章节不再重复

### Requirement: Merge rules remove source content
任何重复内容合并后 MUST 删除源段落，不保留残留引用或“见上文”的提示；仅在需要指向附录或默认值索引时允许链接。

#### Scenario: Duplicate content is merged and removed
- **WHEN** 发现 A/B 两段描述同一规则
- **THEN** 合并为新段落并删除 A/B 原文，不留下残痕

### Requirement: Move rules leave no stubs
内容迁移 MUST 为完整移动，不允许在原位置保留空壳、旧标题或残留提示。

#### Scenario: Moved content is fully relocated
- **WHEN** 某段内容需要归位到正确章节
- **THEN** 原位置不再保留该内容或其残留提示

### Requirement: Default values are centralized
所有“默认值/参数数值” MUST 只保留在“第七部分：关键参数默认值速查”，正文仅保留参数入口链接与说明。

#### Scenario: Defaults appear only in section 7
- **WHEN** 读者在正文查找具体数值
- **THEN** 正文不出现数值，只能通过链接跳到第七部分查看

### Requirement: Large tables live only in appendices
技能表、名册、字段速查、遗产详表等大表 MUST 只出现在附录，正文只保留规则解释与链接。

#### Scenario: Tables are appendix-only
- **WHEN** 读者查找技能表或名册
- **THEN** 仅在附录看到完整表格，正文无重复表

### Requirement: TOC and anchors are valid
目录与锚点 MUST 与正文一致，所有目录链接可跳转到对应章节。

#### Scenario: TOC links work
- **WHEN** 点击目录中的任意链接
- **THEN** 跳转到对应章节标题

### Requirement: Style is clean and consistent
文档表述 MUST 干净、简洁、规范、具体且完整；提示语密度受控（每个大章最多 1 条提示语）。

#### Scenario: Prompt density is limited
- **WHEN** 读者通读某个大章
- **THEN** 仅看到一条简短提示语，其余内容为规则与说明

### Requirement: Semantics and values unchanged
整理过程 MUST 不改变玩法含义与默认值，不新增或删除机制。

#### Scenario: Rules remain the same
- **WHEN** 对比整理前后的规则与数值
- **THEN** 含义与默认值保持一致，仅结构与表述变化
