# Assembly: AWSSDK.CognitoIdentity
- Path: tools/WorldBox.Managed/AWSSDK.CognitoIdentity.dll
- Types: 139

## Namespace: Amazon.CognitoIdentity

### private class Amazon.CognitoIdentity.CognitoAWSCredentials.<>c__DisplayClass45_0

#### Fields
- public Amazon.CognitoIdentity.CognitoAWSCredentials <>4__this
- public Amazon.CognitoIdentity.Model.GetIdRequest getIdRequest

#### Constructors
- public CognitoAWSCredentials.<>c__DisplayClass45_0()

#### Methods
- internal System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetIdResponse> <RefreshIdentity>b__0()

### private class Amazon.CognitoIdentity.CognitoAWSCredentials.<>c__DisplayClass64_0

#### Fields
- public Amazon.CognitoIdentity.CognitoAWSCredentials <>4__this
- public Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityRequest assumeRequest

#### Constructors
- public CognitoAWSCredentials.<>c__DisplayClass64_0()

#### Methods
- internal System.Threading.Tasks.Task<Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityResponse> <GetStsCredentials>b__0()

### private class Amazon.CognitoIdentity.CognitoAWSCredentials.<>c__DisplayClass65_0

#### Fields
- public Amazon.CognitoIdentity.CognitoAWSCredentials <>4__this
- public Amazon.CognitoIdentity.Model.GetOpenIdTokenRequest getTokenRequest

#### Constructors
- public CognitoAWSCredentials.<>c__DisplayClass65_0()

#### Methods
- internal System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetOpenIdTokenResponse> <GetOpenId>b__0()

### private class Amazon.CognitoIdentity.CognitoAWSCredentials.<>c__DisplayClass66_0

#### Fields
- public Amazon.CognitoIdentity.CognitoAWSCredentials <>4__this
- public Amazon.CognitoIdentity.Model.GetCredentialsForIdentityRequest getCredentialsRequest

#### Constructors
- public CognitoAWSCredentials.<>c__DisplayClass66_0()

#### Methods
- internal System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetCredentialsForIdentityResponse> <GetCredentialsForIdentity>b__0()

### private struct Amazon.CognitoIdentity.CognitoAWSCredentials.<GenerateNewCredentialsAsync>d__57
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.CognitoIdentity.CognitoAWSCredentials <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState> <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.CognitoIdentity.CognitoAWSCredentials.<GetCredentialsForRoleAsync>d__58
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.CognitoIdentity.CognitoAWSCredentials <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<string> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.CognitoIdentity.Model.GetOpenIdTokenResponse> <>u__2
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState> <>u__3
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityResponse> <>u__4
- private Amazon.CognitoIdentity.Model.GetOpenIdTokenResponse <getTokenResult>5__3
- private bool <retry>5__2
- public string roleArn

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.CognitoIdentity.CognitoAWSCredentials.<GetIdentityIdAsync>d__46
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.CognitoIdentity.CognitoAWSCredentials <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<string> <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.CognitoIdentity.CognitoAWSCredentials.<GetIdentityIdAsync>d__47
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.CognitoIdentity.CognitoAWSCredentials <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.CognitoIdentity.CognitoAWSCredentials.IdentityState> <>u__1
- public Amazon.CognitoIdentity.CognitoAWSCredentials.RefreshIdentityOptions options

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.CognitoIdentity.CognitoAWSCredentials.<GetPoolCredentialsAsync>d__59
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.CognitoIdentity.CognitoAWSCredentials <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<string> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.CognitoIdentity.Model.GetCredentialsForIdentityResponse> <>u__2
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState> <>u__3
- private Amazon.CognitoIdentity.Model.GetCredentialsForIdentityResponse <response>5__3
- private bool <retry>5__2

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.CognitoIdentity.CognitoAWSCredentials.<RefreshIdentityAsync>d__48
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.CognitoIdentity.CognitoAWSCredentials <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Amazon.CognitoIdentity.CognitoAWSCredentials.IdentityState> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.CognitoIdentity.Model.GetIdResponse> <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class Amazon.CognitoIdentity.AmazonCognitoIdentityClient
- Base: Amazon.Runtime.AmazonServiceClient
- Interfaces: System.IDisposable, Amazon.CognitoIdentity.IAmazonCognitoIdentity, Amazon.Runtime.IAmazonService

#### Fields
- private static Amazon.Runtime.Internal.IServiceMetadata serviceMetadata

#### Properties
- protected Amazon.Runtime.Internal.IServiceMetadata ServiceMetadata { get; }

#### Constructors
- public AmazonCognitoIdentityClient()
- private static AmazonCognitoIdentityClient()
- public AmazonCognitoIdentityClient(Amazon.RegionEndpoint region)
- public AmazonCognitoIdentityClient(Amazon.CognitoIdentity.AmazonCognitoIdentityConfig config)
- public AmazonCognitoIdentityClient(Amazon.Runtime.AWSCredentials credentials)
- public AmazonCognitoIdentityClient(Amazon.Runtime.AWSCredentials credentials, Amazon.RegionEndpoint region)
- public AmazonCognitoIdentityClient(Amazon.Runtime.AWSCredentials credentials, Amazon.CognitoIdentity.AmazonCognitoIdentityConfig clientConfig)
- public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey)
- public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, Amazon.RegionEndpoint region)
- public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, Amazon.CognitoIdentity.AmazonCognitoIdentityConfig clientConfig)
- public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
- public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, Amazon.RegionEndpoint region)
- public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, Amazon.CognitoIdentity.AmazonCognitoIdentityConfig clientConfig)

#### Methods
- internal virtual Amazon.CognitoIdentity.Model.CreateIdentityPoolResponse CreateIdentityPool(Amazon.CognitoIdentity.Model.CreateIdentityPoolRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.CreateIdentityPoolResponse> CreateIdentityPoolAsync(Amazon.CognitoIdentity.Model.CreateIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = null)
- protected override Amazon.Runtime.Internal.Auth.AbstractAWSSigner CreateSigner()
- internal virtual Amazon.CognitoIdentity.Model.DeleteIdentitiesResponse DeleteIdentities(Amazon.CognitoIdentity.Model.DeleteIdentitiesRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.DeleteIdentitiesResponse> DeleteIdentitiesAsync(Amazon.CognitoIdentity.Model.DeleteIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.DeleteIdentityPoolResponse DeleteIdentityPool(Amazon.CognitoIdentity.Model.DeleteIdentityPoolRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(string identityPoolId, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(Amazon.CognitoIdentity.Model.DeleteIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.DescribeIdentityResponse DescribeIdentity(Amazon.CognitoIdentity.Model.DescribeIdentityRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.DescribeIdentityResponse> DescribeIdentityAsync(string identityId, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.DescribeIdentityResponse> DescribeIdentityAsync(Amazon.CognitoIdentity.Model.DescribeIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.DescribeIdentityPoolResponse DescribeIdentityPool(Amazon.CognitoIdentity.Model.DescribeIdentityPoolRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(string identityPoolId, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(Amazon.CognitoIdentity.Model.DescribeIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = null)
- protected override void Dispose(bool disposing)
- internal virtual Amazon.CognitoIdentity.Model.GetCredentialsForIdentityResponse GetCredentialsForIdentity(Amazon.CognitoIdentity.Model.GetCredentialsForIdentityRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, System.Collections.Generic.Dictionary<string, string> logins, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(Amazon.CognitoIdentity.Model.GetCredentialsForIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.GetIdResponse GetId(Amazon.CognitoIdentity.Model.GetIdRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetIdResponse> GetIdAsync(Amazon.CognitoIdentity.Model.GetIdRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.GetIdentityPoolRolesResponse GetIdentityPoolRoles(Amazon.CognitoIdentity.Model.GetIdentityPoolRolesRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(string identityPoolId, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(Amazon.CognitoIdentity.Model.GetIdentityPoolRolesRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.GetOpenIdTokenResponse GetOpenIdToken(Amazon.CognitoIdentity.Model.GetOpenIdTokenRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetOpenIdTokenResponse> GetOpenIdTokenAsync(string identityId, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetOpenIdTokenResponse> GetOpenIdTokenAsync(Amazon.CognitoIdentity.Model.GetOpenIdTokenRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.GetOpenIdTokenForDeveloperIdentityResponse GetOpenIdTokenForDeveloperIdentity(Amazon.CognitoIdentity.Model.GetOpenIdTokenForDeveloperIdentityRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetOpenIdTokenForDeveloperIdentityResponse> GetOpenIdTokenForDeveloperIdentityAsync(Amazon.CognitoIdentity.Model.GetOpenIdTokenForDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.ListIdentitiesResponse ListIdentities(Amazon.CognitoIdentity.Model.ListIdentitiesRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.ListIdentitiesResponse> ListIdentitiesAsync(Amazon.CognitoIdentity.Model.ListIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.ListIdentityPoolsResponse ListIdentityPools(Amazon.CognitoIdentity.Model.ListIdentityPoolsRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.ListIdentityPoolsResponse> ListIdentityPoolsAsync(Amazon.CognitoIdentity.Model.ListIdentityPoolsRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.ListTagsForResourceResponse ListTagsForResource(Amazon.CognitoIdentity.Model.ListTagsForResourceRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.ListTagsForResourceResponse> ListTagsForResourceAsync(Amazon.CognitoIdentity.Model.ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.LookupDeveloperIdentityResponse LookupDeveloperIdentity(Amazon.CognitoIdentity.Model.LookupDeveloperIdentityRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.LookupDeveloperIdentityResponse> LookupDeveloperIdentityAsync(Amazon.CognitoIdentity.Model.LookupDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.MergeDeveloperIdentitiesResponse MergeDeveloperIdentities(Amazon.CognitoIdentity.Model.MergeDeveloperIdentitiesRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.MergeDeveloperIdentitiesResponse> MergeDeveloperIdentitiesAsync(Amazon.CognitoIdentity.Model.MergeDeveloperIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.SetIdentityPoolRolesResponse SetIdentityPoolRoles(Amazon.CognitoIdentity.Model.SetIdentityPoolRolesRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(string identityPoolId, System.Collections.Generic.Dictionary<string, string> roles, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(Amazon.CognitoIdentity.Model.SetIdentityPoolRolesRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.TagResourceResponse TagResource(Amazon.CognitoIdentity.Model.TagResourceRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.TagResourceResponse> TagResourceAsync(Amazon.CognitoIdentity.Model.TagResourceRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.UnlinkDeveloperIdentityResponse UnlinkDeveloperIdentity(Amazon.CognitoIdentity.Model.UnlinkDeveloperIdentityRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.UnlinkDeveloperIdentityResponse> UnlinkDeveloperIdentityAsync(Amazon.CognitoIdentity.Model.UnlinkDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.UnlinkIdentityResponse UnlinkIdentity(Amazon.CognitoIdentity.Model.UnlinkIdentityRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.UnlinkIdentityResponse> UnlinkIdentityAsync(Amazon.CognitoIdentity.Model.UnlinkIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.UntagResourceResponse UntagResource(Amazon.CognitoIdentity.Model.UntagResourceRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.UntagResourceResponse> UntagResourceAsync(Amazon.CognitoIdentity.Model.UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.CognitoIdentity.Model.UpdateIdentityPoolResponse UpdateIdentityPool(Amazon.CognitoIdentity.Model.UpdateIdentityPoolRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.UpdateIdentityPoolResponse> UpdateIdentityPoolAsync(Amazon.CognitoIdentity.Model.UpdateIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = null)

### public class Amazon.CognitoIdentity.AmazonCognitoIdentityConfig
- Base: Amazon.Runtime.ClientConfig
- Interfaces: Amazon.Runtime.IClientConfig

#### Fields
- private static readonly string UserAgentString
- private string _userAgent

#### Properties
- public string RegionEndpointServiceName { get; }
- public string ServiceVersion { get; }
- public string UserAgent { get; }

#### Constructors
- public AmazonCognitoIdentityConfig()
- private static AmazonCognitoIdentityConfig()

### public class Amazon.CognitoIdentity.AmazonCognitoIdentityException
- Base: Amazon.Runtime.AmazonServiceException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public AmazonCognitoIdentityException(string message)
- public AmazonCognitoIdentityException(System.Exception innerException)
- public AmazonCognitoIdentityException(string message, System.Exception innerException)
- public AmazonCognitoIdentityException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public AmazonCognitoIdentityException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Constructors
- public AmazonCognitoIdentityRequest()

### public class Amazon.CognitoIdentity.AmbiguousRoleResolutionType
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.CognitoIdentity.AmbiguousRoleResolutionType AuthenticatedRole
- public static readonly Amazon.CognitoIdentity.AmbiguousRoleResolutionType Deny

#### Constructors
- private static AmbiguousRoleResolutionType()
- public AmbiguousRoleResolutionType(string value)

#### Methods
- public static Amazon.CognitoIdentity.AmbiguousRoleResolutionType FindValue(string value)
- public static Amazon.CognitoIdentity.AmbiguousRoleResolutionType op_Implicit(string value)

### public class Amazon.CognitoIdentity.CognitoAWSCredentials
- Base: Amazon.Runtime.RefreshingAWSCredentials
- Interfaces: System.IDisposable

#### Fields
- private string <AccountId>k__BackingField
- private string <AuthRoleArn>k__BackingField
- private string <IdentityPoolId>k__BackingField
- private System.Collections.Generic.Dictionary<string, string> <Logins>k__BackingField
- private string <UnAuthRoleArn>k__BackingField
- private Amazon.CognitoIdentity.IAmazonCognitoIdentity cib
- private static int DefaultDurationSeconds
- private string identityId
- private static readonly string IDENTITY_ID_CACHE_KEY
- private System.EventHandler<Amazon.CognitoIdentity.CognitoAWSCredentials.IdentityChangedArgs> mIdentityChangedEvent
- private static object refreshIdLock
- private Amazon.SecurityToken.IAmazonSecurityTokenService sts
- private Amazon.CognitoIdentity.CognitoAWSCredentials.IdentityState _identityState

#### Properties
- public string AccountId { get; private set; }
- public string AuthRoleArn { get; private set; }
- protected System.Collections.Generic.Dictionary<string, string> CloneLogins { get; }
- public string[] CurrentLoginProviders { get; }
- public string IdentityPoolId { get; private set; }
- private bool IsIdentitySet { get; }
- private System.Collections.Generic.Dictionary<string, string> Logins { get; set; }
- public int LoginsCount { get; }
- public string UnAuthRoleArn { get; private set; }

#### Events
- public event System.EventHandler<Amazon.CognitoIdentity.CognitoAWSCredentials.IdentityChangedArgs> IdentityChangedEvent

#### Constructors
- private static CognitoAWSCredentials()
- public CognitoAWSCredentials(string identityPoolId, Amazon.RegionEndpoint region)
- public CognitoAWSCredentials(string accountId, string identityPoolId, string unAuthRoleArn, string authRoleArn, Amazon.RegionEndpoint region)
- public CognitoAWSCredentials(string accountId, string identityPoolId, string unAuthRoleArn, string authRoleArn, Amazon.CognitoIdentity.IAmazonCognitoIdentity cibClient, Amazon.SecurityToken.IAmazonSecurityTokenService stsClient)

#### Methods
- public void AddLogin(string providerName, string token)
- public virtual void CacheCredentials(Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState credentialsState)
- public virtual void CacheIdentityId(string identityId)
- public void Clear()
- public virtual void ClearIdentityCache()
- public bool ContainsProvider(string providerName)
- protected override Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState GenerateNewCredentials()
- protected override System.Threading.Tasks.Task<Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState> GenerateNewCredentialsAsync()
- public virtual Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState GetCachedCredentials()
- public virtual string GetCachedIdentityId()
- private Amazon.CognitoIdentity.Model.GetCredentialsForIdentityResponse GetCredentialsForIdentity(Amazon.CognitoIdentity.Model.GetCredentialsForIdentityRequest getCredentialsRequest)
- private Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState GetCredentialsForRole(string roleArn)
- private System.Threading.Tasks.Task<Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState> GetCredentialsForRoleAsync(string roleArn)
- public string GetIdentityId()
- private string GetIdentityId(Amazon.CognitoIdentity.CognitoAWSCredentials.RefreshIdentityOptions options)
- public System.Threading.Tasks.Task<string> GetIdentityIdAsync()
- private System.Threading.Tasks.Task<string> GetIdentityIdAsync(Amazon.CognitoIdentity.CognitoAWSCredentials.RefreshIdentityOptions options)
- protected string GetNamespacedKey(string key)
- private Amazon.CognitoIdentity.Model.GetOpenIdTokenResponse GetOpenId(Amazon.CognitoIdentity.Model.GetOpenIdTokenRequest getTokenRequest)
- private Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState GetPoolCredentials()
- private System.Threading.Tasks.Task<Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState> GetPoolCredentialsAsync()
- private Amazon.SecurityToken.Model.Credentials GetStsCredentials(Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityRequest assumeRequest)
- protected virtual Amazon.CognitoIdentity.CognitoAWSCredentials.IdentityState RefreshIdentity()
- public virtual System.Threading.Tasks.Task<Amazon.CognitoIdentity.CognitoAWSCredentials.IdentityState> RefreshIdentityAsync()
- public void RemoveLogin(string providerName)
- private bool ShouldRetry(Amazon.CognitoIdentity.AmazonCognitoIdentityException e)
- private void UpdateIdentity(string newIdentityId)

### public class Amazon.CognitoIdentity.ErrorCode
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.CognitoIdentity.ErrorCode AccessDenied
- public static readonly Amazon.CognitoIdentity.ErrorCode InternalServerError

#### Constructors
- private static ErrorCode()
- public ErrorCode(string value)

#### Methods
- public static Amazon.CognitoIdentity.ErrorCode FindValue(string value)
- public static Amazon.CognitoIdentity.ErrorCode op_Implicit(string value)

### public interface Amazon.CognitoIdentity.IAmazonCognitoIdentity
- Interfaces: Amazon.Runtime.IAmazonService, System.IDisposable

#### Methods
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.CreateIdentityPoolResponse> CreateIdentityPoolAsync(Amazon.CognitoIdentity.Model.CreateIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.DeleteIdentitiesResponse> DeleteIdentitiesAsync(Amazon.CognitoIdentity.Model.DeleteIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(string identityPoolId, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(Amazon.CognitoIdentity.Model.DeleteIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.DescribeIdentityResponse> DescribeIdentityAsync(string identityId, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.DescribeIdentityResponse> DescribeIdentityAsync(Amazon.CognitoIdentity.Model.DescribeIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(string identityPoolId, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(Amazon.CognitoIdentity.Model.DescribeIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, System.Collections.Generic.Dictionary<string, string> logins, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(Amazon.CognitoIdentity.Model.GetCredentialsForIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetIdResponse> GetIdAsync(Amazon.CognitoIdentity.Model.GetIdRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(string identityPoolId, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(Amazon.CognitoIdentity.Model.GetIdentityPoolRolesRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetOpenIdTokenResponse> GetOpenIdTokenAsync(string identityId, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetOpenIdTokenResponse> GetOpenIdTokenAsync(Amazon.CognitoIdentity.Model.GetOpenIdTokenRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.GetOpenIdTokenForDeveloperIdentityResponse> GetOpenIdTokenForDeveloperIdentityAsync(Amazon.CognitoIdentity.Model.GetOpenIdTokenForDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.ListIdentitiesResponse> ListIdentitiesAsync(Amazon.CognitoIdentity.Model.ListIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.ListIdentityPoolsResponse> ListIdentityPoolsAsync(Amazon.CognitoIdentity.Model.ListIdentityPoolsRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.ListTagsForResourceResponse> ListTagsForResourceAsync(Amazon.CognitoIdentity.Model.ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.LookupDeveloperIdentityResponse> LookupDeveloperIdentityAsync(Amazon.CognitoIdentity.Model.LookupDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.MergeDeveloperIdentitiesResponse> MergeDeveloperIdentitiesAsync(Amazon.CognitoIdentity.Model.MergeDeveloperIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(string identityPoolId, System.Collections.Generic.Dictionary<string, string> roles, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(Amazon.CognitoIdentity.Model.SetIdentityPoolRolesRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.TagResourceResponse> TagResourceAsync(Amazon.CognitoIdentity.Model.TagResourceRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.UnlinkDeveloperIdentityResponse> UnlinkDeveloperIdentityAsync(Amazon.CognitoIdentity.Model.UnlinkDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.UnlinkIdentityResponse> UnlinkIdentityAsync(Amazon.CognitoIdentity.Model.UnlinkIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.UntagResourceResponse> UntagResourceAsync(Amazon.CognitoIdentity.Model.UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.CognitoIdentity.Model.UpdateIdentityPoolResponse> UpdateIdentityPoolAsync(Amazon.CognitoIdentity.Model.UpdateIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = null)

### public class Amazon.CognitoIdentity.CognitoAWSCredentials.IdentityChangedArgs
- Base: System.EventArgs

#### Fields
- private string <NewIdentityId>k__BackingField
- private string <OldIdentityId>k__BackingField

#### Properties
- public string NewIdentityId { get; private set; }
- public string OldIdentityId { get; private set; }

#### Constructors
- internal CognitoAWSCredentials.IdentityChangedArgs(string oldIdentityId, string newIdentityId)

### public class Amazon.CognitoIdentity.CognitoAWSCredentials.IdentityState

#### Fields
- private bool <FromCache>k__BackingField
- private string <IdentityId>k__BackingField
- private string <LoginProvider>k__BackingField
- private string <LoginToken>k__BackingField

#### Properties
- public bool FromCache { get; private set; }
- public string IdentityId { get; private set; }
- public string LoginProvider { get; private set; }
- public bool LoginSpecified { get; }
- public string LoginToken { get; private set; }

#### Constructors
- public CognitoAWSCredentials.IdentityState(string identityId, bool fromCache)
- public CognitoAWSCredentials.IdentityState(string identityId, string provider, string token, bool fromCache)

### public class Amazon.CognitoIdentity.MappingRuleMatchType
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.CognitoIdentity.MappingRuleMatchType Contains
- public static readonly Amazon.CognitoIdentity.MappingRuleMatchType Equals
- public static readonly Amazon.CognitoIdentity.MappingRuleMatchType NotEqual
- public static readonly Amazon.CognitoIdentity.MappingRuleMatchType StartsWith

#### Constructors
- private static MappingRuleMatchType()
- public MappingRuleMatchType(string value)

#### Methods
- public static Amazon.CognitoIdentity.MappingRuleMatchType FindValue(string value)
- public static Amazon.CognitoIdentity.MappingRuleMatchType op_Implicit(string value)

### private enum Amazon.CognitoIdentity.CognitoAWSCredentials.RefreshIdentityOptions
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- None = 0
- Refresh = 1

### public class Amazon.CognitoIdentity.RoleMappingType
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.CognitoIdentity.RoleMappingType Rules
- public static readonly Amazon.CognitoIdentity.RoleMappingType Token

#### Constructors
- private static RoleMappingType()
- public RoleMappingType(string value)

#### Methods
- public static Amazon.CognitoIdentity.RoleMappingType FindValue(string value)
- public static Amazon.CognitoIdentity.RoleMappingType op_Implicit(string value)

## Namespace: Amazon.CognitoIdentity.Internal

### public class Amazon.CognitoIdentity.Internal.AmazonCognitoIdentityMetadata
- Interfaces: Amazon.Runtime.Internal.IServiceMetadata

#### Properties
- public System.Collections.Generic.IDictionary<string, string> OperationNameMapping { get; }
- public string ServiceId { get; }

#### Constructors
- public AmazonCognitoIdentityMetadata()

## Namespace: Amazon.CognitoIdentity.Model

### public class Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo

#### Fields
- private string _clientId
- private string _providerName
- private System.Nullable<bool> _serverSideTokenCheck

#### Properties
- public string ClientId { get; set; }
- public string ProviderName { get; set; }
- public bool ServerSideTokenCheck { get; set; }

#### Constructors
- public CognitoIdentityProviderInfo()

#### Methods
- internal bool IsSetClientId()
- internal bool IsSetProviderName()
- internal bool IsSetServerSideTokenCheck()

### public class Amazon.CognitoIdentity.Model.ConcurrentModificationException
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ConcurrentModificationException(string message)
- public ConcurrentModificationException(System.Exception innerException)
- public ConcurrentModificationException(string message, System.Exception innerException)
- public ConcurrentModificationException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public ConcurrentModificationException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.CreateIdentityPoolRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private System.Nullable<bool> _allowUnauthenticatedIdentities
- private System.Collections.Generic.List<Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo> _cognitoIdentityProviders
- private string _developerProviderName
- private string _identityPoolName
- private System.Collections.Generic.Dictionary<string, string> _identityPoolTags
- private System.Collections.Generic.List<string> _openIdConnectProviderARNs
- private System.Collections.Generic.List<string> _samlProviderARNs
- private System.Collections.Generic.Dictionary<string, string> _supportedLoginProviders

#### Properties
- public bool AllowUnauthenticatedIdentities { get; set; }
- public System.Collections.Generic.List<Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo> CognitoIdentityProviders { get; set; }
- public string DeveloperProviderName { get; set; }
- public string IdentityPoolName { get; set; }
- public System.Collections.Generic.Dictionary<string, string> IdentityPoolTags { get; set; }
- public System.Collections.Generic.List<string> OpenIdConnectProviderARNs { get; set; }
- public System.Collections.Generic.List<string> SamlProviderARNs { get; set; }
- public System.Collections.Generic.Dictionary<string, string> SupportedLoginProviders { get; set; }

#### Constructors
- public CreateIdentityPoolRequest()

#### Methods
- internal bool IsSetAllowUnauthenticatedIdentities()
- internal bool IsSetCognitoIdentityProviders()
- internal bool IsSetDeveloperProviderName()
- internal bool IsSetIdentityPoolName()
- internal bool IsSetIdentityPoolTags()
- internal bool IsSetOpenIdConnectProviderARNs()
- internal bool IsSetSamlProviderARNs()
- internal bool IsSetSupportedLoginProviders()

### public class Amazon.CognitoIdentity.Model.CreateIdentityPoolResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Nullable<bool> _allowUnauthenticatedIdentities
- private System.Collections.Generic.List<Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo> _cognitoIdentityProviders
- private string _developerProviderName
- private string _identityPoolId
- private string _identityPoolName
- private System.Collections.Generic.Dictionary<string, string> _identityPoolTags
- private System.Collections.Generic.List<string> _openIdConnectProviderARNs
- private System.Collections.Generic.List<string> _samlProviderARNs
- private System.Collections.Generic.Dictionary<string, string> _supportedLoginProviders

#### Properties
- public bool AllowUnauthenticatedIdentities { get; set; }
- public System.Collections.Generic.List<Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo> CognitoIdentityProviders { get; set; }
- public string DeveloperProviderName { get; set; }
- public string IdentityPoolId { get; set; }
- public string IdentityPoolName { get; set; }
- public System.Collections.Generic.Dictionary<string, string> IdentityPoolTags { get; set; }
- public System.Collections.Generic.List<string> OpenIdConnectProviderARNs { get; set; }
- public System.Collections.Generic.List<string> SamlProviderARNs { get; set; }
- public System.Collections.Generic.Dictionary<string, string> SupportedLoginProviders { get; set; }

#### Constructors
- public CreateIdentityPoolResponse()

#### Methods
- internal bool IsSetAllowUnauthenticatedIdentities()
- internal bool IsSetCognitoIdentityProviders()
- internal bool IsSetDeveloperProviderName()
- internal bool IsSetIdentityPoolId()
- internal bool IsSetIdentityPoolName()
- internal bool IsSetIdentityPoolTags()
- internal bool IsSetOpenIdConnectProviderARNs()
- internal bool IsSetSamlProviderARNs()
- internal bool IsSetSupportedLoginProviders()

### public class Amazon.CognitoIdentity.Model.Credentials
- Base: Amazon.Runtime.AWSCredentials

#### Fields
- private string _accessKeyId
- private Amazon.Runtime.ImmutableCredentials _credentials
- private System.Nullable<System.DateTime> _expiration
- private string _secretKey
- private string _sessionToken

#### Properties
- public string AccessKeyId { get; set; }
- public System.DateTime Expiration { get; set; }
- public string SecretKey { get; set; }
- public string SessionToken { get; set; }

#### Constructors
- public Credentials()

#### Methods
- public override Amazon.Runtime.ImmutableCredentials GetCredentials()
- internal bool IsSetAccessKeyId()
- internal bool IsSetExpiration()
- internal bool IsSetSecretKey()
- internal bool IsSetSessionToken()

### public class Amazon.CognitoIdentity.Model.DeleteIdentitiesRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private System.Collections.Generic.List<string> _identityIdsToDelete

#### Properties
- public System.Collections.Generic.List<string> IdentityIdsToDelete { get; set; }

#### Constructors
- public DeleteIdentitiesRequest()

#### Methods
- internal bool IsSetIdentityIdsToDelete()

### public class Amazon.CognitoIdentity.Model.DeleteIdentitiesResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.List<Amazon.CognitoIdentity.Model.UnprocessedIdentityId> _unprocessedIdentityIds

#### Properties
- public System.Collections.Generic.List<Amazon.CognitoIdentity.Model.UnprocessedIdentityId> UnprocessedIdentityIds { get; set; }

#### Constructors
- public DeleteIdentitiesResponse()

#### Methods
- internal bool IsSetUnprocessedIdentityIds()

### public class Amazon.CognitoIdentity.Model.DeleteIdentityPoolRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _identityPoolId

#### Properties
- public string IdentityPoolId { get; set; }

#### Constructors
- public DeleteIdentityPoolRequest()

#### Methods
- internal bool IsSetIdentityPoolId()

### public class Amazon.CognitoIdentity.Model.DeleteIdentityPoolResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public DeleteIdentityPoolResponse()

### public class Amazon.CognitoIdentity.Model.DescribeIdentityPoolRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _identityPoolId

#### Properties
- public string IdentityPoolId { get; set; }

#### Constructors
- public DescribeIdentityPoolRequest()

#### Methods
- internal bool IsSetIdentityPoolId()

### public class Amazon.CognitoIdentity.Model.DescribeIdentityPoolResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Nullable<bool> _allowUnauthenticatedIdentities
- private System.Collections.Generic.List<Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo> _cognitoIdentityProviders
- private string _developerProviderName
- private string _identityPoolId
- private string _identityPoolName
- private System.Collections.Generic.Dictionary<string, string> _identityPoolTags
- private System.Collections.Generic.List<string> _openIdConnectProviderARNs
- private System.Collections.Generic.List<string> _samlProviderARNs
- private System.Collections.Generic.Dictionary<string, string> _supportedLoginProviders

#### Properties
- public bool AllowUnauthenticatedIdentities { get; set; }
- public System.Collections.Generic.List<Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo> CognitoIdentityProviders { get; set; }
- public string DeveloperProviderName { get; set; }
- public string IdentityPoolId { get; set; }
- public string IdentityPoolName { get; set; }
- public System.Collections.Generic.Dictionary<string, string> IdentityPoolTags { get; set; }
- public System.Collections.Generic.List<string> OpenIdConnectProviderARNs { get; set; }
- public System.Collections.Generic.List<string> SamlProviderARNs { get; set; }
- public System.Collections.Generic.Dictionary<string, string> SupportedLoginProviders { get; set; }

#### Constructors
- public DescribeIdentityPoolResponse()

#### Methods
- internal bool IsSetAllowUnauthenticatedIdentities()
- internal bool IsSetCognitoIdentityProviders()
- internal bool IsSetDeveloperProviderName()
- internal bool IsSetIdentityPoolId()
- internal bool IsSetIdentityPoolName()
- internal bool IsSetIdentityPoolTags()
- internal bool IsSetOpenIdConnectProviderARNs()
- internal bool IsSetSamlProviderARNs()
- internal bool IsSetSupportedLoginProviders()

### public class Amazon.CognitoIdentity.Model.DescribeIdentityRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _identityId

#### Properties
- public string IdentityId { get; set; }

#### Constructors
- public DescribeIdentityRequest()

#### Methods
- internal bool IsSetIdentityId()

### public class Amazon.CognitoIdentity.Model.DescribeIdentityResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Nullable<System.DateTime> _creationDate
- private string _identityId
- private System.Nullable<System.DateTime> _lastModifiedDate
- private System.Collections.Generic.List<string> _logins

#### Properties
- public System.DateTime CreationDate { get; set; }
- public string IdentityId { get; set; }
- public System.DateTime LastModifiedDate { get; set; }
- public System.Collections.Generic.List<string> Logins { get; set; }

#### Constructors
- public DescribeIdentityResponse()

#### Methods
- internal bool IsSetCreationDate()
- internal bool IsSetIdentityId()
- internal bool IsSetLastModifiedDate()
- internal bool IsSetLogins()

### public class Amazon.CognitoIdentity.Model.DeveloperUserAlreadyRegisteredException
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public DeveloperUserAlreadyRegisteredException(string message)
- public DeveloperUserAlreadyRegisteredException(System.Exception innerException)
- public DeveloperUserAlreadyRegisteredException(string message, System.Exception innerException)
- public DeveloperUserAlreadyRegisteredException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public DeveloperUserAlreadyRegisteredException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.ExternalServiceException
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ExternalServiceException(string message)
- public ExternalServiceException(System.Exception innerException)
- public ExternalServiceException(string message, System.Exception innerException)
- public ExternalServiceException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public ExternalServiceException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.GetCredentialsForIdentityRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _customRoleArn
- private string _identityId
- private System.Collections.Generic.Dictionary<string, string> _logins

#### Properties
- public string CustomRoleArn { get; set; }
- public string IdentityId { get; set; }
- public System.Collections.Generic.Dictionary<string, string> Logins { get; set; }

#### Constructors
- public GetCredentialsForIdentityRequest()

#### Methods
- internal bool IsSetCustomRoleArn()
- internal bool IsSetIdentityId()
- internal bool IsSetLogins()

### public class Amazon.CognitoIdentity.Model.GetCredentialsForIdentityResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.CognitoIdentity.Model.Credentials _credentials
- private string _identityId

#### Properties
- public Amazon.CognitoIdentity.Model.Credentials Credentials { get; set; }
- public string IdentityId { get; set; }

#### Constructors
- public GetCredentialsForIdentityResponse()

#### Methods
- internal bool IsSetCredentials()
- internal bool IsSetIdentityId()

### public class Amazon.CognitoIdentity.Model.GetIdentityPoolRolesRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _identityPoolId

#### Properties
- public string IdentityPoolId { get; set; }

#### Constructors
- public GetIdentityPoolRolesRequest()

#### Methods
- internal bool IsSetIdentityPoolId()

### public class Amazon.CognitoIdentity.Model.GetIdentityPoolRolesResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string _identityPoolId
- private System.Collections.Generic.Dictionary<string, Amazon.CognitoIdentity.Model.RoleMapping> _roleMappings
- private System.Collections.Generic.Dictionary<string, string> _roles

#### Properties
- public string IdentityPoolId { get; set; }
- public System.Collections.Generic.Dictionary<string, Amazon.CognitoIdentity.Model.RoleMapping> RoleMappings { get; set; }
- public System.Collections.Generic.Dictionary<string, string> Roles { get; set; }

#### Constructors
- public GetIdentityPoolRolesResponse()

#### Methods
- internal bool IsSetIdentityPoolId()
- internal bool IsSetRoleMappings()
- internal bool IsSetRoles()

### public class Amazon.CognitoIdentity.Model.GetIdRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _accountId
- private string _identityPoolId
- private System.Collections.Generic.Dictionary<string, string> _logins

#### Properties
- public string AccountId { get; set; }
- public string IdentityPoolId { get; set; }
- public System.Collections.Generic.Dictionary<string, string> Logins { get; set; }

#### Constructors
- public GetIdRequest()

#### Methods
- internal bool IsSetAccountId()
- internal bool IsSetIdentityPoolId()
- internal bool IsSetLogins()

### public class Amazon.CognitoIdentity.Model.GetIdResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string _identityId

#### Properties
- public string IdentityId { get; set; }

#### Constructors
- public GetIdResponse()

#### Methods
- internal bool IsSetIdentityId()

### public class Amazon.CognitoIdentity.Model.GetOpenIdTokenForDeveloperIdentityRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _identityId
- private string _identityPoolId
- private System.Collections.Generic.Dictionary<string, string> _logins
- private System.Nullable<long> _tokenDuration

#### Properties
- public string IdentityId { get; set; }
- public string IdentityPoolId { get; set; }
- public System.Collections.Generic.Dictionary<string, string> Logins { get; set; }
- public long TokenDuration { get; set; }

#### Constructors
- public GetOpenIdTokenForDeveloperIdentityRequest()

#### Methods
- internal bool IsSetIdentityId()
- internal bool IsSetIdentityPoolId()
- internal bool IsSetLogins()
- internal bool IsSetTokenDuration()

### public class Amazon.CognitoIdentity.Model.GetOpenIdTokenForDeveloperIdentityResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string _identityId
- private string _token

#### Properties
- public string IdentityId { get; set; }
- public string Token { get; set; }

#### Constructors
- public GetOpenIdTokenForDeveloperIdentityResponse()

#### Methods
- internal bool IsSetIdentityId()
- internal bool IsSetToken()

### public class Amazon.CognitoIdentity.Model.GetOpenIdTokenRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _identityId
- private System.Collections.Generic.Dictionary<string, string> _logins

#### Properties
- public string IdentityId { get; set; }
- public System.Collections.Generic.Dictionary<string, string> Logins { get; set; }

#### Constructors
- public GetOpenIdTokenRequest()

#### Methods
- internal bool IsSetIdentityId()
- internal bool IsSetLogins()

### public class Amazon.CognitoIdentity.Model.GetOpenIdTokenResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string _identityId
- private string _token

#### Properties
- public string IdentityId { get; set; }
- public string Token { get; set; }

#### Constructors
- public GetOpenIdTokenResponse()

#### Methods
- internal bool IsSetIdentityId()
- internal bool IsSetToken()

### public class Amazon.CognitoIdentity.Model.IdentityDescription

#### Fields
- private System.Nullable<System.DateTime> _creationDate
- private string _identityId
- private System.Nullable<System.DateTime> _lastModifiedDate
- private System.Collections.Generic.List<string> _logins

#### Properties
- public System.DateTime CreationDate { get; set; }
- public string IdentityId { get; set; }
- public System.DateTime LastModifiedDate { get; set; }
- public System.Collections.Generic.List<string> Logins { get; set; }

#### Constructors
- public IdentityDescription()

#### Methods
- internal bool IsSetCreationDate()
- internal bool IsSetIdentityId()
- internal bool IsSetLastModifiedDate()
- internal bool IsSetLogins()

### public class Amazon.CognitoIdentity.Model.IdentityPoolShortDescription

#### Fields
- private string _identityPoolId
- private string _identityPoolName

#### Properties
- public string IdentityPoolId { get; set; }
- public string IdentityPoolName { get; set; }

#### Constructors
- public IdentityPoolShortDescription()

#### Methods
- internal bool IsSetIdentityPoolId()
- internal bool IsSetIdentityPoolName()

### public class Amazon.CognitoIdentity.Model.InternalErrorException
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public InternalErrorException(string message)
- public InternalErrorException(System.Exception innerException)
- public InternalErrorException(string message, System.Exception innerException)
- public InternalErrorException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public InternalErrorException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.InvalidIdentityPoolConfigurationException
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public InvalidIdentityPoolConfigurationException(string message)
- public InvalidIdentityPoolConfigurationException(System.Exception innerException)
- public InvalidIdentityPoolConfigurationException(string message, System.Exception innerException)
- public InvalidIdentityPoolConfigurationException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public InvalidIdentityPoolConfigurationException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.InvalidParameterException
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public InvalidParameterException(string message)
- public InvalidParameterException(System.Exception innerException)
- public InvalidParameterException(string message, System.Exception innerException)
- public InvalidParameterException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public InvalidParameterException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.LimitExceededException
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public LimitExceededException(string message)
- public LimitExceededException(System.Exception innerException)
- public LimitExceededException(string message, System.Exception innerException)
- public LimitExceededException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public LimitExceededException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.ListIdentitiesRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private System.Nullable<bool> _hideDisabled
- private string _identityPoolId
- private System.Nullable<int> _maxResults
- private string _nextToken

#### Properties
- public bool HideDisabled { get; set; }
- public string IdentityPoolId { get; set; }
- public int MaxResults { get; set; }
- public string NextToken { get; set; }

#### Constructors
- public ListIdentitiesRequest()

#### Methods
- internal bool IsSetHideDisabled()
- internal bool IsSetIdentityPoolId()
- internal bool IsSetMaxResults()
- internal bool IsSetNextToken()

### public class Amazon.CognitoIdentity.Model.ListIdentitiesResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.List<Amazon.CognitoIdentity.Model.IdentityDescription> _identities
- private string _identityPoolId
- private string _nextToken

#### Properties
- public System.Collections.Generic.List<Amazon.CognitoIdentity.Model.IdentityDescription> Identities { get; set; }
- public string IdentityPoolId { get; set; }
- public string NextToken { get; set; }

#### Constructors
- public ListIdentitiesResponse()

#### Methods
- internal bool IsSetIdentities()
- internal bool IsSetIdentityPoolId()
- internal bool IsSetNextToken()

### public class Amazon.CognitoIdentity.Model.ListIdentityPoolsRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private System.Nullable<int> _maxResults
- private string _nextToken

#### Properties
- public int MaxResults { get; set; }
- public string NextToken { get; set; }

#### Constructors
- public ListIdentityPoolsRequest()

#### Methods
- internal bool IsSetMaxResults()
- internal bool IsSetNextToken()

### public class Amazon.CognitoIdentity.Model.ListIdentityPoolsResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.List<Amazon.CognitoIdentity.Model.IdentityPoolShortDescription> _identityPools
- private string _nextToken

#### Properties
- public System.Collections.Generic.List<Amazon.CognitoIdentity.Model.IdentityPoolShortDescription> IdentityPools { get; set; }
- public string NextToken { get; set; }

#### Constructors
- public ListIdentityPoolsResponse()

#### Methods
- internal bool IsSetIdentityPools()
- internal bool IsSetNextToken()

### public class Amazon.CognitoIdentity.Model.ListTagsForResourceRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _resourceArn

#### Properties
- public string ResourceArn { get; set; }

#### Constructors
- public ListTagsForResourceRequest()

#### Methods
- internal bool IsSetResourceArn()

### public class Amazon.CognitoIdentity.Model.ListTagsForResourceResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.Dictionary<string, string> _tags

#### Properties
- public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

#### Constructors
- public ListTagsForResourceResponse()

#### Methods
- internal bool IsSetTags()

### public class Amazon.CognitoIdentity.Model.LookupDeveloperIdentityRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _developerUserIdentifier
- private string _identityId
- private string _identityPoolId
- private System.Nullable<int> _maxResults
- private string _nextToken

#### Properties
- public string DeveloperUserIdentifier { get; set; }
- public string IdentityId { get; set; }
- public string IdentityPoolId { get; set; }
- public int MaxResults { get; set; }
- public string NextToken { get; set; }

#### Constructors
- public LookupDeveloperIdentityRequest()

#### Methods
- internal bool IsSetDeveloperUserIdentifier()
- internal bool IsSetIdentityId()
- internal bool IsSetIdentityPoolId()
- internal bool IsSetMaxResults()
- internal bool IsSetNextToken()

### public class Amazon.CognitoIdentity.Model.LookupDeveloperIdentityResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.List<string> _developerUserIdentifierList
- private string _identityId
- private string _nextToken

#### Properties
- public System.Collections.Generic.List<string> DeveloperUserIdentifierList { get; set; }
- public string IdentityId { get; set; }
- public string NextToken { get; set; }

#### Constructors
- public LookupDeveloperIdentityResponse()

#### Methods
- internal bool IsSetDeveloperUserIdentifierList()
- internal bool IsSetIdentityId()
- internal bool IsSetNextToken()

### public class Amazon.CognitoIdentity.Model.MappingRule

#### Fields
- private string _claim
- private Amazon.CognitoIdentity.MappingRuleMatchType _matchType
- private string _roleARN
- private string _value

#### Properties
- public string Claim { get; set; }
- public Amazon.CognitoIdentity.MappingRuleMatchType MatchType { get; set; }
- public string RoleARN { get; set; }
- public string Value { get; set; }

#### Constructors
- public MappingRule()

#### Methods
- internal bool IsSetClaim()
- internal bool IsSetMatchType()
- internal bool IsSetRoleARN()
- internal bool IsSetValue()

### public class Amazon.CognitoIdentity.Model.MergeDeveloperIdentitiesRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _destinationUserIdentifier
- private string _developerProviderName
- private string _identityPoolId
- private string _sourceUserIdentifier

#### Properties
- public string DestinationUserIdentifier { get; set; }
- public string DeveloperProviderName { get; set; }
- public string IdentityPoolId { get; set; }
- public string SourceUserIdentifier { get; set; }

#### Constructors
- public MergeDeveloperIdentitiesRequest()

#### Methods
- internal bool IsSetDestinationUserIdentifier()
- internal bool IsSetDeveloperProviderName()
- internal bool IsSetIdentityPoolId()
- internal bool IsSetSourceUserIdentifier()

### public class Amazon.CognitoIdentity.Model.MergeDeveloperIdentitiesResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string _identityId

#### Properties
- public string IdentityId { get; set; }

#### Constructors
- public MergeDeveloperIdentitiesResponse()

#### Methods
- internal bool IsSetIdentityId()

### public class Amazon.CognitoIdentity.Model.NotAuthorizedException
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public NotAuthorizedException(string message)
- public NotAuthorizedException(System.Exception innerException)
- public NotAuthorizedException(string message, System.Exception innerException)
- public NotAuthorizedException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public NotAuthorizedException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.ResourceConflictException
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ResourceConflictException(string message)
- public ResourceConflictException(System.Exception innerException)
- public ResourceConflictException(string message, System.Exception innerException)
- public ResourceConflictException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public ResourceConflictException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.ResourceNotFoundException
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ResourceNotFoundException(string message)
- public ResourceNotFoundException(System.Exception innerException)
- public ResourceNotFoundException(string message, System.Exception innerException)
- public ResourceNotFoundException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public ResourceNotFoundException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.RoleMapping

#### Fields
- private Amazon.CognitoIdentity.AmbiguousRoleResolutionType _ambiguousRoleResolution
- private Amazon.CognitoIdentity.Model.RulesConfigurationType _rulesConfiguration
- private Amazon.CognitoIdentity.RoleMappingType _type

#### Properties
- public Amazon.CognitoIdentity.AmbiguousRoleResolutionType AmbiguousRoleResolution { get; set; }
- public Amazon.CognitoIdentity.Model.RulesConfigurationType RulesConfiguration { get; set; }
- public Amazon.CognitoIdentity.RoleMappingType Type { get; set; }

#### Constructors
- public RoleMapping()

#### Methods
- internal bool IsSetAmbiguousRoleResolution()
- internal bool IsSetRulesConfiguration()
- internal bool IsSetType()

### public class Amazon.CognitoIdentity.Model.RulesConfigurationType

#### Fields
- private System.Collections.Generic.List<Amazon.CognitoIdentity.Model.MappingRule> _rules

#### Properties
- public System.Collections.Generic.List<Amazon.CognitoIdentity.Model.MappingRule> Rules { get; set; }

#### Constructors
- public RulesConfigurationType()

#### Methods
- internal bool IsSetRules()

### public class Amazon.CognitoIdentity.Model.SetIdentityPoolRolesRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _identityPoolId
- private System.Collections.Generic.Dictionary<string, Amazon.CognitoIdentity.Model.RoleMapping> _roleMappings
- private System.Collections.Generic.Dictionary<string, string> _roles

#### Properties
- public string IdentityPoolId { get; set; }
- public System.Collections.Generic.Dictionary<string, Amazon.CognitoIdentity.Model.RoleMapping> RoleMappings { get; set; }
- public System.Collections.Generic.Dictionary<string, string> Roles { get; set; }

#### Constructors
- public SetIdentityPoolRolesRequest()

#### Methods
- internal bool IsSetIdentityPoolId()
- internal bool IsSetRoleMappings()
- internal bool IsSetRoles()

### public class Amazon.CognitoIdentity.Model.SetIdentityPoolRolesResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public SetIdentityPoolRolesResponse()

### public class Amazon.CognitoIdentity.Model.TagResourceRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _resourceArn
- private System.Collections.Generic.Dictionary<string, string> _tags

#### Properties
- public string ResourceArn { get; set; }
- public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

#### Constructors
- public TagResourceRequest()

#### Methods
- internal bool IsSetResourceArn()
- internal bool IsSetTags()

### public class Amazon.CognitoIdentity.Model.TagResourceResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public TagResourceResponse()

### public class Amazon.CognitoIdentity.Model.TooManyRequestsException
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public TooManyRequestsException(string message)
- public TooManyRequestsException(System.Exception innerException)
- public TooManyRequestsException(string message, System.Exception innerException)
- public TooManyRequestsException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public TooManyRequestsException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.UnlinkDeveloperIdentityRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _developerProviderName
- private string _developerUserIdentifier
- private string _identityId
- private string _identityPoolId

#### Properties
- public string DeveloperProviderName { get; set; }
- public string DeveloperUserIdentifier { get; set; }
- public string IdentityId { get; set; }
- public string IdentityPoolId { get; set; }

#### Constructors
- public UnlinkDeveloperIdentityRequest()

#### Methods
- internal bool IsSetDeveloperProviderName()
- internal bool IsSetDeveloperUserIdentifier()
- internal bool IsSetIdentityId()
- internal bool IsSetIdentityPoolId()

### public class Amazon.CognitoIdentity.Model.UnlinkDeveloperIdentityResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public UnlinkDeveloperIdentityResponse()

### public class Amazon.CognitoIdentity.Model.UnlinkIdentityRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _identityId
- private System.Collections.Generic.Dictionary<string, string> _logins
- private System.Collections.Generic.List<string> _loginsToRemove

#### Properties
- public string IdentityId { get; set; }
- public System.Collections.Generic.Dictionary<string, string> Logins { get; set; }
- public System.Collections.Generic.List<string> LoginsToRemove { get; set; }

#### Constructors
- public UnlinkIdentityRequest()

#### Methods
- internal bool IsSetIdentityId()
- internal bool IsSetLogins()
- internal bool IsSetLoginsToRemove()

### public class Amazon.CognitoIdentity.Model.UnlinkIdentityResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public UnlinkIdentityResponse()

### public class Amazon.CognitoIdentity.Model.UnprocessedIdentityId

#### Fields
- private Amazon.CognitoIdentity.ErrorCode _errorCode
- private string _identityId

#### Properties
- public Amazon.CognitoIdentity.ErrorCode ErrorCode { get; set; }
- public string IdentityId { get; set; }

#### Constructors
- public UnprocessedIdentityId()

#### Methods
- internal bool IsSetErrorCode()
- internal bool IsSetIdentityId()

### public class Amazon.CognitoIdentity.Model.UntagResourceRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _resourceArn
- private System.Collections.Generic.List<string> _tagKeys

#### Properties
- public string ResourceArn { get; set; }
- public System.Collections.Generic.List<string> TagKeys { get; set; }

#### Constructors
- public UntagResourceRequest()

#### Methods
- internal bool IsSetResourceArn()
- internal bool IsSetTagKeys()

### public class Amazon.CognitoIdentity.Model.UntagResourceResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public UntagResourceResponse()

### public class Amazon.CognitoIdentity.Model.UpdateIdentityPoolRequest
- Base: Amazon.CognitoIdentity.AmazonCognitoIdentityRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private System.Nullable<bool> _allowUnauthenticatedIdentities
- private System.Collections.Generic.List<Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo> _cognitoIdentityProviders
- private string _developerProviderName
- private string _identityPoolId
- private string _identityPoolName
- private System.Collections.Generic.Dictionary<string, string> _identityPoolTags
- private System.Collections.Generic.List<string> _openIdConnectProviderARNs
- private System.Collections.Generic.List<string> _samlProviderARNs
- private System.Collections.Generic.Dictionary<string, string> _supportedLoginProviders

#### Properties
- public bool AllowUnauthenticatedIdentities { get; set; }
- public System.Collections.Generic.List<Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo> CognitoIdentityProviders { get; set; }
- public string DeveloperProviderName { get; set; }
- public string IdentityPoolId { get; set; }
- public string IdentityPoolName { get; set; }
- public System.Collections.Generic.Dictionary<string, string> IdentityPoolTags { get; set; }
- public System.Collections.Generic.List<string> OpenIdConnectProviderARNs { get; set; }
- public System.Collections.Generic.List<string> SamlProviderARNs { get; set; }
- public System.Collections.Generic.Dictionary<string, string> SupportedLoginProviders { get; set; }

#### Constructors
- public UpdateIdentityPoolRequest()

#### Methods
- internal bool IsSetAllowUnauthenticatedIdentities()
- internal bool IsSetCognitoIdentityProviders()
- internal bool IsSetDeveloperProviderName()
- internal bool IsSetIdentityPoolId()
- internal bool IsSetIdentityPoolName()
- internal bool IsSetIdentityPoolTags()
- internal bool IsSetOpenIdConnectProviderARNs()
- internal bool IsSetSamlProviderARNs()
- internal bool IsSetSupportedLoginProviders()

### public class Amazon.CognitoIdentity.Model.UpdateIdentityPoolResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Nullable<bool> _allowUnauthenticatedIdentities
- private System.Collections.Generic.List<Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo> _cognitoIdentityProviders
- private string _developerProviderName
- private string _identityPoolId
- private string _identityPoolName
- private System.Collections.Generic.Dictionary<string, string> _identityPoolTags
- private System.Collections.Generic.List<string> _openIdConnectProviderARNs
- private System.Collections.Generic.List<string> _samlProviderARNs
- private System.Collections.Generic.Dictionary<string, string> _supportedLoginProviders

#### Properties
- public bool AllowUnauthenticatedIdentities { get; set; }
- public System.Collections.Generic.List<Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo> CognitoIdentityProviders { get; set; }
- public string DeveloperProviderName { get; set; }
- public string IdentityPoolId { get; set; }
- public string IdentityPoolName { get; set; }
- public System.Collections.Generic.Dictionary<string, string> IdentityPoolTags { get; set; }
- public System.Collections.Generic.List<string> OpenIdConnectProviderARNs { get; set; }
- public System.Collections.Generic.List<string> SamlProviderARNs { get; set; }
- public System.Collections.Generic.Dictionary<string, string> SupportedLoginProviders { get; set; }

#### Constructors
- public UpdateIdentityPoolResponse()

#### Methods
- internal bool IsSetAllowUnauthenticatedIdentities()
- internal bool IsSetCognitoIdentityProviders()
- internal bool IsSetDeveloperProviderName()
- internal bool IsSetIdentityPoolId()
- internal bool IsSetIdentityPoolName()
- internal bool IsSetIdentityPoolTags()
- internal bool IsSetOpenIdConnectProviderARNs()
- internal bool IsSetSamlProviderARNs()
- internal bool IsSetSupportedLoginProviders()

## Namespace: Amazon.CognitoIdentity.Model.Internal.MarshallTransformations

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CognitoIdentityProviderInfoMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IRequestMarshaller<Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo, Amazon.Runtime.Internal.Transform.JsonMarshallerContext>

#### Fields
- public static readonly Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CognitoIdentityProviderInfoMarshaller Instance

#### Constructors
- public CognitoIdentityProviderInfoMarshaller()
- private static CognitoIdentityProviderInfoMarshaller()

#### Methods
- public void Marshall(Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo requestObject, Amazon.Runtime.Internal.Transform.JsonMarshallerContext context)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CognitoIdentityProviderInfoUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CognitoIdentityProviderInfoUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CognitoIdentityProviderInfoUnmarshaller Instance { get; }

#### Constructors
- public CognitoIdentityProviderInfoUnmarshaller()
- private static CognitoIdentityProviderInfoUnmarshaller()

#### Methods
- private Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo,Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>.Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.CognitoIdentity.Model.CognitoIdentityProviderInfo Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CreateIdentityPoolRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.CreateIdentityPoolRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CreateIdentityPoolRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CreateIdentityPoolRequestMarshaller Instance { get; }

#### Constructors
- public CreateIdentityPoolRequestMarshaller()
- private static CreateIdentityPoolRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CreateIdentityPoolRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.CreateIdentityPoolRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CreateIdentityPoolResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CreateIdentityPoolResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CreateIdentityPoolResponseUnmarshaller Instance { get; }

#### Constructors
- public CreateIdentityPoolResponseUnmarshaller()
- private static CreateIdentityPoolResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CreateIdentityPoolResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CredentialsUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.Credentials, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.Credentials, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CredentialsUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.CredentialsUnmarshaller Instance { get; }

#### Constructors
- public CredentialsUnmarshaller()
- private static CredentialsUnmarshaller()

#### Methods
- private Amazon.CognitoIdentity.Model.Credentials Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.Credentials,Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>.Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.CognitoIdentity.Model.Credentials Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentitiesRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.DeleteIdentitiesRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentitiesRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentitiesRequestMarshaller Instance { get; }

#### Constructors
- public DeleteIdentitiesRequestMarshaller()
- private static DeleteIdentitiesRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentitiesRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.DeleteIdentitiesRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentitiesResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentitiesResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentitiesResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteIdentitiesResponseUnmarshaller()
- private static DeleteIdentitiesResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentitiesResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentityPoolRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.DeleteIdentityPoolRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentityPoolRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentityPoolRequestMarshaller Instance { get; }

#### Constructors
- public DeleteIdentityPoolRequestMarshaller()
- private static DeleteIdentityPoolRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentityPoolRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.DeleteIdentityPoolRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentityPoolResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentityPoolResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentityPoolResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteIdentityPoolResponseUnmarshaller()
- private static DeleteIdentityPoolResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DeleteIdentityPoolResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityPoolRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.DescribeIdentityPoolRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityPoolRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityPoolRequestMarshaller Instance { get; }

#### Constructors
- public DescribeIdentityPoolRequestMarshaller()
- private static DescribeIdentityPoolRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityPoolRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.DescribeIdentityPoolRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityPoolResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityPoolResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityPoolResponseUnmarshaller Instance { get; }

#### Constructors
- public DescribeIdentityPoolResponseUnmarshaller()
- private static DescribeIdentityPoolResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityPoolResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.DescribeIdentityRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityRequestMarshaller Instance { get; }

#### Constructors
- public DescribeIdentityRequestMarshaller()
- private static DescribeIdentityRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.DescribeIdentityRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityResponseUnmarshaller Instance { get; }

#### Constructors
- public DescribeIdentityResponseUnmarshaller()
- private static DescribeIdentityResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.DescribeIdentityResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetCredentialsForIdentityRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.GetCredentialsForIdentityRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetCredentialsForIdentityRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetCredentialsForIdentityRequestMarshaller Instance { get; }

#### Constructors
- public GetCredentialsForIdentityRequestMarshaller()
- private static GetCredentialsForIdentityRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetCredentialsForIdentityRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.GetCredentialsForIdentityRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetCredentialsForIdentityResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetCredentialsForIdentityResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetCredentialsForIdentityResponseUnmarshaller Instance { get; }

#### Constructors
- public GetCredentialsForIdentityResponseUnmarshaller()
- private static GetCredentialsForIdentityResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetCredentialsForIdentityResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdentityPoolRolesRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.GetIdentityPoolRolesRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdentityPoolRolesRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdentityPoolRolesRequestMarshaller Instance { get; }

#### Constructors
- public GetIdentityPoolRolesRequestMarshaller()
- private static GetIdentityPoolRolesRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdentityPoolRolesRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.GetIdentityPoolRolesRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdentityPoolRolesResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdentityPoolRolesResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdentityPoolRolesResponseUnmarshaller Instance { get; }

#### Constructors
- public GetIdentityPoolRolesResponseUnmarshaller()
- private static GetIdentityPoolRolesResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdentityPoolRolesResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.GetIdRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdRequestMarshaller Instance { get; }

#### Constructors
- public GetIdRequestMarshaller()
- private static GetIdRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.GetIdRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdResponseUnmarshaller Instance { get; }

#### Constructors
- public GetIdResponseUnmarshaller()
- private static GetIdResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetIdResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenForDeveloperIdentityRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.GetOpenIdTokenForDeveloperIdentityRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenForDeveloperIdentityRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenForDeveloperIdentityRequestMarshaller Instance { get; }

#### Constructors
- public GetOpenIdTokenForDeveloperIdentityRequestMarshaller()
- private static GetOpenIdTokenForDeveloperIdentityRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenForDeveloperIdentityRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.GetOpenIdTokenForDeveloperIdentityRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller Instance { get; }

#### Constructors
- public GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller()
- private static GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.GetOpenIdTokenRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenRequestMarshaller Instance { get; }

#### Constructors
- public GetOpenIdTokenRequestMarshaller()
- private static GetOpenIdTokenRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.GetOpenIdTokenRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenResponseUnmarshaller Instance { get; }

#### Constructors
- public GetOpenIdTokenResponseUnmarshaller()
- private static GetOpenIdTokenResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.GetOpenIdTokenResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.IdentityDescriptionUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.IdentityDescription, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.IdentityDescription, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.IdentityDescriptionUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.IdentityDescriptionUnmarshaller Instance { get; }

#### Constructors
- public IdentityDescriptionUnmarshaller()
- private static IdentityDescriptionUnmarshaller()

#### Methods
- private Amazon.CognitoIdentity.Model.IdentityDescription Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.IdentityDescription,Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>.Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.CognitoIdentity.Model.IdentityDescription Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.IdentityPoolShortDescriptionUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.IdentityPoolShortDescription, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.IdentityPoolShortDescription, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.IdentityPoolShortDescriptionUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.IdentityPoolShortDescriptionUnmarshaller Instance { get; }

#### Constructors
- public IdentityPoolShortDescriptionUnmarshaller()
- private static IdentityPoolShortDescriptionUnmarshaller()

#### Methods
- private Amazon.CognitoIdentity.Model.IdentityPoolShortDescription Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.IdentityPoolShortDescription,Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>.Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.CognitoIdentity.Model.IdentityPoolShortDescription Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentitiesRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.ListIdentitiesRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentitiesRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentitiesRequestMarshaller Instance { get; }

#### Constructors
- public ListIdentitiesRequestMarshaller()
- private static ListIdentitiesRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentitiesRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.ListIdentitiesRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentitiesResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentitiesResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentitiesResponseUnmarshaller Instance { get; }

#### Constructors
- public ListIdentitiesResponseUnmarshaller()
- private static ListIdentitiesResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentitiesResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentityPoolsRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.ListIdentityPoolsRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentityPoolsRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentityPoolsRequestMarshaller Instance { get; }

#### Constructors
- public ListIdentityPoolsRequestMarshaller()
- private static ListIdentityPoolsRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentityPoolsRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.ListIdentityPoolsRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentityPoolsResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentityPoolsResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentityPoolsResponseUnmarshaller Instance { get; }

#### Constructors
- public ListIdentityPoolsResponseUnmarshaller()
- private static ListIdentityPoolsResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListIdentityPoolsResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListTagsForResourceRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.ListTagsForResourceRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListTagsForResourceRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListTagsForResourceRequestMarshaller Instance { get; }

#### Constructors
- public ListTagsForResourceRequestMarshaller()
- private static ListTagsForResourceRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListTagsForResourceRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.ListTagsForResourceRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListTagsForResourceResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListTagsForResourceResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListTagsForResourceResponseUnmarshaller Instance { get; }

#### Constructors
- public ListTagsForResourceResponseUnmarshaller()
- private static ListTagsForResourceResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.ListTagsForResourceResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.LookupDeveloperIdentityRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.LookupDeveloperIdentityRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.LookupDeveloperIdentityRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.LookupDeveloperIdentityRequestMarshaller Instance { get; }

#### Constructors
- public LookupDeveloperIdentityRequestMarshaller()
- private static LookupDeveloperIdentityRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.LookupDeveloperIdentityRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.LookupDeveloperIdentityRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.LookupDeveloperIdentityResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.LookupDeveloperIdentityResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.LookupDeveloperIdentityResponseUnmarshaller Instance { get; }

#### Constructors
- public LookupDeveloperIdentityResponseUnmarshaller()
- private static LookupDeveloperIdentityResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.LookupDeveloperIdentityResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.MappingRuleMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IRequestMarshaller<Amazon.CognitoIdentity.Model.MappingRule, Amazon.Runtime.Internal.Transform.JsonMarshallerContext>

#### Fields
- public static readonly Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.MappingRuleMarshaller Instance

#### Constructors
- public MappingRuleMarshaller()
- private static MappingRuleMarshaller()

#### Methods
- public void Marshall(Amazon.CognitoIdentity.Model.MappingRule requestObject, Amazon.Runtime.Internal.Transform.JsonMarshallerContext context)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.MappingRuleUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.MappingRule, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.MappingRule, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.MappingRuleUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.MappingRuleUnmarshaller Instance { get; }

#### Constructors
- public MappingRuleUnmarshaller()
- private static MappingRuleUnmarshaller()

#### Methods
- private Amazon.CognitoIdentity.Model.MappingRule Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.MappingRule,Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>.Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.CognitoIdentity.Model.MappingRule Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.MergeDeveloperIdentitiesRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.MergeDeveloperIdentitiesRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.MergeDeveloperIdentitiesRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.MergeDeveloperIdentitiesRequestMarshaller Instance { get; }

#### Constructors
- public MergeDeveloperIdentitiesRequestMarshaller()
- private static MergeDeveloperIdentitiesRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.MergeDeveloperIdentitiesRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.MergeDeveloperIdentitiesRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.MergeDeveloperIdentitiesResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.MergeDeveloperIdentitiesResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.MergeDeveloperIdentitiesResponseUnmarshaller Instance { get; }

#### Constructors
- public MergeDeveloperIdentitiesResponseUnmarshaller()
- private static MergeDeveloperIdentitiesResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.MergeDeveloperIdentitiesResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.RoleMappingMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IRequestMarshaller<Amazon.CognitoIdentity.Model.RoleMapping, Amazon.Runtime.Internal.Transform.JsonMarshallerContext>

#### Fields
- public static readonly Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.RoleMappingMarshaller Instance

#### Constructors
- public RoleMappingMarshaller()
- private static RoleMappingMarshaller()

#### Methods
- public void Marshall(Amazon.CognitoIdentity.Model.RoleMapping requestObject, Amazon.Runtime.Internal.Transform.JsonMarshallerContext context)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.RoleMappingUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.RoleMapping, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.RoleMapping, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.RoleMappingUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.RoleMappingUnmarshaller Instance { get; }

#### Constructors
- public RoleMappingUnmarshaller()
- private static RoleMappingUnmarshaller()

#### Methods
- private Amazon.CognitoIdentity.Model.RoleMapping Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.RoleMapping,Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>.Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.CognitoIdentity.Model.RoleMapping Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.RulesConfigurationTypeMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IRequestMarshaller<Amazon.CognitoIdentity.Model.RulesConfigurationType, Amazon.Runtime.Internal.Transform.JsonMarshallerContext>

#### Fields
- public static readonly Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.RulesConfigurationTypeMarshaller Instance

#### Constructors
- public RulesConfigurationTypeMarshaller()
- private static RulesConfigurationTypeMarshaller()

#### Methods
- public void Marshall(Amazon.CognitoIdentity.Model.RulesConfigurationType requestObject, Amazon.Runtime.Internal.Transform.JsonMarshallerContext context)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.RulesConfigurationTypeUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.RulesConfigurationType, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.RulesConfigurationType, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.RulesConfigurationTypeUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.RulesConfigurationTypeUnmarshaller Instance { get; }

#### Constructors
- public RulesConfigurationTypeUnmarshaller()
- private static RulesConfigurationTypeUnmarshaller()

#### Methods
- private Amazon.CognitoIdentity.Model.RulesConfigurationType Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.RulesConfigurationType,Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>.Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.CognitoIdentity.Model.RulesConfigurationType Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.SetIdentityPoolRolesRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.SetIdentityPoolRolesRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.SetIdentityPoolRolesRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.SetIdentityPoolRolesRequestMarshaller Instance { get; }

#### Constructors
- public SetIdentityPoolRolesRequestMarshaller()
- private static SetIdentityPoolRolesRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.SetIdentityPoolRolesRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.SetIdentityPoolRolesRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.SetIdentityPoolRolesResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.SetIdentityPoolRolesResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.SetIdentityPoolRolesResponseUnmarshaller Instance { get; }

#### Constructors
- public SetIdentityPoolRolesResponseUnmarshaller()
- private static SetIdentityPoolRolesResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.SetIdentityPoolRolesResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.TagResourceRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.TagResourceRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.TagResourceRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.TagResourceRequestMarshaller Instance { get; }

#### Constructors
- public TagResourceRequestMarshaller()
- private static TagResourceRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.TagResourceRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.TagResourceRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.TagResourceResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.TagResourceResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.TagResourceResponseUnmarshaller Instance { get; }

#### Constructors
- public TagResourceResponseUnmarshaller()
- private static TagResourceResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.TagResourceResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkDeveloperIdentityRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.UnlinkDeveloperIdentityRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkDeveloperIdentityRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkDeveloperIdentityRequestMarshaller Instance { get; }

#### Constructors
- public UnlinkDeveloperIdentityRequestMarshaller()
- private static UnlinkDeveloperIdentityRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkDeveloperIdentityRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.UnlinkDeveloperIdentityRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkDeveloperIdentityResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkDeveloperIdentityResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkDeveloperIdentityResponseUnmarshaller Instance { get; }

#### Constructors
- public UnlinkDeveloperIdentityResponseUnmarshaller()
- private static UnlinkDeveloperIdentityResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkDeveloperIdentityResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkIdentityRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.UnlinkIdentityRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkIdentityRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkIdentityRequestMarshaller Instance { get; }

#### Constructors
- public UnlinkIdentityRequestMarshaller()
- private static UnlinkIdentityRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkIdentityRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.UnlinkIdentityRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkIdentityResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkIdentityResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkIdentityResponseUnmarshaller Instance { get; }

#### Constructors
- public UnlinkIdentityResponseUnmarshaller()
- private static UnlinkIdentityResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnlinkIdentityResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnprocessedIdentityIdUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.UnprocessedIdentityId, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.UnprocessedIdentityId, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnprocessedIdentityIdUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UnprocessedIdentityIdUnmarshaller Instance { get; }

#### Constructors
- public UnprocessedIdentityIdUnmarshaller()
- private static UnprocessedIdentityIdUnmarshaller()

#### Methods
- private Amazon.CognitoIdentity.Model.UnprocessedIdentityId Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.CognitoIdentity.Model.UnprocessedIdentityId,Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>.Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.CognitoIdentity.Model.UnprocessedIdentityId Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UntagResourceRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.UntagResourceRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UntagResourceRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UntagResourceRequestMarshaller Instance { get; }

#### Constructors
- public UntagResourceRequestMarshaller()
- private static UntagResourceRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UntagResourceRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.UntagResourceRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UntagResourceResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UntagResourceResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UntagResourceResponseUnmarshaller Instance { get; }

#### Constructors
- public UntagResourceResponseUnmarshaller()
- private static UntagResourceResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UntagResourceResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UpdateIdentityPoolRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.CognitoIdentity.Model.UpdateIdentityPoolRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UpdateIdentityPoolRequestMarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UpdateIdentityPoolRequestMarshaller Instance { get; }

#### Constructors
- public UpdateIdentityPoolRequestMarshaller()
- private static UpdateIdentityPoolRequestMarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UpdateIdentityPoolRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.CognitoIdentity.Model.UpdateIdentityPoolRequest publicRequest)

### public class Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UpdateIdentityPoolResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UpdateIdentityPoolResponseUnmarshaller _instance

#### Properties
- public static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UpdateIdentityPoolResponseUnmarshaller Instance { get; }

#### Constructors
- public UpdateIdentityPoolResponseUnmarshaller()
- private static UpdateIdentityPoolResponseUnmarshaller()

#### Methods
- internal static Amazon.CognitoIdentity.Model.Internal.MarshallTransformations.UpdateIdentityPoolResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

