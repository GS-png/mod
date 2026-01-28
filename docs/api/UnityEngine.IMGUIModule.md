# Assembly: UnityEngine.IMGUIModule
- Path: EraWheel/lib/UnityEngine.IMGUIModule.dll
- Types: 70

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Methods
- internal static uint ComputeStringHash(string s)

## Namespace: UnityEngine

### public class UnityEngine.GUILayout.AreaScope
- Base: UnityEngine.GUI.Scope
- Interfaces: System.IDisposable

#### Constructors
- public GUILayout.AreaScope(UnityEngine.Rect screenRect)
- public GUILayout.AreaScope(UnityEngine.Rect screenRect, string text)
- public GUILayout.AreaScope(UnityEngine.Rect screenRect, UnityEngine.Texture image)
- public GUILayout.AreaScope(UnityEngine.Rect screenRect, UnityEngine.GUIContent content)
- public GUILayout.AreaScope(UnityEngine.Rect screenRect, string text, UnityEngine.GUIStyle style)
- public GUILayout.AreaScope(UnityEngine.Rect screenRect, UnityEngine.Texture image, UnityEngine.GUIStyle style)
- public GUILayout.AreaScope(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)

#### Methods
- protected override void CloseScope()

### internal struct UnityEngine.GUI.BackgroundColorScope
- Interfaces: System.IDisposable

#### Fields
- private bool m_Disposed
- private UnityEngine.Color m_PreviousColor

#### Constructors
- public GUI.BackgroundColorScope(UnityEngine.Color newColor)
- public GUI.BackgroundColorScope(float r, float g, float b, float a = 1)

#### Methods
- public void Dispose()

### private enum UnityEngine.TextEditor.CharacterType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LetterLike = 0
- Symbol = 1
- Symbol2 = 2
- WhiteSpace = 3

### private enum UnityEngine.TextSelectingUtilities.CharacterType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LetterLike = 0
- NewLine = 4
- Symbol = 1
- Symbol2 = 2
- WhiteSpace = 3

### public class UnityEngine.GUI.ClipScope
- Base: UnityEngine.GUI.Scope
- Interfaces: System.IDisposable

#### Constructors
- public GUI.ClipScope(UnityEngine.Rect position)
- internal GUI.ClipScope(UnityEngine.Rect position, UnityEngine.Vector2 scrollOffset)

#### Methods
- protected override void CloseScope()

### internal struct UnityEngine.GUI.ColorScope
- Interfaces: System.IDisposable

#### Fields
- private bool m_Disposed
- private UnityEngine.Color m_PreviousColor

#### Constructors
- public GUI.ColorScope(UnityEngine.Color newColor)
- public GUI.ColorScope(float r, float g, float b, float a = 1)

#### Methods
- public void Dispose()

### internal delegate UnityEngine.GUI.CustomSelectionGridItemGUI
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public GUI.CustomSelectionGridItemGUI(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(int item, UnityEngine.Rect rect, UnityEngine.GUIStyle style, int controlID, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(int item, UnityEngine.Rect rect, UnityEngine.GUIStyle style, int controlID)

### public enum UnityEngine.TextEditor.DblClickSnapping
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- PARAGRAPHS = 1
- WORDS = 0

### private enum UnityEngine.TextEditor.Direction
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Backward = 1
- Forward = 0

### private enum UnityEngine.TextSelectingUtilities.Direction
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Backward = 1
- Forward = 0

### public class UnityEngine.Event

#### Fields
- internal System.IntPtr m_Ptr
- private static UnityEngine.Event s_Current
- private static UnityEngine.Event s_MasterEvent

#### Properties
- public bool alt { get; set; }
- public int button { get; set; }
- public bool capsLock { get; set; }
- public char character { get; set; }
- public int clickCount { get; set; }
- public bool command { get; set; }
- public string commandName { get; set; }
- public bool control { get; set; }
- public static UnityEngine.Event current { get; set; }
- public UnityEngine.Vector2 delta { get; set; }
- public int displayIndex { get; set; }
- public bool functionKey { get; }
- internal bool isDirectManipulationDevice { get; }
- public bool isKey { get; }
- public bool isMouse { get; }
- public bool isScrollWheel { get; }
- public UnityEngine.KeyCode keyCode { get; set; }
- public UnityEngine.EventModifiers modifiers { get; set; }
- public UnityEngine.Vector2 mousePosition { get; set; }
- public UnityEngine.Ray mouseRay { get; set; }
- public bool numeric { get; set; }
- public UnityEngine.PenStatus penStatus { get; set; }
- public UnityEngine.PointerType pointerType { get; set; }
- public float pressure { get; set; }
- public UnityEngine.EventType rawType { get; }
- public bool shift { get; set; }
- public UnityEngine.Vector2 tilt { get; set; }
- public float twist { get; set; }
- public UnityEngine.EventType type { get; set; }

#### Constructors
- public Event()
- public Event(int displayIndex)
- public Event(UnityEngine.Event other)

#### Methods
- internal static void CleanupRoots()
- internal static void ClearEvents()
- internal void CopyFrom(UnityEngine.Event e)
- internal void CopyFromPtr(System.IntPtr ptr)
- public override bool Equals(object obj)
- protected override void Finalize()
- internal static int GetDoubleClickTime()
- public static int GetEventCount()
- public override int GetHashCode()
- public UnityEngine.EventType GetTypeForControl(int controlID)
- private static System.IntPtr Internal_Copy(System.IntPtr otherPtr)
- private static System.IntPtr Internal_Create(int displayIndex)
- private static void Internal_Destroy(System.IntPtr ptr)
- internal static void Internal_MakeMasterEventCurrent(int displayIndex)
- private static void Internal_SetNativeEvent(System.IntPtr ptr)
- private void Internal_Use()
- public static UnityEngine.Event KeyboardEvent(string key)
- public static bool PopEvent(UnityEngine.Event outEvent)
- internal static void QueueEvent(UnityEngine.Event outEvent)
- public override string ToString()
- public void Use()

### internal static class UnityEngine.EventCommandNames

#### Fields
- public static const string ColorPickerChanged
- public static const string Copy
- public static const string Cut
- public static const string Delete
- public static const string DeselectAll
- public static const string Duplicate
- public static const string EyeDropperCancelled
- public static const string EyeDropperClicked
- public static const string EyeDropperUpdate
- public static const string Find
- public static const string FrameSelected
- public static const string FrameSelectedWithLock
- public static const string InvertSelection
- public static const string ModifierKeysChanged
- public static const string NewKeyboardFocus
- public static const string OnLostFocus
- public static const string Paste
- public static const string Rename
- public static const string SelectAll
- public static const string SelectChildren
- public static const string SelectPrefabRoot
- public static const string SoftDelete
- public static const string UndoRedoPerformed

### internal struct UnityEngine.EventInterests

#### Fields
- private bool <wantsLessLayoutEvents>k__BackingField
- private bool <wantsMouseEnterLeaveWindow>k__BackingField
- private bool <wantsMouseMove>k__BackingField

#### Properties
- public bool wantsLessLayoutEvents { get; set; }
- public bool wantsMouseEnterLeaveWindow { get; set; }
- public bool wantsMouseMove { get; set; }

#### Methods
- public bool WantsEvent(UnityEngine.EventType type)
- public bool WantsLayoutPass(UnityEngine.EventType type)

### public enum UnityEngine.EventModifiers
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Alt = 4
- CapsLock = 32
- Command = 8
- Control = 2
- FunctionKey = 64
- None = 0
- Numeric = 16
- Shift = 1

### public enum UnityEngine.EventType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ContextClick = 16
- DragExited = 15
- DragPerform = 10
- dragPerform = 10
- DragUpdated = 9
- dragUpdated = 9
- ExecuteCommand = 14
- Ignore = 11
- ignore = 11
- KeyDown = 4
- keyDown = 4
- KeyUp = 5
- keyUp = 5
- Layout = 8
- layout = 8
- MouseDown = 0
- mouseDown = 0
- MouseDrag = 3
- mouseDrag = 3
- MouseEnterWindow = 20
- MouseLeaveWindow = 21
- MouseMove = 2
- mouseMove = 2
- MouseUp = 1
- mouseUp = 1
- Repaint = 7
- repaint = 7
- ScrollWheel = 6
- scrollWheel = 6
- TouchDown = 30
- TouchEnter = 33
- TouchLeave = 34
- TouchMove = 32
- TouchStationary = 35
- TouchUp = 31
- Used = 12
- used = 12
- ValidateCommand = 13

### public class UnityEngine.ExitGUIException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ExitGUIException()
- internal ExitGUIException(string message)

### public enum UnityEngine.FocusType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Keyboard = 1
- Native = 0
- Passive = 2

### public class UnityEngine.GUI.GroupScope
- Base: UnityEngine.GUI.Scope
- Interfaces: System.IDisposable

#### Constructors
- public GUI.GroupScope(UnityEngine.Rect position)
- public GUI.GroupScope(UnityEngine.Rect position, string text)
- public GUI.GroupScope(UnityEngine.Rect position, UnityEngine.Texture image)
- public GUI.GroupScope(UnityEngine.Rect position, UnityEngine.GUIContent content)
- public GUI.GroupScope(UnityEngine.Rect position, UnityEngine.GUIStyle style)
- public GUI.GroupScope(UnityEngine.Rect position, string text, UnityEngine.GUIStyle style)
- public GUI.GroupScope(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.GUIStyle style)

#### Methods
- protected override void CloseScope()

### public class UnityEngine.GUI

#### Fields
- private static System.DateTime <nextScrollStepTime>k__BackingField
- private static int <scrollTroughSide>k__BackingField
- private static UnityEngineInternal.GenericStack <scrollViewStates>k__BackingField
- private static readonly int s_BeginGroupHash
- private static readonly int s_BoxHash
- private static readonly int s_ButonHash
- private static readonly int s_ButtonGridHash
- private static int s_HotTextField
- private static readonly int s_RepeatButtonHash
- private static int s_ScrollControlId
- private static const float s_ScrollStepSize
- private static readonly int s_ScrollviewHash
- private static UnityEngine.GUISkin s_Skin
- private static readonly int s_SliderHash
- private static readonly int s_ToggleHash
- internal static UnityEngine.Rect s_ToolTipRect

#### Properties
- public static UnityEngine.Color backgroundColor { get; set; }
- internal static UnityEngine.Material blendMaterial { get; }
- internal static UnityEngine.Material blitMaterial { get; }
- public static bool changed { get; set; }
- public static UnityEngine.Color color { get; set; }
- public static UnityEngine.Color contentColor { get; set; }
- public static int depth { get; set; }
- public static bool enabled { get; set; }
- internal static bool isInsideList { get; set; }
- public static UnityEngine.Matrix4x4 matrix { get; set; }
- protected static string mouseTooltip { get; }
- internal static System.DateTime nextScrollStepTime { get; set; }
- internal static UnityEngine.Material roundedRectMaterial { get; }
- internal static UnityEngine.Material roundedRectWithColorPerBorderMaterial { get; }
- internal static int scrollTroughSide { get; set; }
- internal static UnityEngineInternal.GenericStack scrollViewStates { get; set; }
- public static UnityEngine.GUISkin skin { get; set; }
- public static string tooltip { get; set; }
- protected static UnityEngine.Rect tooltipRect { get; set; }
- internal static bool usePageScrollbars { get; }

#### Constructors
- private static GUI()
- public GUI()

#### Methods
- public static void BeginClip(UnityEngine.Rect position, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, bool resetOffset)
- public static void BeginClip(UnityEngine.Rect position)
- public static void BeginGroup(UnityEngine.Rect position)
- public static void BeginGroup(UnityEngine.Rect position, string text)
- public static void BeginGroup(UnityEngine.Rect position, UnityEngine.Texture image)
- public static void BeginGroup(UnityEngine.Rect position, UnityEngine.GUIContent content)
- public static void BeginGroup(UnityEngine.Rect position, UnityEngine.GUIStyle style)
- public static void BeginGroup(UnityEngine.Rect position, string text, UnityEngine.GUIStyle style)
- public static void BeginGroup(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.GUIStyle style)
- public static void BeginGroup(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- internal static void BeginGroup(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.Vector2 scrollOffset)
- public static UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect)
- public static UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical)
- public static UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar)
- public static UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar)
- internal static UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background)
- internal static void BeginWindows(int skinMode, int editorWindowInstanceID)
- public static void Box(UnityEngine.Rect position, string text)
- public static void Box(UnityEngine.Rect position, UnityEngine.Texture image)
- public static void Box(UnityEngine.Rect position, UnityEngine.GUIContent content)
- public static void Box(UnityEngine.Rect position, string text, UnityEngine.GUIStyle style)
- public static void Box(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.GUIStyle style)
- public static void Box(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- public static void BringWindowToBack(int windowID)
- public static void BringWindowToFront(int windowID)
- public static bool Button(UnityEngine.Rect position, string text)
- public static bool Button(UnityEngine.Rect position, UnityEngine.Texture image)
- public static bool Button(UnityEngine.Rect position, UnityEngine.GUIContent content)
- public static bool Button(UnityEngine.Rect position, string text, UnityEngine.GUIStyle style)
- public static bool Button(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.GUIStyle style)
- public static bool Button(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- internal static bool Button(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- private static UnityEngine.Rect[] CalcGridRects(UnityEngine.Rect position, UnityEngine.GUIContent[] contents, int xCount, float elemWidth, float elemHeight, UnityEngine.GUIStyle style, UnityEngine.GUIStyle firstStyle, UnityEngine.GUIStyle midStyle, UnityEngine.GUIStyle lastStyle, UnityEngine.GUI.ToolbarButtonSize buttonSize)
- private static UnityEngine.Rect[] CalcGridRectsFixedWidthFixedMargin(UnityEngine.Rect position, int itemCount, int itemsPerRow, float elemWidth, float elemHeight, float spacingHorizontal, float spacingVertical)
- internal static int CalcTotalHorizSpacing(int xCount, UnityEngine.GUIStyle style, UnityEngine.GUIStyle firstStyle, UnityEngine.GUIStyle midStyle, UnityEngine.GUIStyle lastStyle)
- internal static bool CalculateScaledTextureRects(UnityEngine.Rect position, UnityEngine.ScaleMode scaleMode, float imageAspect, ref UnityEngine.Rect outScreenRect, ref UnityEngine.Rect outSourceRect)
- internal static void CallWindowDelegate(UnityEngine.GUI.WindowFunction func, int id, int instanceID, UnityEngine.GUISkin _skin, int forceRect, float width, float height, UnityEngine.GUIStyle style)
- internal static void CleanupRoots()
- protected static UnityEngine.Vector2 DoBeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background)
- internal static bool DoButton(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- private static int DoButtonGrid(UnityEngine.Rect position, int selected, UnityEngine.GUIContent[] contents, string[] controlNames, int itemsPerRow, UnityEngine.GUIStyle style, UnityEngine.GUIStyle firstStyle, UnityEngine.GUIStyle midStyle, UnityEngine.GUIStyle lastStyle, UnityEngine.GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled = null)
- internal static bool DoControl(UnityEngine.Rect position, int id, bool on, bool hover, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- internal static int DoCustomSelectionGrid(UnityEngine.Rect position, int selected, int itemCount, UnityEngine.GUI.CustomSelectionGridItemGUI itemGUI, int itemsPerRow, UnityEngine.GUIStyle style)
- private static void DoLabel(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- private static UnityEngine.Rect DoModalWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUISkin skin)
- private static bool DoRepeatButton(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.FocusType focusType)
- internal static void DoSetSkin(UnityEngine.GUISkin newSkin)
- internal static void DoTextField(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style)
- internal static void DoTextField(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText)
- internal static void DoTextField(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText, char maskChar)
- internal static bool DoToggle(UnityEngine.Rect position, int id, bool value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- private static UnityEngine.Rect DoWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, UnityEngine.GUISkin skin, bool forceRectOnLayout)
- public static void DragWindow(UnityEngine.Rect position)
- public static void DragWindow()
- private static void DragWindow_Injected(ref UnityEngine.Rect position)
- public static void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image)
- public static void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode)
- public static void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend)
- public static void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend, float imageAspect)
- public static void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend, float imageAspect, UnityEngine.Color color, float borderWidth, float borderRadius)
- public static void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend, float imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, float borderRadius)
- public static void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend, float imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses)
- internal static void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend, float imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses, bool drawSmoothCorners)
- internal static void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend, float imageAspect, UnityEngine.Color leftColor, UnityEngine.Color topColor, UnityEngine.Color rightColor, UnityEngine.Color bottomColor, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses)
- internal static void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend, float imageAspect, UnityEngine.Color leftColor, UnityEngine.Color topColor, UnityEngine.Color rightColor, UnityEngine.Color bottomColor, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses, bool drawSmoothCorners)
- public static void DrawTextureWithTexCoords(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.Rect texCoords)
- public static void DrawTextureWithTexCoords(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.Rect texCoords, bool alphaBlend)
- public static void EndClip()
- public static void EndGroup()
- public static void EndScrollView()
- public static void EndScrollView(bool handleScrollWheel)
- internal static void EndWindows()
- internal static void FindStyles(ref UnityEngine.GUIStyle style, out UnityEngine.GUIStyle firstStyle, out UnityEngine.GUIStyle midStyle, out UnityEngine.GUIStyle lastStyle, string first, string mid, string last)
- public static void FocusControl(string name)
- public static void FocusWindow(int windowID)
- public static string GetNameOfFocusedControl()
- internal static UnityEngine.ScrollViewState GetTopScrollView()
- internal static void GrabMouseControl(int id)
- private static void HandleTextFieldEventForDesktop(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, UnityEngine.TextEditor editor)
- private static void HandleTextFieldEventForDesktopWithForcedKeyboard(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText, UnityEngine.TextEditor editor)
- private static void HandleTextFieldEventForTouchscreen(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText, char maskChar, UnityEngine.TextEditor editor)
- internal static bool HasMouseControl(int id)
- public static float HorizontalScrollbar(UnityEngine.Rect position, float value, float size, float leftValue, float rightValue)
- public static float HorizontalScrollbar(UnityEngine.Rect position, float value, float size, float leftValue, float rightValue, UnityEngine.GUIStyle style)
- public static float HorizontalSlider(UnityEngine.Rect position, float value, float leftValue, float rightValue)
- public static float HorizontalSlider(UnityEngine.Rect position, float value, float leftValue, float rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb)
- public static float HorizontalSlider(UnityEngine.Rect position, float value, float leftValue, float rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, UnityEngine.GUIStyle thumbExtent)
- internal static void InternalRepaintEditorWindow()
- private static void Internal_BeginWindows()
- internal static string Internal_Concatenate(UnityEngine.GUIContent first, UnityEngine.GUIContent second)
- private static UnityEngine.Rect Internal_DoModalWindow(int id, int instanceID, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, object skin)
- private static void Internal_DoModalWindow_Injected(int id, int instanceID, ref UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, object skin, out UnityEngine.Rect ret)
- private static UnityEngine.Rect Internal_DoWindow(int id, int instanceID, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, object skin, bool forceRectOnLayout)
- private static void Internal_DoWindow_Injected(int id, int instanceID, ref UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, object skin, bool forceRectOnLayout, out UnityEngine.Rect ret)
- private static void Internal_EndWindows()
- private static string Internal_GetMouseTooltip()
- private static string Internal_GetTooltip()
- private static void Internal_SetTooltip(string value)
- public static void Label(UnityEngine.Rect position, string text)
- public static void Label(UnityEngine.Rect position, UnityEngine.Texture image)
- public static void Label(UnityEngine.Rect position, UnityEngine.GUIContent content)
- public static void Label(UnityEngine.Rect position, string text, UnityEngine.GUIStyle style)
- public static void Label(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.GUIStyle style)
- public static void Label(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- public static UnityEngine.Rect ModalWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, string text)
- public static UnityEngine.Rect ModalWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.Texture image)
- public static UnityEngine.Rect ModalWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent content)
- public static UnityEngine.Rect ModalWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, string text, UnityEngine.GUIStyle style)
- public static UnityEngine.Rect ModalWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.Texture image, UnityEngine.GUIStyle style)
- public static UnityEngine.Rect ModalWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- public static string PasswordField(UnityEngine.Rect position, string password, char maskChar)
- public static string PasswordField(UnityEngine.Rect position, string password, char maskChar, int maxLength)
- public static string PasswordField(UnityEngine.Rect position, string password, char maskChar, UnityEngine.GUIStyle style)
- public static string PasswordField(UnityEngine.Rect position, string password, char maskChar, int maxLength, UnityEngine.GUIStyle style)
- internal static string PasswordFieldGetStrToShow(string password, char maskChar)
- internal static void ReleaseMouseControl()
- public static bool RepeatButton(UnityEngine.Rect position, string text)
- public static bool RepeatButton(UnityEngine.Rect position, UnityEngine.Texture image)
- public static bool RepeatButton(UnityEngine.Rect position, UnityEngine.GUIContent content)
- public static bool RepeatButton(UnityEngine.Rect position, string text, UnityEngine.GUIStyle style)
- public static bool RepeatButton(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.GUIStyle style)
- public static bool RepeatButton(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- internal static float Scroller(UnityEngine.Rect position, float value, float size, float leftValue, float rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, UnityEngine.GUIStyle leftButton, UnityEngine.GUIStyle rightButton, bool horiz)
- internal static bool ScrollerRepeatButton(int scrollerID, UnityEngine.Rect rect, UnityEngine.GUIStyle style)
- public static void ScrollTo(UnityEngine.Rect position)
- public static bool ScrollTowards(UnityEngine.Rect position, float maxDelta)
- public static int SelectionGrid(UnityEngine.Rect position, int selected, string[] texts, int xCount)
- public static int SelectionGrid(UnityEngine.Rect position, int selected, UnityEngine.Texture[] images, int xCount)
- public static int SelectionGrid(UnityEngine.Rect position, int selected, UnityEngine.GUIContent[] content, int xCount)
- public static int SelectionGrid(UnityEngine.Rect position, int selected, string[] texts, int xCount, UnityEngine.GUIStyle style)
- public static int SelectionGrid(UnityEngine.Rect position, int selected, UnityEngine.Texture[] images, int xCount, UnityEngine.GUIStyle style)
- public static int SelectionGrid(UnityEngine.Rect position, int selected, UnityEngine.GUIContent[] contents, int xCount, UnityEngine.GUIStyle style)
- public static void SetNextControlName(string name)
- public static float Slider(UnityEngine.Rect position, float value, float size, float start, float end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, bool horiz, int id, UnityEngine.GUIStyle thumbExtent = null)
- public static string TextArea(UnityEngine.Rect position, string text)
- public static string TextArea(UnityEngine.Rect position, string text, int maxLength)
- public static string TextArea(UnityEngine.Rect position, string text, UnityEngine.GUIStyle style)
- public static string TextArea(UnityEngine.Rect position, string text, int maxLength, UnityEngine.GUIStyle style)
- public static string TextField(UnityEngine.Rect position, string text)
- public static string TextField(UnityEngine.Rect position, string text, int maxLength)
- public static string TextField(UnityEngine.Rect position, string text, UnityEngine.GUIStyle style)
- public static string TextField(UnityEngine.Rect position, string text, int maxLength, UnityEngine.GUIStyle style)
- public static bool Toggle(UnityEngine.Rect position, bool value, string text)
- public static bool Toggle(UnityEngine.Rect position, bool value, UnityEngine.Texture image)
- public static bool Toggle(UnityEngine.Rect position, bool value, UnityEngine.GUIContent content)
- public static bool Toggle(UnityEngine.Rect position, bool value, string text, UnityEngine.GUIStyle style)
- public static bool Toggle(UnityEngine.Rect position, bool value, UnityEngine.Texture image, UnityEngine.GUIStyle style)
- public static bool Toggle(UnityEngine.Rect position, bool value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- public static bool Toggle(UnityEngine.Rect position, int id, bool value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- public static int Toolbar(UnityEngine.Rect position, int selected, string[] texts)
- public static int Toolbar(UnityEngine.Rect position, int selected, UnityEngine.Texture[] images)
- public static int Toolbar(UnityEngine.Rect position, int selected, UnityEngine.GUIContent[] contents)
- public static int Toolbar(UnityEngine.Rect position, int selected, string[] texts, UnityEngine.GUIStyle style)
- public static int Toolbar(UnityEngine.Rect position, int selected, UnityEngine.Texture[] images, UnityEngine.GUIStyle style)
- public static int Toolbar(UnityEngine.Rect position, int selected, UnityEngine.GUIContent[] contents, UnityEngine.GUIStyle style)
- public static int Toolbar(UnityEngine.Rect position, int selected, UnityEngine.GUIContent[] contents, UnityEngine.GUIStyle style, UnityEngine.GUI.ToolbarButtonSize buttonSize)
- internal static int Toolbar(UnityEngine.Rect position, int selected, UnityEngine.GUIContent[] contents, string[] controlNames, UnityEngine.GUIStyle style, UnityEngine.GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled = null)
- public static void UnfocusWindow()
- public static float VerticalScrollbar(UnityEngine.Rect position, float value, float size, float topValue, float bottomValue)
- public static float VerticalScrollbar(UnityEngine.Rect position, float value, float size, float topValue, float bottomValue, UnityEngine.GUIStyle style)
- public static float VerticalSlider(UnityEngine.Rect position, float value, float topValue, float bottomValue)
- public static float VerticalSlider(UnityEngine.Rect position, float value, float topValue, float bottomValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb)
- public static float VerticalSlider(UnityEngine.Rect position, float value, float topValue, float bottomValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, UnityEngine.GUIStyle thumbExtent)
- public static UnityEngine.Rect Window(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, string text)
- public static UnityEngine.Rect Window(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.Texture image)
- public static UnityEngine.Rect Window(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent content)
- public static UnityEngine.Rect Window(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, string text, UnityEngine.GUIStyle style)
- public static UnityEngine.Rect Window(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.Texture image, UnityEngine.GUIStyle style)
- public static UnityEngine.Rect Window(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style)

### internal class UnityEngine.GUIAspectSizer
- Base: UnityEngine.GUILayoutEntry

#### Fields
- private float aspect

#### Constructors
- public GUIAspectSizer(float aspect, UnityEngine.GUILayoutOption[] options)

#### Methods
- public override void CalcHeight()

### internal class UnityEngine.GUIClip

#### Properties
- internal static bool enabled { get; }
- internal static UnityEngine.Rect topmostRect { get; }
- internal static UnityEngine.Rect visibleRect { get; }

#### Constructors
- public GUIClip()

#### Methods
- public static UnityEngine.Vector2 Clip(UnityEngine.Vector2 absolutePos)
- public static UnityEngine.Rect Clip(UnityEngine.Rect absoluteRect)
- public static UnityEngine.Vector2 ClipToWindow(UnityEngine.Vector2 absolutePos)
- public static UnityEngine.Rect ClipToWindow(UnityEngine.Rect absoluteRect)
- private static UnityEngine.Rect ClipToWindow_Rect(UnityEngine.Rect absoluteRect)
- private static void ClipToWindow_Rect_Injected(ref UnityEngine.Rect absoluteRect, out UnityEngine.Rect ret)
- private static UnityEngine.Vector2 ClipToWindow_Vector2(UnityEngine.Vector2 absolutePos)
- private static void ClipToWindow_Vector2_Injected(ref UnityEngine.Vector2 absolutePos, out UnityEngine.Vector2 ret)
- private static UnityEngine.Vector2 Clip_Vector2(UnityEngine.Vector2 absolutePos)
- private static void Clip_Vector2_Injected(ref UnityEngine.Vector2 absolutePos, out UnityEngine.Vector2 ret)
- public static UnityEngine.Vector2 GetAbsoluteMousePosition()
- internal static UnityEngine.Matrix4x4 GetMatrix()
- private static void GetMatrix_Injected(out UnityEngine.Matrix4x4 ret)
- internal static UnityEngine.Matrix4x4 GetParentMatrix()
- private static void GetParentMatrix_Injected(out UnityEngine.Matrix4x4 ret)
- internal static UnityEngine.Rect GetTopRect()
- private static void GetTopRect_Injected(out UnityEngine.Rect ret)
- private static UnityEngine.Rect Internal_Clip_Rect(UnityEngine.Rect absoluteRect)
- private static void Internal_Clip_Rect_Injected(ref UnityEngine.Rect absoluteRect, out UnityEngine.Rect ret)
- private static UnityEngine.Vector2 Internal_GetAbsoluteMousePosition()
- private static void Internal_GetAbsoluteMousePosition_Injected(out UnityEngine.Vector2 ret)
- internal static int Internal_GetCount()
- internal static void Internal_Pop()
- internal static void Internal_PopParentClip()
- internal static void Internal_Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, bool resetOffset)
- internal static void Internal_PushParentClip(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect)
- internal static void Internal_PushParentClip(UnityEngine.Matrix4x4 renderTransform, UnityEngine.Matrix4x4 inputTransform, UnityEngine.Rect clipRect)
- private static void Internal_PushParentClip_Injected(ref UnityEngine.Matrix4x4 renderTransform, ref UnityEngine.Matrix4x4 inputTransform, ref UnityEngine.Rect clipRect)
- private static void Internal_Push_Injected(ref UnityEngine.Rect screenRect, ref UnityEngine.Vector2 scrollOffset, ref UnityEngine.Vector2 renderOffset, bool resetOffset)
- internal static void Pop()
- internal static void Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, bool resetOffset)
- internal static void Reapply()
- internal static void SetMatrix(UnityEngine.Matrix4x4 m)
- private static void SetMatrix_Injected(ref UnityEngine.Matrix4x4 m)
- public static UnityEngine.Vector2 Unclip(UnityEngine.Vector2 pos)
- public static UnityEngine.Rect Unclip(UnityEngine.Rect rect)
- public static UnityEngine.Vector2 UnclipToWindow(UnityEngine.Vector2 pos)
- public static UnityEngine.Rect UnclipToWindow(UnityEngine.Rect rect)
- private static UnityEngine.Rect UnclipToWindow_Rect(UnityEngine.Rect rect)
- private static void UnclipToWindow_Rect_Injected(ref UnityEngine.Rect rect, out UnityEngine.Rect ret)
- private static UnityEngine.Vector2 UnclipToWindow_Vector2(UnityEngine.Vector2 pos)
- private static void UnclipToWindow_Vector2_Injected(ref UnityEngine.Vector2 pos, out UnityEngine.Vector2 ret)
- private static UnityEngine.Rect Unclip_Rect(UnityEngine.Rect rect)
- private static void Unclip_Rect_Injected(ref UnityEngine.Rect rect, out UnityEngine.Rect ret)
- private static UnityEngine.Vector2 Unclip_Vector2(UnityEngine.Vector2 pos)
- private static void Unclip_Vector2_Injected(ref UnityEngine.Vector2 pos, out UnityEngine.Vector2 ret)

### public class UnityEngine.GUIContent

#### Fields
- private UnityEngine.Texture m_Image
- private string m_Text
- private string m_Tooltip
- public static UnityEngine.GUIContent none
- private System.Action OnTextChanged
- private static readonly UnityEngine.GUIContent s_Image
- private static readonly UnityEngine.GUIContent s_Text
- private static readonly UnityEngine.GUIContent s_TextImage

#### Properties
- internal int hash { get; }
- public UnityEngine.Texture image { get; set; }
- public string text { get; set; }
- public string tooltip { get; set; }

#### Events
- internal event System.Action OnTextChanged

#### Constructors
- public GUIContent()
- private static GUIContent()
- public GUIContent(string text)
- public GUIContent(UnityEngine.Texture image)
- public GUIContent(UnityEngine.GUIContent src)
- public GUIContent(string text, UnityEngine.Texture image)
- public GUIContent(string text, string tooltip)
- public GUIContent(UnityEngine.Texture image, string tooltip)
- public GUIContent(string text, UnityEngine.Texture image, string tooltip)

#### Methods
- internal static void ClearStaticCache()
- internal static UnityEngine.GUIContent Temp(string t)
- internal static UnityEngine.GUIContent Temp(string t, string tooltip)
- internal static UnityEngine.GUIContent Temp(UnityEngine.Texture i)
- internal static UnityEngine.GUIContent Temp(UnityEngine.Texture i, string tooltip)
- internal static UnityEngine.GUIContent Temp(string t, UnityEngine.Texture i)
- internal static UnityEngine.GUIContent[] Temp(string[] texts)
- internal static UnityEngine.GUIContent[] Temp(UnityEngine.Texture[] images)
- public override string ToString()

### internal class UnityEngine.GUIDebugger

#### Properties
- public static bool active { get; }

#### Constructors
- public GUIDebugger()

#### Methods
- public static void LogBeginProperty(string targetTypeAssemblyQualifiedName, string path, UnityEngine.Rect position)
- private static void LogBeginProperty_Injected(string targetTypeAssemblyQualifiedName, string path, ref UnityEngine.Rect position)
- public static void LogEndProperty()
- public static void LogLayoutEndGroup()
- public static void LogLayoutEntry(UnityEngine.Rect rect, int left, int right, int top, int bottom, UnityEngine.GUIStyle style)
- private static void LogLayoutEntry_Injected(ref UnityEngine.Rect rect, int left, int right, int top, int bottom, UnityEngine.GUIStyle style)
- public static void LogLayoutGroupEntry(UnityEngine.Rect rect, int left, int right, int top, int bottom, UnityEngine.GUIStyle style, bool isVertical)
- private static void LogLayoutGroupEntry_Injected(ref UnityEngine.Rect rect, int left, int right, int top, int bottom, UnityEngine.GUIStyle style, bool isVertical)

### public class UnityEngine.GUIElement

#### Constructors
- public GUIElement()

#### Methods
- private static void FeatureRemoved()
- public UnityEngine.Rect GetScreenRect(UnityEngine.Camera camera)
- public UnityEngine.Rect GetScreenRect()
- public bool HitTest(UnityEngine.Vector3 screenPosition)
- public bool HitTest(UnityEngine.Vector3 screenPosition, UnityEngine.Camera camera)

### internal class UnityEngine.GUIGridSizer
- Base: UnityEngine.GUILayoutEntry

#### Fields
- private readonly int m_Count
- private readonly float m_MaxButtonHeight
- private readonly float m_MaxButtonWidth
- private readonly float m_MinButtonHeight
- private readonly float m_MinButtonWidth
- private readonly int m_XCount

#### Properties
- private int rows { get; }

#### Constructors
- private GUIGridSizer(UnityEngine.GUIContent[] contents, int xCount, UnityEngine.GUIStyle buttonStyle, UnityEngine.GUILayoutOption[] options)

#### Methods
- public static UnityEngine.Rect GetRect(UnityEngine.GUIContent[] contents, int xCount, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)

### public class UnityEngine.GUILayer

#### Constructors
- public GUILayer()

#### Methods
- public UnityEngine.GUIElement HitTest(UnityEngine.Vector3 screenPosition)

### public class UnityEngine.GUILayout

#### Constructors
- public GUILayout()

#### Methods
- public static void BeginArea(UnityEngine.Rect screenRect)
- public static void BeginArea(UnityEngine.Rect screenRect, string text)
- public static void BeginArea(UnityEngine.Rect screenRect, UnityEngine.Texture image)
- public static void BeginArea(UnityEngine.Rect screenRect, UnityEngine.GUIContent content)
- public static void BeginArea(UnityEngine.Rect screenRect, UnityEngine.GUIStyle style)
- public static void BeginArea(UnityEngine.Rect screenRect, string text, UnityEngine.GUIStyle style)
- public static void BeginArea(UnityEngine.Rect screenRect, UnityEngine.Texture image, UnityEngine.GUIStyle style)
- public static void BeginArea(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- public static void BeginHorizontal(params UnityEngine.GUILayoutOption[] options)
- public static void BeginHorizontal(UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static void BeginHorizontal(string text, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static void BeginHorizontal(UnityEngine.Texture image, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static void BeginHorizontal(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, UnityEngine.GUIStyle style)
- public static UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background, params UnityEngine.GUILayoutOption[] options)
- public static void BeginVertical(params UnityEngine.GUILayoutOption[] options)
- public static void BeginVertical(UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static void BeginVertical(string text, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static void BeginVertical(UnityEngine.Texture image, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static void BeginVertical(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static void Box(UnityEngine.Texture image, params UnityEngine.GUILayoutOption[] options)
- public static void Box(string text, params UnityEngine.GUILayoutOption[] options)
- public static void Box(UnityEngine.GUIContent content, params UnityEngine.GUILayoutOption[] options)
- public static void Box(UnityEngine.Texture image, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static void Box(string text, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static void Box(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static bool Button(UnityEngine.Texture image, params UnityEngine.GUILayoutOption[] options)
- public static bool Button(string text, params UnityEngine.GUILayoutOption[] options)
- public static bool Button(UnityEngine.GUIContent content, params UnityEngine.GUILayoutOption[] options)
- public static bool Button(UnityEngine.Texture image, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static bool Button(string text, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static bool Button(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- private static void DoBox(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
- private static bool DoButton(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
- private static float DoHorizontalSlider(float value, float leftValue, float rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, UnityEngine.GUILayoutOption[] options)
- private static void DoLabel(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
- private static bool DoRepeatButton(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
- private static string DoTextField(string text, int maxLength, bool multiline, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
- private static bool DoToggle(bool value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
- private static float DoVerticalSlider(float value, float leftValue, float rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, params UnityEngine.GUILayoutOption[] options)
- private static UnityEngine.Rect DoWindow(int id, UnityEngine.Rect screenRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
- public static void EndArea()
- public static void EndHorizontal()
- public static void EndScrollView()
- internal static void EndScrollView(bool handleScrollWheel)
- public static void EndVertical()
- public static UnityEngine.GUILayoutOption ExpandHeight(bool expand)
- public static UnityEngine.GUILayoutOption ExpandWidth(bool expand)
- public static void FlexibleSpace()
- public static UnityEngine.GUILayoutOption Height(float height)
- public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, params UnityEngine.GUILayoutOption[] options)
- public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static float HorizontalSlider(float value, float leftValue, float rightValue, params UnityEngine.GUILayoutOption[] options)
- public static float HorizontalSlider(float value, float leftValue, float rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, params UnityEngine.GUILayoutOption[] options)
- public static void Label(UnityEngine.Texture image, params UnityEngine.GUILayoutOption[] options)
- public static void Label(string text, params UnityEngine.GUILayoutOption[] options)
- public static void Label(UnityEngine.GUIContent content, params UnityEngine.GUILayoutOption[] options)
- public static void Label(UnityEngine.Texture image, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static void Label(string text, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static void Label(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.GUILayoutOption MaxHeight(float maxHeight)
- public static UnityEngine.GUILayoutOption MaxWidth(float maxWidth)
- public static UnityEngine.GUILayoutOption MinHeight(float minHeight)
- public static UnityEngine.GUILayoutOption MinWidth(float minWidth)
- public static string PasswordField(string password, char maskChar, params UnityEngine.GUILayoutOption[] options)
- public static string PasswordField(string password, char maskChar, int maxLength, params UnityEngine.GUILayoutOption[] options)
- public static string PasswordField(string password, char maskChar, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static string PasswordField(string password, char maskChar, int maxLength, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static bool RepeatButton(UnityEngine.Texture image, params UnityEngine.GUILayoutOption[] options)
- public static bool RepeatButton(string text, params UnityEngine.GUILayoutOption[] options)
- public static bool RepeatButton(UnityEngine.GUIContent content, params UnityEngine.GUILayoutOption[] options)
- public static bool RepeatButton(UnityEngine.Texture image, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static bool RepeatButton(string text, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static bool RepeatButton(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static int SelectionGrid(int selected, string[] texts, int xCount, params UnityEngine.GUILayoutOption[] options)
- public static int SelectionGrid(int selected, UnityEngine.Texture[] images, int xCount, params UnityEngine.GUILayoutOption[] options)
- public static int SelectionGrid(int selected, UnityEngine.GUIContent[] content, int xCount, params UnityEngine.GUILayoutOption[] options)
- public static int SelectionGrid(int selected, string[] texts, int xCount, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static int SelectionGrid(int selected, UnityEngine.Texture[] images, int xCount, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static int SelectionGrid(int selected, UnityEngine.GUIContent[] contents, int xCount, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static void Space(float pixels)
- public static string TextArea(string text, params UnityEngine.GUILayoutOption[] options)
- public static string TextArea(string text, int maxLength, params UnityEngine.GUILayoutOption[] options)
- public static string TextArea(string text, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static string TextArea(string text, int maxLength, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static string TextField(string text, params UnityEngine.GUILayoutOption[] options)
- public static string TextField(string text, int maxLength, params UnityEngine.GUILayoutOption[] options)
- public static string TextField(string text, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static string TextField(string text, int maxLength, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static bool Toggle(bool value, UnityEngine.Texture image, params UnityEngine.GUILayoutOption[] options)
- public static bool Toggle(bool value, string text, params UnityEngine.GUILayoutOption[] options)
- public static bool Toggle(bool value, UnityEngine.GUIContent content, params UnityEngine.GUILayoutOption[] options)
- public static bool Toggle(bool value, UnityEngine.Texture image, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static bool Toggle(bool value, string text, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static bool Toggle(bool value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static int Toolbar(int selected, string[] texts, params UnityEngine.GUILayoutOption[] options)
- public static int Toolbar(int selected, UnityEngine.Texture[] images, params UnityEngine.GUILayoutOption[] options)
- public static int Toolbar(int selected, UnityEngine.GUIContent[] contents, params UnityEngine.GUILayoutOption[] options)
- public static int Toolbar(int selected, string[] texts, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static int Toolbar(int selected, UnityEngine.Texture[] images, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static int Toolbar(int selected, string[] texts, UnityEngine.GUIStyle style, UnityEngine.GUI.ToolbarButtonSize buttonSize, params UnityEngine.GUILayoutOption[] options)
- public static int Toolbar(int selected, UnityEngine.Texture[] images, UnityEngine.GUIStyle style, UnityEngine.GUI.ToolbarButtonSize buttonSize, params UnityEngine.GUILayoutOption[] options)
- public static int Toolbar(int selected, UnityEngine.GUIContent[] contents, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static int Toolbar(int selected, UnityEngine.GUIContent[] contents, UnityEngine.GUIStyle style, UnityEngine.GUI.ToolbarButtonSize buttonSize, params UnityEngine.GUILayoutOption[] options)
- public static int Toolbar(int selected, UnityEngine.GUIContent[] contents, bool[] enabled, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static int Toolbar(int selected, UnityEngine.GUIContent[] contents, bool[] enabled, UnityEngine.GUIStyle style, UnityEngine.GUI.ToolbarButtonSize buttonSize, params UnityEngine.GUILayoutOption[] options)
- public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, params UnityEngine.GUILayoutOption[] options)
- public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static float VerticalSlider(float value, float leftValue, float rightValue, params UnityEngine.GUILayoutOption[] options)
- public static float VerticalSlider(float value, float leftValue, float rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.GUILayoutOption Width(float width)
- public static UnityEngine.Rect Window(int id, UnityEngine.Rect screenRect, UnityEngine.GUI.WindowFunction func, string text, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Rect Window(int id, UnityEngine.Rect screenRect, UnityEngine.GUI.WindowFunction func, UnityEngine.Texture image, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Rect Window(int id, UnityEngine.Rect screenRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent content, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Rect Window(int id, UnityEngine.Rect screenRect, UnityEngine.GUI.WindowFunction func, string text, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Rect Window(int id, UnityEngine.Rect screenRect, UnityEngine.GUI.WindowFunction func, UnityEngine.Texture image, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Rect Window(int id, UnityEngine.Rect screenRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)

### internal class UnityEngine.GUILayoutEntry

#### Fields
- public bool consideredForMargin
- protected static int indent
- internal static UnityEngine.Rect kDummyRect
- public float maxHeight
- public float maxWidth
- public float minHeight
- public float minWidth
- private UnityEngine.GUIStyle m_Style
- public UnityEngine.Rect rect
- public int stretchHeight
- public int stretchWidth

#### Properties
- public int marginBottom { get; }
- public int marginHorizontal { get; }
- public int marginLeft { get; }
- public int marginRight { get; }
- public int marginTop { get; }
- public int marginVertical { get; }
- public UnityEngine.GUIStyle style { get; set; }

#### Constructors
- private static GUILayoutEntry()
- public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style)
- public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style, UnityEngine.GUILayoutOption[] options)

#### Methods
- public virtual void ApplyOptions(UnityEngine.GUILayoutOption[] options)
- protected virtual void ApplyStyleSettings(UnityEngine.GUIStyle style)
- public virtual void CalcHeight()
- public virtual void CalcWidth()
- public virtual void SetHorizontal(float x, float width)
- public virtual void SetVertical(float y, float height)
- public override string ToString()

### internal class UnityEngine.GUILayoutGroup
- Base: UnityEngine.GUILayoutEntry

#### Fields
- public System.Collections.Generic.List<UnityEngine.GUILayoutEntry> entries
- public bool isVertical
- public bool isWindow
- protected float m_ChildMaxHeight
- protected float m_ChildMaxWidth
- protected float m_ChildMinHeight
- protected float m_ChildMinWidth
- private int m_Cursor
- protected int m_MarginBottom
- protected int m_MarginLeft
- protected int m_MarginRight
- protected int m_MarginTop
- protected int m_StretchableCountX
- protected int m_StretchableCountY
- protected bool m_UserSpecifiedHeight
- protected bool m_UserSpecifiedWidth
- private static readonly UnityEngine.GUILayoutEntry none
- public bool resetCoords
- public bool sameSize
- public float spacing
- public int windowID

#### Properties
- public int marginBottom { get; }
- public int marginLeft { get; }
- public int marginRight { get; }
- public int marginTop { get; }

#### Constructors
- public GUILayoutGroup()
- private static GUILayoutGroup()
- public GUILayoutGroup(UnityEngine.GUIStyle _style, UnityEngine.GUILayoutOption[] options)

#### Methods
- public void Add(UnityEngine.GUILayoutEntry e)
- public override void ApplyOptions(UnityEngine.GUILayoutOption[] options)
- protected override void ApplyStyleSettings(UnityEngine.GUIStyle style)
- public override void CalcHeight()
- public override void CalcWidth()
- public UnityEngine.Rect GetLast()
- public UnityEngine.GUILayoutEntry GetNext()
- public UnityEngine.Rect PeekNext()
- public void ResetCursor()
- public override void SetHorizontal(float x, float width)
- public override void SetVertical(float y, float height)
- public override string ToString()

### public class UnityEngine.GUILayoutOption

#### Fields
- internal UnityEngine.GUILayoutOption.Type type
- internal object value

#### Constructors
- internal GUILayoutOption(UnityEngine.GUILayoutOption.Type type, object value)

### public class UnityEngine.GUILayoutUtility

#### Fields
- private static int <unbalancedgroupscount>k__BackingField
- internal static UnityEngine.GUILayoutUtility.LayoutCache current
- internal static readonly UnityEngine.Rect kDummyRect
- private static UnityEngine.GUIStyle s_SpaceStyle
- private static readonly System.Collections.Generic.Dictionary<int, UnityEngine.GUILayoutUtility.LayoutCache> s_StoredLayouts
- private static readonly System.Collections.Generic.Dictionary<int, UnityEngine.GUILayoutUtility.LayoutCache> s_StoredWindows

#### Properties
- internal static UnityEngine.GUIStyle spaceStyle { get; }
- internal static UnityEngine.GUILayoutGroup topLevel { get; }
- internal static int unbalancedgroupscount { get; set; }

#### Constructors
- public GUILayoutUtility()
- private static GUILayoutUtility()

#### Methods
- internal static void Begin(int instanceID)
- internal static void BeginContainer(UnityEngine.GUILayoutUtility.LayoutCache cache)
- public static void BeginGroup(string GroupName)
- internal static UnityEngine.GUILayoutGroup BeginLayoutArea(UnityEngine.GUIStyle style, System.Type layoutType)
- internal static UnityEngine.GUILayoutGroup BeginLayoutGroup(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options, System.Type layoutType)
- internal static void BeginWindow(int windowID, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
- internal static void CleanupRoots()
- private static UnityEngine.GUILayoutGroup CreateGUILayoutGroupInstanceOfType(System.Type LayoutType)
- internal static UnityEngine.GUILayoutGroup DoBeginLayoutArea(UnityEngine.GUIStyle style, System.Type layoutType)
- private static UnityEngine.Rect DoGetAspectRect(float aspect, UnityEngine.GUILayoutOption[] options)
- private static UnityEngine.Rect DoGetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
- private static UnityEngine.Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
- public static void EndGroup(string groupName)
- internal static void EndLayoutArea()
- internal static void EndLayoutGroup()
- public static UnityEngine.Rect GetAspectRect(float aspect)
- public static UnityEngine.Rect GetAspectRect(float aspect, UnityEngine.GUIStyle style)
- public static UnityEngine.Rect GetAspectRect(float aspect, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Rect GetAspectRect(float aspect, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Rect GetLastRect()
- internal static UnityEngine.GUILayoutUtility.LayoutCache GetLayoutCache(int instanceID, bool isWindow)
- public static UnityEngine.Rect GetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
- public static UnityEngine.Rect GetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Rect GetRect(float width, float height)
- public static UnityEngine.Rect GetRect(float width, float height, UnityEngine.GUIStyle style)
- public static UnityEngine.Rect GetRect(float width, float height, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Rect GetRect(float width, float height, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight)
- public static UnityEngine.Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, UnityEngine.GUIStyle style)
- public static UnityEngine.Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, params UnityEngine.GUILayoutOption[] options)
- public static UnityEngine.Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- internal static UnityEngine.Rect GetWindowsBounds()
- private static void GetWindowsBounds_Injected(out UnityEngine.Rect ret)
- private static UnityEngine.Rect Internal_GetWindowRect(int windowID)
- private static void Internal_GetWindowRect_Injected(int windowID, out UnityEngine.Rect ret)
- private static void Internal_MoveWindow(int windowID, UnityEngine.Rect r)
- private static void Internal_MoveWindow_Injected(int windowID, ref UnityEngine.Rect r)
- internal static void Layout()
- internal static void LayoutFreeGroup(UnityEngine.GUILayoutGroup toplevel)
- internal static void LayoutFromContainer(float w, float h)
- internal static void LayoutFromEditorWindow()
- internal static float LayoutFromInspector(float width)
- private static void LayoutSingleGroup(UnityEngine.GUILayoutGroup i)
- internal static void RemoveSelectedIdList(int instanceID, bool isWindow)
- internal static UnityEngine.GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow)

### internal class UnityEngine.GUIScrollGroup
- Base: UnityEngine.GUILayoutGroup

#### Fields
- public bool allowHorizontalScroll
- public bool allowVerticalScroll
- public float calcMaxHeight
- public float calcMaxWidth
- public float calcMinHeight
- public float calcMinWidth
- public float clientHeight
- public float clientWidth
- public UnityEngine.GUIStyle horizontalScrollbar
- public bool needsHorizontalScrollbar
- public bool needsVerticalScrollbar
- public UnityEngine.GUIStyle verticalScrollbar

#### Constructors
- public GUIScrollGroup()

#### Methods
- public override void CalcHeight()
- public override void CalcWidth()
- public override void SetHorizontal(float x, float width)
- public override void SetVertical(float y, float height)

### public class UnityEngine.GUISettings

#### Fields
- private UnityEngine.Color m_CursorColor
- private float m_CursorFlashSpeed
- private bool m_DoubleClickSelectsWord
- private UnityEngine.Color m_SelectionColor
- private bool m_TripleClickSelectsLine

#### Properties
- public UnityEngine.Color cursorColor { get; set; }
- public float cursorFlashSpeed { get; set; }
- public bool doubleClickSelectsWord { get; set; }
- public UnityEngine.Color selectionColor { get; set; }
- public bool tripleClickSelectsLine { get; set; }

#### Constructors
- public GUISettings()

#### Methods
- private static float Internal_GetCursorFlashSpeed()

### public class UnityEngine.GUISkin
- Base: UnityEngine.ScriptableObject

#### Fields
- internal static UnityEngine.GUISkin current
- internal static UnityEngine.GUIStyle ms_Error
- private UnityEngine.GUIStyle m_box
- private UnityEngine.GUIStyle m_button
- internal UnityEngine.GUIStyle[] m_CustomStyles
- private UnityEngine.Font m_Font
- private UnityEngine.GUIStyle m_horizontalScrollbar
- private UnityEngine.GUIStyle m_horizontalScrollbarLeftButton
- private UnityEngine.GUIStyle m_horizontalScrollbarRightButton
- private UnityEngine.GUIStyle m_horizontalScrollbarThumb
- private UnityEngine.GUIStyle m_horizontalSlider
- private UnityEngine.GUIStyle m_horizontalSliderThumb
- private UnityEngine.GUIStyle m_horizontalSliderThumbExtent
- private UnityEngine.GUIStyle m_label
- private UnityEngine.GUIStyle m_ScrollView
- private UnityEngine.GUISettings m_Settings
- internal static UnityEngine.GUISkin.SkinChangedDelegate m_SkinChanged
- private UnityEngine.GUIStyle m_SliderMixed
- private System.Collections.Generic.Dictionary<string, UnityEngine.GUIStyle> m_Styles
- private UnityEngine.GUIStyle m_textArea
- private UnityEngine.GUIStyle m_textField
- private UnityEngine.GUIStyle m_toggle
- private UnityEngine.GUIStyle m_verticalScrollbar
- private UnityEngine.GUIStyle m_verticalScrollbarDownButton
- private UnityEngine.GUIStyle m_verticalScrollbarThumb
- private UnityEngine.GUIStyle m_verticalScrollbarUpButton
- private UnityEngine.GUIStyle m_verticalSlider
- private UnityEngine.GUIStyle m_verticalSliderThumb
- private UnityEngine.GUIStyle m_verticalSliderThumbExtent
- private UnityEngine.GUIStyle m_window

#### Properties
- public UnityEngine.GUIStyle box { get; set; }
- public UnityEngine.GUIStyle button { get; set; }
- public UnityEngine.GUIStyle[] customStyles { get; set; }
- internal static UnityEngine.GUIStyle error { get; }
- public UnityEngine.Font font { get; set; }
- public UnityEngine.GUIStyle horizontalScrollbar { get; set; }
- public UnityEngine.GUIStyle horizontalScrollbarLeftButton { get; set; }
- public UnityEngine.GUIStyle horizontalScrollbarRightButton { get; set; }
- public UnityEngine.GUIStyle horizontalScrollbarThumb { get; set; }
- public UnityEngine.GUIStyle horizontalSlider { get; set; }
- public UnityEngine.GUIStyle horizontalSliderThumb { get; set; }
- internal UnityEngine.GUIStyle horizontalSliderThumbExtent { get; set; }
- public UnityEngine.GUIStyle label { get; set; }
- public UnityEngine.GUIStyle scrollView { get; set; }
- public UnityEngine.GUISettings settings { get; }
- internal UnityEngine.GUIStyle sliderMixed { get; set; }
- public UnityEngine.GUIStyle textArea { get; set; }
- public UnityEngine.GUIStyle textField { get; set; }
- public UnityEngine.GUIStyle toggle { get; set; }
- public UnityEngine.GUIStyle verticalScrollbar { get; set; }
- public UnityEngine.GUIStyle verticalScrollbarDownButton { get; set; }
- public UnityEngine.GUIStyle verticalScrollbarThumb { get; set; }
- public UnityEngine.GUIStyle verticalScrollbarUpButton { get; set; }
- public UnityEngine.GUIStyle verticalSlider { get; set; }
- public UnityEngine.GUIStyle verticalSliderThumb { get; set; }
- internal UnityEngine.GUIStyle verticalSliderThumbExtent { get; set; }
- public UnityEngine.GUIStyle window { get; set; }

#### Constructors
- public GUISkin()

#### Methods
- internal void Apply()
- private void BuildStyleCache()
- internal static void CleanupRoots()
- public UnityEngine.GUIStyle FindStyle(string styleName)
- public System.Collections.IEnumerator GetEnumerator()
- public UnityEngine.GUIStyle GetStyle(string styleName)
- internal void MakeCurrent()
- internal void OnEnable()

### internal class UnityEngine.GUIStateObjects

#### Fields
- private static System.Collections.Generic.Dictionary<int, object> s_StateCache

#### Constructors
- public GUIStateObjects()
- private static GUIStateObjects()

#### Methods
- internal static object GetStateObject(System.Type t, int controlID)
- internal static object QueryStateObject(System.Type t, int controlID)
- internal static void Tests_ClearObjects()

### public class UnityEngine.GUIStyle

#### Fields
- private UnityEngine.GUIStyleState m_Active
- private UnityEngine.RectOffset m_Border
- private UnityEngine.GUIStyleState m_Focused
- private UnityEngine.GUIStyleState m_Hover
- private UnityEngine.RectOffset m_Margin
- private string m_Name
- private UnityEngine.GUIStyleState m_Normal
- private UnityEngine.GUIStyleState m_OnActive
- private UnityEngine.GUIStyleState m_OnFocused
- private UnityEngine.GUIStyleState m_OnHover
- private UnityEngine.GUIStyleState m_OnNormal
- private UnityEngine.RectOffset m_Overflow
- private UnityEngine.RectOffset m_Padding
- internal System.IntPtr m_Ptr
- internal static bool showKeyboardFocus
- private static UnityEngine.GUIStyle s_None

#### Properties
- public UnityEngine.GUIStyleState active { get; set; }
- public UnityEngine.TextAnchor alignment { get; set; }
- public UnityEngine.RectOffset border { get; set; }
- public UnityEngine.Vector2 clipOffset { get; set; }
- public UnityEngine.TextClipping clipping { get; set; }
- public UnityEngine.Vector2 contentOffset { get; set; }
- public float fixedHeight { get; set; }
- public float fixedWidth { get; set; }
- public UnityEngine.GUIStyleState focused { get; set; }
- public UnityEngine.Font font { get; set; }
- public int fontSize { get; set; }
- public UnityEngine.FontStyle fontStyle { get; set; }
- public UnityEngine.GUIStyleState hover { get; set; }
- public UnityEngine.ImagePosition imagePosition { get; set; }
- internal UnityEngine.Vector2 Internal_clipOffset { get; set; }
- public bool isHeightDependantOnWidth { get; }
- public float lineHeight { get; }
- public UnityEngine.RectOffset margin { get; set; }
- public string name { get; set; }
- public static UnityEngine.GUIStyle none { get; }
- public UnityEngine.GUIStyleState normal { get; set; }
- public UnityEngine.GUIStyleState onActive { get; set; }
- public UnityEngine.GUIStyleState onFocused { get; set; }
- public UnityEngine.GUIStyleState onHover { get; set; }
- public UnityEngine.GUIStyleState onNormal { get; set; }
- public UnityEngine.RectOffset overflow { get; set; }
- public UnityEngine.RectOffset padding { get; set; }
- internal string rawName { get; set; }
- public bool richText { get; set; }
- public bool stretchHeight { get; set; }
- public bool stretchWidth { get; set; }
- public bool wordWrap { get; set; }

#### Constructors
- public GUIStyle()
- private static GUIStyle()
- public GUIStyle(UnityEngine.GUIStyle other)

#### Methods
- private void AssignRectOffset(int idx, System.IntPtr srcRectOffset)
- private void AssignStyleState(int idx, System.IntPtr srcStyleState)
- public float CalcHeight(UnityEngine.GUIContent content, float width)
- public void CalcMinMaxWidth(UnityEngine.GUIContent content, out float minWidth, out float maxWidth)
- public UnityEngine.Vector2 CalcScreenSize(UnityEngine.Vector2 contentSize)
- public UnityEngine.Vector2 CalcSize(UnityEngine.GUIContent content)
- internal UnityEngine.Vector2 CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 constraints)
- internal static void CleanupRoots()
- public void Draw(UnityEngine.Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
- public void Draw(UnityEngine.Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
- public void Draw(UnityEngine.Rect position, UnityEngine.Texture image, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
- public void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
- public void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID)
- public void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on)
- public void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on, bool hover)
- private void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
- public void DrawCursor(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, int character)
- internal void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, UnityEngine.Color selectionColor)
- internal void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition)
- public void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter)
- protected override void Finalize()
- public UnityEngine.Vector2 GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex)
- public int GetCursorStringIndex(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 cursorPixelPosition)
- internal int GetNumCharactersThatFitWithinWidth(string text, float width)
- private System.IntPtr GetRectOffsetPtr(int idx)
- private System.IntPtr GetStyleStatePtr(int idx)
- internal void InternalOnAfterDeserialize()
- private float Internal_CalcHeight(UnityEngine.GUIContent content, float width)
- private UnityEngine.Vector2 Internal_CalcMinMaxWidth(UnityEngine.GUIContent content)
- private void Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent content, out UnityEngine.Vector2 ret)
- internal UnityEngine.Vector2 Internal_CalcSize(UnityEngine.GUIContent content)
- internal UnityEngine.Vector2 Internal_CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 maxSize)
- private void Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent content, ref UnityEngine.Vector2 maxSize, out UnityEngine.Vector2 ret)
- private void Internal_CalcSize_Injected(UnityEngine.GUIContent content, out UnityEngine.Vector2 ret)
- private static System.IntPtr Internal_Copy(UnityEngine.GUIStyle self, UnityEngine.GUIStyle other)
- private static System.IntPtr Internal_Create(UnityEngine.GUIStyle self)
- private static void Internal_Destroy(System.IntPtr self)
- private void Internal_Draw(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
- private void Internal_Draw2(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on)
- private void Internal_Draw2_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on)
- private void Internal_DrawCursor(UnityEngine.Rect position, UnityEngine.GUIContent content, int pos, UnityEngine.Color cursorColor)
- private void Internal_DrawCursor_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, int pos, ref UnityEngine.Color cursorColor)
- private void Internal_DrawWithTextSelection(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, UnityEngine.Color cursorColor, UnityEngine.Color selectionColor)
- private void Internal_DrawWithTextSelection_Injected(ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref UnityEngine.Color cursorColor, ref UnityEngine.Color selectionColor)
- private void Internal_Draw_Injected(ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
- private static float Internal_GetCursorFlashOffset()
- internal UnityEngine.Vector2 Internal_GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex)
- private void Internal_GetCursorPixelPosition_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex, out UnityEngine.Vector2 ret)
- internal int Internal_GetCursorStringIndex(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 cursorPixelPosition)
- private int Internal_GetCursorStringIndex_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, ref UnityEngine.Vector2 cursorPixelPosition)
- internal UnityEngine.Rect[] Internal_GetHyperlinksRect(UnityEngine.Rect localPosition, UnityEngine.GUIContent mContent)
- private UnityEngine.Rect[] Internal_GetHyperlinksRect_Injected(ref UnityEngine.Rect localPosition, UnityEngine.GUIContent mContent)
- private static float Internal_GetLineHeight(System.IntPtr target)
- internal int Internal_GetNumCharactersThatFitWithinWidth(string text, float width)
- internal string Internal_GetSelectedRenderedText(UnityEngine.Rect localPosition, UnityEngine.GUIContent mContent, int selectIndex, int cursorIndex)
- private string Internal_GetSelectedRenderedText_Injected(ref UnityEngine.Rect localPosition, UnityEngine.GUIContent mContent, int selectIndex, int cursorIndex)
- internal static bool IsTooltipActive(string tooltip)
- public static UnityEngine.GUIStyle op_Implicit(string str)
- internal static void SetDefaultFont(UnityEngine.Font font)
- internal static void SetMouseTooltip(string tooltip, UnityEngine.Rect screenRect)
- private static void SetMouseTooltip_Injected(string tooltip, ref UnityEngine.Rect screenRect)
- public override string ToString()

### public class UnityEngine.GUIStyleState

#### Fields
- internal System.IntPtr m_Ptr
- private readonly UnityEngine.GUIStyle m_SourceStyle

#### Properties
- public UnityEngine.Texture2D background { get; set; }
- public UnityEngine.Color textColor { get; set; }

#### Constructors
- public GUIStyleState()
- private GUIStyleState(UnityEngine.GUIStyle sourceStyle, System.IntPtr source)

#### Methods
- private void Cleanup()
- protected override void Finalize()
- internal static UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle sourceStyle, System.IntPtr source)
- private static System.IntPtr Init()
- internal static UnityEngine.GUIStyleState ProduceGUIStyleStateFromDeserialization(UnityEngine.GUIStyle sourceStyle, System.IntPtr source)

### public class UnityEngine.GUITargetAttribute
- Base: System.Attribute

#### Fields
- internal int displayMask

#### Constructors
- public GUITargetAttribute()
- public GUITargetAttribute(int displayIndex)
- public GUITargetAttribute(int displayIndex, int displayIndex1)
- public GUITargetAttribute(int displayIndex, int displayIndex1, params int[] displayIndexList)

#### Methods
- private static int GetGUITargetAttrValue(System.Type klass, string methodName)

### public class UnityEngine.GUITexture

#### Properties
- public UnityEngine.RectOffset border { get; set; }
- public UnityEngine.Color color { get; set; }
- public UnityEngine.Rect pixelInset { get; set; }
- public UnityEngine.Texture texture { get; set; }

#### Constructors
- public GUITexture()

#### Methods
- private static void FeatureRemoved()

### public class UnityEngine.GUIUtility

#### Fields
- private static bool <guiIsExiting>k__BackingField
- internal static System.Action<UnityEngine.EventType, UnityEngine.KeyCode> beforeEventProcessed
- internal static System.Action cleanupRoots
- internal static System.Func<System.Exception, bool> endContainerGUIFromException
- internal static System.Action guiChanged
- private static UnityEngine.Event m_Event
- internal static System.Func<int, System.IntPtr, bool> processEvent
- internal static System.Action releaseCapture
- internal static int s_ControlCount
- internal static System.Func<bool> s_HasCurrentWindowKeyFocusFunc
- internal static int s_OriginalID
- internal static int s_SkinMode
- internal static System.Action takeCapture

#### Properties
- internal static UnityEngine.Vector2 compositionCursorPos { get; set; }
- internal static string compositionString { get; }
- internal static int guiDepth { get; }
- internal static bool guiIsExiting { get; set; }
- public static bool hasModalWindow { get; }
- public static int hotControl { get; set; }
- internal static UnityEngine.IMECompositionMode imeCompositionMode { get; set; }
- public static int keyboardControl { get; set; }
- internal static bool manualTex2SRGBEnabled { get; set; }
- internal static bool mouseUsed { get; set; }
- internal static float pixelsPerPoint { get; }
- public static string systemCopyBuffer { get; set; }
- internal static UnityEngine.Vector2 s_EditorScreenPointOffset { get; set; }
- internal static bool textFieldInput { get; set; }

#### Constructors
- public GUIUtility()
- private static GUIUtility()

#### Methods
- public static UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect, out int widthInPixels, out int heightInPixels)
- public static UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect)
- private static void AlignRectToDevice_Injected(ref UnityEngine.Rect rect, out int widthInPixels, out int heightInPixels, out UnityEngine.Rect ret)
- internal static void BeginContainer(UnityEngine.ObjectGUIState objectGUIState)
- internal static void BeginContainerFromOwner(UnityEngine.ScriptableObject owner)
- internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout)
- internal static int CheckForTabEvent(UnityEngine.Event evt)
- internal static void CheckOnGUI()
- internal static void CleanupRoots()
- internal static void DestroyGUI(int instanceID)
- internal static void EndContainer()
- internal static bool EndContainerGUIFromException(System.Exception exception)
- internal static void EndGUI(int layoutType)
- internal static bool EndGUIFromException(System.Exception exception)
- public static void ExitGUI()
- internal static UnityEngine.GUISkin GetBuiltinSkin(int skin)
- internal static bool GetChanged()
- public static int GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect)
- public static int GetControlID(UnityEngine.FocusType focus)
- public static int GetControlID(UnityEngine.GUIContent contents, UnityEngine.FocusType focus)
- public static int GetControlID(UnityEngine.FocusType focus, UnityEngine.Rect position)
- public static int GetControlID(UnityEngine.GUIContent contents, UnityEngine.FocusType focus, UnityEngine.Rect position)
- public static int GetControlID(int hint, UnityEngine.FocusType focus)
- internal static UnityEngine.GUISkin GetDefaultSkin(int skinMode)
- internal static UnityEngine.GUISkin GetDefaultSkin()
- internal static int GetPermanentControlID()
- public static object GetStateObject(System.Type t, int controlID)
- public static UnityEngine.Vector2 GUIToScreenPoint(UnityEngine.Vector2 guiPoint)
- public static UnityEngine.Rect GUIToScreenRect(UnityEngine.Rect guiRect)
- internal static bool HasFocusableControls()
- internal static bool HasKeyFocus(int controlID)
- internal static bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, int offset)
- internal static bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, bool isDirectManipulationDevice)
- internal static bool HitTest(UnityEngine.Rect rect, UnityEngine.Event evt)
- private static UnityEngine.Vector2 InternalScreenToWindowPoint(UnityEngine.Vector2 screenPoint)
- private static void InternalScreenToWindowPoint_Injected(ref UnityEngine.Vector2 screenPoint, out UnityEngine.Vector2 ret)
- private static UnityEngine.Vector2 InternalWindowToScreenPoint(UnityEngine.Vector2 windowPoint)
- private static void InternalWindowToScreenPoint_Injected(ref UnityEngine.Vector2 windowPoint, out UnityEngine.Vector2 ret)
- internal static void Internal_EndContainer()
- private static void Internal_ExitGUI()
- private static UnityEngine.Object Internal_GetBuiltinSkin(int skin)
- private static int Internal_GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect)
- private static int Internal_GetControlID_Injected(int hint, UnityEngine.FocusType focusType, ref UnityEngine.Rect rect)
- private static object Internal_GetDefaultSkin(int skinMode)
- private static int Internal_GetHotControl()
- private static int Internal_GetKeyboardControl()
- internal static UnityEngine.Vector3 Internal_MultiplyPoint(UnityEngine.Vector3 point, UnityEngine.Matrix4x4 transform)
- private static void Internal_MultiplyPoint_Injected(ref UnityEngine.Vector3 point, ref UnityEngine.Matrix4x4 transform, out UnityEngine.Vector3 ret)
- private static void Internal_SetHotControl(int value)
- private static void Internal_SetKeyboardControl(int value)
- internal static bool IsExitGUIException(System.Exception exception)
- private static void MarkGUIChanged()
- internal static bool OwnsId(int id)
- internal static void ProcessEvent(int instanceID, System.IntPtr nativeEventPtr, out bool result)
- public static object QueryStateObject(System.Type t, int controlID)
- internal static void RemoveCapture()
- internal static void ResetGlobalState()
- public static void RotateAroundPivot(float angle, UnityEngine.Vector2 pivotPoint)
- internal static float RoundToPixelGrid(float v)
- internal static float RoundToPixelGrid(float v, float scale)
- public static void ScaleAroundPivot(UnityEngine.Vector2 scale, UnityEngine.Vector2 pivotPoint)
- public static UnityEngine.Vector2 ScreenToGUIPoint(UnityEngine.Vector2 screenPoint)
- public static UnityEngine.Rect ScreenToGUIRect(UnityEngine.Rect screenRect)
- internal static void SetChanged(bool changed)
- internal static void SetDidGUIWindowsEatLastEvent(bool value)
- internal static void SetKeyboardControlToFirstControlId()
- internal static void SetKeyboardControlToLastControlId()
- internal static bool ShouldRethrowException(System.Exception exception)
- internal static void TakeCapture()

### internal class UnityEngine.GUIWordWrapSizer
- Base: UnityEngine.GUILayoutEntry

#### Fields
- private readonly UnityEngine.GUIContent m_Content
- private readonly float m_ForcedMaxHeight
- private readonly float m_ForcedMinHeight

#### Constructors
- public GUIWordWrapSizer(UnityEngine.GUIStyle style, UnityEngine.GUIContent content, UnityEngine.GUILayoutOption[] options)

#### Methods
- public override void CalcHeight()
- public override void CalcWidth()

### public class UnityEngine.GUILayout.HorizontalScope
- Base: UnityEngine.GUI.Scope
- Interfaces: System.IDisposable

#### Constructors
- public GUILayout.HorizontalScope(params UnityEngine.GUILayoutOption[] options)
- public GUILayout.HorizontalScope(UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public GUILayout.HorizontalScope(string text, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public GUILayout.HorizontalScope(UnityEngine.Texture image, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public GUILayout.HorizontalScope(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)

#### Methods
- protected override void CloseScope()

### public enum UnityEngine.ImagePosition
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ImageAbove = 1
- ImageLeft = 0
- ImageOnly = 2
- TextOnly = 3

### internal class UnityEngine.GUILayoutUtility.LayoutCache

#### Fields
- private int <id>k__BackingField
- internal UnityEngineInternal.GenericStack layoutGroups
- internal UnityEngine.GUILayoutGroup topLevel
- internal UnityEngine.GUILayoutGroup windows

#### Properties
- internal int id { get; private set; }
- public UnityEngine.GUILayoutUtility.LayoutCacheState State { get; }

#### Constructors
- internal GUILayoutUtility.LayoutCache(int instanceID = -1)

#### Methods
- internal void CopyState(UnityEngine.GUILayoutUtility.LayoutCacheState other)
- public void ResetCursor()

### internal struct UnityEngine.GUILayoutUtility.LayoutCacheState

#### Fields
- public readonly int id
- public readonly UnityEngineInternal.GenericStack layoutGroups
- public readonly UnityEngine.GUILayoutGroup topLevel
- public readonly UnityEngine.GUILayoutGroup windows

#### Constructors
- public GUILayoutUtility.LayoutCacheState(UnityEngine.GUILayoutUtility.LayoutCache cache)

### private class UnityEngine.GUILayout.LayoutedWindow

#### Fields
- private readonly UnityEngine.GUI.WindowFunction m_Func
- private readonly UnityEngine.GUILayoutOption[] m_Options
- private readonly UnityEngine.Rect m_ScreenRect
- private readonly UnityEngine.GUIStyle m_Style

#### Constructors
- internal GUILayout.LayoutedWindow(UnityEngine.GUI.WindowFunction f, UnityEngine.Rect screenRect, UnityEngine.GUIContent content, UnityEngine.GUILayoutOption[] options, UnityEngine.GUIStyle style)

#### Methods
- public void DoWindow(int windowID)

### internal class UnityEngine.ObjectGUIState
- Interfaces: System.IDisposable

#### Fields
- internal System.IntPtr m_Ptr

#### Constructors
- public ObjectGUIState()

#### Methods
- private void Destroy()
- public void Dispose()
- protected override void Finalize()
- private static System.IntPtr Internal_Create()
- private static void Internal_Destroy(System.IntPtr ptr)

### internal struct UnityEngine.GUIClip.ParentClipScope
- Interfaces: System.IDisposable

#### Fields
- private bool m_Disposed

#### Constructors
- public GUIClip.ParentClipScope(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect)

#### Methods
- public void Dispose()

### internal enum UnityEngine.PlatformSelection
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Mac = 1
- Native = 0
- Windows = 2

### public enum UnityEngine.PointerType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Mouse = 0
- Pen = 2
- Touch = 1

### public enum UnityEngine.ScaleMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ScaleAndCrop = 1
- ScaleToFit = 2
- StretchToFill = 0

### public class UnityEngine.GUI.Scope
- Interfaces: System.IDisposable

#### Fields
- private bool m_Disposed

#### Constructors
- protected GUI.Scope()

#### Methods
- protected abstract void CloseScope()
- internal virtual void Dispose(bool disposing)
- public void Dispose()
- protected override void Finalize()

### public class UnityEngine.GUI.ScrollViewScope
- Base: UnityEngine.GUI.Scope
- Interfaces: System.IDisposable

#### Fields
- private bool <handleScrollWheel>k__BackingField
- private UnityEngine.Vector2 <scrollPosition>k__BackingField

#### Properties
- public bool handleScrollWheel { get; set; }
- public UnityEngine.Vector2 scrollPosition { get; private set; }

#### Constructors
- public GUI.ScrollViewScope(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect)
- public GUI.ScrollViewScope(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical)
- public GUI.ScrollViewScope(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar)
- public GUI.ScrollViewScope(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar)
- internal GUI.ScrollViewScope(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background)

#### Methods
- protected override void CloseScope()

### public class UnityEngine.GUILayout.ScrollViewScope
- Base: UnityEngine.GUI.Scope
- Interfaces: System.IDisposable

#### Fields
- private bool <handleScrollWheel>k__BackingField
- private UnityEngine.Vector2 <scrollPosition>k__BackingField

#### Properties
- public bool handleScrollWheel { get; set; }
- public UnityEngine.Vector2 scrollPosition { get; private set; }

#### Constructors
- public GUILayout.ScrollViewScope(UnityEngine.Vector2 scrollPosition, params UnityEngine.GUILayoutOption[] options)
- public GUILayout.ScrollViewScope(UnityEngine.Vector2 scrollPosition, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public GUILayout.ScrollViewScope(UnityEngine.Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params UnityEngine.GUILayoutOption[] options)
- public GUILayout.ScrollViewScope(UnityEngine.Vector2 scrollPosition, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, params UnityEngine.GUILayoutOption[] options)
- public GUILayout.ScrollViewScope(UnityEngine.Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, params UnityEngine.GUILayoutOption[] options)
- public GUILayout.ScrollViewScope(UnityEngine.Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background, params UnityEngine.GUILayoutOption[] options)

#### Methods
- protected override void CloseScope()

### internal class UnityEngine.ScrollViewState

#### Fields
- public bool apply
- public bool isDuringTouchScroll
- public UnityEngine.Rect position
- public float previousTimeSinceStartup
- public UnityEngine.Vector2 scrollPosition
- public UnityEngine.Vector2 touchScrollStartMousePosition
- public UnityEngine.Vector2 touchScrollStartPosition
- public UnityEngine.Vector2 velocity
- public UnityEngine.Rect viewRect
- public UnityEngine.Rect visibleRect

#### Constructors
- public ScrollViewState()

#### Methods
- private UnityEngine.Vector2 ScrollNeeded(UnityEngine.Rect pos)
- public void ScrollTo(UnityEngine.Rect pos)
- public bool ScrollTowards(UnityEngine.Rect pos, float maxDelta)

### internal delegate UnityEngine.GUISkin.SkinChangedDelegate
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public GUISkin.SkinChangedDelegate(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

### internal struct UnityEngine.SliderHandler

#### Fields
- private readonly float currentValue
- private readonly float end
- private readonly bool horiz
- private readonly int id
- private readonly UnityEngine.Rect position
- private readonly float size
- private readonly UnityEngine.GUIStyle slider
- private readonly float start
- private readonly UnityEngine.GUIStyle thumb
- private readonly UnityEngine.GUIStyle thumbExtent

#### Constructors
- public SliderHandler(UnityEngine.Rect position, float currentValue, float size, float start, float end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, bool horiz, int id, UnityEngine.GUIStyle thumbExtent = null)

#### Methods
- private float Clamp(float value)
- private float ClampedCurrentValue()
- private UnityEngine.Event CurrentEvent()
- private UnityEngine.EventType CurrentEventType()
- private int CurrentScrollTroughSide()
- public float Handle()
- private UnityEngine.Rect HorizontalThumbRect()
- private bool IsEmptySlider()
- private float MaxValue()
- private float MinValue()
- private float MousePosition()
- private float OnMouseDown()
- private float OnMouseDrag()
- private float OnMouseUp()
- private float OnRepaint()
- private float PageMovementValue()
- private float PageUpMovementBound()
- private UnityEngine.SliderState SliderState()
- private void StartDraggingWithValue(float dragStartValue)
- private bool SupportsPageMovements()
- private UnityEngine.Rect ThumbExtRect()
- private UnityEngine.Rect ThumbRect()
- private UnityEngine.Rect ThumbSelectionRect()
- private float ThumbSize()
- private float ValueForCurrentMousePosition()
- private float ValuesPerPixel()
- private UnityEngine.Rect VerticalThumbRect()

### internal class UnityEngine.SliderState

#### Fields
- public float dragStartPos
- public float dragStartValue
- public bool isDragging

#### Constructors
- public SliderState()

### public enum UnityEngine.TextClipping
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Clip = 1
- Overflow = 0

### internal class UnityEngine.TextEditingUtilities

#### Fields
- internal bool isCompositionActive
- public bool multiline
- private int m_CursorIndexSavedState
- private string m_Text
- private UnityEngine.TextCore.Text.TextHandle m_TextHandle
- private UnityEngine.TextSelectingUtilities m_TextSelectingUtility
- private bool m_UpdateImeWindowPosition
- private static System.Collections.Generic.Dictionary<UnityEngine.Event, UnityEngine.TextEditOp> s_KeyEditOps

#### Properties
- private int cursorIndex { get; set; }
- private bool hasSelection { get; }
- private int m_iAltCursorPos { get; }
- internal bool revealCursor { get; set; }
- private string SelectedText { get; }
- private int selectIndex { get; set; }
- public string text { get; set; }

#### Constructors
- public TextEditingUtilities(UnityEngine.TextSelectingUtilities selectingUtilities, UnityEngine.TextCore.Text.TextHandle textHandle, string text)

#### Methods
- public bool Backspace()
- public bool CanPaste()
- public bool Cut()
- public bool Delete()
- public bool DeleteLineBack()
- public bool DeleteSelection()
- public bool DeleteWordBack()
- public bool DeleteWordForward()
- public void EnableCursorPreviewState()
- public string GeneratePreviewString(bool richText)
- internal bool HandleKeyEvent(UnityEngine.Event e)
- private void InitKeyActions()
- public void Insert(char c)
- private static void MapKey(string key, UnityEngine.TextEditOp action)
- public void MoveSelectionToAltCursor()
- internal void OnBlur()
- public bool Paste()
- private void PerformOperation(UnityEngine.TextEditOp operation)
- private static string ReplaceNewlinesWithSpaces(string value)
- public void ReplaceSelection(string replace)
- public void RestoreCursorState()
- public void SetImeWindowPosition(UnityEngine.Vector2 worldPosition)
- public bool ShouldUpdateImeWindowPosition()
- internal bool TouchScreenKeyboardShouldBeUsed()
- public bool UpdateImeState()

### internal enum UnityEngine.TextEditOp
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Backspace = 19
- Cut = 23
- Delete = 18
- DeleteLineBack = 22
- DeleteWordBack = 20
- DeleteWordForward = 21
- MoveDown = 3
- MoveGraphicalLineEnd = 11
- MoveGraphicalLineStart = 10
- MoveLeft = 0
- MoveLineEnd = 5
- MoveLineStart = 4
- MovePageDown = 9
- MovePageUp = 8
- MoveParagraphBackward = 15
- MoveParagraphForward = 14
- MoveRight = 1
- MoveTextEnd = 7
- MoveTextStart = 6
- MoveToEndOfPreviousWord = 17
- MoveToStartOfNextWord = 16
- MoveUp = 2
- MoveWordLeft = 12
- MoveWordRight = 13
- Paste = 24
- ScrollEnd = 26
- ScrollPageDown = 28
- ScrollPageUp = 27
- ScrollStart = 25

### private enum UnityEngine.TextEditor.TextEditOp
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Backspace = 37
- Copy = 42
- Cut = 41
- Delete = 36
- DeleteLineBack = 40
- DeleteWordBack = 38
- DeleteWordForward = 39
- ExpandSelectGraphicalLineEnd = 27
- ExpandSelectGraphicalLineStart = 26
- MoveDown = 3
- MoveGraphicalLineEnd = 11
- MoveGraphicalLineStart = 10
- MoveLeft = 0
- MoveLineEnd = 5
- MoveLineStart = 4
- MovePageDown = 9
- MovePageUp = 8
- MoveParagraphBackward = 15
- MoveParagraphForward = 14
- MoveRight = 1
- MoveTextEnd = 7
- MoveTextStart = 6
- MoveToEndOfPreviousWord = 17
- MoveToStartOfNextWord = 16
- MoveUp = 2
- MoveWordLeft = 12
- MoveWordRight = 13
- Paste = 43
- ScrollEnd = 47
- ScrollPageDown = 49
- ScrollPageUp = 48
- ScrollStart = 46
- SelectAll = 44
- SelectDown = 21
- SelectGraphicalLineEnd = 29
- SelectGraphicalLineStart = 28
- SelectLeft = 18
- SelectNone = 45
- SelectPageDown = 25
- SelectPageUp = 24
- SelectParagraphBackward = 34
- SelectParagraphForward = 35
- SelectRight = 19
- SelectTextEnd = 23
- SelectTextStart = 22
- SelectToEndOfPreviousWord = 32
- SelectToStartOfNextWord = 33
- SelectUp = 20
- SelectWordLeft = 30
- SelectWordRight = 31

### public class UnityEngine.TextEditor

#### Fields
- public int controlID
- public UnityEngine.Vector2 graphicalCursorPos
- public UnityEngine.Vector2 graphicalSelectCursorPos
- public bool hasHorizontalCursorPos
- public bool isPasswordField
- public UnityEngine.TouchScreenKeyboard keyboardOnScreen
- public bool multiline
- private bool m_bJustSelected
- private UnityEngine.GUIContent m_Content
- private int m_CursorIndex
- private int m_DblClickInitPos
- private UnityEngine.TextEditor.DblClickSnapping m_DblClickSnap
- internal bool m_HasFocus
- private int m_iAltCursorPos
- private bool m_MouseDragSelectsWholeWords
- private UnityEngine.Rect m_Position
- private bool m_RevealCursor
- private int m_SelectIndex
- private int oldPos
- private int oldSelectPos
- private string oldText
- public UnityEngine.Vector2 scrollOffset
- public UnityEngine.GUIStyle style
- private static System.Collections.Generic.Dictionary<UnityEngine.Event, UnityEngine.TextEditor.TextEditOp> s_Keyactions

#### Properties
- public int altCursorPosition { get; set; }
- public UnityEngine.GUIContent content { get; set; }
- public int cursorIndex { get; set; }
- public UnityEngine.TextEditor.DblClickSnapping doubleClickSnapping { get; set; }
- public bool hasSelection { get; }
- internal UnityEngine.Rect localPosition { get; }
- public UnityEngine.Rect position { get; set; }
- public string SelectedText { get; }
- public int selectIndex { get; set; }
- public string text { get; set; }

#### Constructors
- public TextEditor()

#### Methods
- public bool Backspace()
- public bool CanPaste()
- private void ClampTextIndex(ref int index)
- private UnityEngine.TextEditor.CharacterType ClassifyChar(int index)
- private void ClearCursorPos()
- public void Copy()
- public bool Cut()
- public void DblClickSnap(UnityEngine.TextEditor.DblClickSnapping snapping)
- public bool Delete()
- public bool DeleteLineBack()
- public bool DeleteSelection()
- public bool DeleteWordBack()
- public bool DeleteWordForward()
- public void DetectFocusChange()
- public void DrawCursor(string newText)
- private void EnsureValidCodePointIndex(ref int index)
- public void ExpandSelectGraphicalLineEnd()
- public void ExpandSelectGraphicalLineStart()
- private int FindEndOfClassification(int p, UnityEngine.TextEditor.Direction dir)
- private int FindEndOfPreviousWord(int p)
- private int FindNextSeperator(int startPos)
- private int FindPrevSeperator(int startPos)
- public int FindStartOfNextWord(int p)
- private int GetGraphicalLineEnd(int p)
- private int GetGraphicalLineStart(int p)
- internal UnityEngine.Rect[] GetHyperlinksRect()
- private void GrabGraphicalCursorPos()
- public bool HandleKeyEvent(UnityEngine.Event e)
- internal bool HandleKeyEvent(UnityEngine.Event e, bool textIsReadOnly)
- private int IndexOfEndOfLine(int startIndex)
- private void InitKeyActions()
- public void Insert(char c)
- public bool IsOverSelection(UnityEngine.Vector2 cursorPosition)
- private bool IsValidCodePointIndex(int index)
- private static void MapKey(string key, UnityEngine.TextEditor.TextEditOp action)
- public void MouseDragSelectsWholeWords(bool on)
- public void MoveAltCursorToPosition(UnityEngine.Vector2 cursorPosition)
- public void MoveCursorToPosition(UnityEngine.Vector2 cursorPosition)
- protected internal void MoveCursorToPosition_Internal(UnityEngine.Vector2 cursorPosition, bool shift)
- public void MoveDown()
- public void MoveGraphicalLineEnd()
- public void MoveGraphicalLineStart()
- public void MoveLeft()
- public void MoveLineEnd()
- public void MoveLineStart()
- public void MoveParagraphBackward()
- public void MoveParagraphForward()
- public void MoveRight()
- public void MoveSelectionToAltCursor()
- public void MoveTextEnd()
- public void MoveTextStart()
- public void MoveToEndOfPreviousWord()
- public void MoveToStartOfNextWord()
- public void MoveUp()
- public void MoveWordLeft()
- public void MoveWordRight()
- private int NextCodePointIndex(int index)
- internal virtual void OnCursorIndexChange()
- internal virtual void OnDetectFocusChange()
- public void OnFocus()
- public void OnLostFocus()
- internal virtual void OnSelectIndexChange()
- public bool Paste()
- private bool PerformOperation(UnityEngine.TextEditor.TextEditOp operation, bool textIsReadOnly)
- private int PreviousCodePointIndex(int index)
- private static string ReplaceNewlinesWithSpaces(string value)
- public void ReplaceSelection(string replace)
- public void SaveBackup()
- public void SelectAll()
- public void SelectCurrentParagraph()
- public void SelectCurrentWord()
- public void SelectDown()
- public void SelectGraphicalLineEnd()
- public void SelectGraphicalLineStart()
- public void SelectLeft()
- public void SelectNone()
- public void SelectParagraphBackward()
- public void SelectParagraphForward()
- public void SelectRight()
- public void SelectTextEnd()
- public void SelectTextStart()
- public void SelectToEndOfPreviousWord()
- public void SelectToPosition(UnityEngine.Vector2 cursorPosition)
- public void SelectToStartOfNextWord()
- public void SelectUp()
- public void SelectWordLeft()
- public void SelectWordRight()
- public void Undo()
- internal void UpdateScrollOffset()
- public void UpdateScrollOffsetIfNeeded(UnityEngine.Event evt)

### internal class UnityEngine.TextSelectingUtilities

#### Fields
- public UnityEngine.TextEditor.DblClickSnapping dblClickSnap
- public bool hasHorizontalCursorPos
- public int iAltCursorPos
- private static const int kMoveDownHeight
- private static const char kNewLineChar
- private bool m_bJustSelected
- private int m_CursorIndex
- private int m_DblClickInitPosEnd
- private int m_DblClickInitPosStart
- private bool m_MouseDragSelectsWholeWords
- private bool m_RevealCursor
- internal int m_SelectIndex
- private UnityEngine.TextCore.Text.TextHandle m_TextHandle
- internal System.Action OnCursorIndexChange
- internal System.Action OnRevealCursorChange
- internal System.Action OnSelectIndexChange
- private static System.Collections.Generic.Dictionary<UnityEngine.Event, UnityEngine.TextSelectOp> s_KeySelectOps

#### Properties
- private int characterCount { get; }
- public int cursorIndex { get; set; }
- public bool hasSelection { get; }
- private int m_CharacterCount { get; }
- private UnityEngine.TextCore.Text.TextElementInfo[] m_TextElementInfos { get; }
- public bool revealCursor { get; set; }
- public string selectedText { get; }
- public int selectIndex { get; set; }

#### Constructors
- public TextSelectingUtilities(UnityEngine.TextCore.Text.TextHandle textHandle)

#### Methods
- private int ClampTextIndex(int index)
- private UnityEngine.TextSelectingUtilities.CharacterType ClassifyChar(int index)
- public void ClearCursorPos()
- public void Copy()
- public void DblClickSnap(UnityEngine.TextEditor.DblClickSnapping snapping)
- internal int EnsureValidCodePointIndex(int index)
- public void ExpandSelectGraphicalLineEnd()
- public void ExpandSelectGraphicalLineStart()
- private int FindEndOfClassification(int p, UnityEngine.TextSelectingUtilities.Direction dir)
- public int FindEndOfPreviousWord(int p)
- private int FindNextSeperator(int startPos)
- private int FindPrevSeperator(int startPos)
- public int FindStartOfNextWord(int p)
- private int GetGraphicalLineEnd(int p)
- private int GetGraphicalLineStart(int p)
- internal bool HandleKeyEvent(UnityEngine.Event e)
- private int IndexOfEndOfLine(int startIndex)
- private void InitKeyActions()
- private bool IsValidCodePointIndex(int index)
- private static void MapKey(string key, UnityEngine.TextSelectOp action)
- public void MouseDragSelectsWholeWords(bool on)
- protected internal void MoveCursorToPosition_Internal(UnityEngine.Vector2 cursorPosition, bool shift)
- public void MoveDown()
- public void MoveGraphicalLineEnd()
- public void MoveGraphicalLineStart()
- public void MoveLeft()
- public void MoveLineEnd()
- public void MoveLineStart()
- public void MoveParagraphBackward()
- public void MoveParagraphForward()
- public void MoveRight()
- public void MoveTextEnd()
- public void MoveTextStart()
- public void MoveToEndOfPreviousWord()
- public void MoveToStartOfNextWord()
- public void MoveUp()
- public void MoveWordLeft()
- public void MoveWordRight()
- public int NextCodePointIndex(int index)
- public void OnFocus(bool selectAll = true)
- private bool PerformOperation(UnityEngine.TextSelectOp operation)
- public int PreviousCodePointIndex(int index)
- public void SelectAll()
- public void SelectCurrentParagraph()
- public void SelectCurrentWord()
- public void SelectDown()
- public void SelectGraphicalLineEnd()
- public void SelectGraphicalLineStart()
- public void SelectLeft()
- public void SelectNone()
- public void SelectParagraphBackward()
- public void SelectParagraphForward()
- public void SelectRight()
- public void SelectTextEnd()
- public void SelectTextStart()
- public void SelectToEndOfPreviousWord()
- public void SelectToPosition(UnityEngine.Vector2 cursorPosition)
- public void SelectToStartOfNextWord()
- public void SelectUp()
- public void SelectWordLeft()
- public void SelectWordRight()
- internal void SetCursorIndexWithoutNotify(int index)
- internal void SetSelectIndexWithoutNotify(int index)

### internal enum UnityEngine.TextSelectOp
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Copy = 18
- ExpandSelectGraphicalLineEnd = 9
- ExpandSelectGraphicalLineStart = 8
- SelectAll = 19
- SelectDown = 3
- SelectGraphicalLineEnd = 11
- SelectGraphicalLineStart = 10
- SelectLeft = 0
- SelectNone = 20
- SelectPageDown = 7
- SelectPageUp = 6
- SelectParagraphBackward = 16
- SelectParagraphForward = 17
- SelectRight = 1
- SelectTextEnd = 5
- SelectTextStart = 4
- SelectToEndOfPreviousWord = 14
- SelectToStartOfNextWord = 15
- SelectUp = 2
- SelectWordLeft = 12
- SelectWordRight = 13

### public enum UnityEngine.GUI.ToolbarButtonSize
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FitToContents = 1
- Fixed = 0

### internal enum UnityEngine.GUILayoutOption.Type
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- alignEnd = 10
- alignJustify = 11
- alignMiddle = 9
- alignStart = 8
- equalSize = 12
- fixedHeight = 1
- fixedWidth = 0
- maxHeight = 5
- maxWidth = 3
- minHeight = 4
- minWidth = 2
- spacing = 13
- stretchHeight = 7
- stretchWidth = 6

### public class UnityEngine.GUILayout.VerticalScope
- Base: UnityEngine.GUI.Scope
- Interfaces: System.IDisposable

#### Constructors
- public GUILayout.VerticalScope(params UnityEngine.GUILayoutOption[] options)
- public GUILayout.VerticalScope(UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public GUILayout.VerticalScope(string text, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public GUILayout.VerticalScope(UnityEngine.Texture image, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)
- public GUILayout.VerticalScope(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options)

#### Methods
- protected override void CloseScope()

### public delegate UnityEngine.GUI.WindowFunction
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public GUI.WindowFunction(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(int id, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(int id)

