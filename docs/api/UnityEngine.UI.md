# Assembly: UnityEngine.UI
- Path: EraWheel/lib/UnityEngine.UI.dll
- Types: 204

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7141 1A04BBCF788FEE3EB8F02F868E70E7D8BAE76BB4DBC56D2797CF352E76B1DE81
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5527 D6FFFA8E222567B15F4C21510787016455D001AC572E639A75D4171EA40D14D8

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5527

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7141

## Namespace: UnityEngine.EventSystems

### private class UnityEngine.EventSystems.EventSystem.<>c__DisplayClass56_0

#### Fields
- public UnityEngine.GameObject go

#### Constructors
- public EventSystem.<>c__DisplayClass56_0()

#### Methods
- internal void <CreateUIToolkitPanelGameObject>b__0()

### public class UnityEngine.EventSystems.AbstractEventData

#### Fields
- protected bool m_Used

#### Properties
- public bool used { get; }

#### Constructors
- protected AbstractEventData()

#### Methods
- public virtual void Reset()
- public virtual void Use()

### public class UnityEngine.EventSystems.AxisEventData
- Base: UnityEngine.EventSystems.BaseEventData

#### Fields
- private UnityEngine.EventSystems.MoveDirection <moveDir>k__BackingField
- private UnityEngine.Vector2 <moveVector>k__BackingField

#### Properties
- public UnityEngine.EventSystems.MoveDirection moveDir { get; set; }
- public UnityEngine.Vector2 moveVector { get; set; }

#### Constructors
- public AxisEventData(UnityEngine.EventSystems.EventSystem eventSystem)

### public class UnityEngine.EventSystems.BaseEventData
- Base: UnityEngine.EventSystems.AbstractEventData

#### Fields
- private readonly UnityEngine.EventSystems.EventSystem m_EventSystem

#### Properties
- public UnityEngine.EventSystems.BaseInputModule currentInputModule { get; }
- public UnityEngine.GameObject selectedObject { get; set; }

#### Constructors
- public BaseEventData(UnityEngine.EventSystems.EventSystem eventSystem)

### public class UnityEngine.EventSystems.BaseInput
- Base: UnityEngine.EventSystems.UIBehaviour

#### Properties
- public UnityEngine.Vector2 compositionCursorPos { get; set; }
- public string compositionString { get; }
- public UnityEngine.IMECompositionMode imeCompositionMode { get; set; }
- public UnityEngine.Vector2 mousePosition { get; }
- public bool mousePresent { get; }
- public UnityEngine.Vector2 mouseScrollDelta { get; }
- public int touchCount { get; }
- public bool touchSupported { get; }

#### Constructors
- public BaseInput()

#### Methods
- public virtual float GetAxisRaw(string axisName)
- public virtual bool GetButtonDown(string buttonName)
- public virtual bool GetMouseButton(int button)
- public virtual bool GetMouseButtonDown(int button)
- public virtual bool GetMouseButtonUp(int button)
- public virtual UnityEngine.Touch GetTouch(int index)

### public class UnityEngine.EventSystems.BaseInputModule
- Base: UnityEngine.EventSystems.UIBehaviour

#### Fields
- private UnityEngine.EventSystems.AxisEventData m_AxisEventData
- private UnityEngine.EventSystems.BaseEventData m_BaseEventData
- private UnityEngine.EventSystems.BaseInput m_DefaultInput
- private UnityEngine.EventSystems.EventSystem m_EventSystem
- protected UnityEngine.EventSystems.BaseInput m_InputOverride
- protected System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_RaycastResultCache
- private bool m_SendPointerHoverToParent

#### Properties
- protected UnityEngine.EventSystems.EventSystem eventSystem { get; }
- public UnityEngine.EventSystems.BaseInput input { get; }
- public UnityEngine.EventSystems.BaseInput inputOverride { get; set; }
- internal bool sendPointerHoverToParent { get; set; }

#### Constructors
- protected BaseInputModule()

#### Methods
- public virtual void ActivateModule()
- public virtual int ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData)
- public virtual void DeactivateModule()
- protected static UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y)
- protected static UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y, float deadZone)
- protected static UnityEngine.GameObject FindCommonRoot(UnityEngine.GameObject g1, UnityEngine.GameObject g2)
- protected static UnityEngine.EventSystems.RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates)
- protected virtual UnityEngine.EventSystems.AxisEventData GetAxisEventData(float x, float y, float moveDeadZone)
- protected virtual UnityEngine.EventSystems.BaseEventData GetBaseEventData()
- protected void HandlePointerExitAndEnter(UnityEngine.EventSystems.PointerEventData currentPointerData, UnityEngine.GameObject newEnterTarget)
- public virtual bool IsModuleSupported()
- public virtual bool IsPointerOverGameObject(int pointerId)
- protected override void OnDisable()
- protected override void OnEnable()
- public abstract void Process()
- public virtual bool ShouldActivateModule()
- public virtual void UpdateModule()

### public class UnityEngine.EventSystems.BaseRaycaster
- Base: UnityEngine.EventSystems.UIBehaviour

#### Fields
- private UnityEngine.EventSystems.BaseRaycaster m_RootRaycaster

#### Properties
- public UnityEngine.Camera eventCamera { get; }
- public int priority { get; }
- public int renderOrderPriority { get; }
- public UnityEngine.EventSystems.BaseRaycaster rootRaycaster { get; }
- public int sortOrderPriority { get; }

#### Constructors
- protected BaseRaycaster()

#### Methods
- protected override void OnCanvasHierarchyChanged()
- protected override void OnDisable()
- protected override void OnEnable()
- protected override void OnTransformParentChanged()
- public abstract void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
- public override string ToString()

### protected class UnityEngine.EventSystems.PointerInputModule.ButtonState

#### Fields
- private UnityEngine.EventSystems.PointerEventData.InputButton m_Button
- private UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData m_EventData

#### Properties
- public UnityEngine.EventSystems.PointerEventData.InputButton button { get; set; }
- public UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData eventData { get; set; }

#### Constructors
- public PointerInputModule.ButtonState()

### public class UnityEngine.EventSystems.EventTrigger.Entry

#### Fields
- public UnityEngine.EventSystems.EventTrigger.TriggerEvent callback
- public UnityEngine.EventSystems.EventTriggerType eventID

#### Constructors
- public EventTrigger.Entry()

### public delegate UnityEngine.EventSystems.ExecuteEvents.EventFunction<T1>
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ExecuteEvents.EventFunction<T1>(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData)

### public enum UnityEngine.EventSystems.EventHandle
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Unused = 0
- Used = 1

### public class UnityEngine.EventSystems.EventSystem
- Base: UnityEngine.EventSystems.UIBehaviour

#### Fields
- private UnityEngine.EventSystems.BaseInputModule m_CurrentInputModule
- private UnityEngine.GameObject m_CurrentSelected
- private int m_DragThreshold
- private UnityEngine.EventSystems.BaseEventData m_DummyData
- private static System.Collections.Generic.List<UnityEngine.EventSystems.EventSystem> m_EventSystems
- private UnityEngine.GameObject m_FirstSelected
- private bool m_HasFocus
- private bool m_IsTrackingUIToolkitPanels
- private bool m_SelectionGuard
- private bool m_sendNavigationEvents
- private bool m_Started
- private System.Collections.Generic.List<UnityEngine.EventSystems.BaseInputModule> m_SystemInputModules
- private static readonly System.Comparison<UnityEngine.EventSystems.RaycastResult> s_RaycastComparer
- private static UnityEngine.EventSystems.EventSystem.UIToolkitOverrideConfig s_UIToolkitOverride

#### Properties
- public bool alreadySelecting { get; }
- private UnityEngine.EventSystems.BaseEventData baseEventDataCache { get; }
- private bool createUIToolkitPanelGameObjectsOnStart { get; }
- public static UnityEngine.EventSystems.EventSystem current { get; set; }
- public UnityEngine.EventSystems.BaseInputModule currentInputModule { get; }
- public UnityEngine.GameObject currentSelectedGameObject { get; }
- public UnityEngine.GameObject firstSelectedGameObject { get; set; }
- public bool isFocused { get; }
- private bool isUIToolkitActiveEventSystem { get; }
- public UnityEngine.GameObject lastSelectedGameObject { get; }
- public int pixelDragThreshold { get; set; }
- public bool sendNavigationEvents { get; set; }
- private bool sendUIToolkitEvents { get; }

#### Constructors
- protected EventSystem()
- private static EventSystem()

#### Methods
- private void ChangeEventModule(UnityEngine.EventSystems.BaseInputModule module)
- private void CreateUIToolkitPanelGameObject(UnityEngine.UIElements.BaseRuntimePanel panel)
- public bool IsPointerOverGameObject()
- public bool IsPointerOverGameObject(int pointerId)
- protected virtual void OnApplicationFocus(bool hasFocus)
- protected override void OnDisable()
- protected override void OnEnable()
- public void RaycastAll(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults)
- private static int RaycastComparer(UnityEngine.EventSystems.RaycastResult lhs, UnityEngine.EventSystems.RaycastResult rhs)
- public void SetSelectedGameObject(UnityEngine.GameObject selected, UnityEngine.EventSystems.BaseEventData pointer)
- public void SetSelectedGameObject(UnityEngine.GameObject selected)
- public static void SetUITookitEventSystemOverride(UnityEngine.EventSystems.EventSystem activeEventSystem, bool sendEvents = true, bool createPanelGameObjectsOnStart = true)
- protected override void Start()
- private void StartTrackingUIToolkitPanels()
- private void StopTrackingUIToolkitPanels()
- private void TickModules()
- public override string ToString()
- protected virtual void Update()
- public void UpdateModules()

### public class UnityEngine.EventSystems.EventTrigger
- Base: UnityEngine.MonoBehaviour
- Interfaces: UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler

#### Fields
- private System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates

#### Properties
- public System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> delegates { get; set; }
- public System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> triggers { get; set; }

#### Constructors
- protected EventTrigger()

#### Methods
- private void Execute(UnityEngine.EventSystems.EventTriggerType id, UnityEngine.EventSystems.BaseEventData eventData)
- public virtual void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
- public virtual void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
- public virtual void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnDrop(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
- public virtual void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
- public virtual void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
- public virtual void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData)

### public enum UnityEngine.EventSystems.EventTriggerType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BeginDrag = 13
- Cancel = 16
- Deselect = 10
- Drag = 5
- Drop = 6
- EndDrag = 14
- InitializePotentialDrag = 12
- Move = 11
- PointerClick = 4
- PointerDown = 2
- PointerEnter = 0
- PointerExit = 1
- PointerUp = 3
- Scroll = 7
- Select = 9
- Submit = 15
- UpdateSelected = 8

### public static class UnityEngine.EventSystems.ExecuteEvents

#### Fields
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> s_BeginDragHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> s_CancelHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> s_DeselectHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> s_DragHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> s_DropHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> s_EndDragHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> s_InitializePotentialDragHandler
- private static readonly System.Collections.Generic.List<UnityEngine.Transform> s_InternalTransformList
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> s_MoveHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> s_PointerClickHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> s_PointerDownHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> s_PointerEnterHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> s_PointerExitHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> s_PointerMoveHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> s_PointerUpHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> s_ScrollHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> s_SelectHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> s_SubmitHandler
- private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> s_UpdateSelectedHandler

#### Properties
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> beginDragHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> cancelHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> deselectHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> dragHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> dropHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> endDragHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> initializePotentialDrag { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> moveHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> pointerClickHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> pointerDownHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> pointerEnterHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> pointerExitHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> pointerMoveHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> pointerUpHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> scrollHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> selectHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> submitHandler { get; }
- public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> updateSelectedHandler { get; }

#### Constructors
- private static ExecuteEvents()

#### Methods
- public static bool CanHandleEvent<T>(UnityEngine.GameObject go)
- private static void Execute(UnityEngine.EventSystems.IPointerMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.IPointerEnterHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.IPointerExitHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.IPointerDownHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.IPointerUpHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.IPointerClickHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.IInitializePotentialDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.IBeginDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.IDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.IEndDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.IDropHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.IScrollHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.IUpdateSelectedHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.ISelectHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.IDeselectHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.IMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.ISubmitHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- private static void Execute(UnityEngine.EventSystems.ICancelHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
- public static bool Execute<T>(UnityEngine.GameObject target, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor)
- public static UnityEngine.GameObject ExecuteHierarchy<T>(UnityEngine.GameObject root, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction)
- private static void GetEventChain(UnityEngine.GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain)
- public static UnityEngine.GameObject GetEventHandler<T>(UnityEngine.GameObject root)
- private static void GetEventList<T>(UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results)
- private static bool ShouldSendToComponent<T>(UnityEngine.Component component)
- public static T ValidateEventData<T>(UnityEngine.EventSystems.BaseEventData data)

### public enum UnityEngine.EventSystems.PointerEventData.FramePressState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NotChanged = 3
- Pressed = 0
- PressedAndReleased = 2
- Released = 1

### public interface UnityEngine.EventSystems.IBeginDragHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)

### public interface UnityEngine.EventSystems.ICancelHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)

### public interface UnityEngine.EventSystems.IDeselectHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)

### public interface UnityEngine.EventSystems.IDragHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)

### public interface UnityEngine.EventSystems.IDropHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnDrop(UnityEngine.EventSystems.PointerEventData eventData)

### public interface UnityEngine.EventSystems.IEndDragHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)

### public interface UnityEngine.EventSystems.IEventSystemHandler

### public interface UnityEngine.EventSystems.IInitializePotentialDragHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)

### public interface UnityEngine.EventSystems.IMoveHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnMove(UnityEngine.EventSystems.AxisEventData eventData)

### public enum UnityEngine.EventSystems.PointerEventData.InputButton
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Left = 0
- Middle = 2
- Right = 1

### public enum UnityEngine.EventSystems.StandaloneInputModule.InputMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Buttons = 1
- Mouse = 0

### public interface UnityEngine.EventSystems.IPointerClickHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)

### public interface UnityEngine.EventSystems.IPointerDownHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)

### public interface UnityEngine.EventSystems.IPointerEnterHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)

### public interface UnityEngine.EventSystems.IPointerExitHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)

### public interface UnityEngine.EventSystems.IPointerMoveHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData)

### public interface UnityEngine.EventSystems.IPointerUpHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)

### public interface UnityEngine.EventSystems.IScrollHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)

### public interface UnityEngine.EventSystems.ISelectHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)

### public interface UnityEngine.EventSystems.ISubmitHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)

### public interface UnityEngine.EventSystems.IUpdateSelectedHandler
- Interfaces: UnityEngine.EventSystems.IEventSystemHandler

#### Methods
- public void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData)

### public class UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData

#### Fields
- public UnityEngine.EventSystems.PointerEventData buttonData
- public UnityEngine.EventSystems.PointerEventData.FramePressState buttonState

#### Constructors
- public PointerInputModule.MouseButtonEventData()

#### Methods
- public bool PressedThisFrame()
- public bool ReleasedThisFrame()

### protected class UnityEngine.EventSystems.PointerInputModule.MouseState

#### Fields
- private System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons

#### Constructors
- public PointerInputModule.MouseState()

#### Methods
- public bool AnyPressesThisFrame()
- public bool AnyReleasesThisFrame()
- public UnityEngine.EventSystems.PointerInputModule.ButtonState GetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button)
- public void SetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, UnityEngine.EventSystems.PointerEventData data)

### public enum UnityEngine.EventSystems.MoveDirection
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Down = 3
- Left = 0
- None = 4
- Right = 2
- Up = 1

### public class UnityEngine.EventSystems.Physics2DRaycaster
- Base: UnityEngine.EventSystems.PhysicsRaycaster

#### Fields
- private UnityEngine.RaycastHit2D[] m_Hits

#### Constructors
- protected Physics2DRaycaster()

#### Methods
- public override void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)

### public class UnityEngine.EventSystems.PhysicsRaycaster
- Base: UnityEngine.EventSystems.BaseRaycaster

#### Fields
- protected static const int kNoEventMaskSet
- protected UnityEngine.Camera m_EventCamera
- protected UnityEngine.LayerMask m_EventMask
- private UnityEngine.RaycastHit[] m_Hits
- protected int m_LastMaxRayIntersections
- protected int m_MaxRayIntersections

#### Properties
- public int depth { get; }
- public UnityEngine.Camera eventCamera { get; }
- public UnityEngine.LayerMask eventMask { get; set; }
- public int finalEventMask { get; }
- public int maxRayIntersections { get; set; }

#### Constructors
- protected PhysicsRaycaster()

#### Methods
- protected bool ComputeRayAndDistance(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane)
- public override void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)

### public class UnityEngine.EventSystems.PointerEventData
- Base: UnityEngine.EventSystems.BaseEventData

#### Fields
- private float <altitudeAngle>k__BackingField
- private float <azimuthAngle>k__BackingField
- private UnityEngine.EventSystems.PointerEventData.InputButton <button>k__BackingField
- private int <clickCount>k__BackingField
- private float <clickTime>k__BackingField
- private UnityEngine.Vector2 <delta>k__BackingField
- private int <displayIndex>k__BackingField
- private bool <dragging>k__BackingField
- private bool <eligibleForClick>k__BackingField
- private bool <fullyExited>k__BackingField
- private UnityEngine.GameObject <lastPress>k__BackingField
- private UnityEngine.PenStatus <penStatus>k__BackingField
- private UnityEngine.GameObject <pointerClick>k__BackingField
- private UnityEngine.EventSystems.RaycastResult <pointerCurrentRaycast>k__BackingField
- private UnityEngine.GameObject <pointerDrag>k__BackingField
- private UnityEngine.GameObject <pointerEnter>k__BackingField
- private int <pointerId>k__BackingField
- private UnityEngine.EventSystems.RaycastResult <pointerPressRaycast>k__BackingField
- private UnityEngine.Vector2 <position>k__BackingField
- private UnityEngine.Vector2 <pressPosition>k__BackingField
- private float <pressure>k__BackingField
- private UnityEngine.Vector2 <radius>k__BackingField
- private UnityEngine.Vector2 <radiusVariance>k__BackingField
- private UnityEngine.GameObject <rawPointerPress>k__BackingField
- private bool <reentered>k__BackingField
- private UnityEngine.Vector2 <scrollDelta>k__BackingField
- private float <tangentialPressure>k__BackingField
- private UnityEngine.Vector2 <tilt>k__BackingField
- private float <twist>k__BackingField
- private bool <useDragThreshold>k__BackingField
- private UnityEngine.Vector3 <worldNormal>k__BackingField
- private UnityEngine.Vector3 <worldPosition>k__BackingField
- public System.Collections.Generic.List<UnityEngine.GameObject> hovered
- private UnityEngine.GameObject m_PointerPress

#### Properties
- public float altitudeAngle { get; set; }
- public float azimuthAngle { get; set; }
- public UnityEngine.EventSystems.PointerEventData.InputButton button { get; set; }
- public int clickCount { get; set; }
- public float clickTime { get; set; }
- public UnityEngine.Vector2 delta { get; set; }
- public int displayIndex { get; set; }
- public bool dragging { get; set; }
- public bool eligibleForClick { get; set; }
- public UnityEngine.Camera enterEventCamera { get; }
- public bool fullyExited { get; set; }
- public UnityEngine.GameObject lastPress { get; private set; }
- public UnityEngine.PenStatus penStatus { get; set; }
- public UnityEngine.GameObject pointerClick { get; set; }
- public UnityEngine.EventSystems.RaycastResult pointerCurrentRaycast { get; set; }
- public UnityEngine.GameObject pointerDrag { get; set; }
- public UnityEngine.GameObject pointerEnter { get; set; }
- public int pointerId { get; set; }
- public UnityEngine.GameObject pointerPress { get; set; }
- public UnityEngine.EventSystems.RaycastResult pointerPressRaycast { get; set; }
- public UnityEngine.Vector2 position { get; set; }
- public UnityEngine.Camera pressEventCamera { get; }
- public UnityEngine.Vector2 pressPosition { get; set; }
- public float pressure { get; set; }
- public UnityEngine.Vector2 radius { get; set; }
- public UnityEngine.Vector2 radiusVariance { get; set; }
- public UnityEngine.GameObject rawPointerPress { get; set; }
- public bool reentered { get; set; }
- public UnityEngine.Vector2 scrollDelta { get; set; }
- public float tangentialPressure { get; set; }
- public UnityEngine.Vector2 tilt { get; set; }
- public float twist { get; set; }
- public bool useDragThreshold { get; set; }
- public UnityEngine.Vector3 worldNormal { get; set; }
- public UnityEngine.Vector3 worldPosition { get; set; }

#### Constructors
- public PointerEventData(UnityEngine.EventSystems.EventSystem eventSystem)

#### Methods
- public bool IsPointerMoving()
- public bool IsScrolling()
- public override string ToString()

### public class UnityEngine.EventSystems.PointerInputModule
- Base: UnityEngine.EventSystems.BaseInputModule

#### Fields
- public static const int kFakeTouchesId
- public static const int kMouseLeftId
- public static const int kMouseMiddleId
- public static const int kMouseRightId
- private readonly UnityEngine.EventSystems.PointerInputModule.MouseState m_MouseState
- protected System.Collections.Generic.Dictionary<int, UnityEngine.EventSystems.PointerEventData> m_PointerData

#### Constructors
- protected PointerInputModule()

#### Methods
- protected void ClearSelection()
- protected void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to)
- protected void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent)
- protected UnityEngine.EventSystems.PointerEventData GetLastPointerEventData(int id)
- protected virtual UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData()
- protected virtual UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData(int id)
- protected bool GetPointerData(int id, out UnityEngine.EventSystems.PointerEventData data, bool create)
- protected UnityEngine.EventSystems.PointerEventData GetTouchPointerEventData(UnityEngine.Touch input, out bool pressed, out bool released)
- public override bool IsPointerOverGameObject(int pointerId)
- protected virtual void ProcessDrag(UnityEngine.EventSystems.PointerEventData pointerEvent)
- protected virtual void ProcessMove(UnityEngine.EventSystems.PointerEventData pointerEvent)
- protected void RemovePointerData(UnityEngine.EventSystems.PointerEventData data)
- private static bool ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, float threshold, bool useDragThreshold)
- protected UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(int buttonId)
- public override string ToString()

### public static class UnityEngine.EventSystems.RaycasterManager

#### Fields
- private static readonly System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> s_Raycasters

#### Constructors
- private static RaycasterManager()

#### Methods
- internal static void AddRaycaster(UnityEngine.EventSystems.BaseRaycaster baseRaycaster)
- public static System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters()
- internal static void RemoveRaycasters(UnityEngine.EventSystems.BaseRaycaster baseRaycaster)

### private class UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparer
- Interfaces: System.Collections.Generic.IComparer<UnityEngine.RaycastHit>

#### Fields
- public static UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparer instance

#### Constructors
- public PhysicsRaycaster.RaycastHitComparer()
- private static PhysicsRaycaster.RaycastHitComparer()

#### Methods
- public int Compare(UnityEngine.RaycastHit x, UnityEngine.RaycastHit y)

### public struct UnityEngine.EventSystems.RaycastResult

#### Fields
- public int depth
- public int displayIndex
- public float distance
- public float index
- public UnityEngine.EventSystems.BaseRaycaster module
- private UnityEngine.GameObject m_GameObject
- public UnityEngine.Vector2 screenPosition
- public int sortingGroupID
- public int sortingGroupOrder
- public int sortingLayer
- public int sortingOrder
- public UnityEngine.Vector3 worldNormal
- public UnityEngine.Vector3 worldPosition

#### Properties
- public UnityEngine.GameObject gameObject { get; set; }
- public bool isValid { get; }

#### Methods
- public void Clear()
- public override string ToString()

### public class UnityEngine.EventSystems.StandaloneInputModule
- Base: UnityEngine.EventSystems.PointerInputModule

#### Fields
- private static const float doubleClickTime
- private string m_CancelButton
- private int m_ConsecutiveMoveCount
- private UnityEngine.GameObject m_CurrentFocusedGameObject
- private bool m_ForceModuleActive
- private string m_HorizontalAxis
- private float m_InputActionsPerSecond
- private UnityEngine.EventSystems.PointerEventData m_InputPointerEvent
- private UnityEngine.Vector2 m_LastMousePosition
- private UnityEngine.Vector2 m_LastMoveVector
- private UnityEngine.Vector2 m_MousePosition
- private float m_PrevActionTime
- private float m_RepeatDelay
- private string m_SubmitButton
- private string m_VerticalAxis

#### Properties
- public bool allowActivationOnMobileDevice { get; set; }
- public string cancelButton { get; set; }
- public bool forceModuleActive { get; set; }
- public string horizontalAxis { get; set; }
- public float inputActionsPerSecond { get; set; }
- public UnityEngine.EventSystems.StandaloneInputModule.InputMode inputMode { get; }
- public float repeatDelay { get; set; }
- public string submitButton { get; set; }
- public string verticalAxis { get; set; }

#### Constructors
- protected StandaloneInputModule()

#### Methods
- public override void ActivateModule()
- public override void DeactivateModule()
- protected virtual bool ForceAutoSelect()
- protected UnityEngine.GameObject GetCurrentFocusedGameObject()
- private UnityEngine.Vector2 GetRawMoveVector()
- public override void Process()
- protected void ProcessMouseEvent()
- protected void ProcessMouseEvent(int id)
- protected void ProcessMousePress(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData data)
- private bool ProcessTouchEvents()
- protected void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released)
- private void ReleaseMouse(UnityEngine.EventSystems.PointerEventData pointerEvent, UnityEngine.GameObject currentOverGo)
- protected bool SendMoveEventToSelectedObject()
- protected bool SendSubmitEventToSelectedObject()
- protected bool SendUpdateEventToSelectedObject()
- public override bool ShouldActivateModule()
- private bool ShouldIgnoreEventsOnNoFocus()
- public override void UpdateModule()

### public class UnityEngine.EventSystems.TouchInputModule
- Base: UnityEngine.EventSystems.PointerInputModule

#### Fields
- private bool m_ForceModuleActive
- private UnityEngine.EventSystems.PointerEventData m_InputPointerEvent
- private UnityEngine.Vector2 m_LastMousePosition
- private UnityEngine.Vector2 m_MousePosition

#### Properties
- public bool allowActivationOnStandalone { get; set; }
- public bool forceModuleActive { get; set; }

#### Constructors
- protected TouchInputModule()

#### Methods
- public override void DeactivateModule()
- private void FakeTouches()
- public override bool IsModuleSupported()
- public override void Process()
- private void ProcessTouchEvents()
- protected void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released)
- public override bool ShouldActivateModule()
- public override string ToString()
- public override void UpdateModule()
- private bool UseFakeInput()

### public class UnityEngine.EventSystems.EventTrigger.TriggerEvent
- Base: UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public EventTrigger.TriggerEvent()

### public class UnityEngine.EventSystems.UIBehaviour
- Base: UnityEngine.MonoBehaviour

#### Constructors
- protected UIBehaviour()

#### Methods
- protected virtual void Awake()
- public virtual bool IsActive()
- public bool IsDestroyed()
- protected virtual void OnBeforeTransformParentChanged()
- protected virtual void OnCanvasGroupChanged()
- protected virtual void OnCanvasHierarchyChanged()
- protected virtual void OnDestroy()
- protected virtual void OnDidApplyAnimationProperties()
- protected virtual void OnDisable()
- protected virtual void OnEnable()
- protected virtual void OnRectTransformDimensionsChange()
- protected virtual void OnTransformParentChanged()
- protected virtual void Start()

### private struct UnityEngine.EventSystems.EventSystem.UIToolkitOverrideConfig

#### Fields
- public UnityEngine.EventSystems.EventSystem activeEventSystem
- public bool createPanelGameObjectsOnStart
- public bool sendEvents

## Namespace: UnityEngine.UI

### private class UnityEngine.UI.GraphicRaycaster.<>c

#### Fields
- public static readonly UnityEngine.UI.GraphicRaycaster.<>c <>9
- public static System.Comparison<UnityEngine.UI.Graphic> <>9__27_0

#### Constructors
- private static GraphicRaycaster.<>c()
- public GraphicRaycaster.<>c()

#### Methods
- internal int <Raycast>b__27_0(UnityEngine.UI.Graphic g1, UnityEngine.UI.Graphic g2)

### private class UnityEngine.UI.LayoutRebuilder.<>c

#### Fields
- public static readonly UnityEngine.UI.LayoutRebuilder.<>c <>9
- public static System.Predicate<UnityEngine.Component> <>9__10_0
- public static UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_0
- public static UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_1
- public static UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_2
- public static UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_3

#### Constructors
- private static LayoutRebuilder.<>c()
- public LayoutRebuilder.<>c()

#### Methods
- internal UnityEngine.UI.LayoutRebuilder <.cctor>b__5_0()
- internal void <.cctor>b__5_1(UnityEngine.UI.LayoutRebuilder x)
- internal void <Rebuild>b__12_0(UnityEngine.Component e)
- internal void <Rebuild>b__12_1(UnityEngine.Component e)
- internal void <Rebuild>b__12_2(UnityEngine.Component e)
- internal void <Rebuild>b__12_3(UnityEngine.Component e)
- internal bool <StripDisabledBehavioursFromList>b__10_0(UnityEngine.Component e)

### private class UnityEngine.UI.LayoutUtility.<>c

#### Fields
- public static readonly UnityEngine.UI.LayoutUtility.<>c <>9
- public static System.Func<UnityEngine.UI.ILayoutElement, float> <>9__3_0
- public static System.Func<UnityEngine.UI.ILayoutElement, float> <>9__4_0
- public static System.Func<UnityEngine.UI.ILayoutElement, float> <>9__4_1
- public static System.Func<UnityEngine.UI.ILayoutElement, float> <>9__5_0
- public static System.Func<UnityEngine.UI.ILayoutElement, float> <>9__6_0
- public static System.Func<UnityEngine.UI.ILayoutElement, float> <>9__7_0
- public static System.Func<UnityEngine.UI.ILayoutElement, float> <>9__7_1
- public static System.Func<UnityEngine.UI.ILayoutElement, float> <>9__8_0

#### Constructors
- private static LayoutUtility.<>c()
- public LayoutUtility.<>c()

#### Methods
- internal float <GetFlexibleHeight>b__8_0(UnityEngine.UI.ILayoutElement e)
- internal float <GetFlexibleWidth>b__5_0(UnityEngine.UI.ILayoutElement e)
- internal float <GetMinHeight>b__6_0(UnityEngine.UI.ILayoutElement e)
- internal float <GetMinWidth>b__3_0(UnityEngine.UI.ILayoutElement e)
- internal float <GetPreferredHeight>b__7_0(UnityEngine.UI.ILayoutElement e)
- internal float <GetPreferredHeight>b__7_1(UnityEngine.UI.ILayoutElement e)
- internal float <GetPreferredWidth>b__4_0(UnityEngine.UI.ILayoutElement e)
- internal float <GetPreferredWidth>b__4_1(UnityEngine.UI.ILayoutElement e)

### private class UnityEngine.UI.ToggleGroup.<>c

#### Fields
- public static readonly UnityEngine.UI.ToggleGroup.<>c <>9
- public static System.Predicate<UnityEngine.UI.Toggle> <>9__13_0
- public static System.Func<UnityEngine.UI.Toggle, bool> <>9__14_0

#### Constructors
- private static ToggleGroup.<>c()
- public ToggleGroup.<>c()

#### Methods
- internal bool <ActiveToggles>b__14_0(UnityEngine.UI.Toggle x)
- internal bool <AnyTogglesOn>b__13_0(UnityEngine.UI.Toggle x)

### private class UnityEngine.UI.Dropdown.<>c__DisplayClass63_0

#### Fields
- public UnityEngine.UI.Dropdown <>4__this
- public UnityEngine.UI.Dropdown.DropdownItem item

#### Constructors
- public Dropdown.<>c__DisplayClass63_0()

#### Methods
- internal void <Show>b__0(bool x)

### private class UnityEngine.UI.InputField.<CaretBlink>d__170
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public UnityEngine.UI.InputField <>4__this

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public InputField.<CaretBlink>d__170(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class UnityEngine.UI.Scrollbar.<ClickRepeat>d__58
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public UnityEngine.UI.Scrollbar <>4__this
- public UnityEngine.Camera camera
- public UnityEngine.Vector2 screenPosition

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public Scrollbar.<ClickRepeat>d__58(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class UnityEngine.UI.Dropdown.<DelayedDestroyDropdownList>d__75
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public UnityEngine.UI.Dropdown <>4__this
- public float delay

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public Dropdown.<DelayedDestroyDropdownList>d__75(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class UnityEngine.UI.LayoutGroup.<DelayedSetDirty>d__56
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public UnityEngine.RectTransform rectTransform

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public LayoutGroup.<DelayedSetDirty>d__56(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class UnityEngine.UI.InputField.<MouseDragOutsideRect>d__194
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public UnityEngine.UI.InputField <>4__this
- public UnityEngine.EventSystems.PointerEventData eventData

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public InputField.<MouseDragOutsideRect>d__194(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class UnityEngine.UI.Button.<OnFinishSubmit>d__9
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public UnityEngine.UI.Button <>4__this
- private float <elapsedTime>5__3
- private float <fadeTime>5__2

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public Button.<OnFinishSubmit>d__9(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### public class UnityEngine.UI.AnimationTriggers

#### Fields
- private static const string kDefaultDisabledAnimName
- private static const string kDefaultHighlightedAnimName
- private static const string kDefaultNormalAnimName
- private static const string kDefaultPressedAnimName
- private static const string kDefaultSelectedAnimName
- private string m_DisabledTrigger
- private string m_HighlightedTrigger
- private string m_NormalTrigger
- private string m_PressedTrigger
- private string m_SelectedTrigger

#### Properties
- public string disabledTrigger { get; set; }
- public string highlightedTrigger { get; set; }
- public string normalTrigger { get; set; }
- public string pressedTrigger { get; set; }
- public string selectedTrigger { get; set; }

#### Constructors
- public AnimationTriggers()

### public enum UnityEngine.UI.AspectRatioFitter.AspectMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- EnvelopeParent = 4
- FitInParent = 3
- HeightControlsWidth = 2
- None = 0
- WidthControlsHeight = 1

### public class UnityEngine.UI.AspectRatioFitter
- Base: UnityEngine.EventSystems.UIBehaviour
- Interfaces: UnityEngine.UI.ILayoutSelfController, UnityEngine.UI.ILayoutController

#### Fields
- private UnityEngine.UI.AspectRatioFitter.AspectMode m_AspectMode
- private float m_AspectRatio
- private bool m_DelayedSetDirty
- private bool m_DoesParentExist
- private UnityEngine.RectTransform m_Rect
- private UnityEngine.DrivenRectTransformTracker m_Tracker

#### Properties
- public UnityEngine.UI.AspectRatioFitter.AspectMode aspectMode { get; set; }
- public float aspectRatio { get; set; }
- private UnityEngine.RectTransform rectTransform { get; }

#### Constructors
- protected AspectRatioFitter()

#### Methods
- private bool DoesParentExists()
- private UnityEngine.Vector2 GetParentSize()
- private float GetSizeDeltaToProduceSize(float size, int axis)
- public bool IsAspectModeValid()
- public bool IsComponentValidOnObject()
- protected override void OnDisable()
- protected override void OnEnable()
- protected override void OnRectTransformDimensionsChange()
- protected override void OnTransformParentChanged()
- protected void SetDirty()
- public virtual void SetLayoutHorizontal()
- public virtual void SetLayoutVertical()
- protected override void Start()
- protected virtual void Update()
- private void UpdateRect()

### public enum UnityEngine.UI.GridLayoutGroup.Axis
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Horizontal = 0
- Vertical = 1

### private enum UnityEngine.UI.Scrollbar.Axis
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Horizontal = 0
- Vertical = 1

### private enum UnityEngine.UI.Slider.Axis
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Horizontal = 0
- Vertical = 1

### public class UnityEngine.UI.BaseMeshEffect
- Base: UnityEngine.EventSystems.UIBehaviour
- Interfaces: UnityEngine.UI.IMeshModifier

#### Fields
- private UnityEngine.UI.Graphic m_Graphic

#### Properties
- protected UnityEngine.UI.Graphic graphic { get; }

#### Constructors
- protected BaseMeshEffect()

#### Methods
- public virtual void ModifyMesh(UnityEngine.Mesh mesh)
- public abstract void ModifyMesh(UnityEngine.UI.VertexHelper vh)
- protected override void OnDidApplyAnimationProperties()
- protected override void OnDisable()
- protected override void OnEnable()

### public class UnityEngine.UI.BaseVertexEffect

#### Constructors
- protected BaseVertexEffect()

#### Methods
- public abstract void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices)

### public enum UnityEngine.UI.GraphicRaycaster.BlockingObjects
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- All = 3
- None = 0
- ThreeD = 2
- TwoD = 1

### public class UnityEngine.UI.Button
- Base: UnityEngine.UI.Selectable
- Interfaces: UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.ISubmitHandler

#### Fields
- private UnityEngine.UI.Button.ButtonClickedEvent m_OnClick

#### Properties
- public UnityEngine.UI.Button.ButtonClickedEvent onClick { get; set; }

#### Constructors
- protected Button()

#### Methods
- private System.Collections.IEnumerator OnFinishSubmit()
- public virtual void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
- private void Press()

### public class UnityEngine.UI.Button.ButtonClickedEvent
- Base: UnityEngine.Events.UnityEvent
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public Button.ButtonClickedEvent()

### public class UnityEngine.UI.CanvasScaler
- Base: UnityEngine.EventSystems.UIBehaviour

#### Fields
- private static const float kLogBase
- private UnityEngine.Canvas m_Canvas
- protected float m_DefaultSpriteDPI
- protected float m_DynamicPixelsPerUnit
- protected float m_FallbackScreenDPI
- protected float m_MatchWidthOrHeight
- protected UnityEngine.UI.CanvasScaler.Unit m_PhysicalUnit
- protected bool m_PresetInfoIsWorld
- private float m_PrevReferencePixelsPerUnit
- private float m_PrevScaleFactor
- protected float m_ReferencePixelsPerUnit
- protected UnityEngine.Vector2 m_ReferenceResolution
- protected float m_ScaleFactor
- protected UnityEngine.UI.CanvasScaler.ScreenMatchMode m_ScreenMatchMode
- private UnityEngine.UI.CanvasScaler.ScaleMode m_UiScaleMode

#### Properties
- public float defaultSpriteDPI { get; set; }
- public float dynamicPixelsPerUnit { get; set; }
- public float fallbackScreenDPI { get; set; }
- public float matchWidthOrHeight { get; set; }
- public UnityEngine.UI.CanvasScaler.Unit physicalUnit { get; set; }
- public float referencePixelsPerUnit { get; set; }
- public UnityEngine.Vector2 referenceResolution { get; set; }
- public float scaleFactor { get; set; }
- public UnityEngine.UI.CanvasScaler.ScreenMatchMode screenMatchMode { get; set; }
- public UnityEngine.UI.CanvasScaler.ScaleMode uiScaleMode { get; set; }

#### Constructors
- protected CanvasScaler()

#### Methods
- private void Canvas_preWillRenderCanvases()
- protected virtual void Handle()
- protected virtual void HandleConstantPhysicalSize()
- protected virtual void HandleConstantPixelSize()
- protected virtual void HandleScaleWithScreenSize()
- protected virtual void HandleWorldCanvas()
- protected override void OnDisable()
- protected override void OnEnable()
- protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
- protected void SetScaleFactor(float scaleFactor)

### public enum UnityEngine.UI.CanvasUpdate
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LatePreRender = 4
- Layout = 1
- MaxUpdateValue = 5
- PostLayout = 2
- Prelayout = 0
- PreRender = 3

### public class UnityEngine.UI.CanvasUpdateRegistry

#### Fields
- private string[] m_CanvasUpdateProfilerStrings
- private static const string m_CullingUpdateProfilerString
- private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue
- private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue
- private bool m_PerformingGraphicUpdate
- private bool m_PerformingLayoutUpdate
- private static UnityEngine.UI.CanvasUpdateRegistry s_Instance
- private static readonly System.Comparison<UnityEngine.UI.ICanvasElement> s_SortLayoutFunction

#### Properties
- public static UnityEngine.UI.CanvasUpdateRegistry instance { get; }

#### Constructors
- protected CanvasUpdateRegistry()
- private static CanvasUpdateRegistry()

#### Methods
- private void CleanInvalidItems()
- public static void DisableCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element)
- private void InternalDisableCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
- private void InternalDisableCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
- private bool InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
- private bool InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
- private void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
- private void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
- public static bool IsRebuildingGraphics()
- public static bool IsRebuildingLayout()
- private bool ObjectValidForUpdate(UnityEngine.UI.ICanvasElement element)
- private static int ParentCount(UnityEngine.Transform child)
- private void PerformUpdate()
- public static void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
- public static void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
- private static int SortLayoutList(UnityEngine.UI.ICanvasElement x, UnityEngine.UI.ICanvasElement y)
- public static bool TryRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
- public static bool TryRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
- public static void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element)

### public enum UnityEngine.UI.InputField.CharacterValidation
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Alphanumeric = 3
- Decimal = 2
- EmailAddress = 5
- Integer = 1
- Name = 4
- None = 0

### public class UnityEngine.UI.ClipperRegistry

#### Fields
- private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers
- private static UnityEngine.UI.ClipperRegistry s_Instance

#### Properties
- public static UnityEngine.UI.ClipperRegistry instance { get; }

#### Constructors
- protected ClipperRegistry()

#### Methods
- public void Cull()
- public static void Disable(UnityEngine.UI.IClipper c)
- public static void Register(UnityEngine.UI.IClipper c)
- public static void Unregister(UnityEngine.UI.IClipper c)

### public static class UnityEngine.UI.Clipping

#### Methods
- public static UnityEngine.Rect FindCullAndClipWorldRect(System.Collections.Generic.List<UnityEngine.UI.RectMask2D> rectMaskParents, out bool validRect)

### public struct UnityEngine.UI.ColorBlock
- Interfaces: System.IEquatable<UnityEngine.UI.ColorBlock>

#### Fields
- public static UnityEngine.UI.ColorBlock defaultColorBlock
- private float m_ColorMultiplier
- private UnityEngine.Color m_DisabledColor
- private float m_FadeDuration
- private UnityEngine.Color m_HighlightedColor
- private UnityEngine.Color m_NormalColor
- private UnityEngine.Color m_PressedColor
- private UnityEngine.Color m_SelectedColor

#### Properties
- public float colorMultiplier { get; set; }
- public UnityEngine.Color disabledColor { get; set; }
- public float fadeDuration { get; set; }
- public UnityEngine.Color highlightedColor { get; set; }
- public UnityEngine.Color normalColor { get; set; }
- public UnityEngine.Color pressedColor { get; set; }
- public UnityEngine.Color selectedColor { get; set; }

#### Constructors
- private static ColorBlock()

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.UI.ColorBlock other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2)
- public static bool op_Inequality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2)

### public enum UnityEngine.UI.GridLayoutGroup.Constraint
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FixedColumnCount = 1
- FixedRowCount = 2
- Flexible = 0

### public class UnityEngine.UI.ContentSizeFitter
- Base: UnityEngine.EventSystems.UIBehaviour
- Interfaces: UnityEngine.UI.ILayoutSelfController, UnityEngine.UI.ILayoutController

#### Fields
- protected UnityEngine.UI.ContentSizeFitter.FitMode m_HorizontalFit
- private UnityEngine.RectTransform m_Rect
- private UnityEngine.DrivenRectTransformTracker m_Tracker
- protected UnityEngine.UI.ContentSizeFitter.FitMode m_VerticalFit

#### Properties
- public UnityEngine.UI.ContentSizeFitter.FitMode horizontalFit { get; set; }
- private UnityEngine.RectTransform rectTransform { get; }
- public UnityEngine.UI.ContentSizeFitter.FitMode verticalFit { get; set; }

#### Constructors
- protected ContentSizeFitter()

#### Methods
- private void HandleSelfFittingAlongAxis(int axis)
- protected override void OnDisable()
- protected override void OnEnable()
- protected override void OnRectTransformDimensionsChange()
- protected void SetDirty()
- public virtual void SetLayoutHorizontal()
- public virtual void SetLayoutVertical()

### public enum UnityEngine.UI.InputField.ContentType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Alphanumeric = 4
- Autocorrected = 1
- Custom = 9
- DecimalNumber = 3
- EmailAddress = 6
- IntegerNumber = 2
- Name = 5
- Password = 7
- Pin = 8
- Standard = 0

### public enum UnityEngine.UI.GridLayoutGroup.Corner
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LowerLeft = 2
- LowerRight = 3
- UpperLeft = 0
- UpperRight = 1

### public class UnityEngine.UI.MaskableGraphic.CullStateChangedEvent
- Base: UnityEngine.Events.UnityEvent<bool>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public MaskableGraphic.CullStateChangedEvent()

### public static class UnityEngine.UI.DefaultControls

#### Fields
- private static const float kThickHeight
- private static const float kThinHeight
- private static const float kWidth
- private static UnityEngine.UI.DefaultControls.IFactoryControls m_CurrentFactory
- private static UnityEngine.Color s_DefaultSelectableColor
- private static UnityEngine.Vector2 s_ImageElementSize
- private static UnityEngine.Color s_PanelColor
- private static UnityEngine.Color s_TextColor
- private static UnityEngine.Vector2 s_ThickElementSize
- private static UnityEngine.Vector2 s_ThinElementSize

#### Properties
- public static UnityEngine.UI.DefaultControls.IFactoryControls factory { get; }

#### Constructors
- private static DefaultControls()

#### Methods
- public static UnityEngine.GameObject CreateButton(UnityEngine.UI.DefaultControls.Resources resources)
- public static UnityEngine.GameObject CreateDropdown(UnityEngine.UI.DefaultControls.Resources resources)
- public static UnityEngine.GameObject CreateImage(UnityEngine.UI.DefaultControls.Resources resources)
- public static UnityEngine.GameObject CreateInputField(UnityEngine.UI.DefaultControls.Resources resources)
- public static UnityEngine.GameObject CreatePanel(UnityEngine.UI.DefaultControls.Resources resources)
- public static UnityEngine.GameObject CreateRawImage(UnityEngine.UI.DefaultControls.Resources resources)
- public static UnityEngine.GameObject CreateScrollbar(UnityEngine.UI.DefaultControls.Resources resources)
- public static UnityEngine.GameObject CreateScrollView(UnityEngine.UI.DefaultControls.Resources resources)
- public static UnityEngine.GameObject CreateSlider(UnityEngine.UI.DefaultControls.Resources resources)
- public static UnityEngine.GameObject CreateText(UnityEngine.UI.DefaultControls.Resources resources)
- public static UnityEngine.GameObject CreateToggle(UnityEngine.UI.DefaultControls.Resources resources)
- private static UnityEngine.GameObject CreateUIElementRoot(string name, UnityEngine.Vector2 size, params System.Type[] components)
- private static UnityEngine.GameObject CreateUIObject(string name, UnityEngine.GameObject parent, params System.Type[] components)
- private static void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider)
- private static void SetDefaultTextValues(UnityEngine.UI.Text lbl)
- private static void SetLayerRecursively(UnityEngine.GameObject go, int layer)
- private static void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent)

### private class UnityEngine.UI.DefaultControls.DefaultRuntimeFactory
- Interfaces: UnityEngine.UI.DefaultControls.IFactoryControls

#### Fields
- public static UnityEngine.UI.DefaultControls.IFactoryControls Default

#### Constructors
- public DefaultControls.DefaultRuntimeFactory()
- private static DefaultControls.DefaultRuntimeFactory()

#### Methods
- public UnityEngine.GameObject CreateGameObject(string name, params System.Type[] components)

### public enum UnityEngine.UI.Scrollbar.Direction
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BottomToTop = 2
- LeftToRight = 0
- RightToLeft = 1
- TopToBottom = 3

### public enum UnityEngine.UI.Slider.Direction
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BottomToTop = 2
- LeftToRight = 0
- RightToLeft = 1
- TopToBottom = 3

### public class UnityEngine.UI.Dropdown
- Base: UnityEngine.UI.Selectable
- Interfaces: UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler

#### Fields
- private static const int kHighSortingLayer
- private float m_AlphaFadeSpeed
- private UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.FloatTween> m_AlphaTweenRunner
- private UnityEngine.GameObject m_Blocker
- private UnityEngine.UI.Image m_CaptionImage
- private UnityEngine.UI.Text m_CaptionText
- private UnityEngine.GameObject m_Dropdown
- private UnityEngine.UI.Image m_ItemImage
- private System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> m_Items
- private UnityEngine.UI.Text m_ItemText
- private UnityEngine.UI.Dropdown.DropdownEvent m_OnValueChanged
- private UnityEngine.UI.Dropdown.OptionDataList m_Options
- private UnityEngine.RectTransform m_Template
- private int m_Value
- private static UnityEngine.UI.Dropdown.OptionData s_NoOptionData
- private bool validTemplate

#### Properties
- public float alphaFadeSpeed { get; set; }
- public UnityEngine.UI.Image captionImage { get; set; }
- public UnityEngine.UI.Text captionText { get; set; }
- public UnityEngine.UI.Image itemImage { get; set; }
- public UnityEngine.UI.Text itemText { get; set; }
- public UnityEngine.UI.Dropdown.DropdownEvent onValueChanged { get; set; }
- public System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options { get; set; }
- public UnityEngine.RectTransform template { get; set; }
- public int value { get; set; }

#### Constructors
- protected Dropdown()
- private static Dropdown()

#### Methods
- private UnityEngine.UI.Dropdown.DropdownItem AddItem(UnityEngine.UI.Dropdown.OptionData data, bool selected, UnityEngine.UI.Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items)
- public void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options)
- public void AddOptions(System.Collections.Generic.List<string> options)
- public void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options)
- private void AlphaFadeList(float duration, float alpha)
- private void AlphaFadeList(float duration, float start, float end)
- protected override void Awake()
- public void ClearOptions()
- protected virtual UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas)
- protected virtual UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template)
- protected virtual UnityEngine.UI.Dropdown.DropdownItem CreateItem(UnityEngine.UI.Dropdown.DropdownItem itemTemplate)
- private System.Collections.IEnumerator DelayedDestroyDropdownList(float delay)
- protected virtual void DestroyBlocker(UnityEngine.GameObject blocker)
- protected virtual void DestroyDropdownList(UnityEngine.GameObject dropdownList)
- protected virtual void DestroyItem(UnityEngine.UI.Dropdown.DropdownItem item)
- private static T GetOrAddComponent<T>(UnityEngine.GameObject go)
- public void Hide()
- private void ImmediateDestroyDropdownList()
- public virtual void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
- protected override void OnDisable()
- public virtual void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
- private void OnSelectItem(UnityEngine.UI.Toggle toggle)
- public virtual void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
- public void RefreshShownValue()
- private void Set(int value, bool sendCallback = true)
- private void SetAlpha(float alpha)
- private void SetupTemplate(UnityEngine.Canvas rootCanvas)
- public void SetValueWithoutNotify(int input)
- public void Show()
- protected override void Start()

### public class UnityEngine.UI.Dropdown.DropdownEvent
- Base: UnityEngine.Events.UnityEvent<int>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public Dropdown.DropdownEvent()

### protected internal class UnityEngine.UI.Dropdown.DropdownItem
- Base: UnityEngine.MonoBehaviour
- Interfaces: UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler

#### Fields
- private UnityEngine.UI.Image m_Image
- private UnityEngine.RectTransform m_RectTransform
- private UnityEngine.UI.Text m_Text
- private UnityEngine.UI.Toggle m_Toggle

#### Properties
- public UnityEngine.UI.Image image { get; set; }
- public UnityEngine.RectTransform rectTransform { get; set; }
- public UnityEngine.UI.Text text { get; set; }
- public UnityEngine.UI.Toggle toggle { get; set; }

#### Constructors
- public Dropdown.DropdownItem()

#### Methods
- public virtual void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
- public virtual void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)

### protected enum UnityEngine.UI.InputField.EditState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Continue = 0
- Finish = 1

### public class UnityEngine.UI.InputField.EndEditEvent
- Base: UnityEngine.Events.UnityEvent<string>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public InputField.EndEditEvent()

### public enum UnityEngine.UI.Image.FillMethod
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Horizontal = 0
- Radial180 = 3
- Radial360 = 4
- Radial90 = 2
- Vertical = 1

### public enum UnityEngine.UI.ContentSizeFitter.FitMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- MinSize = 1
- PreferredSize = 2
- Unconstrained = 0

### public class UnityEngine.UI.FontData
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Fields
- private bool m_AlignByGeometry
- private UnityEngine.TextAnchor m_Alignment
- private bool m_BestFit
- private UnityEngine.Font m_Font
- private int m_FontSize
- private UnityEngine.FontStyle m_FontStyle
- private UnityEngine.HorizontalWrapMode m_HorizontalOverflow
- private float m_LineSpacing
- private int m_MaxSize
- private int m_MinSize
- private bool m_RichText
- private UnityEngine.VerticalWrapMode m_VerticalOverflow

#### Properties
- public bool alignByGeometry { get; set; }
- public UnityEngine.TextAnchor alignment { get; set; }
- public bool bestFit { get; set; }
- public static UnityEngine.UI.FontData defaultFontData { get; }
- public UnityEngine.Font font { get; set; }
- public int fontSize { get; set; }
- public UnityEngine.FontStyle fontStyle { get; set; }
- public UnityEngine.HorizontalWrapMode horizontalOverflow { get; set; }
- public float lineSpacing { get; set; }
- public int maxSize { get; set; }
- public int minSize { get; set; }
- public bool richText { get; set; }
- public UnityEngine.VerticalWrapMode verticalOverflow { get; set; }

#### Constructors
- public FontData()

#### Methods
- private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
- private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()

### public static class UnityEngine.UI.FontUpdateTracker

#### Fields
- private static System.Collections.Generic.Dictionary<UnityEngine.Font, System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked

#### Constructors
- private static FontUpdateTracker()

#### Methods
- private static void RebuildForFont(UnityEngine.Font f)
- public static void TrackText(UnityEngine.UI.Text t)
- public static void UntrackText(UnityEngine.UI.Text t)

### public delegate UnityEngine.UI.ReflectionMethodsCache.GetRaycastNonAllocCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ReflectionMethodsCache.GetRaycastNonAllocCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i, System.AsyncCallback callback, object object)
- public virtual int EndInvoke(System.IAsyncResult result)
- public virtual int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i)

### public delegate UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ReflectionMethodsCache.GetRayIntersectionAllCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object)
- public virtual UnityEngine.RaycastHit2D[] EndInvoke(System.IAsyncResult result)
- public virtual UnityEngine.RaycastHit2D[] Invoke(UnityEngine.Ray r, float f, int i)

### public delegate UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i, System.AsyncCallback callback, object object)
- public virtual int EndInvoke(System.IAsyncResult result)
- public virtual int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i)

### public class UnityEngine.UI.Graphic
- Base: UnityEngine.EventSystems.UIBehaviour
- Interfaces: UnityEngine.UI.ICanvasElement

#### Fields
- private bool <useLegacyMeshGeneration>k__BackingField
- protected UnityEngine.Mesh m_CachedMesh
- protected UnityEngine.Vector2[] m_CachedUvs
- private UnityEngine.Canvas m_Canvas
- private UnityEngine.CanvasRenderer m_CanvasRenderer
- private UnityEngine.Color m_Color
- private readonly UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.ColorTween> m_ColorTweenRunner
- protected UnityEngine.Material m_Material
- private bool m_MaterialDirty
- protected UnityEngine.Events.UnityAction m_OnDirtyLayoutCallback
- protected UnityEngine.Events.UnityAction m_OnDirtyMaterialCallback
- protected UnityEngine.Events.UnityAction m_OnDirtyVertsCallback
- private UnityEngine.Vector4 m_RaycastPadding
- private bool m_RaycastTarget
- private bool m_RaycastTargetCache
- private UnityEngine.RectTransform m_RectTransform
- protected bool m_SkipLayoutUpdate
- protected bool m_SkipMaterialUpdate
- private bool m_VertsDirty
- protected static UnityEngine.Material s_DefaultUI
- protected static UnityEngine.Mesh s_Mesh
- private static readonly UnityEngine.UI.VertexHelper s_VertexHelper
- protected static UnityEngine.Texture2D s_WhiteTexture

#### Properties
- public UnityEngine.Canvas canvas { get; }
- public UnityEngine.CanvasRenderer canvasRenderer { get; }
- public UnityEngine.Color color { get; set; }
- public static UnityEngine.Material defaultGraphicMaterial { get; }
- public UnityEngine.Material defaultMaterial { get; }
- public int depth { get; }
- public UnityEngine.Texture mainTexture { get; }
- public UnityEngine.Material material { get; set; }
- public UnityEngine.Material materialForRendering { get; }
- public UnityEngine.Vector4 raycastPadding { get; set; }
- public bool raycastTarget { get; set; }
- public UnityEngine.RectTransform rectTransform { get; }
- protected bool useLegacyMeshGeneration { get; set; }
- protected static UnityEngine.Mesh workerMesh { get; }

#### Constructors
- protected Graphic()
- private static Graphic()

#### Methods
- private void CacheCanvas()
- private static UnityEngine.Color CreateColorFromAlpha(float alpha)
- public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
- public virtual void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
- public virtual void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
- private void DoLegacyMeshGeneration()
- private void DoMeshGeneration()
- public UnityEngine.Rect GetPixelAdjustedRect()
- public virtual void GraphicUpdateComplete()
- public virtual void LayoutComplete()
- protected override void OnBeforeTransformParentChanged()
- protected override void OnCanvasHierarchyChanged()
- public virtual void OnCullingChanged()
- protected override void OnDestroy()
- protected override void OnDidApplyAnimationProperties()
- protected override void OnDisable()
- protected override void OnEnable()
- protected virtual void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo)
- protected virtual void OnPopulateMesh(UnityEngine.Mesh m)
- protected virtual void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
- protected override void OnRectTransformDimensionsChange()
- protected override void OnTransformParentChanged()
- public UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point)
- public virtual bool Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
- public virtual void Rebuild(UnityEngine.UI.CanvasUpdate update)
- public void RegisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action)
- public void RegisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action)
- public void RegisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action)
- public virtual void SetAllDirty()
- public virtual void SetLayoutDirty()
- public virtual void SetMaterialDirty()
- public virtual void SetNativeSize()
- public void SetRaycastDirty()
- public virtual void SetVerticesDirty()
- private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
- public void UnregisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action)
- public void UnregisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action)
- public void UnregisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action)
- protected virtual void UpdateGeometry()
- protected virtual void UpdateMaterial()

### public class UnityEngine.UI.GraphicRaycaster
- Base: UnityEngine.EventSystems.BaseRaycaster

#### Fields
- protected static const int kNoEventMaskSet
- protected UnityEngine.LayerMask m_BlockingMask
- private UnityEngine.UI.GraphicRaycaster.BlockingObjects m_BlockingObjects
- private UnityEngine.Canvas m_Canvas
- private bool m_IgnoreReversedGraphics
- private System.Collections.Generic.List<UnityEngine.UI.Graphic> m_RaycastResults
- private static readonly System.Collections.Generic.List<UnityEngine.UI.Graphic> s_SortedGraphics

#### Properties
- public UnityEngine.LayerMask blockingMask { get; set; }
- public UnityEngine.UI.GraphicRaycaster.BlockingObjects blockingObjects { get; set; }
- private UnityEngine.Canvas canvas { get; }
- public UnityEngine.Camera eventCamera { get; }
- public bool ignoreReversedGraphics { get; set; }
- public int renderOrderPriority { get; }
- public int sortOrderPriority { get; }

#### Constructors
- protected GraphicRaycaster()
- private static GraphicRaycaster()

#### Methods
- public override void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
- private static void Raycast(UnityEngine.Canvas canvas, UnityEngine.Camera eventCamera, UnityEngine.Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results)

### public class UnityEngine.UI.GraphicRegistry

#### Fields
- private readonly System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_Graphics
- private readonly System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_RaycastableGraphics
- private static readonly System.Collections.Generic.List<UnityEngine.UI.Graphic> s_EmptyList
- private static UnityEngine.UI.GraphicRegistry s_Instance

#### Properties
- public static UnityEngine.UI.GraphicRegistry instance { get; }

#### Constructors
- protected GraphicRegistry()
- private static GraphicRegistry()

#### Methods
- public static void DisableGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic)
- public static void DisableRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic)
- public static System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(UnityEngine.Canvas canvas)
- public static System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(UnityEngine.Canvas canvas)
- public static void RegisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic)
- public static void RegisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic)
- public static void UnregisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic)
- public static void UnregisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic)

### public class UnityEngine.UI.GridLayoutGroup
- Base: UnityEngine.UI.LayoutGroup
- Interfaces: UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController

#### Fields
- protected UnityEngine.Vector2 m_CellSize
- protected UnityEngine.UI.GridLayoutGroup.Constraint m_Constraint
- protected int m_ConstraintCount
- protected UnityEngine.Vector2 m_Spacing
- protected UnityEngine.UI.GridLayoutGroup.Axis m_StartAxis
- protected UnityEngine.UI.GridLayoutGroup.Corner m_StartCorner

#### Properties
- public UnityEngine.Vector2 cellSize { get; set; }
- public UnityEngine.UI.GridLayoutGroup.Constraint constraint { get; set; }
- public int constraintCount { get; set; }
- public UnityEngine.Vector2 spacing { get; set; }
- public UnityEngine.UI.GridLayoutGroup.Axis startAxis { get; set; }
- public UnityEngine.UI.GridLayoutGroup.Corner startCorner { get; set; }

#### Constructors
- protected GridLayoutGroup()

#### Methods
- public override void CalculateLayoutInputHorizontal()
- public override void CalculateLayoutInputVertical()
- private void SetCellsAlongAxis(int axis)
- public override void SetLayoutHorizontal()
- public override void SetLayoutVertical()

### public class UnityEngine.UI.HorizontalLayoutGroup
- Base: UnityEngine.UI.HorizontalOrVerticalLayoutGroup
- Interfaces: UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController

#### Constructors
- protected HorizontalLayoutGroup()

#### Methods
- public override void CalculateLayoutInputHorizontal()
- public override void CalculateLayoutInputVertical()
- public override void SetLayoutHorizontal()
- public override void SetLayoutVertical()

### public class UnityEngine.UI.HorizontalOrVerticalLayoutGroup
- Base: UnityEngine.UI.LayoutGroup
- Interfaces: UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController

#### Fields
- protected bool m_ChildControlHeight
- protected bool m_ChildControlWidth
- protected bool m_ChildForceExpandHeight
- protected bool m_ChildForceExpandWidth
- protected bool m_ChildScaleHeight
- protected bool m_ChildScaleWidth
- protected bool m_ReverseArrangement
- protected float m_Spacing

#### Properties
- public bool childControlHeight { get; set; }
- public bool childControlWidth { get; set; }
- public bool childForceExpandHeight { get; set; }
- public bool childForceExpandWidth { get; set; }
- public bool childScaleHeight { get; set; }
- public bool childScaleWidth { get; set; }
- public bool reverseArrangement { get; set; }
- public float spacing { get; set; }

#### Constructors
- protected HorizontalOrVerticalLayoutGroup()

#### Methods
- protected void CalcAlongAxis(int axis, bool isVertical)
- private void GetChildSizes(UnityEngine.RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
- protected void SetChildrenAlongAxis(int axis, bool isVertical)

### public interface UnityEngine.UI.ICanvasElement

#### Properties
- public UnityEngine.Transform transform { get; }

#### Methods
- public void GraphicUpdateComplete()
- public bool IsDestroyed()
- public void LayoutComplete()
- public void Rebuild(UnityEngine.UI.CanvasUpdate executing)

### public interface UnityEngine.UI.IClippable

#### Properties
- public UnityEngine.GameObject gameObject { get; }
- public UnityEngine.RectTransform rectTransform { get; }

#### Methods
- public void Cull(UnityEngine.Rect clipRect, bool validRect)
- public void RecalculateClipping()
- public void SetClipRect(UnityEngine.Rect value, bool validRect)
- public void SetClipSoftness(UnityEngine.Vector2 clipSoftness)

### public interface UnityEngine.UI.IClipper

#### Methods
- public void PerformClipping()

### public interface UnityEngine.UI.DefaultControls.IFactoryControls

#### Methods
- public UnityEngine.GameObject CreateGameObject(string name, params System.Type[] components)

### internal interface UnityEngine.UI.IGraphicEnabledDisabled

#### Methods
- public void OnSiblingGraphicEnabledDisabled()

### public interface UnityEngine.UI.ILayoutController

#### Methods
- public void SetLayoutHorizontal()
- public void SetLayoutVertical()

### public interface UnityEngine.UI.ILayoutElement

#### Properties
- public float flexibleHeight { get; }
- public float flexibleWidth { get; }
- public int layoutPriority { get; }
- public float minHeight { get; }
- public float minWidth { get; }
- public float preferredHeight { get; }
- public float preferredWidth { get; }

#### Methods
- public void CalculateLayoutInputHorizontal()
- public void CalculateLayoutInputVertical()

### public interface UnityEngine.UI.ILayoutGroup
- Interfaces: UnityEngine.UI.ILayoutController

### public interface UnityEngine.UI.ILayoutIgnorer

#### Properties
- public bool ignoreLayout { get; }

### public interface UnityEngine.UI.ILayoutSelfController
- Interfaces: UnityEngine.UI.ILayoutController

### public class UnityEngine.UI.Image
- Base: UnityEngine.UI.MaskableGraphic
- Interfaces: UnityEngine.UI.ICanvasElement, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier, UnityEngine.ISerializationCallbackReceiver, UnityEngine.UI.ILayoutElement, UnityEngine.ICanvasRaycastFilter

#### Fields
- private float m_AlphaHitTestMinimumThreshold
- private float m_CachedReferencePixelsPerUnit
- private float m_FillAmount
- private bool m_FillCenter
- private bool m_FillClockwise
- private UnityEngine.UI.Image.FillMethod m_FillMethod
- private int m_FillOrigin
- private UnityEngine.Sprite m_OverrideSprite
- private float m_PixelsPerUnitMultiplier
- private bool m_PreserveAspect
- private UnityEngine.Sprite m_Sprite
- private bool m_Tracked
- private static System.Collections.Generic.List<UnityEngine.UI.Image> m_TrackedTexturelessImages
- private UnityEngine.UI.Image.Type m_Type
- private bool m_UseSpriteMesh
- protected static UnityEngine.Material s_ETC1DefaultUI
- private static bool s_Initialized
- private static readonly UnityEngine.Vector3[] s_Uv
- private static readonly UnityEngine.Vector2[] s_UVScratch
- private static readonly UnityEngine.Vector2[] s_VertScratch
- private static readonly UnityEngine.Vector3[] s_Xy

#### Properties
- private UnityEngine.Sprite activeSprite { get; }
- public float alphaHitTestMinimumThreshold { get; set; }
- public static UnityEngine.Material defaultETC1GraphicMaterial { get; }
- public float eventAlphaThreshold { get; set; }
- public float fillAmount { get; set; }
- public bool fillCenter { get; set; }
- public bool fillClockwise { get; set; }
- public UnityEngine.UI.Image.FillMethod fillMethod { get; set; }
- public int fillOrigin { get; set; }
- public float flexibleHeight { get; }
- public float flexibleWidth { get; }
- public bool hasBorder { get; }
- public int layoutPriority { get; }
- public UnityEngine.Texture mainTexture { get; }
- public UnityEngine.Material material { get; set; }
- public float minHeight { get; }
- public float minWidth { get; }
- protected float multipliedPixelsPerUnit { get; }
- public UnityEngine.Sprite overrideSprite { get; set; }
- public float pixelsPerUnit { get; }
- public float pixelsPerUnitMultiplier { get; set; }
- public float preferredHeight { get; }
- public float preferredWidth { get; }
- public bool preserveAspect { get; set; }
- public UnityEngine.Sprite sprite { get; set; }
- public UnityEngine.UI.Image.Type type { get; set; }
- public bool useSpriteMesh { get; set; }

#### Constructors
- protected Image()
- private static Image()

#### Methods
- private void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0()
- private bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1()
- private static void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector3[] quadPositions, UnityEngine.Color32 color, UnityEngine.Vector3[] quadUVs)
- private static void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector2 posMin, UnityEngine.Vector2 posMax, UnityEngine.Color32 color, UnityEngine.Vector2 uvMin, UnityEngine.Vector2 uvMax)
- public virtual void CalculateLayoutInputHorizontal()
- public virtual void CalculateLayoutInputVertical()
- public void DisableSpriteOptimizations()
- private void GenerateFilledSprite(UnityEngine.UI.VertexHelper toFill, bool preserveAspect)
- private void GenerateSimpleSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect)
- private void GenerateSlicedSprite(UnityEngine.UI.VertexHelper toFill)
- private void GenerateSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect)
- private void GenerateTiledSprite(UnityEngine.UI.VertexHelper toFill)
- private UnityEngine.Vector4 GetAdjustedBorders(UnityEngine.Vector4 border, UnityEngine.Rect adjustedRect)
- private UnityEngine.Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
- public virtual bool IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera)
- private UnityEngine.Vector2 MapCoordinate(UnityEngine.Vector2 local, UnityEngine.Rect rect)
- public virtual void OnAfterDeserialize()
- public virtual void OnBeforeSerialize()
- protected override void OnCanvasHierarchyChanged()
- protected override void OnDidApplyAnimationProperties()
- protected override void OnDisable()
- protected override void OnEnable()
- protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill)
- private void PreserveSpriteAspectRatio(ref UnityEngine.Rect rect, UnityEngine.Vector2 spriteSize)
- private static bool RadialCut(UnityEngine.Vector3[] xy, UnityEngine.Vector3[] uv, float fill, bool invert, int corner)
- private static void RadialCut(UnityEngine.Vector3[] xy, float cos, float sin, bool invert, int corner)
- private static void RebuildImage(UnityEngine.U2D.SpriteAtlas spriteAtlas)
- public override void SetNativeSize()
- private static void TrackImage(UnityEngine.UI.Image g)
- private void TrackSprite()
- private static void UnTrackImage(UnityEngine.UI.Image g)
- protected override void UpdateMaterial()

### public interface UnityEngine.UI.IMask

#### Properties
- public UnityEngine.RectTransform rectTransform { get; }

#### Methods
- public bool Enabled()

### public interface UnityEngine.UI.IMaskable

#### Methods
- public void RecalculateMasking()

### public interface UnityEngine.UI.IMaterialModifier

#### Methods
- public UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)

### public interface UnityEngine.UI.IMeshModifier

#### Methods
- public void ModifyMesh(UnityEngine.Mesh mesh)
- public void ModifyMesh(UnityEngine.UI.VertexHelper verts)

### public class UnityEngine.UI.InputField
- Base: UnityEngine.UI.Selectable
- Interfaces: UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement

#### Fields
- private UnityEngine.RectTransform caretRectTrans
- private static const string kEmailSpecialCharacters
- private static const float kHScrollSpeed
- private static const string kOculusQuestDeviceModel
- private static readonly char[] kSeparators
- private static const float kVScrollSpeed
- private static const int k_MaxTextLength
- private bool m_AllowInput
- private char m_AsteriskChar
- private UnityEngine.Coroutine m_BlinkCoroutine
- private float m_BlinkStartTime
- private UnityEngine.CanvasRenderer m_CachedInputRenderer
- private float m_CaretBlinkRate
- private UnityEngine.Color m_CaretColor
- protected int m_CaretPosition
- protected int m_CaretSelectPosition
- protected bool m_CaretVisible
- private int m_CaretWidth
- private int m_CharacterLimit
- private UnityEngine.UI.InputField.CharacterValidation m_CharacterValidation
- private UnityEngine.UI.InputField.ContentType m_ContentType
- protected UnityEngine.UIVertex[] m_CursorVerts
- private bool m_CustomCaretColor
- private UnityEngine.Coroutine m_DragCoroutine
- private bool m_DragPositionOutOfBounds
- protected int m_DrawEnd
- protected int m_DrawStart
- private bool m_HasDoneFocusTransition
- private bool m_HideMobileInput
- private UnityEngine.TextGenerator m_InputTextCache
- private UnityEngine.UI.InputField.InputType m_InputType
- private bool m_IsCompositionActive
- protected UnityEngine.TouchScreenKeyboard m_Keyboard
- private UnityEngine.TouchScreenKeyboardType m_KeyboardType
- private UnityEngine.UI.InputField.LineType m_LineType
- protected UnityEngine.Mesh m_Mesh
- private UnityEngine.UI.InputField.EndEditEvent m_OnDidEndEdit
- private UnityEngine.UI.InputField.SubmitEvent m_OnSubmit
- private UnityEngine.UI.InputField.OnValidateInput m_OnValidateInput
- private UnityEngine.UI.InputField.OnChangeEvent m_OnValueChanged
- private string m_OriginalText
- protected UnityEngine.UI.Graphic m_Placeholder
- private bool m_PreventFontCallback
- private UnityEngine.Event m_ProcessingEvent
- private bool m_ReadOnly
- private UnityEngine.Color m_SelectionColor
- private bool m_ShouldActivateNextUpdate
- private bool m_ShouldActivateOnSelect
- protected string m_Text
- protected UnityEngine.UI.Text m_TextComponent
- private bool m_TouchKeyboardAllowsInPlaceEditing
- private bool m_UpdateDrag
- private UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime
- private bool m_WasCanceled
- private static bool s_IsQuestDevice

#### Properties
- public char asteriskChar { get; set; }
- protected UnityEngine.TextGenerator cachedInputTextGenerator { get; }
- public float caretBlinkRate { get; set; }
- public UnityEngine.Color caretColor { get; set; }
- public int caretPosition { get; set; }
- protected int caretPositionInternal { get; set; }
- protected int caretSelectPositionInternal { get; set; }
- public int caretWidth { get; set; }
- public int characterLimit { get; set; }
- public UnityEngine.UI.InputField.CharacterValidation characterValidation { get; set; }
- private static string clipboard { get; set; }
- private string compositionString { get; }
- public UnityEngine.UI.InputField.ContentType contentType { get; set; }
- public bool customCaretColor { get; set; }
- public float flexibleHeight { get; }
- public float flexibleWidth { get; }
- private bool hasSelection { get; }
- private UnityEngine.EventSystems.BaseInput input { get; }
- public UnityEngine.UI.InputField.InputType inputType { get; set; }
- public bool isFocused { get; }
- public UnityEngine.TouchScreenKeyboardType keyboardType { get; set; }
- public int layoutPriority { get; }
- public UnityEngine.UI.InputField.LineType lineType { get; set; }
- protected UnityEngine.Mesh mesh { get; }
- public float minHeight { get; }
- public float minWidth { get; }
- public bool multiLine { get; }
- public UnityEngine.UI.InputField.EndEditEvent onEndEdit { get; set; }
- public UnityEngine.UI.InputField.SubmitEvent onSubmit { get; set; }
- public UnityEngine.UI.InputField.OnValidateInput onValidateInput { get; set; }
- public UnityEngine.UI.InputField.OnChangeEvent onValueChange { get; set; }
- public UnityEngine.UI.InputField.OnChangeEvent onValueChanged { get; set; }
- public UnityEngine.UI.Graphic placeholder { get; set; }
- public float preferredHeight { get; }
- public float preferredWidth { get; }
- public bool readOnly { get; set; }
- public int selectionAnchorPosition { get; set; }
- public UnityEngine.Color selectionColor { get; set; }
- public int selectionFocusPosition { get; set; }
- public bool shouldActivateOnSelect { get; set; }
- public bool shouldHideMobileInput { get; set; }
- public string text { get; set; }
- public UnityEngine.UI.Text textComponent { get; set; }
- public UnityEngine.TouchScreenKeyboard touchScreenKeyboard { get; }
- public bool wasCanceled { get; }

#### Constructors
- protected InputField()
- private static InputField()

#### Methods
- public void ActivateInputField()
- private void ActivateInputFieldInternal()
- protected virtual void Append(string input)
- protected virtual void Append(char input)
- private void AssignPositioningIfNeeded()
- private void Backspace()
- public virtual void CalculateLayoutInputHorizontal()
- public virtual void CalculateLayoutInputVertical()
- private System.Collections.IEnumerator CaretBlink()
- protected void ClampPos(ref int pos)
- private void CreateCursorVerts()
- public void DeactivateInputField()
- private void Delete()
- private int DetermineCharacterLine(int charPos, UnityEngine.TextGenerator generator)
- protected override void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant)
- private void EnforceContentType()
- private void EnforceTextHOverflow()
- private int FindtNextWordBegin()
- private int FindtPrevWordBegin()
- public void ForceLabelUpdate()
- private void ForwardSpace()
- private void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset)
- private void GenerateHighlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset)
- protected int GetCharacterIndexFromPosition(UnityEngine.Vector2 pos)
- private UnityEngine.RangeInt GetInternalSelection()
- private static int GetLineEndPosition(UnityEngine.TextGenerator gen, int line)
- private static int GetLineStartPosition(UnityEngine.TextGenerator gen, int line)
- private string GetSelectedString()
- private int GetUnclampedCharacterLineFromPosition(UnityEngine.Vector2 pos, UnityEngine.TextGenerator generator)
- public virtual void GraphicUpdateComplete()
- private bool InPlaceEditing()
- private bool InPlaceEditingChanged()
- private void Insert(char c)
- private bool IsSelectionVisible()
- private bool IsValidChar(char c)
- protected UnityEngine.UI.InputField.EditState KeyPressed(UnityEngine.Event evt)
- protected virtual void LateUpdate()
- public virtual void LayoutComplete()
- private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
- private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
- private void MarkGeometryAsDirty()
- private bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData)
- private System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData)
- private void MoveDown(bool shift)
- private void MoveDown(bool shift, bool goToLastChar)
- private void MoveLeft(bool shift, bool ctrl)
- private void MoveRight(bool shift, bool ctrl)
- public void MoveTextEnd(bool shift)
- public void MoveTextStart(bool shift)
- private void MoveUp(bool shift)
- private void MoveUp(bool shift, bool goToFirstChar)
- public virtual void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
- public override void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
- protected override void OnDestroy()
- protected override void OnDisable()
- public virtual void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
- protected override void OnEnable()
- public virtual void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
- private void OnFillVBO(UnityEngine.Mesh vbo)
- protected void OnFocus()
- public virtual void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
- public override void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
- public override void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
- public virtual void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
- public virtual void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData)
- public void ProcessEvent(UnityEngine.Event e)
- public virtual void Rebuild(UnityEngine.UI.CanvasUpdate update)
- public UnityEngine.Vector2 ScreenToLocal(UnityEngine.Vector2 screen)
- protected void SelectAll()
- protected void SendOnEndEdit()
- protected void SendOnSubmit()
- private void SendOnValueChanged()
- private void SendOnValueChangedAndUpdateLabel()
- private void SetCaretActive()
- private void SetCaretVisible()
- private void SetDrawRangeToContainCaretPosition(int caretPos)
- private void SetText(string value, bool sendCallback = true)
- public void SetTextWithoutNotify(string input)
- private void SetToCustom()
- private void SetToCustomIfContentTypeIsNot(params UnityEngine.UI.InputField.ContentType[] allowedContentTypes)
- private bool TouchScreenKeyboardShouldBeUsed()
- private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
- private void UpdateCaretFromKeyboard()
- private void UpdateCaretMaterial()
- private void UpdateGeometry()
- private void UpdateKeyboardCaret()
- protected void UpdateLabel()
- private void UpdateTouchKeyboardFromEditChanges()
- protected char Validate(string text, int pos, char ch)

### public enum UnityEngine.UI.InputField.InputType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AutoCorrect = 1
- Password = 2
- Standard = 0

### public interface UnityEngine.UI.IVertexModifier

#### Methods
- public void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> verts)

### public class UnityEngine.UI.LayoutElement
- Base: UnityEngine.EventSystems.UIBehaviour
- Interfaces: UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutIgnorer

#### Fields
- private float m_FlexibleHeight
- private float m_FlexibleWidth
- private bool m_IgnoreLayout
- private int m_LayoutPriority
- private float m_MinHeight
- private float m_MinWidth
- private float m_PreferredHeight
- private float m_PreferredWidth

#### Properties
- public float flexibleHeight { get; set; }
- public float flexibleWidth { get; set; }
- public bool ignoreLayout { get; set; }
- public int layoutPriority { get; set; }
- public float minHeight { get; set; }
- public float minWidth { get; set; }
- public float preferredHeight { get; set; }
- public float preferredWidth { get; set; }

#### Constructors
- protected LayoutElement()

#### Methods
- public virtual void CalculateLayoutInputHorizontal()
- public virtual void CalculateLayoutInputVertical()
- protected override void OnBeforeTransformParentChanged()
- protected override void OnDidApplyAnimationProperties()
- protected override void OnDisable()
- protected override void OnEnable()
- protected override void OnTransformParentChanged()
- protected void SetDirty()

### public class UnityEngine.UI.LayoutGroup
- Base: UnityEngine.EventSystems.UIBehaviour
- Interfaces: UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController

#### Fields
- protected UnityEngine.TextAnchor m_ChildAlignment
- protected UnityEngine.RectOffset m_Padding
- private UnityEngine.RectTransform m_Rect
- private System.Collections.Generic.List<UnityEngine.RectTransform> m_RectChildren
- private UnityEngine.Vector2 m_TotalFlexibleSize
- private UnityEngine.Vector2 m_TotalMinSize
- private UnityEngine.Vector2 m_TotalPreferredSize
- protected UnityEngine.DrivenRectTransformTracker m_Tracker

#### Properties
- public UnityEngine.TextAnchor childAlignment { get; set; }
- public float flexibleHeight { get; }
- public float flexibleWidth { get; }
- private bool isRootLayoutGroup { get; }
- public int layoutPriority { get; }
- public float minHeight { get; }
- public float minWidth { get; }
- public UnityEngine.RectOffset padding { get; set; }
- public float preferredHeight { get; }
- public float preferredWidth { get; }
- protected System.Collections.Generic.List<UnityEngine.RectTransform> rectChildren { get; }
- protected UnityEngine.RectTransform rectTransform { get; }

#### Constructors
- protected LayoutGroup()

#### Methods
- public virtual void CalculateLayoutInputHorizontal()
- public abstract void CalculateLayoutInputVertical()
- private System.Collections.IEnumerator DelayedSetDirty(UnityEngine.RectTransform rectTransform)
- protected float GetAlignmentOnAxis(int axis)
- protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding)
- protected float GetTotalFlexibleSize(int axis)
- protected float GetTotalMinSize(int axis)
- protected float GetTotalPreferredSize(int axis)
- protected override void OnDidApplyAnimationProperties()
- protected override void OnDisable()
- protected override void OnEnable()
- protected override void OnRectTransformDimensionsChange()
- protected virtual void OnTransformChildrenChanged()
- protected void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos)
- protected void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos, float size)
- protected void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float scaleFactor)
- protected void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float size, float scaleFactor)
- protected void SetDirty()
- public abstract void SetLayoutHorizontal()
- protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis)
- public abstract void SetLayoutVertical()
- protected void SetProperty<T>(ref T currentValue, T newValue)

### public class UnityEngine.UI.LayoutRebuilder
- Interfaces: UnityEngine.UI.ICanvasElement

#### Fields
- private int m_CachedHashFromTransform
- private UnityEngine.RectTransform m_ToRebuild
- private static UnityEngine.Pool.ObjectPool<UnityEngine.UI.LayoutRebuilder> s_Rebuilders

#### Properties
- public UnityEngine.Transform transform { get; }

#### Constructors
- private static LayoutRebuilder()
- public LayoutRebuilder()

#### Methods
- private void Clear()
- public override bool Equals(object obj)
- public static void ForceRebuildLayoutImmediate(UnityEngine.RectTransform layoutRoot)
- public override int GetHashCode()
- public void GraphicUpdateComplete()
- private void Initialize(UnityEngine.RectTransform controller)
- public bool IsDestroyed()
- public void LayoutComplete()
- public static void MarkLayoutForRebuild(UnityEngine.RectTransform rect)
- private static void MarkLayoutRootForRebuild(UnityEngine.RectTransform controller)
- private void PerformLayoutCalculation(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action)
- private void PerformLayoutControl(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action)
- private static void ReapplyDrivenProperties(UnityEngine.RectTransform driven)
- public void Rebuild(UnityEngine.UI.CanvasUpdate executing)
- private static void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components)
- public override string ToString()
- private static bool ValidController(UnityEngine.RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps)

### public static class UnityEngine.UI.LayoutUtility

#### Methods
- public static float GetFlexibleHeight(UnityEngine.RectTransform rect)
- public static float GetFlexibleSize(UnityEngine.RectTransform rect, int axis)
- public static float GetFlexibleWidth(UnityEngine.RectTransform rect)
- public static float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue)
- public static float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue, out UnityEngine.UI.ILayoutElement source)
- public static float GetMinHeight(UnityEngine.RectTransform rect)
- public static float GetMinSize(UnityEngine.RectTransform rect, int axis)
- public static float GetMinWidth(UnityEngine.RectTransform rect)
- public static float GetPreferredHeight(UnityEngine.RectTransform rect)
- public static float GetPreferredSize(UnityEngine.RectTransform rect, int axis)
- public static float GetPreferredWidth(UnityEngine.RectTransform rect)

### public enum UnityEngine.UI.InputField.LineType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- MultiLineNewline = 2
- MultiLineSubmit = 1
- SingleLine = 0

### public class UnityEngine.UI.Mask
- Base: UnityEngine.EventSystems.UIBehaviour
- Interfaces: UnityEngine.ICanvasRaycastFilter, UnityEngine.UI.IMaterialModifier

#### Fields
- private UnityEngine.UI.Graphic m_Graphic
- private UnityEngine.Material m_MaskMaterial
- private UnityEngine.RectTransform m_RectTransform
- private bool m_ShowMaskGraphic
- private UnityEngine.Material m_UnmaskMaterial

#### Properties
- public UnityEngine.UI.Graphic graphic { get; }
- public UnityEngine.RectTransform rectTransform { get; }
- public bool showMaskGraphic { get; set; }

#### Constructors
- protected Mask()

#### Methods
- public virtual UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
- public virtual bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
- public virtual bool MaskEnabled()
- protected override void OnDisable()
- protected override void OnEnable()
- public virtual void OnSiblingGraphicEnabledDisabled()

### public class UnityEngine.UI.MaskableGraphic
- Base: UnityEngine.UI.Graphic
- Interfaces: UnityEngine.UI.ICanvasElement, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier

#### Fields
- private readonly UnityEngine.Vector3[] m_Corners
- protected bool m_IncludeForMasking
- private bool m_IsMaskingGraphic
- private bool m_Maskable
- protected UnityEngine.Material m_MaskMaterial
- private UnityEngine.UI.MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged
- private UnityEngine.UI.RectMask2D m_ParentMask
- protected bool m_ShouldRecalculate
- protected bool m_ShouldRecalculateStencil
- protected int m_StencilValue

#### Properties
- public bool isMaskingGraphic { get; set; }
- public bool maskable { get; set; }
- public UnityEngine.UI.MaskableGraphic.CullStateChangedEvent onCullStateChanged { get; set; }
- private UnityEngine.Rect rootCanvasRect { get; }

#### Constructors
- protected MaskableGraphic()

#### Methods
- public virtual void Cull(UnityEngine.Rect clipRect, bool validRect)
- public virtual UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
- protected override void OnCanvasHierarchyChanged()
- protected override void OnDisable()
- protected override void OnEnable()
- protected override void OnTransformParentChanged()
- public virtual void ParentMaskStateChanged()
- public virtual void RecalculateClipping()
- public virtual void RecalculateMasking()
- public virtual void SetClipRect(UnityEngine.Rect clipRect, bool validRect)
- public virtual void SetClipSoftness(UnityEngine.Vector2 clipSoftness)
- private UnityEngine.GameObject UnityEngine.UI.IClippable.get_gameObject()
- private void UpdateClipParent()
- private void UpdateCull(bool cull)

### public class UnityEngine.UI.MaskUtilities

#### Constructors
- public MaskUtilities()

#### Methods
- public static UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start)
- public static UnityEngine.UI.RectMask2D GetRectMaskForClippable(UnityEngine.UI.IClippable clippable)
- public static void GetRectMasksForClip(UnityEngine.UI.RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks)
- public static int GetStencilDepth(UnityEngine.Transform transform, UnityEngine.Transform stopAfter)
- public static bool IsDescendantOrSelf(UnityEngine.Transform father, UnityEngine.Transform child)
- public static void Notify2DMaskStateChanged(UnityEngine.Component mask)
- public static void NotifyStencilStateChanged(UnityEngine.Component mask)

### private class UnityEngine.UI.StencilMaterial.MatEntry

#### Fields
- public UnityEngine.Material baseMat
- public UnityEngine.Rendering.ColorWriteMask colorMask
- public UnityEngine.Rendering.CompareFunction compareFunction
- public int count
- public UnityEngine.Material customMat
- public UnityEngine.Rendering.StencilOp operation
- public int readMask
- public int stencilId
- public bool useAlphaClip
- public int writeMask

#### Constructors
- public StencilMaterial.MatEntry()

### internal static class UnityEngine.UI.Misc

#### Methods
- public static void Destroy(UnityEngine.Object obj)
- public static void DestroyImmediate(UnityEngine.Object obj)

### public enum UnityEngine.UI.Navigation.Mode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Automatic = 3
- Explicit = 4
- Horizontal = 1
- None = 0
- Vertical = 2

### public enum UnityEngine.UI.ScrollRect.MovementType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Clamped = 2
- Elastic = 1
- Unrestricted = 0

### internal static class UnityEngine.UI.MultipleDisplayUtilities

#### Methods
- public static bool GetRelativeMousePositionForDrag(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Vector2 position)
- internal static UnityEngine.Vector3 GetRelativeMousePositionForRaycast(UnityEngine.EventSystems.PointerEventData eventData)
- public static UnityEngine.Vector3 RelativeMouseAtScaled(UnityEngine.Vector2 position, int displayIndex)

### public struct UnityEngine.UI.Navigation
- Interfaces: System.IEquatable<UnityEngine.UI.Navigation>

#### Fields
- private UnityEngine.UI.Navigation.Mode m_Mode
- private UnityEngine.UI.Selectable m_SelectOnDown
- private UnityEngine.UI.Selectable m_SelectOnLeft
- private UnityEngine.UI.Selectable m_SelectOnRight
- private UnityEngine.UI.Selectable m_SelectOnUp
- private bool m_WrapAround

#### Properties
- public static UnityEngine.UI.Navigation defaultNavigation { get; }
- public UnityEngine.UI.Navigation.Mode mode { get; set; }
- public UnityEngine.UI.Selectable selectOnDown { get; set; }
- public UnityEngine.UI.Selectable selectOnLeft { get; set; }
- public UnityEngine.UI.Selectable selectOnRight { get; set; }
- public UnityEngine.UI.Selectable selectOnUp { get; set; }
- public bool wrapAround { get; set; }

#### Methods
- public bool Equals(UnityEngine.UI.Navigation other)

### public class UnityEngine.UI.InputField.OnChangeEvent
- Base: UnityEngine.Events.UnityEvent<string>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public InputField.OnChangeEvent()

### public delegate UnityEngine.UI.InputField.OnValidateInput
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public InputField.OnValidateInput(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, System.AsyncCallback callback, object object)
- public virtual char EndInvoke(System.IAsyncResult result)
- public virtual char Invoke(string text, int charIndex, char addedChar)

### public class UnityEngine.UI.Dropdown.OptionData

#### Fields
- private UnityEngine.Sprite m_Image
- private string m_Text

#### Properties
- public UnityEngine.Sprite image { get; set; }
- public string text { get; set; }

#### Constructors
- public Dropdown.OptionData()
- public Dropdown.OptionData(string text)
- public Dropdown.OptionData(UnityEngine.Sprite image)
- public Dropdown.OptionData(string text, UnityEngine.Sprite image)

### public class UnityEngine.UI.Dropdown.OptionDataList

#### Fields
- private System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options

#### Properties
- public System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options { get; set; }

#### Constructors
- public Dropdown.OptionDataList()

### public enum UnityEngine.UI.Image.Origin180
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bottom = 0
- Left = 1
- Right = 3
- Top = 2

### public enum UnityEngine.UI.Image.Origin360
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bottom = 0
- Left = 3
- Right = 1
- Top = 2

### public enum UnityEngine.UI.Image.Origin90
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BottomLeft = 0
- BottomRight = 3
- TopLeft = 1
- TopRight = 2

### public enum UnityEngine.UI.Image.OriginHorizontal
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Left = 0
- Right = 1

### public enum UnityEngine.UI.Image.OriginVertical
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bottom = 0
- Top = 1

### public class UnityEngine.UI.Outline
- Base: UnityEngine.UI.Shadow
- Interfaces: UnityEngine.UI.IMeshModifier

#### Constructors
- protected Outline()

#### Methods
- public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)

### public class UnityEngine.UI.PositionAsUV1
- Base: UnityEngine.UI.BaseMeshEffect
- Interfaces: UnityEngine.UI.IMeshModifier

#### Constructors
- protected PositionAsUV1()

#### Methods
- public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)

### public class UnityEngine.UI.RawImage
- Base: UnityEngine.UI.MaskableGraphic
- Interfaces: UnityEngine.UI.ICanvasElement, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier

#### Fields
- private UnityEngine.Texture m_Texture
- private UnityEngine.Rect m_UVRect

#### Properties
- public UnityEngine.Texture mainTexture { get; }
- public UnityEngine.Texture texture { get; set; }
- public UnityEngine.Rect uvRect { get; set; }

#### Constructors
- protected RawImage()

#### Methods
- protected override void OnDidApplyAnimationProperties()
- protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
- public override void SetNativeSize()

### public delegate UnityEngine.UI.ReflectionMethodsCache.Raycast2DCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ReflectionMethodsCache.Raycast2DCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i, System.AsyncCallback callback, object object)
- public virtual UnityEngine.RaycastHit2D EndInvoke(System.IAsyncResult result)
- public virtual UnityEngine.RaycastHit2D Invoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i)

### public delegate UnityEngine.UI.ReflectionMethodsCache.Raycast3DCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ReflectionMethodsCache.Raycast3DCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.Ray r, out UnityEngine.RaycastHit hit, float f, int i, System.AsyncCallback callback, object object)
- public virtual bool EndInvoke(out UnityEngine.RaycastHit hit, System.IAsyncResult result)
- public virtual bool Invoke(UnityEngine.Ray r, out UnityEngine.RaycastHit hit, float f, int i)

### public delegate UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ReflectionMethodsCache.RaycastAllCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object)
- public virtual UnityEngine.RaycastHit[] EndInvoke(System.IAsyncResult result)
- public virtual UnityEngine.RaycastHit[] Invoke(UnityEngine.Ray r, float f, int i)

### internal class UnityEngine.UI.RectangularVertexClipper

#### Fields
- private readonly UnityEngine.Vector3[] m_CanvasCorners
- private readonly UnityEngine.Vector3[] m_WorldCorners

#### Constructors
- public RectangularVertexClipper()

#### Methods
- public UnityEngine.Rect GetCanvasRect(UnityEngine.RectTransform t, UnityEngine.Canvas c)

### public class UnityEngine.UI.RectMask2D
- Base: UnityEngine.EventSystems.UIBehaviour
- Interfaces: UnityEngine.UI.IClipper, UnityEngine.ICanvasRaycastFilter

#### Fields
- private UnityEngine.Canvas m_Canvas
- private System.Collections.Generic.List<UnityEngine.UI.RectMask2D> m_Clippers
- private System.Collections.Generic.HashSet<UnityEngine.UI.IClippable> m_ClipTargets
- private UnityEngine.Vector3[] m_Corners
- private bool m_ForceClip
- private UnityEngine.Rect m_LastClipRectCanvasSpace
- private System.Collections.Generic.HashSet<UnityEngine.UI.MaskableGraphic> m_MaskableTargets
- private UnityEngine.Vector4 m_Padding
- private UnityEngine.RectTransform m_RectTransform
- private bool m_ShouldRecalculateClipRects
- private UnityEngine.Vector2Int m_Softness
- private readonly UnityEngine.UI.RectangularVertexClipper m_VertexClipper

#### Properties
- internal UnityEngine.Canvas Canvas { get; }
- public UnityEngine.Rect canvasRect { get; }
- public UnityEngine.Vector4 padding { get; set; }
- public UnityEngine.RectTransform rectTransform { get; }
- private UnityEngine.Rect rootCanvasRect { get; }
- public UnityEngine.Vector2Int softness { get; set; }

#### Constructors
- protected RectMask2D()

#### Methods
- public void AddClippable(UnityEngine.UI.IClippable clippable)
- public virtual bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
- protected override void OnCanvasHierarchyChanged()
- protected override void OnDestroy()
- protected override void OnDisable()
- protected override void OnEnable()
- protected override void OnTransformParentChanged()
- public virtual void PerformClipping()
- public void RemoveClippable(UnityEngine.UI.IClippable clippable)
- public virtual void UpdateClipSoftness()

### internal class UnityEngine.UI.ReflectionMethodsCache

#### Fields
- public UnityEngine.UI.ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc
- public UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll
- public UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc
- public UnityEngine.UI.ReflectionMethodsCache.Raycast2DCallback raycast2D
- public UnityEngine.UI.ReflectionMethodsCache.Raycast3DCallback raycast3D
- public UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallback raycast3DAll
- private static UnityEngine.UI.ReflectionMethodsCache s_ReflectionMethodsCache

#### Properties
- public static UnityEngine.UI.ReflectionMethodsCache Singleton { get; }

#### Constructors
- public ReflectionMethodsCache()

### public struct UnityEngine.UI.DefaultControls.Resources

#### Fields
- public UnityEngine.Sprite background
- public UnityEngine.Sprite checkmark
- public UnityEngine.Sprite dropdown
- public UnityEngine.Sprite inputField
- public UnityEngine.Sprite knob
- public UnityEngine.Sprite mask
- public UnityEngine.Sprite standard

### public enum UnityEngine.UI.CanvasScaler.ScaleMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ConstantPhysicalSize = 2
- ConstantPixelSize = 0
- ScaleWithScreenSize = 1

### public enum UnityEngine.UI.CanvasScaler.ScreenMatchMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Expand = 1
- MatchWidthOrHeight = 0
- Shrink = 2

### public class UnityEngine.UI.Scrollbar
- Base: UnityEngine.UI.Selectable
- Interfaces: UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.UI.ICanvasElement

#### Fields
- private bool isPointerDownAndNotDragging
- private UnityEngine.RectTransform m_ContainerRect
- private bool m_DelayedUpdateVisuals
- private UnityEngine.UI.Scrollbar.Direction m_Direction
- private UnityEngine.RectTransform m_HandleRect
- private int m_NumberOfSteps
- private UnityEngine.Vector2 m_Offset
- private UnityEngine.UI.Scrollbar.ScrollEvent m_OnValueChanged
- private UnityEngine.Coroutine m_PointerDownRepeat
- private float m_Size
- private UnityEngine.DrivenRectTransformTracker m_Tracker
- private float m_Value

#### Properties
- private UnityEngine.UI.Scrollbar.Axis axis { get; }
- public UnityEngine.UI.Scrollbar.Direction direction { get; set; }
- public UnityEngine.RectTransform handleRect { get; set; }
- public int numberOfSteps { get; set; }
- public UnityEngine.UI.Scrollbar.ScrollEvent onValueChanged { get; set; }
- private bool reverseValue { get; }
- public float size { get; set; }
- private float stepSize { get; }
- public float value { get; set; }

#### Constructors
- protected Scrollbar()

#### Methods
- protected System.Collections.IEnumerator ClickRepeat(UnityEngine.EventSystems.PointerEventData eventData)
- protected System.Collections.IEnumerator ClickRepeat(UnityEngine.Vector2 screenPosition, UnityEngine.Camera camera)
- private void DoUpdateDrag(UnityEngine.Vector2 handleCorner, float remainingSize)
- public override UnityEngine.UI.Selectable FindSelectableOnDown()
- public override UnityEngine.UI.Selectable FindSelectableOnLeft()
- public override UnityEngine.UI.Selectable FindSelectableOnRight()
- public override UnityEngine.UI.Selectable FindSelectableOnUp()
- public virtual void GraphicUpdateComplete()
- public virtual void LayoutComplete()
- private bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
- protected override void OnDisable()
- public virtual void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
- protected override void OnEnable()
- public virtual void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
- public override void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
- public override void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
- public override void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
- protected override void OnRectTransformDimensionsChange()
- public virtual void Rebuild(UnityEngine.UI.CanvasUpdate executing)
- private void Set(float input, bool sendCallback = true)
- public void SetDirection(UnityEngine.UI.Scrollbar.Direction direction, bool includeRectLayouts)
- public virtual void SetValueWithoutNotify(float input)
- private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
- protected virtual void Update()
- private void UpdateCachedReferences()
- private void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData)
- private void UpdateVisuals()

### public enum UnityEngine.UI.ScrollRect.ScrollbarVisibility
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AutoHide = 1
- AutoHideAndExpandViewport = 2
- Permanent = 0

### public class UnityEngine.UI.Scrollbar.ScrollEvent
- Base: UnityEngine.Events.UnityEvent<float>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public Scrollbar.ScrollEvent()

### public class UnityEngine.UI.ScrollRect
- Base: UnityEngine.EventSystems.UIBehaviour
- Interfaces: UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController

#### Fields
- private UnityEngine.RectTransform m_Content
- protected UnityEngine.Bounds m_ContentBounds
- protected UnityEngine.Vector2 m_ContentStartPosition
- private readonly UnityEngine.Vector3[] m_Corners
- private float m_DecelerationRate
- private bool m_Dragging
- private float m_Elasticity
- private bool m_HasRebuiltLayout
- private bool m_Horizontal
- private UnityEngine.UI.Scrollbar m_HorizontalScrollbar
- private UnityEngine.RectTransform m_HorizontalScrollbarRect
- private float m_HorizontalScrollbarSpacing
- private UnityEngine.UI.ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility
- private bool m_HSliderExpand
- private float m_HSliderHeight
- private bool m_Inertia
- private UnityEngine.UI.ScrollRect.MovementType m_MovementType
- private UnityEngine.UI.ScrollRect.ScrollRectEvent m_OnValueChanged
- private UnityEngine.Vector2 m_PointerStartLocalCursor
- private UnityEngine.Bounds m_PrevContentBounds
- private UnityEngine.Vector2 m_PrevPosition
- private UnityEngine.Bounds m_PrevViewBounds
- private UnityEngine.RectTransform m_Rect
- private bool m_Scrolling
- private float m_ScrollSensitivity
- private UnityEngine.DrivenRectTransformTracker m_Tracker
- private UnityEngine.Vector2 m_Velocity
- private bool m_Vertical
- private UnityEngine.UI.Scrollbar m_VerticalScrollbar
- private UnityEngine.RectTransform m_VerticalScrollbarRect
- private float m_VerticalScrollbarSpacing
- private UnityEngine.UI.ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility
- private UnityEngine.Bounds m_ViewBounds
- private UnityEngine.RectTransform m_Viewport
- private UnityEngine.RectTransform m_ViewRect
- private bool m_VSliderExpand
- private float m_VSliderWidth

#### Properties
- public UnityEngine.RectTransform content { get; set; }
- public float decelerationRate { get; set; }
- public float elasticity { get; set; }
- public float flexibleHeight { get; }
- public float flexibleWidth { get; }
- public bool horizontal { get; set; }
- public float horizontalNormalizedPosition { get; set; }
- public UnityEngine.UI.Scrollbar horizontalScrollbar { get; set; }
- public float horizontalScrollbarSpacing { get; set; }
- public UnityEngine.UI.ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
- private bool hScrollingNeeded { get; }
- public bool inertia { get; set; }
- public int layoutPriority { get; }
- public float minHeight { get; }
- public float minWidth { get; }
- public UnityEngine.UI.ScrollRect.MovementType movementType { get; set; }
- public UnityEngine.Vector2 normalizedPosition { get; set; }
- public UnityEngine.UI.ScrollRect.ScrollRectEvent onValueChanged { get; set; }
- public float preferredHeight { get; }
- public float preferredWidth { get; }
- private UnityEngine.RectTransform rectTransform { get; }
- public float scrollSensitivity { get; set; }
- public UnityEngine.Vector2 velocity { get; set; }
- public bool vertical { get; set; }
- public float verticalNormalizedPosition { get; set; }
- public UnityEngine.UI.Scrollbar verticalScrollbar { get; set; }
- public float verticalScrollbarSpacing { get; set; }
- public UnityEngine.UI.ScrollRect.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
- public UnityEngine.RectTransform viewport { get; set; }
- protected UnityEngine.RectTransform viewRect { get; }
- private bool vScrollingNeeded { get; }

#### Constructors
- protected ScrollRect()

#### Methods
- internal static void AdjustBounds(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Vector2 contentPivot, ref UnityEngine.Vector3 contentSize, ref UnityEngine.Vector3 contentPos)
- public virtual void CalculateLayoutInputHorizontal()
- public virtual void CalculateLayoutInputVertical()
- private UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta)
- private void EnsureLayoutHasRebuilt()
- private UnityEngine.Bounds GetBounds()
- public virtual void GraphicUpdateComplete()
- internal static UnityEngine.Vector2 InternalCalculateOffset(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds, bool horizontal, bool vertical, UnityEngine.UI.ScrollRect.MovementType movementType, ref UnityEngine.Vector2 delta)
- internal static UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, ref UnityEngine.Matrix4x4 viewWorldToLocalMatrix)
- public override bool IsActive()
- protected virtual void LateUpdate()
- public virtual void LayoutComplete()
- public virtual void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
- protected override void OnDisable()
- public virtual void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
- protected override void OnEnable()
- public virtual void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
- protected override void OnRectTransformDimensionsChange()
- public virtual void OnScroll(UnityEngine.EventSystems.PointerEventData data)
- public virtual void Rebuild(UnityEngine.UI.CanvasUpdate executing)
- private static float RubberDelta(float overStretching, float viewSize)
- protected virtual void SetContentAnchoredPosition(UnityEngine.Vector2 position)
- protected void SetDirty()
- protected void SetDirtyCaching()
- private void SetHorizontalNormalizedPosition(float value)
- public virtual void SetLayoutHorizontal()
- public virtual void SetLayoutVertical()
- protected virtual void SetNormalizedPosition(float value, int axis)
- private void SetVerticalNormalizedPosition(float value)
- public virtual void StopMovement()
- private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
- protected void UpdateBounds()
- private void UpdateCachedData()
- private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, UnityEngine.UI.ScrollRect.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar)
- protected void UpdatePrevData()
- private void UpdateScrollbarLayout()
- private void UpdateScrollbars(UnityEngine.Vector2 offset)
- private void UpdateScrollbarVisibility()

### public class UnityEngine.UI.ScrollRect.ScrollRectEvent
- Base: UnityEngine.Events.UnityEvent<UnityEngine.Vector2>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public ScrollRect.ScrollRectEvent()

### public class UnityEngine.UI.Selectable
- Base: UnityEngine.EventSystems.UIBehaviour
- Interfaces: UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler

#### Fields
- private bool <hasSelection>k__BackingField
- private bool <isPointerDown>k__BackingField
- private bool <isPointerInside>k__BackingField
- private UnityEngine.UI.AnimationTriggers m_AnimationTriggers
- private readonly System.Collections.Generic.List<UnityEngine.CanvasGroup> m_CanvasGroupCache
- private UnityEngine.UI.ColorBlock m_Colors
- protected int m_CurrentIndex
- private bool m_EnableCalled
- private bool m_GroupsAllowInteraction
- private bool m_Interactable
- private UnityEngine.UI.Navigation m_Navigation
- private UnityEngine.UI.SpriteState m_SpriteState
- private UnityEngine.UI.Graphic m_TargetGraphic
- private UnityEngine.UI.Selectable.Transition m_Transition
- protected static int s_SelectableCount
- protected static UnityEngine.UI.Selectable[] s_Selectables

#### Properties
- public static int allSelectableCount { get; }
- public static System.Collections.Generic.List<UnityEngine.UI.Selectable> allSelectables { get; }
- public static UnityEngine.UI.Selectable[] allSelectablesArray { get; }
- public UnityEngine.UI.AnimationTriggers animationTriggers { get; set; }
- public UnityEngine.Animator animator { get; }
- public UnityEngine.UI.ColorBlock colors { get; set; }
- protected UnityEngine.UI.Selectable.SelectionState currentSelectionState { get; }
- private bool hasSelection { get; set; }
- public UnityEngine.UI.Image image { get; set; }
- public bool interactable { get; set; }
- private bool isPointerDown { get; set; }
- private bool isPointerInside { get; set; }
- public UnityEngine.UI.Navigation navigation { get; set; }
- public UnityEngine.UI.SpriteState spriteState { get; set; }
- public UnityEngine.UI.Graphic targetGraphic { get; set; }
- public UnityEngine.UI.Selectable.Transition transition { get; set; }

#### Constructors
- protected Selectable()
- private static Selectable()

#### Methods
- public static int AllSelectablesNoAlloc(UnityEngine.UI.Selectable[] selectables)
- protected override void Awake()
- private void DoSpriteSwap(UnityEngine.Sprite newSprite)
- protected virtual void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant)
- private void EvaluateAndTransitionToSelectionState()
- public UnityEngine.UI.Selectable FindSelectable(UnityEngine.Vector3 dir)
- public virtual UnityEngine.UI.Selectable FindSelectableOnDown()
- public virtual UnityEngine.UI.Selectable FindSelectableOnLeft()
- public virtual UnityEngine.UI.Selectable FindSelectableOnRight()
- public virtual UnityEngine.UI.Selectable FindSelectableOnUp()
- private static UnityEngine.Vector3 GetPointOnRectEdge(UnityEngine.RectTransform rect, UnityEngine.Vector2 dir)
- protected virtual void InstantClearState()
- protected bool IsHighlighted()
- public virtual bool IsInteractable()
- protected bool IsPressed()
- private void Navigate(UnityEngine.EventSystems.AxisEventData eventData, UnityEngine.UI.Selectable sel)
- private void OnApplicationFocus(bool hasFocus)
- protected override void OnCanvasGroupChanged()
- public virtual void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
- protected override void OnDidApplyAnimationProperties()
- protected override void OnDisable()
- protected override void OnEnable()
- public virtual void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
- public virtual void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
- private void OnSetProperty()
- protected override void OnTransformParentChanged()
- private bool ParentGroupAllowsInteraction()
- public virtual void Select()
- private void StartColorTween(UnityEngine.Color targetColor, bool instant)
- private void TriggerAnimation(string triggername)

### protected enum UnityEngine.UI.Selectable.SelectionState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Disabled = 4
- Highlighted = 1
- Normal = 0
- Pressed = 2
- Selected = 3

### internal static class UnityEngine.UI.SetPropertyUtility

#### Methods
- public static bool SetClass<T>(ref T currentValue, T newValue)
- public static bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue)
- public static bool SetStruct<T>(ref T currentValue, T newValue)

### public class UnityEngine.UI.Shadow
- Base: UnityEngine.UI.BaseMeshEffect
- Interfaces: UnityEngine.UI.IMeshModifier

#### Fields
- private static const float kMaxEffectDistance
- private UnityEngine.Color m_EffectColor
- private UnityEngine.Vector2 m_EffectDistance
- private bool m_UseGraphicAlpha

#### Properties
- public UnityEngine.Color effectColor { get; set; }
- public UnityEngine.Vector2 effectDistance { get; set; }
- public bool useGraphicAlpha { get; set; }

#### Constructors
- protected Shadow()

#### Methods
- protected void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y)
- protected void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y)
- public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)

### public class UnityEngine.UI.Slider
- Base: UnityEngine.UI.Selectable
- Interfaces: UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.UI.ICanvasElement

#### Fields
- private bool m_DelayedUpdateVisuals
- private UnityEngine.UI.Slider.Direction m_Direction
- private UnityEngine.RectTransform m_FillContainerRect
- private UnityEngine.UI.Image m_FillImage
- private UnityEngine.RectTransform m_FillRect
- private UnityEngine.Transform m_FillTransform
- private UnityEngine.RectTransform m_HandleContainerRect
- private UnityEngine.RectTransform m_HandleRect
- private UnityEngine.Transform m_HandleTransform
- private float m_MaxValue
- private float m_MinValue
- private UnityEngine.Vector2 m_Offset
- private UnityEngine.UI.Slider.SliderEvent m_OnValueChanged
- private UnityEngine.DrivenRectTransformTracker m_Tracker
- protected float m_Value
- private bool m_WholeNumbers

#### Properties
- private UnityEngine.UI.Slider.Axis axis { get; }
- public UnityEngine.UI.Slider.Direction direction { get; set; }
- public UnityEngine.RectTransform fillRect { get; set; }
- public UnityEngine.RectTransform handleRect { get; set; }
- public float maxValue { get; set; }
- public float minValue { get; set; }
- public float normalizedValue { get; set; }
- public UnityEngine.UI.Slider.SliderEvent onValueChanged { get; set; }
- private bool reverseValue { get; }
- private float stepSize { get; }
- public float value { get; set; }
- public bool wholeNumbers { get; set; }

#### Constructors
- protected Slider()

#### Methods
- private float ClampValue(float input)
- public override UnityEngine.UI.Selectable FindSelectableOnDown()
- public override UnityEngine.UI.Selectable FindSelectableOnLeft()
- public override UnityEngine.UI.Selectable FindSelectableOnRight()
- public override UnityEngine.UI.Selectable FindSelectableOnUp()
- public virtual void GraphicUpdateComplete()
- public virtual void LayoutComplete()
- private bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData)
- protected override void OnDidApplyAnimationProperties()
- protected override void OnDisable()
- public virtual void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
- protected override void OnEnable()
- public virtual void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
- public override void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
- public override void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
- protected override void OnRectTransformDimensionsChange()
- public virtual void Rebuild(UnityEngine.UI.CanvasUpdate executing)
- protected virtual void Set(float input, bool sendCallback = true)
- public void SetDirection(UnityEngine.UI.Slider.Direction direction, bool includeRectLayouts)
- public virtual void SetValueWithoutNotify(float input)
- private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
- protected virtual void Update()
- private void UpdateCachedReferences()
- private void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Camera cam)
- private void UpdateVisuals()

### public class UnityEngine.UI.Slider.SliderEvent
- Base: UnityEngine.Events.UnityEvent<float>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public Slider.SliderEvent()

### public struct UnityEngine.UI.SpriteState
- Interfaces: System.IEquatable<UnityEngine.UI.SpriteState>

#### Fields
- private UnityEngine.Sprite m_DisabledSprite
- private UnityEngine.Sprite m_HighlightedSprite
- private UnityEngine.Sprite m_PressedSprite
- private UnityEngine.Sprite m_SelectedSprite

#### Properties
- public UnityEngine.Sprite disabledSprite { get; set; }
- public UnityEngine.Sprite highlightedSprite { get; set; }
- public UnityEngine.Sprite pressedSprite { get; set; }
- public UnityEngine.Sprite selectedSprite { get; set; }

#### Methods
- public bool Equals(UnityEngine.UI.SpriteState other)

### public static class UnityEngine.UI.StencilMaterial

#### Fields
- private static System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List

#### Constructors
- private static StencilMaterial()

#### Methods
- public static UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID)
- public static UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask)
- public static UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask, int readMask, int writeMask)
- public static void ClearAll()
- private static void LogWarningWhenNotInBatchmode(string warning, UnityEngine.Object context)
- public static void Remove(UnityEngine.Material customMat)

### public class UnityEngine.UI.InputField.SubmitEvent
- Base: UnityEngine.Events.UnityEvent<string>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public InputField.SubmitEvent()

### public class UnityEngine.UI.Text
- Base: UnityEngine.UI.MaskableGraphic
- Interfaces: UnityEngine.UI.ICanvasElement, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier, UnityEngine.UI.ILayoutElement

#### Fields
- protected bool m_DisableFontTextureRebuiltCallback
- private UnityEngine.UI.FontData m_FontData
- private readonly UnityEngine.UIVertex[] m_TempVerts
- protected string m_Text
- private UnityEngine.TextGenerator m_TextCache
- private UnityEngine.TextGenerator m_TextCacheForLayout
- protected static UnityEngine.Material s_DefaultText

#### Properties
- public bool alignByGeometry { get; set; }
- public UnityEngine.TextAnchor alignment { get; set; }
- public UnityEngine.TextGenerator cachedTextGenerator { get; }
- public UnityEngine.TextGenerator cachedTextGeneratorForLayout { get; }
- public float flexibleHeight { get; }
- public float flexibleWidth { get; }
- public UnityEngine.Font font { get; set; }
- public int fontSize { get; set; }
- public UnityEngine.FontStyle fontStyle { get; set; }
- public UnityEngine.HorizontalWrapMode horizontalOverflow { get; set; }
- public int layoutPriority { get; }
- public float lineSpacing { get; set; }
- public UnityEngine.Texture mainTexture { get; }
- public float minHeight { get; }
- public float minWidth { get; }
- public float pixelsPerUnit { get; }
- public float preferredHeight { get; }
- public float preferredWidth { get; }
- public bool resizeTextForBestFit { get; set; }
- public int resizeTextMaxSize { get; set; }
- public int resizeTextMinSize { get; set; }
- public bool supportRichText { get; set; }
- public string text { get; set; }
- public UnityEngine.VerticalWrapMode verticalOverflow { get; set; }

#### Constructors
- protected Text()

#### Methods
- internal void AssignDefaultFont()
- internal void AssignDefaultFontIfNecessary()
- public virtual void CalculateLayoutInputHorizontal()
- public virtual void CalculateLayoutInputVertical()
- public void FontTextureChanged()
- public UnityEngine.TextGenerationSettings GetGenerationSettings(UnityEngine.Vector2 extents)
- public static UnityEngine.Vector2 GetTextAnchorPivot(UnityEngine.TextAnchor anchor)
- protected override void OnDisable()
- protected override void OnEnable()
- protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill)
- protected override void UpdateGeometry()

### public class UnityEngine.UI.Toggle
- Base: UnityEngine.UI.Selectable
- Interfaces: UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement

#### Fields
- public UnityEngine.UI.Graphic graphic
- private UnityEngine.UI.ToggleGroup m_Group
- private bool m_IsOn
- public UnityEngine.UI.Toggle.ToggleEvent onValueChanged
- public UnityEngine.UI.Toggle.ToggleTransition toggleTransition

#### Properties
- public UnityEngine.UI.ToggleGroup group { get; set; }
- public bool isOn { get; set; }

#### Constructors
- protected Toggle()

#### Methods
- public virtual void GraphicUpdateComplete()
- private void InternalToggle()
- public virtual void LayoutComplete()
- protected override void OnDestroy()
- protected override void OnDidApplyAnimationProperties()
- protected override void OnDisable()
- protected override void OnEnable()
- public virtual void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
- public virtual void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
- private void PlayEffect(bool instant)
- public virtual void Rebuild(UnityEngine.UI.CanvasUpdate executing)
- private void Set(bool value, bool sendCallback = true)
- public void SetIsOnWithoutNotify(bool value)
- private void SetToggleGroup(UnityEngine.UI.ToggleGroup newGroup, bool setMemberValue)
- protected override void Start()
- private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()

### public class UnityEngine.UI.Toggle.ToggleEvent
- Base: UnityEngine.Events.UnityEvent<bool>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public Toggle.ToggleEvent()

### public class UnityEngine.UI.ToggleGroup
- Base: UnityEngine.EventSystems.UIBehaviour

#### Fields
- private bool m_AllowSwitchOff
- protected System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles

#### Properties
- public bool allowSwitchOff { get; set; }

#### Constructors
- protected ToggleGroup()

#### Methods
- public System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles()
- public bool AnyTogglesOn()
- public void EnsureValidState()
- public UnityEngine.UI.Toggle GetFirstActiveToggle()
- public void NotifyToggleOn(UnityEngine.UI.Toggle toggle, bool sendCallback = true)
- protected override void OnEnable()
- public void RegisterToggle(UnityEngine.UI.Toggle toggle)
- public void SetAllTogglesOff(bool sendCallback = true)
- protected override void Start()
- public void UnregisterToggle(UnityEngine.UI.Toggle toggle)
- private void ValidateToggleIsInGroup(UnityEngine.UI.Toggle toggle)

### public enum UnityEngine.UI.Toggle.ToggleTransition
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Fade = 1
- None = 0

### public enum UnityEngine.UI.Selectable.Transition
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Animation = 3
- ColorTint = 1
- None = 0
- SpriteSwap = 2

### public enum UnityEngine.UI.Image.Type
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Filled = 3
- Simple = 0
- Sliced = 1
- Tiled = 2

### public enum UnityEngine.UI.CanvasScaler.Unit
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Centimeters = 0
- Inches = 2
- Millimeters = 1
- Picas = 4
- Points = 3

### public class UnityEngine.UI.VertexHelper
- Interfaces: System.IDisposable

#### Fields
- private System.Collections.Generic.List<UnityEngine.Color32> m_Colors
- private System.Collections.Generic.List<int> m_Indices
- private bool m_ListsInitalized
- private System.Collections.Generic.List<UnityEngine.Vector3> m_Normals
- private System.Collections.Generic.List<UnityEngine.Vector3> m_Positions
- private System.Collections.Generic.List<UnityEngine.Vector4> m_Tangents
- private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv0S
- private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv1S
- private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv2S
- private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv3S
- private static readonly UnityEngine.Vector3 s_DefaultNormal
- private static readonly UnityEngine.Vector4 s_DefaultTangent

#### Properties
- public int currentIndexCount { get; }
- public int currentVertCount { get; }

#### Constructors
- public VertexHelper()
- private static VertexHelper()
- public VertexHelper(UnityEngine.Mesh m)

#### Methods
- public void AddTriangle(int idx0, int idx1, int idx2)
- public void AddUIVertexQuad(UnityEngine.UIVertex[] verts)
- public void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<int> indices)
- public void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts)
- public void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector4 uv2, UnityEngine.Vector4 uv3, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent)
- public void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent)
- public void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0)
- public void AddVert(UnityEngine.UIVertex v)
- public void Clear()
- public void Dispose()
- public void FillMesh(UnityEngine.Mesh mesh)
- public void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream)
- private void InitializeListIfRequired()
- public void PopulateUIVertex(ref UnityEngine.UIVertex vertex, int i)
- public void SetUIVertex(UnityEngine.UIVertex vertex, int i)

### public class UnityEngine.UI.VerticalLayoutGroup
- Base: UnityEngine.UI.HorizontalOrVerticalLayoutGroup
- Interfaces: UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController

#### Constructors
- protected VerticalLayoutGroup()

#### Methods
- public override void CalculateLayoutInputHorizontal()
- public override void CalculateLayoutInputVertical()
- public override void SetLayoutHorizontal()
- public override void SetLayoutVertical()

## Namespace: UnityEngine.UI.Collections

### internal class UnityEngine.UI.Collections.IndexedSet<T>
- Interfaces: System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable

#### Fields
- private System.Collections.Generic.Dictionary<T, int> m_Dictionary
- private int m_EnabledObjectCount
- private readonly System.Collections.Generic.List<T> m_List

#### Properties
- public int Capacity { get; }
- public int Count { get; }
- public bool IsReadOnly { get; }
- public T Item { get; set; }

#### Constructors
- public IndexedSet<T>()

#### Methods
- public void Add(T item)
- public void Add(T item, bool isActive)
- public bool AddUnique(T item, bool isActive = true)
- public void Clear()
- public bool Contains(T item)
- public void CopyTo(T[] array, int arrayIndex)
- public bool DisableItem(T item)
- public bool EnableItem(T item)
- public System.Collections.Generic.IEnumerator<T> GetEnumerator()
- public int IndexOf(T item)
- public void Insert(int index, T item)
- public bool Remove(T item)
- public void RemoveAll(System.Predicate<T> match)
- public void RemoveAt(int index)
- public void Sort(System.Comparison<T> sortLayoutFunction)
- private void Swap(int index1, int index2)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()

## Namespace: UnityEngine.UI.CoroutineTween

### private class UnityEngine.UI.CoroutineTween.TweenRunner<T>.<Start>d__2<T>
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- private float <elapsedTime>5__2
- public T tweenInfo

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public TweenRunner<T>.<Start>d__2<T>(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### internal struct UnityEngine.UI.CoroutineTween.ColorTween
- Interfaces: UnityEngine.UI.CoroutineTween.ITweenValue

#### Fields
- private float m_Duration
- private bool m_IgnoreTimeScale
- private UnityEngine.Color m_StartColor
- private UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenCallback m_Target
- private UnityEngine.Color m_TargetColor
- private UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode m_TweenMode

#### Properties
- public float duration { get; set; }
- public bool ignoreTimeScale { get; set; }
- public UnityEngine.Color startColor { get; set; }
- public UnityEngine.Color targetColor { get; set; }
- public UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode tweenMode { get; set; }

#### Methods
- public void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback)
- public float GetDuration()
- public bool GetIgnoreTimescale()
- public void TweenValue(float floatPercentage)
- public bool ValidTarget()

### public class UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenCallback
- Base: UnityEngine.Events.UnityEvent<UnityEngine.Color>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public ColorTween.ColorTweenCallback()

### public enum UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- All = 0
- Alpha = 2
- RGB = 1

### internal struct UnityEngine.UI.CoroutineTween.FloatTween
- Interfaces: UnityEngine.UI.CoroutineTween.ITweenValue

#### Fields
- private float m_Duration
- private bool m_IgnoreTimeScale
- private float m_StartValue
- private UnityEngine.UI.CoroutineTween.FloatTween.FloatTweenCallback m_Target
- private float m_TargetValue

#### Properties
- public float duration { get; set; }
- public bool ignoreTimeScale { get; set; }
- public float startValue { get; set; }
- public float targetValue { get; set; }

#### Methods
- public void AddOnChangedCallback(UnityEngine.Events.UnityAction<float> callback)
- public float GetDuration()
- public bool GetIgnoreTimescale()
- public void TweenValue(float floatPercentage)
- public bool ValidTarget()

### public class UnityEngine.UI.CoroutineTween.FloatTween.FloatTweenCallback
- Base: UnityEngine.Events.UnityEvent<float>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public FloatTween.FloatTweenCallback()

### internal interface UnityEngine.UI.CoroutineTween.ITweenValue

#### Properties
- public float duration { get; }
- public bool ignoreTimeScale { get; }

#### Methods
- public void TweenValue(float floatPercentage)
- public bool ValidTarget()

### internal class UnityEngine.UI.CoroutineTween.TweenRunner<T>

#### Fields
- protected UnityEngine.MonoBehaviour m_CoroutineContainer
- protected System.Collections.IEnumerator m_Tween

#### Constructors
- public TweenRunner<T>()

#### Methods
- public void Init(UnityEngine.MonoBehaviour coroutineContainer)
- private static System.Collections.IEnumerator Start(T tweenInfo)
- public void StartTween(T info)
- public void StopTween()

## Namespace: UnityEngine.UIElements

### public class UnityEngine.UIElements.PanelEventHandler
- Base: UnityEngine.EventSystems.UIBehaviour
- Interfaces: UnityEngine.EventSystems.IPointerMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.UIElements.IRuntimePanelComponent, UnityEngine.EventSystems.IPointerClickHandler

#### Fields
- private UnityEngine.Event m_Event
- private float m_LastClickTime
- private UnityEngine.UIElements.BaseRuntimePanel m_Panel
- private readonly UnityEngine.UIElements.PanelEventHandler.PointerEvent m_PointerEvent
- private bool m_Selecting
- private static UnityEngine.EventModifiers s_Modifiers

#### Properties
- private UnityEngine.UIElements.Focusable currentFocusedElement { get; }
- private UnityEngine.EventSystems.EventSystem eventSystem { get; }
- private bool isCurrentFocusedPanel { get; }
- public UnityEngine.UIElements.IPanel panel { get; set; }
- private UnityEngine.GameObject selectableGameObject { get; }

#### Constructors
- public PanelEventHandler()

#### Methods
- private void LateUpdate()
- public void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
- public void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
- protected override void OnDisable()
- private void OnElementBlur(UnityEngine.UIElements.BlurEvent e)
- private void OnElementFocus(UnityEngine.UIElements.FocusEvent e)
- protected override void OnEnable()
- public void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
- private void OnPanelDestroyed()
- public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
- public void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
- private void ProcessImguiEvents(UnityEngine.UIElements.Focusable target)
- private void ProcessKeyboardEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target)
- private void ProcessTabEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target)
- private bool ReadPointerData(UnityEngine.UIElements.PanelEventHandler.PointerEvent pe, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType = Default)
- private void RegisterCallbacks()
- private void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.EventSystems.BaseEventData sourceEventData)
- private void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.Event sourceEvent)
- private void SendKeyDownEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target)
- private void SendKeyUpEvent(UnityEngine.Event e, UnityEngine.UIElements.Focusable target)
- private void SendTabEvent(UnityEngine.Event e, UnityEngine.UIElements.NavigationMoveEvent.Direction direction, UnityEngine.UIElements.Focusable target)
- private void UnregisterCallbacks()
- internal void Update()

### public class UnityEngine.UIElements.PanelRaycaster
- Base: UnityEngine.EventSystems.BaseRaycaster
- Interfaces: UnityEngine.UIElements.IRuntimePanelComponent

#### Fields
- private UnityEngine.UIElements.BaseRuntimePanel m_Panel

#### Properties
- public UnityEngine.Camera eventCamera { get; }
- public UnityEngine.UIElements.IPanel panel { get; set; }
- public int renderOrderPriority { get; }
- private UnityEngine.GameObject selectableGameObject { get; }
- public int sortOrderPriority { get; }

#### Constructors
- public PanelRaycaster()

#### Methods
- private void OnPanelDestroyed()
- public override void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
- private void RegisterCallbacks()
- private void UnregisterCallbacks()

### private class UnityEngine.UIElements.PanelEventHandler.PointerEvent
- Interfaces: UnityEngine.UIElements.IPointerEvent

#### Fields
- private float <altitudeAngle>k__BackingField
- private float <azimuthAngle>k__BackingField
- private int <button>k__BackingField
- private int <clickCount>k__BackingField
- private UnityEngine.Vector3 <deltaPosition>k__BackingField
- private float <deltaTime>k__BackingField
- private bool <isPrimary>k__BackingField
- private UnityEngine.Vector3 <localPosition>k__BackingField
- private UnityEngine.EventModifiers <modifiers>k__BackingField
- private UnityEngine.PenStatus <penStatus>k__BackingField
- private int <pointerId>k__BackingField
- private string <pointerType>k__BackingField
- private UnityEngine.Vector3 <position>k__BackingField
- private int <pressedButtons>k__BackingField
- private float <pressure>k__BackingField
- private UnityEngine.Vector2 <radius>k__BackingField
- private UnityEngine.Vector2 <radiusVariance>k__BackingField
- private float <tangentialPressure>k__BackingField
- private UnityEngine.Vector2 <tilt>k__BackingField
- private float <twist>k__BackingField

#### Properties
- public bool actionKey { get; }
- public float altitudeAngle { get; private set; }
- public bool altKey { get; }
- public float azimuthAngle { get; private set; }
- public int button { get; private set; }
- public int clickCount { get; private set; }
- public bool commandKey { get; }
- public bool ctrlKey { get; }
- public UnityEngine.Vector3 deltaPosition { get; private set; }
- public float deltaTime { get; private set; }
- public bool isPrimary { get; private set; }
- public UnityEngine.Vector3 localPosition { get; private set; }
- public UnityEngine.EventModifiers modifiers { get; private set; }
- public UnityEngine.PenStatus penStatus { get; private set; }
- public int pointerId { get; private set; }
- public string pointerType { get; private set; }
- public UnityEngine.Vector3 position { get; private set; }
- public int pressedButtons { get; private set; }
- public float pressure { get; private set; }
- public UnityEngine.Vector2 radius { get; private set; }
- public UnityEngine.Vector2 radiusVariance { get; private set; }
- public bool shiftKey { get; }
- public float tangentialPressure { get; private set; }
- public UnityEngine.Vector2 tilt { get; private set; }
- public float twist { get; private set; }

#### Constructors
- public PanelEventHandler.PointerEvent()

#### Methods
- internal static bool <Read>g__InRange|90_0(int i, int start, int count)
- public void Read(UnityEngine.UIElements.PanelEventHandler self, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType)
- public void SetPosition(UnityEngine.Vector3 positionOverride, UnityEngine.Vector3 deltaOverride)

### private enum UnityEngine.UIElements.PanelEventHandler.PointerEventType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Default = 0
- Down = 1
- Up = 2

