# Engineering：工作区与命令安全

## 1. 目的

保护用户工作、仓库状态、生成产物和外部系统，避免误删、误覆盖、误发布、误部署和破坏性命令。

## 2. 工作区规则

修改文件前：

- 工具允许时检查当前 working tree status。
- 识别已有用户改动。
- 不覆盖、revert、format、移动或删除用户改动，除非用户明确要求。
- 不假设 uncommitted changes 都是当前 agent 产生的。
- 避免触碰无关文件的 broad formatting。

## 3. Git 规则

除非用户明确要求且影响清晰，否则不要运行：

- `git add`。
- `git commit`。
- `git push`。
- `git tag`。
- branch 创建或删除。
- `git stash`。
- `git rebase`。
- `git reset`。
- 会覆盖文件的 `git checkout` / `git restore`。
- `git clean`。
- force operations。

只需检查状态时，使用 read-only 命令，例如 `status`、`diff`、`log`、`show`。

## 4. 破坏性命令规则

没有明确批准时不要运行：

- 删除任务范围外文件或目录。
- `rm -rf` 或等效命令。
- 非本地环境数据库迁移。
- 生产数据回滚或变更。
- deploy / release 命令。
- force install、force update、dependency reset。
- `sudo`、全局安装、修改系统级配置。
- `chmod -R`、`chown -R` 或清理用户目录。
- 会修改全局机器状态的命令。

需要批准时说明：

- 命令。
- 影响的文件、数据或环境。
- 为什么需要。
- 更安全替代方案。
- rollback / recovery plan。

## 5. 删除文件规则

- 只能删除本次明确废弃且位于任务范围内的文件。
- 批量删除前必须说明影响。
- 删除旧路径前确认 callers、tests、mocks、docs、config、generated artifacts 是否已迁移或不再需要。
- 不清理无关历史文件，除非用户要求。

## 6. 生成和第三方文件

- 不直接编辑生成代码，除非任务明确要求且 source 不可用。
- 优先修改 generation source 并重新生成。
- 不编辑 `vendor`、third-party source、build outputs、minified bundles，除非项目约定要求。
- generated output 变化时，在交付中说明 source spec 和 generation command。

## 7. 临时文件

- 临时脚本、日志、scratch files 尽量放仓库外。
- 任务结束前删除自己创建的临时文件，除非它们是明确交付物。
- 不留下 debug prints、temporary flags、本地路径或机器特定配置。

## 8. 命令执行

- 优先使用项目定义命令。
- 使用验证触达区域所需的最小命令。
- 对 install、migrate、deploy、clean、rewrite files 的命令保持谨慎。
- 命令失败时检查相关失败，不盲目重跑昂贵或破坏性命令。

## 9. 交付补充

```text
工作区安全：<user changes preserved / not checked / details>
破坏性命令：<none / approved command and result>
生成文件：<none / source and generation command>
临时文件：<removed / retained and why>
```
