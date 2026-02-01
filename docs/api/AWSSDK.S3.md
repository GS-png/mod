# Assembly: AWSSDK.S3
- Path: tools/WorldBox.Managed/AWSSDK.S3.dll
- Types: 683

## Namespace: Amazon

### public static class Amazon.AWSConfigsS3

#### Fields
- private static bool <UseSigV4SetExplicitly>k__BackingField
- private static const string s3Key
- public static const string S3UseSignatureVersion4Key
- private static bool _useSignatureVersion4

#### Properties
- public static bool UseSignatureVersion4 { get; set; }
- internal static bool UseSigV4SetExplicitly { get; private set; }

#### Constructors
- private static AWSConfigsS3()

## Namespace: Amazon.S3

### private class Amazon.S3.AmazonS3Client.<>c

#### Fields
- public static readonly Amazon.S3.AmazonS3Client.<>c <>9
- public static System.Func<Amazon.S3.Model.S3Object, string> <>9__9_0

#### Constructors
- private static AmazonS3Client.<>c()
- public AmazonS3Client.<>c()

#### Methods
- internal string <Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.GetAllObjectKeysAsync>b__9_0(Amazon.S3.Model.S3Object o)

### private struct Amazon.S3.AmazonS3Client.<Amazon-Runtime-SharedInterfaces-ICoreAmazonS3-GetAllObjectKeysAsync>d__9
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.AmazonS3Client <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IList<string>> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.ListObjectsResponse> <>u__1
- private System.Collections.Generic.List<string> <keys>5__2
- public System.Collections.Generic.IDictionary<string, object> additionalProperties
- public string bucketName
- public string prefix

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.AmazonS3Client.<Amazon-Runtime-SharedInterfaces-ICoreAmazonS3-GetObjectStreamAsync>d__13
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.AmazonS3Client <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.GetObjectResponse> <>u__1
- public System.Collections.Generic.IDictionary<string, object> additionalProperties
- public string bucketName
- public System.Threading.CancellationToken cancellationToken
- public string objectKey

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.AmazonS3HttpUtil.<GetHeadAsync>d__0
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Amazon.S3.GetHeadResponse> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<System.Net.WebResponse> <>u__1
- public Amazon.Runtime.IClientConfig config
- public string header
- public string url

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class Amazon.S3.AmazonS3Client
- Base: Amazon.Runtime.AmazonServiceClient
- Interfaces: System.IDisposable, Amazon.S3.IAmazonS3, Amazon.Runtime.SharedInterfaces.ICoreAmazonS3, Amazon.Runtime.IAmazonService

#### Fields
- private static Amazon.Runtime.Internal.IServiceMetadata serviceMetadata

#### Properties
- protected Amazon.Runtime.Internal.IServiceMetadata ServiceMetadata { get; }

#### Constructors
- public AmazonS3Client()
- private static AmazonS3Client()
- public AmazonS3Client(Amazon.RegionEndpoint region)
- public AmazonS3Client(Amazon.S3.AmazonS3Config config)
- public AmazonS3Client(Amazon.Runtime.AWSCredentials credentials)
- public AmazonS3Client(Amazon.Runtime.AWSCredentials credentials, Amazon.RegionEndpoint region)
- public AmazonS3Client(Amazon.Runtime.AWSCredentials credentials, Amazon.S3.AmazonS3Config clientConfig)
- public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey)
- public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, Amazon.RegionEndpoint region)
- public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, Amazon.S3.AmazonS3Config clientConfig)
- public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
- public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, Amazon.RegionEndpoint region)
- public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, Amazon.S3.AmazonS3Config clientConfig)

#### Methods
- internal virtual Amazon.S3.Model.AbortMultipartUploadResponse AbortMultipartUpload(Amazon.S3.Model.AbortMultipartUploadRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.AbortMultipartUploadResponse> AbortMultipartUploadAsync(string bucketName, string key, string uploadId, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.AbortMultipartUploadResponse> AbortMultipartUploadAsync(Amazon.S3.Model.AbortMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = null)
- private System.Threading.Tasks.Task Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.DeleteAsync(string bucketName, string objectKey, System.Collections.Generic.IDictionary<string, object> additionalProperties, System.Threading.CancellationToken cancellationToken)
- private System.Threading.Tasks.Task Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.DeletesAsync(string bucketName, System.Collections.Generic.IEnumerable<string> objectKeys, System.Collections.Generic.IDictionary<string, object> additionalProperties, System.Threading.CancellationToken cancellationToken)
- private System.Threading.Tasks.Task<bool> Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.DoesS3BucketExistAsync(string bucketName)
- private System.Threading.Tasks.Task Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.DownloadToFilePathAsync(string bucketName, string objectKey, string filepath, System.Collections.Generic.IDictionary<string, object> additionalProperties, System.Threading.CancellationToken cancellationToken)
- private System.Threading.Tasks.Task Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.EnsureBucketExistsAsync(string bucketName)
- private string Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.GeneratePreSignedURL(string bucketName, string objectKey, System.DateTime expiration, System.Collections.Generic.IDictionary<string, object> additionalProperties)
- private System.Threading.Tasks.Task<System.Collections.Generic.IList<string>> Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.GetAllObjectKeysAsync(string bucketName, string prefix, System.Collections.Generic.IDictionary<string, object> additionalProperties)
- private System.Threading.Tasks.Task<System.IO.Stream> Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.GetObjectStreamAsync(string bucketName, string objectKey, System.Collections.Generic.IDictionary<string, object> additionalProperties, System.Threading.CancellationToken cancellationToken)
- private System.Threading.Tasks.Task Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.MakeObjectPublicAsync(string bucket, string objectKey, bool enable)
- private System.Threading.Tasks.Task Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.UploadObjectFromFilePathAsync(string bucketName, string objectKey, string filepath, System.Collections.Generic.IDictionary<string, object> additionalProperties, System.Threading.CancellationToken cancellationToken)
- private System.Threading.Tasks.Task Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.UploadObjectFromStreamAsync(string bucketName, string objectKey, System.IO.Stream stream, System.Collections.Generic.IDictionary<string, object> additionalProperties, System.Threading.CancellationToken cancellationToken)
- internal static void CleanupRequest(Amazon.Runtime.AmazonWebServiceRequest request)
- internal virtual Amazon.S3.Model.CompleteMultipartUploadResponse CompleteMultipartUpload(Amazon.S3.Model.CompleteMultipartUploadRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(Amazon.S3.Model.CompleteMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal void ConfigureProxy(System.Net.HttpWebRequest httpRequest)
- internal virtual Amazon.S3.Model.CopyObjectResponse CopyObject(Amazon.S3.Model.CopyObjectRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.CopyObjectResponse> CopyObjectAsync(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.CopyObjectResponse> CopyObjectAsync(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.CopyObjectResponse> CopyObjectAsync(Amazon.S3.Model.CopyObjectRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.CopyPartResponse CopyPart(Amazon.S3.Model.CopyPartRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.CopyPartResponse> CopyPartAsync(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, string uploadId, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.CopyPartResponse> CopyPartAsync(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, string uploadId, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.CopyPartResponse> CopyPartAsync(Amazon.S3.Model.CopyPartRequest request, System.Threading.CancellationToken cancellationToken = null)
- protected override Amazon.Runtime.Internal.Auth.AbstractAWSSigner CreateSigner()
- protected override void CustomizeRuntimePipeline(Amazon.Runtime.Internal.RuntimePipeline pipeline)
- internal virtual Amazon.S3.Model.DeleteBucketResponse DeleteBucket(Amazon.S3.Model.DeleteBucketRequest request)
- internal virtual Amazon.S3.Model.DeleteBucketAnalyticsConfigurationResponse DeleteBucketAnalyticsConfiguration(Amazon.S3.Model.DeleteBucketAnalyticsConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketAnalyticsConfigurationResponse> DeleteBucketAnalyticsConfigurationAsync(Amazon.S3.Model.DeleteBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketResponse> DeleteBucketAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketResponse> DeleteBucketAsync(Amazon.S3.Model.DeleteBucketRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.DeleteBucketEncryptionResponse DeleteBucketEncryption(Amazon.S3.Model.DeleteBucketEncryptionRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketEncryptionResponse> DeleteBucketEncryptionAsync(Amazon.S3.Model.DeleteBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.DeleteBucketInventoryConfigurationResponse DeleteBucketInventoryConfiguration(Amazon.S3.Model.DeleteBucketInventoryConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketInventoryConfigurationResponse> DeleteBucketInventoryConfigurationAsync(Amazon.S3.Model.DeleteBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.DeleteBucketMetricsConfigurationResponse DeleteBucketMetricsConfiguration(Amazon.S3.Model.DeleteBucketMetricsConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketMetricsConfigurationResponse> DeleteBucketMetricsConfigurationAsync(Amazon.S3.Model.DeleteBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.DeleteBucketPolicyResponse DeleteBucketPolicy(Amazon.S3.Model.DeleteBucketPolicyRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(Amazon.S3.Model.DeleteBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.DeleteBucketReplicationResponse DeleteBucketReplication(Amazon.S3.Model.DeleteBucketReplicationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketReplicationResponse> DeleteBucketReplicationAsync(Amazon.S3.Model.DeleteBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.DeleteBucketTaggingResponse DeleteBucketTagging(Amazon.S3.Model.DeleteBucketTaggingRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(Amazon.S3.Model.DeleteBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.DeleteBucketWebsiteResponse DeleteBucketWebsite(Amazon.S3.Model.DeleteBucketWebsiteRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(Amazon.S3.Model.DeleteBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.DeleteCORSConfigurationResponse DeleteCORSConfiguration(Amazon.S3.Model.DeleteCORSConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(Amazon.S3.Model.DeleteCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(Amazon.S3.Model.DeleteLifecycleConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(Amazon.S3.Model.DeleteLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.DeleteObjectResponse DeleteObject(Amazon.S3.Model.DeleteObjectRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteObjectResponse> DeleteObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteObjectResponse> DeleteObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteObjectResponse> DeleteObjectAsync(Amazon.S3.Model.DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.DeleteObjectsResponse DeleteObjects(Amazon.S3.Model.DeleteObjectsRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteObjectsResponse> DeleteObjectsAsync(Amazon.S3.Model.DeleteObjectsRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.DeleteObjectTaggingResponse DeleteObjectTagging(Amazon.S3.Model.DeleteObjectTaggingRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeleteObjectTaggingResponse> DeleteObjectTaggingAsync(Amazon.S3.Model.DeleteObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.DeletePublicAccessBlockResponse DeletePublicAccessBlock(Amazon.S3.Model.DeletePublicAccessBlockRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.DeletePublicAccessBlockResponse> DeletePublicAccessBlockAsync(Amazon.S3.Model.DeletePublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = null)
- private Amazon.S3.Protocol DetermineProtocol()
- protected override void Dispose(bool disposing)
- internal virtual Amazon.S3.Model.GetACLResponse GetACL(Amazon.S3.Model.GetACLRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetACLResponse> GetACLAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetACLResponse> GetACLAsync(Amazon.S3.Model.GetACLRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketAccelerateConfigurationResponse GetBucketAccelerateConfiguration(Amazon.S3.Model.GetBucketAccelerateConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketAccelerateConfigurationResponse> GetBucketAccelerateConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketAccelerateConfigurationResponse> GetBucketAccelerateConfigurationAsync(Amazon.S3.Model.GetBucketAccelerateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketAnalyticsConfigurationResponse GetBucketAnalyticsConfiguration(Amazon.S3.Model.GetBucketAnalyticsConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketAnalyticsConfigurationResponse> GetBucketAnalyticsConfigurationAsync(Amazon.S3.Model.GetBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketEncryptionResponse GetBucketEncryption(Amazon.S3.Model.GetBucketEncryptionRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketEncryptionResponse> GetBucketEncryptionAsync(Amazon.S3.Model.GetBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketInventoryConfigurationResponse GetBucketInventoryConfiguration(Amazon.S3.Model.GetBucketInventoryConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketInventoryConfigurationResponse> GetBucketInventoryConfigurationAsync(Amazon.S3.Model.GetBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketLocationResponse GetBucketLocation(Amazon.S3.Model.GetBucketLocationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketLocationResponse> GetBucketLocationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketLocationResponse> GetBucketLocationAsync(Amazon.S3.Model.GetBucketLocationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketLoggingResponse GetBucketLogging(Amazon.S3.Model.GetBucketLoggingRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketLoggingResponse> GetBucketLoggingAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketLoggingResponse> GetBucketLoggingAsync(Amazon.S3.Model.GetBucketLoggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketMetricsConfigurationResponse GetBucketMetricsConfiguration(Amazon.S3.Model.GetBucketMetricsConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketMetricsConfigurationResponse> GetBucketMetricsConfigurationAsync(Amazon.S3.Model.GetBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketNotificationResponse GetBucketNotification(Amazon.S3.Model.GetBucketNotificationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketNotificationResponse> GetBucketNotificationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketNotificationResponse> GetBucketNotificationAsync(Amazon.S3.Model.GetBucketNotificationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketPolicyResponse GetBucketPolicy(Amazon.S3.Model.GetBucketPolicyRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketPolicyResponse> GetBucketPolicyAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketPolicyResponse> GetBucketPolicyAsync(Amazon.S3.Model.GetBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketPolicyStatusResponse GetBucketPolicyStatus(Amazon.S3.Model.GetBucketPolicyStatusRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketPolicyStatusResponse> GetBucketPolicyStatusAsync(Amazon.S3.Model.GetBucketPolicyStatusRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketReplicationResponse GetBucketReplication(Amazon.S3.Model.GetBucketReplicationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketReplicationResponse> GetBucketReplicationAsync(Amazon.S3.Model.GetBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketRequestPaymentResponse GetBucketRequestPayment(Amazon.S3.Model.GetBucketRequestPaymentRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(Amazon.S3.Model.GetBucketRequestPaymentRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketTaggingResponse GetBucketTagging(Amazon.S3.Model.GetBucketTaggingRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketTaggingResponse> GetBucketTaggingAsync(Amazon.S3.Model.GetBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketVersioningResponse GetBucketVersioning(Amazon.S3.Model.GetBucketVersioningRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketVersioningResponse> GetBucketVersioningAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketVersioningResponse> GetBucketVersioningAsync(Amazon.S3.Model.GetBucketVersioningRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetBucketWebsiteResponse GetBucketWebsite(Amazon.S3.Model.GetBucketWebsiteRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketWebsiteResponse> GetBucketWebsiteAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketWebsiteResponse> GetBucketWebsiteAsync(Amazon.S3.Model.GetBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetCORSConfigurationResponse GetCORSConfiguration(Amazon.S3.Model.GetCORSConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetCORSConfigurationResponse> GetCORSConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetCORSConfigurationResponse> GetCORSConfigurationAsync(Amazon.S3.Model.GetCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetLifecycleConfigurationResponse GetLifecycleConfiguration(Amazon.S3.Model.GetLifecycleConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(Amazon.S3.Model.GetLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetObjectResponse GetObject(Amazon.S3.Model.GetObjectRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectResponse> GetObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectResponse> GetObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectResponse> GetObjectAsync(Amazon.S3.Model.GetObjectRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetObjectLegalHoldResponse GetObjectLegalHold(Amazon.S3.Model.GetObjectLegalHoldRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectLegalHoldResponse> GetObjectLegalHoldAsync(Amazon.S3.Model.GetObjectLegalHoldRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetObjectLockConfigurationResponse GetObjectLockConfiguration(Amazon.S3.Model.GetObjectLockConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectLockConfigurationResponse> GetObjectLockConfigurationAsync(Amazon.S3.Model.GetObjectLockConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetObjectMetadataResponse GetObjectMetadata(Amazon.S3.Model.GetObjectMetadataRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectMetadataResponse> GetObjectMetadataAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectMetadataResponse> GetObjectMetadataAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectMetadataResponse> GetObjectMetadataAsync(Amazon.S3.Model.GetObjectMetadataRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetObjectRetentionResponse GetObjectRetention(Amazon.S3.Model.GetObjectRetentionRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectRetentionResponse> GetObjectRetentionAsync(Amazon.S3.Model.GetObjectRetentionRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetObjectTaggingResponse GetObjectTagging(Amazon.S3.Model.GetObjectTaggingRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectTaggingResponse> GetObjectTaggingAsync(Amazon.S3.Model.GetObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.GetObjectTorrentResponse GetObjectTorrent(Amazon.S3.Model.GetObjectTorrentRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectTorrentResponse> GetObjectTorrentAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectTorrentResponse> GetObjectTorrentAsync(Amazon.S3.Model.GetObjectTorrentRequest request, System.Threading.CancellationToken cancellationToken = null)
- public string GetPreSignedURL(Amazon.S3.Model.GetPreSignedUrlRequest request)
- internal string GetPreSignedURLInternal(Amazon.S3.Model.GetPreSignedUrlRequest request, bool useSigV2Fallback = true)
- internal virtual Amazon.S3.Model.GetPublicAccessBlockResponse GetPublicAccessBlock(Amazon.S3.Model.GetPublicAccessBlockRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.GetPublicAccessBlockResponse> GetPublicAccessBlockAsync(Amazon.S3.Model.GetPublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = null)
- private static long GetSecondsUntilExpiration(Amazon.Runtime.IClientConfig config, Amazon.S3.Model.GetPreSignedUrlRequest request, bool aws4Signing)
- internal virtual Amazon.S3.Model.HeadBucketResponse HeadBucket(Amazon.S3.Model.HeadBucketRequest request)
- internal virtual System.Threading.Tasks.Task<Amazon.S3.Model.HeadBucketResponse> HeadBucketAsync(Amazon.S3.Model.HeadBucketRequest request, System.Threading.CancellationToken cancellationToken = null)
- protected override void Initialize()
- internal virtual Amazon.S3.Model.InitiateMultipartUploadResponse InitiateMultipartUpload(Amazon.S3.Model.InitiateMultipartUploadRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(Amazon.S3.Model.InitiateMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.ListBucketAnalyticsConfigurationsResponse ListBucketAnalyticsConfigurations(Amazon.S3.Model.ListBucketAnalyticsConfigurationsRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListBucketAnalyticsConfigurationsResponse> ListBucketAnalyticsConfigurationsAsync(Amazon.S3.Model.ListBucketAnalyticsConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.ListBucketInventoryConfigurationsResponse ListBucketInventoryConfigurations(Amazon.S3.Model.ListBucketInventoryConfigurationsRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListBucketInventoryConfigurationsResponse> ListBucketInventoryConfigurationsAsync(Amazon.S3.Model.ListBucketInventoryConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.ListBucketMetricsConfigurationsResponse ListBucketMetricsConfigurations(Amazon.S3.Model.ListBucketMetricsConfigurationsRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListBucketMetricsConfigurationsResponse> ListBucketMetricsConfigurationsAsync(Amazon.S3.Model.ListBucketMetricsConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.ListBucketsResponse ListBuckets()
- internal virtual Amazon.S3.Model.ListBucketsResponse ListBuckets(Amazon.S3.Model.ListBucketsRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListBucketsResponse> ListBucketsAsync(System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListBucketsResponse> ListBucketsAsync(Amazon.S3.Model.ListBucketsRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.ListMultipartUploadsResponse ListMultipartUploads(Amazon.S3.Model.ListMultipartUploadsRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListMultipartUploadsResponse> ListMultipartUploadsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListMultipartUploadsResponse> ListMultipartUploadsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListMultipartUploadsResponse> ListMultipartUploadsAsync(Amazon.S3.Model.ListMultipartUploadsRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.ListObjectsResponse ListObjects(Amazon.S3.Model.ListObjectsRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListObjectsResponse> ListObjectsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListObjectsResponse> ListObjectsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListObjectsResponse> ListObjectsAsync(Amazon.S3.Model.ListObjectsRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.ListObjectsV2Response ListObjectsV2(Amazon.S3.Model.ListObjectsV2Request request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListObjectsV2Response> ListObjectsV2Async(Amazon.S3.Model.ListObjectsV2Request request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.ListPartsResponse ListParts(Amazon.S3.Model.ListPartsRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListPartsResponse> ListPartsAsync(string bucketName, string key, string uploadId, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListPartsResponse> ListPartsAsync(Amazon.S3.Model.ListPartsRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.ListVersionsResponse ListVersions(Amazon.S3.Model.ListVersionsRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListVersionsResponse> ListVersionsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListVersionsResponse> ListVersionsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.ListVersionsResponse> ListVersionsAsync(Amazon.S3.Model.ListVersionsRequest request, System.Threading.CancellationToken cancellationToken = null)
- private static Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.IClientConfig config, Amazon.S3.Model.GetPreSignedUrlRequest getPreSignedUrlRequest, string accessKey, string token, bool aws4Signing)
- internal virtual Amazon.S3.Model.PutACLResponse PutACL(Amazon.S3.Model.PutACLRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutACLResponse> PutACLAsync(Amazon.S3.Model.PutACLRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutBucketResponse PutBucket(Amazon.S3.Model.PutBucketRequest request)
- internal virtual Amazon.S3.Model.PutBucketAccelerateConfigurationResponse PutBucketAccelerateConfiguration(Amazon.S3.Model.PutBucketAccelerateConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketAccelerateConfigurationResponse> PutBucketAccelerateConfigurationAsync(Amazon.S3.Model.PutBucketAccelerateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutBucketAnalyticsConfigurationResponse PutBucketAnalyticsConfiguration(Amazon.S3.Model.PutBucketAnalyticsConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketAnalyticsConfigurationResponse> PutBucketAnalyticsConfigurationAsync(Amazon.S3.Model.PutBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketResponse> PutBucketAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketResponse> PutBucketAsync(Amazon.S3.Model.PutBucketRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.PutBucketEncryptionResponse PutBucketEncryption(Amazon.S3.Model.PutBucketEncryptionRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.PutBucketEncryptionResponse> PutBucketEncryptionAsync(Amazon.S3.Model.PutBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutBucketInventoryConfigurationResponse PutBucketInventoryConfiguration(Amazon.S3.Model.PutBucketInventoryConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketInventoryConfigurationResponse> PutBucketInventoryConfigurationAsync(Amazon.S3.Model.PutBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutBucketLoggingResponse PutBucketLogging(Amazon.S3.Model.PutBucketLoggingRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketLoggingResponse> PutBucketLoggingAsync(Amazon.S3.Model.PutBucketLoggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutBucketMetricsConfigurationResponse PutBucketMetricsConfiguration(Amazon.S3.Model.PutBucketMetricsConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketMetricsConfigurationResponse> PutBucketMetricsConfigurationAsync(Amazon.S3.Model.PutBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutBucketNotificationResponse PutBucketNotification(Amazon.S3.Model.PutBucketNotificationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketNotificationResponse> PutBucketNotificationAsync(Amazon.S3.Model.PutBucketNotificationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutBucketPolicyResponse PutBucketPolicy(Amazon.S3.Model.PutBucketPolicyRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketPolicyResponse> PutBucketPolicyAsync(string bucketName, string policy, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketPolicyResponse> PutBucketPolicyAsync(string bucketName, string policy, string contentMD5, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketPolicyResponse> PutBucketPolicyAsync(Amazon.S3.Model.PutBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutBucketReplicationResponse PutBucketReplication(Amazon.S3.Model.PutBucketReplicationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketReplicationResponse> PutBucketReplicationAsync(Amazon.S3.Model.PutBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutBucketRequestPaymentResponse PutBucketRequestPayment(Amazon.S3.Model.PutBucketRequestPaymentRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(string bucketName, Amazon.S3.Model.RequestPaymentConfiguration requestPaymentConfiguration, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(Amazon.S3.Model.PutBucketRequestPaymentRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutBucketTaggingResponse PutBucketTagging(Amazon.S3.Model.PutBucketTaggingRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketTaggingResponse> PutBucketTaggingAsync(string bucketName, System.Collections.Generic.List<Amazon.S3.Model.Tag> tagSet, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketTaggingResponse> PutBucketTaggingAsync(Amazon.S3.Model.PutBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutBucketVersioningResponse PutBucketVersioning(Amazon.S3.Model.PutBucketVersioningRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketVersioningResponse> PutBucketVersioningAsync(Amazon.S3.Model.PutBucketVersioningRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutBucketWebsiteResponse PutBucketWebsite(Amazon.S3.Model.PutBucketWebsiteRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketWebsiteResponse> PutBucketWebsiteAsync(string bucketName, Amazon.S3.Model.WebsiteConfiguration websiteConfiguration, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketWebsiteResponse> PutBucketWebsiteAsync(Amazon.S3.Model.PutBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutCORSConfigurationResponse PutCORSConfiguration(Amazon.S3.Model.PutCORSConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutCORSConfigurationResponse> PutCORSConfigurationAsync(string bucketName, Amazon.S3.Model.CORSConfiguration configuration, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutCORSConfigurationResponse> PutCORSConfigurationAsync(Amazon.S3.Model.PutCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutLifecycleConfigurationResponse PutLifecycleConfiguration(Amazon.S3.Model.PutLifecycleConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(string bucketName, Amazon.S3.Model.LifecycleConfiguration configuration, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(Amazon.S3.Model.PutLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutObjectResponse PutObject(Amazon.S3.Model.PutObjectRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutObjectResponse> PutObjectAsync(Amazon.S3.Model.PutObjectRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutObjectLegalHoldResponse PutObjectLegalHold(Amazon.S3.Model.PutObjectLegalHoldRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutObjectLegalHoldResponse> PutObjectLegalHoldAsync(Amazon.S3.Model.PutObjectLegalHoldRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutObjectLockConfigurationResponse PutObjectLockConfiguration(Amazon.S3.Model.PutObjectLockConfigurationRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutObjectLockConfigurationResponse> PutObjectLockConfigurationAsync(Amazon.S3.Model.PutObjectLockConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutObjectRetentionResponse PutObjectRetention(Amazon.S3.Model.PutObjectRetentionRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutObjectRetentionResponse> PutObjectRetentionAsync(Amazon.S3.Model.PutObjectRetentionRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutObjectTaggingResponse PutObjectTagging(Amazon.S3.Model.PutObjectTaggingRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutObjectTaggingResponse> PutObjectTaggingAsync(Amazon.S3.Model.PutObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.PutPublicAccessBlockResponse PutPublicAccessBlock(Amazon.S3.Model.PutPublicAccessBlockRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.PutPublicAccessBlockResponse> PutPublicAccessBlockAsync(Amazon.S3.Model.PutPublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.RestoreObjectResponse RestoreObject(Amazon.S3.Model.RestoreObjectRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, int days, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, string versionId, int days, System.Threading.CancellationToken cancellationToken = null)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.RestoreObjectResponse> RestoreObjectAsync(Amazon.S3.Model.RestoreObjectRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.SelectObjectContentResponse SelectObjectContent(Amazon.S3.Model.SelectObjectContentRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.SelectObjectContentResponse> SelectObjectContentAsync(Amazon.S3.Model.SelectObjectContentRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal virtual Amazon.S3.Model.UploadPartResponse UploadPart(Amazon.S3.Model.UploadPartRequest request)
- public virtual System.Threading.Tasks.Task<Amazon.S3.Model.UploadPartResponse> UploadPartAsync(Amazon.S3.Model.UploadPartRequest request, System.Threading.CancellationToken cancellationToken = null)

### public class Amazon.S3.AmazonS3Config
- Base: Amazon.Runtime.ClientConfig
- Interfaces: Amazon.Runtime.IClientConfig

#### Fields
- private bool forcePathStyle
- private bool useAccelerateEndpoint
- private static readonly string UserAgentString
- private static const string _accelerateDualstackEndpoint
- private static const string _accelerateEndpoint
- private string _userAgent

#### Properties
- internal string AccelerateEndpoint { get; }
- public bool ForcePathStyle { get; set; }
- public string RegionEndpointServiceName { get; }
- public string ServiceVersion { get; }
- public bool UseAccelerateEndpoint { get; set; }
- public string UserAgent { get; }

#### Constructors
- public AmazonS3Config()
- private static AmazonS3Config()

#### Methods
- protected override void Initialize()
- public override void Validate()

### public class Amazon.S3.AmazonS3Exception
- Base: Amazon.Runtime.AmazonServiceException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private string <AmazonCloudFrontId>k__BackingField
- private string <AmazonId2>k__BackingField
- private string <Region>k__BackingField
- private string <ResponseBody>k__BackingField

#### Properties
- public string AmazonCloudFrontId { get; protected set; }
- public string AmazonId2 { get; protected set; }
- public string Message { get; }
- internal string Region { get; set; }
- public string ResponseBody { get; internal set; }

#### Constructors
- public AmazonS3Exception(string message)
- public AmazonS3Exception(System.Exception innerException)
- public AmazonS3Exception(string message, System.Exception innerException)
- public AmazonS3Exception(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public AmazonS3Exception(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public AmazonS3Exception(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode, string amazonId2)
- public AmazonS3Exception(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode, string amazonId2, string amazonCfId)

### internal static class Amazon.S3.AmazonS3HttpUtil

#### Methods
- internal static Amazon.S3.GetHeadResponse GetHead(Amazon.S3.IAmazonS3 s3Client, Amazon.Runtime.IClientConfig config, string url, string header)
- internal static System.Threading.Tasks.Task<Amazon.S3.GetHeadResponse> GetHeadAsync(Amazon.S3.IAmazonS3 s3Client, Amazon.Runtime.IClientConfig config, string url, string header)
- internal static System.Net.HttpWebRequest GetHeadHttpRequest(Amazon.Runtime.IClientConfig config, string url)
- private static System.Net.IWebProxy GetProxyIfAvailableAndConfigured(Amazon.Runtime.IClientConfig config)
- private static Amazon.S3.GetHeadResponse HandleWebException(string header, System.Net.WebException we)
- private static Amazon.S3.GetHeadResponse HandleWebResponse(string header, System.Net.HttpWebResponse httpResponse)
- private static void SetProxyIfAvailableAndConfigured(Amazon.Runtime.IClientConfig config, System.Net.HttpWebRequest httpWebRequest)

### public class Amazon.S3.AnalyticsS3ExportFileFormat
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.AnalyticsS3ExportFileFormat CSV

#### Constructors
- private static AnalyticsS3ExportFileFormat()
- public AnalyticsS3ExportFileFormat(string value)

#### Methods
- public static Amazon.S3.AnalyticsS3ExportFileFormat FindValue(string value)
- public static Amazon.S3.AnalyticsS3ExportFileFormat op_Implicit(string value)

### public class Amazon.S3.BucketAccelerateStatus
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.BucketAccelerateStatus Enabled
- public static readonly Amazon.S3.BucketAccelerateStatus Suspended

#### Constructors
- private static BucketAccelerateStatus()
- public BucketAccelerateStatus(string value)

#### Methods
- public static Amazon.S3.BucketAccelerateStatus FindValue(string value)
- public static Amazon.S3.BucketAccelerateStatus op_Implicit(string value)

### public class Amazon.S3.CompressionType
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.CompressionType Bzip2
- public static readonly Amazon.S3.CompressionType Gzip
- public static readonly Amazon.S3.CompressionType None

#### Constructors
- private static CompressionType()
- private CompressionType(string value)

#### Methods
- public static Amazon.S3.CompressionType FindValue(string value)
- public static Amazon.S3.CompressionType op_Implicit(string value)

### public class Amazon.S3.DeleteMarkerReplicationStatus
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.DeleteMarkerReplicationStatus Disabled
- public static readonly Amazon.S3.DeleteMarkerReplicationStatus Enabled

#### Constructors
- private static DeleteMarkerReplicationStatus()
- public DeleteMarkerReplicationStatus(string value)

#### Methods
- public static Amazon.S3.DeleteMarkerReplicationStatus FindValue(string value)
- public static Amazon.S3.DeleteMarkerReplicationStatus op_Implicit(string value)

### public class Amazon.S3.DeleteObjectsException
- Base: Amazon.S3.AmazonS3Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private Amazon.S3.Model.DeleteObjectsResponse response

#### Properties
- public Amazon.S3.Model.DeleteObjectsResponse Response { get; set; }

#### Constructors
- public DeleteObjectsException(Amazon.S3.Model.DeleteObjectsResponse response)

#### Methods
- private static string CreateMessage(Amazon.S3.Model.DeleteObjectsResponse response)

### public class Amazon.S3.EncodingType
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.EncodingType Url

#### Constructors
- private static EncodingType()
- public EncodingType(string value)

#### Methods
- public static Amazon.S3.EncodingType FindValue(string value)
- public static Amazon.S3.EncodingType op_Implicit(string value)

### public class Amazon.S3.EventType
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.EventType ObjectCreatedAll
- public static readonly Amazon.S3.EventType ObjectCreatedCompleteMultipartUpload
- public static readonly Amazon.S3.EventType ObjectCreatedCopy
- public static readonly Amazon.S3.EventType ObjectCreatedPost
- public static readonly Amazon.S3.EventType ObjectCreatedPut
- public static readonly Amazon.S3.EventType ObjectRemovedAll
- public static readonly Amazon.S3.EventType ObjectRemovedDelete
- public static readonly Amazon.S3.EventType ObjectRemovedDeleteMarkerCreated
- public static readonly Amazon.S3.EventType ObjectRestoreCompleted
- public static readonly Amazon.S3.EventType ObjectRestorePost
- public static readonly Amazon.S3.EventType ReducedRedundancyLostObject

#### Constructors
- private static EventType()
- public EventType(string value)

#### Methods
- public override bool Equals(Amazon.Runtime.ConstantClass obj)
- protected override bool Equals(string value)
- public static Amazon.S3.EventType FindValue(string value)
- public static Amazon.S3.EventType op_Implicit(string value)

### public class Amazon.S3.ExpressionType
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.ExpressionType SQL

#### Constructors
- private static ExpressionType()
- private ExpressionType(string value)

#### Methods
- public static Amazon.S3.ExpressionType FindValue(string value)
- public static Amazon.S3.ExpressionType op_Implicit(string value)

### public class Amazon.S3.FileHeaderInfo
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.FileHeaderInfo Ignore
- public static readonly Amazon.S3.FileHeaderInfo None
- public static readonly Amazon.S3.FileHeaderInfo Use

#### Constructors
- private static FileHeaderInfo()
- private FileHeaderInfo(string value)

#### Methods
- public static Amazon.S3.FileHeaderInfo FindValue(string value)
- public static Amazon.S3.FileHeaderInfo op_Implicit(string value)

### internal class Amazon.S3.GetHeadResponse

#### Fields
- private string <HeaderValue>k__BackingField
- private System.Nullable<System.Net.HttpStatusCode> <StatusCode>k__BackingField

#### Properties
- public string HeaderValue { get; set; }
- public System.Nullable<System.Net.HttpStatusCode> StatusCode { get; set; }

#### Constructors
- public GetHeadResponse()

### public class Amazon.S3.GlacierJobTier
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.GlacierJobTier Bulk
- public static readonly Amazon.S3.GlacierJobTier Expedited
- public static readonly Amazon.S3.GlacierJobTier Standard

#### Constructors
- private static GlacierJobTier()
- private GlacierJobTier(string value)

#### Methods
- public static Amazon.S3.GlacierJobTier FindValue(string value)
- public static Amazon.S3.GlacierJobTier op_Implicit(string value)

### public class Amazon.S3.GranteeType
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.GranteeType CanonicalUser
- public static readonly Amazon.S3.GranteeType Email
- public static readonly Amazon.S3.GranteeType Group

#### Constructors
- private static GranteeType()
- public GranteeType(string value)

#### Methods
- public static Amazon.S3.GranteeType FindValue(string value)
- public static Amazon.S3.GranteeType op_Implicit(string value)

### public enum Amazon.S3.HttpVerb
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DELETE = 3
- GET = 0
- HEAD = 1
- PUT = 2

### public interface Amazon.S3.IAmazonS3
- Interfaces: System.IDisposable, Amazon.Runtime.SharedInterfaces.ICoreAmazonS3, Amazon.Runtime.IAmazonService

#### Methods
- public System.Threading.Tasks.Task<Amazon.S3.Model.AbortMultipartUploadResponse> AbortMultipartUploadAsync(string bucketName, string key, string uploadId, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.AbortMultipartUploadResponse> AbortMultipartUploadAsync(Amazon.S3.Model.AbortMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(Amazon.S3.Model.CompleteMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.CopyObjectResponse> CopyObjectAsync(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.CopyObjectResponse> CopyObjectAsync(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.CopyObjectResponse> CopyObjectAsync(Amazon.S3.Model.CopyObjectRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.CopyPartResponse> CopyPartAsync(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, string uploadId, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.CopyPartResponse> CopyPartAsync(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, string uploadId, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.CopyPartResponse> CopyPartAsync(Amazon.S3.Model.CopyPartRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketAnalyticsConfigurationResponse> DeleteBucketAnalyticsConfigurationAsync(Amazon.S3.Model.DeleteBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketResponse> DeleteBucketAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketResponse> DeleteBucketAsync(Amazon.S3.Model.DeleteBucketRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketEncryptionResponse> DeleteBucketEncryptionAsync(Amazon.S3.Model.DeleteBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketInventoryConfigurationResponse> DeleteBucketInventoryConfigurationAsync(Amazon.S3.Model.DeleteBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketMetricsConfigurationResponse> DeleteBucketMetricsConfigurationAsync(Amazon.S3.Model.DeleteBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(Amazon.S3.Model.DeleteBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketReplicationResponse> DeleteBucketReplicationAsync(Amazon.S3.Model.DeleteBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(Amazon.S3.Model.DeleteBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(Amazon.S3.Model.DeleteBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(Amazon.S3.Model.DeleteCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(Amazon.S3.Model.DeleteLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteObjectResponse> DeleteObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteObjectResponse> DeleteObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteObjectResponse> DeleteObjectAsync(Amazon.S3.Model.DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteObjectsResponse> DeleteObjectsAsync(Amazon.S3.Model.DeleteObjectsRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeleteObjectTaggingResponse> DeleteObjectTaggingAsync(Amazon.S3.Model.DeleteObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.DeletePublicAccessBlockResponse> DeletePublicAccessBlockAsync(Amazon.S3.Model.DeletePublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetACLResponse> GetACLAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetACLResponse> GetACLAsync(Amazon.S3.Model.GetACLRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketAccelerateConfigurationResponse> GetBucketAccelerateConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketAccelerateConfigurationResponse> GetBucketAccelerateConfigurationAsync(Amazon.S3.Model.GetBucketAccelerateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketAnalyticsConfigurationResponse> GetBucketAnalyticsConfigurationAsync(Amazon.S3.Model.GetBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketEncryptionResponse> GetBucketEncryptionAsync(Amazon.S3.Model.GetBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketInventoryConfigurationResponse> GetBucketInventoryConfigurationAsync(Amazon.S3.Model.GetBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketLocationResponse> GetBucketLocationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketLocationResponse> GetBucketLocationAsync(Amazon.S3.Model.GetBucketLocationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketLoggingResponse> GetBucketLoggingAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketLoggingResponse> GetBucketLoggingAsync(Amazon.S3.Model.GetBucketLoggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketMetricsConfigurationResponse> GetBucketMetricsConfigurationAsync(Amazon.S3.Model.GetBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketNotificationResponse> GetBucketNotificationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketNotificationResponse> GetBucketNotificationAsync(Amazon.S3.Model.GetBucketNotificationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketPolicyResponse> GetBucketPolicyAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketPolicyResponse> GetBucketPolicyAsync(Amazon.S3.Model.GetBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketPolicyStatusResponse> GetBucketPolicyStatusAsync(Amazon.S3.Model.GetBucketPolicyStatusRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketReplicationResponse> GetBucketReplicationAsync(Amazon.S3.Model.GetBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(Amazon.S3.Model.GetBucketRequestPaymentRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketTaggingResponse> GetBucketTaggingAsync(Amazon.S3.Model.GetBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketVersioningResponse> GetBucketVersioningAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketVersioningResponse> GetBucketVersioningAsync(Amazon.S3.Model.GetBucketVersioningRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketWebsiteResponse> GetBucketWebsiteAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetBucketWebsiteResponse> GetBucketWebsiteAsync(Amazon.S3.Model.GetBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetCORSConfigurationResponse> GetCORSConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetCORSConfigurationResponse> GetCORSConfigurationAsync(Amazon.S3.Model.GetCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(Amazon.S3.Model.GetLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectResponse> GetObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectResponse> GetObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectResponse> GetObjectAsync(Amazon.S3.Model.GetObjectRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectLegalHoldResponse> GetObjectLegalHoldAsync(Amazon.S3.Model.GetObjectLegalHoldRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectLockConfigurationResponse> GetObjectLockConfigurationAsync(Amazon.S3.Model.GetObjectLockConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectMetadataResponse> GetObjectMetadataAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectMetadataResponse> GetObjectMetadataAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectMetadataResponse> GetObjectMetadataAsync(Amazon.S3.Model.GetObjectMetadataRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectRetentionResponse> GetObjectRetentionAsync(Amazon.S3.Model.GetObjectRetentionRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectTaggingResponse> GetObjectTaggingAsync(Amazon.S3.Model.GetObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectTorrentResponse> GetObjectTorrentAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetObjectTorrentResponse> GetObjectTorrentAsync(Amazon.S3.Model.GetObjectTorrentRequest request, System.Threading.CancellationToken cancellationToken = null)
- public string GetPreSignedURL(Amazon.S3.Model.GetPreSignedUrlRequest request)
- public System.Threading.Tasks.Task<Amazon.S3.Model.GetPublicAccessBlockResponse> GetPublicAccessBlockAsync(Amazon.S3.Model.GetPublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(Amazon.S3.Model.InitiateMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListBucketAnalyticsConfigurationsResponse> ListBucketAnalyticsConfigurationsAsync(Amazon.S3.Model.ListBucketAnalyticsConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListBucketInventoryConfigurationsResponse> ListBucketInventoryConfigurationsAsync(Amazon.S3.Model.ListBucketInventoryConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListBucketMetricsConfigurationsResponse> ListBucketMetricsConfigurationsAsync(Amazon.S3.Model.ListBucketMetricsConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListBucketsResponse> ListBucketsAsync(System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListBucketsResponse> ListBucketsAsync(Amazon.S3.Model.ListBucketsRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListMultipartUploadsResponse> ListMultipartUploadsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListMultipartUploadsResponse> ListMultipartUploadsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListMultipartUploadsResponse> ListMultipartUploadsAsync(Amazon.S3.Model.ListMultipartUploadsRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListObjectsResponse> ListObjectsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListObjectsResponse> ListObjectsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListObjectsResponse> ListObjectsAsync(Amazon.S3.Model.ListObjectsRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListObjectsV2Response> ListObjectsV2Async(Amazon.S3.Model.ListObjectsV2Request request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListPartsResponse> ListPartsAsync(string bucketName, string key, string uploadId, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListPartsResponse> ListPartsAsync(Amazon.S3.Model.ListPartsRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListVersionsResponse> ListVersionsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListVersionsResponse> ListVersionsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.ListVersionsResponse> ListVersionsAsync(Amazon.S3.Model.ListVersionsRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutACLResponse> PutACLAsync(Amazon.S3.Model.PutACLRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketAccelerateConfigurationResponse> PutBucketAccelerateConfigurationAsync(Amazon.S3.Model.PutBucketAccelerateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketAnalyticsConfigurationResponse> PutBucketAnalyticsConfigurationAsync(Amazon.S3.Model.PutBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketResponse> PutBucketAsync(string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketResponse> PutBucketAsync(Amazon.S3.Model.PutBucketRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.PutBucketEncryptionResponse> PutBucketEncryptionAsync(Amazon.S3.Model.PutBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketInventoryConfigurationResponse> PutBucketInventoryConfigurationAsync(Amazon.S3.Model.PutBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketLoggingResponse> PutBucketLoggingAsync(Amazon.S3.Model.PutBucketLoggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketMetricsConfigurationResponse> PutBucketMetricsConfigurationAsync(Amazon.S3.Model.PutBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketNotificationResponse> PutBucketNotificationAsync(Amazon.S3.Model.PutBucketNotificationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketPolicyResponse> PutBucketPolicyAsync(string bucketName, string policy, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketPolicyResponse> PutBucketPolicyAsync(string bucketName, string policy, string contentMD5, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketPolicyResponse> PutBucketPolicyAsync(Amazon.S3.Model.PutBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketReplicationResponse> PutBucketReplicationAsync(Amazon.S3.Model.PutBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(string bucketName, Amazon.S3.Model.RequestPaymentConfiguration requestPaymentConfiguration, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(Amazon.S3.Model.PutBucketRequestPaymentRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketTaggingResponse> PutBucketTaggingAsync(string bucketName, System.Collections.Generic.List<Amazon.S3.Model.Tag> tagSet, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketTaggingResponse> PutBucketTaggingAsync(Amazon.S3.Model.PutBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketVersioningResponse> PutBucketVersioningAsync(Amazon.S3.Model.PutBucketVersioningRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketWebsiteResponse> PutBucketWebsiteAsync(string bucketName, Amazon.S3.Model.WebsiteConfiguration websiteConfiguration, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutBucketWebsiteResponse> PutBucketWebsiteAsync(Amazon.S3.Model.PutBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutCORSConfigurationResponse> PutCORSConfigurationAsync(string bucketName, Amazon.S3.Model.CORSConfiguration configuration, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutCORSConfigurationResponse> PutCORSConfigurationAsync(Amazon.S3.Model.PutCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(string bucketName, Amazon.S3.Model.LifecycleConfiguration configuration, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(Amazon.S3.Model.PutLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutObjectResponse> PutObjectAsync(Amazon.S3.Model.PutObjectRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutObjectLegalHoldResponse> PutObjectLegalHoldAsync(Amazon.S3.Model.PutObjectLegalHoldRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutObjectLockConfigurationResponse> PutObjectLockConfigurationAsync(Amazon.S3.Model.PutObjectLockConfigurationRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutObjectRetentionResponse> PutObjectRetentionAsync(Amazon.S3.Model.PutObjectRetentionRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutObjectTaggingResponse> PutObjectTaggingAsync(Amazon.S3.Model.PutObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.PutPublicAccessBlockResponse> PutPublicAccessBlockAsync(Amazon.S3.Model.PutPublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, int days, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, string versionId, int days, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.RestoreObjectResponse> RestoreObjectAsync(Amazon.S3.Model.RestoreObjectRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.SelectObjectContentResponse> SelectObjectContentAsync(Amazon.S3.Model.SelectObjectContentRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<Amazon.S3.Model.UploadPartResponse> UploadPartAsync(Amazon.S3.Model.UploadPartRequest request, System.Threading.CancellationToken cancellationToken = null)

### public class Amazon.S3.InventoryFormat
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.InventoryFormat CSV
- public static readonly Amazon.S3.InventoryFormat ORC
- public static readonly Amazon.S3.InventoryFormat Parquet

#### Constructors
- private static InventoryFormat()
- public InventoryFormat(string value)

#### Methods
- public static Amazon.S3.InventoryFormat FindValue(string value)
- public static Amazon.S3.InventoryFormat op_Implicit(string value)

### public class Amazon.S3.InventoryFrequency
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.InventoryFrequency Daily
- public static readonly Amazon.S3.InventoryFrequency Weekly

#### Constructors
- private static InventoryFrequency()
- public InventoryFrequency(string value)

#### Methods
- public static Amazon.S3.InventoryFrequency FindValue(string value)
- public static Amazon.S3.InventoryFrequency op_Implicit(string value)

### public class Amazon.S3.InventoryIncludedObjectVersions
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.InventoryIncludedObjectVersions All
- public static readonly Amazon.S3.InventoryIncludedObjectVersions Current

#### Constructors
- private static InventoryIncludedObjectVersions()
- public InventoryIncludedObjectVersions(string value)

#### Methods
- public static Amazon.S3.InventoryIncludedObjectVersions FindValue(string value)
- public static Amazon.S3.InventoryIncludedObjectVersions op_Implicit(string value)

### public class Amazon.S3.InventoryOptionalField
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.InventoryOptionalField EncryptionStatus
- public static readonly Amazon.S3.InventoryOptionalField ETag
- public static readonly Amazon.S3.InventoryOptionalField IsMultipartUploaded
- public static readonly Amazon.S3.InventoryOptionalField LastModifiedDate
- public static readonly Amazon.S3.InventoryOptionalField ObjectLockLegalHoldStatus
- public static readonly Amazon.S3.InventoryOptionalField ObjectLockMode
- public static readonly Amazon.S3.InventoryOptionalField ObjectLockRetainUntilDate
- public static readonly Amazon.S3.InventoryOptionalField ReplicationStatus
- public static readonly Amazon.S3.InventoryOptionalField Size
- public static readonly Amazon.S3.InventoryOptionalField StorageClass

#### Constructors
- private static InventoryOptionalField()
- public InventoryOptionalField(string value)

#### Methods
- public static Amazon.S3.InventoryOptionalField FindValue(string value)
- public static Amazon.S3.InventoryOptionalField op_Implicit(string value)

### public class Amazon.S3.JsonType
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.JsonType Document
- public static readonly Amazon.S3.JsonType Lines

#### Constructors
- private static JsonType()
- private JsonType(string value)

#### Methods
- public static Amazon.S3.JsonType FindValue(string value)
- public static Amazon.S3.JsonType op_Implicit(string value)

### public class Amazon.S3.LifecycleRuleStatus
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.LifecycleRuleStatus Disabled
- public static readonly Amazon.S3.LifecycleRuleStatus Enabled

#### Constructors
- private static LifecycleRuleStatus()
- public LifecycleRuleStatus(string value)

#### Methods
- public static Amazon.S3.LifecycleRuleStatus FindValue(string value)
- public static Amazon.S3.LifecycleRuleStatus op_Implicit(string value)

### public class Amazon.S3.NotificationEvents

#### Fields
- public static readonly string ReducedRedundancyLostObject

#### Constructors
- private NotificationEvents()
- private static NotificationEvents()

### public class Amazon.S3.ObjectLockEnabled
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.ObjectLockEnabled Enabled

#### Constructors
- private static ObjectLockEnabled()
- public ObjectLockEnabled(string value)

#### Methods
- public static Amazon.S3.ObjectLockEnabled FindValue(string value)
- public static Amazon.S3.ObjectLockEnabled op_Implicit(string value)

### public class Amazon.S3.ObjectLockLegalHoldStatus
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.ObjectLockLegalHoldStatus Off
- public static readonly Amazon.S3.ObjectLockLegalHoldStatus On

#### Constructors
- private static ObjectLockLegalHoldStatus()
- public ObjectLockLegalHoldStatus(string value)

#### Methods
- public static Amazon.S3.ObjectLockLegalHoldStatus FindValue(string value)
- public static Amazon.S3.ObjectLockLegalHoldStatus op_Implicit(string value)

### public class Amazon.S3.ObjectLockMode
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.ObjectLockMode Compliance
- public static readonly Amazon.S3.ObjectLockMode Governance

#### Constructors
- private static ObjectLockMode()
- public ObjectLockMode(string value)

#### Methods
- public static Amazon.S3.ObjectLockMode FindValue(string value)
- public static Amazon.S3.ObjectLockMode op_Implicit(string value)

### public class Amazon.S3.ObjectLockRetentionMode
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.ObjectLockRetentionMode Compliance
- public static readonly Amazon.S3.ObjectLockRetentionMode Governance

#### Constructors
- private static ObjectLockRetentionMode()
- public ObjectLockRetentionMode(string value)

#### Methods
- public static Amazon.S3.ObjectLockRetentionMode FindValue(string value)
- public static Amazon.S3.ObjectLockRetentionMode op_Implicit(string value)

### public class Amazon.S3.OwnerOverride
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.OwnerOverride Destination

#### Constructors
- private static OwnerOverride()
- public OwnerOverride(string value)

#### Methods
- public static Amazon.S3.OwnerOverride FindValue(string value)
- public static Amazon.S3.OwnerOverride op_Implicit(string value)

### public enum Amazon.S3.Protocol
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- HTTP = 1
- HTTPS = 0

### public class Amazon.S3.PutBucketEncryptionResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutBucketEncryptionResponse()

### public class Amazon.S3.QuoteFields
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.QuoteFields Always
- public static readonly Amazon.S3.QuoteFields AsNeeded

#### Constructors
- private static QuoteFields()
- private QuoteFields(string value)

#### Methods
- public static Amazon.S3.QuoteFields FindValue(string value)
- public static Amazon.S3.QuoteFields op_Implicit(string value)

### public class Amazon.S3.ReplicationRuleStatus
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.ReplicationRuleStatus Disabled
- public static readonly Amazon.S3.ReplicationRuleStatus Enabled

#### Constructors
- private static ReplicationRuleStatus()
- public ReplicationRuleStatus(string value)

#### Methods
- public static Amazon.S3.ReplicationRuleStatus FindValue(string value)
- public static Amazon.S3.ReplicationRuleStatus op_Implicit(string value)

### public class Amazon.S3.ReplicationStatus
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.ReplicationStatus Completed
- public static readonly Amazon.S3.ReplicationStatus Failed
- public static readonly Amazon.S3.ReplicationStatus Pending
- public static readonly Amazon.S3.ReplicationStatus Replica

#### Constructors
- private static ReplicationStatus()
- public ReplicationStatus(string value)

#### Methods
- public static Amazon.S3.ReplicationStatus FindValue(string value)
- public static Amazon.S3.ReplicationStatus op_Implicit(string value)

### public class Amazon.S3.RequestCharged
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.RequestCharged Requester

#### Constructors
- private static RequestCharged()
- private RequestCharged(string value)

#### Methods
- public static Amazon.S3.RequestCharged FindValue(string value)
- public static Amazon.S3.RequestCharged op_Implicit(string value)

### public class Amazon.S3.RequestPayer
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.RequestPayer Requester

#### Constructors
- private static RequestPayer()
- private RequestPayer(string value)

#### Methods
- public static Amazon.S3.RequestPayer FindValue(string value)
- public static Amazon.S3.RequestPayer op_Implicit(string value)

### public class Amazon.S3.RestoreRequestType
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.RestoreRequestType SELECT

#### Constructors
- private static RestoreRequestType()
- private RestoreRequestType(string value)

#### Methods
- public static Amazon.S3.RestoreRequestType FindValue(string value)
- public static Amazon.S3.RestoreRequestType op_Implicit(string value)

### public class Amazon.S3.S3CannedACL
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.S3CannedACL AuthenticatedRead
- public static readonly Amazon.S3.S3CannedACL AWSExecRead
- public static readonly Amazon.S3.S3CannedACL BucketOwnerFullControl
- public static readonly Amazon.S3.S3CannedACL BucketOwnerRead
- public static readonly Amazon.S3.S3CannedACL LogDeliveryWrite
- public static readonly Amazon.S3.S3CannedACL NoACL
- public static readonly Amazon.S3.S3CannedACL Private
- public static readonly Amazon.S3.S3CannedACL PublicRead
- public static readonly Amazon.S3.S3CannedACL PublicReadWrite

#### Constructors
- private static S3CannedACL()
- public S3CannedACL(string value)

#### Methods
- public static Amazon.S3.S3CannedACL FindValue(string value)
- public static Amazon.S3.S3CannedACL op_Implicit(string value)

### public enum Amazon.S3.S3MetadataDirective
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- COPY = 0
- REPLACE = 1

### public class Amazon.S3.S3Permission
- Base: Amazon.Runtime.ConstantClass

#### Fields
- private string <HeaderName>k__BackingField
- public static readonly Amazon.S3.S3Permission FULL_CONTROL
- public static readonly Amazon.S3.S3Permission READ
- public static readonly Amazon.S3.S3Permission READ_ACP
- public static readonly Amazon.S3.S3Permission RESTORE_OBJECT
- public static readonly Amazon.S3.S3Permission WRITE
- public static readonly Amazon.S3.S3Permission WRITE_ACP

#### Properties
- public string HeaderName { get; private set; }

#### Constructors
- private static S3Permission()
- public S3Permission(string value)
- public S3Permission(string value, string headerName)

#### Methods
- public static Amazon.S3.S3Permission FindValue(string value)
- public static Amazon.S3.S3Permission op_Implicit(string value)

### internal enum Amazon.S3.S3QueryParameter
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Action = 0
- Authorization = 1
- BucketVersion = 2
- CanonicalizedResource = 3
- ContentBody = 4
- ContentLength = 5
- ContentType = 6
- DestinationBucket = 7
- Expires = 8
- Key = 9
- KeyMarker = 20
- MaxUploads = 19
- Query = 10
- QueryToSign = 11
- Range = 12
- RequestAddress = 13
- RequestReadWriteTimeout = 15
- RequestTimeout = 14
- UploadIdMarker = 21
- Url = 16
- Verb = 17
- VerifyChecksum = 18

### public class Amazon.S3.S3Region
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.S3Region APE1
- public static readonly Amazon.S3.S3Region APN1
- public static readonly Amazon.S3.S3Region APN2
- public static readonly Amazon.S3.S3Region APN3
- public static readonly Amazon.S3.S3Region APS1
- public static readonly Amazon.S3.S3Region APS2
- public static readonly Amazon.S3.S3Region APS3
- public static readonly Amazon.S3.S3Region CAN1
- public static readonly Amazon.S3.S3Region CN
- public static readonly Amazon.S3.S3Region CN1
- public static readonly Amazon.S3.S3Region CNW1
- public static readonly Amazon.S3.S3Region EU
- public static readonly Amazon.S3.S3Region EUC1
- public static readonly Amazon.S3.S3Region EUN1
- public static readonly Amazon.S3.S3Region EUW1
- public static readonly Amazon.S3.S3Region EUW2
- public static readonly Amazon.S3.S3Region EUW3
- public static readonly Amazon.S3.S3Region GOV
- public static readonly Amazon.S3.S3Region GOVE1
- public static readonly Amazon.S3.S3Region GOVW1
- public static readonly Amazon.S3.S3Region SAE1
- public static readonly Amazon.S3.S3Region SFO
- public static readonly Amazon.S3.S3Region US
- public static readonly Amazon.S3.S3Region USE2
- public static readonly Amazon.S3.S3Region USW1
- public static readonly Amazon.S3.S3Region USW2

#### Constructors
- private static S3Region()
- public S3Region(string value)

#### Methods
- public static Amazon.S3.S3Region FindValue(string value)
- public static Amazon.S3.S3Region op_Implicit(string value)

### public class Amazon.S3.S3StorageClass
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.S3StorageClass DeepArchive
- public static readonly Amazon.S3.S3StorageClass Glacier
- public static readonly Amazon.S3.S3StorageClass IntelligentTiering
- public static readonly Amazon.S3.S3StorageClass OneZoneInfrequentAccess
- public static readonly Amazon.S3.S3StorageClass ReducedRedundancy
- public static readonly Amazon.S3.S3StorageClass Standard
- public static readonly Amazon.S3.S3StorageClass StandardInfrequentAccess

#### Constructors
- private static S3StorageClass()
- public S3StorageClass(string value)

#### Methods
- public static Amazon.S3.S3StorageClass FindValue(string value)
- public static Amazon.S3.S3StorageClass op_Implicit(string value)

### public class Amazon.S3.ServerSideEncryptionCustomerMethod
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.ServerSideEncryptionCustomerMethod AES256
- public static readonly Amazon.S3.ServerSideEncryptionCustomerMethod None

#### Constructors
- private static ServerSideEncryptionCustomerMethod()
- public ServerSideEncryptionCustomerMethod(string value)

#### Methods
- public static Amazon.S3.ServerSideEncryptionCustomerMethod FindValue(string value)
- public static Amazon.S3.ServerSideEncryptionCustomerMethod op_Implicit(string value)

### public class Amazon.S3.ServerSideEncryptionMethod
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.ServerSideEncryptionMethod AES256
- public static readonly Amazon.S3.ServerSideEncryptionMethod AWSKMS
- public static readonly Amazon.S3.ServerSideEncryptionMethod None

#### Constructors
- private static ServerSideEncryptionMethod()
- public ServerSideEncryptionMethod(string value)

#### Methods
- public static Amazon.S3.ServerSideEncryptionMethod FindValue(string value)
- public static Amazon.S3.ServerSideEncryptionMethod op_Implicit(string value)

### public class Amazon.S3.SseKmsEncryptedObjectsStatus
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.SseKmsEncryptedObjectsStatus Disabled
- public static readonly Amazon.S3.SseKmsEncryptedObjectsStatus Enabled

#### Constructors
- private static SseKmsEncryptedObjectsStatus()
- public SseKmsEncryptedObjectsStatus(string value)

#### Methods
- public static Amazon.S3.SseKmsEncryptedObjectsStatus FindValue(string value)
- public static Amazon.S3.SseKmsEncryptedObjectsStatus op_Implicit(string value)

### public class Amazon.S3.StorageClassAnalysisSchemaVersion
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.StorageClassAnalysisSchemaVersion V_1

#### Constructors
- private static StorageClassAnalysisSchemaVersion()
- public StorageClassAnalysisSchemaVersion(string value)

#### Methods
- public static Amazon.S3.StorageClassAnalysisSchemaVersion FindValue(string value)
- public static Amazon.S3.StorageClassAnalysisSchemaVersion op_Implicit(string value)

### internal class Amazon.S3.TaggingDirective
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.TaggingDirective COPY
- public static readonly Amazon.S3.TaggingDirective REPLACE

#### Constructors
- private static TaggingDirective()
- public TaggingDirective(string value)

#### Methods
- public static Amazon.S3.TaggingDirective FindValue(string value)
- public static Amazon.S3.TaggingDirective op_Implicit(string value)

### public class Amazon.S3.VersionStatus
- Base: Amazon.Runtime.ConstantClass

#### Fields
- public static readonly Amazon.S3.VersionStatus Enabled
- public static readonly Amazon.S3.VersionStatus Off
- public static readonly Amazon.S3.VersionStatus Suspended

#### Constructors
- private static VersionStatus()
- public VersionStatus(string value)

#### Methods
- public static Amazon.S3.VersionStatus FindValue(string value)
- public static Amazon.S3.VersionStatus op_Implicit(string value)

## Namespace: Amazon.S3.Encryption

### private struct Amazon.S3.Encryption.EncryptionUtils.<GenerateInstructionsForKMSMaterialsAsync>d__24
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Amazon.S3.Encryption.EncryptionInstructions> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.Runtime.SharedInterfaces.GenerateDataKeyResult> <>u__1
- private byte[] <iv>5__2
- public Amazon.Runtime.SharedInterfaces.ICoreAmazonKMS kmsClient
- public Amazon.S3.Encryption.EncryptionMaterials materials

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class Amazon.S3.Encryption.AmazonS3CryptoConfiguration
- Base: Amazon.S3.AmazonS3Config
- Interfaces: Amazon.Runtime.IClientConfig

#### Fields
- private Amazon.S3.Encryption.CryptoStorageMode <StorageMode>k__BackingField

#### Properties
- public Amazon.S3.Encryption.CryptoStorageMode StorageMode { get; set; }

#### Constructors
- public AmazonS3CryptoConfiguration()

### public class Amazon.S3.Encryption.AmazonS3EncryptionClient
- Base: Amazon.S3.AmazonS3Client
- Interfaces: System.IDisposable, Amazon.S3.IAmazonS3, Amazon.Runtime.SharedInterfaces.ICoreAmazonS3, Amazon.Runtime.IAmazonService, Amazon.S3.Internal.IAmazonS3Encryption

#### Fields
- private Amazon.S3.Encryption.EncryptionMaterials <EncryptionMaterials>k__BackingField
- private Amazon.S3.Encryption.AmazonS3CryptoConfiguration <S3CryptoConfig>k__BackingField
- internal System.Collections.Generic.Dictionary<string, Amazon.S3.Encryption.UploadPartEncryptionContext> CurrentMultiPartUploadKeys
- private Amazon.Runtime.SharedInterfaces.ICoreAmazonKMS kmsClient
- private readonly object kmsClientLock
- private Amazon.S3.AmazonS3Client s3ClientForInstructionFile
- internal static const string S3CryptoStream
- private static readonly string S3KMSEncryptionFeature

#### Properties
- internal Amazon.S3.Encryption.EncryptionMaterials EncryptionMaterials { get; private set; }
- internal Amazon.Runtime.SharedInterfaces.ICoreAmazonKMS KMSClient { get; }
- internal Amazon.S3.AmazonS3Client S3ClientForInstructionFile { get; }
- internal Amazon.S3.Encryption.AmazonS3CryptoConfiguration S3CryptoConfig { get; private set; }
- protected bool SupportResponseLogging { get; }

#### Constructors
- private static AmazonS3EncryptionClient()
- public AmazonS3EncryptionClient(Amazon.S3.Encryption.EncryptionMaterials materials)
- public AmazonS3EncryptionClient(Amazon.RegionEndpoint region, Amazon.S3.Encryption.EncryptionMaterials materials)
- public AmazonS3EncryptionClient(Amazon.S3.Encryption.AmazonS3CryptoConfiguration config, Amazon.S3.Encryption.EncryptionMaterials materials)
- public AmazonS3EncryptionClient(Amazon.Runtime.AWSCredentials credentials, Amazon.S3.Encryption.EncryptionMaterials materials)
- public AmazonS3EncryptionClient(Amazon.Runtime.AWSCredentials credentials, Amazon.RegionEndpoint region, Amazon.S3.Encryption.EncryptionMaterials materials)
- public AmazonS3EncryptionClient(Amazon.Runtime.AWSCredentials credentials, Amazon.S3.Encryption.AmazonS3CryptoConfiguration config, Amazon.S3.Encryption.EncryptionMaterials materials)
- public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, Amazon.S3.Encryption.EncryptionMaterials materials)
- public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, Amazon.RegionEndpoint region, Amazon.S3.Encryption.EncryptionMaterials materials)
- public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, Amazon.S3.Encryption.AmazonS3CryptoConfiguration config, Amazon.S3.Encryption.EncryptionMaterials materials)
- public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, Amazon.S3.Encryption.EncryptionMaterials materials)
- public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, Amazon.RegionEndpoint region, Amazon.S3.Encryption.EncryptionMaterials materials)
- public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, Amazon.S3.Encryption.AmazonS3CryptoConfiguration config, Amazon.S3.Encryption.EncryptionMaterials materials)

#### Methods
- protected override void CustomizeRuntimePipeline(Amazon.Runtime.Internal.RuntimePipeline pipeline)
- protected override void Dispose(bool disposing)

### public enum Amazon.S3.Encryption.CryptoStorageMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- InstructionFile = 0
- ObjectMetadata = 1

### public class Amazon.S3.Encryption.EncryptionInstructions

#### Fields
- private byte[] <EncryptedEnvelopeKey>k__BackingField
- private byte[] <EnvelopeKey>k__BackingField
- private byte[] <InitializationVector>k__BackingField
- private System.Collections.Generic.Dictionary<string, string> <MaterialsDescription>k__BackingField

#### Properties
- internal byte[] EncryptedEnvelopeKey { get; private set; }
- internal byte[] EnvelopeKey { get; private set; }
- internal byte[] InitializationVector { get; private set; }
- internal System.Collections.Generic.Dictionary<string, string> MaterialsDescription { get; private set; }

#### Constructors
- public EncryptionInstructions(System.Collections.Generic.Dictionary<string, string> materialsDescription, byte[] envelopeKey, byte[] iv)
- public EncryptionInstructions(System.Collections.Generic.Dictionary<string, string> materialsDescription, byte[] envelopeKey, byte[] encryptedKey, byte[] iv)

### public class Amazon.S3.Encryption.EncryptionMaterials

#### Fields
- private System.Security.Cryptography.AsymmetricAlgorithm <AsymmetricProvider>k__BackingField
- private string <KMSKeyID>k__BackingField
- private System.Security.Cryptography.SymmetricAlgorithm <SymmetricProvider>k__BackingField
- private System.Collections.Generic.Dictionary<string, string> materialsDescription

#### Properties
- internal System.Security.Cryptography.AsymmetricAlgorithm AsymmetricProvider { get; private set; }
- internal string KMSKeyID { get; private set; }
- internal System.Collections.Generic.Dictionary<string, string> MaterialsDescription { get; }
- internal System.Security.Cryptography.SymmetricAlgorithm SymmetricProvider { get; private set; }

#### Constructors
- public EncryptionMaterials(System.Security.Cryptography.AsymmetricAlgorithm algorithm)
- public EncryptionMaterials(System.Security.Cryptography.SymmetricAlgorithm algorithm)
- public EncryptionMaterials(string kmsKeyID)
- private EncryptionMaterials(System.Security.Cryptography.AsymmetricAlgorithm asymmetricAlgorithm, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm, string kmsKeyID)

### internal static class Amazon.S3.Encryption.EncryptionUtils

#### Fields
- private static const int IVLength
- public static const string KMSCmkIDKey
- public static const string KMSKeySpec
- private static const string ModeMessage
- private static const string XAmzCEKAlg
- private static const string XAmzCEKAlgValue
- private static const string XAmzCryptoInstrFile
- private static const string XAmzIV
- private static const string XAmzKey
- public static const string XAmzKeyV2
- public static const string XAmzMatDesc
- private static const string XAmzUnencryptedContentLength
- private static const string XAmzWrapAlg
- private static const string XAmzWrapAlgValue

#### Methods
- internal static void AddUnencryptedContentLengthToMetadata(Amazon.S3.Model.PutObjectRequest request)
- internal static Amazon.S3.Encryption.EncryptionInstructions BuildInstructionsFromObjectMetadata(Amazon.S3.Model.GetObjectResponse response, Amazon.S3.Encryption.EncryptionMaterials materials, byte[] decryptedEnvelopeKeyKMS)
- internal static Amazon.S3.Encryption.EncryptionInstructions BuildInstructionsUsingInstructionFile(Amazon.S3.Model.GetObjectResponse response, Amazon.S3.Encryption.EncryptionMaterials materials)
- internal static Amazon.S3.Model.PutObjectRequest CreateInstructionFileRequest(Amazon.Runtime.AmazonWebServiceRequest request, Amazon.S3.Encryption.EncryptionInstructions instructions)
- private static byte[] DecryptEnvelopeKeyUsingAsymmetricKeyPair(System.Security.Cryptography.AsymmetricAlgorithm asymmetricAlgorithm, byte[] encryptedEnvelopeKey)
- private static byte[] DecryptEnvelopeKeyUsingSymmetricKey(System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm, byte[] encryptedEnvelopeKey)
- internal static byte[] DecryptNonKMSEnvelopeKey(byte[] encryptedEnvelopeKey, Amazon.S3.Encryption.EncryptionMaterials materials)
- internal static void DecryptObjectUsingInstructions(Amazon.S3.Model.GetObjectResponse response, Amazon.S3.Encryption.EncryptionInstructions instructions)
- internal static System.IO.Stream DecryptStream(System.IO.Stream encryptedStream, Amazon.S3.Encryption.EncryptionInstructions encryptionInstructions)
- private static byte[] EncryptEnvelopeKeyUsingAsymmetricKeyPair(System.Security.Cryptography.AsymmetricAlgorithm asymmetricAlgorithm, byte[] envelopeKey)
- private static byte[] EncryptEnvelopeKeyUsingSymmetricKey(System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm, byte[] envelopeKey)
- internal static System.IO.Stream EncryptRequestUsingInstruction(System.IO.Stream toBeEncrypted, Amazon.S3.Encryption.EncryptionInstructions instructions)
- internal static System.IO.Stream EncryptUploadPartRequestUsingInstructions(System.IO.Stream toBeEncrypted, Amazon.S3.Encryption.EncryptionInstructions instructions)
- internal static void EnsureSupportedAlgorithms(Amazon.S3.Model.MetadataCollection metadata)
- internal static Amazon.S3.Encryption.EncryptionInstructions GenerateInstructionsForKMSMaterials(Amazon.Runtime.SharedInterfaces.ICoreAmazonKMS kmsClient, Amazon.S3.Encryption.EncryptionMaterials materials)
- internal static System.Threading.Tasks.Task<Amazon.S3.Encryption.EncryptionInstructions> GenerateInstructionsForKMSMaterialsAsync(Amazon.Runtime.SharedInterfaces.ICoreAmazonKMS kmsClient, Amazon.S3.Encryption.EncryptionMaterials materials)
- internal static Amazon.S3.Encryption.EncryptionInstructions GenerateInstructionsForNonKMSMaterials(Amazon.S3.Encryption.EncryptionMaterials materials)
- internal static Amazon.S3.Model.GetObjectRequest GetInstructionFileRequest(Amazon.S3.Model.GetObjectResponse response)
- internal static bool IsEncryptionInfoInInstructionFile(Amazon.S3.Model.GetObjectResponse response)
- internal static bool IsEncryptionInfoInMetadata(Amazon.S3.Model.GetObjectResponse response)
- internal static void UpdateMetadataWithEncryptionInstructions(Amazon.Runtime.AmazonWebServiceRequest request, Amazon.S3.Encryption.EncryptionInstructions instructions, bool useV2Metadata)

### internal class Amazon.S3.Encryption.UploadPartEncryptionContext

#### Fields
- private byte[] <EncryptedEnvelopeKey>k__BackingField
- private byte[] <EnvelopeKey>k__BackingField
- private byte[] <FirstIV>k__BackingField
- private bool <IsFinalPart>k__BackingField
- private byte[] <NextIV>k__BackingField
- private int <PartNumber>k__BackingField
- private Amazon.S3.Encryption.CryptoStorageMode <StorageMode>k__BackingField

#### Properties
- public byte[] EncryptedEnvelopeKey { get; set; }
- public byte[] EnvelopeKey { get; set; }
- public byte[] FirstIV { get; set; }
- public bool IsFinalPart { get; set; }
- public byte[] NextIV { get; set; }
- public int PartNumber { get; set; }
- public Amazon.S3.Encryption.CryptoStorageMode StorageMode { get; set; }

#### Constructors
- public UploadPartEncryptionContext()

## Namespace: Amazon.S3.Encryption.Internal

### private struct Amazon.S3.Encryption.Internal.SetupEncryptionHandler.<InvokeAsync>d__7<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Encryption.Internal.SetupEncryptionHandler <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__2
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Encryption.Internal.SetupDecryptionHandler.<InvokeAsync>d__8<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Encryption.Internal.SetupDecryptionHandler <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2
- private T <response>5__2
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Encryption.Internal.SetupDecryptionHandler.<PostInvokeAsync>d__9
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Encryption.Internal.SetupDecryptionHandler <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<byte[]> <>u__1
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Encryption.Internal.SetupEncryptionHandler.<PreInvokeAsync>d__8
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Encryption.Internal.SetupEncryptionHandler <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Encryption.EncryptionInstructions> <>u__1
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class Amazon.S3.Encryption.Internal.SetupDecryptionHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Fields
- private Amazon.S3.Encryption.AmazonS3EncryptionClient <EncryptionClient>k__BackingField
- private static const string KMSKeyIDMetadataMessage

#### Properties
- public Amazon.S3.Encryption.AmazonS3EncryptionClient EncryptionClient { get; private set; }

#### Constructors
- public SetupDecryptionHandler(Amazon.S3.Encryption.AmazonS3EncryptionClient encryptionClient)

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- private void DecryptObjectUsingInstructionFile(Amazon.S3.Model.GetObjectResponse response, Amazon.S3.Model.GetObjectResponse instructionFileResponse)
- private void DecryptObjectUsingMetadata(Amazon.S3.Model.GetObjectResponse objectResponse, byte[] decryptedEnvelopeKeyKMS)
- private static string GetKMSKeyIDFromMetadata(Amazon.S3.Model.MetadataCollection metadata)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- private static bool KMSEnvelopeKeyIsPresent(Amazon.Runtime.IExecutionContext executionContext, out byte[] encryptedKMSEnvelopeKey, out System.Collections.Generic.Dictionary<string, string> encryptionContext)
- protected void PostInvoke(Amazon.Runtime.IExecutionContext executionContext)
- protected System.Threading.Tasks.Task PostInvokeAsync(Amazon.Runtime.IExecutionContext executionContext)
- protected void PostInvokeSynchronous(Amazon.Runtime.IExecutionContext executionContext, byte[] decryptedEnvelopeKeyKMS)

### public class Amazon.S3.Encryption.Internal.SetupEncryptionHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Fields
- private Amazon.S3.Encryption.AmazonS3EncryptionClient <EncryptionClient>k__BackingField

#### Properties
- public Amazon.S3.Encryption.AmazonS3EncryptionClient EncryptionClient { get; private set; }

#### Constructors
- public SetupEncryptionHandler(Amazon.S3.Encryption.AmazonS3EncryptionClient encryptionClient)

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- private void GenerateEncryptedObjectRequestUsingInstructionFile(Amazon.S3.Model.PutObjectRequest putObjectRequest, Amazon.S3.Encryption.EncryptionInstructions instructions)
- private void GenerateEncryptedObjectRequestUsingMetadata(Amazon.S3.Model.PutObjectRequest putObjectRequest, Amazon.S3.Encryption.EncryptionInstructions instructions)
- private void GenerateEncryptedUploadPartRequest(Amazon.S3.Model.UploadPartRequest request)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- private static bool NeedToGenerateInstructions(Amazon.Runtime.IExecutionContext executionContext)
- private bool NeedToGenerateKMSInstructions(Amazon.Runtime.IExecutionContext executionContext)
- protected void PreInvoke(Amazon.Runtime.IExecutionContext executionContext)
- protected System.Threading.Tasks.Task PreInvokeAsync(Amazon.Runtime.IExecutionContext executionContext)
- private void PreInvokeSynchronous(Amazon.Runtime.IExecutionContext executionContext, Amazon.S3.Encryption.EncryptionInstructions instructions)
- private void ValidateConfigAndMaterials()

### public class Amazon.S3.Encryption.Internal.UserAgentHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Constructors
- public UserAgentHandler()

#### Methods
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- protected virtual void PreInvoke(Amazon.Runtime.IExecutionContext executionContext)

## Namespace: Amazon.S3.Internal

### private class Amazon.S3.Internal.AmazonS3PostMarshallHandler.<>c

#### Fields
- public static readonly Amazon.S3.Internal.AmazonS3PostMarshallHandler.<>c <>9
- public static System.Func<System.Collections.Generic.KeyValuePair<string, string>, bool> <>9__8_0
- public static System.Func<System.Collections.Generic.KeyValuePair<string, string>, string> <>9__8_1

#### Constructors
- private static AmazonS3PostMarshallHandler.<>c()
- public AmazonS3PostMarshallHandler.<>c()

#### Methods
- internal bool <ValidateSseKeyHeaders>b__8_0(System.Collections.Generic.KeyValuePair<string, string> kvp)
- internal string <ValidateSseKeyHeaders>b__8_1(System.Collections.Generic.KeyValuePair<string, string> kvp)

### private struct Amazon.S3.Internal.AmazonS3ExceptionHandler.<InvokeAsync>d__1<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Internal.AmazonS3ExceptionHandler <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__1
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Internal.AmazonS3ResponseHandler.<InvokeAsync>d__1<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Internal.AmazonS3ResponseHandler <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__1
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Internal.AmazonS3RetryPolicy.<RetryForExceptionAsync>d__4
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Internal.AmazonS3RetryPolicy <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<string> <>u__1
- public System.Exception exception
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class Amazon.S3.Internal.AmazonS3ExceptionHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Constructors
- public AmazonS3ExceptionHandler()

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- protected virtual void HandleException(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.S3.Internal.AmazonS3KmsHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Constructors
- public AmazonS3KmsHandler()

#### Methods
- internal static void EvaluateIfSigV4Required(Amazon.Runtime.Internal.IRequest request)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- protected virtual void PreInvoke(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.S3.Internal.AmazonS3Metadata
- Interfaces: Amazon.Runtime.Internal.IServiceMetadata

#### Properties
- public System.Collections.Generic.IDictionary<string, string> OperationNameMapping { get; }
- public string ServiceId { get; }

#### Constructors
- public AmazonS3Metadata()

### public class Amazon.S3.Internal.AmazonS3PostMarshallHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Fields
- private static System.Text.RegularExpressions.Regex bucketValidationRegex
- private static System.Text.RegularExpressions.Regex dnsValidationRegex1
- private static System.Text.RegularExpressions.Regex dnsValidationRegex2
- private static string[] invalidPatterns
- private static char[] separators
- private static System.Collections.Generic.HashSet<string> sseKeyHeaders
- private static System.Collections.Generic.HashSet<System.Type> UnsupportedAccelerateRequestTypes

#### Constructors
- public AmazonS3PostMarshallHandler()
- private static AmazonS3PostMarshallHandler()

#### Methods
- public static bool BucketNameContainsPeriod(string bucketName)
- private static System.Uri GetAccelerateEndpoint(string bucketName, Amazon.S3.AmazonS3Config config)
- internal static string GetBucketName(string resourcePath)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- public static bool IsDnsCompatibleBucketName(string bucketName)
- public static bool IsValidBucketName(string bucketName)
- protected virtual void PreInvoke(Amazon.Runtime.IExecutionContext executionContext)
- public static void ProcessRequestHandlers(Amazon.Runtime.IExecutionContext executionContext)
- private static bool StringContainsAny(string toCheck, string[] values, System.StringComparison stringComparison)
- private static void ValidateHttpsOnlyHeaders(Amazon.Runtime.Internal.IRequest request)
- private static void ValidateSseHeaderValue(Amazon.Runtime.Internal.IRequest request)
- private static void ValidateSseKeyHeaders(Amazon.Runtime.Internal.IRequest request)

### public class Amazon.S3.Internal.AmazonS3PreMarshallHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Constructors
- public AmazonS3PreMarshallHandler()

#### Methods
- private static string DetermineBucketRegionCode(Amazon.Runtime.IClientConfig config)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- protected virtual void PreInvoke(Amazon.Runtime.IExecutionContext executionContext)
- private static void ProcessPreRequestHandlers(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.S3.Internal.AmazonS3RedirectHandler
- Base: Amazon.Runtime.Internal.RedirectHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Constructors
- public AmazonS3RedirectHandler()

#### Methods
- protected override void FinalizeForRedirect(Amazon.Runtime.IExecutionContext executionContext, string redirectedLocation)

### public class Amazon.S3.Internal.AmazonS3ResponseHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Fields
- private static char[] etagTrimChars

#### Constructors
- public AmazonS3ResponseHandler()
- private static AmazonS3ResponseHandler()

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- private static void CompareHashes(string etag, byte[] hash)
- private static bool HasSSEHeaders(Amazon.Runtime.Internal.Transform.IWebResponseData webResponseData)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- protected virtual void PostInvoke(Amazon.Runtime.IExecutionContext executionContext)
- private static void ProcessResponseHandlers(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.S3.Internal.AmazonS3RetryPolicy
- Base: Amazon.Runtime.Internal.DefaultRetryPolicy

#### Fields
- private static const string AWS_KMS_Signature_Error
- private static System.Collections.Generic.ICollection<System.Type> RequestsWith200Error

#### Constructors
- private static AmazonS3RetryPolicy()
- public AmazonS3RetryPolicy(Amazon.Runtime.IClientConfig config)

#### Methods
- private bool <>n__0(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)
- public override System.Threading.Tasks.Task<bool> RetryForExceptionAsync(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)
- public System.Nullable<bool> RetryForExceptionSync(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)

### internal interface Amazon.S3.Internal.IAmazonS3Encryption

### public class Amazon.S3.Internal.S3Signer
- Base: Amazon.Runtime.Internal.Auth.AbstractAWSSigner

#### Fields
- private readonly Amazon.Runtime.Internal.Auth.S3Signer _s3Signer

#### Properties
- public Amazon.Runtime.Internal.Auth.ClientProtocol Protocol { get; }

#### Constructors
- public S3Signer()

#### Methods
- private static void RegionDetectionUpdater(Amazon.Runtime.Internal.IRequest request)
- public override void Sign(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig clientConfig, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
- internal static void SignRequest(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)

## Namespace: Amazon.S3.Model

### private class Amazon.S3.Model.SelectObjectContentEventStream.<>c

#### Fields
- public static readonly Amazon.S3.Model.SelectObjectContentEventStream.<>c <>9
- public static System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, Amazon.S3.Model.IS3Event> <>9__32_3
- public static System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, Amazon.S3.Model.IS3Event> <>9__32_4
- public static System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, Amazon.S3.Model.IS3Event> <>9__32_5
- public static System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, Amazon.S3.Model.IS3Event> <>9__32_6
- public static System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, Amazon.S3.Model.IS3Event> <>9__32_7
- public static System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, Amazon.S3.Model.IS3Event> <>9__32_8

#### Constructors
- private static SelectObjectContentEventStream.<>c()
- public SelectObjectContentEventStream.<>c()

#### Methods
- internal Amazon.S3.Model.IS3Event <.ctor>b__32_3(Amazon.Runtime.EventStreams.IEventStreamMessage payload)
- internal Amazon.S3.Model.IS3Event <.ctor>b__32_4(Amazon.Runtime.EventStreams.IEventStreamMessage payload)
- internal Amazon.S3.Model.IS3Event <.ctor>b__32_5(Amazon.Runtime.EventStreams.IEventStreamMessage payload)
- internal Amazon.S3.Model.IS3Event <.ctor>b__32_6(Amazon.Runtime.EventStreams.IEventStreamMessage payload)
- internal Amazon.S3.Model.IS3Event <.ctor>b__32_7(Amazon.Runtime.EventStreams.IEventStreamMessage payload)
- internal Amazon.S3.Model.IS3Event <.ctor>b__32_8(Amazon.Runtime.EventStreams.IEventStreamMessage payload)

### private class Amazon.S3.Model.GetObjectResponse.<>c

#### Fields
- public static readonly Amazon.S3.Model.GetObjectResponse.<>c <>9
- public static System.Func<System.IO.Stream, bool> <>9__134_0

#### Constructors
- private static GetObjectResponse.<>c()
- public GetObjectResponse.<>c()

#### Methods
- internal bool <ValidateWrittenStreamSize>b__134_0(System.IO.Stream s)

### private struct Amazon.S3.Model.GetObjectResponse.<WriteResponseStreamToFileAsync>d__135
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Model.GetObjectResponse <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<int> <>u__2
- private byte[] <buffer>5__5
- private int <bytesRead>5__6
- private long <current>5__3
- private System.IO.Stream <downloadStream>5__2
- private System.IO.Stream <stream>5__4
- private long <totalIncrementTransferred>5__7
- public bool append
- public System.Threading.CancellationToken cancellationToken
- public string filePath

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class Amazon.S3.Model.AbortMultipartUploadRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string key
- private Amazon.S3.RequestPayer requestPayer
- private string uploadId

#### Properties
- public string BucketName { get; set; }
- public string Key { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public string UploadId { get; set; }

#### Constructors
- public AbortMultipartUploadRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetKey()
- internal bool IsSetRequestPayer()
- internal bool IsSetUploadId()

### public class Amazon.S3.Model.AbortMultipartUploadResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.RequestCharged requestCharged

#### Properties
- public Amazon.S3.RequestCharged RequestCharged { get; set; }

#### Constructors
- public AbortMultipartUploadResponse()

#### Methods
- internal bool IsSetRequestCharged()

### public class Amazon.S3.Model.AccelerateConfiguration

#### Fields
- private Amazon.S3.BucketAccelerateStatus status

#### Properties
- public Amazon.S3.BucketAccelerateStatus Status { get; set; }

#### Constructors
- public AccelerateConfiguration()

#### Methods
- internal bool IsSetBucketAccelerateStatus()

### public class Amazon.S3.Model.AccessControlTranslation

#### Fields
- private Amazon.S3.OwnerOverride owner

#### Properties
- public Amazon.S3.OwnerOverride Owner { get; set; }

#### Constructors
- public AccessControlTranslation()

#### Methods
- internal bool IsSetOwner()

### public class Amazon.S3.Model.AnalyticsAndOperator
- Base: Amazon.S3.Model.AnalyticsNAryOperator

#### Constructors
- public AnalyticsAndOperator(System.Collections.Generic.List<Amazon.S3.Model.AnalyticsFilterPredicate> operands)

#### Methods
- internal override void Accept(Amazon.S3.Model.Internal.IAnalyticsPredicateVisitor analyticsPredicateVisitor)

### public class Amazon.S3.Model.AnalyticsConfiguration

#### Fields
- private Amazon.S3.Model.AnalyticsFilter analyticsFilter
- private string analyticsId
- private Amazon.S3.Model.StorageClassAnalysis storageClassAnalysis

#### Properties
- public Amazon.S3.Model.AnalyticsFilter AnalyticsFilter { get; set; }
- public string AnalyticsId { get; set; }
- public Amazon.S3.Model.StorageClassAnalysis StorageClassAnalysis { get; set; }

#### Constructors
- public AnalyticsConfiguration()

#### Methods
- internal bool IsSetAnalyticsFilter()
- internal bool IsSetAnalyticsId()
- internal bool IsSetStorageClassAnalysis()

### public class Amazon.S3.Model.AnalyticsExportDestination

#### Fields
- private Amazon.S3.Model.AnalyticsS3BucketDestination analyticsS3BucketDestination

#### Properties
- public Amazon.S3.Model.AnalyticsS3BucketDestination S3BucketDestination { get; set; }

#### Constructors
- public AnalyticsExportDestination()

#### Methods
- internal bool IsSetS3BucketDestination()

### public class Amazon.S3.Model.AnalyticsFilter

#### Fields
- private Amazon.S3.Model.AnalyticsFilterPredicate analyticsFilterPredicate

#### Properties
- public Amazon.S3.Model.AnalyticsFilterPredicate AnalyticsFilterPredicate { get; set; }

#### Constructors
- public AnalyticsFilter()

### public class Amazon.S3.Model.AnalyticsFilterPredicate

#### Constructors
- protected AnalyticsFilterPredicate()

#### Methods
- internal abstract void Accept(Amazon.S3.Model.Internal.IAnalyticsPredicateVisitor analyticsPredicateVisitor)

### public class Amazon.S3.Model.AnalyticsNAryOperator
- Base: Amazon.S3.Model.AnalyticsFilterPredicate

#### Fields
- private readonly System.Collections.Generic.List<Amazon.S3.Model.AnalyticsFilterPredicate> operands

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.AnalyticsFilterPredicate> Operands { get; }

#### Constructors
- protected AnalyticsNAryOperator(System.Collections.Generic.List<Amazon.S3.Model.AnalyticsFilterPredicate> operands)

### public class Amazon.S3.Model.AnalyticsPrefixPredicate
- Base: Amazon.S3.Model.AnalyticsFilterPredicate

#### Fields
- private readonly string prefix

#### Properties
- public string Prefix { get; }

#### Constructors
- public AnalyticsPrefixPredicate(string prefix)

#### Methods
- internal override void Accept(Amazon.S3.Model.Internal.IAnalyticsPredicateVisitor analyticsPredicateVisitor)

### public class Amazon.S3.Model.AnalyticsS3BucketDestination

#### Fields
- private string accountId
- private Amazon.S3.AnalyticsS3ExportFileFormat analyticsS3ExportFileFormat
- private string bucketName
- private string prefix

#### Properties
- public string BucketAccountId { get; set; }
- public string BucketName { get; set; }
- public string Format { get; set; }
- public string Prefix { get; set; }

#### Constructors
- public AnalyticsS3BucketDestination()

#### Methods
- internal bool IsSetBucketAccountId()
- internal bool IsSetBucketName()
- internal bool IsSetFormat()
- internal bool IsSetPrefix()

### public class Amazon.S3.Model.AnalyticsTagPredicate
- Base: Amazon.S3.Model.AnalyticsFilterPredicate

#### Fields
- private readonly Amazon.S3.Model.Tag tag

#### Properties
- public Amazon.S3.Model.Tag Tag { get; }

#### Constructors
- public AnalyticsTagPredicate(Amazon.S3.Model.Tag tag)

#### Methods
- internal override void Accept(Amazon.S3.Model.Internal.IAnalyticsPredicateVisitor analyticsPredicateVisitor)

### public class Amazon.S3.Model.ByteRange

#### Fields
- private long <End>k__BackingField
- private long <Start>k__BackingField
- private string _formattedByteRange

#### Properties
- public long End { get; set; }
- public string FormattedByteRange { get; set; }
- public long Start { get; set; }

#### Constructors
- public ByteRange(string byteRangeValue)
- public ByteRange(long start, long end)

### public class Amazon.S3.Model.CompleteMultipartUploadRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string key
- private System.Collections.Generic.List<Amazon.S3.Model.PartETag> partETags
- private Amazon.S3.RequestPayer requestPayer
- private string uploadId

#### Properties
- public string BucketName { get; set; }
- public string Key { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.PartETag> PartETags { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public string UploadId { get; set; }

#### Constructors
- public CompleteMultipartUploadRequest()

#### Methods
- public void AddPartETags(params Amazon.S3.Model.PartETag[] partETags)
- public void AddPartETags(System.Collections.Generic.IEnumerable<Amazon.S3.Model.PartETag> partETags)
- public void AddPartETags(params Amazon.S3.Model.UploadPartResponse[] responses)
- public void AddPartETags(System.Collections.Generic.IEnumerable<Amazon.S3.Model.UploadPartResponse> responses)
- public void AddPartETags(params Amazon.S3.Model.CopyPartResponse[] responses)
- public void AddPartETags(System.Collections.Generic.IEnumerable<Amazon.S3.Model.CopyPartResponse> responses)
- internal bool IsSetBucketName()
- internal bool IsSetKey()
- internal bool IsSetRequestPayer()
- internal bool IsSetUploadId()

### public class Amazon.S3.Model.CompleteMultipartUploadResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string bucketName
- private string eTag
- private Amazon.S3.Model.Expiration expiration
- private string key
- private string location
- private Amazon.S3.RequestCharged requestCharged
- private Amazon.S3.ServerSideEncryptionMethod serverSideEncryption
- private string serverSideEncryptionKeyManagementServiceKeyId
- private string versionId

#### Properties
- public string BucketName { get; set; }
- public string ETag { get; set; }
- public Amazon.S3.Model.Expiration Expiration { get; set; }
- public string Key { get; set; }
- public string Location { get; set; }
- public Amazon.S3.RequestCharged RequestCharged { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public CompleteMultipartUploadResponse()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetETag()
- internal bool IsSetKey()
- internal bool IsSetLocation()
- internal bool IsSetRequestCharged()
- internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.ContinuationEvent
- Interfaces: Amazon.S3.Model.IS3Event, Amazon.Runtime.EventStreams.Internal.IEventStreamEvent

#### Constructors
- public ContinuationEvent()
- public ContinuationEvent(Amazon.Runtime.EventStreams.IEventStreamMessage message)

### public class Amazon.S3.Model.CopyObjectRequest
- Base: Amazon.S3.Model.PutWithACLRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private Amazon.S3.S3CannedACL cannedACL
- private Amazon.S3.ServerSideEncryptionCustomerMethod copySourceServerSideCustomerEncryption
- private string copySourceServerSideEncryptionCustomerProvidedKey
- private string copySourceServerSideEncryptionCustomerProvidedKeyMD5
- private string dstBucket
- private string dstKey
- private string etagToMatch
- private string etagToNotMatch
- private Amazon.S3.Model.HeadersCollection headersCollection
- private Amazon.S3.Model.MetadataCollection metadataCollection
- private Amazon.S3.S3MetadataDirective metadataDirective
- private System.Nullable<System.DateTime> modifiedSinceDate
- private System.Nullable<System.DateTime> modifiedSinceDateUtc
- private Amazon.S3.ObjectLockLegalHoldStatus objectLockLegalHoldStatus
- private Amazon.S3.ObjectLockMode objectLockMode
- private System.Nullable<System.DateTime> objectLockRetainUntilDate
- private Amazon.S3.RequestPayer requestPayer
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideCustomerEncryption
- private Amazon.S3.ServerSideEncryptionMethod serverSideEncryption
- private string serverSideEncryptionCustomerProvidedKey
- private string serverSideEncryptionCustomerProvidedKeyMD5
- private string serverSideEncryptionKeyManagementServiceEncryptionContext
- private string serverSideEncryptionKeyManagementServiceKeyId
- private string srcBucket
- private string srcKey
- private string srcVersionId
- private Amazon.S3.S3StorageClass storageClass
- private System.Collections.Generic.List<Amazon.S3.Model.Tag> tagset
- private System.Nullable<System.DateTime> unmodifiedSinceDate
- private System.Nullable<System.DateTime> unmodifiedSinceDateUtc
- private string websiteRedirectLocation

#### Properties
- public Amazon.S3.S3CannedACL CannedACL { get; set; }
- public string ContentType { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod CopySourceServerSideEncryptionCustomerMethod { get; set; }
- public string CopySourceServerSideEncryptionCustomerProvidedKey { get; set; }
- public string CopySourceServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }
- public string DestinationBucket { get; set; }
- public string DestinationKey { get; set; }
- public string ETagToMatch { get; set; }
- public string ETagToNotMatch { get; set; }
- public Amazon.S3.Model.HeadersCollection Headers { get; }
- public Amazon.S3.Model.MetadataCollection Metadata { get; }
- public Amazon.S3.S3MetadataDirective MetadataDirective { get; set; }
- public System.DateTime ModifiedSinceDate { get; set; }
- public System.DateTime ModifiedSinceDateUtc { get; set; }
- public Amazon.S3.ObjectLockLegalHoldStatus ObjectLockLegalHoldStatus { get; set; }
- public Amazon.S3.ObjectLockMode ObjectLockMode { get; set; }
- public System.DateTime ObjectLockRetainUntilDate { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionCustomerProvidedKey { get; set; }
- public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }
- public string ServerSideEncryptionKeyManagementServiceEncryptionContext { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }
- public string SourceBucket { get; set; }
- public string SourceKey { get; set; }
- public string SourceVersionId { get; set; }
- public Amazon.S3.S3StorageClass StorageClass { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.Tag> TagSet { get; set; }
- public System.DateTime UnmodifiedSinceDate { get; set; }
- public System.DateTime UnmodifiedSinceDateUtc { get; set; }
- public string WebsiteRedirectLocation { get; set; }

#### Constructors
- public CopyObjectRequest()

#### Methods
- internal bool IsSetCannedACL()
- internal bool IsSetCopySourceServerSideEncryptionCustomerMethod()
- internal bool IsSetCopySourceServerSideEncryptionCustomerProvidedKey()
- internal bool IsSetCopySourceServerSideEncryptionCustomerProvidedKeyMD5()
- internal bool IsSetDestinationBucket()
- internal bool IsSetDestinationKey()
- internal bool IsSetETagToMatch()
- internal bool IsSetETagToNotMatch()
- internal bool IsSetModifiedSinceDateUtc()
- internal bool IsSetObjectLockLegalHoldStatus()
- internal bool IsSetObjectLockMode()
- internal bool IsSetObjectLockRetainUntilDate()
- internal bool IsSetRequestPayer()
- internal bool IsSetServerSideEncryptionCustomerMethod()
- internal bool IsSetServerSideEncryptionCustomerProvidedKey()
- internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
- internal bool IsSetServerSideEncryptionKeyManagementServiceEncryptionContext()
- internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
- internal bool IsSetServerSideEncryptionMethod()
- internal bool IsSetSourceBucket()
- internal bool IsSetSourceKey()
- internal bool IsSetSourceVersionId()
- internal bool IsSetStorageClass()
- internal bool IsSetTagSet()
- internal bool IsSetUnmodifiedSinceDateUtc()
- internal bool IsSetWebsiteRedirectLocation()

### public class Amazon.S3.Model.CopyObjectResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string eTag
- private Amazon.S3.Model.Expiration expiration
- private string lastModified
- private Amazon.S3.RequestCharged requestCharged
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideCustomerEncryption
- private Amazon.S3.ServerSideEncryptionMethod serverSideEncryption
- private string serverSideEncryptionCustomerProvidedKeyMD5
- private string serverSideEncryptionKeyManagementServiceEncryptionContext
- private string serverSideEncryptionKeyManagementServiceKeyId
- private string srcVersionId
- private string versionId

#### Properties
- public string ETag { get; set; }
- public Amazon.S3.Model.Expiration Expiration { get; set; }
- public string LastModified { get; set; }
- public Amazon.S3.RequestCharged RequestCharged { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }
- public string ServerSideEncryptionKeyManagementServiceEncryptionContext { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }
- public string SourceVersionId { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public CopyObjectResponse()

#### Methods
- internal bool IsSetRequestCharged()

### public class Amazon.S3.Model.CopyPartRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private Amazon.S3.ServerSideEncryptionCustomerMethod copySourceServerSideCustomerEncryption
- private string copySourceServerSideEncryptionCustomerProvidedKey
- private string copySourceServerSideEncryptionCustomerProvidedKeyMD5
- private string dstBucket
- private string dstKey
- private System.Collections.Generic.List<string> etagsToMatch
- private System.Collections.Generic.List<string> etagsToNotMatch
- private System.Nullable<long> firstByte
- private System.Nullable<long> lastByte
- private System.Nullable<System.DateTime> modifiedSinceDate
- private System.Nullable<int> partNumber
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideCustomerEncryption
- private Amazon.S3.ServerSideEncryptionMethod serverSideEncryption
- private string serverSideEncryptionCustomerProvidedKey
- private string serverSideEncryptionCustomerProvidedKeyMD5
- private string serverSideEncryptionKeyManagementServiceKeyId
- private string srcBucket
- private string srcKey
- private string srcVersionId
- private System.Nullable<System.DateTime> unmodifiedSinceDate
- private string uploadId

#### Properties
- public Amazon.S3.ServerSideEncryptionCustomerMethod CopySourceServerSideEncryptionCustomerMethod { get; set; }
- public string CopySourceServerSideEncryptionCustomerProvidedKey { get; set; }
- public string CopySourceServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }
- public string DestinationBucket { get; set; }
- public string DestinationKey { get; set; }
- public System.Collections.Generic.List<string> ETagsToNotMatch { get; set; }
- public System.Collections.Generic.List<string> ETagToMatch { get; set; }
- public long FirstByte { get; set; }
- public long LastByte { get; set; }
- public System.DateTime ModifiedSinceDate { get; set; }
- public int PartNumber { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionCustomerProvidedKey { get; set; }
- public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }
- public string SourceBucket { get; set; }
- public string SourceKey { get; set; }
- public string SourceVersionId { get; set; }
- public System.DateTime UnmodifiedSinceDate { get; set; }
- public string UploadId { get; set; }

#### Constructors
- public CopyPartRequest()

#### Methods
- internal bool IsSetCopySourceServerSideEncryptionCustomerMethod()
- internal bool IsSetCopySourceServerSideEncryptionCustomerProvidedKey()
- internal bool IsSetCopySourceServerSideEncryptionCustomerProvidedKeyMD5()
- internal bool IsSetDestinationBucket()
- internal bool IsSetDestinationKey()
- internal bool IsSetETagToMatch()
- internal bool IsSetETagToNotMatch()
- internal bool IsSetFirstByte()
- internal bool IsSetLastByte()
- internal bool IsSetModifiedSinceDate()
- internal bool IsSetPartNumber()
- internal bool IsSetServerSideEncryptionCustomerMethod()
- internal bool IsSetServerSideEncryptionCustomerProvidedKey()
- internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
- internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
- internal bool IsSetServerSideEncryptionMethod()
- internal bool IsSetSourceBucket()
- internal bool IsSetSourceKey()
- internal bool IsSetSourceVersionId()
- internal bool IsSetUnmodifiedSinceDate()
- internal bool IsSetUploadId()

### public class Amazon.S3.Model.CopyPartResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string copySourceVersionId
- private string eTag
- private System.Nullable<System.DateTime> lastModified
- private int partNumber
- private Amazon.S3.ServerSideEncryptionMethod serverSideEncryption
- private string serverSideEncryptionKeyManagementServiceKeyId

#### Properties
- public string CopySourceVersionId { get; set; }
- public string ETag { get; set; }
- public System.DateTime LastModified { get; set; }
- public int PartNumber { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }

#### Constructors
- public CopyPartResponse()

#### Methods
- internal bool IsSetCopySourceVersionId()
- internal bool IsSetETag()
- internal bool IsSetLastModified()
- internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
- internal bool IsSetServerSideEncryptionMethod()

### public class Amazon.S3.Model.CORSConfiguration

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Model.CORSRule> rules

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.CORSRule> Rules { get; set; }

#### Constructors
- public CORSConfiguration()

#### Methods
- internal bool IsSetRules()

### public class Amazon.S3.Model.CORSRule

#### Fields
- private System.Collections.Generic.List<string> allowedHeaders
- private System.Collections.Generic.List<string> allowedMethods
- private System.Collections.Generic.List<string> allowedOrigins
- private System.Collections.Generic.List<string> exposeHeaders
- private string id
- private System.Nullable<int> maxAgeSeconds

#### Properties
- public System.Collections.Generic.List<string> AllowedHeaders { get; set; }
- public System.Collections.Generic.List<string> AllowedMethods { get; set; }
- public System.Collections.Generic.List<string> AllowedOrigins { get; set; }
- public System.Collections.Generic.List<string> ExposeHeaders { get; set; }
- public string Id { get; set; }
- public int MaxAgeSeconds { get; set; }

#### Constructors
- public CORSRule()

#### Methods
- internal bool IsSetAllowedHeaders()
- internal bool IsSetAllowedMethods()
- internal bool IsSetAllowedOrigins()
- internal bool IsSetExposeHeaders()
- internal bool IsSetId()
- internal bool IsSetMaxAgeSeconds()

### public class Amazon.S3.Model.CSVInput

#### Fields
- private string <Comments>k__BackingField
- private string <FieldDelimiter>k__BackingField
- private Amazon.S3.FileHeaderInfo <FileHeaderInfo>k__BackingField
- private string <QuoteCharacter>k__BackingField
- private string <QuoteEscapeCharacter>k__BackingField
- private string <RecordDelimiter>k__BackingField
- private System.Nullable<bool> _allowQuotedRecordDelimiter

#### Properties
- public bool AllowQuotedRecordDelimiter { get; set; }
- public string Comments { get; set; }
- public string FieldDelimiter { get; set; }
- public Amazon.S3.FileHeaderInfo FileHeaderInfo { get; set; }
- public string QuoteCharacter { get; set; }
- public string QuoteEscapeCharacter { get; set; }
- public string RecordDelimiter { get; set; }

#### Constructors
- public CSVInput()

#### Methods
- internal bool IsSetAllowQuotedRecordDelimiter()
- internal bool IsSetComments()
- internal bool IsSetFieldDelimiter()
- internal bool IsSetFileHeaderInfo()
- internal bool IsSetQuoteCharacter()
- internal bool IsSetQuoteEscapeCharacter()
- internal bool IsSetRecordDelimiter()
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.CSVOutput

#### Fields
- private string <FieldDelimiter>k__BackingField
- private string <QuoteCharacter>k__BackingField
- private string <QuoteEscapeCharacter>k__BackingField
- private Amazon.S3.QuoteFields <QuoteFields>k__BackingField
- private string <RecordDelimiter>k__BackingField

#### Properties
- public string FieldDelimiter { get; set; }
- public string QuoteCharacter { get; set; }
- public string QuoteEscapeCharacter { get; set; }
- public Amazon.S3.QuoteFields QuoteFields { get; set; }
- public string RecordDelimiter { get; set; }

#### Constructors
- public CSVOutput()

#### Methods
- internal bool IsSetFieldDelimiter()
- internal bool IsSetQuoteCharacter()
- internal bool IsSetQuoteEscapeCharacter()
- internal bool IsSetQuoteFields()
- internal bool IsSetRecordDelimiter()
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.DefaultRetention

#### Fields
- private System.Nullable<int> _days
- private Amazon.S3.ObjectLockRetentionMode _mode
- private System.Nullable<int> _years

#### Properties
- public int Days { get; set; }
- public Amazon.S3.ObjectLockRetentionMode Mode { get; set; }
- public int Years { get; set; }

#### Constructors
- public DefaultRetention()

#### Methods
- internal bool IsSetDays()
- internal bool IsSetMode()
- internal bool IsSetYears()

### public class Amazon.S3.Model.DeleteBucketAnalyticsConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string analyticsId
- private string bucketName

#### Properties
- public string AnalyticsId { get; set; }
- public string BucketName { get; set; }

#### Constructors
- public DeleteBucketAnalyticsConfigurationRequest()

#### Methods
- internal bool IsSetAnalyticsId()
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.DeleteBucketAnalyticsConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public DeleteBucketAnalyticsConfigurationResponse()

### public class Amazon.S3.Model.DeleteBucketEncryptionRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public DeleteBucketEncryptionRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.DeleteBucketEncryptionResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public DeleteBucketEncryptionResponse()

### public class Amazon.S3.Model.DeleteBucketInventoryConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string inventoryId

#### Properties
- public string BucketName { get; set; }
- public string InventoryId { get; set; }

#### Constructors
- public DeleteBucketInventoryConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetInventoryId()

### public class Amazon.S3.Model.DeleteBucketInventoryConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public DeleteBucketInventoryConfigurationResponse()

### public class Amazon.S3.Model.DeleteBucketMetricsConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string metricsId

#### Properties
- public string BucketName { get; set; }
- public string MetricsId { get; set; }

#### Constructors
- public DeleteBucketMetricsConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetMetricsId()

### public class Amazon.S3.Model.DeleteBucketMetricsConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public DeleteBucketMetricsConfigurationResponse()

### public class Amazon.S3.Model.DeleteBucketPolicyRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public DeleteBucketPolicyRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.DeleteBucketPolicyResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public DeleteBucketPolicyResponse()

### public class Amazon.S3.Model.DeleteBucketReplicationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public DeleteBucketReplicationRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.DeleteBucketReplicationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public DeleteBucketReplicationResponse()

### public class Amazon.S3.Model.DeleteBucketRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private Amazon.S3.S3Region bucketRegion
- private bool useClientRegion

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.S3Region BucketRegion { get; set; }
- public bool UseClientRegion { get; set; }

#### Constructors
- public DeleteBucketRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetBucketRegion()

### public class Amazon.S3.Model.DeleteBucketResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public DeleteBucketResponse()

### public class Amazon.S3.Model.DeleteBucketTaggingRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public DeleteBucketTaggingRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.DeleteBucketTaggingResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public DeleteBucketTaggingResponse()

### public class Amazon.S3.Model.DeleteBucketWebsiteRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public DeleteBucketWebsiteRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.DeleteBucketWebsiteResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public DeleteBucketWebsiteResponse()

### public class Amazon.S3.Model.DeleteCORSConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public DeleteCORSConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.DeleteCORSConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public DeleteCORSConfigurationResponse()

### public class Amazon.S3.Model.DeletedObject

#### Fields
- private System.Nullable<bool> deleteMarker
- private string deleteMarkerVersionId
- private string key
- private string versionId

#### Properties
- public bool DeleteMarker { get; set; }
- public string DeleteMarkerVersionId { get; set; }
- public string Key { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public DeletedObject()

#### Methods
- internal bool IsSetDeleteMarker()
- internal bool IsSetDeleteMarkerVersionId()
- internal bool IsSetKey()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.DeleteError

#### Fields
- private string code
- private string key
- private string message
- private string versionId

#### Properties
- public string Code { get; set; }
- public string Key { get; set; }
- public string Message { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public DeleteError()

### public class Amazon.S3.Model.DeleteLifecycleConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public DeleteLifecycleConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.DeleteLifecycleConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public DeleteLifecycleConfigurationResponse()

### public class Amazon.S3.Model.DeleteMarkerReplication

#### Fields
- private Amazon.S3.DeleteMarkerReplicationStatus status

#### Properties
- public Amazon.S3.DeleteMarkerReplicationStatus Status { get; set; }

#### Constructors
- public DeleteMarkerReplication()

#### Methods
- internal bool IsSetStatus()

### public class Amazon.S3.Model.DeleteObjectRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private System.Nullable<bool> bypassGovernanceRetention
- private string key
- private Amazon.S3.Model.MfaCodes mfaCodes
- private Amazon.S3.RequestPayer requestPayer
- private string versionId

#### Properties
- public string BucketName { get; set; }
- public bool BypassGovernanceRetention { get; set; }
- public string Key { get; set; }
- public Amazon.S3.Model.MfaCodes MfaCodes { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public DeleteObjectRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetBypassGovernanceRetention()
- internal bool IsSetKey()
- internal bool IsSetMfaCodes()
- internal bool IsSetRequestPayer()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.DeleteObjectResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string deleteMarker
- private Amazon.S3.RequestCharged requestCharged
- private string versionId

#### Properties
- public string DeleteMarker { get; set; }
- public Amazon.S3.RequestCharged RequestCharged { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public DeleteObjectResponse()

#### Methods
- internal bool IsSetDeleteMarker()
- internal bool IsSetRequestCharged()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.DeleteObjectsRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private System.Nullable<bool> bypassGovernanceRetention
- private Amazon.S3.Model.MfaCodes mfaCodes
- private System.Collections.Generic.List<Amazon.S3.Model.KeyVersion> objects
- private System.Nullable<bool> quiet
- private Amazon.S3.RequestPayer requestPayer

#### Properties
- public string BucketName { get; set; }
- public bool BypassGovernanceRetention { get; set; }
- public Amazon.S3.Model.MfaCodes MfaCodes { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.KeyVersion> Objects { get; set; }
- public bool Quiet { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }

#### Constructors
- public DeleteObjectsRequest()

#### Methods
- public void AddKey(string key)
- public void AddKey(string key, string version)
- private void AddKey(Amazon.S3.Model.KeyVersion keyVersion)
- internal bool IsSetBucketName()
- internal bool IsSetBypassGovernanceRetention()
- internal bool IsSetMfaCodes()
- internal bool IsSetObjects()
- internal bool IsSetQuiet()
- internal bool IsSetRequestPayer()

### public class Amazon.S3.Model.DeleteObjectsResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Model.DeletedObject> deleted
- private System.Collections.Generic.List<Amazon.S3.Model.DeleteError> errors
- private Amazon.S3.RequestCharged requestCharged

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.DeletedObject> DeletedObjects { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.DeleteError> DeleteErrors { get; set; }
- public Amazon.S3.RequestCharged RequestCharged { get; set; }

#### Constructors
- public DeleteObjectsResponse()

#### Methods
- internal bool IsSetDeletedObjects()
- internal bool IsSetDeleteErrors()
- internal bool IsSetRequestCharged()

### public class Amazon.S3.Model.DeleteObjectTaggingRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string key
- private string versionId

#### Properties
- public string BucketName { get; set; }
- public string Key { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public DeleteObjectTaggingRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetKey()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.DeleteObjectTaggingResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string versionId

#### Properties
- public string VersionId { get; set; }

#### Constructors
- public DeleteObjectTaggingResponse()

#### Methods
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.DeletePublicAccessBlockRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public DeletePublicAccessBlockRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.DeletePublicAccessBlockResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public DeletePublicAccessBlockResponse()

### public class Amazon.S3.Model.EncryptionConfiguration

#### Fields
- private string replicaKmsKeyID

#### Properties
- public string ReplicaKmsKeyID { get; set; }

#### Constructors
- public EncryptionConfiguration()

#### Methods
- internal bool isSetReplicaKmsKeyID()

### public class Amazon.S3.Model.EndEvent
- Interfaces: Amazon.S3.Model.IS3Event, Amazon.Runtime.EventStreams.Internal.IEventStreamEvent, Amazon.Runtime.EventStreams.Internal.IEventStreamTerminalEvent

#### Constructors
- public EndEvent()
- public EndEvent(Amazon.Runtime.EventStreams.IEventStreamMessage message)

### public class Amazon.S3.Model.Expiration

#### Fields
- private System.DateTime expiryDate
- private System.DateTime expiryDateUtc
- private static System.Text.RegularExpressions.Regex expiryRegex
- private string ruleId
- private static System.Text.RegularExpressions.Regex ruleRegex

#### Properties
- public System.DateTime ExpiryDate { get; set; }
- public System.DateTime ExpiryDateUtc { get; set; }
- public string RuleId { get; set; }

#### Constructors
- public Expiration()
- private static Expiration()
- internal Expiration(string headerValue)

#### Methods
- private static string UrlDecode(string url)

### public class Amazon.S3.Model.Filter

#### Fields
- private Amazon.S3.Model.S3KeyFilter s3KeyFilter

#### Properties
- public Amazon.S3.Model.S3KeyFilter S3KeyFilter { get; set; }

#### Constructors
- public Filter()

#### Methods
- internal bool IsSetS3KeyFilter()

### public class Amazon.S3.Model.FilterRule

#### Fields
- private string _name
- private string _value

#### Properties
- public string Name { get; set; }
- public string Value { get; set; }

#### Constructors
- public FilterRule()
- public FilterRule(string name, string value)

#### Methods
- internal bool IsSetName()
- internal bool IsSetValue()

### public class Amazon.S3.Model.GetACLRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string <BucketName>k__BackingField
- private string <Key>k__BackingField
- private string <VersionId>k__BackingField

#### Properties
- public string BucketName { get; set; }
- public string Key { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public GetACLRequest()

#### Methods
- internal bool IsSetBucket()
- internal bool IsSetKey()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.GetACLResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.S3AccessControlList <AccessControlList>k__BackingField

#### Properties
- public Amazon.S3.Model.S3AccessControlList AccessControlList { get; set; }

#### Constructors
- public GetACLResponse()

### public class Amazon.S3.Model.GetBucketAccelerateConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetBucketAccelerateConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetBucketAccelerateConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.BucketAccelerateStatus status

#### Properties
- public Amazon.S3.BucketAccelerateStatus Status { get; set; }

#### Constructors
- public GetBucketAccelerateConfigurationResponse()

### public class Amazon.S3.Model.GetBucketAnalyticsConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string analyticsId
- private string bucketName

#### Properties
- public string AnalyticsId { get; set; }
- public string BucketName { get; set; }

#### Constructors
- public GetBucketAnalyticsConfigurationRequest()

#### Methods
- internal bool IsSetAnalyticsId()
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetBucketAnalyticsConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.AnalyticsConfiguration analyticsConfiguration

#### Properties
- public Amazon.S3.Model.AnalyticsConfiguration AnalyticsConfiguration { get; set; }

#### Constructors
- public GetBucketAnalyticsConfigurationResponse()

#### Methods
- internal bool IsSetAnalyticsConfiguration()

### public class Amazon.S3.Model.GetBucketEncryptionRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetBucketEncryptionRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetBucketEncryptionResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.ServerSideEncryptionConfiguration serverSideEncryptionConfiguration

#### Properties
- public Amazon.S3.Model.ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration { get; set; }

#### Constructors
- public GetBucketEncryptionResponse()

#### Methods
- internal bool IsSetServerSideEncryptionConfiguration()

### public class Amazon.S3.Model.GetBucketInventoryConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string inventoryId

#### Properties
- public string BucketName { get; set; }
- public string InventoryId { get; set; }

#### Constructors
- public GetBucketInventoryConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetInventoryId()

### public class Amazon.S3.Model.GetBucketInventoryConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.InventoryConfiguration inventoryConfiguration

#### Properties
- public Amazon.S3.Model.InventoryConfiguration InventoryConfiguration { get; set; }

#### Constructors
- public GetBucketInventoryConfigurationResponse()

#### Methods
- internal bool IsSetInventoryConfiguration()

### public class Amazon.S3.Model.GetBucketLocationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string <BucketName>k__BackingField

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetBucketLocationRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetBucketLocationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string location

#### Properties
- public Amazon.S3.S3Region Location { get; set; }

#### Constructors
- public GetBucketLocationResponse()

### public class Amazon.S3.Model.GetBucketLoggingRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetBucketLoggingRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetBucketLoggingResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.S3BucketLoggingConfig bucketLoggingConfig

#### Properties
- public Amazon.S3.Model.S3BucketLoggingConfig BucketLoggingConfig { get; set; }

#### Constructors
- public GetBucketLoggingResponse()

### public class Amazon.S3.Model.GetBucketMetricsConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string metricsId

#### Properties
- public string BucketName { get; set; }
- public string MetricsId { get; set; }

#### Constructors
- public GetBucketMetricsConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetMetricsId()

### public class Amazon.S3.Model.GetBucketMetricsConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.MetricsConfiguration metricsConfiguration

#### Properties
- public Amazon.S3.Model.MetricsConfiguration MetricsConfiguration { get; set; }

#### Constructors
- public GetBucketMetricsConfigurationResponse()

#### Methods
- internal bool IsSetMetricsConfiguration()

### public class Amazon.S3.Model.GetBucketNotificationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucket

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetBucketNotificationRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetBucketNotificationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Model.LambdaFunctionConfiguration> _lambdaFunctionConfigurations
- private System.Collections.Generic.List<Amazon.S3.Model.QueueConfiguration> _queueConfigurations
- private System.Collections.Generic.List<Amazon.S3.Model.TopicConfiguration> _topicConfigurations

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.LambdaFunctionConfiguration> LambdaFunctionConfigurations { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.QueueConfiguration> QueueConfigurations { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.TopicConfiguration> TopicConfigurations { get; set; }

#### Constructors
- public GetBucketNotificationResponse()

### public class Amazon.S3.Model.GetBucketPolicyRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string <BucketName>k__BackingField

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetBucketPolicyRequest()

#### Methods
- internal bool IsSetBucket()

### public class Amazon.S3.Model.GetBucketPolicyResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string <Policy>k__BackingField

#### Properties
- public string Policy { get; set; }

#### Constructors
- public GetBucketPolicyResponse()

#### Methods
- internal bool IsSetPolicy()

### public class Amazon.S3.Model.GetBucketPolicyStatusRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetBucketPolicyStatusRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetBucketPolicyStatusResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.PolicyStatus policyStatus

#### Properties
- public Amazon.S3.Model.PolicyStatus PolicyStatus { get; set; }

#### Constructors
- public GetBucketPolicyStatusResponse()

#### Methods
- internal bool IsSetPolicyStatus()

### public class Amazon.S3.Model.GetBucketReplicationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetBucketReplicationRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetBucketReplicationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.ReplicationConfiguration configuration

#### Properties
- public Amazon.S3.Model.ReplicationConfiguration Configuration { get; set; }

#### Constructors
- public GetBucketReplicationResponse()

### public class Amazon.S3.Model.GetBucketRequestPaymentRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetBucketRequestPaymentRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetBucketRequestPaymentResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string payer

#### Properties
- public string Payer { get; set; }

#### Constructors
- public GetBucketRequestPaymentResponse()

#### Methods
- internal bool IsSetPayer()

### public class Amazon.S3.Model.GetBucketTaggingRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetBucketTaggingRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetBucketTaggingResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Model.Tag> tagSet

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.Tag> TagSet { get; set; }

#### Constructors
- public GetBucketTaggingResponse()

#### Methods
- internal bool IsSetTagSet()

### public class Amazon.S3.Model.GetBucketVersioningRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetBucketVersioningRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetBucketVersioningResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.S3BucketVersioningConfig config

#### Properties
- public Amazon.S3.Model.S3BucketVersioningConfig VersioningConfig { get; set; }

#### Constructors
- public GetBucketVersioningResponse()

### public class Amazon.S3.Model.GetBucketWebsiteRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetBucketWebsiteRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetBucketWebsiteResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.WebsiteConfiguration websiteConfiguration

#### Properties
- public Amazon.S3.Model.WebsiteConfiguration WebsiteConfiguration { get; set; }

#### Constructors
- public GetBucketWebsiteResponse()

### public class Amazon.S3.Model.GetCORSConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetCORSConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetCORSConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.CORSConfiguration configuration

#### Properties
- public Amazon.S3.Model.CORSConfiguration Configuration { get; set; }

#### Constructors
- public GetCORSConfigurationResponse()

#### Methods
- internal bool IsSetConfiguration()

### public class Amazon.S3.Model.GetLifecycleConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetLifecycleConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetLifecycleConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.LifecycleConfiguration configuration

#### Properties
- public Amazon.S3.Model.LifecycleConfiguration Configuration { get; set; }

#### Constructors
- public GetLifecycleConfigurationResponse()

### public class Amazon.S3.Model.GetObjectLegalHoldRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _bucketName
- private string _key
- private Amazon.S3.RequestPayer _requestPayer
- private string _versionId

#### Properties
- public string BucketName { get; set; }
- public string Key { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public GetObjectLegalHoldRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetKey()
- internal bool IsSetRequestPayer()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.GetObjectLegalHoldResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.ObjectLockLegalHold _legalHold

#### Properties
- public Amazon.S3.Model.ObjectLockLegalHold LegalHold { get; set; }

#### Constructors
- public GetObjectLegalHoldResponse()

#### Methods
- internal bool IsSetLegalHold()

### public class Amazon.S3.Model.GetObjectLockConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetObjectLockConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetObjectLockConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.ObjectLockConfiguration _objectLockConfiguration

#### Properties
- public Amazon.S3.Model.ObjectLockConfiguration ObjectLockConfiguration { get; set; }

#### Constructors
- public GetObjectLockConfigurationResponse()

#### Methods
- internal bool IsSetObjectLockConfiguration()

### public class Amazon.S3.Model.GetObjectMetadataRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string etagToMatch
- private string etagToNotMatch
- private string key
- private System.Nullable<System.DateTime> modifiedSinceDate
- private System.Nullable<System.DateTime> modifiedSinceDateUtc
- private System.Nullable<int> partNumber
- private Amazon.S3.RequestPayer requestPayer
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideCustomerEncryption
- private string serverSideEncryptionCustomerProvidedKey
- private string serverSideEncryptionCustomerProvidedKeyMD5
- private System.Nullable<System.DateTime> unmodifiedSinceDate
- private System.Nullable<System.DateTime> unmodifiedSinceDateUtc
- private string versionId

#### Properties
- public string BucketName { get; set; }
- public string EtagToMatch { get; set; }
- public string EtagToNotMatch { get; set; }
- public string Key { get; set; }
- public System.DateTime ModifiedSinceDate { get; set; }
- public System.DateTime ModifiedSinceDateUtc { get; set; }
- public System.Nullable<int> PartNumber { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionCustomerProvidedKey { get; set; }
- public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }
- public System.DateTime UnmodifiedSinceDate { get; set; }
- public System.DateTime UnmodifiedSinceDateUtc { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public GetObjectMetadataRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetEtagToMatch()
- internal bool IsSetEtagToNotMatch()
- internal bool IsSetKey()
- internal bool IsSetModifiedSinceDateUtc()
- internal bool IsSetPartNumber()
- internal bool IsSetRequestPayer()
- internal bool IsSetServerSideEncryptionCustomerMethod()
- internal bool IsSetServerSideEncryptionCustomerProvidedKey()
- internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
- internal bool IsSetUnmodifiedSinceDateUtc()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.GetObjectMetadataResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string <RawExpires>k__BackingField
- private string acceptRanges
- private string contentRange
- private string deleteMarker
- private string eTag
- private Amazon.S3.Model.Expiration expiration
- private System.Nullable<System.DateTime> expires
- private Amazon.S3.Model.HeadersCollection headersCollection
- private bool isExpiresUnmarshalled
- private System.Nullable<System.DateTime> lastModified
- private Amazon.S3.Model.MetadataCollection metadataCollection
- private System.Nullable<int> missingMeta
- private Amazon.S3.ObjectLockLegalHoldStatus objectLockLegalHoldStatus
- private Amazon.S3.ObjectLockMode objectLockMode
- private System.Nullable<System.DateTime> objectLockRetainUntilDate
- private System.Nullable<int> partsCount
- private Amazon.S3.ReplicationStatus replicationStatus
- private Amazon.S3.RequestCharged requestCharged
- private System.Nullable<System.DateTime> restoreExpiration
- private bool restoreInProgress
- private Amazon.S3.ServerSideEncryptionMethod serverSideEncryption
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideEncryptionCustomerMethod
- private string serverSideEncryptionKeyManagementServiceKeyId
- private Amazon.S3.S3StorageClass storageClass
- private string versionId
- private string websiteRedirectLocation

#### Properties
- public string AcceptRanges { get; set; }
- public string ContentRange { get; set; }
- public string DeleteMarker { get; set; }
- public string ETag { get; set; }
- public Amazon.S3.Model.Expiration Expiration { get; set; }
- public System.DateTime Expires { get; set; }
- public Amazon.S3.Model.HeadersCollection Headers { get; }
- public System.DateTime LastModified { get; set; }
- public Amazon.S3.Model.MetadataCollection Metadata { get; }
- public int MissingMeta { get; set; }
- public Amazon.S3.ObjectLockLegalHoldStatus ObjectLockLegalHoldStatus { get; set; }
- public Amazon.S3.ObjectLockMode ObjectLockMode { get; set; }
- public System.DateTime ObjectLockRetainUntilDate { get; set; }
- public System.Nullable<int> PartsCount { get; set; }
- internal string RawExpires { get; set; }
- public Amazon.S3.ReplicationStatus ReplicationStatus { get; set; }
- public Amazon.S3.RequestCharged RequestCharged { get; set; }
- public System.Nullable<System.DateTime> RestoreExpiration { get; set; }
- public bool RestoreInProgress { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }
- public Amazon.S3.S3StorageClass StorageClass { get; set; }
- public string VersionId { get; set; }
- public string WebsiteRedirectLocation { get; set; }

#### Constructors
- public GetObjectMetadataResponse()

#### Methods
- internal bool IsSetAcceptRanges()
- internal bool IsSetContentRange()
- internal bool IsSetDeleteMarker()
- internal bool IsSetETag()
- internal bool IsSetExpiration()
- internal bool IsSetExpires()
- internal bool IsSetLastModified()
- internal bool IsSetMissingMeta()
- internal bool IsSetObjectLockLegalHoldStatus()
- internal bool IsSetObjectLockMode()
- internal bool IsSetObjectLockRetainUntilDate()
- internal bool IsSetPartsCount()
- internal bool IsSetReplicationStatus()
- internal bool IsSetRequestCharged()
- internal bool IsSetServerSideEncryptionCustomerMethod()
- internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
- internal bool IsSetServerSideEncryptionMethod()
- internal bool IsSetStorageClass()
- internal bool IsSetVersionId()
- internal bool IsSetWebsiteRedirectLocation()

### public class Amazon.S3.Model.GetObjectRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private Amazon.S3.Model.ByteRange byteRange
- private string etagToMatch
- private string etagToNotMatch
- private string key
- private System.Nullable<System.DateTime> modifiedSinceDate
- private System.Nullable<System.DateTime> modifiedSinceDateUtc
- private System.Nullable<int> partNumber
- private Amazon.S3.RequestPayer requestPayer
- private System.Nullable<System.DateTime> responseExpires
- private System.Nullable<System.DateTime> responseExpiresUtc
- private Amazon.S3.Model.ResponseHeaderOverrides responseHeaders
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideCustomerEncryption
- private string serverSideEncryptionCustomerProvidedKey
- private string serverSideEncryptionCustomerProvidedKeyMD5
- private System.Nullable<System.DateTime> unmodifiedSinceDate
- private System.Nullable<System.DateTime> unmodifiedSinceDateUtc
- private string versionId

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.Model.ByteRange ByteRange { get; set; }
- public string EtagToMatch { get; set; }
- public string EtagToNotMatch { get; set; }
- public string Key { get; set; }
- public System.DateTime ModifiedSinceDate { get; set; }
- public System.DateTime ModifiedSinceDateUtc { get; set; }
- public System.Nullable<int> PartNumber { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public System.DateTime ResponseExpires { get; set; }
- public System.DateTime ResponseExpiresUtc { get; set; }
- public Amazon.S3.Model.ResponseHeaderOverrides ResponseHeaderOverrides { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionCustomerProvidedKey { get; set; }
- public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }
- public System.DateTime UnmodifiedSinceDate { get; set; }
- public System.DateTime UnmodifiedSinceDateUtc { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public GetObjectRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetByteRange()
- internal bool IsSetEtagToMatch()
- internal bool IsSetEtagToNotMatch()
- internal bool IsSetKey()
- internal bool IsSetModifiedSinceDateUtc()
- internal bool IsSetPartNumber()
- internal bool IsSetRequestPayer()
- internal bool IsSetResponseExpiresUtc()
- internal bool IsSetServerSideEncryptionCustomerMethod()
- internal bool IsSetServerSideEncryptionCustomerProvidedKey()
- internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
- internal bool IsSetUnmodifiedSinceDateUtc()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.GetObjectResponse
- Base: Amazon.S3.Model.StreamResponse
- Interfaces: System.IDisposable

#### Fields
- private string <RawExpires>k__BackingField
- private string acceptRanges
- private string bucketName
- private string contentRange
- private string deleteMarker
- private string eTag
- private Amazon.S3.Model.Expiration expiration
- private System.Nullable<System.DateTime> expires
- private Amazon.S3.Model.HeadersCollection headersCollection
- private bool isExpiresUnmarshalled
- private string key
- private System.Nullable<System.DateTime> lastModified
- private Amazon.S3.Model.MetadataCollection metadataCollection
- private System.Nullable<int> missingMeta
- private Amazon.S3.ObjectLockLegalHoldStatus objectLockLegalHoldStatus
- private Amazon.S3.ObjectLockMode objectLockMode
- private System.Nullable<System.DateTime> objectLockRetainUntilDate
- private System.Nullable<int> partsCount
- private Amazon.S3.ReplicationStatus replicationStatus
- private Amazon.S3.RequestCharged requestCharged
- private System.Nullable<System.DateTime> restoreExpiration
- private bool restoreInProgress
- private Amazon.S3.ServerSideEncryptionMethod serverSideEncryption
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideEncryptionCustomerMethod
- private string serverSideEncryptionKeyManagementServiceKeyId
- private Amazon.S3.S3StorageClass storageClass
- private System.Nullable<int> tagCount
- private string versionId
- private string websiteRedirectLocation
- private System.EventHandler<Amazon.S3.Model.WriteObjectProgressArgs> WriteObjectProgressEvent

#### Properties
- public string AcceptRanges { get; set; }
- public string BucketName { get; set; }
- public string ContentRange { get; set; }
- public string DeleteMarker { get; set; }
- public string ETag { get; set; }
- public Amazon.S3.Model.Expiration Expiration { get; set; }
- public System.DateTime Expires { get; set; }
- public Amazon.S3.Model.HeadersCollection Headers { get; }
- public string Key { get; set; }
- public System.DateTime LastModified { get; set; }
- public Amazon.S3.Model.MetadataCollection Metadata { get; }
- public int MissingMeta { get; set; }
- public Amazon.S3.ObjectLockLegalHoldStatus ObjectLockLegalHoldStatus { get; set; }
- public Amazon.S3.ObjectLockMode ObjectLockMode { get; set; }
- public System.DateTime ObjectLockRetainUntilDate { get; set; }
- public System.Nullable<int> PartsCount { get; set; }
- internal string RawExpires { get; set; }
- public Amazon.S3.ReplicationStatus ReplicationStatus { get; set; }
- public Amazon.S3.RequestCharged RequestCharged { get; set; }
- public System.Nullable<System.DateTime> RestoreExpiration { get; set; }
- public bool RestoreInProgress { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }
- public Amazon.S3.S3StorageClass StorageClass { get; set; }
- public int TagCount { get; set; }
- public string VersionId { get; set; }
- public string WebsiteRedirectLocation { get; set; }

#### Events
- public event System.EventHandler<Amazon.S3.Model.WriteObjectProgressArgs> WriteObjectProgressEvent

#### Constructors
- public GetObjectResponse()

#### Methods
- internal bool IsSetAcceptRanges()
- internal bool IsSetContentRange()
- internal bool IsSetDeleteMarker()
- internal bool IsSetETag()
- internal bool IsSetExpiration()
- internal bool IsSetExpires()
- internal bool IsSetLastModified()
- internal bool IsSetMissingMeta()
- internal bool IsSetObjectLockLegalHoldStatus()
- internal bool IsSetObjectLockMode()
- internal bool IsSetObjectLockRetainUntilDate()
- internal bool IsSetPartsCount()
- internal bool IsSetReplicationStatus()
- internal bool IsSetRequestCharged()
- internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
- internal bool IsSetServerSideEncryptionMethod()
- internal bool IsSetStorageClass()
- internal bool IsSetVersionId()
- internal bool IsSetWebsiteRedirectLocation()
- internal void OnRaiseProgressEvent(string file, long incrementTransferred, long transferred, long total, bool completed)
- private void ValidateWrittenStreamSize(long bytesWritten)
- public System.Threading.Tasks.Task WriteResponseStreamToFileAsync(string filePath, bool append, System.Threading.CancellationToken cancellationToken)

### public class Amazon.S3.Model.GetObjectRetentionRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _bucketName
- private string _key
- private Amazon.S3.RequestPayer _requestPayer
- private string _versionId

#### Properties
- public string BucketName { get; set; }
- public string Key { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public GetObjectRetentionRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetKey()
- internal bool IsSetRequestPayer()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.GetObjectRetentionResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.ObjectLockRetention _retention

#### Properties
- public Amazon.S3.Model.ObjectLockRetention Retention { get; set; }

#### Constructors
- public GetObjectRetentionResponse()

#### Methods
- internal bool IsSetRetention()

### public class Amazon.S3.Model.GetObjectTaggingRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string key
- private string versionId

#### Properties
- public string BucketName { get; set; }
- public string Key { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public GetObjectTaggingRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetKey()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.GetObjectTaggingResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Model.Tag> tagging

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.Tag> Tagging { get; set; }

#### Constructors
- public GetObjectTaggingResponse()

### public class Amazon.S3.Model.GetObjectTorrentRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string key
- private Amazon.S3.RequestPayer requestPayer

#### Properties
- public string BucketName { get; set; }
- public string Key { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }

#### Constructors
- public GetObjectTorrentRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetKey()
- internal bool IsSetRequestPayer()

### public class Amazon.S3.Model.GetObjectTorrentResponse
- Base: Amazon.S3.Model.StreamResponse
- Interfaces: System.IDisposable

#### Fields
- private Amazon.S3.RequestCharged requestCharged

#### Properties
- public Amazon.S3.RequestCharged RequestCharged { get; set; }

#### Constructors
- public GetObjectTorrentResponse()

#### Methods
- internal bool IsSetRequestCharged()

### public class Amazon.S3.Model.GetPreSignedUrlRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private Amazon.S3.ServerSideEncryptionMethod encryption
- private System.Nullable<System.DateTime> expires
- private Amazon.S3.Model.HeadersCollection headersCollection
- private string key
- private Amazon.S3.Model.MetadataCollection metadataCollection
- private Amazon.S3.Model.ParameterCollection parameterCollection
- private Amazon.S3.Protocol protocol
- private Amazon.S3.RequestPayer requestPayer
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideCustomerEncryption
- private string serverSideEncryptionKeyManagementServiceKeyId
- private Amazon.S3.HttpVerb verb
- private string versionId
- private Amazon.S3.Model.ResponseHeaderOverrides _responseHeaders

#### Properties
- public string BucketName { get; set; }
- public string ContentType { get; set; }
- public System.DateTime Expires { get; set; }
- public Amazon.S3.Model.HeadersCollection Headers { get; internal set; }
- public string Key { get; set; }
- public Amazon.S3.Model.MetadataCollection Metadata { get; internal set; }
- public Amazon.S3.Model.ParameterCollection Parameters { get; internal set; }
- public Amazon.S3.Protocol Protocol { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public Amazon.S3.Model.ResponseHeaderOverrides ResponseHeaderOverrides { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }
- public Amazon.S3.HttpVerb Verb { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public GetPreSignedUrlRequest()

#### Methods
- internal bool IsSetBucketName()
- public bool IsSetExpires()
- internal bool IsSetKey()
- internal bool IsSetRequestPayer()
- internal bool IsSetServerSideEncryptionCustomerMethod()
- internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.GetPreSignedUrlResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string <Url>k__BackingField

#### Properties
- public string Url { get; internal set; }

#### Constructors
- public GetPreSignedUrlResponse(string url)

### public class Amazon.S3.Model.GetPublicAccessBlockRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public GetPublicAccessBlockRequest()

#### Methods
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.GetPublicAccessBlockResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.PublicAccessBlockConfiguration publicAccessBlockConfiguration

#### Properties
- public Amazon.S3.Model.PublicAccessBlockConfiguration PublicAccessBlockConfiguration { get; set; }

#### Constructors
- public GetPublicAccessBlockResponse()

#### Methods
- internal bool IsSetPublicAccessBlockConfiguration()

### internal class Amazon.S3.Model.HeadBucketRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName

#### Properties
- public string BucketName { get; set; }

#### Constructors
- public HeadBucketRequest()

#### Methods
- internal bool IsSetBucketName()

### internal class Amazon.S3.Model.HeadBucketResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public HeadBucketResponse()

### public class Amazon.S3.Model.HeadersCollection

#### Fields
- private readonly System.Collections.Generic.IDictionary<string, string> _values

#### Properties
- public string CacheControl { get; set; }
- public string ContentDisposition { get; set; }
- public string ContentEncoding { get; set; }
- public long ContentLength { get; set; }
- public string ContentMD5 { get; set; }
- public string ContentType { get; set; }
- public int Count { get; }
- public System.Nullable<System.DateTime> Expires { get; set; }
- public System.Nullable<System.DateTime> ExpiresUtc { get; set; }
- public string Item { get; set; }
- public System.Collections.Generic.ICollection<string> Keys { get; }

#### Constructors
- public HeadersCollection()

#### Methods
- internal bool IsSetContentType()

### public class Amazon.S3.Model.InitiateMultipartUploadRequest
- Base: Amazon.S3.Model.PutWithACLRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private byte[] <EncryptedEnvelopeKey>k__BackingField
- private byte[] <EnvelopeKey>k__BackingField
- private byte[] <IV>k__BackingField
- private Amazon.S3.Encryption.CryptoStorageMode <StorageMode>k__BackingField
- private string bucketName
- private Amazon.S3.S3CannedACL cannedACL
- private Amazon.S3.Model.HeadersCollection headersCollection
- private string key
- private Amazon.S3.Model.MetadataCollection metadataCollection
- private Amazon.S3.ObjectLockLegalHoldStatus objectLockLegalHoldStatus
- private Amazon.S3.ObjectLockMode objectLockMode
- private System.Nullable<System.DateTime> objectLockRetainUntilDate
- private Amazon.S3.RequestPayer requestPayer
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideCustomerEncryption
- private Amazon.S3.ServerSideEncryptionMethod serverSideEncryption
- private string serverSideEncryptionCustomerProvidedKey
- private string serverSideEncryptionCustomerProvidedKeyMD5
- private string serverSideEncryptionKeyManagementServiceEncryptionContext
- private string serverSideEncryptionKeyManagementServiceKeyId
- private Amazon.S3.S3StorageClass storageClass
- private System.Collections.Generic.List<Amazon.S3.Model.Tag> tagset
- private string websiteRedirectLocation

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.S3CannedACL CannedACL { get; set; }
- public string ContentType { get; set; }
- internal byte[] EncryptedEnvelopeKey { get; set; }
- internal byte[] EnvelopeKey { get; set; }
- public Amazon.S3.Model.HeadersCollection Headers { get; internal set; }
- internal byte[] IV { get; set; }
- public string Key { get; set; }
- public Amazon.S3.Model.MetadataCollection Metadata { get; internal set; }
- public Amazon.S3.ObjectLockLegalHoldStatus ObjectLockLegalHoldStatus { get; set; }
- public Amazon.S3.ObjectLockMode ObjectLockMode { get; set; }
- public System.DateTime ObjectLockRetainUntilDate { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionCustomerProvidedKey { get; set; }
- public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }
- public string ServerSideEncryptionKeyManagementServiceEncryptionContext { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }
- public Amazon.S3.S3StorageClass StorageClass { get; set; }
- internal Amazon.S3.Encryption.CryptoStorageMode StorageMode { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.Tag> TagSet { get; set; }
- public string WebsiteRedirectLocation { get; set; }

#### Constructors
- public InitiateMultipartUploadRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetCannedACL()
- internal bool IsSetKey()
- internal bool IsSetObjectLockLegalHoldStatus()
- internal bool IsSetObjectLockMode()
- internal bool IsSetObjectLockRetainUntilDate()
- internal bool IsSetRequestPayer()
- internal bool IsSetServerSideEncryptionCustomerMethod()
- internal bool IsSetServerSideEncryptionCustomerProvidedKey()
- internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
- internal bool IsSetServerSideEncryptionKeyManagementServiceEncryptionContext()
- internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
- internal bool IsSetServerSideEncryptionMethod()
- internal bool IsSetStorageClass()
- internal bool IsSetTagSet()
- internal bool IsSetWebsiteRedirectLocation()

### public class Amazon.S3.Model.InitiateMultipartUploadResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Nullable<System.DateTime> abortDate
- private string abortRuleId
- private string bucketName
- private string key
- private Amazon.S3.RequestCharged requestCharged
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideCustomerEncryption
- private Amazon.S3.ServerSideEncryptionMethod serverSideEncryption
- private string serverSideEncryptionCustomerProvidedKeyMD5
- private string serverSideEncryptionKeyManagementServiceEncryptionContext
- private string serverSideEncryptionKeyManagementServiceKeyId
- private string uploadId

#### Properties
- public System.DateTime AbortDate { get; set; }
- public string AbortRuleId { get; set; }
- public string BucketName { get; set; }
- public string Key { get; set; }
- public Amazon.S3.RequestCharged RequestCharged { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }
- public string ServerSideEncryptionKeyManagementServiceEncryptionContext { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }
- public string UploadId { get; set; }

#### Constructors
- public InitiateMultipartUploadResponse()

#### Methods
- internal bool IsSetAbortDate()
- internal bool IsSetAbortRuleId()
- internal bool IsSetBucketName()
- internal bool IsSetKey()
- internal bool IsSetRequestCharged()
- internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
- internal bool IsSetUploadId()

### public class Amazon.S3.Model.Initiator

#### Fields
- private string displayName
- private string iD

#### Properties
- public string DisplayName { get; set; }
- public string Id { get; set; }

#### Constructors
- public Initiator()

#### Methods
- internal bool IsSetDisplayName()
- internal bool IsSetId()

### public class Amazon.S3.Model.InputSerialization

#### Fields
- private Amazon.S3.CompressionType <CompressionType>k__BackingField
- private Amazon.S3.Model.CSVInput <CSV>k__BackingField
- private Amazon.S3.Model.JSONInput <JSON>k__BackingField
- private Amazon.S3.Model.ParquetInput <Parquet>k__BackingField

#### Properties
- public Amazon.S3.CompressionType CompressionType { get; set; }
- public Amazon.S3.Model.CSVInput CSV { get; set; }
- public Amazon.S3.Model.JSONInput JSON { get; set; }
- public Amazon.S3.Model.ParquetInput Parquet { get; set; }

#### Constructors
- public InputSerialization()

#### Methods
- internal bool IsSetCompressionType()
- internal bool IsSetCSV()
- internal bool IsSetJSON()
- internal bool IsSetParquet()
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.InventoryConfiguration

#### Fields
- private Amazon.S3.Model.InventoryDestination inventoryDestination
- private Amazon.S3.Model.InventoryFilter inventoryFilter
- private string inventoryId
- private Amazon.S3.InventoryIncludedObjectVersions inventoryIncludedObjectVersions
- private System.Collections.Generic.List<Amazon.S3.InventoryOptionalField> inventoryOptionalFields
- private Amazon.S3.Model.InventorySchedule inventorySchedule
- private bool isEnabled

#### Properties
- public Amazon.S3.Model.InventoryDestination Destination { get; set; }
- public Amazon.S3.InventoryIncludedObjectVersions IncludedObjectVersions { get; set; }
- public Amazon.S3.Model.InventoryFilter InventoryFilter { get; set; }
- public string InventoryId { get; set; }
- public System.Collections.Generic.List<Amazon.S3.InventoryOptionalField> InventoryOptionalFields { get; set; }
- public bool IsEnabled { get; set; }
- public Amazon.S3.Model.InventorySchedule Schedule { get; set; }

#### Constructors
- public InventoryConfiguration()

#### Methods
- internal bool IsSetDestination()
- internal bool IsSetIncludedObjectVersions()
- internal bool IsSetInventoryFilter()
- internal bool IsSetInventoryId()
- internal bool IsSetInventoryOptionalFields()
- internal bool IsSetSchedule()

### public class Amazon.S3.Model.InventoryDestination

#### Fields
- private Amazon.S3.Model.InventoryS3BucketDestination inventoryS3BucketDestination

#### Properties
- public Amazon.S3.Model.InventoryS3BucketDestination S3BucketDestination { get; set; }

#### Constructors
- public InventoryDestination()

#### Methods
- public bool isSetS3BucketDestination()

### public class Amazon.S3.Model.InventoryEncryption

#### Fields
- private Amazon.S3.Model.SSEKMS sSEKms
- private Amazon.S3.Model.SSES3 sSES3

#### Properties
- public Amazon.S3.Model.SSEKMS SSEKMS { get; set; }
- public Amazon.S3.Model.SSES3 SSES3 { get; set; }

#### Constructors
- public InventoryEncryption()

#### Methods
- internal bool IsSetSSEKMS()
- internal bool IsSetSSES3()

### public class Amazon.S3.Model.InventoryFilter

#### Fields
- private Amazon.S3.Model.InventoryFilterPredicate inventoryFilterPredicate

#### Properties
- public Amazon.S3.Model.InventoryFilterPredicate InventoryFilterPredicate { get; set; }

#### Constructors
- public InventoryFilter()

### public class Amazon.S3.Model.InventoryFilterPredicate

#### Constructors
- protected InventoryFilterPredicate()

#### Methods
- internal abstract void Accept(Amazon.S3.Model.Internal.IInventoryPredicateVisitor inventoryPredicateVisitor)

### public class Amazon.S3.Model.InventoryPrefixPredicate
- Base: Amazon.S3.Model.InventoryFilterPredicate

#### Fields
- private readonly string prefix

#### Properties
- public string Prefix { get; }

#### Constructors
- public InventoryPrefixPredicate(string prefix)

#### Methods
- internal override void Accept(Amazon.S3.Model.Internal.IInventoryPredicateVisitor inventoryPredicateVisitor)

### public class Amazon.S3.Model.InventoryS3BucketDestination

#### Fields
- private string accountId
- private string bucketName
- private Amazon.S3.Model.InventoryEncryption inventoryEncryption
- private Amazon.S3.InventoryFormat inventoryFormat
- private string prefix

#### Properties
- public string AccountId { get; set; }
- public string BucketName { get; set; }
- public Amazon.S3.Model.InventoryEncryption InventoryEncryption { get; set; }
- public Amazon.S3.InventoryFormat InventoryFormat { get; set; }
- public string Prefix { get; set; }

#### Constructors
- public InventoryS3BucketDestination()

#### Methods
- public bool IsSetAccountId()
- internal bool IsSetBucketName()
- internal bool IsSetInventoryEncryption()
- internal bool IsSetInventoryFormat()
- internal bool IsSetPrefix()

### public class Amazon.S3.Model.InventorySchedule

#### Fields
- private Amazon.S3.InventoryFrequency inventoryFrequency

#### Properties
- public Amazon.S3.InventoryFrequency Frequency { get; set; }

#### Constructors
- public InventorySchedule()

#### Methods
- internal bool IsFrequency()

### public interface Amazon.S3.Model.IS3Event
- Interfaces: Amazon.Runtime.EventStreams.Internal.IEventStreamEvent

### public interface Amazon.S3.Model.ISelectObjectContentEventStream
- Interfaces: Amazon.Runtime.EventStreams.Internal.IEnumerableEventStream<Amazon.S3.Model.IS3Event, Amazon.S3.Model.S3EventStreamException>, Amazon.Runtime.EventStreams.Internal.IEventStream<Amazon.S3.Model.IS3Event, Amazon.S3.Model.S3EventStreamException>, System.IDisposable, System.Collections.Generic.IEnumerable<Amazon.S3.Model.IS3Event>, System.Collections.IEnumerable

#### Events
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.ContinuationEvent>> ContinuationEventReceived
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.EndEvent>> EndEventReceived
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.IS3Event>> EventReceived
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamExceptionReceivedArgs<Amazon.S3.Model.S3EventStreamException>> ExceptionReceived
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.ProgressEvent>> ProgressEventReceived
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.RecordsEvent>> RecordsEventReceived
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.StatsEvent>> StatsEventReceived

### public class Amazon.S3.Model.JSONInput

#### Fields
- private Amazon.S3.JsonType <JsonType>k__BackingField

#### Properties
- public Amazon.S3.JsonType JsonType { get; set; }

#### Constructors
- public JSONInput()

#### Methods
- internal bool IsSetType()
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.JSONOutput

#### Fields
- private string <RecordDelimiter>k__BackingField

#### Properties
- public string RecordDelimiter { get; set; }

#### Constructors
- public JSONOutput()

#### Methods
- internal bool IsSetRecordDelimiter()
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.KeyVersion

#### Fields
- private string key
- private string versionId

#### Properties
- public string Key { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public KeyVersion()

#### Methods
- internal bool IsSetKey()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.LambdaFunctionConfiguration
- Base: Amazon.S3.Model.NotificationConfiguration

#### Fields
- private string <FunctionArn>k__BackingField
- private string <Id>k__BackingField

#### Properties
- public string FunctionArn { get; set; }
- public string Id { get; set; }

#### Constructors
- public LambdaFunctionConfiguration()

#### Methods
- internal bool IsSetFunctionArn()
- internal bool IsSetId()

### public class Amazon.S3.Model.LifecycleAndOperator
- Base: Amazon.S3.Model.LifecycleNAryOperator

#### Constructors
- public LifecycleAndOperator()

#### Methods
- internal override void Accept(Amazon.S3.Model.Internal.ILifecyclePredicateVisitor visitor)

### public class Amazon.S3.Model.LifecycleConfiguration

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Model.LifecycleRule> rules

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.LifecycleRule> Rules { get; set; }

#### Constructors
- public LifecycleConfiguration()

#### Methods
- internal bool IsSetRules()

### public class Amazon.S3.Model.LifecycleFilter

#### Fields
- private Amazon.S3.Model.LifecycleFilterPredicate <LifecycleFilterPredicate>k__BackingField

#### Properties
- public Amazon.S3.Model.LifecycleFilterPredicate LifecycleFilterPredicate { get; set; }

#### Constructors
- public LifecycleFilter()

#### Methods
- internal bool IsSetLifecycleFilterPredicate()

### public class Amazon.S3.Model.LifecycleFilterPredicate

#### Constructors
- protected LifecycleFilterPredicate()

#### Methods
- internal abstract void Accept(Amazon.S3.Model.Internal.ILifecyclePredicateVisitor visitor)

### public class Amazon.S3.Model.LifecycleNAryOperator
- Base: Amazon.S3.Model.LifecycleFilterPredicate

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Model.LifecycleFilterPredicate> <Operands>k__BackingField

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.LifecycleFilterPredicate> Operands { get; set; }

#### Constructors
- protected LifecycleNAryOperator()

#### Methods
- internal bool IsSetOperands()

### public class Amazon.S3.Model.LifecyclePrefixPredicate
- Base: Amazon.S3.Model.LifecycleFilterPredicate

#### Fields
- private string <Prefix>k__BackingField

#### Properties
- public string Prefix { get; set; }

#### Constructors
- public LifecyclePrefixPredicate()

#### Methods
- internal override void Accept(Amazon.S3.Model.Internal.ILifecyclePredicateVisitor visitor)
- internal bool IsSetPrefix()

### public class Amazon.S3.Model.LifecycleRule

#### Fields
- private Amazon.S3.Model.LifecycleRuleAbortIncompleteMultipartUpload abortIncompleteMultipartUpload
- private Amazon.S3.Model.LifecycleRuleExpiration expiration
- private Amazon.S3.Model.LifecycleFilter filter
- private string id
- private Amazon.S3.Model.LifecycleRuleNoncurrentVersionExpiration noncurrentVersionExpiration
- private System.Collections.Generic.List<Amazon.S3.Model.LifecycleRuleNoncurrentVersionTransition> noncurrentVersionTransitions
- private string prefix
- private Amazon.S3.LifecycleRuleStatus status
- private System.Collections.Generic.List<Amazon.S3.Model.LifecycleTransition> transitions

#### Properties
- public Amazon.S3.Model.LifecycleRuleAbortIncompleteMultipartUpload AbortIncompleteMultipartUpload { get; set; }
- public Amazon.S3.Model.LifecycleRuleExpiration Expiration { get; set; }
- public Amazon.S3.Model.LifecycleFilter Filter { get; set; }
- public string Id { get; set; }
- public Amazon.S3.Model.LifecycleRuleNoncurrentVersionExpiration NoncurrentVersionExpiration { get; set; }
- public Amazon.S3.Model.LifecycleRuleNoncurrentVersionTransition NoncurrentVersionTransition { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.LifecycleRuleNoncurrentVersionTransition> NoncurrentVersionTransitions { get; set; }
- public string Prefix { get; set; }
- public Amazon.S3.LifecycleRuleStatus Status { get; set; }
- public Amazon.S3.Model.LifecycleTransition Transition { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.LifecycleTransition> Transitions { get; set; }

#### Constructors
- public LifecycleRule()

#### Methods
- internal bool IsSetAbortIncompleteMultipartUpload()
- internal bool IsSetExpiration()
- internal bool IsSetFilter()
- internal bool IsSetId()
- internal bool IsSetNoncurrentVersionExpiration()
- internal bool IsSetNoncurrentVersionTransition()
- internal bool IsSetNoncurrentVersionTransitions()
- internal bool IsSetPrefix()
- internal bool IsSetStatus()
- internal bool IsSetTransition()
- internal bool IsSetTransitions()

### public class Amazon.S3.Model.LifecycleRuleAbortIncompleteMultipartUpload

#### Fields
- private System.Nullable<int> daysAfterInitiation

#### Properties
- public int DaysAfterInitiation { get; set; }

#### Constructors
- public LifecycleRuleAbortIncompleteMultipartUpload()

#### Methods
- internal bool IsSetDaysAfterInitiation()

### public class Amazon.S3.Model.LifecycleRuleExpiration

#### Fields
- private System.Nullable<System.DateTime> date
- private System.Nullable<System.DateTime> dateUtc
- private System.Nullable<int> days
- private System.Nullable<bool> expiredObjectDeleteMarker

#### Properties
- public System.DateTime Date { get; set; }
- public System.DateTime DateUtc { get; set; }
- public int Days { get; set; }
- public bool ExpiredObjectDeleteMarker { get; set; }

#### Constructors
- public LifecycleRuleExpiration()

#### Methods
- internal bool IsSetDateUtc()
- internal bool IsSetDays()
- internal bool IsSetExpiredObjectDeleteMarker()

### public class Amazon.S3.Model.LifecycleRuleNoncurrentVersionExpiration

#### Fields
- private System.Nullable<int> noncurrentDays

#### Properties
- public int NoncurrentDays { get; set; }

#### Constructors
- public LifecycleRuleNoncurrentVersionExpiration()

#### Methods
- internal bool IsSetNoncurrentDays()

### public class Amazon.S3.Model.LifecycleRuleNoncurrentVersionTransition

#### Fields
- private System.Nullable<int> noncurrentDays
- private Amazon.S3.S3StorageClass storageClass

#### Properties
- public int NoncurrentDays { get; set; }
- public Amazon.S3.S3StorageClass StorageClass { get; set; }

#### Constructors
- public LifecycleRuleNoncurrentVersionTransition()

#### Methods
- internal bool IsSetNoncurrentDays()
- internal bool IsSetStorageClass()

### public class Amazon.S3.Model.LifecycleTagPredicate
- Base: Amazon.S3.Model.LifecycleFilterPredicate

#### Fields
- private Amazon.S3.Model.Tag <Tag>k__BackingField

#### Properties
- public Amazon.S3.Model.Tag Tag { get; set; }

#### Constructors
- public LifecycleTagPredicate()

#### Methods
- internal override void Accept(Amazon.S3.Model.Internal.ILifecyclePredicateVisitor visitor)
- internal bool IsSetTag()

### public class Amazon.S3.Model.LifecycleTransition

#### Fields
- private System.Nullable<System.DateTime> date
- private System.Nullable<System.DateTime> dateUtc
- private System.Nullable<int> days
- private Amazon.S3.S3StorageClass storageClass

#### Properties
- public System.DateTime Date { get; set; }
- public System.DateTime DateUtc { get; set; }
- public int Days { get; set; }
- public Amazon.S3.S3StorageClass StorageClass { get; set; }

#### Constructors
- public LifecycleTransition()

#### Methods
- internal bool IsSetDateUtc()
- internal bool IsSetDays()
- internal bool IsSetStorageClass()

### public class Amazon.S3.Model.ListBucketAnalyticsConfigurationsRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string token

#### Properties
- public string BucketName { get; set; }
- public string ContinuationToken { get; set; }

#### Constructors
- public ListBucketAnalyticsConfigurationsRequest()

#### Methods
- internal bool IsSetBucket()
- internal bool IsSetContinuationToken()

### public class Amazon.S3.Model.ListBucketAnalyticsConfigurationsResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Model.AnalyticsConfiguration> analyticsConfigurationList
- private System.Nullable<bool> isTruncated
- private string nextToken
- private string token

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.AnalyticsConfiguration> AnalyticsConfigurationList { get; set; }
- public string ContinuationToken { get; set; }
- public bool IsTruncated { get; set; }
- public string NextContinuationToken { get; set; }

#### Constructors
- public ListBucketAnalyticsConfigurationsResponse()

#### Methods
- public bool IsSetAnalyticsConfigurationList()
- internal bool IsSetIsTruncated()
- internal bool IsSetNextToken()
- internal bool IsSetToken()

### public class Amazon.S3.Model.ListBucketInventoryConfigurationsRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string token

#### Properties
- public string BucketName { get; set; }
- public string ContinuationToken { get; set; }

#### Constructors
- public ListBucketInventoryConfigurationsRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetContinuationToken()

### public class Amazon.S3.Model.ListBucketInventoryConfigurationsResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Model.InventoryConfiguration> inventoryConfigurationList
- private System.Nullable<bool> isTruncated
- private string nextToken
- private string token

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.InventoryConfiguration> InventoryConfigurationList { get; set; }
- public bool IsTruncated { get; set; }
- public string NextToken { get; set; }
- public string Token { get; set; }

#### Constructors
- public ListBucketInventoryConfigurationsResponse()

#### Methods
- public bool IsSetInventoryConfigurationList()
- internal bool IsSetIsTruncated()
- internal bool IsSetNextToken()
- internal bool IsSetToken()

### public class Amazon.S3.Model.ListBucketMetricsConfigurationsRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string token

#### Properties
- public string BucketName { get; set; }
- public string ContinuationToken { get; set; }

#### Constructors
- public ListBucketMetricsConfigurationsRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetContinuationToken()

### public class Amazon.S3.Model.ListBucketMetricsConfigurationsResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Nullable<bool> isTruncated
- private System.Collections.Generic.List<Amazon.S3.Model.MetricsConfiguration> metricsConfigurationList
- private string nextToken
- private string token

#### Properties
- public bool IsTruncated { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.MetricsConfiguration> MetricsConfigurationList { get; set; }
- public string NextToken { get; set; }
- public string Token { get; set; }

#### Constructors
- public ListBucketMetricsConfigurationsResponse()

#### Methods
- internal bool IsSetIsTruncated()
- public bool IsSetMetricsConfigurationList()
- internal bool IsSetNextToken()
- internal bool IsSetToken()

### public class Amazon.S3.Model.ListBucketsRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Constructors
- public ListBucketsRequest()

### public class Amazon.S3.Model.ListBucketsResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Model.S3Bucket> buckets
- private Amazon.S3.Model.Owner owner

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.S3Bucket> Buckets { get; set; }
- public Amazon.S3.Model.Owner Owner { get; set; }

#### Constructors
- public ListBucketsResponse()

#### Methods
- internal bool IsSetBuckets()
- internal bool IsSetOwner()

### public class Amazon.S3.Model.ListMultipartUploadsRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string delimiter
- private Amazon.S3.EncodingType encoding
- private string keyMarker
- private System.Nullable<int> maxUploads
- private string prefix
- private string uploadIdMarker

#### Properties
- public string BucketName { get; set; }
- public string Delimiter { get; set; }
- public Amazon.S3.EncodingType Encoding { get; set; }
- public string KeyMarker { get; set; }
- public int MaxUploads { get; set; }
- public string Prefix { get; set; }
- public string UploadIdMarker { get; set; }

#### Constructors
- public ListMultipartUploadsRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetDelimiter()
- internal bool IsSetEncoding()
- internal bool IsSetKeyMarker()
- internal bool IsSetMaxUploads()
- internal bool IsSetPrefix()
- internal bool IsSetUploadIdMarker()

### public class Amazon.S3.Model.ListMultipartUploadsResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string bucketName
- private System.Collections.Generic.List<string> commonPrefixes
- private string delimiter
- private System.Nullable<bool> isTruncated
- private string keyMarker
- private System.Nullable<int> maxUploads
- private System.Collections.Generic.List<Amazon.S3.Model.MultipartUpload> multipartUploads
- private string nextKeyMarker
- private string nextUploadIdMarker
- private string prefix
- private string uploadIdMarker

#### Properties
- public string BucketName { get; set; }
- public System.Collections.Generic.List<string> CommonPrefixes { get; }
- public string Delimiter { get; set; }
- public bool IsTruncated { get; set; }
- public string KeyMarker { get; set; }
- public int MaxUploads { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.MultipartUpload> MultipartUploads { get; set; }
- public string NextKeyMarker { get; set; }
- public string NextUploadIdMarker { get; set; }
- public string Prefix { get; set; }
- public string UploadIdMarker { get; set; }

#### Constructors
- public ListMultipartUploadsResponse()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetIsTruncated()
- internal bool IsSetKeyMarker()
- internal bool IsSetMaxUploads()
- internal bool IsSetNextKeyMarker()
- internal bool IsSetNextUploadIdMarker()
- internal bool IsSetUploadIdMarker()

### public class Amazon.S3.Model.ListObjectsRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string delimiter
- private Amazon.S3.EncodingType encoding
- private string marker
- private System.Nullable<int> maxKeys
- private string prefix
- private Amazon.S3.RequestPayer requestPayer

#### Properties
- public string BucketName { get; set; }
- public string Delimiter { get; set; }
- public Amazon.S3.EncodingType Encoding { get; set; }
- public string Marker { get; set; }
- public int MaxKeys { get; set; }
- public string Prefix { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }

#### Constructors
- public ListObjectsRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetDelimiter()
- internal bool IsSetEncoding()
- internal bool IsSetMarker()
- internal bool IsSetMaxKeys()
- internal bool IsSetPrefix()
- internal bool IsSetRequestPayer()

### public class Amazon.S3.Model.ListObjectsResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.List<string> commonPrefixes
- private System.Collections.Generic.List<Amazon.S3.Model.S3Object> contents
- private string delimiter
- private System.Nullable<bool> isTruncated
- private System.Nullable<int> maxKeys
- private string name
- private string nextMarker
- private string prefix

#### Properties
- public System.Collections.Generic.List<string> CommonPrefixes { get; set; }
- public string Delimiter { get; set; }
- public bool IsTruncated { get; set; }
- public int MaxKeys { get; set; }
- public string Name { get; set; }
- public string NextMarker { get; set; }
- public string Prefix { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.S3Object> S3Objects { get; set; }

#### Constructors
- public ListObjectsResponse()

#### Methods
- internal bool IsSetCommonPrefixes()
- internal bool IsSetContents()
- internal bool IsSetIsTruncated()
- internal bool IsSetMaxKeys()
- internal bool IsSetName()
- internal bool IsSetNextMarker()
- internal bool IsSetPrefix()

### public class Amazon.S3.Model.ListObjectsV2Request
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string continuationToken
- private string delimiter
- private Amazon.S3.EncodingType encoding
- private System.Nullable<bool> fetchOwner
- private System.Nullable<int> maxKeys
- private string prefix
- private Amazon.S3.RequestPayer requestPayer
- private string startAfter

#### Properties
- public string BucketName { get; set; }
- public string ContinuationToken { get; set; }
- public string Delimiter { get; set; }
- public Amazon.S3.EncodingType Encoding { get; set; }
- public bool FetchOwner { get; set; }
- public int MaxKeys { get; set; }
- public string Prefix { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public string StartAfter { get; set; }

#### Constructors
- public ListObjectsV2Request()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetContinuationToken()
- internal bool IsSetDelimiter()
- internal bool IsSetEncoding()
- internal bool IsSetFetchOwner()
- internal bool IsSetMaxKeys()
- internal bool IsSetPrefix()
- internal bool IsSetRequestPayer()
- internal bool IsSetStartAfter()

### public class Amazon.S3.Model.ListObjectsV2Response
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.List<string> commonPrefixes
- private System.Collections.Generic.List<Amazon.S3.Model.S3Object> contents
- private string continuationToken
- private string delimiter
- private Amazon.S3.EncodingType encoding
- private System.Nullable<bool> isTruncated
- private System.Nullable<int> keyCount
- private System.Nullable<int> maxKeys
- private string name
- private string nextContinuationToken
- private string prefix
- private string startAfter

#### Properties
- public System.Collections.Generic.List<string> CommonPrefixes { get; set; }
- public string ContinuationToken { get; set; }
- public string Delimiter { get; set; }
- public Amazon.S3.EncodingType Encoding { get; set; }
- public bool IsTruncated { get; set; }
- public int KeyCount { get; set; }
- public int MaxKeys { get; set; }
- public string Name { get; set; }
- public string NextContinuationToken { get; set; }
- public string Prefix { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.S3Object> S3Objects { get; set; }
- public string StartAfter { get; set; }

#### Constructors
- public ListObjectsV2Response()

#### Methods
- internal bool IsSetCommonPrefixes()
- internal bool IsSetContents()
- internal bool IsSetContinuationToken()
- internal bool IsSetEncoding()
- internal bool IsSetIsTruncated()
- internal bool IsSetKeyCount()
- internal bool IsSetMaxKeys()
- internal bool IsSetName()
- internal bool IsSetNextContinuationToken()
- internal bool IsSetPrefix()
- internal bool IsSetStartAfter()

### public class Amazon.S3.Model.ListPartsRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private Amazon.S3.EncodingType encoding
- private string key
- private System.Nullable<int> maxParts
- private string partNumberMarker
- private Amazon.S3.RequestPayer requestPayer
- private string uploadId

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.EncodingType Encoding { get; set; }
- public string Key { get; set; }
- public int MaxParts { get; set; }
- public string PartNumberMarker { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public string UploadId { get; set; }

#### Constructors
- public ListPartsRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetEncoding()
- internal bool IsSetKey()
- internal bool IsSetMaxParts()
- internal bool IsSetPartNumberMarker()
- internal bool IsSetRequestPayer()
- internal bool IsSetUploadId()

### public class Amazon.S3.Model.ListPartsResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Nullable<System.DateTime> abortDate
- private string abortRuleId
- private string bucketName
- private Amazon.S3.Model.Initiator initiator
- private System.Nullable<bool> isTruncated
- private string key
- private System.Nullable<int> maxParts
- private System.Nullable<int> nextPartNumberMarker
- private Amazon.S3.Model.Owner owner
- private System.Nullable<int> partNumberMarker
- private System.Collections.Generic.List<Amazon.S3.Model.PartDetail> parts
- private Amazon.S3.RequestCharged requestCharged
- private Amazon.S3.S3StorageClass storageClass
- private string uploadId

#### Properties
- public System.DateTime AbortDate { get; set; }
- public string AbortRuleId { get; set; }
- public string BucketName { get; set; }
- public Amazon.S3.Model.Initiator Initiator { get; set; }
- public bool IsTruncated { get; set; }
- public string Key { get; set; }
- public int MaxParts { get; set; }
- public int NextPartNumberMarker { get; set; }
- public Amazon.S3.Model.Owner Owner { get; set; }
- public int PartNumberMarker { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.PartDetail> Parts { get; set; }
- public Amazon.S3.RequestCharged RequestCharged { get; set; }
- public string StorageClass { get; set; }
- public string UploadId { get; set; }

#### Constructors
- public ListPartsResponse()

#### Methods
- internal bool IsSetAbortDate()
- internal bool IsSetAbortRuleId()
- internal bool IsSetBucketName()
- internal bool IsSetInitiator()
- internal bool IsSetIsTruncated()
- internal bool IsSetKey()
- internal bool IsSetMaxParts()
- internal bool IsSetNextPartNumberMarker()
- internal bool IsSetOwner()
- internal bool IsSetPartNumberMarker()
- internal bool IsSetParts()
- internal bool IsSetRequestCharged()
- internal bool IsSetStorageClass()
- internal bool IsSetUploadId()

### public class Amazon.S3.Model.ListVersionsRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string delimiter
- private Amazon.S3.EncodingType encoding
- private string keyMarker
- private System.Nullable<int> maxKeys
- private string prefix
- private string versionIdMarker

#### Properties
- public string BucketName { get; set; }
- public string Delimiter { get; set; }
- public Amazon.S3.EncodingType Encoding { get; set; }
- public string KeyMarker { get; set; }
- public int MaxKeys { get; set; }
- public string Prefix { get; set; }
- public string VersionIdMarker { get; set; }

#### Constructors
- public ListVersionsRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetDelimiter()
- internal bool IsSetEncoding()
- internal bool IsSetKeyMarker()
- internal bool IsSetMaxKeys()
- internal bool IsSetPrefix()
- internal bool IsSetVersionIdMarker()

### public class Amazon.S3.Model.ListVersionsResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private System.Collections.Generic.List<string> commonPrefixes
- private string delimiter
- private System.Nullable<bool> isTruncated
- private string keyMarker
- private System.Nullable<int> maxKeys
- private string name
- private string nextKeyMarker
- private string nextVersionIdMarker
- private string prefix
- private string versionIdMarker
- private System.Collections.Generic.List<Amazon.S3.Model.S3ObjectVersion> versions

#### Properties
- public System.Collections.Generic.List<string> CommonPrefixes { get; set; }
- public string Delimiter { get; set; }
- public bool IsTruncated { get; set; }
- public string KeyMarker { get; set; }
- public int MaxKeys { get; set; }
- public string Name { get; set; }
- public string NextKeyMarker { get; set; }
- public string NextVersionIdMarker { get; set; }
- public string Prefix { get; set; }
- public string VersionIdMarker { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.S3ObjectVersion> Versions { get; set; }

#### Constructors
- public ListVersionsResponse()

#### Methods
- internal bool IsSetCommonPrefixes()
- internal bool IsSetIsTruncated()
- internal bool IsSetKeyMarker()
- internal bool IsSetMaxKeys()
- internal bool IsSetName()
- internal bool IsSetNextKeyMarker()
- internal bool IsSetNextVersionIdMarker()
- internal bool IsSetPrefix()
- internal bool IsSetVersionIdMarker()
- internal bool IsSetVersions()

### public class Amazon.S3.Model.MetadataCollection

#### Fields
- internal static const string MetaDataHeaderPrefix
- private System.Collections.Generic.IDictionary<string, string> values

#### Properties
- public int Count { get; }
- public string Item { get; set; }
- public System.Collections.Generic.ICollection<string> Keys { get; }

#### Constructors
- public MetadataCollection()

#### Methods
- public void Add(string name, string value)
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.MetadataEntry

#### Fields
- private string <Name>k__BackingField
- private string <Value>k__BackingField

#### Properties
- public string Name { get; set; }
- public string Value { get; set; }

#### Constructors
- public MetadataEntry()

#### Methods
- internal bool IsSetName()
- internal bool IsSetValue()
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.MetricsAndOperator
- Base: Amazon.S3.Model.MetricsNAryOperator

#### Constructors
- public MetricsAndOperator(System.Collections.Generic.List<Amazon.S3.Model.MetricsFilterPredicate> operands)

#### Methods
- internal override void Accept(Amazon.S3.Model.Internal.IMetricsPredicateVisitor metricsPredicateVisitor)

### public class Amazon.S3.Model.MetricsConfiguration

#### Fields
- private Amazon.S3.Model.MetricsFilter metricsFilter
- private string metricsId

#### Properties
- public Amazon.S3.Model.MetricsFilter MetricsFilter { get; set; }
- public string MetricsId { get; set; }

#### Constructors
- public MetricsConfiguration()

#### Methods
- internal bool IsSetMetricsFilter()
- internal bool IsSetMetricsId()

### public class Amazon.S3.Model.MetricsFilter

#### Fields
- private Amazon.S3.Model.MetricsFilterPredicate metricsFilterPredicate

#### Properties
- public Amazon.S3.Model.MetricsFilterPredicate MetricsFilterPredicate { get; set; }

#### Constructors
- public MetricsFilter()

### public class Amazon.S3.Model.MetricsFilterPredicate

#### Constructors
- protected MetricsFilterPredicate()

#### Methods
- internal abstract void Accept(Amazon.S3.Model.Internal.IMetricsPredicateVisitor metricsPredicateVisitor)

### public class Amazon.S3.Model.MetricsNAryOperator
- Base: Amazon.S3.Model.MetricsFilterPredicate

#### Fields
- private readonly System.Collections.Generic.List<Amazon.S3.Model.MetricsFilterPredicate> operands

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.MetricsFilterPredicate> Operands { get; }

#### Constructors
- protected MetricsNAryOperator(System.Collections.Generic.List<Amazon.S3.Model.MetricsFilterPredicate> operands)

### public class Amazon.S3.Model.MetricsPrefixPredicate
- Base: Amazon.S3.Model.MetricsFilterPredicate

#### Fields
- private readonly string prefix

#### Properties
- public string Prefix { get; }

#### Constructors
- public MetricsPrefixPredicate(string prefix)

#### Methods
- internal override void Accept(Amazon.S3.Model.Internal.IMetricsPredicateVisitor metricsPredicateVisitor)

### public class Amazon.S3.Model.MetricsTagPredicate
- Base: Amazon.S3.Model.MetricsFilterPredicate

#### Fields
- private readonly Amazon.S3.Model.Tag tag

#### Properties
- public Amazon.S3.Model.Tag Tag { get; }

#### Constructors
- public MetricsTagPredicate(Amazon.S3.Model.Tag tag)

#### Methods
- internal override void Accept(Amazon.S3.Model.Internal.IMetricsPredicateVisitor metricsPredicateVisitor)

### public class Amazon.S3.Model.MfaCodes

#### Fields
- private string <AuthenticationValue>k__BackingField
- private string <SerialNumber>k__BackingField

#### Properties
- public string AuthenticationValue { get; set; }
- public string FormattedMfaCodes { get; }
- public string SerialNumber { get; set; }

#### Constructors
- public MfaCodes()

### public class Amazon.S3.Model.MultipartUpload

#### Fields
- private System.Nullable<System.DateTime> initiated
- private Amazon.S3.Model.Initiator initiator
- private string key
- private Amazon.S3.Model.Owner owner
- private Amazon.S3.S3StorageClass storageClass
- private string uploadId

#### Properties
- public System.DateTime Initiated { get; set; }
- public Amazon.S3.Model.Initiator Initiator { get; set; }
- public string Key { get; set; }
- public Amazon.S3.Model.Owner Owner { get; set; }
- public Amazon.S3.S3StorageClass StorageClass { get; set; }
- public string UploadId { get; set; }

#### Constructors
- public MultipartUpload()

#### Methods
- internal bool IsSetInitiated()
- internal bool IsSetInitiator()
- internal bool IsSetKey()
- internal bool IsSetOwner()
- internal bool IsSetStorageClass()
- internal bool IsSetUploadId()

### public class Amazon.S3.Model.NotificationConfiguration

#### Fields
- private Amazon.S3.Model.Filter filter
- private System.Collections.Generic.List<Amazon.S3.EventType> _events

#### Properties
- public System.Collections.Generic.List<Amazon.S3.EventType> Events { get; set; }
- public Amazon.S3.Model.Filter Filter { get; set; }

#### Constructors
- protected NotificationConfiguration()

#### Methods
- internal bool IsSetEvents()
- internal bool IsSetFilter()

### public class Amazon.S3.Model.ObjectLockConfiguration

#### Fields
- private Amazon.S3.ObjectLockEnabled _objectLockEnabled
- private Amazon.S3.Model.ObjectLockRule _rule

#### Properties
- public Amazon.S3.ObjectLockEnabled ObjectLockEnabled { get; set; }
- public Amazon.S3.Model.ObjectLockRule Rule { get; set; }

#### Constructors
- public ObjectLockConfiguration()

#### Methods
- internal bool IsSetObjectLockEnabled()
- internal bool IsSetRule()

### public class Amazon.S3.Model.ObjectLockLegalHold

#### Fields
- private Amazon.S3.ObjectLockLegalHoldStatus _status

#### Properties
- public Amazon.S3.ObjectLockLegalHoldStatus Status { get; set; }

#### Constructors
- public ObjectLockLegalHold()

#### Methods
- internal bool IsSetStatus()

### public class Amazon.S3.Model.ObjectLockRetention

#### Fields
- private Amazon.S3.ObjectLockRetentionMode _mode
- private System.Nullable<System.DateTime> _retainUntilDate

#### Properties
- public Amazon.S3.ObjectLockRetentionMode Mode { get; set; }
- public System.DateTime RetainUntilDate { get; set; }

#### Constructors
- public ObjectLockRetention()

#### Methods
- internal bool IsSetMode()
- internal bool IsSetRetainUntilDate()

### public class Amazon.S3.Model.ObjectLockRule

#### Fields
- private Amazon.S3.Model.DefaultRetention _defaultRetention

#### Properties
- public Amazon.S3.Model.DefaultRetention DefaultRetention { get; set; }

#### Constructors
- public ObjectLockRule()

#### Methods
- internal bool IsSetDefaultRetention()

### public class Amazon.S3.Model.OutputLocation

#### Fields
- private Amazon.S3.Model.S3Location <S3>k__BackingField

#### Properties
- public Amazon.S3.Model.S3Location S3 { get; set; }

#### Constructors
- public OutputLocation()

#### Methods
- internal bool IsSetS3()
- internal void Marshall(string propertyName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.OutputSerialization

#### Fields
- private Amazon.S3.Model.CSVOutput <CSV>k__BackingField
- private Amazon.S3.Model.JSONOutput <JSON>k__BackingField

#### Properties
- public Amazon.S3.Model.CSVOutput CSV { get; set; }
- public Amazon.S3.Model.JSONOutput JSON { get; set; }

#### Constructors
- public OutputSerialization()

#### Methods
- internal bool IsSetCSV()
- internal bool IsSetJSON()
- internal void Marshall(string propertyName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.Owner

#### Fields
- private string <DisplayName>k__BackingField
- private string <Id>k__BackingField

#### Properties
- public string DisplayName { get; set; }
- public string Id { get; set; }

#### Constructors
- public Owner()

#### Methods
- internal bool IsSetDisplayName()
- internal bool IsSetId()

### public class Amazon.S3.Model.ParameterCollection

#### Fields
- private System.Collections.Generic.IDictionary<string, string> values

#### Properties
- public int Count { get; }
- public string Item { get; set; }
- public System.Collections.Generic.ICollection<string> Keys { get; }

#### Constructors
- public ParameterCollection()

#### Methods
- public void Add(string name, string value)

### public class Amazon.S3.Model.ParquetInput

#### Constructors
- public ParquetInput()

#### Methods
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.PartDetail
- Base: Amazon.S3.Model.PartETag
- Interfaces: System.IComparable<Amazon.S3.Model.PartETag>

#### Fields
- private System.Nullable<System.DateTime> lastModified
- private System.Nullable<long> size

#### Properties
- public System.DateTime LastModified { get; set; }
- public long Size { get; set; }

#### Constructors
- public PartDetail()

#### Methods
- internal bool IsLastModified()
- internal bool IsSize()

### public class Amazon.S3.Model.PartETag
- Interfaces: System.IComparable<Amazon.S3.Model.PartETag>

#### Fields
- private string eTag
- private System.Nullable<int> partNumber

#### Properties
- public string ETag { get; set; }
- public int PartNumber { get; set; }

#### Constructors
- public PartETag()
- public PartETag(int partNumber, string eTag)

#### Methods
- public int CompareTo(Amazon.S3.Model.PartETag other)
- internal bool IsSetETag()
- internal bool IsSetPartNumber()

### public class Amazon.S3.Model.PolicyStatus

#### Fields
- private System.Nullable<bool> isPublic

#### Properties
- public bool IsPublic { get; set; }

#### Constructors
- public PolicyStatus()

#### Methods
- internal bool IsSetIsPublic()

### public class Amazon.S3.Model.Progress

#### Fields
- private long <BytesProcessed>k__BackingField
- private long <BytesReturned>k__BackingField
- private long <BytesScanned>k__BackingField

#### Properties
- public long BytesProcessed { get; set; }
- public long BytesReturned { get; set; }
- public long BytesScanned { get; set; }

#### Constructors
- public Progress()

#### Methods
- internal static Amazon.S3.Model.Progress Unmarshall(byte[] payload)

### public class Amazon.S3.Model.ProgressEvent
- Interfaces: Amazon.S3.Model.IS3Event, Amazon.Runtime.EventStreams.Internal.IEventStreamEvent

#### Fields
- private Amazon.S3.Model.Progress <Details>k__BackingField

#### Properties
- public Amazon.S3.Model.Progress Details { get; set; }

#### Constructors
- public ProgressEvent()
- public ProgressEvent(Amazon.Runtime.EventStreams.IEventStreamMessage message)

### public class Amazon.S3.Model.PublicAccessBlockConfiguration

#### Fields
- private System.Nullable<bool> blockPublicAcls
- private System.Nullable<bool> blockPublicPolicy
- private System.Nullable<bool> ignorePublicAcls
- private System.Nullable<bool> restrictPublicBuckets

#### Properties
- public bool BlockPublicAcls { get; set; }
- public bool BlockPublicPolicy { get; set; }
- public bool IgnorePublicAcls { get; set; }
- public bool RestrictPublicBuckets { get; set; }

#### Constructors
- public PublicAccessBlockConfiguration()

#### Methods
- internal bool IsSetBlockPublicAcls()
- internal bool IsSetBlockPublicPolicy()
- internal bool IsSetIgnorePublicAcls()
- internal bool IsSetRestrictPublicBuckets()

### public class Amazon.S3.Model.PutACLRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private Amazon.S3.Model.S3AccessControlList accessControlPolicy
- private string bucket
- private Amazon.S3.S3CannedACL cannedACL
- private string key
- private string versionId

#### Properties
- public Amazon.S3.Model.S3AccessControlList AccessControlList { get; set; }
- public string BucketName { get; set; }
- public Amazon.S3.S3CannedACL CannedACL { get; set; }
- public string Key { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public PutACLRequest()

#### Methods
- internal bool IsSetAccessControlPolicy()
- internal bool IsSetBucketName()
- internal bool IsSetCannedACL()
- internal bool IsSetKey()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.PutACLResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutACLResponse()

### public class Amazon.S3.Model.PutBucketAccelerateConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private Amazon.S3.Model.AccelerateConfiguration accelerateConfiguration
- private string bucketName

#### Properties
- public Amazon.S3.Model.AccelerateConfiguration AccelerateConfiguration { get; set; }
- public string BucketName { get; set; }

#### Constructors
- public PutBucketAccelerateConfigurationRequest()

#### Methods
- internal bool IsSetAccelerateConfiguration()
- internal bool IsSetBucketName()

### public class Amazon.S3.Model.PutBucketAccelerateConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutBucketAccelerateConfigurationResponse()

### public class Amazon.S3.Model.PutBucketAnalyticsConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private Amazon.S3.Model.AnalyticsConfiguration analyticsConfiguration
- private string analyticsId
- private string bucketName

#### Properties
- public Amazon.S3.Model.AnalyticsConfiguration AnalyticsConfiguration { get; set; }
- public string AnalyticsId { get; set; }
- public string BucketName { get; set; }

#### Constructors
- public PutBucketAnalyticsConfigurationRequest()

#### Methods
- internal bool IsSetAnalyticsConfiguration()
- internal bool IsSetAnalyticsId()
- internal bool IsSetBucket()

### public class Amazon.S3.Model.PutBucketAnalyticsConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutBucketAnalyticsConfigurationResponse()

### public class Amazon.S3.Model.PutBucketEncryptionRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string contentMD5
- private Amazon.S3.Model.ServerSideEncryptionConfiguration serverSideEncryptionConfiguration

#### Properties
- public string BucketName { get; set; }
- public string ContentMD5 { get; set; }
- public Amazon.S3.Model.ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration { get; set; }

#### Constructors
- public PutBucketEncryptionRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetContentMD5()
- internal bool IsSetServerSideEncryptionConfiguration()

### public class Amazon.S3.Model.PutBucketInventoryConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private Amazon.S3.Model.InventoryConfiguration inventoryConfiguration
- private string inventoryId

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.Model.InventoryConfiguration InventoryConfiguration { get; set; }
- public string InventoryId { get; set; }

#### Constructors
- public PutBucketInventoryConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetInventoryConfiguration()
- internal bool IsSetInventoryId()

### public class Amazon.S3.Model.PutBucketInventoryConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutBucketInventoryConfigurationResponse()

### public class Amazon.S3.Model.PutBucketLoggingRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string <BucketName>k__BackingField
- private Amazon.S3.Model.S3BucketLoggingConfig <LoggingConfig>k__BackingField

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.Model.S3BucketLoggingConfig LoggingConfig { get; set; }

#### Constructors
- public PutBucketLoggingRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetLoggingConfig()

### public class Amazon.S3.Model.PutBucketLoggingResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutBucketLoggingResponse()

### public class Amazon.S3.Model.PutBucketMetricsConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private Amazon.S3.Model.MetricsConfiguration metricsConfiguration
- private string metricsId

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.Model.MetricsConfiguration MetricsConfiguration { get; set; }
- public string MetricsId { get; set; }

#### Constructors
- public PutBucketMetricsConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetMetricsConfiguration()
- internal bool IsSetMetricsId()

### public class Amazon.S3.Model.PutBucketMetricsConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutBucketMetricsConfigurationResponse()

### public class Amazon.S3.Model.PutBucketNotificationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string <BucketName>k__BackingField
- private System.Collections.Generic.List<Amazon.S3.Model.LambdaFunctionConfiguration> <LambdaFunctionConfigurations>k__BackingField
- private System.Collections.Generic.List<Amazon.S3.Model.QueueConfiguration> <QueueConfigurations>k__BackingField
- private System.Collections.Generic.List<Amazon.S3.Model.TopicConfiguration> <TopicConfigurations>k__BackingField

#### Properties
- public string BucketName { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.LambdaFunctionConfiguration> LambdaFunctionConfigurations { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.QueueConfiguration> QueueConfigurations { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.TopicConfiguration> TopicConfigurations { get; set; }

#### Constructors
- public PutBucketNotificationRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetLambdaFunctionConfigurations()
- internal bool IsSetQueueConfigurations()
- internal bool IsSetTopicConfigurations()

### public class Amazon.S3.Model.PutBucketNotificationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutBucketNotificationResponse()

### public class Amazon.S3.Model.PutBucketPolicyRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string <BucketName>k__BackingField
- private string <ContentMD5>k__BackingField
- private string <Policy>k__BackingField
- private System.Nullable<bool> confirmRemoveSelfBucketAccess

#### Properties
- public string BucketName { get; set; }
- public bool ConfirmRemoveSelfBucketAccess { get; set; }
- public string ContentMD5 { get; set; }
- protected bool IncludeSHA256Header { get; }
- public string Policy { get; set; }

#### Constructors
- public PutBucketPolicyRequest()

#### Methods
- internal bool IsSetBucket()
- internal bool IsSetConfirmRemoveSelfBucketAccess()
- internal bool IsSetContentMD5()
- internal bool IsSetPolicy()

### public class Amazon.S3.Model.PutBucketPolicyResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutBucketPolicyResponse()

### public class Amazon.S3.Model.PutBucketReplicationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private Amazon.S3.Model.ReplicationConfiguration configuration
- private string token

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.Model.ReplicationConfiguration Configuration { get; set; }
- public string Token { get; set; }

#### Constructors
- public PutBucketReplicationRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetConfiguration()
- internal bool IsSetToken()

### public class Amazon.S3.Model.PutBucketReplicationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutBucketReplicationResponse()

### public class Amazon.S3.Model.PutBucketRequest
- Base: Amazon.S3.Model.PutWithACLRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private Amazon.S3.S3Region bucketRegion
- private string bucketRegionName
- private Amazon.S3.S3CannedACL cannedAcl
- private bool useClientRegion
- private System.Nullable<bool> _objectLockEnabledForBucket

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.S3Region BucketRegion { get; set; }
- public string BucketRegionName { get; set; }
- public Amazon.S3.S3CannedACL CannedACL { get; set; }
- public bool ObjectLockEnabledForBucket { get; set; }
- public bool UseClientRegion { get; set; }

#### Constructors
- public PutBucketRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetBucketRegion()
- internal bool IsSetBucketRegionName()
- internal bool IsSetCannedACL()
- internal bool IsSetObjectLockEnabledForBucket()

### public class Amazon.S3.Model.PutBucketRequestPaymentRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private Amazon.S3.Model.RequestPaymentConfiguration requestPaymentConfiguration

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.Model.RequestPaymentConfiguration RequestPaymentConfiguration { get; set; }

#### Constructors
- public PutBucketRequestPaymentRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetRequestPaymentConfiguration()

### public class Amazon.S3.Model.PutBucketRequestPaymentResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutBucketRequestPaymentResponse()

### public class Amazon.S3.Model.PutBucketResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutBucketResponse()

### public class Amazon.S3.Model.PutBucketTaggingRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private System.Collections.Generic.List<Amazon.S3.Model.Tag> tagSet

#### Properties
- public string BucketName { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.Tag> TagSet { get; set; }

#### Constructors
- public PutBucketTaggingRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetTagSet()

### public class Amazon.S3.Model.PutBucketTaggingResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutBucketTaggingResponse()

### public class Amazon.S3.Model.PutBucketVersioningRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private Amazon.S3.Model.S3BucketVersioningConfig config
- private Amazon.S3.Model.MfaCodes mfaCodes

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.Model.MfaCodes MfaCodes { get; set; }
- public Amazon.S3.Model.S3BucketVersioningConfig VersioningConfig { get; set; }

#### Constructors
- public PutBucketVersioningRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetMfaCodes()
- internal bool IsSetVersioningConfiguration()

### public class Amazon.S3.Model.PutBucketVersioningResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutBucketVersioningResponse()

### public class Amazon.S3.Model.PutBucketWebsiteRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private Amazon.S3.Model.WebsiteConfiguration websiteConfiguration

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.Model.WebsiteConfiguration WebsiteConfiguration { get; set; }

#### Constructors
- public PutBucketWebsiteRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetWebsiteConfiguration()

### public class Amazon.S3.Model.PutBucketWebsiteResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutBucketWebsiteResponse()

### public class Amazon.S3.Model.PutCORSConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private Amazon.S3.Model.CORSConfiguration configuration

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.Model.CORSConfiguration Configuration { get; set; }

#### Constructors
- public PutCORSConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetConfiguration()

### public class Amazon.S3.Model.PutCORSConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutCORSConfigurationResponse()

### public class Amazon.S3.Model.PutLifecycleConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private Amazon.S3.Model.LifecycleConfiguration lifecycleConfiguration

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.Model.LifecycleConfiguration Configuration { get; set; }

#### Constructors
- public PutLifecycleConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetConfiguration()

### public class Amazon.S3.Model.PutLifecycleConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutLifecycleConfigurationResponse()

### public class Amazon.S3.Model.PutObjectLegalHoldRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _bucketName
- private string _contentMD5
- private string _key
- private Amazon.S3.Model.ObjectLockLegalHold _legalHold
- private Amazon.S3.RequestPayer _requestPayer
- private string _versionId

#### Properties
- public string BucketName { get; set; }
- public string ContentMD5 { get; set; }
- public string Key { get; set; }
- public Amazon.S3.Model.ObjectLockLegalHold LegalHold { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public PutObjectLegalHoldRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetContentMD5()
- internal bool IsSetKey()
- internal bool IsSetLegalHold()
- internal bool IsSetRequestPayer()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.PutObjectLegalHoldResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.RequestCharged _requestCharged

#### Properties
- public Amazon.S3.RequestCharged RequestCharged { get; set; }

#### Constructors
- public PutObjectLegalHoldResponse()

#### Methods
- internal bool IsSetRequestCharged()

### public class Amazon.S3.Model.PutObjectLockConfigurationRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _bucketName
- private string _contentMD5
- private Amazon.S3.Model.ObjectLockConfiguration _objectLockConfiguration
- private Amazon.S3.RequestPayer _requestPayer
- private string _token

#### Properties
- public string BucketName { get; set; }
- public string ContentMD5 { get; set; }
- public Amazon.S3.Model.ObjectLockConfiguration ObjectLockConfiguration { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public string Token { get; set; }

#### Constructors
- public PutObjectLockConfigurationRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetContentMD5()
- internal bool IsSetObjectLockConfiguration()
- internal bool IsSetRequestPayer()
- internal bool IsSetToken()

### public class Amazon.S3.Model.PutObjectLockConfigurationResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.RequestCharged _requestCharged

#### Properties
- public Amazon.S3.RequestCharged RequestCharged { get; set; }

#### Constructors
- public PutObjectLockConfigurationResponse()

#### Methods
- internal bool IsSetRequestCharged()

### public class Amazon.S3.Model.PutObjectRequest
- Base: Amazon.S3.Model.PutWithACLRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private bool autoCloseStream
- private bool autoResetStreamPosition
- private string bucketName
- private Amazon.S3.S3CannedACL cannedACL
- private string contentBody
- private string filePath
- private Amazon.S3.Model.HeadersCollection headersCollection
- private System.IO.Stream inputStream
- private string key
- private string md5Digest
- private Amazon.S3.Model.MetadataCollection metadataCollection
- private Amazon.S3.ObjectLockLegalHoldStatus objectLockLegalHoldStatus
- private Amazon.S3.ObjectLockMode objectLockMode
- private System.Nullable<System.DateTime> objectLockRetainUntilDate
- private Amazon.S3.RequestPayer requestPayer
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideCustomerEncryption
- private Amazon.S3.ServerSideEncryptionMethod serverSideEncryption
- private string serverSideEncryptionCustomerProvidedKey
- private string serverSideEncryptionCustomerProvidedKeyMD5
- private string serverSideEncryptionKeyManagementServiceEncryptionContext
- private string serverSideEncryptionKeyManagementServiceKeyId
- private Amazon.S3.S3StorageClass storageClass
- private System.Collections.Generic.List<Amazon.S3.Model.Tag> tagset
- private bool useChunkEncoding
- private string websiteRedirectLocation

#### Properties
- public bool AutoCloseStream { get; set; }
- public bool AutoResetStreamPosition { get; set; }
- public string BucketName { get; set; }
- public Amazon.S3.S3CannedACL CannedACL { get; set; }
- public string ContentBody { get; set; }
- public string ContentType { get; set; }
- protected bool Expect100Continue { get; }
- public string FilePath { get; set; }
- public Amazon.S3.Model.HeadersCollection Headers { get; internal set; }
- protected bool IncludeSHA256Header { get; }
- public System.IO.Stream InputStream { get; set; }
- public string Key { get; set; }
- public string MD5Digest { get; set; }
- public Amazon.S3.Model.MetadataCollection Metadata { get; internal set; }
- public Amazon.S3.ObjectLockLegalHoldStatus ObjectLockLegalHoldStatus { get; set; }
- public Amazon.S3.ObjectLockMode ObjectLockMode { get; set; }
- public System.DateTime ObjectLockRetainUntilDate { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionCustomerProvidedKey { get; set; }
- public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }
- public string ServerSideEncryptionKeyManagementServiceEncryptionContext { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }
- public Amazon.S3.S3StorageClass StorageClass { get; set; }
- public System.EventHandler<Amazon.Runtime.StreamTransferProgressArgs> StreamTransferProgress { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.Tag> TagSet { get; set; }
- public bool UseChunkEncoding { get; set; }
- public string WebsiteRedirectLocation { get; set; }

#### Constructors
- public PutObjectRequest()

#### Methods
- internal bool IsSetBucket()
- internal bool IsSetCannedACL()
- internal bool IsSetInputStream()
- internal bool IsSetKey()
- internal bool IsSetMD5Digest()
- internal bool IsSetObjectLockLegalHoldStatus()
- internal bool IsSetObjectLockMode()
- internal bool IsSetObjectLockRetainUntilDate()
- internal bool IsSetRequestPayer()
- internal bool IsSetServerSideEncryptionCustomerMethod()
- internal bool IsSetServerSideEncryptionCustomerProvidedKey()
- internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
- internal bool IsSetServerSideEncryptionKeyManagementServiceEncryptionContext()
- internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
- internal bool IsSetServerSideEncryptionMethod()
- internal bool IsSetStorageClass()
- internal bool IsSetTagSet()
- internal bool IsSetWebsiteRedirectLocation()
- internal void SetupForFilePath()

### public class Amazon.S3.Model.PutObjectResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string eTag
- private Amazon.S3.Model.Expiration expiration
- private Amazon.S3.RequestCharged requestCharged
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideCustomerEncryption
- private Amazon.S3.ServerSideEncryptionMethod serverSideEncryption
- private string serverSideEncryptionCustomerProvidedKeyMD5
- private string serverSideEncryptionKeyManagementServiceEncryptionContext
- private string serverSideEncryptionKeyManagementServiceKeyId
- private string versionId

#### Properties
- public string ETag { get; set; }
- public Amazon.S3.Model.Expiration Expiration { get; set; }
- public Amazon.S3.RequestCharged RequestCharged { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }
- public string ServerSideEncryptionKeyManagementServiceEncryptionContext { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public PutObjectResponse()

#### Methods
- internal bool IsSetETag()
- internal bool IsSetRequestCharged()
- internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.PutObjectRetentionRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string _bucketName
- private System.Nullable<bool> _bypassGovernanceRetention
- private string _contentMD5
- private string _key
- private Amazon.S3.RequestPayer _requestPayer
- private Amazon.S3.Model.ObjectLockRetention _retention
- private string _versionId

#### Properties
- public string BucketName { get; set; }
- public bool BypassGovernanceRetention { get; set; }
- public string ContentMD5 { get; set; }
- public string Key { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public Amazon.S3.Model.ObjectLockRetention Retention { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public PutObjectRetentionRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetBypassGovernanceRetention()
- internal bool IsSetContentMD5()
- internal bool IsSetKey()
- internal bool IsSetRequestPayer()
- internal bool IsSetRetention()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.PutObjectRetentionResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.RequestCharged _requestCharged

#### Properties
- public Amazon.S3.RequestCharged RequestCharged { get; set; }

#### Constructors
- public PutObjectRetentionResponse()

#### Methods
- internal bool IsSetRequestCharged()

### public class Amazon.S3.Model.PutObjectTaggingRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string key
- private string md5Digest
- private Amazon.S3.Model.Tagging tagging
- private string versionId

#### Properties
- public string BucketName { get; set; }
- public string Key { get; set; }
- public Amazon.S3.Model.Tagging Tagging { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public PutObjectTaggingRequest()

#### Methods
- internal bool IsSetBucket()
- internal bool IsSetKey()
- internal bool IsSetTagging()
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.PutObjectTaggingResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string versionId

#### Properties
- public string VersionId { get; set; }

#### Constructors
- public PutObjectTaggingResponse()

#### Methods
- internal bool IsSetVersionId()

### public class Amazon.S3.Model.PutPublicAccessBlockRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private string contentMD5
- private Amazon.S3.Model.PublicAccessBlockConfiguration publicAccessBlockConfiguration

#### Properties
- public string BucketName { get; set; }
- public string ContentMD5 { get; set; }
- public Amazon.S3.Model.PublicAccessBlockConfiguration PublicAccessBlockConfiguration { get; set; }

#### Constructors
- public PutPublicAccessBlockRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetContentMD5()
- internal bool IsSetPublicAccessBlockConfiguration()

### public class Amazon.S3.Model.PutPublicAccessBlockResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Constructors
- public PutPublicAccessBlockResponse()

### public class Amazon.S3.Model.PutWithACLRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Model.S3Grant> _grants

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.S3Grant> Grants { get; set; }

#### Constructors
- protected PutWithACLRequest()

### public class Amazon.S3.Model.QueueConfiguration
- Base: Amazon.S3.Model.NotificationConfiguration

#### Fields
- private string <Id>k__BackingField
- private string <Queue>k__BackingField

#### Properties
- public string Id { get; set; }
- public string Queue { get; set; }

#### Constructors
- public QueueConfiguration()

#### Methods
- internal bool IsSetId()
- internal bool IsSetQueue()

### public class Amazon.S3.Model.RecordsEvent
- Interfaces: Amazon.S3.Model.IS3Event, Amazon.Runtime.EventStreams.Internal.IEventStreamEvent

#### Fields
- private System.IO.Stream <Payload>k__BackingField

#### Properties
- public System.IO.Stream Payload { get; set; }

#### Constructors
- public RecordsEvent()
- public RecordsEvent(Amazon.Runtime.EventStreams.IEventStreamMessage message)

### public class Amazon.S3.Model.ReplicationConfiguration

#### Fields
- private string role
- private System.Collections.Generic.List<Amazon.S3.Model.ReplicationRule> rules

#### Properties
- public string Role { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.ReplicationRule> Rules { get; set; }

#### Constructors
- public ReplicationConfiguration()

#### Methods
- internal bool IsSetRole()
- internal bool IsSetRules()

### public class Amazon.S3.Model.ReplicationDestination

#### Fields
- private Amazon.S3.Model.AccessControlTranslation accessControlTranslation
- private string accountId
- private string bucketArn
- private Amazon.S3.Model.EncryptionConfiguration encryptionConfiguration
- private Amazon.S3.S3StorageClass storageClass

#### Properties
- public Amazon.S3.Model.AccessControlTranslation AccessControlTranslation { get; set; }
- public string AccountId { get; set; }
- public string BucketArn { get; set; }
- public Amazon.S3.Model.EncryptionConfiguration EncryptionConfiguration { get; set; }
- public Amazon.S3.S3StorageClass StorageClass { get; set; }

#### Constructors
- public ReplicationDestination()

#### Methods
- public bool IsSetAccessControlTranslation()
- public bool IsSetAccountId()
- internal bool IsSetBucketArn()
- public bool IsSetEncryptionConfiguration()
- internal bool IsSetStorageClass()

### public class Amazon.S3.Model.ReplicationRule

#### Fields
- private Amazon.S3.Model.DeleteMarkerReplication deleteMarkerReplication
- private Amazon.S3.Model.ReplicationDestination destination
- private Amazon.S3.Model.ReplicationRuleFilter filter
- private string id
- private string prefix
- private System.Nullable<int> priority
- private Amazon.S3.Model.SourceSelectionCriteria sourceSelectionCriteria
- private Amazon.S3.ReplicationRuleStatus status

#### Properties
- public Amazon.S3.Model.DeleteMarkerReplication DeleteMarkerReplication { get; set; }
- public Amazon.S3.Model.ReplicationDestination Destination { get; set; }
- public Amazon.S3.Model.ReplicationRuleFilter Filter { get; set; }
- public string Id { get; set; }
- public string Prefix { get; set; }
- public int Priority { get; set; }
- public Amazon.S3.Model.SourceSelectionCriteria SourceSelectionCriteria { get; set; }
- public Amazon.S3.ReplicationRuleStatus Status { get; set; }

#### Constructors
- public ReplicationRule()

#### Methods
- internal bool IsSetDeleteMarkerReplication()
- internal bool IsSetDestination()
- internal bool IsSetFilter()
- internal bool IsSetId()
- internal bool IsSetPrefix()
- internal bool IsSetPriority()
- internal bool IsSetSourceSelectionCriteria()
- internal bool IsSetStatus()

### public class Amazon.S3.Model.ReplicationRuleAndOperator

#### Fields
- private string prefix
- private System.Collections.Generic.List<Amazon.S3.Model.Tag> tags

#### Properties
- public string Prefix { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.Tag> Tags { get; set; }

#### Constructors
- public ReplicationRuleAndOperator()

#### Methods
- internal bool IsSetPrefix()
- internal bool IsSetTags()

### public class Amazon.S3.Model.ReplicationRuleFilter

#### Fields
- private Amazon.S3.Model.ReplicationRuleAndOperator and
- private string prefix
- private Amazon.S3.Model.Tag tag

#### Properties
- public Amazon.S3.Model.ReplicationRuleAndOperator And { get; set; }
- public string Prefix { get; set; }
- public Amazon.S3.Model.Tag Tag { get; set; }

#### Constructors
- public ReplicationRuleFilter()

#### Methods
- internal bool IsSetAnd()
- internal bool IsSetPrefix()
- internal bool IsSetTag()

### public class Amazon.S3.Model.RequestPaymentConfiguration

#### Fields
- private string payer

#### Properties
- public string Payer { get; set; }

#### Constructors
- public RequestPaymentConfiguration()

#### Methods
- internal bool IsSetPayer()

### public class Amazon.S3.Model.ResponseHeaderOverrides

#### Fields
- internal static const string RESPONSE_CACHE_CONTROL
- internal static const string RESPONSE_CONTENT_DISPOSITION
- internal static const string RESPONSE_CONTENT_ENCODING
- internal static const string RESPONSE_CONTENT_LANGUAGE
- internal static const string RESPONSE_CONTENT_TYPE
- internal static const string RESPONSE_EXPIRES
- private string _cacheControl
- private string _contentDisposition
- private string _contentEncoding
- private string _contentLanguage
- private string _contentType
- private string _expires

#### Properties
- public string CacheControl { get; set; }
- public string ContentDisposition { get; set; }
- public string ContentEncoding { get; set; }
- public string ContentLanguage { get; set; }
- public string ContentType { get; set; }
- public string Expires { get; set; }

#### Constructors
- public ResponseHeaderOverrides()

### public class Amazon.S3.Model.RestoreObjectRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string bucketName
- private System.Nullable<int> days
- private string description
- private string key
- private Amazon.S3.Model.OutputLocation outputLocation
- private Amazon.S3.RequestPayer requestPayer
- private Amazon.S3.GlacierJobTier retrievalTier
- private Amazon.S3.Model.SelectParameters selectParameters
- private Amazon.S3.GlacierJobTier tier
- private Amazon.S3.RestoreRequestType type
- private string versionId

#### Properties
- public string BucketName { get; set; }
- public int Days { get; set; }
- public string Description { get; set; }
- public string Key { get; set; }
- public Amazon.S3.Model.OutputLocation OutputLocation { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public Amazon.S3.RestoreRequestType RestoreRequestType { get; set; }
- public Amazon.S3.GlacierJobTier RetrievalTier { get; set; }
- public Amazon.S3.Model.SelectParameters SelectParameters { get; set; }
- public Amazon.S3.GlacierJobTier Tier { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public RestoreObjectRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetDays()
- internal bool IsSetDescription()
- internal bool IsSetKey()
- internal bool IsSetOutputLocation()
- internal bool IsSetRequestPayer()
- internal bool IsSetRetrievalTier()
- internal bool IsSetSelectParameters()
- internal bool IsSetTier()
- internal bool IsSetType()
- internal bool IsSetVersionId()
- internal void Marshall(string propertyName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.RestoreObjectResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.RequestCharged requestCharged
- private string restoreOutputPath

#### Properties
- public Amazon.S3.RequestCharged RequestCharged { get; set; }
- public string RestoreOutputPath { get; set; }

#### Constructors
- public RestoreObjectResponse()

#### Methods
- internal bool IsSetRequestCharged()
- internal bool IsSetRestoreOutputPath()

### public class Amazon.S3.Model.RoutingRule

#### Fields
- private Amazon.S3.Model.RoutingRuleCondition condition
- private Amazon.S3.Model.RoutingRuleRedirect redirect

#### Properties
- public Amazon.S3.Model.RoutingRuleCondition Condition { get; set; }
- public Amazon.S3.Model.RoutingRuleRedirect Redirect { get; set; }

#### Constructors
- public RoutingRule()

#### Methods
- internal bool IsSetCondition()
- internal bool IsSetRedirect()

### public class Amazon.S3.Model.RoutingRuleCondition

#### Fields
- private string httpErrorCodeReturnedEquals
- private string keyPrefixEquals

#### Properties
- public string HttpErrorCodeReturnedEquals { get; set; }
- public string KeyPrefixEquals { get; set; }

#### Constructors
- public RoutingRuleCondition()

#### Methods
- internal bool IsSetHttpErrorCodeReturnedEquals()
- internal bool IsSetKeyPrefixEquals()

### public class Amazon.S3.Model.RoutingRuleRedirect

#### Fields
- private string hostName
- private string httpRedirectCode
- private string protocol
- private string replaceKeyPrefixWith
- private string replaceKeyWith

#### Properties
- public string HostName { get; set; }
- public string HttpRedirectCode { get; set; }
- public string Protocol { get; set; }
- public string ReplaceKeyPrefixWith { get; set; }
- public string ReplaceKeyWith { get; set; }

#### Constructors
- public RoutingRuleRedirect()

#### Methods
- internal bool IsSetHostName()
- internal bool IsSetHttpRedirectCode()
- internal bool IsSetProtocol()
- internal bool IsSetReplaceKeyPrefixWith()
- internal bool IsSetReplaceKeyWith()

### public class Amazon.S3.Model.S3AccessControlList

#### Fields
- private Amazon.S3.Model.Owner <Owner>k__BackingField
- private System.Collections.Generic.List<Amazon.S3.Model.S3Grant> grantList

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.S3Grant> Grants { get; set; }
- public Amazon.S3.Model.Owner Owner { get; set; }

#### Constructors
- public S3AccessControlList()

#### Methods
- public void AddGrant(Amazon.S3.Model.S3Grantee grantee, Amazon.S3.S3Permission permission)
- internal bool IsSetGrants()
- internal bool IsSetOwner()
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)
- public void RemoveGrant(Amazon.S3.Model.S3Grantee grantee, Amazon.S3.S3Permission permission)
- public void RemoveGrant(Amazon.S3.Model.S3Grantee grantee)

### public class Amazon.S3.Model.S3Bucket

#### Fields
- private string bucketName
- private System.Nullable<System.DateTime> creationDate

#### Properties
- public string BucketName { get; set; }
- public System.DateTime CreationDate { get; set; }

#### Constructors
- public S3Bucket()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetCreationDate()

### public class Amazon.S3.Model.S3BucketLoggingConfig

#### Fields
- private string <TargetBucketName>k__BackingField
- private string <TargetPrefix>k__BackingField
- private System.Collections.Generic.List<Amazon.S3.Model.S3Grant> targetGrants

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.S3Grant> Grants { get; set; }
- public string TargetBucketName { get; set; }
- public string TargetPrefix { get; set; }

#### Constructors
- public S3BucketLoggingConfig()

#### Methods
- public void AddGrant(Amazon.S3.Model.S3Grantee grantee, Amazon.S3.S3Permission permission)
- internal bool IsSetGrants()
- internal bool IsSetTargetBucket()
- internal bool IsSetTargetPrefix()
- public void RemoveGrant(Amazon.S3.Model.S3Grantee grantee, Amazon.S3.S3Permission permission)
- public void RemoveGrant(Amazon.S3.Model.S3Grantee grantee)

### public class Amazon.S3.Model.S3BucketVersioningConfig

#### Fields
- private System.Nullable<bool> enableMfaDelete
- private Amazon.S3.VersionStatus status

#### Properties
- public bool EnableMfaDelete { get; set; }
- public Amazon.S3.VersionStatus Status { get; set; }

#### Constructors
- public S3BucketVersioningConfig()

#### Methods
- internal bool IsSetEnableMfaDelete()
- internal bool IsSetStatus()

### public class Amazon.S3.Model.S3Encryption

#### Fields
- private Amazon.S3.ServerSideEncryptionMethod <EncryptionType>k__BackingField
- private string <KMSContext>k__BackingField
- private string <KMSKeyId>k__BackingField

#### Properties
- public Amazon.S3.ServerSideEncryptionMethod EncryptionType { get; set; }
- public string KMSContext { get; set; }
- public string KMSKeyId { get; set; }

#### Constructors
- public S3Encryption()

#### Methods
- internal bool IsSetEncryptionType()
- internal bool IsSetKMSContext()
- internal bool IsSetKMSKeyId()
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.S3EventStreamException
- Base: Amazon.Runtime.EventStreams.Internal.EventStreamException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public S3EventStreamException()
- public S3EventStreamException(string message)
- public S3EventStreamException(string message, System.Exception innerException)

### public class Amazon.S3.Model.S3Grant

#### Fields
- private Amazon.S3.Model.S3Grantee grantee
- private Amazon.S3.S3Permission permission

#### Properties
- public Amazon.S3.Model.S3Grantee Grantee { get; set; }
- public Amazon.S3.S3Permission Permission { get; set; }

#### Constructors
- public S3Grant()

#### Methods
- internal bool IsSetGrantee()
- internal bool IsSetPermission()
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.S3Grantee

#### Fields
- private string canonicalUser
- private string displayName
- private string emailAddress
- private string uRI

#### Properties
- public string CanonicalUser { get; set; }
- public string DisplayName { get; set; }
- public string EmailAddress { get; set; }
- public Amazon.S3.GranteeType Type { get; }
- public string URI { get; set; }

#### Constructors
- public S3Grantee()

#### Methods
- internal bool IsSetCanonicalUser()
- internal bool IsSetDisplayName()
- internal bool IsSetEmailAddress()
- internal bool IsSetType()
- internal bool IsSetURI()

### public class Amazon.S3.Model.S3KeyFilter

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Model.FilterRule> filterRules

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.FilterRule> FilterRules { get; set; }

#### Constructors
- public S3KeyFilter()

#### Methods
- internal bool IsSetFilterRules()

### public class Amazon.S3.Model.S3Location

#### Fields
- private Amazon.S3.Model.S3AccessControlList <AccessControlList>k__BackingField
- private string <BucketName>k__BackingField
- private Amazon.S3.S3CannedACL <CannedACL>k__BackingField
- private Amazon.S3.Model.S3Encryption <Encryption>k__BackingField
- private string <Prefix>k__BackingField
- private Amazon.S3.S3StorageClass <StorageClass>k__BackingField
- private Amazon.S3.Model.Tagging <Tagging>k__BackingField
- private Amazon.S3.Model.MetadataCollection <UserMetadata>k__BackingField

#### Properties
- public Amazon.S3.Model.S3AccessControlList AccessControlList { get; set; }
- public string BucketName { get; set; }
- public Amazon.S3.S3CannedACL CannedACL { get; set; }
- public Amazon.S3.Model.S3Encryption Encryption { get; set; }
- public string Prefix { get; set; }
- public Amazon.S3.S3StorageClass StorageClass { get; set; }
- public Amazon.S3.Model.Tagging Tagging { get; set; }
- public Amazon.S3.Model.MetadataCollection UserMetadata { get; set; }

#### Constructors
- public S3Location()

#### Methods
- internal bool IsSetAccessControlList()
- internal bool IsSetBucketName()
- internal bool IsSetCannedACL()
- internal bool IsSetEncryption()
- internal bool IsSetPrefix()
- internal bool IsSetStorageClass()
- internal bool IsSetTagging()
- internal bool IsSetUserMetadata()
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.S3Object

#### Fields
- private string bucketName
- private string eTag
- private string key
- private System.Nullable<System.DateTime> lastModified
- private Amazon.S3.Model.Owner owner
- private System.Nullable<long> size
- private Amazon.S3.S3StorageClass storageClass

#### Properties
- public string BucketName { get; set; }
- public string ETag { get; set; }
- public string Key { get; set; }
- public System.DateTime LastModified { get; set; }
- public Amazon.S3.Model.Owner Owner { get; set; }
- public long Size { get; set; }
- public Amazon.S3.S3StorageClass StorageClass { get; set; }

#### Constructors
- public S3Object()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetETag()
- internal bool IsSetKey()
- internal bool IsSetLastModified()
- internal bool IsSetOwner()
- internal bool IsSetSize()
- internal bool IsSetStorageClass()

### public class Amazon.S3.Model.S3ObjectVersion
- Base: Amazon.S3.Model.S3Object

#### Fields
- private bool isDeleteMarker
- private System.Nullable<bool> isLatest
- private string versionId

#### Properties
- public bool IsDeleteMarker { get; set; }
- public bool IsLatest { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public S3ObjectVersion()

### public class Amazon.S3.Model.SelectObjectContentEventStream
- Base: Amazon.Runtime.EventStreams.Internal.EnumerableEventStream<Amazon.S3.Model.IS3Event, Amazon.S3.Model.S3EventStreamException>
- Interfaces: Amazon.Runtime.EventStreams.Internal.IEventStream<Amazon.S3.Model.IS3Event, Amazon.S3.Model.S3EventStreamException>, System.IDisposable, Amazon.Runtime.EventStreams.Internal.IEnumerableEventStream<Amazon.S3.Model.IS3Event, Amazon.S3.Model.S3EventStreamException>, System.Collections.Generic.IEnumerable<Amazon.S3.Model.IS3Event>, System.Collections.IEnumerable, Amazon.S3.Model.ISelectObjectContentEventStream

#### Fields
- private readonly System.Collections.Generic.IDictionary<string, System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, Amazon.S3.Model.IS3Event>> <EventMapping>k__BackingField
- private readonly System.Collections.Generic.IDictionary<string, System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, Amazon.S3.Model.S3EventStreamException>> <ExceptionMapping>k__BackingField
- private System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.ContinuationEvent>> ContinuationEventReceived
- private System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.EndEvent>> EndEventReceived
- private System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.IS3Event>> EventReceived
- private System.EventHandler<Amazon.Runtime.EventStreams.EventStreamExceptionReceivedArgs<Amazon.S3.Model.S3EventStreamException>> ExceptionReceived
- private System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.ProgressEvent>> ProgressEventReceived
- private System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.RecordsEvent>> RecordsEventReceived
- private System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.StatsEvent>> StatsEventReceived
- private bool _isProcessing

#### Properties
- protected System.Collections.Generic.IDictionary<string, System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, Amazon.S3.Model.IS3Event>> EventMapping { get; }
- protected System.Collections.Generic.IDictionary<string, System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, Amazon.S3.Model.S3EventStreamException>> ExceptionMapping { get; }
- protected bool IsProcessing { get; set; }

#### Events
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.ContinuationEvent>> ContinuationEventReceived
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.EndEvent>> EndEventReceived
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.IS3Event>> EventReceived
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamExceptionReceivedArgs<Amazon.S3.Model.S3EventStreamException>> ExceptionReceived
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.ProgressEvent>> ProgressEventReceived
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.RecordsEvent>> RecordsEventReceived
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.StatsEvent>> StatsEventReceived

#### Constructors
- public SelectObjectContentEventStream(System.IO.Stream selectObjectStream)
- public SelectObjectContentEventStream(System.IO.Stream selectObjectStream, Amazon.Runtime.EventStreams.Internal.IEventStreamDecoder eventStreamDecoder)

#### Methods
- private void <.ctor>b__32_0(object sender, Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<Amazon.S3.Model.IS3Event> args)
- private void <.ctor>b__32_1(object sender, Amazon.Runtime.EventStreams.EventStreamExceptionReceivedArgs<Amazon.S3.Model.S3EventStreamException> args)
- private void <.ctor>b__32_2(object sender, Amazon.Runtime.EventStreams.Internal.EventStreamMessageReceivedEventArgs args)
- private bool RaiseEvent<T>(System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<T>> eventHandler, Amazon.S3.Model.IS3Event ev)

### public class Amazon.S3.Model.SelectObjectContentRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private string <Bucket>k__BackingField
- private string <Expression>k__BackingField
- private Amazon.S3.ExpressionType <ExpressionType>k__BackingField
- private Amazon.S3.Model.InputSerialization <InputSerialization>k__BackingField
- private string <Key>k__BackingField
- private Amazon.S3.Model.OutputSerialization <OutputSerialization>k__BackingField
- private System.Nullable<bool> <RequestProgress>k__BackingField
- private Amazon.S3.ServerSideEncryptionCustomerMethod <ServerSideCustomerEncryptionMethod>k__BackingField
- private string <ServerSideEncryptionCustomerProvidedKey>k__BackingField
- private string <ServerSideEncryptionCustomerProvidedKeyMD5>k__BackingField

#### Properties
- public string Bucket { get; set; }
- public string Expression { get; set; }
- public Amazon.S3.ExpressionType ExpressionType { get; set; }
- public Amazon.S3.Model.InputSerialization InputSerialization { get; set; }
- public string Key { get; set; }
- public Amazon.S3.Model.OutputSerialization OutputSerialization { get; set; }
- public System.Nullable<bool> RequestProgress { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideCustomerEncryptionMethod { get; set; }
- public string ServerSideEncryptionCustomerProvidedKey { get; set; }
- public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }

#### Constructors
- public SelectObjectContentRequest()

#### Methods
- internal bool IsSetBucket()
- internal bool IsSetExpression()
- internal bool IsSetExpressionType()
- internal bool IsSetInputSerialization()
- internal bool IsSetKey()
- internal bool IsSetOutputSerialization()
- internal bool IsSetRequestProgress()
- internal bool IsSetServerSideCustomerEncryptionMethod()
- internal bool IsSetServerSideEncryptionCustomerProvidedKey()
- internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()

### public class Amazon.S3.Model.SelectObjectContentResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private Amazon.S3.Model.ISelectObjectContentEventStream <Payload>k__BackingField

#### Properties
- public Amazon.S3.Model.ISelectObjectContentEventStream Payload { get; set; }

#### Constructors
- public SelectObjectContentResponse()

#### Methods
- internal bool IsSetPayload()

### public class Amazon.S3.Model.SelectParameters

#### Fields
- private string <Expression>k__BackingField
- private Amazon.S3.ExpressionType <ExpressionType>k__BackingField
- private Amazon.S3.Model.InputSerialization <InputSerialization>k__BackingField
- private Amazon.S3.Model.OutputSerialization <OutputSerialization>k__BackingField

#### Properties
- public string Expression { get; set; }
- public Amazon.S3.ExpressionType ExpressionType { get; set; }
- public Amazon.S3.Model.InputSerialization InputSerialization { get; set; }
- public Amazon.S3.Model.OutputSerialization OutputSerialization { get; set; }

#### Constructors
- public SelectParameters()

#### Methods
- internal bool IsSetExpression()
- internal bool IsSetExpressionType()
- internal bool IsSetInputSerialization()
- internal bool IsSetOutputSerialization()
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.ServerSideEncryptionByDefault

#### Fields
- private Amazon.S3.ServerSideEncryptionMethod serverSideEncryptionAlgorithm
- private string serverSideEncryptionKeyManagementServiceKeyId

#### Properties
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionAlgorithm { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }

#### Constructors
- public ServerSideEncryptionByDefault()

#### Methods
- internal bool IsSetServerSideEncryptionAlgorithm()
- internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()

### public class Amazon.S3.Model.ServerSideEncryptionConfiguration

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Model.ServerSideEncryptionRule> serverSideEncryptionRules

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.ServerSideEncryptionRule> ServerSideEncryptionRules { get; set; }

#### Constructors
- public ServerSideEncryptionConfiguration()

#### Methods
- internal bool IsSetServerSideEncryptionRules()

### public class Amazon.S3.Model.ServerSideEncryptionRule

#### Fields
- private Amazon.S3.Model.ServerSideEncryptionByDefault serverSideEncryptionByDefault

#### Properties
- public Amazon.S3.Model.ServerSideEncryptionByDefault ServerSideEncryptionByDefault { get; set; }

#### Constructors
- public ServerSideEncryptionRule()

#### Methods
- internal bool IsSetServerSideEncryptionByDefault()

### public class Amazon.S3.Model.SourceSelectionCriteria

#### Fields
- private Amazon.S3.Model.SseKmsEncryptedObjects sseKmsEncryptedObjects

#### Properties
- public Amazon.S3.Model.SseKmsEncryptedObjects SseKmsEncryptedObjects { get; set; }

#### Constructors
- public SourceSelectionCriteria()

#### Methods
- internal bool IsSetSseKmsEncryptedObjects()

### public class Amazon.S3.Model.SSEKMS

#### Fields
- private string keyId

#### Properties
- public string KeyId { get; set; }

#### Constructors
- public SSEKMS()

#### Methods
- internal bool IsSetKeyId()

### public class Amazon.S3.Model.SseKmsEncryptedObjects

#### Fields
- private Amazon.S3.SseKmsEncryptedObjectsStatus sseKmsEncryptedObjectsStatus

#### Properties
- public Amazon.S3.SseKmsEncryptedObjectsStatus SseKmsEncryptedObjectsStatus { get; set; }

#### Constructors
- public SseKmsEncryptedObjects()

#### Methods
- internal bool IsSetSseKmsEncryptedObjectsStatus()

### public class Amazon.S3.Model.SSES3

#### Constructors
- public SSES3()

### public class Amazon.S3.Model.Stats

#### Fields
- private long <BytesProcessed>k__BackingField
- private long <BytesReturned>k__BackingField
- private long <BytesScanned>k__BackingField

#### Properties
- public long BytesProcessed { get; set; }
- public long BytesReturned { get; set; }
- public long BytesScanned { get; set; }

#### Constructors
- public Stats()

#### Methods
- internal static Amazon.S3.Model.Stats Unmarshall(byte[] payload)

### public class Amazon.S3.Model.StatsEvent
- Interfaces: Amazon.S3.Model.IS3Event, Amazon.Runtime.EventStreams.Internal.IEventStreamEvent

#### Fields
- private Amazon.S3.Model.Stats <Details>k__BackingField

#### Properties
- public Amazon.S3.Model.Stats Details { get; set; }

#### Constructors
- public StatsEvent()
- public StatsEvent(Amazon.Runtime.EventStreams.IEventStreamMessage message)

### public class Amazon.S3.Model.StorageClassAnalysis

#### Fields
- private Amazon.S3.Model.StorageClassAnalysisDataExport storageClassAnalysisDataExport

#### Properties
- public Amazon.S3.Model.StorageClassAnalysisDataExport DataExport { get; set; }

#### Constructors
- public StorageClassAnalysis()

#### Methods
- internal bool IsSetDataExport()

### public class Amazon.S3.Model.StorageClassAnalysisDataExport

#### Fields
- private Amazon.S3.Model.AnalyticsExportDestination analyticsExportDestination
- private Amazon.S3.StorageClassAnalysisSchemaVersion storageClassAnalysisSchemaVersion

#### Properties
- public Amazon.S3.Model.AnalyticsExportDestination Destination { get; set; }
- public Amazon.S3.StorageClassAnalysisSchemaVersion OutputSchemaVersion { get; set; }

#### Constructors
- public StorageClassAnalysisDataExport()

#### Methods
- internal bool IsSetDestination()
- internal bool IsSetOutputSchemaVersion()

### public class Amazon.S3.Model.StreamResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse
- Interfaces: System.IDisposable

#### Fields
- private bool disposed
- private System.IO.Stream responseStream

#### Properties
- public System.IO.Stream ResponseStream { get; set; }

#### Constructors
- protected StreamResponse()

#### Methods
- public void Dispose()
- private void Dispose(bool disposing)
- internal bool IsSetResponseStream()

### public class Amazon.S3.Model.StreamSizeMismatchException
- Base: Amazon.S3.AmazonS3Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private long <ActualSize>k__BackingField
- private long <ExpectedSize>k__BackingField

#### Properties
- public long ActualSize { get; set; }
- public long ExpectedSize { get; set; }

#### Constructors
- public StreamSizeMismatchException(string message)
- public StreamSizeMismatchException(System.Exception innerException)
- public StreamSizeMismatchException(string message, System.Exception innerException)
- public StreamSizeMismatchException(string message, long expectedSize, long actualSize, string requestId, string amazonId2)
- public StreamSizeMismatchException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public StreamSizeMismatchException(string message, long expectedSize, long actualSize, string requestId, string amazonId2, string amazonCfId)
- public StreamSizeMismatchException(string message, System.Exception innerException, long expectedSize, long actualSize, string requestId, string amazonId2)
- public StreamSizeMismatchException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public StreamSizeMismatchException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode, string amazonId2)

### public class Amazon.S3.Model.Tag

#### Fields
- private string key
- private string value

#### Properties
- public string Key { get; set; }
- public string Value { get; set; }

#### Constructors
- public Tag()

#### Methods
- internal bool IsSetKey()
- internal bool IsSetValue()
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.Tagging

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Model.Tag> tagSet

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Model.Tag> TagSet { get; set; }

#### Constructors
- public Tagging()

#### Methods
- internal void Marshall(string memberName, System.Xml.XmlWriter xmlWriter)

### public class Amazon.S3.Model.TopicConfiguration
- Base: Amazon.S3.Model.NotificationConfiguration

#### Fields
- private string <Id>k__BackingField
- private string <Topic>k__BackingField

#### Properties
- public string Event { get; set; }
- public string Id { get; set; }
- public string Topic { get; set; }

#### Constructors
- public TopicConfiguration()

#### Methods
- internal bool IsSetId()
- internal bool IsSetTopic()

### public class Amazon.S3.Model.TransferProgressArgs
- Base: System.EventArgs

#### Fields
- private long _incrementTransferred
- private long _total
- private long _transferred

#### Properties
- internal long IncrementTransferred { get; }
- public int PercentDone { get; }
- public long TotalBytes { get; }
- public long TransferredBytes { get; }

#### Constructors
- public TransferProgressArgs(long incrementTransferred, long transferred, long total)

#### Methods
- public override string ToString()

### public class Amazon.S3.Model.UnknownEventStreamEvent
- Base: Amazon.Runtime.EventStreams.Internal.UnknownEventStreamEvent
- Interfaces: Amazon.Runtime.EventStreams.Internal.IEventStreamEvent, Amazon.S3.Model.IS3Event

#### Constructors
- public UnknownEventStreamEvent()
- public UnknownEventStreamEvent(Amazon.Runtime.EventStreams.IEventStreamMessage receivedMessage)
- public UnknownEventStreamEvent(Amazon.Runtime.EventStreams.IEventStreamMessage receivedMessage, string eventType)

### public class Amazon.S3.Model.UploadPartRequest
- Base: Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private int <IVSize>k__BackingField
- private string bucketName
- private string filePath
- private System.Nullable<long> filePosition
- private System.IO.Stream inputStream
- private string key
- private bool lastPart
- private string md5Digest
- private System.Nullable<int> partNumber
- private System.Nullable<long> partSize
- private Amazon.S3.RequestPayer requestPayer
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideCustomerEncryption
- private string serverSideEncryptionCustomerProvidedKey
- private string serverSideEncryptionCustomerProvidedKeyMD5
- private string uploadId
- private bool useChunkEncoding

#### Properties
- public string BucketName { get; set; }
- protected bool Expect100Continue { get; }
- public string FilePath { get; set; }
- public long FilePosition { get; set; }
- protected bool IncludeSHA256Header { get; }
- public System.IO.Stream InputStream { get; set; }
- public bool IsLastPart { get; set; }
- internal int IVSize { get; set; }
- public string Key { get; set; }
- public string MD5Digest { get; set; }
- public int PartNumber { get; set; }
- public long PartSize { get; set; }
- public Amazon.S3.RequestPayer RequestPayer { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionCustomerProvidedKey { get; set; }
- public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }
- public System.EventHandler<Amazon.Runtime.StreamTransferProgressArgs> StreamTransferProgress { get; set; }
- public string UploadId { get; set; }
- public bool UseChunkEncoding { get; set; }

#### Constructors
- public UploadPartRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetFilePath()
- internal bool IsSetFilePosition()
- internal bool IsSetInputStream()
- internal bool IsSetKey()
- internal bool IsSetMD5Digest()
- internal bool IsSetPartNumber()
- internal bool IsSetPartSize()
- internal bool IsSetRequestPayer()
- internal bool IsSetServerSideEncryptionCustomerMethod()
- internal bool IsSetServerSideEncryptionCustomerProvidedKey()
- internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
- internal bool IsSetUploadId()
- internal void SetupForFilePath()

### public class Amazon.S3.Model.UploadPartResponse
- Base: Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private string eTag
- private int partNumber
- private Amazon.S3.RequestCharged requestCharged
- private Amazon.S3.ServerSideEncryptionMethod serverSideEncryption

#### Properties
- public string ETag { get; set; }
- public int PartNumber { get; set; }
- public Amazon.S3.RequestCharged RequestCharged { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }

#### Constructors
- public UploadPartResponse()

#### Methods
- internal bool IsSetETag()
- internal bool IsSetRequestCharged()

### public class Amazon.S3.Model.WebsiteConfiguration

#### Fields
- private string errorDocument
- private string indexDocumentSuffix
- private Amazon.S3.Model.RoutingRuleRedirect redirectAllRequestsTo
- private System.Collections.Generic.List<Amazon.S3.Model.RoutingRule> routingRules

#### Properties
- public string ErrorDocument { get; set; }
- public string IndexDocumentSuffix { get; set; }
- public Amazon.S3.Model.RoutingRuleRedirect RedirectAllRequestsTo { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.RoutingRule> RoutingRules { get; set; }

#### Constructors
- public WebsiteConfiguration()

#### Methods
- internal bool IsSetErrorDocument()
- internal bool IsSetIndexDocumentSuffix()
- internal bool IsSetRedirectAllRequestsTo()
- internal bool IsSetRoutingRules()

### public class Amazon.S3.Model.WriteObjectProgressArgs
- Base: Amazon.S3.Model.TransferProgressArgs

#### Fields
- private string <BucketName>k__BackingField
- private string <FilePath>k__BackingField
- private bool <IsCompleted>k__BackingField
- private string <Key>k__BackingField
- private string <VersionId>k__BackingField

#### Properties
- public string BucketName { get; private set; }
- public string FilePath { get; private set; }
- public bool IsCompleted { get; private set; }
- public string Key { get; private set; }
- public string VersionId { get; private set; }

#### Constructors
- internal WriteObjectProgressArgs(string bucketName, string key, string versionId, long incrementTransferred, long transferred, long total, bool completed)
- internal WriteObjectProgressArgs(string bucketName, string key, string filePath, string versionId, long incrementTransferred, long transferred, long total, bool completed)

## Namespace: Amazon.S3.Model.Internal

### internal class Amazon.S3.Model.Internal.AnalyticsPredicateVisitor
- Interfaces: Amazon.S3.Model.Internal.IAnalyticsPredicateVisitor

#### Fields
- private readonly System.Xml.XmlWriter xmlWriter

#### Constructors
- public AnalyticsPredicateVisitor(System.Xml.XmlWriter xmlWriter)

#### Methods
- public void Visit(Amazon.S3.Model.AnalyticsPrefixPredicate analyticsPrefixPredicate)
- public void visit(Amazon.S3.Model.AnalyticsTagPredicate analyticsTagPredicate)
- public void visit(Amazon.S3.Model.AnalyticsAndOperator analyticsAndOperatorPredicate)

### internal interface Amazon.S3.Model.Internal.IAnalyticsPredicateVisitor

#### Methods
- public void Visit(Amazon.S3.Model.AnalyticsPrefixPredicate analyticsPrefixPredicate)
- public void visit(Amazon.S3.Model.AnalyticsTagPredicate analyticsTagPredicate)
- public void visit(Amazon.S3.Model.AnalyticsAndOperator analyticsAndOperatorPredicate)

### internal interface Amazon.S3.Model.Internal.IInventoryPredicateVisitor

#### Methods
- public void Visit(Amazon.S3.Model.InventoryPrefixPredicate inventoryPrefixPredicate)

### internal interface Amazon.S3.Model.Internal.ILifecyclePredicateVisitor

#### Methods
- public void Visit(Amazon.S3.Model.LifecyclePrefixPredicate lifecyclePrefixPredicate)
- public void Visit(Amazon.S3.Model.LifecycleTagPredicate lifecycleTagPredicate)
- public void Visit(Amazon.S3.Model.LifecycleAndOperator lifecycleAndOperator)

### internal interface Amazon.S3.Model.Internal.IMetricsPredicateVisitor

#### Methods
- public void Visit(Amazon.S3.Model.MetricsPrefixPredicate metricsPrefixPredicate)
- public void visit(Amazon.S3.Model.MetricsTagPredicate metricsTagPredicate)
- public void visit(Amazon.S3.Model.MetricsAndOperator metricsAndOperatorPredicate)

### internal class Amazon.S3.Model.Internal.InventoryPredicateVisitor
- Interfaces: Amazon.S3.Model.Internal.IInventoryPredicateVisitor

#### Fields
- private readonly System.Xml.XmlWriter xmlWriter

#### Constructors
- public InventoryPredicateVisitor(System.Xml.XmlWriter xmlWriter)

#### Methods
- public void Visit(Amazon.S3.Model.InventoryPrefixPredicate inventoryPrefixPredicate)

### internal class Amazon.S3.Model.Internal.LifecycleFilterPredicateMarshallVisitor
- Interfaces: Amazon.S3.Model.Internal.ILifecyclePredicateVisitor

#### Fields
- private System.Xml.XmlWriter xmlWriter

#### Constructors
- public LifecycleFilterPredicateMarshallVisitor(System.Xml.XmlWriter xmlWriter)

#### Methods
- public void Visit(Amazon.S3.Model.LifecyclePrefixPredicate lifecyclePrefixPredicate)
- public void Visit(Amazon.S3.Model.LifecycleTagPredicate lifecycleTagPredicate)
- public void Visit(Amazon.S3.Model.LifecycleAndOperator lifecycleAndOperator)

### internal class Amazon.S3.Model.Internal.MetricsPredicateVisitor
- Interfaces: Amazon.S3.Model.Internal.IMetricsPredicateVisitor

#### Fields
- private readonly System.Xml.XmlWriter xmlWriter

#### Constructors
- public MetricsPredicateVisitor(System.Xml.XmlWriter xmlWriter)

#### Methods
- public void Visit(Amazon.S3.Model.MetricsPrefixPredicate metricsPrefixPredicate)
- public void visit(Amazon.S3.Model.MetricsTagPredicate metricsTagPredicate)
- public void visit(Amazon.S3.Model.MetricsAndOperator metricsAndOperatorPredicate)

## Namespace: Amazon.S3.Model.Internal.MarshallTransformations

### public class Amazon.S3.Model.Internal.MarshallTransformations.AbortIncompleteMultipartUploadUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.LifecycleRuleAbortIncompleteMultipartUpload, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.LifecycleRuleAbortIncompleteMultipartUpload, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.AbortIncompleteMultipartUploadUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.AbortIncompleteMultipartUploadUnmarshaller Instance { get; }

#### Constructors
- public AbortIncompleteMultipartUploadUnmarshaller()

#### Methods
- public Amazon.S3.Model.LifecycleRuleAbortIncompleteMultipartUpload Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.LifecycleRuleAbortIncompleteMultipartUpload Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.AbortMultipartUploadRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.AbortMultipartUploadRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.AbortMultipartUploadRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.AbortMultipartUploadRequestMarshaller Instance { get; }

#### Constructors
- public AbortMultipartUploadRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.AbortMultipartUploadRequest abortMultipartUploadRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.AbortMultipartUploadResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.AbortMultipartUploadResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.AbortMultipartUploadResponseUnmarshaller Instance { get; }

#### Constructors
- public AbortMultipartUploadResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.AccessControlTranslationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.AccessControlTranslation, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.AccessControlTranslation, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.AccessControlTranslationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.AccessControlTranslationUnmarshaller Instance { get; }

#### Constructors
- public AccessControlTranslationUnmarshaller()

#### Methods
- public Amazon.S3.Model.AccessControlTranslation Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.AccessControlTranslation Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.AnalyticsConfigurationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.AnalyticsConfiguration, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.AnalyticsConfiguration, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.AnalyticsConfigurationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.AnalyticsConfigurationUnmarshaller Instance { get; }

#### Constructors
- public AnalyticsConfigurationUnmarshaller()

#### Methods
- public Amazon.S3.Model.AnalyticsConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.AnalyticsConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.AnalyticsExportDestinationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.AnalyticsExportDestination, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.AnalyticsExportDestination, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.AnalyticsExportDestinationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.AnalyticsExportDestinationUnmarshaller Instance { get; }

#### Constructors
- public AnalyticsExportDestinationUnmarshaller()

#### Methods
- public Amazon.S3.Model.AnalyticsExportDestination Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.AnalyticsExportDestination Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.AnalyticsPredicateListUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<System.Collections.Generic.List<Amazon.S3.Model.AnalyticsFilterPredicate>, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<System.Collections.Generic.List<Amazon.S3.Model.AnalyticsFilterPredicate>, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.AnalyticsPredicateListUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.AnalyticsPredicateListUnmarshaller Instance { get; }

#### Constructors
- public AnalyticsPredicateListUnmarshaller()

#### Methods
- public System.Collections.Generic.List<Amazon.S3.Model.AnalyticsFilterPredicate> Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public System.Collections.Generic.List<Amazon.S3.Model.AnalyticsFilterPredicate> Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.AnalyticsS3BucketDestinationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.AnalyticsS3BucketDestination, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.AnalyticsS3BucketDestination, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.AnalyticsS3BucketDestinationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.AnalyticsS3BucketDestinationUnmarshaller Instance { get; }

#### Constructors
- public AnalyticsS3BucketDestinationUnmarshaller()

#### Methods
- public Amazon.S3.Model.AnalyticsS3BucketDestination Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.AnalyticsS3BucketDestination Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.BucketUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.S3Bucket, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.S3Bucket, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.BucketUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.BucketUnmarshaller Instance { get; }

#### Constructors
- public BucketUnmarshaller()

#### Methods
- public Amazon.S3.Model.S3Bucket Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.S3Bucket Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.CommonPrefixesItemUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<string, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<string, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.CommonPrefixesItemUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.CommonPrefixesItemUnmarshaller Instance { get; }

#### Constructors
- public CommonPrefixesItemUnmarshaller()

#### Methods
- public string Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public string Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.CompleteMultipartUploadRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.CompleteMultipartUploadRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.CompleteMultipartUploadRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.CompleteMultipartUploadRequestMarshaller Instance { get; }

#### Constructors
- public CompleteMultipartUploadRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.CompleteMultipartUploadRequest completeMultipartUploadRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.CompleteMultipartUploadResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.CompleteMultipartUploadResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.CompleteMultipartUploadResponseUnmarshaller Instance { get; }

#### Constructors
- public CompleteMultipartUploadResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.CompleteMultipartUploadResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ContentsItemUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.S3Object, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.S3Object, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ContentsItemUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ContentsItemUnmarshaller Instance { get; }

#### Constructors
- public ContentsItemUnmarshaller()

#### Methods
- public Amazon.S3.Model.S3Object Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.S3Object Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.CopyObjectRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.CopyObjectRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.CopyObjectRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.CopyObjectRequestMarshaller Instance { get; }

#### Constructors
- public CopyObjectRequestMarshaller()

#### Methods
- private static string ConstructCopySourceHeaderValue(string bucket, string key, string version)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.CopyObjectRequest copyObjectRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.CopyObjectResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.CopyObjectResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.CopyObjectResponseUnmarshaller Instance { get; }

#### Constructors
- public CopyObjectResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.CopyObjectResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.CopyPartRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.CopyPartRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.CopyPartRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.CopyPartRequestMarshaller Instance { get; }

#### Constructors
- public CopyPartRequestMarshaller()

#### Methods
- private static string ConstructCopySourceHeaderValue(string bucket, string key, string version)
- private static string ConstructCopySourceRangeHeader(long firstByte, long lastByte)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.CopyPartRequest copyPartRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.CopyPartResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.CopyPartResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.CopyPartResponseUnmarshaller Instance { get; }

#### Constructors
- public CopyPartResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.CopyPartResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.CORSRuleUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.CORSRule, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.CORSRule, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.CORSRuleUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.CORSRuleUnmarshaller Instance { get; }

#### Constructors
- public CORSRuleUnmarshaller()

#### Methods
- public Amazon.S3.Model.CORSRule Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.CORSRule Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DefaultRetentionUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.DefaultRetention, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.DefaultRetention, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DefaultRetentionUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DefaultRetentionUnmarshaller Instance { get; }

#### Constructors
- public DefaultRetentionUnmarshaller()

#### Methods
- public Amazon.S3.Model.DefaultRetention Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.DefaultRetention Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketAnalyticsConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeleteBucketAnalyticsConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketAnalyticsConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketAnalyticsConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public DeleteBucketAnalyticsConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeleteBucketAnalyticsConfigurationRequest deleteBucketAnalyticsConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketAnalyticsConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketAnalyticsConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketAnalyticsConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteBucketAnalyticsConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketEncryptionRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeleteBucketEncryptionRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketEncryptionRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketEncryptionRequestMarshaller Instance { get; }

#### Constructors
- public DeleteBucketEncryptionRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeleteBucketEncryptionRequest deleteBucketEncryptionRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketEncryptionResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketEncryptionResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketEncryptionResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteBucketEncryptionResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketInventoryConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeleteBucketInventoryConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketInventoryConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketInventoryConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public DeleteBucketInventoryConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeleteBucketInventoryConfigurationRequest deleteInventoryConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketInventoryConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketInventoryConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketInventoryConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteBucketInventoryConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketMetricsConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeleteBucketMetricsConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketMetricsConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketMetricsConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public DeleteBucketMetricsConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeleteBucketMetricsConfigurationRequest deleteBucketMetricsConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketMetricsConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketMetricsConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketMetricsConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteBucketMetricsConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketPolicyRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeleteBucketPolicyRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketPolicyRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketPolicyRequestMarshaller Instance { get; }

#### Constructors
- public DeleteBucketPolicyRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeleteBucketPolicyRequest deleteBucketPolicyRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketPolicyResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketPolicyResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketPolicyResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteBucketPolicyResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketReplicationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeleteBucketReplicationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketReplicationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketReplicationRequestMarshaller Instance { get; }

#### Constructors
- public DeleteBucketReplicationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeleteBucketReplicationRequest deleteBucketReplicationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketReplicationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketReplicationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketReplicationResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteBucketReplicationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeleteBucketRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketRequestMarshaller Instance { get; }

#### Constructors
- public DeleteBucketRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeleteBucketRequest deleteBucketRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteBucketResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketTaggingRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeleteBucketTaggingRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketTaggingRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketTaggingRequestMarshaller Instance { get; }

#### Constructors
- public DeleteBucketTaggingRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeleteBucketTaggingRequest deleteBucketTaggingRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketTaggingResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketTaggingResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketTaggingResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteBucketTaggingResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketWebsiteRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeleteBucketWebsiteRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketWebsiteRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketWebsiteRequestMarshaller Instance { get; }

#### Constructors
- public DeleteBucketWebsiteRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeleteBucketWebsiteRequest deleteBucketWebsiteRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketWebsiteResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketWebsiteResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteBucketWebsiteResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteBucketWebsiteResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteCORSConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeleteCORSConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteCORSConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteCORSConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public DeleteCORSConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeleteCORSConfigurationRequest deleteCORSConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteCORSConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteCORSConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteCORSConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteCORSConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeletedObjectUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.DeletedObject, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.DeletedObject, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeletedObjectUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeletedObjectUnmarshaller Instance { get; }

#### Constructors
- public DeletedObjectUnmarshaller()

#### Methods
- public Amazon.S3.Model.DeletedObject Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.DeletedObject Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteLifecycleConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeleteLifecycleConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteLifecycleConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteLifecycleConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public DeleteLifecycleConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeleteLifecycleConfigurationRequest deleteLifecycleConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteLifecycleConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteLifecycleConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteLifecycleConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteLifecycleConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteMarkerReplicationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.DeleteMarkerReplication, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteMarkerReplicationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteMarkerReplicationUnmarshaller Instance { get; }

#### Constructors
- public DeleteMarkerReplicationUnmarshaller()

#### Methods
- public Amazon.S3.Model.DeleteMarkerReplication Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeleteObjectRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectRequestMarshaller Instance { get; }

#### Constructors
- public DeleteObjectRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeleteObjectRequest deleteObjectRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteObjectResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.DeleteObjectResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectsRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeleteObjectsRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectsRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectsRequestMarshaller Instance { get; }

#### Constructors
- public DeleteObjectsRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeleteObjectsRequest deleteObjectsRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectsResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectsResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectsResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteObjectsResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.DeleteObjectsResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectTaggingRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeleteObjectTaggingRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectTaggingRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectTaggingRequestMarshaller Instance { get; }

#### Constructors
- public DeleteObjectTaggingRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeleteObjectTaggingRequest deleteObjectTaggingRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectTaggingResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectTaggingResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectTaggingResponseUnmarshaller Instance { get; }

#### Constructors
- public DeleteObjectTaggingResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.DeleteObjectTaggingResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeletePublicAccessBlockRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.DeletePublicAccessBlockRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeletePublicAccessBlockRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeletePublicAccessBlockRequestMarshaller Instance { get; }

#### Constructors
- public DeletePublicAccessBlockRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.DeletePublicAccessBlockRequest deletePublicAccessBlockRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.DeletePublicAccessBlockResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.DeletePublicAccessBlockResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.DeletePublicAccessBlockResponseUnmarshaller Instance { get; }

#### Constructors
- public DeletePublicAccessBlockResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.EncryptionConfigurationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.EncryptionConfiguration, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.EncryptionConfiguration, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.EncryptionConfigurationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.EncryptionConfigurationUnmarshaller Instance { get; }

#### Constructors
- public EncryptionConfigurationUnmarshaller()

#### Methods
- public Amazon.S3.Model.EncryptionConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.EncryptionConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ErrorsItemUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.DeleteError, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.DeleteError, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ErrorsItemUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ErrorsItemUnmarshaller Instance { get; }

#### Constructors
- public ErrorsItemUnmarshaller()

#### Methods
- public Amazon.S3.Model.DeleteError Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.DeleteError Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ExpirationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.LifecycleRuleExpiration, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.LifecycleRuleExpiration, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ExpirationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ExpirationUnmarshaller Instance { get; }

#### Constructors
- public ExpirationUnmarshaller()

#### Methods
- public Amazon.S3.Model.LifecycleRuleExpiration Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.LifecycleRuleExpiration Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.FilterRuleUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.FilterRule, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.FilterRule, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.FilterRuleUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.FilterRuleUnmarshaller Instance { get; }

#### Constructors
- public FilterRuleUnmarshaller()

#### Methods
- public Amazon.S3.Model.FilterRule Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.FilterRule Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.FilterUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.Filter, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.Filter, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.FilterUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.FilterUnmarshaller Instance { get; }

#### Constructors
- public FilterUnmarshaller()

#### Methods
- public Amazon.S3.Model.Filter Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.Filter Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetACLRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetACLRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetACLRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetACLRequestMarshaller Instance { get; }

#### Constructors
- public GetACLRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetACLRequest getObjectAclRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetACLResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetACLResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetACLResponseUnmarshaller Instance { get; }

#### Constructors
- public GetACLResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetACLResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketAccelerateConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketAccelerateConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketAccelerateConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketAccelerateConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketAccelerateConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketAccelerateConfigurationRequest getBucketAccelerateRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketAccelerateConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketAccelerateConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketAccelerateConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketAccelerateConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketAccelerateConfigurationResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketAnalyticsConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketAnalyticsConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketAnalyticsConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketAnalyticsConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketAnalyticsConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketAnalyticsConfigurationRequest getAnalyticsConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketAnalyticsConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketAnalyticsConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketAnalyticsConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketAnalyticsConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketAnalyticsConfigurationResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketEncryptionRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketEncryptionRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketEncryptionRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketEncryptionRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketEncryptionRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketEncryptionRequest getEncryptionRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketEncryptionResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketEncryptionResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketEncryptionResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketEncryptionResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketEncryptionResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketInventoryConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketInventoryConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketInventoryConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketInventoryConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketInventoryConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketInventoryConfigurationRequest getInventoryConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketInventoryConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketInventoryConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketInventoryConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketInventoryConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketInventoryConfigurationResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketLocationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketLocationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketLocationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketLocationRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketLocationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketLocationRequest getBucketLocationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketLocationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketLocationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketLocationResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketLocationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketLocationResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketLoggingRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketLoggingRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketLoggingRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketLoggingRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketLoggingRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketLoggingRequest getBucketLoggingRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketLoggingResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketLoggingResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketLoggingResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketLoggingResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketLoggingResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketMetricsConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketMetricsConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketMetricsConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketMetricsConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketMetricsConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketMetricsConfigurationRequest getBucketMetricsConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketMetricsConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketMetricsConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketMetricsConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketMetricsConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketMetricsConfigurationResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketNotificationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketNotificationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketNotificationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketNotificationRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketNotificationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketNotificationRequest getBucketNotificationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketNotificationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketNotificationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketNotificationResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketNotificationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketNotificationResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketPolicyRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketPolicyRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketPolicyRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketPolicyRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketPolicyRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketPolicyRequest getBucketPolicyRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketPolicyResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketPolicyResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketPolicyResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketPolicyResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketPolicyResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketPolicyStatusRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketPolicyStatusRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketPolicyStatusRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketPolicyStatusRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketPolicyStatusRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketPolicyStatusRequest getBucketPolicyStatusRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketPolicyStatusResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketPolicyStatusResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketPolicyStatusResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketPolicyStatusResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketPolicyStatusResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketReplicationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketReplicationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketReplicationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketReplicationRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketReplicationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketReplicationRequest getBucketReplicationConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketReplicationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketReplicationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketReplicationResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketReplicationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketReplicationResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketRequestPaymentRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketRequestPaymentRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketRequestPaymentRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketRequestPaymentRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketRequestPaymentRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketRequestPaymentRequest getBucketRequestPaymentRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketRequestPaymentResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketRequestPaymentResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketRequestPaymentResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketRequestPaymentResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketRequestPaymentResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketTaggingRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketTaggingRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketTaggingRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketTaggingRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketTaggingRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketTaggingRequest getBucketTaggingRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketTaggingResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketTaggingResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketTaggingResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketTaggingResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketTaggingResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketVersioningRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketVersioningRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketVersioningRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketVersioningRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketVersioningRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketVersioningRequest getBucketVersioningRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketVersioningResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketVersioningResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketVersioningResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketVersioningResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketVersioningResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketWebsiteRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetBucketWebsiteRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketWebsiteRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketWebsiteRequestMarshaller Instance { get; }

#### Constructors
- public GetBucketWebsiteRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetBucketWebsiteRequest getBucketWebsiteRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetBucketWebsiteResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketWebsiteResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetBucketWebsiteResponseUnmarshaller Instance { get; }

#### Constructors
- public GetBucketWebsiteResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetBucketWebsiteResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetCORSConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetCORSConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetCORSConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetCORSConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public GetCORSConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetCORSConfigurationRequest getCORSConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetCORSConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetCORSConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetCORSConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public GetCORSConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetCORSConfigurationResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetLifecycleConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetLifecycleConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetLifecycleConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetLifecycleConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public GetLifecycleConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetLifecycleConfigurationRequest getLifecycleConfiguration)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetLifecycleConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetLifecycleConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetLifecycleConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public GetLifecycleConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetLifecycleConfigurationResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetObjectLegalHoldRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetObjectLegalHoldRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectLegalHoldRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectLegalHoldRequestMarshaller Instance { get; }

#### Constructors
- public GetObjectLegalHoldRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetObjectLegalHoldRequest publicRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetObjectLegalHoldResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectLegalHoldResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectLegalHoldResponseUnmarshaller Instance { get; }

#### Constructors
- public GetObjectLegalHoldResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetObjectLegalHoldResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetObjectLockConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetObjectLockConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectLockConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectLockConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public GetObjectLockConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetObjectLockConfigurationRequest publicRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetObjectLockConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectLockConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectLockConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public GetObjectLockConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetObjectLockConfigurationResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetObjectMetadataRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetObjectMetadataRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectMetadataRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectMetadataRequestMarshaller Instance { get; }

#### Constructors
- public GetObjectMetadataRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetObjectMetadataRequest headObjectRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetObjectMetadataResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectMetadataResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectMetadataResponseUnmarshaller Instance { get; }

#### Constructors
- public GetObjectMetadataResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetObjectMetadataResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetObjectRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetObjectRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectRequestMarshaller Instance { get; }

#### Constructors
- public GetObjectRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetObjectRequest getObjectRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetObjectResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectResponseUnmarshaller _instance

#### Properties
- public bool HasStreamingProperty { get; }
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectResponseUnmarshaller Instance { get; }

#### Constructors
- public GetObjectResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetObjectResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetObjectRetentionRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetObjectRetentionRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectRetentionRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectRetentionRequestMarshaller Instance { get; }

#### Constructors
- public GetObjectRetentionRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetObjectRetentionRequest publicRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetObjectRetentionResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectRetentionResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectRetentionResponseUnmarshaller Instance { get; }

#### Constructors
- public GetObjectRetentionResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetObjectRetentionResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetObjectTaggingRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetObjectTaggingRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectTaggingRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectTaggingRequestMarshaller Instance { get; }

#### Constructors
- public GetObjectTaggingRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetObjectTaggingRequest getObjectTaggingRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetObjectTaggingResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectTaggingResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectTaggingResponseUnmarshaller Instance { get; }

#### Constructors
- public GetObjectTaggingResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetObjectTaggingResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetObjectTorrentRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetObjectTorrentRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectTorrentRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectTorrentRequestMarshaller Instance { get; }

#### Constructors
- public GetObjectTorrentRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetObjectTorrentRequest getObjectTorrentRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetObjectTorrentResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectTorrentResponseUnmarshaller _instance

#### Properties
- public bool HasStreamingProperty { get; }
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetObjectTorrentResponseUnmarshaller Instance { get; }

#### Constructors
- public GetObjectTorrentResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetObjectTorrentResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetPublicAccessBlockRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.GetPublicAccessBlockRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetPublicAccessBlockRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetPublicAccessBlockRequestMarshaller Instance { get; }

#### Constructors
- public GetPublicAccessBlockRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.GetPublicAccessBlockRequest getPublicAccessBlockRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GetPublicAccessBlockResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GetPublicAccessBlockResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GetPublicAccessBlockResponseUnmarshaller Instance { get; }

#### Constructors
- public GetPublicAccessBlockResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.GetPublicAccessBlockResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GranteeUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.S3Grantee, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.S3Grantee, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GranteeUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GranteeUnmarshaller Instance { get; }

#### Constructors
- public GranteeUnmarshaller()

#### Methods
- public Amazon.S3.Model.S3Grantee Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.S3Grantee Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.GrantUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.S3Grant, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.S3Grant, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.GrantUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.GrantUnmarshaller Instance { get; }

#### Constructors
- public GrantUnmarshaller()

#### Methods
- public Amazon.S3.Model.S3Grant Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.S3Grant Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### internal class Amazon.S3.Model.Internal.MarshallTransformations.HeadBucketRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.HeadBucketRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.HeadBucketRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.HeadBucketRequestMarshaller Instance { get; }

#### Constructors
- public HeadBucketRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.HeadBucketRequest headBucketRequest)

### internal class Amazon.S3.Model.Internal.MarshallTransformations.HeadBucketResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.HeadBucketResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.HeadBucketResponseUnmarshaller Instance { get; }

#### Constructors
- public HeadBucketResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public static class Amazon.S3.Model.Internal.MarshallTransformations.HeaderACLRequestMarshaller

#### Methods
- public static void Marshall(Amazon.Runtime.Internal.IRequest request, Amazon.S3.Model.PutWithACLRequest aclRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.InitiateMultipartUploadRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.InitiateMultipartUploadRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.InitiateMultipartUploadRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.InitiateMultipartUploadRequestMarshaller Instance { get; }

#### Constructors
- public InitiateMultipartUploadRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.InitiateMultipartUploadRequest initiateMultipartUploadRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.InitiateMultipartUploadResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.InitiateMultipartUploadResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.InitiateMultipartUploadResponseUnmarshaller Instance { get; }

#### Constructors
- public InitiateMultipartUploadResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.InitiateMultipartUploadResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.InitiatorUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.Initiator, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.Initiator, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.InitiatorUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.InitiatorUnmarshaller Instance { get; }

#### Constructors
- public InitiatorUnmarshaller()

#### Methods
- public Amazon.S3.Model.Initiator Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.Initiator Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.InventoryConfigurationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.InventoryConfiguration, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.InventoryConfiguration, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.InventoryConfigurationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.InventoryConfigurationUnmarshaller Instance { get; }

#### Constructors
- public InventoryConfigurationUnmarshaller()

#### Methods
- public Amazon.S3.Model.InventoryConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.InventoryConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.InventoryDestinationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.InventoryDestination, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.InventoryDestination, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.InventoryDestinationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.InventoryDestinationUnmarshaller Instance { get; }

#### Constructors
- public InventoryDestinationUnmarshaller()

#### Methods
- public Amazon.S3.Model.InventoryDestination Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.InventoryDestination Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.InventoryEncryptionUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.InventoryEncryption, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.InventoryEncryption, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.InventoryEncryptionUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.InventoryEncryptionUnmarshaller Instance { get; }

#### Constructors
- public InventoryEncryptionUnmarshaller()

#### Methods
- public Amazon.S3.Model.InventoryEncryption Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.InventoryEncryption Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.InventoryFilterUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.InventoryFilter, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.InventoryFilter, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.InventoryFilterUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.InventoryFilterUnmarshaller Instance { get; }

#### Constructors
- public InventoryFilterUnmarshaller()

#### Methods
- public Amazon.S3.Model.InventoryFilter Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.InventoryFilter Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.InventoryS3BucketDestinationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.InventoryS3BucketDestination, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.InventoryS3BucketDestination, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.InventoryS3BucketDestinationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.InventoryS3BucketDestinationUnmarshaller Instance { get; }

#### Constructors
- public InventoryS3BucketDestinationUnmarshaller()

#### Methods
- public Amazon.S3.Model.InventoryS3BucketDestination Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.InventoryS3BucketDestination Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.InventoryScheduleUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.InventorySchedule, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.InventorySchedule, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.InventoryScheduleUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.InventoryScheduleUnmarshaller Instance { get; }

#### Constructors
- public InventoryScheduleUnmarshaller()

#### Methods
- public Amazon.S3.Model.InventorySchedule Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.InventorySchedule Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.LambdaFunctionConfigurationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.LambdaFunctionConfiguration, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.LambdaFunctionConfiguration, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.LambdaFunctionConfigurationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.LambdaFunctionConfigurationUnmarshaller Instance { get; }

#### Constructors
- public LambdaFunctionConfigurationUnmarshaller()

#### Methods
- public Amazon.S3.Model.LambdaFunctionConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.LambdaFunctionConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.LifecycleFilterPredicateListUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<System.Collections.Generic.List<Amazon.S3.Model.LifecycleFilterPredicate>, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<System.Collections.Generic.List<Amazon.S3.Model.LifecycleFilterPredicate>, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.LifecycleFilterPredicateListUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.LifecycleFilterPredicateListUnmarshaller Instance { get; }

#### Constructors
- public LifecycleFilterPredicateListUnmarshaller()

#### Methods
- public System.Collections.Generic.List<Amazon.S3.Model.LifecycleFilterPredicate> Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public System.Collections.Generic.List<Amazon.S3.Model.LifecycleFilterPredicate> Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.LifecycleRuleNoncurrentVersionExpirationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.LifecycleRuleNoncurrentVersionExpiration, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.LifecycleRuleNoncurrentVersionExpiration, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.LifecycleRuleNoncurrentVersionExpirationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.LifecycleRuleNoncurrentVersionExpirationUnmarshaller Instance { get; }

#### Constructors
- public LifecycleRuleNoncurrentVersionExpirationUnmarshaller()

#### Methods
- public Amazon.S3.Model.LifecycleRuleNoncurrentVersionExpiration Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.LifecycleRuleNoncurrentVersionExpiration Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.LifecycleRuleNoncurrentVersionTransitionUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.LifecycleRuleNoncurrentVersionTransition, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.LifecycleRuleNoncurrentVersionTransition, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.LifecycleRuleNoncurrentVersionTransitionUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.LifecycleRuleNoncurrentVersionTransitionUnmarshaller Instance { get; }

#### Constructors
- public LifecycleRuleNoncurrentVersionTransitionUnmarshaller()

#### Methods
- public Amazon.S3.Model.LifecycleRuleNoncurrentVersionTransition Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.LifecycleRuleNoncurrentVersionTransition Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListBucketAnalyticsConfigurationsRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.ListBucketAnalyticsConfigurationsRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketAnalyticsConfigurationsRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketAnalyticsConfigurationsRequestMarshaller Instance { get; }

#### Constructors
- public ListBucketAnalyticsConfigurationsRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.ListBucketAnalyticsConfigurationsRequest listBucketAnalyticsConfigurationsRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListBucketAnalyticsConfigurationsResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketAnalyticsConfigurationsResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketAnalyticsConfigurationsResponseUnmarshaller Instance { get; }

#### Constructors
- public ListBucketAnalyticsConfigurationsResponseUnmarshaller()
- private static ListBucketAnalyticsConfigurationsResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.ListBucketAnalyticsConfigurationsResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListBucketInventoryConfigurationsRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.ListBucketInventoryConfigurationsRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketInventoryConfigurationsRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketInventoryConfigurationsRequestMarshaller Instance { get; }

#### Constructors
- public ListBucketInventoryConfigurationsRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.ListBucketInventoryConfigurationsRequest listBucketInventoryConfigurationsRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListBucketInventoryConfigurationsResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketInventoryConfigurationsResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketInventoryConfigurationsResponseUnmarshaller Instance { get; }

#### Constructors
- public ListBucketInventoryConfigurationsResponseUnmarshaller()
- private static ListBucketInventoryConfigurationsResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.ListBucketInventoryConfigurationsResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListBucketMetricsConfigurationsRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.ListBucketMetricsConfigurationsRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketMetricsConfigurationsRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketMetricsConfigurationsRequestMarshaller Instance { get; }

#### Constructors
- public ListBucketMetricsConfigurationsRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.ListBucketMetricsConfigurationsRequest listBucketMetricsConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListBucketMetricsConfigurationsResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketMetricsConfigurationsResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketMetricsConfigurationsResponseUnmarshaller Instance { get; }

#### Constructors
- public ListBucketMetricsConfigurationsResponseUnmarshaller()
- private static ListBucketMetricsConfigurationsResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.ListBucketMetricsConfigurationsResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListBucketsRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.ListBucketsRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketsRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketsRequestMarshaller Instance { get; }

#### Constructors
- public ListBucketsRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.ListBucketsRequest listBucketsRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListBucketsResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketsResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListBucketsResponseUnmarshaller Instance { get; }

#### Constructors
- public ListBucketsResponseUnmarshaller()
- private static ListBucketsResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.ListBucketsResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListMultipartUploadsRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.ListMultipartUploadsRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListMultipartUploadsRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListMultipartUploadsRequestMarshaller Instance { get; }

#### Constructors
- public ListMultipartUploadsRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.ListMultipartUploadsRequest listMultipartUploadsRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListMultipartUploadsResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListMultipartUploadsResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListMultipartUploadsResponseUnmarshaller Instance { get; }

#### Constructors
- public ListMultipartUploadsResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.ListMultipartUploadsResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListObjectsRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.ListObjectsRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListObjectsRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListObjectsRequestMarshaller Instance { get; }

#### Constructors
- public ListObjectsRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.ListObjectsRequest listObjectsRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListObjectsResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListObjectsResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListObjectsResponseUnmarshaller Instance { get; }

#### Constructors
- public ListObjectsResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.ListObjectsResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListObjectsV2RequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.ListObjectsV2Request>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListObjectsV2RequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListObjectsV2RequestMarshaller Instance { get; }

#### Constructors
- public ListObjectsV2RequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.ListObjectsV2Request listObjectsRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListObjectsV2ResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListObjectsV2ResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListObjectsV2ResponseUnmarshaller Instance { get; }

#### Constructors
- public ListObjectsV2ResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.ListObjectsV2Response response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListPartsRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.ListPartsRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListPartsRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListPartsRequestMarshaller Instance { get; }

#### Constructors
- public ListPartsRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.ListPartsRequest listPartsRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListPartsResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListPartsResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListPartsResponseUnmarshaller Instance { get; }

#### Constructors
- public ListPartsResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.ListPartsResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListVersionsRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.ListVersionsRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListVersionsRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListVersionsRequestMarshaller Instance { get; }

#### Constructors
- public ListVersionsRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.ListVersionsRequest listVersionsRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ListVersionsResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ListVersionsResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ListVersionsResponseUnmarshaller Instance { get; }

#### Constructors
- public ListVersionsResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.ListVersionsResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.LoggingEnabledUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.S3BucketLoggingConfig, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.S3BucketLoggingConfig, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.LoggingEnabledUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.LoggingEnabledUnmarshaller Instance { get; }

#### Constructors
- public LoggingEnabledUnmarshaller()

#### Methods
- public Amazon.S3.Model.S3BucketLoggingConfig Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.S3BucketLoggingConfig Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.MetricsConfigurationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.MetricsConfiguration, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.MetricsConfiguration, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.MetricsConfigurationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.MetricsConfigurationUnmarshaller Instance { get; }

#### Constructors
- public MetricsConfigurationUnmarshaller()

#### Methods
- public Amazon.S3.Model.MetricsConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.MetricsConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.MetricsPredicateListFilterUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<System.Collections.Generic.List<Amazon.S3.Model.MetricsFilterPredicate>, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<System.Collections.Generic.List<Amazon.S3.Model.MetricsFilterPredicate>, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.MetricsPredicateListFilterUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.MetricsPredicateListFilterUnmarshaller Instance { get; }

#### Constructors
- public MetricsPredicateListFilterUnmarshaller()

#### Methods
- public System.Collections.Generic.List<Amazon.S3.Model.MetricsFilterPredicate> Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public System.Collections.Generic.List<Amazon.S3.Model.MetricsFilterPredicate> Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.MultipartUploadUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.MultipartUpload, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.MultipartUpload, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.MultipartUploadUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.MultipartUploadUnmarshaller Instance { get; }

#### Constructors
- public MultipartUploadUnmarshaller()

#### Methods
- public Amazon.S3.Model.MultipartUpload Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.MultipartUpload Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ObjectLockConfigurationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ObjectLockConfiguration, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ObjectLockConfiguration, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ObjectLockConfigurationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ObjectLockConfigurationUnmarshaller Instance { get; }

#### Constructors
- public ObjectLockConfigurationUnmarshaller()

#### Methods
- public Amazon.S3.Model.ObjectLockConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.ObjectLockConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ObjectLockLegalHoldUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ObjectLockLegalHold, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ObjectLockLegalHold, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ObjectLockLegalHoldUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ObjectLockLegalHoldUnmarshaller Instance { get; }

#### Constructors
- public ObjectLockLegalHoldUnmarshaller()

#### Methods
- public Amazon.S3.Model.ObjectLockLegalHold Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.ObjectLockLegalHold Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ObjectLockRetentionUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ObjectLockRetention, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ObjectLockRetention, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ObjectLockRetentionUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ObjectLockRetentionUnmarshaller Instance { get; }

#### Constructors
- public ObjectLockRetentionUnmarshaller()

#### Methods
- public Amazon.S3.Model.ObjectLockRetention Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.ObjectLockRetention Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ObjectLockRuleUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ObjectLockRule, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ObjectLockRule, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ObjectLockRuleUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ObjectLockRuleUnmarshaller Instance { get; }

#### Constructors
- public ObjectLockRuleUnmarshaller()

#### Methods
- public Amazon.S3.Model.ObjectLockRule Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.ObjectLockRule Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.OwnerUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.Owner, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.Owner, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.OwnerUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.OwnerUnmarshaller Instance { get; }

#### Constructors
- public OwnerUnmarshaller()

#### Methods
- public Amazon.S3.Model.Owner Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.Owner Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PartDetailUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.PartDetail, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.PartDetail, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PartDetailUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PartDetailUnmarshaller Instance { get; }

#### Constructors
- public PartDetailUnmarshaller()

#### Methods
- public Amazon.S3.Model.PartDetail Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.PartDetail Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PolicyStatusUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.PolicyStatus, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.PolicyStatus, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PolicyStatusUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PolicyStatusUnmarshaller Instance { get; }

#### Constructors
- public PolicyStatusUnmarshaller()

#### Methods
- public Amazon.S3.Model.PolicyStatus Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.PolicyStatus Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PublicAccessBlockConfigurationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.PublicAccessBlockConfiguration, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.PublicAccessBlockConfiguration, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PublicAccessBlockConfigurationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PublicAccessBlockConfigurationUnmarshaller Instance { get; }

#### Constructors
- public PublicAccessBlockConfigurationUnmarshaller()

#### Methods
- public Amazon.S3.Model.PublicAccessBlockConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.PublicAccessBlockConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutACLRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutACLRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutACLRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutACLRequestMarshaller Instance { get; }

#### Constructors
- public PutACLRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutACLRequest putObjectAclRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutACLResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutACLResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutACLResponseUnmarshaller Instance { get; }

#### Constructors
- public PutACLResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketAccelerateConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutBucketAccelerateConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketAccelerateConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketAccelerateConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public PutBucketAccelerateConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutBucketAccelerateConfigurationRequest putBucketAccelerateRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketAccelerateConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketAccelerateConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketAccelerateConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public PutBucketAccelerateConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketAnalyticsConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutBucketAnalyticsConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketAnalyticsConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketAnalyticsConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public PutBucketAnalyticsConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutBucketAnalyticsConfigurationRequest putBucketAnalyticsConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketAnalyticsConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketAnalyticsConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketAnalyticsConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public PutBucketAnalyticsConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketEncryptionRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutBucketEncryptionRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketEncryptionRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketEncryptionRequestMarshaller Instance { get; }

#### Constructors
- public PutBucketEncryptionRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutBucketEncryptionRequest putBucketEncryptionRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketEncryptionResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketEncryptionResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketEncryptionResponseUnmarshaller Instance { get; }

#### Constructors
- public PutBucketEncryptionResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketInventoryConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutBucketInventoryConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketInventoryConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketInventoryConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public PutBucketInventoryConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutBucketInventoryConfigurationRequest putBucketInventoryConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketInventoryConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketInventoryConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketInventoryConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public PutBucketInventoryConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketLoggingRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutBucketLoggingRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketLoggingRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketLoggingRequestMarshaller Instance { get; }

#### Constructors
- public PutBucketLoggingRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutBucketLoggingRequest putBucketLoggingRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketLoggingResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketLoggingResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketLoggingResponseUnmarshaller Instance { get; }

#### Constructors
- public PutBucketLoggingResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketMetricsConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutBucketMetricsConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketMetricsConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketMetricsConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public PutBucketMetricsConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutBucketMetricsConfigurationRequest PutBucketMetricsConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketMetricsConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketMetricsConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketMetricsConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public PutBucketMetricsConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketNotificationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutBucketNotificationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketNotificationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketNotificationRequestMarshaller Instance { get; }

#### Constructors
- public PutBucketNotificationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutBucketNotificationRequest putBucketNotificationRequest)
- private static void WriteConfigurationCommon(System.Xml.XmlWriter xmlWriter, Amazon.S3.Model.NotificationConfiguration notificationConfiguration)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketNotificationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketNotificationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketNotificationResponseUnmarshaller Instance { get; }

#### Constructors
- public PutBucketNotificationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketPolicyRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutBucketPolicyRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketPolicyRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketPolicyRequestMarshaller Instance { get; }

#### Constructors
- public PutBucketPolicyRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutBucketPolicyRequest putBucketPolicyRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketPolicyResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketPolicyResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketPolicyResponseUnmarshaller Instance { get; }

#### Constructors
- public PutBucketPolicyResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketReplicationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutBucketReplicationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketReplicationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketReplicationRequestMarshaller Instance { get; }

#### Constructors
- public PutBucketReplicationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutBucketReplicationRequest putBucketreplicationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketReplicationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketReplicationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketReplicationResponseUnmarshaller Instance { get; }

#### Constructors
- public PutBucketReplicationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutBucketRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketRequestMarshaller Instance { get; }

#### Constructors
- public PutBucketRequestMarshaller()

#### Methods
- protected internal static void ConvertPutWithACLRequest(Amazon.S3.Model.PutWithACLRequest request, Amazon.Runtime.Internal.IRequest irequest)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutBucketRequest putBucketRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketRequestPaymentRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutBucketRequestPaymentRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketRequestPaymentRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketRequestPaymentRequestMarshaller Instance { get; }

#### Constructors
- public PutBucketRequestPaymentRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutBucketRequestPaymentRequest putBucketRequestPaymentRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketRequestPaymentResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketRequestPaymentResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketRequestPaymentResponseUnmarshaller Instance { get; }

#### Constructors
- public PutBucketRequestPaymentResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketResponseUnmarshaller Instance { get; }

#### Constructors
- public PutBucketResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.PutBucketResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketTaggingRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutBucketTaggingRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketTaggingRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketTaggingRequestMarshaller Instance { get; }

#### Constructors
- public PutBucketTaggingRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutBucketTaggingRequest putBucketTaggingRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketTaggingResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketTaggingResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketTaggingResponseUnmarshaller Instance { get; }

#### Constructors
- public PutBucketTaggingResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketVersioningRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutBucketVersioningRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketVersioningRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketVersioningRequestMarshaller Instance { get; }

#### Constructors
- public PutBucketVersioningRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutBucketVersioningRequest putBucketVersioningRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketVersioningResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketVersioningResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketVersioningResponseUnmarshaller Instance { get; }

#### Constructors
- public PutBucketVersioningResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketWebsiteRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutBucketWebsiteRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketWebsiteRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketWebsiteRequestMarshaller Instance { get; }

#### Constructors
- public PutBucketWebsiteRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutBucketWebsiteRequest putBucketWebsiteRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutBucketWebsiteResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketWebsiteResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutBucketWebsiteResponseUnmarshaller Instance { get; }

#### Constructors
- public PutBucketWebsiteResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutCORSConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutCORSConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutCORSConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutCORSConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public PutCORSConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutCORSConfigurationRequest putCORSConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutCORSConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutCORSConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutCORSConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public PutCORSConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutLifecycleConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutLifecycleConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutLifecycleConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutLifecycleConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public PutLifecycleConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutLifecycleConfigurationRequest putLifecycleConfigurationRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutLifecycleConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutLifecycleConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutLifecycleConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public PutLifecycleConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutObjectLegalHoldRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutObjectLegalHoldRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectLegalHoldRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectLegalHoldRequestMarshaller Instance { get; }

#### Constructors
- public PutObjectLegalHoldRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutObjectLegalHoldRequest publicRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutObjectLegalHoldResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectLegalHoldResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectLegalHoldResponseUnmarshaller Instance { get; }

#### Constructors
- public PutObjectLegalHoldResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutObjectLockConfigurationRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutObjectLockConfigurationRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectLockConfigurationRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectLockConfigurationRequestMarshaller Instance { get; }

#### Constructors
- public PutObjectLockConfigurationRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutObjectLockConfigurationRequest publicRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutObjectLockConfigurationResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectLockConfigurationResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectLockConfigurationResponseUnmarshaller Instance { get; }

#### Constructors
- public PutObjectLockConfigurationResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutObjectRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutObjectRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectRequestMarshaller Instance { get; }

#### Constructors
- public PutObjectRequestMarshaller()

#### Methods
- private static System.IO.Stream GetStreamWithLength(System.IO.Stream baseStream, long hintLength)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutObjectRequest putObjectRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutObjectResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectResponseUnmarshaller Instance { get; }

#### Constructors
- public PutObjectResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.PutObjectResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutObjectRetentionRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutObjectRetentionRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectRetentionRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectRetentionRequestMarshaller Instance { get; }

#### Constructors
- public PutObjectRetentionRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutObjectRetentionRequest publicRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutObjectRetentionResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectRetentionResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectRetentionResponseUnmarshaller Instance { get; }

#### Constructors
- public PutObjectRetentionResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutObjectTaggingRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutObjectTaggingRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectTaggingRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectTaggingRequestMarshaller Instance { get; }

#### Constructors
- public PutObjectTaggingRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutObjectTaggingRequest putObjectTaggingRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutObjectTaggingResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectTaggingResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutObjectTaggingResponseUnmarshaller Instance { get; }

#### Constructors
- public PutObjectTaggingResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.PutObjectTaggingResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutPublicAccessBlockRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.PutPublicAccessBlockRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutPublicAccessBlockRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutPublicAccessBlockRequestMarshaller Instance { get; }

#### Constructors
- public PutPublicAccessBlockRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.PutPublicAccessBlockRequest putPutPublicAccessBlockRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.PutPublicAccessBlockResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.PutPublicAccessBlockResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.PutPublicAccessBlockResponseUnmarshaller Instance { get; }

#### Constructors
- public PutPublicAccessBlockResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.QueueConfigurationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.QueueConfiguration, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.QueueConfiguration, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.QueueConfigurationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.QueueConfigurationUnmarshaller Instance { get; }

#### Constructors
- public QueueConfigurationUnmarshaller()

#### Methods
- public Amazon.S3.Model.QueueConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.QueueConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ReplicationDestinationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ReplicationDestination, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ReplicationDestination, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ReplicationDestinationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ReplicationDestinationUnmarshaller Instance { get; }

#### Constructors
- public ReplicationDestinationUnmarshaller()

#### Methods
- public Amazon.S3.Model.ReplicationDestination Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.ReplicationDestination Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ReplicationRuleAndOperatorUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ReplicationRuleAndOperator, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ReplicationRuleAndOperatorUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ReplicationRuleAndOperatorUnmarshaller Instance { get; }

#### Constructors
- public ReplicationRuleAndOperatorUnmarshaller()

#### Methods
- public Amazon.S3.Model.ReplicationRuleAndOperator Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ReplicationRuleFilterUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ReplicationRuleFilter, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ReplicationRuleFilterUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ReplicationRuleFilterUnmarshaller Instance { get; }

#### Constructors
- public ReplicationRuleFilterUnmarshaller()

#### Methods
- public Amazon.S3.Model.ReplicationRuleFilter Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ReplicationRuleUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ReplicationRule, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ReplicationRule, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ReplicationRuleUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ReplicationRuleUnmarshaller Instance { get; }

#### Constructors
- public ReplicationRuleUnmarshaller()

#### Methods
- public Amazon.S3.Model.ReplicationRule Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.ReplicationRule Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.RestoreObjectRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.RestoreObjectRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.RestoreObjectRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.RestoreObjectRequestMarshaller Instance { get; }

#### Constructors
- public RestoreObjectRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.RestoreObjectRequest restoreObjectRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.RestoreObjectResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.RestoreObjectResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.RestoreObjectResponseUnmarshaller Instance { get; }

#### Constructors
- public RestoreObjectResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.RoutingRuleConditionUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.RoutingRuleCondition, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.RoutingRuleCondition, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.RoutingRuleConditionUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.RoutingRuleConditionUnmarshaller Instance { get; }

#### Constructors
- public RoutingRuleConditionUnmarshaller()

#### Methods
- public Amazon.S3.Model.RoutingRuleCondition Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.RoutingRuleCondition Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.RoutingRuleRedirectUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.RoutingRuleRedirect, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.RoutingRuleRedirect, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.RoutingRuleRedirectUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.RoutingRuleRedirectUnmarshaller Instance { get; }

#### Constructors
- public RoutingRuleRedirectUnmarshaller()

#### Methods
- public Amazon.S3.Model.RoutingRuleRedirect Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.RoutingRuleRedirect Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.RoutingRuleUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.RoutingRule, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.RoutingRule, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.RoutingRuleUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.RoutingRuleUnmarshaller Instance { get; }

#### Constructors
- public RoutingRuleUnmarshaller()

#### Methods
- public Amazon.S3.Model.RoutingRule Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.RoutingRule Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.RulesItemUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.LifecycleRule, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.LifecycleRule, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.RulesItemUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.RulesItemUnmarshaller Instance { get; }

#### Constructors
- public RulesItemUnmarshaller()

#### Methods
- public Amazon.S3.Model.LifecycleRule Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.LifecycleRule Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.S3ErrorResponse
- Base: Amazon.Runtime.Internal.ErrorResponse

#### Fields
- private string <AmzCfId>k__BackingField
- private string <Id2>k__BackingField
- private System.Exception <ParsingException>k__BackingField
- private string <Region>k__BackingField
- private string <Resource>k__BackingField

#### Properties
- public string AmzCfId { get; set; }
- public string Id2 { get; set; }
- public System.Exception ParsingException { get; set; }
- internal string Region { get; set; }
- public string Resource { get; set; }

#### Constructors
- public S3ErrorResponse()

### public class Amazon.S3.Model.Internal.MarshallTransformations.S3ErrorResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.Internal.MarshallTransformations.S3ErrorResponse, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>

#### Fields
- private static const string XML_CONTENT_TYPE
- private static Amazon.S3.Model.Internal.MarshallTransformations.S3ErrorResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.S3ErrorResponseUnmarshaller Instance { get; }

#### Constructors
- public S3ErrorResponseUnmarshaller()

#### Methods
- public Amazon.S3.Model.Internal.MarshallTransformations.S3ErrorResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.S3KeyFilterUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.S3KeyFilter, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.S3KeyFilter, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.S3KeyFilterUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.S3KeyFilterUnmarshaller Instance { get; }

#### Constructors
- public S3KeyFilterUnmarshaller()

#### Methods
- public Amazon.S3.Model.S3KeyFilter Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.S3KeyFilter Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.XmlResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Constructors
- protected S3ReponseUnmarshaller()

#### Methods
- protected override Amazon.Runtime.Internal.Transform.UnmarshallerContext ConstructUnmarshallerContext(System.IO.Stream responseStream, bool maintainResponseBody, Amazon.Runtime.Internal.Transform.IWebResponseData response)
- public override Amazon.Runtime.Internal.Transform.UnmarshallerContext CreateContext(Amazon.Runtime.Internal.Transform.IWebResponseData response, bool readEntireResponse, System.IO.Stream stream, Amazon.Runtime.Internal.Util.RequestMetrics metrics)
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.UnmarshallerContext input)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public static class Amazon.S3.Model.Internal.MarshallTransformations.S3Transforms

#### Methods
- internal static void BuildQueryParameterMap(Amazon.Runtime.Internal.IRequest request, System.Collections.Generic.IDictionary<string, string> queryParameters, string queryString, params string[] unusedIfNullValueParams)
- internal static System.DateTime ToDateTime(string value)
- internal static int ToInt(string value)
- internal static string ToString(string value)
- internal static string ToStringValue(string value)
- internal static string ToStringValue(int value)
- internal static string ToStringValue(System.DateTime value, string dateFormat = "ddd, dd MMM yyyy HH:mm:ss \G\M\T")
- internal static string ToStringValue(bool value)
- internal static string ToURLEncodedValue(string value, bool path)
- internal static string ToURLEncodedValue(int value, bool path)
- internal static string ToURLEncodedValue(System.DateTime value, bool path)
- internal static string ToXmlStringValue(string value)
- internal static string ToXmlStringValue(System.DateTime value)
- internal static string ToXmlStringValue(int value)
- internal static string ToXmlStringValue(bool value)
- internal static T Unmarshall<T>(string text)

### public class Amazon.S3.Model.Internal.MarshallTransformations.S3UnmarshallerContext
- Base: Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext
- Interfaces: System.IDisposable

#### Fields
- private bool _checkedForErrorResponse

#### Constructors
- public S3UnmarshallerContext(System.IO.Stream responseStream, bool maintainResponseBody, Amazon.Runtime.Internal.Transform.IWebResponseData responseData)

#### Methods
- public override bool Read()

### public class Amazon.S3.Model.Internal.MarshallTransformations.SelectObjectContentRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.SelectObjectContentRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.SelectObjectContentRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.SelectObjectContentRequestMarshaller Instance { get; }

#### Constructors
- public SelectObjectContentRequestMarshaller()

#### Methods
- private static System.ArgumentException ConstructExceptionArgumentRequired(string parameterName)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.SelectObjectContentRequest selectObjectContentRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.SelectObjectContentResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.SelectObjectContentResponseUnmarshaller _instance

#### Properties
- public bool HasStreamingProperty { get; }
- public static Amazon.S3.Model.Internal.MarshallTransformations.SelectObjectContentResponseUnmarshaller Instance { get; }

#### Constructors
- public SelectObjectContentResponseUnmarshaller()

#### Methods
- protected override bool ShouldReadEntireResponse(Amazon.Runtime.Internal.Transform.IWebResponseData response, bool readEntireResponse)
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.SelectObjectContentResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ServerSideEncryptionByDefaultUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ServerSideEncryptionByDefault, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ServerSideEncryptionByDefault, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ServerSideEncryptionByDefaultUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ServerSideEncryptionByDefaultUnmarshaller Instance { get; }

#### Constructors
- public ServerSideEncryptionByDefaultUnmarshaller()

#### Methods
- public Amazon.S3.Model.ServerSideEncryptionByDefault Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.ServerSideEncryptionByDefault Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext input)

### public class Amazon.S3.Model.Internal.MarshallTransformations.ServerSideEncryptionRuleUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ServerSideEncryptionRule, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.ServerSideEncryptionRule, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.ServerSideEncryptionRuleUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.ServerSideEncryptionRuleUnmarshaller Instance { get; }

#### Constructors
- public ServerSideEncryptionRuleUnmarshaller()

#### Methods
- public Amazon.S3.Model.ServerSideEncryptionRule Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.ServerSideEncryptionRule Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext input)

### public class Amazon.S3.Model.Internal.MarshallTransformations.SourceSelectionCriteriaUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.SourceSelectionCriteria, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.SourceSelectionCriteria, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.SourceSelectionCriteriaUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.SourceSelectionCriteriaUnmarshaller Instance { get; }

#### Constructors
- public SourceSelectionCriteriaUnmarshaller()

#### Methods
- public Amazon.S3.Model.SourceSelectionCriteria Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.SourceSelectionCriteria Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.SseKmsEncryptedObjectsUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.SseKmsEncryptedObjects, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.SseKmsEncryptedObjects, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.SseKmsEncryptedObjectsUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.SseKmsEncryptedObjectsUnmarshaller Instance { get; }

#### Constructors
- public SseKmsEncryptedObjectsUnmarshaller()

#### Methods
- public Amazon.S3.Model.SseKmsEncryptedObjects Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.SseKmsEncryptedObjects Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.SSEKMSUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.SSEKMS, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.SSEKMS, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.SSEKMSUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.SSEKMSUnmarshaller Instance { get; }

#### Constructors
- public SSEKMSUnmarshaller()

#### Methods
- public Amazon.S3.Model.SSEKMS Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.SSEKMS Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.StorageClassAnalysisDataExportUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.StorageClassAnalysisDataExport, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.StorageClassAnalysisDataExport, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.StorageClassAnalysisDataExportUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.StorageClassAnalysisDataExportUnmarshaller Instance { get; }

#### Constructors
- public StorageClassAnalysisDataExportUnmarshaller()

#### Methods
- public Amazon.S3.Model.StorageClassAnalysisDataExport Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.StorageClassAnalysisDataExport Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.StorageClassAnalysisUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.StorageClassAnalysis, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.StorageClassAnalysis, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.StorageClassAnalysisUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.StorageClassAnalysisUnmarshaller Instance { get; }

#### Constructors
- public StorageClassAnalysisUnmarshaller()

#### Methods
- public Amazon.S3.Model.StorageClassAnalysis Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.StorageClassAnalysis Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.TagUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.Tag, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.Tag, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.TagUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.TagUnmarshaller Instance { get; }

#### Constructors
- public TagUnmarshaller()

#### Methods
- public Amazon.S3.Model.Tag Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.Tag Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.TopicConfigurationUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.TopicConfiguration, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.TopicConfiguration, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.TopicConfigurationUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.TopicConfigurationUnmarshaller Instance { get; }

#### Constructors
- public TopicConfigurationUnmarshaller()

#### Methods
- public Amazon.S3.Model.TopicConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.TopicConfiguration Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.TransitionUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.LifecycleTransition, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.LifecycleTransition, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.TransitionUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.TransitionUnmarshaller Instance { get; }

#### Constructors
- public TransitionUnmarshaller()

#### Methods
- public Amazon.S3.Model.LifecycleTransition Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.LifecycleTransition Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.S3.Model.Internal.MarshallTransformations.UploadPartRequestMarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.S3.Model.UploadPartRequest>, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.UploadPartRequestMarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.UploadPartRequestMarshaller Instance { get; }

#### Constructors
- public UploadPartRequestMarshaller()

#### Methods
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
- public Amazon.Runtime.Internal.IRequest Marshall(Amazon.S3.Model.UploadPartRequest uploadPartRequest)

### public class Amazon.S3.Model.Internal.MarshallTransformations.UploadPartResponseUnmarshaller
- Base: Amazon.S3.Model.Internal.MarshallTransformations.S3ReponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.UploadPartResponseUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.UploadPartResponseUnmarshaller Instance { get; }

#### Constructors
- public UploadPartResponseUnmarshaller()

#### Methods
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- private static void UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.S3.Model.UploadPartResponse response)

### public class Amazon.S3.Model.Internal.MarshallTransformations.VersionsItemUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.S3ObjectVersion, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.S3.Model.S3ObjectVersion, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.S3.Model.Internal.MarshallTransformations.VersionsItemUnmarshaller _instance

#### Properties
- public static Amazon.S3.Model.Internal.MarshallTransformations.VersionsItemUnmarshaller Instance { get; }

#### Constructors
- public VersionsItemUnmarshaller()

#### Methods
- public Amazon.S3.Model.S3ObjectVersion Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.S3.Model.S3ObjectVersion Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

## Namespace: Amazon.S3.Transfer

### private struct Amazon.S3.Transfer.TransferUtility.<OpenStreamAsync>d__27
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Transfer.TransferUtility <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1
- private Amazon.S3.Transfer.Internal.OpenStreamCommand <command>5__2
- public System.Threading.CancellationToken cancellationToken
- public Amazon.S3.Transfer.TransferUtilityOpenStreamRequest request

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class Amazon.S3.Transfer.BaseDownloadRequest

#### Fields
- private string bucketName
- private string key
- private System.Nullable<System.DateTime> modifiedSinceDate
- private System.Nullable<System.DateTime> modifiedSinceDateUtc
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideCustomerEncryption
- private string serverSideEncryptionCustomerProvidedKey
- private string serverSideEncryptionCustomerProvidedKeyMD5
- private System.Nullable<System.DateTime> unmodifiedSinceDate
- private System.Nullable<System.DateTime> unmodifiedSinceDateUtc
- private string versionId

#### Properties
- public string BucketName { get; set; }
- public string Key { get; set; }
- public System.DateTime ModifiedSinceDate { get; set; }
- public System.DateTime ModifiedSinceDateUtc { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionCustomerProvidedKey { get; set; }
- public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }
- public System.DateTime UnmodifiedSinceDate { get; set; }
- public System.DateTime UnmodifiedSinceDateUtc { get; set; }
- public string VersionId { get; set; }

#### Constructors
- protected BaseDownloadRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetKey()
- internal bool IsSetModifiedSinceDateUtc()
- internal bool IsSetUnmodifiedSinceDateUtc()
- internal bool IsSetVersionId()

### public class Amazon.S3.Transfer.BaseUploadRequest

#### Constructors
- protected BaseUploadRequest()

### public class Amazon.S3.Transfer.DownloadDirectoryProgressArgs
- Base: System.EventArgs

#### Fields
- private string <CurrentFile>k__BackingField
- private int <NumberOfFilesDownloaded>k__BackingField
- private long <TotalBytes>k__BackingField
- private long <TotalNumberOfBytesForCurrentFile>k__BackingField
- private int <TotalNumberOfFiles>k__BackingField
- private long <TransferredBytes>k__BackingField
- private long <TransferredBytesForCurrentFile>k__BackingField

#### Properties
- public string CurrentFile { get; set; }
- public int NumberOfFilesDownloaded { get; set; }
- public long TotalBytes { get; set; }
- public long TotalNumberOfBytesForCurrentFile { get; set; }
- public int TotalNumberOfFiles { get; set; }
- public long TransferredBytes { get; set; }
- public long TransferredBytesForCurrentFile { get; set; }

#### Constructors
- public DownloadDirectoryProgressArgs(int numberOfFilesDownloaded, int totalNumberOfFiles, string currentFile, long transferredBytesForCurrentFile, long totalNumberOfBytesForCurrentFile)
- public DownloadDirectoryProgressArgs(int numberOfFilesDownloaded, int totalNumberOfFiles, long transferredBytes, long totalBytes, string currentFile, long transferredBytesForCurrentFile, long totalNumberOfBytesForCurrentFile)

#### Methods
- public override string ToString()

### public interface Amazon.S3.Transfer.ITransferUtility
- Interfaces: System.IDisposable

#### Properties
- public Amazon.S3.IAmazonS3 S3Client { get; }

#### Methods
- public void AbortMultipartUploads(string bucketName, System.DateTime initiatedDate)
- public System.Threading.Tasks.Task AbortMultipartUploadsAsync(string bucketName, System.DateTime initiatedDate, System.Threading.CancellationToken cancellationToken = null)
- public void Download(string filePath, string bucketName, string key)
- public void Download(Amazon.S3.Transfer.TransferUtilityDownloadRequest request)
- public System.Threading.Tasks.Task DownloadAsync(Amazon.S3.Transfer.TransferUtilityDownloadRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task DownloadAsync(string filePath, string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public void DownloadDirectory(string bucketName, string s3Directory, string localDirectory)
- public void DownloadDirectory(Amazon.S3.Transfer.TransferUtilityDownloadDirectoryRequest request)
- public System.Threading.Tasks.Task DownloadDirectoryAsync(string bucketName, string s3Directory, string localDirectory, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task DownloadDirectoryAsync(Amazon.S3.Transfer.TransferUtilityDownloadDirectoryRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.IO.Stream OpenStream(string bucketName, string key)
- public System.IO.Stream OpenStream(Amazon.S3.Transfer.TransferUtilityOpenStreamRequest request)
- public System.Threading.Tasks.Task<System.IO.Stream> OpenStreamAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<System.IO.Stream> OpenStreamAsync(Amazon.S3.Transfer.TransferUtilityOpenStreamRequest request, System.Threading.CancellationToken cancellationToken = null)
- public void Upload(string filePath, string bucketName)
- public void Upload(string filePath, string bucketName, string key)
- public void Upload(System.IO.Stream stream, string bucketName, string key)
- public void Upload(Amazon.S3.Transfer.TransferUtilityUploadRequest request)
- public System.Threading.Tasks.Task UploadAsync(string filePath, string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task UploadAsync(string filePath, string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task UploadAsync(System.IO.Stream stream, string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task UploadAsync(Amazon.S3.Transfer.TransferUtilityUploadRequest request, System.Threading.CancellationToken cancellationToken = null)
- public void UploadDirectory(string directory, string bucketName)
- public void UploadDirectory(string directory, string bucketName, string searchPattern, System.IO.SearchOption searchOption)
- public void UploadDirectory(Amazon.S3.Transfer.TransferUtilityUploadDirectoryRequest request)
- public System.Threading.Tasks.Task UploadDirectoryAsync(string directory, string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task UploadDirectoryAsync(string directory, string bucketName, string searchPattern, System.IO.SearchOption searchOption, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task UploadDirectoryAsync(Amazon.S3.Transfer.TransferUtilityUploadDirectoryRequest request, System.Threading.CancellationToken cancellationToken = null)

### public class Amazon.S3.Transfer.TransferUtility
- Interfaces: Amazon.S3.Transfer.ITransferUtility, System.IDisposable

#### Fields
- private Amazon.S3.Transfer.TransferUtilityConfig _config
- private bool _isDisposed
- private Amazon.S3.IAmazonS3 _s3Client
- private bool _shouldDispose

#### Properties
- public Amazon.S3.IAmazonS3 S3Client { get; }

#### Constructors
- public TransferUtility()
- public TransferUtility(Amazon.S3.IAmazonS3 s3Client)
- public TransferUtility(Amazon.RegionEndpoint region)
- public TransferUtility(Amazon.S3.Transfer.TransferUtilityConfig config)
- public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey)
- public TransferUtility(Amazon.S3.IAmazonS3 s3Client, Amazon.S3.Transfer.TransferUtilityConfig config)
- public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey, Amazon.RegionEndpoint region)
- public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey, Amazon.S3.Transfer.TransferUtilityConfig config)
- public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey, Amazon.RegionEndpoint region, Amazon.S3.Transfer.TransferUtilityConfig config)

#### Methods
- public void AbortMultipartUploads(string bucketName, System.DateTime initiatedDate)
- public System.Threading.Tasks.Task AbortMultipartUploadsAsync(string bucketName, System.DateTime initiatedDate, System.Threading.CancellationToken cancellationToken = null)
- private static Amazon.S3.Transfer.TransferUtilityDownloadDirectoryRequest ConstructDownloadDirectoryRequest(string bucketName, string s3Directory, string localDirectory)
- private static Amazon.S3.Transfer.TransferUtilityDownloadRequest ConstructDownloadRequest(string filePath, string bucketName, string key)
- private static Amazon.S3.Transfer.TransferUtilityUploadDirectoryRequest ConstructUploadDirectoryRequest(string directory, string bucketName)
- private static Amazon.S3.Transfer.TransferUtilityUploadDirectoryRequest ConstructUploadDirectoryRequest(string directory, string bucketName, string searchPattern, System.IO.SearchOption searchOption)
- private static Amazon.S3.Transfer.TransferUtilityUploadRequest ConstructUploadRequest(string filePath, string bucketName)
- private static Amazon.S3.Transfer.TransferUtilityUploadRequest ConstructUploadRequest(string filePath, string bucketName, string key)
- private static Amazon.S3.Transfer.TransferUtilityUploadRequest ConstructUploadRequest(System.IO.Stream stream, string bucketName, string key)
- protected virtual void Dispose(bool disposing)
- public void Dispose()
- public void Download(string filePath, string bucketName, string key)
- public void Download(Amazon.S3.Transfer.TransferUtilityDownloadRequest request)
- public System.Threading.Tasks.Task DownloadAsync(Amazon.S3.Transfer.TransferUtilityDownloadRequest request, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task DownloadAsync(string filePath, string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public void DownloadDirectory(string bucketName, string s3Directory, string localDirectory)
- public void DownloadDirectory(Amazon.S3.Transfer.TransferUtilityDownloadDirectoryRequest request)
- public System.Threading.Tasks.Task DownloadDirectoryAsync(string bucketName, string s3Directory, string localDirectory, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task DownloadDirectoryAsync(Amazon.S3.Transfer.TransferUtilityDownloadDirectoryRequest request, System.Threading.CancellationToken cancellationToken = null)
- internal Amazon.S3.Transfer.Internal.BaseCommand GetUploadCommand(Amazon.S3.Transfer.TransferUtilityUploadRequest request)
- internal Amazon.S3.Transfer.Internal.BaseCommand GetUploadCommand(Amazon.S3.Transfer.TransferUtilityUploadRequest request, System.Threading.SemaphoreSlim asyncThrottler)
- private bool IsMultipartUpload(Amazon.S3.Transfer.TransferUtilityUploadRequest request)
- public System.IO.Stream OpenStream(string bucketName, string key)
- public System.IO.Stream OpenStream(Amazon.S3.Transfer.TransferUtilityOpenStreamRequest request)
- public System.Threading.Tasks.Task<System.IO.Stream> OpenStreamAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<System.IO.Stream> OpenStreamAsync(Amazon.S3.Transfer.TransferUtilityOpenStreamRequest request, System.Threading.CancellationToken cancellationToken = null)
- public void Upload(string filePath, string bucketName)
- public void Upload(string filePath, string bucketName, string key)
- public void Upload(System.IO.Stream stream, string bucketName, string key)
- public void Upload(Amazon.S3.Transfer.TransferUtilityUploadRequest request)
- public System.Threading.Tasks.Task UploadAsync(string filePath, string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task UploadAsync(string filePath, string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task UploadAsync(System.IO.Stream stream, string bucketName, string key, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task UploadAsync(Amazon.S3.Transfer.TransferUtilityUploadRequest request, System.Threading.CancellationToken cancellationToken = null)
- public void UploadDirectory(string directory, string bucketName)
- public void UploadDirectory(string directory, string bucketName, string searchPattern, System.IO.SearchOption searchOption)
- public void UploadDirectory(Amazon.S3.Transfer.TransferUtilityUploadDirectoryRequest request)
- public System.Threading.Tasks.Task UploadDirectoryAsync(string directory, string bucketName, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task UploadDirectoryAsync(string directory, string bucketName, string searchPattern, System.IO.SearchOption searchOption, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task UploadDirectoryAsync(Amazon.S3.Transfer.TransferUtilityUploadDirectoryRequest request, System.Threading.CancellationToken cancellationToken = null)
- private static void validate(Amazon.S3.Transfer.TransferUtilityUploadRequest request)
- private static void validate(Amazon.S3.Transfer.TransferUtilityUploadDirectoryRequest request)

### public class Amazon.S3.Transfer.TransferUtilityConfig

#### Fields
- private int _concurrentServiceRequests
- private long _minSizeBeforePartUpload

#### Properties
- public int ConcurrentServiceRequests { get; set; }
- public long MinSizeBeforePartUpload { get; set; }
- public int NumberOfUploadThreads { get; set; }

#### Constructors
- public TransferUtilityConfig()

### public class Amazon.S3.Transfer.TransferUtilityDownloadDirectoryRequest

#### Fields
- private string bucketName
- private System.EventHandler<Amazon.S3.Transfer.DownloadDirectoryProgressArgs> DownloadedDirectoryProgressEvent
- private bool downloadFilesConcurrently
- private string localDirectory
- private System.Nullable<System.DateTime> modifiedSinceDate
- private System.Nullable<System.DateTime> modifiedSinceDateUtc
- private string s3Directory
- private System.Nullable<System.DateTime> unmodifiedSinceDate
- private System.Nullable<System.DateTime> unmodifiedSinceDateUtc

#### Properties
- public string BucketName { get; set; }
- internal bool DownloadFilesConcurrently { get; set; }
- public string LocalDirectory { get; set; }
- public System.DateTime ModifiedSinceDate { get; set; }
- public System.DateTime ModifiedSinceDateUtc { get; set; }
- public string S3Directory { get; set; }
- public System.DateTime UnmodifiedSinceDate { get; set; }
- public System.DateTime UnmodifiedSinceDateUtc { get; set; }

#### Events
- public event System.EventHandler<Amazon.S3.Transfer.DownloadDirectoryProgressArgs> DownloadedDirectoryProgressEvent

#### Constructors
- public TransferUtilityDownloadDirectoryRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetLocalDirectory()
- internal bool IsSetModifiedSinceDate()
- internal bool IsSetModifiedSinceDateUtc()
- internal bool IsSetS3Directory()
- internal bool IsSetUnmodifiedSinceDate()
- internal bool IsSetUnmodifiedSinceDateUtc()
- internal void OnRaiseProgressEvent(Amazon.S3.Transfer.DownloadDirectoryProgressArgs downloadDirectoryProgress)

### public class Amazon.S3.Transfer.TransferUtilityDownloadRequest
- Base: Amazon.S3.Transfer.BaseDownloadRequest

#### Fields
- private string <FilePath>k__BackingField
- private System.EventHandler<Amazon.S3.Model.WriteObjectProgressArgs> WriteObjectProgressEvent

#### Properties
- public string FilePath { get; set; }

#### Events
- public event System.EventHandler<Amazon.S3.Model.WriteObjectProgressArgs> WriteObjectProgressEvent

#### Constructors
- public TransferUtilityDownloadRequest()

#### Methods
- internal bool IsSetFilePath()
- internal void OnRaiseProgressEvent(Amazon.S3.Model.WriteObjectProgressArgs progressArgs)

### public class Amazon.S3.Transfer.TransferUtilityOpenStreamRequest
- Base: Amazon.S3.Transfer.BaseDownloadRequest

#### Constructors
- public TransferUtilityOpenStreamRequest()

### public class Amazon.S3.Transfer.TransferUtilityUploadDirectoryRequest
- Base: Amazon.S3.Transfer.BaseUploadRequest

#### Fields
- private string contentType
- private Amazon.S3.ServerSideEncryptionMethod encryption
- private Amazon.S3.Model.MetadataCollection metadataCollection
- private string serverSideEncryptionKeyManagementServiceKeyId
- private System.Collections.Generic.List<Amazon.S3.Model.Tag> tagset
- private System.EventHandler<Amazon.S3.Transfer.UploadDirectoryFileRequestArgs> UploadDirectoryFileRequestEvent
- private System.EventHandler<Amazon.S3.Transfer.UploadDirectoryProgressArgs> UploadDirectoryProgressEvent
- private string _bucketname
- private Amazon.S3.S3CannedACL _cannedACL
- private string _directory
- private string _keyPrefix
- private System.IO.SearchOption _searchOption
- private string _searchPattern
- private Amazon.S3.S3StorageClass _storageClass
- private bool _uploadFilesConcurrently

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.S3CannedACL CannedACL { get; set; }
- public string ContentType { get; set; }
- public string Directory { get; set; }
- public string KeyPrefix { get; set; }
- public Amazon.S3.Model.MetadataCollection Metadata { get; internal set; }
- public System.IO.SearchOption SearchOption { get; set; }
- public string SearchPattern { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }
- public Amazon.S3.S3StorageClass StorageClass { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.Tag> TagSet { get; set; }
- internal bool UploadFilesConcurrently { get; set; }

#### Events
- public event System.EventHandler<Amazon.S3.Transfer.UploadDirectoryFileRequestArgs> UploadDirectoryFileRequestEvent
- public event System.EventHandler<Amazon.S3.Transfer.UploadDirectoryProgressArgs> UploadDirectoryProgressEvent

#### Constructors
- public TransferUtilityUploadDirectoryRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetCannedACL()
- internal bool IsSetDirectory()
- internal bool IsSetKeyPrefix()
- internal bool IsSetSearchPattern()
- internal void OnRaiseProgressEvent(Amazon.S3.Transfer.UploadDirectoryProgressArgs uploadDirectoryProgress)
- internal void RaiseUploadDirectoryFileRequestEvent(Amazon.S3.Transfer.TransferUtilityUploadRequest request)

### public class Amazon.S3.Transfer.TransferUtilityUploadRequest
- Base: Amazon.S3.Transfer.BaseUploadRequest

#### Fields
- private string <FilePath>k__BackingField
- private bool autoCloseStream
- private bool autoResetStreamPosition
- private string bucketName
- private Amazon.S3.S3CannedACL cannedACL
- private string contentType
- private Amazon.S3.ServerSideEncryptionMethod encryption
- private Amazon.S3.Model.HeadersCollection headersCollection
- private System.IO.Stream inputStream
- private string key
- private Amazon.S3.Model.MetadataCollection metadataCollection
- private System.Nullable<long> partSize
- private Amazon.S3.ServerSideEncryptionCustomerMethod serverSideCustomerEncryption
- private string serverSideEncryptionCustomerProvidedKey
- private string serverSideEncryptionCustomerProvidedKeyMD5
- private string serverSideEncryptionKeyManagementServiceKeyId
- private Amazon.S3.S3StorageClass storageClass
- private System.Collections.Generic.List<Amazon.S3.Model.Tag> tagset
- private System.EventHandler<Amazon.S3.Transfer.UploadProgressArgs> UploadProgressEvent

#### Properties
- public bool AutoCloseStream { get; set; }
- public bool AutoResetStreamPosition { get; set; }
- public string BucketName { get; set; }
- public Amazon.S3.S3CannedACL CannedACL { get; set; }
- internal long ContentLength { get; }
- public string ContentType { get; set; }
- public string FilePath { get; set; }
- public Amazon.S3.Model.HeadersCollection Headers { get; internal set; }
- public System.IO.Stream InputStream { get; set; }
- public string Key { get; set; }
- public Amazon.S3.Model.MetadataCollection Metadata { get; internal set; }
- public long PartSize { get; set; }
- public Amazon.S3.ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }
- public string ServerSideEncryptionCustomerProvidedKey { get; set; }
- public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }
- public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }
- public Amazon.S3.ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }
- public Amazon.S3.S3StorageClass StorageClass { get; set; }
- public System.Collections.Generic.List<Amazon.S3.Model.Tag> TagSet { get; set; }

#### Events
- public event System.EventHandler<Amazon.S3.Transfer.UploadProgressArgs> UploadProgressEvent

#### Constructors
- public TransferUtilityUploadRequest()

#### Methods
- internal bool IsSetBucketName()
- internal bool IsSetCannedACL()
- internal bool IsSetContentType()
- internal bool IsSetFilePath()
- internal bool IsSetInputStream()
- internal bool IsSetKey()
- internal bool IsSetPartSize()
- internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
- internal void OnRaiseProgressEvent(Amazon.S3.Transfer.UploadProgressArgs progressArgs)
- public void RemoveCannedACL()
- public Amazon.S3.Transfer.TransferUtilityUploadRequest WithAutoCloseStream(bool autoCloseStream)

### public class Amazon.S3.Transfer.UploadDirectoryFileRequestArgs
- Base: System.EventArgs

#### Fields
- private Amazon.S3.Transfer.TransferUtilityUploadRequest <UploadRequest>k__BackingField

#### Properties
- public Amazon.S3.Transfer.TransferUtilityUploadRequest UploadRequest { get; set; }

#### Constructors
- public UploadDirectoryFileRequestArgs(Amazon.S3.Transfer.TransferUtilityUploadRequest request)

### public class Amazon.S3.Transfer.UploadDirectoryProgressArgs
- Base: System.EventArgs

#### Fields
- private string <CurrentFile>k__BackingField
- private int <NumberOfFilesUploaded>k__BackingField
- private long <TotalBytes>k__BackingField
- private long <TotalNumberOfBytesForCurrentFile>k__BackingField
- private int <TotalNumberOfFiles>k__BackingField
- private long <TransferredBytes>k__BackingField
- private long <TransferredBytesForCurrentFile>k__BackingField

#### Properties
- public string CurrentFile { get; set; }
- public int NumberOfFilesUploaded { get; set; }
- public long TotalBytes { get; set; }
- public long TotalNumberOfBytesForCurrentFile { get; set; }
- public int TotalNumberOfFiles { get; set; }
- public long TransferredBytes { get; set; }
- public long TransferredBytesForCurrentFile { get; set; }

#### Constructors
- public UploadDirectoryProgressArgs(int numberOfFilesUploaded, int totalNumberOfFiles, string currentFile, long transferredBytesForCurrentFile, long totalNumberOfBytesForCurrentFile)
- public UploadDirectoryProgressArgs(int numberOfFilesUploaded, int totalNumberOfFiles, long transferredBytes, long totalBytes, string currentFile, long transferredBytesForCurrentFile, long totalNumberOfBytesForCurrentFile)

#### Methods
- public override string ToString()

### public class Amazon.S3.Transfer.UploadProgressArgs
- Base: Amazon.S3.Model.TransferProgressArgs

#### Fields
- private long <CompensationForRetry>k__BackingField
- private string <FilePath>k__BackingField

#### Properties
- internal long CompensationForRetry { get; set; }
- public string FilePath { get; private set; }

#### Constructors
- public UploadProgressArgs(long incrementTransferred, long transferred, long total)
- public UploadProgressArgs(long incrementTransferred, long transferred, long total, string filePath)
- internal UploadProgressArgs(long incrementTransferred, long transferred, long total, long compensationForRetry, string filePath)

## Namespace: Amazon.S3.Transfer.Internal

### private class Amazon.S3.Transfer.Internal.UploadDirectoryCommand.<>c__DisplayClass16_0

#### Fields
- public Amazon.S3.Transfer.Internal.UploadDirectoryCommand <>4__this
- public string path
- public System.IO.SearchOption searchOption
- public string searchPattern

#### Constructors
- public UploadDirectoryCommand.<>c__DisplayClass16_0()

#### Methods
- internal string[] <GetFiles>b__0()

### private struct Amazon.S3.Transfer.Internal.AbortMultipartUploadsCommand.<AbortAsync>d__9
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Transfer.Internal.AbortMultipartUploadsCommand <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Amazon.S3.Model.AbortMultipartUploadResponse> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.AbortMultipartUploadResponse> <>u__1
- public Amazon.S3.Model.AbortMultipartUploadRequest abortRequest
- public System.Threading.SemaphoreSlim asyncThrottler
- public System.Threading.CancellationToken cancellationToken
- public System.Threading.CancellationTokenSource internalCts

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Transfer.Internal.SimpleUploadCommand.<ExecuteAsync>d__10
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Transfer.Internal.SimpleUploadCommand <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.PutObjectResponse> <>u__2
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Transfer.Internal.DownloadCommand.<ExecuteAsync>d__11
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Transfer.Internal.DownloadCommand <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.GetObjectResponse> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2
- private Amazon.S3.Model.GetObjectRequest <getRequest>5__2
- private int <maxRetries>5__3
- private string <mostRecentETag>5__6
- private Amazon.S3.Model.GetObjectResponse <response>5__7
- private int <retries>5__4
- private bool <shouldRetry>5__5
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Transfer.Internal.UploadDirectoryCommand.<ExecuteAsync>d__15
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Transfer.Internal.UploadDirectoryCommand <>4__this
- private string[] <>7__wrap7
- private int <>7__wrap8
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<string[]> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2
- private System.Threading.SemaphoreSlim <asyncThrottler>5__4
- private string <basePath>5__3
- private string <filepath>5__10
- private System.Threading.CancellationTokenSource <internalCts>5__6
- private System.Threading.SemaphoreSlim <loopThrottler>5__5
- private System.Collections.Generic.List<System.Threading.Tasks.Task> <pendingTasks>5__7
- private string <prefix>5__2
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Transfer.Internal.DownloadDirectoryCommand.<ExecuteAsync>d__22
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Transfer.Internal.DownloadDirectoryCommand <>4__this
- private System.Collections.Generic.List<T>.Enumerator<Amazon.S3.Model.S3Object> <>7__wrap6
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.ListObjectsResponse> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2
- private System.Threading.SemaphoreSlim <asyncThrottler>5__4
- private System.Threading.CancellationTokenSource <internalCts>5__5
- private Amazon.S3.Model.ListObjectsRequest <listRequest>5__2
- private System.Collections.Generic.List<Amazon.S3.Model.S3Object> <objs>5__3
- private System.Collections.Generic.List<System.Threading.Tasks.Task> <pendingTasks>5__6
- private Amazon.S3.Model.S3Object <s3o>5__8
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Transfer.Internal.MultipartUploadCommand.<ExecuteAsync>d__23
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Transfer.Internal.MultipartUploadCommand <>4__this
- private System.Collections.Generic.Queue<T>.Enumerator<Amazon.S3.Model.UploadPartRequest> <>7__wrap5
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.InitiateMultipartUploadResponse> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<System.Collections.Generic.List<Amazon.S3.Model.UploadPartResponse>> <>u__3
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.CompleteMultipartUploadResponse> <>u__4
- private Amazon.S3.Model.InitiateMultipartUploadResponse <initResponse>5__2
- private System.Threading.CancellationTokenSource <internalCts>5__5
- private System.Threading.SemaphoreSlim <localThrottler>5__4
- private System.Collections.Generic.List<System.Threading.Tasks.Task<Amazon.S3.Model.UploadPartResponse>> <pendingUploadPartTasks>5__3
- private Amazon.S3.Model.UploadPartRequest <uploadRequest>5__7
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Transfer.Internal.AbortMultipartUploadsCommand.<ExecuteAsync>d__8
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Transfer.Internal.AbortMultipartUploadsCommand <>4__this
- private System.Collections.Generic.List<T>.Enumerator<Amazon.S3.Model.MultipartUpload> <>7__wrap6
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.ListMultipartUploadsResponse> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<System.Collections.Generic.List<Amazon.S3.Model.AbortMultipartUploadResponse>> <>u__3
- private System.Threading.SemaphoreSlim <asyncThrottler>5__2
- private System.Threading.CancellationToken <internalCancellationToken>5__4
- private System.Threading.CancellationTokenSource <internalCts>5__3
- private Amazon.S3.Model.ListMultipartUploadsResponse <listResponse>5__5
- private System.Collections.Generic.List<System.Threading.Tasks.Task<Amazon.S3.Model.AbortMultipartUploadResponse>> <pendingTasks>5__6
- private Amazon.S3.Model.MultipartUpload <upload>5__8
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Transfer.Internal.OpenStreamCommand.<ExecuteAsync>d__9
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Transfer.Internal.OpenStreamCommand <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.GetObjectResponse> <>u__1
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Transfer.Internal.BaseCommand.<ExecuteCommandAsync>d__7
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1
- public Amazon.S3.Transfer.Internal.BaseCommand command
- public System.Threading.CancellationTokenSource internalCts
- public System.Threading.SemaphoreSlim throttler

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Transfer.Internal.MultipartUploadCommand.<UploadPartAsync>d__24
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.S3.Transfer.Internal.MultipartUploadCommand <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Amazon.S3.Model.UploadPartResponse> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.UploadPartResponse> <>u__1
- public System.Threading.SemaphoreSlim asyncThrottler
- public System.Threading.CancellationTokenSource internalCts
- public Amazon.S3.Model.UploadPartRequest uploadRequest

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Transfer.Internal.BaseCommand.<WhenAllOrFirstExceptionAsync>d__5<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<T>> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<System.Threading.Tasks.Task<T>> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__2
- private System.Threading.Tasks.Task<T> <completedTask>5__5
- private int <processed>5__2
- private System.Collections.Generic.List<T> <responses>5__4
- private int <total>5__3
- public System.Threading.CancellationToken cancellationToken
- public System.Collections.Generic.List<System.Threading.Tasks.Task<T>> pendingTasks

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Transfer.Internal.BaseCommand.<WhenAllOrFirstExceptionAsync>d__6
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2
- private System.Threading.Tasks.Task <completedTask>5__4
- private int <processed>5__2
- private int <total>5__3
- public System.Threading.CancellationToken cancellationToken
- public System.Collections.Generic.List<System.Threading.Tasks.Task> pendingTasks

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### internal class Amazon.S3.Transfer.Internal.AbortMultipartUploadsCommand
- Base: Amazon.S3.Transfer.Internal.BaseCommand

#### Fields
- private string _bucketName
- private Amazon.S3.Transfer.TransferUtilityConfig _config
- private System.DateTime _initiatedDate
- private Amazon.S3.IAmazonS3 _s3Client

#### Constructors
- internal AbortMultipartUploadsCommand(Amazon.S3.IAmazonS3 s3Client, string bucketName, System.DateTime initiateDate)
- internal AbortMultipartUploadsCommand(Amazon.S3.IAmazonS3 s3Client, string bucketName, System.DateTime initiateDate, Amazon.S3.Transfer.TransferUtilityConfig config)

#### Methods
- private System.Threading.Tasks.Task<Amazon.S3.Model.AbortMultipartUploadResponse> AbortAsync(Amazon.S3.Model.AbortMultipartUploadRequest abortRequest, System.Threading.CancellationTokenSource internalCts, System.Threading.CancellationToken cancellationToken, System.Threading.SemaphoreSlim asyncThrottler)
- private Amazon.S3.Model.AbortMultipartUploadRequest ConstructAbortMultipartUploadRequest(Amazon.S3.Model.MultipartUpload upload)
- private Amazon.S3.Model.ListMultipartUploadsRequest ConstructListMultipartUploadsRequest(Amazon.S3.Model.ListMultipartUploadsResponse listResponse)
- public override System.Threading.Tasks.Task ExecuteAsync(System.Threading.CancellationToken cancellationToken)

### internal class Amazon.S3.Transfer.Internal.BaseCommand

#### Properties
- public object Return { get; }

#### Constructors
- protected BaseCommand()

#### Methods
- protected Amazon.S3.Model.GetObjectRequest ConvertToGetObjectRequest(Amazon.S3.Transfer.BaseDownloadRequest request)
- public abstract System.Threading.Tasks.Task ExecuteAsync(System.Threading.CancellationToken cancellationToken)
- protected static System.Threading.Tasks.Task ExecuteCommandAsync(Amazon.S3.Transfer.Internal.BaseCommand command, System.Threading.CancellationTokenSource internalCts, System.Threading.SemaphoreSlim throttler)
- protected void RequestEventHandler(object sender, Amazon.Runtime.RequestEventArgs args)
- protected static System.Threading.Tasks.Task<System.Collections.Generic.List<T>> WhenAllOrFirstExceptionAsync<T>(System.Collections.Generic.List<System.Threading.Tasks.Task<T>> pendingTasks, System.Threading.CancellationToken cancellationToken)
- protected static System.Threading.Tasks.Task WhenAllOrFirstExceptionAsync(System.Collections.Generic.List<System.Threading.Tasks.Task> pendingTasks, System.Threading.CancellationToken cancellationToken)

### internal class Amazon.S3.Transfer.Internal.DownloadCommand
- Base: Amazon.S3.Transfer.Internal.BaseCommand

#### Fields
- private static int MAX_BACKOFF_IN_MILLISECONDS
- private Amazon.S3.Transfer.TransferUtilityDownloadRequest _request
- private Amazon.S3.IAmazonS3 _s3Client

#### Properties
- private static Amazon.Runtime.Internal.Util.Logger Logger { get; }

#### Constructors
- private static DownloadCommand()
- internal DownloadCommand(Amazon.S3.IAmazonS3 s3Client, Amazon.S3.Transfer.TransferUtilityDownloadRequest request)

#### Methods
- private static Amazon.S3.Model.ByteRange ByteRangeRemainingForDownload(string filepath)
- public override System.Threading.Tasks.Task ExecuteAsync(System.Threading.CancellationToken cancellationToken)
- private static bool HandleException(System.Exception exception, int retries, int maxRetries)
- private static bool HandleExceptionForHttpClient(System.Exception exception, int retries, int maxRetries)
- private void OnWriteObjectProgressEvent(object sender, Amazon.S3.Model.WriteObjectProgressArgs e)
- private void ValidateRequest()
- private static void WaitBeforeRetry(int retries)

### internal class Amazon.S3.Transfer.Internal.DownloadDirectoryCommand
- Base: Amazon.S3.Transfer.Internal.BaseCommand

#### Fields
- private bool <DownloadFilesConcurrently>k__BackingField
- private Amazon.S3.Transfer.TransferUtilityConfig _config
- private string _currentFile
- private int _numberOfFilesDownloaded
- private readonly Amazon.S3.Transfer.TransferUtilityDownloadDirectoryRequest _request
- private readonly Amazon.S3.IAmazonS3 _s3Client
- private readonly bool _skipEncryptionInstructionFiles
- private long _totalBytes
- private int _totalNumberOfFilesToDownload
- private long _transferredBytes

#### Properties
- public bool DownloadFilesConcurrently { get; set; }

#### Constructors
- internal DownloadDirectoryCommand(Amazon.S3.IAmazonS3 s3Client, Amazon.S3.Transfer.TransferUtilityDownloadDirectoryRequest request)
- internal DownloadDirectoryCommand(Amazon.S3.IAmazonS3 s3Client, Amazon.S3.Transfer.TransferUtilityDownloadDirectoryRequest request, Amazon.S3.Transfer.TransferUtilityConfig config)

#### Methods
- private Amazon.S3.Model.ListObjectsRequest ConstructListObjectRequest()
- private Amazon.S3.Transfer.TransferUtilityDownloadRequest ConstructTransferUtilityDownloadRequest(Amazon.S3.Model.S3Object s3Object, int prefixLength)
- private void downloadedProgressEventCallback(object sender, Amazon.S3.Model.WriteObjectProgressArgs e)
- private void EnsureDirectoryExists(System.IO.DirectoryInfo directory)
- public override System.Threading.Tasks.Task ExecuteAsync(System.Threading.CancellationToken cancellationToken)
- private bool IsInstructionFile(string key)
- private bool ShouldDownload(Amazon.S3.Model.S3Object s3o)
- private void ValidateRequest()

### internal class Amazon.S3.Transfer.Internal.MultipartUploadCommand
- Base: Amazon.S3.Transfer.Internal.BaseCommand

#### Fields
- private System.Threading.SemaphoreSlim <AsyncThrottler>k__BackingField
- private Amazon.S3.Transfer.TransferUtilityConfig _config
- private long _contentLength
- private Amazon.S3.Transfer.TransferUtilityUploadRequest _fileTransporterRequest
- private long _partSize
- private System.Collections.Generic.Queue<Amazon.S3.Model.UploadPartRequest> _partsToUpload
- private Amazon.S3.IAmazonS3 _s3Client
- private int _totalNumberOfParts
- private long _totalTransferredBytes
- private System.Collections.Generic.List<Amazon.S3.Model.UploadPartResponse> _uploadResponses

#### Properties
- public System.Threading.SemaphoreSlim AsyncThrottler { get; set; }
- private static Amazon.Runtime.Internal.Util.Logger Logger { get; }

#### Constructors
- internal MultipartUploadCommand(Amazon.S3.IAmazonS3 s3Client, Amazon.S3.Transfer.TransferUtilityConfig config, Amazon.S3.Transfer.TransferUtilityUploadRequest fileTransporterRequest)

#### Methods
- private void AbortMultipartUpload(string uploadId)
- private int CalculateConcurrentServiceRequests()
- private static long calculatePartSize(long fileSize)
- private void Cleanup(string uploadId, System.Collections.Generic.List<System.Threading.Tasks.Task<Amazon.S3.Model.UploadPartResponse>> tasks)
- private Amazon.S3.Model.CompleteMultipartUploadRequest ConstructCompleteMultipartUploadRequest(Amazon.S3.Model.InitiateMultipartUploadResponse initResponse)
- private Amazon.S3.Model.InitiateMultipartUploadRequest ConstructInitiateMultipartUploadRequest()
- private Amazon.S3.Model.UploadPartRequest ConstructUploadPartRequest(int partNumber, long filePosition, Amazon.S3.Model.InitiateMultipartUploadResponse initResponse)
- private string determineContentType()
- public override System.Threading.Tasks.Task ExecuteAsync(System.Threading.CancellationToken cancellationToken)
- private System.Threading.Tasks.Task<Amazon.S3.Model.UploadPartResponse> UploadPartAsync(Amazon.S3.Model.UploadPartRequest uploadRequest, System.Threading.CancellationTokenSource internalCts, System.Threading.SemaphoreSlim asyncThrottler)
- private void UploadPartProgressEventCallback(object sender, Amazon.S3.Transfer.UploadProgressArgs e)

### internal class Amazon.S3.Transfer.Internal.OpenStreamCommand
- Base: Amazon.S3.Transfer.Internal.BaseCommand

#### Fields
- private Amazon.S3.Transfer.TransferUtilityOpenStreamRequest _request
- private System.IO.Stream _responseStream
- private Amazon.S3.IAmazonS3 _s3Client

#### Properties
- internal System.IO.Stream ResponseStream { get; }
- public object Return { get; }

#### Constructors
- internal OpenStreamCommand(Amazon.S3.IAmazonS3 s3Client, Amazon.S3.Transfer.TransferUtilityOpenStreamRequest request)

#### Methods
- private Amazon.S3.Model.GetObjectRequest ConstructRequest()
- public override System.Threading.Tasks.Task ExecuteAsync(System.Threading.CancellationToken cancellationToken)

### internal class Amazon.S3.Transfer.Internal.ProgressHandler

#### Fields
- private System.EventHandler<Amazon.S3.Transfer.UploadProgressArgs> _callback
- private Amazon.Runtime.StreamTransferProgressArgs _lastProgressArgs

#### Constructors
- public ProgressHandler(System.EventHandler<Amazon.S3.Transfer.UploadProgressArgs> callback)

#### Methods
- public void OnTransferProgress(object sender, Amazon.Runtime.StreamTransferProgressArgs e)

### internal class Amazon.S3.Transfer.Internal.SimpleUploadCommand
- Base: Amazon.S3.Transfer.Internal.BaseCommand

#### Fields
- private System.Threading.SemaphoreSlim <AsyncThrottler>k__BackingField
- private Amazon.S3.Transfer.TransferUtilityConfig _config
- private Amazon.S3.Transfer.TransferUtilityUploadRequest _fileTransporterRequest
- private Amazon.S3.IAmazonS3 _s3Client

#### Properties
- public System.Threading.SemaphoreSlim AsyncThrottler { get; set; }

#### Constructors
- internal SimpleUploadCommand(Amazon.S3.IAmazonS3 s3Client, Amazon.S3.Transfer.TransferUtilityConfig config, Amazon.S3.Transfer.TransferUtilityUploadRequest fileTransporterRequest)

#### Methods
- private Amazon.S3.Model.PutObjectRequest ConstructRequest()
- public override System.Threading.Tasks.Task ExecuteAsync(System.Threading.CancellationToken cancellationToken)
- private void PutObjectProgressEventCallback(object sender, Amazon.S3.Transfer.UploadProgressArgs e)

### internal class Amazon.S3.Transfer.Internal.UploadDirectoryCommand
- Base: Amazon.S3.Transfer.Internal.BaseCommand

#### Fields
- private bool <UploadFilesConcurrently>k__BackingField
- private Amazon.S3.Transfer.TransferUtilityConfig _config
- private int _numberOfFilesUploaded
- private Amazon.S3.Transfer.TransferUtilityUploadDirectoryRequest _request
- private long _totalBytes
- private int _totalNumberOfFiles
- private long _transferredBytes
- private Amazon.S3.Transfer.TransferUtility _utility

#### Properties
- public bool UploadFilesConcurrently { get; set; }

#### Constructors
- internal UploadDirectoryCommand(Amazon.S3.Transfer.TransferUtility utility, Amazon.S3.Transfer.TransferUtilityConfig config, Amazon.S3.Transfer.TransferUtilityUploadDirectoryRequest request)

#### Methods
- private Amazon.S3.Transfer.TransferUtilityUploadRequest ConstructRequest(string basePath, string filepath, string prefix)
- public override System.Threading.Tasks.Task ExecuteAsync(System.Threading.CancellationToken cancellationToken)
- private System.Threading.Tasks.Task<string[]> GetFiles(string path, string searchPattern, System.IO.SearchOption searchOption, System.Threading.CancellationToken cancellationToken)
- private string GetKeyPrefix()
- private void UploadProgressEventCallback(object sender, Amazon.S3.Transfer.UploadProgressArgs e)

## Namespace: Amazon.S3.Util

### private struct Amazon.S3.Util.AmazonS3Util.<DeleteS3BucketWithObjectsInternalAsync>d__27
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.ListVersionsResponse> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.DeleteObjectsResponse> <>u__2
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.DeleteBucketResponse> <>u__3
- private Amazon.S3.Model.ListVersionsRequest <listVersionsRequest>5__2
- private Amazon.S3.Model.ListVersionsResponse <listVersionsResponse>5__3
- private int <retries>5__4
- public string bucketName
- public Amazon.S3.Util.S3DeleteBucketWithObjectsOptions deleteOptions
- public Amazon.S3.IAmazonS3 s3Client
- public System.Threading.CancellationToken token
- public System.Action<Amazon.S3.Util.S3DeleteBucketWithObjectsUpdate> updateCallback

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Util.BucketRegionDetector.<DetectMismatchWithHeadBucketFallbackAsync>d__12
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private Amazon.S3.Util.AmazonS3Uri <>7__wrap1
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<string> <>u__1
- public Amazon.Runtime.ImmutableCredentials credentials
- public Amazon.S3.Util.AmazonS3Uri requestedBucketUri
- public Amazon.Runtime.AmazonServiceException serviceException

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Util.AmazonS3Util.<DoesS3BucketExistAsync>d__20
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<System.Net.WebResponse> <>u__1
- public string bucketName
- public Amazon.S3.IAmazonS3 s3Client

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Util.AmazonS3Util.<DoesS3BucketExistV2Async>d__19
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.Model.GetACLResponse> <>u__1
- public string bucketName
- public Amazon.S3.IAmazonS3 s3Client

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.S3.Util.BucketRegionDetector.<GetBucketRegionNoPipelineAsync>d__13
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.S3.GetHeadResponse> <>u__1
- private Amazon.S3.AmazonS3Client <s3Client>5__2
- public string bucketName
- public Amazon.Runtime.ImmutableCredentials credentials

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class Amazon.S3.Util.AmazonS3Uri

#### Fields
- private string <Bucket>k__BackingField
- private bool <IsPathStyle>k__BackingField
- private string <Key>k__BackingField
- private Amazon.RegionEndpoint <Region>k__BackingField
- private static const string EndpointPattern

#### Properties
- public string Bucket { get; private set; }
- public bool IsPathStyle { get; private set; }
- public string Key { get; private set; }
- public Amazon.RegionEndpoint Region { get; set; }

#### Constructors
- public AmazonS3Uri(string uri)
- public AmazonS3Uri(System.Uri uri)

#### Methods
- private static void AppendDecoded(System.Text.StringBuilder builder, string s, int index)
- private static string Decode(string s)
- private static string Decode(string s, int firstPercent)
- private static int FromHex(char c)
- public static bool IsAmazonS3Endpoint(string uri)
- public static bool IsAmazonS3Endpoint(System.Uri uri)
- public static bool TryParseAmazonS3Uri(string uri, out Amazon.S3.Util.AmazonS3Uri amazonS3Uri)
- public static bool TryParseAmazonS3Uri(System.Uri uri, out Amazon.S3.Util.AmazonS3Uri amazonS3Uri)

### public static class Amazon.S3.Util.AmazonS3Util

#### Fields
- private static System.Collections.Generic.Dictionary<string, string> extensionToMime

#### Properties
- public static string FormattedCurrentTimestamp { get; }

#### Constructors
- private static AmazonS3Util()

#### Methods
- internal static void AddQueryStringParameter(System.Text.StringBuilder queryString, string parameterName, string parameterValue)
- internal static void AddQueryStringParameter(System.Text.StringBuilder queryString, string parameterName, string parameterValue, System.Collections.Generic.IDictionary<string, string> parameterMap)
- internal static string ComputeEncodedMD5FromEncodedString(string base64EncodedString)
- public static System.Threading.Tasks.Task DeleteS3BucketWithObjectsAsync(Amazon.S3.IAmazonS3 s3Client, string bucketName)
- public static System.Threading.Tasks.Task DeleteS3BucketWithObjectsAsync(Amazon.S3.IAmazonS3 s3Client, string bucketName, Amazon.S3.Util.S3DeleteBucketWithObjectsOptions deleteOptions)
- public static System.Threading.Tasks.Task DeleteS3BucketWithObjectsAsync(Amazon.S3.IAmazonS3 s3Client, string bucketName, System.Threading.CancellationToken token)
- public static System.Threading.Tasks.Task DeleteS3BucketWithObjectsAsync(Amazon.S3.IAmazonS3 s3Client, string bucketName, Amazon.S3.Util.S3DeleteBucketWithObjectsOptions deleteOptions, System.Threading.CancellationToken token)
- public static System.Threading.Tasks.Task DeleteS3BucketWithObjectsAsync(Amazon.S3.IAmazonS3 s3Client, string bucketName, Amazon.S3.Util.S3DeleteBucketWithObjectsOptions deleteOptions, System.Action<Amazon.S3.Util.S3DeleteBucketWithObjectsUpdate> updateCallback, System.Threading.CancellationToken token)
- private static System.Threading.Tasks.Task DeleteS3BucketWithObjectsInternalAsync(Amazon.S3.IAmazonS3 s3Client, string bucketName, Amazon.S3.Util.S3DeleteBucketWithObjectsOptions deleteOptions, System.Action<Amazon.S3.Util.S3DeleteBucketWithObjectsUpdate> updateCallback, System.Threading.CancellationToken token)
- public static System.Threading.Tasks.Task<bool> DoesS3BucketExistAsync(Amazon.S3.IAmazonS3 s3Client, string bucketName)
- public static System.Threading.Tasks.Task<bool> DoesS3BucketExistV2Async(Amazon.S3.IAmazonS3 s3Client, string bucketName)
- public static string GenerateChecksumForContent(string content, bool fBase64Encode)
- private static System.Threading.Tasks.Task InvokeDeleteS3BucketWithObjects(object state, System.Threading.CancellationToken token)
- private static void InvokeS3DeleteBucketWithObjectsUpdateCallback(System.Action<Amazon.S3.Util.S3DeleteBucketWithObjectsUpdate> updateCallback, Amazon.S3.Util.S3DeleteBucketWithObjectsUpdate update)
- internal static bool IsInstructionFile(string key)
- public static System.IO.Stream MakeStreamSeekable(System.IO.Stream input)
- public static string MimeTypeFromExtension(string ext)
- internal static void ParseAmzRestoreHeader(string header, out bool restoreInProgress, out System.Nullable<System.DateTime> restoreExpiration)
- internal static System.Nullable<System.DateTime> ParseExpiresHeader(string rawValue, string requestId)
- internal static string SerializeTaggingToXml(Amazon.S3.Model.Tagging tagging)
- internal static void SerializeTagSetToXml(System.Xml.XmlWriter xmlWriter, System.Collections.Generic.List<Amazon.S3.Model.Tag> tagset)
- internal static void SerializeTagToXml(System.Xml.XmlWriter xmlWriter, Amazon.S3.Model.Tag tag)
- internal static void SetMetadataHeaders(Amazon.Runtime.Internal.IRequest request, Amazon.S3.Model.MetadataCollection metadata)
- internal static string TagSetToQueryString(System.Collections.Generic.List<Amazon.S3.Model.Tag> tags)
- public static string UrlEncode(string data, bool path)
- public static bool ValidateV2Bucket(string bucketName)

### public static class Amazon.S3.Util.BucketRegionDetector

#### Fields
- private static Amazon.Runtime.Internal.Util.LruCache<string, Amazon.RegionEndpoint> <BucketRegionCache>k__BackingField
- private static const string AuthorizationHeaderMalformedErrorCode
- private static const int BucketRegionCacheMaxEntries

#### Properties
- public static Amazon.Runtime.Internal.Util.LruCache<string, Amazon.RegionEndpoint> BucketRegionCache { get; private set; }

#### Constructors
- private static BucketRegionDetector()

#### Methods
- private static string CheckRegionAndUpdateCache(Amazon.S3.Util.AmazonS3Uri requestedBucketUri, string actualRegion)
- internal static System.Threading.Tasks.Task<string> DetectMismatchWithHeadBucketFallbackAsync(Amazon.S3.Util.AmazonS3Uri requestedBucketUri, Amazon.Runtime.AmazonServiceException serviceException, Amazon.Runtime.ImmutableCredentials credentials)
- private static System.Threading.Tasks.Task<string> GetBucketRegionNoPipelineAsync(string bucketName, Amazon.Runtime.ImmutableCredentials credentials)
- internal static string GetCorrectRegion(Amazon.S3.Util.AmazonS3Uri requestedBucketUri, System.Net.HttpStatusCode headBucketStatusCode, string xAmzBucketRegionHeaderValue)
- private static string GetCorrectRegion(Amazon.S3.Util.AmazonS3Uri requestedBucketUri, Amazon.Runtime.AmazonServiceException serviceException)
- private static string GetHeadBucketPreSignedUrl(string bucketName, Amazon.Runtime.ImmutableCredentials credentials)
- private static Amazon.S3.AmazonS3Client GetUsEast1ClientFromCredentials(Amazon.Runtime.ImmutableCredentials credentials)

### public class Amazon.S3.Util.S3EventNotification.RequestParametersEntity

#### Fields
- private string <SourceIPAddress>k__BackingField

#### Properties
- public string SourceIPAddress { get; set; }

#### Constructors
- public S3EventNotification.RequestParametersEntity()

### public class Amazon.S3.Util.S3EventNotification.ResponseElementsEntity

#### Fields
- private string <XAmzId2>k__BackingField
- private string <XAmzRequestId>k__BackingField

#### Properties
- public string XAmzId2 { get; set; }
- public string XAmzRequestId { get; set; }

#### Constructors
- public S3EventNotification.ResponseElementsEntity()

### public class Amazon.S3.Util.S3EventNotification.S3BucketEntity

#### Fields
- private string <Arn>k__BackingField
- private string <Name>k__BackingField
- private Amazon.S3.Util.S3EventNotification.UserIdentityEntity <OwnerIdentity>k__BackingField

#### Properties
- public string Arn { get; set; }
- public string Name { get; set; }
- public Amazon.S3.Util.S3EventNotification.UserIdentityEntity OwnerIdentity { get; set; }

#### Constructors
- public S3EventNotification.S3BucketEntity()

### internal static class Amazon.S3.Util.S3Constants

#### Fields
- internal static const string AmzGrantHeaderFullControl
- internal static const string AmzGrantHeaderRead
- internal static const string AmzGrantHeaderReadAcp
- internal static const string AmzGrantHeaderRestoreObject
- internal static const string AmzGrantHeaderWrite
- internal static const string AmzGrantHeaderWriteAcp
- internal static string AmzHeaderMultipartPartsCount
- internal static string AmzHeaderRequestCharged
- internal static string AmzHeaderRequestPayer
- internal static string AmzHeaderRestoreOutputPath
- internal static string AmzHeaderTagging
- internal static string AmzHeaderTaggingCount
- internal static string AmzHeaderTaggingDirective
- internal static readonly string[] BucketVersions
- internal static const int DefaultBufferSize
- internal static const string EncryptionInstructionfileSuffix
- internal static System.Collections.Generic.HashSet<string> GetObjectExtraSubResources
- internal static const int MaxBucketLength
- internal static const int MaxNumberOfParts
- internal static readonly string[] MetadataDirectives
- internal static const int MinBucketLength
- internal static readonly long MinPartSize
- internal static const int MULTIPLE_OBJECT_DELETE_LIMIT
- internal static const string NoSuchBucketPolicy
- internal static const string NoSuchCORSConfiguration
- internal static const string NoSuchLifecycleConfiguration
- internal static const string NoSuchWebsiteConfiguration
- internal static string PostFormDataAccessKeyId
- internal static string PostFormDataAcl
- internal static string PostFormDataContentType
- internal static string PostFormDataMetaPrefix
- internal static string PostFormDataObjectKey
- internal static string PostFormDataPolicy
- internal static string PostFormDataRedirect
- internal static string PostFormDataSecurityToken
- internal static string PostFormDataSignature
- internal static string PostFormDataStatus
- internal static string PostFormDataXAmzAlgorithm
- internal static string PostFormDataXAmzCredential
- internal static string PostFormDataXAmzDate
- internal static string PostFormDataXAmzPrefix
- internal static string PostFormDataXAmzSignature
- internal static const int PutObjectDefaultTimeout
- internal static const string REGION_EU_WEST_1
- internal static const string REGION_US_EAST_1
- internal static const string S3AlternateDefaultEndpoint
- internal static const string S3DefaultEndpoint
- internal static const string VersioningEnabled
- internal static const string VersioningOff
- internal static const string VersioningSuspended

#### Constructors
- private static S3Constants()

### public class Amazon.S3.Util.S3DeleteBucketWithObjectsOptions

#### Fields
- private bool <ContinueOnError>k__BackingField
- private bool <QuietMode>k__BackingField

#### Properties
- public bool ContinueOnError { get; set; }
- public bool QuietMode { get; set; }

#### Constructors
- public S3DeleteBucketWithObjectsOptions()

### internal class Amazon.S3.Util.S3DeleteBucketWithObjectsRequest

#### Fields
- private string <BucketName>k__BackingField
- private Amazon.S3.Util.S3DeleteBucketWithObjectsOptions <DeleteOptions>k__BackingField
- private Amazon.S3.IAmazonS3 <S3Client>k__BackingField
- private System.Action<Amazon.S3.Util.S3DeleteBucketWithObjectsUpdate> <UpdateCallback>k__BackingField

#### Properties
- public string BucketName { get; set; }
- public Amazon.S3.Util.S3DeleteBucketWithObjectsOptions DeleteOptions { get; set; }
- public Amazon.S3.IAmazonS3 S3Client { get; set; }
- public System.Action<Amazon.S3.Util.S3DeleteBucketWithObjectsUpdate> UpdateCallback { get; set; }

#### Constructors
- public S3DeleteBucketWithObjectsRequest()

### public class Amazon.S3.Util.S3DeleteBucketWithObjectsUpdate

#### Fields
- private System.Collections.Generic.IList<Amazon.S3.Model.DeletedObject> <DeletedObjects>k__BackingField
- private System.Collections.Generic.IList<Amazon.S3.Model.DeleteError> <DeleteErrors>k__BackingField

#### Properties
- public System.Collections.Generic.IList<Amazon.S3.Model.DeletedObject> DeletedObjects { get; set; }
- public System.Collections.Generic.IList<Amazon.S3.Model.DeleteError> DeleteErrors { get; set; }

#### Constructors
- public S3DeleteBucketWithObjectsUpdate()

### public class Amazon.S3.Util.S3EventNotification.S3Entity

#### Fields
- private Amazon.S3.Util.S3EventNotification.S3BucketEntity <Bucket>k__BackingField
- private string <ConfigurationId>k__BackingField
- private Amazon.S3.Util.S3EventNotification.S3ObjectEntity <Object>k__BackingField
- private string <S3SchemaVersion>k__BackingField

#### Properties
- public Amazon.S3.Util.S3EventNotification.S3BucketEntity Bucket { get; set; }
- public string ConfigurationId { get; set; }
- public Amazon.S3.Util.S3EventNotification.S3ObjectEntity Object { get; set; }
- public string S3SchemaVersion { get; set; }

#### Constructors
- public S3EventNotification.S3Entity()

### public class Amazon.S3.Util.S3EventNotification

#### Fields
- private System.Collections.Generic.List<Amazon.S3.Util.S3EventNotification.S3EventNotificationRecord> <Records>k__BackingField

#### Properties
- public System.Collections.Generic.List<Amazon.S3.Util.S3EventNotification.S3EventNotificationRecord> Records { get; set; }

#### Constructors
- public S3EventNotification()

#### Methods
- private static System.Nullable<System.DateTime> GetValueAsDateTime(ThirdParty.Json.LitJson.JsonData data, string key)
- private static long GetValueAsLong(ThirdParty.Json.LitJson.JsonData data, string key)
- private static string GetValueAsString(ThirdParty.Json.LitJson.JsonData data, string key)
- public static Amazon.S3.Util.S3EventNotification ParseJson(string json)

### public class Amazon.S3.Util.S3EventNotification.S3EventNotificationRecord

#### Fields
- private string <AwsRegion>k__BackingField
- private Amazon.S3.EventType <EventName>k__BackingField
- private string <EventSource>k__BackingField
- private System.DateTime <EventTime>k__BackingField
- private string <EventVersion>k__BackingField
- private Amazon.S3.Util.S3EventNotification.S3GlacierEventDataEntity <GlacierEventData>k__BackingField
- private Amazon.S3.Util.S3EventNotification.RequestParametersEntity <RequestParameters>k__BackingField
- private Amazon.S3.Util.S3EventNotification.ResponseElementsEntity <ResponseElements>k__BackingField
- private Amazon.S3.Util.S3EventNotification.S3Entity <S3>k__BackingField
- private Amazon.S3.Util.S3EventNotification.UserIdentityEntity <UserIdentity>k__BackingField

#### Properties
- public string AwsRegion { get; set; }
- public Amazon.S3.EventType EventName { get; set; }
- public string EventSource { get; set; }
- public System.DateTime EventTime { get; set; }
- public string EventVersion { get; set; }
- public Amazon.S3.Util.S3EventNotification.S3GlacierEventDataEntity GlacierEventData { get; set; }
- public Amazon.S3.Util.S3EventNotification.RequestParametersEntity RequestParameters { get; set; }
- public Amazon.S3.Util.S3EventNotification.ResponseElementsEntity ResponseElements { get; set; }
- public Amazon.S3.Util.S3EventNotification.S3Entity S3 { get; set; }
- public Amazon.S3.Util.S3EventNotification.UserIdentityEntity UserIdentity { get; set; }

#### Constructors
- public S3EventNotification.S3EventNotificationRecord()

### public class Amazon.S3.Util.S3EventNotification.S3GlacierEventDataEntity

#### Fields
- private Amazon.S3.Util.S3EventNotification.S3RestoreEventDataEntity <RestoreEventData>k__BackingField

#### Properties
- public Amazon.S3.Util.S3EventNotification.S3RestoreEventDataEntity RestoreEventData { get; set; }

#### Constructors
- public S3EventNotification.S3GlacierEventDataEntity()

### public class Amazon.S3.Util.S3EventNotification.S3ObjectEntity

#### Fields
- private string <ETag>k__BackingField
- private string <Key>k__BackingField
- private string <Sequencer>k__BackingField
- private long <Size>k__BackingField
- private string <VersionId>k__BackingField

#### Properties
- public string ETag { get; set; }
- public string Key { get; set; }
- public string Sequencer { get; set; }
- public long Size { get; set; }
- public string VersionId { get; set; }

#### Constructors
- public S3EventNotification.S3ObjectEntity()

### public class Amazon.S3.Util.S3EventNotification.S3RestoreEventDataEntity

#### Fields
- private System.DateTime <LifecycleRestorationExpiryTime>k__BackingField
- private string <LifecycleRestoreStorageClass>k__BackingField

#### Properties
- public System.DateTime LifecycleRestorationExpiryTime { get; set; }
- public string LifecycleRestoreStorageClass { get; set; }

#### Constructors
- public S3EventNotification.S3RestoreEventDataEntity()

### public class Amazon.S3.Util.S3EventNotification.UserIdentityEntity

#### Fields
- private string <PrincipalId>k__BackingField

#### Properties
- public string PrincipalId { get; set; }

#### Constructors
- public S3EventNotification.UserIdentityEntity()

