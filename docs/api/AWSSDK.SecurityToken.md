# Assembly: AWSSDK.SecurityToken
- Path: tools/WorldBox.Managed/AWSSDK.SecurityToken.dll
- Types: 61

## Namespace: Amazon.SecurityToken

### public class Amazon.SecurityToken.AmazonSecurityTokenServiceClient
- Base: Amazon.Runtime.AmazonServiceClient
- Interfaces: System.IDisposable, Amazon.SecurityToken.IAmazonSecurityTokenService, Amazon.Runtime.SharedInterfaces.ICoreAmazonSTS, Amazon.Runtime.SharedInterfaces.ICoreAmazonSTS_SAML, Amazon.Runtime.IAmazonService

#### Fields
- private static Amazon.Runtime.Internal.IServiceMetadata serviceMetadata

#### Properties
- protected Amazon.Runtime.Internal.IServiceMetadata ServiceMetadata { get; }

#### Constructors
- public AmazonSecurityTokenServiceClient()
- private static AmazonSecurityTokenServiceClient()
- public AmazonSecurityTokenServiceClient(Amazon.RegionEndpoint region)
- public AmazonSecurityTokenServiceClient(Amazon.SecurityToken.AmazonSecurityTokenServiceConfig config)
- public AmazonSecurityTokenServiceClient(Amazon.Runtime.AWSCredentials credentials)
- public AmazonSecurityTokenServiceClient(Amazon.Runtime.AWSCredentials credentials, Amazon.RegionEndpoint region)
- public AmazonSecurityTokenServiceClient(Amazon.Runtime.AWSCredentials credentials, Amazon.SecurityToken.AmazonSecurityTokenServiceConfig clientConfig)
- public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
- public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, Amazon.RegionEndpoint region)
- public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, Amazon.SecurityToken.AmazonSecurityTokenServiceConfig clientConfig)
- public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
- public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, Amazon.RegionEndpoint region)
- public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, Amazon.SecurityToken.AmazonSecurityTokenServiceConfig clientConfig)

#### Methods
- private Amazon.Runtime.AssumeRoleImmutableCredentials Amazon.Runtime.SharedInterfaces.ICoreAmazonSTS.CredentialsFromAssumeRoleAuthentication(string roleArn, string roleSessionName, Amazon.Runtime.AssumeRoleAWSCredentialsOptions options)
- private Amazon.Runtime.SAMLImmutableCredentials Amazon.Runtime.SharedInterfaces.ICoreAmazonSTS_SAML.CredentialsFromSAMLAuthentication(string endpoint, string authenticationType, string roleARN, System.TimeSpan credentialDuration, System.Net.ICredentials userCredential)
- internal virtual Amazon.SecurityToken.Model.AssumeRoleResponse AssumeRole(Amazon.SecurityToken.Model.AssumeRoleRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.SecurityToken.Model.AssumeRoleResponse> AssumeRoleAsync(Amazon.SecurityToken.Model.AssumeRoleRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.SecurityToken.Model.AssumeRoleWithSAMLResponse AssumeRoleWithSAML(Amazon.SecurityToken.Model.AssumeRoleWithSAMLRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.SecurityToken.Model.AssumeRoleWithSAMLResponse> AssumeRoleWithSAMLAsync(Amazon.SecurityToken.Model.AssumeRoleWithSAMLRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentity(Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentityAsync(Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- protected override Amazon.Runtime.Internal.Auth.AbstractAWSSigner CreateSigner()
- internal virtual Amazon.SecurityToken.Model.DecodeAuthorizationMessageResponse DecodeAuthorizationMessage(Amazon.SecurityToken.Model.DecodeAuthorizationMessageRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.SecurityToken.Model.DecodeAuthorizationMessageResponse> DecodeAuthorizationMessageAsync(Amazon.SecurityToken.Model.DecodeAuthorizationMessageRequest request, System.Threading.CancellationToken cancellationToken = null)
- protected override void Dispose(bool disposing)
- internal virtual Amazon.SecurityToken.Model.GetAccessKeyInfoResponse GetAccessKeyInfo(Amazon.SecurityToken.Model.GetAccessKeyInfoRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.SecurityToken.Model.GetAccessKeyInfoResponse> GetAccessKeyInfoAsync(Amazon.SecurityToken.Model.GetAccessKeyInfoRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.SecurityToken.Model.GetCallerIdentityResponse GetCallerIdentity(Amazon.SecurityToken.Model.GetCallerIdentityRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.SecurityToken.Model.GetCallerIdentityResponse> GetCallerIdentityAsync(Amazon.SecurityToken.Model.GetCallerIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.SecurityToken.Model.GetFederationTokenResponse GetFederationToken(Amazon.SecurityToken.Model.GetFederationTokenRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.SecurityToken.Model.GetFederationTokenResponse> GetFederationTokenAsync(Amazon.SecurityToken.Model.GetFederationTokenRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.SecurityToken.Model.GetSessionTokenResponse GetSessionToken()
- internal virtual Amazon.SecurityToken.Model.GetSessionTokenResponse GetSessionToken(Amazon.SecurityToken.Model.GetSessionTokenRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.SecurityToken.Model.GetSessionTokenResponse> GetSessionTokenAsync(System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.SecurityToken.Model.GetSessionTokenResponse> GetSessionTokenAsync(Amazon.SecurityToken.Model.GetSessionTokenRequest request, System.Threading.CancellationToken cancellationToken = null)

### public class Amazon.SecurityToken.AmazonSecurityTokenServiceConfig
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
- public AmazonSecurityTokenServiceConfig()
- private static AmazonSecurityTokenServiceConfig()

### public class Amazon.SecurityToken.AmazonSecurityTokenServiceException
- Base: Amazon.Runtime.AmazonServiceException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public AmazonSecurityTokenServiceException(string message)
- public AmazonSecurityTokenServiceException(System.Exception innerException)
- public AmazonSecurityTokenServiceException(string message, System.Exception innerException)
- public AmazonSecurityTokenServiceException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public AmazonSecurityTokenServiceException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.SecurityToken.AmazonSecurityTokenServiceRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Constructors
- public AmazonSecurityTokenServiceRequest()

### public interface Amazon.SecurityToken.IAmazonSecurityTokenService
- Interfaces: System.IDisposable, Amazon.Runtime.SharedInterfaces.ICoreAmazonSTS, Amazon.Runtime.SharedInterfaces.ICoreAmazonSTS_SAML, Amazon.Runtime.IAmazonService

#### Methods
- public System.Threading.Tasks.Task<Amazon.SecurityToken.Model.AssumeRoleResponse> AssumeRoleAsync(Amazon.SecurityToken.Model.AssumeRoleRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.SecurityToken.Model.AssumeRoleWithSAMLResponse> AssumeRoleWithSAMLAsync(Amazon.SecurityToken.Model.AssumeRoleWithSAMLRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentityAsync(Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.SecurityToken.Model.DecodeAuthorizationMessageResponse> DecodeAuthorizationMessageAsync(Amazon.SecurityToken.Model.DecodeAuthorizationMessageRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.SecurityToken.Model.GetAccessKeyInfoResponse> GetAccessKeyInfoAsync(Amazon.SecurityToken.Model.GetAccessKeyInfoRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.SecurityToken.Model.GetCallerIdentityResponse> GetCallerIdentityAsync(Amazon.SecurityToken.Model.GetCallerIdentityRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.SecurityToken.Model.GetFederationTokenResponse> GetFederationTokenAsync(Amazon.SecurityToken.Model.GetFederationTokenRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.SecurityToken.Model.GetSessionTokenResponse> GetSessionTokenAsync(System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.SecurityToken.Model.GetSessionTokenResponse> GetSessionTokenAsync(Amazon.SecurityToken.Model.GetSessionTokenRequest request, System.Threading.CancellationToken cancellationToken = null)

### public class Amazon.SecurityToken.STSAssumeRoleAWSCredentials
- Base: Amazon.Runtime.RefreshingAWSCredentials
- Interfaces: System.IDisposable

#### Fields
- private Amazon.SecurityToken.Model.AssumeRoleRequest _assumeRequest
- private Amazon.SecurityToken.Model.AssumeRoleWithSAMLRequest _assumeSamlRequest
- private static System.TimeSpan _defaultPreemptExpiryTime
- private bool _isDisposed
- private Amazon.SecurityToken.IAmazonSecurityTokenService _stsClient

#### Constructors
- private static STSAssumeRoleAWSCredentials()
- public STSAssumeRoleAWSCredentials(Amazon.SecurityToken.Model.AssumeRoleWithSAMLRequest assumeRoleWithSamlRequest)
- public STSAssumeRoleAWSCredentials(Amazon.SecurityToken.IAmazonSecurityTokenService sts, Amazon.SecurityToken.Model.AssumeRoleRequest assumeRoleRequest)

#### Methods
- private System.Threading.Tasks.Task<Amazon.SecurityToken.Model.AssumeRoleResponse> <GetServiceCredentials>b__10_0()
- private System.Threading.Tasks.Task<Amazon.SecurityToken.Model.AssumeRoleWithSAMLResponse> <GetServiceCredentials>b__10_1()
- protected virtual void Dispose(bool disposing)
- public void Dispose()
- protected override Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState GenerateNewCredentials()
- private Amazon.SecurityToken.Model.Credentials GetServiceCredentials()

## Namespace: Amazon.SecurityToken.Internal

### public class Amazon.SecurityToken.Internal.AmazonSecurityTokenServiceMetadata
- Interfaces: Amazon.Runtime.Internal.IServiceMetadata

#### Properties
- public System.Collections.Generic.IDictionary<string, string> OperationNameMapping { get; }
- public string ServiceId { get; }

#### Constructors
- public AmazonSecurityTokenServiceMetadata()

## Namespace: Amazon.SecurityToken.Model

### public class Amazon.SecurityToken.Model.AssumedRoleUser

#### Fields
- private string _arn
- private string _assumedRoleId

#### Properties
- public string Arn { get; set; }
- public string AssumedRoleId { get; set; }

#### Constructors
- public AssumedRoleUser()

#### Methods
- internal bool IsSetArn()
- internal bool IsSetAssumedRoleId()

### public class Amazon.SecurityToken.Model.AssumeRoleRequest
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private System.Nullable<int> _durationSeconds
- private string _externalId
- private string _policy
- private System.Collections.Generic.List<Amazon.SecurityToken.Model.PolicyDescriptorType> _policyArns
- private string _roleArn
- private string _roleSessionName
- private string _serialNumber
- private string _tokenCode

#### Properties
- public int DurationSeconds { get; set; }
- public string ExternalId { get; set; }
- public string Policy { get; set; }
- public System.Collections.Generic.List<Amazon.SecurityToken.Model.PolicyDescriptorType> PolicyArns { get; set; }
- public string RoleArn { get; set; }
- public string RoleSessionName { get; set; }
- public string SerialNumber { get; set; }
- public string TokenCode { get; set; }

#### Constructors
- public AssumeRoleRequest()

#### Methods
- internal bool IsSetDurationSeconds()
- internal bool IsSetExternalId()
- internal bool IsSetPolicy()
- internal bool IsSetPolicyArns()
- internal bool IsSetRoleArn()
- internal bool IsSetRoleSessionName()
- internal bool IsSetSerialNumber()
- internal bool IsSetTokenCode()

### public class Amazon.SecurityToken.Model.AssumeRoleResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.SecurityToken.Model.AssumedRoleUser _assumedRoleUser
- private Amazon.SecurityToken.Model.Credentials _credentials
- private System.Nullable<int> _packedPolicySize

#### Properties
- public Amazon.SecurityToken.Model.AssumedRoleUser AssumedRoleUser { get; set; }
- public Amazon.SecurityToken.Model.Credentials Credentials { get; set; }
- public int PackedPolicySize { get; set; }

#### Constructors
- public AssumeRoleResponse()

#### Methods
- internal bool IsSetAssumedRoleUser()
- internal bool IsSetCredentials()
- internal bool IsSetPackedPolicySize()

### public class Amazon.SecurityToken.Model.AssumeRoleWithSAMLRequest
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private System.Nullable<int> _durationSeconds
- private string _policy
- private System.Collections.Generic.List<Amazon.SecurityToken.Model.PolicyDescriptorType> _policyArns
- private string _principalArn
- private string _roleArn
- private string _samlAssertion

#### Properties
- public int DurationSeconds { get; set; }
- public string Policy { get; set; }
- public System.Collections.Generic.List<Amazon.SecurityToken.Model.PolicyDescriptorType> PolicyArns { get; set; }
- public string PrincipalArn { get; set; }
- public string RoleArn { get; set; }
- public string SAMLAssertion { get; set; }

#### Constructors
- public AssumeRoleWithSAMLRequest()

#### Methods
- internal bool IsSetDurationSeconds()
- internal bool IsSetPolicy()
- internal bool IsSetPolicyArns()
- internal bool IsSetPrincipalArn()
- internal bool IsSetRoleArn()
- internal bool IsSetSAMLAssertion()

### public class Amazon.SecurityToken.Model.AssumeRoleWithSAMLResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.SecurityToken.Model.AssumedRoleUser _assumedRoleUser
- private string _audience
- private Amazon.SecurityToken.Model.Credentials _credentials
- private string _issuer
- private string _nameQualifier
- private System.Nullable<int> _packedPolicySize
- private string _subject
- private string _subjectType

#### Properties
- public Amazon.SecurityToken.Model.AssumedRoleUser AssumedRoleUser { get; set; }
- public string Audience { get; set; }
- public Amazon.SecurityToken.Model.Credentials Credentials { get; set; }
- public string Issuer { get; set; }
- public string NameQualifier { get; set; }
- public int PackedPolicySize { get; set; }
- public string Subject { get; set; }
- public string SubjectType { get; set; }

#### Constructors
- public AssumeRoleWithSAMLResponse()

#### Methods
- internal bool IsSetAssumedRoleUser()
- internal bool IsSetAudience()
- internal bool IsSetCredentials()
- internal bool IsSetIssuer()
- internal bool IsSetNameQualifier()
- internal bool IsSetPackedPolicySize()
- internal bool IsSetSubject()
- internal bool IsSetSubjectType()

### public class Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityRequest
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private System.Nullable<int> _durationSeconds
- private string _policy
- private System.Collections.Generic.List<Amazon.SecurityToken.Model.PolicyDescriptorType> _policyArns
- private string _providerId
- private string _roleArn
- private string _roleSessionName
- private string _webIdentityToken

#### Properties
- public int DurationSeconds { get; set; }
- public string Policy { get; set; }
- public System.Collections.Generic.List<Amazon.SecurityToken.Model.PolicyDescriptorType> PolicyArns { get; set; }
- public string ProviderId { get; set; }
- public string RoleArn { get; set; }
- public string RoleSessionName { get; set; }
- public string WebIdentityToken { get; set; }

#### Constructors
- public AssumeRoleWithWebIdentityRequest()

#### Methods
- internal bool IsSetDurationSeconds()
- internal bool IsSetPolicy()
- internal bool IsSetPolicyArns()
- internal bool IsSetProviderId()
- internal bool IsSetRoleArn()
- internal bool IsSetRoleSessionName()
- internal bool IsSetWebIdentityToken()

### public class Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.SecurityToken.Model.AssumedRoleUser _assumedRoleUser
- private string _audience
- private Amazon.SecurityToken.Model.Credentials _credentials
- private System.Nullable<int> _packedPolicySize
- private string _provider
- private string _subjectFromWebIdentityToken

#### Properties
- public Amazon.SecurityToken.Model.AssumedRoleUser AssumedRoleUser { get; set; }
- public string Audience { get; set; }
- public Amazon.SecurityToken.Model.Credentials Credentials { get; set; }
- public int PackedPolicySize { get; set; }
- public string Provider { get; set; }
- public string SubjectFromWebIdentityToken { get; set; }

#### Constructors
- public AssumeRoleWithWebIdentityResponse()

#### Methods
- internal bool IsSetAssumedRoleUser()
- internal bool IsSetAudience()
- internal bool IsSetCredentials()
- internal bool IsSetPackedPolicySize()
- internal bool IsSetProvider()
- internal bool IsSetSubjectFromWebIdentityToken()

### public class Amazon.SecurityToken.Model.Credentials
- Base: Amazon.Runtime.AWSCredentials

#### Fields
- private string _accessKeyId
- private Amazon.Runtime.ImmutableCredentials _credentials
- private System.Nullable<System.DateTime> _expiration
- private string _secretAccessKey
- private string _sessionToken

#### Properties
- public string AccessKeyId { get; set; }
- public System.DateTime Expiration { get; set; }
- public string SecretAccessKey { get; set; }
- public string SessionToken { get; set; }

#### Constructors
- public Credentials()
- public Credentials(string accessKeyId, string secretAccessKey, string sessionToken, System.DateTime expiration)

#### Methods
- public override Amazon.Runtime.ImmutableCredentials GetCredentials()
- internal bool IsSetAccessKeyId()
- internal bool IsSetExpiration()
- internal bool IsSetSecretAccessKey()
- internal bool IsSetSessionToken()

### public class Amazon.SecurityToken.Model.DecodeAuthorizationMessageRequest
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _encodedMessage

#### Properties
- public string EncodedMessage { get; set; }

#### Constructors
- public DecodeAuthorizationMessageRequest()

#### Methods
- internal bool IsSetEncodedMessage()

### public class Amazon.SecurityToken.Model.DecodeAuthorizationMessageResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string _decodedMessage

#### Properties
- public string DecodedMessage { get; set; }

#### Constructors
- public DecodeAuthorizationMessageResponse()

#### Methods
- internal bool IsSetDecodedMessage()

### public class Amazon.SecurityToken.Model.ExpiredTokenException
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ExpiredTokenException(string message)
- public ExpiredTokenException(System.Exception innerException)
- public ExpiredTokenException(string message, System.Exception innerException)
- public ExpiredTokenException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public ExpiredTokenException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.SecurityToken.Model.FederatedUser

#### Fields
- private string _arn
- private string _federatedUserId

#### Properties
- public string Arn { get; set; }
- public string FederatedUserId { get; set; }

#### Constructors
- public FederatedUser()
- public FederatedUser(string federatedUserId, string arn)

#### Methods
- internal bool IsSetArn()
- internal bool IsSetFederatedUserId()

### public class Amazon.SecurityToken.Model.GetAccessKeyInfoRequest
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _accessKeyId

#### Properties
- public string AccessKeyId { get; set; }

#### Constructors
- public GetAccessKeyInfoRequest()

#### Methods
- internal bool IsSetAccessKeyId()

### public class Amazon.SecurityToken.Model.GetAccessKeyInfoResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string _account

#### Properties
- public string Account { get; set; }

#### Constructors
- public GetAccessKeyInfoResponse()

#### Methods
- internal bool IsSetAccount()

### public class Amazon.SecurityToken.Model.GetCallerIdentityRequest
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Constructors
- public GetCallerIdentityRequest()

### public class Amazon.SecurityToken.Model.GetCallerIdentityResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string _account
- private string _arn
- private string _userId

#### Properties
- public string Account { get; set; }
- public string Arn { get; set; }
- public string UserId { get; set; }

#### Constructors
- public GetCallerIdentityResponse()

#### Methods
- internal bool IsSetAccount()
- internal bool IsSetArn()
- internal bool IsSetUserId()

### public class Amazon.SecurityToken.Model.GetFederationTokenRequest
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private System.Nullable<int> _durationSeconds
- private string _name
- private string _policy
- private System.Collections.Generic.List<Amazon.SecurityToken.Model.PolicyDescriptorType> _policyArns

#### Properties
- public int DurationSeconds { get; set; }
- public string Name { get; set; }
- public string Policy { get; set; }
- public System.Collections.Generic.List<Amazon.SecurityToken.Model.PolicyDescriptorType> PolicyArns { get; set; }

#### Constructors
- public GetFederationTokenRequest()
- public GetFederationTokenRequest(string name)

#### Methods
- internal bool IsSetDurationSeconds()
- internal bool IsSetName()
- internal bool IsSetPolicy()
- internal bool IsSetPolicyArns()

### public class Amazon.SecurityToken.Model.GetFederationTokenResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.SecurityToken.Model.Credentials _credentials
- private Amazon.SecurityToken.Model.FederatedUser _federatedUser
- private System.Nullable<int> _packedPolicySize

#### Properties
- public Amazon.SecurityToken.Model.Credentials Credentials { get; set; }
- public Amazon.SecurityToken.Model.FederatedUser FederatedUser { get; set; }
- public int PackedPolicySize { get; set; }

#### Constructors
- public GetFederationTokenResponse()

#### Methods
- internal bool IsSetCredentials()
- internal bool IsSetFederatedUser()
- internal bool IsSetPackedPolicySize()

### public class Amazon.SecurityToken.Model.GetSessionTokenRequest
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private System.Nullable<int> _durationSeconds
- private string _serialNumber
- private string _tokenCode

#### Properties
- public int DurationSeconds { get; set; }
- public string SerialNumber { get; set; }
- public string TokenCode { get; set; }

#### Constructors
- public GetSessionTokenRequest()

#### Methods
- internal bool IsSetDurationSeconds()
- internal bool IsSetSerialNumber()
- internal bool IsSetTokenCode()

### public class Amazon.SecurityToken.Model.GetSessionTokenResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.SecurityToken.Model.Credentials _credentials

#### Properties
- public Amazon.SecurityToken.Model.Credentials Credentials { get; set; }

#### Constructors
- public GetSessionTokenResponse()

#### Methods
- internal bool IsSetCredentials()

### public class Amazon.SecurityToken.Model.IDPCommunicationErrorException
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public IDPCommunicationErrorException(string message)
- public IDPCommunicationErrorException(System.Exception innerException)
- public IDPCommunicationErrorException(string message, System.Exception innerException)
- public IDPCommunicationErrorException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public IDPCommunicationErrorException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.SecurityToken.Model.IDPRejectedClaimException
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public IDPRejectedClaimException(string message)
- public IDPRejectedClaimException(System.Exception innerException)
- public IDPRejectedClaimException(string message, System.Exception innerException)
- public IDPRejectedClaimException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public IDPRejectedClaimException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.SecurityToken.Model.InvalidAuthorizationMessageException
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public InvalidAuthorizationMessageException(string message)
- public InvalidAuthorizationMessageException(System.Exception innerException)
- public InvalidAuthorizationMessageException(string message, System.Exception innerException)
- public InvalidAuthorizationMessageException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public InvalidAuthorizationMessageException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.SecurityToken.Model.InvalidIdentityTokenException
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public InvalidIdentityTokenException(string message)
- public InvalidIdentityTokenException(System.Exception innerException)
- public InvalidIdentityTokenException(string message, System.Exception innerException)
- public InvalidIdentityTokenException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public InvalidIdentityTokenException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.SecurityToken.Model.MalformedPolicyDocumentException
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public MalformedPolicyDocumentException(string message)
- public MalformedPolicyDocumentException(System.Exception innerException)
- public MalformedPolicyDocumentException(string message, System.Exception innerException)
- public MalformedPolicyDocumentException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public MalformedPolicyDocumentException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.SecurityToken.Model.PackedPolicyTooLargeException
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public PackedPolicyTooLargeException(string message)
- public PackedPolicyTooLargeException(System.Exception innerException)
- public PackedPolicyTooLargeException(string message, System.Exception innerException)
- public PackedPolicyTooLargeException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public PackedPolicyTooLargeException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

### public class Amazon.SecurityToken.Model.PolicyDescriptorType

#### Fields
- private string _arn

#### Properties
- public string Arn { get; set; }

#### Constructors
- public PolicyDescriptorType()

#### Methods
- internal bool IsSetArn()

### public class Amazon.SecurityToken.Model.RegionDisabledException
- Base: Amazon.SecurityToken.AmazonSecurityTokenServiceException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public RegionDisabledException(string message)
- public RegionDisabledException(System.Exception innerException)
- public RegionDisabledException(string message, System.Exception innerException)
- public RegionDisabledException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public RegionDisabledException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

## Namespace: Amazon.SecurityToken.Model.Internal.MarshallTransformations

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumedRoleUserUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.SecurityToken.Model.AssumedRoleUser, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.SecurityToken.Model.AssumedRoleUser, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumedRoleUserUnmarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumedRoleUserUnmarshaller Instance { get; }

#### Constructors
- public AssumedRoleUserUnmarshaller()
- private static AssumedRoleUserUnmarshaller()

#### Methods
- public Amazon.SecurityToken.Model.AssumedRoleUser Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.SecurityToken.Model.AssumedRoleUser Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.SecurityToken.Model.AssumeRoleRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleRequestMarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleRequestMarshaller Instance { get; }

#### Constructors
- public AssumeRoleRequestMarshaller()
- private static AssumeRoleRequestMarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.SecurityToken.Model.AssumeRoleRequest publicRequest)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.XmlResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleResponseUnmarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleResponseUnmarshaller Instance { get; }

#### Constructors
- public AssumeRoleResponseUnmarshaller()
- private static AssumeRoleResponseUnmarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.SecurityToken.Model.AssumeRoleResponse response)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithSAMLRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.SecurityToken.Model.AssumeRoleWithSAMLRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithSAMLRequestMarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithSAMLRequestMarshaller Instance { get; }

#### Constructors
- public AssumeRoleWithSAMLRequestMarshaller()
- private static AssumeRoleWithSAMLRequestMarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithSAMLRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.SecurityToken.Model.AssumeRoleWithSAMLRequest publicRequest)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithSAMLResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.XmlResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithSAMLResponseUnmarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithSAMLResponseUnmarshaller Instance { get; }

#### Constructors
- public AssumeRoleWithSAMLResponseUnmarshaller()
- private static AssumeRoleWithSAMLResponseUnmarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithSAMLResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.SecurityToken.Model.AssumeRoleWithSAMLResponse response)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithWebIdentityRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithWebIdentityRequestMarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithWebIdentityRequestMarshaller Instance { get; }

#### Constructors
- public AssumeRoleWithWebIdentityRequestMarshaller()
- private static AssumeRoleWithWebIdentityRequestMarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithWebIdentityRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityRequest publicRequest)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithWebIdentityResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.XmlResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithWebIdentityResponseUnmarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithWebIdentityResponseUnmarshaller Instance { get; }

#### Constructors
- public AssumeRoleWithWebIdentityResponseUnmarshaller()
- private static AssumeRoleWithWebIdentityResponseUnmarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.AssumeRoleWithWebIdentityResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityResponse response)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.CredentialsUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.SecurityToken.Model.Credentials, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.SecurityToken.Model.Credentials, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.CredentialsUnmarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.CredentialsUnmarshaller Instance { get; }

#### Constructors
- public CredentialsUnmarshaller()
- private static CredentialsUnmarshaller()

#### Methods
- public Amazon.SecurityToken.Model.Credentials Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.SecurityToken.Model.Credentials Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.DecodeAuthorizationMessageRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.SecurityToken.Model.DecodeAuthorizationMessageRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.DecodeAuthorizationMessageRequestMarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.DecodeAuthorizationMessageRequestMarshaller Instance { get; }

#### Constructors
- public DecodeAuthorizationMessageRequestMarshaller()
- private static DecodeAuthorizationMessageRequestMarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.DecodeAuthorizationMessageRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.SecurityToken.Model.DecodeAuthorizationMessageRequest publicRequest)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.DecodeAuthorizationMessageResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.XmlResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.DecodeAuthorizationMessageResponseUnmarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.DecodeAuthorizationMessageResponseUnmarshaller Instance { get; }

#### Constructors
- public DecodeAuthorizationMessageResponseUnmarshaller()
- private static DecodeAuthorizationMessageResponseUnmarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.DecodeAuthorizationMessageResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.SecurityToken.Model.DecodeAuthorizationMessageResponse response)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.FederatedUserUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.SecurityToken.Model.FederatedUser, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.SecurityToken.Model.FederatedUser, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.FederatedUserUnmarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.FederatedUserUnmarshaller Instance { get; }

#### Constructors
- public FederatedUserUnmarshaller()
- private static FederatedUserUnmarshaller()

#### Methods
- public Amazon.SecurityToken.Model.FederatedUser Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.SecurityToken.Model.FederatedUser Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetAccessKeyInfoRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.SecurityToken.Model.GetAccessKeyInfoRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetAccessKeyInfoRequestMarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetAccessKeyInfoRequestMarshaller Instance { get; }

#### Constructors
- public GetAccessKeyInfoRequestMarshaller()
- private static GetAccessKeyInfoRequestMarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetAccessKeyInfoRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.SecurityToken.Model.GetAccessKeyInfoRequest publicRequest)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetAccessKeyInfoResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.XmlResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetAccessKeyInfoResponseUnmarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetAccessKeyInfoResponseUnmarshaller Instance { get; }

#### Constructors
- public GetAccessKeyInfoResponseUnmarshaller()
- private static GetAccessKeyInfoResponseUnmarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetAccessKeyInfoResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.SecurityToken.Model.GetAccessKeyInfoResponse response)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetCallerIdentityRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.SecurityToken.Model.GetCallerIdentityRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetCallerIdentityRequestMarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetCallerIdentityRequestMarshaller Instance { get; }

#### Constructors
- public GetCallerIdentityRequestMarshaller()
- private static GetCallerIdentityRequestMarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetCallerIdentityRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.SecurityToken.Model.GetCallerIdentityRequest publicRequest)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetCallerIdentityResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.XmlResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetCallerIdentityResponseUnmarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetCallerIdentityResponseUnmarshaller Instance { get; }

#### Constructors
- public GetCallerIdentityResponseUnmarshaller()
- private static GetCallerIdentityResponseUnmarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetCallerIdentityResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.SecurityToken.Model.GetCallerIdentityResponse response)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetFederationTokenRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.SecurityToken.Model.GetFederationTokenRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetFederationTokenRequestMarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetFederationTokenRequestMarshaller Instance { get; }

#### Constructors
- public GetFederationTokenRequestMarshaller()
- private static GetFederationTokenRequestMarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetFederationTokenRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.SecurityToken.Model.GetFederationTokenRequest publicRequest)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetFederationTokenResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.XmlResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetFederationTokenResponseUnmarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetFederationTokenResponseUnmarshaller Instance { get; }

#### Constructors
- public GetFederationTokenResponseUnmarshaller()
- private static GetFederationTokenResponseUnmarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetFederationTokenResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.SecurityToken.Model.GetFederationTokenResponse response)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetSessionTokenRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.SecurityToken.Model.GetSessionTokenRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetSessionTokenRequestMarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetSessionTokenRequestMarshaller Instance { get; }

#### Constructors
- public GetSessionTokenRequestMarshaller()
- private static GetSessionTokenRequestMarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetSessionTokenRequestMarshaller GetInstance()
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.SecurityToken.Model.GetSessionTokenRequest publicRequest)

### public class Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetSessionTokenResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.XmlResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetSessionTokenResponseUnmarshaller _instance

#### Properties
- public static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetSessionTokenResponseUnmarshaller Instance { get; }

#### Constructors
- public GetSessionTokenResponseUnmarshaller()
- private static GetSessionTokenResponseUnmarshaller()

#### Methods
- internal static Amazon.SecurityToken.Model.Internal.MarshallTransformations.GetSessionTokenResponseUnmarshaller GetInstance()
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.SecurityToken.Model.GetSessionTokenResponse response)

## Namespace: Amazon.SecurityToken.SAML

### internal class Amazon.SecurityToken.SAML.AdfsAuthenticationController
- Interfaces: Amazon.SecurityToken.SAML.IAuthenticationController

#### Constructors
- public AdfsAuthenticationController()

#### Methods
- public string Authenticate(System.Uri identityProvider, System.Net.ICredentials credentials, string authenticationType, System.Net.IWebProxy proxySettings)
- private static string QueryProvider(System.Uri identityProvider, System.Net.IWebProxy proxySettings, System.Net.ICredentials credentials, string authenticationType)

### public class Amazon.SecurityToken.SAML.AdfsAuthenticationControllerException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public AdfsAuthenticationControllerException(string message)
- public AdfsAuthenticationControllerException(System.Exception innerException)
- public AdfsAuthenticationControllerException(string message, System.Exception innerException)

### internal class Amazon.SecurityToken.SAML.AdfsAuthenticationResponseParser
- Interfaces: Amazon.SecurityToken.SAML.IAuthenticationResponseParser

#### Constructors
- public AdfsAuthenticationResponseParser()

#### Methods
- public Amazon.SecurityToken.SAML.SAMLAssertion Parse(string authenticationResponse)

### public interface Amazon.SecurityToken.SAML.IAuthenticationController

#### Methods
- public string Authenticate(System.Uri identityProvider, System.Net.ICredentials credentials, string authenticationType, System.Net.IWebProxy proxySettings)

### public interface Amazon.SecurityToken.SAML.IAuthenticationResponseParser

#### Methods
- public Amazon.SecurityToken.SAML.SAMLAssertion Parse(string authenticationResponse)

### public class Amazon.SecurityToken.SAML.SAMLAssertion

#### Fields
- private string <AssertionDocument>k__BackingField
- private System.Collections.Generic.IDictionary<string, string> <RoleSet>k__BackingField
- private static const string AssertionNamespace
- private static const string RoleXPath

#### Properties
- public string AssertionDocument { get; private set; }
- public System.Collections.Generic.IDictionary<string, string> RoleSet { get; private set; }

#### Constructors
- internal SAMLAssertion(string assertion)

#### Methods
- private System.Collections.Generic.IDictionary<string, string> ExtractRoleData()
- private static string ExtractRoleName(string chunk)
- public Amazon.Runtime.SAMLImmutableCredentials GetRoleCredentials(Amazon.SecurityToken.IAmazonSecurityTokenService stsClient, string principalAndRoleArns, System.TimeSpan duration)
- private static bool IsSamlProvider(string chunk)

### public class Amazon.SecurityToken.SAML.SAMLAuthenticationController

#### Fields
- private Amazon.SecurityToken.SAML.IAuthenticationController <AuthenticationController>k__BackingField
- private System.Net.IWebProxy <ProxySettings>k__BackingField
- private Amazon.SecurityToken.SAML.IAuthenticationResponseParser <ResponseParser>k__BackingField

#### Properties
- public Amazon.SecurityToken.SAML.IAuthenticationController AuthenticationController { get; private set; }
- public System.Net.IWebProxy ProxySettings { get; private set; }
- public Amazon.SecurityToken.SAML.IAuthenticationResponseParser ResponseParser { get; private set; }

#### Constructors
- public SAMLAuthenticationController()
- public SAMLAuthenticationController(System.Net.IWebProxy proxySettings)
- public SAMLAuthenticationController(Amazon.SecurityToken.SAML.IAuthenticationController authenticationController, Amazon.SecurityToken.SAML.IAuthenticationResponseParser responseParser, System.Net.IWebProxy proxySettings)

#### Methods
- public Amazon.SecurityToken.SAML.SAMLAssertion GetSAMLAssertion(string identityProviderUrl, System.Net.ICredentials credentials, string authenticationType)
- public Amazon.SecurityToken.SAML.SAMLAssertion GetSAMLAssertion(System.Uri identityProviderUrl, System.Net.ICredentials credentials, string authenticationType)

