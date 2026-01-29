# Assembly: Unity.Analytics.Tracker
- Path: tools/WorldBox.Managed/Unity.Analytics.Tracker.dll
- Types: 25

## Namespace: UnityEngine.Analytics

### private class UnityEngine.Analytics.AnalyticsEventTracker.<TimedTrigger>c__Iterator0
- Interfaces: System.Collections.IEnumerator, System.IDisposable, System.Collections.Generic.IEnumerator<object>

#### Fields
- internal object $current
- internal bool $disposing
- internal int $PC
- internal UnityEngine.Analytics.AnalyticsEventTracker $this

#### Properties
- private object System.Collections.Generic.IEnumerator<object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public AnalyticsEventTracker.<TimedTrigger>c__Iterator0()

#### Methods
- public void Dispose()
- public bool MoveNext()
- public void Reset()

### public class UnityEngine.Analytics.AnalyticsEventParam

#### Fields
- private string m_GroupID
- private string m_Name
- private UnityEngine.Analytics.AnalyticsEventParam.RequirementType m_RequirementType
- private string m_Tooltip
- private UnityEngine.Analytics.ValueProperty m_Value

#### Properties
- public string groupID { get; }
- public string name { get; }
- public UnityEngine.Analytics.AnalyticsEventParam.RequirementType requirementType { get; }
- public object value { get; }
- public UnityEngine.Analytics.ValueProperty valueProperty { get; }

#### Constructors
- public AnalyticsEventParam(string name)

### public class UnityEngine.Analytics.AnalyticsEventParamListContainer

#### Fields
- private System.Collections.Generic.List<UnityEngine.Analytics.AnalyticsEventParam> m_Parameters

#### Properties
- public System.Collections.Generic.List<UnityEngine.Analytics.AnalyticsEventParam> parameters { get; set; }

#### Constructors
- public AnalyticsEventParamListContainer()

### public class UnityEngine.Analytics.AnalyticsEventTracker
- Base: UnityEngine.MonoBehaviour

#### Fields
- private UnityEngine.Analytics.StandardEventPayload m_EventPayload
- public UnityEngine.Analytics.EventTrigger m_Trigger

#### Properties
- public UnityEngine.Analytics.StandardEventPayload payload { get; }

#### Constructors
- public AnalyticsEventTracker()

#### Methods
- private void Awake()
- private void OnApplicationPause(bool paused)
- private void OnDestroy()
- private void OnDisable()
- private void OnEnable()
- private UnityEngine.Analytics.AnalyticsResult SendEvent()
- private void Start()
- private System.Collections.IEnumerator TimedTrigger()
- public void TriggerEvent()

### public static class UnityEngine.Analytics.AnalyticsEventTrackerSettings

#### Fields
- public static readonly int paramCountMax
- public static readonly int triggerRuleCountMax

#### Constructors
- private static AnalyticsEventTrackerSettings()

### public class UnityEngine.Analytics.AnalyticsTracker
- Base: UnityEngine.MonoBehaviour

#### Fields
- private System.Collections.Generic.Dictionary<string, object> m_Dict
- private string m_EventName
- private int m_PrevDictHash
- private UnityEngine.Analytics.TrackableProperty m_TrackableProperty
- internal UnityEngine.Analytics.AnalyticsTracker.Trigger m_Trigger

#### Properties
- public string eventName { get; set; }
- internal UnityEngine.Analytics.TrackableProperty TP { get; set; }

#### Constructors
- public AnalyticsTracker()

#### Methods
- private void Awake()
- private void BuildParameters()
- private void OnApplicationPause()
- private void OnDestroy()
- private void OnDisable()
- private void OnEnable()
- private void SendEvent()
- private void Start()
- public void TriggerEvent()

### public class UnityEngine.Analytics.EventTrigger

#### Fields
- private bool m_ApplyRules
- private float m_InitTime
- private bool m_IsTriggerExpanded
- private UnityEngine.Analytics.TriggerLifecycleEvent m_LifecycleEvent
- private UnityEngine.Analytics.TriggerMethod m_Method
- private float m_RepeatTime
- private int m_Repetitions
- private UnityEngine.Analytics.TriggerListContainer m_Rules
- private UnityEngine.Analytics.TriggerBool m_TriggerBool
- private UnityEngine.Analytics.EventTrigger.OnTrigger m_TriggerFunction
- private UnityEngine.Analytics.TriggerType m_Type
- public int repetitionCount

#### Properties
- public float initTime { get; set; }
- public UnityEngine.Analytics.TriggerLifecycleEvent lifecycleEvent { get; }
- public float repeatTime { get; set; }
- public int repetitions { get; set; }
- public UnityEngine.Analytics.TriggerType triggerType { get; }

#### Constructors
- public EventTrigger()

#### Methods
- public void AddRule()
- public void RemoveRule(int index)
- public bool Test(UnityEngine.GameObject gameObject = null)

### internal class UnityEngine.Analytics.TrackableProperty.FieldWithTarget

#### Fields
- private bool m_DoStatic
- private string m_FieldPath
- private string m_ParamName
- private string m_StaticString
- private UnityEngine.Object m_Target
- private string m_TypeString

#### Properties
- public bool doStatic { get; set; }
- public string fieldPath { get; set; }
- public string paramName { get; set; }
- public string staticString { get; set; }
- public UnityEngine.Object target { get; set; }
- public string typeString { get; set; }

#### Constructors
- public TrackableProperty.FieldWithTarget()

#### Methods
- public object GetValue()

### internal delegate UnityEngine.Analytics.EventTrigger.OnTrigger
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public EventTrigger.OnTrigger(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

### public enum UnityEngine.Analytics.ValueProperty.PropertyType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Disabled = 0
- Dynamic = 2
- Static = 1

### public enum UnityEngine.Analytics.AnalyticsEventParam.RequirementType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- None = 0
- Optional = 2
- Required = 1

### public class UnityEngine.Analytics.StandardEventPayload

#### Fields
- private static System.Collections.Generic.Dictionary<string, object> m_EventData
- private bool m_IsEventExpanded
- private string m_Name
- private UnityEngine.Analytics.AnalyticsEventParamListContainer m_Parameters
- private string m_StandardEventType
- public System.Type standardEventType

#### Properties
- public string name { get; set; }
- public UnityEngine.Analytics.AnalyticsEventParamListContainer parameters { get; }

#### Constructors
- public StandardEventPayload()
- private static StandardEventPayload()

#### Methods
- private System.Collections.Generic.IDictionary<string, object> GetParameters()
- private bool IsCustomDataValid()
- private bool IsRequiredDataValid()
- public virtual UnityEngine.Analytics.AnalyticsResult Send()

### public class UnityEngine.Analytics.TrackableField
- Base: UnityEngine.Analytics.TrackablePropertyBase

#### Fields
- private string m_EnumType
- private string m_Type
- private string[] m_ValidTypeNames

#### Constructors
- public TrackableField(params System.Type[] validTypes)

#### Methods
- public object GetValue()

### internal class UnityEngine.Analytics.TrackableProperty

#### Fields
- public static const int kMaxParams
- private System.Collections.Generic.List<UnityEngine.Analytics.TrackableProperty.FieldWithTarget> m_Fields

#### Properties
- public System.Collections.Generic.List<UnityEngine.Analytics.TrackableProperty.FieldWithTarget> fields { get; set; }

#### Constructors
- public TrackableProperty()

#### Methods
- public override int GetHashCode()

### public class UnityEngine.Analytics.TrackablePropertyBase

#### Fields
- protected string m_Path
- protected UnityEngine.Object m_Target

#### Constructors
- protected TrackablePropertyBase()

### public class UnityEngine.Analytics.TrackableTrigger

#### Fields
- private string m_MethodPath
- private UnityEngine.GameObject m_Target

#### Constructors
- public TrackableTrigger()

### internal enum UnityEngine.Analytics.AnalyticsTracker.Trigger
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Awake = 1
- External = 0
- OnApplicationPause = 5
- OnDestroy = 6
- OnDisable = 4
- OnEnable = 3
- Start = 2

### public enum UnityEngine.Analytics.TriggerBool
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- All = 0
- Any = 1
- None = 2

### public enum UnityEngine.Analytics.TriggerLifecycleEvent
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Awake = 1
- None = 0
- OnApplicationPause = 5
- OnApplicationUnpause = 6
- OnDestroy = 7
- OnDisable = 4
- OnEnable = 3
- Start = 2

### public class UnityEngine.Analytics.TriggerListContainer

#### Fields
- private System.Collections.Generic.List<UnityEngine.Analytics.TriggerRule> m_Rules

#### Properties
- internal System.Collections.Generic.List<UnityEngine.Analytics.TriggerRule> rules { get; set; }

#### Constructors
- public TriggerListContainer()

### public class UnityEngine.Analytics.TriggerMethod

#### Constructors
- public TriggerMethod()

### public enum UnityEngine.Analytics.TriggerOperator
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DoesNotEqual = 1
- Equals = 0
- IsBetween = 6
- IsBetweenOrEqualTo = 7
- IsGreaterThan = 2
- IsGreaterThanOrEqualTo = 3
- IsLessThan = 4
- IsLessThanOrEqualTo = 5

### public class UnityEngine.Analytics.TriggerRule

#### Fields
- private UnityEngine.Analytics.TriggerOperator m_Operator
- private UnityEngine.Analytics.TrackableField m_Target
- private UnityEngine.Analytics.ValueProperty m_Value
- private UnityEngine.Analytics.ValueProperty m_Value2

#### Constructors
- public TriggerRule()

#### Methods
- private double GetDouble(object value)
- private bool SafeEquals(double double1, double double2)
- public bool Test()
- public bool Test(out bool error, out string message)
- private bool TestByBool(bool currentValue)
- private bool TestByDouble(double currentValue)
- private bool TestByEnum(string currentValue)
- private bool TestByObject(object currentValue)
- private bool TestByString(string currentValue)

### public enum UnityEngine.Analytics.TriggerType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ExposedMethod = 3
- External = 1
- Lifecycle = 0
- Timer = 2

### public class UnityEngine.Analytics.ValueProperty

#### Fields
- private bool m_CanDisable
- private string m_CustomValue
- private bool m_EditingCustomValue
- private string m_EnumType
- private bool m_EnumTypeIsCustomizable
- private bool m_FixedType
- private int m_PopupIndex
- private UnityEngine.Analytics.ValueProperty.PropertyType m_PropertyType
- private UnityEngine.Analytics.TrackableField m_Target
- private string m_Value
- private string m_ValueType

#### Properties
- public string propertyValue { get; }
- public UnityEngine.Analytics.TrackableField target { get; }
- public string valueType { get; set; }

#### Constructors
- public ValueProperty()

#### Methods
- public bool IsValid()

