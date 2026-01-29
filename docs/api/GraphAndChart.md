# Assembly: GraphAndChart
- Path: tools/WorldBox.Managed/GraphAndChart.dll
- Types: 195

## Namespace: (global)

### private class HoverText.<>c

#### Fields
- public static readonly HoverText.<>c <>9
- public static System.Predicate<ChartAndGraph.CharItemEffectController> <>9__10_0

#### Constructors
- private static HoverText.<>c()
- public HoverText.<>c()

#### Methods
- internal bool <Update>b__10_0(ChartAndGraph.CharItemEffectController x)

### private class TextController.<>c__DisplayClass36_0

#### Fields
- public TextController <>4__this
- public float scale

#### Constructors
- public TextController.<>c__DisplayClass36_0()

#### Methods
- internal bool <ApplyTextPosition>b__0(BillboardText x)

### private class GraphDataFiller.<GetData>d__29
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public GraphDataFiller <>4__this
- private UnityEngine.Networking.UnityWebRequest <webRequest>5__2
- public UnityEngine.WWWForm postData

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public GraphDataFiller.<GetData>d__29(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8134 0BA994FA6BEF1BE13A2021774BA21754E6352B37A3EC4528370AACCBE03B7BC4
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6080 A3C8A72DB0FFDD2114B604C878368BA6FE6B0B7A14605308777DDA23C0B9D0F1

### private class HoverText.<SelectText>d__11
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public UnityEngine.UI.Text text

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public HoverText.<SelectText>d__11(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### public class AxisCoordinates
- Base: UnityEngine.MonoBehaviour

#### Fields
- public UnityEngine.UI.Text Coordinates
- private UnityEngine.RectTransform mHorizontal
- private UnityEngine.RectTransform mVertical
- public UnityEngine.RectTransform Prefab
- public string TextFormat

#### Constructors
- public AxisCoordinates()

#### Methods
- private void Start()
- private void Update()

### public class BillboardText
- Base: UnityEngine.MonoBehaviour

#### Fields
- private UnityEngine.GameObject <UIText>k__BackingField
- private object <UserData>k__BackingField
- public ChartAndGraph.TextDirection Direction
- private UnityEngine.RectTransform mRect
- private UnityEngine.CanvasRenderer[] mRenderers
- public UnityEngine.RectTransform parent
- public bool parentSet
- public UnityEngine.RectTransform RectTransformOverride
- public bool Recycled
- public float Scale
- public bool YMirror

#### Properties
- public UnityEngine.RectTransform Rect { get; }
- public UnityEngine.GameObject UIText { get; set; }
- public object UserData { get; set; }

#### Constructors
- public BillboardText()

#### Methods
- public void SetVisible(bool visible)

### public class GraphDataFiller.CategoryData

#### Fields
- public GraphDataFiller.VectorFormat DataFormat
- public string DataObjectName
- public GraphDataFiller.DataType DataType
- public bool Enabled
- public string Name
- public string ParentObjectName
- public string SizeDataObjectName
- public int Skip
- public string XDataObjectName
- public string XDateFormat
- public string YDataObjectName
- public string YDateFormat

#### Constructors
- public GraphDataFiller.CategoryData()

### public class CategoryLabels
- Base: ChartAndGraph.AlignedItemLabels
- Interfaces: ChartAndGraph.IInternalSettings, UnityEngine.ISerializationCallbackReceiver

#### Fields
- private CategoryLabels.ChartCategoryLabelOptions visibleLabels

#### Properties
- protected System.Action<ChartAndGraph.IInternalUse, bool> Assign { get; }
- public CategoryLabels.ChartCategoryLabelOptions VisibleLabels { get; set; }

#### Constructors
- public CategoryLabels()

#### Methods
- private void <get_Assign>b__6_0(ChartAndGraph.IInternalUse x, bool clear)

### private delegate GraphDataFiller.CategoryLoader
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public GraphDataFiller.CategoryLoader(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(GraphDataFiller.CategoryData data, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(GraphDataFiller.CategoryData data)

### public enum CategoryLabels.ChartCategoryLabelOptions
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- All = 0
- FirstOnly = 1

### public enum ChartLabelAlignment
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Base = 1
- Center = 2
- Top = 0

### public class ChartText
- Base: UnityEngine.MonoBehaviour

#### Constructors
- public ChartText()

#### Methods
- private void Start()
- private void Update()

### public enum GraphDataFiller.DataType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ArrayForEachElement = 1
- ObjectArray = 2
- VectorArray = 0

### public enum GraphDataFiller.DocumentFormat
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- JSON = 1
- XML = 0

### public class GraphDataFiller
- Base: UnityEngine.MonoBehaviour

#### Fields
- public GraphDataFiller.CategoryData[] Categories
- public ChartAndGraph.GraphChartBase CategoryPrefab
- public bool FillOnStart
- public GraphDataFiller.DocumentFormat Format
- public ChartAndGraph.GraphChartBase GraphObject
- private object[] mCategoryVisualStyle
- private System.Collections.Generic.Dictionary<GraphDataFiller.DataType, GraphDataFiller.CategoryLoader> mLoaders
- private ChartAndGraph.ChartParser mParser
- private static System.Collections.Generic.Dictionary<GraphDataFiller.VectorFormat, GraphDataFiller.VectorFormatData> mVectorFormats
- public string RemoteUrl

#### Constructors
- private static GraphDataFiller()
- public GraphDataFiller()

#### Methods
- public void ApplyData(string text)
- private UnityEngine.Networking.UnityWebRequest CreateRequest(UnityEngine.WWWForm postData)
- private static void CreateVectorFormats()
- private void EnsureCreateDataTypes()
- public void Fill()
- public void Fill(UnityEngine.WWWForm postData)
- private System.Collections.IEnumerator GetData(UnityEngine.WWWForm postData)
- private void LoadArrayForEachElement(GraphDataFiller.CategoryData data)
- private void LoadCategoryVisualStyle(ChartAndGraph.GraphChartBase graph)
- private void LoadObjectArray(GraphDataFiller.CategoryData data)
- private void LoadVectorArray(GraphDataFiller.CategoryData data)
- private double ParseItem(string item, string format)
- private void Start()
- private void Update()

### public class GraphDataVisualEditor
- Base: UnityEngine.MonoBehaviour

#### Constructors
- public GraphDataVisualEditor()

#### Methods
- private void Start()
- private void Update()

### public class GroupLabels
- Base: ItemLabelsBase
- Interfaces: ChartAndGraph.IInternalSettings, UnityEngine.ISerializationCallbackReceiver

#### Fields
- private ChartAndGraph.GroupLabelAlignment alignment

#### Properties
- public ChartAndGraph.GroupLabelAlignment Alignment { get; set; }
- protected System.Action<ChartAndGraph.IInternalUse, bool> Assign { get; }

#### Constructors
- public GroupLabels()

#### Methods
- private void <get_Assign>b__5_0(ChartAndGraph.IInternalUse x, bool clear)

### public class HoverText
- Base: UnityEngine.MonoBehaviour

#### Fields
- public int FontSize
- private int fractionDigits
- private ChartAndGraph.AnyChart mChart
- private System.Collections.Generic.List<UnityEngine.UI.Text> mItems
- private System.Collections.Generic.List<ChartAndGraph.CharItemEffectController> mRemoved
- public UnityEngine.Vector3 TextOffset
- public UnityEngine.UI.Text TextPrefab

#### Constructors
- public HoverText()

#### Methods
- private void GraphHover(ChartAndGraph.GraphChartBase.GraphEventArgs args)
- private void NonHover()
- private void PopText(string data, UnityEngine.Vector3 position, bool worldPositionStays)
- private void RemoveText(UnityEngine.UI.Text text)
- private System.Collections.IEnumerator SelectText(UnityEngine.UI.Text text)
- private void Start()
- private void Update()

### public class ItemLabelsBase
- Base: ChartAndGraph.ChartSettingItemBase
- Interfaces: ChartAndGraph.IInternalSettings, UnityEngine.ISerializationCallbackReceiver

#### Fields
- private float fontSharpness
- private int fontSize
- private ChartAndGraph.ChartOrientedSize location
- private float seperation
- private ChartAndGraph.TextFormatting textFormat
- private UnityEngine.MonoBehaviour textPrefab

#### Properties
- public float FontSharpness { get; set; }
- public int FontSize { get; set; }
- public ChartAndGraph.ChartOrientedSize Location { get; set; }
- public float Seperation { get; set; }
- public ChartAndGraph.TextFormatting TextFormat { get; set; }
- public UnityEngine.MonoBehaviour TextPrefab { get; set; }

#### Constructors
- public ItemLabelsBase()

#### Methods
- private void AddChildObjects()
- private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
- private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
- public virtual void ValidateProperties()

### private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData

#### Fields
- public byte[] FilePathsData
- public bool IsEditorOnly
- public int TotalFiles
- public int TotalTypes
- public byte[] TypesData

### public class TextController
- Base: UnityEngine.MonoBehaviour

#### Fields
- private float <GlobalRotation>k__BackingField
- public UnityEngine.Camera Camera
- private UnityEngine.GameObject mAddCanvasUnder
- private UnityEngine.Canvas mCanvas
- private float mInnerScale
- private bool mInvalidated
- private UnityEngine.Vector3[] mPlaneCorners
- private float mPrevScale
- private ChartAndGraph.AnyChart mPrivateParent
- private UnityEngine.RectTransform mRect
- private System.Collections.Generic.List<BillboardText> mText
- private bool OwnsCanvas
- public float PlaneDistance

#### Properties
- public float GlobalRotation { get; set; }
- internal ChartAndGraph.AnyChart mParent { get; set; }
- private UnityEngine.Canvas SafeCanvas { get; }
- internal System.Collections.Generic.List<BillboardText> Text { get; }

#### Constructors
- public TextController()

#### Methods
- public void AddText(BillboardText billboard)
- public void ApplyTextPosition()
- private UnityEngine.Camera AssignCamera(UnityEngine.Camera camera)
- private void CalculatePlane(UnityEngine.Camera cam, UnityEngine.RectTransform transform, out UnityEngine.Vector3 center, out UnityEngine.Vector3 normal)
- private void Canvas_willRenderCanvases()
- public void DestroyAll()
- private UnityEngine.Camera EnsureCamera()
- private void EnsureCanvas()
- private void LateUpdate()
- private void OnDestory()
- private void OnDestroy()
- private UnityEngine.Vector3 ProjectPointOnPlane(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint, UnityEngine.Vector3 point)
- internal void SetInnerScale(float scale)
- private void Start()
- private void Update()

### internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1

#### Constructors
- public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()

#### Methods
- private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()

### public enum GraphDataFiller.VectorFormat
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- SIZE_X_Y = 4
- SIZE_Y_X = 5
- X_Y = 0
- X_Y_GAP_SIZE = 6
- X_Y_SIZE = 2
- Y_X = 1
- Y_X_GAP_SIZE = 7
- Y_X_SIZE = 3

### private class GraphDataFiller.VectorFormatData

#### Fields
- public int Length
- public int Size
- public int X
- public int Y

#### Constructors
- public GraphDataFiller.VectorFormatData(int x, int y, int size, int length)

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6080

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8134

## Namespace: ChartAndGraph

### private class ChartAndGraph.GraphChart.<>c

#### Fields
- public static readonly ChartAndGraph.GraphChart.<>c <>9
- public static System.Func<ChartAndGraph.DoubleVector3, UnityEngine.Vector4> <>9__54_3

#### Constructors
- private static GraphChart.<>c()
- public GraphChart.<>c()

#### Methods
- internal UnityEngine.Vector4 <InternalGenerateChart>b__54_3(ChartAndGraph.DoubleVector3 x)

### private class ChartAndGraph.GraphData.<>c

#### Fields
- public static readonly ChartAndGraph.GraphData.<>c <>9
- public static System.Func<ChartAndGraph.BaseScrollableCategoryData, bool> <>9__29_0
- public static System.Func<ChartAndGraph.BaseScrollableCategoryData, int> <>9__29_1
- public static System.Func<ChartAndGraph.BaseScrollableCategoryData, int> <>9__56_0
- public static System.Func<ChartAndGraph.BaseScrollableCategoryData, string> <>9__56_1
- public static System.Func<ChartAndGraph.GraphData.SerializedCategory, int> <>9__71_0
- public static System.Func<System.Collections.Generic.KeyValuePair<string, ChartAndGraph.BaseScrollableCategoryData>, System.Collections.Generic.KeyValuePair<string, ChartAndGraph.GraphData.CategoryData>> <>9__71_1
- public static System.Func<ChartAndGraph.BaseScrollableCategoryData, ChartAndGraph.GraphData.CategoryData> <>9__80_0
- public static System.Func<ChartAndGraph.GraphData.CategoryData, int> <>9__80_1

#### Constructors
- private static GraphData.<>c()
- public GraphData.<>c()

#### Methods
- internal ChartAndGraph.GraphData.CategoryData <ChartAndGraph.IInternalGraphData.get_Categories>b__80_0(ChartAndGraph.BaseScrollableCategoryData x)
- internal int <ChartAndGraph.IInternalGraphData.get_Categories>b__80_1(ChartAndGraph.GraphData.CategoryData x)
- internal int <get_CategoryNames>b__56_0(ChartAndGraph.BaseScrollableCategoryData x)
- internal string <get_CategoryNames>b__56_1(ChartAndGraph.BaseScrollableCategoryData x)
- internal int <OnBeforeSerialize>b__71_0(ChartAndGraph.GraphData.SerializedCategory x)
- internal System.Collections.Generic.KeyValuePair<string, ChartAndGraph.GraphData.CategoryData> <OnBeforeSerialize>b__71_1(System.Collections.Generic.KeyValuePair<string, ChartAndGraph.BaseScrollableCategoryData> x)
- internal bool <StoreAllCategoriesinOrder>b__29_0(ChartAndGraph.BaseScrollableCategoryData x)
- internal int <StoreAllCategoriesinOrder>b__29_1(ChartAndGraph.BaseScrollableCategoryData x)

### private class ChartAndGraph.CanvasLines.LineSegement.<>c

#### Fields
- public static readonly ChartAndGraph.CanvasLines.LineSegement.<>c <>9
- public static System.Func<UnityEngine.Vector3, UnityEngine.Vector4> <>9__1_0

#### Constructors
- private static CanvasLines.LineSegement.<>c()
- public CanvasLines.LineSegement.<>c()

#### Methods
- internal UnityEngine.Vector4 <.ctor>b__1_0(UnityEngine.Vector3 x)

### private class ChartAndGraph.AbstractChartData.<>c__DisplayClass2_0

#### Fields
- public string group

#### Constructors
- public AbstractChartData.<>c__DisplayClass2_0()

#### Methods
- internal bool <RemoveSliderForGroup>b__0(ChartAndGraph.AbstractChartData.Slider x)

### private class ChartAndGraph.AxisBase.<>c__DisplayClass33_0

#### Fields
- public double parentSize
- public double range
- public double startValue

#### Constructors
- public AxisBase.<>c__DisplayClass33_0()

#### Methods
- internal double <DrawCustomDivisions>b__0(double x)

### private class ChartAndGraph.AxisBase.<>c__DisplayClass34_0

#### Fields
- public double parentSize
- public double range
- public double startValue

#### Constructors
- public AxisBase.<>c__DisplayClass34_0()

#### Methods
- internal double <DrawDivisions>b__0(double x)

### private class ChartAndGraph.GraphData.<>c__DisplayClass36_0

#### Fields
- public string category

#### Constructors
- public GraphData.<>c__DisplayClass36_0()

#### Methods
- internal bool <RemoveCategory>b__0(ChartAndGraph.BaseSlider x)

### private class ChartAndGraph.AbstractChartData.<>c__DisplayClass3_0

#### Fields
- public string category

#### Constructors
- public AbstractChartData.<>c__DisplayClass3_0()

#### Methods
- internal bool <RemoveSliderForCategory>b__0(ChartAndGraph.AbstractChartData.Slider x)

### private class ChartAndGraph.GraphData.<>c__DisplayClass41_0

#### Fields
- public string category

#### Constructors
- public GraphData.<>c__DisplayClass41_0()

#### Methods
- internal bool <ClearCategory>b__0(ChartAndGraph.BaseSlider x)

### private class ChartAndGraph.AbstractChartData.<>c__DisplayClass4_0

#### Fields
- public string category
- public string group

#### Constructors
- public AbstractChartData.<>c__DisplayClass4_0()

#### Methods
- internal bool <RemoveSlider>b__0(ChartAndGraph.AbstractChartData.Slider x)

### private class ChartAndGraph.GraphChart.<>c__DisplayClass54_0

#### Fields
- public ChartAndGraph.GraphChart <>4__this
- public ChartAndGraph.GraphChart.CategoryObject categoryObj
- public string catName

#### Constructors
- public GraphChart.<>c__DisplayClass54_0()

#### Methods
- internal void <InternalGenerateChart>b__0(int idx, int t, object d, UnityEngine.Vector2 pos)
- internal void <InternalGenerateChart>b__1(int idx, int t, object d, UnityEngine.Vector2 pos)
- internal void <InternalGenerateChart>b__2()

### private class ChartAndGraph.JsonParser.<GetAllChildObjects>d__12
- Interfaces: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Collections.Generic.KeyValuePair<string, object> <>2__current
- public object <>3__obj
- private GraphAndChartSimpleJSON.JSONNode.KeyEnumerator <>7__wrap2
- private int <>l__initialThreadId
- private GraphAndChartSimpleJSON.JSONNode <node>5__2
- private object obj

#### Properties
- private System.Collections.Generic.KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public JsonParser.<GetAllChildObjects>d__12(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class ChartAndGraph.XMLParser.<GetAllChildObjects>d__12
- Interfaces: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Collections.Generic.KeyValuePair<string, object> <>2__current
- public object <>3__obj
- private System.Collections.IEnumerator <>7__wrap1
- private int <>l__initialThreadId
- private object obj

#### Properties
- private System.Collections.Generic.KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public XMLParser.<GetAllChildObjects>d__12(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class ChartAndGraph.CanvasLines.<getDotVeritces>d__57
- Interfaces: System.Collections.Generic.IEnumerable<UnityEngine.UIVertex>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.UIVertex>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private UnityEngine.UIVertex <>2__current
- public ChartAndGraph.CanvasLines <>4__this
- private int <>l__initialThreadId
- private int <i>5__3
- private int <j>5__6
- private ChartAndGraph.CanvasLines.LineSegement <seg>5__4
- private int <total>5__5
- private UnityEngine.UIVertex <v2>5__7
- private UnityEngine.UIVertex <v3>5__8
- private UnityEngine.UIVertex <v4>5__9
- private float <z>5__2

#### Properties
- private UnityEngine.UIVertex System.Collections.Generic.IEnumerator<UnityEngine.UIVertex>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public CanvasLines.<getDotVeritces>d__57(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<UnityEngine.UIVertex> System.Collections.Generic.IEnumerable<UnityEngine.UIVertex>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class ChartAndGraph.CanvasLines.<getFillVeritces>d__59
- Interfaces: System.Collections.Generic.IEnumerable<UnityEngine.UIVertex>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.UIVertex>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private UnityEngine.UIVertex <>2__current
- public ChartAndGraph.CanvasLines <>4__this
- private int <>l__initialThreadId
- private int <i>5__3
- private int <j>5__6
- private ChartAndGraph.CanvasLines.LineSegement <seg>5__4
- private int <totalLines>5__5
- private UnityEngine.UIVertex <v2>5__7
- private UnityEngine.UIVertex <v3>5__8
- private UnityEngine.UIVertex <v4>5__9
- private UnityEngine.UIVertex <vCross>5__10
- private float <z>5__2

#### Properties
- private UnityEngine.UIVertex System.Collections.Generic.IEnumerator<UnityEngine.UIVertex>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public CanvasLines.<getFillVeritces>d__59(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<UnityEngine.UIVertex> System.Collections.Generic.IEnumerable<UnityEngine.UIVertex>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class ChartAndGraph.CanvasLines.<getLineVertices>d__60
- Interfaces: System.Collections.Generic.IEnumerable<UnityEngine.UIVertex>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.UIVertex>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private UnityEngine.UIVertex <>2__current
- public ChartAndGraph.CanvasLines <>4__this
- private int <>l__initialThreadId
- private UnityEngine.Vector3 <a1>5__18
- private UnityEngine.Vector3 <a2>5__19
- private float <halfThickness>5__2
- private int <i>5__4
- private int <j>5__11
- private ChartAndGraph.CanvasLines.Line <line>5__12
- private float <myZ>5__17
- private System.Nullable<ChartAndGraph.CanvasLines.Line> <peek>5__7
- private System.Nullable<ChartAndGraph.CanvasLines.Line> <prev>5__8
- private ChartAndGraph.CanvasLines.LineSegement <seg>5__5
- private float <tileUv>5__9
- private int <totalLines>5__6
- private float <totalUv>5__10
- private UnityEngine.UIVertex <v1>5__13
- private UnityEngine.UIVertex <v2>5__14
- private UnityEngine.UIVertex <v3>5__15
- private UnityEngine.UIVertex <v4>5__16
- private float <z>5__3

#### Properties
- private UnityEngine.UIVertex System.Collections.Generic.IEnumerator<UnityEngine.UIVertex>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public CanvasLines.<getLineVertices>d__60(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<UnityEngine.UIVertex> System.Collections.Generic.IEnumerable<UnityEngine.UIVertex>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class ChartAndGraph.CanvasLinesHover.<getVerices>d__3
- Interfaces: System.Collections.Generic.IEnumerable<UnityEngine.UIVertex>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.UIVertex>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private UnityEngine.UIVertex <>2__current
- public ChartAndGraph.CanvasLinesHover <>4__this
- private int <>l__initialThreadId
- private UnityEngine.UIVertex <v>5__2

#### Properties
- private UnityEngine.UIVertex System.Collections.Generic.IEnumerator<UnityEngine.UIVertex>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public CanvasLinesHover.<getVerices>d__3(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<UnityEngine.UIVertex> System.Collections.Generic.IEnumerable<UnityEngine.UIVertex>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class ChartAndGraph.AxisBase.DivisionEnumerable.<System-Collections-IEnumerable-GetEnumerator>d__7
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public ChartAndGraph.AxisBase.DivisionEnumerable <>4__this
- private double <current>5__3
- private double <startRange>5__2

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public AxisBase.DivisionEnumerable.<System-Collections-IEnumerable-GetEnumerator>d__7(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### public class ChartAndGraph.AbstractChartData

#### Fields
- protected System.Collections.Generic.List<ChartAndGraph.AbstractChartData.Slider> mSliders

#### Constructors
- protected AbstractChartData()

#### Methods
- private bool DoSlider(ChartAndGraph.AbstractChartData.Slider s)
- protected void RemoveSlider(string category, string group)
- protected void RemoveSliderForCategory(string category)
- protected void RemoveSliderForGroup(string group)
- protected abstract void SetValueInternal(string column, string row, double value)
- protected void UpdateSliders()

### public class ChartAndGraph.AlignedItemLabels
- Base: ItemLabelsBase
- Interfaces: ChartAndGraph.IInternalSettings, UnityEngine.ISerializationCallbackReceiver

#### Fields
- private ChartLabelAlignment alignment

#### Properties
- public ChartLabelAlignment Alignment { get; set; }

#### Constructors
- protected AlignedItemLabels()

### public class ChartAndGraph.AnyChart
- Base: UnityEngine.MonoBehaviour
- Interfaces: ChartAndGraph.IInternalUse, UnityEngine.ISerializationCallbackReceiver

#### Fields
- private bool <CanvasChanged>k__BackingField
- private bool <IsUnderCanvas>k__BackingField
- private System.Action ChartGenerated
- private System.Func<System.DateTime, string> customDateTimeFormat
- private System.Func<double, int, string> customNumberFormat
- protected bool hideHierarchy
- protected UnityEngine.GameObject HorizontalCustomDivisions
- protected UnityEngine.GameObject HorizontalCustomDivisionsSub
- protected UnityEngine.GameObject HorizontalMainDevisions
- protected UnityEngine.GameObject HorizontalSubDevisions
- private bool keepOrthoSize
- private bool maintainLabelSize
- private System.Collections.Generic.List<ChartAndGraph.Axis.IAxisGenerator> mAxis
- protected CategoryLabels mCategoryLabels
- protected UnityEngine.GameObject mFixPosition
- private bool mGenerateOnNextUpdate
- private bool mGenerating
- protected GroupLabels mGroupLabels
- protected ChartAndGraph.HorizontalAxis mHorizontalAxis
- private System.Collections.Generic.HashSet<double> mHorizontalCustomAxis
- private System.Collections.Generic.HashSet<double> mHorizontalCustomAxisSubDivision
- private System.Collections.Generic.Dictionary<double, string> mHorizontalValueToStringMap
- private System.Collections.Generic.HashSet<object> mHovered
- protected ChartAndGraph.ItemLabels mItemLabels
- private UnityEngine.Vector2 mLastSetSize
- protected UnityEngine.GameObject mPreviewObject
- private bool mRealtimeOnNextUpdate
- private TextController mTextController
- private System.Collections.Generic.Dictionary<ChartAndGraph.DoubleVector3, System.Collections.Generic.KeyValuePair<string, string>> mVectorToValueMap
- protected ChartAndGraph.VerticalAxis mVerticalAxis
- private System.Collections.Generic.HashSet<double> mVerticalCustomAxis
- private System.Collections.Generic.HashSet<double> mVerticalCustomAxisSubdivision
- private System.Collections.Generic.Dictionary<double, string> mVerticalValueToStringMap
- public UnityEngine.Events.UnityEvent OnRedraw
- private bool paperEffectText
- private static System.Collections.Generic.List<UnityEngine.GameObject> toMove
- protected UnityEngine.GameObject VerticalCustomDevisions
- protected UnityEngine.GameObject VerticalCustomDevisionsSub
- protected UnityEngine.GameObject VerticalMainDevisions
- protected UnityEngine.GameObject VerticalSubDevisions
- private float vRSpaceScale
- private bool vRSpaceText

#### Properties
- protected bool CanvasChanged { get; private set; }
- protected UnityEngine.Vector3 CanvasFitOffset { get; }
- private CategoryLabels ChartAndGraph.IInternalUse.CategoryLabels { get; set; }
- private GroupLabels ChartAndGraph.IInternalUse.GroupLabels { get; set; }
- private bool ChartAndGraph.IInternalUse.HideHierarchy { get; }
- private ChartAndGraph.HorizontalAxis ChartAndGraph.IInternalUse.HorizontalAxis { get; set; }
- private System.Collections.Generic.HashSet<double> ChartAndGraph.IInternalUse.HorizontalCustomAxis { get; }
- private System.Collections.Generic.HashSet<double> ChartAndGraph.IInternalUse.HorizontalCustomAxisSubDivision { get; }
- private ChartAndGraph.LegenedData ChartAndGraph.IInternalUse.InternalLegendInfo { get; }
- private bool ChartAndGraph.IInternalUse.InternalSupportsCategoryLables { get; }
- private bool ChartAndGraph.IInternalUse.InternalSupportsGroupLabels { get; }
- private bool ChartAndGraph.IInternalUse.InternalSupportsItemLabels { get; }
- private UnityEngine.Camera ChartAndGraph.IInternalUse.InternalTextCamera { get; }
- private TextController ChartAndGraph.IInternalUse.InternalTextController { get; }
- private float ChartAndGraph.IInternalUse.InternalTextIdleDistance { get; }
- private float ChartAndGraph.IInternalUse.InternalTotalDepth { get; }
- private float ChartAndGraph.IInternalUse.InternalTotalHeight { get; }
- private float ChartAndGraph.IInternalUse.InternalTotalWidth { get; }
- private ChartAndGraph.ItemLabels ChartAndGraph.IInternalUse.ItemLabels { get; set; }
- private ChartAndGraph.VerticalAxis ChartAndGraph.IInternalUse.VerticalAxis { get; set; }
- private System.Collections.Generic.HashSet<double> ChartAndGraph.IInternalUse.VerticalCustomAxis { get; }
- private System.Collections.Generic.HashSet<double> ChartAndGraph.IInternalUse.VerticalCustomAxisSubDivision { get; }
- public System.Func<System.DateTime, string> CustomDateTimeFormat { get; set; }
- public System.Func<double, int, string> CustomNumberFormat { get; set; }
- protected ChartAndGraph.IChartData DataLink { get; }
- protected ChartAndGraph.AnyChart.FitAlign FitAlignCanvas { get; }
- protected ChartAndGraph.AnyChart.FitType FitAspectCanvas { get; }
- protected float FitZRotationCanvas { get; }
- protected UnityEngine.GameObject FixPosition { get; }
- public System.Collections.Generic.Dictionary<double, string> HorizontalValueToStringMap { get; }
- protected bool Invalidating { get; }
- public bool IsCanvas { get; }
- protected bool IsUnderCanvas { get; private set; }
- public bool KeepOrthoSize { get; set; }
- protected ChartAndGraph.LegenedData LegendInfo { get; }
- public bool MaintainLabelSize { get; set; }
- protected ChartAndGraph.ChartMagin MarginLink { get; }
- public bool PaperEffectText { get; set; }
- protected bool ShouldFitCanvas { get; }
- public bool SupportRealtimeGeneration { get; }
- protected bool SupportsCategoryLabels { get; }
- protected bool SupportsGroupLables { get; }
- protected bool SupportsItemLabels { get; }
- protected UnityEngine.Camera TextCameraLink { get; }
- protected TextController TextController { get; private set; }
- protected float TextIdleDistanceLink { get; }
- public float TotalDepth { get; }
- protected float TotalDepthLink { get; }
- public float TotalHeight { get; }
- protected float TotalHeightLink { get; }
- public float TotalWidth { get; }
- protected float TotalWidthLink { get; }
- public System.Collections.Generic.Dictionary<ChartAndGraph.DoubleVector3, System.Collections.Generic.KeyValuePair<string, string>> VectorValueToStringMap { get; }
- public System.Collections.Generic.Dictionary<double, string> VerticalValueToStringMap { get; }
- public float VRSpaceScale { get; set; }
- public bool VRSpaceText { get; set; }

#### Events
- private event System.Action ChartAndGraph.IInternalUse.Generated
- private event System.Action ChartGenerated

#### Constructors
- protected AnyChart()
- private static AnyChart()

#### Methods
- public void AddHorizontalAxisDivision(double pos, bool subDivision = false)
- public void AddVerticalAxisDivision(double pos, bool subDivision = false)
- public void Awake()
- private void AxisChanged(object sender, System.EventArgs e)
- private void ChartAndGraph.IInternalUse.CallOnValidate()
- private bool ChartAndGraph.IInternalUse.InternalHasValues(ChartAndGraph.AxisBase axis)
- private void ChartAndGraph.IInternalUse.InternalItemHovered(object userData)
- private void ChartAndGraph.IInternalUse.InternalItemLeave(object userData)
- private void ChartAndGraph.IInternalUse.InternalItemSelected(object userData)
- private double ChartAndGraph.IInternalUse.InternalMaxValue(ChartAndGraph.AxisBase axis)
- private double ChartAndGraph.IInternalUse.InternalMinValue(ChartAndGraph.AxisBase axis)
- protected virtual void ClearChart()
- public void ClearHorizontalCustomDivisions()
- public void ClearVerticalCustomDivisions()
- private void CreateTextController()
- private void DoCanvas(bool start)
- protected void EnsureTextController()
- private void FitCanvas()
- protected void FixAxisLabels()
- protected void GenerateAxis(bool force)
- public void GenerateChart()
- public virtual void GenerateRealtime()
- protected virtual double GetScrollOffset(int axis)
- protected abstract bool HasValues(ChartAndGraph.AxisBase axis)
- public virtual void InternalGenerateChart()
- protected internal virtual ChartAndGraph.Axis.IAxisGenerator InternalUpdateAxis(ref UnityEngine.GameObject axisObject, ChartAndGraph.AxisBase axisBase, ChartAndGraph.ChartOrientation axisOrientation, int divType, bool forceRecreate, double scrollOffset)
- public virtual void Invalidate()
- protected virtual void InvalidateRealtime()
- protected void InvokeOnRedraw()
- private void Labels_OnDataChanged(object sender, System.EventArgs e)
- private void Labels_OnDataUpdate(object sender, System.EventArgs e)
- protected virtual void LateUpdate()
- protected abstract double MaxValue(ChartAndGraph.AxisBase axis)
- protected abstract double MinValue(ChartAndGraph.AxisBase axis)
- protected virtual void OnAfterDeserializeEvent()
- protected virtual void OnAxisValuesChanged()
- protected virtual void OnBeforeSerializeEvent()
- protected virtual void OnDisable()
- protected virtual void OnEnable()
- protected virtual void OnItemHoverted(object userData)
- protected virtual void OnItemLeave(object userData, string type)
- protected virtual void OnItemSelected(object userData)
- protected virtual void OnLabelSettingChanged()
- protected virtual void OnLabelSettingsSet()
- protected virtual void OnNonHoverted()
- protected virtual void OnPropertyUpdated()
- protected virtual void OnTransformParentChanged()
- protected virtual void OnValidate()
- protected void RaiseChartGenerated()
- public void RemoveHorizontalAxisDivision(double pos)
- public void RemoveVerticalAxisDivision(double pos)
- protected virtual void Start()
- private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
- private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
- protected virtual void Update()
- protected virtual void ValidateProperties()

### public struct ChartAndGraph.AutoFloat
- Interfaces: System.IEquatable<ChartAndGraph.AutoFloat>

#### Fields
- public bool Automatic
- public float Value

#### Constructors
- public AutoFloat(bool automatic, float value)

#### Methods
- public bool Equals(ChartAndGraph.AutoFloat autoFloat)
- public override bool Equals(object obj)
- public override int GetHashCode()
- public static bool op_Equality(ChartAndGraph.AutoFloat a, ChartAndGraph.AutoFloat b)
- public static bool op_Inequality(ChartAndGraph.AutoFloat a, ChartAndGraph.AutoFloat b)

### public class ChartAndGraph.AxisBase
- Base: ChartAndGraph.ChartSettingItemBase
- Interfaces: ChartAndGraph.IInternalSettings, UnityEngine.ISerializationCallbackReceiver

#### Fields
- private System.Func<double, int, string> customNumberFormatWorldbox
- private ChartAndGraph.AutoFloat depth
- private ChartAndGraph.AxisFormat format
- private ChartAndGraph.ChartMainDivisionInfo mainDivisions
- private System.Collections.Generic.Dictionary<double, string> mFormats
- private System.Collections.Generic.List<double> mTmpToRemove
- private bool SimpleView
- private ChartAndGraph.ChartSubDivisionInfo subDivisions
- private bool withEdges2

#### Properties
- public System.Func<double, int, string> CustomNumberFormatWorldbox { get; set; }
- public ChartAndGraph.AutoFloat Depth { get; set; }
- public ChartAndGraph.AxisFormat Format { get; set; }
- public ChartAndGraph.ChartMainDivisionInfo MainDivisions { get; }
- public ChartAndGraph.ChartDivisionInfo SubDivisions { get; }
- public bool WithEdges { get; set; }

#### Constructors
- public AxisBase()

#### Methods
- internal void AddCustomDivisionsToChartMesh(double scrollOffset, ChartAndGraph.AnyChart parent, UnityEngine.Transform parentTransform, ChartAndGraph.IChartMesh mesh, ChartAndGraph.ChartOrientation orientation, bool isSub)
- private void AddInnerItems()
- internal void AddMainDivisionToChartMesh(double scrollOffset, ChartAndGraph.AnyChart parent, UnityEngine.Transform parentTransform, ChartAndGraph.IChartMesh mesh, ChartAndGraph.ChartOrientation orientation)
- internal void AddSubdivisionToChartMesh(double scrollOffset, ChartAndGraph.AnyChart parent, UnityEngine.Transform parentTransform, ChartAndGraph.IChartMesh mesh, ChartAndGraph.ChartOrientation orientation)
- public void ClearFormats()
- private void DrawCustomDivisions(double scrollOffset, ChartAndGraph.AnyChart parent, UnityEngine.Transform parentTransform, ChartAndGraph.ChartDivisionInfo info, ChartAndGraph.IChartMesh mesh, int group, ChartAndGraph.ChartOrientation orientation, bool oppositeSide, bool subDivision = false)
- private void DrawDivisions(double scrollOffset, ChartAndGraph.AnyChart parent, UnityEngine.Transform parentTransform, ChartAndGraph.ChartDivisionInfo info, ChartAndGraph.IChartMesh mesh, int group, ChartAndGraph.ChartOrientation orientation, double gap, bool oppositeSide, double mainGap)
- private void GetDirectionVectors(ChartAndGraph.AnyChart parent, ChartAndGraph.ChartDivisionInfo info, ChartAndGraph.ChartOrientation orientation, float scrollOffset, bool oppositeSide, out ChartAndGraph.DoubleVector3 startPosition, out ChartAndGraph.DoubleVector3 lengthDirection, out ChartAndGraph.DoubleVector3 advanceDirection)
- private System.Nullable<double> GetMainGap(ChartAndGraph.AnyChart parent, double range)
- private void GetStartEnd(ChartAndGraph.AnyChart parent, ChartAndGraph.ChartOrientation orientation, float total, out float start, out float end)
- private void SetMeshUv(ChartAndGraph.IChartMesh mesh, float length, float offset)
- private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
- private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
- public void ValidateProperties()

### public class ChartAndGraph.AxisChart
- Base: ChartAndGraph.AnyChart
- Interfaces: ChartAndGraph.IInternalUse, UnityEngine.ISerializationCallbackReceiver

#### Constructors
- protected AxisChart()

### public enum ChartAndGraph.AxisFormat
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Date = 2
- DateTime = 3
- Number = 0
- Time = 1
- WorldBoxCustom = 4

### public class ChartAndGraph.BaseScrollableCategoryData

#### Fields
- public bool Enabled
- public System.Nullable<double> MaxRadius
- public System.Nullable<double> MaxX
- public System.Nullable<double> MaxY
- public System.Nullable<double> MinX
- public System.Nullable<double> MinY
- public string Name
- public int ViewOrder

#### Constructors
- public BaseScrollableCategoryData()

### public class ChartAndGraph.BaseSlider

#### Fields
- private double <Duration>k__BackingField
- private double <StartTime>k__BackingField

#### Properties
- public string Category { get; }
- public double Duration { get; set; }
- public ChartAndGraph.DoubleVector2 Max { get; }
- public ChartAndGraph.DoubleVector2 Min { get; }
- public int MinIndex { get; }
- public double StartTime { get; set; }

#### Constructors
- protected BaseSlider()

#### Methods
- public virtual bool Update()

### public class ChartAndGraph.BoxPathGenerator
- Base: ChartAndGraph.SmoothPathGenerator

#### Fields
- public float HeightRatio
- private System.Collections.Generic.List<int> mTmpTringle
- private System.Collections.Generic.List<UnityEngine.Vector2> mTmpUv
- private System.Collections.Generic.List<UnityEngine.Vector3> mVertices

#### Constructors
- public BoxPathGenerator()

#### Methods
- private void AddTringles(System.Collections.Generic.List<int> tringles, int from, int to)
- public override void Generator(UnityEngine.Vector3[] path, float thickness, bool closed)
- private int WriteBox(float thickness, UnityEngine.Quaternion rotation, UnityEngine.Vector3 center, float u)

### public class ChartAndGraph.CanvasAttribute
- Base: System.Attribute

#### Constructors
- public CanvasAttribute()

### internal class ChartAndGraph.CanvasChartMesh
- Base: ChartAndGraph.ChartMeshBase
- Interfaces: ChartAndGraph.IChartMesh

#### Fields
- private System.Collections.Generic.List<UnityEngine.UIVertex> mListWrapAround
- private bool mTextOnly
- private UnityEngine.UIVertex[] mTmpQuad
- private UnityEngine.UI.VertexHelper mVHWrapAround

#### Constructors
- public CanvasChartMesh(bool forText)
- public CanvasChartMesh(UnityEngine.UI.VertexHelper wrapAround)
- public CanvasChartMesh(System.Collections.Generic.List<UnityEngine.UIVertex> wrapAround)

#### Methods
- public override void AddQuad(UnityEngine.UIVertex vLeftTop, UnityEngine.UIVertex vRightTop, UnityEngine.UIVertex vLeftBottom, UnityEngine.UIVertex vRightBottom)
- public override BillboardText AddText(ChartAndGraph.AnyChart chart, UnityEngine.MonoBehaviour prefab, UnityEngine.Transform parentTransform, int fontSize, float fontScale, string text, float x, float y, float z, float angle, object userData)
- public override void AddXYRect(UnityEngine.Rect rect, int subMeshGroup, float depth)
- public override void AddXZRect(UnityEngine.Rect rect, int subMeshGroup, float yPosition)
- public override void AddYZRect(UnityEngine.Rect rect, int subMeshGroup, float xPosition)
- private UnityEngine.UIVertex FloorVertex(UnityEngine.UIVertex vertex)
- public void WrapAround(UnityEngine.UI.VertexHelper wrapAround)
- public void WrapAround(System.Collections.Generic.List<UnityEngine.UIVertex> wrapAround)

### public class ChartAndGraph.CanvasLines
- Base: ChartAndGraph.EventHandlingGraphic
- Interfaces: UnityEngine.UI.ICanvasElement, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier

#### Fields
- private System.Nullable<UnityEngine.Rect> <ClipRect>k__BackingField
- private bool <EnableOptimization>k__BackingField
- private float innerTile
- private UnityEngine.Material mCachedMaterial
- private UnityEngine.Rect mFillRect
- private bool mFillRender
- private float mFillZero
- private System.Collections.Generic.List<ChartAndGraph.CanvasLines.LineSegement> mLines
- private float mMaxX
- private float mMaxY
- private int mMinModifyIndex
- private float mMinX
- private float mMinY
- private bool mNegativeFill
- private UnityEngine.Material mOriginalMaterial
- private bool mPointRender
- private float mPointSize
- private System.Collections.Generic.List<UnityEngine.Vector3> mPositions
- private bool mStretchY
- private UnityEngine.UIVertex[] mTmpVerts
- private System.Collections.Generic.List<int> mTringles
- private System.Collections.Generic.List<UnityEngine.Vector2> mUvs
- private UnityEngine.Mesh mVHMesh
- public float Thickness

#### Properties
- public System.Nullable<UnityEngine.Rect> ClipRect { get; set; }
- public bool EnableOptimization { get; set; }
- public UnityEngine.Material material { get; set; }
- protected UnityEngine.Vector2 Max { get; }
- protected UnityEngine.Vector2 Min { get; }
- protected float MouseInThreshold { get; }
- public float Tiling { get; set; }

#### Constructors
- public CanvasLines()

#### Methods
- protected override void Awake()
- private void FindBoundingValues()
- private System.Collections.Generic.IEnumerable<UnityEngine.UIVertex> getDotVeritces()
- private System.Collections.Generic.IEnumerable<UnityEngine.UIVertex> getFillVeritces()
- private System.Collections.Generic.IEnumerable<UnityEngine.UIVertex> getLineVertices()
- private void GetSide(UnityEngine.Vector3 point, UnityEngine.Vector3 dir, UnityEngine.Vector3 normal, float dist, float size, float z, out UnityEngine.Vector3 p1, out UnityEngine.Vector3 p2)
- private System.Collections.Generic.IEnumerable<UnityEngine.UIVertex> getVerices()
- public void MakeFillRender(UnityEngine.Rect fillRect, float fillZero, bool stretchY, bool negative)
- public void MakePointRender(float pointSize)
- internal void ModifyLines(int minModifyIndex, System.Collections.Generic.List<UnityEngine.Vector4> lines)
- protected override void OnDestroy()
- protected override void OnDisable()
- protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
- protected override void Pick(UnityEngine.Vector3 mouse, out int pickedIndex, out int pickedType, out object selectionData)
- private void PickDot(UnityEngine.Vector3 mouse, out int segment, out int point, out object selectionData)
- private void PickLine(UnityEngine.Vector3 mouse, out int segment, out int line, out object selectionData)
- private void ProcesssPoint(ref UnityEngine.Vector4 point, ref float halfSize)
- public void SetAllowMouse(bool pVal)
- public void SetFillZero(float zero)
- internal void SetLines(System.Collections.Generic.List<ChartAndGraph.CanvasLines.LineSegement> lines)
- protected override void SetUpHoverObject(ChartAndGraph.ChartItemEffect hover, int index, int type, object data)
- private UnityEngine.Vector2 TransformUv(UnityEngine.Vector2 uv)
- private void TrimItem(float x1, float y1, float x2, float y2, bool xAxis, bool oposite, ref UnityEngine.Vector2 from, ref UnityEngine.Vector2 to)
- private void TrimLine(UnityEngine.Rect r, ref UnityEngine.Vector2 from, ref UnityEngine.Vector2 to)
- protected override void Update()
- protected override void UpdateGeometry()
- protected override void UpdateMaterial()
- private void WriteTo<T>(System.Collections.Generic.List<T> list, int index, T val)

### public class ChartAndGraph.CanvasLinesHover
- Base: UnityEngine.UI.MaskableGraphic
- Interfaces: UnityEngine.UI.ICanvasElement, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier

#### Fields
- private float mHalfThickness
- private UnityEngine.UIVertex[] mTmpVerts

#### Constructors
- public CanvasLinesHover()

#### Methods
- private System.Collections.Generic.IEnumerable<UnityEngine.UIVertex> getVerices()
- public void Init(float thickness)
- protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)

### public class ChartAndGraph.GraphData.CategoryData
- Base: ChartAndGraph.BaseScrollableCategoryData

#### Fields
- public bool AllowNonFunctions
- public double CurveAnimationCurrentTime
- private double CurveAnimationFactor
- public double CurveAnimationTotalTime
- public System.Collections.Generic.List<ChartAndGraph.DoubleVector3> Data
- public double Depth
- public UnityEngine.GameObject DotPrefab
- public UnityEngine.Material FillMaterial
- public ChartAndGraph.FillPathGenerator FillPrefab
- public UnityEngine.Vector2[] initialData
- public bool IsBezierCurve
- public ChartAndGraph.ChartItemEffect LineHoverPrefab
- public UnityEngine.Material LineMaterial
- public ChartAndGraph.PathGenerator LinePrefab
- public double LineThickness
- public ChartAndGraph.MaterialTiling LineTiling
- public bool MaskPoints
- private static System.Collections.Generic.List<ChartAndGraph.DoubleVector3> mEmpty
- public System.Collections.Generic.List<ChartAndGraph.DoubleVector3> mTmpCurveData
- public ChartAndGraph.ChartItemEffect PointHoverPrefab
- public UnityEngine.Material PointMaterial
- public double PointSize
- public bool Regenerate
- public int SegmentsPerCurve
- public bool StetchFill

#### Constructors
- public GraphData.CategoryData()
- private static GraphData.CategoryData()

#### Methods
- public void AddInnerCurve(ChartAndGraph.DoubleVector3 p1, ChartAndGraph.DoubleVector3 c1, ChartAndGraph.DoubleVector3 c2, ChartAndGraph.DoubleVector3 p2, double factor)
- public System.Collections.Generic.List<ChartAndGraph.DoubleVector3> getPoints()
- public void Restore(object store)
- public object Store()
- public bool UpdateCurveAnimation()

### private class ChartAndGraph.GraphChart.CategoryObject

#### Fields
- public System.Collections.Generic.Dictionary<int, System.ValueTuple<ChartAndGraph.DoubleVector3, string>> mCahced
- public ChartAndGraph.CanvasLines mDots
- public ChartAndGraph.CanvasLines mFill
- public ChartAndGraph.CanvasChartMesh mItemLabels
- public ChartAndGraph.CanvasLines mLines

#### Constructors
- public GraphChart.CategoryObject()

### public class ChartAndGraph.CharItemEffectController
- Base: UnityEngine.MonoBehaviour

#### Fields
- private bool <InitialScale>k__BackingField
- private bool <WorkOnParent>k__BackingField
- private System.Collections.Generic.List<ChartAndGraph.ChartItemEffect> mEffects
- private UnityEngine.Vector3 mInitialScale
- private UnityEngine.Transform mParent

#### Properties
- internal bool InitialScale { get; set; }
- protected UnityEngine.Transform Parent { get; }
- internal bool WorkOnParent { get; set; }

#### Constructors
- public CharItemEffectController()

#### Methods
- private void OnTransformParentChanged()
- public void Register(ChartAndGraph.ChartItemEffect effect)
- private void Start()
- public void Unregister(ChartAndGraph.ChartItemEffect effect)
- private void Update()

### internal class ChartAndGraph.ChartAdancedSettings

#### Fields
- public int AxisFractionDigits
- private static string[] FractionDigits
- private static ChartAndGraph.ChartAdancedSettings mInstance
- public int ValueFractionDigits

#### Properties
- public static ChartAndGraph.ChartAdancedSettings Instance { get; }

#### Constructors
- public ChartAdancedSettings()
- private static ChartAdancedSettings()

#### Methods
- public string FormatFractionDigits(int digits, double val, System.Func<double, int, string> format = null)
- private string getFormat(int value)
- private string InnerFormat(string format, double val)

### public class ChartAndGraph.ChartCommon

#### Fields
- private static System.Collections.Generic.IEqualityComparer<double> <DefaultDoubleComparer>k__BackingField
- private static System.Collections.Generic.IEqualityComparer<ChartAndGraph.DoubleVector3> <DefaultDoubleVector3Comparer>k__BackingField
- private static System.Collections.Generic.IEqualityComparer<int> <DefaultIntComparer>k__BackingField
- private static UnityEngine.Material mDefaultMaterial

#### Properties
- public static System.Collections.Generic.IEqualityComparer<double> DefaultDoubleComparer { get; private set; }
- public static System.Collections.Generic.IEqualityComparer<ChartAndGraph.DoubleVector3> DefaultDoubleVector3Comparer { get; private set; }
- public static System.Collections.Generic.IEqualityComparer<int> DefaultIntComparer { get; private set; }
- internal static UnityEngine.Material DefaultMaterial { get; }
- internal static bool IsInEditMode { get; }

#### Constructors
- private static ChartCommon()
- public ChartCommon()

#### Methods
- internal static double Clamp(double val)
- internal static void CleanMesh(UnityEngine.Mesh newMesh, ref UnityEngine.Mesh cleanMesh)
- internal static BillboardText CreateBillboardText(BillboardText item, UnityEngine.MonoBehaviour prefab, UnityEngine.Transform parentTransform, string text, float x, float y, float z, float angle, UnityEngine.Transform relativeFrom, bool hideHirarechy, int fontSize, float sharpness)
- internal static UnityEngine.GameObject CreateCanvasChartItem()
- internal static UnityEngine.GameObject CreateChartItem()
- internal static UnityEngine.UIVertex CreateVertex(UnityEngine.Vector3 pos, UnityEngine.Vector2 uv)
- internal static UnityEngine.UIVertex CreateVertex(UnityEngine.Vector3 pos, UnityEngine.Vector2 uv, float z)
- private static float CrossProduct(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c)
- internal static void DoTextSign(UnityEngine.MonoBehaviour Text, double sign)
- private static float DotProduct(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c)
- internal static T EnsureComponent<T>(UnityEngine.GameObject obj)
- internal static void FixBillboardText(ItemLabelsBase labels, BillboardText text)
- internal static UnityEngine.Rect FixRect(UnityEngine.Rect r)
- internal static UnityEngine.Vector2 FromPolar(float angleDeg, float radius)
- internal static UnityEngine.Vector2 FromPolarRadians(float angleDeg, float radius)
- internal static float GetAutoDepth(ChartAndGraph.AnyChart parent, ChartAndGraph.ChartOrientation orientation, ChartAndGraph.ChartDivisionInfo info)
- internal static float GetAutoLength(ChartAndGraph.AnyChart parent, ChartAndGraph.ChartOrientation orientation)
- internal static float GetAutoLength(ChartAndGraph.AnyChart parent, ChartAndGraph.ChartOrientation orientation, ChartAndGraph.ChartDivisionInfo info)
- internal static string GetText(UnityEngine.GameObject obj)
- internal static float GetTiling(ChartAndGraph.MaterialTiling tiling)
- internal static void HideObject(UnityEngine.GameObject obj, bool hideMode)
- internal static void HideObjectEditor(UnityEngine.GameObject obj, bool hideMode)
- internal static ChartAndGraph.DoubleVector4 interpolateInRect(UnityEngine.Rect rect, ChartAndGraph.DoubleVector3 point)
- internal static double interpolateInRectX(UnityEngine.Rect rect, double x)
- internal static double interpolateInRectY(UnityEngine.Rect rect, double y)
- internal static UnityEngine.Vector3 LineCrossing(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, float horizontal)
- internal static void MakeMaskable(UnityEngine.GameObject obj, bool masksable)
- internal static double Max(System.Nullable<double> x, double y)
- internal static double Min(System.Nullable<double> x, double y)
- internal static double normalizeInRange(double value, double min, double size)
- internal static double normalizeInRangeX(double value, ChartAndGraph.DoubleVector3 min, ChartAndGraph.DoubleVector3 size)
- internal static double normalizeInRangeY(double value, ChartAndGraph.DoubleVector3 min, ChartAndGraph.DoubleVector3 size)
- public static UnityEngine.Vector2 Perpendicular(UnityEngine.Vector2 v)
- internal static UnityEngine.Rect RectFromCenter(float centerX, float sizeX, float top, float bottom)
- internal static bool SafeAssignMaterial(UnityEngine.Renderer renderer, UnityEngine.Material material, UnityEngine.Material defualt)
- public static void SafeDestroy(UnityEngine.Object obj)
- internal static bool SegmentIntersection(UnityEngine.Vector2 a1, UnityEngine.Vector2 a2, UnityEngine.Vector2 b1, UnityEngine.Vector2 b2, out UnityEngine.Vector2 intersection)
- internal static float SegmentPointSqrDistance(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 point)
- internal static bool SetTextParams(UnityEngine.GameObject obj, string text, int fontSize, float sharpness)
- internal static float SmoothLerp(float from, float to, float factor)
- internal static BillboardText UpdateBillboardText(BillboardText billboardText, UnityEngine.Transform parentTransform, string text, float x, float y, float z, float angle, UnityEngine.Transform relativeFrom, bool hideHirarechy, bool yMirror)
- internal static void UpdateTextParams(UnityEngine.GameObject obj, string text)

### public class ChartAndGraph.ChartDataSourceBaseCollection<T>
- Interfaces: System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable

#### Fields
- private System.Action<T> ItemRemoved
- private System.Action<string, int, string, int> ItemsReplaced
- private System.Collections.Generic.List<T> mItems
- private System.Collections.Generic.Dictionary<string, T> mNameToItem
- private System.Action<string, ChartAndGraph.DataSource.IDataItem> NameChanged
- private System.EventHandler OrderChanged

#### Properties
- public int Count { get; }
- public bool IsReadOnly { get; }
- public T Item { get; }
- public T Item { get; }
- protected string ItemTypeName { get; }

#### Events
- public event System.Action<T> ItemRemoved
- public event System.Action<string, int, string, int> ItemsReplaced
- public event System.Action<string, ChartAndGraph.DataSource.IDataItem> NameChanged
- public event System.EventHandler OrderChanged

#### Constructors
- protected ChartDataSourceBaseCollection<T>()

#### Methods
- public void Add(T item)
- public void Clear()
- public bool Contains(T item)
- public void CopyTo(T[] array, int arrayIndex)
- public System.Collections.Generic.IEnumerator<T> GetEnumerator()
- public void Insert(int index, T item)
- public void Move(string name, int newPosition)
- private void NameChangedHandler(string prevName, ChartAndGraph.DataSource.IDataItem item)
- public bool Remove(T item)
- public void SwitchPositions(string first, string second)
- public void SwitchPositions(int first, int second)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- public bool TryGetIndexByName(string name, out int result)

### public class ChartAndGraph.ChartDateUtility

#### Fields
- private static System.DateTime Epoch

#### Constructors
- public ChartDateUtility()
- private static ChartDateUtility()

#### Methods
- public static string DateToDateString(System.DateTime dateTime)
- public static string DateToDateTimeString(System.DateTime dateTime, System.Func<System.DateTime, string> customFormat)
- public static string DateToTimeString(System.DateTime dateTime)
- public static double DateToValue(System.DateTime dateTime)
- public static double TimeSpanToValue(System.TimeSpan span)
- public static System.DateTime ValueToDate(double value)

### public enum ChartAndGraph.ChartDivisionAligment
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Opposite = 2
- Standard = 1

### public class ChartAndGraph.ChartDivisionInfo
- Interfaces: ChartAndGraph.IInternalSettings

#### Fields
- private ChartAndGraph.ChartDivisionAligment alignment
- private float fontSharpness
- private int fontSize
- private int fractionDigits
- private ChartAndGraph.AutoFloat markBackLength
- private ChartAndGraph.AutoFloat markDepth
- private ChartAndGraph.AutoFloat markLength
- private float markThickness
- private UnityEngine.Material material
- private ChartAndGraph.MaterialTiling materialTiling
- protected ChartAndGraph.ChartDivisionInfo.DivisionMessure messure
- private System.EventHandler OnDataChanged
- private System.EventHandler OnDataUpdate
- private float textDepth
- private UnityEngine.MonoBehaviour textPrefab
- private string textPrefix
- private float textSeperation
- private string textSuffix
- private int total
- protected float unitsPerDivision

#### Properties
- public ChartAndGraph.ChartDivisionAligment Alignment { get; set; }
- public float FontSharpness { get; set; }
- public int FontSize { get; set; }
- public int FractionDigits { get; set; }
- public ChartAndGraph.AutoFloat MarkBackLength { get; set; }
- public ChartAndGraph.AutoFloat MarkDepth { get; set; }
- public ChartAndGraph.AutoFloat MarkLength { get; set; }
- public float MarkThickness { get; set; }
- public UnityEngine.Material Material { get; set; }
- public ChartAndGraph.MaterialTiling MaterialTiling { get; set; }
- public float TextDepth { get; set; }
- public UnityEngine.MonoBehaviour TextPrefab { get; set; }
- public string TextPrefix { get; set; }
- public float TextSeperation { get; set; }
- public string TextSuffix { get; set; }
- public int Total { get; set; }

#### Events
- private event System.EventHandler ChartAndGraph.IInternalSettings.InternalOnDataChanged
- private event System.EventHandler ChartAndGraph.IInternalSettings.InternalOnDataUpdate
- private event System.EventHandler OnDataChanged
- private event System.EventHandler OnDataUpdate

#### Constructors
- public ChartDivisionInfo()

#### Methods
- protected virtual void RaiseOnChanged()
- public void ValidateProperites()
- protected virtual float ValidateTotal(float total)

### public class ChartAndGraph.ChartDynamicMaterial

#### Fields
- public UnityEngine.Color Hover
- public UnityEngine.Material Normal
- public UnityEngine.Color Selected

#### Constructors
- public ChartDynamicMaterial()
- public ChartDynamicMaterial(UnityEngine.Material normal)
- public ChartDynamicMaterial(UnityEngine.Material normal, UnityEngine.Color hover, UnityEngine.Color selected)

### public class ChartAndGraph.ChartFillerEditorAttribute
- Base: System.Attribute

#### Fields
- public GraphDataFiller.DataType ShowForType

#### Constructors
- public ChartFillerEditorAttribute(GraphDataFiller.DataType type)

### public class ChartAndGraph.ChartItem
- Base: UnityEngine.MonoBehaviour

#### Fields
- private object <TagData>k__BackingField

#### Properties
- public object TagData { get; set; }

#### Constructors
- public ChartItem()

### public class ChartAndGraph.ChartItemEffect
- Base: UnityEngine.MonoBehaviour

#### Fields
- private object <ItemData>k__BackingField
- private int <ItemIndex>k__BackingField
- private int <ItemType>k__BackingField
- private System.Action<ChartAndGraph.ChartItemEffect> Deactivate
- private ChartAndGraph.CharItemEffectController mController

#### Properties
- protected ChartAndGraph.CharItemEffectController Controller { get; }
- internal object ItemData { get; set; }
- internal int ItemIndex { get; set; }
- internal int ItemType { get; set; }
- internal UnityEngine.Quaternion Rotation { get; }
- internal UnityEngine.Vector3 ScaleMultiplier { get; }
- internal UnityEngine.Vector3 Translation { get; }

#### Events
- public event System.Action<ChartAndGraph.ChartItemEffect> Deactivate

#### Constructors
- protected ChartItemEffect()

#### Methods
- protected virtual void Destroy()
- protected virtual void OnDisable()
- protected virtual void OnEnable()
- protected void RaiseDeactivated()
- private void Register()
- protected virtual void Start()
- public abstract void TriggerIn(bool deactivateOnEnd)
- public abstract void TriggerOut(bool deactivateOnEnd)
- private void Unregister()

### public class ChartAndGraph.ChartItemEvents
- Base: UnityEngine.MonoBehaviour
- Interfaces: UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, ChartAndGraph.InternalItemEvents

#### Fields
- private bool mMouseDown
- private bool mMouseOver
- private ChartAndGraph.IInternalUse mParent
- private object mUserData
- public ChartAndGraph.ChartItemEvents.Event OnMouseHover
- public ChartAndGraph.ChartItemEvents.Event OnMouseLeave
- public ChartAndGraph.ChartItemEvents.Event OnSelected

#### Properties
- private ChartAndGraph.IInternalUse ChartAndGraph.InternalItemEvents.Parent { get; set; }
- private object ChartAndGraph.InternalItemEvents.UserData { get; set; }

#### Constructors
- public ChartItemEvents()

#### Methods
- private void OnMouseDown()
- private void OnMouseEnter()
- private void OnMouseExit()
- private void OnMouseUp()
- public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
- public void Select(bool selected)
- private void Start()

### internal class ChartAndGraph.ChartItemGrowEffect
- Base: ChartAndGraph.ChartItemEffect

#### Fields
- public UnityEngine.AnimationCurve GrowEaseFunction
- public float GrowMultiplier
- private static const int GrowOp
- private static const int GrowShrinkOp
- public bool HorizontalOnly
- private bool mDeactivateOnEnd
- private float mScaleMultiplier
- private float mStartTime
- private float mStartValue
- private static const int NoOp
- private int Operation
- public UnityEngine.AnimationCurve ShrinkEaseFunction
- private static const int ShrinkOp
- public float TimeScale
- public bool VerticalOnly

#### Properties
- internal UnityEngine.Quaternion Rotation { get; }
- internal UnityEngine.Vector3 ScaleMultiplier { get; }
- internal UnityEngine.Vector3 Translation { get; }

#### Constructors
- public ChartItemGrowEffect()

#### Methods
- public bool CheckAnimationEnded(float time, UnityEngine.AnimationCurve curve)
- private void FixEaseFunction(UnityEngine.AnimationCurve curve)
- public void Grow()
- public void GrowAndShrink()
- public void Shrink()
- public override void TriggerIn(bool deactivateOnEnd)
- public override void TriggerOut(bool deactivateOnEnd)
- private void Update()

### public class ChartAndGraph.ChartItemLerpEffect
- Base: ChartAndGraph.ChartItemEffect

#### Fields
- public UnityEngine.AnimationCurve GrowEaseFunction
- private static const int GrowOp
- private static const int GrowShrinkOp
- private bool mDeactivateOnEnd
- private float mStartTime
- private float mStartValue
- private static const int NoOp
- private int Operation
- public UnityEngine.AnimationCurve ShrinkEaseFunction
- private static const int ShrinkOp
- public float TimeScale

#### Constructors
- protected ChartItemLerpEffect()

#### Methods
- protected abstract void ApplyLerp(float value)
- public bool CheckAnimationEnded(float time, UnityEngine.AnimationCurve curve)
- private void FixEaseFunction(UnityEngine.AnimationCurve curve)
- protected abstract float GetStartValue()
- public void Grow()
- public void GrowAndShrink()
- public void Shrink()
- protected override void Start()
- public override void TriggerIn(bool deactivateOnEnd)
- public override void TriggerOut(bool deactivateOnEnd)
- private void Update()

### internal class ChartAndGraph.ChartItemMaterialLerpEffect
- Base: UnityEngine.MonoBehaviour

#### Fields
- public float LerpTime

#### Constructors
- public ChartItemMaterialLerpEffect()

### internal class ChartAndGraph.ChartItemNoDelete
- Base: ChartAndGraph.ChartItem

#### Constructors
- public ChartItemNoDelete()

### internal class ChartAndGraph.ChartItemTextBlend
- Base: ChartAndGraph.ChartItemLerpEffect

#### Fields
- private System.Collections.Generic.Dictionary<UnityEngine.Object, float> mInitialValues
- private UnityEngine.CanvasRenderer mRenderer
- private UnityEngine.UI.Shadow[] mShadows
- private UnityEngine.UI.Text mText

#### Properties
- internal UnityEngine.Quaternion Rotation { get; }
- internal UnityEngine.Vector3 ScaleMultiplier { get; }
- internal UnityEngine.Vector3 Translation { get; }

#### Constructors
- public ChartItemTextBlend()

#### Methods
- protected override void ApplyLerp(float value)
- private UnityEngine.CanvasRenderer EnsureRenderer()
- protected override float GetStartValue()
- protected override void Start()

### public struct ChartAndGraph.ChartMagin

#### Fields
- private float bottom
- private float left
- private float right
- private float top

#### Properties
- public float Bottom { get; }
- public float Left { get; }
- public float Right { get; }
- public float Top { get; }

#### Constructors
- public ChartMagin(float leftMargin, float topMargin, float rightMargin, float bottomMargin)

### public class ChartAndGraph.ChartMainDivisionInfo
- Base: ChartAndGraph.ChartDivisionInfo
- Interfaces: ChartAndGraph.IInternalSettings

#### Properties
- public ChartAndGraph.ChartDivisionInfo.DivisionMessure Messure { get; set; }
- public float UnitsPerDivision { get; set; }

#### Constructors
- public ChartMainDivisionInfo()

### public class ChartAndGraph.ChartMaterialController
- Base: UnityEngine.MonoBehaviour
- Interfaces: UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler

#### Fields
- private System.Nullable<int> BaseColorId
- private System.Nullable<int> CombineId
- public bool HandleEvents
- private float mAccumilatedTime
- private ChartAndGraph.ChartDynamicMaterial materials
- private UnityEngine.UI.Graphic mCanvasRenderer
- internal ChartAndGraph.ChartItemMaterialLerpEffect mLerpEffect
- private UnityEngine.Color mLerpFrom
- private bool mLerping
- private UnityEngine.Color mLerpTo
- private UnityEngine.Material mMat
- private bool mMouseDown
- private bool mMouseOver
- private UnityEngine.Renderer mRenderer
- public bool Selected
- private static bool WarnedNull

#### Properties
- internal ChartAndGraph.ChartDynamicMaterial Materials { get; set; }

#### Constructors
- public ChartMaterialController()

#### Methods
- private int BaseColor()
- private int Combine()
- private UnityEngine.Color GetColorCombine(UnityEngine.Material m)
- private void OnDestroy()
- private void OnMouseDown()
- private void OnMouseEnter()
- private void OnMouseExit()
- private void OnMouseUp()
- public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
- public void Refresh()
- private void SetColor(UnityEngine.Color c)
- private void SetColorCombine(UnityEngine.Material m, UnityEngine.Color c)
- private void SetMaterial(UnityEngine.Material m, UnityEngine.Material fallback)
- private void SetRendererColor(UnityEngine.Color c)
- private void Start()
- public void TriggerOff()
- public void TriggerOn()
- private void Update()
- private void WarnNullItem()

### internal class ChartAndGraph.ChartMeshBase
- Interfaces: ChartAndGraph.IChartMesh

#### Fields
- private float <Length>k__BackingField
- private float <Offset>k__BackingField
- private ChartAndGraph.ChartOrientation <Orientation>k__BackingField
- private bool <RecycleText>k__BackingField
- private float innerTile
- private System.Collections.Generic.List<BillboardText> mCached
- private System.Collections.Generic.List<BillboardText> mCurrentTexts
- private System.Collections.Generic.Dictionary<string, BillboardText> mRecycled
- private System.Collections.Generic.List<BillboardText> mText
- private UnityEngine.Vector2[] mTmpUv
- private UnityEngine.Vector2[][] mUvs

#### Properties
- public System.Collections.Generic.List<BillboardText> CurrentTextObjects { get; }
- public float Length { get; set; }
- public float Offset { get; set; }
- public ChartAndGraph.ChartOrientation Orientation { get; set; }
- public bool RecycleText { get; set; }
- public System.Collections.Generic.List<BillboardText> TextObjects { get; }
- public float Tile { get; set; }

#### Constructors
- public ChartMeshBase()

#### Methods
- public abstract void AddQuad(UnityEngine.UIVertex vLeftTop, UnityEngine.UIVertex vRightTop, UnityEngine.UIVertex vLeftBottom, UnityEngine.UIVertex vRightBottom)
- public virtual BillboardText AddText(ChartAndGraph.AnyChart chart, UnityEngine.MonoBehaviour prefab, UnityEngine.Transform parentTransform, int fontSize, float fontSharpness, string text, float x, float y, float z, float angle, object userData)
- public abstract void AddXYRect(UnityEngine.Rect rect, int subMeshGroup, float depth)
- public abstract void AddXZRect(UnityEngine.Rect rect, int subMeshGroup, float yPosition)
- public abstract void AddYZRect(UnityEngine.Rect rect, int subMeshGroup, float xPosition)
- public virtual void Clear()
- private void DestoryBillboard(BillboardText t)
- public void DestoryRecycled()
- protected UnityEngine.Vector2[] GetUvs(UnityEngine.Rect rect)
- protected UnityEngine.Vector2[] GetUvs(UnityEngine.Rect rect, ChartAndGraph.ChartOrientation orientaion)

### public enum ChartAndGraph.ChartOrientation
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Horizontal = 0
- Vertical = 1

### public class ChartAndGraph.ChartOrientedSize

#### Fields
- public float Breadth
- public float Depth

#### Constructors
- public ChartOrientedSize()
- public ChartOrientedSize(float breadth)
- public ChartOrientedSize(float breadth, float depth)

#### Methods
- public override bool Equals(object obj)
- public override int GetHashCode()

### public class ChartAndGraph.ChartParser

#### Constructors
- protected ChartParser()

#### Methods
- public abstract System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> GetAllChildObjects(object obj)
- public abstract int GetArraySize(object arr)
- public abstract object GetChildObject(object obj, string name)
- public abstract string GetChildObjectValue(object obj, string name)
- public abstract string GetItem(object arr, int item)
- public abstract object GetItemObject(object arr, int item)
- public abstract object GetObject(string name)
- public abstract string ObjectValue(object obj)
- public abstract bool SetPathRelativeTo(string pathObject)

### public class ChartAndGraph.ChartSettingItemBase
- Base: UnityEngine.MonoBehaviour
- Interfaces: ChartAndGraph.IInternalSettings

#### Fields
- private ChartAndGraph.AnyChart mChart
- private System.EventHandler OnDataChanged
- private System.EventHandler OnDataUpdate

#### Properties
- protected System.Action<ChartAndGraph.IInternalUse, bool> Assign { get; }
- private ChartAndGraph.AnyChart SafeChart { get; }

#### Events
- private event System.EventHandler ChartAndGraph.IInternalSettings.InternalOnDataChanged
- private event System.EventHandler ChartAndGraph.IInternalSettings.InternalOnDataUpdate
- private event System.EventHandler OnDataChanged
- private event System.EventHandler OnDataUpdate

#### Constructors
- protected ChartSettingItemBase()

#### Methods
- protected void AddInnerItem(ChartAndGraph.IInternalSettings item)
- private void Item_InternalOnDataChanged(object sender, System.EventArgs e)
- private void Item_InternalOnDataUpdate(object sender, System.EventArgs e)
- protected virtual void OnDestroy()
- protected virtual void OnDisable()
- protected virtual void OnEnable()
- protected virtual void OnValidate()
- protected virtual void RaiseOnChanged()
- protected virtual void RaiseOnUpdate()
- private void SafeAssign(bool clear)
- protected virtual void Start()

### internal class ChartAndGraph.ChartSparseDataSource
- Base: ChartAndGraph.DataSource.ChartDataSourceBase

#### Fields
- private System.Collections.Generic.Dictionary<ChartAndGraph.DataSource.ChartDataItemBase, int> mChartDataToIndex
- public ChartAndGraph.DataSource.ChartColumnCollection mColumns
- private System.Collections.Generic.Dictionary<ChartAndGraph.ChartSparseDataSource.KeyElement, double> mData
- private bool mFireEvent
- private System.Nullable<System.Collections.Generic.KeyValuePair<ChartAndGraph.ChartSparseDataSource.KeyElement, double>> mMaxValue
- private System.Nullable<System.Collections.Generic.KeyValuePair<ChartAndGraph.ChartSparseDataSource.KeyElement, double>> mMinValue
- private double[,] mRawData
- public ChartAndGraph.DataSource.ChartRowCollection mRows
- private bool mSuspendEvents

#### Properties
- public ChartAndGraph.DataSource.ChartColumnCollection Columns { get; }
- public ChartAndGraph.DataSource.ChartRowCollection Rows { get; }
- public bool SuspendEvents { get; set; }

#### Constructors
- public ChartSparseDataSource()

#### Methods
- public void AddLabel(string columnName, int rowIndex, string text)
- public void Clear()
- private void Columns_ItemRemoved(ChartAndGraph.DataSource.ChartDataColumn obj)
- private void EnsureRawData()
- private void FindMinMaxValue()
- public override double[,] getRawData()
- internal System.Nullable<double> getRawMaxValue()
- internal System.Nullable<double> getRawMinValue()
- public double GetValue(string ColumnName, string RowName)
- public double GetValue(string ColumnName, int rowIndex)
- public double GetValue(int columnIndex, int rowIndex)
- private bool HasZeroItems()
- private double InnerGetValue(ChartAndGraph.DataSource.ChartDataColumn column, ChartAndGraph.DataSource.ChartDataRow row)
- private void InnerSetValue(ChartAndGraph.DataSource.ChartDataColumn column, ChartAndGraph.DataSource.ChartDataRow row, double amount)
- private void ItemRemoved(ChartAndGraph.DataSource.IDataItem item)
- private void MColumns_ItemsReplaced(string first, int firstIndex, string second, int secondIndex)
- private void MColumns_NameChanged(string arg1, ChartAndGraph.DataSource.IDataItem arg2)
- private void MRows_NameChanged(string arg1, ChartAndGraph.DataSource.IDataItem arg2)
- private void OrderChanged(object sender, System.EventArgs e)
- private void PrepareRawData()
- private void Rows_ItemRemoved(ChartAndGraph.DataSource.ChartDataRow obj)
- public void SetValue(string ColumnName, string RowName, double amount)
- public void SetValue(string ColumnName, int rowIndex, double amount)
- public void SetValue(int columnIndex, int rowIndex, double amount)
- private bool VerifyMinMaxValue(ChartAndGraph.ChartSparseDataSource.KeyElement element, double value)

### internal class ChartAndGraph.ChartSubDivisionInfo
- Base: ChartAndGraph.ChartDivisionInfo
- Interfaces: ChartAndGraph.IInternalSettings

#### Constructors
- public ChartSubDivisionInfo()

#### Methods
- protected override float ValidateTotal(float total)

### public class ChartAndGraph.CustomChartPointer
- Base: UnityEngine.UI.MaskableGraphic
- Interfaces: UnityEngine.UI.ICanvasElement, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler

#### Fields
- public bool Click
- public bool IsMouseDown
- public bool IsOut
- public UnityEngine.Vector2 ScreenPosition

#### Constructors
- public CustomChartPointer()

#### Methods
- protected override void Awake()
- private void LateUpdate()
- public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
- public override bool Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
- protected override void UpdateGeometry()

### internal class ChartAndGraph.CustomPathGenerator
- Base: ChartAndGraph.SmoothPathGenerator

#### Fields
- private bool mClosedSmooth
- private System.Collections.Generic.List<UnityEngine.Vector3> mOfPAth
- private System.Collections.Generic.List<UnityEngine.Quaternion> mTmpAngles
- private System.Collections.Generic.List<float> mTmpScales
- private System.Collections.Generic.List<int> mTmpTringle
- private System.Collections.Generic.List<UnityEngine.Vector2> mTmpUv
- private System.Collections.Generic.List<UnityEngine.Vector3> mVertices

#### Constructors
- public CustomPathGenerator()

#### Methods
- private void AddTringles(System.Collections.Generic.List<int> tringles, int from, int to)
- public void Generate(float startAngle, float angleSpan, float radius, float innerRadius, int segments, float outerdepth, float innerdepth)
- public override void Generator(UnityEngine.Vector3[] path, float thickness, bool closed)
- private UnityEngine.Quaternion getAngle(int index, UnityEngine.Quaternion def)
- private float getScale(int index)
- protected void OfPath(UnityEngine.Vector3[] path)
- private float quickBlend(float blend)
- private int writeItem(UnityEngine.Quaternion angle, UnityEngine.Vector3 center, float scale, float u)

### public class ChartAndGraph.CylinderPathGenerator
- Base: ChartAndGraph.SmoothPathGenerator

#### Fields
- public int CircleVertices
- public float HeightRatio
- private UnityEngine.Vector3[] mCircleTemp
- private UnityEngine.Vector3[] mCurrentCircle
- private System.Collections.Generic.List<int> mTmpTringle
- private System.Collections.Generic.List<UnityEngine.Vector2> mTmpUv
- private System.Collections.Generic.List<UnityEngine.Vector3> mVertices

#### Constructors
- public CylinderPathGenerator()

#### Methods
- private void AddTringles(System.Collections.Generic.List<int> tringles, int from, int to)
- private void EnsureCirlce()
- public override void Generator(UnityEngine.Vector3[] path, float thickness, bool closed)
- private int WriteCircle(float thickness, UnityEngine.Quaternion angle, UnityEngine.Vector3 center, float u)

### private class ChartAndGraph.AxisBase.DivisionEnumerable
- Interfaces: System.Collections.IEnumerable

#### Fields
- private double mDirection
- private double mEndValue
- private double mFraction
- private double mGap
- private double mStartValue
- private bool mWithSides

#### Constructors
- public AxisBase.DivisionEnumerable(double startValue, double fraction, double direction, double gap, double endValue, bool withSides)

#### Methods
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()

### public enum ChartAndGraph.ChartDivisionInfo.DivisionMessure
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DataUnits = 1
- TotalDivisions = 0

### private class ChartAndGraph.ChartCommon.DoubleComparer
- Interfaces: System.Collections.Generic.IEqualityComparer<double>

#### Constructors
- public ChartCommon.DoubleComparer()

#### Methods
- public bool Equals(double x, double y)
- public int GetHashCode(double obj)

### public struct ChartAndGraph.DoubleRect

#### Fields
- public double Height
- public double Width
- public double X
- public double Y

#### Properties
- public ChartAndGraph.DoubleVector3 max { get; }
- public ChartAndGraph.DoubleVector3 min { get; }

#### Constructors
- public DoubleRect(double x, double y, double width, double height)

#### Methods
- public override string ToString()

### public struct ChartAndGraph.DoubleVector2

#### Fields
- public double x
- public double y

#### Constructors
- public DoubleVector2(UnityEngine.Vector2 v)
- public DoubleVector2(double _x, double _y)

#### Methods
- public ChartAndGraph.DoubleVector3 ToDoubleVector3()
- public UnityEngine.Vector2 ToVector2()

### public struct ChartAndGraph.DoubleVector3

#### Fields
- public double x
- public double y
- public double z

#### Properties
- public static ChartAndGraph.DoubleVector3 back { get; }
- public static ChartAndGraph.DoubleVector3 down { get; }
- public static ChartAndGraph.DoubleVector3 forward { get; }
- public static ChartAndGraph.DoubleVector3 fwd { get; }
- public double Item { get; set; }
- public static ChartAndGraph.DoubleVector3 left { get; }
- public double magnitude { get; }
- public ChartAndGraph.DoubleVector3 normalized { get; }
- public static ChartAndGraph.DoubleVector3 one { get; }
- public static ChartAndGraph.DoubleVector3 right { get; }
- public double sqrMagnitude { get; }
- public static ChartAndGraph.DoubleVector3 up { get; }
- public static ChartAndGraph.DoubleVector3 zero { get; }

#### Constructors
- public DoubleVector3(UnityEngine.Vector3 v)
- public DoubleVector3(double x, double y)
- public DoubleVector3(double x, double y, double z)

#### Methods
- public static ChartAndGraph.DoubleVector3 ClampMagnitude(ChartAndGraph.DoubleVector3 vector, double maxLength)
- public static ChartAndGraph.DoubleVector3 Cross(ChartAndGraph.DoubleVector3 lhs, ChartAndGraph.DoubleVector3 rhs)
- public static double Distance(ChartAndGraph.DoubleVector3 a, ChartAndGraph.DoubleVector3 b)
- public static double Dot(ChartAndGraph.DoubleVector3 lhs, ChartAndGraph.DoubleVector3 rhs)
- public override bool Equals(object other)
- public override int GetHashCode()
- public static ChartAndGraph.DoubleVector3 Lerp(ChartAndGraph.DoubleVector3 a, ChartAndGraph.DoubleVector3 b, double t)
- public static ChartAndGraph.DoubleVector3 LerpUnclamped(ChartAndGraph.DoubleVector3 a, ChartAndGraph.DoubleVector3 b, double t)
- public static double Magnitude(ChartAndGraph.DoubleVector3 a)
- public static ChartAndGraph.DoubleVector3 Max(ChartAndGraph.DoubleVector3 lhs, ChartAndGraph.DoubleVector3 rhs)
- public static ChartAndGraph.DoubleVector3 Min(ChartAndGraph.DoubleVector3 lhs, ChartAndGraph.DoubleVector3 rhs)
- public static ChartAndGraph.DoubleVector3 MoveTowards(ChartAndGraph.DoubleVector3 current, ChartAndGraph.DoubleVector3 target, double maxDistanceDelta)
- public static ChartAndGraph.DoubleVector3 Normalize(ChartAndGraph.DoubleVector3 value)
- public void Normalize()
- public static ChartAndGraph.DoubleVector3 op_Addition(ChartAndGraph.DoubleVector3 a, ChartAndGraph.DoubleVector3 b)
- public static ChartAndGraph.DoubleVector3 op_Division(ChartAndGraph.DoubleVector3 a, double d)
- public static bool op_Equality(ChartAndGraph.DoubleVector3 lhs, ChartAndGraph.DoubleVector3 rhs)
- public static bool op_Inequality(ChartAndGraph.DoubleVector3 lhs, ChartAndGraph.DoubleVector3 rhs)
- public static ChartAndGraph.DoubleVector3 op_Multiply(ChartAndGraph.DoubleVector3 a, double d)
- public static ChartAndGraph.DoubleVector3 op_Multiply(double d, ChartAndGraph.DoubleVector3 a)
- public static ChartAndGraph.DoubleVector3 op_Subtraction(ChartAndGraph.DoubleVector3 a, ChartAndGraph.DoubleVector3 b)
- public static ChartAndGraph.DoubleVector3 op_UnaryNegation(ChartAndGraph.DoubleVector3 a)
- public static ChartAndGraph.DoubleVector3 Reflect(ChartAndGraph.DoubleVector3 inDirection, ChartAndGraph.DoubleVector3 inNormal)
- public static ChartAndGraph.DoubleVector3 Scale(ChartAndGraph.DoubleVector3 a, ChartAndGraph.DoubleVector3 b)
- public void Scale(ChartAndGraph.DoubleVector3 scale)
- public void Set(double new_x, double new_y, double new_z)
- public static double SqrMagnitude(ChartAndGraph.DoubleVector3 a)
- public ChartAndGraph.DoubleVector2 ToDoubleVector2()
- public ChartAndGraph.DoubleVector4 ToDoubleVector4()
- public override string ToString()
- public string ToString(string format)
- public UnityEngine.Vector2 ToVector2()
- public UnityEngine.Vector3 ToVector3()
- public UnityEngine.Vector3 ToVector4()

### private class ChartAndGraph.ChartCommon.DoubleVector3Comparer
- Interfaces: System.Collections.Generic.IEqualityComparer<ChartAndGraph.DoubleVector3>

#### Constructors
- public ChartCommon.DoubleVector3Comparer()

#### Methods
- public bool Equals(ChartAndGraph.DoubleVector3 x, ChartAndGraph.DoubleVector3 y)
- public int GetHashCode(ChartAndGraph.DoubleVector3 obj)

### public struct ChartAndGraph.DoubleVector4

#### Fields
- public double w
- public double x
- public double y
- public double z

#### Constructors
- public DoubleVector4(double _x, double _y, double _z, double _w)

#### Methods
- public ChartAndGraph.DoubleVector3 ToDoubleVector3()
- public UnityEngine.Vector3 ToVector3()
- public UnityEngine.Vector4 ToVector4()

### public class ChartAndGraph.ChartItemEvents.Event
- Base: UnityEngine.Events.UnityEvent<UnityEngine.GameObject>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public ChartItemEvents.Event()

### public class ChartAndGraph.EventHandlingGraphic
- Base: UnityEngine.UI.MaskableGraphic
- Interfaces: UnityEngine.UI.ICanvasElement, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier

#### Fields
- private int <refrenceIndex>k__BackingField
- public bool allowMouse
- private ChartAndGraph.EventHandlingGraphic.GraphicEvent Click
- private ChartAndGraph.EventHandlingGraphic.GraphicEvent Hover
- private System.Action Leave
- private ChartAndGraph.SensitivityControl mControl
- private ChartAndGraph.ChartItemEffect mCurrentHover
- private bool mForceMouseMove
- private System.Collections.Generic.List<ChartAndGraph.ChartItemEffect> mHoverFreeObjects
- private System.Collections.Generic.List<ChartAndGraph.ChartItemEffect> mHoverObjectes
- private ChartAndGraph.ChartItemEffect mHoverPrefab
- private UnityEngine.Transform mHoverTransform
- private bool mIsMouseIn
- private UnityEngine.Vector2 mLastMousePosition
- private object mPickedData
- private int mPickedIndex
- private int mPickedType
- protected System.Nullable<UnityEngine.Rect> mUvRect
- protected System.Nullable<UnityEngine.Rect> ViewRect
- private UnityEngine.UI.GraphicRaycaster _caster
- private ChartAndGraph.AnyChart _chart
- private ChartAndGraph.CustomChartPointer _pointer

#### Properties
- protected UnityEngine.Vector2 Max { get; }
- private UnityEngine.UI.GraphicRaycaster mCaster { get; set; }
- private ChartAndGraph.AnyChart mChart { get; set; }
- protected UnityEngine.Vector2 Min { get; }
- protected float MouseInThreshold { get; }
- private ChartAndGraph.CustomChartPointer mPointer { get; set; }
- protected int refrenceIndex { get; private set; }
- public float Sensitivity { get; }

#### Events
- public event ChartAndGraph.EventHandlingGraphic.GraphicEvent Click
- public event ChartAndGraph.EventHandlingGraphic.GraphicEvent Hover
- public event System.Action Leave

#### Constructors
- protected EventHandlingGraphic()

#### Methods
- public void ClearEvents()
- internal void DoLeave()
- private void DoMouse(UnityEngine.Vector3 mouse, bool leave, bool force)
- private void Effect_Deactivate(ChartAndGraph.ChartItemEffect obj)
- private void HandleMouseDown()
- public bool HandleMouseMove(bool force)
- public void HoverTransform(UnityEngine.Transform t)
- public ChartAndGraph.ChartItemEffect LockHoverObject(int index, int type, object selectionData)
- protected abstract void Pick(UnityEngine.Vector3 mouse, out int pickedIndex, out int pickedType, out object SelectionData)
- public void RefreshInputs()
- public void SetHoverPrefab(ChartAndGraph.ChartItemEffect prefab)
- public void SetRefrenceIndex(int index)
- protected void SetUpAllHoverObjects()
- protected abstract void SetUpHoverObject(ChartAndGraph.ChartItemEffect hover, int index, int type, object selectionData)
- private void SetUpHoverObject(ChartAndGraph.ChartItemEffect hover)
- protected void SetupHoverObjectToRect(ChartAndGraph.ChartItemEffect hover, int index, int type, UnityEngine.Rect rect)
- public void SetViewRect(UnityEngine.Rect r, UnityEngine.Rect uvRect)
- private void TriggerIn(ChartAndGraph.ChartItemEffect hover)
- private void TriggerOut(ChartAndGraph.ChartItemEffect hover)
- protected virtual void Update()

### public class ChartAndGraph.FillPathGenerator
- Base: ChartAndGraph.SmoothPathGenerator

#### Fields
- public bool MatchLine
- private float mGraphBottom
- private float mGraphTop
- private bool mHasParent
- private float mParentJointSize
- private int mParentJointSmoothing
- private System.Collections.Generic.List<int> mTmpTringle
- private System.Collections.Generic.List<UnityEngine.Vector2> mTmpUv
- private System.Collections.Generic.List<UnityEngine.Vector3> mVertices
- private bool StretchFill
- public bool WithTop

#### Properties
- protected float JointSizeLink { get; }
- protected int JointSmoothingLink { get; }

#### Constructors
- public FillPathGenerator()

#### Methods
- private void AddTringles(System.Collections.Generic.List<int> tringles, int from, int to)
- public override void Generator(UnityEngine.Vector3[] path, float thickness, bool closed)
- public void SetGraphBounds(float bottom, float top)
- public void SetLineSmoothing(bool hasParent, int jointSmoothing, float jointSize)
- public void SetStrechFill(bool strech)
- private int WriteVector(UnityEngine.Vector3 position, float thickness, float u)

### public enum ChartAndGraph.AnyChart.FitAlign
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CenterXCenterY = 2
- CenterXStartY = 1
- StartXCenterY = 0
- StartXStartY = 3

### public enum ChartAndGraph.AnyChart.FitOrientation
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Normal = 0
- Vertical = 1
- VerticalOpopsite = 2

### public enum ChartAndGraph.AnyChart.FitType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Aspect = 1
- Height = 2
- None = 0
- Width = 3

### internal class ChartAndGraph.GameObjectPool<T>

#### Fields
- private System.Collections.Generic.List<T> mPool

#### Constructors
- public GameObjectPool<T>()

#### Methods
- public void DeactivateObjects()
- public void DestoryAll()
- public void RecycleObject(T obj)
- public T TakeObject()

### public class ChartAndGraph.GraphChart
- Base: ChartAndGraph.GraphChartBase
- Interfaces: ChartAndGraph.IInternalUse, UnityEngine.ISerializationCallbackReceiver, ChartAndGraph.ICanvas

#### Fields
- public bool allowMouse
- private bool enableBetaOptimization
- private ChartAndGraph.ChartMagin fitMargin
- private bool fitToContainer
- public ChartAndGraph.GraphChartBase.GraphEvent LineClicked
- public ChartAndGraph.GraphChartBase.GraphEvent LineHovered
- private System.Collections.Generic.Dictionary<string, ChartAndGraph.GraphChart.CategoryObject> mCategoryObjects
- private System.Collections.Generic.List<ChartAndGraph.DoubleVector4> mClipped
- private System.Collections.Generic.HashSet<string> mOccupiedCateogies
- private System.Text.StringBuilder mRealtimeStringBuilder
- private System.Collections.Generic.List<ChartAndGraph.DoubleVector3> mTmpData
- private System.Collections.Generic.List<int> mTmpToRemove
- private System.Collections.Generic.List<UnityEngine.Vector4> mTransformed
- private bool negativeFill
- private bool SupressRealtimeGeneration
- private UnityEngine.Transform _hoverTransform

#### Properties
- private bool EnableBetaOptimization { get; set; }
- protected ChartAndGraph.AnyChart.FitType FitAspectCanvas { get; }
- public ChartAndGraph.ChartMagin FitMargin { get; set; }
- public bool FitToContainer { get; set; }
- public UnityEngine.Transform HoverTransform { get; set; }
- public bool IsCanvas { get; }
- protected ChartAndGraph.ChartMagin MarginLink { get; }
- public bool NegativeFill { get; set; }
- protected bool ShouldFitCanvas { get; }
- public bool SupportRealtimeGeneration { get; }

#### Constructors
- public GraphChart()

#### Methods
- private bool <OnItemLeave>b__64_0(string x)
- private void AddOccupiedCategory(string cat, string type)
- private double AddRadius(double radius, double mag, double min, double max)
- private void CenterObject(UnityEngine.GameObject obj, UnityEngine.RectTransform parent)
- public override void ClearCache()
- protected override void ClearChart()
- private ChartAndGraph.CanvasLines CreateDataObject(ChartAndGraph.GraphData.CategoryData data, UnityEngine.GameObject rectMask, bool mask)
- internal void CreateHoverTransform()
- private void Dots_Click(string category, int idx, UnityEngine.Vector2 pos)
- private void Dots_Hover(string category, int idx, UnityEngine.Vector2 pos)
- private void Dots_Leave(string category)
- public override void GenerateRealtime()
- protected override double GetCategoryDepth(string category)
- public override void InternalGenerateChart()
- private void Lines_Clicked(string category, int idx, UnityEngine.Vector2 pos)
- private void Lines_Hover(string category, int idx, UnityEngine.Vector2 pos)
- private void Lines_Leave(string category)
- protected override void OnItemHoverted(object userData)
- protected override void OnItemLeave(object userData, string type)
- protected override void OnItemSelected(object userData)
- protected void OnLineHovered(object userData)
- protected void OnLineSelected(object userData)
- internal override void SetAsMixedSeries()
- protected override void Update()
- protected override void ViewPortionChanged()

### public class ChartAndGraph.GraphChartBase
- Base: ChartAndGraph.ScrollableAxisChart
- Interfaces: ChartAndGraph.IInternalUse, UnityEngine.ISerializationCallbackReceiver

#### Fields
- protected ChartAndGraph.GraphData Data
- protected float heightRatio
- private string itemFormat
- protected System.Collections.Generic.Dictionary<string, int> mMinimumUpdateIndex
- protected bool mRealtimeUpdateIndex
- private System.Text.StringBuilder mTmpBuilder
- public UnityEngine.Events.UnityEvent NonHovered
- public ChartAndGraph.GraphChartBase.GraphEvent PointClicked
- public ChartAndGraph.GraphChartBase.GraphEvent PointHovered
- protected float widthRatio

#### Properties
- protected ChartAndGraph.IChartData DataLink { get; }
- public ChartAndGraph.GraphData DataSource { get; }
- public float HeightRatio { get; set; }
- public string ItemFormat { get; set; }
- protected ChartAndGraph.LegenedData LegendInfo { get; }
- protected bool SupportsCategoryLabels { get; }
- protected bool SupportsGroupLables { get; }
- protected bool SupportsItemLabels { get; }
- protected float TotalDepthLink { get; }
- protected float TotalHeightLink { get; }
- protected float TotalWidthLink { get; }
- public float WidthRatio { get; set; }

#### Constructors
- protected GraphChartBase()

#### Methods
- public abstract void ClearCache()
- protected void ClearRealtimeIndexdata()
- protected int ClipPoints(System.Collections.Generic.IList<ChartAndGraph.DoubleVector3> points, System.Collections.Generic.List<ChartAndGraph.DoubleVector4> res, out UnityEngine.Rect uv)
- private UnityEngine.Rect CreateUvRect(UnityEngine.Rect completeRect, UnityEngine.Rect lineRect)
- public string FormatItem(double x, double y)
- public string FormatItem(string x, string y)
- protected void FormatItem(System.Text.StringBuilder builder, string x, string y)
- protected override float GetScrollingRange(int axis)
- private void GraphChartBase_InternalRealTimeDataChanged(int index, string category)
- private void GraphChartBase_InternalViewPortionChanged(object sender, System.EventArgs e)
- private void GraphChart_InternalDataChanged(object sender, System.EventArgs e)
- protected override bool HasValues(ChartAndGraph.AxisBase axis)
- private void HookEvents()
- public override void Invalidate()
- protected override double MaxValue(ChartAndGraph.AxisBase axis)
- protected override double MinValue(ChartAndGraph.AxisBase axis)
- protected override void OnAxisValuesChanged()
- protected override void OnItemHoverted(object userData)
- protected override void OnItemSelected(object userData)
- protected override void OnLabelSettingChanged()
- protected override void OnLabelSettingsSet()
- protected override void OnValidate()
- protected override void Start()
- protected ChartAndGraph.DoubleVector4 TransformPoint(UnityEngine.Rect viewRect, UnityEngine.Vector3 point, ChartAndGraph.DoubleVector2 min, ChartAndGraph.DoubleVector2 range)
- protected void TransformPoints(System.Collections.Generic.IList<ChartAndGraph.DoubleVector3> points, UnityEngine.Rect viewRect, ChartAndGraph.DoubleVector3 min, ChartAndGraph.DoubleVector3 max)
- protected bool TransformPoints(System.Collections.Generic.IList<ChartAndGraph.DoubleVector4> points, System.Collections.Generic.List<UnityEngine.Vector4> output, UnityEngine.Rect viewRect, ChartAndGraph.DoubleVector3 min, ChartAndGraph.DoubleVector3 max)
- protected override void Update()
- private void UpdateMinMax(ChartAndGraph.DoubleVector3 point, ref double minX, ref double minY, ref double maxX, ref double maxY)
- protected override void ValidateProperties()
- protected abstract void ViewPortionChanged()

### public class ChartAndGraph.GraphData
- Base: ChartAndGraph.ScrollableChartData
- Interfaces: ChartAndGraph.IChartData, ChartAndGraph.IMixedSeriesProxy, ChartAndGraph.IInternalGraphData

#### Fields
- private ChartAndGraph.GraphData.VectorComparer mComparer
- private ChartAndGraph.GraphData.SerializedCategory[] mSerializedData
- private System.Collections.Generic.List<ChartAndGraph.DoubleVector3> mTmpDriv

#### Properties
- public System.Collections.Generic.IEnumerable<string> CategoryNames { get; }
- private System.Collections.Generic.IEnumerable<ChartAndGraph.GraphData.CategoryData> ChartAndGraph.IInternalGraphData.Categories { get; }
- private int ChartAndGraph.IInternalGraphData.TotalCategories { get; }
- private bool IsExtended { get; }

#### Events
- private event System.EventHandler ChartAndGraph.IInternalGraphData.InternalDataChanged
- private event System.Action<int, string> ChartAndGraph.IInternalGraphData.InternalRealTimeDataChanged
- private event System.EventHandler ChartAndGraph.IInternalGraphData.InternalViewPortionChanged

#### Constructors
- public GraphData()

#### Methods
- public void AddCategory(string category, UnityEngine.Material lineMaterial, double lineThickness, ChartAndGraph.MaterialTiling lineTiling, UnityEngine.Material innerFill, bool strechFill, UnityEngine.Material pointMaterial, double pointSize, bool maskPoints = false)
- protected override bool AddCategory(string category, ChartAndGraph.BaseScrollableCategoryData data)
- public void AddCurveToCategory(string category, ChartAndGraph.DoubleVector2 controlPointA, ChartAndGraph.DoubleVector2 controlPointB, ChartAndGraph.DoubleVector2 toPoint, double pointSize = -1)
- protected void AddInnerCategoryGraph(string category, ChartAndGraph.PathGenerator linePrefab, UnityEngine.Material lineMaterial, double lineThickness, ChartAndGraph.MaterialTiling lineTiling, ChartAndGraph.FillPathGenerator fillPrefab, UnityEngine.Material innerFill, bool strechFill, UnityEngine.GameObject pointPrefab, UnityEngine.Material pointMaterial, double pointSize, double depth, bool isCurve, int segmentsPerCurve, UnityEngine.Vector2[] initialData = null)
- public void AddLinearCurveToCategory(string category, ChartAndGraph.DoubleVector2 toPoint, double pointSize = -1)
- public void AddPointToCategory(string category, System.DateTime x, System.DateTime y, double pointSize = -1)
- public void AddPointToCategory(string category, System.DateTime x, double y, double pointSize = -1)
- public void AddPointToCategory(string category, double x, System.DateTime y, double pointSize = -1)
- public void AddPointToCategory(string category, double x, double y, double pointSize = -1)
- public static void AddPointToCategoryWithLabel(ChartAndGraph.GraphChartBase chart, string category, System.DateTime x, double y, double pointSize = -1, string xLabel = null, string yLabel = null)
- public static void AddPointToCategoryWithLabel(ChartAndGraph.GraphChartBase chart, string category, double x, System.DateTime y, double pointSize = -1, string xLabel = null, string yLabel = null)
- public static void AddPointToCategoryWithLabel(ChartAndGraph.GraphChartBase chart, string category, System.DateTime x, System.DateTime y, double pointSize = -1, string xLabel = null, string yLabel = null)
- public static void AddPointToCategoryWithLabel(ChartAndGraph.GraphChartBase chart, string category, double x, double y, double pointSize = -1, string xLabel = null, string yLabel = null)
- public void AnimateCurve(string category, float time)
- protected override void AppendDatum(string category, ChartAndGraph.MixedSeriesGenericValue value)
- protected override void AppendDatum(string category, System.Collections.Generic.IList<ChartAndGraph.MixedSeriesGenericValue> value)
- private double ChartAndGraph.IInternalGraphData.GetMaxValue(int axis, bool dataValue)
- private double ChartAndGraph.IInternalGraphData.GetMinValue(int axis, bool dataValue)
- private void CheckExtended(ref bool result)
- public void ClearAndMakeBezierCurve(string category)
- public void ClearAndMakeLinear(string category)
- public void ClearAndSetAllowNonFunctions(string category, bool AllowNonFunctions)
- public void ClearCategory(string category)
- public void GetCategoryFill(string category, out UnityEngine.Material fillMaterial, out bool strechFill)
- public void GetCategoryLine(string category, out UnityEngine.Material lineMaterial, out double lineThickness, out ChartAndGraph.MaterialTiling lineTiling)
- public void GetCategoryPoint(string category, out UnityEngine.Material pointMaterial, out double pointSize)
- public override ChartAndGraph.BaseScrollableCategoryData GetDefaultCategory()
- public bool GetLastPoint(string category, out ChartAndGraph.DoubleVector3 point)
- public ChartAndGraph.DoubleVector3 GetPoint(string category, int index)
- public int GetPointCount(string category)
- protected override void InnerClearCategory(string category)
- public bool isCategoryEnabled(string category)
- public void MakeCurveCategorySmooth(string category, float tensor = 0.25)
- public void MakeCurveCategorySmoothCubic(string category)
- private double max3(double a, double b, double c)
- private ChartAndGraph.DoubleVector2 max3(ChartAndGraph.DoubleVector2 a, ChartAndGraph.DoubleVector2 b, ChartAndGraph.DoubleVector2 c)
- private double min3(double a, double b, double c)
- private ChartAndGraph.DoubleVector2 min3(ChartAndGraph.DoubleVector2 a, ChartAndGraph.DoubleVector2 b, ChartAndGraph.DoubleVector2 c)
- public override void OnAfterDeserialize()
- public override void OnBeforeSerialize()
- public bool RemoveCategory(string category)
- public void RenameCategory(string prevName, string newName)
- public void RestoreCategory(string category, object store)
- public void Set2DCategoryPrefabs(string category, ChartAndGraph.ChartItemEffect lineHover, ChartAndGraph.ChartItemEffect pointHover)
- public void SetCategoryEnabled(string category, bool enabled)
- public void SetCategoryFill(string category, UnityEngine.Material fillMaterial, bool strechFill)
- public void SetCategoryLine(string category, UnityEngine.Material lineMaterial, double lineThickness, ChartAndGraph.MaterialTiling lineTiling)
- public void SetCategoryPoint(string category, UnityEngine.Material pointMaterial, double pointSize)
- public void SetCategoryViewOrder(string category, int viewOrder)
- public void SetCurveInitialPoint(string category, System.DateTime x, double y, double pointSize = -1)
- public void SetCurveInitialPoint(string category, System.DateTime x, System.DateTime y, double pointSize = -1)
- public void SetCurveInitialPoint(string category, double x, System.DateTime y, double pointSize = -1)
- public void SetCurveInitialPoint(string category, double x, double y, double pointSize = -1)
- private void SetInitialData(string category, UnityEngine.Vector2[] initialData, bool isCurve)
- public object[] StoreAllCategoriesinOrder()
- public object StoreCategory(string category)
- public override void Update()

### public class ChartAndGraph.GraphChartBase.GraphEvent
- Base: UnityEngine.Events.UnityEvent<ChartAndGraph.GraphChartBase.GraphEventArgs>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public GraphChartBase.GraphEvent()

### public class ChartAndGraph.GraphChartBase.GraphEventArgs
- Interfaces: System.IEquatable<ChartAndGraph.GraphChartBase.GraphEventArgs>

#### Fields
- private string <Category>k__BackingField
- private string <Group>k__BackingField
- private int <Index>k__BackingField
- private float <Magnitude>k__BackingField
- private UnityEngine.Vector3 <Position>k__BackingField
- private ChartAndGraph.DoubleVector2 <Value>k__BackingField
- private string <XString>k__BackingField
- private string <YString>k__BackingField

#### Properties
- public string Category { get; private set; }
- public string Group { get; private set; }
- public int Index { get; private set; }
- public float Magnitude { get; private set; }
- public UnityEngine.Vector3 Position { get; private set; }
- public ChartAndGraph.DoubleVector2 Value { get; private set; }
- public string XString { get; private set; }
- public string YString { get; private set; }

#### Constructors
- public GraphChartBase.GraphEventArgs(int index, UnityEngine.Vector3 position, ChartAndGraph.DoubleVector2 value, float magnitude, string category, string xString, string yString)

#### Methods
- public override bool Equals(object obj)
- public bool Equals(ChartAndGraph.GraphChartBase.GraphEventArgs other)
- public override int GetHashCode()

### internal class ChartAndGraph.GraphFileManager

#### Constructors
- public GraphFileManager()

#### Methods
- public void LoadGraphDataFromFile(string path, ChartAndGraph.GraphChartBase graph)
- public void SaveGraphDataToFile(string path, ChartAndGraph.GraphChartBase graph)

### public delegate ChartAndGraph.EventHandlingGraphic.GraphicEvent
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public EventHandlingGraphic.GraphicEvent(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(int index, int type, object data, UnityEngine.Vector2 position, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(int index, int type, object data, UnityEngine.Vector2 position)

### public enum ChartAndGraph.GroupLabelAlignment
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AlternateSides = 3
- BarBottom = 5
- BarTop = 4
- BeginingOfGroup = 2
- Center = 0
- EndOfGroup = 1
- FirstBar = 6

### public class ChartAndGraph.HorizontalAxis
- Base: ChartAndGraph.AxisBase
- Interfaces: ChartAndGraph.IInternalSettings, UnityEngine.ISerializationCallbackReceiver

#### Properties
- protected System.Action<ChartAndGraph.IInternalUse, bool> Assign { get; }

#### Constructors
- public HorizontalAxis()

#### Methods
- private void <get_Assign>b__1_0(ChartAndGraph.IInternalUse x, bool clear)

### public interface ChartAndGraph.ICanvas

### public interface ChartAndGraph.IChartData

#### Methods
- public void OnAfterDeserialize()
- public void OnBeforeSerialize()
- public void Update()

### internal interface ChartAndGraph.IChartMesh

#### Properties
- public float Length { get; set; }
- public float Offset { get; set; }
- public System.Collections.Generic.List<BillboardText> TextObjects { get; }
- public float Tile { get; set; }

#### Methods
- public void AddQuad(UnityEngine.UIVertex vLeftTop, UnityEngine.UIVertex vRightTop, UnityEngine.UIVertex vLeftBottom, UnityEngine.UIVertex vRightBottom)
- public BillboardText AddText(ChartAndGraph.AnyChart chart, UnityEngine.MonoBehaviour prefab, UnityEngine.Transform parentTransform, int fontSize, float fontScale, string text, float x, float y, float z, float angle, object userData)
- public void AddXYRect(UnityEngine.Rect rect, int subMeshGroup, float depth)
- public void AddXZRect(UnityEngine.Rect rect, int subMeshGroup, float yPosition)
- public void AddYZRect(UnityEngine.Rect rect, int subMeshGroup, float xPosition)

### internal interface ChartAndGraph.IInternalGraphData

#### Properties
- public System.Collections.Generic.IEnumerable<ChartAndGraph.GraphData.CategoryData> Categories { get; }
- public int TotalCategories { get; }

#### Events
- public event System.EventHandler InternalDataChanged
- public event System.Action<int, string> InternalRealTimeDataChanged
- public event System.EventHandler InternalViewPortionChanged

#### Methods
- public double GetMaxValue(int axis, bool dataValue)
- public double GetMinValue(int axis, bool dataValue)
- public void OnAfterDeserialize()
- public void OnBeforeSerialize()
- public void Update()

### public interface ChartAndGraph.IInternalSettings

#### Events
- public event System.EventHandler InternalOnDataChanged
- public event System.EventHandler InternalOnDataUpdate

### public interface ChartAndGraph.IInternalUse

#### Properties
- public CategoryLabels CategoryLabels { get; set; }
- public GroupLabels GroupLabels { get; set; }
- public bool HideHierarchy { get; }
- public ChartAndGraph.HorizontalAxis HorizontalAxis { get; set; }
- public System.Collections.Generic.HashSet<double> HorizontalCustomAxis { get; }
- public System.Collections.Generic.HashSet<double> HorizontalCustomAxisSubDivision { get; }
- public ChartAndGraph.LegenedData InternalLegendInfo { get; }
- public bool InternalSupportsCategoryLables { get; }
- public bool InternalSupportsGroupLabels { get; }
- public bool InternalSupportsItemLabels { get; }
- public UnityEngine.Camera InternalTextCamera { get; }
- public TextController InternalTextController { get; }
- public float InternalTextIdleDistance { get; }
- public float InternalTotalDepth { get; }
- public float InternalTotalHeight { get; }
- public float InternalTotalWidth { get; }
- public ChartAndGraph.ItemLabels ItemLabels { get; set; }
- public ChartAndGraph.VerticalAxis VerticalAxis { get; set; }
- public System.Collections.Generic.HashSet<double> VerticalCustomAxis { get; }
- public System.Collections.Generic.HashSet<double> VerticalCustomAxisSubDivision { get; }

#### Events
- public event System.Action Generated

#### Methods
- public void CallOnValidate()
- public bool InternalHasValues(ChartAndGraph.AxisBase axis)
- public void InternalItemHovered(object userData)
- public void InternalItemLeave(object userData)
- public void InternalItemSelected(object userData)
- public double InternalMaxValue(ChartAndGraph.AxisBase axis)
- public double InternalMinValue(ChartAndGraph.AxisBase axis)

### internal interface ChartAndGraph.IMixedChartDelegate

#### Methods
- public ChartAndGraph.ScrollableAxisChart CreateCategoryView(System.Type t, ChartAndGraph.ScrollableAxisChart prefab)
- public void DeactivateChart(ChartAndGraph.ScrollableAxisChart chart)
- public void ReactivateChart(ChartAndGraph.ScrollableAxisChart chart)
- public void RealaseChart(ChartAndGraph.ScrollableAxisChart chart)
- public void SetData(System.Collections.Generic.Dictionary<string, ChartAndGraph.BaseScrollableCategoryData> data)

### internal interface ChartAndGraph.IMixedSeriesProxy

#### Methods
- public bool AddCategory(string category, ChartAndGraph.BaseScrollableCategoryData data)
- public void AppendDatum(string category, ChartAndGraph.MixedSeriesGenericValue value)
- public void AppendDatum(string category, System.Collections.Generic.IList<ChartAndGraph.MixedSeriesGenericValue> value)
- public void ClearCategory(string category)
- public bool HasCategory(string catgeory)

### public class ChartAndGraph.InfoBox
- Base: UnityEngine.MonoBehaviour

#### Fields
- public ChartAndGraph.GraphChartBase[] GraphChart
- public UnityEngine.UI.Text infoText

#### Constructors
- public InfoBox()

#### Methods
- private void GraphClicked(ChartAndGraph.GraphChartBase.GraphEventArgs args)
- private void GraphHoverd(ChartAndGraph.GraphChartBase.GraphEventArgs args)
- private void GraphLineClicked(ChartAndGraph.GraphChartBase.GraphEventArgs args)
- private void GraphLineHoverd(ChartAndGraph.GraphChartBase.GraphEventArgs args)
- public void HookChartEvents()
- private void NonHovered()
- private void Start()
- private void Update()

### private class ChartAndGraph.ChartCommon.IntComparer
- Interfaces: System.Collections.Generic.IEqualityComparer<int>

#### Constructors
- public ChartCommon.IntComparer()

#### Methods
- public bool Equals(int x, int y)
- public int GetHashCode(int obj)

### internal interface ChartAndGraph.InternalItemEvents

#### Properties
- public ChartAndGraph.IInternalUse Parent { get; set; }
- public object UserData { get; set; }

### public class ChartAndGraph.ItemLabels
- Base: ChartAndGraph.AlignedItemLabels
- Interfaces: ChartAndGraph.IInternalSettings, UnityEngine.ISerializationCallbackReceiver

#### Fields
- private int fractionDigits

#### Properties
- protected System.Action<ChartAndGraph.IInternalUse, bool> Assign { get; }
- public int FractionDigits { get; set; }

#### Constructors
- public ItemLabels()

#### Methods
- private void <get_Assign>b__5_0(ChartAndGraph.IInternalUse x, bool clear)

### internal class ChartAndGraph.JsonParser
- Base: ChartAndGraph.ChartParser

#### Fields
- private GraphAndChartSimpleJSON.JSONNode mBaseJson
- private GraphAndChartSimpleJSON.JSONNode mRelativePath

#### Constructors
- public JsonParser(string data)

#### Methods
- public override System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> GetAllChildObjects(object obj)
- public override int GetArraySize(object arr)
- public override object GetChildObject(object obj, string name)
- public override string GetChildObjectValue(object obj, string name)
- public override string GetItem(object arr, int item)
- public override object GetItemObject(object arr, int item)
- public override object GetObject(string name)
- private object GetObjectFromRoot(GraphAndChartSimpleJSON.JSONNode root, string name)
- public override string ObjectValue(object obj)
- public override bool SetPathRelativeTo(string pathObject)

### private struct ChartAndGraph.ChartSparseDataSource.KeyElement

#### Fields
- private ChartAndGraph.DataSource.ChartDataColumn <Column>k__BackingField
- private ChartAndGraph.DataSource.ChartDataRow <Row>k__BackingField

#### Properties
- public ChartAndGraph.DataSource.ChartDataColumn Column { get; private set; }
- public ChartAndGraph.DataSource.ChartDataRow Row { get; private set; }

#### Constructors
- public ChartSparseDataSource.KeyElement(ChartAndGraph.DataSource.ChartDataRow row, ChartAndGraph.DataSource.ChartDataColumn column)

#### Methods
- public override bool Equals(object obj)
- public override int GetHashCode()
- public bool IsIn(ChartAndGraph.DataSource.IDataItem item)
- public bool IsInColumn(ChartAndGraph.DataSource.ChartDataColumn column)
- public bool IsInRow(ChartAndGraph.DataSource.ChartDataRow row)
- public static bool op_Equality(ChartAndGraph.ChartSparseDataSource.KeyElement a, ChartAndGraph.ChartSparseDataSource.KeyElement b)
- public static bool op_Inequality(ChartAndGraph.ChartSparseDataSource.KeyElement a, ChartAndGraph.ChartSparseDataSource.KeyElement b)

### public class ChartAndGraph.LegenedData

#### Fields
- private System.Collections.Generic.List<ChartAndGraph.LegenedData.LegenedItem> mItems

#### Properties
- public System.Collections.Generic.IEnumerable<ChartAndGraph.LegenedData.LegenedItem> Items { get; }

#### Constructors
- public LegenedData()

#### Methods
- public void AddLegenedItem(ChartAndGraph.LegenedData.LegenedItem item)

### public class ChartAndGraph.LegenedData.LegenedItem

#### Fields
- public UnityEngine.Material Material
- public string Name

#### Constructors
- public LegenedData.LegenedItem()

### internal struct ChartAndGraph.CanvasLines.Line

#### Fields
- private bool <Degenerated>k__BackingField
- private UnityEngine.Vector3 <Dir>k__BackingField
- private UnityEngine.Vector3 <From>k__BackingField
- private float <Mag>k__BackingField
- private UnityEngine.Vector3 <Normal>k__BackingField
- private UnityEngine.Vector3 <P1>k__BackingField
- private UnityEngine.Vector3 <P2>k__BackingField
- private UnityEngine.Vector3 <P3>k__BackingField
- private UnityEngine.Vector3 <P4>k__BackingField
- private UnityEngine.Vector3 <To>k__BackingField

#### Properties
- public bool Degenerated { get; private set; }
- public UnityEngine.Vector3 Dir { get; private set; }
- public UnityEngine.Vector3 From { get; private set; }
- public float Mag { get; private set; }
- public UnityEngine.Vector3 Normal { get; private set; }
- public UnityEngine.Vector3 P1 { get; private set; }
- public UnityEngine.Vector3 P2 { get; private set; }
- public UnityEngine.Vector3 P3 { get; private set; }
- public UnityEngine.Vector3 P4 { get; private set; }
- public UnityEngine.Vector3 To { get; private set; }

#### Constructors
- public CanvasLines.Line(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float halfThickness, bool hasNext, bool hasPrev)

### internal class ChartAndGraph.LineRendererPathGenerator
- Base: ChartAndGraph.PathGenerator

#### Fields
- private UnityEngine.LineRenderer mRenderer

#### Constructors
- public LineRendererPathGenerator()

#### Methods
- public override void Clear()
- public void EnsureRenderer()
- public override void Generator(UnityEngine.Vector3[] path, float thickness, bool closed)
- private void Start()

### internal class ChartAndGraph.CanvasLines.LineSegement

#### Fields
- private System.Collections.Generic.List<UnityEngine.Vector4> mLines

#### Properties
- public int LineCount { get; }
- public int PointCount { get; }

#### Constructors
- public CanvasLines.LineSegement(System.Collections.Generic.IList<UnityEngine.Vector3> lines)
- public CanvasLines.LineSegement(System.Collections.Generic.IList<UnityEngine.Vector4> lines)

#### Methods
- public void GetLine(int index, out UnityEngine.Vector3 from, out UnityEngine.Vector3 to)
- public ChartAndGraph.CanvasLines.Line GetLine(int index, float halfThickness, bool hasPrev, bool hasNext)
- public double GetLineMag(int index)
- public UnityEngine.Vector4 getPoint(int index)
- public void ModifiyLines(System.Collections.Generic.List<UnityEngine.Vector4> v)

### public struct ChartAndGraph.MaterialTiling
- Interfaces: System.IEquatable<ChartAndGraph.MaterialTiling>

#### Fields
- public bool EnableTiling
- public float TileFactor

#### Constructors
- public MaterialTiling(bool enable, float value)

#### Methods
- public bool Equals(ChartAndGraph.MaterialTiling other)
- public override bool Equals(object obj)
- public override int GetHashCode()
- public static bool op_Equality(ChartAndGraph.MaterialTiling a, ChartAndGraph.MaterialTiling b)
- public static bool op_Inequality(ChartAndGraph.MaterialTiling a, ChartAndGraph.MaterialTiling b)

### public enum ChartAndGraph.MeshDimention
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- _2D = 0
- _3D = 1

### public struct ChartAndGraph.MixedSeriesGenericValue

#### Fields
- private double high
- private int index
- private double low
- private string name
- private double size
- private int subIndex
- private object userData
- private double x
- private double x1
- private double y
- private double y1

### public class ChartAndGraph.NonCanvasAttribute
- Base: System.Attribute

#### Constructors
- public NonCanvasAttribute()

### public class ChartAndGraph.PathGenerator
- Base: UnityEngine.MonoBehaviour

#### Constructors
- protected PathGenerator()

#### Methods
- public abstract void Clear()
- public abstract void Generator(UnityEngine.Vector3[] path, float thickness, bool closed)

### internal class ChartAndGraph.PathMultiplier

#### Fields
- public float JointSize
- public int JointSmoothing
- private System.Collections.Generic.List<UnityEngine.Vector3> mInnerTmpCenters
- protected System.Collections.Generic.List<UnityEngine.Vector3> mMultipliedPath
- protected System.Collections.Generic.List<UnityEngine.Vector3> mTmpCenters

#### Constructors
- public PathMultiplier()

#### Methods
- private void AddCenters(UnityEngine.Vector3 translation, float scale)
- private void AddJointSegments(UnityEngine.Vector3 from, UnityEngine.Vector3 curr, UnityEngine.Vector3 to)
- public void ApplyToMesh(ChartAndGraph.WorldSpaceChartMesh mesh)
- protected UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 diff)
- public void ModifyPath(UnityEngine.Vector3[] path, bool closed)
- public void MultiplyPath(UnityEngine.Vector3[] path)

### public class ChartAndGraph.ScrollableAxisChart
- Base: ChartAndGraph.AxisChart
- Interfaces: ChartAndGraph.IInternalUse, UnityEngine.ISerializationCallbackReceiver

#### Fields
- protected bool autoScrollHorizontally
- protected bool autoScrollVertically
- private bool horizontalPanning
- protected double horizontalScrolling
- protected System.Collections.Generic.HashSet<BillboardText> mActiveTexts
- private UnityEngine.UI.GraphicRaycaster mCaster
- private System.Nullable<UnityEngine.Vector2> mLastPosition
- private UnityEngine.GameObject mMask
- public UnityEngine.Events.UnityEvent MousePan
- private ChartAndGraph.CustomChartPointer mPointer
- private bool mStencilMask
- protected System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, BillboardText>> mTexts
- private bool raycastTarget
- protected bool scrollable
- private bool verticalPanning
- protected double verticalScrolling

#### Properties
- public bool AutoScrollHorizontally { get; set; }
- public bool AutoScrollVertically { get; set; }
- protected UnityEngine.Vector3 CanvasFitOffset { get; }
- public bool HorizontalPanning { get; set; }
- public double HorizontalScrolling { get; set; }
- private UnityEngine.Vector3 PointShift { get; }
- public bool RaycastTarget { get; set; }
- public bool Scrollable { get; set; }
- public ChartAndGraph.ScrollableChartData ScrollableData { get; }
- public bool StencilMask { get; set; }
- public bool VerticalPanning { get; set; }
- public double VerticalScrolling { get; set; }

#### Constructors
- protected ScrollableAxisChart()

#### Methods
- protected void AddActiveText(BillboardText b)
- protected void AddBillboardText(string cat, int index, BillboardText text)
- protected void ClearBillboard()
- protected void ClearBillboardCategories()
- protected override void ClearChart()
- protected UnityEngine.GameObject CreateRectMask(UnityEngine.Rect viewRect)
- public override void GenerateRealtime()
- protected abstract double GetCategoryDepth(string category)
- protected abstract float GetScrollingRange(int axis)
- protected override double GetScrollOffset(int axis)
- protected void GetScrollParams(out double minX, out double minY, out double maxX, out double maxY, out double xScroll, out double yScroll, out double xSize, out double ySize, out double xOut)
- private void HandleMouseDrag()
- public bool IsRectVisible(ChartAndGraph.DoubleRect rect)
- private void MouseDraged(UnityEngine.Vector2 delta)
- public bool MouseToClient(out double x, out double y)
- private ChartAndGraph.DoubleVector3 NormalizedToPoint(double x, double y)
- public bool PointToClient(UnityEngine.Vector3 worldPoint, out double x, out System.DateTime y)
- public bool PointToClient(UnityEngine.Vector3 worldPoint, out System.DateTime x, out System.DateTime y)
- public bool PointToClient(UnityEngine.Vector3 worldPoint, out System.DateTime x, out double y)
- public bool PointToClient(UnityEngine.Vector3 worldPoint, out double x, out double y)
- private ChartAndGraph.DoubleVector3 PointToNormalized(double x, double y)
- public bool PointToWorldSpace(out UnityEngine.Vector3 result, System.DateTime x, double y, string category = null)
- public bool PointToWorldSpace(out UnityEngine.Vector3 result, double x, System.DateTime y, string category = null)
- public bool PointToWorldSpace(out UnityEngine.Vector3 result, System.DateTime x, System.DateTime y, string category = null)
- public bool PointToWorldSpace(out UnityEngine.Vector3 result, double x, double y, string category = null)
- public bool RectToCanvas(UnityEngine.RectTransform assignTo, ChartAndGraph.DoubleRect rect, string catgeory = null)
- protected void SelectActiveText(BillboardText b)
- internal abstract void SetAsMixedSeries()
- protected string StringFromAxisFormat(ChartAndGraph.DoubleVector3 val, ChartAndGraph.AxisBase axis, bool isX)
- protected string StringFromAxisFormat(ChartAndGraph.DoubleVector3 val, ChartAndGraph.AxisBase axis, int fractionDigits, bool isX)
- protected void TriggerActiveTextsOut()
- public bool TrimRect(ChartAndGraph.DoubleRect rect, out ChartAndGraph.DoubleRect trimmed)
- protected override void Update()

### public class ChartAndGraph.ScrollableChartData
- Interfaces: ChartAndGraph.IChartData, ChartAndGraph.IMixedSeriesProxy

#### Fields
- private double automaticcHorizontaViewGap
- private bool automaticHorizontalView
- private bool automaticVerticallView
- private double automaticVerticalViewGap
- private System.EventHandler DataChanged
- private double horizontalViewOrigin
- private double horizontalViewSize
- protected System.Collections.Generic.Dictionary<string, ChartAndGraph.BaseScrollableCategoryData> mData
- protected System.Collections.Generic.List<ChartAndGraph.BaseSlider> mSliders
- protected bool mSuspendEvents
- private System.Action<int, string> RealtimeDataChanged
- private double verticalViewOrigin
- private double verticalViewSize
- private System.EventHandler ViewPortionChanged

#### Properties
- public double AutomaticcHorizontaViewGap { get; set; }
- public bool AutomaticHorizontalView { get; set; }
- public bool AutomaticVerticallView { get; set; }
- public double AutomaticVerticallViewGap { get; set; }
- public double HorizontalViewOrigin { get; set; }
- public double HorizontalViewSize { get; set; }
- public double VerticalViewOrigin { get; set; }
- public double VerticalViewSize { get; set; }

#### Events
- protected event System.EventHandler DataChanged
- protected event System.Action<int, string> RealtimeDataChanged
- protected event System.EventHandler ViewPortionChanged

#### Constructors
- protected ScrollableChartData()

#### Methods
- private bool <Update>b__47_0(ChartAndGraph.BaseSlider x)
- protected abstract bool AddCategory(string category, ChartAndGraph.BaseScrollableCategoryData data)
- protected abstract void AppendDatum(string category, ChartAndGraph.MixedSeriesGenericValue value)
- protected abstract void AppendDatum(string category, System.Collections.Generic.IList<ChartAndGraph.MixedSeriesGenericValue> value)
- private bool ChartAndGraph.IMixedSeriesProxy.AddCategory(string category, ChartAndGraph.BaseScrollableCategoryData data)
- private void ChartAndGraph.IMixedSeriesProxy.AppendDatum(string category, ChartAndGraph.MixedSeriesGenericValue value)
- private void ChartAndGraph.IMixedSeriesProxy.AppendDatum(string category, System.Collections.Generic.IList<ChartAndGraph.MixedSeriesGenericValue> value)
- private void ChartAndGraph.IMixedSeriesProxy.ClearCategory(string category)
- private bool ChartAndGraph.IMixedSeriesProxy.HasCategory(string catgeory)
- public void Clear()
- public int countData()
- public void EndBatch()
- public abstract ChartAndGraph.BaseScrollableCategoryData GetDefaultCategory()
- public virtual double GetMaxValue(int axis, bool dataValue)
- public double GetMaxXValue()
- public double GetMaxYValue()
- public virtual double GetMinValue(int axis, bool dataValue)
- public double GetMinXValue()
- public double GetMinYValue()
- public bool hasAnyData()
- public bool HasCategory(string category)
- protected abstract void InnerClearCategory(string category)
- protected void ModifyMinMax(ChartAndGraph.BaseScrollableCategoryData data, ChartAndGraph.DoubleVector3 point)
- public abstract void OnAfterDeserialize()
- public abstract void OnBeforeSerialize()
- protected void RaiseDataChanged()
- protected void RaiseRealtimeDataChanged(int index, string category)
- protected void RaiseViewPortionChanged()
- public void RestoreDataValues()
- public void RestoreDataValues(int axis)
- public void StartBatch()
- public virtual void Update()

### public class ChartAndGraph.SensitivityControl
- Base: UnityEngine.MonoBehaviour

#### Fields
- public float Sensitivity

#### Constructors
- public SensitivityControl()

### private class ChartAndGraph.GraphData.SerializedCategory

#### Fields
- public bool AllowNonFunctionsBeta
- public ChartAndGraph.DoubleVector3[] data
- public double Depth
- public UnityEngine.GameObject DotPrefab
- public ChartAndGraph.FillPathGenerator FillPrefab
- public UnityEngine.Vector2[] InitialData
- public UnityEngine.Material InnerFill
- public bool IsBezierCurve
- public ChartAndGraph.ChartItemEffect LineHoverPrefab
- public ChartAndGraph.PathGenerator LinePrefab
- public double LineThickness
- public ChartAndGraph.MaterialTiling LineTiling
- public bool MaskPoints
- public UnityEngine.Material Material
- public System.Nullable<double> MaxRadius
- public System.Nullable<double> MaxX
- public System.Nullable<double> MaxY
- public System.Nullable<double> MinX
- public System.Nullable<double> MinY
- public string Name
- public ChartAndGraph.ChartItemEffect PointHoverPrefab
- public UnityEngine.Material PointMaterial
- public double PointSize
- public int SegmentsPerCurve
- public bool StetchFill
- public int ViewOrder

#### Constructors
- public GraphData.SerializedCategory()

### public class ChartAndGraph.SimpleAttribute
- Base: System.Attribute

#### Constructors
- public SimpleAttribute()

### protected class ChartAndGraph.AbstractChartData.Slider

#### Fields
- public string category
- public UnityEngine.AnimationCurve curve
- public double from
- public string group
- public float startTime
- public float timeScale
- public double to
- public float totalTime

#### Constructors
- public AbstractChartData.Slider()

#### Methods
- public bool UpdateSlider(ChartAndGraph.AbstractChartData data)

### private class ChartAndGraph.GraphData.Slider
- Base: ChartAndGraph.BaseSlider

#### Fields
- public ChartAndGraph.DoubleVector3 Base
- public string category
- public ChartAndGraph.DoubleVector3 current
- public int from
- public int index
- private ChartAndGraph.GraphData mParent
- public ChartAndGraph.DoubleVector3 To

#### Properties
- public string Category { get; }
- public ChartAndGraph.DoubleVector2 Max { get; }
- public ChartAndGraph.DoubleVector2 Min { get; }
- public int MinIndex { get; }

#### Constructors
- public GraphData.Slider(ChartAndGraph.GraphData parent)

#### Methods
- public override bool Update()

### public class ChartAndGraph.SmoothPathGenerator
- Base: ChartAndGraph.PathGenerator

#### Fields
- public float JointSize
- public int JointSmoothing
- private UnityEngine.Mesh mCleanMesh
- private UnityEngine.MeshFilter mFilter
- private System.Collections.Generic.List<UnityEngine.Vector3> mInnerTmpCenters
- protected System.Collections.Generic.List<int> mSkipJoints
- protected System.Collections.Generic.List<UnityEngine.Vector3> mTmpCenters

#### Properties
- protected float JointSizeLink { get; }
- protected int JointSmoothingLink { get; }

#### Constructors
- protected SmoothPathGenerator()

#### Methods
- private void AddJointSegments(UnityEngine.Vector3 from, UnityEngine.Vector3 curr, UnityEngine.Vector3 to)
- public override void Clear()
- protected bool EnsureMeshFilter()
- protected UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 diff)
- protected void ModifyPath(UnityEngine.Vector3[] path, bool closed, System.Collections.Generic.List<UnityEngine.Vector3> res)
- protected void ModifyPath(UnityEngine.Vector3[] path, bool closed)
- public void OnDestroy()
- public void SetMesh(System.Collections.Generic.List<UnityEngine.Vector3> vertices, System.Collections.Generic.List<UnityEngine.Vector2> uvs, System.Collections.Generic.List<int> triangles)
- public void SetMesh(UnityEngine.Mesh mesh)

### internal class ChartAndGraph.AxisBase.TextData

#### Fields
- public int fractionDigits
- public ChartAndGraph.ChartDivisionInfo info
- public double interp

#### Constructors
- public AxisBase.TextData()

### public class ChartAndGraph.TextDirection
- Base: UnityEngine.MonoBehaviour

#### Fields
- private TextController controller
- public float Gap
- public float Length
- public UnityEngine.Material LineMaterial
- public ChartAndGraph.CanvasLines Lines
- public ChartAndGraph.CanvasLines Point
- public UnityEngine.Material PointMaterial
- public float PointSize
- private UnityEngine.Transform relativeFrom
- private UnityEngine.Transform relativeTo
- public UnityEngine.MonoBehaviour Text
- public float Thickness

#### Constructors
- public TextDirection()

#### Methods
- public void LateUpdate()
- public void SetDirection(float angle)
- private void SetDirection(UnityEngine.Vector3 dir)
- public void SetRelativeTo(UnityEngine.Transform from, UnityEngine.Transform to)
- public void SetTextController(TextController control)
- public void Start()

### public class ChartAndGraph.TextFormatting
- Interfaces: ChartAndGraph.IInternalSettings

#### Fields
- private string customFormat
- private System.EventHandler OnDataChanged
- private System.EventHandler OnDataUpdate
- private string prefix
- private string suffix

#### Properties
- public string CustomFormat { get; set; }
- public string Prefix { get; set; }
- public string Suffix { get; set; }

#### Events
- private event System.EventHandler ChartAndGraph.IInternalSettings.InternalOnDataChanged
- private event System.EventHandler ChartAndGraph.IInternalSettings.InternalOnDataUpdate
- private event System.EventHandler OnDataChanged
- private event System.EventHandler OnDataUpdate

#### Constructors
- public TextFormatting()

#### Methods
- public void Format(System.Text.StringBuilder builder, string data, string category, string group)
- public string Format(string data, string category, string group)
- private string FormatKeywords(string str, string category, string group)
- private void FormatKeywords(System.Text.StringBuilder builder, string category, string group)
- protected virtual void RaiseOnChanged()
- protected virtual void RaiseOnUpdate()
- private string ValidString(string str)

### private class ChartAndGraph.GraphData.VectorComparer
- Interfaces: System.Collections.Generic.IComparer<ChartAndGraph.DoubleVector3>

#### Constructors
- public GraphData.VectorComparer()

#### Methods
- public int Compare(ChartAndGraph.DoubleVector3 x, ChartAndGraph.DoubleVector3 y)

### public class ChartAndGraph.VerticalAxis
- Base: ChartAndGraph.AxisBase
- Interfaces: ChartAndGraph.IInternalSettings, UnityEngine.ISerializationCallbackReceiver

#### Properties
- protected System.Action<ChartAndGraph.IInternalUse, bool> Assign { get; }

#### Constructors
- public VerticalAxis()

#### Methods
- private void <get_Assign>b__1_0(ChartAndGraph.IInternalUse x, bool clear)

### internal class ChartAndGraph.WorldSpaceChartMesh
- Base: ChartAndGraph.ChartMeshBase
- Interfaces: ChartAndGraph.IChartMesh

#### Fields
- private bool mIsCanvas
- private System.Collections.Generic.List<int>[] mTringles
- private System.Collections.Generic.List<UnityEngine.Vector2> mUv
- private System.Collections.Generic.List<UnityEngine.Vector3> mVertices

#### Constructors
- public WorldSpaceChartMesh(bool isCanvas)
- public WorldSpaceChartMesh(int groups)

#### Methods
- public override void AddQuad(UnityEngine.UIVertex vLeftTop, UnityEngine.UIVertex vRightTop, UnityEngine.UIVertex vLeftBottom, UnityEngine.UIVertex vRightBottom)
- public override BillboardText AddText(ChartAndGraph.AnyChart chart, UnityEngine.MonoBehaviour prefab, UnityEngine.Transform parentTransform, int fontSize, float fontScale, string text, float x, float y, float z, float angle, object userData)
- public void AddTringle(int x, int y, int z)
- protected void AddTringle(System.Collections.Generic.List<int> tringleList, int x, int y, int z)
- public int AddVertex(UnityEngine.UIVertex v)
- public int AddVertex(UnityEngine.Vector3 pos, UnityEngine.Vector2 uv)
- public override void AddXYRect(UnityEngine.Rect rect, int subMeshGroup, float depth)
- public override void AddXZRect(UnityEngine.Rect rect, int subMeshGroup, float yPosition)
- public override void AddYZRect(UnityEngine.Rect rect, int subMeshGroup, float xPosition)
- public void ApplyToMesh(UnityEngine.Mesh m)
- public override void Clear()
- public UnityEngine.Mesh Generate(UnityEngine.Mesh m)
- public UnityEngine.Mesh Generate()
- private UnityEngine.Color[] GetColors()
- protected System.Collections.Generic.List<int> GetTringlesForGroup(int subMeshGroup)
- protected void ValidateMesh()

### internal class ChartAndGraph.XMLParser
- Base: ChartAndGraph.ChartParser

#### Fields
- private System.Xml.XmlElement mRelativeElement
- private System.Xml.XmlDocument mXmlDoc

#### Constructors
- public XMLParser(string xml)

#### Methods
- public override System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> GetAllChildObjects(object obj)
- public override int GetArraySize(object arr)
- public override object GetChildObject(object obj, string name)
- public override string GetChildObjectValue(object obj, string name)
- public override string GetItem(object arr, int item)
- public override object GetItemObject(object arr, int item)
- public override object GetObject(string name)
- private object GetObjectFromRoot(System.Xml.XmlElement root, string name)
- public override string ObjectValue(object obj)
- public override bool SetPathRelativeTo(string pathObject)

## Namespace: ChartAndGraph.Axis

### public class ChartAndGraph.Axis.AxisGenerator
- Base: UnityEngine.MonoBehaviour
- Interfaces: ChartAndGraph.Axis.IAxisGenerator

#### Fields
- private ChartAndGraph.AxisBase mAxis
- private UnityEngine.Mesh mCleanMesh
- private UnityEngine.Mesh mCreated
- private UnityEngine.Material mDispose
- private int mDivType
- private UnityEngine.MeshFilter mFilter
- private UnityEngine.Material mMaterial
- private ChartAndGraph.WorldSpaceChartMesh mMesh
- private ChartAndGraph.ChartOrientation mOrientation
- private ChartAndGraph.AnyChart mParent
- private UnityEngine.MeshRenderer mRenderer
- private double mScroll
- private System.Collections.Generic.List<BillboardText> mTexts
- private float mTiling

#### Constructors
- public AxisGenerator()

#### Methods
- public void FixLabels(ChartAndGraph.AnyChart parent)
- public UnityEngine.GameObject GetGameObject()
- private float GetTiling(ChartAndGraph.AnyChart parent, ChartAndGraph.ChartOrientation orientation, ChartAndGraph.ChartDivisionInfo inf)
- private void InnerFixLabels(ChartAndGraph.AnyChart parent)
- private void InnerSetAxis(double scrollOffset, ChartAndGraph.AnyChart parent, ChartAndGraph.AxisBase axis, ChartAndGraph.ChartOrientation axisOrientation, int divType)
- private void OnDestroy()
- public void SetAxis(double scrollOffset, ChartAndGraph.AnyChart parent, ChartAndGraph.AxisBase axis, ChartAndGraph.ChartOrientation axisOrientation, int divType)
- private void Start()
- public UnityEngine.Object This()
- protected virtual void Update()

### internal class ChartAndGraph.Axis.CanvasAxisGenerator
- Base: UnityEngine.UI.Image
- Interfaces: UnityEngine.UI.ICanvasElement, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier, UnityEngine.ISerializationCallbackReceiver, UnityEngine.UI.ILayoutElement, UnityEngine.ICanvasRaycastFilter, ChartAndGraph.Axis.IAxisGenerator

#### Fields
- private ChartAndGraph.AxisBase mAxis
- private UnityEngine.Mesh mCleanMesh
- private UnityEngine.Material mDispose
- private int mDivType
- private UnityEngine.MeshFilter mFilter
- private UnityEngine.Material mMaterial
- private ChartAndGraph.CanvasChartMesh mMesh
- private ChartAndGraph.ChartOrientation mOrientation
- private ChartAndGraph.AnyChart mParent
- private UnityEngine.MeshRenderer mRenderer
- private double mScrollOffset
- private System.Collections.Generic.List<BillboardText> mTexts
- private float mTiling

#### Constructors
- public CanvasAxisGenerator()

#### Methods
- private void AddToCanvasChartMesh(ChartAndGraph.CanvasChartMesh mesh)
- public void FixLabels(ChartAndGraph.AnyChart parent)
- public UnityEngine.GameObject GetGameObject()
- private float GetTiling(ChartAndGraph.MaterialTiling tiling)
- protected override void OnDestroy()
- protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
- public void SetAxis(double scrollOffset, ChartAndGraph.AnyChart parent, ChartAndGraph.AxisBase axis, ChartAndGraph.ChartOrientation axisOrientation, int divType)
- public UnityEngine.Object This()
- protected virtual void Update()
- protected override void UpdateMaterial()

### public interface ChartAndGraph.Axis.IAxisGenerator

#### Methods
- public void FixLabels(ChartAndGraph.AnyChart parent)
- public UnityEngine.GameObject GetGameObject()
- public void SetAxis(double scrollOffset, ChartAndGraph.AnyChart parent, ChartAndGraph.AxisBase axis, ChartAndGraph.ChartOrientation axisOrientation, int divType)
- public UnityEngine.Object This()

## Namespace: ChartAndGraph.Common

### internal struct ChartAndGraph.Common.ChartItemIndex

#### Fields
- private int <Category>k__BackingField
- private int <Group>k__BackingField

#### Properties
- public int Category { get; set; }
- public int Group { get; set; }

#### Constructors
- public ChartItemIndex(int group, int category)

#### Methods
- public override bool Equals(object obj)
- public override int GetHashCode()

## Namespace: ChartAndGraph.DataSource

### internal class ChartAndGraph.DataSource.ChartColumnCollection
- Base: ChartAndGraph.ChartDataSourceBaseCollection<ChartAndGraph.DataSource.ChartDataColumn>
- Interfaces: System.Collections.Generic.ICollection<ChartAndGraph.DataSource.ChartDataColumn>, System.Collections.Generic.IEnumerable<ChartAndGraph.DataSource.ChartDataColumn>, System.Collections.IEnumerable

#### Properties
- protected string ItemTypeName { get; }

#### Constructors
- public ChartColumnCollection()

### internal class ChartAndGraph.DataSource.ChartDataColumn
- Base: ChartAndGraph.DataSource.ChartDataItemBase
- Interfaces: ChartAndGraph.DataSource.IDataItem

#### Constructors
- public ChartDataColumn(string name)

### internal class ChartAndGraph.DataSource.ChartDataItemBase
- Interfaces: ChartAndGraph.DataSource.IDataItem

#### Fields
- private ChartAndGraph.ChartDynamicMaterial <Material>k__BackingField
- private object <UserData>k__BackingField
- private string mName
- private string mPrevName
- private System.Action<string, ChartAndGraph.DataSource.IDataItem> NameChanged

#### Properties
- public ChartAndGraph.ChartDynamicMaterial Material { get; set; }
- public string Name { get; set; }
- public object UserData { get; set; }

#### Events
- public event System.Action<string, ChartAndGraph.DataSource.IDataItem> NameChanged

#### Constructors
- public ChartDataItemBase(string name)

#### Methods
- public void CancelNameChange()

### internal class ChartAndGraph.DataSource.ChartDataRow
- Base: ChartAndGraph.DataSource.ChartDataItemBase
- Interfaces: ChartAndGraph.DataSource.IDataItem

#### Constructors
- public ChartDataRow(string name)

### internal class ChartAndGraph.DataSource.ChartDataSourceBase

#### Fields
- private System.EventHandler DataStructureChanged
- private System.EventHandler<ChartAndGraph.DataSource.ChartDataSourceBase.DataValueChangedEventArgs> DataValueChanged
- private System.Action<string, int, string, int> ItemsReplaced

#### Properties
- public ChartAndGraph.DataSource.ChartColumnCollection Columns { get; }
- public ChartAndGraph.DataSource.ChartRowCollection Rows { get; }

#### Events
- public event System.EventHandler DataStructureChanged
- public event System.EventHandler<ChartAndGraph.DataSource.ChartDataSourceBase.DataValueChangedEventArgs> DataValueChanged
- public event System.Action<string, int, string, int> ItemsReplaced

#### Constructors
- protected ChartDataSourceBase()

#### Methods
- public abstract double[,] getRawData()
- protected void OnDataStructureChanged()
- protected void OnDataValueChanged(ChartAndGraph.DataSource.ChartDataSourceBase.DataValueChangedEventArgs data)
- protected void OnItemsReplaced(string first, int firstIndex, string second, int secondIndex)

### internal class ChartAndGraph.DataSource.ChartRowCollection
- Base: ChartAndGraph.ChartDataSourceBaseCollection<ChartAndGraph.DataSource.ChartDataRow>
- Interfaces: System.Collections.Generic.ICollection<ChartAndGraph.DataSource.ChartDataRow>, System.Collections.Generic.IEnumerable<ChartAndGraph.DataSource.ChartDataRow>, System.Collections.IEnumerable

#### Properties
- protected string ItemTypeName { get; }

#### Constructors
- public ChartRowCollection()

### public class ChartAndGraph.DataSource.ChartDataSourceBase.DataValueChangedEventArgs
- Base: System.EventArgs

#### Fields
- private ChartAndGraph.Common.ChartItemIndex <ItemIndex>k__BackingField
- private bool <MinMaxChanged>k__BackingField
- private double <NewValue>k__BackingField
- private double <OldValue>k__BackingField

#### Properties
- public ChartAndGraph.Common.ChartItemIndex ItemIndex { get; private set; }
- public bool MinMaxChanged { get; private set; }
- public double NewValue { get; private set; }
- public double OldValue { get; private set; }

#### Constructors
- public ChartDataSourceBase.DataValueChangedEventArgs(int group, int category, double oldValue, double newValue, bool minMaxChanged)

### public interface ChartAndGraph.DataSource.IDataItem

#### Properties
- public string Name { get; set; }

#### Events
- public event System.Action<string, ChartAndGraph.DataSource.IDataItem> NameChanged

#### Methods
- public void CancelNameChange()

## Namespace: ChartAndGraph.Exceptions

### internal class ChartAndGraph.Exceptions.ChartDuplicateItemException
- Base: ChartAndGraph.Exceptions.ChartException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ChartDuplicateItemException(string message)

### internal class ChartAndGraph.Exceptions.ChartException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ChartException(string message)

### internal class ChartAndGraph.Exceptions.ChartItemNotExistException
- Base: ChartAndGraph.Exceptions.ChartException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ChartItemNotExistException(string message)

## Namespace: ChartAndGraph.Legened

### internal class ChartAndGraph.Legened.CanvasLegend
- Base: UnityEngine.MonoBehaviour

#### Fields
- public ChartAndGraph.Legened.CanvasLegend.ImageOverride[] CategoryImages
- private ChartAndGraph.AnyChart chart
- private int fontSize
- private ChartAndGraph.Legened.CanvasLegendItem legendItemPrefab
- private bool mGenerateNext
- private System.Collections.Generic.List<UnityEngine.Object> mToDispose

#### Properties
- public ChartAndGraph.AnyChart Chart { get; set; }
- public int FontSize { get; set; }
- public ChartAndGraph.Legened.CanvasLegendItem LegenedItemPrefab { get; set; }

#### Constructors
- public CanvasLegend()

#### Methods
- private void CanvasLegend_Generated()
- public void Clear()
- private UnityEngine.Material CreateCanvasGradient(UnityEngine.Material mat)
- private System.Collections.Generic.Dictionary<string, UnityEngine.Texture2D> CreateimageDictionary()
- private UnityEngine.Sprite CreateSpriteFromTexture(UnityEngine.Texture2D t)
- public void Generate()
- private void InnerGenerate()
- private bool isGradientShader(UnityEngine.Material mat)
- private void OnDestory()
- private void OnDisable()
- private void OnEnable()
- protected void OnValidate()
- protected void PropertyChanged()
- private void Start()
- private void Update()

### internal class ChartAndGraph.Legened.CanvasLegendItem
- Base: UnityEngine.MonoBehaviour

#### Fields
- public UnityEngine.UI.Image Image
- public UnityEngine.UI.Text Text

#### Constructors
- public CanvasLegendItem()

### public class ChartAndGraph.Legened.CanvasLegend.ImageOverride

#### Fields
- public string category
- public UnityEngine.Texture2D Image

#### Constructors
- public CanvasLegend.ImageOverride()

## Namespace: GraphAndChartSimpleJSON

### private class GraphAndChartSimpleJSON.JSONObject.<>c__DisplayClass21_0

#### Fields
- public GraphAndChartSimpleJSON.JSONNode aNode

#### Constructors
- public JSONObject.<>c__DisplayClass21_0()

#### Methods
- internal bool <Remove>b__0(System.Collections.Generic.KeyValuePair<string, GraphAndChartSimpleJSON.JSONNode> k)

### private class GraphAndChartSimpleJSON.JSONArray.<get_Children>d__22
- Interfaces: System.Collections.Generic.IEnumerable<GraphAndChartSimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<GraphAndChartSimpleJSON.JSONNode>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private GraphAndChartSimpleJSON.JSONNode <>2__current
- public GraphAndChartSimpleJSON.JSONArray <>4__this
- private System.Collections.Generic.List<T>.Enumerator<GraphAndChartSimpleJSON.JSONNode> <>7__wrap1
- private int <>l__initialThreadId

#### Properties
- private GraphAndChartSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<GraphAndChartSimpleJSON.JSONNode>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public JSONArray.<get_Children>d__22(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<GraphAndChartSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<GraphAndChartSimpleJSON.JSONNode>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class GraphAndChartSimpleJSON.JSONObject.<get_Children>d__23
- Interfaces: System.Collections.Generic.IEnumerable<GraphAndChartSimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<GraphAndChartSimpleJSON.JSONNode>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private GraphAndChartSimpleJSON.JSONNode <>2__current
- public GraphAndChartSimpleJSON.JSONObject <>4__this
- private System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, GraphAndChartSimpleJSON.JSONNode> <>7__wrap1
- private int <>l__initialThreadId

#### Properties
- private GraphAndChartSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<GraphAndChartSimpleJSON.JSONNode>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public JSONObject.<get_Children>d__23(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<GraphAndChartSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<GraphAndChartSimpleJSON.JSONNode>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class GraphAndChartSimpleJSON.JSONNode.<get_Children>d__40
- Interfaces: System.Collections.Generic.IEnumerable<GraphAndChartSimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<GraphAndChartSimpleJSON.JSONNode>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private GraphAndChartSimpleJSON.JSONNode <>2__current
- private int <>l__initialThreadId

#### Properties
- private GraphAndChartSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<GraphAndChartSimpleJSON.JSONNode>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public JSONNode.<get_Children>d__40(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<GraphAndChartSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<GraphAndChartSimpleJSON.JSONNode>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class GraphAndChartSimpleJSON.JSONNode.<get_DeepChildren>d__42
- Interfaces: System.Collections.Generic.IEnumerable<GraphAndChartSimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<GraphAndChartSimpleJSON.JSONNode>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private GraphAndChartSimpleJSON.JSONNode <>2__current
- public GraphAndChartSimpleJSON.JSONNode <>4__this
- private System.Collections.Generic.IEnumerator<GraphAndChartSimpleJSON.JSONNode> <>7__wrap1
- private System.Collections.Generic.IEnumerator<GraphAndChartSimpleJSON.JSONNode> <>7__wrap2
- private int <>l__initialThreadId

#### Properties
- private GraphAndChartSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<GraphAndChartSimpleJSON.JSONNode>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public JSONNode.<get_DeepChildren>d__42(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private void <>m__Finally2()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<GraphAndChartSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<GraphAndChartSimpleJSON.JSONNode>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### public struct GraphAndChartSimpleJSON.JSONNode.Enumerator

#### Fields
- private System.Collections.Generic.List<T>.Enumerator<GraphAndChartSimpleJSON.JSONNode> m_Array
- private System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, GraphAndChartSimpleJSON.JSONNode> m_Object
- private GraphAndChartSimpleJSON.JSONNode.Enumerator.Type type

#### Properties
- public System.Collections.Generic.KeyValuePair<string, GraphAndChartSimpleJSON.JSONNode> Current { get; }
- public bool IsValid { get; }

#### Constructors
- public JSONNode.Enumerator(System.Collections.Generic.List<T>.Enumerator<GraphAndChartSimpleJSON.JSONNode> aArrayEnum)
- public JSONNode.Enumerator(System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, GraphAndChartSimpleJSON.JSONNode> aDictEnum)

#### Methods
- public bool MoveNext()

### public static class GraphAndChartSimpleJSON.JSON

#### Methods
- public static GraphAndChartSimpleJSON.JSONNode Parse(string aJSON)

### public class GraphAndChartSimpleJSON.JSONArray
- Base: GraphAndChartSimpleJSON.JSONNode

#### Fields
- private bool inline
- private System.Collections.Generic.List<GraphAndChartSimpleJSON.JSONNode> m_List

#### Properties
- public System.Collections.Generic.IEnumerable<GraphAndChartSimpleJSON.JSONNode> Children { get; }
- public int Count { get; }
- public bool Inline { get; set; }
- public bool IsArray { get; }
- public GraphAndChartSimpleJSON.JSONNode Item { get; set; }
- public GraphAndChartSimpleJSON.JSONNode Item { get; set; }
- public GraphAndChartSimpleJSON.JSONNodeType Tag { get; }

#### Constructors
- public JSONArray()

#### Methods
- public override void Add(string aKey, GraphAndChartSimpleJSON.JSONNode aItem)
- public override GraphAndChartSimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override GraphAndChartSimpleJSON.JSONNode Remove(int aIndex)
- public override GraphAndChartSimpleJSON.JSONNode Remove(GraphAndChartSimpleJSON.JSONNode aNode)
- public override void SerializeBinary(System.IO.BinaryWriter aWriter)
- internal override void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, GraphAndChartSimpleJSON.JSONTextMode aMode)

### public class GraphAndChartSimpleJSON.JSONBool
- Base: GraphAndChartSimpleJSON.JSONNode

#### Fields
- private bool m_Data

#### Properties
- public bool AsBool { get; set; }
- public bool IsBoolean { get; }
- public GraphAndChartSimpleJSON.JSONNodeType Tag { get; }
- public string Value { get; set; }

#### Constructors
- public JSONBool(bool aData)
- public JSONBool(string aData)

#### Methods
- public override bool Equals(object obj)
- public override GraphAndChartSimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override int GetHashCode()
- public override void SerializeBinary(System.IO.BinaryWriter aWriter)
- internal override void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, GraphAndChartSimpleJSON.JSONTextMode aMode)

### public enum GraphAndChartSimpleJSON.JSONContainerType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Array = 0
- Object = 1

### internal class GraphAndChartSimpleJSON.JSONLazyCreator
- Base: GraphAndChartSimpleJSON.JSONNode

#### Fields
- private string m_Key
- private GraphAndChartSimpleJSON.JSONNode m_Node

#### Properties
- public GraphAndChartSimpleJSON.JSONArray AsArray { get; }
- public bool AsBool { get; set; }
- public double AsDouble { get; set; }
- public float AsFloat { get; set; }
- public int AsInt { get; set; }
- public long AsLong { get; set; }
- public GraphAndChartSimpleJSON.JSONObject AsObject { get; }
- public GraphAndChartSimpleJSON.JSONNode Item { get; set; }
- public GraphAndChartSimpleJSON.JSONNode Item { get; set; }
- public GraphAndChartSimpleJSON.JSONNodeType Tag { get; }

#### Constructors
- public JSONLazyCreator(GraphAndChartSimpleJSON.JSONNode aNode)
- public JSONLazyCreator(GraphAndChartSimpleJSON.JSONNode aNode, string aKey)

#### Methods
- public override void Add(GraphAndChartSimpleJSON.JSONNode aItem)
- public override void Add(string aKey, GraphAndChartSimpleJSON.JSONNode aItem)
- public override bool Equals(object obj)
- public override GraphAndChartSimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override int GetHashCode()
- public static bool op_Equality(GraphAndChartSimpleJSON.JSONLazyCreator a, object b)
- public static bool op_Inequality(GraphAndChartSimpleJSON.JSONLazyCreator a, object b)
- public override void SerializeBinary(System.IO.BinaryWriter aWriter)
- private T Set<T>(T aVal)
- internal override void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, GraphAndChartSimpleJSON.JSONTextMode aMode)

### public class GraphAndChartSimpleJSON.JSONNode

#### Fields
- public static bool forceASCII
- public static bool longAsString
- private static System.Text.StringBuilder m_EscapeBuilder
- public static GraphAndChartSimpleJSON.JSONContainerType QuaternionContainerType
- public static GraphAndChartSimpleJSON.JSONContainerType RectContainerType
- public static GraphAndChartSimpleJSON.JSONContainerType VectorContainerType

#### Properties
- public GraphAndChartSimpleJSON.JSONArray AsArray { get; }
- public bool AsBool { get; set; }
- public double AsDouble { get; set; }
- public float AsFloat { get; set; }
- public int AsInt { get; set; }
- public long AsLong { get; set; }
- public GraphAndChartSimpleJSON.JSONObject AsObject { get; }
- public System.Collections.Generic.IEnumerable<GraphAndChartSimpleJSON.JSONNode> Children { get; }
- public int Count { get; }
- public System.Collections.Generic.IEnumerable<GraphAndChartSimpleJSON.JSONNode> DeepChildren { get; }
- internal static System.Text.StringBuilder EscapeBuilder { get; }
- public bool Inline { get; set; }
- public bool IsArray { get; }
- public bool IsBoolean { get; }
- public bool IsNull { get; }
- public bool IsNumber { get; }
- public bool IsObject { get; }
- public bool IsString { get; }
- public GraphAndChartSimpleJSON.JSONNode Item { get; set; }
- public GraphAndChartSimpleJSON.JSONNode Item { get; set; }
- public GraphAndChartSimpleJSON.JSONNode.KeyEnumerator Keys { get; }
- public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, GraphAndChartSimpleJSON.JSONNode>> Linq { get; }
- public GraphAndChartSimpleJSON.JSONNodeType Tag { get; }
- public string Value { get; set; }
- public GraphAndChartSimpleJSON.JSONNode.ValueEnumerator Values { get; }

#### Constructors
- protected JSONNode()

#### Methods
- public virtual void Add(string aKey, GraphAndChartSimpleJSON.JSONNode aItem)
- public virtual void Add(GraphAndChartSimpleJSON.JSONNode aItem)
- public static GraphAndChartSimpleJSON.JSONNode DeserializeBinary(System.IO.BinaryReader aReader)
- public override bool Equals(object obj)
- internal static string Escape(string aText)
- private static GraphAndChartSimpleJSON.JSONNode GetContainer(GraphAndChartSimpleJSON.JSONContainerType aType)
- public abstract GraphAndChartSimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override int GetHashCode()
- public static GraphAndChartSimpleJSON.JSONNode LoadFromBinaryBase64(string aBase64)
- public static GraphAndChartSimpleJSON.JSONNode LoadFromBinaryFile(string aFileName)
- public static GraphAndChartSimpleJSON.JSONNode LoadFromBinaryStream(System.IO.Stream aData)
- public static GraphAndChartSimpleJSON.JSONNode LoadFromCompressedBase64(string aBase64)
- public static GraphAndChartSimpleJSON.JSONNode LoadFromCompressedFile(string aFileName)
- public static GraphAndChartSimpleJSON.JSONNode LoadFromCompressedStream(System.IO.Stream aData)
- public static bool op_Equality(GraphAndChartSimpleJSON.JSONNode a, object b)
- public static GraphAndChartSimpleJSON.JSONNode op_Implicit(string s)
- public static string op_Implicit(GraphAndChartSimpleJSON.JSONNode d)
- public static GraphAndChartSimpleJSON.JSONNode op_Implicit(double n)
- public static double op_Implicit(GraphAndChartSimpleJSON.JSONNode d)
- public static GraphAndChartSimpleJSON.JSONNode op_Implicit(float n)
- public static float op_Implicit(GraphAndChartSimpleJSON.JSONNode d)
- public static GraphAndChartSimpleJSON.JSONNode op_Implicit(int n)
- public static int op_Implicit(GraphAndChartSimpleJSON.JSONNode d)
- public static GraphAndChartSimpleJSON.JSONNode op_Implicit(long n)
- public static long op_Implicit(GraphAndChartSimpleJSON.JSONNode d)
- public static GraphAndChartSimpleJSON.JSONNode op_Implicit(bool b)
- public static bool op_Implicit(GraphAndChartSimpleJSON.JSONNode d)
- public static GraphAndChartSimpleJSON.JSONNode op_Implicit(System.Collections.Generic.KeyValuePair<string, GraphAndChartSimpleJSON.JSONNode> aKeyValue)
- public static GraphAndChartSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector2 aVec)
- public static GraphAndChartSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector3 aVec)
- public static GraphAndChartSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector4 aVec)
- public static GraphAndChartSimpleJSON.JSONNode op_Implicit(UnityEngine.Quaternion aRot)
- public static GraphAndChartSimpleJSON.JSONNode op_Implicit(UnityEngine.Rect aRect)
- public static GraphAndChartSimpleJSON.JSONNode op_Implicit(UnityEngine.RectOffset aRect)
- public static UnityEngine.Vector2 op_Implicit(GraphAndChartSimpleJSON.JSONNode aNode)
- public static UnityEngine.Vector3 op_Implicit(GraphAndChartSimpleJSON.JSONNode aNode)
- public static UnityEngine.Vector4 op_Implicit(GraphAndChartSimpleJSON.JSONNode aNode)
- public static UnityEngine.Quaternion op_Implicit(GraphAndChartSimpleJSON.JSONNode aNode)
- public static UnityEngine.Rect op_Implicit(GraphAndChartSimpleJSON.JSONNode aNode)
- public static UnityEngine.RectOffset op_Implicit(GraphAndChartSimpleJSON.JSONNode aNode)
- public static bool op_Inequality(GraphAndChartSimpleJSON.JSONNode a, object b)
- public static GraphAndChartSimpleJSON.JSONNode Parse(string aJSON)
- private static GraphAndChartSimpleJSON.JSONNode ParseElement(string token, bool quoted)
- public UnityEngine.Matrix4x4 ReadMatrix()
- public UnityEngine.Quaternion ReadQuaternion(UnityEngine.Quaternion aDefault)
- public UnityEngine.Quaternion ReadQuaternion()
- public UnityEngine.Rect ReadRect(UnityEngine.Rect aDefault)
- public UnityEngine.Rect ReadRect()
- public UnityEngine.RectOffset ReadRectOffset(UnityEngine.RectOffset aDefault)
- public UnityEngine.RectOffset ReadRectOffset()
- public UnityEngine.Vector2 ReadVector2(UnityEngine.Vector2 aDefault)
- public UnityEngine.Vector2 ReadVector2(string aXName, string aYName)
- public UnityEngine.Vector2 ReadVector2()
- public UnityEngine.Vector3 ReadVector3(UnityEngine.Vector3 aDefault)
- public UnityEngine.Vector3 ReadVector3(string aXName, string aYName, string aZName)
- public UnityEngine.Vector3 ReadVector3()
- public UnityEngine.Vector4 ReadVector4(UnityEngine.Vector4 aDefault)
- public UnityEngine.Vector4 ReadVector4()
- public virtual GraphAndChartSimpleJSON.JSONNode Remove(string aKey)
- public virtual GraphAndChartSimpleJSON.JSONNode Remove(int aIndex)
- public virtual GraphAndChartSimpleJSON.JSONNode Remove(GraphAndChartSimpleJSON.JSONNode aNode)
- public string SaveToBinaryBase64()
- public void SaveToBinaryFile(string aFileName)
- public void SaveToBinaryStream(System.IO.Stream aData)
- public string SaveToCompressedBase64()
- public void SaveToCompressedFile(string aFileName)
- public void SaveToCompressedStream(System.IO.Stream aData)
- public abstract void SerializeBinary(System.IO.BinaryWriter aWriter)
- public override string ToString()
- public virtual string ToString(int aIndent)
- public GraphAndChartSimpleJSON.JSONNode WriteMatrix(UnityEngine.Matrix4x4 aMatrix)
- public GraphAndChartSimpleJSON.JSONNode WriteQuaternion(UnityEngine.Quaternion aRot)
- public GraphAndChartSimpleJSON.JSONNode WriteRect(UnityEngine.Rect aRect)
- public GraphAndChartSimpleJSON.JSONNode WriteRectOffset(UnityEngine.RectOffset aRect)
- internal abstract void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, GraphAndChartSimpleJSON.JSONTextMode aMode)
- public GraphAndChartSimpleJSON.JSONNode WriteVector2(UnityEngine.Vector2 aVec, string aXName = "x", string aYName = "y")
- public GraphAndChartSimpleJSON.JSONNode WriteVector3(UnityEngine.Vector3 aVec, string aXName = "x", string aYName = "y", string aZName = "z")
- public GraphAndChartSimpleJSON.JSONNode WriteVector4(UnityEngine.Vector4 aVec)

### public enum GraphAndChartSimpleJSON.JSONNodeType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Array = 1
- Boolean = 6
- Custom = 255
- None = 7
- NullValue = 5
- Number = 4
- Object = 2
- String = 3

### public class GraphAndChartSimpleJSON.JSONNull
- Base: GraphAndChartSimpleJSON.JSONNode

#### Fields
- private static GraphAndChartSimpleJSON.JSONNull m_StaticInstance
- public static bool reuseSameInstance

#### Properties
- public bool AsBool { get; set; }
- public bool IsNull { get; }
- public GraphAndChartSimpleJSON.JSONNodeType Tag { get; }
- public string Value { get; set; }

#### Constructors
- private JSONNull()
- private static JSONNull()

#### Methods
- public static GraphAndChartSimpleJSON.JSONNull CreateOrGet()
- public override bool Equals(object obj)
- public override GraphAndChartSimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override int GetHashCode()
- public override void SerializeBinary(System.IO.BinaryWriter aWriter)
- internal override void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, GraphAndChartSimpleJSON.JSONTextMode aMode)

### public class GraphAndChartSimpleJSON.JSONNumber
- Base: GraphAndChartSimpleJSON.JSONNode

#### Fields
- private double m_Data

#### Properties
- public double AsDouble { get; set; }
- public long AsLong { get; set; }
- public bool IsNumber { get; }
- public GraphAndChartSimpleJSON.JSONNodeType Tag { get; }
- public string Value { get; set; }

#### Constructors
- public JSONNumber(double aData)
- public JSONNumber(string aData)

#### Methods
- public override bool Equals(object obj)
- public override GraphAndChartSimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override int GetHashCode()
- private static bool IsNumeric(object value)
- public override void SerializeBinary(System.IO.BinaryWriter aWriter)
- internal override void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, GraphAndChartSimpleJSON.JSONTextMode aMode)

### public class GraphAndChartSimpleJSON.JSONObject
- Base: GraphAndChartSimpleJSON.JSONNode

#### Fields
- private bool inline
- private System.Collections.Generic.Dictionary<string, GraphAndChartSimpleJSON.JSONNode> m_Dict

#### Properties
- public System.Collections.Generic.IEnumerable<GraphAndChartSimpleJSON.JSONNode> Children { get; }
- public int Count { get; }
- public bool Inline { get; set; }
- public bool IsObject { get; }
- public GraphAndChartSimpleJSON.JSONNode Item { get; set; }
- public GraphAndChartSimpleJSON.JSONNode Item { get; set; }
- public GraphAndChartSimpleJSON.JSONNodeType Tag { get; }

#### Constructors
- public JSONObject()

#### Methods
- public override void Add(string aKey, GraphAndChartSimpleJSON.JSONNode aItem)
- public override GraphAndChartSimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override GraphAndChartSimpleJSON.JSONNode Remove(string aKey)
- public override GraphAndChartSimpleJSON.JSONNode Remove(int aIndex)
- public override GraphAndChartSimpleJSON.JSONNode Remove(GraphAndChartSimpleJSON.JSONNode aNode)
- public override void SerializeBinary(System.IO.BinaryWriter aWriter)
- internal override void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, GraphAndChartSimpleJSON.JSONTextMode aMode)

### public class GraphAndChartSimpleJSON.JSONString
- Base: GraphAndChartSimpleJSON.JSONNode

#### Fields
- private string m_Data

#### Properties
- public bool IsString { get; }
- public GraphAndChartSimpleJSON.JSONNodeType Tag { get; }
- public string Value { get; set; }

#### Constructors
- public JSONString(string aData)

#### Methods
- public override bool Equals(object obj)
- public override GraphAndChartSimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override int GetHashCode()
- public override void SerializeBinary(System.IO.BinaryWriter aWriter)
- internal override void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, GraphAndChartSimpleJSON.JSONTextMode aMode)

### public enum GraphAndChartSimpleJSON.JSONTextMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Compact = 0
- Indent = 1

### public struct GraphAndChartSimpleJSON.JSONNode.KeyEnumerator

#### Fields
- private GraphAndChartSimpleJSON.JSONNode.Enumerator m_Enumerator

#### Properties
- public string Current { get; }

#### Constructors
- public JSONNode.KeyEnumerator(System.Collections.Generic.List<T>.Enumerator<GraphAndChartSimpleJSON.JSONNode> aArrayEnum)
- public JSONNode.KeyEnumerator(System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, GraphAndChartSimpleJSON.JSONNode> aDictEnum)
- public JSONNode.KeyEnumerator(GraphAndChartSimpleJSON.JSONNode.Enumerator aEnumerator)

#### Methods
- public GraphAndChartSimpleJSON.JSONNode.KeyEnumerator GetEnumerator()
- public bool MoveNext()

### public class GraphAndChartSimpleJSON.JSONNode.LinqEnumerator
- Interfaces: System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, GraphAndChartSimpleJSON.JSONNode>>, System.IDisposable, System.Collections.IEnumerator, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, GraphAndChartSimpleJSON.JSONNode>>, System.Collections.IEnumerable

#### Fields
- private GraphAndChartSimpleJSON.JSONNode.Enumerator m_Enumerator
- private GraphAndChartSimpleJSON.JSONNode m_Node

#### Properties
- public System.Collections.Generic.KeyValuePair<string, GraphAndChartSimpleJSON.JSONNode> Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- internal JSONNode.LinqEnumerator(GraphAndChartSimpleJSON.JSONNode aNode)

#### Methods
- public void Dispose()
- public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, GraphAndChartSimpleJSON.JSONNode>> GetEnumerator()
- public bool MoveNext()
- public void Reset()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()

### private enum GraphAndChartSimpleJSON.JSONNode.Enumerator.Type
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Array = 1
- None = 0
- Object = 2

### public struct GraphAndChartSimpleJSON.JSONNode.ValueEnumerator

#### Fields
- private GraphAndChartSimpleJSON.JSONNode.Enumerator m_Enumerator

#### Properties
- public GraphAndChartSimpleJSON.JSONNode Current { get; }

#### Constructors
- public JSONNode.ValueEnumerator(System.Collections.Generic.List<T>.Enumerator<GraphAndChartSimpleJSON.JSONNode> aArrayEnum)
- public JSONNode.ValueEnumerator(System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, GraphAndChartSimpleJSON.JSONNode> aDictEnum)
- public JSONNode.ValueEnumerator(GraphAndChartSimpleJSON.JSONNode.Enumerator aEnumerator)

#### Methods
- public GraphAndChartSimpleJSON.JSONNode.ValueEnumerator GetEnumerator()
- public bool MoveNext()

