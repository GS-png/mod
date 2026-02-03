## ADDED Requirements

### Requirement: 文档分区顺序固定
整理后的 `EraWheel_Redesign.md` MUST 按固定分区顺序组织：使用指南、术语速查、项目概述、核心系统规则、玩家 UI 与配置、技术基础、版本规划与验收、附录大表。

#### Scenario: 分区顺序可核对
- **WHEN** 读者按目录从上到下查看章节
- **THEN** 章节顺序与规定分区顺序一致

### Requirement: 规则唯一权威
所有规则、口径、默认值与实现入口 MUST 只出现一次，其他位置不得重复描述。

#### Scenario: 无重复描述
- **WHEN** 读者查找任一规则关键词
- **THEN** 只出现一个权威段落且无重复解释

### Requirement: 参数默认值归位
每个系统的默认参数表 MUST 放在该系统小节内，且不再保留独立的“第七部分默认值速查”。

#### Scenario: 系统小节含默认值
- **WHEN** 读者查看某系统小节（如轮回系统）
- **THEN** 默认参数表在该小节内可直接查看

### Requirement: 合并与移动不留残留
合并内容 MUST 形成新的完整段落，并删除原位置内容；移动内容 MUST 从原位置完全移除；删除内容不得保留引用或占位语。

#### Scenario: 原位置无残留
- **WHEN** 合并或移动完成后检查原位置
- **THEN** 原位置不存在残留文本或引用痕迹

### Requirement: 目录与锚点一致
目录项、快速入口与正文锚点 MUST 完全一致，所有内部跳转可用。

#### Scenario: 目录跳转可用
- **WHEN** 点击任意目录或快速入口链接
- **THEN** 页面跳转到对应标题位置

### Requirement: 内容不改口径
整理过程中 MUST 不改变玩法目标与数值口径，只允许移动、合并、删冗余和改表述。

#### Scenario: 数值口径一致
- **WHEN** 对比整理前后的默认数值与规则口径
- **THEN** 数值与口径保持一致

### Requirement: 仅修改目标文档
本次变更 MUST 只允许修改 `EraWheel_Redesign.md`，不得同步改动其他文档。

#### Scenario: 修改范围受限
- **WHEN** 查看本次变更的文件列表
- **THEN** 除 OpenSpec 产物外只包含 `EraWheel_Redesign.md`
