# Assembly: AWSSDK.Core
- Path: tools/WorldBox.Managed/AWSSDK.Core.dll
- Types: 624

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly long 061A5324C70B4F1E6D47D61AE85585A1A0C17AB4
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 50B1635D1FB2907A171B71751E1A3FA79423CA17

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112

## Namespace: Amazon

### public static class Amazon.AWSConfigs

#### Fields
- private static System.TimeSpan <ClockOffset>k__BackingField
- public static const string AWSProfileNameKey
- public static const string AWSProfilesLocationKey
- public static const string AWSRegionKey
- private static bool configPresent
- public static const string EndpointDefinitionKey
- internal static const string LoggingDestinationProperty
- public static const string LoggingKey
- public static const string LogMetricsKey
- internal static System.ComponentModel.PropertyChangedEventHandler mPropertyChanged
- internal static readonly object propertyChangedLock
- public static const string ResponseLoggingKey
- private static System.Collections.Generic.List<string> standardConfigs
- public static const string UseSdkCacheKey
- internal static System.Func<System.DateTime> utcNowSource
- private static char[] validSeparators
- internal static string _awsAccountsLocation
- internal static string _awsProfileName
- internal static string _awsRegion
- internal static string _endpointDefinition
- private static object _lock
- internal static Amazon.LoggingOptions _logging
- internal static bool _logMetrics
- internal static Amazon.ResponseLoggingOption _responseLogging
- private static Amazon.Util.Internal.RootConfig _rootConfig
- private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Diagnostics.TraceListener>> _traceListeners
- internal static bool _useSdkCache

#### Properties
- public static string AWSProfileName { get; set; }
- public static string AWSProfilesLocation { get; set; }
- public static string AWSRegion { get; set; }
- public static System.TimeSpan ClockOffset { get; internal set; }
- public static bool CorrectForClockSkew { get; set; }
- public static Amazon.Util.CSMConfig CSMConfig { get; set; }
- public static string EndpointDefinition { get; set; }
- public static Amazon.LoggingOptions Logging { get; set; }
- public static Amazon.Util.LoggingConfig LoggingConfig { get; }
- public static bool LogMetrics { get; set; }
- public static System.Nullable<System.TimeSpan> ManualClockCorrection { get; set; }
- public static Amazon.Util.ProxyConfig ProxyConfig { get; }
- public static Amazon.RegionEndpoint RegionEndpoint { get; set; }
- public static Amazon.ResponseLoggingOption ResponseLogging { get; set; }
- public static bool UseSdkCache { get; set; }

#### Events
- internal static event System.ComponentModel.PropertyChangedEventHandler PropertyChanged

#### Constructors
- private static AWSConfigs()

#### Methods
- public static void AddTraceListener(string source, System.Diagnostics.TraceListener listener)
- public static string GetConfig(string name)
- private static bool GetConfigBool(string name, bool defaultValue = false)
- private static T GetConfigEnum<T>(string name)
- private static Amazon.LoggingOptions GetLoggingSetting()
- private static System.DateTime GetUtcNow()
- internal static void OnPropertyChanged(string name)
- private static T ParseEnum<T>(string value)
- public static void RemoveTraceListener(string source, string name)
- internal static System.Diagnostics.TraceListener[] TraceListeners(string source)
- private static bool TryParseEnum<T>(string value, out T result)
- internal static bool XmlSectionExists(string sectionName)

### public class Amazon.RegionEndpoint.Endpoint

#### Fields
- private string <AuthRegion>k__BackingField
- private string <Hostname>k__BackingField
- private string <SignatureVersionOverride>k__BackingField

#### Properties
- public string AuthRegion { get; private set; }
- public string Hostname { get; private set; }
- public string SignatureVersionOverride { get; private set; }

#### Constructors
- internal RegionEndpoint.Endpoint(string hostname, string authregion, string signatureVersionOverride)

#### Methods
- public override string ToString()

### public enum Amazon.LoggingOptions
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Console = 16
- Log4Net = 1
- None = 0
- SystemDiagnostics = 2

### public enum Amazon.LogMetricsFormatOption
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- JSON = 1
- Standard = 0

### public class Amazon.RegionEndpoint

#### Fields
- private string <DisplayName>k__BackingField
- private string <SystemName>k__BackingField
- public static readonly Amazon.RegionEndpoint APEast1
- public static readonly Amazon.RegionEndpoint APNortheast1
- public static readonly Amazon.RegionEndpoint APNortheast2
- public static readonly Amazon.RegionEndpoint APNortheast3
- public static readonly Amazon.RegionEndpoint APSouth1
- public static readonly Amazon.RegionEndpoint APSoutheast1
- public static readonly Amazon.RegionEndpoint APSoutheast2
- public static readonly Amazon.RegionEndpoint CACentral1
- public static readonly Amazon.RegionEndpoint CNNorth1
- public static readonly Amazon.RegionEndpoint CNNorthWest1
- public static readonly Amazon.RegionEndpoint EUCentral1
- public static readonly Amazon.RegionEndpoint EUNorth1
- public static readonly Amazon.RegionEndpoint EUWest1
- public static readonly Amazon.RegionEndpoint EUWest2
- public static readonly Amazon.RegionEndpoint EUWest3
- public static readonly Amazon.RegionEndpoint SAEast1
- public static readonly Amazon.RegionEndpoint USEast1
- public static readonly Amazon.RegionEndpoint USEast2
- public static readonly Amazon.RegionEndpoint USGovCloudEast1
- public static readonly Amazon.RegionEndpoint USGovCloudWest1
- public static readonly Amazon.RegionEndpoint USWest1
- public static readonly Amazon.RegionEndpoint USWest2
- private static System.Collections.Generic.Dictionary<string, Amazon.RegionEndpoint> _hashBySystemName
- private static Amazon.Internal.IRegionEndpointProvider _regionEndpointProvider

#### Properties
- public string DisplayName { get; private set; }
- public static System.Collections.Generic.IEnumerable<Amazon.RegionEndpoint> EnumerableAllRegions { get; }
- private Amazon.Internal.IRegionEndpoint InternedRegionEndpoint { get; }
- private static Amazon.Internal.IRegionEndpointProvider RegionEndpointProvider { get; }
- public string SystemName { get; private set; }

#### Constructors
- private static RegionEndpoint()
- private RegionEndpoint(string systemName, string displayName)

#### Methods
- public static Amazon.RegionEndpoint GetBySystemName(string systemName)
- private static Amazon.RegionEndpoint GetEndpoint(string systemName, string displayName)
- public Amazon.RegionEndpoint.Endpoint GetEndpointForService(string serviceName)
- public Amazon.RegionEndpoint.Endpoint GetEndpointForService(string serviceName, bool dualStack)
- public override string ToString()

### public enum Amazon.ResponseLoggingOption
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Always = 2
- Never = 0
- OnError = 1

## Namespace: Amazon.Auth.AccessControlPolicy

### private class Amazon.Auth.AccessControlPolicy.Policy.<>c__DisplayClass18_0

#### Fields
- public Amazon.Auth.AccessControlPolicy.Resource resource

#### Constructors
- public Policy.<>c__DisplayClass18_0()

#### Methods
- internal bool <StatementContainsResources>b__0(Amazon.Auth.AccessControlPolicy.Resource x)

### private class Amazon.Auth.AccessControlPolicy.Policy.<>c__DisplayClass19_0

#### Fields
- public Amazon.Auth.AccessControlPolicy.ActionIdentifier action

#### Constructors
- public Policy.<>c__DisplayClass19_0()

#### Methods
- internal bool <StatementContainsActions>b__0(Amazon.Auth.AccessControlPolicy.ActionIdentifier x)

### private class Amazon.Auth.AccessControlPolicy.Policy.<>c__DisplayClass20_0

#### Fields
- public Amazon.Auth.AccessControlPolicy.Condition condition

#### Constructors
- public Policy.<>c__DisplayClass20_0()

#### Methods
- internal bool <StatementContainsConditions>b__0(Amazon.Auth.AccessControlPolicy.Condition x)

### private class Amazon.Auth.AccessControlPolicy.Policy.<>c__DisplayClass21_0

#### Fields
- public Amazon.Auth.AccessControlPolicy.Principal principal

#### Constructors
- public Policy.<>c__DisplayClass21_0()

#### Methods
- internal bool <StatementContainsPrincipals>b__0(Amazon.Auth.AccessControlPolicy.Principal x)

### public class Amazon.Auth.AccessControlPolicy.ActionIdentifier

#### Fields
- private string actionName

#### Properties
- public string ActionName { get; set; }

#### Constructors
- public ActionIdentifier(string actionName)

### public enum Amazon.Auth.AccessControlPolicy.ConditionFactory.ArnComparisonType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ArnEquals = 0
- ArnLike = 1
- ArnNotEquals = 2
- ArnNotLike = 3

### public class Amazon.Auth.AccessControlPolicy.Condition

#### Fields
- private string conditionKey
- private string type
- private string[] values

#### Properties
- public string ConditionKey { get; set; }
- public string Type { get; set; }
- public string[] Values { get; set; }

#### Constructors
- public Condition()
- public Condition(string type, string conditionKey, params string[] values)

### public static class Amazon.Auth.AccessControlPolicy.ConditionFactory

#### Fields
- public static const string CURRENT_TIME_CONDITION_KEY
- public static const string EPOCH_TIME_CONDITION_KEY
- public static const string REFERRER_CONDITION_KEY
- public static const string S3_CANNED_ACL_CONDITION_KEY
- public static const string S3_COPY_SOURCE_CONDITION_KEY
- public static const string S3_DELIMITER_CONDITION_KEY
- public static const string S3_LOCATION_CONSTRAINT_CONDITION_KEY
- public static const string S3_MAX_KEYS_CONDITION_KEY
- public static const string S3_METADATA_DIRECTIVE_CONDITION_KEY
- public static const string S3_PREFIX_CONDITION_KEY
- public static const string S3_VERSION_ID_CONDITION_KEY
- public static const string SECURE_TRANSPORT_CONDITION_KEY
- public static const string SNS_ENDPOINT_CONDITION_KEY
- public static const string SNS_PROTOCOL_CONDITION_KEY
- public static const string SOURCE_ARN_CONDITION_KEY
- public static const string SOURCE_IP_CONDITION_KEY
- public static const string USER_AGENT_CONDITION_KEY

#### Methods
- public static Amazon.Auth.AccessControlPolicy.Condition NewCannedACLCondition(string cannedAcl)
- public static Amazon.Auth.AccessControlPolicy.Condition NewCondition(Amazon.Auth.AccessControlPolicy.ConditionFactory.ArnComparisonType type, string key, string value)
- public static Amazon.Auth.AccessControlPolicy.Condition NewCondition(string key, bool value)
- public static Amazon.Auth.AccessControlPolicy.Condition NewCondition(Amazon.Auth.AccessControlPolicy.ConditionFactory.DateComparisonType type, System.DateTime date)
- public static Amazon.Auth.AccessControlPolicy.Condition NewCondition(Amazon.Auth.AccessControlPolicy.ConditionFactory.IpAddressComparisonType type, string ipAddressRange)
- public static Amazon.Auth.AccessControlPolicy.Condition NewCondition(Amazon.Auth.AccessControlPolicy.ConditionFactory.NumericComparisonType type, string key, string value)
- public static Amazon.Auth.AccessControlPolicy.Condition NewCondition(Amazon.Auth.AccessControlPolicy.ConditionFactory.StringComparisonType type, string key, string value)
- public static Amazon.Auth.AccessControlPolicy.Condition NewConditionUtc(Amazon.Auth.AccessControlPolicy.ConditionFactory.DateComparisonType type, System.DateTime date)
- public static Amazon.Auth.AccessControlPolicy.Condition NewEndpointCondition(string endpointPattern)
- public static Amazon.Auth.AccessControlPolicy.Condition NewIpAddressCondition(string ipAddressRange)
- public static Amazon.Auth.AccessControlPolicy.Condition NewProtocolCondition(string protocol)
- public static Amazon.Auth.AccessControlPolicy.Condition NewSecureTransportCondition()
- public static Amazon.Auth.AccessControlPolicy.Condition NewSourceArnCondition(string arnPattern)

### public enum Amazon.Auth.AccessControlPolicy.ConditionFactory.DateComparisonType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DateEquals = 0
- DateGreaterThan = 1
- DateGreaterThanEquals = 2
- DateLessThan = 3
- DateLessThanEquals = 4
- DateNotEquals = 5

### public enum Amazon.Auth.AccessControlPolicy.ConditionFactory.IpAddressComparisonType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- IpAddress = 0
- NotIpAddress = 1

### public enum Amazon.Auth.AccessControlPolicy.ConditionFactory.NumericComparisonType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NumericEquals = 0
- NumericGreaterThan = 1
- NumericGreaterThanEquals = 2
- NumericLessThan = 3
- NumericLessThanEquals = 4
- NumericNotEquals = 5

### public class Amazon.Auth.AccessControlPolicy.Policy

#### Fields
- private static const string DEFAULT_POLICY_VERSION
- private string id
- private System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.Statement> statements
- private string version

#### Properties
- public string Id { get; set; }
- public System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.Statement> Statements { get; set; }
- public string Version { get; set; }

#### Constructors
- public Policy()
- public Policy(string id)
- public Policy(string id, System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.Statement> statements)

#### Methods
- public bool CheckIfStatementExists(Amazon.Auth.AccessControlPolicy.Statement statement)
- public static Amazon.Auth.AccessControlPolicy.Policy FromJson(string json)
- private static bool StatementContainsActions(Amazon.Auth.AccessControlPolicy.Statement statement, System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.ActionIdentifier> actions)
- private static bool StatementContainsConditions(Amazon.Auth.AccessControlPolicy.Statement statement, System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.Condition> conditions)
- private static bool StatementContainsPrincipals(Amazon.Auth.AccessControlPolicy.Statement statement, System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.Principal> principals)
- private static bool StatementContainsResources(Amazon.Auth.AccessControlPolicy.Statement statement, System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.Resource> resources)
- public string ToJson()
- public string ToJson(bool prettyPrint)
- public Amazon.Auth.AccessControlPolicy.Policy WithId(string id)
- public Amazon.Auth.AccessControlPolicy.Policy WithStatements(params Amazon.Auth.AccessControlPolicy.Statement[] statements)

### public class Amazon.Auth.AccessControlPolicy.Principal

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.Principal AllUsers
- public static readonly Amazon.Auth.AccessControlPolicy.Principal Anonymous
- public static const string ANONYMOUS_PROVIDER
- public static const string AWS_PROVIDER
- public static const string CANONICAL_USER_PROVIDER
- public static const string FEDERATED_PROVIDER
- private string id
- private string provider
- public static const string SERVICE_PROVIDER

#### Properties
- public string Id { get; }
- public string Provider { get; set; }

#### Constructors
- private static Principal()
- public Principal(string accountId)
- public Principal(string provider, string id)
- public Principal(string provider, string id, bool stripHyphen)

### public class Amazon.Auth.AccessControlPolicy.Resource

#### Fields
- private string resource

#### Properties
- public string Id { get; }

#### Constructors
- public Resource(string resource)

### public static class Amazon.Auth.AccessControlPolicy.ResourceFactory

#### Methods
- private static string FormatAccountId(string accountId)
- public static Amazon.Auth.AccessControlPolicy.Resource NewS3BucketResource(string bucketName)
- public static Amazon.Auth.AccessControlPolicy.Resource NewS3ObjectResource(string bucketName, string keyPattern)
- public static Amazon.Auth.AccessControlPolicy.Resource NewSQSQueueResource(string accountId, string queueName)

### public class Amazon.Auth.AccessControlPolicy.Statement

#### Fields
- private System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.ActionIdentifier> actions
- private System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.Condition> conditions
- private Amazon.Auth.AccessControlPolicy.Statement.StatementEffect effect
- private string id
- private System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.Principal> principals
- private System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.Resource> resources

#### Properties
- public System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.ActionIdentifier> Actions { get; set; }
- public System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.Condition> Conditions { get; set; }
- public Amazon.Auth.AccessControlPolicy.Statement.StatementEffect Effect { get; set; }
- public string Id { get; set; }
- public System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.Principal> Principals { get; set; }
- public System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.Resource> Resources { get; set; }

#### Constructors
- public Statement(Amazon.Auth.AccessControlPolicy.Statement.StatementEffect effect)

#### Methods
- public Amazon.Auth.AccessControlPolicy.Statement WithActionIdentifiers(params Amazon.Auth.AccessControlPolicy.ActionIdentifier[] actions)
- public Amazon.Auth.AccessControlPolicy.Statement WithConditions(params Amazon.Auth.AccessControlPolicy.Condition[] conditions)
- public Amazon.Auth.AccessControlPolicy.Statement WithId(string id)
- public Amazon.Auth.AccessControlPolicy.Statement WithPrincipals(params Amazon.Auth.AccessControlPolicy.Principal[] principals)
- public Amazon.Auth.AccessControlPolicy.Statement WithResources(params Amazon.Auth.AccessControlPolicy.Resource[] resources)

### public enum Amazon.Auth.AccessControlPolicy.Statement.StatementEffect
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Allow = 0
- Deny = 1

### public enum Amazon.Auth.AccessControlPolicy.ConditionFactory.StringComparisonType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- StringEquals = 0
- StringEqualsIgnoreCase = 1
- StringLike = 2
- StringNotEquals = 3
- StringNotEqualsIgnoreCase = 4
- StringNotLike = 5

## Namespace: Amazon.Auth.AccessControlPolicy.ActionIdentifiers

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.AppStreamActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllAppStreamActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateApplication
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateSession
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteApplication
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetApiRoot
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetApplication
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetApplicationError
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetApplicationErrors
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetApplications
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetApplicationStatus
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetSession
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetSessions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetSessionStatus
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateApplication
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateApplicationState
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateSessionState

#### Constructors
- private static AppStreamActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.AutoScalingActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllAutoScalingActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateAutoScalingGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateLaunchConfiguration
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateOrUpdateScalingTrigger
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateOrUpdateTags
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteAutoScalingGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteLaunchConfiguration
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteNotificationConfiguration
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeletePolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteScheduledAction
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteTags
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteTrigger
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeAdjustmentTypes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeAutoScalingGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeAutoScalingInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeAutoScalingNotificationTypes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeLaunchConfigurations
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeMetricCollectionTypes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeNotificationConfigurations
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribePolicies
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeScalingActivities
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeScalingProcessTypes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeScheduledActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeTags
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeTriggers
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DisableMetricsCollection
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier EnableMetricsCollection
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ExecutePolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutNotificationConfiguration
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutScalingPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutScheduledUpdateGroupAction
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ResumeProcesses
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetDesiredCapacity
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetInstanceHealth
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SuspendProcesses
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier TerminateInstanceInAutoScalingGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateAutoScalingGroup

#### Constructors
- private static AutoScalingActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.BillingActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllBillingActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyAccount
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyBilling
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyPaymentMethods
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ViewAccount
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ViewBilling
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ViewPaymentMethods
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ViewUsage

#### Constructors
- private static BillingActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.CloudFormationActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllCloudFormationActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateStack
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteStack
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeStackEvents
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeStackResource
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeStackResources
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeStacks
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier EstimateTemplateCost
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetTemplate
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListStackResources
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListStacks
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateStack
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ValidateTemplate

#### Constructors
- private static CloudFormationActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.CloudFrontActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllCloudFrontActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateCloudFrontOriginAccessIdentity
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateDistribution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateInvalidation
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateStreamingDistribution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteCloudFrontOriginAccessIdentity
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteDistribution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteStreamingDistribution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetCloudFrontOriginAccessIdentity
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetCloudFrontOriginAccessIdentityConfig
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetDistribution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetDistributionConfig
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetInvalidation
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetStreamingDistribution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetStreamingDistributionConfig
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListCloudFrontOriginAccessIdentities
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListDistributions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListInvalidations
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListStreamingDistributions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateCloudFrontOriginAccessIdentity
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateDistribution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateStreamingDistribution

#### Constructors
- private static CloudFrontActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.CloudSearchActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllCloudSearchActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier BuildSuggesters
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateDomain
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DefineAnalysisScheme
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DefineExpression
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DefineIndexField
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DefineSuggester
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteAnalysisScheme
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteDomain
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteExpression
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteIndexField
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteSuggester
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeAnalysisSchemes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeAvailabilityOptions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeDomains
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeExpressions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeIndexFields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeScalingParameters
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeServiceAccessPolicies
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeSuggesters
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier IndexDocuments
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListDomainNames
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateAvailabilityOptions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateScalingParameters
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateServiceAccessPolicies

#### Constructors
- private static CloudSearchActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.CloudTrailActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllCloudTrailActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateTrail
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteTrail
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeTrails
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetTrailStatus
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier StartLogging
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier StopLogging
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateTrail

#### Constructors
- private static CloudTrailActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.CloudWatchActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllCloudWatchActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteAlarms
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeAlarmHistory
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeAlarms
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeAlarmsForMetric
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DisableAlarmActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier EnableAlarmActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetMetricStatistics
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListMetrics
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutMetricAlarm
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutMetricData
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetAlarmState

#### Constructors
- private static CloudWatchActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.CloudWatchLogsActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllCloudWatchLogsActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateLogGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateLogStream
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteLogGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteLogStream
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteMetricFilter
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteRetentionPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeLogGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeLogStreams
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeMetricFilters
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetLogEvents
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutLogEvents
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutMetricFilter
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutRetentionPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier TestMetricFilter

#### Constructors
- private static CloudWatchLogsActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.CognitoIdentityActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllCognitoIdentityActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateIdentityPool
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteIdentityPool
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeIdentityPool
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListIdentities
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListIdentityPools
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateIdentityPool

#### Constructors
- private static CognitoIdentityActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.CognitoSyncActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllCognitoSyncActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteDataset
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeDataset
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeIdentityPoolUsage
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeIdentityUsage
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListDatasets
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListIdentityPoolUsage
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListRecords
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateRecords

#### Constructors
- private static CognitoSyncActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.DirectConnectActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllDirectConnectActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateConnection
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreatePrivateVirtualInterface
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreatePublicVirtualInterface
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteConnection
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteVirtualInterface
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeConnectionDetail
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeConnections
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeOfferingDetail
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeOfferings
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeVirtualGateways
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeVirtualInterfaces

#### Constructors
- private static DirectConnectActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.DynamoDBActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllDynamoDBActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier BatchGetItem
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier BatchWriteItem
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateTable
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteItem
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteTable
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeTable
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetItem
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListTables
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutItem
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier Query
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier Scan
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateItem
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateTable

#### Constructors
- private static DynamoDBActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.EC2ActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AcceptVpcPeeringConnection
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ActivateLicense
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllEC2Actions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllocateAddress
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AssignPrivateIpAddresses
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AssociateAddress
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AssociateDhcpOptions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AssociateRouteTable
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AttachInternetGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AttachNetworkInterface
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AttachVolume
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AttachVpnGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AuthorizeSecurityGroupEgress
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AuthorizeSecurityGroupIngress
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier BundleInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CancelBundleTask
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CancelConversionTask
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CancelExportTask
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CancelReservedInstancesListing
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CancelSpotInstanceRequests
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ConfirmProductInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CopyImage
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CopySnapshot
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateCustomerGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateDhcpOptions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateImage
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateInstanceExportTask
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateInternetGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateKeyPair
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateNetworkAcl
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateNetworkAclEntry
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateNetworkInterface
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreatePlacementGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateReservedInstancesListing
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateRoute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateRouteTable
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateSecurityGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateSnapshot
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateSpotDatafeedSubscription
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateSubnet
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateTags
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateVolume
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateVpc
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateVpcPeeringConnection
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateVpnConnection
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateVpnConnectionRoute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateVpnGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeactivateLicense
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteCustomerGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteDhcpOptions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteInternetGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteKeyPair
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteNetworkAcl
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteNetworkAclEntry
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteNetworkInterface
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeletePlacementGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteRoute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteRouteTable
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteSecurityGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteSnapshot
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteSpotDatafeedSubscription
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteSubnet
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteTags
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteVolume
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteVpc
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteVpcPeeringConnection
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteVpnConnection
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteVpnConnectionRoute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteVpnGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeregisterImage
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeAccountAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeAddresses
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeAvailabilityZones
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeBundleTasks
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeConversionTasks
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeCustomerGateways
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeDhcpOptions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeExportTasks
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeImageAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeImages
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeInstanceAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeInstanceStatus
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeInternetGateways
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeKeyPairs
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeLicenses
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeNetworkAcls
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeNetworkInterfaceAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeNetworkInterfaces
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribePlacementGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeRegions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeReservedInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeReservedInstancesListings
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeReservedInstancesModifications
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeReservedInstancesOfferings
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeRouteTables
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeSecurityGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeSnapshotAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeSnapshots
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeSpotDatafeedSubscription
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeSpotInstanceRequests
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeSpotPriceHistory
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeSubnets
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeTags
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeVolumeAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeVolumes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeVolumeStatus
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeVpcAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeVpcPeeringConnection
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeVpcs
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeVpnConnections
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeVpnGateways
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DetachInternetGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DetachNetworkInterface
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DetachVolume
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DetachVpnGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DisableVgwRoutePropagation
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DisassociateAddress
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DisassociateRouteTable
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier EnableVgwRoutePropagation
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier EnableVolumeIO
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetConsoleOutput
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetPasswordData
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ImportInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ImportKeyPair
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ImportVolume
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyImageAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyInstanceAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyNetworkInterfaceAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyReservedInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifySnapshotAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyVolumeAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyVpcAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier MonitorInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PurchaseReservedInstancesOffering
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RebootInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RegisterImage
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RejectVpcPeeringConnection
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ReleaseAddress
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ReplaceNetworkAclAssociation
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ReplaceNetworkAclEntry
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ReplaceRoute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ReplaceRouteTableAssociation
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ReportInstanceStatus
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RequestSpotInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ResetImageAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ResetInstanceAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ResetNetworkInterfaceAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ResetSnapshotAttribute
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RevokeSecurityGroupEgress
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RevokeSecurityGroupIngress
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RunInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier StartInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier StopInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier TerminateInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UnassignPrivateIpAddresses
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UnmonitorInstances

#### Constructors
- private static EC2ActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.ElastiCacheActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllElastiCacheActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AuthorizeCacheSecurityGroupIngress
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateCacheCluster
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateCacheParameterGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateCacheSecurityGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteCacheCluster
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteCacheParameterGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteCacheSecurityGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeCacheClusters
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeCacheParameterGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeCacheParameters
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeCacheSecurityGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeEngineDefaultParameters
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeEvents
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyCacheCluster
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyCacheParameterGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RebootCacheCluster
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ResetCacheParameterGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RevokeCacheSecurityGroupIngress

#### Constructors
- private static ElastiCacheActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.ElasticBeanstalkActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllElasticBeanstalkActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CheckDNSAvailability
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateApplication
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateApplicationVersion
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateConfigurationTemplate
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateEnvironment
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateStorageLocation
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteApplication
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteApplicationVersion
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteConfigurationTemplate
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteEnvironmentConfiguration
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeApplications
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeApplicationVersions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeConfigurationOptions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeConfigurationSettings
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeEnvironmentResources
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeEnvironments
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeEvents
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListAvailableSolutionStacks
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RebuildEnvironment
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RequestEnvironmentInfo
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RestartAppServer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RetrieveEnvironmentInfo
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SwapEnvironmentCNAMEs
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier TerminateEnvironment
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateApplication
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateApplicationVersion
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateConfigurationTemplate
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateEnvironment
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ValidateConfigurationSettings

#### Constructors
- private static ElasticBeanstalkActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.ElasticLoadBalancingActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllElasticLoadBalancingActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ApplySecurityGroupsToLoadBalancer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AttachLoadBalancerToSubnets
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ConfigureHealthCheck
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateAppCookieStickinessPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateLBCookieStickinessPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateLoadBalancer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateLoadBalancerListeners
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateLoadBalancerPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteLoadBalancer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteLoadBalancerListeners
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteLoadBalancerPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeregisterInstancesFromLoadBalancer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeInstanceHealth
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeLoadBalancerAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeLoadBalancerPolicies
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeLoadBalancerPolicyTypes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeLoadBalancers
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DetachLoadBalancerFromSubnets
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DisableAvailabilityZonesForLoadBalancer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier EnableAvailabilityZonesForLoadBalancer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyLoadBalancerAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RegisterInstancesWithLoadBalancer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetLoadBalancerListenerSSLCertificate
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetLoadBalancerPoliciesForBackendServer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetLoadBalancerPoliciesOfListener

#### Constructors
- private static ElasticLoadBalancingActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.ElasticMapReduceActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AddInstanceGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AddJobFlowSteps
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AddTags
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllElasticMapReduceActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeCluster
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeJobFlows
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeStep
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListBootstrapActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListClusters
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListInstanceGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListSteps
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyInstanceGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RemoveTags
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RunJobFlow
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetTerminationProtection
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier TerminateJobFlows

#### Constructors
- private static ElasticMapReduceActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.ElasticTranscoderActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllElasticTranscoderActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CancelJob
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateJob
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreatePipeline
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreatePreset
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeletePipeline
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeletePreset
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListJobsByPipeline
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListJobsByStatus
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListPipelines
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListPresets
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ReadJob
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ReadPipeline
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ReadPreset
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier TestRole
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdatePipeline
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdatePipelineNotifications
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdatePipelineStatus

#### Constructors
- private static ElasticTranscoderActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.GlacierActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AbortMultipartUpload
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllGlacierActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CompleteMultipartUpload
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateVault
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteArchive
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteVault
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteVaultNotifications
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeJob
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeVault
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetJobOutput
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetVaultNotifications
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier InitiateJob
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier InitiateMultipartUpload
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListJobs
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListMultipartUploads
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListParts
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListVaults
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetVaultNotifications
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UploadArchive
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UploadMultipartPart

#### Constructors
- private static GlacierActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.IdentityandAccessManagementActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AddRoleToInstanceProfile
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AddUserToGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllIdentityandAccessManagementActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ChangePassword
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateAccessKey
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateAccountAlias
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateInstanceProfile
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateLoginProfile
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateRole
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateSAMLProvider
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateUser
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateVirtualMFADevice
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeactivateMFADevice
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteAccessKey
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteAccountAlias
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteAccountPasswordPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteGroupPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteInstanceProfile
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteLoginProfile
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteRole
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteRolePolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteSAMLProvider
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteServerCertificate
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteSigningCertificate
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteUser
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteUserPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteVirtualMFADevice
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier EnableMFADevice
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GenerateCredentialReport
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetAccountPasswordPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetAccountSummary
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetCredentialReport
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetGroupPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetInstanceProfile
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetLoginProfile
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetRole
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetRolePolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetSAMLProvider
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetServerCertificate
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetUser
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetUserPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListAccessKeys
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListAccountAliases
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListGroupPolicies
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListGroupsForUser
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListInstanceProfiles
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListInstanceProfilesForRole
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListMFADevices
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListRolePolicies
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListRoles
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListSAMLProviders
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListServerCertificates
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListSigningCertificates
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListUserPolicies
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListUsers
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListVirtualMFADevices
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PassRole
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutGroupPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutRolePolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutUserPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RemoveRoleFromInstanceProfile
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RemoveUserFromGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ResyncMFADevice
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateAccessKey
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateAccountPasswordPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateAssumeRolePolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateLoginProfile
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateSAMLProvider
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateServerCertificate
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateSigningCertificate
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateUser
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UploadServerCertificate
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UploadSigningCertificate

#### Constructors
- private static IdentityandAccessManagementActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.ImportExportActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllImportExportActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CancelJob
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateJob
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetStatus
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListJobs
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateJob

#### Constructors
- private static ImportExportActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.KinesisActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllKinesisActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateStream
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteStream
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeStream
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetRecords
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetShardIterator
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListStreams
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier MergeShards
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutRecord
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SplitShard

#### Constructors
- private static KinesisActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.MarketplaceActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllMarketplaceActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier Subscribe
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier Unsubscribe
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ViewSubscriptions

#### Constructors
- private static MarketplaceActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.MarketplaceManagementPortalActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllMarketplaceManagementPortalActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier uploadFiles
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier viewMarketing
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier viewReports
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier viewSupport

#### Constructors
- private static MarketplaceManagementPortalActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.MobileAnalyticsActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllMobileAnalyticsActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetFinancialReports
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetReports
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutEvents

#### Constructors
- private static MobileAnalyticsActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.OpsWorksActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllOpsWorksActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AssignVolume
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AssociateElasticIp
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AttachElasticLoadBalancer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CloneStack
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateApp
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateDeployment
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateLayer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateStack
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateUserProfile
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteApp
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteLayer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteStack
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteUserProfile
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeregisterElasticIp
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeregisterVolume
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeApps
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeCommands
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeDeployments
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeElasticIps
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeElasticLoadBalancers
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeLayers
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeLoadBasedAutoScaling
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribePermissions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeRaidArrays
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeServiceErrors
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeStacks
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeTimeBasedAutoScaling
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeUserProfiles
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeVolumes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DetachElasticLoadBalancer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DisassociateElasticIp
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetHostnameSuggestion
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RebootInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RegisterElasticIp
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RegisterVolume
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetLoadBasedAutoScaling
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetPermission
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetTimeBasedAutoScaling
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier StartInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier StartStack
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier StopInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier StopStack
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UnassignVolume
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateApp
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateElasticIp
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateLayer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateStack
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateUserProfile
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateVolume

#### Constructors
- private static OpsWorksActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.RDSActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AddSourceIdentifierToSubscription
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AddTagsToResource
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllRDSActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AuthorizeDBSecurityGroupIngress
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CopyDBSnapshot
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateDBInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateDBInstanceReadReplica
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateDBParameterGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateDBSecurityGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateDBSnapshot
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateDBSubnetGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateEventSubscription
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateOptionGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteDBInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteDBParameterGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteDBSecurityGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteDBSnapshot
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteDBSubnetGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteEventSubscription
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteOptionGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeDBEngineVersions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeDBInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeDBLogFiles
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeDBParameterGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeDBParameters
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeDBSecurityGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeDBSnapshots
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeDBSubnetGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeEngineDefaultParameters
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeEventCategories
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeEvents
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeEventSubscriptions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeOptionGroupOptions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeOptionGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeOrderableDBInstanceOptions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeReservedDBInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeReservedDBInstancesOfferings
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DownloadDBLogFilePortion
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListTagsForResource
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyDBInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyDBParameterGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyDBSubnetGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyEventSubscription
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyOptionGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PromoteReadReplica
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PurchaseReservedDBInstancesOffering
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RebootDBInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RemoveSourceIdentifierFromSubscription
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RemoveTagsFromResource
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ResetDBParameterGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RestoreDBInstanceFromDBSnapshot
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RestoreDBInstanceToPointInTime
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RevokeDBSecurityGroupIngress

#### Constructors
- private static RDSActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.RedshiftActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllRedshiftActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AuthorizeClusterSecurityGroupIngress
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AuthorizeSnapshotAccess
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CopyClusterSnapshot
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateCluster
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateClusterParameterGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateClusterSecurityGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateClusterSnapshot
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateClusterSubnetGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateEventSubscription
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateHsmClientCertificate
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateHsmConfiguration
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteCluster
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteClusterParameterGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteClusterSecurityGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteClusterSnapshot
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteClusterSubnetGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteEventSubscription
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteHsmClientCertificate
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteHsmConfiguration
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeClusterParameterGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeClusterParameters
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeClusters
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeClusterSecurityGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeClusterSnapshots
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeClusterSubnetGroups
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeClusterVersions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeDefaultClusterParameters
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeEventCategories
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeEvents
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeEventSubscriptions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeHsmClientCertificates
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeHsmConfigurations
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeLoggingStatus
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeOrderableClusterOptions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeReservedNodeOfferings
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeReservedNodes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeResize
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DisableLogging
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DisableSnapshotCopy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier EnableLogging
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier EnableSnapshotCopy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyCluster
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyClusterParameterGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyClusterSubnetGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifyEventSubscription
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ModifySnapshotCopyRetentionPeriod
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PurchaseReservedNodeOffering
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RebootCluster
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ResetClusterParameterGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RestoreFromClusterSnapshot
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RevokeClusterSecurityGroupIngress
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RevokeSnapshotAccess
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RotateEncryptionKey
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ViewQueriesInConsole

#### Constructors
- private static RedshiftActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.Route53ActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllRoute53Actions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ChangeResourceRecordSets
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateHostedZone
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteHostedZone
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetChange
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetHostedZone
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListHostedZones
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListResourceRecordSets

#### Constructors
- private static Route53ActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.S3ActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AbortMultipartUpload
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllS3Actions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateBucket
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteBucket
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteBucketPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteBucketWebsite
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteObject
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteObjectVersion
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetBucketAcl
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetBucketCORS
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetBucketLocation
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetBucketLogging
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetBucketNotification
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetBucketPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetBucketRequestPayment
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetBucketTagging
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetBucketVersioning
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetBucketWebsite
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetLifecycleConfiguration
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetObject
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetObjectAcl
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetObjectTorrent
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetObjectVersion
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetObjectVersionAcl
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetObjectVersionTorrent
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListAllMyBuckets
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListBucket
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListBucketMultipartUploads
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListBucketVersions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListMultipartUploadParts
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutBucketAcl
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutBucketCORS
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutBucketLogging
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutBucketNotification
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutBucketPolicy
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutBucketRequestPayment
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutBucketTagging
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutBucketVersioning
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutBucketWebsite
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutLifecycleConfiguration
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutObject
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutObjectAcl
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutObjectVersionAcl
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RestoreObject

#### Constructors
- private static S3ActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.SecurityTokenServiceActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllSecurityTokenServiceActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AssumeRole
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetFederationToken

#### Constructors
- private static SecurityTokenServiceActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.SESActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllSESActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteIdentity
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteVerifiedEmailAddress
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetIdentityDkimAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetIdentityNotificationAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetIdentityVerificationAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetSendQuota
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetSendStatistics
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListIdentities
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListVerifiedEmailAddresses
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SendEmail
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SendRawEmail
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetIdentityDkimEnabled
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetIdentityFeedbackForwardingEnabled
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetIdentityNotificationTopic
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier VerifyDomainDkim
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier VerifyDomainIdentity
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier VerifyEmailAddress
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier VerifyEmailIdentity

#### Constructors
- private static SESActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.SimpleDBActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllSimpleDBActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier BatchDeleteAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier BatchPutAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateDomain
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteDomain
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DomainMetadata
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListDomains
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PutAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier Select

#### Constructors
- private static SimpleDBActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.SimpleWorkflowServiceActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllSimpleWorkflowServiceActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CancelTimer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CancelWorkflowExecution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CompleteWorkflowExecution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ContinueAsNewWorkflowExecution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CountClosedWorkflowExecutions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CountOpenWorkflowExecutions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CountPendingActivityTasks
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CountPendingDecisionTasks
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeprecateActivityType
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeprecateDomain
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeprecateWorkflowType
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeActivityType
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeDomain
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeWorkflowExecution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeWorkflowType
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier FailWorkflowExecution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetWorkflowExecutionHistory
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListActivityTypes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListClosedWorkflowExecutions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListDomains
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListOpenWorkflowExecutions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListWorkflowTypes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PollForActivityTask
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PollForDecisionTask
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RecordActivityTaskHeartbeat
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RecordMarker
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RegisterActivityType
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RegisterDomain
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RegisterWorkflowType
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RequestCancelActivityTask
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RequestCancelExternalWorkflowExecution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RequestCancelWorkflowExecution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RespondActivityTaskCanceled
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RespondActivityTaskCompleted
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RespondActivityTaskFailed
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RespondDecisionTaskCompleted
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ScheduleActivityTask
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SignalExternalWorkflowExecution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SignalWorkflowExecution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier StartChildWorkflowExecution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier StartTimer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier StartWorkflowExecution
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier TerminateWorkflowExecution

#### Constructors
- private static SimpleWorkflowServiceActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.SNSActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AddPermission
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllSNSActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ConfirmSubscription
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreatePlatformApplication
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreatePlatformEndpoint
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateTopic
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteEndpoint
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeletePlatformApplication
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteTopic
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetEndpointAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetPlatformApplicationAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetSubscriptionAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetTopicAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListEndpointsByPlatformApplication
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListPlatformApplications
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListSubscriptions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListSubscriptionsByTopic
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListTopics
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier Publish
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RemovePermission
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetEndpointAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetPlatformApplicationAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetSubscriptionAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetTopicAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier Subscribe
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier Unsubscribe

#### Constructors
- private static SNSActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.SQSActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AddPermission
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllSQSActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ChangeMessageVisibility
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateQueue
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteMessage
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteQueue
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetQueueAttributes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetQueueUrl
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListQueues
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ReceiveMessage
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RemovePermission
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SendMessage
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier SetQueueAttributes

#### Constructors
- private static SQSActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.StorageGatewayActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ActivateGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AddCache
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AddUploadBuffer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AddWorkingStorage
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllStorageGatewayActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CancelArchival
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CancelRetrieval
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateCachediSCSIVolume
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateSnapshot
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateSnapshotFromVolumeRecoveryPoint
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateStorediSCSIVolume
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateTapes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteBandwidthRateLimit
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteChapCredentials
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteSnapshotSchedule
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteTape
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteTapeArchive
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteVolume
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeBandwidthRateLimit
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeCache
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeCachediSCSIVolumes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeChapCredentials
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeGatewayInformation
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeMaintenanceStartTime
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeSnapshotSchedule
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeStorediSCSIVolumes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeTapeArchives
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeTapeRecoveryPoints
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeTapes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeUploadBuffer
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeVTLDevices
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeWorkingStorage
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DisableGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListGateways
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListLocalDisks
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListVolumeRecoveryPoints
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ListVolumes
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RetrieveTapeArchive
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RetrieveTapeRecoveryPoint
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ShutdownGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier StartGateway
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateBandwidthRateLimit
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateChapCredentials
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateGatewayInformation
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateGatewaySoftwareNow
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateMaintenanceStartTime
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateSnapshotSchedule

#### Constructors
- private static StorageGatewayActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.WhispersyncActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllWhispersyncActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier GetDatamapUpdates
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier PatchDatamapUpdates

#### Constructors
- private static WhispersyncActionIdentifiers()

### public static class Amazon.Auth.AccessControlPolicy.ActionIdentifiers.ZocaloActionIdentifiers

#### Fields
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier ActivateUser
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AddUserToGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier AllZocaloActions
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CheckAlias
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier CreateInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeactivateUser
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeleteInstance
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DeregisterDirectory
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeAvailableDirectories
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier DescribeInstances
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RegisterDirectory
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier RemoveUserFromGroup
- public static readonly Amazon.Auth.AccessControlPolicy.ActionIdentifier UpdateInstanceAlias

#### Constructors
- private static ZocaloActionIdentifiers()

## Namespace: Amazon.Auth.AccessControlPolicy.Internal

### internal static class Amazon.Auth.AccessControlPolicy.Internal.JsonDocumentFields

#### Fields
- internal static const string ACTION
- internal static const string CONDITION
- internal static const string EFFECT_VALUE_ALLOW
- internal static const string POLICY_ID
- internal static const string PRINCIPAL
- internal static const string RESOURCE
- internal static const string STATEMENT
- internal static const string STATEMENT_EFFECT
- internal static const string STATEMENT_ID
- internal static const string VERSION

### internal static class Amazon.Auth.AccessControlPolicy.Internal.JsonPolicyReader

#### Methods
- private static void convertActions(Amazon.Auth.AccessControlPolicy.Statement statement, ThirdParty.Json.LitJson.JsonData jStatement)
- private static void convertCondition(Amazon.Auth.AccessControlPolicy.Statement statement, ThirdParty.Json.LitJson.JsonData jStatement)
- private static void convertConditionRecord(Amazon.Auth.AccessControlPolicy.Statement statement, ThirdParty.Json.LitJson.JsonData jCondition)
- private static void convertPrincipalRecord(Amazon.Auth.AccessControlPolicy.Statement statement, ThirdParty.Json.LitJson.JsonData jPrincipal)
- private static void convertPrincipals(Amazon.Auth.AccessControlPolicy.Statement statement, ThirdParty.Json.LitJson.JsonData jStatement)
- private static void convertResources(Amazon.Auth.AccessControlPolicy.Statement statement, ThirdParty.Json.LitJson.JsonData jStatement)
- private static Amazon.Auth.AccessControlPolicy.Statement convertStatement(ThirdParty.Json.LitJson.JsonData jStatement)
- public static Amazon.Auth.AccessControlPolicy.Policy ReadJsonStringToPolicy(string jsonString)

### internal static class Amazon.Auth.AccessControlPolicy.Internal.JsonPolicyWriter

#### Methods
- private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>> sortConditionsByTypeAndKey(System.Collections.Generic.IList<Amazon.Auth.AccessControlPolicy.Condition> conditions)
- private static void writeActions(Amazon.Auth.AccessControlPolicy.Statement statement, ThirdParty.Json.LitJson.JsonWriter generator)
- private static void writeConditions(Amazon.Auth.AccessControlPolicy.Statement statement, ThirdParty.Json.LitJson.JsonWriter generator)
- private static void writePolicy(Amazon.Auth.AccessControlPolicy.Policy policy, ThirdParty.Json.LitJson.JsonWriter generator)
- public static string WritePolicyToString(bool prettyPrint, Amazon.Auth.AccessControlPolicy.Policy policy)
- private static void writePrincipals(Amazon.Auth.AccessControlPolicy.Statement statement, ThirdParty.Json.LitJson.JsonWriter generator)
- private static void writePropertyValue(ThirdParty.Json.LitJson.JsonWriter generator, string propertyName, string value)
- private static void writeResources(Amazon.Auth.AccessControlPolicy.Statement statement, ThirdParty.Json.LitJson.JsonWriter generator)

## Namespace: Amazon.Internal

### public interface Amazon.Internal.IRegionEndpoint

#### Properties
- public string DisplayName { get; }
- public string RegionName { get; }

#### Methods
- public Amazon.RegionEndpoint.Endpoint GetEndpointForService(string serviceName, bool dualStack)

### public interface Amazon.Internal.IRegionEndpointProvider

#### Properties
- public System.Collections.Generic.IEnumerable<Amazon.Internal.IRegionEndpoint> AllRegionEndpoints { get; }

#### Methods
- public Amazon.Internal.IRegionEndpoint GetRegionEndpoint(string regionName)

### public class Amazon.Internal.RegionEndpointProviderV2.RegionEndpoint
- Interfaces: Amazon.Internal.IRegionEndpoint

#### Fields
- private string <DisplayName>k__BackingField
- private string <SystemName>k__BackingField
- private static const string DEFAULT_RULE
- private static System.Collections.Generic.Dictionary<string, Amazon.Internal.RegionEndpointProviderV2.RegionEndpoint> hashBySystemName
- private static bool loaded
- private static readonly object LOCK_OBJECT
- private static const int MAX_DOWNLOAD_RETRIES
- private static const string REGIONS_CUSTOMIZATIONS_FILE
- private static const string REGIONS_FILE
- private static System.Collections.Generic.Dictionary<string, ThirdParty.Json.LitJson.JsonData> _documentEndpoints

#### Properties
- public string DisplayName { get; private set; }
- public static System.Collections.Generic.IEnumerable<Amazon.Internal.RegionEndpointProviderV2.RegionEndpoint> EnumerableAllRegions { get; }
- public string RegionName { get; }
- public string SystemName { get; private set; }

#### Constructors
- private static RegionEndpointProviderV2.RegionEndpoint()
- private RegionEndpointProviderV2.RegionEndpoint(string systemName, string displayName)

#### Methods
- public static Amazon.Internal.RegionEndpointProviderV2.RegionEndpoint GetBySystemName(string systemName)
- private static Amazon.Internal.RegionEndpointProviderV2.RegionEndpoint GetEndpoint(string systemName, string displayName)
- public Amazon.RegionEndpoint.Endpoint GetEndpointForService(string serviceName, bool dualStack)
- private ThirdParty.Json.LitJson.JsonData GetEndpointRule(string serviceName)
- private static void LoadEndpointDefinitionFromFilePath(string path)
- private static void LoadEndpointDefinitionFromWeb(string url)
- private static void LoadEndpointDefinitions()
- public static void LoadEndpointDefinitions(string endpointsPath)
- private static void LoadEndpointDefinitionsFromEmbeddedResource()
- private static void ReadEndpointFile(System.IO.Stream stream)
- public override string ToString()
- private static bool TryLoadEndpointDefinitionsFromAssemblyDir()
- public static void UnloadEndpointDefinitions()

### public class Amazon.Internal.RegionEndpointProviderV2
- Interfaces: Amazon.Internal.IRegionEndpointProvider

#### Fields
- private static System.Net.IWebProxy <Proxy>k__BackingField

#### Properties
- public System.Collections.Generic.IEnumerable<Amazon.Internal.IRegionEndpoint> AllRegionEndpoints { get; }
- public static System.Net.IWebProxy Proxy { get; set; }

#### Constructors
- public RegionEndpointProviderV2()

#### Methods
- public Amazon.Internal.IRegionEndpoint GetRegionEndpoint(string regionName)

### public class Amazon.Internal.RegionEndpointProviderV3
- Interfaces: Amazon.Internal.IRegionEndpointProvider

#### Fields
- private static const string ENDPOINT_JSON
- private static const string ENDPOINT_JSON_RESOURCE
- private System.Collections.Generic.IEnumerable<Amazon.Internal.IRegionEndpoint> _allRegionEndpoints
- private object _allRegionEndpointsLock
- private static ThirdParty.Json.LitJson.JsonData _emptyDictionaryJsonData
- private System.Collections.Generic.Dictionary<string, Amazon.Internal.IRegionEndpoint> _regionEndpointMap
- private object _regionEndpointMapLock
- private ThirdParty.Json.LitJson.JsonData _root

#### Properties
- public System.Collections.Generic.IEnumerable<Amazon.Internal.IRegionEndpoint> AllRegionEndpoints { get; }

#### Constructors
- public RegionEndpointProviderV3()
- private static RegionEndpointProviderV3()
- public RegionEndpointProviderV3(ThirdParty.Json.LitJson.JsonData root)

#### Methods
- private static System.IO.Stream GetEndpointJsonSourceStream()
- private Amazon.Internal.IRegionEndpoint GetNonstandardRegionEndpoint(string regionName)
- public Amazon.Internal.IRegionEndpoint GetRegionEndpoint(string regionName)
- private static string GetUnknownRegionDescription(string regionName)
- private static bool IsRegionInPartition(string regionName, ThirdParty.Json.LitJson.JsonData partition, out string description)

### public class Amazon.Internal.RegionEndpointV3
- Interfaces: Amazon.Internal.IRegionEndpoint

#### Fields
- private string <DisplayName>k__BackingField
- private string <RegionName>k__BackingField
- private ThirdParty.Json.LitJson.JsonData _partitionJsonData
- private Amazon.Internal.RegionEndpointV3.ServiceMap _serviceMap
- private ThirdParty.Json.LitJson.JsonData _servicesJsonData
- private bool _servicesLoaded

#### Properties
- public string DisplayName { get; private set; }
- public string PartitionName { get; }
- public string RegionName { get; private set; }

#### Constructors
- public RegionEndpointV3(string regionName, string displayName, ThirdParty.Json.LitJson.JsonData partition, ThirdParty.Json.LitJson.JsonData services)

#### Methods
- private void AddServiceToMap(ThirdParty.Json.LitJson.JsonData service, string serviceName)
- private void CreateEndpointAndAddToServiceMap(ThirdParty.Json.LitJson.JsonData result, string regionName, string serviceName)
- private void CreateEndpointAndAddToServiceMap(ThirdParty.Json.LitJson.JsonData result, string regionName, string serviceName, bool dualStack)
- private Amazon.RegionEndpoint.Endpoint CreateUnknownEndpoint(string serviceName, bool dualStack)
- private static string DetermineAuthRegion(ThirdParty.Json.LitJson.JsonData credentialScope)
- private static string DetermineSignatureOverride(ThirdParty.Json.LitJson.JsonData defaults, string serviceName)
- public Amazon.RegionEndpoint.Endpoint GetEndpointForService(string serviceName, bool dualStack)
- private static void MergeJsonData(ThirdParty.Json.LitJson.JsonData target, ThirdParty.Json.LitJson.JsonData source)
- private void ParseAllServices()

### private class Amazon.Internal.RegionEndpointV3.ServiceMap

#### Fields
- private System.Collections.Generic.Dictionary<string, Amazon.RegionEndpoint.Endpoint> _dualServiceMap
- private System.Collections.Generic.Dictionary<string, Amazon.RegionEndpoint.Endpoint> _serviceMap

#### Constructors
- public RegionEndpointV3.ServiceMap()

#### Methods
- public void Add(string serviceName, bool dualStack, Amazon.RegionEndpoint.Endpoint endpoint)
- public bool ContainsKey(string servicName)
- private System.Collections.Generic.Dictionary<string, Amazon.RegionEndpoint.Endpoint> GetMap(bool dualStack)
- public bool TryGetEndpoint(string serviceName, bool dualStack, out Amazon.RegionEndpoint.Endpoint endpoint)

## Namespace: Amazon.MissingTypes

### public interface Amazon.MissingTypes.ICloneable

#### Methods
- public object Clone()

### public interface Amazon.MissingTypes.IOrderedDictionary
- Interfaces: System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable

#### Properties
- public object Item { get; set; }

#### Methods
- public System.Collections.IDictionaryEnumerator GetEnumerator()
- public void Insert(int index, object key, object value)
- public void RemoveAt(int index)

## Namespace: Amazon.Runtime

### private class Amazon.Runtime.AmazonServiceClient.<>c

#### Fields
- public static readonly Amazon.Runtime.AmazonServiceClient.<>c <>9
- public static System.Func<System.Collections.Generic.KeyValuePair<string, string>, bool> <>9__62_0

#### Constructors
- private static AmazonServiceClient.<>c()
- public AmazonServiceClient.<>c()

#### Methods
- internal bool <ComposeUrl>b__62_0(System.Collections.Generic.KeyValuePair<string, string> v)

### private class Amazon.Runtime.FallbackRegionFactory.<>c

#### Fields
- public static readonly Amazon.Runtime.FallbackRegionFactory.<>c <>9
- public static Amazon.Runtime.FallbackRegionFactory.RegionGenerator <>9__12_0
- public static Amazon.Runtime.FallbackRegionFactory.RegionGenerator <>9__12_1
- public static Amazon.Runtime.FallbackRegionFactory.RegionGenerator <>9__12_2
- public static Amazon.Runtime.FallbackRegionFactory.RegionGenerator <>9__12_3
- public static Amazon.Runtime.FallbackRegionFactory.RegionGenerator <>9__12_4
- public static Amazon.Runtime.FallbackRegionFactory.RegionGenerator <>9__12_5
- public static Amazon.Runtime.FallbackRegionFactory.RegionGenerator <>9__12_6

#### Constructors
- private static FallbackRegionFactory.<>c()
- public FallbackRegionFactory.<>c()

#### Methods
- internal Amazon.Runtime.AWSRegion <Reset>b__12_0()
- internal Amazon.Runtime.AWSRegion <Reset>b__12_1()
- internal Amazon.Runtime.AWSRegion <Reset>b__12_2()
- internal Amazon.Runtime.AWSRegion <Reset>b__12_3()
- internal Amazon.Runtime.AWSRegion <Reset>b__12_4()
- internal Amazon.Runtime.AWSRegion <Reset>b__12_5()
- internal Amazon.Runtime.AWSRegion <Reset>b__12_6()

### private class Amazon.Runtime.FallbackCredentialsFactory.<>c

#### Fields
- public static readonly Amazon.Runtime.FallbackCredentialsFactory.<>c <>9
- public static Amazon.Runtime.FallbackCredentialsFactory.CredentialsGenerator <>9__10_0
- public static Amazon.Runtime.FallbackCredentialsFactory.CredentialsGenerator <>9__10_1

#### Constructors
- private static FallbackCredentialsFactory.<>c()
- public FallbackCredentialsFactory.<>c()

#### Methods
- internal Amazon.Runtime.AWSCredentials <Reset>b__10_0()
- internal Amazon.Runtime.AWSCredentials <Reset>b__10_1()

### private class Amazon.Runtime.FallbackEndpointDiscoveryEnabledFactory.<>c

#### Fields
- public static readonly Amazon.Runtime.FallbackEndpointDiscoveryEnabledFactory.<>c <>9
- public static Amazon.Runtime.FallbackEndpointDiscoveryEnabledFactory.ConfigGenerator <>9__8_0
- public static Amazon.Runtime.FallbackEndpointDiscoveryEnabledFactory.ConfigGenerator <>9__8_1

#### Constructors
- private static FallbackEndpointDiscoveryEnabledFactory.<>c()
- public FallbackEndpointDiscoveryEnabledFactory.<>c()

#### Methods
- internal bool <Reset>b__8_0()
- internal bool <Reset>b__8_1()

### private class Amazon.Runtime.FallbackCredentialsFactory.<>c__DisplayClass10_0

#### Fields
- public System.Net.IWebProxy proxy

#### Constructors
- public FallbackCredentialsFactory.<>c__DisplayClass10_0()

#### Methods
- internal Amazon.Runtime.AWSCredentials <Reset>b__2()

### private struct Amazon.Runtime.ProcessAWSCredentials.<DetermineProcessCredentialAsync>d__7
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.ProcessAWSCredentials <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.Util.ProcessExecutionResult> <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Amazon.Runtime.InstanceProfileAWSCredentials.<GetAvailableRoles>d__14
- Interfaces: System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private string <>2__current
- public System.Net.IWebProxy <>3__proxy
- private string[] <>7__wrap1
- private int <>7__wrap2
- private int <>l__initialThreadId
- private System.Net.IWebProxy proxy

#### Properties
- private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public InstanceProfileAWSCredentials.<GetAvailableRoles>d__14(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private struct Amazon.Runtime.RefreshingAWSCredentials.<GetCredentialsAsync>d__10
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.RefreshingAWSCredentials <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Amazon.Runtime.ImmutableCredentials> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState> <>u__2

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.HttpWebRequestMessage.<GetResponseAsync>d__20
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.HttpWebRequestMessage <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Amazon.Runtime.Internal.Transform.IWebResponseData> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<System.Net.Http.HttpResponseMessage> <>u__1
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.MonitoringListener.<PostMessagesOverUDPAsync>d__10
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.MonitoringListener <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<int> <>u__1
- public string response

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.RetryPolicy.<RetryAsync>d__27
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.RetryPolicy <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<bool> <>u__1
- private bool <canRetry>5__2
- private bool <isClockSkewError>5__3
- public System.Exception exception
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class Amazon.Runtime.AmazonClientException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public AmazonClientException(string message)
- public AmazonClientException(string message, System.Exception innerException)

### public class Amazon.Runtime.AmazonDateTimeUnmarshallingException
- Base: Amazon.Runtime.AmazonUnmarshallingException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private string <InvalidDateTimeToken>k__BackingField

#### Properties
- public string InvalidDateTimeToken { get; private set; }

#### Constructors
- public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, string invalidDateTimeToken, System.Exception innerException)
- public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, string invalidDateTimeToken, System.Exception innerException)
- public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, string invalidDateTimeToken, string message, System.Exception innerException)

### public class Amazon.Runtime.AmazonServiceClient
- Interfaces: System.IDisposable

#### Fields
- private Amazon.Runtime.IClientConfig <Config>k__BackingField
- private Amazon.Runtime.AWSCredentials <Credentials>k__BackingField
- private Amazon.Runtime.Internal.EndpointDiscoveryResolverBase <EndpointDiscoveryResolver>k__BackingField
- private Amazon.Runtime.Internal.RuntimePipeline <RuntimePipeline>k__BackingField
- private readonly Amazon.Runtime.Internal.IServiceMetadata <ServiceMetadata>k__BackingField
- private Amazon.Runtime.Internal.Auth.AbstractAWSSigner <Signer>k__BackingField
- private Amazon.Runtime.ResponseEventHandler mAfterResponseEvent
- private Amazon.Runtime.PreRequestEventHandler mBeforeMarshallingEvent
- private Amazon.Runtime.RequestEventHandler mBeforeRequestEvent
- private Amazon.Runtime.ExceptionEventHandler mExceptionEvent
- private bool _disposed
- private Amazon.Runtime.Internal.Util.Logger _logger

#### Properties
- public Amazon.Runtime.IClientConfig Config { get; private set; }
- protected internal Amazon.Runtime.AWSCredentials Credentials { get; private set; }
- protected Amazon.Runtime.Internal.EndpointDiscoveryResolverBase EndpointDiscoveryResolver { get; private set; }
- protected Amazon.Runtime.Internal.RuntimePipeline RuntimePipeline { get; set; }
- protected Amazon.Runtime.Internal.IServiceMetadata ServiceMetadata { get; }
- protected Amazon.Runtime.Internal.Auth.AbstractAWSSigner Signer { get; private set; }
- protected bool SupportResponseLogging { get; }

#### Events
- public event Amazon.Runtime.ResponseEventHandler AfterResponseEvent
- internal event Amazon.Runtime.PreRequestEventHandler BeforeMarshallingEvent
- public event Amazon.Runtime.RequestEventHandler BeforeRequestEvent
- public event Amazon.Runtime.ExceptionEventHandler ExceptionEvent

#### Constructors
- protected AmazonServiceClient(Amazon.Runtime.AWSCredentials credentials, Amazon.Runtime.ClientConfig config)
- protected AmazonServiceClient(string awsAccessKeyId, string awsSecretAccessKey, Amazon.Runtime.ClientConfig config)
- protected AmazonServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, Amazon.Runtime.ClientConfig config)

#### Methods
- private void BuildRuntimePipeline()
- internal C CloneConfig<C>()
- internal void CloneConfig(Amazon.Runtime.ClientConfig newConfig)
- public static System.Uri ComposeUrl(Amazon.Runtime.Internal.IRequest iRequest)
- protected abstract Amazon.Runtime.Internal.Auth.AbstractAWSSigner CreateSigner()
- protected virtual void CustomizeRuntimePipeline(Amazon.Runtime.Internal.RuntimePipeline pipeline)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- private static void DontUnescapePathDotsAndSlashes(System.Uri uri)
- protected virtual System.Collections.Generic.IEnumerable<Amazon.Runtime.Internal.DiscoveryEndpointBase> EndpointOperation(Amazon.Runtime.Internal.EndpointOperationContextBase context)
- protected virtual void Initialize()
- protected TResponse Invoke<TRequest, TResponse>(TRequest request, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest> marshaller, Amazon.Runtime.Internal.Transform.ResponseUnmarshaller unmarshaller)
- protected TResponse Invoke<TResponse>(Amazon.Runtime.AmazonWebServiceRequest request, Amazon.Runtime.Internal.InvokeOptionsBase options)
- protected System.Threading.Tasks.Task<TResponse> InvokeAsync<TRequest, TResponse>(TRequest request, Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest> marshaller, Amazon.Runtime.Internal.Transform.ResponseUnmarshaller unmarshaller, System.Threading.CancellationToken cancellationToken)
- protected System.Threading.Tasks.Task<TResponse> InvokeAsync<TResponse>(Amazon.Runtime.AmazonWebServiceRequest request, Amazon.Runtime.Internal.InvokeOptionsBase options, System.Threading.CancellationToken cancellationToken)
- protected virtual void ProcessExceptionHandlers(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)
- protected void ProcessPreRequestHandlers(Amazon.Runtime.IExecutionContext executionContext)
- protected void ProcessRequestHandlers(Amazon.Runtime.IExecutionContext executionContext)
- protected void ProcessResponseHandlers(Amazon.Runtime.IExecutionContext executionContext)
- private static void SetupCSMHandler(Amazon.Runtime.IRequestContext requestContext)
- private void ThrowIfDisposed()

### public class Amazon.Runtime.AmazonServiceException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private string errorCode
- private Amazon.Runtime.ErrorType errorType
- private string requestId
- private System.Net.HttpStatusCode statusCode

#### Properties
- public string ErrorCode { get; set; }
- public Amazon.Runtime.ErrorType ErrorType { get; set; }
- public string RequestId { get; set; }
- public System.Net.HttpStatusCode StatusCode { get; set; }

#### Constructors
- public AmazonServiceException()
- public AmazonServiceException(string message)
- public AmazonServiceException(System.Exception innerException)
- public AmazonServiceException(string message, System.Exception innerException)
- public AmazonServiceException(string message, System.Exception innerException, System.Net.HttpStatusCode statusCode)
- public AmazonServiceException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)
- public AmazonServiceException(string message, System.Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, System.Net.HttpStatusCode statusCode)

#### Methods
- private static string BuildGenericErrorMessage(string errorCode, System.Net.HttpStatusCode statusCode)

### public class Amazon.Runtime.AmazonUnmarshallingException
- Base: Amazon.Runtime.AmazonServiceException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private string <LastKnownLocation>k__BackingField
- private string <ResponseBody>k__BackingField

#### Properties
- public string LastKnownLocation { get; private set; }
- public string Message { get; }
- public string ResponseBody { get; private set; }

#### Constructors
- public AmazonUnmarshallingException(string requestId, string lastKnownLocation, System.Exception innerException)
- public AmazonUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, System.Exception innerException)
- public AmazonUnmarshallingException(string requestId, string lastKnownLocation, System.Exception innerException, System.Net.HttpStatusCode statusCode)
- public AmazonUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, string message, System.Exception innerException)
- public AmazonUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, System.Exception innerException, System.Net.HttpStatusCode statusCode)

#### Methods
- private static void AppendFormat(System.Text.StringBuilder sb, string format, string value)

### public class Amazon.Runtime.AmazonWebServiceRequest
- Interfaces: Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Fields
- private System.EventHandler<Amazon.Runtime.StreamTransferProgressArgs> <Amazon.Runtime.Internal.IAmazonWebServiceRequest.StreamUploadProgressCallback>k__BackingField
- private bool <Amazon.Runtime.Internal.IAmazonWebServiceRequest.UseSigV4>k__BackingField
- internal Amazon.Runtime.RequestEventHandler mBeforeRequestEvent
- private System.Collections.Generic.Dictionary<string, object> requestState

#### Properties
- private System.Collections.Generic.Dictionary<string, object> Amazon.Runtime.Internal.IAmazonWebServiceRequest.RequestState { get; }
- private System.EventHandler<Amazon.Runtime.StreamTransferProgressArgs> Amazon.Runtime.Internal.IAmazonWebServiceRequest.StreamUploadProgressCallback { get; set; }
- private bool Amazon.Runtime.Internal.IAmazonWebServiceRequest.UseSigV4 { get; set; }
- protected bool Expect100Continue { get; }
- protected bool IncludeSHA256Header { get; }

#### Events
- internal event Amazon.Runtime.RequestEventHandler BeforeRequestEvent

#### Constructors
- protected AmazonWebServiceRequest()

#### Methods
- private void Amazon.Runtime.Internal.IAmazonWebServiceRequest.AddBeforeRequestHandler(Amazon.Runtime.RequestEventHandler handler)
- private void Amazon.Runtime.Internal.IAmazonWebServiceRequest.RemoveBeforeRequestHandler(Amazon.Runtime.RequestEventHandler handler)
- protected virtual Amazon.Runtime.Internal.Auth.AbstractAWSSigner CreateSigner()
- internal void FireBeforeRequestEvent(object sender, Amazon.Runtime.RequestEventArgs args)
- internal bool GetExpect100Continue()
- internal bool GetIncludeSHA256Header()
- internal Amazon.Runtime.Internal.Auth.AbstractAWSSigner GetSigner()

### public class Amazon.Runtime.AmazonWebServiceResponse

#### Fields
- private long contentLength
- private System.Net.HttpStatusCode httpStatusCode
- private Amazon.Runtime.ResponseMetadata responseMetadataField

#### Properties
- public long ContentLength { get; set; }
- public System.Net.HttpStatusCode HttpStatusCode { get; set; }
- public Amazon.Runtime.ResponseMetadata ResponseMetadata { get; set; }

#### Constructors
- public AmazonWebServiceResponse()

### public class Amazon.Runtime.AnonymousAWSCredentials
- Base: Amazon.Runtime.AWSCredentials

#### Constructors
- public AnonymousAWSCredentials()

#### Methods
- public override Amazon.Runtime.ImmutableCredentials GetCredentials()

### public class Amazon.Runtime.AppConfigAWSRegion
- Base: Amazon.Runtime.AWSRegion

#### Constructors
- public AppConfigAWSRegion()

### public class Amazon.Runtime.AssumeRoleAWSCredentials
- Base: Amazon.Runtime.RefreshingAWSCredentials
- Interfaces: System.IDisposable

#### Fields
- private Amazon.Runtime.AssumeRoleAWSCredentialsOptions <Options>k__BackingField
- private string <RoleArn>k__BackingField
- private string <RoleSessionName>k__BackingField
- private Amazon.Runtime.AWSCredentials <SourceCredentials>k__BackingField
- private Amazon.RegionEndpoint DefaultSTSClientRegion
- private Amazon.Runtime.Internal.Util.Logger _logger

#### Properties
- public Amazon.Runtime.AssumeRoleAWSCredentialsOptions Options { get; private set; }
- public string RoleArn { get; private set; }
- public string RoleSessionName { get; private set; }
- public Amazon.Runtime.AWSCredentials SourceCredentials { get; private set; }

#### Constructors
- public AssumeRoleAWSCredentials(Amazon.Runtime.AWSCredentials sourceCredentials, string roleArn, string roleSessionName)
- public AssumeRoleAWSCredentials(Amazon.Runtime.AWSCredentials sourceCredentials, string roleArn, string roleSessionName, Amazon.Runtime.AssumeRoleAWSCredentialsOptions options)

#### Methods
- protected override Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState GenerateNewCredentials()

### public class Amazon.Runtime.AssumeRoleAWSCredentialsOptions

#### Fields
- private System.Nullable<int> <DurationSeconds>k__BackingField
- private string <ExternalId>k__BackingField
- private string <MfaSerialNumber>k__BackingField
- private System.Func<string> <MfaTokenCodeCallback>k__BackingField
- private string <Policy>k__BackingField
- private System.Net.IWebProxy <ProxySettings>k__BackingField

#### Properties
- public System.Nullable<int> DurationSeconds { get; set; }
- public string ExternalId { get; set; }
- public string MfaSerialNumber { get; set; }
- public string MfaTokenCode { get; }
- public System.Func<string> MfaTokenCodeCallback { get; set; }
- public string Policy { get; set; }
- public System.Net.IWebProxy ProxySettings { get; set; }

#### Constructors
- public AssumeRoleAWSCredentialsOptions()

### public class Amazon.Runtime.AssumeRoleImmutableCredentials
- Base: Amazon.Runtime.ImmutableCredentials

#### Fields
- private System.DateTime <Expiration>k__BackingField

#### Properties
- public System.DateTime Expiration { get; private set; }

#### Constructors
- public AssumeRoleImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token, System.DateTime expiration)

#### Methods
- public Amazon.Runtime.AssumeRoleImmutableCredentials Copy()
- public override bool Equals(object obj)
- public override int GetHashCode()

### public class Amazon.Runtime.AWSCredentials

#### Constructors
- protected AWSCredentials()

#### Methods
- public abstract Amazon.Runtime.ImmutableCredentials GetCredentials()
- public virtual System.Threading.Tasks.Task<Amazon.Runtime.ImmutableCredentials> GetCredentialsAsync()
- protected virtual void Validate()

### public class Amazon.Runtime.AWSRegion

#### Fields
- private Amazon.RegionEndpoint <Region>k__BackingField

#### Properties
- public Amazon.RegionEndpoint Region { get; protected set; }

#### Constructors
- protected AWSRegion()

#### Methods
- protected void SetRegionFromName(string regionSystemName)

### public class Amazon.Runtime.BasicAWSCredentials
- Base: Amazon.Runtime.AWSCredentials

#### Fields
- private Amazon.Runtime.ImmutableCredentials _credentials

#### Constructors
- public BasicAWSCredentials(string accessKey, string secretKey)

#### Methods
- public override bool Equals(object obj)
- public override Amazon.Runtime.ImmutableCredentials GetCredentials()
- public override int GetHashCode()

### public class Amazon.Runtime.ClientConfig
- Interfaces: Amazon.Runtime.IClientConfig

#### Fields
- private Amazon.Runtime.HttpClientFactory <HttpClientFactory>k__BackingField
- private System.Nullable<int> <MaxConnectionsPerServer>k__BackingField
- private bool allowAutoRedirect
- private string authRegion
- private string authServiceName
- private int bufferSize
- private bool cacheHttpClient
- private bool disableHostPrefixInjection
- private bool disableLogging
- private int endpointDiscoveryCacheLimit
- private System.Nullable<bool> endpointDiscoveryEnabled
- internal static readonly System.TimeSpan InfiniteTimeout
- private bool logMetrics
- private bool logResponse
- private int maxErrorRetry
- public static readonly System.TimeSpan MaxTimeout
- private bool probeForRegionEndpoint
- private long progressUpdateInterval
- private System.Net.IWebProxy proxy
- private System.Net.ICredentials proxyCredentials
- private string proxyHost
- private int proxyPort
- private bool readEntireResponse
- private System.Nullable<System.TimeSpan> readWriteTimeout
- private Amazon.RegionEndpoint regionEndpoint
- private bool resignRetries
- private string serviceURL
- private Amazon.Runtime.SigningAlgorithm signatureMethod
- private string signatureVersion
- private bool throttleRetries
- private System.Nullable<System.TimeSpan> timeout
- private bool useDualstackEndpoint
- private bool useHttp
- private System.Nullable<int> _httpClientCacheSize

#### Properties
- public bool AllowAutoRedirect { get; set; }
- public string AuthenticationRegion { get; set; }
- public string AuthenticationServiceName { get; set; }
- public int BufferSize { get; set; }
- public bool CacheHttpClient { get; set; }
- public System.TimeSpan ClockOffset { get; }
- public System.DateTime CorrectedUtcNow { get; }
- public bool DisableHostPrefixInjection { get; set; }
- public bool DisableLogging { get; set; }
- public int EndpointDiscoveryCacheLimit { get; set; }
- public bool EndpointDiscoveryEnabled { get; set; }
- public int HttpClientCacheSize { get; set; }
- public Amazon.Runtime.HttpClientFactory HttpClientFactory { get; set; }
- public bool LogMetrics { get; set; }
- public bool LogResponse { get; set; }
- public System.Nullable<int> MaxConnectionsPerServer { get; set; }
- public int MaxErrorRetry { get; set; }
- public long ProgressUpdateInterval { get; set; }
- public System.Net.ICredentials ProxyCredentials { get; set; }
- public string ProxyHost { get; set; }
- public int ProxyPort { get; set; }
- public bool ReadEntireResponse { get; set; }
- public System.Nullable<System.TimeSpan> ReadWriteTimeout { get; set; }
- public Amazon.RegionEndpoint RegionEndpoint { get; set; }
- public string RegionEndpointServiceName { get; }
- public bool ResignRetries { get; set; }
- public string ServiceURL { get; set; }
- public string ServiceVersion { get; }
- public Amazon.Runtime.SigningAlgorithm SignatureMethod { get; set; }
- public string SignatureVersion { get; set; }
- public bool ThrottleRetries { get; set; }
- public System.Nullable<System.TimeSpan> Timeout { get; set; }
- public bool UseDualstackEndpoint { get; set; }
- public bool UseHttp { get; set; }
- public string UserAgent { get; }

#### Constructors
- public ClientConfig()
- private static ClientConfig()

#### Methods
- internal static bool CacheHttpClients(Amazon.Runtime.IClientConfig clientConfig)
- internal static string CreateConfigUniqueString(Amazon.Runtime.IClientConfig clientConfig)
- public string DetermineServiceURL()
- internal static bool DisposeHttpClients(Amazon.Runtime.IClientConfig clientConfig)
- private static Amazon.RegionEndpoint GetDefaultRegionEndpoint()
- public static System.Nullable<System.TimeSpan> GetTimeoutValue(System.Nullable<System.TimeSpan> clientTimeout, System.Nullable<System.TimeSpan> requestTimeout)
- internal static string GetUrl(Amazon.RegionEndpoint regionEndpoint, string regionEndpointServiceName, bool useHttp, bool useDualStack)
- public System.Net.IWebProxy GetWebProxy()
- protected virtual void Initialize()
- public void SetUseNagleIfAvailable(bool useNagle)
- public void SetWebProxy(System.Net.IWebProxy proxy)
- internal static bool UseGlobalHttpClientCache(Amazon.Runtime.IClientConfig clientConfig)
- public virtual void Validate()
- public static void ValidateTimeout(System.Nullable<System.TimeSpan> timeout)

### private delegate Amazon.Runtime.FallbackEndpointDiscoveryEnabledFactory.ConfigGenerator
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public FallbackEndpointDiscoveryEnabledFactory.ConfigGenerator(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual bool EndInvoke(System.IAsyncResult result)
- public virtual bool Invoke()

### public class Amazon.Runtime.ConstantClass

#### Fields
- private string <Value>k__BackingField
- private static System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.Dictionary<string, Amazon.Runtime.ConstantClass>> staticFields
- private static readonly object staticFieldsLock

#### Properties
- public string Value { get; private set; }

#### Constructors
- private static ConstantClass()
- protected ConstantClass(string value)

#### Methods
- public override bool Equals(object obj)
- public virtual bool Equals(Amazon.Runtime.ConstantClass obj)
- protected virtual bool Equals(string value)
- protected static T FindValue<T>(string value)
- public override int GetHashCode()
- internal Amazon.Runtime.ConstantClass Intern()
- private static void LoadFields(System.Type t)
- public static bool op_Equality(Amazon.Runtime.ConstantClass a, Amazon.Runtime.ConstantClass b)
- public static bool op_Equality(Amazon.Runtime.ConstantClass a, string b)
- public static bool op_Equality(string a, Amazon.Runtime.ConstantClass b)
- public static string op_Implicit(Amazon.Runtime.ConstantClass value)
- public static bool op_Inequality(Amazon.Runtime.ConstantClass a, Amazon.Runtime.ConstantClass b)
- public static bool op_Inequality(Amazon.Runtime.ConstantClass a, string b)
- public static bool op_Inequality(string a, Amazon.Runtime.ConstantClass b)
- public override string ToString()
- public string ToString(System.IFormatProvider provider)

### public static class Amazon.Runtime.CorrectClockSkew

#### Fields
- private static System.Collections.Generic.IDictionary<string, System.TimeSpan> clockCorrectionDictionary
- private static System.Threading.ReaderWriterLockSlim clockCorrectionDictionaryLock
- private static System.Nullable<System.TimeSpan> manualClockCorrection
- private static System.Threading.ReaderWriterLockSlim manualClockCorrectionLock

#### Properties
- internal static System.Nullable<System.TimeSpan> GlobalClockCorrection { get; set; }

#### Constructors
- private static CorrectClockSkew()

#### Methods
- public static System.TimeSpan GetClockCorrectionForEndpoint(string endpoint)
- public static System.DateTime GetCorrectedUtcNowForEndpoint(string endpoint)
- internal static void SetClockCorrectionForEndpoint(string endpoint, System.TimeSpan correction)

### public class Amazon.Runtime.CredentialRequestCallbackArgs

#### Fields
- private object <CustomState>k__BackingField
- private bool <PreviousAuthenticationFailed>k__BackingField
- private string <ProfileName>k__BackingField
- private string <UserIdentity>k__BackingField

#### Properties
- public object CustomState { get; internal set; }
- public bool PreviousAuthenticationFailed { get; internal set; }
- public string ProfileName { get; internal set; }
- public string UserIdentity { get; internal set; }

#### Constructors
- public CredentialRequestCallbackArgs()

### public delegate Amazon.Runtime.FallbackCredentialsFactory.CredentialsGenerator
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public FallbackCredentialsFactory.CredentialsGenerator(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual Amazon.Runtime.AWSCredentials EndInvoke(System.IAsyncResult result)
- public virtual Amazon.Runtime.AWSCredentials Invoke()

### public class Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState

#### Fields
- private Amazon.Runtime.ImmutableCredentials <Credentials>k__BackingField
- private System.DateTime <Expiration>k__BackingField

#### Properties
- public Amazon.Runtime.ImmutableCredentials Credentials { get; set; }
- public System.DateTime Expiration { get; set; }

#### Constructors
- public RefreshingAWSCredentials.CredentialsRefreshState()
- public RefreshingAWSCredentials.CredentialsRefreshState(Amazon.Runtime.ImmutableCredentials credentials, System.DateTime expiration)

#### Methods
- internal bool IsExpiredWithin(System.TimeSpan preemptExpiryTime)

### internal class Amazon.Runtime.DefaultInstanceProfileAWSCredentials
- Base: Amazon.Runtime.AWSCredentials
- Interfaces: System.IDisposable

#### Fields
- private System.Threading.Timer credentialsRetrieverTimer
- private static const string FailedToGetCredentialsMessage
- private static object instanceLock
- private bool isDisposed
- private Amazon.Runtime.ImmutableCredentials lastRetrievedCredentials
- private Amazon.Runtime.Internal.Util.Logger logger
- private static readonly System.TimeSpan neverTimespan
- private static readonly System.TimeSpan refreshRate
- private static Amazon.Runtime.DefaultInstanceProfileAWSCredentials _instance

#### Properties
- public static Amazon.Runtime.DefaultInstanceProfileAWSCredentials Instance { get; }

#### Constructors
- private DefaultInstanceProfileAWSCredentials()
- private static DefaultInstanceProfileAWSCredentials()

#### Methods
- private static void CheckIsIMDSEnabled()
- protected virtual void Dispose(bool disposing)
- public void Dispose()
- private static Amazon.Runtime.ImmutableCredentials FetchCredentials()
- public override Amazon.Runtime.ImmutableCredentials GetCredentials()
- public override System.Threading.Tasks.Task<Amazon.Runtime.ImmutableCredentials> GetCredentialsAsync()
- private void RenewCredentials(object unused)

### public class Amazon.Runtime.ECSTaskCredentials
- Base: Amazon.Runtime.URIBasedRefreshingCredentialHelper
- Interfaces: System.IDisposable

#### Fields
- public static const string ContainerCredentialsURIEnvVariable
- public static const string EndpointAddress
- private static int MaxRetries
- private System.Net.IWebProxy Proxy
- private string Server
- private string Uri

#### Constructors
- public ECSTaskCredentials()
- private static ECSTaskCredentials()
- public ECSTaskCredentials(System.Net.IWebProxy proxy)

#### Methods
- protected override Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState GenerateNewCredentials()

### public class Amazon.Runtime.EnvironmentVariableAWSEndpointDiscoveryEnabled

#### Fields
- private bool <Enabled>k__BackingField
- public static const string ENVIRONMENT_VARIABLE_AWS_ENABLE_ENDPOINT_DISCOVERY

#### Properties
- public bool Enabled { get; private set; }

#### Constructors
- public EnvironmentVariableAWSEndpointDiscoveryEnabled()

### public class Amazon.Runtime.EnvironmentVariableAWSRegion
- Base: Amazon.Runtime.AWSRegion

#### Fields
- public static const string ENVIRONMENT_VARIABLE_REGION

#### Constructors
- public EnvironmentVariableAWSRegion()

### public class Amazon.Runtime.EnvironmentVariablesAWSCredentials
- Base: Amazon.Runtime.AWSCredentials

#### Fields
- public static const string ENVIRONMENT_VARIABLE_ACCESSKEY
- public static const string ENVIRONMENT_VARIABLE_SECRETKEY
- public static const string ENVIRONMENT_VARIABLE_SESSION_TOKEN
- public static const string LEGACY_ENVIRONMENT_VARIABLE_SECRETKEY
- private Amazon.Runtime.Internal.Util.Logger logger

#### Constructors
- public EnvironmentVariablesAWSCredentials()

#### Methods
- public Amazon.Runtime.ImmutableCredentials FetchCredentials()
- public override Amazon.Runtime.ImmutableCredentials GetCredentials()

### public enum Amazon.Runtime.ErrorType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Receiver = 1
- Sender = 0
- Unknown = 2

### public class Amazon.Runtime.ExceptionEventArgs
- Base: System.EventArgs

#### Constructors
- protected ExceptionEventArgs()

### public delegate Amazon.Runtime.ExceptionEventHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ExceptionEventHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(object sender, Amazon.Runtime.ExceptionEventArgs e, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(object sender, Amazon.Runtime.ExceptionEventArgs e)

### public static class Amazon.Runtime.FallbackCredentialsFactory

#### Fields
- private static System.Collections.Generic.List<Amazon.Runtime.FallbackCredentialsFactory.CredentialsGenerator> <CredentialsGenerators>k__BackingField
- internal static const string AWS_PROFILE_ENVIRONMENT_VARIABLE
- private static Amazon.Runtime.AWSCredentials cachedCredentials
- private static readonly Amazon.Runtime.CredentialManagement.CredentialProfileStoreChain credentialProfileChain
- internal static const string DefaultProfileName

#### Properties
- public static System.Collections.Generic.List<Amazon.Runtime.FallbackCredentialsFactory.CredentialsGenerator> CredentialsGenerators { get; set; }

#### Constructors
- private static FallbackCredentialsFactory()

#### Methods
- private static Amazon.Runtime.AWSCredentials ECSEC2CredentialsWrapper()
- private static Amazon.Runtime.AWSCredentials ECSEC2CredentialsWrapper(System.Net.IWebProxy proxy)
- private static Amazon.Runtime.AWSCredentials GetAWSCredentials(Amazon.Runtime.CredentialManagement.ICredentialProfileSource source)
- public static Amazon.Runtime.AWSCredentials GetCredentials()
- public static Amazon.Runtime.AWSCredentials GetCredentials(bool fallbackToAnonymous)
- public static void Reset()
- public static void Reset(System.Net.IWebProxy proxy)

### public static class Amazon.Runtime.FallbackEndpointDiscoveryEnabledFactory

#### Fields
- private static System.Collections.Generic.List<Amazon.Runtime.FallbackEndpointDiscoveryEnabledFactory.ConfigGenerator> <EnabledGenerators>k__BackingField
- private static Amazon.Runtime.CredentialManagement.CredentialProfileStoreChain credentialProfileChain
- private static System.Nullable<bool> endpointDiscoveryEnabled
- private static object _lock

#### Properties
- private static System.Collections.Generic.List<Amazon.Runtime.FallbackEndpointDiscoveryEnabledFactory.ConfigGenerator> EnabledGenerators { get; set; }

#### Constructors
- private static FallbackEndpointDiscoveryEnabledFactory()

#### Methods
- public static System.Nullable<bool> GetEnabled()
- public static void Reset()

### public static class Amazon.Runtime.FallbackRegionFactory

#### Fields
- private static System.Collections.Generic.List<Amazon.Runtime.FallbackRegionFactory.RegionGenerator> <AllGenerators>k__BackingField
- private static System.Collections.Generic.List<Amazon.Runtime.FallbackRegionFactory.RegionGenerator> <NonMetadataGenerators>k__BackingField
- private static Amazon.Runtime.AWSRegion cachedRegion
- private static Amazon.Runtime.CredentialManagement.CredentialProfileStoreChain credentialProfileChain
- private static object _lock

#### Properties
- private static System.Collections.Generic.List<Amazon.Runtime.FallbackRegionFactory.RegionGenerator> AllGenerators { get; set; }
- private static System.Collections.Generic.List<Amazon.Runtime.FallbackRegionFactory.RegionGenerator> NonMetadataGenerators { get; set; }

#### Constructors
- private static FallbackRegionFactory()

#### Methods
- public static Amazon.RegionEndpoint GetRegionEndpoint()
- public static Amazon.RegionEndpoint GetRegionEndpoint(bool includeInstanceMetadata)
- public static void Reset()

### public class Amazon.Runtime.FederatedAuthenticationCancelledException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public FederatedAuthenticationCancelledException(string msg)
- public FederatedAuthenticationCancelledException(string msg, System.Exception inner)

### public class Amazon.Runtime.FederatedAuthenticationFailureException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public FederatedAuthenticationFailureException(string msg)
- public FederatedAuthenticationFailureException(string msg, System.Exception inner)

### public class Amazon.Runtime.FederatedAWSCredentials
- Base: Amazon.Runtime.RefreshingAWSCredentials
- Interfaces: System.IDisposable

#### Fields
- private Amazon.Runtime.FederatedAWSCredentialsOptions <Options>k__BackingField
- private string <RoleArn>k__BackingField
- private Amazon.Runtime.CredentialManagement.SAMLEndpoint <SAMLEndpoint>k__BackingField
- private static readonly System.TimeSpan DefaultPreemptExpiryTime
- private static readonly Amazon.RegionEndpoint DefaultSTSClientRegion
- private static const int MaxAuthenticationRetries
- private static readonly System.TimeSpan MaximumCredentialTimespan
- private readonly Amazon.Runtime.CredentialManagement.Internal.SAMLRoleSessionManager sessionManager

#### Properties
- public Amazon.Runtime.FederatedAWSCredentialsOptions Options { get; private set; }
- public string RoleArn { get; private set; }
- public Amazon.Runtime.CredentialManagement.SAMLEndpoint SAMLEndpoint { get; private set; }

#### Constructors
- private static FederatedAWSCredentials()
- public FederatedAWSCredentials(Amazon.Runtime.CredentialManagement.SAMLEndpoint samlEndpoint, string roleArn)
- public FederatedAWSCredentials(Amazon.Runtime.CredentialManagement.SAMLEndpoint samlEndpoint, string roleArn, Amazon.Runtime.FederatedAWSCredentialsOptions options)

#### Methods
- private Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState Authenticate(System.Net.ICredentials userCredential)
- public override void ClearCredentials()
- protected override Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState GenerateNewCredentials()
- private string GetRoleSessionName()
- private void RegisterRoleSession(Amazon.Runtime.SAMLImmutableCredentials sessionCredentials)
- private bool TryGetRoleSession(out Amazon.Runtime.SAMLImmutableCredentials sessionCredentials)

### public class Amazon.Runtime.FederatedAWSCredentialsOptions

#### Fields
- private System.Func<Amazon.Runtime.CredentialRequestCallbackArgs, System.Net.NetworkCredential> credentialRequestCallback
- private object customCallbackState
- private string profileName
- private System.Net.WebProxy proxySettings
- private Amazon.RegionEndpoint stsRegion
- private readonly object syncLock
- private string userIdentity

#### Properties
- public System.Func<Amazon.Runtime.CredentialRequestCallbackArgs, System.Net.NetworkCredential> CredentialRequestCallback { get; set; }
- public object CustomCallbackState { get; set; }
- public string ProfileName { get; set; }
- public System.Net.WebProxy ProxySettings { get; set; }
- public Amazon.RegionEndpoint STSRegion { get; set; }
- public string UserIdentity { get; set; }

#### Constructors
- public FederatedAWSCredentialsOptions()

### public class Amazon.Runtime.HeadersRequestEventArgs
- Base: Amazon.Runtime.RequestEventArgs

#### Fields
- private System.Collections.Generic.IDictionary<string, string> <Headers>k__BackingField

#### Properties
- public System.Collections.Generic.IDictionary<string, string> Headers { get; protected set; }

#### Constructors
- protected HeadersRequestEventArgs()

#### Methods
- internal static Amazon.Runtime.HeadersRequestEventArgs Create(System.Collections.Generic.IDictionary<string, string> headers)

### public class Amazon.Runtime.HttpClientCache
- Interfaces: System.IDisposable

#### Fields
- private int count
- private System.Net.Http.HttpClient[] _clients

#### Constructors
- public HttpClientCache(System.Net.Http.HttpClient[] clients)

#### Methods
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- public System.Net.Http.HttpClient GetNextClient()

### public class Amazon.Runtime.HttpClientFactory

#### Constructors
- protected HttpClientFactory()

#### Methods
- public abstract System.Net.Http.HttpClient CreateHttpClient(Amazon.Runtime.IClientConfig clientConfig)
- public virtual bool DisposeHttpClientsAfterUse(Amazon.Runtime.IClientConfig clientConfig)
- public virtual string GetConfigUniqueString(Amazon.Runtime.IClientConfig clientConfig)
- public virtual bool UseSDKHttpClientCaching(Amazon.Runtime.IClientConfig clientConfig)

### public class Amazon.Runtime.HttpRequestMessageFactory
- Interfaces: Amazon.Runtime.IHttpRequestFactory<System.Net.Http.HttpContent>, System.IDisposable

#### Fields
- private Amazon.Runtime.IClientConfig _clientConfig
- private Amazon.Runtime.HttpClientCache _httpClientCache
- private static readonly System.Threading.ReaderWriterLockSlim _httpClientCacheRWLock
- private static readonly System.Collections.Generic.IDictionary<string, Amazon.Runtime.HttpClientCache> _httpClientCaches
- private bool _useGlobalHttpClientCache

#### Constructors
- private static HttpRequestMessageFactory()
- public HttpRequestMessageFactory(Amazon.Runtime.IClientConfig clientConfig)

#### Methods
- private static System.Net.Http.HttpClient CreateHttpClient(Amazon.Runtime.IClientConfig clientConfig)
- private static Amazon.Runtime.HttpClientCache CreateHttpClientCache(Amazon.Runtime.IClientConfig clientConfig)
- public Amazon.Runtime.IHttpRequest<System.Net.Http.HttpContent> CreateHttpRequest(System.Uri requestUri)
- private static System.Net.Http.HttpClient CreateManagedHttpClient(Amazon.Runtime.IClientConfig clientConfig)
- public void Dispose()
- protected virtual void Dispose(bool disposing)

### public class Amazon.Runtime.HttpWebRequestMessage
- Interfaces: Amazon.Runtime.IHttpRequest<System.Net.Http.HttpContent>, System.IDisposable

#### Fields
- private static System.Collections.Generic.HashSet<string> ContentHeaderNames
- private Amazon.Runtime.IClientConfig _clientConfig
- private bool _disposed
- private System.Net.Http.HttpClient _httpClient
- private System.Net.Http.HttpRequestMessage _request

#### Properties
- public System.Net.Http.HttpClient HttpClient { get; }
- public string Method { get; set; }
- public System.Net.Http.HttpRequestMessage Request { get; }
- public System.Uri RequestUri { get; }

#### Constructors
- private static HttpWebRequestMessage()
- public HttpWebRequestMessage(System.Net.Http.HttpClient httpClient, System.Uri requestUri, Amazon.Runtime.IClientConfig config)

#### Methods
- public void Abort()
- public void ConfigureRequest(Amazon.Runtime.IRequestContext requestContext)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- public System.Net.Http.HttpContent GetRequestContent()
- public System.Threading.Tasks.Task<System.Net.Http.HttpContent> GetRequestContentAsync()
- public Amazon.Runtime.Internal.Transform.IWebResponseData GetResponse()
- public System.Threading.Tasks.Task<Amazon.Runtime.Internal.Transform.IWebResponseData> GetResponseAsync(System.Threading.CancellationToken cancellationToken)
- public void SetRequestHeaders(System.Collections.Generic.IDictionary<string, string> headers)
- public System.IO.Stream SetupProgressListeners(System.IO.Stream originalStream, long progressUpdateInterval, object sender, System.EventHandler<Amazon.Runtime.StreamTransferProgressArgs> callback)
- private void WriteContentHeaders(System.Collections.Generic.IDictionary<string, string> contentHeaders)
- public void WriteToRequestBody(System.Net.Http.HttpContent requestContent, System.IO.Stream contentStream, System.Collections.Generic.IDictionary<string, string> contentHeaders, Amazon.Runtime.IRequestContext requestContext)
- public void WriteToRequestBody(System.Net.Http.HttpContent requestContent, byte[] content, System.Collections.Generic.IDictionary<string, string> contentHeaders)

### public interface Amazon.Runtime.IAmazonService

#### Properties
- public Amazon.Runtime.IClientConfig Config { get; }

### public interface Amazon.Runtime.IAsyncExecutionContext

#### Properties
- public Amazon.Runtime.IAsyncRequestContext RequestContext { get; }
- public Amazon.Runtime.IAsyncResponseContext ResponseContext { get; }
- public object RuntimeState { get; set; }

### public interface Amazon.Runtime.IAsyncRequestContext
- Interfaces: Amazon.Runtime.IRequestContext

#### Properties
- public System.AsyncCallback Callback { get; }
- public object State { get; }

### public interface Amazon.Runtime.IAsyncResponseContext
- Interfaces: Amazon.Runtime.IResponseContext

### public interface Amazon.Runtime.IClientConfig

#### Properties
- public bool AllowAutoRedirect { get; }
- public string AuthenticationRegion { get; }
- public string AuthenticationServiceName { get; }
- public int BufferSize { get; }
- public bool CacheHttpClient { get; }
- public System.TimeSpan ClockOffset { get; }
- public System.DateTime CorrectedUtcNow { get; }
- public bool DisableHostPrefixInjection { get; }
- public bool DisableLogging { get; }
- public int EndpointDiscoveryCacheLimit { get; }
- public bool EndpointDiscoveryEnabled { get; }
- public int HttpClientCacheSize { get; }
- public Amazon.Runtime.HttpClientFactory HttpClientFactory { get; }
- public bool LogMetrics { get; }
- public bool LogResponse { get; }
- public System.Nullable<int> MaxConnectionsPerServer { get; }
- public int MaxErrorRetry { get; }
- public long ProgressUpdateInterval { get; }
- public System.Net.ICredentials ProxyCredentials { get; }
- public string ProxyHost { get; }
- public int ProxyPort { get; }
- public bool ReadEntireResponse { get; }
- public Amazon.RegionEndpoint RegionEndpoint { get; }
- public string RegionEndpointServiceName { get; }
- public bool ResignRetries { get; }
- public string ServiceURL { get; }
- public string ServiceVersion { get; }
- public Amazon.Runtime.SigningAlgorithm SignatureMethod { get; }
- public string SignatureVersion { get; }
- public bool ThrottleRetries { get; }
- public System.Nullable<System.TimeSpan> Timeout { get; }
- public bool UseDualstackEndpoint { get; }
- public bool UseHttp { get; }
- public string UserAgent { get; }

#### Methods
- public string DetermineServiceURL()
- public System.Net.IWebProxy GetWebProxy()
- public void Validate()

### public interface Amazon.Runtime.IExceptionHandler

#### Methods
- public bool Handle(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)

### public interface Amazon.Runtime.IExceptionHandler<T>
- Interfaces: Amazon.Runtime.IExceptionHandler

#### Methods
- public bool HandleException(Amazon.Runtime.IExecutionContext executionContext, T exception)

### public interface Amazon.Runtime.IExecutionContext

#### Properties
- public Amazon.Runtime.IRequestContext RequestContext { get; }
- public Amazon.Runtime.IResponseContext ResponseContext { get; }

### public interface Amazon.Runtime.IHttpRequestFactory<TRequestContent>
- Interfaces: System.IDisposable

#### Methods
- public Amazon.Runtime.IHttpRequest<TRequestContent> CreateHttpRequest(System.Uri requestUri)

### public interface Amazon.Runtime.IHttpRequest<TRequestContent>
- Interfaces: System.IDisposable

#### Properties
- public string Method { get; set; }
- public System.Uri RequestUri { get; }

#### Methods
- public void Abort()
- public void ConfigureRequest(Amazon.Runtime.IRequestContext requestContext)
- public TRequestContent GetRequestContent()
- public System.Threading.Tasks.Task<TRequestContent> GetRequestContentAsync()
- public Amazon.Runtime.Internal.Transform.IWebResponseData GetResponse()
- public System.Threading.Tasks.Task<Amazon.Runtime.Internal.Transform.IWebResponseData> GetResponseAsync(System.Threading.CancellationToken cancellationToken)
- public void SetRequestHeaders(System.Collections.Generic.IDictionary<string, string> headers)
- public System.IO.Stream SetupProgressListeners(System.IO.Stream originalStream, long progressUpdateInterval, object sender, System.EventHandler<Amazon.Runtime.StreamTransferProgressArgs> callback)
- public void WriteToRequestBody(TRequestContent requestContent, System.IO.Stream contentStream, System.Collections.Generic.IDictionary<string, string> contentHeaders, Amazon.Runtime.IRequestContext requestContext)
- public void WriteToRequestBody(TRequestContent requestContent, byte[] content, System.Collections.Generic.IDictionary<string, string> contentHeaders)

### public interface Amazon.Runtime.ILogMessage

#### Properties
- public object[] Args { get; }
- public string Format { get; }
- public System.IFormatProvider Provider { get; }

### public interface Amazon.Runtime.IMetricsFormatter

#### Methods
- public string FormatMetrics(Amazon.Runtime.IRequestMetrics metrics)

### public interface Amazon.Runtime.IMetricsTiming

#### Properties
- public long ElapsedTicks { get; }
- public System.TimeSpan ElapsedTime { get; }
- public bool IsFinished { get; }

### public class Amazon.Runtime.ImmutableCredentials

#### Fields
- private string <AccessKey>k__BackingField
- private string <SecretKey>k__BackingField
- private string <Token>k__BackingField

#### Properties
- public string AccessKey { get; private set; }
- public string SecretKey { get; private set; }
- public string Token { get; private set; }
- public bool UseToken { get; }

#### Constructors
- private ImmutableCredentials()
- public ImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token)

#### Methods
- public virtual Amazon.Runtime.ImmutableCredentials Copy()
- public override bool Equals(object obj)
- public override int GetHashCode()

### public class Amazon.Runtime.InstanceProfileAWSCredentials
- Base: Amazon.Runtime.URIBasedRefreshingCredentialHelper
- Interfaces: System.IDisposable

#### Fields
- private string <Role>k__BackingField
- private static string[] AliasSeparators
- private static string InfoPath
- private static string RolesPath
- private static string Server
- private Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState _currentRefreshState
- private static System.TimeSpan _preemptExpiryTime
- private System.Net.IWebProxy _proxy
- private static System.TimeSpan _refreshAttemptPeriod

#### Properties
- private System.Uri CurrentRoleUri { get; }
- private static System.Uri InfoUri { get; }
- public string Role { get; set; }
- private static System.Uri RolesUri { get; }

#### Constructors
- public InstanceProfileAWSCredentials()
- private static InstanceProfileAWSCredentials()
- public InstanceProfileAWSCredentials(string role)
- public InstanceProfileAWSCredentials(System.Net.IWebProxy proxy)
- public InstanceProfileAWSCredentials(string role, System.Net.IWebProxy proxy)

#### Methods
- private static void CheckIsIMDSEnabled()
- protected override Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState GenerateNewCredentials()
- public static System.Collections.Generic.IEnumerable<string> GetAvailableRoles()
- public static System.Collections.Generic.IEnumerable<string> GetAvailableRoles(System.Net.IWebProxy proxy)
- private Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState GetEarlyRefreshState(Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState state)
- private static string GetFirstRole()
- private static string GetFirstRole(System.Net.IWebProxy proxy)
- private Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState GetRefreshState()
- private Amazon.Runtime.URIBasedRefreshingCredentialHelper.SecurityCredentials GetRoleCredentials()
- private static Amazon.Runtime.URIBasedRefreshingCredentialHelper.SecurityInfo GetServiceInfo(System.Net.IWebProxy proxy)
- private static bool IsNullOrWhiteSpace(string s)

### public class Amazon.Runtime.InstanceProfileAWSRegion
- Base: Amazon.Runtime.AWSRegion

#### Constructors
- public InstanceProfileAWSRegion()

### public interface Amazon.Runtime.IPipelineHandler

#### Properties
- public Amazon.Runtime.IPipelineHandler InnerHandler { get; set; }
- public Amazon.Runtime.Internal.Util.ILogger Logger { get; set; }
- public Amazon.Runtime.IPipelineHandler OuterHandler { get; set; }

#### Methods
- public System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)

### public interface Amazon.Runtime.IRequestContext

#### Properties
- public System.Threading.CancellationToken CancellationToken { get; }
- public Amazon.Runtime.IClientConfig ClientConfig { get; }
- public Amazon.Runtime.Internal.MonitoringAPICallAttempt CSMCallAttempt { get; set; }
- public Amazon.Runtime.Internal.MonitoringAPICallEvent CSMCallEvent { get; set; }
- public bool CSMEnabled { get; }
- public int EndpointDiscoveryRetries { get; set; }
- public Amazon.Runtime.ImmutableCredentials ImmutableCredentials { get; set; }
- public bool IsAsync { get; }
- public bool IsLastExceptionRetryable { get; set; }
- public bool IsSigned { get; set; }
- public Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest> Marshaller { get; }
- public Amazon.Runtime.Internal.Util.RequestMetrics Metrics { get; }
- public Amazon.Runtime.Internal.InvokeOptionsBase Options { get; }
- public Amazon.Runtime.AmazonWebServiceRequest OriginalRequest { get; }
- public Amazon.Runtime.Internal.IRequest Request { get; set; }
- public string RequestName { get; }
- public int Retries { get; set; }
- public Amazon.Runtime.Internal.IServiceMetadata ServiceMetaData { get; }
- public Amazon.Runtime.Internal.Auth.AbstractAWSSigner Signer { get; }
- public Amazon.Runtime.Internal.Transform.ResponseUnmarshaller Unmarshaller { get; }

### public interface Amazon.Runtime.IRequestMetrics

#### Properties
- public System.Collections.Generic.Dictionary<Amazon.Runtime.Metric, long> Counters { get; }
- public bool IsEnabled { get; }
- public System.Collections.Generic.Dictionary<Amazon.Runtime.Metric, System.Collections.Generic.List<object>> Properties { get; }
- public System.Collections.Generic.Dictionary<Amazon.Runtime.Metric, System.Collections.Generic.List<Amazon.Runtime.IMetricsTiming>> Timings { get; }

#### Methods
- public string ToJSON()

### public interface Amazon.Runtime.IResponseContext

#### Properties
- public Amazon.Runtime.Internal.Transform.IWebResponseData HttpResponse { get; set; }
- public Amazon.Runtime.AmazonWebServiceResponse Response { get; set; }

### public enum Amazon.Runtime.Metric
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AmzCfId = 26
- AmzId2 = 2
- AsyncCall = 20
- AttemptCount = 10
- AWSErrorCode = 0
- AWSRequestID = 1
- BytesProcessed = 3
- CanonicalRequest = 18
- ClientExecuteTime = 21
- CredentialsRequestTime = 11
- CSMAttemptLatency = 19
- Exception = 4
- HttpRequestTime = 12
- MethodName = 22
- ProxyHost = 13
- ProxyPort = 14
- RedirectLocation = 5
- RequestSigningTime = 15
- RequestSize = 25
- ResponseProcessingTime = 6
- ResponseReadTime = 8
- ResponseUnmarshallTime = 7
- RetryPauseTime = 16
- ServiceEndpoint = 23
- ServiceName = 24
- StatusCode = 9
- StringToSign = 17

### internal class Amazon.Runtime.MonitoringListener
- Interfaces: System.IDisposable

#### Fields
- private static readonly Amazon.Runtime.MonitoringListener csmMonitoringListenerInstance
- private readonly Amazon.Runtime.Internal.Util.Logger logger
- private bool _disposed
- private readonly string _host
- private readonly int _port
- private readonly System.Net.Sockets.UdpClient _udpClient

#### Properties
- public static Amazon.Runtime.MonitoringListener Instance { get; }

#### Constructors
- private MonitoringListener()
- private static MonitoringListener()

#### Methods
- public void Dispose()
- private void Dispose(bool disposing)
- public void PostMessagesOverUDP(string response)
- public System.Threading.Tasks.Task PostMessagesOverUDPAsync(string response)

### public class Amazon.Runtime.ParameterValue

#### Constructors
- protected ParameterValue()

### public class Amazon.Runtime.PreRequestEventArgs
- Base: System.EventArgs

#### Fields
- private Amazon.Runtime.AmazonWebServiceRequest <Request>k__BackingField

#### Properties
- public Amazon.Runtime.AmazonWebServiceRequest Request { get; protected set; }

#### Constructors
- protected PreRequestEventArgs()

#### Methods
- internal static Amazon.Runtime.PreRequestEventArgs Create(Amazon.Runtime.AmazonWebServiceRequest request)

### public delegate Amazon.Runtime.PreRequestEventHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public PreRequestEventHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(object sender, Amazon.Runtime.PreRequestEventArgs e, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(object sender, Amazon.Runtime.PreRequestEventArgs e)

### public class Amazon.Runtime.ProcessAWSCredentialException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ProcessAWSCredentialException(string message)
- public ProcessAWSCredentialException(string message, System.Exception inner)

### public class Amazon.Runtime.ProcessAWSCredentials
- Base: Amazon.Runtime.RefreshingAWSCredentials
- Interfaces: System.IDisposable

#### Fields
- private Amazon.Runtime.Internal.Util.Logger _logger
- private readonly System.Diagnostics.ProcessStartInfo _processStartInfo
- private static const string _versionString

#### Constructors
- public ProcessAWSCredentials(string processCredentialInfo)

#### Methods
- public Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState DetermineProcessCredential()
- public System.Threading.Tasks.Task<Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState> DetermineProcessCredentialAsync()
- protected override Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState GenerateNewCredentials()
- protected override System.Threading.Tasks.Task<Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState> GenerateNewCredentialsAsync()
- private Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState SetCredentialsRefreshState(Amazon.Util.ProcessExecutionResult processInfo)

### public class Amazon.Runtime.ProfileAWSEndpointDiscoveryEnabled

#### Fields
- private bool <Enabled>k__BackingField

#### Properties
- public bool Enabled { get; private set; }

#### Constructors
- public ProfileAWSEndpointDiscoveryEnabled(Amazon.Runtime.CredentialManagement.ICredentialProfileSource source)
- public ProfileAWSEndpointDiscoveryEnabled(Amazon.Runtime.CredentialManagement.ICredentialProfileSource source, string profileName)

#### Methods
- private void Setup(Amazon.Runtime.CredentialManagement.ICredentialProfileSource source, string profileName)

### public class Amazon.Runtime.ProfileAWSRegion
- Base: Amazon.Runtime.AWSRegion

#### Constructors
- public ProfileAWSRegion(Amazon.Runtime.CredentialManagement.ICredentialProfileSource source)
- public ProfileAWSRegion(Amazon.Runtime.CredentialManagement.ICredentialProfileSource source, string profileName)

#### Methods
- private void Setup(Amazon.Runtime.CredentialManagement.ICredentialProfileSource source, string profileName)

### public class Amazon.Runtime.RefreshingAWSCredentials
- Base: Amazon.Runtime.AWSCredentials
- Interfaces: System.IDisposable

#### Fields
- protected Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState currentState
- private bool _disposed
- private Amazon.Runtime.Internal.Util.Logger _logger
- private System.TimeSpan _preemptExpiryTime
- private readonly System.Threading.SemaphoreSlim _updateGeneratedCredentialsSemaphore

#### Properties
- public System.TimeSpan PreemptExpiryTime { get; set; }
- protected bool ShouldUpdate { get; }

#### Constructors
- protected RefreshingAWSCredentials()

#### Methods
- private Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState <GenerateNewCredentialsAsync>b__16_0()
- public virtual void ClearCredentials()
- protected virtual void Dispose(bool disposing)
- public void Dispose()
- protected virtual Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState GenerateNewCredentials()
- protected virtual System.Threading.Tasks.Task<Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState> GenerateNewCredentialsAsync()
- public override Amazon.Runtime.ImmutableCredentials GetCredentials()
- public override System.Threading.Tasks.Task<Amazon.Runtime.ImmutableCredentials> GetCredentialsAsync()
- private static bool ShouldUpdateState(Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState state, System.TimeSpan preemptExpiryTime)
- private static void UpdateToGeneratedCredentials(Amazon.Runtime.RefreshingAWSCredentials.CredentialsRefreshState state, System.TimeSpan preemptExpiryTime)

### private delegate Amazon.Runtime.FallbackRegionFactory.RegionGenerator
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public FallbackRegionFactory.RegionGenerator(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual Amazon.Runtime.AWSRegion EndInvoke(System.IAsyncResult result)
- public virtual Amazon.Runtime.AWSRegion Invoke()

### public class Amazon.Runtime.RequestEventArgs
- Base: System.EventArgs

#### Constructors
- protected RequestEventArgs()

### public delegate Amazon.Runtime.RequestEventHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public RequestEventHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(object sender, Amazon.Runtime.RequestEventArgs e, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(object sender, Amazon.Runtime.RequestEventArgs e)

### public class Amazon.Runtime.ResponseEventArgs
- Base: System.EventArgs

#### Constructors
- protected ResponseEventArgs()

### public delegate Amazon.Runtime.ResponseEventHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ResponseEventHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(object sender, Amazon.Runtime.ResponseEventArgs e, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(object sender, Amazon.Runtime.ResponseEventArgs e)

### public class Amazon.Runtime.ResponseMetadata

#### Fields
- private string requestIdField
- private System.Collections.Generic.IDictionary<string, string> _metadata

#### Properties
- public System.Collections.Generic.IDictionary<string, string> Metadata { get; }
- public string RequestId { get; set; }

#### Constructors
- public ResponseMetadata()

### public class Amazon.Runtime.RetryPolicy

#### Fields
- private Amazon.Runtime.Internal.Util.ILogger <Logger>k__BackingField
- private int <MaxRetries>k__BackingField
- private static System.Collections.Generic.HashSet<string> clockSkewErrorCodes
- private static System.TimeSpan clockSkewMaxThreshold
- private static const string clockSkewMessageFormat
- private static const string clockSkewMessageMinusSeparator
- private static const string clockSkewMessageParen
- private static const string clockSkewMessagePlusSeparator
- private static const string clockSkewUpdatedFormat

#### Properties
- public Amazon.Runtime.Internal.Util.ILogger Logger { get; set; }
- public int MaxRetries { get; protected set; }

#### Constructors
- protected RetryPolicy()
- private static RetryPolicy()

#### Methods
- public abstract bool CanRetry(Amazon.Runtime.IExecutionContext executionContext)
- private static Amazon.Runtime.Internal.Transform.IWebResponseData GetWebData(Amazon.Runtime.AmazonServiceException ase)
- private bool IsClockskew(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)
- public virtual void NotifySuccess(Amazon.Runtime.IExecutionContext executionContext)
- public virtual bool OnRetry(Amazon.Runtime.IExecutionContext executionContext)
- public virtual bool OnRetry(Amazon.Runtime.IExecutionContext executionContext, bool bypassAcquireCapacity)
- public bool Retry(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)
- public System.Threading.Tasks.Task<bool> RetryAsync(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)
- public abstract bool RetryForException(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)
- public abstract System.Threading.Tasks.Task<bool> RetryForExceptionAsync(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)
- public abstract bool RetryLimitReached(Amazon.Runtime.IExecutionContext executionContext)
- private static bool TryParseDateHeader(Amazon.Runtime.AmazonServiceException ase, out System.DateTime serverTime)
- private static bool TryParseExceptionMessage(Amazon.Runtime.AmazonServiceException ase, out System.DateTime serverTime)
- public abstract void WaitBeforeRetry(Amazon.Runtime.IExecutionContext executionContext)
- public abstract System.Threading.Tasks.Task WaitBeforeRetryAsync(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.Runtime.SAMLImmutableCredentials
- Base: Amazon.Runtime.ImmutableCredentials

#### Fields
- private System.DateTime <Expires>k__BackingField
- private string <Subject>k__BackingField
- private static const string AccessKeyProperty
- private static const string ExpiresProperty
- private static const string SecretKeyProperty
- private static const string SubjectProperty
- private static const string TokenProperty

#### Properties
- public System.DateTime Expires { get; private set; }
- public string Subject { get; private set; }

#### Constructors
- public SAMLImmutableCredentials(Amazon.Runtime.ImmutableCredentials credentials, System.DateTime expires, string subject)
- public SAMLImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token, System.DateTime expires, string subject)

#### Methods
- public override Amazon.Runtime.ImmutableCredentials Copy()
- public override bool Equals(object obj)
- internal static Amazon.Runtime.SAMLImmutableCredentials FromJson(string json)
- public override int GetHashCode()
- internal string ToJson()

### protected class Amazon.Runtime.URIBasedRefreshingCredentialHelper.SecurityBase

#### Fields
- private string <Code>k__BackingField
- private System.DateTime <LastUpdated>k__BackingField
- private string <Message>k__BackingField

#### Properties
- public string Code { get; set; }
- public System.DateTime LastUpdated { get; set; }
- public string Message { get; set; }

#### Constructors
- public URIBasedRefreshingCredentialHelper.SecurityBase()

### protected class Amazon.Runtime.URIBasedRefreshingCredentialHelper.SecurityCredentials
- Base: Amazon.Runtime.URIBasedRefreshingCredentialHelper.SecurityBase

#### Fields
- private string <AccessKeyId>k__BackingField
- private System.DateTime <Expiration>k__BackingField
- private string <RoleArn>k__BackingField
- private string <SecretAccessKey>k__BackingField
- private string <Token>k__BackingField
- private string <Type>k__BackingField

#### Properties
- public string AccessKeyId { get; set; }
- public System.DateTime Expiration { get; set; }
- public string RoleArn { get; set; }
- public string SecretAccessKey { get; set; }
- public string Token { get; set; }
- public string Type { get; set; }

#### Constructors
- public URIBasedRefreshingCredentialHelper.SecurityCredentials()

### protected class Amazon.Runtime.URIBasedRefreshingCredentialHelper.SecurityInfo
- Base: Amazon.Runtime.URIBasedRefreshingCredentialHelper.SecurityBase

#### Fields
- private string <InstanceProfileArn>k__BackingField
- private string <InstanceProfileId>k__BackingField

#### Properties
- public string InstanceProfileArn { get; set; }
- public string InstanceProfileId { get; set; }

#### Constructors
- public URIBasedRefreshingCredentialHelper.SecurityInfo()

### public class Amazon.Runtime.SessionAWSCredentials
- Base: Amazon.Runtime.AWSCredentials

#### Fields
- private Amazon.Runtime.ImmutableCredentials _lastCredentials

#### Constructors
- public SessionAWSCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token)

#### Methods
- public override bool Equals(object obj)
- public override Amazon.Runtime.ImmutableCredentials GetCredentials()
- public override int GetHashCode()

### public class Amazon.Runtime.SignatureException
- Base: Amazon.Runtime.Internal.Auth.SignatureException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public SignatureException(string message)
- public SignatureException(string message, System.Exception innerException)

### public enum Amazon.Runtime.SigningAlgorithm
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- HmacSHA1 = 0
- HmacSHA256 = 1

### public class Amazon.Runtime.StoredProfileAWSCredentials
- Base: Amazon.Runtime.AWSCredentials

#### Fields
- private string <ProfileName>k__BackingField
- private string <ProfilesLocation>k__BackingField
- private Amazon.Runtime.AWSCredentials _wrappedCredentials

#### Properties
- public string ProfileName { get; private set; }
- public string ProfilesLocation { get; private set; }
- public Amazon.Runtime.AWSCredentials WrappedCredentials { get; }

#### Constructors
- public StoredProfileAWSCredentials()
- public StoredProfileAWSCredentials(string profileName)
- public StoredProfileAWSCredentials(string profileName, string profilesLocation)

#### Methods
- public static bool CanCreateFrom(string profileName, string profilesLocation)
- public override Amazon.Runtime.ImmutableCredentials GetCredentials()
- public static bool IsProfileKnown(string profileName, string profilesLocation)
- private static bool ValidCredentialsExistInSharedFile(string profilesLocation, string profileName)

### public class Amazon.Runtime.StoredProfileCredentials

#### Fields
- public static const string DefaultSharedCredentialFilename
- public static const string DefaultSharedCredentialLocation
- public static const string DEFAULT_PROFILE_NAME
- private static string[] PotentialEnvironmentPathsToCredentialsFile
- public static const string SHARED_CREDENTIALS_FILE_ENVVAR

#### Constructors
- protected StoredProfileCredentials()
- private static StoredProfileCredentials()

#### Methods
- public static Amazon.Runtime.AWSCredentials GetProfile(string profileName)
- public static Amazon.Runtime.AWSCredentials GetProfile(string profileName, string profileLocation)
- public static string ResolveSharedCredentialFileLocation(string profileLocation)
- private static string TestSharedCredentialFileExists(string pathOrFilename)

### public class Amazon.Runtime.StreamTransferProgressArgs
- Base: System.EventArgs

#### Fields
- private long _incrementTransferred
- private long _total
- private long _transferred

#### Properties
- public long IncrementTransferred { get; }
- public int PercentDone { get; }
- public long TotalBytes { get; }
- public long TransferredBytes { get; }

#### Constructors
- public StreamTransferProgressArgs(long incrementTransferred, long transferred, long total)

#### Methods
- public override string ToString()

### public class Amazon.Runtime.StringListParameterValue
- Base: Amazon.Runtime.ParameterValue

#### Fields
- private System.Collections.Generic.List<string> <Value>k__BackingField

#### Properties
- public System.Collections.Generic.List<string> Value { get; set; }

#### Constructors
- internal StringListParameterValue()
- public StringListParameterValue(System.Collections.Generic.List<string> values)

### public class Amazon.Runtime.StringParameterValue
- Base: Amazon.Runtime.ParameterValue

#### Fields
- private string <Value>k__BackingField

#### Properties
- public string Value { get; set; }

#### Constructors
- internal StringParameterValue()
- public StringParameterValue(string value)

### public class Amazon.Runtime.URIBasedRefreshingCredentialHelper
- Base: Amazon.Runtime.RefreshingAWSCredentials
- Interfaces: System.IDisposable

#### Fields
- private static string SuccessCode

#### Constructors
- public URIBasedRefreshingCredentialHelper()
- private static URIBasedRefreshingCredentialHelper()

#### Methods
- protected static string GetContents(System.Uri uri)
- protected static string GetContents(System.Uri uri, System.Net.IWebProxy proxy)
- protected static T GetObjectFromResponse<T>(System.Uri uri)
- protected static T GetObjectFromResponse<T>(System.Uri uri, System.Net.IWebProxy proxy)
- protected static void ValidateResponse(Amazon.Runtime.URIBasedRefreshingCredentialHelper.SecurityBase response)

### public class Amazon.Runtime.WebServiceExceptionEventArgs
- Base: Amazon.Runtime.ExceptionEventArgs

#### Fields
- private System.Uri <Endpoint>k__BackingField
- private System.Exception <Exception>k__BackingField
- private System.Collections.Generic.IDictionary<string, string> <Headers>k__BackingField
- private System.Collections.Generic.IDictionary<string, string> <Parameters>k__BackingField
- private Amazon.Runtime.AmazonWebServiceRequest <Request>k__BackingField
- private string <ServiceName>k__BackingField

#### Properties
- public System.Uri Endpoint { get; protected set; }
- public System.Exception Exception { get; protected set; }
- public System.Collections.Generic.IDictionary<string, string> Headers { get; protected set; }
- public System.Collections.Generic.IDictionary<string, string> Parameters { get; protected set; }
- public Amazon.Runtime.AmazonWebServiceRequest Request { get; protected set; }
- public string ServiceName { get; protected set; }

#### Constructors
- protected WebServiceExceptionEventArgs()

#### Methods
- internal static Amazon.Runtime.WebServiceExceptionEventArgs Create(System.Exception exception, Amazon.Runtime.Internal.IRequest request)

### public class Amazon.Runtime.WebServiceRequestEventArgs
- Base: Amazon.Runtime.RequestEventArgs

#### Fields
- private System.Uri <Endpoint>k__BackingField
- private System.Collections.Generic.IDictionary<string, string> <Headers>k__BackingField
- private Amazon.Runtime.Internal.ParameterCollection <ParameterCollection>k__BackingField
- private System.Collections.Generic.IDictionary<string, string> <Parameters>k__BackingField
- private Amazon.Runtime.AmazonWebServiceRequest <Request>k__BackingField
- private string <ServiceName>k__BackingField

#### Properties
- public System.Uri Endpoint { get; protected set; }
- public System.Collections.Generic.IDictionary<string, string> Headers { get; protected set; }
- public Amazon.Runtime.AmazonWebServiceRequest OriginalRequest { get; }
- public Amazon.Runtime.Internal.ParameterCollection ParameterCollection { get; protected set; }
- public System.Collections.Generic.IDictionary<string, string> Parameters { get; protected set; }
- public Amazon.Runtime.AmazonWebServiceRequest Request { get; protected set; }
- public string ServiceName { get; protected set; }

#### Constructors
- protected WebServiceRequestEventArgs()

#### Methods
- internal static Amazon.Runtime.WebServiceRequestEventArgs Create(Amazon.Runtime.Internal.IRequest request)

### public class Amazon.Runtime.WebServiceResponseEventArgs
- Base: Amazon.Runtime.ResponseEventArgs

#### Fields
- private System.Uri <Endpoint>k__BackingField
- private System.Collections.Generic.IDictionary<string, string> <Parameters>k__BackingField
- private Amazon.Runtime.AmazonWebServiceRequest <Request>k__BackingField
- private System.Collections.Generic.IDictionary<string, string> <RequestHeaders>k__BackingField
- private Amazon.Runtime.AmazonWebServiceResponse <Response>k__BackingField
- private System.Collections.Generic.IDictionary<string, string> <ResponseHeaders>k__BackingField
- private string <ServiceName>k__BackingField

#### Properties
- public System.Uri Endpoint { get; private set; }
- public System.Collections.Generic.IDictionary<string, string> Parameters { get; private set; }
- public Amazon.Runtime.AmazonWebServiceRequest Request { get; private set; }
- public System.Collections.Generic.IDictionary<string, string> RequestHeaders { get; private set; }
- public Amazon.Runtime.AmazonWebServiceResponse Response { get; private set; }
- public System.Collections.Generic.IDictionary<string, string> ResponseHeaders { get; private set; }
- public string ServiceName { get; private set; }

#### Constructors
- protected WebServiceResponseEventArgs()

#### Methods
- internal static Amazon.Runtime.WebServiceResponseEventArgs Create(Amazon.Runtime.AmazonWebServiceResponse response, Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.Internal.Transform.IWebResponseData webResponseData)

## Namespace: Amazon.Runtime.CredentialManagement

### private class Amazon.Runtime.CredentialManagement.CredentialProfile.<>c

#### Fields
- public static readonly Amazon.Runtime.CredentialManagement.CredentialProfile.<>c <>9
- public static System.Func<System.Collections.Generic.KeyValuePair<string, string>, string> <>9__39_0
- public static System.Func<System.Collections.Generic.KeyValuePair<string, string>, string> <>9__39_1

#### Constructors
- private static CredentialProfile.<>c()
- public CredentialProfile.<>c()

#### Methods
- internal string <GetPropertiesString>b__39_0(System.Collections.Generic.KeyValuePair<string, string> p)
- internal string <GetPropertiesString>b__39_1(System.Collections.Generic.KeyValuePair<string, string> p)

### private class Amazon.Runtime.CredentialManagement.NetSDKCredentialsFile.<>c

#### Fields
- public static readonly Amazon.Runtime.CredentialManagement.NetSDKCredentialsFile.<>c <>9
- public static System.Func<Amazon.Runtime.CredentialManagement.CredentialProfile, string> <>9__9_0

#### Constructors
- private static NetSDKCredentialsFile.<>c()
- public NetSDKCredentialsFile.<>c()

#### Methods
- internal string <ListProfileNames>b__9_0(Amazon.Runtime.CredentialManagement.CredentialProfile p)

### private class Amazon.Runtime.CredentialManagement.SharedCredentialsFile.<>c

#### Fields
- public static readonly Amazon.Runtime.CredentialManagement.SharedCredentialsFile.<>c <>9
- public static System.Func<Amazon.Runtime.CredentialManagement.CredentialProfile, string> <>9__24_0

#### Constructors
- private static SharedCredentialsFile.<>c()
- public SharedCredentialsFile.<>c()

#### Methods
- internal string <ListProfileNames>b__24_0(Amazon.Runtime.CredentialManagement.CredentialProfile p)

### public static class Amazon.Runtime.CredentialManagement.AWSCredentialsFactory

#### Fields
- private static System.Collections.Generic.HashSet<Amazon.Runtime.CredentialManagement.Internal.CredentialProfileType> CallbackProfileTypes
- private static const string RoleSessionNamePrefix

#### Constructors
- private static AWSCredentialsFactory()

#### Methods
- public static Amazon.Runtime.AWSCredentials GetAWSCredentials(Amazon.Runtime.CredentialManagement.CredentialProfile profile, Amazon.Runtime.CredentialManagement.ICredentialProfileSource profileSource)
- public static Amazon.Runtime.AWSCredentials GetAWSCredentials(Amazon.Runtime.CredentialManagement.CredentialProfileOptions options, Amazon.Runtime.CredentialManagement.ICredentialProfileSource profileSource)
- public static Amazon.Runtime.AWSCredentials GetAWSCredentials(Amazon.Runtime.CredentialManagement.CredentialProfile profile, Amazon.Runtime.CredentialManagement.ICredentialProfileSource profileSource, bool nonCallbackOnly)
- public static Amazon.Runtime.AWSCredentials GetAWSCredentials(Amazon.Runtime.CredentialManagement.CredentialProfileOptions options, Amazon.Runtime.CredentialManagement.ICredentialProfileSource profileSource, bool nonCallbackOnly)
- private static Amazon.Runtime.AWSCredentials GetAWSCredentials(string profileName, Amazon.Runtime.CredentialManagement.ICredentialProfileSource profileSource, Amazon.Runtime.CredentialManagement.CredentialProfileOptions options, Amazon.RegionEndpoint stsRegion, bool nonCallbackOnly)
- private static Amazon.Runtime.AWSCredentials GetAWSCredentialsInternal(string profileName, System.Nullable<Amazon.Runtime.CredentialManagement.Internal.CredentialProfileType> profileType, Amazon.Runtime.CredentialManagement.CredentialProfileOptions options, Amazon.RegionEndpoint stsRegion, Amazon.Runtime.CredentialManagement.ICredentialProfileSource profileSource, bool throwIfInvalid, System.Collections.Generic.HashSet<string> profileLoopAvoidance = null)
- private static Amazon.Runtime.AWSCredentials GetCredentialSourceAWSCredentials(string credentialSourceType, bool throwIfInvalid)
- private static Amazon.Runtime.AWSCredentials GetSourceAWSCredentials(string sourceProfileName, Amazon.Runtime.CredentialManagement.ICredentialProfileSource profileSource, bool throwIfInvalid, System.Collections.Generic.HashSet<string> profileLoopAvoidance = null)
- internal static bool IsCallbackRequired(System.Nullable<Amazon.Runtime.CredentialManagement.Internal.CredentialProfileType> profileType)
- private static Amazon.Runtime.BasicAWSCredentials ThrowInvalidOrReturnNull(string profileName, bool doThrow)
- private static Amazon.Runtime.BasicAWSCredentials ThrowOrReturnNull(string message, System.Exception innerException, bool doThrow)
- public static bool TryGetAWSCredentials(Amazon.Runtime.CredentialManagement.CredentialProfile profile, Amazon.Runtime.CredentialManagement.ICredentialProfileSource profileSource, out Amazon.Runtime.AWSCredentials credentials)
- public static bool TryGetAWSCredentials(Amazon.Runtime.CredentialManagement.CredentialProfileOptions options, Amazon.Runtime.CredentialManagement.ICredentialProfileSource profileSource, out Amazon.Runtime.AWSCredentials credentials)

### public class Amazon.Runtime.CredentialManagement.CredentialProfile

#### Fields
- private Amazon.Runtime.CredentialManagement.ICredentialProfileStore <CredentialProfileStore>k__BackingField
- private System.Nullable<bool> <EndpointDiscoveryEnabled>k__BackingField
- private string <Name>k__BackingField
- private Amazon.Runtime.CredentialManagement.CredentialProfileOptions <Options>k__BackingField
- private Amazon.RegionEndpoint <Region>k__BackingField
- private System.Nullable<System.Guid> <UniqueKey>k__BackingField
- private System.Collections.Generic.Dictionary<string, string> _properties

#### Properties
- public bool CanCreateAWSCredentials { get; }
- public string CredentialDescription { get; }
- public Amazon.Runtime.CredentialManagement.ICredentialProfileStore CredentialProfileStore { get; internal set; }
- public System.Nullable<bool> EndpointDiscoveryEnabled { get; set; }
- internal bool IsCallbackRequired { get; }
- public string Name { get; private set; }
- public Amazon.Runtime.CredentialManagement.CredentialProfileOptions Options { get; private set; }
- internal System.Nullable<Amazon.Runtime.CredentialManagement.Internal.CredentialProfileType> ProfileType { get; }
- internal System.Collections.Generic.Dictionary<string, string> Properties { get; set; }
- public Amazon.RegionEndpoint Region { get; set; }
- internal System.Nullable<System.Guid> UniqueKey { get; set; }

#### Constructors
- public CredentialProfile(string name, Amazon.Runtime.CredentialManagement.CredentialProfileOptions profileOptions)

#### Methods
- public override bool Equals(object obj)
- public Amazon.Runtime.AWSCredentials GetAWSCredentials(Amazon.Runtime.CredentialManagement.ICredentialProfileSource profileSource)
- internal Amazon.Runtime.AWSCredentials GetAWSCredentials(Amazon.Runtime.CredentialManagement.ICredentialProfileSource profileSource, bool nonCallbackOnly)
- public override int GetHashCode()
- private string GetPropertiesString()
- public override string ToString()

### public class Amazon.Runtime.CredentialManagement.CredentialProfileOptions

#### Fields
- private string <AccessKey>k__BackingField
- private string <CredentialProcess>k__BackingField
- private string <CredentialSource>k__BackingField
- private string <EndpointName>k__BackingField
- private string <ExternalID>k__BackingField
- private string <MfaSerial>k__BackingField
- private string <RoleArn>k__BackingField
- private string <SecretKey>k__BackingField
- private string <SourceProfile>k__BackingField
- private string <Token>k__BackingField
- private string <UserIdentity>k__BackingField

#### Properties
- public string AccessKey { get; set; }
- public string CredentialProcess { get; set; }
- public string CredentialSource { get; set; }
- public string EndpointName { get; set; }
- public string ExternalID { get; set; }
- internal bool IsEmpty { get; }
- public string MfaSerial { get; set; }
- public string RoleArn { get; set; }
- public string SecretKey { get; set; }
- public string SourceProfile { get; set; }
- public string Token { get; set; }
- public string UserIdentity { get; set; }

#### Constructors
- public CredentialProfileOptions()

#### Methods
- public override bool Equals(object obj)
- public override int GetHashCode()
- public override string ToString()

### public class Amazon.Runtime.CredentialManagement.CredentialProfileStoreChain
- Interfaces: Amazon.Runtime.CredentialManagement.ICredentialProfileSource

#### Fields
- private string <ProfilesLocation>k__BackingField

#### Properties
- public string ProfilesLocation { get; private set; }

#### Constructors
- public CredentialProfileStoreChain()
- public CredentialProfileStoreChain(string profilesLocation)

#### Methods
- public System.Collections.Generic.List<Amazon.Runtime.CredentialManagement.CredentialProfile> ListProfiles()
- public void RegisterProfile(Amazon.Runtime.CredentialManagement.CredentialProfile profile)
- public bool TryGetAWSCredentials(string profileName, out Amazon.Runtime.AWSCredentials credentials)
- public bool TryGetProfile(string profileName, out Amazon.Runtime.CredentialManagement.CredentialProfile profile)
- public void UnregisterProfile(string profileName)

### public interface Amazon.Runtime.CredentialManagement.ICredentialProfileSource

#### Methods
- public bool TryGetProfile(string profileName, out Amazon.Runtime.CredentialManagement.CredentialProfile profile)

### public interface Amazon.Runtime.CredentialManagement.ICredentialProfileStore
- Interfaces: Amazon.Runtime.CredentialManagement.ICredentialProfileSource

#### Methods
- public void CopyProfile(string fromProfileName, string toProfileName)
- public void CopyProfile(string fromProfileName, string toProfileName, bool force)
- public System.Collections.Generic.List<string> ListProfileNames()
- public System.Collections.Generic.List<Amazon.Runtime.CredentialManagement.CredentialProfile> ListProfiles()
- public void RegisterProfile(Amazon.Runtime.CredentialManagement.CredentialProfile profile)
- public void RenameProfile(string oldProfileName, string newProfileName)
- public void RenameProfile(string oldProfileName, string newProfileName, bool force)
- public void UnregisterProfile(string profileName)

### public class Amazon.Runtime.CredentialManagement.NetSDKCredentialsFile
- Interfaces: Amazon.Runtime.CredentialManagement.ICredentialProfileStore, Amazon.Runtime.CredentialManagement.ICredentialProfileSource

#### Fields
- private static const string AWSCredentialsProfileType
- public static const string DefaultProfileName
- private static const string EndpointDiscoveryEnabledField
- private static readonly Amazon.Runtime.CredentialManagement.Internal.CredentialProfilePropertyMapping PropertyMapping
- private static const string RegionField
- private static readonly System.Collections.Generic.HashSet<string> ReservedPropertyNames
- private static const string SAMLRoleProfileType
- private readonly Amazon.Util.Internal.NamedSettingsManager _settingsManager

#### Constructors
- public NetSDKCredentialsFile()
- private static NetSDKCredentialsFile()

#### Methods
- public void CopyProfile(string fromProfileName, string toProfileName)
- public void CopyProfile(string fromProfileName, string toProfileName, bool force)
- public System.Collections.Generic.List<string> ListProfileNames()
- public System.Collections.Generic.List<Amazon.Runtime.CredentialManagement.CredentialProfile> ListProfiles()
- public void RegisterProfile(Amazon.Runtime.CredentialManagement.CredentialProfile profile)
- public void RenameProfile(string oldProfileName, string newProfileName)
- public void RenameProfile(string oldProfileName, string newProfileName, bool force)
- private static void SetProfileTypeField(System.Collections.Generic.IDictionary<string, string> properties, Amazon.Runtime.CredentialManagement.Internal.CredentialProfileType profileType)
- public bool TryGetProfile(string profileName, out Amazon.Runtime.CredentialManagement.CredentialProfile profile)
- public void UnregisterProfile(string profileName)

### public enum Amazon.Runtime.CredentialManagement.SAMLAuthenticationType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Digest = 1
- Kerberos = 2
- Negotiate = 3
- NTLM = 0

### public class Amazon.Runtime.CredentialManagement.SAMLEndpoint

#### Fields
- private Amazon.Runtime.CredentialManagement.SAMLAuthenticationType <AuthenticationType>k__BackingField
- private System.Uri <EndpointUri>k__BackingField
- private string <Name>k__BackingField
- private Amazon.Runtime.CredentialManagement.SAMLAuthenticationType DefaultAuthenticationType

#### Properties
- public Amazon.Runtime.CredentialManagement.SAMLAuthenticationType AuthenticationType { get; private set; }
- public System.Uri EndpointUri { get; private set; }
- public string Name { get; private set; }

#### Constructors
- public SAMLEndpoint(string name, System.Uri endpointUri)
- internal SAMLEndpoint(string name, string endpointUri, string authenticationType)
- public SAMLEndpoint(string name, System.Uri endpointUri, Amazon.Runtime.CredentialManagement.SAMLAuthenticationType authenticationType)

#### Methods
- private void SetProperties(string name, System.Uri endpointUri, Amazon.Runtime.CredentialManagement.SAMLAuthenticationType authenticationType)

### public class Amazon.Runtime.CredentialManagement.SAMLEndpointManager

#### Fields
- private Amazon.Util.Internal.NamedSettingsManager settingsManager

#### Properties
- public static bool IsAvailable { get; }

#### Constructors
- public SAMLEndpointManager()

#### Methods
- public Amazon.Runtime.CredentialManagement.SAMLEndpoint GetEndpoint(string endpointName)
- public System.Collections.Generic.List<string> ListEndpointNames()
- public System.Collections.Generic.List<Amazon.Runtime.CredentialManagement.SAMLEndpoint> ListEndpoints()
- public void RegisterEndpoint(Amazon.Runtime.CredentialManagement.SAMLEndpoint samlEndpoint)
- public bool TryGetEndpoint(string endpointName, out Amazon.Runtime.CredentialManagement.SAMLEndpoint samlEndpoint)
- public void UnregisterEndpoint(string endpointName)

### public class Amazon.Runtime.CredentialManagement.SharedCredentialsFile
- Interfaces: Amazon.Runtime.CredentialManagement.ICredentialProfileStore, Amazon.Runtime.CredentialManagement.ICredentialProfileSource

#### Fields
- private string <FilePath>k__BackingField
- private static const string ConfigFileName
- private static const string CredentialProcess
- public static readonly string DefaultDirectory
- private static const string DefaultDirectoryName
- private static const string DefaultFileName
- public static readonly string DefaultFilePath
- public static const string DefaultProfileName
- private static const string EndpointDiscoveryEnabledField
- private static readonly System.Collections.Generic.HashSet<Amazon.Runtime.CredentialManagement.Internal.CredentialProfileType> ProfileTypeWhitelist
- private static readonly Amazon.Runtime.CredentialManagement.Internal.CredentialProfilePropertyMapping PropertyMapping
- private static const string RegionField
- private static readonly System.Collections.Generic.HashSet<string> ReservedPropertyNames
- private static const string ToolkitArtifactGuidField
- private Amazon.Runtime.Internal.Util.ProfileIniFile _configFile
- private Amazon.Runtime.Internal.Util.ProfileIniFile _credentialsFile
- private readonly Amazon.Runtime.Internal.Util.Logger _logger

#### Properties
- public string FilePath { get; private set; }

#### Constructors
- private static SharedCredentialsFile()
- public SharedCredentialsFile()
- public SharedCredentialsFile(string filePath)

#### Methods
- public void CopyProfile(string fromProfileName, string toProfileName)
- public void CopyProfile(string fromProfileName, string toProfileName, bool force)
- private static bool IsSupportedProfileType(System.Nullable<Amazon.Runtime.CredentialManagement.Internal.CredentialProfileType> profileType)
- private System.Collections.Generic.HashSet<string> ListAllProfileNames()
- public System.Collections.Generic.List<string> ListProfileNames()
- public System.Collections.Generic.List<Amazon.Runtime.CredentialManagement.CredentialProfile> ListProfiles()
- private void Refresh()
- public void RegisterProfile(Amazon.Runtime.CredentialManagement.CredentialProfile profile)
- private void RegisterProfileInternal(Amazon.Runtime.CredentialManagement.CredentialProfile profile)
- public void RenameProfile(string oldProfileName, string newProfileName)
- public void RenameProfile(string oldProfileName, string newProfileName, bool force)
- private void SetUpFilePath(string filePath)
- public bool TryGetProfile(string profileName, out Amazon.Runtime.CredentialManagement.CredentialProfile profile)
- private bool TryGetProfile(string profileName, bool doRefresh, out Amazon.Runtime.CredentialManagement.CredentialProfile profile)
- private bool TryGetSection(string sectionName, out System.Collections.Generic.Dictionary<string, string> iniProperties)
- public void UnregisterProfile(string profileName)

## Namespace: Amazon.Runtime.CredentialManagement.Internal

### private class Amazon.Runtime.CredentialManagement.Internal.CredentialProfilePropertyMapping.<>c

#### Fields
- public static readonly Amazon.Runtime.CredentialManagement.Internal.CredentialProfilePropertyMapping.<>c <>9
- public static System.Func<System.Reflection.PropertyInfo, string> <>9__10_0
- public static System.Func<string, bool> <>9__4_0

#### Constructors
- private static CredentialProfilePropertyMapping.<>c()
- public CredentialProfilePropertyMapping.<>c()

#### Methods
- internal string <.cctor>b__11_0(System.Reflection.PropertyInfo p)
- internal bool <.ctor>b__4_0(string v)
- internal string <Convert>b__10_0(System.Reflection.PropertyInfo p)

### public class Amazon.Runtime.CredentialManagement.Internal.CredentialProfilePropertyMapping

#### Fields
- private static readonly System.Reflection.PropertyInfo[] CredentialProfileReflectionProperties
- private static readonly System.Collections.Generic.HashSet<string> TypePropertySet
- private readonly System.Collections.Generic.HashSet<string> _mappedNames
- private readonly System.Collections.Generic.Dictionary<string, string> _nameMapping

#### Constructors
- private static CredentialProfilePropertyMapping()
- public CredentialProfilePropertyMapping(System.Collections.Generic.Dictionary<string, string> nameMapping)

#### Methods
- public System.Collections.Generic.Dictionary<string, string> CombineProfileParts(Amazon.Runtime.CredentialManagement.CredentialProfileOptions profileOptions, System.Collections.Generic.HashSet<string> reservedPropertyNames, System.Collections.Generic.Dictionary<string, string> reservedProperties, System.Collections.Generic.Dictionary<string, string> userProperties)
- private System.Collections.Generic.Dictionary<string, string> Convert(Amazon.Runtime.CredentialManagement.CredentialProfileOptions profileOptions)
- public void ExtractProfileParts(System.Collections.Generic.Dictionary<string, string> profileDictionary, System.Collections.Generic.HashSet<string> reservedKeys, out Amazon.Runtime.CredentialManagement.CredentialProfileOptions profileOptions, out System.Collections.Generic.Dictionary<string, string> userProperties)
- public void ExtractProfileParts(System.Collections.Generic.Dictionary<string, string> profileDictionary, System.Collections.Generic.HashSet<string> reservedKeys, out Amazon.Runtime.CredentialManagement.CredentialProfileOptions profileOptions, out System.Collections.Generic.Dictionary<string, string> reservedProperties, out System.Collections.Generic.Dictionary<string, string> userProperties)
- private void ValidateNoProfileOptionsProperties(System.Collections.Generic.Dictionary<string, string> userProperties)
- private static void ValidateNoReservedProperties(System.Collections.Generic.HashSet<string> reservedPropertyNames, System.Collections.Generic.Dictionary<string, string> userProperties)

### public enum Amazon.Runtime.CredentialManagement.Internal.CredentialProfileType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AssumeRole = 0
- AssumeRoleCredentialSource = 1
- AssumeRoleExternal = 2
- AssumeRoleExternalMFA = 3
- AssumeRoleMFA = 4
- Basic = 5
- CredentialProcess = 9
- SAMLRole = 6
- SAMLRoleUserIdentity = 7
- Session = 8

### public static class Amazon.Runtime.CredentialManagement.Internal.CredentialProfileTypeDetector

#### Fields
- private static const string AccessKey
- private static const string AssumeRoleCredentials
- private static const string BasicCredentials
- private static const string CredentialProcess
- private static const string CredentialSource
- private static System.Collections.Generic.Dictionary<Amazon.Runtime.CredentialManagement.Internal.CredentialProfileType, string> CredentialTypeDictionary
- private static const string EndpointName
- private static const string ExternalID
- private static const string MfaSerial
- private static const string RoleArn
- private static const string SAMLCredentials
- private static const string SecretKey
- private static const string SessionCredentials
- private static const string SourceProfile
- private static const string Token
- private static System.Collections.Generic.Dictionary<Amazon.Runtime.CredentialManagement.Internal.CredentialProfileType, System.Collections.Generic.HashSet<string>> TypePropertyDictionary
- private static const string UserIdentity

#### Constructors
- private static CredentialProfileTypeDetector()

#### Methods
- public static System.Nullable<Amazon.Runtime.CredentialManagement.Internal.CredentialProfileType> DetectProfileType(Amazon.Runtime.CredentialManagement.CredentialProfileOptions profileOptions)
- public static System.Collections.Generic.HashSet<string> GetPropertiesForProfileType(Amazon.Runtime.CredentialManagement.Internal.CredentialProfileType profileType)
- private static System.Collections.Generic.HashSet<string> GetPropertyNames(Amazon.Runtime.CredentialManagement.CredentialProfileOptions profileOptions)
- public static string GetUserFriendlyCredentialType(System.Nullable<Amazon.Runtime.CredentialManagement.Internal.CredentialProfileType> profileType)

### public static class Amazon.Runtime.CredentialManagement.Internal.CredentialProfileUtils

#### Methods
- public static System.Guid EnsureUniqueKeyAssigned(Amazon.Runtime.CredentialManagement.CredentialProfile profile, Amazon.Runtime.CredentialManagement.ICredentialProfileStore profileStore)
- public static System.Nullable<Amazon.Runtime.CredentialManagement.Internal.CredentialProfileType> GetProfileType(Amazon.Runtime.CredentialManagement.CredentialProfile profile)
- public static System.Collections.Generic.Dictionary<string, string> GetProperties(Amazon.Runtime.CredentialManagement.CredentialProfile profile)
- public static string GetProperty(Amazon.Runtime.CredentialManagement.CredentialProfile profile, string key)
- public static string GetUniqueKey(Amazon.Runtime.CredentialManagement.CredentialProfile profile)
- public static bool IsCallbackRequired(Amazon.Runtime.CredentialManagement.CredentialProfile profile)
- public static void SetProperty(Amazon.Runtime.CredentialManagement.CredentialProfile profile, string key, string value)
- public static void SetUniqueKey(Amazon.Runtime.CredentialManagement.CredentialProfile profile, System.Nullable<System.Guid> uniqueKey)

### public enum Amazon.Runtime.CredentialManagement.Internal.CredentialSourceType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Ec2InstanceMetadata = 0
- EcsContainer = 2
- Environment = 1

### public class Amazon.Runtime.CredentialManagement.Internal.SAMLRoleSessionManager

#### Fields
- private Amazon.Util.Internal.SettingsManager settingsManager

#### Properties
- public static bool IsAvailable { get; }

#### Constructors
- public SAMLRoleSessionManager()

#### Methods
- public void Clear()
- public void RegisterRoleSession(string roleSessionName, Amazon.Runtime.SAMLImmutableCredentials credentials)
- public bool TryGetRoleSession(string roleSessionName, out Amazon.Runtime.SAMLImmutableCredentials credentials)
- public void UnregisterRoleSession(string roleSessionName)

## Namespace: Amazon.Runtime.EventStreams

### public class Amazon.Runtime.EventStreams.EventStreamChecksumFailureException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public EventStreamChecksumFailureException(string message)

### public class Amazon.Runtime.EventStreams.EventStreamErrorCodeException
- Base: Amazon.Runtime.EventStreams.Internal.EventStreamException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Properties
- public int ErrorCode { get; private set; }

#### Constructors
- public EventStreamErrorCodeException(int errorCode)
- public EventStreamErrorCodeException(int errorCode, string message)

### public class Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<T>
- Base: System.EventArgs

#### Fields
- private readonly T <EventStreamEvent>k__BackingField

#### Properties
- public T EventStreamEvent { get; }

#### Constructors
- public EventStreamEventReceivedArgs<T>(T eventStreamEvent)

### public class Amazon.Runtime.EventStreams.EventStreamExceptionReceivedArgs<T>
- Base: System.EventArgs

#### Fields
- private readonly T <EventStreamException>k__BackingField

#### Properties
- public T EventStreamException { get; }

#### Constructors
- public EventStreamExceptionReceivedArgs<T>(T eventStreamException)

### public class Amazon.Runtime.EventStreams.EventStreamHeader
- Interfaces: Amazon.Runtime.EventStreams.IEventStreamHeader

#### Fields
- private Amazon.Runtime.EventStreams.EventStreamHeaderType <HeaderType>k__BackingField
- private object <HeaderValue>k__BackingField
- private readonly string <Name>k__BackingField
- private static const int _sizeOfByte
- private static const int _sizeOfGuid
- private static const int _sizeOfInt16
- private static const int _sizeOfInt32
- private static const int _sizeOfInt64
- private static readonly System.DateTime _unixEpoch

#### Properties
- public Amazon.Runtime.EventStreams.EventStreamHeaderType HeaderType { get; set; }
- private object HeaderValue { get; set; }
- public string Name { get; }

#### Constructors
- private static EventStreamHeader()
- public EventStreamHeader(string name)

#### Methods
- public bool AsBool()
- public byte AsByte()
- public byte[] AsByteBuf()
- public short AsInt16()
- public int AsInt32()
- public long AsInt64()
- public string AsString()
- public System.DateTime AsTimestamp()
- public System.Guid AsUUID()
- public static Amazon.Runtime.EventStreams.EventStreamHeader FromBuffer(byte[] buffer, int offset, ref int newOffset)
- public int GetWireSize()
- public void SetBool(bool value)
- public void SetByte(byte value)
- public void SetByteBuf(byte[] value)
- public void SetInt16(short value)
- public void SetInt32(int value)
- public void SetInt64(long value)
- public void SetString(string value)
- public void SetTimestamp(System.DateTime value)
- public void SetUUID(System.Guid value)
- public int WriteToBuffer(byte[] buffer, int offset)

### public enum Amazon.Runtime.EventStreams.EventStreamHeaderType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BoolFalse = 1
- BoolTrue = 0
- Byte = 2
- ByteBuf = 6
- Int16 = 3
- Int32 = 4
- Int64 = 5
- String = 7
- Timestamp = 8
- UUID = 9

### public class Amazon.Runtime.EventStreams.EventStreamMessage
- Interfaces: Amazon.Runtime.EventStreams.IEventStreamMessage

#### Fields
- private System.Collections.Generic.Dictionary<string, Amazon.Runtime.EventStreams.IEventStreamHeader> <Headers>k__BackingField
- private byte[] <Payload>k__BackingField
- public static const string ContentType
- internal static const int FramingSize
- internal static const int PreludeLen
- internal static const int SizeOfInt32
- internal static const int TrailerLen

#### Properties
- public System.Collections.Generic.Dictionary<string, Amazon.Runtime.EventStreams.IEventStreamHeader> Headers { get; set; }
- public byte[] Payload { get; set; }

#### Constructors
- private EventStreamMessage()
- public EventStreamMessage(System.Collections.Generic.List<Amazon.Runtime.EventStreams.IEventStreamHeader> headers, byte[] payload)

#### Methods
- public static Amazon.Runtime.EventStreams.EventStreamMessage FromBuffer(byte[] buffer, int offset, int length)
- public byte[] ToByteArray()

### public class Amazon.Runtime.EventStreams.EventStreamParseException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public EventStreamParseException(string message)

### public class Amazon.Runtime.EventStreams.EventStreamValidationException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public EventStreamValidationException()
- public EventStreamValidationException(string message)
- public EventStreamValidationException(string message, System.Exception innerException)

### public interface Amazon.Runtime.EventStreams.IEventStreamHeader

#### Properties
- public Amazon.Runtime.EventStreams.EventStreamHeaderType HeaderType { get; }
- public string Name { get; }

#### Methods
- public bool AsBool()
- public byte AsByte()
- public byte[] AsByteBuf()
- public short AsInt16()
- public int AsInt32()
- public long AsInt64()
- public string AsString()
- public System.DateTime AsTimestamp()
- public System.Guid AsUUID()
- public int GetWireSize()
- public void SetBool(bool value)
- public void SetByte(byte value)
- public void SetByteBuf(byte[] value)
- public void SetInt16(short value)
- public void SetInt32(int value)
- public void SetInt64(long value)
- public void SetString(string value)
- public void SetTimestamp(System.DateTime value)
- public void SetUUID(System.Guid value)
- public int WriteToBuffer(byte[] buffer, int offset)

### public interface Amazon.Runtime.EventStreams.IEventStreamMessage

#### Properties
- public System.Collections.Generic.Dictionary<string, Amazon.Runtime.EventStreams.IEventStreamHeader> Headers { get; set; }
- public byte[] Payload { get; set; }

#### Methods
- public byte[] ToByteArray()

### public class Amazon.Runtime.EventStreams.UnknownEventStreamException
- Base: Amazon.Runtime.EventStreams.Internal.EventStreamException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Properties
- public string ExceptionType { get; private set; }

#### Constructors
- public UnknownEventStreamException(string exceptionType)

### public class Amazon.Runtime.EventStreams.UnknownEventStreamMessageTypeException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public UnknownEventStreamMessageTypeException()

## Namespace: Amazon.Runtime.EventStreams.Internal

### private class Amazon.Runtime.EventStreams.Internal.EnumerableEventStream<T, TE>.<>c__DisplayClass7_0<T, TE>

#### Fields
- public System.Collections.Generic.Queue<T> events

#### Constructors
- public EnumerableEventStream<T, TE>.<>c__DisplayClass7_0<T, TE>()

#### Methods
- internal void <GetEnumerator>b__0(object sender, Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<T> args)

### private class Amazon.Runtime.EventStreams.Internal.EnumerableEventStream<T, TE>.<GetEnumerator>d__7<T, TE>
- Interfaces: System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private T <>2__current
- public Amazon.Runtime.EventStreams.Internal.EnumerableEventStream<T, TE> <>4__this
- private Amazon.Runtime.EventStreams.Internal.EnumerableEventStream<T, TE>.<>c__DisplayClass7_0<T, TE> <>8__1
- private byte[] <buffer>5__2

#### Properties
- private T System.Collections.Generic.IEnumerator<T>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public EnumerableEventStream<T, TE>.<GetEnumerator>d__7<T, TE>(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private enum Amazon.Runtime.EventStreams.Internal.EventStreamDecoder.DecoderState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Error = 4
- ProcessPrelude = 2
- ReadMessage = 3
- ReadPrelude = 1
- Start = 0

### public class Amazon.Runtime.EventStreams.Internal.EnumerableEventStream<T, TE>
- Base: Amazon.Runtime.EventStreams.Internal.EventStream<T, TE>
- Interfaces: Amazon.Runtime.EventStreams.Internal.IEventStream<T, TE>, System.IDisposable, Amazon.Runtime.EventStreams.Internal.IEnumerableEventStream<T, TE>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable

#### Fields
- private bool <IsEnumerated>k__BackingField
- private static const string MutuallyExclusiveExceptionMessage

#### Properties
- protected bool IsEnumerated { get; set; }

#### Constructors
- protected EnumerableEventStream<T, TE>(System.IO.Stream stream)
- protected EnumerableEventStream<T, TE>(System.IO.Stream stream, Amazon.Runtime.EventStreams.Internal.IEventStreamDecoder eventStreamDecoder)

#### Methods
- public System.Collections.Generic.IEnumerator<T> GetEnumerator()
- public override void StartProcessing()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()

### public class Amazon.Runtime.EventStreams.Internal.EventStreamDecoder
- Interfaces: Amazon.Runtime.EventStreams.Internal.IEventStreamDecoder, System.IDisposable

#### Fields
- private object <MessageReceivedContext>k__BackingField
- private bool disposedValue
- private System.EventHandler<Amazon.Runtime.EventStreams.Internal.EventStreamMessageReceivedEventArgs> MessageReceived
- private int _amountBytesRead
- private int _currentMessageLength
- private ThirdParty.Ionic.Zlib.CrcCalculatorStream _runningChecksumStream
- private Amazon.Runtime.EventStreams.Internal.EventStreamDecoder.DecoderState _state
- private Amazon.Runtime.EventStreams.Internal.EventStreamDecoder.ProcessRead[] _stateFns
- private byte[] _workingBuffer
- private byte[] _workingMessage

#### Properties
- public object MessageReceivedContext { get; set; }

#### Events
- public event System.EventHandler<Amazon.Runtime.EventStreams.Internal.EventStreamMessageReceivedEventArgs> MessageReceived

#### Constructors
- public EventStreamDecoder()

#### Methods
- protected virtual void Dispose(bool disposing)
- public void Dispose()
- private int Error(byte[] data, int offset, int length)
- public void ProcessData(byte[] data, int offset, int length)
- private void ProcessMessage()
- private int ProcessPrelude(byte[] data, int offset, int length)
- private int ReadMessage(byte[] data, int offset, int length)
- private int ReadPrelude(byte[] data, int offset, int length)
- private int Start(byte[] data, int offset, int length)

### public class Amazon.Runtime.EventStreams.Internal.EventStreamDecoderIllegalStateException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public EventStreamDecoderIllegalStateException(string message)

### public class Amazon.Runtime.EventStreams.Internal.EventStreamException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- protected EventStreamException()
- protected EventStreamException(string message)
- protected EventStreamException(string message, System.Exception innerException)

### public class Amazon.Runtime.EventStreams.Internal.EventStreamMessageReceivedEventArgs
- Base: System.EventArgs

#### Fields
- private object <Context>k__BackingField
- private Amazon.Runtime.EventStreams.EventStreamMessage <Message>k__BackingField

#### Properties
- public object Context { get; private set; }
- public Amazon.Runtime.EventStreams.EventStreamMessage Message { get; private set; }

#### Constructors
- public EventStreamMessageReceivedEventArgs(Amazon.Runtime.EventStreams.EventStreamMessage message)
- public EventStreamMessageReceivedEventArgs(Amazon.Runtime.EventStreams.EventStreamMessage message, object context)

### public class Amazon.Runtime.EventStreams.Internal.EventStream<T, TE>
- Interfaces: Amazon.Runtime.EventStreams.Internal.IEventStream<T, TE>, System.IDisposable

#### Fields
- private int <BufferSize>k__BackingField
- private readonly Amazon.Runtime.EventStreams.Internal.IEventStreamDecoder <Decoder>k__BackingField
- private readonly System.IO.Stream <NetworkStream>k__BackingField
- private static const string ErrorHeaderMessageTypeValue
- private static const string EventHeaderMessageTypeValue
- private System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<T>> EventReceived
- private static const string ExceptionHeaderMessageTypeValue
- private System.EventHandler<Amazon.Runtime.EventStreams.EventStreamExceptionReceivedArgs<TE>> ExceptionReceived
- private static const string HeaderErrorCode
- private static const string HeaderErrorMessage
- private static const string HeaderEventType
- private static const string HeaderExceptionType
- private static const string HeaderMessageType
- protected static const string UnknownEventKey
- private static const string WrappedErrorMessage
- private bool _disposed

#### Properties
- public int BufferSize { get; set; }
- protected Amazon.Runtime.EventStreams.Internal.IEventStreamDecoder Decoder { get; }
- protected System.Collections.Generic.IDictionary<string, System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, T>> EventMapping { get; }
- protected System.Collections.Generic.IDictionary<string, System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, TE>> ExceptionMapping { get; }
- protected bool IsProcessing { get; set; }
- protected System.IO.Stream NetworkStream { get; }

#### Events
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<T>> EventReceived
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamExceptionReceivedArgs<TE>> ExceptionReceived

#### Constructors
- protected EventStream<T, TE>(System.IO.Stream stream)
- protected EventStream<T, TE>(System.IO.Stream stream, Amazon.Runtime.EventStreams.Internal.IEventStreamDecoder eventStreamDecoder)

#### Methods
- private void <Process>b__36_0()
- protected T ConvertMessageToEvent(Amazon.Runtime.EventStreams.EventStreamMessage eventStreamMessage)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- protected void Process()
- private void ProcessLoop()
- private void ProcessLoop(object state)
- protected void ReadFromStream(byte[] buffer)
- public virtual void StartProcessing()
- protected TE WrapException(System.Exception ex)

### public interface Amazon.Runtime.EventStreams.Internal.IEnumerableEventStream<T, TE>
- Interfaces: Amazon.Runtime.EventStreams.Internal.IEventStream<T, TE>, System.IDisposable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable

### public interface Amazon.Runtime.EventStreams.Internal.IEventStreamDecoder
- Interfaces: System.IDisposable

#### Events
- public event System.EventHandler<Amazon.Runtime.EventStreams.Internal.EventStreamMessageReceivedEventArgs> MessageReceived

#### Methods
- public void ProcessData(byte[] data, int offset, int length)

### public interface Amazon.Runtime.EventStreams.Internal.IEventStreamEvent

### public interface Amazon.Runtime.EventStreams.Internal.IEventStreamTerminalEvent
- Interfaces: Amazon.Runtime.EventStreams.Internal.IEventStreamEvent

### public interface Amazon.Runtime.EventStreams.Internal.IEventStream<T, TE>
- Interfaces: System.IDisposable

#### Properties
- public int BufferSize { get; set; }

#### Events
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamEventReceivedArgs<T>> EventReceived
- public event System.EventHandler<Amazon.Runtime.EventStreams.EventStreamExceptionReceivedArgs<TE>> ExceptionReceived

#### Methods
- public void StartProcessing()

### private delegate Amazon.Runtime.EventStreams.Internal.EventStreamDecoder.ProcessRead
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public EventStreamDecoder.ProcessRead(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(byte[] data, int offset, int length, System.AsyncCallback callback, object object)
- public virtual int EndInvoke(System.IAsyncResult result)
- public virtual int Invoke(byte[] data, int offset, int length)

### public class Amazon.Runtime.EventStreams.Internal.UnknownEventStreamEvent
- Interfaces: Amazon.Runtime.EventStreams.Internal.IEventStreamEvent

#### Fields
- private string <EventType>k__BackingField
- private Amazon.Runtime.EventStreams.IEventStreamMessage <ReceivedMessage>k__BackingField

#### Properties
- public string EventType { get; set; }
- public Amazon.Runtime.EventStreams.IEventStreamMessage ReceivedMessage { get; set; }

#### Constructors
- public UnknownEventStreamEvent()
- public UnknownEventStreamEvent(Amazon.Runtime.EventStreams.IEventStreamMessage receivedMessage, string eventType)

## Namespace: Amazon.Runtime.Internal

### private struct Amazon.Runtime.Internal.AsyncRunner.<>c__DisplayClass1_0<T>.<<Run>b__0>d<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.AsyncRunner.<>c__DisplayClass1_0<T> <>4__this
- private Amazon.Runtime.Internal.AsyncRunner.<>c__DisplayClass1_2<T> <>8__1
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private System.Threading.Thread <thread>5__2

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Amazon.Runtime.Internal.DefaultRequest.<>c

#### Fields
- public static readonly Amazon.Runtime.Internal.DefaultRequest.<>c <>9
- public static System.Func<System.IO.Stream, bool> <>9__68_0

#### Constructors
- private static DefaultRequest.<>c()
- public DefaultRequest.<>c()

#### Methods
- internal bool <ComputeContentStreamHash>b__68_0(System.IO.Stream s)

### private class Amazon.Runtime.Internal.AsyncRunner.<>c__DisplayClass0_0

#### Fields
- public System.Action action

#### Constructors
- public AsyncRunner.<>c__DisplayClass0_0()

#### Methods
- internal object <Run>b__0()

### private class Amazon.Runtime.Internal.ServiceClientHelpers.<>c__DisplayClass15_0

#### Fields
- public string assemblyName

#### Constructors
- public ServiceClientHelpers.<>c__DisplayClass15_0()

#### Methods
- internal bool <GetSDKAssembly>b__0(System.Reflection.Assembly x)

### private class Amazon.Runtime.Internal.AsyncRunner.<>c__DisplayClass1_0<T>

#### Fields
- public System.Func<T> action
- public System.Threading.CancellationToken cancellationToken

#### Constructors
- public AsyncRunner.<>c__DisplayClass1_0<T>()

#### Methods
- internal System.Threading.Tasks.Task<T> <Run>b__0()

### private class Amazon.Runtime.Internal.AsyncRunner.<>c__DisplayClass1_1<T>

#### Fields
- public Amazon.Runtime.Internal.AsyncRunner.<>c__DisplayClass1_0<T> CS$<>8__locals1
- public System.Exception exception
- public T result

#### Constructors
- public AsyncRunner.<>c__DisplayClass1_1<T>()

### private class Amazon.Runtime.Internal.AsyncRunner.<>c__DisplayClass1_2<T>

#### Fields
- public Amazon.Runtime.Internal.AsyncRunner.<>c__DisplayClass1_1<T> CS$<>8__locals2
- public System.Threading.SemaphoreSlim semaphore

#### Constructors
- public AsyncRunner.<>c__DisplayClass1_2<T>()

#### Methods
- internal void <Run>b__1()

### private class Amazon.Runtime.Internal.EndpointDiscoveryResolverBase.<>c__DisplayClass5_0

#### Fields
- public Amazon.Runtime.Internal.EndpointDiscoveryResolverBase <>4__this
- public string cacheKey
- public System.Func<System.Collections.Generic.IList<Amazon.Runtime.Internal.DiscoveryEndpointBase>> InvokeEndpointOperation

#### Constructors
- public EndpointDiscoveryResolverBase.<>c__DisplayClass5_0()

#### Methods
- internal void <ResolveEndpoints>b__0()
- internal void <ResolveEndpoints>b__1()

### private class Amazon.Runtime.Internal.RuntimePipelineCustomizerRegistry.<>c__DisplayClass7_0

#### Fields
- public Amazon.Runtime.Internal.IRuntimePipelineCustomizer customizer

#### Constructors
- public RuntimePipelineCustomizerRegistry.<>c__DisplayClass7_0()

#### Methods
- internal bool <Register>b__0(Amazon.Runtime.Internal.IRuntimePipelineCustomizer x)

### private struct Amazon.Runtime.Internal.HttpHandler<TRequestContent>.<CompleteFailedRequest>d__10<TRequestContent>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.Runtime.Internal.Transform.IWebResponseData> <>u__1
- private Amazon.Runtime.Internal.Transform.IWebResponseData <iwrd>5__2
- public Amazon.Runtime.IExecutionContext executionContext
- public Amazon.Runtime.IHttpRequest<TRequestContent> httpRequest

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Amazon.Runtime.Internal.RuntimePipeline.<EnumerateHandlers>d__21
- Interfaces: System.Collections.Generic.IEnumerable<Amazon.Runtime.IPipelineHandler>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Amazon.Runtime.IPipelineHandler>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private Amazon.Runtime.IPipelineHandler <>2__current
- public Amazon.Runtime.Internal.RuntimePipeline <>4__this
- private int <>l__initialThreadId
- private Amazon.Runtime.IPipelineHandler <handler>5__2

#### Properties
- private Amazon.Runtime.IPipelineHandler System.Collections.Generic.IEnumerator<Amazon.Runtime.IPipelineHandler>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public RuntimePipeline.<EnumerateHandlers>d__21(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<Amazon.Runtime.IPipelineHandler> System.Collections.Generic.IEnumerable<Amazon.Runtime.IPipelineHandler>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Amazon.Runtime.Internal.ParametersDictionaryFacade.<GetEnumerator>d__23
- Interfaces: System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Collections.Generic.KeyValuePair<string, string> <>2__current
- public Amazon.Runtime.Internal.ParametersDictionaryFacade <>4__this
- private System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator<string, Amazon.Runtime.ParameterValue> <>7__wrap1

#### Properties
- private System.Collections.Generic.KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public ParametersDictionaryFacade.<GetEnumerator>d__23(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Amazon.Runtime.Internal.ParameterCollection.<GetParametersEnumerable>d__4
- Interfaces: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Collections.Generic.KeyValuePair<string, string> <>2__current
- public Amazon.Runtime.Internal.ParameterCollection <>4__this
- private System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator<string, Amazon.Runtime.ParameterValue> <>7__wrap1
- private System.Collections.Generic.List<T>.Enumerator<string> <>7__wrap3
- private int <>l__initialThreadId
- private string <name>5__3

#### Properties
- private System.Collections.Generic.KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public ParameterCollection.<GetParametersEnumerable>d__4(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private void <>m__Finally2()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private struct Amazon.Runtime.Internal.RetryHandler.<InvokeAsync>d__10<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.RetryHandler <>4__this
- private Amazon.Runtime.Internal.Util.TimingEvent <>7__wrap4
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<bool> <>u__2
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__3
- private System.Runtime.ExceptionServices.ExceptionDispatchInfo <capturedException>5__4
- private Amazon.Runtime.IRequestContext <requestContext>5__2
- private bool <shouldRetry>5__3
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.Internal.MetricsHandler.<InvokeAsync>d__1<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.MetricsHandler <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__1
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.Internal.RedirectHandler.<InvokeAsync>d__1<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.RedirectHandler <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__1
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.Internal.CSMCallAttemptHandler.<InvokeAsync>d__1<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.CSMCallAttemptHandler <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__1
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.Internal.EndpointDiscoveryHandler.<InvokeAsync>d__2<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.EndpointDiscoveryHandler <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__1
- private System.Uri <regionalEndpoint>5__3
- private Amazon.Runtime.IRequestContext <requestContext>5__2
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.Internal.CSMCallEventHandler.<InvokeAsync>d__2<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.CSMCallEventHandler <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__1
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.Internal.Unmarshaller.<InvokeAsync>d__3<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.Unmarshaller <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.Internal.ErrorHandler.<InvokeAsync>d__5<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.ErrorHandler <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__1
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.Internal.ErrorCallbackHandler.<InvokeAsync>d__5<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.ErrorCallbackHandler <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__1
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.Internal.CredentialsRetriever.<InvokeAsync>d__7<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.CredentialsRetriever <>4__this
- private Amazon.Runtime.Internal.Util.TimingEvent <>7__wrap1
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.Runtime.ImmutableCredentials> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__2
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.Internal.CallbackHandler.<InvokeAsync>d__9<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.CallbackHandler <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<T> <>u__1
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.Internal.HttpHandler<TRequestContent>.<InvokeAsync>d__9<TRequestContent, T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.HttpHandler<TRequestContent> <>4__this
- private Amazon.Runtime.Internal.Util.TimingEvent <>7__wrap2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<TRequestContent> <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.Runtime.Internal.Transform.IWebResponseData> <>u__3
- private System.Runtime.ExceptionServices.ExceptionDispatchInfo <edi>5__4
- private Amazon.Runtime.IHttpRequest<TRequestContent> <httpRequest>5__2
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.Internal.Unmarshaller.<UnmarshallAsync>d__5
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.Unmarshaller <>4__this
- private Amazon.Runtime.Internal.Util.TimingEvent <>7__wrap3
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<System.IO.Stream> <>u__1
- private bool <readEntireResponse>5__6
- private Amazon.Runtime.IRequestContext <requestContext>5__2
- private Amazon.Runtime.IResponseContext <responseContext>5__3
- private Amazon.Runtime.Internal.Transform.ResponseUnmarshaller <unmarshaller>5__5
- public Amazon.Runtime.IExecutionContext executionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class Amazon.Runtime.Internal.AppConfigCSMConfigs

#### Constructors
- public AppConfigCSMConfigs(Amazon.Runtime.Internal.CSMFallbackConfigChain cSMFallbackConfigChain)

### public class Amazon.Runtime.Internal.AsyncExecutionContext
- Interfaces: Amazon.Runtime.IAsyncExecutionContext

#### Fields
- private Amazon.Runtime.IAsyncRequestContext <RequestContext>k__BackingField
- private Amazon.Runtime.IAsyncResponseContext <ResponseContext>k__BackingField
- private object <RuntimeState>k__BackingField

#### Properties
- public Amazon.Runtime.IAsyncRequestContext RequestContext { get; private set; }
- public Amazon.Runtime.IAsyncResponseContext ResponseContext { get; private set; }
- public object RuntimeState { get; set; }

#### Constructors
- public AsyncExecutionContext(bool enableMetrics, Amazon.Runtime.Internal.Auth.AbstractAWSSigner clientSigner)
- public AsyncExecutionContext(Amazon.Runtime.IAsyncRequestContext requestContext, Amazon.Runtime.IAsyncResponseContext responseContext)

### public class Amazon.Runtime.Internal.AsyncRequestContext
- Base: Amazon.Runtime.Internal.RequestContext
- Interfaces: Amazon.Runtime.IRequestContext, Amazon.Runtime.IAsyncRequestContext

#### Fields
- private System.AsyncCallback <Callback>k__BackingField
- private object <State>k__BackingField

#### Properties
- public System.AsyncCallback Callback { get; set; }
- public object State { get; set; }

#### Constructors
- public AsyncRequestContext(bool enableMetrics, Amazon.Runtime.Internal.Auth.AbstractAWSSigner clientSigner)

### public class Amazon.Runtime.Internal.AsyncResponseContext
- Base: Amazon.Runtime.Internal.ResponseContext
- Interfaces: Amazon.Runtime.IResponseContext, Amazon.Runtime.IAsyncResponseContext

#### Constructors
- public AsyncResponseContext()

### public static class Amazon.Runtime.Internal.AsyncRunner

#### Methods
- public static System.Threading.Tasks.Task Run(System.Action action, System.Threading.CancellationToken cancellationToken)
- public static System.Threading.Tasks.Task<T> Run<T>(System.Func<T> action, System.Threading.CancellationToken cancellationToken)

### public class Amazon.Runtime.Internal.AutoConstructedDictionary<K, V>
- Base: System.Collections.Generic.Dictionary<K, V>
- Interfaces: System.Collections.Generic.IDictionary<K, V>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K, V>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K, V>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary<K, V>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<K, V>>, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback

#### Constructors
- public AutoConstructedDictionary<K, V>()

### public class Amazon.Runtime.Internal.AutoConstructedList<T>
- Base: System.Collections.Generic.List<T>
- Interfaces: System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IReadOnlyCollection<T>

#### Constructors
- public AutoConstructedList<T>()

### public class Amazon.Runtime.Internal.AWSPropertyAttribute
- Base: System.Attribute

#### Fields
- private bool <IsMaxSet>k__BackingField
- private bool <IsMinSet>k__BackingField
- private bool <Required>k__BackingField
- private long max
- private long min

#### Properties
- public bool IsMaxSet { get; private set; }
- public bool IsMinSet { get; private set; }
- public long Max { get; set; }
- public long Min { get; set; }
- public bool Required { get; set; }

#### Constructors
- public AWSPropertyAttribute()

### public class Amazon.Runtime.Internal.CallbackHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Fields
- private System.Action<Amazon.Runtime.IExecutionContext> <OnPostInvoke>k__BackingField
- private System.Action<Amazon.Runtime.IExecutionContext> <OnPreInvoke>k__BackingField

#### Properties
- public System.Action<Amazon.Runtime.IExecutionContext> OnPostInvoke { get; set; }
- public System.Action<Amazon.Runtime.IExecutionContext> OnPreInvoke { get; set; }

#### Constructors
- public CallbackHandler()

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- protected void PostInvoke(Amazon.Runtime.IExecutionContext executionContext)
- protected void PreInvoke(Amazon.Runtime.IExecutionContext executionContext)
- private void RaiseOnPostInvoke(Amazon.Runtime.IExecutionContext context)
- private void RaiseOnPreInvoke(Amazon.Runtime.IExecutionContext context)

### public class Amazon.Runtime.Internal.CapacityManager
- Interfaces: System.IDisposable

#### Fields
- private readonly int THROTTLED_RETRIES
- private readonly int THROTTLE_REQUEST_COST
- private readonly int THROTTLE_RETRY_REQUEST_COST
- private bool _disposed
- private System.Threading.ReaderWriterLockSlim _rwlock
- private static System.Collections.Generic.Dictionary<string, Amazon.Runtime.Internal.RetryCapacity> _serviceUrlToCapacityMap

#### Constructors
- private static CapacityManager()
- public CapacityManager(int throttleRetryCount, int throttleRetryCost, int throttleCost)

#### Methods
- private Amazon.Runtime.Internal.RetryCapacity AddNewRetryCapacity(string serviceURL)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- public Amazon.Runtime.Internal.RetryCapacity GetRetryCapacity(string serviceURL)
- private static void ReleaseCapacity(int capacity, Amazon.Runtime.Internal.RetryCapacity retryCapacity)
- public bool TryAcquireCapacity(Amazon.Runtime.Internal.RetryCapacity retryCapacity)
- private bool TryGetRetryCapacity(string key, out Amazon.Runtime.Internal.RetryCapacity value)
- public void TryReleaseCapacity(bool isRetryRequest, Amazon.Runtime.Internal.RetryCapacity retryCapacity)

### public class Amazon.Runtime.Internal.ClientContext

#### Fields
- private string <AppID>k__BackingField
- private static const string APP_ID_KEY
- private static const string CLIENT_APP_PACKAGE_NAME_KEY
- private static const string CLIENT_APP_TITLE_KEY
- private static const string CLIENT_APP_VERSION_CODE_KEY
- private static const string CLIENT_APP_VERSION_NAME_KEY
- private static const string CLIENT_ID_CACHE_FILENAME
- private static const string CLIENT_ID_KEY
- private static const string CLIENT_KEY
- private static const string CUSTOM_KEY
- private static const string ENV_KEY
- private static const string ENV_LOCALE_KEY
- private static const string ENV_MAKE_KEY
- private static const string ENV_MODEL_KEY
- private static const string ENV_PLATFORM_KEY
- private static const string ENV_PLATFORM_VERSION_KEY
- private static const string SERVICES_KEY
- private static const string SERVICE_MOBILE_ANALYTICS_APP_ID_KEY
- private static const string SERVICE_MOBILE_ANALYTICS_KEY
- private System.Collections.Generic.IDictionary<string, string> _client
- private System.Collections.IDictionary _clientContext
- private System.Collections.Generic.IDictionary<string, string> _custom
- private System.Collections.Generic.IDictionary<string, string> _env
- private static object _lock
- private System.Collections.Generic.IDictionary<string, System.Collections.IDictionary> _services

#### Properties
- public string AppID { get; set; }

#### Constructors
- public ClientContext()
- private static ClientContext()

#### Methods
- public void AddCustomAttributes(string key, string value)
- public string ToJsonString()

### public delegate Amazon.Runtime.Internal.CSMFallbackConfigChain.ConfigurationSource
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public CSMFallbackConfigChain.ConfigurationSource(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

### public class Amazon.Runtime.Internal.CredentialsRetriever
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Fields
- private Amazon.Runtime.AWSCredentials <Credentials>k__BackingField

#### Properties
- protected Amazon.Runtime.AWSCredentials Credentials { get; private set; }

#### Constructors
- public CredentialsRetriever(Amazon.Runtime.AWSCredentials credentials)

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- protected virtual void PreInvoke(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.Runtime.Internal.CSMCallAttemptHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Constructors
- public CSMCallAttemptHandler()

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- private static void CaptureAmazonException(Amazon.Runtime.Internal.MonitoringAPICallAttempt monitoringAPICallAttempt, Amazon.Runtime.AmazonServiceException e)
- private static void CaptureSDKExceptionMessage(Amazon.Runtime.Internal.MonitoringAPICallAttempt monitoringAPICallAttempt, System.Exception e)
- protected static void CSMCallAttemptMetricsCapture(Amazon.Runtime.IRequestContext requestContext, Amazon.Runtime.IResponseContext responseContext)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- protected virtual void PreInvoke(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.Runtime.Internal.CSMCallEventHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Fields
- private System.Diagnostics.Stopwatch stopWatch

#### Constructors
- public CSMCallEventHandler()

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- private static void CaptureCSMCallEventExceptionData(Amazon.Runtime.IRequestContext requestContext, System.Exception exception)
- private void CSMCallEventMetricsCapture(Amazon.Runtime.IExecutionContext executionContext)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- protected void PreInvoke(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.Runtime.Internal.CSMConfiguration

#### Fields
- private string <ClientId>k__BackingField
- private bool <Enabled>k__BackingField
- private string <Host>k__BackingField
- private int <Port>k__BackingField

#### Properties
- public string ClientId { get; internal set; }
- public bool Enabled { get; internal set; }
- public string Host { get; internal set; }
- public int Port { get; internal set; }

#### Constructors
- public CSMConfiguration()

### public class Amazon.Runtime.Internal.CSMFallbackConfigChain

#### Fields
- private System.Collections.Generic.List<Amazon.Runtime.Internal.CSMFallbackConfigChain.ConfigurationSource> <AllGenerators>k__BackingField
- private string <ConfigSource>k__BackingField
- private Amazon.Runtime.Internal.CSMConfiguration <CSMConfiguration>k__BackingField
- private bool <IsConfigSet>k__BackingField
- private static Amazon.Runtime.CredentialManagement.CredentialProfileStoreChain credentialProfileChain
- private readonly Amazon.Runtime.Internal.Util.ILogger LOGGER

#### Properties
- public System.Collections.Generic.List<Amazon.Runtime.Internal.CSMFallbackConfigChain.ConfigurationSource> AllGenerators { get; set; }
- public string ConfigSource { get; set; }
- public Amazon.Runtime.Internal.CSMConfiguration CSMConfiguration { get; internal set; }
- internal bool IsConfigSet { get; set; }

#### Constructors
- public CSMFallbackConfigChain()
- private static CSMFallbackConfigChain()

#### Methods
- private void <.ctor>b__19_0()
- private void <.ctor>b__19_1()
- private void <.ctor>b__19_2()
- public Amazon.Runtime.Internal.CSMConfiguration GetCSMConfig()

### protected enum Amazon.Runtime.Internal.MonitoringAPICall.CSMType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ApiCall = 0
- ApiCallAttempt = 1

### public static class Amazon.Runtime.Internal.CSMUtilities

#### Fields
- private static const string requestKey

#### Methods
- private static bool CreateUDPMessage(Amazon.Runtime.Internal.MonitoringAPICallAttempt monitoringAPICallAttempt, out string response)
- private static bool CreateUDPMessage(Amazon.Runtime.Internal.MonitoringAPICallEvent monitoringAPICallEvent, out string response)
- private static ThirdParty.Json.LitJson.JsonWriter CreateUDPMessage(Amazon.Runtime.Internal.MonitoringAPICall monitoringAPICall, ThirdParty.Json.LitJson.JsonWriter jw)
- public static string GetApiNameFromRequest(string requestName, System.Collections.Generic.IDictionary<string, string> serviceApiNameMapping, string serviceName)
- public static void SerializetoJsonAndPostOverUDP(Amazon.Runtime.Internal.MonitoringAPICall monitoringAPICall)
- public static System.Threading.Tasks.Task SerializetoJsonAndPostOverUDPAsync(Amazon.Runtime.Internal.MonitoringAPICall monitoringAPICall)

### public class Amazon.Runtime.Internal.DefaultRequest
- Interfaces: Amazon.Runtime.Internal.IRequest

#### Fields
- private string <AuthenticationRegion>k__BackingField
- private Amazon.Runtime.Internal.Auth.AWS4SigningResult <AWS4SignerResult>k__BackingField
- private string <CanonicalResourcePrefix>k__BackingField
- private string <DeterminedSigningRegion>k__BackingField
- private string <HostPrefix>k__BackingField
- private bool <SetContentFromParameters>k__BackingField
- private bool <Suppress404Exceptions>k__BackingField
- private bool <UseChunkEncoding>k__BackingField
- private bool <UseSigV4>k__BackingField
- private Amazon.RegionEndpoint alternateRegion
- private string canonicalResource
- private byte[] content
- private System.IO.Stream contentStream
- private string contentStreamHash
- private System.Uri endpoint
- private readonly System.Collections.Generic.IDictionary<string, string> headers
- private string httpMethod
- private int marshallerVersion
- private readonly Amazon.Runtime.AmazonWebServiceRequest originalRequest
- private long originalStreamLength
- private readonly Amazon.Runtime.Internal.ParameterCollection parametersCollection
- private readonly System.Collections.Generic.IDictionary<string, string> parametersFacade
- private readonly System.Collections.Generic.IDictionary<string, string> pathResources
- private string requestName
- private string resourcePath
- private string serviceName
- private readonly System.Collections.Generic.IDictionary<string, string> subResources
- private bool useQueryString

#### Properties
- public Amazon.RegionEndpoint AlternateEndpoint { get; set; }
- public string AuthenticationRegion { get; set; }
- public Amazon.Runtime.Internal.Auth.AWS4SigningResult AWS4SignerResult { get; set; }
- public string CanonicalResource { get; set; }
- public string CanonicalResourcePrefix { get; set; }
- public byte[] Content { get; set; }
- public System.IO.Stream ContentStream { get; set; }
- public string DeterminedSigningRegion { get; set; }
- public System.Uri Endpoint { get; set; }
- public System.Collections.Generic.IDictionary<string, string> Headers { get; }
- public string HostPrefix { get; set; }
- public string HttpMethod { get; set; }
- public int MarshallerVersion { get; set; }
- public Amazon.Runtime.AmazonWebServiceRequest OriginalRequest { get; }
- public long OriginalStreamPosition { get; set; }
- public Amazon.Runtime.Internal.ParameterCollection ParameterCollection { get; }
- public System.Collections.Generic.IDictionary<string, string> Parameters { get; }
- public System.Collections.Generic.IDictionary<string, string> PathResources { get; }
- public string RequestName { get; }
- public string ResourcePath { get; set; }
- public string ServiceName { get; }
- public bool SetContentFromParameters { get; set; }
- public System.Collections.Generic.IDictionary<string, string> SubResources { get; }
- public bool Suppress404Exceptions { get; set; }
- public bool UseChunkEncoding { get; set; }
- public bool UseQueryString { get; set; }
- public bool UseSigV4 { get; set; }

#### Constructors
- public DefaultRequest(Amazon.Runtime.AmazonWebServiceRequest request, string serviceName)

#### Methods
- public void AddPathResource(string key, string value)
- public void AddSubResource(string subResource)
- public void AddSubResource(string subResource, string value)
- public string ComputeContentStreamHash()
- public string GetHeaderValue(string headerName)
- public bool HasRequestBody()
- public bool IsRequestStreamRewindable()
- public bool MayContainRequestBody()

### public class Amazon.Runtime.Internal.DefaultRetryPolicy
- Base: Amazon.Runtime.RetryPolicy

#### Fields
- private static const int INVALID_ENDPOINT_EXCEPTION_STATUSCODE
- private static const int THROTTLED_RETRIES
- private static const int THROTTLE_REQUEST_COST
- private static const int THROTTLE_RETRY_REQUEST_COST
- private static readonly Amazon.Runtime.Internal.CapacityManager _capacityManagerInstance
- private System.Collections.Generic.ICollection<string> _errorCodesToRetryOn
- private System.Collections.Generic.ICollection<System.Net.HttpStatusCode> _httpStatusCodesToRetryOn
- private int _maxBackoffInMilliseconds
- private static readonly System.Collections.Generic.HashSet<string> _netStandardRetryErrorMessages
- private Amazon.Runtime.Internal.RetryCapacity _retryCapacity
- private System.Collections.Generic.ICollection<System.Net.WebExceptionStatus> _webExceptionStatusesToRetryOn

#### Properties
- public System.Collections.Generic.ICollection<string> ErrorCodesToRetryOn { get; }
- public System.Collections.Generic.ICollection<System.Net.HttpStatusCode> HttpStatusCodesToRetryOn { get; }
- public int MaxBackoffInMilliseconds { get; set; }
- public System.Collections.Generic.ICollection<System.Net.WebExceptionStatus> WebExceptionStatusesToRetryOn { get; }

#### Constructors
- private static DefaultRetryPolicy()
- public DefaultRetryPolicy(int maxRetries)
- public DefaultRetryPolicy(Amazon.Runtime.IClientConfig config)

#### Methods
- private static int CalculateRetryDelay(int retries, int maxBackoffInMilliseconds)
- public override bool CanRetry(Amazon.Runtime.IExecutionContext executionContext)
- protected static bool ContainErrorMessage(System.Exception exception)
- protected static bool IsInnerException<T>(System.Exception exception)
- protected static bool IsInnerException<T>(System.Exception exception, out T inner)
- public override void NotifySuccess(Amazon.Runtime.IExecutionContext executionContext)
- public override bool OnRetry(Amazon.Runtime.IExecutionContext executionContext)
- public override bool OnRetry(Amazon.Runtime.IExecutionContext executionContext, bool bypassAcquireCapacity)
- public override bool RetryForException(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)
- public override System.Threading.Tasks.Task<bool> RetryForExceptionAsync(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)
- private bool RetryForExceptionSync(System.Exception exception)
- private bool RetryForExceptionSync(System.Exception exception, Amazon.Runtime.IExecutionContext executionContext)
- public override bool RetryLimitReached(Amazon.Runtime.IExecutionContext executionContext)
- public override void WaitBeforeRetry(Amazon.Runtime.IExecutionContext executionContext)
- public static void WaitBeforeRetry(int retries, int maxBackoffInMilliseconds)
- public override System.Threading.Tasks.Task WaitBeforeRetryAsync(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.Runtime.Internal.DeterminedCSMConfiguration

#### Fields
- private Amazon.Runtime.Internal.CSMConfiguration <CSMConfiguration>k__BackingField
- private static readonly Amazon.Runtime.Internal.DeterminedCSMConfiguration instance

#### Properties
- public Amazon.Runtime.Internal.CSMConfiguration CSMConfiguration { get; set; }
- public static Amazon.Runtime.Internal.DeterminedCSMConfiguration Instance { get; }

#### Constructors
- private DeterminedCSMConfiguration()
- private static DeterminedCSMConfiguration()

### public class Amazon.Runtime.Internal.DiscoveryEndpoint
- Base: Amazon.Runtime.Internal.DiscoveryEndpointBase

#### Constructors
- public DiscoveryEndpoint(string address, long cachePeriodInMinutes)

### public class Amazon.Runtime.Internal.DiscoveryEndpointBase

#### Fields
- private object objectExtendLock
- private string _address
- private long _cachePeriodInMinutes
- private System.DateTime _createdOn

#### Properties
- public string Address { get; protected set; }
- public long CachePeriodInMinutes { get; protected set; }

#### Constructors
- protected DiscoveryEndpointBase(string address, long cachePeriodInMinutes)

#### Methods
- public void ExtendExpiration(long minutes)
- public bool HasExpired()

### public class Amazon.Runtime.Internal.EndpointDiscoveryData
- Base: Amazon.Runtime.Internal.EndpointDiscoveryDataBase

#### Constructors
- public EndpointDiscoveryData(bool required)

### public class Amazon.Runtime.Internal.EndpointDiscoveryDataBase

#### Fields
- private System.Collections.Generic.SortedDictionary<string, string> _identifiers
- private bool _required

#### Properties
- public System.Collections.Generic.SortedDictionary<string, string> Identifiers { get; protected set; }
- public bool Required { get; protected set; }

#### Constructors
- protected EndpointDiscoveryDataBase(bool required)

### public class Amazon.Runtime.Internal.EndpointDiscoveryHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Fields
- private static const int INVALID_ENDPOINT_EXCEPTION_STATUSCODE

#### Constructors
- public EndpointDiscoveryHandler()

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- public static void DiscoverEndpoints(Amazon.Runtime.IRequestContext requestContext, bool evictCacheKey)
- public static void EvictCacheKeyForRequest(Amazon.Runtime.IRequestContext requestContext, System.Uri regionalEndpoint)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- private static bool IsInvalidEndpointException(System.Exception exception)
- private static string OperationNameFromRequestName(string requestName)
- protected static void PreInvoke(Amazon.Runtime.IExecutionContext executionContext)
- private static System.Collections.Generic.IEnumerable<Amazon.Runtime.Internal.DiscoveryEndpointBase> ProcessEndpointDiscovery(Amazon.Runtime.IRequestContext requestContext, bool evictCacheKey, System.Uri evictUri)

### public class Amazon.Runtime.Internal.EndpointDiscoveryResolver
- Base: Amazon.Runtime.Internal.EndpointDiscoveryResolverBase

#### Constructors
- public EndpointDiscoveryResolver(Amazon.Runtime.IClientConfig config, Amazon.Runtime.Internal.Util.Logger logger)

### public class Amazon.Runtime.Internal.EndpointDiscoveryResolverBase

#### Fields
- private object objectCacheLock
- private Amazon.Runtime.Internal.Util.LruCache<string, System.Collections.Generic.IList<Amazon.Runtime.Internal.DiscoveryEndpointBase>> _cache
- private Amazon.Runtime.IClientConfig _config
- private Amazon.Runtime.Internal.Util.Logger _logger

#### Properties
- public int CacheCount { get; }

#### Constructors
- protected EndpointDiscoveryResolverBase(Amazon.Runtime.IClientConfig config, Amazon.Runtime.Internal.Util.Logger logger)

#### Methods
- private static string BuildEndpointDiscoveryCacheKey(Amazon.Runtime.Internal.EndpointOperationContextBase context)
- public virtual System.Collections.Generic.IList<Amazon.Runtime.Internal.DiscoveryEndpointBase> GetDiscoveryEndpointsFromCache(string cacheKey)
- private System.Collections.Generic.IEnumerable<Amazon.Runtime.Internal.DiscoveryEndpointBase> ProcessEndpointCache(string cacheKey, bool evictCacheKey, System.Uri evictUri, out bool refreshCache)
- private System.Collections.Generic.IEnumerable<Amazon.Runtime.Internal.DiscoveryEndpointBase> ProcessInvokeEndpointOperation(string cacheKey, System.Func<System.Collections.Generic.IList<Amazon.Runtime.Internal.DiscoveryEndpointBase>> InvokeEndpointOperation, bool endpointRequired)
- public virtual System.Collections.Generic.IEnumerable<Amazon.Runtime.Internal.DiscoveryEndpointBase> ResolveEndpoints(Amazon.Runtime.Internal.EndpointOperationContextBase context, System.Func<System.Collections.Generic.IList<Amazon.Runtime.Internal.DiscoveryEndpointBase>> InvokeEndpointOperation)

### public class Amazon.Runtime.Internal.EndpointOperationContext
- Base: Amazon.Runtime.Internal.EndpointOperationContextBase

#### Constructors
- public EndpointOperationContext(string customerCredentials, string operationName, Amazon.Runtime.Internal.EndpointDiscoveryDataBase endpointDiscoveryData, bool evictCacheKey, System.Uri evictUri)

### public class Amazon.Runtime.Internal.EndpointOperationContextBase

#### Fields
- private string _customerCredentials
- private Amazon.Runtime.Internal.EndpointDiscoveryDataBase _endpointDiscoveryData
- private bool _evictCacheKey
- private System.Uri _evictUri
- private string _operationName

#### Properties
- public string CustomerCredentials { get; protected set; }
- public Amazon.Runtime.Internal.EndpointDiscoveryDataBase EndpointDiscoveryData { get; protected set; }
- public bool EvictCacheKey { get; protected set; }
- public System.Uri EvictUri { get; protected set; }
- public string OperationName { get; protected set; }

#### Constructors
- protected EndpointOperationContextBase(string customerCredentials, string operationName, Amazon.Runtime.Internal.EndpointDiscoveryDataBase endpointDiscoveryData, bool evictCacheKey, System.Uri evictUri)

### public delegate Amazon.Runtime.Internal.EndpointOperationDelegate
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public EndpointOperationDelegate(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Amazon.Runtime.Internal.EndpointOperationContextBase context, System.AsyncCallback callback, object object)
- public virtual System.Collections.Generic.IEnumerable<Amazon.Runtime.Internal.DiscoveryEndpointBase> EndInvoke(System.IAsyncResult result)
- public virtual System.Collections.Generic.IEnumerable<Amazon.Runtime.Internal.DiscoveryEndpointBase> Invoke(Amazon.Runtime.Internal.EndpointOperationContextBase context)

### public class Amazon.Runtime.Internal.EndpointResolver
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Constructors
- public EndpointResolver()

#### Methods
- public virtual System.Uri DetermineEndpoint(Amazon.Runtime.IRequestContext requestContext)
- public static System.Uri DetermineEndpoint(Amazon.Runtime.IClientConfig config, Amazon.Runtime.Internal.IRequest request)
- private static System.Uri InjectHostPrefix(Amazon.Runtime.IClientConfig config, Amazon.Runtime.Internal.IRequest request, System.Uri endpoint)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- protected void PreInvoke(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.Runtime.Internal.EnvironmentVariableCSMConfigs

#### Fields
- private Amazon.Util.Internal.IEnvironmentVariableRetriever <environmentRetriever>k__BackingField
- private static const string CSM_CLIENTID
- private static const string CSM_ENABLED
- private static const string CSM_HOST
- private static const string CSM_PORT

#### Properties
- private Amazon.Util.Internal.IEnvironmentVariableRetriever environmentRetriever { get; set; }

#### Constructors
- public EnvironmentVariableCSMConfigs(Amazon.Runtime.Internal.CSMFallbackConfigChain cSMFallbackConfigChain)
- public EnvironmentVariableCSMConfigs(Amazon.Util.Internal.IEnvironmentVariableRetriever environmentRetriever, Amazon.Runtime.Internal.CSMFallbackConfigChain cSMFallbackConfigChain)

#### Methods
- private void SetupConfiguration(Amazon.Runtime.Internal.CSMFallbackConfigChain cSMFallbackConfigChain)

### public class Amazon.Runtime.Internal.ErrorCallbackHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Fields
- private System.Action<Amazon.Runtime.IExecutionContext, System.Exception> <OnError>k__BackingField

#### Properties
- public System.Action<Amazon.Runtime.IExecutionContext, System.Exception> OnError { get; set; }

#### Constructors
- public ErrorCallbackHandler()

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- protected void HandleException(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.Runtime.Internal.ErrorHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Fields
- private System.Collections.Generic.IDictionary<System.Type, Amazon.Runtime.IExceptionHandler> _exceptionHandlers

#### Properties
- public System.Collections.Generic.IDictionary<System.Type, Amazon.Runtime.IExceptionHandler> ExceptionHandlers { get; }

#### Constructors
- public ErrorHandler(Amazon.Runtime.Internal.Util.ILogger logger)

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- private static void DisposeReponse(Amazon.Runtime.IResponseContext responseContext)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- private bool ProcessException(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)

### public class Amazon.Runtime.Internal.ErrorResponse

#### Fields
- private string code
- private string message
- private string requestId
- private Amazon.Runtime.ErrorType type

#### Properties
- public string Code { get; set; }
- public string Message { get; set; }
- public string RequestId { get; set; }
- public Amazon.Runtime.ErrorType Type { get; set; }

#### Constructors
- public ErrorResponse()

### public class Amazon.Runtime.Internal.ExceptionHandler<T>
- Interfaces: Amazon.Runtime.IExceptionHandler<T>, Amazon.Runtime.IExceptionHandler

#### Fields
- private Amazon.Runtime.Internal.Util.ILogger _logger

#### Properties
- protected Amazon.Runtime.Internal.Util.ILogger Logger { get; }

#### Constructors
- protected ExceptionHandler<T>(Amazon.Runtime.Internal.Util.ILogger logger)

#### Methods
- public bool Handle(Amazon.Runtime.IExecutionContext executionContext, System.Exception exception)
- public abstract bool HandleException(Amazon.Runtime.IExecutionContext executionContext, T exception)

### public class Amazon.Runtime.Internal.ExecutionContext
- Interfaces: Amazon.Runtime.IExecutionContext

#### Fields
- private Amazon.Runtime.IRequestContext <RequestContext>k__BackingField
- private Amazon.Runtime.IResponseContext <ResponseContext>k__BackingField

#### Properties
- public Amazon.Runtime.IRequestContext RequestContext { get; private set; }
- public Amazon.Runtime.IResponseContext ResponseContext { get; private set; }

#### Constructors
- public ExecutionContext(bool enableMetrics, Amazon.Runtime.Internal.Auth.AbstractAWSSigner clientSigner)
- public ExecutionContext(Amazon.Runtime.IRequestContext requestContext, Amazon.Runtime.IResponseContext responseContext)

#### Methods
- public static Amazon.Runtime.IExecutionContext CreateFromAsyncContext(Amazon.Runtime.IAsyncExecutionContext asyncContext)

### public class Amazon.Runtime.Internal.HttpErrorResponseException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private Amazon.Runtime.Internal.Transform.IWebResponseData <Response>k__BackingField

#### Properties
- public Amazon.Runtime.Internal.Transform.IWebResponseData Response { get; private set; }

#### Constructors
- public HttpErrorResponseException(Amazon.Runtime.Internal.Transform.IWebResponseData response)
- public HttpErrorResponseException(string message, Amazon.Runtime.Internal.Transform.IWebResponseData response)
- public HttpErrorResponseException(string message, System.Exception innerException, Amazon.Runtime.Internal.Transform.IWebResponseData response)

### public class Amazon.Runtime.Internal.HttpErrorResponseExceptionHandler
- Base: Amazon.Runtime.Internal.ExceptionHandler<Amazon.Runtime.Internal.HttpErrorResponseException>
- Interfaces: Amazon.Runtime.IExceptionHandler<Amazon.Runtime.Internal.HttpErrorResponseException>, Amazon.Runtime.IExceptionHandler

#### Constructors
- public HttpErrorResponseExceptionHandler(Amazon.Runtime.Internal.Util.ILogger logger)

#### Methods
- public override bool HandleException(Amazon.Runtime.IExecutionContext executionContext, Amazon.Runtime.Internal.HttpErrorResponseException exception)
- private bool HandleSuppressed404(Amazon.Runtime.IExecutionContext executionContext, Amazon.Runtime.Internal.Transform.IWebResponseData httpErrorResponse)

### public class Amazon.Runtime.Internal.HttpHandler<TRequestContent>
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler, System.IDisposable

#### Fields
- private object <CallbackSender>k__BackingField
- private bool _disposed
- private Amazon.Runtime.IHttpRequestFactory<TRequestContent> _requestFactory

#### Properties
- public object CallbackSender { get; private set; }

#### Constructors
- public HttpHandler<TRequestContent>(Amazon.Runtime.IHttpRequestFactory<TRequestContent> requestFactory, object callbackSender)

#### Methods
- private static void CompleteFailedRequest(Amazon.Runtime.IHttpRequest<TRequestContent> httpRequest)
- private static System.Threading.Tasks.Task CompleteFailedRequest(Amazon.Runtime.IExecutionContext executionContext, Amazon.Runtime.IHttpRequest<TRequestContent> httpRequest)
- protected virtual Amazon.Runtime.IHttpRequest<TRequestContent> CreateWebRequest(Amazon.Runtime.IRequestContext requestContext)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- private static void SetMetrics(Amazon.Runtime.IRequestContext requestContext)
- private void WriteContentToRequestBody(TRequestContent requestContent, Amazon.Runtime.IHttpRequest<TRequestContent> httpRequest, Amazon.Runtime.IRequestContext requestContext)

### public interface Amazon.Runtime.Internal.IAmazonWebServiceRequest

#### Properties
- public System.Collections.Generic.Dictionary<string, object> RequestState { get; }
- public System.EventHandler<Amazon.Runtime.StreamTransferProgressArgs> StreamUploadProgressCallback { get; set; }
- public bool UseSigV4 { get; set; }

#### Methods
- public void AddBeforeRequestHandler(Amazon.Runtime.RequestEventHandler handler)
- public void RemoveBeforeRequestHandler(Amazon.Runtime.RequestEventHandler handler)

### public class Amazon.Runtime.Internal.InvokeOptions
- Base: Amazon.Runtime.Internal.InvokeOptionsBase

#### Constructors
- public InvokeOptions()

### public class Amazon.Runtime.Internal.InvokeOptionsBase

#### Fields
- private Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.EndpointDiscoveryDataBase, Amazon.Runtime.AmazonWebServiceRequest> _endpointDiscoveryMarshaller
- private Amazon.Runtime.Internal.EndpointOperationDelegate _endpointOperation
- private Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest> _requestMarshaller
- private Amazon.Runtime.Internal.Transform.ResponseUnmarshaller _responseUnmarshaller

#### Properties
- public Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.EndpointDiscoveryDataBase, Amazon.Runtime.AmazonWebServiceRequest> EndpointDiscoveryMarshaller { get; set; }
- public Amazon.Runtime.Internal.EndpointOperationDelegate EndpointOperation { get; set; }
- public Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest> RequestMarshaller { get; set; }
- public Amazon.Runtime.Internal.Transform.ResponseUnmarshaller ResponseUnmarshaller { get; set; }

#### Constructors
- protected InvokeOptionsBase()

### public interface Amazon.Runtime.Internal.IRequest

#### Properties
- public Amazon.RegionEndpoint AlternateEndpoint { get; set; }
- public string AuthenticationRegion { get; set; }
- public Amazon.Runtime.Internal.Auth.AWS4SigningResult AWS4SignerResult { get; set; }
- public string CanonicalResourcePrefix { get; set; }
- public byte[] Content { get; set; }
- public System.IO.Stream ContentStream { get; set; }
- public string DeterminedSigningRegion { get; set; }
- public System.Uri Endpoint { get; set; }
- public System.Collections.Generic.IDictionary<string, string> Headers { get; }
- public string HostPrefix { get; set; }
- public string HttpMethod { get; set; }
- public int MarshallerVersion { get; set; }
- public Amazon.Runtime.AmazonWebServiceRequest OriginalRequest { get; }
- public long OriginalStreamPosition { get; set; }
- public Amazon.Runtime.Internal.ParameterCollection ParameterCollection { get; }
- public System.Collections.Generic.IDictionary<string, string> Parameters { get; }
- public System.Collections.Generic.IDictionary<string, string> PathResources { get; }
- public string RequestName { get; }
- public string ResourcePath { get; set; }
- public string ServiceName { get; }
- public bool SetContentFromParameters { get; set; }
- public System.Collections.Generic.IDictionary<string, string> SubResources { get; }
- public bool Suppress404Exceptions { get; set; }
- public bool UseChunkEncoding { get; set; }
- public bool UseQueryString { get; set; }
- public bool UseSigV4 { get; set; }

#### Methods
- public void AddPathResource(string key, string value)
- public void AddSubResource(string subResource)
- public void AddSubResource(string subResource, string value)
- public string ComputeContentStreamHash()
- public string GetHeaderValue(string headerName)
- public bool HasRequestBody()
- public bool IsRequestStreamRewindable()
- public bool MayContainRequestBody()

### public interface Amazon.Runtime.Internal.IRequestData

#### Properties
- public Amazon.Runtime.Internal.Util.RequestMetrics Metrics { get; }
- public Amazon.Runtime.Internal.IRequest Request { get; }
- public int RetriesAttempt { get; }
- public Amazon.Runtime.Internal.Auth.AbstractAWSSigner Signer { get; }
- public Amazon.Runtime.Internal.Transform.ResponseUnmarshaller Unmarshaller { get; }

### public interface Amazon.Runtime.Internal.IRuntimePipelineCustomizer

#### Properties
- public string UniqueName { get; }

#### Methods
- public void Customize(System.Type type, Amazon.Runtime.Internal.RuntimePipeline pipeline)

### public interface Amazon.Runtime.Internal.IServiceMetadata

#### Properties
- public System.Collections.Generic.IDictionary<string, string> OperationNameMapping { get; }
- public string ServiceId { get; }

### public class Amazon.Runtime.Internal.Marshaller
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Constructors
- public Marshaller()

#### Methods
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- protected static void PreInvoke(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.Runtime.Internal.MetricsHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Constructors
- public MetricsHandler()

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.Runtime.Internal.MonitoringAPICall

#### Fields
- private string <Api>k__BackingField
- private string <ClientId>k__BackingField
- private string <Region>k__BackingField
- private string <Service>k__BackingField
- private long <Timestamp>k__BackingField
- private string <Type>k__BackingField
- private string <UserAgent>k__BackingField
- private int <Version>k__BackingField

#### Properties
- public string Api { get; internal set; }
- public string ClientId { get; internal set; }
- public string Region { get; internal set; }
- public string Service { get; internal set; }
- public long Timestamp { get; internal set; }
- public string Type { get; internal set; }
- public string UserAgent { get; internal set; }
- public int Version { get; internal set; }

#### Constructors
- public MonitoringAPICall()
- public MonitoringAPICall(Amazon.Runtime.IRequestContext requestContext)

### public class Amazon.Runtime.Internal.MonitoringAPICallAttempt
- Base: Amazon.Runtime.Internal.MonitoringAPICall

#### Fields
- private string <AccessKey>k__BackingField
- private long <AttemptLatency>k__BackingField
- private string <AWSException>k__BackingField
- private string <AWSExceptionMessage>k__BackingField
- private string <Fqdn>k__BackingField
- private System.Nullable<int> <HttpStatusCode>k__BackingField
- private string <SdkException>k__BackingField
- private string <SdkExceptionMessage>k__BackingField
- private string <SessionToken>k__BackingField
- private string <XAmzId2>k__BackingField
- private string <XAmznRequestId>k__BackingField
- private string <XAmzRequestId>k__BackingField

#### Properties
- public string AccessKey { get; internal set; }
- public long AttemptLatency { get; internal set; }
- public string AWSException { get; internal set; }
- public string AWSExceptionMessage { get; internal set; }
- public string Fqdn { get; internal set; }
- public System.Nullable<int> HttpStatusCode { get; internal set; }
- public string SdkException { get; internal set; }
- public string SdkExceptionMessage { get; internal set; }
- public string SessionToken { get; internal set; }
- public string XAmzId2 { get; internal set; }
- public string XAmznRequestId { get; internal set; }
- public string XAmzRequestId { get; internal set; }

#### Constructors
- public MonitoringAPICallAttempt(Amazon.Runtime.IRequestContext requestContext)

### public class Amazon.Runtime.Internal.MonitoringAPICallEvent
- Base: Amazon.Runtime.Internal.MonitoringAPICall

#### Fields
- private int <AttemptCount>k__BackingField
- private string <FinalAWSException>k__BackingField
- private string <FinalAWSExceptionMessage>k__BackingField
- private System.Nullable<int> <FinalHttpStatusCode>k__BackingField
- private string <FinalSdkException>k__BackingField
- private string <FinalSdkExceptionMessage>k__BackingField
- private bool <IsLastExceptionRetryable>k__BackingField
- private long <Latency>k__BackingField

#### Properties
- public int AttemptCount { get; internal set; }
- public string FinalAWSException { get; internal set; }
- public string FinalAWSExceptionMessage { get; internal set; }
- public System.Nullable<int> FinalHttpStatusCode { get; internal set; }
- public string FinalSdkException { get; internal set; }
- public string FinalSdkExceptionMessage { get; internal set; }
- public bool IsLastExceptionRetryable { get; internal set; }
- public long Latency { get; internal set; }

#### Constructors
- public MonitoringAPICallEvent(Amazon.Runtime.IRequestContext requestContext)

### public class Amazon.Runtime.Internal.ParameterCollection
- Base: System.Collections.Generic.SortedDictionary<string, Amazon.Runtime.ParameterValue>
- Interfaces: System.Collections.Generic.IDictionary<string, Amazon.Runtime.ParameterValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, Amazon.Runtime.ParameterValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Amazon.Runtime.ParameterValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary<string, Amazon.Runtime.ParameterValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<string, Amazon.Runtime.ParameterValue>>

#### Constructors
- public ParameterCollection()

#### Methods
- public void Add(string key, string value)
- public void Add(string key, System.Collections.Generic.List<string> values)
- private System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> GetParametersEnumerable()
- public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>> GetSortedParametersList()

### public class Amazon.Runtime.Internal.ParametersDictionaryFacade
- Interfaces: System.Collections.Generic.IDictionary<string, string>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable

#### Fields
- private readonly Amazon.Runtime.Internal.ParameterCollection _parameterCollection

#### Properties
- public int Count { get; }
- public bool IsReadOnly { get; }
- public string Item { get; set; }
- public System.Collections.Generic.ICollection<string> Keys { get; }
- public System.Collections.Generic.ICollection<string> Values { get; }

#### Constructors
- public ParametersDictionaryFacade(Amazon.Runtime.Internal.ParameterCollection collection)

#### Methods
- public void Add(string key, string value)
- public void Add(System.Collections.Generic.KeyValuePair<string, string> item)
- public void Clear()
- public bool Contains(System.Collections.Generic.KeyValuePair<string, string> item)
- public bool ContainsKey(string key)
- public void CopyTo(System.Collections.Generic.KeyValuePair<string, string>[] array, int arrayIndex)
- public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> GetEnumerator()
- private static string ParameterValueToString(Amazon.Runtime.ParameterValue pv)
- public bool Remove(string key)
- public bool Remove(System.Collections.Generic.KeyValuePair<string, string> item)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- public bool TryGetValue(string key, out string value)
- private static void UpdateParameterValue(Amazon.Runtime.ParameterValue pv, string newValue)

### public class Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Fields
- private Amazon.Runtime.IPipelineHandler <InnerHandler>k__BackingField
- private Amazon.Runtime.Internal.Util.ILogger <Logger>k__BackingField
- private Amazon.Runtime.IPipelineHandler <OuterHandler>k__BackingField

#### Properties
- public Amazon.Runtime.IPipelineHandler InnerHandler { get; set; }
- public Amazon.Runtime.Internal.Util.ILogger Logger { get; set; }
- public Amazon.Runtime.IPipelineHandler OuterHandler { get; set; }

#### Constructors
- protected PipelineHandler()

#### Methods
- public virtual System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public virtual void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- protected void LogMetrics(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.Runtime.Internal.ProcessCredentialVersion1

#### Fields
- private string <AccessKeyId>k__BackingField
- private System.DateTime <Expiration>k__BackingField
- private string <SecretAccessKey>k__BackingField
- private string <SessionToken>k__BackingField
- private int <Version>k__BackingField

#### Properties
- public string AccessKeyId { get; set; }
- public System.DateTime Expiration { get; set; }
- public string SecretAccessKey { get; set; }
- public string SessionToken { get; set; }
- public int Version { get; set; }

#### Constructors
- public ProcessCredentialVersion1()

### public class Amazon.Runtime.Internal.ProfileCSMConfigs

#### Fields
- private string <ProfileName>k__BackingField
- private static const string CSM_CLIENTID
- private static const string CSM_ENABLED
- private static const string CSM_HOST
- private static const string CSM_PORT
- private static const string CSM_PROFILE_ERROR_MSG

#### Properties
- private string ProfileName { get; set; }

#### Constructors
- public ProfileCSMConfigs(Amazon.Runtime.CredentialManagement.ICredentialProfileSource source, Amazon.Runtime.Internal.CSMFallbackConfigChain cSMFallbackConfigChain)
- public ProfileCSMConfigs(Amazon.Runtime.Internal.CSMFallbackConfigChain cSMFallbackConfigChain, string profileName, System.Collections.Generic.IDictionary<string, string> profileProperties)

#### Methods
- private void Setup(Amazon.Runtime.Internal.CSMFallbackConfigChain cSMFallbackConfigChain, System.Collections.Generic.IDictionary<string, string> profileProperties)

### public class Amazon.Runtime.Internal.RedirectHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Constructors
- public RedirectHandler()

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- protected virtual void FinalizeForRedirect(Amazon.Runtime.IExecutionContext executionContext, string redirectedLocation)
- private bool HandleRedirect(Amazon.Runtime.IExecutionContext executionContext)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)

### public class Amazon.Runtime.Internal.RequestContext
- Interfaces: Amazon.Runtime.IRequestContext

#### Fields
- private System.Threading.CancellationToken <CancellationToken>k__BackingField
- private Amazon.Runtime.IClientConfig <ClientConfig>k__BackingField
- private Amazon.Runtime.Internal.MonitoringAPICallAttempt <CSMCallAttempt>k__BackingField
- private Amazon.Runtime.Internal.MonitoringAPICallEvent <CSMCallEvent>k__BackingField
- private bool <CSMEnabled>k__BackingField
- private int <EndpointDiscoveryRetries>k__BackingField
- private Amazon.Runtime.ImmutableCredentials <ImmutableCredentials>k__BackingField
- private bool <IsAsync>k__BackingField
- private bool <IsLastExceptionRetryable>k__BackingField
- private bool <IsSigned>k__BackingField
- private Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest> <Marshaller>k__BackingField
- private Amazon.Runtime.Internal.Util.RequestMetrics <Metrics>k__BackingField
- private Amazon.Runtime.Internal.InvokeOptionsBase <Options>k__BackingField
- private Amazon.Runtime.AmazonWebServiceRequest <OriginalRequest>k__BackingField
- private Amazon.Runtime.Internal.IRequest <Request>k__BackingField
- private int <Retries>k__BackingField
- private Amazon.Runtime.Internal.Transform.ResponseUnmarshaller <Unmarshaller>k__BackingField
- private Amazon.Runtime.Internal.Auth.AbstractAWSSigner clientSigner
- private Amazon.Runtime.Internal.IServiceMetadata _serviceMetadata

#### Properties
- public System.Threading.CancellationToken CancellationToken { get; set; }
- public Amazon.Runtime.IClientConfig ClientConfig { get; set; }
- public Amazon.Runtime.Internal.MonitoringAPICallAttempt CSMCallAttempt { get; set; }
- public Amazon.Runtime.Internal.MonitoringAPICallEvent CSMCallEvent { get; set; }
- public bool CSMEnabled { get; private set; }
- public int EndpointDiscoveryRetries { get; set; }
- public Amazon.Runtime.ImmutableCredentials ImmutableCredentials { get; set; }
- public bool IsAsync { get; set; }
- public bool IsLastExceptionRetryable { get; set; }
- public bool IsSigned { get; set; }
- public Amazon.Runtime.Internal.Transform.IMarshaller<Amazon.Runtime.Internal.IRequest, Amazon.Runtime.AmazonWebServiceRequest> Marshaller { get; set; }
- public Amazon.Runtime.Internal.Util.RequestMetrics Metrics { get; private set; }
- public Amazon.Runtime.Internal.InvokeOptionsBase Options { get; set; }
- public Amazon.Runtime.AmazonWebServiceRequest OriginalRequest { get; set; }
- public Amazon.Runtime.Internal.IRequest Request { get; set; }
- public string RequestName { get; }
- public int Retries { get; set; }
- public Amazon.Runtime.Internal.IServiceMetadata ServiceMetaData { get; internal set; }
- public Amazon.Runtime.Internal.Auth.AbstractAWSSigner Signer { get; }
- public Amazon.Runtime.Internal.Transform.ResponseUnmarshaller Unmarshaller { get; set; }

#### Constructors
- public RequestContext(bool enableMetrics, Amazon.Runtime.Internal.Auth.AbstractAWSSigner clientSigner)

### public class Amazon.Runtime.Internal.ResponseContext
- Interfaces: Amazon.Runtime.IResponseContext

#### Fields
- private Amazon.Runtime.Internal.Transform.IWebResponseData <HttpResponse>k__BackingField
- private Amazon.Runtime.AmazonWebServiceResponse <Response>k__BackingField

#### Properties
- public Amazon.Runtime.Internal.Transform.IWebResponseData HttpResponse { get; set; }
- public Amazon.Runtime.AmazonWebServiceResponse Response { get; set; }

#### Constructors
- public ResponseContext()

### public class Amazon.Runtime.Internal.RetryCapacity

#### Fields
- private int <AvailableCapacity>k__BackingField
- private readonly int _maxCapacity

#### Properties
- public int AvailableCapacity { get; set; }
- public int MaxCapacity { get; }

#### Constructors
- public RetryCapacity(int maxCapacity)

### public class Amazon.Runtime.Internal.RetryHandler
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Fields
- private Amazon.Runtime.RetryPolicy <RetryPolicy>k__BackingField
- private Amazon.Runtime.Internal.Util.ILogger _logger

#### Properties
- public Amazon.Runtime.Internal.Util.ILogger Logger { get; set; }
- public Amazon.Runtime.RetryPolicy RetryPolicy { get; private set; }

#### Constructors
- public RetryHandler(Amazon.Runtime.RetryPolicy retryPolicy)

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- private void LogForError(Amazon.Runtime.IRequestContext requestContext, System.Exception exception)
- private void LogForRetry(Amazon.Runtime.IRequestContext requestContext, System.Exception exception)
- internal static void PrepareForRetry(Amazon.Runtime.IRequestContext requestContext)

### public class Amazon.Runtime.Internal.RuntimePipeline
- Interfaces: System.IDisposable

#### Fields
- private bool _disposed
- private Amazon.Runtime.IPipelineHandler _handler
- private Amazon.Runtime.Internal.Util.ILogger _logger

#### Properties
- public Amazon.Runtime.IPipelineHandler Handler { get; }
- public System.Collections.Generic.List<Amazon.Runtime.IPipelineHandler> Handlers { get; }

#### Constructors
- public RuntimePipeline(Amazon.Runtime.IPipelineHandler handler)
- public RuntimePipeline(System.Collections.Generic.IList<Amazon.Runtime.IPipelineHandler> handlers)
- public RuntimePipeline(System.Collections.Generic.IList<Amazon.Runtime.IPipelineHandler> handlers, Amazon.Runtime.Internal.Util.ILogger logger)
- public RuntimePipeline(Amazon.Runtime.IPipelineHandler handler, Amazon.Runtime.Internal.Util.ILogger logger)

#### Methods
- public void AddHandler(Amazon.Runtime.IPipelineHandler handler)
- public void AddHandlerAfter<T>(Amazon.Runtime.IPipelineHandler handler)
- public void AddHandlerBefore<T>(Amazon.Runtime.IPipelineHandler handler)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- public System.Collections.Generic.IEnumerable<Amazon.Runtime.IPipelineHandler> EnumerateHandlers()
- private static Amazon.Runtime.IPipelineHandler GetInnermostHandler(Amazon.Runtime.IPipelineHandler handler)
- private static void InsertHandler(Amazon.Runtime.IPipelineHandler handler, Amazon.Runtime.IPipelineHandler current)
- public System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public Amazon.Runtime.IResponseContext InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- public void RemoveHandler<T>()
- public void ReplaceHandler<T>(Amazon.Runtime.IPipelineHandler handler)
- private void SetHandlerProperties(Amazon.Runtime.IPipelineHandler handler)
- private void ThrowIfDisposed()

### public class Amazon.Runtime.Internal.RuntimePipelineCustomizerRegistry
- Interfaces: System.IDisposable

#### Fields
- private static readonly Amazon.Runtime.Internal.RuntimePipelineCustomizerRegistry <Instance>k__BackingField
- private System.Collections.Generic.IList<Amazon.Runtime.Internal.IRuntimePipelineCustomizer> _customizers
- private Amazon.Runtime.Internal.Util.Logger _logger
- private System.Threading.ReaderWriterLockSlim _rwlock

#### Properties
- public static Amazon.Runtime.Internal.RuntimePipelineCustomizerRegistry Instance { get; }

#### Constructors
- private RuntimePipelineCustomizerRegistry()
- private static RuntimePipelineCustomizerRegistry()

#### Methods
- internal void ApplyCustomizations(System.Type type, Amazon.Runtime.Internal.RuntimePipeline pipeline)
- public void Deregister(Amazon.Runtime.Internal.IRuntimePipelineCustomizer customizer)
- public void Deregister(string uniqueName)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- public void Register(Amazon.Runtime.Internal.IRuntimePipelineCustomizer customizer)

### public static class Amazon.Runtime.Internal.ServiceClientHelpers

#### Fields
- public static const string KMS_ASSEMBLY_NAME
- public static const string KMS_SERVICE_CLASS_NAME
- public static const string S3_ASSEMBLY_NAME
- public static const string S3_SERVICE_CLASS_NAME
- public static const string STS_ASSEMBLY_NAME
- public static const string STS_SERVICE_CLASS_NAME
- public static const string STS_SERVICE_CONFIG_NAME

#### Methods
- public static Amazon.Runtime.ClientConfig CreateServiceConfig(string assemblyName, string serviceConfigClassName)
- public static TClient CreateServiceFromAnother<TClient, TConfig>(Amazon.Runtime.AmazonServiceClient originalServiceClient)
- public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName, Amazon.RegionEndpoint region)
- public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName, Amazon.Runtime.AWSCredentials credentials, Amazon.RegionEndpoint region)
- public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName, Amazon.Runtime.AWSCredentials credentials, Amazon.Runtime.ClientConfig config)
- public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName, Amazon.Runtime.AmazonServiceClient originalServiceClient)
- private static System.Reflection.Assembly GetSDKAssembly(string assemblyName)
- private static Amazon.Util.Internal.ITypeInfo LoadServiceClientType(string assemblyName, string serviceClientClassName)
- private static Amazon.Util.Internal.ITypeInfo LoadServiceConfigType(string assemblyName, string serviceConfigClassName)

### internal class Amazon.Runtime.Internal.ServiceMetadata
- Interfaces: Amazon.Runtime.Internal.IServiceMetadata

#### Fields
- private readonly System.Collections.Generic.IDictionary<string, string> <OperationNameMapping>k__BackingField
- private readonly string <ServiceId>k__BackingField

#### Properties
- public System.Collections.Generic.IDictionary<string, string> OperationNameMapping { get; }
- public string ServiceId { get; }

#### Constructors
- public ServiceMetadata()

### public class Amazon.Runtime.Internal.Signer
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Constructors
- public Signer()

#### Methods
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- protected static void PreInvoke(Amazon.Runtime.IExecutionContext executionContext)
- private static bool ShouldSign(Amazon.Runtime.IRequestContext requestContext)
- public static void SignRequest(Amazon.Runtime.IRequestContext requestContext)

### internal class Amazon.Runtime.Internal.StreamReadTracker

#### Fields
- private System.EventHandler<Amazon.Runtime.StreamTransferProgressArgs> callback
- private long contentLength
- private long progressUpdateInterval
- private object sender
- private long totalBytesRead
- private long totalIncrementTransferred

#### Constructors
- internal StreamReadTracker(object sender, System.EventHandler<Amazon.Runtime.StreamTransferProgressArgs> callback, long contentLength, long progressUpdateInterval)

#### Methods
- public void ReadProgress(int bytesRead)
- public void UpdateProgress(float progress)

### public class Amazon.Runtime.Internal.Unmarshaller
- Base: Amazon.Runtime.Internal.PipelineHandler
- Interfaces: Amazon.Runtime.IPipelineHandler

#### Fields
- private bool _supportsResponseLogging

#### Constructors
- public Unmarshaller(bool supportsResponseLogging)

#### Methods
- private System.Threading.Tasks.Task<T> <>n__0<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override System.Threading.Tasks.Task<T> InvokeAsync<T>(Amazon.Runtime.IExecutionContext executionContext)
- public override void InvokeSync(Amazon.Runtime.IExecutionContext executionContext)
- private static bool ShouldLogResponseBody(bool supportsResponseLogging, Amazon.Runtime.IRequestContext requestContext)
- private void Unmarshall(Amazon.Runtime.IExecutionContext executionContext)
- private System.Threading.Tasks.Task UnmarshallAsync(Amazon.Runtime.IExecutionContext executionContext)
- private Amazon.Runtime.AmazonWebServiceResponse UnmarshallResponse(Amazon.Runtime.Internal.Transform.UnmarshallerContext context, Amazon.Runtime.IRequestContext requestContext)

## Namespace: Amazon.Runtime.Internal.Auth

### private class Amazon.Runtime.Internal.Auth.AWS4Signer.<>c

#### Fields
- public static readonly Amazon.Runtime.Internal.Auth.AWS4Signer.<>c <>9
- public static System.Func<System.Collections.Generic.KeyValuePair<string, string>, bool> <>9__48_0
- public static System.Func<System.Collections.Generic.KeyValuePair<string, string>, string> <>9__52_0

#### Constructors
- private static AWS4Signer.<>c()
- public AWS4Signer.<>c()

#### Methods
- internal string <CanonicalizeQueryParameters>b__52_0(System.Collections.Generic.KeyValuePair<string, string> kvp)
- internal bool <GetParametersToCanonicalize>b__48_0(System.Collections.Generic.KeyValuePair<string, string> queryParameter)

### private class Amazon.Runtime.Internal.Auth.S3Signer.<>c

#### Fields
- public static readonly Amazon.Runtime.Internal.Auth.S3Signer.<>c <>9
- public static System.Func<string, string> <>9__10_0
- public static System.Comparison<System.Collections.Generic.KeyValuePair<string, string>> <>9__13_0

#### Constructors
- private static S3Signer.<>c()
- public S3Signer.<>c()

#### Methods
- internal string <BuildCanonicalizedHeaders>b__10_0(string x)
- internal int <BuildCanonicalizedResource>b__13_0(System.Collections.Generic.KeyValuePair<string, string> firstPair, System.Collections.Generic.KeyValuePair<string, string> nextPair)

### public class Amazon.Runtime.Internal.Auth.AbstractAWSSigner

#### Fields
- private Amazon.Runtime.Internal.Auth.AWS4Signer _aws4Signer

#### Properties
- private Amazon.Runtime.Internal.Auth.AWS4Signer AWS4SignerInstance { get; }
- public Amazon.Runtime.Internal.Auth.ClientProtocol Protocol { get; }

#### Constructors
- protected AbstractAWSSigner()

#### Methods
- protected static string ComputeHash(string data, string secretkey, Amazon.Runtime.SigningAlgorithm algorithm)
- protected static string ComputeHash(byte[] data, string secretkey, Amazon.Runtime.SigningAlgorithm algorithm)
- protected Amazon.Runtime.Internal.Auth.AbstractAWSSigner SelectSigner(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig config)
- protected Amazon.Runtime.Internal.Auth.AbstractAWSSigner SelectSigner(Amazon.Runtime.Internal.Auth.AbstractAWSSigner defaultSigner, bool useSigV4Setting, Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig config)
- public abstract void Sign(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig clientConfig, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
- protected static bool UseV4Signing(bool useSigV4Setting, Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig config)

### internal class Amazon.Runtime.Internal.Auth.AWS3HTTPSigner
- Base: Amazon.Runtime.Internal.Auth.AWS3Signer

#### Constructors
- public AWS3HTTPSigner()

### public class Amazon.Runtime.Internal.Auth.AWS3Signer
- Base: Amazon.Runtime.Internal.Auth.AbstractAWSSigner

#### Fields
- private bool <UseAws3Https>k__BackingField
- private static const string HTTPS_SCHEME
- private static const string HTTP_SCHEME
- private static const string Slash

#### Properties
- public Amazon.Runtime.Internal.Auth.ClientProtocol Protocol { get; }
- private bool UseAws3Https { get; set; }

#### Constructors
- public AWS3Signer()
- public AWS3Signer(bool useAws3Https)

#### Methods
- private static string GetCanonicalizedHeadersForStringToSign(Amazon.Runtime.Internal.IRequest request)
- private static string GetCanonicalizedQueryString(System.Collections.Generic.IDictionary<string, string> parameters)
- private static string GetCanonicalizedResourcePath(Amazon.Runtime.Internal.IRequest request)
- private static System.Collections.Generic.List<string> GetHeadersForStringToSign(Amazon.Runtime.Internal.IRequest request)
- private static string GetRequestPayload(Amazon.Runtime.Internal.IRequest request)
- private static string GetSignedHeadersComponent(Amazon.Runtime.Internal.IRequest request)
- private static bool IsHttpsRequest(Amazon.Runtime.Internal.IRequest request)
- public override void Sign(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig clientConfig, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
- private static void SignHttp(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
- private static void SignHttps(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig clientConfig, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)

### public class Amazon.Runtime.Internal.Auth.AWS4PreSignedUrlSigner
- Base: Amazon.Runtime.Internal.Auth.AWS4Signer

#### Fields
- public static const long MaxAWS4PreSignedUrlExpiry
- internal static const string XAmzAlgorithm
- internal static const string XAmzCredential
- internal static const string XAmzExpires
- internal static const string XAmzSignature

#### Constructors
- public AWS4PreSignedUrlSigner()

#### Methods
- public override void Sign(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig clientConfig, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
- public Amazon.Runtime.Internal.Auth.AWS4SigningResult SignRequest(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig clientConfig, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
- public static Amazon.Runtime.Internal.Auth.AWS4SigningResult SignRequest(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig clientConfig, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey, string service, string overrideSigningRegion)

### public class Amazon.Runtime.Internal.Auth.AWS4Signer
- Base: Amazon.Runtime.Internal.Auth.AbstractAWSSigner

#### Fields
- private bool <SignPayload>k__BackingField
- public static const string Algorithm
- public static const string AWS4AlgorithmTag
- public static const string AWSChunkedEncoding
- public static const string Credential
- public static const string EmptyBodySha256
- public static const string Scheme
- public static const string Signature
- public static const string SignedHeaders
- private static const Amazon.Runtime.SigningAlgorithm SignerAlgorithm
- public static const string StreamingBodySha256
- public static const string Terminator
- public static readonly byte[] TerminatorBytes
- public static const string UnsignedPayload
- private static System.Collections.Generic.IEnumerable<string> _headersToIgnoreWhenSigning

#### Properties
- public Amazon.Runtime.Internal.Auth.ClientProtocol Protocol { get; }
- public bool SignPayload { get; private set; }

#### Constructors
- public AWS4Signer()
- private static AWS4Signer()
- public AWS4Signer(bool signPayload)

#### Methods
- protected static string CanonicalizeHeaderNames(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> sortedHeaders)
- protected static string CanonicalizeHeaders(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> sortedHeaders)
- protected static string CanonicalizeQueryParameters(string queryString)
- protected static string CanonicalizeQueryParameters(string queryString, bool uriEncodeParameters)
- protected static string CanonicalizeQueryParameters(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> parameters)
- protected static string CanonicalizeQueryParameters(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> parameters, bool uriEncodeParameters)
- protected static string CanonicalizeRequest(System.Uri endpoint, string resourcePath, string httpMethod, System.Collections.Generic.IDictionary<string, string> sortedHeaders, string canonicalQueryString, string precomputedBodyHash)
- protected static string CanonicalizeRequest(System.Uri endpoint, string resourcePath, string httpMethod, System.Collections.Generic.IDictionary<string, string> sortedHeaders, string canonicalQueryString, string precomputedBodyHash, System.Collections.Generic.IDictionary<string, string> pathResources, int marshallerVersion)
- private static void CleanHeaders(System.Collections.Generic.IDictionary<string, string> headers)
- public static byte[] ComposeSigningKey(string awsSecretAccessKey, string region, string date, string service)
- public static byte[] ComputeHash(string data)
- public static byte[] ComputeHash(byte[] data)
- public static byte[] ComputeKeyedHash(Amazon.Runtime.SigningAlgorithm algorithm, byte[] key, string data)
- public static byte[] ComputeKeyedHash(Amazon.Runtime.SigningAlgorithm algorithm, byte[] key, byte[] data)
- public static Amazon.Runtime.Internal.Auth.AWS4SigningResult ComputeSignature(Amazon.Runtime.ImmutableCredentials credentials, string region, System.DateTime signedAt, string service, string signedHeaders, string canonicalRequest)
- public static Amazon.Runtime.Internal.Auth.AWS4SigningResult ComputeSignature(string awsAccessKey, string awsSecretAccessKey, string region, System.DateTime signedAt, string service, string signedHeaders, string canonicalRequest)
- public static Amazon.Runtime.Internal.Auth.AWS4SigningResult ComputeSignature(string awsAccessKey, string awsSecretAccessKey, string region, System.DateTime signedAt, string service, string signedHeaders, string canonicalRequest, Amazon.Runtime.Internal.Util.RequestMetrics metrics)
- internal static string DetermineService(Amazon.Runtime.IClientConfig clientConfig)
- public static string DetermineSigningRegion(Amazon.Runtime.IClientConfig clientConfig, string serviceName, Amazon.RegionEndpoint alternateEndpoint, Amazon.Runtime.Internal.IRequest request)
- public static string FormatDateTime(System.DateTime dt, string formatString)
- protected static System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>> GetParametersToCanonicalize(Amazon.Runtime.Internal.IRequest request)
- private static byte[] GetRequestPayloadBytes(Amazon.Runtime.Internal.IRequest request)
- public static System.DateTime InitializeHeaders(System.Collections.Generic.IDictionary<string, string> headers, System.Uri requestEndpoint)
- public static System.DateTime InitializeHeaders(System.Collections.Generic.IDictionary<string, string> headers, System.Uri requestEndpoint, System.DateTime requestDateTime)
- private static string SetPayloadSignatureHeader(Amazon.Runtime.Internal.IRequest request, string payloadHash)
- public static string SetRequestBodyHash(Amazon.Runtime.Internal.IRequest request)
- public static string SetRequestBodyHash(Amazon.Runtime.Internal.IRequest request, bool signPayload)
- public override void Sign(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig clientConfig, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
- public static byte[] SignBlob(byte[] key, string data)
- public static byte[] SignBlob(byte[] key, byte[] data)
- public Amazon.Runtime.Internal.Auth.AWS4SigningResult SignRequest(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig clientConfig, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
- protected static System.Collections.Generic.IDictionary<string, string> SortAndPruneHeaders(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> requestHeaders)

### public class Amazon.Runtime.Internal.Auth.AWS4SigningResult

#### Fields
- private readonly string _awsAccessKeyId
- private readonly System.DateTime _originalDateTime
- private readonly string _scope
- private readonly byte[] _signature
- private readonly string _signedHeaders
- private readonly byte[] _signingKey

#### Properties
- public string AccessKeyId { get; }
- public string ForAuthorizationHeader { get; }
- public string ForQueryParameters { get; }
- public string ISO8601Date { get; }
- public string ISO8601DateTime { get; }
- public string Scope { get; }
- public string Signature { get; }
- public byte[] SignatureBytes { get; }
- public string SignedHeaders { get; }
- public byte[] SigningKey { get; }

#### Constructors
- public AWS4SigningResult(string awsAccessKeyId, System.DateTime signedAt, string signedHeaders, string scope, byte[] signingKey, byte[] signature)

### public enum Amazon.Runtime.Internal.Auth.ClientProtocol
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- QueryStringProtocol = 0
- RestProtocol = 1
- Unknown = 2

### public class Amazon.Runtime.Internal.Auth.CloudFrontSigner
- Base: Amazon.Runtime.Internal.Auth.AbstractAWSSigner

#### Properties
- public Amazon.Runtime.Internal.Auth.ClientProtocol Protocol { get; }

#### Constructors
- public CloudFrontSigner()

#### Methods
- public override void Sign(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig clientConfig, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)

### public class Amazon.Runtime.Internal.Auth.NullSigner
- Base: Amazon.Runtime.Internal.Auth.AbstractAWSSigner

#### Properties
- public Amazon.Runtime.Internal.Auth.ClientProtocol Protocol { get; }

#### Constructors
- public NullSigner()

#### Methods
- public override void Sign(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig clientConfig, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)

### public class Amazon.Runtime.Internal.Auth.QueryStringSigner
- Base: Amazon.Runtime.Internal.Auth.AbstractAWSSigner

#### Fields
- private static const string SignatureVersion2

#### Properties
- public Amazon.Runtime.Internal.Auth.ClientProtocol Protocol { get; }

#### Constructors
- public QueryStringSigner()

#### Methods
- public override void Sign(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig clientConfig, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)

### public delegate Amazon.Runtime.Internal.Auth.S3Signer.RegionDetectionUpdater
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public S3Signer.RegionDetectionUpdater(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Amazon.Runtime.Internal.IRequest request, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Amazon.Runtime.Internal.IRequest request)

### public class Amazon.Runtime.Internal.Auth.S3Signer
- Base: Amazon.Runtime.Internal.Auth.AbstractAWSSigner

#### Fields
- private static readonly System.Collections.Generic.HashSet<string> SignableParameters
- private static readonly System.Collections.Generic.HashSet<string> SubResourcesSigningExclusion
- private readonly Amazon.Runtime.Internal.Auth.S3Signer.RegionDetectionUpdater _regionDetector
- private readonly bool _useSigV4

#### Properties
- public Amazon.Runtime.Internal.Auth.ClientProtocol Protocol { get; }

#### Constructors
- public S3Signer()
- private static S3Signer()
- public S3Signer(bool useSigV4, Amazon.Runtime.Internal.Auth.S3Signer.RegionDetectionUpdater regionDetector)

#### Methods
- private static string BuildCanonicalizedHeaders(System.Collections.Generic.IDictionary<string, string> headers)
- private static string BuildCanonicalizedResource(Amazon.Runtime.Internal.IRequest request)
- private static string BuildStringToSign(Amazon.Runtime.Internal.IRequest request)
- public override void Sign(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.IClientConfig clientConfig, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
- public static void SignRequest(Amazon.Runtime.Internal.IRequest request, Amazon.Runtime.Internal.Util.RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)

### public class Amazon.Runtime.Internal.Auth.SignatureException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public SignatureException(string message)
- public SignatureException(string message, System.Exception innerException)

## Namespace: Amazon.Runtime.Internal.Settings

### private class Amazon.Runtime.Internal.Settings.SettingsCollection.<GetEnumerator>d__11
- Interfaces: System.Collections.Generic.IEnumerator<Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings <>2__current
- public Amazon.Runtime.Internal.Settings.SettingsCollection <>4__this
- private System.Collections.Generic.Dictionary<TKey, TValue>.KeyCollection<TKey, TValue>.Enumerator<string, System.Collections.Generic.Dictionary<string, object>> <>7__wrap1

#### Properties
- private Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings System.Collections.Generic.IEnumerator<Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public SettingsCollection.<GetEnumerator>d__11(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private enum Amazon.Runtime.Internal.Settings.UserCrypto.CryptProtectFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CRYPTPROTECT_AUDIT = 16
- CRYPTPROTECT_CRED_SYNC = 8
- CRYPTPROTECT_LOCAL_MACHINE = 4
- CRYPTPROTECT_NO_RECOVERY = 32
- CRYPTPROTECT_UI_FORBIDDEN = 1
- CRYPTPROTECT_VERIFY_PROTECTION = 64

### private enum Amazon.Runtime.Internal.Settings.UserCrypto.CryptProtectPromptFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CRYPTPROTECT_PROMPT_ON_PROTECT = 2
- CRYPTPROTECT_PROMPT_ON_UNPROTECT = 1

### private struct Amazon.Runtime.Internal.Settings.UserCrypto.CRYPTPROTECT_PROMPTSTRUCT

#### Fields
- public int cbSize
- public Amazon.Runtime.Internal.Settings.UserCrypto.CryptProtectPromptFlags dwPromptFlags
- public System.IntPtr hwndApp
- public string szPrompt

### private struct Amazon.Runtime.Internal.Settings.UserCrypto.DATA_BLOB

#### Fields
- public int cbData
- public System.IntPtr pbData

### public class Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings

#### Fields
- private string _uniqueKey
- private System.Collections.Generic.Dictionary<string, object> _values

#### Properties
- public bool IsEmpty { get; }
- public string Item { get; set; }
- public System.Collections.Generic.IEnumerable<string> Keys { get; }
- public string UniqueKey { get; }

#### Constructors
- internal SettingsCollection.ObjectSettings(string uniqueKey, System.Collections.Generic.Dictionary<string, object> values)

#### Methods
- public void Clear()
- public string GetValueOrDefault(string key, string defaultValue)
- public void Remove(string key)
- internal void WriteToJson(ThirdParty.Json.LitJson.JsonWriter writer)

### public class Amazon.Runtime.Internal.Settings.PersistenceManager

#### Fields
- private static readonly Amazon.Runtime.Internal.Settings.PersistenceManager INSTANCE
- private static string SettingsStoreFolder
- private readonly System.Collections.Generic.HashSet<string> _encryptedKeys
- private readonly System.Collections.Generic.Dictionary<string, Amazon.Runtime.Internal.Settings.SettingsWatcher> _watchers

#### Properties
- public static Amazon.Runtime.Internal.Settings.PersistenceManager Instance { get; }

#### Constructors
- private static PersistenceManager()
- private PersistenceManager()

#### Methods
- private void decryptAnyEncryptedValues(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> settings)
- private void disableWatcher(string type)
- private void enableWatcher(string type)
- private static string getFileFromType(string type)
- public string GetSetting(string key)
- public Amazon.Runtime.Internal.Settings.SettingsCollection GetSettings(string type)
- public static string GetSettingsStoreFolder()
- internal bool IsEncrypted(string key)
- private Amazon.Runtime.Internal.Settings.SettingsCollection loadSettingsType(string type)
- public void SaveSettings(string type, Amazon.Runtime.Internal.Settings.SettingsCollection settings)
- private void saveSettingsType(string type, Amazon.Runtime.Internal.Settings.SettingsCollection settings)
- public void SetSetting(string key, string value)
- public Amazon.Runtime.Internal.Settings.SettingsWatcher Watch(string type)

### public class Amazon.Runtime.Internal.Settings.SettingsCollection
- Interfaces: System.Collections.Generic.IEnumerable<Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings>, System.Collections.IEnumerable

#### Fields
- private bool <InitializedEmpty>k__BackingField
- private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> _values

#### Properties
- public int Count { get; }
- public bool InitializedEmpty { get; private set; }
- public Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings Item { get; }

#### Constructors
- public SettingsCollection()
- public SettingsCollection(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> values)

#### Methods
- public void Clear()
- public System.Collections.Generic.IEnumerator<Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings> GetEnumerator()
- public Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings NewObjectSettings()
- public Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings NewObjectSettings(string uniqueKey)
- internal void Persist(System.IO.StreamWriter writer)
- public void Remove(string uniqueKey)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()

### public static class Amazon.Runtime.Internal.Settings.SettingsConstants

#### Fields
- public static const string AccessKeyField
- public static const string AccountNumberField
- public static const string AuthenticationTypeField
- public static const string CredentialProcess
- public static const string CredentialSourceField
- public static const string DisplayNameField
- public static const string EC2ConnectSettings
- public static const string EC2InstanceMapDrives
- public static const string EC2InstancePassword
- public static const string EC2InstanceSaveCredentials
- public static const string EC2InstanceUseKeyPair
- public static const string EC2InstanceUserName
- public static const string EndpointField
- public static const string EndpointNameField
- public static const string ExternalIDField
- public static const string HostedFilesLocation
- public static const string LastAcountSelectedKey
- public static const string LastVersionDoNotRemindMe
- public static const string MfaSerialField
- public static const string MiscSettings
- public static const string ProfileTypeField
- public static const string ProxyHost
- public static const string ProxyPasswordEncrypted
- public static const string ProxyPasswordObsolete
- public static const string ProxyPort
- public static const string ProxySettings
- public static const string ProxyUsernameEncrypted
- public static const string ProxyUsernameObsolete
- public static const string RecentUsages
- public static const string Region
- public static const string RegisteredProfiles
- public static const string RegisteredRoleSessions
- public static const string RegisteredSAMLEndpoints
- public static const string Restrictions
- public static const string RoleArnField
- public static const string RoleSession
- public static const string SecretKeyField
- public static const string SecretKeyRepository
- public static const string SessionTokenField
- public static const string SourceProfileField
- public static const string UserIdentityField
- public static const string UserPreferences
- public static const string VersionCheck

### public class Amazon.Runtime.Internal.Settings.SettingsWatcher
- Interfaces: System.IDisposable

#### Fields
- private bool <Enable>k__BackingField
- private System.EventHandler SettingsChanged
- private string type

#### Properties
- public bool Enable { get; set; }

#### Events
- public event System.EventHandler SettingsChanged

#### Constructors
- private SettingsWatcher()
- internal SettingsWatcher(string filePath, string type)

#### Methods
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- public Amazon.Runtime.Internal.Settings.SettingsCollection GetSettings()

### public static class Amazon.Runtime.Internal.Settings.UserCrypto

#### Fields
- private static System.Nullable<bool> _isUserCryptAvailable

#### Properties
- public static bool IsUserCryptAvailable { get; }

#### Methods
- private static Amazon.Runtime.Internal.Settings.UserCrypto.DATA_BLOB ConvertData(byte[] data)
- private static bool CryptProtectData(ref Amazon.Runtime.Internal.Settings.UserCrypto.DATA_BLOB pDataIn, string szDataDescr, ref Amazon.Runtime.Internal.Settings.UserCrypto.DATA_BLOB pOptionalEntropy, System.IntPtr pvReserved, ref Amazon.Runtime.Internal.Settings.UserCrypto.CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, Amazon.Runtime.Internal.Settings.UserCrypto.CryptProtectFlags dwFlags, ref Amazon.Runtime.Internal.Settings.UserCrypto.DATA_BLOB pDataOut)
- private static bool CryptUnprotectData(ref Amazon.Runtime.Internal.Settings.UserCrypto.DATA_BLOB pDataIn, string szDataDescr, ref Amazon.Runtime.Internal.Settings.UserCrypto.DATA_BLOB pOptionalEntropy, System.IntPtr pvReserved, ref Amazon.Runtime.Internal.Settings.UserCrypto.CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, Amazon.Runtime.Internal.Settings.UserCrypto.CryptProtectFlags dwFlags, ref Amazon.Runtime.Internal.Settings.UserCrypto.DATA_BLOB pDataOut)
- public static string Decrypt(string encrypted)
- public static string Encrypt(string unencrypted)

## Namespace: Amazon.Runtime.Internal.Transform

### public class Amazon.Runtime.Internal.Transform.BoolUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<bool, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<bool, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.BoolUnmarshaller _instance

#### Properties
- public static Amazon.Runtime.Internal.Transform.BoolUnmarshaller Instance { get; }

#### Constructors
- private BoolUnmarshaller()
- private static BoolUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.BoolUnmarshaller GetInstance()
- public bool Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public bool Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.ByteUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<byte, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<byte, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.ByteUnmarshaller _instance

#### Properties
- public static Amazon.Runtime.Internal.Transform.ByteUnmarshaller Instance { get; }

#### Constructors
- private ByteUnmarshaller()
- private static ByteUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.ByteUnmarshaller GetInstance()
- public byte Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public byte Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public static class Amazon.Runtime.Internal.Transform.CustomMarshallTransformations

#### Methods
- public static long ConvertDateTimeToEpochMilliseconds(System.DateTime dateTime)

### public class Amazon.Runtime.Internal.Transform.DateTimeEpochLongMillisecondsUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<System.DateTime, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<System.DateTime, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.DateTimeEpochLongMillisecondsUnmarshaller _instance

#### Properties
- public static Amazon.Runtime.Internal.Transform.DateTimeEpochLongMillisecondsUnmarshaller Instance { get; }

#### Constructors
- private DateTimeEpochLongMillisecondsUnmarshaller()
- private static DateTimeEpochLongMillisecondsUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.DateTimeEpochLongMillisecondsUnmarshaller GetInstance()
- public System.DateTime Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public System.DateTime Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.DateTimeUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<System.DateTime, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<System.DateTime, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.DateTimeUnmarshaller _instance

#### Properties
- public static Amazon.Runtime.Internal.Transform.DateTimeUnmarshaller Instance { get; }

#### Constructors
- private DateTimeUnmarshaller()
- private static DateTimeUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.DateTimeUnmarshaller GetInstance()
- public System.DateTime Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public System.DateTime Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- internal static System.Nullable<System.DateTime> UnmarshallInternal(string text, bool treatAsNullable)

### public class Amazon.Runtime.Internal.Transform.DecimalUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<decimal, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<decimal, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.DecimalUnmarshaller _instance

#### Properties
- public static Amazon.Runtime.Internal.Transform.DecimalUnmarshaller Instance { get; }

#### Constructors
- private DecimalUnmarshaller()
- private static DecimalUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.DecimalUnmarshaller GetInstance()
- public decimal Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public decimal Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.DictionaryUnmarshaller<TKey, TValue, TKeyUnmarshaller, TValueUnmarshaller>
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<System.Collections.Generic.Dictionary<TKey, TValue>, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<System.Collections.Generic.Dictionary<TKey, TValue>, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private Amazon.Runtime.Internal.Transform.KeyValueUnmarshaller<TKey, TValue, TKeyUnmarshaller, TValueUnmarshaller> KVUnmarshaller

#### Constructors
- public DictionaryUnmarshaller<TKey, TValue, TKeyUnmarshaller, TValueUnmarshaller>(TKeyUnmarshaller kUnmarshaller, TValueUnmarshaller vUnmarshaller)

#### Methods
- public System.Collections.Generic.Dictionary<TKey, TValue> Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public System.Collections.Generic.Dictionary<TKey, TValue> Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.DoubleUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<double, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<double, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.DoubleUnmarshaller _instance

#### Properties
- public static Amazon.Runtime.Internal.Transform.DoubleUnmarshaller Instance { get; }

#### Constructors
- private DoubleUnmarshaller()
- private static DoubleUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.DoubleUnmarshaller GetInstance()
- public double Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public double Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.EC2ResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.XmlResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Constructors
- protected EC2ResponseUnmarshaller()

#### Methods
- protected override Amazon.Runtime.Internal.Transform.UnmarshallerContext ConstructUnmarshallerContext(System.IO.Stream responseStream, bool maintainResponseBody, Amazon.Runtime.Internal.Transform.IWebResponseData response)
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.UnmarshallerContext input)

### public class Amazon.Runtime.Internal.Transform.EC2UnmarshallerContext
- Base: Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext
- Interfaces: System.IDisposable

#### Fields
- private string <RequestId>k__BackingField

#### Properties
- public string RequestId { get; private set; }

#### Constructors
- public EC2UnmarshallerContext(System.IO.Stream responseStream, bool maintainResponseBody, Amazon.Runtime.Internal.Transform.IWebResponseData responseData)

#### Methods
- public override bool Read()

### public class Amazon.Runtime.Internal.Transform.ErrorResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.Internal.ErrorResponse, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.ErrorResponseUnmarshaller instance

#### Constructors
- public ErrorResponseUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.ErrorResponseUnmarshaller GetInstance()
- private static void PopulateErrorResponseFromXmlIfPossible(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse response)
- private static bool TryReadContext(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.Runtime.Internal.ErrorResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.FloatUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<float, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<float, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.FloatUnmarshaller _instance

#### Properties
- public static Amazon.Runtime.Internal.Transform.FloatUnmarshaller Instance { get; }

#### Constructors
- private FloatUnmarshaller()
- private static FloatUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.FloatUnmarshaller GetInstance()
- public float Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public float Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.HttpClientResponseData
- Interfaces: Amazon.Runtime.Internal.Transform.IWebResponseData

#### Fields
- private long <ContentLength>k__BackingField
- private string <ContentType>k__BackingField
- private bool <IsSuccessStatusCode>k__BackingField
- private System.Net.HttpStatusCode <StatusCode>k__BackingField
- private string[] _headerNames
- private System.Collections.Generic.HashSet<string> _headerNamesSet
- private System.Collections.Generic.Dictionary<string, string> _headers
- private Amazon.Runtime.Internal.Transform.HttpResponseMessageBody _response

#### Properties
- public long ContentLength { get; private set; }
- public string ContentType { get; private set; }
- public bool IsSuccessStatusCode { get; private set; }
- public Amazon.Runtime.Internal.Transform.IHttpResponseBody ResponseBody { get; }
- public System.Net.HttpStatusCode StatusCode { get; private set; }

#### Constructors
- internal HttpClientResponseData(System.Net.Http.HttpResponseMessage response)
- internal HttpClientResponseData(System.Net.Http.HttpResponseMessage response, System.Net.Http.HttpClient httpClient, bool disposeClient)

#### Methods
- private void CopyHeaderValues(System.Net.Http.HttpResponseMessage response)
- private string GetFirstHeaderValue(System.Net.Http.Headers.HttpHeaders headers, string key)
- public string[] GetHeaderNames()
- public string GetHeaderValue(string headerName)
- public bool IsHeaderPresent(string headerName)

### public class Amazon.Runtime.Internal.Transform.HttpResponseMessageBody
- Interfaces: Amazon.Runtime.Internal.Transform.IHttpResponseBody, System.IDisposable

#### Fields
- private bool _disposeClient
- private bool _disposed
- private System.Net.Http.HttpClient _httpClient
- private System.Net.Http.HttpResponseMessage _response

#### Constructors
- public HttpResponseMessageBody(System.Net.Http.HttpResponseMessage response, System.Net.Http.HttpClient httpClient, bool disposeClient)

#### Methods
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- public System.IO.Stream OpenResponse()
- public System.Threading.Tasks.Task<System.IO.Stream> OpenResponseAsync()

### public interface Amazon.Runtime.Internal.Transform.IHttpResponseBody
- Interfaces: System.IDisposable

#### Methods
- public System.IO.Stream OpenResponse()
- public System.Threading.Tasks.Task<System.IO.Stream> OpenResponseAsync()

### public interface Amazon.Runtime.Internal.Transform.IMarshaller<T, R>

#### Methods
- public T Marshall(R input)

### public class Amazon.Runtime.Internal.Transform.IntUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<int, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<int, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.IntUnmarshaller _instance

#### Properties
- public static Amazon.Runtime.Internal.Transform.IntUnmarshaller Instance { get; }

#### Constructors
- private IntUnmarshaller()
- private static IntUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.IntUnmarshaller GetInstance()
- public int Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public int Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public interface Amazon.Runtime.Internal.Transform.IRequestMarshaller<R, T>

#### Methods
- public void Marshall(R requestObject, T context)

### public interface Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<T, R>
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<T, R>

#### Methods
- public Amazon.Runtime.AmazonServiceException UnmarshallException(R input, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public interface Amazon.Runtime.Internal.Transform.IUnmarshaller<T, R>

#### Methods
- public T Unmarshall(R input)

### public interface Amazon.Runtime.Internal.Transform.IWebResponseData

#### Properties
- public long ContentLength { get; }
- public string ContentType { get; }
- public bool IsSuccessStatusCode { get; }
- public Amazon.Runtime.Internal.Transform.IHttpResponseBody ResponseBody { get; }
- public System.Net.HttpStatusCode StatusCode { get; }

#### Methods
- public string[] GetHeaderNames()
- public string GetHeaderValue(string headerName)
- public bool IsHeaderPresent(string headerName)

### public class Amazon.Runtime.Internal.Transform.JsonErrorResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.Internal.ErrorResponse, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.JsonErrorResponseUnmarshaller instance

#### Constructors
- public JsonErrorResponseUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.JsonErrorResponseUnmarshaller GetInstance()
- private static void GetValuesFromJsonIfPossible(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context, out string type, out string message, out string code)
- private static bool TryReadContext(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)
- public Amazon.Runtime.Internal.ErrorResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.JsonMarshallerContext
- Base: Amazon.Runtime.Internal.Transform.MarshallerContext

#### Fields
- private ThirdParty.Json.LitJson.JsonWriter <Writer>k__BackingField

#### Properties
- public ThirdParty.Json.LitJson.JsonWriter Writer { get; private set; }

#### Constructors
- public JsonMarshallerContext(Amazon.Runtime.Internal.IRequest request, ThirdParty.Json.LitJson.JsonWriter writer)

### private class Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext.JsonPathStack

#### Fields
- private int currentDepth
- private System.Collections.Generic.Stack<string> stack
- private string stackString
- private System.Text.StringBuilder stackStringBuilder

#### Properties
- public int Count { get; }
- public int CurrentDepth { get; }
- public string CurrentPath { get; }

#### Constructors
- public JsonUnmarshallerContext.JsonPathStack()

#### Methods
- public string Peek()
- public string Pop()
- public void Push(string value)

### public class Amazon.Runtime.Internal.Transform.JsonResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.ResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Constructors
- protected JsonResponseUnmarshaller()

#### Methods
- protected override Amazon.Runtime.Internal.Transform.UnmarshallerContext ConstructUnmarshallerContext(System.IO.Stream responseStream, bool maintainResponseBody, Amazon.Runtime.Internal.Transform.IWebResponseData response)
- protected override bool ShouldReadEntireResponse(Amazon.Runtime.Internal.Transform.IWebResponseData response, bool readEntireResponse)
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.UnmarshallerContext input)
- public abstract Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext input)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.UnmarshallerContext input, System.Exception innerException, System.Net.HttpStatusCode statusCode)
- public abstract Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext input, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext
- Base: Amazon.Runtime.Internal.Transform.UnmarshallerContext
- Interfaces: System.IDisposable

#### Fields
- private string currentField
- private System.Nullable<ThirdParty.Json.LitJson.JsonToken> currentToken
- private static const string DELIMITER
- private bool disposed
- private ThirdParty.Json.LitJson.JsonReader jsonReader
- private Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext.JsonPathStack stack
- private System.IO.StreamReader streamReader
- private bool wasPeeked

#### Properties
- public int CurrentDepth { get; }
- public string CurrentPath { get; }
- public ThirdParty.Json.LitJson.JsonToken CurrentTokenType { get; }
- public bool IsEndElement { get; }
- public bool IsStartElement { get; }
- public bool IsStartOfDocument { get; }
- public System.IO.Stream Stream { get; }

#### Constructors
- public JsonUnmarshallerContext(System.IO.Stream responseStream, bool maintainResponseBody, Amazon.Runtime.Internal.Transform.IWebResponseData responseData)

#### Methods
- protected override void Dispose(bool disposing)
- public bool Peek(ThirdParty.Json.LitJson.JsonToken token)
- public int Peek()
- public override bool Read()
- public override string ReadText()
- private int StreamPeek()
- private void UpdateContext()

### public class Amazon.Runtime.Internal.Transform.KeyValueUnmarshaller<K, V, KUnmarshaller, VUnmarshaller>
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<System.Collections.Generic.KeyValuePair<K, V>, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<System.Collections.Generic.KeyValuePair<K, V>, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private KUnmarshaller keyUnmarshaller
- private VUnmarshaller valueUnmarshaller

#### Constructors
- public KeyValueUnmarshaller<K, V, KUnmarshaller, VUnmarshaller>(KUnmarshaller keyUnmarshaller, VUnmarshaller valueUnmarshaller)

#### Methods
- public System.Collections.Generic.KeyValuePair<K, V> Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public System.Collections.Generic.KeyValuePair<K, V> Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.ListUnmarshaller<I, IUnmarshaller>
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<System.Collections.Generic.List<I>, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<System.Collections.Generic.List<I>, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private IUnmarshaller iUnmarshaller

#### Constructors
- public ListUnmarshaller<I, IUnmarshaller>(IUnmarshaller iUnmarshaller)

#### Methods
- public System.Collections.Generic.List<I> Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public System.Collections.Generic.List<I> Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.LongUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<long, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<long, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.LongUnmarshaller _instance

#### Properties
- public static Amazon.Runtime.Internal.Transform.LongUnmarshaller Instance { get; }

#### Constructors
- private LongUnmarshaller()
- private static LongUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.LongUnmarshaller GetInstance()
- public long Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public long Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.MarshallerContext

#### Fields
- private Amazon.Runtime.Internal.IRequest <Request>k__BackingField

#### Properties
- public Amazon.Runtime.Internal.IRequest Request { get; private set; }

#### Constructors
- protected MarshallerContext(Amazon.Runtime.Internal.IRequest request)

### public class Amazon.Runtime.Internal.Transform.MemoryStreamUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<System.IO.MemoryStream, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<System.IO.MemoryStream, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.MemoryStreamUnmarshaller _instance

#### Properties
- public static Amazon.Runtime.Internal.Transform.MemoryStreamUnmarshaller Instance { get; }

#### Constructors
- private MemoryStreamUnmarshaller()
- private static MemoryStreamUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.MemoryStreamUnmarshaller GetInstance()
- public System.IO.MemoryStream Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public System.IO.MemoryStream Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.NullableDateTimeUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<System.Nullable<System.DateTime>, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.NullableDateTimeUnmarshaller _instance

#### Properties
- public static Amazon.Runtime.Internal.Transform.NullableDateTimeUnmarshaller Instance { get; }

#### Constructors
- private NullableDateTimeUnmarshaller()
- private static NullableDateTimeUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.NullableDateTimeUnmarshaller GetInstance()
- public System.Nullable<System.DateTime> Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.NullableIntUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<System.Nullable<int>, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.NullableIntUnmarshaller _instance

#### Properties
- public static Amazon.Runtime.Internal.Transform.NullableIntUnmarshaller Instance { get; }

#### Constructors
- private NullableIntUnmarshaller()
- private static NullableIntUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.NullableIntUnmarshaller GetInstance()
- public System.Nullable<int> Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.ResponseMetadataUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.ResponseMetadata, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.ResponseMetadata, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.ResponseMetadataUnmarshaller _instance

#### Properties
- public static Amazon.Runtime.Internal.Transform.ResponseMetadataUnmarshaller Instance { get; }

#### Constructors
- private ResponseMetadataUnmarshaller()
- private static ResponseMetadataUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.ResponseMetadataUnmarshaller GetInstance()
- public Amazon.Runtime.ResponseMetadata Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public Amazon.Runtime.ResponseMetadata Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.ResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Properties
- public bool HasStreamingProperty { get; }

#### Constructors
- protected ResponseUnmarshaller()

#### Methods
- protected abstract Amazon.Runtime.Internal.Transform.UnmarshallerContext ConstructUnmarshallerContext(System.IO.Stream responseStream, bool maintainResponseBody, Amazon.Runtime.Internal.Transform.IWebResponseData response)
- public virtual Amazon.Runtime.Internal.Transform.UnmarshallerContext CreateContext(Amazon.Runtime.Internal.Transform.IWebResponseData response, bool readEntireResponse, System.IO.Stream stream, Amazon.Runtime.Internal.Util.RequestMetrics metrics)
- public static string GetDefaultErrorMessage<T>()
- protected virtual bool ShouldReadEntireResponse(Amazon.Runtime.Internal.Transform.IWebResponseData response, bool readEntireResponse)
- public abstract Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.UnmarshallerContext input)
- public virtual Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.UnmarshallerContext input, System.Exception innerException, System.Net.HttpStatusCode statusCode)
- public Amazon.Runtime.AmazonWebServiceResponse UnmarshallResponse(Amazon.Runtime.Internal.Transform.UnmarshallerContext context)

### internal static class Amazon.Runtime.Internal.Transform.SimpleTypeUnmarshaller<T>

#### Methods
- public static T Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public static T Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.StringUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IUnmarshaller<string, Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<string, Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext>

#### Fields
- private static Amazon.Runtime.Internal.Transform.StringUnmarshaller _instance

#### Properties
- public static Amazon.Runtime.Internal.Transform.StringUnmarshaller Instance { get; }

#### Constructors
- private StringUnmarshaller()
- private static StringUnmarshaller()

#### Methods
- public static Amazon.Runtime.Internal.Transform.StringUnmarshaller GetInstance()
- public string Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext context)
- public string Unmarshall(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext context)

### public class Amazon.Runtime.Internal.Transform.UnmarshallerContext
- Interfaces: System.IDisposable

#### Fields
- private int <Crc32Result>k__BackingField
- private ThirdParty.Ionic.Zlib.CrcCalculatorStream <CrcStream>k__BackingField
- private bool <MaintainResponseBody>k__BackingField
- private Amazon.Runtime.Internal.Transform.IWebResponseData <WebResponseData>k__BackingField
- private Amazon.Runtime.Internal.Util.CachingWrapperStream <WrappingStream>k__BackingField
- private bool disposed

#### Properties
- protected int Crc32Result { get; set; }
- protected ThirdParty.Ionic.Zlib.CrcCalculatorStream CrcStream { get; set; }
- public int CurrentDepth { get; }
- public string CurrentPath { get; }
- public bool IsEndElement { get; }
- public bool IsStartElement { get; }
- public bool IsStartOfDocument { get; }
- protected bool MaintainResponseBody { get; set; }
- public string ResponseBody { get; }
- public Amazon.Runtime.Internal.Transform.IWebResponseData ResponseData { get; }
- protected Amazon.Runtime.Internal.Transform.IWebResponseData WebResponseData { get; set; }
- protected Amazon.Runtime.Internal.Util.CachingWrapperStream WrappingStream { get; set; }

#### Constructors
- protected UnmarshallerContext()

#### Methods
- protected virtual void Dispose(bool disposing)
- public void Dispose()
- public byte[] GetResponseBodyBytes()
- public abstract bool Read()
- public bool ReadAtDepth(int targetDepth)
- public abstract string ReadText()
- protected void SetupCRCStream(Amazon.Runtime.Internal.Transform.IWebResponseData responseData, System.IO.Stream responseStream, long contentLength)
- public bool TestExpression(string expression)
- public bool TestExpression(string expression, int startingStackDepth)
- private static bool TestExpression(string expression, string currentPath)
- private static bool TestExpression(string expression, int startingStackDepth, string currentPath, int currentDepth)
- internal void ValidateCRC32IfAvailable()

### public static class Amazon.Runtime.Internal.Transform.UnmarshallerExtensions

#### Methods
- public static void Add<TKey, TValue>(System.Collections.Generic.Dictionary<TKey, TValue> dict, System.Collections.Generic.KeyValuePair<TKey, TValue> item)

### public class Amazon.Runtime.Internal.Transform.XmlMarshallerContext
- Base: Amazon.Runtime.Internal.Transform.MarshallerContext

#### Fields
- private System.Xml.XmlWriter <Writer>k__BackingField

#### Properties
- public System.Xml.XmlWriter Writer { get; private set; }

#### Constructors
- public XmlMarshallerContext(Amazon.Runtime.Internal.IRequest request, System.Xml.XmlWriter writer)

### public class Amazon.Runtime.Internal.Transform.XmlResponseUnmarshaller
- Base: Amazon.Runtime.Internal.Transform.ResponseUnmarshaller
- Interfaces: Amazon.Runtime.Internal.Transform.IResponseUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>, Amazon.Runtime.Internal.Transform.IUnmarshaller<Amazon.Runtime.AmazonWebServiceResponse, Amazon.Runtime.Internal.Transform.UnmarshallerContext>

#### Constructors
- protected XmlResponseUnmarshaller()

#### Methods
- protected override Amazon.Runtime.Internal.Transform.UnmarshallerContext ConstructUnmarshallerContext(System.IO.Stream responseStream, bool maintainResponseBody, Amazon.Runtime.Internal.Transform.IWebResponseData response)
- public override Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.UnmarshallerContext input)
- public abstract Amazon.Runtime.AmazonWebServiceResponse Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext input)
- public override Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.UnmarshallerContext input, System.Exception innerException, System.Net.HttpStatusCode statusCode)
- public abstract Amazon.Runtime.AmazonServiceException UnmarshallException(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext input, System.Exception innerException, System.Net.HttpStatusCode statusCode)

### public class Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext
- Base: Amazon.Runtime.Internal.Transform.UnmarshallerContext
- Interfaces: System.IDisposable

#### Fields
- private System.Collections.Generic.IEnumerator<string> attributeEnumerator
- private System.Collections.Generic.List<string> attributeNames
- private System.Collections.Generic.Dictionary<string, string> attributeValues
- private bool disposed
- private string nodeContent
- private static System.Collections.Generic.HashSet<System.Xml.XmlNodeType> nodesToSkip
- private System.Xml.XmlNodeType nodeType
- private static readonly System.Xml.XmlReaderSettings READER_SETTINGS
- private System.Collections.Generic.Stack<string> stack
- private string stackString
- private System.IO.StreamReader streamReader
- private System.Xml.XmlReader _xmlReader

#### Properties
- public int CurrentDepth { get; }
- public string CurrentPath { get; }
- public bool IsAttribute { get; }
- public bool IsEndElement { get; }
- public bool IsStartElement { get; }
- public bool IsStartOfDocument { get; }
- public System.IO.Stream Stream { get; }
- private System.Xml.XmlReader XmlReader { get; }

#### Constructors
- private static XmlUnmarshallerContext()
- public XmlUnmarshallerContext(System.IO.Stream responseStream, bool maintainResponseBody, Amazon.Runtime.Internal.Transform.IWebResponseData responseData)

#### Methods
- protected override void Dispose(bool disposing)
- public override bool Read()
- private void ReadElement()
- public override string ReadText()
- private static string StackToPath(System.Collections.Generic.Stack<string> stack)

## Namespace: Amazon.Runtime.Internal.Util

### private struct Amazon.Runtime.Internal.Util.AsyncHelpers.<>c__DisplayClass0_1.<<RunSync>b__0>d
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.Util.AsyncHelpers.<>c__DisplayClass0_1 <>4__this
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.Internal.Util.AsyncHelpers.<>c__DisplayClass1_1<T>.<<RunSync>b__0>d<T>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.Internal.Util.AsyncHelpers.<>c__DisplayClass1_1<T> <>4__this
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<T> <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Amazon.Runtime.Internal.Util.ChunkedUploadWrapperStream.<>c

#### Fields
- public static readonly Amazon.Runtime.Internal.Util.ChunkedUploadWrapperStream.<>c <>9
- public static System.Func<System.IO.Stream, bool> <>9__14_0

#### Constructors
- private static ChunkedUploadWrapperStream.<>c()
- public ChunkedUploadWrapperStream.<>c()

#### Methods
- internal bool <.ctor>b__14_0(System.IO.Stream s)

### private class Amazon.Runtime.Internal.Util.BackgroundInvoker.<>c

#### Fields
- public static readonly Amazon.Runtime.Internal.Util.BackgroundInvoker.<>c <>9
- public static System.Action<System.Action> <>9__0_0

#### Constructors
- private static BackgroundInvoker.<>c()
- public BackgroundInvoker.<>c()

#### Methods
- internal void <.ctor>b__0_0(System.Action action)

### private class Amazon.Runtime.Internal.Util.Hashing.<>c

#### Fields
- public static readonly Amazon.Runtime.Internal.Util.Hashing.<>c <>9
- public static System.Func<object, int> <>9__0_0

#### Constructors
- private static Hashing.<>c()
- public Hashing.<>c()

#### Methods
- internal int <Hash>b__0_0(object v)

### private class Amazon.Runtime.Internal.Util.RequestMetrics.<>c

#### Fields
- public static readonly Amazon.Runtime.Internal.Util.RequestMetrics.<>c <>9
- public static System.Func<Amazon.Runtime.Metric, string> <>9__33_0

#### Constructors
- private static RequestMetrics.<>c()
- public RequestMetrics.<>c()

#### Methods
- internal string <GetErrors>b__33_0(Amazon.Runtime.Metric k)

### private class Amazon.Runtime.Internal.Util.AsyncHelpers.<>c__DisplayClass0_0

#### Fields
- public System.Func<System.Threading.Tasks.Task> task

#### Constructors
- public AsyncHelpers.<>c__DisplayClass0_0()

### private class Amazon.Runtime.Internal.Util.AsyncHelpers.<>c__DisplayClass0_1

#### Fields
- public Amazon.Runtime.Internal.Util.AsyncHelpers.<>c__DisplayClass0_0 CS$<>8__locals1
- public Amazon.Runtime.Internal.Util.AsyncHelpers.ExclusiveSynchronizationContext synch

#### Constructors
- public AsyncHelpers.<>c__DisplayClass0_1()

#### Methods
- internal void <RunSync>b__0(object _)

### private class Amazon.Runtime.Internal.Util.AsyncHelpers.<>c__DisplayClass1_0<T>

#### Fields
- public System.Func<System.Threading.Tasks.Task<T>> task

#### Constructors
- public AsyncHelpers.<>c__DisplayClass1_0<T>()

### private class Amazon.Runtime.Internal.Util.AsyncHelpers.<>c__DisplayClass1_1<T>

#### Fields
- public Amazon.Runtime.Internal.Util.AsyncHelpers.<>c__DisplayClass1_0<T> CS$<>8__locals1
- public T ret
- public Amazon.Runtime.Internal.Util.AsyncHelpers.ExclusiveSynchronizationContext synch

#### Constructors
- public AsyncHelpers.<>c__DisplayClass1_1<T>()

#### Methods
- internal void <RunSync>b__0(object _)

### private class Amazon.Runtime.Internal.Util.SdkCache.<>c__DisplayClass5_0<TKey, TValue>

#### Fields
- public System.Collections.Generic.IEqualityComparer<TKey> keyComparer

#### Constructors
- public SdkCache.<>c__DisplayClass5_0<TKey, TValue>()

#### Methods
- internal Amazon.Runtime.Internal.Util.ICache <GetCache>b__0(Amazon.Runtime.Internal.Util.SdkCache.CacheKey k)

### public class Amazon.Runtime.Internal.Util.AESDecryptionStream
- Base: Amazon.Runtime.Internal.Util.DecryptStream<Amazon.Runtime.Internal.Util.DecryptionWrapperAES>
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Constructors
- public AESDecryptionStream(System.IO.Stream baseStream, byte[] key, byte[] IV)

### public class Amazon.Runtime.Internal.Util.AESEncryptionPutObjectStream
- Base: Amazon.Runtime.Internal.Util.EncryptStream<Amazon.Runtime.Internal.Util.EncryptionWrapperAES>
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Constructors
- public AESEncryptionPutObjectStream(System.IO.Stream baseStream, byte[] key, byte[] IV)

### public class Amazon.Runtime.Internal.Util.AESEncryptionUploadPartStream
- Base: Amazon.Runtime.Internal.Util.EncryptUploadPartStream<Amazon.Runtime.Internal.Util.EncryptionWrapperAES>
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Constructors
- public AESEncryptionUploadPartStream(System.IO.Stream baseStream, byte[] key, byte[] IV)

### internal class Amazon.Runtime.Internal.Util.AlwaysSendDictionary<TKey, TValue>
- Base: System.Collections.Generic.Dictionary<TKey, TValue>
- Interfaces: System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback

#### Constructors
- public AlwaysSendDictionary<TKey, TValue>()
- public AlwaysSendDictionary<TKey, TValue>(System.Collections.Generic.IEqualityComparer<TKey> comparer)
- public AlwaysSendDictionary<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> dictionary)

### internal class Amazon.Runtime.Internal.Util.AlwaysSendList<T>
- Base: System.Collections.Generic.List<T>
- Interfaces: System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IReadOnlyCollection<T>

#### Constructors
- public AlwaysSendList<T>()
- public AlwaysSendList<T>(System.Collections.Generic.IEnumerable<T> collection)

### public static class Amazon.Runtime.Internal.Util.AsyncHelpers

#### Methods
- public static void RunSync(System.Func<System.Threading.Tasks.Task> task)
- public static T RunSync<T>(System.Func<System.Threading.Tasks.Task<T>> task)

### internal class Amazon.Runtime.Internal.Util.BackgroundDispatcher<T>
- Interfaces: System.IDisposable

#### Fields
- private bool <IsRunning>k__BackingField
- private System.Action<T> action
- private System.Threading.Thread backgroundThread
- private bool isDisposed
- private static const int MAX_QUEUE_SIZE
- private System.Collections.Generic.Queue<T> queue
- private System.Threading.AutoResetEvent resetEvent
- private bool shouldStop

#### Properties
- public bool IsRunning { get; private set; }

#### Constructors
- public BackgroundDispatcher<T>(System.Action<T> action)

#### Methods
- public void Dispatch(T data)
- protected virtual void Dispose(bool disposing)
- public void Dispose()
- protected override void Finalize()
- private void HandleInvoked()
- private void Run()
- public void Stop()

### internal class Amazon.Runtime.Internal.Util.BackgroundInvoker
- Base: Amazon.Runtime.Internal.Util.BackgroundDispatcher<System.Action>
- Interfaces: System.IDisposable

#### Constructors
- public BackgroundInvoker()

### private class Amazon.Runtime.Internal.Util.Cache<TKey, TValue>.CacheItem<TKey, TValue, T>

#### Fields
- private System.DateTime <LastUseTime>k__BackingField
- private T _value

#### Properties
- public System.DateTime LastUseTime { get; private set; }
- public T Value { get; private set; }

#### Constructors
- public Cache<TKey, TValue>.CacheItem<TKey, TValue, T>(T value)

### internal class Amazon.Runtime.Internal.Util.SdkCache.CacheKey

#### Fields
- private object <CacheType>k__BackingField
- private Amazon.Runtime.ImmutableCredentials <ImmutableCredentials>k__BackingField
- private Amazon.RegionEndpoint <RegionEndpoint>k__BackingField
- private string <ServiceUrl>k__BackingField

#### Properties
- public object CacheType { get; private set; }
- public Amazon.Runtime.ImmutableCredentials ImmutableCredentials { get; private set; }
- public Amazon.RegionEndpoint RegionEndpoint { get; private set; }
- public string ServiceUrl { get; private set; }

#### Constructors
- private SdkCache.CacheKey()

#### Methods
- public static Amazon.Runtime.Internal.Util.SdkCache.CacheKey Create(Amazon.Runtime.AmazonServiceClient client, object cacheType)
- public static Amazon.Runtime.Internal.Util.SdkCache.CacheKey Create(object cacheType)
- public override bool Equals(object obj)
- public override int GetHashCode()

### internal class Amazon.Runtime.Internal.Util.Cache<TKey, TValue>
- Interfaces: Amazon.Runtime.Internal.Util.ICache<TKey, TValue>, Amazon.Runtime.Internal.Util.ICache

#### Fields
- private System.DateTime <LastCacheClean>k__BackingField
- private System.TimeSpan cacheClearPeriod
- private readonly object CacheLock
- private System.Collections.Generic.Dictionary<TKey, Amazon.Runtime.Internal.Util.Cache<TKey, TValue>.CacheItem<TKey, TValue, TValue>> Contents
- public static System.TimeSpan DefaultCacheClearPeriod
- public static System.TimeSpan DefaultMaximumItemLifespan
- private System.TimeSpan maximumItemLifespan

#### Properties
- public System.TimeSpan CacheClearPeriod { get; set; }
- public int ItemCount { get; }
- public System.Collections.Generic.List<TKey> Keys { get; }
- public System.DateTime LastCacheClean { get; private set; }
- public System.TimeSpan MaximumItemLifespan { get; set; }

#### Constructors
- private static Cache<TKey, TValue>()
- public Cache<TKey, TValue>(System.Collections.Generic.IEqualityComparer<TKey> keyComparer = null)

#### Methods
- public void Clear(TKey key)
- public void Clear()
- private static System.DateTime GetCorrectedLocalTime()
- public TValue GetValue(TKey key, System.Func<TKey, TValue> creator)
- public TValue GetValue(TKey key, System.Func<TKey, TValue> creator, out bool isStaleItem)
- private TValue GetValueHelper(TKey key, out bool isStaleItem, System.Func<TKey, TValue> creator = null)
- private bool IsValidItem(Amazon.Runtime.Internal.Util.Cache<TKey, TValue>.CacheItem<TKey, TValue, TValue> item)
- private void RemoveOldItems_Locked()
- public TOut UseCache<TOut>(TKey key, System.Func<TOut> operation, System.Action onError, System.Predicate<System.Exception> shouldRetryForException)

### public class Amazon.Runtime.Internal.Util.CachingWrapperStream
- Base: Amazon.Runtime.Internal.Util.WrapperStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private System.Collections.Generic.List<byte> <AllReadBytes>k__BackingField
- private int _cachedBytes
- private int _cacheLimit

#### Properties
- public System.Collections.Generic.List<byte> AllReadBytes { get; private set; }
- public bool CanSeek { get; }
- public long Position { get; set; }

#### Constructors
- public CachingWrapperStream(System.IO.Stream baseStream, int cacheLimit)

#### Methods
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)

### public class Amazon.Runtime.Internal.Util.ChunkedUploadWrapperStream
- Base: Amazon.Runtime.Internal.Util.WrapperStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private Amazon.Runtime.Internal.Auth.AWS4SigningResult <HeaderSigningResult>k__BackingField
- private string <PreviousChunkSignature>k__BackingField
- private static const string CHUNK_SIGNATURE_HEADER
- private static const string CHUNK_STRING_TO_SIGN_PREFIX
- private static const string CLRF
- public static readonly int DefaultChunkSize
- private static const int SIGNATURE_LENGTH
- private byte[] _inputBuffer
- private readonly byte[] _outputBuffer
- private int _outputBufferDataLen
- private bool _outputBufferIsTerminatingChunk
- private int _outputBufferPos
- private readonly Amazon.Runtime.Internal.Util.ChunkedUploadWrapperStream.ReadStrategy _readStrategy
- private readonly int _wrappedStreamBufferSize
- private bool _wrappedStreamConsumed

#### Properties
- public bool CanSeek { get; }
- internal bool HasLength { get; }
- private Amazon.Runtime.Internal.Auth.AWS4SigningResult HeaderSigningResult { get; set; }
- public long Length { get; }
- private string PreviousChunkSignature { get; set; }

#### Constructors
- private static ChunkedUploadWrapperStream()
- internal ChunkedUploadWrapperStream(System.IO.Stream stream, int wrappedStreamBufferSize, Amazon.Runtime.Internal.Auth.AWS4SigningResult headerSigningResult)

#### Methods
- private static long CalculateChunkHeaderLength(long chunkDataSize)
- public static long ComputeChunkedContentLength(long originalLength)
- private void ConstructOutputBufferChunk(int dataLen)
- private int FillInputBuffer()
- public override int Read(byte[] buffer, int offset, int count)

### public class Amazon.Runtime.Internal.Util.DecryptionWrapper
- Interfaces: Amazon.Runtime.Internal.Util.IDecryptionWrapper

#### Fields
- private System.Security.Cryptography.SymmetricAlgorithm algorithm
- private System.Security.Cryptography.ICryptoTransform decryptor
- private static const int encryptionKeySize

#### Properties
- public System.Security.Cryptography.ICryptoTransform Transformer { get; }

#### Constructors
- protected DecryptionWrapper()

#### Methods
- protected abstract System.Security.Cryptography.SymmetricAlgorithm CreateAlgorithm()
- public void CreateDecryptor()
- public void SetDecryptionData(byte[] key, byte[] IV)

### public class Amazon.Runtime.Internal.Util.DecryptionWrapperAES
- Base: Amazon.Runtime.Internal.Util.DecryptionWrapper
- Interfaces: Amazon.Runtime.Internal.Util.IDecryptionWrapper

#### Constructors
- public DecryptionWrapperAES()

#### Methods
- protected override System.Security.Cryptography.SymmetricAlgorithm CreateAlgorithm()

### public class Amazon.Runtime.Internal.Util.DecryptStream
- Base: Amazon.Runtime.Internal.Util.WrapperStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private Amazon.Runtime.Internal.Util.IDecryptionWrapper <Algorithm>k__BackingField
- private System.Security.Cryptography.CryptoStream <CryptoStream>k__BackingField

#### Properties
- protected Amazon.Runtime.Internal.Util.IDecryptionWrapper Algorithm { get; set; }
- public bool CanSeek { get; }
- protected System.Security.Cryptography.CryptoStream CryptoStream { get; set; }
- public long Position { get; set; }

#### Constructors
- protected DecryptStream(System.IO.Stream baseStream)

#### Methods
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- private void ValidateBaseStream()

### public class Amazon.Runtime.Internal.Util.DecryptStream<T>
- Base: Amazon.Runtime.Internal.Util.DecryptStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Constructors
- public DecryptStream<T>(System.IO.Stream baseStream, byte[] envelopeKey, byte[] IV)

### public class Amazon.Runtime.Internal.Util.EncryptionWrapper
- Interfaces: Amazon.Runtime.Internal.Util.IEncryptionWrapper

#### Fields
- private System.Security.Cryptography.SymmetricAlgorithm algorithm
- private static const int encryptionKeySize
- private System.Security.Cryptography.ICryptoTransform encryptor

#### Constructors
- protected EncryptionWrapper()

#### Methods
- public int AppendBlock(byte[] buffer, int offset, int count, byte[] target, int targetOffset)
- public byte[] AppendLastBlock(byte[] buffer, int offset, int count)
- protected abstract System.Security.Cryptography.SymmetricAlgorithm CreateAlgorithm()
- public void CreateEncryptor()
- public void Reset()
- public void SetEncryptionData(byte[] key, byte[] IV)

### public class Amazon.Runtime.Internal.Util.EncryptionWrapperAES
- Base: Amazon.Runtime.Internal.Util.EncryptionWrapper
- Interfaces: Amazon.Runtime.Internal.Util.IEncryptionWrapper

#### Constructors
- public EncryptionWrapperAES()

#### Methods
- protected override System.Security.Cryptography.SymmetricAlgorithm CreateAlgorithm()

### public class Amazon.Runtime.Internal.Util.EncryptStream
- Base: Amazon.Runtime.Internal.Util.WrapperStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private Amazon.Runtime.Internal.Util.IEncryptionWrapper <Algorithm>k__BackingField
- private byte[] internalBuffer
- private static const int internalEncryptionBlockSize
- private bool performedLastBlockTransform

#### Properties
- protected Amazon.Runtime.Internal.Util.IEncryptionWrapper Algorithm { get; set; }
- public bool CanSeek { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- protected EncryptStream(System.IO.Stream baseStream)

#### Methods
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- private void ValidateBaseStream()

### public class Amazon.Runtime.Internal.Util.EncryptStream<T>
- Base: Amazon.Runtime.Internal.Util.EncryptStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Constructors
- public EncryptStream<T>(System.IO.Stream baseStream, byte[] key, byte[] IV)

### public class Amazon.Runtime.Internal.Util.EncryptUploadPartStream
- Base: Amazon.Runtime.Internal.Util.WrapperStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private Amazon.Runtime.Internal.Util.IEncryptionWrapper <Algorithm>k__BackingField
- private byte[] <InitializationVector>k__BackingField
- private byte[] internalBuffer
- internal static const int InternalEncryptionBlockSize

#### Properties
- protected Amazon.Runtime.Internal.Util.IEncryptionWrapper Algorithm { get; set; }
- public bool CanSeek { get; }
- public byte[] InitializationVector { get; protected set; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- protected EncryptUploadPartStream(System.IO.Stream baseStream)

#### Methods
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- private void ValidateBaseStream()

### public class Amazon.Runtime.Internal.Util.EncryptUploadPartStream<T>
- Base: Amazon.Runtime.Internal.Util.EncryptUploadPartStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Constructors
- public EncryptUploadPartStream<T>(System.IO.Stream baseStream, byte[] key, byte[] IV)

### public static class Amazon.Runtime.Internal.Util.EndianConversionUtility

#### Methods
- public static long HostToNetworkOrder(long host)
- public static int HostToNetworkOrder(int host)
- public static short HostToNetworkOrder(short host)
- public static long NetworkToHostOrder(long network)
- public static int NetworkToHostOrder(int network)
- public static short NetworkToHostOrder(short network)

### internal class Amazon.Runtime.Internal.Util.EventStream
- Base: Amazon.Runtime.Internal.Util.WrapperStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private bool disableClose
- private Amazon.Runtime.Internal.Util.EventStream.ReadProgress OnRead

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanTimeout { get; }
- public bool CanWrite { get; }
- public long Length { get; }
- public long Position { get; set; }
- public int ReadTimeout { get; set; }
- public int WriteTimeout { get; set; }

#### Events
- internal event Amazon.Runtime.Internal.Util.EventStream.ReadProgress OnRead

#### Constructors
- internal EventStream(System.IO.Stream stream, bool disableClose)

#### Methods
- protected override void Dispose(bool disposing)
- public override void Flush()
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public override void Write(byte[] buffer, int offset, int count)
- public override void WriteByte(byte value)

### private class Amazon.Runtime.Internal.Util.AsyncHelpers.ExclusiveSynchronizationContext
- Base: System.Threading.SynchronizationContext

#### Fields
- private System.Exception <InnerException>k__BackingField
- private bool done
- private readonly System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback, object>> items
- private readonly System.Threading.AutoResetEvent workItemsWaiting

#### Properties
- public System.Exception InnerException { get; set; }

#### Constructors
- public AsyncHelpers.ExclusiveSynchronizationContext()

#### Methods
- private void <EndMessageLoop>b__9_0(object _)
- public void BeginMessageLoop()
- public override System.Threading.SynchronizationContext CreateCopy()
- public void EndMessageLoop()
- public override void Post(System.Threading.SendOrPostCallback d, object state)
- public override void Send(System.Threading.SendOrPostCallback d, object state)

### public static class Amazon.Runtime.Internal.Util.Extensions

#### Fields
- private static readonly double TickFrequency
- private static readonly long TicksPerSecond

#### Constructors
- private static Extensions()

#### Methods
- public static long GetElapsedDateTimeTicks(System.Diagnostics.Stopwatch self)
- public static bool HasRequestData(Amazon.Runtime.Internal.IRequest request)

### public static class Amazon.Runtime.Internal.Util.GuidUtils

#### Methods
- public static bool TryParseGuid(string value, out System.Guid result)
- public static bool TryParseNullableGuid(string value, out System.Nullable<System.Guid> result)

### public static class Amazon.Runtime.Internal.Util.Hashing

#### Methods
- public static int CombineHashes(params int[] hashes)
- private static int CombineHashesInternal(int a, int b)
- public static int Hash(params object[] value)

### public class Amazon.Runtime.Internal.Util.HashingWrapper
- Interfaces: Amazon.Runtime.Internal.Util.IHashingWrapper, System.IDisposable

#### Fields
- private static string MD5ManagedName
- private ThirdParty.MD5.MD5Managed _algorithm

#### Constructors
- private static HashingWrapper()
- public HashingWrapper(string algorithmName)

#### Methods
- public void AppendBlock(byte[] buffer)
- public void AppendBlock(byte[] buffer, int offset, int count)
- public byte[] AppendLastBlock(byte[] buffer)
- public byte[] AppendLastBlock(byte[] buffer, int offset, int count)
- public void Clear()
- public byte[] ComputeHash(byte[] buffer)
- public byte[] ComputeHash(System.IO.Stream stream)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- private void Init(string algorithmName)

### public class Amazon.Runtime.Internal.Util.HashingWrapperMD5
- Base: Amazon.Runtime.Internal.Util.HashingWrapper
- Interfaces: Amazon.Runtime.Internal.Util.IHashingWrapper, System.IDisposable

#### Constructors
- public HashingWrapperMD5()

### public class Amazon.Runtime.Internal.Util.HashStream
- Base: Amazon.Runtime.Internal.Util.WrapperStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private Amazon.Runtime.Internal.Util.IHashingWrapper <Algorithm>k__BackingField
- private byte[] <CalculatedHash>k__BackingField
- private long <CurrentPosition>k__BackingField
- private byte[] <ExpectedHash>k__BackingField
- private long <ExpectedLength>k__BackingField

#### Properties
- protected Amazon.Runtime.Internal.Util.IHashingWrapper Algorithm { get; set; }
- public byte[] CalculatedHash { get; protected set; }
- public bool CanSeek { get; }
- protected long CurrentPosition { get; private set; }
- public byte[] ExpectedHash { get; private set; }
- public long ExpectedLength { get; protected set; }
- protected bool FinishedHashing { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- protected HashStream(System.IO.Stream baseStream, byte[] expectedHash, long expectedLength)

#### Methods
- public virtual void CalculateHash()
- protected static bool CompareHashes(byte[] expected, byte[] actual)
- protected override void Dispose(bool disposing)
- public override int Read(byte[] buffer, int offset, int count)
- public void Reset()
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- private void ValidateBaseStream()

### public class Amazon.Runtime.Internal.Util.HashStream<T>
- Base: Amazon.Runtime.Internal.Util.HashStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Constructors
- public HashStream<T>(System.IO.Stream baseStream, byte[] expectedHash, long expectedLength)

### public static class Amazon.Runtime.Internal.Util.HostPrefixUtils

#### Fields
- private static System.Text.RegularExpressions.Regex labelValidationRegex

#### Constructors
- private static HostPrefixUtils()

#### Methods
- public static bool IsValidLabelValue(string value)

### public interface Amazon.Runtime.Internal.Util.ICache

#### Properties
- public System.TimeSpan CacheClearPeriod { get; set; }
- public int ItemCount { get; }
- public System.TimeSpan MaximumItemLifespan { get; set; }

#### Methods
- public void Clear()

### public interface Amazon.Runtime.Internal.Util.ICache<TKey, TValue>
- Interfaces: Amazon.Runtime.Internal.Util.ICache

#### Properties
- public System.Collections.Generic.List<TKey> Keys { get; }

#### Methods
- public void Clear(TKey key)
- public TValue GetValue(TKey key, System.Func<TKey, TValue> creator)
- public TValue GetValue(TKey key, System.Func<TKey, TValue> creator, out bool isStaleItem)
- public TOut UseCache<TOut>(TKey key, System.Func<TOut> operation, System.Action onError, System.Predicate<System.Exception> shouldRetryForException)

### public interface Amazon.Runtime.Internal.Util.IDecryptionWrapper

#### Properties
- public System.Security.Cryptography.ICryptoTransform Transformer { get; }

#### Methods
- public void CreateDecryptor()
- public void SetDecryptionData(byte[] key, byte[] IV)

### public interface Amazon.Runtime.Internal.Util.IEncryptionWrapper

#### Methods
- public int AppendBlock(byte[] buffer, int offset, int count, byte[] target, int targetOffset)
- public byte[] AppendLastBlock(byte[] buffer, int offset, int count)
- public void CreateEncryptor()
- public void Reset()
- public void SetEncryptionData(byte[] key, byte[] IV)

### public interface Amazon.Runtime.Internal.Util.IHashingWrapper
- Interfaces: System.IDisposable

#### Methods
- public void AppendBlock(byte[] buffer)
- public void AppendBlock(byte[] buffer, int offset, int count)
- public byte[] AppendLastBlock(byte[] buffer)
- public byte[] AppendLastBlock(byte[] buffer, int offset, int count)
- public void Clear()
- public byte[] ComputeHash(byte[] buffer)
- public byte[] ComputeHash(System.IO.Stream stream)

### public interface Amazon.Runtime.Internal.Util.ILogger

#### Methods
- public void Debug(System.Exception exception, string messageFormat, params object[] args)
- public void DebugFormat(string messageFormat, params object[] args)
- public void Error(System.Exception exception, string messageFormat, params object[] args)
- public void Flush()
- public void InfoFormat(string messageFormat, params object[] args)

### public class Amazon.Runtime.Internal.Util.IniFile

#### Fields
- private static const string hashComment
- private static const string keyValueSeparator
- private Amazon.Runtime.Internal.Util.Logger logger
- private static const string sectionNamePrefix
- private static const string sectionNameSuffix
- private static const string semiColonComment
- private Amazon.Runtime.Internal.Util.OptimisticLockedTextFile textFile

#### Properties
- public string FilePath { get; }
- private System.Collections.Generic.List<string> Lines { get; }

#### Constructors
- public IniFile(string filePath)

#### Methods
- public void CopySection(string fromSectionName, string toSectionName, System.Collections.Generic.Dictionary<string, string> replaceProperties)
- public void CopySection(string fromSectionName, string toSectionName, System.Collections.Generic.Dictionary<string, string> replaceProperties, bool force)
- public void DeleteSection(string sectionName)
- public void EditSection(string sectionName, System.Collections.Generic.SortedDictionary<string, string> properties)
- public void EnsureSectionExists(string sectionName)
- private string GetErrorMessage(int lineNumber)
- private string GetLineMessage(int lineNumber)
- private static string GetPropertyLine(string propertyName, string propertyValue)
- private static bool IsCommentOrBlank(string line)
- private bool IsDuplicateProperty(System.Collections.Generic.Dictionary<string, string> properties, string propertyName, string sectionName, int lineNumber)
- private static bool IsProperty(string line)
- private static bool IsSection(string line)
- public virtual System.Collections.Generic.HashSet<string> ListSectionNames()
- public void Persist()
- public void RenameSection(string oldSectionName, string newSectionName)
- public void RenameSection(string oldSectionName, string newSectionName, bool force)
- public bool SectionExists(string sectionName)
- private bool SeekProperty(ref int lineNumber, out string propertyName, out string propertyValue)
- private bool SeekSection(ref int lineNumber, out string sectionName)
- public override string ToString()
- public virtual bool TryGetSection(string sectionName, out System.Collections.Generic.Dictionary<string, string> properties)
- public bool TryGetSection(System.Text.RegularExpressions.Regex sectionNameRegex, out System.Collections.Generic.Dictionary<string, string> properties)
- public bool TryGetSection(System.Text.RegularExpressions.Regex sectionNameRegex, out string sectionName, out System.Collections.Generic.Dictionary<string, string> properties)
- private static bool TryParseProperty(string line, out string propertyName, out string propertyValue)
- private static bool TryParseSection(string line, out string sectionName)
- private bool TrySeekSection(System.Text.RegularExpressions.Regex sectionNameRegex, ref int lineNumber, out string sectionName)
- private bool TrySeekSection(string sectionName, ref int lineNumber)
- private void Validate()

### internal class Amazon.Runtime.Internal.Util.InternalConsoleLogger
- Base: Amazon.Runtime.Internal.Util.InternalLogger

#### Fields
- public static long _sequanceId

#### Constructors
- public InternalConsoleLogger(System.Type declaringType)

#### Methods
- public override void Debug(System.Exception exception, string messageFormat, params object[] args)
- public override void DebugFormat(string message, params object[] arguments)
- public override void Error(System.Exception exception, string messageFormat, params object[] args)
- public override void Flush()
- public override void InfoFormat(string message, params object[] arguments)
- private void Log(Amazon.Runtime.Internal.Util.InternalConsoleLogger.LogLevel logLevel, string message, System.Exception ex)

### internal class Amazon.Runtime.Internal.Util.InternalLog4netLogger
- Base: Amazon.Runtime.Internal.Util.InternalLogger

#### Fields
- private static object debugLevelPropertyValue
- private static object errorLevelPropertyValue
- private static System.Reflection.MethodInfo getLoggerWithTypeMethod
- private static object infoLevelPropertyValue
- private object internalLogger
- private System.Nullable<bool> isDebugEnabled
- private static System.Reflection.MethodInfo isEnabledForMethod
- private System.Nullable<bool> isErrorEnabled
- private System.Nullable<bool> isInfoEnabled
- private static System.Type levelType
- private static Amazon.Util.Internal.ITypeInfo levelTypeInfo
- private static Amazon.Runtime.Internal.Util.InternalLog4netLogger.LoadState loadState
- private static readonly object LOCK
- private static System.Type loggerType
- private static System.Type logMangerType
- private static Amazon.Util.Internal.ITypeInfo logMangerTypeInfo
- private static System.Reflection.MethodInfo logMethod
- private static System.Type logType
- private static Amazon.Util.Internal.ITypeInfo logTypeInfo
- private static System.Type systemStringFormatType

#### Properties
- public bool IsDebugEnabled { get; }
- public bool IsErrorEnabled { get; }
- public bool IsInfoEnabled { get; }

#### Constructors
- private static InternalLog4netLogger()
- public InternalLog4netLogger(System.Type declaringType)

#### Methods
- public override void Debug(System.Exception exception, string messageFormat, params object[] args)
- public override void DebugFormat(string message, params object[] arguments)
- public override void Error(System.Exception exception, string messageFormat, params object[] args)
- public override void Flush()
- public override void InfoFormat(string message, params object[] arguments)
- private static void loadStatics()

### internal class Amazon.Runtime.Internal.Util.InternalLogger

#### Fields
- private System.Type <DeclaringType>k__BackingField
- private bool <IsEnabled>k__BackingField

#### Properties
- public System.Type DeclaringType { get; private set; }
- public bool IsDebugEnabled { get; }
- public bool IsEnabled { get; set; }
- public bool IsErrorEnabled { get; }
- public bool IsInfoEnabled { get; }

#### Constructors
- public InternalLogger(System.Type declaringType)

#### Methods
- public abstract void Debug(System.Exception exception, string messageFormat, params object[] args)
- public abstract void DebugFormat(string message, params object[] arguments)
- public abstract void Error(System.Exception exception, string messageFormat, params object[] args)
- public abstract void Flush()
- public abstract void InfoFormat(string message, params object[] arguments)

### internal class Amazon.Runtime.Internal.Util.InternalSystemDiagnosticsLogger
- Base: Amazon.Runtime.Internal.Util.InternalLogger

#### Fields
- private int eventId
- private System.Diagnostics.TraceSource trace

#### Properties
- public bool IsDebugEnabled { get; }
- public bool IsErrorEnabled { get; }
- public bool IsInfoEnabled { get; }

#### Constructors
- public InternalSystemDiagnosticsLogger(System.Type declaringType)

#### Methods
- public override void Debug(System.Exception exception, string messageFormat, params object[] args)
- public override void DebugFormat(string messageFormat, params object[] args)
- public override void Error(System.Exception exception, string messageFormat, params object[] args)
- public override void Flush()
- public override void InfoFormat(string message, params object[] arguments)

### private enum Amazon.Runtime.Internal.Util.InternalLog4netLogger.LoadState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Failed = 1
- Loading = 2
- Success = 3
- Uninitialized = 0

### public class Amazon.Runtime.Internal.Util.Logger
- Interfaces: Amazon.Runtime.Internal.Util.ILogger

#### Fields
- private static System.Collections.Generic.IDictionary<System.Type, Amazon.Runtime.Internal.Util.Logger> cachedLoggers
- private static Amazon.Runtime.Internal.Util.Logger emptyLogger
- private System.Collections.Generic.List<Amazon.Runtime.Internal.Util.InternalLogger> loggers

#### Properties
- public static Amazon.Runtime.Internal.Util.Logger EmptyLogger { get; }

#### Constructors
- private Logger()
- private static Logger()
- private Logger(System.Type type)

#### Methods
- public static void ClearLoggerCache()
- private void ConfigsChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
- private void ConfigureLoggers()
- public void Debug(System.Exception exception, string messageFormat, params object[] args)
- public void DebugFormat(string messageFormat, params object[] args)
- public void Error(System.Exception exception, string messageFormat, params object[] args)
- public void Flush()
- public static Amazon.Runtime.Internal.Util.Logger GetLogger(System.Type type)
- public void InfoFormat(string messageFormat, params object[] args)

### private enum Amazon.Runtime.Internal.Util.InternalConsoleLogger.LogLevel
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Assert = 7
- Debug = 3
- Error = 6
- Info = 4
- Verbose = 2
- Warn = 5

### public class Amazon.Runtime.Internal.Util.LogMessage
- Interfaces: Amazon.Runtime.ILogMessage

#### Fields
- private object[] <Args>k__BackingField
- private string <Format>k__BackingField
- private System.IFormatProvider <Provider>k__BackingField

#### Properties
- public object[] Args { get; private set; }
- public string Format { get; private set; }
- public System.IFormatProvider Provider { get; private set; }

#### Constructors
- public LogMessage(string message)
- public LogMessage(string format, params object[] args)
- public LogMessage(System.IFormatProvider provider, string format, params object[] args)

#### Methods
- public override string ToString()

### public class Amazon.Runtime.Internal.Util.LruCache<TKey, TValue>

#### Fields
- private int <MaxEntries>k__BackingField
- private System.Collections.Generic.Dictionary<TKey, Amazon.Runtime.Internal.Util.LruListItem<TKey, TValue>> cache
- private readonly object cacheLock
- private Amazon.Runtime.Internal.Util.LruList<TKey, TValue> lruList

#### Properties
- public int Count { get; }
- public int MaxEntries { get; private set; }

#### Constructors
- public LruCache<TKey, TValue>(int maxEntries)

#### Methods
- public void AddOrUpdate(TKey key, TValue value)
- public void Clear()
- public void Evict(TKey key)
- public TValue GetOrAdd(TKey key, System.Func<TKey, TValue> factory)
- public bool TryGetValue(TKey key, out TValue value)

### public class Amazon.Runtime.Internal.Util.LruListItem<TKey, TValue>

#### Fields
- private TKey <Key>k__BackingField
- private Amazon.Runtime.Internal.Util.LruListItem<TKey, TValue> <Next>k__BackingField
- private Amazon.Runtime.Internal.Util.LruListItem<TKey, TValue> <Previous>k__BackingField
- private TValue <Value>k__BackingField

#### Properties
- public TKey Key { get; private set; }
- public Amazon.Runtime.Internal.Util.LruListItem<TKey, TValue> Next { get; set; }
- public Amazon.Runtime.Internal.Util.LruListItem<TKey, TValue> Previous { get; set; }
- public TValue Value { get; set; }

#### Constructors
- public LruListItem<TKey, TValue>(TKey key, TValue value)

### public class Amazon.Runtime.Internal.Util.LruList<TKey, TValue>

#### Fields
- private Amazon.Runtime.Internal.Util.LruListItem<TKey, TValue> <Head>k__BackingField
- private Amazon.Runtime.Internal.Util.LruListItem<TKey, TValue> <Tail>k__BackingField

#### Properties
- public Amazon.Runtime.Internal.Util.LruListItem<TKey, TValue> Head { get; private set; }
- public Amazon.Runtime.Internal.Util.LruListItem<TKey, TValue> Tail { get; private set; }

#### Constructors
- public LruList<TKey, TValue>()

#### Methods
- public void Add(Amazon.Runtime.Internal.Util.LruListItem<TKey, TValue> item)
- internal void Clear()
- public TKey EvictOldest()
- public void Remove(Amazon.Runtime.Internal.Util.LruListItem<TKey, TValue> item)
- public void Touch(Amazon.Runtime.Internal.Util.LruListItem<TKey, TValue> item)

### public class Amazon.Runtime.Internal.Util.MD5Stream
- Base: Amazon.Runtime.Internal.Util.HashStream<Amazon.Runtime.Internal.Util.HashingWrapperMD5>
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private Amazon.Runtime.Internal.Util.Logger _logger

#### Constructors
- public MD5Stream(System.IO.Stream baseStream, byte[] expectedHash, long expectedLength)

### public class Amazon.Runtime.Internal.Util.MetricError

#### Fields
- private System.Exception <Exception>k__BackingField
- private string <Message>k__BackingField
- private Amazon.Runtime.Metric <Metric>k__BackingField
- private System.DateTime <Time>k__BackingField

#### Properties
- public System.Exception Exception { get; private set; }
- public string Message { get; private set; }
- public Amazon.Runtime.Metric Metric { get; private set; }
- public System.DateTime Time { get; private set; }

#### Constructors
- public MetricError(Amazon.Runtime.Metric metric, string messageFormat, params object[] args)
- public MetricError(Amazon.Runtime.Metric metric, System.Exception exception, string messageFormat, params object[] args)

### public class Amazon.Runtime.Internal.Util.NonDisposingWrapperStream
- Base: Amazon.Runtime.Internal.Util.WrapperStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Constructors
- public NonDisposingWrapperStream(System.IO.Stream baseStream)

#### Methods
- protected override void Dispose(bool disposing)

### internal class Amazon.Runtime.Internal.Util.NullStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- public NullStream()

#### Methods
- public override void Flush()
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public override void Write(byte[] buffer, int offset, int count)

### public class Amazon.Runtime.Internal.Util.OptimisticLockedTextFile

#### Fields
- private string <FilePath>k__BackingField
- private System.Collections.Generic.List<string> <Lines>k__BackingField
- private string <OriginalContents>k__BackingField

#### Properties
- public string FilePath { get; private set; }
- public System.Collections.Generic.List<string> Lines { get; private set; }
- private string OriginalContents { get; set; }

#### Constructors
- public OptimisticLockedTextFile(string filePath)

#### Methods
- private static bool HasEnding(string line)
- public void Persist()
- private void Read()
- private static System.Collections.Generic.List<string> ReadLinesWithEndings(string str)
- public override string ToString()

### public class Amazon.Runtime.Internal.Util.PartialReadOnlyWrapperStream
- Base: Amazon.Runtime.Internal.Util.ReadOnlyWrapperStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private long _currentPosition
- private long _size

#### Properties
- public long Length { get; }
- public long Position { get; }
- private long RemainingSize { get; }

#### Constructors
- public PartialReadOnlyWrapperStream(System.IO.Stream baseStream, long size)

#### Methods
- public override int Read(byte[] buffer, int offset, int count)

### public class Amazon.Runtime.Internal.Util.PartialWrapperStream
- Base: Amazon.Runtime.Internal.Util.WrapperStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private long initialPosition
- private long partSize

#### Properties
- public long Length { get; }
- public long Position { get; set; }
- private long RemainingPartSize { get; }

#### Constructors
- public PartialWrapperStream(System.IO.Stream stream, long partSize)

#### Methods
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public override void Write(byte[] buffer, int offset, int count)
- public override void WriteByte(byte value)

### public class Amazon.Runtime.Internal.Util.ProfileIniFile
- Base: Amazon.Runtime.Internal.Util.IniFile

#### Fields
- private bool <ProfileMarkerRequired>k__BackingField
- private static const string ProfileMarker

#### Properties
- public bool ProfileMarkerRequired { get; set; }

#### Constructors
- public ProfileIniFile(string filePath, bool profileMarkerRequired)

#### Methods
- public override System.Collections.Generic.HashSet<string> ListSectionNames()
- public override bool TryGetSection(string sectionName, out System.Collections.Generic.Dictionary<string, string> properties)

### public class Amazon.Runtime.Internal.Util.ReadOnlyWrapperStream
- Base: Amazon.Runtime.Internal.Util.WrapperStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- public ReadOnlyWrapperStream(System.IO.Stream baseStream)

#### Methods
- public override void Flush()
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public override void Write(byte[] buffer, int offset, int count)

### internal delegate Amazon.Runtime.Internal.Util.EventStream.ReadProgress
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public EventStream.ReadProgress(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(int bytesRead, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(int bytesRead)

### private enum Amazon.Runtime.Internal.Util.ChunkedUploadWrapperStream.ReadStrategy
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ReadAndCopy = 1
- ReadDirect = 0

### public class Amazon.Runtime.Internal.Util.RequestMetrics
- Interfaces: Amazon.Runtime.IRequestMetrics

#### Fields
- private System.Collections.Generic.Dictionary<Amazon.Runtime.Metric, long> <Counters>k__BackingField
- private bool <IsEnabled>k__BackingField
- private System.Collections.Generic.Dictionary<Amazon.Runtime.Metric, System.Collections.Generic.List<object>> <Properties>k__BackingField
- private System.Collections.Generic.Dictionary<Amazon.Runtime.Metric, System.Collections.Generic.List<Amazon.Runtime.IMetricsTiming>> <Timings>k__BackingField
- private System.Collections.Generic.List<Amazon.Runtime.Internal.Util.MetricError> errors
- private System.Collections.Generic.Dictionary<Amazon.Runtime.Metric, Amazon.Runtime.Internal.Util.Timing> inFlightTimings
- private object metricsLock
- private System.Diagnostics.Stopwatch stopWatch

#### Properties
- public System.Collections.Generic.Dictionary<Amazon.Runtime.Metric, long> Counters { get; set; }
- private long CurrentTime { get; }
- public bool IsEnabled { get; internal set; }
- public System.Collections.Generic.Dictionary<Amazon.Runtime.Metric, System.Collections.Generic.List<object>> Properties { get; set; }
- public System.Collections.Generic.Dictionary<Amazon.Runtime.Metric, System.Collections.Generic.List<Amazon.Runtime.IMetricsTiming>> Timings { get; set; }

#### Constructors
- public RequestMetrics()

#### Methods
- public void AddProperty(Amazon.Runtime.Metric metric, object property)
- public string GetErrors()
- public void IncrementCounter(Amazon.Runtime.Metric metric)
- private static void Log(System.Text.StringBuilder builder, Amazon.Runtime.Metric metric, object metricValue)
- private static void Log(System.Text.StringBuilder builder, Amazon.Runtime.Metric metric, System.Collections.Generic.List<object> metricValues)
- private void LogError_Locked(Amazon.Runtime.Metric metric, string messageFormat, params object[] args)
- private static void LogHelper(System.Text.StringBuilder builder, Amazon.Runtime.Metric metric, params object[] metricValues)
- private static string ObjectToString(object data)
- public void SetCounter(Amazon.Runtime.Metric metric, long value)
- public Amazon.Runtime.Internal.Util.TimingEvent StartEvent(Amazon.Runtime.Metric metric)
- public Amazon.Runtime.Internal.Util.Timing StopEvent(Amazon.Runtime.Metric metric)
- public string ToJSON()
- public override string ToString()

### public class Amazon.Runtime.Internal.Util.S3Uri

#### Fields
- private string <Bucket>k__BackingField
- private bool <IsPathStyle>k__BackingField
- private string <Key>k__BackingField
- private Amazon.RegionEndpoint <Region>k__BackingField
- private static const string S3ControlExlusionPattern
- private static readonly System.Text.RegularExpressions.Regex S3ControlExlusionRegex
- private static const string S3EndpointPattern
- private static readonly System.Text.RegularExpressions.Regex S3EndpointRegex

#### Properties
- public string Bucket { get; private set; }
- public bool IsPathStyle { get; private set; }
- public string Key { get; private set; }
- public Amazon.RegionEndpoint Region { get; set; }

#### Constructors
- private static S3Uri()
- public S3Uri(string uri)
- public S3Uri(System.Uri uri)

#### Methods
- private static void AppendDecoded(System.Text.StringBuilder builder, string s, int index)
- private static string Decode(string s)
- private static string Decode(string s, int firstPercent)
- private static int FromHex(char c)
- public static bool IsS3Uri(System.Uri uri)

### public static class Amazon.Runtime.Internal.Util.SdkCache

#### Fields
- private static Amazon.Runtime.Internal.Util.Cache<Amazon.Runtime.Internal.Util.SdkCache.CacheKey, Amazon.Runtime.Internal.Util.ICache> cache
- private static object cacheLock

#### Constructors
- private static SdkCache()

#### Methods
- public static void Clear()
- public static void Clear(object cacheType)
- public static Amazon.Runtime.Internal.Util.ICache<TKey, TValue> GetCache<TKey, TValue>(object client, object cacheIdentifier, System.Collections.Generic.IEqualityComparer<TKey> keyComparer)
- public static Amazon.Runtime.Internal.Util.ICache<TKey, TValue> GetCache<TKey, TValue>(Amazon.Runtime.AmazonServiceClient client, object cacheIdentifier, System.Collections.Generic.IEqualityComparer<TKey> keyComparer)

### public static class Amazon.Runtime.Internal.Util.StringUtils

#### Fields
- private static readonly System.Text.Encoding UTF_8

#### Constructors
- private static StringUtils()

#### Methods
- public static string FromBool(bool value)
- public static string FromDateTime(System.DateTime value)
- public static string FromDateTimeToISO8601(System.DateTime value)
- public static string FromDateTimeToRFC822(System.DateTime value)
- public static string FromDateTimeToUnixTimestamp(System.DateTime value)
- public static string FromDecimal(decimal value)
- public static string FromDouble(double value)
- public static string FromInt(int value)
- public static string FromInt(System.Nullable<int> value)
- public static string FromLong(long value)
- public static string FromMemoryStream(System.IO.MemoryStream value)
- public static string FromString(string value)
- public static string FromString(Amazon.Runtime.ConstantClass value)
- public static string FromStringWithSlashEncoding(string value)
- public static long Utf8ByteLength(string value)

### public class Amazon.Runtime.Internal.Util.Timing
- Interfaces: Amazon.Runtime.IMetricsTiming

#### Fields
- private bool <IsFinished>k__BackingField
- private long endTime
- private long startTime

#### Properties
- public long ElapsedTicks { get; }
- public System.TimeSpan ElapsedTime { get; }
- public bool IsFinished { get; private set; }

#### Constructors
- public Timing()
- public Timing(long currentTime)

#### Methods
- public void Stop(long currentTime)

### public class Amazon.Runtime.Internal.Util.TimingEvent
- Interfaces: System.IDisposable

#### Fields
- private bool disposed
- private Amazon.Runtime.Metric metric
- private Amazon.Runtime.Internal.Util.RequestMetrics metrics

#### Constructors
- internal TimingEvent(Amazon.Runtime.Internal.Util.RequestMetrics metrics, Amazon.Runtime.Metric metric)

#### Methods
- protected virtual void Dispose(bool disposing)
- public void Dispose()
- protected override void Finalize()

### internal static class Amazon.Runtime.Internal.Util.TraceSourceUtil

#### Methods
- public static System.Diagnostics.TraceSource GetTraceSource(System.Type targetType)
- public static System.Diagnostics.TraceSource GetTraceSource(System.Type targetType, System.Diagnostics.SourceLevels sourceLevels)
- private static System.Diagnostics.TraceSource GetTraceSourceWithListeners(string name, System.Diagnostics.SourceLevels sourceLevels)

### public class Amazon.Runtime.Internal.Util.WebProxy
- Interfaces: System.Net.IWebProxy

#### Fields
- private System.Net.ICredentials <Credentials>k__BackingField
- private System.Uri <ProxyUri>k__BackingField

#### Properties
- public System.Net.ICredentials Credentials { get; set; }
- public System.Uri ProxyUri { get; set; }

#### Constructors
- public WebProxy(string proxyUri)
- public WebProxy(System.Uri proxyUri)
- public WebProxy(string proxyHost, int proxyPort)

#### Methods
- public System.Uri GetProxy(System.Uri destination)
- public bool IsBypassed(System.Uri host)

### public class Amazon.Runtime.Internal.Util.WrapperStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private System.IO.Stream <BaseStream>k__BackingField

#### Properties
- protected System.IO.Stream BaseStream { get; private set; }
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- internal bool HasLength { get; }
- public long Length { get; }
- public long Position { get; set; }
- public int ReadTimeout { get; set; }
- public int WriteTimeout { get; set; }

#### Constructors
- public WrapperStream(System.IO.Stream baseStream)

#### Methods
- protected override void Dispose(bool disposing)
- public override void Flush()
- public System.IO.Stream GetNonWrapperBaseStream()
- public static System.IO.Stream GetNonWrapperBaseStream(System.IO.Stream stream)
- public System.IO.Stream GetSeekableBaseStream()
- public override int Read(byte[] buffer, int offset, int count)
- public System.IO.Stream SearchWrappedStream(System.Func<System.IO.Stream, bool> condition)
- public static System.IO.Stream SearchWrappedStream(System.IO.Stream stream, System.Func<System.IO.Stream, bool> condition)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public override void Write(byte[] buffer, int offset, int count)

## Namespace: Amazon.Runtime.SharedInterfaces

### public class Amazon.Runtime.SharedInterfaces.GenerateDataKeyResult

#### Fields
- private byte[] <KeyCiphertext>k__BackingField
- private byte[] <KeyPlaintext>k__BackingField

#### Properties
- public byte[] KeyCiphertext { get; set; }
- public byte[] KeyPlaintext { get; set; }

#### Constructors
- public GenerateDataKeyResult()

### public interface Amazon.Runtime.SharedInterfaces.ICoreAmazonKMS
- Interfaces: System.IDisposable

#### Methods
- public byte[] Decrypt(byte[] ciphertextBlob, System.Collections.Generic.Dictionary<string, string> encryptionContext)
- public System.Threading.Tasks.Task<byte[]> DecryptAsync(byte[] ciphertextBlob, System.Collections.Generic.Dictionary<string, string> encryptionContext)
- public Amazon.Runtime.SharedInterfaces.GenerateDataKeyResult GenerateDataKey(string keyID, System.Collections.Generic.Dictionary<string, string> encryptionContext, string keySpec)
- public System.Threading.Tasks.Task<Amazon.Runtime.SharedInterfaces.GenerateDataKeyResult> GenerateDataKeyAsync(string keyID, System.Collections.Generic.Dictionary<string, string> encryptionContext, string keySpec)

### public interface Amazon.Runtime.SharedInterfaces.ICoreAmazonS3

#### Methods
- public System.Threading.Tasks.Task DeleteAsync(string bucketName, string objectKey, System.Collections.Generic.IDictionary<string, object> additionalProperties, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task DeletesAsync(string bucketName, System.Collections.Generic.IEnumerable<string> objectKeys, System.Collections.Generic.IDictionary<string, object> additionalProperties, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task<bool> DoesS3BucketExistAsync(string bucketName)
- public System.Threading.Tasks.Task DownloadToFilePathAsync(string bucketName, string objectKey, string filepath, System.Collections.Generic.IDictionary<string, object> additionalProperties, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task EnsureBucketExistsAsync(string bucketName)
- public string GeneratePreSignedURL(string bucketName, string objectKey, System.DateTime expiration, System.Collections.Generic.IDictionary<string, object> additionalProperties)
- public System.Threading.Tasks.Task<System.Collections.Generic.IList<string>> GetAllObjectKeysAsync(string bucketName, string prefix, System.Collections.Generic.IDictionary<string, object> additionalProperties)
- public System.Threading.Tasks.Task<System.IO.Stream> GetObjectStreamAsync(string bucketName, string objectKey, System.Collections.Generic.IDictionary<string, object> additionalProperties, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task MakeObjectPublicAsync(string bucketName, string objectKey, bool enable)
- public System.Threading.Tasks.Task UploadObjectFromFilePathAsync(string bucketName, string objectKey, string filepath, System.Collections.Generic.IDictionary<string, object> additionalProperties, System.Threading.CancellationToken cancellationToken = null)
- public System.Threading.Tasks.Task UploadObjectFromStreamAsync(string bucketName, string objectKey, System.IO.Stream stream, System.Collections.Generic.IDictionary<string, object> additionalProperties, System.Threading.CancellationToken cancellationToken = null)

### public interface Amazon.Runtime.SharedInterfaces.ICoreAmazonSQS

#### Methods
- public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetAttributesAsync(string queueUrl)
- public System.Threading.Tasks.Task SetAttributesAsync(string queueUrl, System.Collections.Generic.Dictionary<string, string> attributes)

### public interface Amazon.Runtime.SharedInterfaces.ICoreAmazonSTS

#### Methods
- public Amazon.Runtime.AssumeRoleImmutableCredentials CredentialsFromAssumeRoleAuthentication(string roleArn, string roleSessionName, Amazon.Runtime.AssumeRoleAWSCredentialsOptions options)

### public interface Amazon.Runtime.SharedInterfaces.ICoreAmazonSTS_SAML

#### Methods
- public Amazon.Runtime.SAMLImmutableCredentials CredentialsFromSAMLAuthentication(string endpoint, string authenticationType, string roleARN, System.TimeSpan credentialDuration, System.Net.ICredentials userCredential)

## Namespace: Amazon.Runtime.SharedInterfaces.Internal

### private struct Amazon.Runtime.SharedInterfaces.Internal.CoreAmazonKMS.<DecryptAsync>d__8
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.SharedInterfaces.Internal.CoreAmazonKMS <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<byte[]> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<byte[]> <>u__1
- public byte[] ciphertextBlob
- public System.Collections.Generic.Dictionary<string, string> encryptionContext

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Runtime.SharedInterfaces.Internal.CoreAmazonKMS.<GenerateDataKeyAsync>d__9
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Runtime.SharedInterfaces.Internal.CoreAmazonKMS <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Amazon.Runtime.SharedInterfaces.GenerateDataKeyResult> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<Amazon.Runtime.SharedInterfaces.GenerateDataKeyResult> <>u__1
- public System.Collections.Generic.Dictionary<string, string> encryptionContext
- public string keyID
- public string keySpec

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class Amazon.Runtime.SharedInterfaces.Internal.CoreAmazonKMS
- Interfaces: Amazon.Runtime.SharedInterfaces.ICoreAmazonKMS, System.IDisposable

#### Fields
- private bool disposed
- private Amazon.Runtime.AmazonServiceClient existingClient
- private string feature
- private Amazon.Runtime.SharedInterfaces.ICoreAmazonKMS wrappedClient
- private object wrappedClientLock

#### Constructors
- public CoreAmazonKMS(Amazon.Runtime.AmazonServiceClient existingClient, string feature)

#### Methods
- private static Amazon.Runtime.SharedInterfaces.ICoreAmazonKMS CreateFromExistingClient(Amazon.Runtime.AmazonServiceClient existingClient, string feature)
- public byte[] Decrypt(byte[] ciphertextBlob, System.Collections.Generic.Dictionary<string, string> encryptionContext)
- public System.Threading.Tasks.Task<byte[]> DecryptAsync(byte[] ciphertextBlob, System.Collections.Generic.Dictionary<string, string> encryptionContext)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- private void EnsureWrappedClientIsInstantiated()
- public Amazon.Runtime.SharedInterfaces.GenerateDataKeyResult GenerateDataKey(string keyID, System.Collections.Generic.Dictionary<string, string> encryptionContext, string keySpec)
- public System.Threading.Tasks.Task<Amazon.Runtime.SharedInterfaces.GenerateDataKeyResult> GenerateDataKeyAsync(string keyID, System.Collections.Generic.Dictionary<string, string> encryptionContext, string keySpec)

## Namespace: Amazon.Util

### private class Amazon.Util.AWSSDKUtils.<>c

#### Fields
- public static readonly Amazon.Util.AWSSDKUtils.<>c <>9
- public static System.Func<string, string> <>9__36_0
- public static System.Func<string, string> <>9__36_1
- public static System.Func<string, string> <>9__36_2
- public static System.Func<string, string> <>9__38_1
- public static System.Func<Amazon.Util.AWSSDKUtils.IsSetMethodsCacheKey, System.Reflection.MethodInfo> <>9__96_0

#### Constructors
- private static AWSSDKUtils.<>c()
- public AWSSDKUtils.<>c()

#### Methods
- internal string <CanonicalizeResourcePath>b__36_0(string segment)
- internal string <CanonicalizeResourcePath>b__36_1(string segment)
- internal string <CanonicalizeResourcePath>b__36_2(string segment)
- internal System.Reflection.MethodInfo <IsPropertySet>b__96_0(Amazon.Util.AWSSDKUtils.IsSetMethodsCacheKey k)
- internal string <JoinResourcePathSegments>b__38_1(string segment)

### private class Amazon.Util.ProfileManager.<>c

#### Fields
- public static readonly Amazon.Util.ProfileManager.<>c <>9
- public static System.Func<Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings, string> <>9__9_0

#### Constructors
- private static ProfileManager.<>c()
- public ProfileManager.<>c()

#### Methods
- internal string <ListProfileNames>b__9_0(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings os)

### private class Amazon.Util.PaginatedResourceFactory.<>c__DisplayClass1_0<ItemType, TRequestType, TResponseType>

#### Fields
- public object client
- public System.Reflection.MethodInfo fetcherMethod

#### Constructors
- public PaginatedResourceFactory.<>c__DisplayClass1_0<ItemType, TRequestType, TResponseType>()

#### Methods
- internal TResponseType <Create>b__0(TRequestType req)

### private class Amazon.Util.ProfileManager.<>c__DisplayClass22_0

#### Fields
- public string profileName

#### Constructors
- public ProfileManager.<>c__DisplayClass22_0()

#### Methods
- internal bool <ReadProfileSettings>b__0(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings x)

### private class Amazon.Util.ProfileManager.<>c__DisplayClass23_0

#### Fields
- public string settingsKey

#### Constructors
- public ProfileManager.<>c__DisplayClass23_0()

#### Methods
- internal bool <ReadSettings>b__0(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings x)

### private class Amazon.Util.AWSPublicIpAddressRanges.<>c__DisplayClass24_0

#### Fields
- public string serviceKey

#### Constructors
- public AWSPublicIpAddressRanges.<>c__DisplayClass24_0()

#### Methods
- internal bool <AddressRangesByServiceKey>b__0(Amazon.Util.AWSPublicIpAddressRange ar)

### private class Amazon.Util.AWSPublicIpAddressRanges.<>c__DisplayClass25_0

#### Fields
- public string regionIdentifier

#### Constructors
- public AWSPublicIpAddressRanges.<>c__DisplayClass25_0()

#### Methods
- internal bool <AddressRangesByRegion>b__0(Amazon.Util.AWSPublicIpAddressRange ar)

### private class Amazon.Util.AWSPublicIpAddressRanges.<>c__DisplayClass29_0

#### Fields
- public Amazon.Util.AWSPublicIpAddressRange.AddressFormat addressFormat
- public string prefixKey

#### Constructors
- public AWSPublicIpAddressRanges.<>c__DisplayClass29_0()

#### Methods
- internal Amazon.Util.AWSPublicIpAddressRange <ParseRange>b__0(ThirdParty.Json.LitJson.JsonData range)

### private class Amazon.Util.PaginatedResourceFactory.<>c__DisplayClass2_0<ItemType, TRequestType, TResponseType>

#### Fields
- public System.Func<TRequestType, TResponseType> call
- public string itemListPropertyPath
- public TRequestType request
- public string tokenRequestPropertyPath
- public string tokenResponsePropertyPath

#### Constructors
- public PaginatedResourceFactory.<>c__DisplayClass2_0<ItemType, TRequestType, TResponseType>()

#### Methods
- internal Amazon.Util.Marker<ItemType> <Create>b__0(string token)

### private class Amazon.Util.AWSSDKUtils.<>c__DisplayClass38_0

#### Fields
- public bool path

#### Constructors
- public AWSSDKUtils.<>c__DisplayClass38_0()

#### Methods
- internal string <JoinResourcePathSegments>b__0(string segment)

### private class Amazon.Util.AWSSDKUtils.<>c__DisplayClass52_0<T>

#### Fields
- public T args
- public object sender

#### Constructors
- public AWSSDKUtils.<>c__DisplayClass52_0<T>()

### private class Amazon.Util.AWSSDKUtils.<>c__DisplayClass52_1<T>

#### Fields
- public Amazon.Util.AWSSDKUtils.<>c__DisplayClass52_0<T> CS$<>8__locals1
- public System.EventHandler<T> eventHandler

#### Constructors
- public AWSSDKUtils.<>c__DisplayClass52_1<T>()

#### Methods
- internal void <InvokeInBackground>b__0()

### private class Amazon.Util.AWSSDKUtils.<>c__DisplayClass87_0

#### Fields
- public System.Uri uri

#### Constructors
- public AWSSDKUtils.<>c__DisplayClass87_0()

### private class Amazon.Util.AWSSDKUtils.<>c__DisplayClass87_1

#### Fields
- public System.Net.Http.HttpClient client
- public Amazon.Util.AWSSDKUtils.<>c__DisplayClass87_0 CS$<>8__locals1

#### Constructors
- public AWSSDKUtils.<>c__DisplayClass87_1()

#### Methods
- internal System.Threading.Tasks.Task<string> <DownloadStringContent>b__0()

### private class Amazon.Util.AWSSDKUtils.<>c__DisplayClass94_0

#### Fields
- public System.Diagnostics.Process process

#### Constructors
- public AWSSDKUtils.<>c__DisplayClass94_0()

### private class Amazon.Util.AWSSDKUtils.<>c__DisplayClass94_1

#### Fields
- public Amazon.Util.AWSSDKUtils.<>c__DisplayClass94_0 CS$<>8__locals1
- public string standardOutput

#### Constructors
- public AWSSDKUtils.<>c__DisplayClass94_1()

#### Methods
- internal void <RunProcess>b__0()

### private class Amazon.Util.AWSSDKUtils.<>c__DisplayClass95_0

#### Fields
- public System.Threading.Tasks.TaskCompletionSource<object> tcs

#### Constructors
- public AWSSDKUtils.<>c__DisplayClass95_0()

#### Methods
- internal void <RunProcessAsync>b__0(object s, System.EventArgs ea)

### private struct Amazon.Util.AWSHttpClient.<GetResponseHeadersAsync>d__17
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Amazon.Util.AWSHttpClient <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<System.Tuple<string, System.Collections.Generic.IEnumerable<string>, System.Net.HttpStatusCode>>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Net.Http.HttpResponseMessage> <>u__1
- private System.Collections.Generic.List<System.Tuple<string, System.Collections.Generic.IEnumerable<string>, System.Net.HttpStatusCode>> <headers>5__2
- public string httpMethodValue
- public string url

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Amazon.Util.AWSSDKUtils.<RunProcessAsync>d__95
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Amazon.Util.ProcessExecutionResult> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private System.Diagnostics.Process <process>5__2
- private System.Threading.Tasks.Task<string> <standardErrorTask>5__3
- private System.Threading.Tasks.Task<string> <standardOutputTask>5__4
- public System.Diagnostics.ProcessStartInfo processStartInfo

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public enum Amazon.Util.AWSPublicIpAddressRange.AddressFormat
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Ipv4 = 0
- Ipv6 = 1

### public class Amazon.Util.AWSCredentialsProfile
- Base: Amazon.Util.ProfileSettingsBase

#### Fields
- private Amazon.Runtime.BasicAWSCredentials <Credentials>k__BackingField

#### Properties
- public Amazon.Runtime.BasicAWSCredentials Credentials { get; private set; }

#### Constructors
- private AWSCredentialsProfile(string profileName, string accessKeyId, string secretKey)

#### Methods
- public static bool CanCreateFrom(string profileName)
- public static bool CanCreateFrom(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings os)
- public static Amazon.Util.AWSCredentialsProfile LoadFrom(string profileName)
- public static Amazon.Util.AWSCredentialsProfile LoadFrom(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings os)
- public override string Persist()
- public static string Persist(string profileName, string accessKeyId, string secretKey)
- public static void Validate(string profileName)
- private static void Validate(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings os)

### public class Amazon.Util.AWSHttpClient
- Interfaces: System.IDisposable

#### Fields
- private bool disposed
- private System.Net.Http.HttpClient _httpClient

#### Properties
- public System.Uri BaseAddress { get; set; }
- public long MaxResponseContentBufferSize { get; set; }
- public System.TimeSpan Timeout { get; set; }

#### Constructors
- public AWSHttpClient()
- internal AWSHttpClient(System.Net.Http.HttpMessageHandler handler)
- internal AWSHttpClient(System.Net.IWebProxy proxy, bool useProxy)
- internal AWSHttpClient(System.Net.Http.HttpMessageHandler handler, bool disposeHandler)

#### Methods
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- public System.Threading.Tasks.Task<System.Collections.Generic.List<System.Tuple<string, System.Collections.Generic.IEnumerable<string>, System.Net.HttpStatusCode>>> GetResponseHeadersAsync(string httpMethodValue, string url)
- public System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(string requestUri)
- public static bool IsHttpInnerException(System.Exception exception)
- public System.Threading.Tasks.Task PutRequestUriAsync(string requestUri, Amazon.Util.AWSStreamContent content, System.Collections.Generic.IDictionary<string, string> requestHeaders)

### public class Amazon.Util.AWSPublicIpAddressRange

#### Fields
- private Amazon.Util.AWSPublicIpAddressRange.AddressFormat <IpAddressFormat>k__BackingField
- private string <IpPrefix>k__BackingField
- private string <Region>k__BackingField
- private string <Service>k__BackingField

#### Properties
- public Amazon.Util.AWSPublicIpAddressRange.AddressFormat IpAddressFormat { get; internal set; }
- public string IpPrefix { get; internal set; }
- public string Region { get; internal set; }
- public string Service { get; internal set; }

#### Constructors
- public AWSPublicIpAddressRange()

### public class Amazon.Util.AWSPublicIpAddressRanges

#### Fields
- private System.Collections.Generic.IEnumerable<Amazon.Util.AWSPublicIpAddressRange> <AllAddressRanges>k__BackingField
- private System.DateTime <CreateDate>k__BackingField
- public static const string AmazonServiceKey
- public static const string CloudFrontServiceKey
- private static const string createDateFormatString
- private static const string createDateKey
- public static const string EC2ServiceKey
- public static const string GlobalRegionIdentifier
- private static readonly System.Uri IpAddressRangeEndpoint
- private static const string ipv4PrefixesKey
- private static const string ipv4PrefixKey
- private static const string ipv6PrefixesKey
- private static const string ipv6PrefixKey
- private static const string regionKey
- public static const string Route53HealthChecksServiceKey
- public static const string Route53ServiceKey
- private static const string serviceKey

#### Properties
- public System.Collections.Generic.IEnumerable<Amazon.Util.AWSPublicIpAddressRange> AllAddressRanges { get; private set; }
- public System.DateTime CreateDate { get; private set; }
- public System.Collections.Generic.IEnumerable<string> ServiceKeys { get; }

#### Constructors
- private AWSPublicIpAddressRanges()
- private static AWSPublicIpAddressRanges()

#### Methods
- public System.Collections.Generic.IEnumerable<Amazon.Util.AWSPublicIpAddressRange> AddressRangesByRegion(string regionIdentifier)
- public System.Collections.Generic.IEnumerable<Amazon.Util.AWSPublicIpAddressRange> AddressRangesByServiceKey(string serviceKey)
- public static Amazon.Util.AWSPublicIpAddressRanges Load()
- public static Amazon.Util.AWSPublicIpAddressRanges Load(System.Net.IWebProxy proxy)
- private static Amazon.Util.AWSPublicIpAddressRanges Parse(string fileContent)
- private static System.Collections.Generic.IEnumerable<Amazon.Util.AWSPublicIpAddressRange> ParseRange(ThirdParty.Json.LitJson.JsonData ranges, Amazon.Util.AWSPublicIpAddressRange.AddressFormat addressFormat)

### public static class Amazon.Util.AWSSDKUtils

#### Fields
- private static readonly System.Text.RegularExpressions.Regex CompressWhitespaceRegex
- public static const int DefaultBufferSize
- private static const int DefaultConnectionLimit
- internal static const string DefaultGovRegion
- private static const int DefaultMarshallerVersion
- private static const int DefaultMaxIdleTime
- internal static const int DefaultMaxRetry
- public static const long DefaultProgressUpdateInterval
- internal static const string DefaultRegion
- private static const string EncodedSlash
- public static readonly System.DateTime EPOCH_START
- public static const string GMTDateFormat
- public static const string ISO8601BasicDateFormat
- public static const string ISO8601BasicDateTimeFormat
- public static const string ISO8601DateFormat
- public static const string ISO8601DateFormatNoMS
- private static Amazon.Runtime.Internal.Util.LruCache<Amazon.Util.AWSSDKUtils.IsSetMethodsCacheKey, System.Reflection.MethodInfo> IsSetMethodsCache
- private static const int MaxIsSetMethodsCacheSize
- public static const string RFC822DateFormat
- internal static System.Collections.Generic.Dictionary<int, string> RFCEncodingSchemes
- internal static const string S3Accelerate
- internal static const string S3Control
- private static const string Slash
- private static const char SlashChar
- public static const string UrlEncodedContent
- public static const string UserAgentHeader
- private static string ValidPathCharacters
- public static const string ValidUrlCharacters
- public static const string ValidUrlCharactersRFC1738
- private static Amazon.Runtime.Internal.Util.BackgroundInvoker _dispatcher
- private static readonly string _userAgent

#### Properties
- public static System.DateTime CorrectedUtcNow { get; }
- private static Amazon.Runtime.Internal.Util.BackgroundInvoker Dispatcher { get; }
- public static string FormattedCurrentTimestampGMT { get; }
- public static string FormattedCurrentTimestampISO8601 { get; }
- public static string FormattedCurrentTimestampRFC822 { get; }

#### Constructors
- private static AWSSDKUtils()

#### Methods
- internal static bool AreEqual(object[] itemsA, object[] itemsB)
- internal static bool AreEqual(object a, object b)
- public static string BytesToHexString(byte[] value)
- internal static string CalculateStringToSignV2(Amazon.Runtime.Internal.ParameterCollection parameterCollection, string serviceUrl)
- public static string CanonicalizeResourcePath(System.Uri endpoint, string resourcePath)
- public static string CanonicalizeResourcePath(System.Uri endpoint, string resourcePath, bool detectPreEncode)
- public static string CanonicalizeResourcePath(System.Uri endpoint, string resourcePath, bool detectPreEncode, System.Collections.Generic.IDictionary<string, string> pathResources, int marshallerVersion)
- public static string CompressSpaces(string data)
- public static long ConvertDateTimetoMilliseconds(System.DateTime dateTime)
- public static System.DateTime ConvertFromUnixEpochSeconds(int seconds)
- public static long ConvertTimeSpanToMilliseconds(System.TimeSpan timeSpan)
- public static double ConvertToUnixEpochMilliSeconds(System.DateTime dateTime)
- public static int ConvertToUnixEpochSeconds(System.DateTime dateTime)
- public static double ConvertToUnixEpochSecondsDouble(System.DateTime dateTime)
- public static string ConvertToUnixEpochSecondsString(System.DateTime dateTime)
- public static void CopyStream(System.IO.Stream source, System.IO.Stream destination)
- public static void CopyStream(System.IO.Stream source, System.IO.Stream destination, int bufferSize)
- public static string DetermineRegion(string url)
- public static string DetermineService(string url)
- private static string DetermineValidPathCharacters()
- internal static bool DictionariesAreEqual<K, V>(System.Collections.Generic.Dictionary<K, V> a, System.Collections.Generic.Dictionary<K, V> b)
- public static string DownloadStringContent(System.Uri uri)
- public static string DownloadStringContent(System.Uri uri, System.TimeSpan timeout)
- public static string DownloadStringContent(System.Uri uri, System.Net.IWebProxy proxy)
- public static string DownloadStringContent(System.Uri uri, System.TimeSpan timeout, System.Net.IWebProxy proxy)
- public static void ForceCanonicalPathAndQuery(System.Uri uri)
- public static System.IO.MemoryStream GenerateMemoryStreamFromString(string s)
- internal static int GetConnectionLimit(System.Nullable<int> clientConfigValue)
- public static string GetExtension(string path)
- public static string GetFormattedTimestampISO8601(int minutesFromNow)
- internal static string GetFormattedTimestampISO8601(Amazon.Runtime.IClientConfig config)
- private static string GetFormattedTimestampISO8601(System.DateTime dateTime)
- public static string GetFormattedTimestampRFC822(int minutesFromNow)
- internal static string GetParametersAsString(Amazon.Runtime.Internal.IRequest request)
- internal static string GetParametersAsString(Amazon.Runtime.Internal.ParameterCollection parameterCollection)
- public static System.TimeSpan GetTimeSpanInTicks(System.DateTime dateTime)
- public static bool HasBidiControlCharacters(string input)
- public static byte[] HexStringToBytes(string hex)
- public static void InvokeInBackground<T>(System.EventHandler<T> handler, T args, object sender)
- private static bool IsBidiControlChar(char c)
- private static bool IsPathSeparator(char ch)
- public static bool IsPropertySet(object awsServiceObject, string propertyName)
- public static string Join(System.Collections.Generic.List<string> strings)
- public static string JoinResourcePathSegments(System.Collections.Generic.IEnumerable<string> pathSegments, bool path)
- public static System.IO.Stream OpenStream(System.Uri uri)
- public static System.IO.Stream OpenStream(System.Uri uri, System.Net.IWebProxy proxy)
- public static System.Collections.Generic.Dictionary<string, string> ParseQueryParameters(string url)
- public static void PreserveStackTrace(System.Exception exception)
- public static string ProtectEncodedSlashUrlEncode(string data, bool path)
- public static string ResolveResourcePath(string resourcePath, System.Collections.Generic.IDictionary<string, string> pathResources)
- public static Amazon.Util.ProcessExecutionResult RunProcess(System.Diagnostics.ProcessStartInfo processStartInfo)
- public static System.Threading.Tasks.Task<Amazon.Util.ProcessExecutionResult> RunProcessAsync(System.Diagnostics.ProcessStartInfo processStartInfo)
- public static void Sleep(System.TimeSpan ts)
- public static void Sleep(int ms)
- public static System.Collections.Generic.IEnumerable<string> SplitResourcePathIntoSegments(string resourcePath, System.Collections.Generic.IDictionary<string, string> pathResources)
- public static string ToHex(byte[] data, bool lowercase)
- public static string UrlEncode(string data, bool path)
- public static string UrlEncode(int rfcNumber, string data, bool path)
- internal static string UrlEncodeSlash(string data)

### public class Amazon.Util.AWSStreamContent
- Interfaces: System.IDisposable

#### Fields
- private System.Net.Http.StreamContent <StreamContent>k__BackingField
- private bool disposed

#### Properties
- internal System.Net.Http.StreamContent StreamContent { get; set; }

#### Constructors
- public AWSStreamContent(System.IO.Stream content)
- public AWSStreamContent(System.IO.Stream content, int bufferSize)

#### Methods
- public void AddHttpContentHeader(string name, string value)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- public bool RemoveHttpContentHeader(string name)

### public class Amazon.Util.CircularReferenceTracking

#### Fields
- private System.Collections.Generic.Stack<Amazon.Util.CircularReferenceTracking.Tracker> referenceTrackers
- private object referenceTrackersLock

#### Constructors
- public CircularReferenceTracking()

#### Methods
- private void PopTracker(Amazon.Util.CircularReferenceTracking.Tracker tracker)
- public System.IDisposable Track(object target)
- private bool TrackerExists(object target)

### private class Amazon.Util.CryptoUtilFactory.CryptoUtil
- Interfaces: Amazon.Util.ICryptoUtil

#### Fields
- private static System.Security.Cryptography.HashAlgorithm _hashAlgorithm

#### Properties
- private static System.Security.Cryptography.HashAlgorithm SHA256HashAlgorithmInstance { get; }

#### Constructors
- internal CryptoUtilFactory.CryptoUtil()
- private static CryptoUtilFactory.CryptoUtil()

#### Methods
- public byte[] ComputeMD5Hash(byte[] data)
- public byte[] ComputeMD5Hash(System.IO.Stream steam)
- public byte[] ComputeSHA256Hash(byte[] data)
- public byte[] ComputeSHA256Hash(System.IO.Stream steam)
- private System.Security.Cryptography.KeyedHashAlgorithm CreateKeyedHashAlgorithm(Amazon.Runtime.SigningAlgorithm algorithmName)
- public string HMACSign(string data, string key, Amazon.Runtime.SigningAlgorithm algorithmName)
- public string HMACSign(byte[] data, string key, Amazon.Runtime.SigningAlgorithm algorithmName)
- public byte[] HMACSignBinary(byte[] data, byte[] key, Amazon.Runtime.SigningAlgorithm algorithmName)

### public static class Amazon.Util.CryptoUtilFactory

#### Fields
- private static Amazon.Util.CryptoUtilFactory.CryptoUtil util

#### Properties
- public static Amazon.Util.ICryptoUtil CryptoInstance { get; }

#### Constructors
- private static CryptoUtilFactory()

### public class Amazon.Util.CSMConfig

#### Fields
- private string <CSMClientId>k__BackingField
- private System.Nullable<bool> <CSMEnabled>k__BackingField
- private string <CSMHost>k__BackingField
- private int <CSMPort>k__BackingField
- internal static const string DEFAULT_HOST
- internal static const int DEFAULT_PORT

#### Properties
- public string CSMClientId { get; set; }
- public System.Nullable<bool> CSMEnabled { get; set; }
- public string CSMHost { get; set; }
- public int CSMPort { get; set; }

#### Constructors
- public CSMConfig()

### public static class Amazon.Util.EC2InstanceMetadata

#### Fields
- private static System.Net.IWebProxy <Proxy>k__BackingField
- public static readonly string AWS_EC2_METADATA_DISABLED
- private static int DEFAULT_RETRIES
- public static readonly string EC2_DYNAMICDATA_ROOT
- public static readonly string EC2_METADATA_ROOT
- public static readonly string EC2_METADATA_SVC
- public static readonly string EC2_USERDATA_ROOT
- public static readonly string LATEST
- private static int MAX_RETRIES
- private static int MIN_PAUSE_MS
- private static System.Collections.Generic.Dictionary<string, string> _cache

#### Properties
- public static string AmiId { get; }
- public static string AmiLaunchIndex { get; }
- public static string AmiManifestPath { get; }
- public static System.Collections.Generic.IEnumerable<string> AncestorAmiIds { get; }
- public static string AvailabilityZone { get; }
- public static System.Collections.Generic.IDictionary<string, string> BlockDeviceMapping { get; }
- public static string Hostname { get; }
- public static Amazon.Util.IAMInstanceProfileMetadata IAMInstanceProfileInfo { get; }
- public static System.Collections.Generic.IDictionary<string, Amazon.Util.IAMSecurityCredentialMetadata> IAMSecurityCredentials { get; }
- public static string IdentityDocument { get; }
- public static string IdentityPkcs7 { get; }
- public static string IdentitySignature { get; }
- public static string InstanceAction { get; }
- public static string InstanceId { get; }
- public static string InstanceMonitoring { get; }
- public static string InstanceType { get; }
- public static bool IsIMDSEnabled { get; }
- public static string KernelId { get; }
- public static string LocalHostname { get; }
- public static string MacAddress { get; }
- public static System.Collections.Generic.IEnumerable<Amazon.Util.NetworkInterfaceMetadata> NetworkInterfaces { get; }
- public static string PrivateIpAddress { get; }
- public static System.Collections.Generic.IEnumerable<string> ProductCodes { get; }
- public static System.Net.IWebProxy Proxy { get; set; }
- public static string PublicKey { get; }
- public static string RamdiskId { get; }
- public static Amazon.RegionEndpoint Region { get; }
- public static string ReservationId { get; }
- public static System.Collections.Generic.IEnumerable<string> SecurityGroups { get; }
- public static string UserData { get; }

#### Constructors
- private static EC2InstanceMetadata()

#### Methods
- private static string FetchData(string path)
- private static string FetchData(string path, bool force)
- public static string GetData(string path)
- public static string GetData(string path, int tries)
- public static System.Collections.Generic.IEnumerable<string> GetItems(string path)
- public static System.Collections.Generic.IEnumerable<string> GetItems(string path, int tries)
- private static System.Collections.Generic.List<string> GetItems(string relativeOrAbsolutePath, int tries, bool slurp)
- private static void PauseExponentially(int tries)

### internal static class Amazon.Util.Extensions

#### Methods
- internal static string ToUpper(string str, System.Globalization.CultureInfo culture)

### public class Amazon.Util.HeaderKeys

#### Fields
- public static const string AcceptHeader
- public static const string AuthorizationHeader
- public static const string ConfirmSelfBucketAccess
- public static const string ConnectionHeader
- public static const string ContentDispositionHeader
- public static const string ContentEncodingHeader
- public static const string ContentLengthHeader
- public static const string ContentMD5Header
- public static const string ContentRangeHeader
- public static const string ContentTypeHeader
- public static const string DateHeader
- public static const string ETagHeader
- public static const string ExpectHeader
- public static const string Expires
- public static const string HostHeader
- public static const string IfMatchHeader
- public static const string IfModifiedSinceHeader
- public static const string IfNoneMatchHeader
- public static const string IfUnmodifiedSinceHeader
- public static const string LocationHeader
- public static const string RangeHeader
- public static const string RequestIdHeader
- public static const string StatusHeader
- public static const string TransferEncodingHeader
- public static const string UserAgentHeader
- public static const string XAmzAbortDateHeader
- public static const string XAmzAbortRuleIdHeader
- public static const string XAmzAccountId
- public static const string XAmzAclHeader
- public static const string XAmzApiVersion
- public static const string XAmzAuthorizationHeader
- public static const string XAmzBucketRegion
- public static const string XAmzCloudFrontIdHeader
- public static const string XAmzContentLengthHeader
- public static const string XAmzContentSha256Header
- public static const string XAmzCopySourceHeader
- public static const string XAmzCopySourceIfMatchHeader
- public static const string XAmzCopySourceIfModifiedSinceHeader
- public static const string XAmzCopySourceIfNoneMatchHeader
- public static const string XAmzCopySourceIfUnmodifiedSinceHeader
- public static const string XAmzCopySourceRangeHeader
- public static const string XAmzCopySourceSSECustomerAlgorithmHeader
- public static const string XAmzCopySourceSSECustomerKeyHeader
- public static const string XAmzCopySourceSSECustomerKeyMD5Header
- public static const string XAmzDateHeader
- public static const string XAmzDecodedContentLengthHeader
- public static const string XAmzErrorType
- public static const string XAmzId2Header
- public static const string XAmzMetadataDirectiveHeader
- public static const string XAmzMfaHeader
- public static const string XAmznErrorMessage
- public static const string XAmzNonceHeader
- public static const string XAmznTraceIdHeader
- public static const string XAmzRequestIdHeader
- public static const string XAmzSecurityTokenHeader
- public static const string XAmzServerSideEncryptionAwsKmsKeyIdHeader
- public static const string XAmzServerSideEncryptionHeader
- public static const string XAmzSignedHeadersHeader
- public static const string XAmzSSECustomerAlgorithmHeader
- public static const string XAmzSSECustomerKeyHeader
- public static const string XAmzSSECustomerKeyMD5Header
- public static const string XAmzStorageClassHeader
- public static const string XAmzUserAgentHeader
- public static const string XAmzVersionIdHeader
- public static const string XAmzWebsiteRedirectLocationHeader
- public static const string XHttpMethodOverrideHeader

#### Constructors
- protected HeaderKeys()

### public class Amazon.Util.IAMInstanceProfileMetadata

#### Fields
- private string <Code>k__BackingField
- private string <InstanceProfileArn>k__BackingField
- private string <InstanceProfileId>k__BackingField
- private System.DateTime <LastUpdated>k__BackingField
- private string <Message>k__BackingField

#### Properties
- public string Code { get; set; }
- public string InstanceProfileArn { get; set; }
- public string InstanceProfileId { get; set; }
- public System.DateTime LastUpdated { get; set; }
- public string Message { get; set; }

#### Constructors
- public IAMInstanceProfileMetadata()

### public class Amazon.Util.IAMSecurityCredentialMetadata

#### Fields
- private string <AccessKeyId>k__BackingField
- private string <Code>k__BackingField
- private System.DateTime <Expiration>k__BackingField
- private System.DateTime <LastUpdated>k__BackingField
- private string <Message>k__BackingField
- private string <SecretAccessKey>k__BackingField
- private string <Token>k__BackingField
- private string <Type>k__BackingField

#### Properties
- public string AccessKeyId { get; set; }
- public string Code { get; set; }
- public System.DateTime Expiration { get; set; }
- public System.DateTime LastUpdated { get; set; }
- public string Message { get; set; }
- public string SecretAccessKey { get; set; }
- public string Token { get; set; }
- public string Type { get; set; }

#### Constructors
- public IAMSecurityCredentialMetadata()

### public interface Amazon.Util.ICryptoUtil

#### Methods
- public byte[] ComputeMD5Hash(byte[] data)
- public byte[] ComputeMD5Hash(System.IO.Stream steam)
- public byte[] ComputeSHA256Hash(byte[] data)
- public byte[] ComputeSHA256Hash(System.IO.Stream steam)
- public string HMACSign(string data, string key, Amazon.Runtime.SigningAlgorithm algorithmName)
- public string HMACSign(byte[] data, string key, Amazon.Runtime.SigningAlgorithm algorithmName)
- public byte[] HMACSignBinary(byte[] data, byte[] key, Amazon.Runtime.SigningAlgorithm algorithmName)

### private class Amazon.Util.EC2InstanceMetadata.IMDSDisabledException
- Base: System.InvalidOperationException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public EC2InstanceMetadata.IMDSDisabledException()

### private class Amazon.Util.AWSSDKUtils.IsSetMethodsCacheKey

#### Fields
- public readonly string PropertyName
- public readonly System.Type Type

#### Constructors
- public AWSSDKUtils.IsSetMethodsCacheKey(System.Type type, string propertyName)

#### Methods
- public override bool Equals(object other)
- public override int GetHashCode()
- public override string ToString()

### public class Amazon.Util.JitteredDelay

#### Fields
- private System.TimeSpan _baseIncrement
- private int _count
- private System.TimeSpan _maxDelay
- private System.Random _rand
- private System.TimeSpan _variance

#### Constructors
- public JitteredDelay(System.TimeSpan baseIncrement, System.TimeSpan variance)
- public JitteredDelay(System.TimeSpan baseIncrement, System.TimeSpan variance, System.TimeSpan maxDelay)

#### Methods
- public System.TimeSpan GetRetryDelay(int attemptCount)
- public System.TimeSpan Next()
- public void Reset()

### public class Amazon.Util.LoggingConfig

#### Fields
- private bool <LogMetrics>k__BackingField
- private Amazon.Runtime.IMetricsFormatter <LogMetricsCustomFormatter>k__BackingField
- private Amazon.LogMetricsFormatOption <LogMetricsFormat>k__BackingField
- private Amazon.ResponseLoggingOption <LogResponses>k__BackingField
- private int <LogResponsesSizeLimit>k__BackingField
- public static readonly int DefaultLogResponsesSizeLimit
- private Amazon.LoggingOptions _logTo

#### Properties
- public bool LogMetrics { get; set; }
- public Amazon.Runtime.IMetricsFormatter LogMetricsCustomFormatter { get; set; }
- public Amazon.LogMetricsFormatOption LogMetricsFormat { get; set; }
- public Amazon.ResponseLoggingOption LogResponses { get; set; }
- public int LogResponsesSizeLimit { get; set; }
- public Amazon.LoggingOptions LogTo { get; set; }

#### Constructors
- internal LoggingConfig()
- private static LoggingConfig()

### internal class Amazon.Util.Marker<U>

#### Fields
- private System.Collections.Generic.List<U> data
- private string nextToken

#### Properties
- internal System.Collections.Generic.List<U> Data { get; }
- internal string NextToken { get; }

#### Constructors
- internal Marker<U>(System.Collections.Generic.List<U> data, string nextToken)

### public class Amazon.Util.NetworkInterfaceMetadata

#### Fields
- private System.Collections.Generic.IEnumerable<string> _availableKeys
- private System.Collections.Generic.Dictionary<string, string> _data
- private string _mac
- private string _path

#### Properties
- public string LocalHostname { get; }
- public System.Collections.Generic.IEnumerable<string> LocalIPv4s { get; }
- public string MacAddress { get; }
- public string OwnerId { get; }
- public string Profile { get; }
- public string PublicHostname { get; }
- public System.Collections.Generic.IEnumerable<string> PublicIPv4s { get; }
- public System.Collections.Generic.IEnumerable<string> SecurityGroupIds { get; }
- public System.Collections.Generic.IEnumerable<string> SecurityGroups { get; }
- public string SubnetId { get; }
- public string SubnetIPv4CidrBlock { get; }
- public string VpcId { get; }

#### Constructors
- private NetworkInterfaceMetadata()
- public NetworkInterfaceMetadata(string macAddress)

#### Methods
- private string GetData(string key)
- public System.Collections.Generic.IEnumerable<string> GetIpV4Association(string publicIp)
- private System.Collections.Generic.IEnumerable<string> GetItems(string key)

### public static class Amazon.Util.PaginatedResourceFactory

#### Methods
- internal static T Cast<T>(object o)
- public static object Create<TItemType, TRequestType, TResponseType>(Amazon.Util.PaginatedResourceInfo pri)
- private static Amazon.Util.PaginatedResource<ItemType> Create<ItemType, TRequestType, TResponseType>(object client, string methodName, object request, string tokenRequestPropertyPath, string tokenResponsePropertyPath, string itemListPropertyPath)
- private static Amazon.Util.PaginatedResource<ItemType> Create<ItemType, TRequestType, TResponseType>(System.Func<TRequestType, TResponseType> call, TRequestType request, string tokenRequestPropertyPath, string tokenResponsePropertyPath, string itemListPropertyPath)
- private static System.Type GetFuncType<T, U>()
- internal static System.Type GetPropertyTypeFromPath(System.Type start, string path)
- private static T GetPropertyValueFromPath<T>(object instance, string path)
- private static void SetPropertyValueAtPath(object instance, string path, string value)

### public class Amazon.Util.PaginatedResourceInfo

#### Fields
- private object <Client>k__BackingField
- private string <ItemListPropertyPath>k__BackingField
- private string <MethodName>k__BackingField
- private object <Request>k__BackingField
- private string tokenRequestPropertyPath
- private string tokenResponsePropertyPath

#### Properties
- internal object Client { get; set; }
- internal string ItemListPropertyPath { get; set; }
- internal string MethodName { get; set; }
- internal object Request { get; set; }
- internal string TokenRequestPropertyPath { get; set; }
- internal string TokenResponsePropertyPath { get; set; }

#### Constructors
- public PaginatedResourceInfo()

#### Methods
- internal void Verify()
- private static void VerifyProperty(string propName, System.Type start, string path, System.Type expectedType)
- private static void VerifyProperty(string propName, System.Type start, string path, System.Type expectedType, bool skipTypecheck)
- public Amazon.Util.PaginatedResourceInfo WithClient(object client)
- public Amazon.Util.PaginatedResourceInfo WithItemListPropertyPath(string itemListPropertyPath)
- public Amazon.Util.PaginatedResourceInfo WithMethodName(string methodName)
- public Amazon.Util.PaginatedResourceInfo WithRequest(object request)
- public Amazon.Util.PaginatedResourceInfo WithTokenRequestPropertyPath(string tokenRequestPropertyPath)
- public Amazon.Util.PaginatedResourceInfo WithTokenResponsePropertyPath(string tokenResponsePropertyPath)

### internal class Amazon.Util.PaginatedResource<U>
- Interfaces: System.Collections.Generic.IEnumerable<U>, System.Collections.IEnumerable

#### Fields
- internal System.Func<string, Amazon.Util.Marker<U>> fetcher

#### Constructors
- internal PaginatedResource<U>(System.Func<string, Amazon.Util.Marker<U>> fetcher)

#### Methods
- public System.Collections.Generic.IEnumerator<U> GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()

### internal class Amazon.Util.PaginationEnumerator<U>
- Interfaces: System.Collections.Generic.IEnumerator<U>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private static Amazon.Util.Marker<U> blankSpot
- private Amazon.Util.Marker<U> currentSpot
- private Amazon.Util.PaginatedResource<U> paginatedResource
- private int position
- private bool started

#### Properties
- public U Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- private static PaginationEnumerator<U>()
- internal PaginationEnumerator<U>(Amazon.Util.PaginatedResource<U> paginatedResource)

#### Methods
- public void Dispose()
- public bool MoveNext()
- public void Reset()

### public class Amazon.Util.ProcessExecutionResult

#### Fields
- private int <ExitCode>k__BackingField
- private string <StandardError>k__BackingField
- private string <StandardOutput>k__BackingField

#### Properties
- public int ExitCode { get; set; }
- public string StandardError { get; set; }
- public string StandardOutput { get; set; }

#### Constructors
- public ProcessExecutionResult()

### public static class Amazon.Util.ProfileManager

#### Fields
- public static const string AWSCredentialsProfileType
- public static const string SAMLRoleProfileType

#### Properties
- public static bool IsAvailable { get; }

#### Methods
- public static string CopyProfileSettings(string sourceProfileName, string destinationProfileName)
- public static string CopyProfileSettings(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings source, string destinationProfileName)
- public static Amazon.Runtime.AWSCredentials GetAWSCredentials(string profileName)
- public static Amazon.Util.ProfileSettingsBase GetProfile(string profileName)
- public static T GetProfile<T>(string profileName)
- public static Amazon.Util.SAMLEndpointSettings GetSAMLEndpoint(string endpointName)
- public static bool IsProfileKnown(string profileName)
- public static System.Collections.Generic.IEnumerable<string> ListProfileNames()
- public static System.Collections.Generic.IEnumerable<Amazon.Util.ProfileSettingsBase> ListProfiles()
- internal static Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings ReadProfileSettings(string profileName)
- internal static Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings ReadProfileSettings(Amazon.Runtime.Internal.Settings.SettingsCollection settings, string profileName)
- internal static Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings ReadSettings(Amazon.Runtime.Internal.Settings.SettingsCollection settings, string settingsKey)
- public static void RegisterProfile(string profileName, string accessKeyId, string secretKey)
- public static string RegisterSAMLEndpoint(string endpointName, System.Uri endpoint, string authenticationType)
- public static void RegisterSAMLRoleProfile(string profileName, string endpointName, string roleArn, string userIdentity)
- public static void RegisterSAMLRoleProfile(string profileName, string endpointName, string roleArn, string userIdentity, string stsRegion)
- public static bool TryGetAWSCredentials(string profileName, out Amazon.Runtime.AWSCredentials credentials)
- public static bool TryGetProfile<T>(string profileName, out T profile)
- public static bool TryGetSAMLEndpoint(string endpointName, out Amazon.Util.SAMLEndpointSettings endpointSettings)
- public static void UnregisterProfile(string profileName)

### public class Amazon.Util.ProfileSettingsBase

#### Fields
- private string <Name>k__BackingField
- private string <UniqueId>k__BackingField

#### Properties
- public string Name { get; protected set; }
- public string UniqueId { get; protected set; }

#### Constructors
- protected ProfileSettingsBase()

#### Methods
- protected static Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings LoadCredentialsProfile(string profileName)
- public abstract string Persist()

### public class Amazon.Util.ProxyConfig

#### Fields
- private System.Collections.Generic.List<string> <BypassList>k__BackingField
- private bool <BypassOnLocal>k__BackingField
- private string <Host>k__BackingField
- private string <Password>k__BackingField
- private System.Nullable<int> <Port>k__BackingField
- private string <Username>k__BackingField

#### Properties
- public System.Collections.Generic.List<string> BypassList { get; set; }
- public bool BypassOnLocal { get; set; }
- public string Host { get; set; }
- public string Password { get; set; }
- public System.Nullable<int> Port { get; set; }
- public string Username { get; set; }

#### Constructors
- internal ProxyConfig()

### public class Amazon.Util.SAMLEndpointSettings
- Base: Amazon.Util.ProfileSettingsBase

#### Fields
- private System.Uri <Endpoint>k__BackingField
- public static readonly string DefaultAuthenticationType
- private string _authenticationType

#### Properties
- public string AuthenticationType { get; }
- public System.Uri Endpoint { get; private set; }

#### Constructors
- private static SAMLEndpointSettings()
- private SAMLEndpointSettings(string settingsName, System.Uri endpoint, string authenticationType)

#### Methods
- public static bool CanCreateFrom(string endpointName)
- public static bool CanCreateFrom(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings os)
- public static Amazon.Util.SAMLEndpointSettings LoadFrom(string endpointName)
- public static Amazon.Util.SAMLEndpointSettings LoadFrom(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings os)
- private static Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings LoadSettings(string endpointName)
- public override string Persist()
- public static string Persist(string settingsName, System.Uri endpoint, string authenticationType)
- public static void Validate(string endpointName)
- private static void Validate(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings os)

### public class Amazon.Util.SAMLRoleProfile
- Base: Amazon.Util.ProfileSettingsBase

#### Fields
- private Amazon.Util.SAMLEndpointSettings <EndpointSettings>k__BackingField
- private string <Region>k__BackingField
- private string <RoleArn>k__BackingField
- private string <UserIdentity>k__BackingField
- private Amazon.Runtime.SAMLImmutableCredentials _session
- private object _synclock

#### Properties
- public Amazon.Util.SAMLEndpointSettings EndpointSettings { get; internal set; }
- public string Region { get; private set; }
- public string RoleArn { get; internal set; }
- public bool UseDefaultUserIdentity { get; }
- public string UserIdentity { get; internal set; }

#### Constructors
- private SAMLRoleProfile(string profileName, Amazon.Util.SAMLEndpointSettings endpointSettings, string roleArn, string userIdentity, Amazon.Runtime.SAMLImmutableCredentials currentSession, string region)

#### Methods
- public static bool CanCreateFrom(string profileName)
- public static bool CanCreateFrom(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings os)
- public Amazon.Runtime.SAMLImmutableCredentials GetCurrentSession()
- private static Amazon.Runtime.SAMLImmutableCredentials LoadActiveSessionCredentials(string profileName)
- public static Amazon.Util.SAMLRoleProfile LoadFrom(string profileName)
- public static Amazon.Util.SAMLRoleProfile LoadFrom(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings os)
- public override string Persist()
- private string Persist(string session)
- public static string Persist(string profileName, string endpointSettingsName, string roleArn, string userIdentity, string session, string region)
- private static void PersistActiveSessionCredentials(string profileName, string session)
- public void PersistSession(Amazon.Runtime.SAMLImmutableCredentials credentials)
- private void UpdateProfileSessionData(Amazon.Runtime.SAMLImmutableCredentials credentials)
- public static void Validate(string profileName)
- private static void Validate(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings os)

### private class Amazon.Util.CircularReferenceTracking.Tracker
- Interfaces: System.IDisposable

#### Fields
- private Amazon.Util.CircularReferenceTracking <State>k__BackingField
- private object <Target>k__BackingField
- private bool disposed

#### Properties
- private Amazon.Util.CircularReferenceTracking State { get; set; }
- public object Target { get; private set; }

#### Constructors
- public CircularReferenceTracking.Tracker(Amazon.Util.CircularReferenceTracking state, object target)

#### Methods
- protected virtual void Dispose(bool disposing)
- public void Dispose()
- protected override void Finalize()
- public override string ToString()

## Namespace: Amazon.Util.Internal

### private class Amazon.Util.Internal.SettingsManager.<>c

#### Fields
- public static readonly Amazon.Util.Internal.SettingsManager.<>c <>9
- public static System.Func<Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings, string> <>9__11_0

#### Constructors
- private static SettingsManager.<>c()
- public SettingsManager.<>c()

#### Methods
- internal string <ListUniqueKeys>b__11_0(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings x)

### private class Amazon.Util.Internal.SettingsManager.<>c__DisplayClass12_0

#### Fields
- public string propertyName

#### Constructors
- public SettingsManager.<>c__DisplayClass12_0()

#### Methods
- internal string <SelectProperty>b__0(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings x)

### private class Amazon.Util.Internal.TypeFactory.TypeInfoWrapper.<>c__DisplayClass12_0

#### Fields
- public System.Collections.Generic.HashSet<string> processedProperties

#### Constructors
- public TypeFactory.TypeInfoWrapper.<>c__DisplayClass12_0()

#### Methods
- internal bool <GetMembers_Helper>b__0(System.Reflection.MemberInfo member)

### private class Amazon.Util.Internal.SettingsManager.<>c__DisplayClass16_0

#### Fields
- public string propertyName
- public string value

#### Constructors
- public SettingsManager.<>c__DisplayClass16_0()

#### Methods
- internal bool <TryGetObjectSettings>b__0(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings x)

### private class Amazon.Util.Internal.SettingsManager.<>c__DisplayClass17_0

#### Fields
- public string uniqueKey

#### Constructors
- public SettingsManager.<>c__DisplayClass17_0()

#### Methods
- internal bool <TryGetObjectSettings>b__0(Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings x)

### private class Amazon.Util.Internal.TypeFactory.TypeInfoWrapper.<>c__DisplayClass4_0

#### Fields
- public string name

#### Constructors
- public TypeFactory.TypeInfoWrapper.<>c__DisplayClass4_0()

#### Methods
- internal bool <GetInterface>b__0(System.Type x)

### private class Amazon.Util.Internal.TypeFactory.TypeInfoWrapper.<GetMembers_Helper>d__12
- Interfaces: System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Reflection.MemberInfo <>2__current
- public System.Reflection.TypeInfo <>3__ti
- private System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> <>7__wrap2
- private System.Collections.Generic.List<T>.Enumerator<System.Reflection.MemberInfo> <>7__wrap3
- private int <>l__initialThreadId
- private System.Func<System.Reflection.MemberInfo, bool> <alreadyProcessProperty>5__2
- private System.Reflection.TypeInfo ti

#### Properties
- private System.Reflection.MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public TypeFactory.TypeInfoWrapper.<GetMembers_Helper>d__12(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private void <>m__Finally2()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Amazon.Util.Internal.TypeFactory.AbstractTypeInfo
- Interfaces: Amazon.Util.Internal.ITypeInfo

#### Fields
- protected System.Type _type

#### Properties
- public System.Reflection.Assembly Assembly { get; }
- public System.Type BaseType { get; }
- public bool ContainsGenericParameters { get; }
- public string FullName { get; }
- public bool IsAbstract { get; }
- public bool IsArray { get; }
- public bool IsClass { get; }
- public bool IsEnum { get; }
- public bool IsGenericType { get; }
- public bool IsGenericTypeDefinition { get; }
- public bool IsInterface { get; }
- public bool IsSealed { get; }
- public bool IsValueType { get; }
- public string Name { get; }
- public System.Type Type { get; }

#### Constructors
- internal TypeFactory.AbstractTypeInfo(System.Type type)

#### Methods
- public System.Array ArrayCreateInstance(int length)
- public object CreateInstance()
- public Amazon.Util.Internal.ITypeInfo EnumGetUnderlyingType()
- public object EnumToObject(object value)
- public override bool Equals(object obj)
- public abstract System.Reflection.ConstructorInfo GetConstructor(Amazon.Util.Internal.ITypeInfo[] paramTypes)
- public abstract object[] GetCustomAttributes(bool inherit)
- public abstract object[] GetCustomAttributes(Amazon.Util.Internal.ITypeInfo attributeType, bool inherit)
- public Amazon.Util.Internal.ITypeInfo GetElementType()
- public abstract System.Reflection.FieldInfo GetField(string name)
- public abstract System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields()
- public abstract System.Type[] GetGenericArguments()
- public abstract System.Type GetGenericTypeDefinition()
- public override int GetHashCode()
- public abstract System.Type GetInterface(string name)
- public abstract System.Type[] GetInterfaces()
- public abstract System.Reflection.MemberInfo[] GetMembers()
- public abstract System.Reflection.MethodInfo GetMethod(string name)
- public abstract System.Reflection.MethodInfo GetMethod(string name, Amazon.Util.Internal.ITypeInfo[] paramTypes)
- public abstract System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties()
- public abstract System.Reflection.PropertyInfo GetProperty(string name)
- public abstract bool IsAssignableFrom(Amazon.Util.Internal.ITypeInfo typeInfo)
- public bool IsType(System.Type type)

### public class Amazon.Util.Internal.EnvironmentVariableRetriever
- Interfaces: Amazon.Util.Internal.IEnvironmentVariableRetriever

#### Constructors
- public EnvironmentVariableRetriever()

#### Methods
- public string GetEnvironmentVariable(string key)

### public class Amazon.Util.Internal.EnvironmentVariableSource

#### Fields
- private Amazon.Util.Internal.IEnvironmentVariableRetriever <EnvironmentVariableRetriever>k__BackingField
- private static readonly Amazon.Util.Internal.EnvironmentVariableSource instance

#### Properties
- public Amazon.Util.Internal.IEnvironmentVariableRetriever EnvironmentVariableRetriever { get; set; }
- public static Amazon.Util.Internal.EnvironmentVariableSource Instance { get; }

#### Constructors
- private EnvironmentVariableSource()
- private static EnvironmentVariableSource()

### public interface Amazon.Util.Internal.IEnvironmentVariableRetriever

#### Methods
- public string GetEnvironmentVariable(string key)

### public static class Amazon.Util.Internal.InternalSDKUtils

#### Fields
- internal static const string CoreVersionNumber
- internal static string EXECUTION_ENVIRONMENT_ENVVAR
- internal static const string UnknownNetFrameworkVersion
- internal static const string UnknownVersion
- private static string _customData
- private static string _customSdkUserAgent
- private static readonly string _unknown
- private static string _userAgentBaseName
- private static string _versionNumber

#### Constructors
- private static InternalSDKUtils()

#### Methods
- public static void AddToDictionary<TKey, TValue>(System.Collections.Generic.Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
- public static void ApplyValues(object target, System.Collections.Generic.IDictionary<string, object> propertyValues)
- private static void BuildCustomUserAgentString()
- public static string BuildUserAgentString(string serviceSdkVersion)
- public static string DetermineFramework()
- public static string DetermineOS()
- public static string DetermineOSVersion()
- public static string DetermineRuntime()
- public static void FillDictionary<T, TKey, TValue>(System.Collections.Generic.IEnumerable<T> items, System.Func<T, TKey> keyGenerator, System.Func<T, TValue> valueGenerator, System.Collections.Generic.Dictionary<TKey, TValue> targetDictionary)
- internal static string GetExecutionEnvironment()
- private static string GetExecutionEnvironmentUserAgentString()
- public static bool GetIsSet<T>(System.Nullable<T> field)
- public static bool GetIsSet<T>(System.Collections.Generic.List<T> field)
- public static bool GetIsSet<TKey, TVvalue>(System.Collections.Generic.Dictionary<TKey, TVvalue> field)
- public static string GetValidSubstringOrUnknown(string str, int start, int end)
- public static string PlatformUserAgent()
- public static void SetIsSet<T>(bool isSet, ref System.Nullable<T> field)
- public static void SetIsSet<T>(bool isSet, ref System.Collections.Generic.List<T> field)
- public static void SetIsSet<TKey, TValue>(bool isSet, ref System.Collections.Generic.Dictionary<TKey, TValue> field)
- public static void SetUserAgent(string productName, string versionNumber)
- public static void SetUserAgent(string productName, string versionNumber, string customData)
- public static System.Collections.Generic.Dictionary<TKey, TValue> ToDictionary<T, TKey, TValue>(System.Collections.Generic.IEnumerable<T> items, System.Func<T, TKey> keyGenerator, System.Func<T, TValue> valueGenerator)
- public static System.Collections.Generic.Dictionary<TKey, TValue> ToDictionary<T, TKey, TValue>(System.Collections.Generic.IEnumerable<T> items, System.Func<T, TKey> keyGenerator, System.Func<T, TValue> valueGenerator, System.Collections.Generic.IEqualityComparer<TKey> comparer)
- public static bool TryFindByValue<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, TValue value, System.Collections.Generic.IEqualityComparer<TValue> valueComparer, out TKey key)

### public interface Amazon.Util.Internal.ITypeInfo

#### Properties
- public System.Reflection.Assembly Assembly { get; }
- public System.Type BaseType { get; }
- public bool ContainsGenericParameters { get; }
- public string FullName { get; }
- public bool IsAbstract { get; }
- public bool IsArray { get; }
- public bool IsClass { get; }
- public bool IsEnum { get; }
- public bool IsGenericType { get; }
- public bool IsGenericTypeDefinition { get; }
- public bool IsInterface { get; }
- public bool IsSealed { get; }
- public bool IsValueType { get; }
- public string Name { get; }
- public System.Type Type { get; }

#### Methods
- public System.Array ArrayCreateInstance(int length)
- public object CreateInstance()
- public Amazon.Util.Internal.ITypeInfo EnumGetUnderlyingType()
- public object EnumToObject(object value)
- public System.Reflection.ConstructorInfo GetConstructor(Amazon.Util.Internal.ITypeInfo[] paramTypes)
- public object[] GetCustomAttributes(bool inherit)
- public object[] GetCustomAttributes(Amazon.Util.Internal.ITypeInfo attributeType, bool inherit)
- public Amazon.Util.Internal.ITypeInfo GetElementType()
- public System.Reflection.FieldInfo GetField(string name)
- public System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields()
- public System.Type[] GetGenericArguments()
- public System.Type GetGenericTypeDefinition()
- public System.Type GetInterface(string name)
- public System.Type[] GetInterfaces()
- public System.Reflection.MemberInfo[] GetMembers()
- public System.Reflection.MethodInfo GetMethod(string name)
- public System.Reflection.MethodInfo GetMethod(string name, Amazon.Util.Internal.ITypeInfo[] paramTypes)
- public System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties()
- public System.Reflection.PropertyInfo GetProperty(string name)
- public bool IsAssignableFrom(Amazon.Util.Internal.ITypeInfo typeInfo)
- public bool IsType(System.Type type)

### public class Amazon.Util.Internal.NamedSettingsManager

#### Fields
- private Amazon.Util.Internal.SettingsManager settingsManager

#### Properties
- public static bool IsAvailable { get; }

#### Constructors
- public NamedSettingsManager(string settingsType)

#### Methods
- public void CopyObject(string fromDisplayName, string toDisplayName, bool force)
- public System.Collections.Generic.List<string> ListObjectNames()
- public string RegisterObject(string displayName, System.Collections.Generic.Dictionary<string, string> properties)
- public void RenameObject(string oldDisplayName, string newDisplayName, bool force)
- public bool TryGetObject(string displayName, out System.Collections.Generic.Dictionary<string, string> properties)
- public bool TryGetObject(string displayName, out string uniqueKey, out System.Collections.Generic.Dictionary<string, string> properties)
- public void UnregisterObject(string displayName)

### public class Amazon.Util.Internal.RootConfig

#### Fields
- private string <ApplicationName>k__BackingField
- private bool <CorrectForClockSkew>k__BackingField
- private string <CSMClientId>k__BackingField
- private Amazon.Util.CSMConfig <CSMConfig>k__BackingField
- private System.Nullable<bool> <CSMEnabled>k__BackingField
- private System.Nullable<int> <CSMPort>k__BackingField
- private string <EndpointDefinition>k__BackingField
- private Amazon.Util.LoggingConfig <Logging>k__BackingField
- private string <ProfileName>k__BackingField
- private string <ProfilesLocation>k__BackingField
- private Amazon.Util.ProxyConfig <Proxy>k__BackingField
- private string <Region>k__BackingField
- private System.Collections.Generic.IDictionary<string, System.Xml.Linq.XElement> <ServiceSections>k__BackingField
- private bool <UseSdkCache>k__BackingField
- private static const string _rootAwsSectionName

#### Properties
- public string ApplicationName { get; set; }
- public bool CorrectForClockSkew { get; set; }
- public string CSMClientId { get; set; }
- public Amazon.Util.CSMConfig CSMConfig { get; set; }
- public System.Nullable<bool> CSMEnabled { get; set; }
- public System.Nullable<int> CSMPort { get; set; }
- public string EndpointDefinition { get; set; }
- public Amazon.Util.LoggingConfig Logging { get; private set; }
- public string ProfileName { get; set; }
- public string ProfilesLocation { get; set; }
- public Amazon.Util.ProxyConfig Proxy { get; private set; }
- public string Region { get; set; }
- public Amazon.RegionEndpoint RegionEndpoint { get; set; }
- private System.Collections.Generic.IDictionary<string, System.Xml.Linq.XElement> ServiceSections { get; set; }
- public bool UseSdkCache { get; set; }

#### Constructors
- public RootConfig()

#### Methods
- private static string Choose(string a, string b)
- public System.Xml.Linq.XElement GetServiceSection(string service)

### public class Amazon.Util.Internal.SettingsManager

#### Fields
- private string <SettingsType>k__BackingField

#### Properties
- public static bool IsAvailable { get; }
- public string SettingsType { get; private set; }

#### Constructors
- public SettingsManager(string settingsType)

#### Methods
- private static void EnsureAvailable()
- private Amazon.Runtime.Internal.Settings.SettingsCollection GetSettings()
- public System.Collections.Generic.List<string> ListUniqueKeys()
- public string RegisterObject(System.Collections.Generic.Dictionary<string, string> properties)
- public string RegisterObject(string uniqueKey, System.Collections.Generic.Dictionary<string, string> properties)
- private void SaveSettings(Amazon.Runtime.Internal.Settings.SettingsCollection settings)
- public System.Collections.Generic.List<string> SelectProperty(string propertyName)
- public bool TryGetObject(string uniqueKey, out System.Collections.Generic.Dictionary<string, string> properties)
- public bool TryGetObjectByProperty(string propertyName, string value, out string uniqueKey, out System.Collections.Generic.Dictionary<string, string> properties)
- private static bool TryGetObjectSettings(string propertyName, string value, Amazon.Runtime.Internal.Settings.SettingsCollection settings, out Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings objectSettings)
- private static bool TryGetObjectSettings(string uniqueKey, Amazon.Runtime.Internal.Settings.SettingsCollection settings, out Amazon.Runtime.Internal.Settings.SettingsCollection.ObjectSettings objectSettings)
- public void UnregisterObject(string uniqueKey)

### public static class Amazon.Util.Internal.TypeFactory

#### Fields
- public static readonly Amazon.Util.Internal.ITypeInfo[] EmptyTypes

#### Constructors
- private static TypeFactory()

#### Methods
- public static Amazon.Util.Internal.ITypeInfo GetTypeInfo(System.Type type)

### private class Amazon.Util.Internal.TypeFactory.TypeInfoWrapper
- Base: Amazon.Util.Internal.TypeFactory.AbstractTypeInfo
- Interfaces: Amazon.Util.Internal.ITypeInfo

#### Fields
- private static readonly System.Type objectType
- private System.Reflection.TypeInfo _typeInfo

#### Properties
- public System.Reflection.Assembly Assembly { get; }
- public System.Type BaseType { get; }
- public bool ContainsGenericParameters { get; }
- public bool IsAbstract { get; }
- public bool IsClass { get; }
- public bool IsEnum { get; }
- public bool IsGenericType { get; }
- public bool IsGenericTypeDefinition { get; }
- public bool IsInterface { get; }
- public bool IsSealed { get; }
- public bool IsValueType { get; }

#### Constructors
- private static TypeFactory.TypeInfoWrapper()
- internal TypeFactory.TypeInfoWrapper(System.Type type)

#### Methods
- public override System.Reflection.ConstructorInfo GetConstructor(Amazon.Util.Internal.ITypeInfo[] paramTypes)
- public override object[] GetCustomAttributes(bool inherit)
- public override object[] GetCustomAttributes(Amazon.Util.Internal.ITypeInfo attributeType, bool inherit)
- public override System.Reflection.FieldInfo GetField(string name)
- public override System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields()
- public override System.Type[] GetGenericArguments()
- public override System.Type GetGenericTypeDefinition()
- public override System.Type GetInterface(string name)
- public override System.Type[] GetInterfaces()
- public override System.Reflection.MemberInfo[] GetMembers()
- private static System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetMembers_Helper(System.Reflection.TypeInfo ti)
- public override System.Reflection.MethodInfo GetMethod(string name)
- public override System.Reflection.MethodInfo GetMethod(string name, Amazon.Util.Internal.ITypeInfo[] paramTypes)
- public override System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties()
- public override System.Reflection.PropertyInfo GetProperty(string name)
- public override bool IsAssignableFrom(Amazon.Util.Internal.ITypeInfo typeInfo)
- private static bool IsBackingField(System.Reflection.MemberInfo mi)

## Namespace: Amazon.Util.Internal.PlatformServices

### public class Amazon.Util.Internal.PlatformServices.ApplicationInfo
- Interfaces: Amazon.Util.Internal.PlatformServices.IApplicationInfo

#### Properties
- public string AppTitle { get; }
- public string AppVersionCode { get; }
- public string AppVersionName { get; }
- public string PackageName { get; }

#### Constructors
- public ApplicationInfo()

### public class Amazon.Util.Internal.PlatformServices.ApplicationSettings
- Interfaces: Amazon.Util.Internal.PlatformServices.IApplicationSettings

#### Constructors
- public ApplicationSettings()

#### Methods
- public string GetValue(string key, Amazon.Util.Internal.PlatformServices.ApplicationSettingsMode mode)
- public void RemoveValue(string key, Amazon.Util.Internal.PlatformServices.ApplicationSettingsMode mode)
- public void SetValue(string key, string value, Amazon.Util.Internal.PlatformServices.ApplicationSettingsMode mode)

### public enum Amazon.Util.Internal.PlatformServices.ApplicationSettingsMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Local = 1
- None = 0
- Roaming = 2

### public class Amazon.Util.Internal.PlatformServices.EnvironmentInfo
- Interfaces: Amazon.Util.Internal.PlatformServices.IEnvironmentInfo

#### Fields
- private string <FrameworkUserAgent>k__BackingField
- private string <Locale>k__BackingField
- private string <Make>k__BackingField
- private string <Model>k__BackingField
- private string <PclPlatform>k__BackingField
- private string <Platform>k__BackingField
- private string <PlatformUserAgent>k__BackingField
- private string <PlatformVersion>k__BackingField

#### Properties
- public string FrameworkUserAgent { get; private set; }
- public string Locale { get; private set; }
- public string Make { get; private set; }
- public string Model { get; private set; }
- public string PclPlatform { get; private set; }
- public string Platform { get; private set; }
- public string PlatformUserAgent { get; private set; }
- public string PlatformVersion { get; private set; }

#### Constructors
- public EnvironmentInfo()

### public interface Amazon.Util.Internal.PlatformServices.IApplicationInfo

#### Properties
- public string AppTitle { get; }
- public string AppVersionCode { get; }
- public string AppVersionName { get; }
- public string PackageName { get; }

### public interface Amazon.Util.Internal.PlatformServices.IApplicationSettings

#### Methods
- public string GetValue(string key, Amazon.Util.Internal.PlatformServices.ApplicationSettingsMode mode)
- public void RemoveValue(string key, Amazon.Util.Internal.PlatformServices.ApplicationSettingsMode mode)
- public void SetValue(string key, string value, Amazon.Util.Internal.PlatformServices.ApplicationSettingsMode mode)

### public interface Amazon.Util.Internal.PlatformServices.IEnvironmentInfo

#### Properties
- public string FrameworkUserAgent { get; }
- public string Locale { get; }
- public string Make { get; }
- public string Model { get; }
- public string PclPlatform { get; }
- public string Platform { get; }
- public string PlatformUserAgent { get; }
- public string PlatformVersion { get; }

### public interface Amazon.Util.Internal.PlatformServices.INetworkReachability

#### Properties
- public Amazon.Util.Internal.PlatformServices.NetworkStatus NetworkStatus { get; }

#### Events
- public event System.EventHandler<Amazon.Util.Internal.PlatformServices.NetworkStatusEventArgs> NetworkReachabilityChanged

### private enum Amazon.Util.Internal.PlatformServices.ServiceFactory.InstantiationModel
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- InstancePerCall = 1
- Singleton = 0

### public class Amazon.Util.Internal.PlatformServices.NetworkReachability
- Interfaces: Amazon.Util.Internal.PlatformServices.INetworkReachability

#### Properties
- public Amazon.Util.Internal.PlatformServices.NetworkStatus NetworkStatus { get; }

#### Events
- public event System.EventHandler<Amazon.Util.Internal.PlatformServices.NetworkStatusEventArgs> NetworkReachabilityChanged

#### Constructors
- public NetworkReachability()

### public enum Amazon.Util.Internal.PlatformServices.NetworkStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NotReachable = 0
- ReachableViaCarrierDataNetwork = 1
- ReachableViaWiFiNetwork = 2

### public class Amazon.Util.Internal.PlatformServices.NetworkStatusEventArgs
- Base: System.EventArgs

#### Fields
- private Amazon.Util.Internal.PlatformServices.NetworkStatus <Status>k__BackingField

#### Properties
- public Amazon.Util.Internal.PlatformServices.NetworkStatus Status { get; private set; }

#### Constructors
- public NetworkStatusEventArgs(Amazon.Util.Internal.PlatformServices.NetworkStatus status)

### public class Amazon.Util.Internal.PlatformServices.ServiceFactory

#### Fields
- public static Amazon.Util.Internal.PlatformServices.ServiceFactory Instance
- internal static const string NotImplementedErrorMessage
- private static bool _factoryInitialized
- private System.Collections.Generic.IDictionary<System.Type, Amazon.Util.Internal.PlatformServices.ServiceFactory.InstantiationModel> _instantationMappings
- private static readonly object _lock
- private static System.Collections.Generic.IDictionary<System.Type, System.Type> _mappings
- private System.Collections.Generic.IDictionary<System.Type, object> _singletonServices

#### Constructors
- private ServiceFactory()
- private static ServiceFactory()

#### Methods
- public T GetService<T>()
- private static System.Type GetServiceType<T>()
- public static void RegisterService<T>(System.Type serviceType)

## Namespace: ThirdParty.BouncyCastle.Asn1

### public class ThirdParty.BouncyCastle.Asn1.Asn1Encodable

#### Constructors
- protected Asn1Encodable()

#### Methods
- public abstract ThirdParty.BouncyCastle.Asn1.Asn1Object ToAsn1Object()

### public class ThirdParty.BouncyCastle.Asn1.Asn1EncodableVector
- Interfaces: System.Collections.IEnumerable

#### Fields
- private System.Collections.IList v

#### Properties
- public int Count { get; }
- public ThirdParty.BouncyCastle.Asn1.Asn1Encodable Item { get; }
- public int Size { get; }

#### Constructors
- public Asn1EncodableVector(params ThirdParty.BouncyCastle.Asn1.Asn1Encodable[] v)

#### Methods
- public void Add(params ThirdParty.BouncyCastle.Asn1.Asn1Encodable[] objs)
- public void AddOptional(params ThirdParty.BouncyCastle.Asn1.Asn1Encodable[] objs)
- public static ThirdParty.BouncyCastle.Asn1.Asn1EncodableVector FromEnumerable(System.Collections.IEnumerable e)
- public ThirdParty.BouncyCastle.Asn1.Asn1Encodable Get(int index)
- public System.Collections.IEnumerator GetEnumerator()

### public class ThirdParty.BouncyCastle.Asn1.Asn1InputStream
- Base: ThirdParty.BouncyCastle.Asn1.Utilities.FilterStream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- public static const int Constructed
- public static const int Integer
- private readonly int limit

#### Constructors
- public Asn1InputStream(System.IO.Stream inputStream)
- public Asn1InputStream(byte[] input)
- public Asn1InputStream(System.IO.Stream inputStream, int limit)

#### Methods
- internal virtual ThirdParty.BouncyCastle.Asn1.Asn1EncodableVector BuildDerEncodableVector(System.IO.Stream dIn)
- internal ThirdParty.BouncyCastle.Asn1.Asn1EncodableVector BuildEncodableVector()
- private ThirdParty.BouncyCastle.Asn1.Asn1Object BuildObject(int tag, int tagNo, int length)
- internal virtual ThirdParty.BouncyCastle.Asn1.DerSequence CreateDerSequence(System.IO.Stream dIn)
- internal static ThirdParty.BouncyCastle.Asn1.Asn1Object CreatePrimitiveDerObject(int tagNo, byte[] bytes)
- internal static int FindLimit(System.IO.Stream input)
- internal static int ReadLength(System.IO.Stream s, int limit)
- public ThirdParty.BouncyCastle.Asn1.Asn1Object ReadObject()
- internal static int ReadTagNumber(System.IO.Stream s, int tag)

### public class ThirdParty.BouncyCastle.Asn1.Asn1Object
- Base: ThirdParty.BouncyCastle.Asn1.Asn1Encodable

#### Constructors
- protected Asn1Object()

#### Methods
- public static ThirdParty.BouncyCastle.Asn1.Asn1Object FromByteArray(byte[] data)
- public static ThirdParty.BouncyCastle.Asn1.Asn1Object FromStream(System.IO.Stream inStr)
- public override ThirdParty.BouncyCastle.Asn1.Asn1Object ToAsn1Object()

### public class ThirdParty.BouncyCastle.Asn1.Asn1Sequence
- Base: ThirdParty.BouncyCastle.Asn1.Asn1Object
- Interfaces: System.Collections.IEnumerable

#### Fields
- private readonly System.Collections.IList seq

#### Properties
- public int Count { get; }
- public ThirdParty.BouncyCastle.Asn1.Asn1Encodable Item { get; }
- public int Size { get; }

#### Constructors
- protected internal Asn1Sequence(int capacity)

#### Methods
- protected internal void AddObject(ThirdParty.BouncyCastle.Asn1.Asn1Encodable obj)
- private ThirdParty.BouncyCastle.Asn1.Asn1Encodable GetCurrent(System.Collections.IEnumerator e)
- public virtual System.Collections.IEnumerator GetEnumerator()
- public ThirdParty.BouncyCastle.Asn1.Asn1Encodable GetObjectAt(int index)
- public System.Collections.IEnumerator GetObjects()

### public class ThirdParty.BouncyCastle.Asn1.DerInteger
- Base: ThirdParty.BouncyCastle.Asn1.Asn1Object

#### Fields
- private readonly byte[] bytes

#### Properties
- public byte[] Bytes { get; }
- public ThirdParty.BouncyCastle.Math.BigInteger Value { get; }

#### Constructors
- public DerInteger(int value)
- public DerInteger(ThirdParty.BouncyCastle.Math.BigInteger value)
- public DerInteger(byte[] bytes)

#### Methods
- public override string ToString()

### public class ThirdParty.BouncyCastle.Asn1.DerSequence
- Base: ThirdParty.BouncyCastle.Asn1.Asn1Sequence
- Interfaces: System.Collections.IEnumerable

#### Fields
- public static readonly ThirdParty.BouncyCastle.Asn1.DerSequence Empty

#### Constructors
- public DerSequence()
- private static DerSequence()
- public DerSequence(ThirdParty.BouncyCastle.Asn1.Asn1Encodable obj)
- public DerSequence(params ThirdParty.BouncyCastle.Asn1.Asn1Encodable[] v)
- public DerSequence(ThirdParty.BouncyCastle.Asn1.Asn1EncodableVector v)

#### Methods
- public static ThirdParty.BouncyCastle.Asn1.DerSequence FromVector(ThirdParty.BouncyCastle.Asn1.Asn1EncodableVector v)

## Namespace: ThirdParty.BouncyCastle.Asn1.Utilities

### public class ThirdParty.BouncyCastle.Asn1.Utilities.FilterStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- protected readonly System.IO.Stream s

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- public FilterStream(System.IO.Stream s)

#### Methods
- public override void Close()
- public override void Flush()
- public override int Read(byte[] buffer, int offset, int count)
- public override int ReadByte()
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public override void Write(byte[] buffer, int offset, int count)
- public override void WriteByte(byte value)

## Namespace: ThirdParty.BouncyCastle.Math

### public class ThirdParty.BouncyCastle.Math.BigInteger

#### Fields
- private static const int BitsPerByte
- private static const int BitsPerInt
- private static const int BytesPerInt
- private static const long IMASK
- private int[] magnitude
- private int nBitLength
- public static readonly ThirdParty.BouncyCastle.Math.BigInteger One
- private static readonly System.Random RandomSource
- private static readonly byte[] rndMask
- private int sign
- public static readonly ThirdParty.BouncyCastle.Math.BigInteger Ten
- public static readonly ThirdParty.BouncyCastle.Math.BigInteger Three
- public static readonly ThirdParty.BouncyCastle.Math.BigInteger Two
- public static readonly ThirdParty.BouncyCastle.Math.BigInteger Zero
- private static readonly byte[] ZeroEncoding
- private static readonly int[] ZeroMagnitude

#### Properties
- public int BitLength { get; }

#### Constructors
- private BigInteger()
- private static BigInteger()
- public BigInteger(byte[] bytes)
- private BigInteger(int signum, int[] mag, bool checkMag)
- public BigInteger(byte[] bytes, int offset, int length)

#### Methods
- private static int[] AddMagnitudes(int[] a, int[] b)
- private ThirdParty.BouncyCastle.Math.BigInteger AddToMagnitude(int[] magToAdd)
- private static int BitLen(int w)
- private int calcBitLength(int indx, int[] mag)
- private static int CompareNoLeadingZeroes(int xIndx, int[] x, int yIndx, int[] y)
- public int CompareTo(object obj)
- private static int CompareTo(int xIndx, int[] x, int yIndx, int[] y)
- public int CompareTo(ThirdParty.BouncyCastle.Math.BigInteger value)
- private static ThirdParty.BouncyCastle.Math.BigInteger createUValueOf(ulong value)
- private static ThirdParty.BouncyCastle.Math.BigInteger createValueOf(long value)
- private static int[] doSubBigLil(int[] bigMag, int[] lilMag)
- public override bool Equals(object obj)
- private static int GetByteLength(int nBits)
- public override int GetHashCode()
- private ThirdParty.BouncyCastle.Math.BigInteger Inc()
- private static int[] MakeMagnitude(byte[] bytes, int offset, int length)
- public ThirdParty.BouncyCastle.Math.BigInteger Negate()
- public ThirdParty.BouncyCastle.Math.BigInteger Not()
- private static int[] Subtract(int xStart, int[] x, int yStart, int[] y)
- public byte[] ToByteArray()
- private byte[] ToByteArray(bool unsigned)
- public byte[] ToByteArrayUnsigned()
- public static ThirdParty.BouncyCastle.Math.BigInteger ValueOf(long value)

## Namespace: ThirdParty.BouncyCastle.OpenSsl

### public class ThirdParty.BouncyCastle.OpenSsl.PemReader
- Base: ThirdParty.BouncyCastle.Utilities.IO.Pem.PemReader

#### Constructors
- public PemReader(System.IO.TextReader reader)

#### Methods
- private System.Security.Cryptography.RSAParameters convertSequenceToRSAParameters(ThirdParty.BouncyCastle.Asn1.Asn1Sequence seq)
- public static byte[] FixAlignment(byte[] inputBytes, int alignment)
- private int GetAlignmentValue(byte[] modules)
- public System.Security.Cryptography.RSAParameters ReadPrivatekey()

## Namespace: ThirdParty.BouncyCastle.Utilities

### internal class ThirdParty.BouncyCastle.Utilities.Platform

#### Constructors
- protected Platform()

#### Methods
- internal static System.Collections.IList CreateArrayList()
- internal static System.Collections.IList CreateArrayList(int capacity)
- internal static System.Collections.IList CreateArrayList(System.Collections.ICollection collection)
- internal static System.Collections.IList CreateArrayList(System.Collections.IEnumerable collection)

## Namespace: ThirdParty.BouncyCastle.Utilities.IO.Pem

### public class ThirdParty.BouncyCastle.Utilities.IO.Pem.PemGenerationException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public PemGenerationException()
- public PemGenerationException(string message)
- public PemGenerationException(string message, System.Exception exception)

### public class ThirdParty.BouncyCastle.Utilities.IO.Pem.PemHeader

#### Fields
- private string name
- private string val

#### Properties
- public string Name { get; }
- public string Value { get; }

#### Constructors
- public PemHeader(string name, string val)

#### Methods
- public override bool Equals(object obj)
- public override int GetHashCode()
- private int GetHashCode(string s)

### public class ThirdParty.BouncyCastle.Utilities.IO.Pem.PemObject
- Interfaces: ThirdParty.BouncyCastle.Utilities.IO.Pem.PemObjectGenerator

#### Fields
- private byte[] content
- private System.Collections.IList headers
- private string type

#### Properties
- public byte[] Content { get; }
- public System.Collections.IList Headers { get; }
- public string Type { get; }

#### Constructors
- public PemObject(string type, byte[] content)
- public PemObject(string type, System.Collections.IList headers, byte[] content)

#### Methods
- public ThirdParty.BouncyCastle.Utilities.IO.Pem.PemObject Generate()

### public interface ThirdParty.BouncyCastle.Utilities.IO.Pem.PemObjectGenerator

#### Methods
- public ThirdParty.BouncyCastle.Utilities.IO.Pem.PemObject Generate()

### public interface ThirdParty.BouncyCastle.Utilities.IO.Pem.PemObjectParser

#### Methods
- public object ParseObject(ThirdParty.BouncyCastle.Utilities.IO.Pem.PemObject obj)

### public class ThirdParty.BouncyCastle.Utilities.IO.Pem.PemReader

#### Fields
- private static const string BeginString
- private static const string EndString
- private readonly System.IO.TextReader reader

#### Properties
- public System.IO.TextReader Reader { get; }

#### Constructors
- public PemReader(System.IO.TextReader reader)

#### Methods
- private ThirdParty.BouncyCastle.Utilities.IO.Pem.PemObject LoadObject(string type)
- public ThirdParty.BouncyCastle.Utilities.IO.Pem.PemObject ReadPemObject()

## Namespace: ThirdParty.Ionic.Zlib

### internal class ThirdParty.Ionic.Zlib.CRC32

#### Fields
- private static const int BUFFER_SIZE
- private static uint[] crc32Table
- private uint _RunningCrc32Result
- private long _TotalBytesRead

#### Properties
- public int Crc32Result { get; }
- public long TotalBytesRead { get; }

#### Constructors
- private static CRC32()
- public CRC32()

#### Methods
- public int ComputeCrc32(int W, byte B)
- public int GetCrc32(System.IO.Stream input)
- public int GetCrc32AndCopy(System.IO.Stream input, System.IO.Stream output)
- public void SlurpBlock(byte[] block, int offset, int count)
- internal int _InternalComputeCrc32(uint W, byte B)

### public class ThirdParty.Ionic.Zlib.CrcCalculatorStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private ThirdParty.Ionic.Zlib.CRC32 _Crc32
- private System.IO.Stream _InnerStream
- private long _length

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public int Crc32 { get; }
- public long Length { get; }
- public long Position { get; set; }
- public long TotalBytesSlurped { get; }

#### Constructors
- public CrcCalculatorStream(System.IO.Stream stream)
- public CrcCalculatorStream(System.IO.Stream stream, long length)

#### Methods
- public override void Flush()
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public override void Write(byte[] buffer, int offset, int count)

## Namespace: ThirdParty.Json.LitJson

### private class ThirdParty.Json.LitJson.JsonMapper.<>c

#### Fields
- public static readonly ThirdParty.Json.LitJson.JsonMapper.<>c <>9
- public static ThirdParty.Json.LitJson.ExporterFunc <>9__25_0
- public static ThirdParty.Json.LitJson.ExporterFunc <>9__25_1
- public static ThirdParty.Json.LitJson.ExporterFunc <>9__25_10
- public static ThirdParty.Json.LitJson.ExporterFunc <>9__25_2
- public static ThirdParty.Json.LitJson.ExporterFunc <>9__25_3
- public static ThirdParty.Json.LitJson.ExporterFunc <>9__25_4
- public static ThirdParty.Json.LitJson.ExporterFunc <>9__25_5
- public static ThirdParty.Json.LitJson.ExporterFunc <>9__25_6
- public static ThirdParty.Json.LitJson.ExporterFunc <>9__25_7
- public static ThirdParty.Json.LitJson.ExporterFunc <>9__25_8
- public static ThirdParty.Json.LitJson.ExporterFunc <>9__25_9
- public static ThirdParty.Json.LitJson.ImporterFunc <>9__26_0
- public static ThirdParty.Json.LitJson.ImporterFunc <>9__26_1
- public static ThirdParty.Json.LitJson.ImporterFunc <>9__26_10
- public static ThirdParty.Json.LitJson.ImporterFunc <>9__26_11
- public static ThirdParty.Json.LitJson.ImporterFunc <>9__26_12
- public static ThirdParty.Json.LitJson.ImporterFunc <>9__26_13
- public static ThirdParty.Json.LitJson.ImporterFunc <>9__26_2
- public static ThirdParty.Json.LitJson.ImporterFunc <>9__26_3
- public static ThirdParty.Json.LitJson.ImporterFunc <>9__26_4
- public static ThirdParty.Json.LitJson.ImporterFunc <>9__26_5
- public static ThirdParty.Json.LitJson.ImporterFunc <>9__26_6
- public static ThirdParty.Json.LitJson.ImporterFunc <>9__26_7
- public static ThirdParty.Json.LitJson.ImporterFunc <>9__26_8
- public static ThirdParty.Json.LitJson.ImporterFunc <>9__26_9
- public static ThirdParty.Json.LitJson.WrapperFactory <>9__31_0
- public static ThirdParty.Json.LitJson.WrapperFactory <>9__32_0
- public static ThirdParty.Json.LitJson.WrapperFactory <>9__33_0

#### Constructors
- private static JsonMapper.<>c()
- public JsonMapper.<>c()

#### Methods
- internal void <RegisterBaseExporters>b__25_0(object obj, ThirdParty.Json.LitJson.JsonWriter writer)
- internal void <RegisterBaseExporters>b__25_1(object obj, ThirdParty.Json.LitJson.JsonWriter writer)
- internal void <RegisterBaseExporters>b__25_10(object obj, ThirdParty.Json.LitJson.JsonWriter writer)
- internal void <RegisterBaseExporters>b__25_2(object obj, ThirdParty.Json.LitJson.JsonWriter writer)
- internal void <RegisterBaseExporters>b__25_3(object obj, ThirdParty.Json.LitJson.JsonWriter writer)
- internal void <RegisterBaseExporters>b__25_4(object obj, ThirdParty.Json.LitJson.JsonWriter writer)
- internal void <RegisterBaseExporters>b__25_5(object obj, ThirdParty.Json.LitJson.JsonWriter writer)
- internal void <RegisterBaseExporters>b__25_6(object obj, ThirdParty.Json.LitJson.JsonWriter writer)
- internal void <RegisterBaseExporters>b__25_7(object obj, ThirdParty.Json.LitJson.JsonWriter writer)
- internal void <RegisterBaseExporters>b__25_8(object obj, ThirdParty.Json.LitJson.JsonWriter writer)
- internal void <RegisterBaseExporters>b__25_9(object obj, ThirdParty.Json.LitJson.JsonWriter writer)
- internal object <RegisterBaseImporters>b__26_0(object input)
- internal object <RegisterBaseImporters>b__26_1(object input)
- internal object <RegisterBaseImporters>b__26_10(object input)
- internal object <RegisterBaseImporters>b__26_11(object input)
- internal object <RegisterBaseImporters>b__26_12(object input)
- internal object <RegisterBaseImporters>b__26_13(object input)
- internal object <RegisterBaseImporters>b__26_2(object input)
- internal object <RegisterBaseImporters>b__26_3(object input)
- internal object <RegisterBaseImporters>b__26_4(object input)
- internal object <RegisterBaseImporters>b__26_5(object input)
- internal object <RegisterBaseImporters>b__26_6(object input)
- internal object <RegisterBaseImporters>b__26_7(object input)
- internal object <RegisterBaseImporters>b__26_8(object input)
- internal object <RegisterBaseImporters>b__26_9(object input)
- internal ThirdParty.Json.LitJson.IJsonWrapper <ToObject>b__31_0()
- internal ThirdParty.Json.LitJson.IJsonWrapper <ToObject>b__32_0()
- internal ThirdParty.Json.LitJson.IJsonWrapper <ToObject>b__33_0()

### private class ThirdParty.Json.LitJson.JsonMapper.<>c__DisplayClass39_0<T>

#### Fields
- public ThirdParty.Json.LitJson.ExporterFunc<T> exporter

#### Constructors
- public JsonMapper.<>c__DisplayClass39_0<T>()

#### Methods
- internal void <RegisterExporter>b__0(object obj, ThirdParty.Json.LitJson.JsonWriter writer)

### private class ThirdParty.Json.LitJson.JsonMapper.<>c__DisplayClass40_0<TJson, TValue>

#### Fields
- public ThirdParty.Json.LitJson.ImporterFunc<TJson, TValue> importer

#### Constructors
- public JsonMapper.<>c__DisplayClass40_0<TJson, TValue>()

#### Methods
- internal object <RegisterImporter>b__0(object input)

### internal struct ThirdParty.Json.LitJson.ArrayMetadata

#### Fields
- private System.Type element_type
- private bool is_array
- private bool is_list

#### Properties
- public System.Type ElementType { get; set; }
- public bool IsArray { get; set; }
- public bool IsList { get; set; }

### internal enum ThirdParty.Json.LitJson.Condition
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- InArray = 0
- InObject = 1
- NotAProperty = 2
- Property = 3
- Value = 4

### internal delegate ThirdParty.Json.LitJson.ExporterFunc
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ExporterFunc(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(object obj, ThirdParty.Json.LitJson.JsonWriter writer, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(object obj, ThirdParty.Json.LitJson.JsonWriter writer)

### public delegate ThirdParty.Json.LitJson.ExporterFunc<T>
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ExporterFunc<T>(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(T obj, ThirdParty.Json.LitJson.JsonWriter writer, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(T obj, ThirdParty.Json.LitJson.JsonWriter writer)

### internal class ThirdParty.Json.LitJson.FsmContext

#### Fields
- public ThirdParty.Json.LitJson.Lexer L
- public int NextState
- public bool Return
- public int StateStack

#### Constructors
- public FsmContext()

### public interface ThirdParty.Json.LitJson.IJsonWrapper
- Interfaces: System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Specialized.IOrderedDictionary, System.Collections.IDictionary

#### Properties
- public bool IsArray { get; }
- public bool IsBoolean { get; }
- public bool IsDouble { get; }
- public bool IsInt { get; }
- public bool IsLong { get; }
- public bool IsObject { get; }
- public bool IsString { get; }
- public bool IsUInt { get; }
- public bool IsULong { get; }

#### Methods
- public bool GetBoolean()
- public double GetDouble()
- public int GetInt()
- public ThirdParty.Json.LitJson.JsonType GetJsonType()
- public long GetLong()
- public string GetString()
- public uint GetUInt()
- public ulong GetULong()
- public void SetBoolean(bool val)
- public void SetDouble(double val)
- public void SetInt(int val)
- public void SetJsonType(ThirdParty.Json.LitJson.JsonType type)
- public void SetLong(long val)
- public void SetString(string val)
- public void SetUInt(uint val)
- public void SetULong(ulong val)
- public string ToJson()
- public void ToJson(ThirdParty.Json.LitJson.JsonWriter writer)

### internal delegate ThirdParty.Json.LitJson.ImporterFunc
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ImporterFunc(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(object input, System.AsyncCallback callback, object object)
- public virtual object EndInvoke(System.IAsyncResult result)
- public virtual object Invoke(object input)

### public delegate ThirdParty.Json.LitJson.ImporterFunc<TJson, TValue>
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ImporterFunc<TJson, TValue>(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(TJson input, System.AsyncCallback callback, object object)
- public virtual TValue EndInvoke(System.IAsyncResult result)
- public virtual TValue Invoke(TJson input)

### public class ThirdParty.Json.LitJson.JsonData
- Interfaces: ThirdParty.Json.LitJson.IJsonWrapper, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Specialized.IOrderedDictionary, System.Collections.IDictionary, System.IEquatable<ThirdParty.Json.LitJson.JsonData>

#### Fields
- private System.Collections.Generic.IList<ThirdParty.Json.LitJson.JsonData> inst_array
- private bool inst_boolean
- private double inst_double
- private ulong inst_number
- private System.Collections.Generic.IDictionary<string, ThirdParty.Json.LitJson.JsonData> inst_object
- private string inst_string
- private string json
- private System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, ThirdParty.Json.LitJson.JsonData>> object_list
- private ThirdParty.Json.LitJson.JsonType type

#### Properties
- public int Count { get; }
- public bool IsArray { get; }
- public bool IsBoolean { get; }
- public bool IsDouble { get; }
- public bool IsInt { get; }
- public bool IsLong { get; }
- public bool IsObject { get; }
- public bool IsString { get; }
- public bool IsUInt { get; }
- public bool IsULong { get; }
- public ThirdParty.Json.LitJson.JsonData Item { get; set; }
- public ThirdParty.Json.LitJson.JsonData Item { get; set; }
- public System.Collections.Generic.IEnumerable<string> PropertyNames { get; }
- private int System.Collections.ICollection.Count { get; }
- private bool System.Collections.ICollection.IsSynchronized { get; }
- private object System.Collections.ICollection.SyncRoot { get; }
- private bool System.Collections.IDictionary.IsFixedSize { get; }
- private bool System.Collections.IDictionary.IsReadOnly { get; }
- private object System.Collections.IDictionary.Item { get; set; }
- private System.Collections.ICollection System.Collections.IDictionary.Keys { get; }
- private System.Collections.ICollection System.Collections.IDictionary.Values { get; }
- private bool System.Collections.IList.IsFixedSize { get; }
- private bool System.Collections.IList.IsReadOnly { get; }
- private object System.Collections.IList.Item { get; set; }
- private object System.Collections.Specialized.IOrderedDictionary.Item { get; set; }
- private bool ThirdParty.Json.LitJson.IJsonWrapper.IsArray { get; }
- private bool ThirdParty.Json.LitJson.IJsonWrapper.IsBoolean { get; }
- private bool ThirdParty.Json.LitJson.IJsonWrapper.IsDouble { get; }
- private bool ThirdParty.Json.LitJson.IJsonWrapper.IsInt { get; }
- private bool ThirdParty.Json.LitJson.IJsonWrapper.IsLong { get; }
- private bool ThirdParty.Json.LitJson.IJsonWrapper.IsObject { get; }
- private bool ThirdParty.Json.LitJson.IJsonWrapper.IsString { get; }

#### Constructors
- public JsonData()
- public JsonData(bool boolean)
- public JsonData(double number)
- public JsonData(int number)
- public JsonData(uint number)
- public JsonData(long number)
- public JsonData(ulong number)
- public JsonData(object obj)
- public JsonData(string str)

#### Methods
- public int Add(object value)
- public void Clear()
- private System.Collections.ICollection EnsureCollection()
- private System.Collections.IDictionary EnsureDictionary()
- private System.Collections.IList EnsureList()
- public bool Equals(ThirdParty.Json.LitJson.JsonData x)
- public ThirdParty.Json.LitJson.JsonType GetJsonType()
- public static bool op_Explicit(ThirdParty.Json.LitJson.JsonData data)
- public static double op_Explicit(ThirdParty.Json.LitJson.JsonData data)
- public static int op_Explicit(ThirdParty.Json.LitJson.JsonData data)
- public static uint op_Explicit(ThirdParty.Json.LitJson.JsonData data)
- public static long op_Explicit(ThirdParty.Json.LitJson.JsonData data)
- public static ulong op_Explicit(ThirdParty.Json.LitJson.JsonData data)
- public static string op_Explicit(ThirdParty.Json.LitJson.JsonData data)
- public static ThirdParty.Json.LitJson.JsonData op_Implicit(bool data)
- public static ThirdParty.Json.LitJson.JsonData op_Implicit(double data)
- public static ThirdParty.Json.LitJson.JsonData op_Implicit(int data)
- public static ThirdParty.Json.LitJson.JsonData op_Implicit(long data)
- public static ThirdParty.Json.LitJson.JsonData op_Implicit(string data)
- public void SetJsonType(ThirdParty.Json.LitJson.JsonType type)
- private void System.Collections.ICollection.CopyTo(System.Array array, int index)
- private void System.Collections.IDictionary.Add(object key, object value)
- private void System.Collections.IDictionary.Clear()
- private bool System.Collections.IDictionary.Contains(object key)
- private System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
- private void System.Collections.IDictionary.Remove(object key)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private int System.Collections.IList.Add(object value)
- private void System.Collections.IList.Clear()
- private bool System.Collections.IList.Contains(object value)
- private int System.Collections.IList.IndexOf(object value)
- private void System.Collections.IList.Insert(int index, object value)
- private void System.Collections.IList.Remove(object value)
- private void System.Collections.IList.RemoveAt(int index)
- private System.Collections.IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator()
- private void System.Collections.Specialized.IOrderedDictionary.Insert(int idx, object key, object value)
- private void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int idx)
- private bool ThirdParty.Json.LitJson.IJsonWrapper.GetBoolean()
- private double ThirdParty.Json.LitJson.IJsonWrapper.GetDouble()
- private int ThirdParty.Json.LitJson.IJsonWrapper.GetInt()
- private long ThirdParty.Json.LitJson.IJsonWrapper.GetLong()
- private string ThirdParty.Json.LitJson.IJsonWrapper.GetString()
- private uint ThirdParty.Json.LitJson.IJsonWrapper.GetUInt()
- private ulong ThirdParty.Json.LitJson.IJsonWrapper.GetULong()
- private void ThirdParty.Json.LitJson.IJsonWrapper.SetBoolean(bool val)
- private void ThirdParty.Json.LitJson.IJsonWrapper.SetDouble(double val)
- private void ThirdParty.Json.LitJson.IJsonWrapper.SetInt(int val)
- private void ThirdParty.Json.LitJson.IJsonWrapper.SetLong(long val)
- private void ThirdParty.Json.LitJson.IJsonWrapper.SetString(string val)
- private void ThirdParty.Json.LitJson.IJsonWrapper.SetUInt(uint val)
- private void ThirdParty.Json.LitJson.IJsonWrapper.SetULong(ulong val)
- private string ThirdParty.Json.LitJson.IJsonWrapper.ToJson()
- private void ThirdParty.Json.LitJson.IJsonWrapper.ToJson(ThirdParty.Json.LitJson.JsonWriter writer)
- public string ToJson()
- public void ToJson(ThirdParty.Json.LitJson.JsonWriter writer)
- private ThirdParty.Json.LitJson.JsonData ToJsonData(object obj)
- public override string ToString()
- private static void WriteJson(ThirdParty.Json.LitJson.IJsonWrapper obj, ThirdParty.Json.LitJson.JsonWriter writer)

### public class ThirdParty.Json.LitJson.JsonException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public JsonException()
- internal JsonException(ThirdParty.Json.LitJson.ParserToken token)
- internal JsonException(int c)
- public JsonException(string message)
- internal JsonException(ThirdParty.Json.LitJson.ParserToken token, System.Exception inner_exception)
- internal JsonException(int c, System.Exception inner_exception)
- public JsonException(string message, System.Exception inner_exception)

### public class ThirdParty.Json.LitJson.JsonMapper

#### Fields
- private static System.Collections.Generic.IDictionary<System.Type, ThirdParty.Json.LitJson.ArrayMetadata> array_metadata
- private static readonly object array_metadata_lock
- private static System.Collections.Generic.IDictionary<System.Type, ThirdParty.Json.LitJson.ExporterFunc> base_exporters_table
- private static System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<System.Type, ThirdParty.Json.LitJson.ImporterFunc>> base_importers_table
- private static System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<System.Type, System.Reflection.MethodInfo>> conv_ops
- private static readonly object conv_ops_lock
- private static System.Collections.Generic.IDictionary<System.Type, ThirdParty.Json.LitJson.ExporterFunc> custom_exporters_table
- private static System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<System.Type, ThirdParty.Json.LitJson.ImporterFunc>> custom_importers_table
- private static System.IFormatProvider datetime_format
- private static readonly System.Collections.Generic.HashSet<string> dictionary_properties_to_ignore
- private static int max_nesting_depth
- private static System.Collections.Generic.IDictionary<System.Type, ThirdParty.Json.LitJson.ObjectMetadata> object_metadata
- private static readonly object object_metadata_lock
- private static ThirdParty.Json.LitJson.JsonWriter static_writer
- private static readonly object static_writer_lock
- private static System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IList<ThirdParty.Json.LitJson.PropertyMetadata>> type_properties
- private static readonly object type_properties_lock

#### Constructors
- private static JsonMapper()
- public JsonMapper()

#### Methods
- private static void AddArrayMetadata(System.Type type)
- private static void AddObjectMetadata(System.Type type)
- private static void AddTypeProperties(System.Type type)
- private static System.Reflection.MethodInfo GetConvOp(System.Type t1, System.Type t2)
- private static object ReadValue(System.Type inst_type, ThirdParty.Json.LitJson.JsonReader reader)
- private static ThirdParty.Json.LitJson.IJsonWrapper ReadValue(ThirdParty.Json.LitJson.WrapperFactory factory, ThirdParty.Json.LitJson.JsonReader reader)
- private static void RegisterBaseExporters()
- private static void RegisterBaseImporters()
- public static void RegisterExporter<T>(ThirdParty.Json.LitJson.ExporterFunc<T> exporter)
- private static void RegisterImporter(System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<System.Type, ThirdParty.Json.LitJson.ImporterFunc>> table, System.Type json_type, System.Type value_type, ThirdParty.Json.LitJson.ImporterFunc importer)
- public static void RegisterImporter<TJson, TValue>(ThirdParty.Json.LitJson.ImporterFunc<TJson, TValue> importer)
- public static string ToJson(object obj)
- public static void ToJson(object obj, ThirdParty.Json.LitJson.JsonWriter writer)
- public static ThirdParty.Json.LitJson.JsonData ToObject(ThirdParty.Json.LitJson.JsonReader reader)
- public static ThirdParty.Json.LitJson.JsonData ToObject(System.IO.TextReader reader)
- public static ThirdParty.Json.LitJson.JsonData ToObject(string json)
- public static T ToObject<T>(ThirdParty.Json.LitJson.JsonReader reader)
- public static T ToObject<T>(System.IO.TextReader reader)
- public static T ToObject<T>(string json)
- public static ThirdParty.Json.LitJson.IJsonWrapper ToWrapper(ThirdParty.Json.LitJson.WrapperFactory factory, ThirdParty.Json.LitJson.JsonReader reader)
- public static ThirdParty.Json.LitJson.IJsonWrapper ToWrapper(ThirdParty.Json.LitJson.WrapperFactory factory, string json)
- public static void UnregisterExporters()
- public static void UnregisterImporters()
- private static void ValidateRequiredFields(object instance, System.Type inst_type)
- private static void WriteValue(object obj, ThirdParty.Json.LitJson.JsonWriter writer, bool writer_is_private, int depth)

### public class ThirdParty.Json.LitJson.JsonPropertyAttribute
- Base: System.Attribute

#### Fields
- private bool <Required>k__BackingField

#### Properties
- public bool Required { get; set; }

#### Constructors
- public JsonPropertyAttribute()

### public class ThirdParty.Json.LitJson.JsonReader

#### Fields
- private int current_input
- private int current_symbol
- private System.Collections.Generic.Stack<ThirdParty.Json.LitJson.JsonToken> depth
- private bool end_of_input
- private bool end_of_json
- private ThirdParty.Json.LitJson.Lexer lexer
- private bool parser_in_string
- private bool parser_return
- private System.IO.TextReader reader
- private bool reader_is_owned
- private bool read_started
- private ThirdParty.Json.LitJson.JsonToken token
- private object token_value

#### Properties
- public bool AllowComments { get; set; }
- public bool AllowSingleQuotedStrings { get; set; }
- public bool EndOfInput { get; }
- public bool EndOfJson { get; }
- public ThirdParty.Json.LitJson.JsonToken Token { get; }
- public object Value { get; }

#### Constructors
- public JsonReader(string json_text)
- public JsonReader(System.IO.TextReader reader)
- private JsonReader(System.IO.TextReader reader, bool owned)

#### Methods
- public void Close()
- private void ProcessNumber(string number)
- private void ProcessSymbol()
- public bool Read()
- private bool ReadToken()

### public enum ThirdParty.Json.LitJson.JsonToken
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ArrayEnd = 5
- ArrayStart = 4
- Boolean = 12
- Double = 10
- Int = 6
- Long = 8
- None = 0
- Null = 13
- ObjectEnd = 3
- ObjectStart = 1
- PropertyName = 2
- String = 11
- UInt = 7
- ULong = 9

### public enum ThirdParty.Json.LitJson.JsonType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Array = 2
- Boolean = 9
- Double = 8
- Int = 4
- Long = 6
- None = 0
- Object = 1
- String = 3
- UInt = 5
- ULong = 7

### public class ThirdParty.Json.LitJson.JsonWriter

#### Fields
- private ThirdParty.Json.LitJson.WriterContext context
- private System.Collections.Generic.Stack<ThirdParty.Json.LitJson.WriterContext> ctx_stack
- private bool has_reached_end
- private char[] hex_seq
- private int indentation
- private int indent_value
- private System.Text.StringBuilder inst_string_builder
- private static System.Globalization.NumberFormatInfo number_format
- private bool pretty_print
- private bool validate
- private System.IO.TextWriter writer

#### Properties
- public int IndentValue { get; set; }
- public bool PrettyPrint { get; set; }
- public System.IO.TextWriter TextWriter { get; }
- public bool Validate { get; set; }

#### Constructors
- private static JsonWriter()
- public JsonWriter()
- public JsonWriter(System.Text.StringBuilder sb)
- public JsonWriter(System.IO.TextWriter writer)

#### Methods
- private void DoValidation(ThirdParty.Json.LitJson.Condition cond)
- private void Indent()
- private void Init()
- private static void IntToHex(int n, char[] hex)
- private void Put(string str)
- private void PutNewline()
- private void PutNewline(bool add_comma)
- private void PutString(string str)
- public void Reset()
- public override string ToString()
- private void Unindent()
- public void Write(bool boolean)
- public void Write(decimal number)
- public void Write(double number)
- public void Write(int number)
- public void Write(uint number)
- public void Write(long number)
- public void Write(string str)
- public void Write(ulong number)
- public void Write(System.DateTime date)
- public void WriteArrayEnd()
- public void WriteArrayStart()
- public void WriteObjectEnd()
- public void WriteObjectStart()
- public void WritePropertyName(string property_name)
- public void WriteRaw(string str)

### internal class ThirdParty.Json.LitJson.Lexer

#### Fields
- private bool allow_comments
- private bool allow_single_quoted_strings
- private bool end_of_input
- private ThirdParty.Json.LitJson.FsmContext fsm_context
- private static ThirdParty.Json.LitJson.Lexer.StateHandler[] fsm_handler_table
- private static int[] fsm_return_table
- private int input_buffer
- private int input_char
- private System.IO.TextReader reader
- private int state
- private System.Text.StringBuilder string_buffer
- private string string_value
- private int token
- private int unichar

#### Properties
- public bool AllowComments { get; set; }
- public bool AllowSingleQuotedStrings { get; set; }
- public bool EndOfInput { get; }
- public string StringValue { get; }
- public int Token { get; }

#### Constructors
- private static Lexer()
- public Lexer(System.IO.TextReader reader)

#### Methods
- private bool GetChar()
- private static int HexValue(int digit)
- private int NextChar()
- public bool NextToken()
- private static void PopulateFsmTables()
- private static char ProcessEscChar(int esc_char)
- private static bool State1(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State10(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State11(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State12(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State13(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State14(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State15(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State16(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State17(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State18(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State19(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State2(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State20(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State21(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State22(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State23(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State24(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State25(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State26(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State27(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State28(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State3(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State4(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State5(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State6(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State7(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State8(ThirdParty.Json.LitJson.FsmContext ctx)
- private static bool State9(ThirdParty.Json.LitJson.FsmContext ctx)
- private void UngetChar()

### internal struct ThirdParty.Json.LitJson.ObjectMetadata

#### Fields
- private System.Type element_type
- private bool is_dictionary
- private System.Collections.Generic.IDictionary<string, ThirdParty.Json.LitJson.PropertyMetadata> properties

#### Properties
- public System.Type ElementType { get; set; }
- public bool IsDictionary { get; set; }
- public System.Collections.Generic.IDictionary<string, ThirdParty.Json.LitJson.PropertyMetadata> Properties { get; set; }

### internal class ThirdParty.Json.LitJson.OrderedDictionaryEnumerator
- Interfaces: System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator

#### Fields
- private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, ThirdParty.Json.LitJson.JsonData>> list_enumerator

#### Properties
- public object Current { get; }
- public System.Collections.DictionaryEntry Entry { get; }
- public object Key { get; }
- public object Value { get; }

#### Constructors
- public OrderedDictionaryEnumerator(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, ThirdParty.Json.LitJson.JsonData>> enumerator)

#### Methods
- public bool MoveNext()
- public void Reset()

### internal enum ThirdParty.Json.LitJson.ParserToken
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Array = 65548
- ArrayPrime = 65549
- Char = 65542
- CharSeq = 65541
- End = 65553
- Epsilon = 65554
- False = 65539
- None = 65536
- Null = 65540
- Number = 65537
- Object = 65544
- ObjectPrime = 65545
- Pair = 65546
- PairRest = 65547
- String = 65552
- Text = 65543
- True = 65538
- Value = 65550
- ValueRest = 65551

### internal struct ThirdParty.Json.LitJson.PropertyMetadata

#### Fields
- public System.Reflection.MemberInfo Info
- public bool IsField
- public System.Type Type

### private delegate ThirdParty.Json.LitJson.Lexer.StateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Lexer.StateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ThirdParty.Json.LitJson.FsmContext ctx, System.AsyncCallback callback, object object)
- public virtual bool EndInvoke(System.IAsyncResult result)
- public virtual bool Invoke(ThirdParty.Json.LitJson.FsmContext ctx)

### public delegate ThirdParty.Json.LitJson.WrapperFactory
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public WrapperFactory(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual ThirdParty.Json.LitJson.IJsonWrapper EndInvoke(System.IAsyncResult result)
- public virtual ThirdParty.Json.LitJson.IJsonWrapper Invoke()

### internal class ThirdParty.Json.LitJson.WriterContext

#### Fields
- public int Count
- public bool ExpectingValue
- public bool InArray
- public bool InObject
- public int Padding

#### Constructors
- public WriterContext()

## Namespace: ThirdParty.MD5

### internal struct ThirdParty.MD5.ABCDStruct

#### Fields
- public uint A
- public uint B
- public uint C
- public uint D

### internal class ThirdParty.MD5.MD5Core

#### Constructors
- private MD5Core()

#### Methods
- private static uint[] Converter(byte[] input, int ibStart)
- public static byte[] GetHash(string input, System.Text.Encoding encoding)
- public static byte[] GetHash(string input)
- public static byte[] GetHash(byte[] input)
- internal static void GetHashBlock(byte[] input, ref ThirdParty.MD5.ABCDStruct ABCDValue, int ibStart)
- internal static byte[] GetHashFinalBlock(byte[] input, int ibStart, int cbSize, ThirdParty.MD5.ABCDStruct ABCD, long len)
- public static string GetHashString(byte[] input)
- public static string GetHashString(string input, System.Text.Encoding encoding)
- public static string GetHashString(string input)
- private static uint LSR(uint i, int s)
- private static uint r1(uint a, uint b, uint c, uint d, uint x, int s, uint t)
- private static uint r2(uint a, uint b, uint c, uint d, uint x, int s, uint t)
- private static uint r3(uint a, uint b, uint c, uint d, uint x, int s, uint t)
- private static uint r4(uint a, uint b, uint c, uint d, uint x, int s, uint t)

### public class ThirdParty.MD5.MD5Managed
- Base: System.Security.Cryptography.HashAlgorithm
- Interfaces: System.IDisposable, System.Security.Cryptography.ICryptoTransform

#### Fields
- private ThirdParty.MD5.ABCDStruct _abcd
- private byte[] _data
- private int _dataSize
- private long _totalLength

#### Constructors
- public MD5Managed()

#### Methods
- protected override void HashCore(byte[] array, int ibStart, int cbSize)
- protected override byte[] HashFinal()
- public override void Initialize()
- public void TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount)
- public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)

