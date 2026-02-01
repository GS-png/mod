# Assembly: Unity.Services.Core.Telemetry
- Path: tools/WorldBox.Managed/Unity.Services.Core.Telemetry.dll
- Types: 13

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=872 3ABE754990AB9402E5E027A6C9D59B002A1E4BC0728BEF1207AB5B633B8F39A9
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=484 6C4A5F01BC43B01AA1FF5BB45FB0DEC5ED38978C85521CD72D230EDCC816D39E

### private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData

#### Fields
- public byte[] FilePathsData
- public bool IsEditorOnly
- public int TotalFiles
- public int TotalTypes
- public byte[] TypesData

### internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1

#### Constructors
- public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()

#### Methods
- private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=484

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=872

## Namespace: Unity.Services.Core.Telemetry.Internal

### internal class Unity.Services.Core.Telemetry.Internal.Diagnostics
- Interfaces: Unity.Services.Core.Telemetry.Internal.IDiagnostics

#### Fields
- private readonly System.Collections.Generic.IDictionary<string, string> <PackageTags>k__BackingField

#### Properties
- internal System.Collections.Generic.IDictionary<string, string> PackageTags { get; }

#### Constructors
- public Diagnostics()

#### Methods
- public void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<string, string> tags = null)

### internal class Unity.Services.Core.Telemetry.Internal.DiagnosticsFactory
- Interfaces: Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory, Unity.Services.Core.Internal.IServiceComponent

#### Fields
- private readonly System.Collections.Generic.IReadOnlyDictionary<string, string> <CommonTags>k__BackingField

#### Properties
- public System.Collections.Generic.IReadOnlyDictionary<string, string> CommonTags { get; }

#### Constructors
- public DiagnosticsFactory()

#### Methods
- public Unity.Services.Core.Telemetry.Internal.IDiagnostics Create(string packageName)

### internal class Unity.Services.Core.Telemetry.Internal.DisabledDiagnostics
- Interfaces: Unity.Services.Core.Telemetry.Internal.IDiagnostics

#### Constructors
- public DisabledDiagnostics()

#### Methods
- private void Unity.Services.Core.Telemetry.Internal.IDiagnostics.SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<string, string> tags)

### internal class Unity.Services.Core.Telemetry.Internal.DisabledDiagnosticsFactory
- Interfaces: Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory, Unity.Services.Core.Internal.IServiceComponent

#### Fields
- private readonly System.Collections.Generic.IReadOnlyDictionary<string, string> <Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory.CommonTags>k__BackingField

#### Properties
- private System.Collections.Generic.IReadOnlyDictionary<string, string> Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory.CommonTags { get; }

#### Constructors
- public DisabledDiagnosticsFactory()

#### Methods
- private Unity.Services.Core.Telemetry.Internal.IDiagnostics Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory.Create(string packageName)

### internal class Unity.Services.Core.Telemetry.Internal.DisabledMetrics
- Interfaces: Unity.Services.Core.Telemetry.Internal.IMetrics

#### Constructors
- public DisabledMetrics()

#### Methods
- private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags)
- private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(string name, double time, System.Collections.Generic.IDictionary<string, string> tags)
- private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags)

### internal class Unity.Services.Core.Telemetry.Internal.DisabledMetricsFactory
- Interfaces: Unity.Services.Core.Telemetry.Internal.IMetricsFactory, Unity.Services.Core.Internal.IServiceComponent

#### Fields
- private readonly System.Collections.Generic.IReadOnlyDictionary<string, string> <Unity.Services.Core.Telemetry.Internal.IMetricsFactory.CommonTags>k__BackingField

#### Properties
- private System.Collections.Generic.IReadOnlyDictionary<string, string> Unity.Services.Core.Telemetry.Internal.IMetricsFactory.CommonTags { get; }

#### Constructors
- public DisabledMetricsFactory()

#### Methods
- private Unity.Services.Core.Telemetry.Internal.IMetrics Unity.Services.Core.Telemetry.Internal.IMetricsFactory.Create(string packageName)

### internal class Unity.Services.Core.Telemetry.Internal.Metrics
- Interfaces: Unity.Services.Core.Telemetry.Internal.IMetrics

#### Fields
- private readonly System.Collections.Generic.IDictionary<string, string> <PackageTags>k__BackingField

#### Properties
- internal System.Collections.Generic.IDictionary<string, string> PackageTags { get; }

#### Constructors
- public Metrics()

#### Methods
- private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags)
- private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(string name, double time, System.Collections.Generic.IDictionary<string, string> tags)
- private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags)

### internal class Unity.Services.Core.Telemetry.Internal.MetricsFactory
- Interfaces: Unity.Services.Core.Telemetry.Internal.IMetricsFactory, Unity.Services.Core.Internal.IServiceComponent

#### Fields
- private readonly System.Collections.Generic.IReadOnlyDictionary<string, string> <CommonTags>k__BackingField

#### Properties
- public System.Collections.Generic.IReadOnlyDictionary<string, string> CommonTags { get; }

#### Constructors
- public MetricsFactory()

#### Methods
- public Unity.Services.Core.Telemetry.Internal.IMetrics Create(string packageName)

