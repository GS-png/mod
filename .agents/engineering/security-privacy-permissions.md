# Engineering：安全、隐私与权限

## 1. 目的

防止不安全输入处理、权限绕过、密钥泄露、隐私违规、注入漏洞、SSRF、多租户越权和不安全文件 / 网络行为。

## 2. 何时加载

触达以下任一情况时加载：

- Authentication、authorization、identity、roles、scopes、sessions、tokens。
- Personal data 或 sensitive business data。
- External input、file upload/download、paths、URLs、templates。
- SQL、command execution、shell、queries、expressions。
- Network calls、webhooks、external integrations。
- Logs、metrics、traces、errors、audit events。
- Crypto、signing、hashing、serialization、parsing。
- CORS、CSRF、cookies、OAuth、redirect、tenant / org / workspace 边界。

## 3. 必查项

实现前识别：

- Trust boundaries。
- Caller identity 和 permission model。
- Tenant / org / workspace / owner 边界。
- 涉及的敏感数据。
- 输入来源和校验规则。
- 输出目的地和日志行为。
- 现有 security utilities 和 permission checks。
- authorization / validation 失败行为。

## 4. 输入与注入规则

- external input、files、network data、logs、permission claims 默认不可信。
- 校验 type、format、range、size、business meaning。
- 使用 safe path API，防止 path traversal。
- 路径安全必须考虑 symlink、absolute path、path normalization 和允许目录边界。
- SQL 使用 parameterized query 或 safe query builder。
- 不用危险字符串拼接构造 shell command。
- template output 按上下文 escape / sanitize。
- 对外部输入设置 size limit 和 timeout where relevant。

## 5. 权限规则

- 权限检查必须在 trust boundary 服务端执行，不只在 UI。
- 使用项目 auth / authorization authority。
- 遵守 least privilege。
- 验证 allowed 和 denied 两条路径。
- 不信任客户端提供的 role、user ID、tenant ID、org ID、workspace ID、owner ID 或 scope。
- 不绕过既有 middleware、guards、policies、scopes。
- 多租户系统中，tenant / org / workspace / owner 隔离必须服务端验证。

## 6. Secret 与隐私规则

- 不提交 secrets、tokens、private keys、passwords、real credentials、production values。
- 不记录 secrets、auth headers、tokens、passwords、personal data、sensitive payloads。
- logs 和 errors 必须 redact。
- 使用 stable IDs、error codes、stage names、state summaries 定位问题。
- 测试 fixture 使用合成数据，除非用户明确提供安全数据。

## 7. Web、URL 与外部集成风险

- URL、webhook、callback、远程资源必须考虑 SSRF、内网地址、重定向、协议限制和 DNS 变化风险。
- 网络调用在项目模式支持时必须有 timeout。
- retry 必须有 backoff、上限和 idempotency。
- webhook 应验证 signature 或 trusted source。
- OAuth callback、redirect、token scope、session、cookie 改动必须说明攻击面和验证方式。
- CORS / CSRF 改动必须说明允许来源、凭证策略和失败路径。
- 不向外部用户暴露内部错误细节。

## 8. 验证

验证：

- Authorized success path。
- Unauthorized / forbidden path。
- Invalid input path。
- Sensitive data 未记录或返回。
- Injection / path traversal / unsafe command 风险已避免。
- Tenant / org / workspace / owner 隔离。
- Token / credential 处理符合项目惯例。

## 9. 交付补充

```text
信任边界：<input/identity enters where>
权限检查：<where enforced>
租户 / owner 隔离：<if relevant>
敏感数据：<none / details and protection>
安全验证：<tests or manual checks>
剩余风险：<risk if not fully verified>
```
