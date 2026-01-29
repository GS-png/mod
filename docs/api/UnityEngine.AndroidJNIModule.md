# Assembly: UnityEngine.AndroidJNIModule
- Path: tools/WorldBox.Managed/UnityEngine.AndroidJNIModule.dll
- Types: 30

## Namespace: UnityEngine

### public class UnityEngine.AndroidJavaClass
- Base: UnityEngine.AndroidJavaObject
- Interfaces: System.IDisposable

#### Constructors
- public AndroidJavaClass(string className)
- internal AndroidJavaClass(System.IntPtr jclass)

#### Methods
- private void _AndroidJavaClass(string className)

### public class UnityEngine.AndroidJavaException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private string mJavaStackTrace

#### Properties
- public string StackTrace { get; }

#### Constructors
- internal AndroidJavaException(string message, string javaStackTrace)

### public class UnityEngine.AndroidJavaObject
- Interfaces: System.IDisposable

#### Fields
- private static bool enableDebugPrints
- internal UnityEngine.GlobalJavaObjectRef m_jclass
- internal UnityEngine.GlobalJavaObjectRef m_jobject

#### Constructors
- internal AndroidJavaObject()
- public AndroidJavaObject(System.IntPtr jobject)
- public AndroidJavaObject(string className, string[] args)
- public AndroidJavaObject(string className, UnityEngine.AndroidJavaObject[] args)
- public AndroidJavaObject(string className, UnityEngine.AndroidJavaClass[] args)
- public AndroidJavaObject(string className, UnityEngine.AndroidJavaProxy[] args)
- public AndroidJavaObject(string className, UnityEngine.AndroidJavaRunnable[] args)
- public AndroidJavaObject(string className, params object[] args)
- public AndroidJavaObject(System.IntPtr clazz, System.IntPtr constructorID, params object[] args)

#### Methods
- internal static UnityEngine.AndroidJavaClass AndroidJavaClassDeleteLocalRef(System.IntPtr jclass)
- internal static UnityEngine.AndroidJavaObject AndroidJavaObjectDeleteLocalRef(System.IntPtr jobject)
- public void Call<T>(string methodName, T[] args)
- public void Call<T>(System.IntPtr methodID, T[] args)
- public void Call(string methodName, params object[] args)
- public void Call(System.IntPtr methodID, params object[] args)
- public ReturnType Call<ReturnType, T>(string methodName, T[] args)
- public ReturnType Call<ReturnType, T>(System.IntPtr methodID, T[] args)
- public ReturnType Call<ReturnType>(string methodName, params object[] args)
- public ReturnType Call<ReturnType>(System.IntPtr methodID, params object[] args)
- public void CallStatic<T>(string methodName, T[] args)
- public void CallStatic<T>(System.IntPtr methodID, T[] args)
- public void CallStatic(string methodName, params object[] args)
- public void CallStatic(System.IntPtr methodID, params object[] args)
- public ReturnType CallStatic<ReturnType, T>(string methodName, T[] args)
- public ReturnType CallStatic<ReturnType, T>(System.IntPtr methodID, T[] args)
- public ReturnType CallStatic<ReturnType>(string methodName, params object[] args)
- public ReturnType CallStatic<ReturnType>(System.IntPtr methodID, params object[] args)
- public UnityEngine.AndroidJavaObject CloneReference()
- protected void DebugPrint(string msg)
- protected void DebugPrint(string call, string methodName, string signature, object[] args)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- protected override void Finalize()
- internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(System.IntPtr jobject)
- public FieldType Get<FieldType>(string fieldName)
- public FieldType Get<FieldType>(System.IntPtr fieldID)
- public System.IntPtr GetRawClass()
- public System.IntPtr GetRawObject()
- public FieldType GetStatic<FieldType>(string fieldName)
- public FieldType GetStatic<FieldType>(System.IntPtr fieldID)
- public void Set<FieldType>(string fieldName, FieldType val)
- public void Set<FieldType>(System.IntPtr fieldID, FieldType val)
- public void SetStatic<FieldType>(string fieldName, FieldType val)
- public void SetStatic<FieldType>(System.IntPtr fieldID, FieldType val)
- private void _AndroidJavaObject(string className, params object[] args)
- private void _AndroidJavaObject(System.IntPtr constructorID, params object[] args)
- protected void _Call(string methodName, params object[] args)
- protected void _Call(System.IntPtr methodID, params object[] args)
- protected ReturnType _Call<ReturnType>(string methodName, params object[] args)
- protected ReturnType _Call<ReturnType>(System.IntPtr methodID, params object[] args)
- protected void _CallStatic(string methodName, params object[] args)
- protected void _CallStatic(System.IntPtr methodID, params object[] args)
- protected ReturnType _CallStatic<ReturnType>(string methodName, params object[] args)
- protected ReturnType _CallStatic<ReturnType>(System.IntPtr methodID, params object[] args)
- protected FieldType _Get<FieldType>(string fieldName)
- protected FieldType _Get<FieldType>(System.IntPtr fieldID)
- protected System.IntPtr _GetRawClass()
- protected System.IntPtr _GetRawObject()
- protected FieldType _GetStatic<FieldType>(string fieldName)
- protected FieldType _GetStatic<FieldType>(System.IntPtr fieldID)
- protected void _Set<FieldType>(string fieldName, FieldType val)
- protected void _Set<FieldType>(System.IntPtr fieldID, FieldType val)
- protected void _SetStatic<FieldType>(string fieldName, FieldType val)
- protected void _SetStatic<FieldType>(System.IntPtr fieldID, FieldType val)

### public class UnityEngine.AndroidJavaProxy

#### Fields
- public readonly UnityEngine.AndroidJavaClass javaInterface
- internal System.IntPtr proxyObject
- private static readonly System.IntPtr s_HashCodeMethodID
- private static readonly UnityEngine.GlobalJavaObjectRef s_JavaLangSystemClass

#### Constructors
- private static AndroidJavaProxy()
- public AndroidJavaProxy(string javaInterface)
- public AndroidJavaProxy(UnityEngine.AndroidJavaClass javaInterface)

#### Methods
- public virtual bool equals(UnityEngine.AndroidJavaObject obj)
- protected override void Finalize()
- internal UnityEngine.AndroidJavaObject GetProxyObject()
- internal System.IntPtr GetRawProxy()
- public virtual int hashCode()
- public virtual UnityEngine.AndroidJavaObject Invoke(string methodName, object[] args)
- public virtual UnityEngine.AndroidJavaObject Invoke(string methodName, UnityEngine.AndroidJavaObject[] javaArgs)
- public virtual System.IntPtr Invoke(string methodName, System.IntPtr javaArgs)
- public virtual string toString()

### public delegate UnityEngine.AndroidJavaRunnable
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AndroidJavaRunnable(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

### internal class UnityEngine.AndroidJavaRunnableProxy
- Base: UnityEngine.AndroidJavaProxy

#### Fields
- private UnityEngine.AndroidJavaRunnable mRunnable

#### Constructors
- public AndroidJavaRunnableProxy(UnityEngine.AndroidJavaRunnable runnable)

#### Methods
- public override System.IntPtr Invoke(string methodName, System.IntPtr javaArgs)
- public void run()

### public static class UnityEngine.AndroidJNI

#### Methods
- public static System.IntPtr AllocObject(System.IntPtr clazz)
- public static int AttachCurrentThread()
- public static bool CallBooleanMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static bool CallBooleanMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static bool CallBooleanMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static byte CallByteMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static char CallCharMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static char CallCharMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static char CallCharMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static double CallDoubleMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static double CallDoubleMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static double CallDoubleMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static float CallFloatMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static float CallFloatMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static float CallFloatMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static int CallIntMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static int CallIntMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static int CallIntMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static long CallLongMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static long CallLongMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static long CallLongMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static System.IntPtr CallObjectMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static System.IntPtr CallObjectMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static System.IntPtr CallObjectMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static sbyte CallSByteMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static sbyte CallSByteMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static sbyte CallSByteMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static short CallShortMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static short CallShortMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static short CallShortMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static bool CallStaticBooleanMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static bool CallStaticBooleanMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static bool CallStaticBooleanMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static byte CallStaticByteMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static char CallStaticCharMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static char CallStaticCharMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static char CallStaticCharMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static double CallStaticDoubleMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static double CallStaticDoubleMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static double CallStaticDoubleMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static float CallStaticFloatMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static float CallStaticFloatMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static float CallStaticFloatMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static int CallStaticIntMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static int CallStaticIntMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static int CallStaticIntMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static long CallStaticLongMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static long CallStaticLongMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static long CallStaticLongMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static System.IntPtr CallStaticObjectMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static System.IntPtr CallStaticObjectMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static System.IntPtr CallStaticObjectMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static sbyte CallStaticSByteMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static sbyte CallStaticSByteMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static sbyte CallStaticSByteMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static short CallStaticShortMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static short CallStaticShortMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static short CallStaticShortMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static string CallStaticStringMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static string CallStaticStringMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static string CallStaticStringMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static void CallStaticVoidMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static void CallStaticVoidMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static void CallStaticVoidMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static string CallStringMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static string CallStringMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static string CallStringMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static void CallVoidMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static void CallVoidMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static void CallVoidMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue* args)
- private static System.IntPtr ConvertToBooleanArray(bool[] array)
- public static void DeleteGlobalRef(System.IntPtr obj)
- public static void DeleteLocalRef(System.IntPtr obj)
- public static void DeleteWeakGlobalRef(System.IntPtr obj)
- public static int DetachCurrentThread()
- public static int EnsureLocalCapacity(int capacity)
- public static void ExceptionClear()
- public static void ExceptionDescribe()
- public static System.IntPtr ExceptionOccurred()
- public static void FatalError(string message)
- public static System.IntPtr FindClass(string name)
- public static bool[] FromBooleanArray(System.IntPtr array)
- public static byte[] FromByteArray(System.IntPtr array)
- public static char[] FromCharArray(System.IntPtr array)
- public static double[] FromDoubleArray(System.IntPtr array)
- public static float[] FromFloatArray(System.IntPtr array)
- public static int[] FromIntArray(System.IntPtr array)
- public static long[] FromLongArray(System.IntPtr array)
- public static System.IntPtr[] FromObjectArray(System.IntPtr array)
- public static System.IntPtr FromReflectedField(System.IntPtr refField)
- public static System.IntPtr FromReflectedMethod(System.IntPtr refMethod)
- public static sbyte[] FromSByteArray(System.IntPtr array)
- public static short[] FromShortArray(System.IntPtr array)
- public static int GetArrayLength(System.IntPtr array)
- public static bool GetBooleanArrayElement(System.IntPtr array, int index)
- public static bool GetBooleanField(System.IntPtr obj, System.IntPtr fieldID)
- public static byte GetByteArrayElement(System.IntPtr array, int index)
- public static byte GetByteField(System.IntPtr obj, System.IntPtr fieldID)
- public static char GetCharArrayElement(System.IntPtr array, int index)
- public static char GetCharField(System.IntPtr obj, System.IntPtr fieldID)
- private static Unity.Collections.NativeArray<T> GetDirectBuffer<T>(System.IntPtr buffer)
- public static sbyte* GetDirectBufferAddress(System.IntPtr buffer)
- public static long GetDirectBufferCapacity(System.IntPtr buffer)
- public static Unity.Collections.NativeArray<byte> GetDirectByteBuffer(System.IntPtr buffer)
- public static Unity.Collections.NativeArray<sbyte> GetDirectSByteBuffer(System.IntPtr buffer)
- public static double GetDoubleArrayElement(System.IntPtr array, int index)
- public static double GetDoubleField(System.IntPtr obj, System.IntPtr fieldID)
- public static System.IntPtr GetFieldID(System.IntPtr clazz, string name, string sig)
- public static float GetFloatArrayElement(System.IntPtr array, int index)
- public static float GetFloatField(System.IntPtr obj, System.IntPtr fieldID)
- public static int GetIntArrayElement(System.IntPtr array, int index)
- public static int GetIntField(System.IntPtr obj, System.IntPtr fieldID)
- public static System.IntPtr GetJavaVM()
- public static long GetLongArrayElement(System.IntPtr array, int index)
- public static long GetLongField(System.IntPtr obj, System.IntPtr fieldID)
- public static System.IntPtr GetMethodID(System.IntPtr clazz, string name, string sig)
- public static System.IntPtr GetObjectArrayElement(System.IntPtr array, int index)
- public static System.IntPtr GetObjectClass(System.IntPtr obj)
- public static System.IntPtr GetObjectField(System.IntPtr obj, System.IntPtr fieldID)
- internal static uint GetQueueGlobalRefsCount()
- public static sbyte GetSByteArrayElement(System.IntPtr array, int index)
- public static sbyte GetSByteField(System.IntPtr obj, System.IntPtr fieldID)
- public static short GetShortArrayElement(System.IntPtr array, int index)
- public static short GetShortField(System.IntPtr obj, System.IntPtr fieldID)
- public static bool GetStaticBooleanField(System.IntPtr clazz, System.IntPtr fieldID)
- public static byte GetStaticByteField(System.IntPtr clazz, System.IntPtr fieldID)
- public static char GetStaticCharField(System.IntPtr clazz, System.IntPtr fieldID)
- public static double GetStaticDoubleField(System.IntPtr clazz, System.IntPtr fieldID)
- public static System.IntPtr GetStaticFieldID(System.IntPtr clazz, string name, string sig)
- public static float GetStaticFloatField(System.IntPtr clazz, System.IntPtr fieldID)
- public static int GetStaticIntField(System.IntPtr clazz, System.IntPtr fieldID)
- public static long GetStaticLongField(System.IntPtr clazz, System.IntPtr fieldID)
- public static System.IntPtr GetStaticMethodID(System.IntPtr clazz, string name, string sig)
- public static System.IntPtr GetStaticObjectField(System.IntPtr clazz, System.IntPtr fieldID)
- public static sbyte GetStaticSByteField(System.IntPtr clazz, System.IntPtr fieldID)
- public static short GetStaticShortField(System.IntPtr clazz, System.IntPtr fieldID)
- public static string GetStaticStringField(System.IntPtr clazz, System.IntPtr fieldID)
- public static string GetStringChars(System.IntPtr str)
- public static string GetStringField(System.IntPtr obj, System.IntPtr fieldID)
- public static int GetStringLength(System.IntPtr str)
- public static string GetStringUTFChars(System.IntPtr str)
- public static int GetStringUTFLength(System.IntPtr str)
- public static System.IntPtr GetSuperclass(System.IntPtr clazz)
- public static int GetVersion()
- public static bool IsAssignableFrom(System.IntPtr clazz1, System.IntPtr clazz2)
- public static bool IsInstanceOf(System.IntPtr obj, System.IntPtr clazz)
- public static bool IsSameObject(System.IntPtr obj1, System.IntPtr obj2)
- public static System.IntPtr NewBooleanArray(int size)
- public static System.IntPtr NewByteArray(int size)
- public static System.IntPtr NewCharArray(int size)
- public static System.IntPtr NewDirectByteBuffer(byte* buffer, long capacity)
- public static System.IntPtr NewDirectByteBuffer(Unity.Collections.NativeArray<byte> buffer)
- public static System.IntPtr NewDirectByteBuffer(Unity.Collections.NativeArray<sbyte> buffer)
- private static System.IntPtr NewDirectByteBufferFromNativeArray<T>(Unity.Collections.NativeArray<T> buffer)
- public static System.IntPtr NewDoubleArray(int size)
- public static System.IntPtr NewFloatArray(int size)
- public static System.IntPtr NewGlobalRef(System.IntPtr obj)
- public static System.IntPtr NewIntArray(int size)
- public static System.IntPtr NewLocalRef(System.IntPtr obj)
- public static System.IntPtr NewLongArray(int size)
- public static System.IntPtr NewObject(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static System.IntPtr NewObject(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static System.IntPtr NewObjectA(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue* args)
- public static System.IntPtr NewObjectArray(int size, System.IntPtr clazz, System.IntPtr obj)
- public static System.IntPtr NewSByteArray(int size)
- public static System.IntPtr NewShortArray(int size)
- public static System.IntPtr NewString(string chars)
- public static System.IntPtr NewString(char[] chars)
- private static System.IntPtr NewStringFromStr(string chars)
- public static System.IntPtr NewStringUTF(string bytes)
- public static System.IntPtr NewWeakGlobalRef(System.IntPtr obj)
- public static System.IntPtr PopLocalFrame(System.IntPtr ptr)
- public static int PushLocalFrame(int capacity)
- internal static void QueueDeleteGlobalRef(System.IntPtr obj)
- public static int RegisterNatives(System.IntPtr clazz, UnityEngine.JNINativeMethod[] methods)
- private static System.IntPtr RegisterNativesAllocate(int length)
- private static int RegisterNativesAndFree(System.IntPtr clazz, System.IntPtr natives, int n)
- private static void RegisterNativesSet(System.IntPtr natives, int idx, string name, string signature, System.IntPtr fnPtr)
- public static void SetBooleanArrayElement(System.IntPtr array, int index, byte val)
- public static void SetBooleanArrayElement(System.IntPtr array, int index, bool val)
- public static void SetBooleanField(System.IntPtr obj, System.IntPtr fieldID, bool val)
- public static void SetByteArrayElement(System.IntPtr array, int index, sbyte val)
- public static void SetByteField(System.IntPtr obj, System.IntPtr fieldID, byte val)
- public static void SetCharArrayElement(System.IntPtr array, int index, char val)
- public static void SetCharField(System.IntPtr obj, System.IntPtr fieldID, char val)
- public static void SetDoubleArrayElement(System.IntPtr array, int index, double val)
- public static void SetDoubleField(System.IntPtr obj, System.IntPtr fieldID, double val)
- public static void SetFloatArrayElement(System.IntPtr array, int index, float val)
- public static void SetFloatField(System.IntPtr obj, System.IntPtr fieldID, float val)
- public static void SetIntArrayElement(System.IntPtr array, int index, int val)
- public static void SetIntField(System.IntPtr obj, System.IntPtr fieldID, int val)
- public static void SetLongArrayElement(System.IntPtr array, int index, long val)
- public static void SetLongField(System.IntPtr obj, System.IntPtr fieldID, long val)
- public static void SetObjectArrayElement(System.IntPtr array, int index, System.IntPtr obj)
- public static void SetObjectField(System.IntPtr obj, System.IntPtr fieldID, System.IntPtr val)
- public static void SetSByteArrayElement(System.IntPtr array, int index, sbyte val)
- public static void SetSByteField(System.IntPtr obj, System.IntPtr fieldID, sbyte val)
- public static void SetShortArrayElement(System.IntPtr array, int index, short val)
- public static void SetShortField(System.IntPtr obj, System.IntPtr fieldID, short val)
- public static void SetStaticBooleanField(System.IntPtr clazz, System.IntPtr fieldID, bool val)
- public static void SetStaticByteField(System.IntPtr clazz, System.IntPtr fieldID, byte val)
- public static void SetStaticCharField(System.IntPtr clazz, System.IntPtr fieldID, char val)
- public static void SetStaticDoubleField(System.IntPtr clazz, System.IntPtr fieldID, double val)
- public static void SetStaticFloatField(System.IntPtr clazz, System.IntPtr fieldID, float val)
- public static void SetStaticIntField(System.IntPtr clazz, System.IntPtr fieldID, int val)
- public static void SetStaticLongField(System.IntPtr clazz, System.IntPtr fieldID, long val)
- public static void SetStaticObjectField(System.IntPtr clazz, System.IntPtr fieldID, System.IntPtr val)
- public static void SetStaticSByteField(System.IntPtr clazz, System.IntPtr fieldID, sbyte val)
- public static void SetStaticShortField(System.IntPtr clazz, System.IntPtr fieldID, short val)
- public static void SetStaticStringField(System.IntPtr clazz, System.IntPtr fieldID, string val)
- public static void SetStringField(System.IntPtr obj, System.IntPtr fieldID, string val)
- public static int Throw(System.IntPtr obj)
- public static int ThrowNew(System.IntPtr clazz, string message)
- public static System.IntPtr ToBooleanArray(bool[] array)
- public static System.IntPtr ToByteArray(byte[] array)
- public static System.IntPtr ToCharArray(char[] array)
- public static System.IntPtr ToCharArray(char* array, int length)
- public static System.IntPtr ToDoubleArray(double[] array)
- public static System.IntPtr ToDoubleArray(double* array, int length)
- public static System.IntPtr ToFloatArray(float[] array)
- public static System.IntPtr ToFloatArray(float* array, int length)
- public static System.IntPtr ToIntArray(int[] array)
- public static System.IntPtr ToIntArray(int* array, int length)
- public static System.IntPtr ToLongArray(long[] array)
- public static System.IntPtr ToLongArray(long* array, int length)
- public static System.IntPtr ToObjectArray(System.IntPtr* array, int length, System.IntPtr arrayClass)
- public static System.IntPtr ToObjectArray(System.IntPtr[] array, System.IntPtr arrayClass)
- public static System.IntPtr ToObjectArray(System.IntPtr[] array)
- public static System.IntPtr ToReflectedField(System.IntPtr clazz, System.IntPtr fieldID, bool isStatic)
- public static System.IntPtr ToReflectedMethod(System.IntPtr clazz, System.IntPtr methodID, bool isStatic)
- public static System.IntPtr ToSByteArray(sbyte[] array)
- public static System.IntPtr ToSByteArray(sbyte* array, int length)
- public static System.IntPtr ToShortArray(short[] array)
- public static System.IntPtr ToShortArray(short* array, int length)
- public static int UnregisterNatives(System.IntPtr clazz)

### public static class UnityEngine.AndroidJNIHelper

#### Properties
- public static bool debug { get; set; }

#### Methods
- private static System.IntPtr Box(UnityEngine.jvalue val, string boxedClass, string signature)
- public static System.IntPtr Box(sbyte value)
- public static System.IntPtr Box(short value)
- public static System.IntPtr Box(int value)
- public static System.IntPtr Box(long value)
- public static System.IntPtr Box(float value)
- public static System.IntPtr Box(double value)
- public static System.IntPtr Box(char value)
- public static System.IntPtr Box(bool value)
- public static ArrayType ConvertFromJNIArray<ArrayType>(System.IntPtr array)
- public static System.IntPtr ConvertToJNIArray(System.Array array)
- public static System.IntPtr CreateJavaProxy(UnityEngine.AndroidJavaProxy proxy)
- public static System.IntPtr CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable)
- public static UnityEngine.jvalue[] CreateJNIArgArray(object[] args)
- public static void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs)
- public static void DeleteJNIArgArray(object[] args, UnityEngine.jvalue[] jniArgs)
- public static void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs)
- public static System.IntPtr GetConstructorID(System.IntPtr javaClass)
- public static System.IntPtr GetConstructorID(System.IntPtr javaClass, string signature)
- public static System.IntPtr GetConstructorID(System.IntPtr jclass, object[] args)
- public static System.IntPtr GetFieldID(System.IntPtr javaClass, string fieldName)
- public static System.IntPtr GetFieldID(System.IntPtr javaClass, string fieldName, string signature)
- public static System.IntPtr GetFieldID(System.IntPtr javaClass, string fieldName, string signature, bool isStatic)
- public static System.IntPtr GetFieldID<FieldType>(System.IntPtr jclass, string fieldName, bool isStatic)
- public static System.IntPtr GetMethodID(System.IntPtr javaClass, string methodName)
- public static System.IntPtr GetMethodID(System.IntPtr javaClass, string methodName, string signature)
- public static System.IntPtr GetMethodID(System.IntPtr javaClass, string methodName, string signature, bool isStatic)
- public static System.IntPtr GetMethodID(System.IntPtr jclass, string methodName, object[] args, bool isStatic)
- public static System.IntPtr GetMethodID<ReturnType>(System.IntPtr jclass, string methodName, object[] args, bool isStatic)
- public static string GetSignature(object obj)
- public static string GetSignature(object[] args)
- public static string GetSignature<ReturnType>(object[] args)
- private static System.IntPtr GetUnboxMethod(System.IntPtr obj, string methodName, string signature)
- public static void Unbox(System.IntPtr obj, out sbyte value)
- public static void Unbox(System.IntPtr obj, out short value)
- public static void Unbox(System.IntPtr obj, out int value)
- public static void Unbox(System.IntPtr obj, out long value)
- public static void Unbox(System.IntPtr obj, out float value)
- public static void Unbox(System.IntPtr obj, out double value)
- public static void Unbox(System.IntPtr obj, out char value)
- public static void Unbox(System.IntPtr obj, out bool value)

### internal class UnityEngine.AndroidJNISafe

#### Constructors
- public AndroidJNISafe()

#### Methods
- public static bool CallBooleanMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static bool CallBooleanMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static char CallCharMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static char CallCharMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static double CallDoubleMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static double CallDoubleMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static float CallFloatMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static float CallFloatMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static int CallIntMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static int CallIntMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static long CallLongMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static long CallLongMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static System.IntPtr CallObjectMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static System.IntPtr CallObjectMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static sbyte CallSByteMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static sbyte CallSByteMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static short CallShortMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static short CallShortMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static bool CallStaticBooleanMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static bool CallStaticBooleanMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static char CallStaticCharMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static char CallStaticCharMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static double CallStaticDoubleMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static double CallStaticDoubleMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static float CallStaticFloatMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static float CallStaticFloatMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static int CallStaticIntMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static int CallStaticIntMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static long CallStaticLongMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static long CallStaticLongMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static System.IntPtr CallStaticObjectMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static System.IntPtr CallStaticObjectMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static sbyte CallStaticSByteMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static sbyte CallStaticSByteMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static short CallStaticShortMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static short CallStaticShortMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static string CallStaticStringMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static string CallStaticStringMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static void CallStaticVoidMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static void CallStaticVoidMethod(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static string CallStringMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static string CallStringMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static void CallVoidMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static void CallVoidMethod(System.IntPtr obj, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static void CheckException()
- public static void DeleteGlobalRef(System.IntPtr globalref)
- public static void DeleteLocalRef(System.IntPtr localref)
- public static void DeleteWeakGlobalRef(System.IntPtr globalref)
- public static System.IntPtr FindClass(string name)
- public static bool[] FromBooleanArray(System.IntPtr array)
- public static byte[] FromByteArray(System.IntPtr array)
- public static char[] FromCharArray(System.IntPtr array)
- public static double[] FromDoubleArray(System.IntPtr array)
- public static float[] FromFloatArray(System.IntPtr array)
- public static int[] FromIntArray(System.IntPtr array)
- public static long[] FromLongArray(System.IntPtr array)
- public static System.IntPtr[] FromObjectArray(System.IntPtr array)
- public static System.IntPtr FromReflectedField(System.IntPtr refField)
- public static System.IntPtr FromReflectedMethod(System.IntPtr refMethod)
- public static sbyte[] FromSByteArray(System.IntPtr array)
- public static short[] FromShortArray(System.IntPtr array)
- public static int GetArrayLength(System.IntPtr array)
- public static bool GetBooleanField(System.IntPtr obj, System.IntPtr fieldID)
- public static char GetCharField(System.IntPtr obj, System.IntPtr fieldID)
- public static double GetDoubleField(System.IntPtr obj, System.IntPtr fieldID)
- public static System.IntPtr GetFieldID(System.IntPtr clazz, string name, string sig)
- public static float GetFloatField(System.IntPtr obj, System.IntPtr fieldID)
- public static int GetIntField(System.IntPtr obj, System.IntPtr fieldID)
- public static long GetLongField(System.IntPtr obj, System.IntPtr fieldID)
- public static System.IntPtr GetMethodID(System.IntPtr obj, string name, string sig)
- public static System.IntPtr GetObjectArrayElement(System.IntPtr array, int index)
- public static System.IntPtr GetObjectClass(System.IntPtr ptr)
- public static System.IntPtr GetObjectField(System.IntPtr obj, System.IntPtr fieldID)
- public static sbyte GetSByteField(System.IntPtr obj, System.IntPtr fieldID)
- public static short GetShortField(System.IntPtr obj, System.IntPtr fieldID)
- public static bool GetStaticBooleanField(System.IntPtr clazz, System.IntPtr fieldID)
- public static char GetStaticCharField(System.IntPtr clazz, System.IntPtr fieldID)
- public static double GetStaticDoubleField(System.IntPtr clazz, System.IntPtr fieldID)
- public static System.IntPtr GetStaticFieldID(System.IntPtr clazz, string name, string sig)
- public static float GetStaticFloatField(System.IntPtr clazz, System.IntPtr fieldID)
- public static int GetStaticIntField(System.IntPtr clazz, System.IntPtr fieldID)
- public static long GetStaticLongField(System.IntPtr clazz, System.IntPtr fieldID)
- public static System.IntPtr GetStaticMethodID(System.IntPtr clazz, string name, string sig)
- public static System.IntPtr GetStaticObjectField(System.IntPtr clazz, System.IntPtr fieldID)
- public static sbyte GetStaticSByteField(System.IntPtr clazz, System.IntPtr fieldID)
- public static short GetStaticShortField(System.IntPtr clazz, System.IntPtr fieldID)
- public static string GetStaticStringField(System.IntPtr clazz, System.IntPtr fieldID)
- public static string GetStringChars(System.IntPtr str)
- public static string GetStringField(System.IntPtr obj, System.IntPtr fieldID)
- public static string GetStringUTFChars(System.IntPtr str)
- public static System.IntPtr NewObject(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args)
- public static System.IntPtr NewObject(System.IntPtr clazz, System.IntPtr methodID, System.Span<UnityEngine.jvalue> args)
- public static System.IntPtr NewString(string chars)
- public static System.IntPtr NewStringUTF(string bytes)
- public static void QueueDeleteGlobalRef(System.IntPtr globalref)
- public static void SetBooleanField(System.IntPtr obj, System.IntPtr fieldID, bool val)
- public static void SetCharField(System.IntPtr obj, System.IntPtr fieldID, char val)
- public static void SetDoubleField(System.IntPtr obj, System.IntPtr fieldID, double val)
- public static void SetFloatField(System.IntPtr obj, System.IntPtr fieldID, float val)
- public static void SetIntField(System.IntPtr obj, System.IntPtr fieldID, int val)
- public static void SetLongField(System.IntPtr obj, System.IntPtr fieldID, long val)
- public static void SetObjectField(System.IntPtr obj, System.IntPtr fieldID, System.IntPtr val)
- public static void SetSByteField(System.IntPtr obj, System.IntPtr fieldID, sbyte val)
- public static void SetShortField(System.IntPtr obj, System.IntPtr fieldID, short val)
- public static void SetStaticBooleanField(System.IntPtr clazz, System.IntPtr fieldID, bool val)
- public static void SetStaticCharField(System.IntPtr clazz, System.IntPtr fieldID, char val)
- public static void SetStaticDoubleField(System.IntPtr clazz, System.IntPtr fieldID, double val)
- public static void SetStaticFloatField(System.IntPtr clazz, System.IntPtr fieldID, float val)
- public static void SetStaticIntField(System.IntPtr clazz, System.IntPtr fieldID, int val)
- public static void SetStaticLongField(System.IntPtr clazz, System.IntPtr fieldID, long val)
- public static void SetStaticObjectField(System.IntPtr clazz, System.IntPtr fieldID, System.IntPtr val)
- public static void SetStaticSByteField(System.IntPtr clazz, System.IntPtr fieldID, sbyte val)
- public static void SetStaticShortField(System.IntPtr clazz, System.IntPtr fieldID, short val)
- public static void SetStaticStringField(System.IntPtr clazz, System.IntPtr fieldID, string val)
- public static void SetStringField(System.IntPtr obj, System.IntPtr fieldID, string val)
- public static System.IntPtr ToBooleanArray(bool[] array)
- public static System.IntPtr ToByteArray(byte[] array)
- public static System.IntPtr ToCharArray(char[] array)
- public static System.IntPtr ToDoubleArray(double[] array)
- public static System.IntPtr ToFloatArray(float[] array)
- public static System.IntPtr ToIntArray(int[] array)
- public static System.IntPtr ToLongArray(long[] array)
- public static System.IntPtr ToObjectArray(System.IntPtr[] array)
- public static System.IntPtr ToObjectArray(System.IntPtr[] array, System.IntPtr type)
- public static System.IntPtr ToSByteArray(sbyte[] array)
- public static System.IntPtr ToShortArray(short[] array)

### internal class UnityEngine.AndroidReflection

#### Fields
- private static const string RELECTION_HELPER_CLASS_NAME
- private static readonly System.IntPtr s_FieldGetDeclaringClass
- private static readonly System.IntPtr s_ReflectionHelperCeateInvocationError
- private static readonly UnityEngine.GlobalJavaObjectRef s_ReflectionHelperClass
- private static readonly System.IntPtr s_ReflectionHelperGetConstructorID
- private static readonly System.IntPtr s_ReflectionHelperGetFieldID
- private static readonly System.IntPtr s_ReflectionHelperGetFieldSignature
- private static readonly System.IntPtr s_ReflectionHelperGetMethodID
- private static readonly System.IntPtr s_ReflectionHelperNewProxyInstance

#### Constructors
- public AndroidReflection()
- private static AndroidReflection()

#### Methods
- internal static System.IntPtr CreateInvocationError(System.Exception ex, bool methodNotFound)
- public static System.IntPtr GetConstructorMember(System.IntPtr jclass, string signature)
- public static System.IntPtr GetFieldClass(System.IntPtr field)
- public static System.IntPtr GetFieldMember(System.IntPtr jclass, string fieldName, string signature, bool isStatic)
- public static string GetFieldSignature(System.IntPtr field)
- private static System.IntPtr GetMethodID(string clazz, string methodName, string signature)
- public static System.IntPtr GetMethodMember(System.IntPtr jclass, string methodName, string signature, bool isStatic)
- private static System.IntPtr GetStaticMethodID(string clazz, string methodName, string signature)
- public static bool IsAssignableFrom(System.Type t, System.Type from)
- public static bool IsPrimitive(System.Type t)
- public static System.IntPtr NewProxyInstance(System.IntPtr player, System.IntPtr delegateHandle, System.IntPtr interfaze)

### internal class UnityEngine.GlobalJavaObjectRef

#### Fields
- private bool m_disposed
- protected System.IntPtr m_jobject

#### Constructors
- public GlobalJavaObjectRef(System.IntPtr jobject)

#### Methods
- public void Dispose()
- protected override void Finalize()
- public static System.IntPtr op_Implicit(UnityEngine.GlobalJavaObjectRef obj)

### public struct UnityEngine.JNINativeMethod

#### Fields
- public System.IntPtr fnPtr
- public string name
- public string signature

### public struct UnityEngine.jvalue

#### Fields
- public sbyte b
- public char c
- public double d
- public float f
- public int i
- public long j
- public System.IntPtr l
- public short s
- public bool z

### internal class UnityEngine._AndroidJNIHelper

#### Constructors
- public _AndroidJNIHelper()

#### Methods
- public static UnityEngine.AndroidJavaObject Box(object obj)
- public static ArrayType ConvertFromJNIArray<ArrayType>(System.IntPtr array)
- public static System.IntPtr ConvertToJNIArray(System.Array array)
- public static System.IntPtr CreateJavaProxy(System.IntPtr player, System.IntPtr delegateHandle, UnityEngine.AndroidJavaProxy proxy)
- public static System.IntPtr CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable)
- public static void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> ret)
- public static void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs)
- public static System.IntPtr GetConstructorID(System.IntPtr jclass, object[] args)
- public static System.IntPtr GetConstructorID(System.IntPtr jclass, string signature)
- public static System.IntPtr GetFieldID<ReturnType>(System.IntPtr jclass, string fieldName, bool isStatic)
- public static System.IntPtr GetFieldID(System.IntPtr jclass, string fieldName, string signature, bool isStatic)
- public static System.IntPtr GetMethodID(System.IntPtr jclass, string methodName, object[] args, bool isStatic)
- public static System.IntPtr GetMethodID<ReturnType>(System.IntPtr jclass, string methodName, object[] args, bool isStatic)
- public static System.IntPtr GetMethodID(System.IntPtr jclass, string methodName, string signature, bool isStatic)
- private static System.IntPtr GetMethodIDFallback(System.IntPtr jclass, string methodName, string signature, bool isStatic)
- public static string GetSignature(object obj)
- public static string GetSignature(object[] args)
- public static string GetSignature<ReturnType>(object[] args)
- public static System.IntPtr InvokeJavaProxyMethod(UnityEngine.AndroidJavaProxy proxy, System.IntPtr jmethodName, System.IntPtr jargs)
- public static object Unbox(UnityEngine.AndroidJavaObject obj)
- public static object UnboxArray(UnityEngine.AndroidJavaObject obj)

## Namespace: UnityEngine.Android

### private class UnityEngine.Android.DownloadAssetPackAsyncOperation.<>c

#### Fields
- public static readonly UnityEngine.Android.DownloadAssetPackAsyncOperation.<>c <>9
- public static System.Func<string, string> <>9__11_0
- public static System.Func<string, UnityEngine.Android.AndroidAssetPackInfo> <>9__11_1

#### Constructors
- private static DownloadAssetPackAsyncOperation.<>c()
- public DownloadAssetPackAsyncOperation.<>c()

#### Methods
- internal string <.ctor>b__11_0(string name)
- internal UnityEngine.Android.AndroidAssetPackInfo <.ctor>b__11_1(string name)

### internal static class UnityEngine.Android.AndroidApp

#### Fields
- private static UnityEngine.AndroidJavaObject m_Activity
- private static UnityEngine.AndroidJavaObject m_Context
- private static UnityEngine.AndroidJavaObject m_UnityPlayer

#### Properties
- public static UnityEngine.AndroidJavaObject Activity { get; }
- public static UnityEngine.AndroidJavaObject Context { get; }
- public static UnityEngine.AndroidJavaObject UnityPlayer { get; }
- public static System.IntPtr UnityPlayerRaw { get; }

#### Methods
- private static void AcquireContextAndActivity()

### public enum UnityEngine.Android.AndroidAssetPackError
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AccessDenied = -7
- ApiNotAvailable = -5
- AppNotOwned = -13
- AppUnavailable = -1
- DownloadNotFound = -4
- InsufficientStorage = -10
- InternalError = -100
- InvalidRequest = -3
- NetworkError = -6
- NetworkUnrestricted = -12
- NoError = 0
- PackUnavailable = -2
- PlayStoreNotFound = -11

### public class UnityEngine.Android.AndroidAssetPackInfo

#### Fields
- private readonly ulong <bytesDownloaded>k__BackingField
- private readonly UnityEngine.Android.AndroidAssetPackError <error>k__BackingField
- private readonly string <name>k__BackingField
- private readonly ulong <size>k__BackingField
- private readonly UnityEngine.Android.AndroidAssetPackStatus <status>k__BackingField
- private readonly float <transferProgress>k__BackingField

#### Properties
- public ulong bytesDownloaded { get; }
- public UnityEngine.Android.AndroidAssetPackError error { get; }
- public string name { get; }
- public ulong size { get; }
- public UnityEngine.Android.AndroidAssetPackStatus status { get; }
- public float transferProgress { get; }

#### Constructors
- internal AndroidAssetPackInfo(string name, UnityEngine.Android.AndroidAssetPackStatus status, ulong size, ulong bytesDownloaded, float transferProgress, UnityEngine.Android.AndroidAssetPackError error)

### public static class UnityEngine.Android.AndroidAssetPacks

#### Properties
- public static bool coreUnityAssetPacksDownloaded { get; }
- internal static string dataPackName { get; }
- internal static string streamingAssetsPackName { get; }

#### Methods
- public static void CancelAssetPackDownload(string[] assetPackNames)
- private static bool CoreUnityAssetPacksDownloaded()
- public static void DownloadAssetPackAsync(string[] assetPackNames, System.Action<UnityEngine.Android.AndroidAssetPackInfo> callback)
- public static UnityEngine.Android.DownloadAssetPackAsyncOperation DownloadAssetPackAsync(string[] assetPackNames)
- public static string GetAssetPackPath(string assetPackName)
- public static void GetAssetPackStateAsync(string[] assetPackNames, System.Action<ulong, UnityEngine.Android.AndroidAssetPackState[]> callback)
- public static UnityEngine.Android.GetAssetPackStateAsyncOperation GetAssetPackStateAsync(string[] assetPackNames)
- public static string[] GetCoreUnityAssetPackNames()
- private static string GetDataPackName()
- private static string GetStreamingAssetsPackName()
- public static void RemoveAssetPack(string assetPackName)
- public static void RequestToUseMobileDataAsync(System.Action<UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult> callback)
- public static UnityEngine.Android.RequestToUseMobileDataAsyncOperation RequestToUseMobileDataAsync()

### public class UnityEngine.Android.AndroidAssetPackState

#### Fields
- private readonly UnityEngine.Android.AndroidAssetPackError <error>k__BackingField
- private readonly string <name>k__BackingField
- private readonly UnityEngine.Android.AndroidAssetPackStatus <status>k__BackingField

#### Properties
- public UnityEngine.Android.AndroidAssetPackError error { get; }
- public string name { get; }
- public UnityEngine.Android.AndroidAssetPackStatus status { get; }

#### Constructors
- internal AndroidAssetPackState(string name, UnityEngine.Android.AndroidAssetPackStatus status, UnityEngine.Android.AndroidAssetPackError error)

### public enum UnityEngine.Android.AndroidAssetPackStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Canceled = 6
- Completed = 4
- Downloading = 2
- Failed = 5
- NotInstalled = 8
- Pending = 1
- Transferring = 3
- Unknown = 0
- WaitingForWifi = 7

### public class UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult

#### Fields
- private readonly bool <allowed>k__BackingField

#### Properties
- public bool allowed { get; }

#### Constructors
- internal AndroidAssetPackUseMobileDataRequestResult(bool allowed)

### public class UnityEngine.Android.AndroidDevice

#### Properties
- public static UnityEngine.Android.AndroidHardwareType hardwareType { get; }

#### Constructors
- public AndroidDevice()

#### Methods
- public static void SetSustainedPerformanceMode(bool enabled)

### public enum UnityEngine.Android.AndroidHardwareType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ChromeOS = 1
- Generic = 0

### public static class UnityEngine.Android.DiagnosticsReporting

#### Methods
- public static void CallReportFullyDrawn()

### public class UnityEngine.Android.DownloadAssetPackAsyncOperation
- Base: UnityEngine.CustomYieldInstruction
- Interfaces: System.Collections.IEnumerator

#### Fields
- private System.Collections.Generic.Dictionary<string, UnityEngine.Android.AndroidAssetPackInfo> m_AssetPackInfos

#### Properties
- public string[] downloadedAssetPacks { get; }
- public string[] downloadFailedAssetPacks { get; }
- public bool isDone { get; }
- public bool keepWaiting { get; }
- public float progress { get; }

#### Constructors
- internal DownloadAssetPackAsyncOperation(string[] assetPackNames)

#### Methods
- internal void OnUpdate(UnityEngine.Android.AndroidAssetPackInfo info)

### public class UnityEngine.Android.GetAssetPackStateAsyncOperation
- Base: UnityEngine.CustomYieldInstruction
- Interfaces: System.Collections.IEnumerator

#### Fields
- private readonly object m_OperationLock
- private ulong m_Size
- private UnityEngine.Android.AndroidAssetPackState[] m_States

#### Properties
- public bool isDone { get; }
- public bool keepWaiting { get; }
- public ulong size { get; }
- public UnityEngine.Android.AndroidAssetPackState[] states { get; }

#### Constructors
- internal GetAssetPackStateAsyncOperation()

#### Methods
- internal void OnResult(ulong size, UnityEngine.Android.AndroidAssetPackState[] states)

### public struct UnityEngine.Android.Permission

#### Fields
- public static const string Camera
- public static const string CoarseLocation
- public static const string ExternalStorageRead
- public static const string ExternalStorageWrite
- public static const string FineLocation
- public static const string Microphone
- private static UnityEngine.AndroidJavaObject m_UnityPermissions

#### Methods
- private static UnityEngine.AndroidJavaObject GetUnityPermissions()
- public static bool HasUserAuthorizedPermission(string permission)
- public static void RequestUserPermission(string permission)
- public static void RequestUserPermission(string permission, UnityEngine.Android.PermissionCallbacks callbacks)
- public static void RequestUserPermissions(string[] permissions)
- public static void RequestUserPermissions(string[] permissions, UnityEngine.Android.PermissionCallbacks callbacks)

### public class UnityEngine.Android.PermissionCallbacks
- Base: UnityEngine.AndroidJavaProxy

#### Fields
- private System.Action<string> PermissionDenied
- private System.Action<string> PermissionDeniedAndDontAskAgain
- private System.Action<string> PermissionGranted

#### Events
- public event System.Action<string> PermissionDenied
- public event System.Action<string> PermissionDeniedAndDontAskAgain
- public event System.Action<string> PermissionGranted

#### Constructors
- public PermissionCallbacks()

#### Methods
- private void onPermissionDenied(string permissionName)
- private void onPermissionDeniedAndDontAskAgain(string permissionName)
- private void onPermissionGranted(string permissionName)

### public class UnityEngine.Android.RequestToUseMobileDataAsyncOperation
- Base: UnityEngine.CustomYieldInstruction
- Interfaces: System.Collections.IEnumerator

#### Fields
- private readonly object m_OperationLock
- private UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult m_RequestResult

#### Properties
- public bool isDone { get; }
- public bool keepWaiting { get; }
- public UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult result { get; }

#### Constructors
- internal RequestToUseMobileDataAsyncOperation()

#### Methods
- internal void OnResult(UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult result)

