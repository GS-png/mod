# Assembly: nunit.framework
- Path: tools/WorldBox.Managed/nunit.framework.dll
- Types: 463

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 055CECA622BD87BB0FEC22E1169DB14ABBB795CDA70AD5FDD3363B88F61D2E07
- internal static readonly long C65FF76D950BEAC710050526425F2766D44BD48A125EFCCD7A57BA45CD579664

#### Methods
- internal static uint ComputeStringHash(string s)

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6

## Namespace: NUnit

### public class NUnit.Env

#### Fields
- public static readonly string DefaultWorkDirectory
- public static string DocumentFolder
- public static readonly string NewLine

#### Constructors
- public Env()
- private static Env()

### public static class NUnit.FrameworkPackageSettings

#### Fields
- public static const string DebugTests
- public static const string DefaultTestNamePattern
- public static const string DefaultTimeout
- public static const string InternalTraceLevel
- public static const string InternalTraceWriter
- public static const string LOAD
- public static const string NumberOfTestWorkers
- public static const string PauseBeforeRun
- public static const string RandomSeed
- public static const string StopOnError
- public static const string SynchronousEvents
- public static const string TestParameters
- public static const string WorkDirectory

## Namespace: NUnit.Compatibility

### private class NUnit.Compatibility.AdditionalTypeExtensions.<>c__DisplayClass2_0

#### Fields
- public System.Type to

#### Constructors
- public AdditionalTypeExtensions.<>c__DisplayClass2_0()

#### Methods
- internal bool <IsCastableFrom>b__0(System.Reflection.MethodInfo m)

### public static class NUnit.Compatibility.AdditionalTypeExtensions

#### Fields
- private static System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<System.Type>> convertibleValueTypes

#### Constructors
- private static AdditionalTypeExtensions()

#### Methods
- public static bool IsCastableFrom(System.Type to, System.Type from)
- public static bool ParametersMatch(System.Reflection.ParameterInfo[] pinfos, System.Type[] ptypes)

### public static class NUnit.Compatibility.AssemblyExtensions

#### Methods
- public static T GetCustomAttribute<T>(System.Reflection.Assembly assembly)

### public static class NUnit.Compatibility.AttributeHelper

#### Methods
- public static System.Attribute[] GetCustomAttributes(object actual, System.Type attributeType, bool inherit)

### public class NUnit.Compatibility.LongLivedMarshalByRefObject
- Base: System.MarshalByRefObject

#### Constructors
- public LongLivedMarshalByRefObject()

#### Methods
- public override object InitializeLifetimeService()

### public class NUnit.Compatibility.NUnitNullType

#### Constructors
- public NUnitNullType()

### public static class NUnit.Compatibility.TypeExtensions

#### Methods
- public static System.Type GetTypeInfo(System.Type type)

## Namespace: NUnit.Framework

### private class NUnit.Framework.TestContext.<>c__DisplayClass58_0<TSUPPORTED>

#### Fields
- public NUnit.Framework.Constraints.ValueFormatter formatter

#### Constructors
- public TestContext.<>c__DisplayClass58_0<TSUPPORTED>()

#### Methods
- internal NUnit.Framework.Constraints.ValueFormatter <AddFormatter>b__0(NUnit.Framework.Constraints.ValueFormatter next)

### private class NUnit.Framework.TestContext.<>c__DisplayClass58_1<TSUPPORTED>

#### Fields
- public NUnit.Framework.TestContext.<>c__DisplayClass58_0<TSUPPORTED> CS$<>8__locals1
- public NUnit.Framework.Constraints.ValueFormatter next

#### Constructors
- public TestContext.<>c__DisplayClass58_1<TSUPPORTED>()

#### Methods
- internal string <AddFormatter>b__1(object val)

### private class NUnit.Framework.TestFixtureSourceAttribute.<BuildFrom>d__17
- Interfaces: System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestSuite>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<NUnit.Framework.Internal.TestSuite>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private NUnit.Framework.Internal.TestSuite <>2__current
- public NUnit.Framework.Interfaces.ITypeInfo <>3__typeInfo
- public NUnit.Framework.TestFixtureSourceAttribute <>4__this
- private int <>l__initialThreadId
- private System.Collections.Generic.IEnumerator<NUnit.Framework.Interfaces.ITestFixtureData> <>s__2
- private NUnit.Framework.Internal.TestFixtureParameters <parms>5__3
- private System.Type <sourceType>5__1
- private NUnit.Framework.Interfaces.ITypeInfo typeInfo

#### Properties
- private NUnit.Framework.Internal.TestSuite System.Collections.Generic.IEnumerator<NUnit.Framework.Internal.TestSuite>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public TestFixtureSourceAttribute.<BuildFrom>d__17(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<NUnit.Framework.Internal.TestSuite> System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestSuite>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class NUnit.Framework.TestCaseSourceAttribute.<BuildFrom>d__21
- Interfaces: System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestMethod>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<NUnit.Framework.Internal.TestMethod>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private NUnit.Framework.Internal.TestMethod <>2__current
- public NUnit.Framework.Interfaces.IMethodInfo <>3__method
- public NUnit.Framework.Internal.Test <>3__suite
- public NUnit.Framework.TestCaseSourceAttribute <>4__this
- private int <>l__initialThreadId
- private System.Collections.Generic.IEnumerator<NUnit.Framework.Interfaces.ITestCaseData> <>s__1
- private NUnit.Framework.Internal.TestCaseParameters <parms>5__2
- private NUnit.Framework.Interfaces.IMethodInfo method
- private NUnit.Framework.Internal.Test suite

#### Properties
- private NUnit.Framework.Internal.TestMethod System.Collections.Generic.IEnumerator<NUnit.Framework.Internal.TestMethod>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public TestCaseSourceAttribute.<BuildFrom>d__21(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<NUnit.Framework.Internal.TestMethod> System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestMethod>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class NUnit.Framework.TestFixtureAttribute.<BuildFrom>d__48
- Interfaces: System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestSuite>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<NUnit.Framework.Internal.TestSuite>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private NUnit.Framework.Internal.TestSuite <>2__current
- public NUnit.Framework.Interfaces.ITypeInfo <>3__typeInfo
- public NUnit.Framework.TestFixtureAttribute <>4__this
- private int <>l__initialThreadId
- private NUnit.Framework.Interfaces.ITypeInfo typeInfo

#### Properties
- private NUnit.Framework.Internal.TestSuite System.Collections.Generic.IEnumerator<NUnit.Framework.Internal.TestSuite>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public TestFixtureAttribute.<BuildFrom>d__48(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<NUnit.Framework.Internal.TestSuite> System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestSuite>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class NUnit.Framework.TestCaseAttribute.<BuildFrom>d__63
- Interfaces: System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestMethod>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<NUnit.Framework.Internal.TestMethod>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private NUnit.Framework.Internal.TestMethod <>2__current
- public NUnit.Framework.Interfaces.IMethodInfo <>3__method
- public NUnit.Framework.Internal.Test <>3__suite
- public NUnit.Framework.TestCaseAttribute <>4__this
- private int <>l__initialThreadId
- private NUnit.Framework.Internal.PlatformHelper <platformHelper>5__2
- private NUnit.Framework.Internal.TestMethod <test>5__1
- private NUnit.Framework.Interfaces.IMethodInfo method
- private NUnit.Framework.Internal.Test suite

#### Properties
- private NUnit.Framework.Internal.TestMethod System.Collections.Generic.IEnumerator<NUnit.Framework.Internal.TestMethod>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public TestCaseAttribute.<BuildFrom>d__63(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<NUnit.Framework.Internal.TestMethod> System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestMethod>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class NUnit.Framework.RandomAttribute.RandomDataConverter.<GetData>d__2
- Interfaces: System.Collections.Generic.IEnumerable<object>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public NUnit.Framework.Interfaces.IParameterInfo <>3__parameter
- public NUnit.Framework.RandomAttribute.RandomDataConverter <>4__this
- private int <>l__initialThreadId
- private System.Collections.IEnumerator <>s__2
- private double <d>5__5
- private int <ival>5__4
- private object <obj>5__3
- private System.Type <parmType>5__1
- private NUnit.Framework.Interfaces.IParameterInfo parameter

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public RandomAttribute.RandomDataConverter.<GetData>d__2(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class NUnit.Framework.RandomAttribute.EnumDataSource.<GetData>d__2
- Interfaces: System.Collections.Generic.IEnumerable<object>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public NUnit.Framework.Interfaces.IParameterInfo <>3__parameter
- public NUnit.Framework.RandomAttribute.EnumDataSource <>4__this
- private int <>l__initialThreadId
- private int <i>5__2
- private NUnit.Framework.Internal.Randomizer <randomizer>5__1
- private NUnit.Framework.Interfaces.IParameterInfo parameter

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public RandomAttribute.EnumDataSource.<GetData>d__2(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class NUnit.Framework.RandomAttribute.RandomDataSource<T>.<GetData>d__7<T>
- Interfaces: System.Collections.Generic.IEnumerable<object>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public NUnit.Framework.Interfaces.IParameterInfo <>3__parameter
- public NUnit.Framework.RandomAttribute.RandomDataSource<T> <>4__this
- private int <>l__initialThreadId
- private int <i>5__1
- private NUnit.Framework.Interfaces.IParameterInfo parameter

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public RandomAttribute.RandomDataSource<T>.<GetData>d__7<T>(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### public enum NUnit.Framework.ActionTargets
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Default = 0
- Suite = 2
- Test = 1

### public class NUnit.Framework.ApartmentAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Constructors
- public ApartmentAttribute(System.Threading.ApartmentState apartmentState)

### public class NUnit.Framework.Assert

#### Constructors
- protected Assert()

#### Methods
- public static void AreEqual(double expected, double actual, double delta, string message, params object[] args)
- public static void AreEqual(double expected, double actual, double delta)
- public static void AreEqual(double expected, System.Nullable<double> actual, double delta, string message, params object[] args)
- public static void AreEqual(double expected, System.Nullable<double> actual, double delta)
- public static void AreEqual(object expected, object actual, string message, params object[] args)
- public static void AreEqual(object expected, object actual)
- public static void AreNotEqual(object expected, object actual, string message, params object[] args)
- public static void AreNotEqual(object expected, object actual)
- public static void AreNotSame(object expected, object actual, string message, params object[] args)
- public static void AreNotSame(object expected, object actual)
- public static void AreSame(object expected, object actual, string message, params object[] args)
- public static void AreSame(object expected, object actual)
- protected static void AssertDoublesAreEqual(double expected, double actual, double delta, string message, object[] args)
- public static void ByVal(object actual, NUnit.Framework.Constraints.IResolveConstraint expression)
- public static void ByVal(object actual, NUnit.Framework.Constraints.IResolveConstraint expression, string message, params object[] args)
- public static System.Exception Catch(NUnit.Framework.TestDelegate code, string message, params object[] args)
- public static System.Exception Catch(NUnit.Framework.TestDelegate code)
- public static System.Exception Catch(System.Type expectedExceptionType, NUnit.Framework.TestDelegate code, string message, params object[] args)
- public static System.Exception Catch(System.Type expectedExceptionType, NUnit.Framework.TestDelegate code)
- public static TActual Catch<TActual>(NUnit.Framework.TestDelegate code, string message, params object[] args)
- public static TActual Catch<TActual>(NUnit.Framework.TestDelegate code)
- public static void Contains(object expected, System.Collections.ICollection actual, string message, params object[] args)
- public static void Contains(object expected, System.Collections.ICollection actual)
- public static void DoesNotThrow(NUnit.Framework.TestDelegate code, string message, params object[] args)
- public static void DoesNotThrow(NUnit.Framework.TestDelegate code)
- public static bool Equals(object a, object b)
- public static void Fail(string message, params object[] args)
- public static void Fail(string message)
- public static void Fail()
- public static void False(System.Nullable<bool> condition, string message, params object[] args)
- public static void False(bool condition, string message, params object[] args)
- public static void False(System.Nullable<bool> condition)
- public static void False(bool condition)
- public static void Greater(int arg1, int arg2, string message, params object[] args)
- public static void Greater(int arg1, int arg2)
- public static void Greater(uint arg1, uint arg2, string message, params object[] args)
- public static void Greater(uint arg1, uint arg2)
- public static void Greater(long arg1, long arg2, string message, params object[] args)
- public static void Greater(long arg1, long arg2)
- public static void Greater(ulong arg1, ulong arg2, string message, params object[] args)
- public static void Greater(ulong arg1, ulong arg2)
- public static void Greater(decimal arg1, decimal arg2, string message, params object[] args)
- public static void Greater(decimal arg1, decimal arg2)
- public static void Greater(double arg1, double arg2, string message, params object[] args)
- public static void Greater(double arg1, double arg2)
- public static void Greater(float arg1, float arg2, string message, params object[] args)
- public static void Greater(float arg1, float arg2)
- public static void Greater(System.IComparable arg1, System.IComparable arg2, string message, params object[] args)
- public static void Greater(System.IComparable arg1, System.IComparable arg2)
- public static void GreaterOrEqual(int arg1, int arg2, string message, params object[] args)
- public static void GreaterOrEqual(int arg1, int arg2)
- public static void GreaterOrEqual(uint arg1, uint arg2, string message, params object[] args)
- public static void GreaterOrEqual(uint arg1, uint arg2)
- public static void GreaterOrEqual(long arg1, long arg2, string message, params object[] args)
- public static void GreaterOrEqual(long arg1, long arg2)
- public static void GreaterOrEqual(ulong arg1, ulong arg2, string message, params object[] args)
- public static void GreaterOrEqual(ulong arg1, ulong arg2)
- public static void GreaterOrEqual(decimal arg1, decimal arg2, string message, params object[] args)
- public static void GreaterOrEqual(decimal arg1, decimal arg2)
- public static void GreaterOrEqual(double arg1, double arg2, string message, params object[] args)
- public static void GreaterOrEqual(double arg1, double arg2)
- public static void GreaterOrEqual(float arg1, float arg2, string message, params object[] args)
- public static void GreaterOrEqual(float arg1, float arg2)
- public static void GreaterOrEqual(System.IComparable arg1, System.IComparable arg2, string message, params object[] args)
- public static void GreaterOrEqual(System.IComparable arg1, System.IComparable arg2)
- public static void Ignore(string message, params object[] args)
- public static void Ignore(string message)
- public static void Ignore()
- public static void Inconclusive(string message, params object[] args)
- public static void Inconclusive(string message)
- public static void Inconclusive()
- private static void IncrementAssertCount()
- public static void IsAssignableFrom(System.Type expected, object actual, string message, params object[] args)
- public static void IsAssignableFrom(System.Type expected, object actual)
- public static void IsAssignableFrom<TExpected>(object actual, string message, params object[] args)
- public static void IsAssignableFrom<TExpected>(object actual)
- public static void IsEmpty(string aString, string message, params object[] args)
- public static void IsEmpty(string aString)
- public static void IsEmpty(System.Collections.IEnumerable collection, string message, params object[] args)
- public static void IsEmpty(System.Collections.IEnumerable collection)
- public static void IsFalse(System.Nullable<bool> condition, string message, params object[] args)
- public static void IsFalse(bool condition, string message, params object[] args)
- public static void IsFalse(System.Nullable<bool> condition)
- public static void IsFalse(bool condition)
- public static void IsInstanceOf(System.Type expected, object actual, string message, params object[] args)
- public static void IsInstanceOf(System.Type expected, object actual)
- public static void IsInstanceOf<TExpected>(object actual, string message, params object[] args)
- public static void IsInstanceOf<TExpected>(object actual)
- public static void IsNaN(double aDouble, string message, params object[] args)
- public static void IsNaN(double aDouble)
- public static void IsNaN(System.Nullable<double> aDouble, string message, params object[] args)
- public static void IsNaN(System.Nullable<double> aDouble)
- public static void IsNotAssignableFrom(System.Type expected, object actual, string message, params object[] args)
- public static void IsNotAssignableFrom(System.Type expected, object actual)
- public static void IsNotAssignableFrom<TExpected>(object actual, string message, params object[] args)
- public static void IsNotAssignableFrom<TExpected>(object actual)
- public static void IsNotEmpty(string aString, string message, params object[] args)
- public static void IsNotEmpty(string aString)
- public static void IsNotEmpty(System.Collections.IEnumerable collection, string message, params object[] args)
- public static void IsNotEmpty(System.Collections.IEnumerable collection)
- public static void IsNotInstanceOf(System.Type expected, object actual, string message, params object[] args)
- public static void IsNotInstanceOf(System.Type expected, object actual)
- public static void IsNotInstanceOf<TExpected>(object actual, string message, params object[] args)
- public static void IsNotInstanceOf<TExpected>(object actual)
- public static void IsNotNull(object anObject, string message, params object[] args)
- public static void IsNotNull(object anObject)
- public static void IsNull(object anObject, string message, params object[] args)
- public static void IsNull(object anObject)
- public static void IsTrue(System.Nullable<bool> condition, string message, params object[] args)
- public static void IsTrue(bool condition, string message, params object[] args)
- public static void IsTrue(System.Nullable<bool> condition)
- public static void IsTrue(bool condition)
- public static void Less(int arg1, int arg2, string message, params object[] args)
- public static void Less(int arg1, int arg2)
- public static void Less(uint arg1, uint arg2, string message, params object[] args)
- public static void Less(uint arg1, uint arg2)
- public static void Less(long arg1, long arg2, string message, params object[] args)
- public static void Less(long arg1, long arg2)
- public static void Less(ulong arg1, ulong arg2, string message, params object[] args)
- public static void Less(ulong arg1, ulong arg2)
- public static void Less(decimal arg1, decimal arg2, string message, params object[] args)
- public static void Less(decimal arg1, decimal arg2)
- public static void Less(double arg1, double arg2, string message, params object[] args)
- public static void Less(double arg1, double arg2)
- public static void Less(float arg1, float arg2, string message, params object[] args)
- public static void Less(float arg1, float arg2)
- public static void Less(System.IComparable arg1, System.IComparable arg2, string message, params object[] args)
- public static void Less(System.IComparable arg1, System.IComparable arg2)
- public static void LessOrEqual(int arg1, int arg2, string message, params object[] args)
- public static void LessOrEqual(int arg1, int arg2)
- public static void LessOrEqual(uint arg1, uint arg2, string message, params object[] args)
- public static void LessOrEqual(uint arg1, uint arg2)
- public static void LessOrEqual(long arg1, long arg2, string message, params object[] args)
- public static void LessOrEqual(long arg1, long arg2)
- public static void LessOrEqual(ulong arg1, ulong arg2, string message, params object[] args)
- public static void LessOrEqual(ulong arg1, ulong arg2)
- public static void LessOrEqual(decimal arg1, decimal arg2, string message, params object[] args)
- public static void LessOrEqual(decimal arg1, decimal arg2)
- public static void LessOrEqual(double arg1, double arg2, string message, params object[] args)
- public static void LessOrEqual(double arg1, double arg2)
- public static void LessOrEqual(float arg1, float arg2, string message, params object[] args)
- public static void LessOrEqual(float arg1, float arg2)
- public static void LessOrEqual(System.IComparable arg1, System.IComparable arg2, string message, params object[] args)
- public static void LessOrEqual(System.IComparable arg1, System.IComparable arg2)
- public static void Negative(int actual)
- public static void Negative(int actual, string message, params object[] args)
- public static void Negative(uint actual)
- public static void Negative(uint actual, string message, params object[] args)
- public static void Negative(long actual)
- public static void Negative(long actual, string message, params object[] args)
- public static void Negative(ulong actual)
- public static void Negative(ulong actual, string message, params object[] args)
- public static void Negative(decimal actual)
- public static void Negative(decimal actual, string message, params object[] args)
- public static void Negative(double actual)
- public static void Negative(double actual, string message, params object[] args)
- public static void Negative(float actual)
- public static void Negative(float actual, string message, params object[] args)
- public static void NotNull(object anObject, string message, params object[] args)
- public static void NotNull(object anObject)
- public static void NotZero(int actual)
- public static void NotZero(int actual, string message, params object[] args)
- public static void NotZero(uint actual)
- public static void NotZero(uint actual, string message, params object[] args)
- public static void NotZero(long actual)
- public static void NotZero(long actual, string message, params object[] args)
- public static void NotZero(ulong actual)
- public static void NotZero(ulong actual, string message, params object[] args)
- public static void NotZero(decimal actual)
- public static void NotZero(decimal actual, string message, params object[] args)
- public static void NotZero(double actual)
- public static void NotZero(double actual, string message, params object[] args)
- public static void NotZero(float actual)
- public static void NotZero(float actual, string message, params object[] args)
- public static void Null(object anObject, string message, params object[] args)
- public static void Null(object anObject)
- public static void Pass(string message, params object[] args)
- public static void Pass(string message)
- public static void Pass()
- public static void Positive(int actual)
- public static void Positive(int actual, string message, params object[] args)
- public static void Positive(uint actual)
- public static void Positive(uint actual, string message, params object[] args)
- public static void Positive(long actual)
- public static void Positive(long actual, string message, params object[] args)
- public static void Positive(ulong actual)
- public static void Positive(ulong actual, string message, params object[] args)
- public static void Positive(decimal actual)
- public static void Positive(decimal actual, string message, params object[] args)
- public static void Positive(double actual)
- public static void Positive(double actual, string message, params object[] args)
- public static void Positive(float actual)
- public static void Positive(float actual, string message, params object[] args)
- public static void ReferenceEquals(object a, object b)
- public static void That(bool condition, string message, params object[] args)
- public static void That(bool condition)
- public static void That(bool condition, System.Func<string> getExceptionMessage)
- public static void That(System.Func<bool> condition, string message, params object[] args)
- public static void That(System.Func<bool> condition)
- public static void That(System.Func<bool> condition, System.Func<string> getExceptionMessage)
- public static void That<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del, NUnit.Framework.Constraints.IResolveConstraint expr)
- public static void That<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del, NUnit.Framework.Constraints.IResolveConstraint expr, string message, params object[] args)
- public static void That<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del, NUnit.Framework.Constraints.IResolveConstraint expr, System.Func<string> getExceptionMessage)
- public static void That(NUnit.Framework.TestDelegate code, NUnit.Framework.Constraints.IResolveConstraint constraint)
- public static void That(NUnit.Framework.TestDelegate code, NUnit.Framework.Constraints.IResolveConstraint constraint, string message, params object[] args)
- public static void That(NUnit.Framework.TestDelegate code, NUnit.Framework.Constraints.IResolveConstraint constraint, System.Func<string> getExceptionMessage)
- public static void That<TActual>(TActual actual, NUnit.Framework.Constraints.IResolveConstraint expression)
- public static void That<TActual>(TActual actual, NUnit.Framework.Constraints.IResolveConstraint expression, string message, params object[] args)
- public static void That<TActual>(TActual actual, NUnit.Framework.Constraints.IResolveConstraint expression, System.Func<string> getExceptionMessage)
- public static System.Exception Throws(NUnit.Framework.Constraints.IResolveConstraint expression, NUnit.Framework.TestDelegate code, string message, params object[] args)
- public static System.Exception Throws(NUnit.Framework.Constraints.IResolveConstraint expression, NUnit.Framework.TestDelegate code)
- public static System.Exception Throws(System.Type expectedExceptionType, NUnit.Framework.TestDelegate code, string message, params object[] args)
- public static System.Exception Throws(System.Type expectedExceptionType, NUnit.Framework.TestDelegate code)
- public static TActual Throws<TActual>(NUnit.Framework.TestDelegate code, string message, params object[] args)
- public static TActual Throws<TActual>(NUnit.Framework.TestDelegate code)
- public static void True(System.Nullable<bool> condition, string message, params object[] args)
- public static void True(bool condition, string message, params object[] args)
- public static void True(System.Nullable<bool> condition)
- public static void True(bool condition)
- public static void Zero(int actual)
- public static void Zero(int actual, string message, params object[] args)
- public static void Zero(uint actual)
- public static void Zero(uint actual, string message, params object[] args)
- public static void Zero(long actual)
- public static void Zero(long actual, string message, params object[] args)
- public static void Zero(ulong actual)
- public static void Zero(ulong actual, string message, params object[] args)
- public static void Zero(decimal actual)
- public static void Zero(decimal actual, string message, params object[] args)
- public static void Zero(double actual)
- public static void Zero(double actual, string message, params object[] args)
- public static void Zero(float actual)
- public static void Zero(float actual, string message, params object[] args)

### public class NUnit.Framework.AssertionException
- Base: NUnit.Framework.ResultStateException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Properties
- public NUnit.Framework.Interfaces.ResultState ResultState { get; }

#### Constructors
- public AssertionException(string message)
- public AssertionException(string message, System.Exception inner)
- protected AssertionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### public class NUnit.Framework.AssertionHelper
- Base: NUnit.Framework.Constraints.ConstraintFactory

#### Constructors
- public AssertionHelper()

#### Methods
- public void Expect(bool condition, string message, params object[] args)
- public void Expect(bool condition)
- public void Expect<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del, NUnit.Framework.Constraints.IResolveConstraint expr)
- public void Expect<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del, NUnit.Framework.Constraints.IResolveConstraint expr, string message, params object[] args)
- public void Expect(NUnit.Framework.TestDelegate code, NUnit.Framework.Constraints.IResolveConstraint constraint)
- public static void Expect<TActual>(TActual actual, NUnit.Framework.Constraints.IResolveConstraint expression)
- public static void Expect<TActual>(TActual actual, NUnit.Framework.Constraints.IResolveConstraint expression, string message, params object[] args)
- public NUnit.Framework.ListMapper Map(System.Collections.ICollection original)

### public class NUnit.Framework.Assume

#### Constructors
- public Assume()

#### Methods
- public static bool Equals(object a, object b)
- public static void ReferenceEquals(object a, object b)
- public static void That<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del, NUnit.Framework.Constraints.IResolveConstraint expr)
- public static void That<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del, NUnit.Framework.Constraints.IResolveConstraint expr, string message, params object[] args)
- public static void That<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del, NUnit.Framework.Constraints.IResolveConstraint expr, System.Func<string> getExceptionMessage)
- public static void That(bool condition, string message, params object[] args)
- public static void That(bool condition)
- public static void That(bool condition, System.Func<string> getExceptionMessage)
- public static void That(System.Func<bool> condition, string message, params object[] args)
- public static void That(System.Func<bool> condition)
- public static void That(System.Func<bool> condition, System.Func<string> getExceptionMessage)
- public static void That(NUnit.Framework.TestDelegate code, NUnit.Framework.Constraints.IResolveConstraint constraint)
- public static void That<TActual>(TActual actual, NUnit.Framework.Constraints.IResolveConstraint expression)
- public static void That<TActual>(TActual actual, NUnit.Framework.Constraints.IResolveConstraint expression, string message, params object[] args)
- public static void That<TActual>(TActual actual, NUnit.Framework.Constraints.IResolveConstraint expression, System.Func<string> getExceptionMessage)

### public class NUnit.Framework.AuthorAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Constructors
- public AuthorAttribute(string name)
- public AuthorAttribute(string name, string email)

### private class NUnit.Framework.RandomAttribute.ByteDataSource
- Base: NUnit.Framework.RandomAttribute.RandomDataSource<byte>
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Constructors
- public RandomAttribute.ByteDataSource(int count)
- public RandomAttribute.ByteDataSource(byte min, byte max, int count)

#### Methods
- protected override byte GetNext()
- protected override byte GetNext(byte min, byte max)

### public class NUnit.Framework.CategoryAttribute
- Base: NUnit.Framework.NUnitAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Fields
- protected string categoryName

#### Properties
- public string Name { get; }

#### Constructors
- protected CategoryAttribute()
- public CategoryAttribute(string name)

#### Methods
- public void ApplyToTest(NUnit.Framework.Internal.Test test)

### public class NUnit.Framework.CollectionAssert

#### Constructors
- public CollectionAssert()

#### Methods
- public static void AllItemsAreInstancesOfType(System.Collections.IEnumerable collection, System.Type expectedType)
- public static void AllItemsAreInstancesOfType(System.Collections.IEnumerable collection, System.Type expectedType, string message, params object[] args)
- public static void AllItemsAreNotNull(System.Collections.IEnumerable collection)
- public static void AllItemsAreNotNull(System.Collections.IEnumerable collection, string message, params object[] args)
- public static void AllItemsAreUnique(System.Collections.IEnumerable collection)
- public static void AllItemsAreUnique(System.Collections.IEnumerable collection, string message, params object[] args)
- public static void AreEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual)
- public static void AreEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, System.Collections.IComparer comparer)
- public static void AreEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, string message, params object[] args)
- public static void AreEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, System.Collections.IComparer comparer, string message, params object[] args)
- public static void AreEquivalent(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual)
- public static void AreEquivalent(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, string message, params object[] args)
- public static void AreNotEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual)
- public static void AreNotEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, System.Collections.IComparer comparer)
- public static void AreNotEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, string message, params object[] args)
- public static void AreNotEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, System.Collections.IComparer comparer, string message, params object[] args)
- public static void AreNotEquivalent(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual)
- public static void AreNotEquivalent(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, string message, params object[] args)
- public static void Contains(System.Collections.IEnumerable collection, object actual)
- public static void Contains(System.Collections.IEnumerable collection, object actual, string message, params object[] args)
- public static void DoesNotContain(System.Collections.IEnumerable collection, object actual)
- public static void DoesNotContain(System.Collections.IEnumerable collection, object actual, string message, params object[] args)
- public static bool Equals(object a, object b)
- public static void IsEmpty(System.Collections.IEnumerable collection, string message, params object[] args)
- public static void IsEmpty(System.Collections.IEnumerable collection)
- public static void IsNotEmpty(System.Collections.IEnumerable collection, string message, params object[] args)
- public static void IsNotEmpty(System.Collections.IEnumerable collection)
- public static void IsNotSubsetOf(System.Collections.IEnumerable subset, System.Collections.IEnumerable superset)
- public static void IsNotSubsetOf(System.Collections.IEnumerable subset, System.Collections.IEnumerable superset, string message, params object[] args)
- public static void IsNotSupersetOf(System.Collections.IEnumerable superset, System.Collections.IEnumerable subset)
- public static void IsNotSupersetOf(System.Collections.IEnumerable superset, System.Collections.IEnumerable subset, string message, params object[] args)
- public static void IsOrdered(System.Collections.IEnumerable collection, string message, params object[] args)
- public static void IsOrdered(System.Collections.IEnumerable collection)
- public static void IsOrdered(System.Collections.IEnumerable collection, System.Collections.IComparer comparer, string message, params object[] args)
- public static void IsOrdered(System.Collections.IEnumerable collection, System.Collections.IComparer comparer)
- public static void IsSubsetOf(System.Collections.IEnumerable subset, System.Collections.IEnumerable superset)
- public static void IsSubsetOf(System.Collections.IEnumerable subset, System.Collections.IEnumerable superset, string message, params object[] args)
- public static void IsSupersetOf(System.Collections.IEnumerable superset, System.Collections.IEnumerable subset)
- public static void IsSupersetOf(System.Collections.IEnumerable superset, System.Collections.IEnumerable subset, string message, params object[] args)
- public static void ReferenceEquals(object a, object b)

### public class NUnit.Framework.CombinatorialAttribute
- Base: NUnit.Framework.CombiningStrategyAttribute
- Interfaces: NUnit.Framework.Interfaces.ITestBuilder, NUnit.Framework.Interfaces.IApplyToTest

#### Constructors
- public CombinatorialAttribute()

### public class NUnit.Framework.CombiningStrategyAttribute
- Base: NUnit.Framework.NUnitAttribute
- Interfaces: NUnit.Framework.Interfaces.ITestBuilder, NUnit.Framework.Interfaces.IApplyToTest

#### Fields
- private NUnit.Framework.Internal.Builders.NUnitTestCaseBuilder _builder
- private NUnit.Framework.Interfaces.IParameterDataProvider _dataProvider
- private NUnit.Framework.Interfaces.ICombiningStrategy _strategy

#### Constructors
- protected CombiningStrategyAttribute(NUnit.Framework.Interfaces.ICombiningStrategy strategy, NUnit.Framework.Interfaces.IParameterDataProvider provider)
- protected CombiningStrategyAttribute(object strategy, object provider)

#### Methods
- public void ApplyToTest(NUnit.Framework.Internal.Test test)
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestMethod> BuildFrom(NUnit.Framework.Interfaces.IMethodInfo method, NUnit.Framework.Internal.Test suite)

### public class NUnit.Framework.Contains

#### Constructors
- public Contains()

#### Methods
- public static NUnit.Framework.Constraints.CollectionContainsConstraint Item(object expected)
- public static NUnit.Framework.Constraints.DictionaryContainsKeyConstraint Key(object expected)
- public static NUnit.Framework.Constraints.SubstringConstraint Substring(string expected)
- public static NUnit.Framework.Constraints.DictionaryContainsValueConstraint Value(object expected)

### public class NUnit.Framework.CultureAttribute
- Base: NUnit.Framework.IncludeExcludeAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Fields
- private NUnit.Framework.Internal.CultureDetector cultureDetector
- private System.Globalization.CultureInfo currentCulture

#### Constructors
- public CultureAttribute()
- public CultureAttribute(string cultures)

#### Methods
- public void ApplyToTest(NUnit.Framework.Internal.Test test)
- private bool IsCultureSupported()
- public bool IsCultureSupported(string culture)
- public bool IsCultureSupported(string[] cultures)

### public class NUnit.Framework.DataAttribute
- Base: NUnit.Framework.NUnitAttribute

#### Constructors
- public DataAttribute()

### public class NUnit.Framework.DatapointAttribute
- Base: NUnit.Framework.NUnitAttribute

#### Constructors
- public DatapointAttribute()

### public class NUnit.Framework.DatapointsAttribute
- Base: NUnit.Framework.DatapointSourceAttribute

#### Constructors
- public DatapointsAttribute()

### public class NUnit.Framework.DatapointSourceAttribute
- Base: NUnit.Framework.NUnitAttribute

#### Constructors
- public DatapointSourceAttribute()

### private class NUnit.Framework.RandomAttribute.DecimalDataSource
- Base: NUnit.Framework.RandomAttribute.RandomDataSource<decimal>
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Constructors
- public RandomAttribute.DecimalDataSource(int count)
- public RandomAttribute.DecimalDataSource(decimal min, decimal max, int count)

#### Methods
- protected override decimal GetNext()
- protected override decimal GetNext(decimal min, decimal max)

### public class NUnit.Framework.DescriptionAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Constructors
- public DescriptionAttribute(string description)

### public static class NUnit.Framework.DirectoryAssert

#### Methods
- public static void AreEqual(System.IO.DirectoryInfo expected, System.IO.DirectoryInfo actual, string message, params object[] args)
- public static void AreEqual(System.IO.DirectoryInfo expected, System.IO.DirectoryInfo actual)
- public static void AreNotEqual(System.IO.DirectoryInfo expected, System.IO.DirectoryInfo actual, string message, params object[] args)
- public static void AreNotEqual(System.IO.DirectoryInfo expected, System.IO.DirectoryInfo actual)
- public static void DoesNotExist(System.IO.DirectoryInfo actual, string message, params object[] args)
- public static void DoesNotExist(System.IO.DirectoryInfo actual)
- public static void DoesNotExist(string actual, string message, params object[] args)
- public static void DoesNotExist(string actual)
- public static bool Equals(object a, object b)
- public static void Exists(System.IO.DirectoryInfo actual, string message, params object[] args)
- public static void Exists(System.IO.DirectoryInfo actual)
- public static void Exists(string actual, string message, params object[] args)
- public static void Exists(string actual)
- public static void ReferenceEquals(object a, object b)

### public static class NUnit.Framework.Does

#### Properties
- public static NUnit.Framework.Constraints.FileOrDirectoryExistsConstraint Exist { get; }
- public static NUnit.Framework.Constraints.ConstraintExpression Not { get; }

#### Methods
- public static NUnit.Framework.Constraints.CollectionContainsConstraint Contain(object expected)
- public static NUnit.Framework.Constraints.ContainsConstraint Contain(string expected)
- public static NUnit.Framework.Constraints.EndsWithConstraint EndWith(string expected)
- public static NUnit.Framework.Constraints.RegexConstraint Match(string pattern)
- public static NUnit.Framework.Constraints.StartsWithConstraint StartWith(string expected)

### private class NUnit.Framework.RandomAttribute.DoubleDataSource
- Base: NUnit.Framework.RandomAttribute.RandomDataSource<double>
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Constructors
- public RandomAttribute.DoubleDataSource(int count)
- public RandomAttribute.DoubleDataSource(double min, double max, int count)

#### Methods
- protected override double GetNext()
- protected override double GetNext(double min, double max)

### private class NUnit.Framework.RandomAttribute.EnumDataSource
- Base: NUnit.Framework.RandomAttribute.RandomDataSource
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Fields
- private int _count

#### Constructors
- public RandomAttribute.EnumDataSource(int count)

#### Methods
- public override System.Collections.IEnumerable GetData(NUnit.Framework.Interfaces.IParameterInfo parameter)

### public class NUnit.Framework.ExplicitAttribute
- Base: NUnit.Framework.NUnitAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Fields
- private string _reason

#### Constructors
- public ExplicitAttribute()
- public ExplicitAttribute(string reason)

#### Methods
- public void ApplyToTest(NUnit.Framework.Internal.Test test)

### public static class NUnit.Framework.FileAssert

#### Methods
- public static void AreEqual(System.IO.Stream expected, System.IO.Stream actual, string message, params object[] args)
- public static void AreEqual(System.IO.Stream expected, System.IO.Stream actual)
- public static void AreEqual(System.IO.FileInfo expected, System.IO.FileInfo actual, string message, params object[] args)
- public static void AreEqual(System.IO.FileInfo expected, System.IO.FileInfo actual)
- public static void AreEqual(string expected, string actual, string message, params object[] args)
- public static void AreEqual(string expected, string actual)
- public static void AreNotEqual(System.IO.Stream expected, System.IO.Stream actual, string message, params object[] args)
- public static void AreNotEqual(System.IO.Stream expected, System.IO.Stream actual)
- public static void AreNotEqual(System.IO.FileInfo expected, System.IO.FileInfo actual, string message, params object[] args)
- public static void AreNotEqual(System.IO.FileInfo expected, System.IO.FileInfo actual)
- public static void AreNotEqual(string expected, string actual, string message, params object[] args)
- public static void AreNotEqual(string expected, string actual)
- public static void DoesNotExist(System.IO.FileInfo actual, string message, params object[] args)
- public static void DoesNotExist(System.IO.FileInfo actual)
- public static void DoesNotExist(string actual, string message, params object[] args)
- public static void DoesNotExist(string actual)
- public static bool Equals(object a, object b)
- public static void Exists(System.IO.FileInfo actual, string message, params object[] args)
- public static void Exists(System.IO.FileInfo actual)
- public static void Exists(string actual, string message, params object[] args)
- public static void Exists(string actual)
- public static void ReferenceEquals(object a, object b)

### private class NUnit.Framework.RandomAttribute.FloatDataSource
- Base: NUnit.Framework.RandomAttribute.RandomDataSource<float>
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Constructors
- public RandomAttribute.FloatDataSource(int count)
- public RandomAttribute.FloatDataSource(float min, float max, int count)

#### Methods
- protected override float GetNext()
- protected override float GetNext(float min, float max)

### public static class NUnit.Framework.GlobalSettings

#### Fields
- public static double DefaultFloatingPointTolerance

### internal static class NUnit.Framework.Guard

#### Methods
- public static void ArgumentInRange(bool condition, string message, string paramName)
- public static void ArgumentNotNull(object value, string name)
- public static void ArgumentNotNullOrEmpty(string value, string name)
- public static void ArgumentValid(bool condition, string message, string paramName)
- public static void OperationValid(bool condition, string message)

### public class NUnit.Framework.Has

#### Properties
- public static NUnit.Framework.Constraints.ConstraintExpression All { get; }
- public static NUnit.Framework.Constraints.ResolvableConstraintExpression Count { get; }
- public static NUnit.Framework.Constraints.ResolvableConstraintExpression InnerException { get; }
- public static NUnit.Framework.Constraints.ResolvableConstraintExpression Length { get; }
- public static NUnit.Framework.Constraints.ResolvableConstraintExpression Message { get; }
- public static NUnit.Framework.Constraints.ConstraintExpression No { get; }
- public static NUnit.Framework.Constraints.ConstraintExpression None { get; }
- public static NUnit.Framework.Constraints.ConstraintExpression Some { get; }

#### Constructors
- public Has()

#### Methods
- public static NUnit.Framework.Constraints.ResolvableConstraintExpression Attribute(System.Type expectedType)
- public static NUnit.Framework.Constraints.ResolvableConstraintExpression Attribute<T>()
- public static NUnit.Framework.Constraints.ConstraintExpression Exactly(int expectedCount)
- public static NUnit.Framework.Constraints.CollectionContainsConstraint Member(object expected)
- public static NUnit.Framework.Constraints.ResolvableConstraintExpression Property(string name)

### public class NUnit.Framework.IgnoreAttribute
- Base: NUnit.Framework.NUnitAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Fields
- private string _reason
- private string _until
- private System.Nullable<System.DateTime> _untilDate

#### Properties
- public string Reason { get; private set; }
- public string Until { get; set; }

#### Constructors
- public IgnoreAttribute(string reason)

#### Methods
- public void ApplyToTest(NUnit.Framework.Internal.Test test)

### public class NUnit.Framework.IgnoreException
- Base: NUnit.Framework.ResultStateException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Properties
- public NUnit.Framework.Interfaces.ResultState ResultState { get; }

#### Constructors
- public IgnoreException(string message)
- public IgnoreException(string message, System.Exception inner)
- protected IgnoreException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### public class NUnit.Framework.IncludeExcludeAttribute
- Base: NUnit.Framework.NUnitAttribute

#### Fields
- private string exclude
- private string include
- private string reason

#### Properties
- public string Exclude { get; set; }
- public string Include { get; set; }
- public string Reason { get; set; }

#### Constructors
- public IncludeExcludeAttribute()
- public IncludeExcludeAttribute(string include)

### public class NUnit.Framework.InconclusiveException
- Base: NUnit.Framework.ResultStateException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Properties
- public NUnit.Framework.Interfaces.ResultState ResultState { get; }

#### Constructors
- public InconclusiveException(string message)
- public InconclusiveException(string message, System.Exception inner)
- protected InconclusiveException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### private class NUnit.Framework.RandomAttribute.IntDataSource
- Base: NUnit.Framework.RandomAttribute.RandomDataSource<int>
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Constructors
- public RandomAttribute.IntDataSource(int count)
- public RandomAttribute.IntDataSource(int min, int max, int count)

#### Methods
- protected override int GetNext()
- protected override int GetNext(int min, int max)

### public class NUnit.Framework.Is

#### Properties
- public static NUnit.Framework.Constraints.ConstraintExpression All { get; }
- public static NUnit.Framework.Constraints.BinarySerializableConstraint BinarySerializable { get; }
- public static NUnit.Framework.Constraints.EmptyConstraint Empty { get; }
- public static NUnit.Framework.Constraints.FalseConstraint False { get; }
- public static NUnit.Framework.Constraints.NaNConstraint NaN { get; }
- public static NUnit.Framework.Constraints.LessThanConstraint Negative { get; }
- public static NUnit.Framework.Constraints.ConstraintExpression Not { get; }
- public static NUnit.Framework.Constraints.NullConstraint Null { get; }
- public static NUnit.Framework.Constraints.CollectionOrderedConstraint Ordered { get; }
- public static NUnit.Framework.Constraints.GreaterThanConstraint Positive { get; }
- public static NUnit.Framework.Constraints.TrueConstraint True { get; }
- public static NUnit.Framework.Constraints.UniqueItemsConstraint Unique { get; }
- public static NUnit.Framework.Constraints.XmlSerializableConstraint XmlSerializable { get; }
- public static NUnit.Framework.Constraints.EqualConstraint Zero { get; }

#### Constructors
- public Is()

#### Methods
- public static NUnit.Framework.Constraints.AssignableFromConstraint AssignableFrom(System.Type expectedType)
- public static NUnit.Framework.Constraints.AssignableFromConstraint AssignableFrom<TExpected>()
- public static NUnit.Framework.Constraints.AssignableToConstraint AssignableTo(System.Type expectedType)
- public static NUnit.Framework.Constraints.AssignableToConstraint AssignableTo<TExpected>()
- public static NUnit.Framework.Constraints.GreaterThanOrEqualConstraint AtLeast(object expected)
- public static NUnit.Framework.Constraints.LessThanOrEqualConstraint AtMost(object expected)
- public static NUnit.Framework.Constraints.EqualConstraint EqualTo(object expected)
- public static NUnit.Framework.Constraints.CollectionEquivalentConstraint EquivalentTo(System.Collections.IEnumerable expected)
- public static NUnit.Framework.Constraints.GreaterThanConstraint GreaterThan(object expected)
- public static NUnit.Framework.Constraints.GreaterThanOrEqualConstraint GreaterThanOrEqualTo(object expected)
- public static NUnit.Framework.Constraints.RangeConstraint InRange(System.IComparable from, System.IComparable to)
- public static NUnit.Framework.Constraints.InstanceOfTypeConstraint InstanceOf(System.Type expectedType)
- public static NUnit.Framework.Constraints.InstanceOfTypeConstraint InstanceOf<TExpected>()
- public static NUnit.Framework.Constraints.LessThanConstraint LessThan(object expected)
- public static NUnit.Framework.Constraints.LessThanOrEqualConstraint LessThanOrEqualTo(object expected)
- public static NUnit.Framework.Constraints.SameAsConstraint SameAs(object expected)
- public static NUnit.Framework.Constraints.SamePathConstraint SamePath(string expected)
- public static NUnit.Framework.Constraints.SamePathOrUnderConstraint SamePathOrUnder(string expected)
- public static NUnit.Framework.Constraints.SubstringConstraint StringContaining(string expected)
- public static NUnit.Framework.Constraints.EndsWithConstraint StringEnding(string expected)
- public static NUnit.Framework.Constraints.RegexConstraint StringMatching(string pattern)
- public static NUnit.Framework.Constraints.StartsWithConstraint StringStarting(string expected)
- public static NUnit.Framework.Constraints.SubPathConstraint SubPathOf(string expected)
- public static NUnit.Framework.Constraints.CollectionSubsetConstraint SubsetOf(System.Collections.IEnumerable expected)
- public static NUnit.Framework.Constraints.CollectionSupersetConstraint SupersetOf(System.Collections.IEnumerable expected)
- public static NUnit.Framework.Constraints.ExactTypeConstraint TypeOf(System.Type expectedType)
- public static NUnit.Framework.Constraints.ExactTypeConstraint TypeOf<TExpected>()

### public interface NUnit.Framework.ITestAction

#### Properties
- public NUnit.Framework.ActionTargets Targets { get; }

#### Methods
- public void AfterTest(NUnit.Framework.Interfaces.ITest test)
- public void BeforeTest(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Iz
- Base: NUnit.Framework.Is

#### Constructors
- public Iz()

### public class NUnit.Framework.LevelOfParallelismAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Constructors
- public LevelOfParallelismAttribute(int level)

### public class NUnit.Framework.List

#### Constructors
- public List()

#### Methods
- public static NUnit.Framework.ListMapper Map(System.Collections.ICollection actual)

### public class NUnit.Framework.ListMapper

#### Fields
- private System.Collections.ICollection original

#### Constructors
- public ListMapper(System.Collections.ICollection original)

#### Methods
- public System.Collections.ICollection Property(string name)

### private class NUnit.Framework.RandomAttribute.LongDataSource
- Base: NUnit.Framework.RandomAttribute.RandomDataSource<long>
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Constructors
- public RandomAttribute.LongDataSource(int count)
- public RandomAttribute.LongDataSource(long min, long max, int count)

#### Methods
- protected override long GetNext()
- protected override long GetNext(long min, long max)

### public class NUnit.Framework.MaxTimeAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest, NUnit.Framework.Interfaces.IWrapSetUpTearDown, NUnit.Framework.Interfaces.ICommandWrapper

#### Fields
- private int _milliseconds

#### Constructors
- public MaxTimeAttribute(int milliseconds)

#### Methods
- private NUnit.Framework.Internal.Commands.TestCommand NUnit.Framework.Interfaces.ICommandWrapper.Wrap(NUnit.Framework.Internal.Commands.TestCommand command)

### public class NUnit.Framework.NUnitAttribute
- Base: System.Attribute

#### Constructors
- public NUnitAttribute()

### public class NUnit.Framework.OneTimeSetUpAttribute
- Base: NUnit.Framework.NUnitAttribute

#### Constructors
- public OneTimeSetUpAttribute()

### public class NUnit.Framework.OneTimeTearDownAttribute
- Base: NUnit.Framework.NUnitAttribute

#### Constructors
- public OneTimeTearDownAttribute()

### public class NUnit.Framework.OrderAttribute
- Base: NUnit.Framework.NUnitAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Fields
- public readonly int Order

#### Constructors
- public OrderAttribute(int order)

#### Methods
- public void ApplyToTest(NUnit.Framework.Internal.Test test)

### public class NUnit.Framework.PairwiseAttribute
- Base: NUnit.Framework.CombiningStrategyAttribute
- Interfaces: NUnit.Framework.Interfaces.ITestBuilder, NUnit.Framework.Interfaces.IApplyToTest

#### Constructors
- public PairwiseAttribute()

### public class NUnit.Framework.ParallelizableAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest, NUnit.Framework.Interfaces.IApplyToContext

#### Fields
- private NUnit.Framework.ParallelScope _scope

#### Constructors
- public ParallelizableAttribute()
- public ParallelizableAttribute(NUnit.Framework.ParallelScope scope)

#### Methods
- public void ApplyToContext(NUnit.Framework.Internal.ITestExecutionContext context)

### public enum NUnit.Framework.ParallelScope
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Children = 2
- Fixtures = 4
- None = 0
- Self = 1

### public class NUnit.Framework.PlatformAttribute
- Base: NUnit.Framework.IncludeExcludeAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Fields
- private NUnit.Framework.Internal.PlatformHelper platformHelper

#### Constructors
- public PlatformAttribute()
- public PlatformAttribute(string platforms)

#### Methods
- public void ApplyToTest(NUnit.Framework.Internal.Test test)

### public class NUnit.Framework.PostTestAttribute
- Base: NUnit.Framework.NUnitAttribute

#### Constructors
- public PostTestAttribute()

### public class NUnit.Framework.PreTestAttribute
- Base: NUnit.Framework.NUnitAttribute

#### Constructors
- public PreTestAttribute()

### public class NUnit.Framework.PropertyAttribute
- Base: NUnit.Framework.NUnitAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Fields
- private NUnit.Framework.Internal.PropertyBag properties

#### Properties
- public NUnit.Framework.Interfaces.IPropertyBag Properties { get; }

#### Constructors
- protected PropertyAttribute()
- protected PropertyAttribute(object propertyValue)
- public PropertyAttribute(string propertyName, string propertyValue)
- public PropertyAttribute(string propertyName, int propertyValue)
- public PropertyAttribute(string propertyName, double propertyValue)

#### Methods
- public virtual void ApplyToTest(NUnit.Framework.Internal.Test test)

### public class NUnit.Framework.RandomAttribute
- Base: NUnit.Framework.DataAttribute
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Fields
- private int _count
- private NUnit.Framework.RandomAttribute.RandomDataSource _source

#### Constructors
- public RandomAttribute(int count)
- public RandomAttribute(int min, int max, int count)
- public RandomAttribute(uint min, uint max, int count)
- public RandomAttribute(long min, long max, int count)
- public RandomAttribute(ulong min, ulong max, int count)
- public RandomAttribute(short min, short max, int count)
- public RandomAttribute(ushort min, ushort max, int count)
- public RandomAttribute(double min, double max, int count)
- public RandomAttribute(float min, float max, int count)
- public RandomAttribute(byte min, byte max, int count)
- public RandomAttribute(sbyte min, sbyte max, int count)

#### Methods
- public System.Collections.IEnumerable GetData(NUnit.Framework.Interfaces.IParameterInfo parameter)
- private bool WeConvert(System.Type sourceType, System.Type targetType)

### private class NUnit.Framework.RandomAttribute.RandomDataConverter
- Base: NUnit.Framework.RandomAttribute.RandomDataSource
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Fields
- private NUnit.Framework.Interfaces.IParameterDataSource _source

#### Constructors
- public RandomAttribute.RandomDataConverter(NUnit.Framework.Interfaces.IParameterDataSource source)

#### Methods
- public override System.Collections.IEnumerable GetData(NUnit.Framework.Interfaces.IParameterInfo parameter)

### private class NUnit.Framework.RandomAttribute.RandomDataSource
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Fields
- private System.Type <DataType>k__BackingField

#### Properties
- public System.Type DataType { get; protected set; }

#### Constructors
- protected RandomAttribute.RandomDataSource()

#### Methods
- public abstract System.Collections.IEnumerable GetData(NUnit.Framework.Interfaces.IParameterInfo parameter)

### private class NUnit.Framework.RandomAttribute.RandomDataSource<T>
- Base: NUnit.Framework.RandomAttribute.RandomDataSource
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Fields
- private int _count
- private bool _inRange
- private T _max
- private T _min
- protected NUnit.Framework.Internal.Randomizer _randomizer

#### Constructors
- protected RandomAttribute.RandomDataSource<T>(int count)
- protected RandomAttribute.RandomDataSource<T>(T min, T max, int count)

#### Methods
- public override System.Collections.IEnumerable GetData(NUnit.Framework.Interfaces.IParameterInfo parameter)
- protected abstract T GetNext()
- protected abstract T GetNext(T min, T max)

### public class NUnit.Framework.RangeAttribute
- Base: NUnit.Framework.ValuesAttribute
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Constructors
- public RangeAttribute(int from, int to)
- public RangeAttribute(uint from, uint to)
- public RangeAttribute(long from, long to)
- public RangeAttribute(ulong from, ulong to)
- public RangeAttribute(int from, int to, int step)
- public RangeAttribute(uint from, uint to, uint step)
- public RangeAttribute(long from, long to, long step)
- public RangeAttribute(ulong from, ulong to, ulong step)
- public RangeAttribute(double from, double to, double step)
- public RangeAttribute(float from, float to, float step)

### public class NUnit.Framework.RepeatAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest, NUnit.Framework.Interfaces.IWrapSetUpTearDown, NUnit.Framework.Interfaces.ICommandWrapper

#### Fields
- private int _count

#### Constructors
- public RepeatAttribute(int count)

#### Methods
- public NUnit.Framework.Internal.Commands.TestCommand Wrap(NUnit.Framework.Internal.Commands.TestCommand command)

### public class NUnit.Framework.RepeatAttribute.RepeatedTestCommand
- Base: NUnit.Framework.Internal.Commands.DelegatingTestCommand

#### Fields
- private int repeatCount

#### Constructors
- public RepeatAttribute.RepeatedTestCommand(NUnit.Framework.Internal.Commands.TestCommand innerCommand, int repeatCount)

#### Methods
- public override NUnit.Framework.Internal.TestResult Execute(NUnit.Framework.Internal.ITestExecutionContext context)

### public class NUnit.Framework.RequiresMTAAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Constructors
- public RequiresMTAAttribute()

### public class NUnit.Framework.RequiresSTAAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Constructors
- public RequiresSTAAttribute()

### public class NUnit.Framework.RequiresThreadAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Constructors
- public RequiresThreadAttribute()
- public RequiresThreadAttribute(System.Threading.ApartmentState apartment)

#### Methods
- private void NUnit.Framework.Interfaces.IApplyToTest.ApplyToTest(NUnit.Framework.Internal.Test test)

### public class NUnit.Framework.TestContext.ResultAdapter

#### Fields
- private readonly NUnit.Framework.Internal.TestResult _result

#### Properties
- public int FailCount { get; }
- public int InconclusiveCount { get; }
- public string Message { get; }
- public NUnit.Framework.Interfaces.ResultState Outcome { get; }
- public int PassCount { get; }
- public int SkipCount { get; }
- public string StackTrace { get; }

#### Constructors
- public TestContext.ResultAdapter(NUnit.Framework.Internal.TestResult result)

### public class NUnit.Framework.ResultStateException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Properties
- public NUnit.Framework.Interfaces.ResultState ResultState { get; }

#### Constructors
- public ResultStateException(string message)
- public ResultStateException(string message, System.Exception inner)
- protected ResultStateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### public class NUnit.Framework.RetryAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest, NUnit.Framework.Interfaces.IWrapSetUpTearDown, NUnit.Framework.Interfaces.ICommandWrapper

#### Fields
- private int _count

#### Constructors
- public RetryAttribute(int count)

#### Methods
- public NUnit.Framework.Internal.Commands.TestCommand Wrap(NUnit.Framework.Internal.Commands.TestCommand command)

### public class NUnit.Framework.RetryAttribute.RetryCommand
- Base: NUnit.Framework.Internal.Commands.DelegatingTestCommand

#### Fields
- private int _retryCount

#### Constructors
- public RetryAttribute.RetryCommand(NUnit.Framework.Internal.Commands.TestCommand innerCommand, int retryCount)

#### Methods
- public override NUnit.Framework.Internal.TestResult Execute(NUnit.Framework.Internal.ITestExecutionContext context)

### private class NUnit.Framework.RandomAttribute.SByteDataSource
- Base: NUnit.Framework.RandomAttribute.RandomDataSource<sbyte>
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Constructors
- public RandomAttribute.SByteDataSource(int count)
- public RandomAttribute.SByteDataSource(sbyte min, sbyte max, int count)

#### Methods
- protected override sbyte GetNext()
- protected override sbyte GetNext(sbyte min, sbyte max)

### public class NUnit.Framework.SequentialAttribute
- Base: NUnit.Framework.CombiningStrategyAttribute
- Interfaces: NUnit.Framework.Interfaces.ITestBuilder, NUnit.Framework.Interfaces.IApplyToTest

#### Constructors
- public SequentialAttribute()

### public class NUnit.Framework.SetCultureAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest, NUnit.Framework.Interfaces.IApplyToContext

#### Fields
- private string _culture

#### Constructors
- public SetCultureAttribute(string culture)

#### Methods
- private void NUnit.Framework.Interfaces.IApplyToContext.ApplyToContext(NUnit.Framework.Internal.ITestExecutionContext context)

### public class NUnit.Framework.SetUICultureAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest, NUnit.Framework.Interfaces.IApplyToContext

#### Fields
- private string _culture

#### Constructors
- public SetUICultureAttribute(string culture)

#### Methods
- private void NUnit.Framework.Interfaces.IApplyToContext.ApplyToContext(NUnit.Framework.Internal.ITestExecutionContext context)

### public class NUnit.Framework.SetUpAttribute
- Base: NUnit.Framework.NUnitAttribute

#### Constructors
- public SetUpAttribute()

### public class NUnit.Framework.SetUpFixtureAttribute
- Base: NUnit.Framework.NUnitAttribute
- Interfaces: NUnit.Framework.Interfaces.IFixtureBuilder

#### Constructors
- public SetUpFixtureAttribute()

#### Methods
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestSuite> BuildFrom(NUnit.Framework.Interfaces.ITypeInfo typeInfo)
- private bool IsValidFixtureType(NUnit.Framework.Interfaces.ITypeInfo typeInfo, ref string reason)

### private class NUnit.Framework.RandomAttribute.ShortDataSource
- Base: NUnit.Framework.RandomAttribute.RandomDataSource<short>
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Constructors
- public RandomAttribute.ShortDataSource(int count)
- public RandomAttribute.ShortDataSource(short min, short max, int count)

#### Methods
- protected override short GetNext()
- protected override short GetNext(short min, short max)

### public class NUnit.Framework.SingleThreadedAttribute
- Base: NUnit.Framework.NUnitAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToContext

#### Constructors
- public SingleThreadedAttribute()

#### Methods
- public void ApplyToContext(NUnit.Framework.Internal.ITestExecutionContext context)

### public enum NUnit.Framework.SpecialValue
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Null = 0

### public class NUnit.Framework.StringAssert

#### Constructors
- public StringAssert()

#### Methods
- public static void AreEqualIgnoringCase(string expected, string actual, string message, params object[] args)
- public static void AreEqualIgnoringCase(string expected, string actual)
- public static void AreNotEqualIgnoringCase(string expected, string actual, string message, params object[] args)
- public static void AreNotEqualIgnoringCase(string expected, string actual)
- public static void Contains(string expected, string actual, string message, params object[] args)
- public static void Contains(string expected, string actual)
- public static void DoesNotContain(string expected, string actual, string message, params object[] args)
- public static void DoesNotContain(string expected, string actual)
- public static void DoesNotEndWith(string expected, string actual, string message, params object[] args)
- public static void DoesNotEndWith(string expected, string actual)
- public static void DoesNotMatch(string pattern, string actual, string message, params object[] args)
- public static void DoesNotMatch(string pattern, string actual)
- public static void DoesNotStartWith(string expected, string actual, string message, params object[] args)
- public static void DoesNotStartWith(string expected, string actual)
- public static void EndsWith(string expected, string actual, string message, params object[] args)
- public static void EndsWith(string expected, string actual)
- public static bool Equals(object a, object b)
- public static void IsMatch(string pattern, string actual, string message, params object[] args)
- public static void IsMatch(string pattern, string actual)
- public static void ReferenceEquals(object a, object b)
- public static void StartsWith(string expected, string actual, string message, params object[] args)
- public static void StartsWith(string expected, string actual)

### public class NUnit.Framework.SuccessException
- Base: NUnit.Framework.ResultStateException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Properties
- public NUnit.Framework.Interfaces.ResultState ResultState { get; }

#### Constructors
- public SuccessException(string message)
- public SuccessException(string message, System.Exception inner)
- protected SuccessException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### public class NUnit.Framework.TearDownAttribute
- Base: NUnit.Framework.NUnitAttribute

#### Constructors
- public TearDownAttribute()

### public class NUnit.Framework.TestActionAttribute
- Base: System.Attribute
- Interfaces: NUnit.Framework.ITestAction

#### Properties
- public NUnit.Framework.ActionTargets Targets { get; }

#### Constructors
- protected TestActionAttribute()

#### Methods
- public virtual void AfterTest(NUnit.Framework.Interfaces.ITest test)
- public virtual void BeforeTest(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.TestContext.TestAdapter

#### Fields
- private readonly NUnit.Framework.Internal.Test _test

#### Properties
- public string ClassName { get; }
- public string FullName { get; }
- public string ID { get; }
- public string MethodName { get; }
- public string Name { get; }
- public NUnit.Framework.Interfaces.IPropertyBag Properties { get; }

#### Constructors
- public TestContext.TestAdapter(NUnit.Framework.Internal.Test test)

### public class NUnit.Framework.TestAssemblyDirectoryResolveAttribute
- Base: NUnit.Framework.NUnitAttribute

#### Constructors
- public TestAssemblyDirectoryResolveAttribute()

### public class NUnit.Framework.TestAttribute
- Base: NUnit.Framework.NUnitAttribute
- Interfaces: NUnit.Framework.Interfaces.ISimpleTestBuilder, NUnit.Framework.Interfaces.IApplyToTest, NUnit.Framework.Interfaces.IImplyFixture

#### Fields
- private string <Author>k__BackingField
- private string <Description>k__BackingField
- private bool <HasExpectedResult>k__BackingField
- private System.Type <TestOf>k__BackingField
- private readonly NUnit.Framework.Internal.Builders.NUnitTestCaseBuilder _builder
- private object _expectedResult

#### Properties
- public string Author { get; set; }
- public string Description { get; set; }
- public object ExpectedResult { get; set; }
- public bool HasExpectedResult { get; private set; }
- public System.Type TestOf { get; set; }

#### Constructors
- public TestAttribute()

#### Methods
- public void ApplyToTest(NUnit.Framework.Internal.Test test)
- public NUnit.Framework.Internal.TestMethod BuildFrom(NUnit.Framework.Interfaces.IMethodInfo method, NUnit.Framework.Internal.Test suite)

### public class NUnit.Framework.TestCaseAttribute
- Base: NUnit.Framework.NUnitAttribute
- Interfaces: NUnit.Framework.Interfaces.ITestBuilder, NUnit.Framework.Interfaces.ITestCaseData, NUnit.Framework.Interfaces.ITestData, NUnit.Framework.Interfaces.IImplyFixture

#### Fields
- private object[] <Arguments>k__BackingField
- private string <ExcludePlatform>k__BackingField
- private bool <HasExpectedResult>k__BackingField
- private string <IncludePlatform>k__BackingField
- private NUnit.Framework.Interfaces.IPropertyBag <Properties>k__BackingField
- private NUnit.Framework.Interfaces.RunState <RunState>k__BackingField
- private string <TestName>k__BackingField
- private object _expectedResult
- private System.Type _testOf

#### Properties
- public object[] Arguments { get; private set; }
- public string Author { get; set; }
- public string Category { get; set; }
- public string Description { get; set; }
- public string ExcludePlatform { get; set; }
- public object ExpectedResult { get; set; }
- public bool Explicit { get; set; }
- public bool HasExpectedResult { get; private set; }
- public string Ignore { get; set; }
- public string IgnoreReason { get; set; }
- public string IncludePlatform { get; set; }
- public NUnit.Framework.Interfaces.IPropertyBag Properties { get; private set; }
- public string Reason { get; set; }
- public NUnit.Framework.Interfaces.RunState RunState { get; private set; }
- public string TestName { get; set; }
- public System.Type TestOf { get; set; }

#### Constructors
- public TestCaseAttribute(params object[] arguments)
- public TestCaseAttribute(object arg)
- public TestCaseAttribute(object arg1, object arg2)
- public TestCaseAttribute(object arg1, object arg2, object arg3)

#### Methods
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestMethod> BuildFrom(NUnit.Framework.Interfaces.IMethodInfo method, NUnit.Framework.Internal.Test suite)
- private NUnit.Framework.Internal.TestCaseParameters GetParametersForTestCase(NUnit.Framework.Interfaces.IMethodInfo method)
- private static void PerformSpecialConversions(object[] arglist, NUnit.Framework.Interfaces.IParameterInfo[] parameters)

### public class NUnit.Framework.TestCaseData
- Base: NUnit.Framework.Internal.TestCaseParameters
- Interfaces: NUnit.Framework.Interfaces.ITestData, NUnit.Framework.Interfaces.IApplyToTest, NUnit.Framework.Interfaces.ITestCaseData

#### Constructors
- public TestCaseData(params object[] args)
- public TestCaseData(object arg)
- public TestCaseData(object arg1, object arg2)
- public TestCaseData(object arg1, object arg2, object arg3)

#### Methods
- public NUnit.Framework.TestCaseData Explicit()
- public NUnit.Framework.TestCaseData Explicit(string reason)
- public NUnit.Framework.TestCaseData Ignore(string reason)
- public NUnit.Framework.TestCaseData Returns(object result)
- public NUnit.Framework.TestCaseData SetCategory(string category)
- public NUnit.Framework.TestCaseData SetDescription(string description)
- public NUnit.Framework.TestCaseData SetName(string name)
- public NUnit.Framework.TestCaseData SetProperty(string propName, string propValue)
- public NUnit.Framework.TestCaseData SetProperty(string propName, int propValue)
- public NUnit.Framework.TestCaseData SetProperty(string propName, double propValue)

### public class NUnit.Framework.TestCaseSourceAttribute
- Base: NUnit.Framework.NUnitAttribute
- Interfaces: NUnit.Framework.Interfaces.ITestBuilder, NUnit.Framework.Interfaces.IImplyFixture

#### Fields
- private string <Category>k__BackingField
- private object[] <MethodParams>k__BackingField
- private string <SourceName>k__BackingField
- private System.Type <SourceType>k__BackingField
- private static const string NumberOfArgsDoesNotMatch
- private static const string ParamGivenToField
- private static const string ParamGivenToProperty
- private static const string SourceMustBeStatic
- private NUnit.Framework.Internal.Builders.NUnitTestCaseBuilder _builder

#### Properties
- public string Category { get; set; }
- public object[] MethodParams { get; private set; }
- public string SourceName { get; private set; }
- public System.Type SourceType { get; private set; }

#### Constructors
- public TestCaseSourceAttribute(string sourceName)
- public TestCaseSourceAttribute(System.Type sourceType)
- public TestCaseSourceAttribute(System.Type sourceType, string sourceName)
- public TestCaseSourceAttribute(System.Type sourceType, string sourceName, object[] methodParams)

#### Methods
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestMethod> BuildFrom(NUnit.Framework.Interfaces.IMethodInfo method, NUnit.Framework.Internal.Test suite)
- private System.Collections.Generic.IEnumerable<NUnit.Framework.Interfaces.ITestCaseData> GetTestCasesFor(NUnit.Framework.Interfaces.IMethodInfo method)
- private System.Collections.IEnumerable GetTestCaseSource(NUnit.Framework.Interfaces.IMethodInfo method)
- private static System.Collections.IEnumerable ReturnErrorAsParameter(string errorMessage)

### public class NUnit.Framework.TestContext

#### Fields
- public static NUnit.Framework.Internal.ITestExecutionContext CurrentTestExecutionContext
- public static System.IO.TextWriter Error
- public static readonly NUnit.Framework.TestParameters Parameters
- public static readonly System.IO.TextWriter Progress
- private NUnit.Framework.TestContext.ResultAdapter _result
- private NUnit.Framework.TestContext.TestAdapter _test
- private NUnit.Framework.Internal.ITestExecutionContext _testExecutionContext

#### Properties
- public static NUnit.Framework.TestContext CurrentContext { get; }
- public static System.IO.TextWriter Out { get; }
- public NUnit.Framework.Internal.Randomizer Random { get; }
- public NUnit.Framework.TestContext.ResultAdapter Result { get; }
- public NUnit.Framework.TestContext.TestAdapter Test { get; }
- public string TestDirectory { get; }
- public string WorkDirectory { get; }
- public string WorkerId { get; }

#### Constructors
- private static TestContext()
- public TestContext(NUnit.Framework.Internal.ITestExecutionContext testExecutionContext)

#### Methods
- public static void AddFormatter(NUnit.Framework.Constraints.ValueFormatterFactory formatterFactory)
- public static void AddFormatter<TSUPPORTED>(NUnit.Framework.Constraints.ValueFormatter formatter)
- public static void Write(bool value)
- public static void Write(char value)
- public static void Write(char[] value)
- public static void Write(double value)
- public static void Write(int value)
- public static void Write(long value)
- public static void Write(decimal value)
- public static void Write(object value)
- public static void Write(float value)
- public static void Write(string value)
- public static void Write(uint value)
- public static void Write(ulong value)
- public static void Write(string format, object arg1)
- public static void Write(string format, object arg1, object arg2)
- public static void Write(string format, object arg1, object arg2, object arg3)
- public static void Write(string format, params object[] args)
- public static void WriteLine()
- public static void WriteLine(bool value)
- public static void WriteLine(char value)
- public static void WriteLine(char[] value)
- public static void WriteLine(double value)
- public static void WriteLine(int value)
- public static void WriteLine(long value)
- public static void WriteLine(decimal value)
- public static void WriteLine(object value)
- public static void WriteLine(float value)
- public static void WriteLine(string value)
- public static void WriteLine(uint value)
- public static void WriteLine(ulong value)
- public static void WriteLine(string format, object arg1)
- public static void WriteLine(string format, object arg1, object arg2)
- public static void WriteLine(string format, object arg1, object arg2, object arg3)
- public static void WriteLine(string format, params object[] args)

### public delegate NUnit.Framework.TestDelegate
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public TestDelegate(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

### public class NUnit.Framework.TestFixtureAttribute
- Base: NUnit.Framework.NUnitAttribute
- Interfaces: NUnit.Framework.Interfaces.IFixtureBuilder, NUnit.Framework.Interfaces.ITestFixtureData, NUnit.Framework.Interfaces.ITestData

#### Fields
- private object[] <Arguments>k__BackingField
- private NUnit.Framework.Interfaces.IPropertyBag <Properties>k__BackingField
- private NUnit.Framework.Interfaces.RunState <RunState>k__BackingField
- private string <TestName>k__BackingField
- private System.Type[] <TypeArgs>k__BackingField
- private readonly NUnit.Framework.Internal.Builders.NUnitTestFixtureBuilder _builder
- private System.Type _testOf

#### Properties
- public object[] Arguments { get; private set; }
- public string Author { get; set; }
- public string Category { get; set; }
- public string Description { get; set; }
- public bool Explicit { get; set; }
- public string Ignore { get; set; }
- public string IgnoreReason { get; set; }
- public NUnit.Framework.Interfaces.IPropertyBag Properties { get; private set; }
- public string Reason { get; set; }
- public NUnit.Framework.Interfaces.RunState RunState { get; private set; }
- public string TestName { get; set; }
- public System.Type TestOf { get; set; }
- public System.Type[] TypeArgs { get; set; }

#### Constructors
- public TestFixtureAttribute()
- public TestFixtureAttribute(params object[] arguments)

#### Methods
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestSuite> BuildFrom(NUnit.Framework.Interfaces.ITypeInfo typeInfo)

### public class NUnit.Framework.TestFixtureData
- Base: NUnit.Framework.Internal.TestFixtureParameters
- Interfaces: NUnit.Framework.Interfaces.ITestData, NUnit.Framework.Interfaces.IApplyToTest, NUnit.Framework.Interfaces.ITestFixtureData

#### Constructors
- public TestFixtureData(params object[] args)
- public TestFixtureData(object arg)
- public TestFixtureData(object arg1, object arg2)
- public TestFixtureData(object arg1, object arg2, object arg3)

#### Methods
- public NUnit.Framework.TestFixtureData Explicit()
- public NUnit.Framework.TestFixtureData Explicit(string reason)
- public NUnit.Framework.TestFixtureData Ignore(string reason)

### public class NUnit.Framework.TestFixtureSetUpAttribute
- Base: NUnit.Framework.OneTimeSetUpAttribute

#### Constructors
- public TestFixtureSetUpAttribute()

### public class NUnit.Framework.TestFixtureSourceAttribute
- Base: NUnit.Framework.NUnitAttribute
- Interfaces: NUnit.Framework.Interfaces.IFixtureBuilder

#### Fields
- private string <Category>k__BackingField
- private string <SourceName>k__BackingField
- private System.Type <SourceType>k__BackingField
- public static const string MUST_BE_STATIC
- private readonly NUnit.Framework.Internal.Builders.NUnitTestFixtureBuilder _builder

#### Properties
- public string Category { get; set; }
- public string SourceName { get; private set; }
- public System.Type SourceType { get; private set; }

#### Constructors
- public TestFixtureSourceAttribute(string sourceName)
- public TestFixtureSourceAttribute(System.Type sourceType)
- public TestFixtureSourceAttribute(System.Type sourceType, string sourceName)

#### Methods
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestSuite> BuildFrom(NUnit.Framework.Interfaces.ITypeInfo typeInfo)
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Interfaces.ITestFixtureData> GetParametersFor(System.Type sourceType)
- private System.Collections.IEnumerable GetTestFixtureSource(System.Type sourceType)
- private static System.Collections.IEnumerable SourceMustBeStaticError()

### public class NUnit.Framework.TestFixtureTearDownAttribute
- Base: NUnit.Framework.OneTimeTearDownAttribute

#### Constructors
- public TestFixtureTearDownAttribute()

### public class NUnit.Framework.TestOfAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest

#### Constructors
- public TestOfAttribute(System.Type type)
- public TestOfAttribute(string typeName)

### public class NUnit.Framework.TestParameters

#### Fields
- private static readonly System.IFormatProvider MODIFIED_INVARIANT_CULTURE
- private readonly System.Collections.Generic.Dictionary<string, string> _parameters

#### Properties
- public int Count { get; }
- public string Item { get; }
- public System.Collections.Generic.ICollection<string> Names { get; }

#### Constructors
- public TestParameters()
- private static TestParameters()

#### Methods
- internal void Add(string name, string value)
- private static System.IFormatProvider CreateModifiedInvariantCulture()
- public bool Exists(string name)
- public string Get(string name)
- public string Get(string name, string defaultValue)
- public T Get<T>(string name, T defaultValue)

### public class NUnit.Framework.TheoryAttribute
- Base: NUnit.Framework.CombiningStrategyAttribute
- Interfaces: NUnit.Framework.Interfaces.ITestBuilder, NUnit.Framework.Interfaces.IApplyToTest, NUnit.Framework.Interfaces.IImplyFixture

#### Constructors
- public TheoryAttribute()

### public class NUnit.Framework.Throws

#### Properties
- public static NUnit.Framework.Constraints.ExactTypeConstraint ArgumentException { get; }
- public static NUnit.Framework.Constraints.ExactTypeConstraint ArgumentNullException { get; }
- public static NUnit.Framework.Constraints.ResolvableConstraintExpression Exception { get; }
- public static NUnit.Framework.Constraints.ResolvableConstraintExpression InnerException { get; }
- public static NUnit.Framework.Constraints.ExactTypeConstraint InvalidOperationException { get; }
- public static NUnit.Framework.Constraints.ThrowsNothingConstraint Nothing { get; }
- public static NUnit.Framework.Constraints.ExactTypeConstraint TargetInvocationException { get; }

#### Constructors
- public Throws()

#### Methods
- public static NUnit.Framework.Constraints.InstanceOfTypeConstraint InstanceOf(System.Type expectedType)
- public static NUnit.Framework.Constraints.InstanceOfTypeConstraint InstanceOf<TExpected>()
- public static NUnit.Framework.Constraints.ExactTypeConstraint TypeOf(System.Type expectedType)
- public static NUnit.Framework.Constraints.ExactTypeConstraint TypeOf<TExpected>()

### public class NUnit.Framework.TimeoutAttribute
- Base: NUnit.Framework.PropertyAttribute
- Interfaces: NUnit.Framework.Interfaces.IApplyToTest, NUnit.Framework.Interfaces.IApplyToContext

#### Fields
- private int _timeout

#### Constructors
- public TimeoutAttribute(int timeout)

#### Methods
- private void NUnit.Framework.Interfaces.IApplyToContext.ApplyToContext(NUnit.Framework.Internal.ITestExecutionContext context)

### private class NUnit.Framework.RandomAttribute.UIntDataSource
- Base: NUnit.Framework.RandomAttribute.RandomDataSource<uint>
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Constructors
- public RandomAttribute.UIntDataSource(int count)
- public RandomAttribute.UIntDataSource(uint min, uint max, int count)

#### Methods
- protected override uint GetNext()
- protected override uint GetNext(uint min, uint max)

### private class NUnit.Framework.RandomAttribute.ULongDataSource
- Base: NUnit.Framework.RandomAttribute.RandomDataSource<ulong>
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Constructors
- public RandomAttribute.ULongDataSource(int count)
- public RandomAttribute.ULongDataSource(ulong min, ulong max, int count)

#### Methods
- protected override ulong GetNext()
- protected override ulong GetNext(ulong min, ulong max)

### private class NUnit.Framework.RandomAttribute.UShortDataSource
- Base: NUnit.Framework.RandomAttribute.RandomDataSource<ushort>
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Constructors
- public RandomAttribute.UShortDataSource(int count)
- public RandomAttribute.UShortDataSource(ushort min, ushort max, int count)

#### Methods
- protected override ushort GetNext()
- protected override ushort GetNext(ushort min, ushort max)

### public class NUnit.Framework.ValuesAttribute
- Base: NUnit.Framework.DataAttribute
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Fields
- protected object[] data

#### Constructors
- public ValuesAttribute()
- public ValuesAttribute(object arg1)
- public ValuesAttribute(params object[] args)
- public ValuesAttribute(object arg1, object arg2)
- public ValuesAttribute(object arg1, object arg2, object arg3)

#### Methods
- public System.Collections.IEnumerable GetData(NUnit.Framework.Interfaces.IParameterInfo parameter)
- private System.Collections.IEnumerable GetData(System.Type targetType)

### public class NUnit.Framework.ValueSourceAttribute
- Base: NUnit.Framework.DataAttribute
- Interfaces: NUnit.Framework.Interfaces.IParameterDataSource

#### Fields
- private string <SourceName>k__BackingField
- private System.Type <SourceType>k__BackingField

#### Properties
- public string SourceName { get; private set; }
- public System.Type SourceType { get; private set; }

#### Constructors
- public ValueSourceAttribute(string sourceName)
- public ValueSourceAttribute(System.Type sourceType, string sourceName)

#### Methods
- public System.Collections.IEnumerable GetData(NUnit.Framework.Interfaces.IParameterInfo parameter)
- private System.Collections.IEnumerable GetDataSource(NUnit.Framework.Interfaces.IParameterInfo parameter)
- private static System.Collections.IEnumerable GetDataSourceValue(System.Reflection.MemberInfo[] members)
- private static void ThrowInvalidDataSourceException()

## Namespace: NUnit.Framework.Api

### private class NUnit.Framework.Api.FrameworkController.<>c

#### Fields
- public static readonly NUnit.Framework.Api.FrameworkController.<>c <>9
- public static System.Func<System.Collections.DictionaryEntry, string> <>9__6_0
- public static System.Func<System.Collections.DictionaryEntry, object> <>9__6_1

#### Constructors
- private static FrameworkController.<>c()
- public FrameworkController.<>c()

#### Methods
- internal string <Initialize>b__6_0(System.Collections.DictionaryEntry de)
- internal object <Initialize>b__6_1(System.Collections.DictionaryEntry de)

### private class NUnit.Framework.Api.FrameworkController.ActionCallback
- Interfaces: System.Web.UI.ICallbackEventHandler

#### Fields
- private System.Action<string> _callback

#### Constructors
- public FrameworkController.ActionCallback(System.Action<string> callback)

#### Methods
- public string GetCallbackResult()
- public void RaiseCallbackEvent(string report)

### public class NUnit.Framework.Api.FrameworkController.CountTestsAction
- Base: NUnit.Framework.Api.FrameworkController.FrameworkControllerAction

#### Constructors
- public FrameworkController.CountTestsAction(NUnit.Framework.Api.FrameworkController controller, string filter, object handler)

### public class NUnit.Framework.Api.DefaultTestAssemblyBuilder
- Interfaces: NUnit.Framework.Api.ITestAssemblyBuilder

#### Fields
- private static NUnit.Framework.Internal.Logger log
- private NUnit.Framework.Interfaces.ISuiteBuilder _defaultSuiteBuilder

#### Constructors
- public DefaultTestAssemblyBuilder()
- private static DefaultTestAssemblyBuilder()

#### Methods
- public NUnit.Framework.Interfaces.ITest Build(System.Reflection.Assembly assembly, System.Collections.Generic.IDictionary<string, object> options)
- public NUnit.Framework.Interfaces.ITest Build(string assemblyName, System.Collections.Generic.IDictionary<string, object> options)
- private NUnit.Framework.Internal.TestSuite Build(System.Reflection.Assembly assembly, string assemblyPath, System.Collections.Generic.IDictionary<string, object> options)
- private NUnit.Framework.Internal.TestSuite BuildTestAssembly(System.Reflection.Assembly assembly, string assemblyName, System.Collections.Generic.IList<NUnit.Framework.Internal.Test> fixtures)
- private System.Collections.Generic.IList<System.Type> GetCandidateFixtureTypes(System.Reflection.Assembly assembly, System.Collections.IList names)
- private System.Collections.Generic.IList<NUnit.Framework.Internal.Test> GetFixtures(System.Reflection.Assembly assembly, System.Collections.IList names)

### public class NUnit.Framework.Api.FrameworkController.ExploreTestsAction
- Base: NUnit.Framework.Api.FrameworkController.FrameworkControllerAction

#### Constructors
- public FrameworkController.ExploreTestsAction(NUnit.Framework.Api.FrameworkController controller, string filter, object handler)

### public class NUnit.Framework.Api.FrameworkController
- Base: NUnit.Compatibility.LongLivedMarshalByRefObject

#### Fields
- private System.Reflection.Assembly <Assembly>k__BackingField
- private string <AssemblyNameOrPath>k__BackingField
- private NUnit.Framework.Api.ITestAssemblyBuilder <Builder>k__BackingField
- private NUnit.Framework.Api.ITestAssemblyRunner <Runner>k__BackingField
- private System.Collections.Generic.IDictionary<string, object> <Settings>k__BackingField
- private static const string LOG_FILE_FORMAT
- private System.Reflection.Assembly _testAssembly

#### Properties
- public System.Reflection.Assembly Assembly { get; private set; }
- public string AssemblyNameOrPath { get; private set; }
- public NUnit.Framework.Api.ITestAssemblyBuilder Builder { get; private set; }
- public NUnit.Framework.Api.ITestAssemblyRunner Runner { get; private set; }
- internal System.Collections.Generic.IDictionary<string, object> Settings { get; private set; }

#### Constructors
- public FrameworkController(string assemblyNameOrPath, string idPrefix, System.Collections.IDictionary settings)
- public FrameworkController(System.Reflection.Assembly assembly, string idPrefix, System.Collections.IDictionary settings)
- public FrameworkController(string assemblyNameOrPath, string idPrefix, System.Collections.IDictionary settings, string runnerType, string builderType)
- public FrameworkController(System.Reflection.Assembly assembly, string idPrefix, System.Collections.IDictionary settings, string runnerType, string builderType)

#### Methods
- private static void AddSetting(NUnit.Framework.Interfaces.TNode settingsNode, string name, object value)
- public int CountTests(string filter)
- private void CountTests(System.Web.UI.ICallbackEventHandler handler, string filter)
- public string ExploreTests(string filter)
- private void ExploreTests(System.Web.UI.ICallbackEventHandler handler, string filter)
- private static string GetProcessorArchitecture()
- private void Initialize(string assemblyPath, System.Collections.IDictionary settings)
- public static NUnit.Framework.Interfaces.TNode InsertEnvironmentElement(NUnit.Framework.Interfaces.TNode targetNode)
- public static NUnit.Framework.Interfaces.TNode InsertSettingsElement(NUnit.Framework.Interfaces.TNode targetNode, System.Collections.Generic.IDictionary<string, object> settings)
- public string LoadTests()
- private void LoadTests(System.Web.UI.ICallbackEventHandler handler)
- private void RunAsync(System.Action<string> callback, string filter)
- private void RunAsync(System.Web.UI.ICallbackEventHandler handler, string filter)
- public string RunTests(string filter)
- public string RunTests(System.Action<string> callback, string filter)
- private void RunTests(System.Web.UI.ICallbackEventHandler handler, string filter)
- public void StopRun(bool force)
- private void StopRun(System.Web.UI.ICallbackEventHandler handler, bool force)

### public class NUnit.Framework.Api.FrameworkController.FrameworkControllerAction
- Base: NUnit.Compatibility.LongLivedMarshalByRefObject

#### Constructors
- protected FrameworkController.FrameworkControllerAction()

### public interface NUnit.Framework.Api.ITestAssemblyBuilder

#### Methods
- public NUnit.Framework.Interfaces.ITest Build(System.Reflection.Assembly assembly, System.Collections.Generic.IDictionary<string, object> options)
- public NUnit.Framework.Interfaces.ITest Build(string assemblyName, System.Collections.Generic.IDictionary<string, object> options)

### public interface NUnit.Framework.Api.ITestAssemblyRunner

#### Properties
- public bool IsTestComplete { get; }
- public bool IsTestLoaded { get; }
- public bool IsTestRunning { get; }
- public NUnit.Framework.Interfaces.ITest LoadedTest { get; }
- public NUnit.Framework.Interfaces.ITestResult Result { get; }

#### Methods
- public int CountTestCases(NUnit.Framework.Interfaces.ITestFilter filter)
- public NUnit.Framework.Interfaces.ITest Load(string assemblyName, System.Collections.Generic.IDictionary<string, object> settings)
- public NUnit.Framework.Interfaces.ITest Load(System.Reflection.Assembly assembly, System.Collections.Generic.IDictionary<string, object> settings)
- public NUnit.Framework.Interfaces.ITestResult Run(NUnit.Framework.Interfaces.ITestListener listener, NUnit.Framework.Interfaces.ITestFilter filter)
- public void RunAsync(NUnit.Framework.Interfaces.ITestListener listener, NUnit.Framework.Interfaces.ITestFilter filter)
- public void StopRun(bool force)
- public bool WaitForCompletion(int timeout)

### public class NUnit.Framework.Api.FrameworkController.LoadTestsAction
- Base: NUnit.Framework.Api.FrameworkController.FrameworkControllerAction

#### Constructors
- public FrameworkController.LoadTestsAction(NUnit.Framework.Api.FrameworkController controller, object handler)

### public class NUnit.Framework.Api.NUnitTestAssemblyRunner
- Interfaces: NUnit.Framework.Api.ITestAssemblyRunner

#### Fields
- private NUnit.Framework.Internal.TestExecutionContext <Context>k__BackingField
- private NUnit.Framework.Interfaces.ITest <LoadedTest>k__BackingField
- private System.Collections.Generic.IDictionary<string, object> <Settings>k__BackingField
- private NUnit.Framework.Internal.Execution.WorkItem <TopLevelWorkItem>k__BackingField
- private static NUnit.Framework.Internal.Logger log
- private NUnit.Framework.Api.ITestAssemblyBuilder _builder
- private System.Threading.ManualResetEvent _runComplete
- private System.IO.TextWriter _savedErr
- private System.IO.TextWriter _savedOut

#### Properties
- private NUnit.Framework.Internal.TestExecutionContext Context { get; set; }
- public bool IsTestComplete { get; }
- public bool IsTestLoaded { get; }
- public bool IsTestRunning { get; }
- public NUnit.Framework.Interfaces.ITest LoadedTest { get; protected set; }
- public NUnit.Framework.Interfaces.ITestResult Result { get; }
- protected System.Collections.Generic.IDictionary<string, object> Settings { get; set; }
- private NUnit.Framework.Internal.Execution.WorkItem TopLevelWorkItem { get; set; }

#### Constructors
- private static NUnitTestAssemblyRunner()
- public NUnitTestAssemblyRunner(NUnit.Framework.Api.ITestAssemblyBuilder builder)

#### Methods
- public int CountTestCases(NUnit.Framework.Interfaces.ITestFilter filter)
- private int CountTestCases(NUnit.Framework.Interfaces.ITest test, NUnit.Framework.Interfaces.ITestFilter filter)
- private void CreateTestExecutionContext(NUnit.Framework.Interfaces.ITestListener listener)
- public NUnit.Framework.Interfaces.ITest Load(string assemblyName, System.Collections.Generic.IDictionary<string, object> settings)
- public NUnit.Framework.Interfaces.ITest Load(System.Reflection.Assembly assembly, System.Collections.Generic.IDictionary<string, object> settings)
- private void OnRunCompleted(object sender, System.EventArgs e)
- public NUnit.Framework.Interfaces.ITestResult Run(NUnit.Framework.Interfaces.ITestListener listener, NUnit.Framework.Interfaces.ITestFilter filter)
- public void RunAsync(NUnit.Framework.Interfaces.ITestListener listener, NUnit.Framework.Interfaces.ITestFilter filter)
- private void StartRun(NUnit.Framework.Interfaces.ITestListener listener)
- public void StopRun(bool force)
- public bool WaitForCompletion(int timeout)

### public class NUnit.Framework.Api.FrameworkController.RunAsyncAction
- Base: NUnit.Framework.Api.FrameworkController.FrameworkControllerAction

#### Constructors
- public FrameworkController.RunAsyncAction(NUnit.Framework.Api.FrameworkController controller, string filter, object handler)

### public class NUnit.Framework.Api.FrameworkController.RunTestsAction
- Base: NUnit.Framework.Api.FrameworkController.FrameworkControllerAction

#### Constructors
- public FrameworkController.RunTestsAction(NUnit.Framework.Api.FrameworkController controller, string filter, object handler)

### public class NUnit.Framework.Api.FrameworkController.StopRunAction
- Base: NUnit.Framework.Api.FrameworkController.FrameworkControllerAction

#### Constructors
- public FrameworkController.StopRunAction(NUnit.Framework.Api.FrameworkController controller, bool force, object handler)

## Namespace: NUnit.Framework.Constraints

### private class NUnit.Framework.Constraints.MsgUtils.<>c

#### Fields
- public static readonly NUnit.Framework.Constraints.MsgUtils.<>c <>9

#### Constructors
- private static MsgUtils.<>c()
- public MsgUtils.<>c()

#### Methods
- internal string <.cctor>b__14_0(object val)
- internal NUnit.Framework.Constraints.ValueFormatter <.cctor>b__14_1(NUnit.Framework.Constraints.ValueFormatter next)
- internal NUnit.Framework.Constraints.ValueFormatter <.cctor>b__14_10(NUnit.Framework.Constraints.ValueFormatter next)
- internal NUnit.Framework.Constraints.ValueFormatter <.cctor>b__14_2(NUnit.Framework.Constraints.ValueFormatter next)
- internal NUnit.Framework.Constraints.ValueFormatter <.cctor>b__14_3(NUnit.Framework.Constraints.ValueFormatter next)
- internal NUnit.Framework.Constraints.ValueFormatter <.cctor>b__14_4(NUnit.Framework.Constraints.ValueFormatter next)
- internal NUnit.Framework.Constraints.ValueFormatter <.cctor>b__14_5(NUnit.Framework.Constraints.ValueFormatter next)
- internal NUnit.Framework.Constraints.ValueFormatter <.cctor>b__14_6(NUnit.Framework.Constraints.ValueFormatter next)
- internal NUnit.Framework.Constraints.ValueFormatter <.cctor>b__14_7(NUnit.Framework.Constraints.ValueFormatter next)
- internal NUnit.Framework.Constraints.ValueFormatter <.cctor>b__14_8(NUnit.Framework.Constraints.ValueFormatter next)
- internal NUnit.Framework.Constraints.ValueFormatter <.cctor>b__14_9(NUnit.Framework.Constraints.ValueFormatter next)

### private class NUnit.Framework.Constraints.CollectionContainsConstraint.<>c__DisplayClass10_0<TCollectionType, TMemberType>

#### Fields
- public System.Func<TCollectionType, TMemberType, bool> comparison

#### Constructors
- public CollectionContainsConstraint.<>c__DisplayClass10_0<TCollectionType, TMemberType>()

#### Methods
- internal bool <Using>b__0(TMemberType actual, TCollectionType expected)

### private class NUnit.Framework.Constraints.MsgUtils.<>c__DisplayClass14_0

#### Fields
- public NUnit.Framework.Constraints.ValueFormatter next

#### Constructors
- public MsgUtils.<>c__DisplayClass14_0()

#### Methods
- internal string <.cctor>b__11(object val)

### private class NUnit.Framework.Constraints.MsgUtils.<>c__DisplayClass14_1

#### Fields
- public NUnit.Framework.Constraints.ValueFormatter next

#### Constructors
- public MsgUtils.<>c__DisplayClass14_1()

#### Methods
- internal string <.cctor>b__12(object val)

### private class NUnit.Framework.Constraints.MsgUtils.<>c__DisplayClass14_2

#### Fields
- public NUnit.Framework.Constraints.ValueFormatter next

#### Constructors
- public MsgUtils.<>c__DisplayClass14_2()

#### Methods
- internal string <.cctor>b__13(object val)

### private class NUnit.Framework.Constraints.MsgUtils.<>c__DisplayClass14_3

#### Fields
- public NUnit.Framework.Constraints.ValueFormatter next

#### Constructors
- public MsgUtils.<>c__DisplayClass14_3()

#### Methods
- internal string <.cctor>b__14(object val)

### private class NUnit.Framework.Constraints.MsgUtils.<>c__DisplayClass14_4

#### Fields
- public NUnit.Framework.Constraints.ValueFormatter next

#### Constructors
- public MsgUtils.<>c__DisplayClass14_4()

#### Methods
- internal string <.cctor>b__15(object val)

### private class NUnit.Framework.Constraints.MsgUtils.<>c__DisplayClass14_5

#### Fields
- public NUnit.Framework.Constraints.ValueFormatter next

#### Constructors
- public MsgUtils.<>c__DisplayClass14_5()

#### Methods
- internal string <.cctor>b__16(object val)

### private class NUnit.Framework.Constraints.MsgUtils.<>c__DisplayClass14_6

#### Fields
- public NUnit.Framework.Constraints.ValueFormatter next

#### Constructors
- public MsgUtils.<>c__DisplayClass14_6()

#### Methods
- internal string <.cctor>b__17(object val)

### private class NUnit.Framework.Constraints.MsgUtils.<>c__DisplayClass14_7

#### Fields
- public NUnit.Framework.Constraints.ValueFormatter next

#### Constructors
- public MsgUtils.<>c__DisplayClass14_7()

#### Methods
- internal string <.cctor>b__18(object val)

### private class NUnit.Framework.Constraints.MsgUtils.<>c__DisplayClass14_8

#### Fields
- public NUnit.Framework.Constraints.ValueFormatter next

#### Constructors
- public MsgUtils.<>c__DisplayClass14_8()

#### Methods
- internal string <.cctor>b__19(object val)

### private class NUnit.Framework.Constraints.MsgUtils.<>c__DisplayClass14_9

#### Fields
- public NUnit.Framework.Constraints.ValueFormatter next

#### Constructors
- public MsgUtils.<>c__DisplayClass14_9()

#### Methods
- internal string <.cctor>b__20(object val)

### private class NUnit.Framework.Constraints.ThrowsExceptionConstraint.<>c__DisplayClass3_0<TActual>

#### Fields
- public NUnit.Framework.Constraints.ActualValueDelegate<TActual> del

#### Constructors
- public ThrowsExceptionConstraint.<>c__DisplayClass3_0<TActual>()

#### Methods
- internal void <GetTestObject>b__0()

### private class NUnit.Framework.Constraints.CollectionSupersetConstraint.<>c__DisplayClass7_0<TSupersetType, TSubsetType>

#### Fields
- public System.Func<TSupersetType, TSubsetType, bool> comparison

#### Constructors
- public CollectionSupersetConstraint.<>c__DisplayClass7_0<TSupersetType, TSubsetType>()

#### Methods
- internal bool <Using>b__0(TSubsetType actual, TSupersetType expected)

### public delegate NUnit.Framework.Constraints.ActualValueDelegate<TActual>
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActualValueDelegate<TActual>(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual TActual EndInvoke(System.IAsyncResult result)
- public virtual TActual Invoke()

### public class NUnit.Framework.Constraints.AllItemsConstraint
- Base: NUnit.Framework.Constraints.PrefixConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string DisplayName { get; }

#### Constructors
- public AllItemsConstraint(NUnit.Framework.Constraints.IConstraint itemConstraint)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### public class NUnit.Framework.Constraints.AllOperator
- Base: NUnit.Framework.Constraints.CollectionOperator

#### Constructors
- public AllOperator()

#### Methods
- public override NUnit.Framework.Constraints.IConstraint ApplyPrefix(NUnit.Framework.Constraints.IConstraint constraint)

### public class NUnit.Framework.Constraints.AndConstraint
- Base: NUnit.Framework.Constraints.BinaryConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string Description { get; }

#### Constructors
- public AndConstraint(NUnit.Framework.Constraints.IConstraint left, NUnit.Framework.Constraints.IConstraint right)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### private class NUnit.Framework.Constraints.AndConstraint.AndConstraintResult
- Base: NUnit.Framework.Constraints.ConstraintResult

#### Fields
- private NUnit.Framework.Constraints.ConstraintResult leftResult
- private NUnit.Framework.Constraints.ConstraintResult rightResult

#### Constructors
- public AndConstraint.AndConstraintResult(NUnit.Framework.Constraints.AndConstraint constraint, object actual, NUnit.Framework.Constraints.ConstraintResult leftResult, NUnit.Framework.Constraints.ConstraintResult rightResult)

#### Methods
- public override void WriteActualValueTo(NUnit.Framework.Constraints.MessageWriter writer)

### public class NUnit.Framework.Constraints.AndOperator
- Base: NUnit.Framework.Constraints.BinaryOperator

#### Constructors
- public AndOperator()

#### Methods
- public override NUnit.Framework.Constraints.IConstraint ApplyOperator(NUnit.Framework.Constraints.IConstraint left, NUnit.Framework.Constraints.IConstraint right)

### public class NUnit.Framework.Constraints.AssignableFromConstraint
- Base: NUnit.Framework.Constraints.TypeConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public AssignableFromConstraint(System.Type type)

#### Methods
- protected override bool Matches(object actual)

### public class NUnit.Framework.Constraints.AssignableToConstraint
- Base: NUnit.Framework.Constraints.TypeConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public AssignableToConstraint(System.Type type)

#### Methods
- protected override bool Matches(object actual)

### public class NUnit.Framework.Constraints.AttributeConstraint
- Base: NUnit.Framework.Constraints.PrefixConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private System.Attribute attrFound
- private readonly System.Type expectedType

#### Constructors
- public AttributeConstraint(System.Type type, NUnit.Framework.Constraints.IConstraint baseConstraint)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- protected override string GetStringRepresentation()

### public class NUnit.Framework.Constraints.AttributeExistsConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private System.Type expectedType

#### Properties
- public string Description { get; }

#### Constructors
- public AttributeExistsConstraint(System.Type type)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### public class NUnit.Framework.Constraints.AttributeOperator
- Base: NUnit.Framework.Constraints.SelfResolvingOperator

#### Fields
- private readonly System.Type type

#### Constructors
- public AttributeOperator(System.Type type)

#### Methods
- public override void Reduce(NUnit.Framework.Constraints.ConstraintBuilder.ConstraintStack stack)

### public class NUnit.Framework.Constraints.BinaryConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- protected NUnit.Framework.Constraints.IConstraint Left
- protected NUnit.Framework.Constraints.IConstraint Right

#### Constructors
- protected BinaryConstraint(NUnit.Framework.Constraints.IConstraint left, NUnit.Framework.Constraints.IConstraint right)

### public class NUnit.Framework.Constraints.BinaryOperator
- Base: NUnit.Framework.Constraints.ConstraintOperator

#### Properties
- public int LeftPrecedence { get; }
- public int RightPrecedence { get; }

#### Constructors
- protected BinaryOperator()

#### Methods
- public abstract NUnit.Framework.Constraints.IConstraint ApplyOperator(NUnit.Framework.Constraints.IConstraint left, NUnit.Framework.Constraints.IConstraint right)
- public override void Reduce(NUnit.Framework.Constraints.ConstraintBuilder.ConstraintStack stack)

### public class NUnit.Framework.Constraints.BinarySerializableConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private readonly System.Runtime.Serialization.Formatters.Binary.BinaryFormatter serializer

#### Properties
- public string Description { get; }

#### Constructors
- public BinarySerializableConstraint()

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- protected override string GetStringRepresentation()

### public class NUnit.Framework.Constraints.CollectionConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- protected CollectionConstraint()
- protected CollectionConstraint(object arg)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- protected static bool IsEmpty(System.Collections.IEnumerable enumerable)
- protected abstract bool Matches(System.Collections.IEnumerable collection)

### public class NUnit.Framework.Constraints.CollectionContainsConstraint
- Base: NUnit.Framework.Constraints.CollectionItemsEqualConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private object <Expected>k__BackingField

#### Properties
- public string Description { get; }
- public string DisplayName { get; }
- protected object Expected { get; private set; }

#### Constructors
- public CollectionContainsConstraint(object expected)

#### Methods
- protected override bool Matches(System.Collections.IEnumerable actual)
- public NUnit.Framework.Constraints.CollectionContainsConstraint Using<TCollectionType, TMemberType>(System.Func<TCollectionType, TMemberType, bool> comparison)

### public class NUnit.Framework.Constraints.CollectionEquivalentConstraint
- Base: NUnit.Framework.Constraints.CollectionItemsEqualConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private readonly System.Collections.IEnumerable _expected

#### Properties
- public string Description { get; }
- public string DisplayName { get; }

#### Constructors
- public CollectionEquivalentConstraint(System.Collections.IEnumerable expected)

#### Methods
- protected override bool Matches(System.Collections.IEnumerable actual)
- public NUnit.Framework.Constraints.CollectionEquivalentConstraint Using<TActual, TExpected>(System.Func<TActual, TExpected, bool> comparison)

### public class NUnit.Framework.Constraints.CollectionItemsEqualConstraint
- Base: NUnit.Framework.Constraints.CollectionConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private readonly NUnit.Framework.Constraints.NUnitEqualityComparer comparer

#### Properties
- public NUnit.Framework.Constraints.CollectionItemsEqualConstraint IgnoreCase { get; }

#### Constructors
- protected CollectionItemsEqualConstraint()
- protected CollectionItemsEqualConstraint(object arg)

#### Methods
- protected bool ItemsEqual(object x, object y)
- protected NUnit.Framework.Constraints.CollectionTally Tally(System.Collections.IEnumerable c)
- public NUnit.Framework.Constraints.CollectionItemsEqualConstraint Using(System.Collections.IComparer comparer)
- public NUnit.Framework.Constraints.CollectionItemsEqualConstraint Using<T>(System.Collections.Generic.IComparer<T> comparer)
- public NUnit.Framework.Constraints.CollectionItemsEqualConstraint Using<T>(System.Comparison<T> comparer)
- public NUnit.Framework.Constraints.CollectionItemsEqualConstraint Using(System.Collections.IEqualityComparer comparer)
- public NUnit.Framework.Constraints.CollectionItemsEqualConstraint Using<T>(System.Collections.Generic.IEqualityComparer<T> comparer)
- internal NUnit.Framework.Constraints.CollectionItemsEqualConstraint Using(NUnit.Framework.Constraints.EqualityAdapter adapter)

### public class NUnit.Framework.Constraints.CollectionOperator
- Base: NUnit.Framework.Constraints.PrefixOperator

#### Constructors
- protected CollectionOperator()

### public class NUnit.Framework.Constraints.CollectionOrderedConstraint
- Base: NUnit.Framework.Constraints.CollectionConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private NUnit.Framework.Constraints.CollectionOrderedConstraint.OrderingStep _activeStep
- private System.Collections.Generic.List<NUnit.Framework.Constraints.CollectionOrderedConstraint.OrderingStep> _steps

#### Properties
- public NUnit.Framework.Constraints.CollectionOrderedConstraint Ascending { get; }
- public NUnit.Framework.Constraints.CollectionOrderedConstraint Descending { get; }
- public string Description { get; }
- public string DisplayName { get; }
- public NUnit.Framework.Constraints.CollectionOrderedConstraint Then { get; }

#### Constructors
- public CollectionOrderedConstraint()

#### Methods
- public NUnit.Framework.Constraints.CollectionOrderedConstraint By(string propertyName)
- private void CreateNextStep(string propertyName)
- protected override string GetStringRepresentation()
- protected override bool Matches(System.Collections.IEnumerable actual)
- public NUnit.Framework.Constraints.CollectionOrderedConstraint Using(System.Collections.IComparer comparer)
- public NUnit.Framework.Constraints.CollectionOrderedConstraint Using<T>(System.Collections.Generic.IComparer<T> comparer)
- public NUnit.Framework.Constraints.CollectionOrderedConstraint Using<T>(System.Comparison<T> comparer)

### public class NUnit.Framework.Constraints.CollectionSubsetConstraint
- Base: NUnit.Framework.Constraints.CollectionItemsEqualConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private System.Collections.IEnumerable _expected

#### Properties
- public string Description { get; }
- public string DisplayName { get; }

#### Constructors
- public CollectionSubsetConstraint(System.Collections.IEnumerable expected)

#### Methods
- protected override bool Matches(System.Collections.IEnumerable actual)
- public NUnit.Framework.Constraints.CollectionSubsetConstraint Using<TSubsetType, TSupersetType>(System.Func<TSubsetType, TSupersetType, bool> comparison)

### public class NUnit.Framework.Constraints.CollectionSupersetConstraint
- Base: NUnit.Framework.Constraints.CollectionItemsEqualConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private System.Collections.IEnumerable _expected

#### Properties
- public string Description { get; }
- public string DisplayName { get; }

#### Constructors
- public CollectionSupersetConstraint(System.Collections.IEnumerable expected)

#### Methods
- protected override bool Matches(System.Collections.IEnumerable actual)
- public NUnit.Framework.Constraints.CollectionSupersetConstraint Using<TSupersetType, TSubsetType>(System.Func<TSupersetType, TSubsetType, bool> comparison)

### public class NUnit.Framework.Constraints.CollectionTally

#### Fields
- private readonly NUnit.Framework.Constraints.NUnitEqualityComparer comparer
- private readonly System.Collections.Generic.List<object> list

#### Properties
- public int Count { get; }

#### Constructors
- public CollectionTally(NUnit.Framework.Constraints.NUnitEqualityComparer comparer, System.Collections.IEnumerable c)

#### Methods
- private bool ItemsEqual(object expected, object actual)
- public bool TryRemove(object o)
- public bool TryRemove(System.Collections.IEnumerable c)

### private class NUnit.Framework.Constraints.ComparisonAdapter.ComparerAdapter
- Base: NUnit.Framework.Constraints.ComparisonAdapter

#### Fields
- private readonly System.Collections.IComparer comparer

#### Constructors
- public ComparisonAdapter.ComparerAdapter(System.Collections.IComparer comparer)

#### Methods
- public override int Compare(object expected, object actual)

### private class NUnit.Framework.Constraints.EqualityAdapter.ComparerAdapter
- Base: NUnit.Framework.Constraints.EqualityAdapter

#### Fields
- private System.Collections.IComparer comparer

#### Constructors
- public EqualityAdapter.ComparerAdapter(System.Collections.IComparer comparer)

#### Methods
- public override bool AreEqual(object x, object y)

### private class NUnit.Framework.Constraints.ComparisonAdapter.ComparerAdapter<T>
- Base: NUnit.Framework.Constraints.ComparisonAdapter

#### Fields
- private readonly System.Collections.Generic.IComparer<T> comparer

#### Constructors
- public ComparisonAdapter.ComparerAdapter<T>(System.Collections.Generic.IComparer<T> comparer)

#### Methods
- public override int Compare(object expected, object actual)

### private class NUnit.Framework.Constraints.EqualityAdapter.ComparerAdapter<T>
- Base: NUnit.Framework.Constraints.EqualityAdapter.GenericEqualityAdapter<T>

#### Fields
- private System.Collections.Generic.IComparer<T> comparer

#### Constructors
- public EqualityAdapter.ComparerAdapter<T>(System.Collections.Generic.IComparer<T> comparer)

#### Methods
- public override bool AreEqual(object x, object y)

### public class NUnit.Framework.Constraints.ComparisonAdapter

#### Properties
- public static NUnit.Framework.Constraints.ComparisonAdapter Default { get; }

#### Constructors
- protected ComparisonAdapter()

#### Methods
- public abstract int Compare(object expected, object actual)
- public static NUnit.Framework.Constraints.ComparisonAdapter For(System.Collections.IComparer comparer)
- public static NUnit.Framework.Constraints.ComparisonAdapter For<T>(System.Collections.Generic.IComparer<T> comparer)
- public static NUnit.Framework.Constraints.ComparisonAdapter For<T>(System.Comparison<T> comparer)

### private class NUnit.Framework.Constraints.ComparisonAdapter.ComparisonAdapterForComparison<T>
- Base: NUnit.Framework.Constraints.ComparisonAdapter

#### Fields
- private readonly System.Comparison<T> comparison

#### Constructors
- public ComparisonAdapter.ComparisonAdapterForComparison<T>(System.Comparison<T> comparer)

#### Methods
- public override int Compare(object expected, object actual)

### private class NUnit.Framework.Constraints.EqualityAdapter.ComparisonAdapter<T>
- Base: NUnit.Framework.Constraints.EqualityAdapter.GenericEqualityAdapter<T>

#### Fields
- private System.Comparison<T> comparer

#### Constructors
- public EqualityAdapter.ComparisonAdapter<T>(System.Comparison<T> comparer)

#### Methods
- public override bool AreEqual(object x, object y)

### public class NUnit.Framework.Constraints.ComparisonConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private NUnit.Framework.Constraints.ComparisonAdapter comparer
- protected bool equalComparisonResult
- protected object expected
- protected bool greaterComparisonResult
- protected bool lessComparisonResult

#### Constructors
- protected ComparisonConstraint(object value, bool lessComparisonResult, bool equalComparisonResult, bool greaterComparisonResult, string predicate)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- public NUnit.Framework.Constraints.ComparisonConstraint Using(System.Collections.IComparer comparer)
- public NUnit.Framework.Constraints.ComparisonConstraint Using<T>(System.Collections.Generic.IComparer<T> comparer)
- public NUnit.Framework.Constraints.ComparisonConstraint Using<T>(System.Comparison<T> comparer)

### public class NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private object[] <Arguments>k__BackingField
- private NUnit.Framework.Constraints.ConstraintBuilder <Builder>k__BackingField
- private string <Description>k__BackingField
- private System.Lazy<string> _displayName

#### Properties
- public NUnit.Framework.Constraints.ConstraintExpression And { get; }
- public object[] Arguments { get; private set; }
- public NUnit.Framework.Constraints.ConstraintBuilder Builder { get; set; }
- public string Description { get; protected set; }
- public string DisplayName { get; }
- public NUnit.Framework.Constraints.ConstraintExpression Or { get; }
- public NUnit.Framework.Constraints.ConstraintExpression With { get; }

#### Constructors
- protected Constraint(params object[] args)

#### Methods
- private string <.ctor>b__1_0()
- public NUnit.Framework.Constraints.DelayedConstraint After(int delayInMilliseconds)
- public NUnit.Framework.Constraints.DelayedConstraint After(int delayInMilliseconds, int pollingInterval)
- public abstract NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- public virtual NUnit.Framework.Constraints.ConstraintResult ApplyTo<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del)
- public virtual NUnit.Framework.Constraints.ConstraintResult ApplyTo<TActual>(ref TActual actual)
- protected virtual string GetStringRepresentation()
- protected virtual object GetTestObject<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del)
- private NUnit.Framework.Constraints.IConstraint NUnit.Framework.Constraints.IResolveConstraint.Resolve()
- public static NUnit.Framework.Constraints.Constraint op_BitwiseAnd(NUnit.Framework.Constraints.Constraint left, NUnit.Framework.Constraints.Constraint right)
- public static NUnit.Framework.Constraints.Constraint op_BitwiseOr(NUnit.Framework.Constraints.Constraint left, NUnit.Framework.Constraints.Constraint right)
- public static NUnit.Framework.Constraints.Constraint op_LogicalNot(NUnit.Framework.Constraints.Constraint constraint)
- public override string ToString()
- private static string _displayable(object o)

### public class NUnit.Framework.Constraints.ConstraintBuilder
- Interfaces: NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private readonly NUnit.Framework.Constraints.ConstraintBuilder.ConstraintStack constraints
- private object lastPushed
- private readonly NUnit.Framework.Constraints.ConstraintBuilder.OperatorStack ops

#### Properties
- private bool IsResolvable { get; }

#### Constructors
- public ConstraintBuilder()

#### Methods
- public void Append(NUnit.Framework.Constraints.ConstraintOperator op)
- public void Append(NUnit.Framework.Constraints.Constraint constraint)
- private void ReduceOperatorStack(int targetPrecedence)
- public NUnit.Framework.Constraints.IConstraint Resolve()
- private void SetTopOperatorRightContext(object rightContext)

### public class NUnit.Framework.Constraints.ConstraintExpression

#### Fields
- protected NUnit.Framework.Constraints.ConstraintBuilder builder

#### Properties
- public NUnit.Framework.Constraints.ConstraintExpression All { get; }
- public NUnit.Framework.Constraints.BinarySerializableConstraint BinarySerializable { get; }
- public NUnit.Framework.Constraints.ResolvableConstraintExpression Count { get; }
- public NUnit.Framework.Constraints.EmptyConstraint Empty { get; }
- public NUnit.Framework.Constraints.Constraint Exist { get; }
- public NUnit.Framework.Constraints.FalseConstraint False { get; }
- public NUnit.Framework.Constraints.ResolvableConstraintExpression InnerException { get; }
- public NUnit.Framework.Constraints.ResolvableConstraintExpression Length { get; }
- public NUnit.Framework.Constraints.ResolvableConstraintExpression Message { get; }
- public NUnit.Framework.Constraints.NaNConstraint NaN { get; }
- public NUnit.Framework.Constraints.LessThanConstraint Negative { get; }
- public NUnit.Framework.Constraints.ConstraintExpression No { get; }
- public NUnit.Framework.Constraints.ConstraintExpression None { get; }
- public NUnit.Framework.Constraints.ConstraintExpression Not { get; }
- public NUnit.Framework.Constraints.NullConstraint Null { get; }
- public NUnit.Framework.Constraints.CollectionOrderedConstraint Ordered { get; }
- public NUnit.Framework.Constraints.GreaterThanConstraint Positive { get; }
- public NUnit.Framework.Constraints.ConstraintExpression Some { get; }
- public NUnit.Framework.Constraints.TrueConstraint True { get; }
- public NUnit.Framework.Constraints.UniqueItemsConstraint Unique { get; }
- public NUnit.Framework.Constraints.ConstraintExpression With { get; }
- public NUnit.Framework.Constraints.XmlSerializableConstraint XmlSerializable { get; }
- public NUnit.Framework.Constraints.EqualConstraint Zero { get; }

#### Constructors
- public ConstraintExpression()
- public ConstraintExpression(NUnit.Framework.Constraints.ConstraintBuilder builder)

#### Methods
- public NUnit.Framework.Constraints.ConstraintExpression Append(NUnit.Framework.Constraints.ConstraintOperator op)
- public NUnit.Framework.Constraints.ResolvableConstraintExpression Append(NUnit.Framework.Constraints.SelfResolvingOperator op)
- public NUnit.Framework.Constraints.Constraint Append(NUnit.Framework.Constraints.Constraint constraint)
- public NUnit.Framework.Constraints.AssignableFromConstraint AssignableFrom(System.Type expectedType)
- public NUnit.Framework.Constraints.AssignableFromConstraint AssignableFrom<TExpected>()
- public NUnit.Framework.Constraints.AssignableToConstraint AssignableTo(System.Type expectedType)
- public NUnit.Framework.Constraints.AssignableToConstraint AssignableTo<TExpected>()
- public NUnit.Framework.Constraints.GreaterThanOrEqualConstraint AtLeast(object expected)
- public NUnit.Framework.Constraints.LessThanOrEqualConstraint AtMost(object expected)
- public NUnit.Framework.Constraints.ResolvableConstraintExpression Attribute(System.Type expectedType)
- public NUnit.Framework.Constraints.ResolvableConstraintExpression Attribute<TExpected>()
- public NUnit.Framework.Constraints.ContainsConstraint Contain(string expected)
- public NUnit.Framework.Constraints.CollectionContainsConstraint Contains(object expected)
- public NUnit.Framework.Constraints.ContainsConstraint Contains(string expected)
- public NUnit.Framework.Constraints.SubstringConstraint ContainsSubstring(string expected)
- public NUnit.Framework.Constraints.EndsWithConstraint EndsWith(string expected)
- public NUnit.Framework.Constraints.EndsWithConstraint EndWith(string expected)
- public NUnit.Framework.Constraints.EqualConstraint EqualTo(object expected)
- public NUnit.Framework.Constraints.CollectionEquivalentConstraint EquivalentTo(System.Collections.IEnumerable expected)
- public NUnit.Framework.Constraints.ConstraintExpression Exactly(int expectedCount)
- public NUnit.Framework.Constraints.GreaterThanConstraint GreaterThan(object expected)
- public NUnit.Framework.Constraints.GreaterThanOrEqualConstraint GreaterThanOrEqualTo(object expected)
- public NUnit.Framework.Constraints.RangeConstraint InRange(System.IComparable from, System.IComparable to)
- public NUnit.Framework.Constraints.InstanceOfTypeConstraint InstanceOf(System.Type expectedType)
- public NUnit.Framework.Constraints.InstanceOfTypeConstraint InstanceOf<TExpected>()
- public NUnit.Framework.Constraints.LessThanConstraint LessThan(object expected)
- public NUnit.Framework.Constraints.LessThanOrEqualConstraint LessThanOrEqualTo(object expected)
- public NUnit.Framework.Constraints.RegexConstraint Match(string pattern)
- public NUnit.Framework.Constraints.Constraint Matches(NUnit.Framework.Constraints.IResolveConstraint constraint)
- public NUnit.Framework.Constraints.Constraint Matches<TActual>(System.Predicate<TActual> predicate)
- public NUnit.Framework.Constraints.RegexConstraint Matches(string pattern)
- public NUnit.Framework.Constraints.CollectionContainsConstraint Member(object expected)
- public NUnit.Framework.Constraints.ResolvableConstraintExpression Property(string name)
- public NUnit.Framework.Constraints.SameAsConstraint SameAs(object expected)
- public NUnit.Framework.Constraints.SamePathConstraint SamePath(string expected)
- public NUnit.Framework.Constraints.SamePathOrUnderConstraint SamePathOrUnder(string expected)
- public NUnit.Framework.Constraints.StartsWithConstraint StartsWith(string expected)
- public NUnit.Framework.Constraints.StartsWithConstraint StartWith(string expected)
- public NUnit.Framework.Constraints.SubstringConstraint StringContaining(string expected)
- public NUnit.Framework.Constraints.EndsWithConstraint StringEnding(string expected)
- public NUnit.Framework.Constraints.RegexConstraint StringMatching(string pattern)
- public NUnit.Framework.Constraints.StartsWithConstraint StringStarting(string expected)
- public NUnit.Framework.Constraints.SubPathConstraint SubPathOf(string expected)
- public NUnit.Framework.Constraints.CollectionSubsetConstraint SubsetOf(System.Collections.IEnumerable expected)
- public NUnit.Framework.Constraints.CollectionSupersetConstraint SupersetOf(System.Collections.IEnumerable expected)
- public override string ToString()
- public NUnit.Framework.Constraints.ExactTypeConstraint TypeOf(System.Type expectedType)
- public NUnit.Framework.Constraints.ExactTypeConstraint TypeOf<TExpected>()

### public class NUnit.Framework.Constraints.ConstraintFactory

#### Properties
- public NUnit.Framework.Constraints.ConstraintExpression All { get; }
- public NUnit.Framework.Constraints.BinarySerializableConstraint BinarySerializable { get; }
- public NUnit.Framework.Constraints.ResolvableConstraintExpression Count { get; }
- public NUnit.Framework.Constraints.EmptyConstraint Empty { get; }
- public NUnit.Framework.Constraints.FalseConstraint False { get; }
- public NUnit.Framework.Constraints.ResolvableConstraintExpression InnerException { get; }
- public NUnit.Framework.Constraints.ResolvableConstraintExpression Length { get; }
- public NUnit.Framework.Constraints.ResolvableConstraintExpression Message { get; }
- public NUnit.Framework.Constraints.NaNConstraint NaN { get; }
- public NUnit.Framework.Constraints.LessThanConstraint Negative { get; }
- public NUnit.Framework.Constraints.ConstraintExpression No { get; }
- public NUnit.Framework.Constraints.ConstraintExpression None { get; }
- public NUnit.Framework.Constraints.ConstraintExpression Not { get; }
- public NUnit.Framework.Constraints.NullConstraint Null { get; }
- public NUnit.Framework.Constraints.CollectionOrderedConstraint Ordered { get; }
- public NUnit.Framework.Constraints.GreaterThanConstraint Positive { get; }
- public NUnit.Framework.Constraints.ConstraintExpression Some { get; }
- public NUnit.Framework.Constraints.TrueConstraint True { get; }
- public NUnit.Framework.Constraints.UniqueItemsConstraint Unique { get; }
- public NUnit.Framework.Constraints.XmlSerializableConstraint XmlSerializable { get; }
- public NUnit.Framework.Constraints.EqualConstraint Zero { get; }

#### Constructors
- public ConstraintFactory()

#### Methods
- public NUnit.Framework.Constraints.AssignableFromConstraint AssignableFrom(System.Type expectedType)
- public NUnit.Framework.Constraints.AssignableFromConstraint AssignableFrom<TExpected>()
- public NUnit.Framework.Constraints.AssignableToConstraint AssignableTo(System.Type expectedType)
- public NUnit.Framework.Constraints.AssignableToConstraint AssignableTo<TExpected>()
- public NUnit.Framework.Constraints.GreaterThanOrEqualConstraint AtLeast(object expected)
- public NUnit.Framework.Constraints.LessThanOrEqualConstraint AtMost(object expected)
- public NUnit.Framework.Constraints.ResolvableConstraintExpression Attribute(System.Type expectedType)
- public NUnit.Framework.Constraints.ResolvableConstraintExpression Attribute<TExpected>()
- public NUnit.Framework.Constraints.CollectionContainsConstraint Contains(object expected)
- public NUnit.Framework.Constraints.ContainsConstraint Contains(string expected)
- public NUnit.Framework.Constraints.SubstringConstraint ContainsSubstring(string expected)
- public NUnit.Framework.Constraints.SubstringConstraint DoesNotContain(string expected)
- public NUnit.Framework.Constraints.EndsWithConstraint DoesNotEndWith(string expected)
- public NUnit.Framework.Constraints.RegexConstraint DoesNotMatch(string pattern)
- public NUnit.Framework.Constraints.StartsWithConstraint DoesNotStartWith(string expected)
- public NUnit.Framework.Constraints.EndsWithConstraint EndsWith(string expected)
- public NUnit.Framework.Constraints.EndsWithConstraint EndWith(string expected)
- public NUnit.Framework.Constraints.EqualConstraint EqualTo(object expected)
- public NUnit.Framework.Constraints.CollectionEquivalentConstraint EquivalentTo(System.Collections.IEnumerable expected)
- public static NUnit.Framework.Constraints.ConstraintExpression Exactly(int expectedCount)
- public NUnit.Framework.Constraints.GreaterThanConstraint GreaterThan(object expected)
- public NUnit.Framework.Constraints.GreaterThanOrEqualConstraint GreaterThanOrEqualTo(object expected)
- public NUnit.Framework.Constraints.RangeConstraint InRange(System.IComparable from, System.IComparable to)
- public NUnit.Framework.Constraints.InstanceOfTypeConstraint InstanceOf(System.Type expectedType)
- public NUnit.Framework.Constraints.InstanceOfTypeConstraint InstanceOf<TExpected>()
- public NUnit.Framework.Constraints.LessThanConstraint LessThan(object expected)
- public NUnit.Framework.Constraints.LessThanOrEqualConstraint LessThanOrEqualTo(object expected)
- public NUnit.Framework.Constraints.RegexConstraint Match(string pattern)
- public NUnit.Framework.Constraints.RegexConstraint Matches(string pattern)
- public NUnit.Framework.Constraints.CollectionContainsConstraint Member(object expected)
- public NUnit.Framework.Constraints.ResolvableConstraintExpression Property(string name)
- public NUnit.Framework.Constraints.SameAsConstraint SameAs(object expected)
- public NUnit.Framework.Constraints.SamePathConstraint SamePath(string expected)
- public NUnit.Framework.Constraints.SamePathOrUnderConstraint SamePathOrUnder(string expected)
- public NUnit.Framework.Constraints.StartsWithConstraint StartsWith(string expected)
- public NUnit.Framework.Constraints.StartsWithConstraint StartWith(string expected)
- public NUnit.Framework.Constraints.SubstringConstraint StringContaining(string expected)
- public NUnit.Framework.Constraints.EndsWithConstraint StringEnding(string expected)
- public NUnit.Framework.Constraints.RegexConstraint StringMatching(string pattern)
- public NUnit.Framework.Constraints.StartsWithConstraint StringStarting(string expected)
- public NUnit.Framework.Constraints.SubPathConstraint SubPathOf(string expected)
- public NUnit.Framework.Constraints.CollectionSubsetConstraint SubsetOf(System.Collections.IEnumerable expected)
- public NUnit.Framework.Constraints.CollectionSupersetConstraint SupersetOf(System.Collections.IEnumerable expected)
- public NUnit.Framework.Constraints.ExactTypeConstraint TypeOf(System.Type expectedType)
- public NUnit.Framework.Constraints.ExactTypeConstraint TypeOf<TExpected>()

### public class NUnit.Framework.Constraints.ConstraintOperator

#### Fields
- private object leftContext
- protected int left_precedence
- private object rightContext
- protected int right_precedence

#### Properties
- public object LeftContext { get; set; }
- public int LeftPrecedence { get; }
- public object RightContext { get; set; }
- public int RightPrecedence { get; }

#### Constructors
- protected ConstraintOperator()

#### Methods
- public abstract void Reduce(NUnit.Framework.Constraints.ConstraintBuilder.ConstraintStack stack)

### public class NUnit.Framework.Constraints.ConstraintResult

#### Fields
- private object <ActualValue>k__BackingField
- private NUnit.Framework.Constraints.ConstraintStatus <Status>k__BackingField
- private NUnit.Framework.Constraints.IConstraint _constraint

#### Properties
- public object ActualValue { get; private set; }
- public string Description { get; }
- public bool IsSuccess { get; }
- public string Name { get; }
- public NUnit.Framework.Constraints.ConstraintStatus Status { get; set; }

#### Constructors
- public ConstraintResult(NUnit.Framework.Constraints.IConstraint constraint, object actualValue)
- public ConstraintResult(NUnit.Framework.Constraints.IConstraint constraint, object actualValue, NUnit.Framework.Constraints.ConstraintStatus status)
- public ConstraintResult(NUnit.Framework.Constraints.IConstraint constraint, object actualValue, bool isSuccess)

#### Methods
- public virtual void WriteActualValueTo(NUnit.Framework.Constraints.MessageWriter writer)
- public virtual void WriteMessageTo(NUnit.Framework.Constraints.MessageWriter writer)

### public class NUnit.Framework.Constraints.ConstraintBuilder.ConstraintStack

#### Fields
- private readonly NUnit.Framework.Constraints.ConstraintBuilder builder
- private readonly System.Collections.Generic.Stack<NUnit.Framework.Constraints.IConstraint> stack

#### Properties
- public bool Empty { get; }

#### Constructors
- public ConstraintBuilder.ConstraintStack(NUnit.Framework.Constraints.ConstraintBuilder builder)

#### Methods
- public NUnit.Framework.Constraints.IConstraint Pop()
- public void Push(NUnit.Framework.Constraints.IConstraint constraint)

### public enum NUnit.Framework.Constraints.ConstraintStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Error = 3
- Failure = 2
- Success = 1
- Unknown = 0

### public class NUnit.Framework.Constraints.ContainsConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private readonly object _expected
- private bool _ignoreCase
- private NUnit.Framework.Constraints.Constraint _realConstraint

#### Properties
- public string Description { get; }
- public NUnit.Framework.Constraints.ContainsConstraint IgnoreCase { get; }

#### Constructors
- public ContainsConstraint(object expected)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### private class NUnit.Framework.Constraints.ComparisonAdapter.DefaultComparisonAdapter
- Base: NUnit.Framework.Constraints.ComparisonAdapter.ComparerAdapter

#### Constructors
- public ComparisonAdapter.DefaultComparisonAdapter()

### public class NUnit.Framework.Constraints.DelayedConstraint
- Base: NUnit.Framework.Constraints.PrefixConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private readonly int delayInMilliseconds
- private readonly int pollingInterval

#### Properties
- public string Description { get; }

#### Constructors
- public DelayedConstraint(NUnit.Framework.Constraints.IConstraint baseConstraint, int delayInMilliseconds)
- public DelayedConstraint(NUnit.Framework.Constraints.IConstraint baseConstraint, int delayInMilliseconds, int pollingInterval)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del)
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo<TActual>(ref TActual actual)
- protected override string GetStringRepresentation()
- private static object InvokeDelegate<T>(NUnit.Framework.Constraints.ActualValueDelegate<T> del)
- private static System.TimeSpan TimestampDiff(long timestamp1, long timestamp2)
- private static long TimestampOffset(long timestamp, System.TimeSpan offset)

### public class NUnit.Framework.Constraints.DictionaryContainsKeyConstraint
- Base: NUnit.Framework.Constraints.CollectionContainsConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string Description { get; }
- public string DisplayName { get; }

#### Constructors
- public DictionaryContainsKeyConstraint(object expected)

#### Methods
- protected override bool Matches(System.Collections.IEnumerable actual)

### public class NUnit.Framework.Constraints.DictionaryContainsValueConstraint
- Base: NUnit.Framework.Constraints.CollectionContainsConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string Description { get; }
- public string DisplayName { get; }

#### Constructors
- public DictionaryContainsValueConstraint(object expected)

#### Methods
- protected override bool Matches(System.Collections.IEnumerable actual)

### private struct NUnit.Framework.Constraints.FloatingPointNumerics.DoubleLongUnion

#### Fields
- public double Double
- public long Long
- public ulong ULong

### public class NUnit.Framework.Constraints.EmptyCollectionConstraint
- Base: NUnit.Framework.Constraints.CollectionConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string Description { get; }

#### Constructors
- public EmptyCollectionConstraint()

#### Methods
- protected override bool Matches(System.Collections.IEnumerable collection)

### public class NUnit.Framework.Constraints.EmptyConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private NUnit.Framework.Constraints.Constraint realConstraint

#### Properties
- public string Description { get; }

#### Constructors
- public EmptyConstraint()

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### public class NUnit.Framework.Constraints.EmptyDirectoryConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private int files
- private int subdirs

#### Properties
- public string Description { get; }

#### Constructors
- public EmptyDirectoryConstraint()

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### public class NUnit.Framework.Constraints.EmptyStringConstraint
- Base: NUnit.Framework.Constraints.StringConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string Description { get; }

#### Constructors
- public EmptyStringConstraint()

#### Methods
- protected override bool Matches(string actual)

### public class NUnit.Framework.Constraints.EndsWithConstraint
- Base: NUnit.Framework.Constraints.StringConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public EndsWithConstraint(string expected)

#### Methods
- protected override bool Matches(string actual)

### public class NUnit.Framework.Constraints.EqualConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private bool <ClipStrings>k__BackingField
- private NUnit.Framework.Constraints.NUnitEqualityComparer _comparer
- private readonly object _expected
- private NUnit.Framework.Constraints.Tolerance _tolerance

#### Properties
- public NUnit.Framework.Constraints.EqualConstraint AsCollection { get; }
- public bool CaseInsensitive { get; }
- public bool ClipStrings { get; private set; }
- public NUnit.Framework.Constraints.EqualConstraint Days { get; }
- public string Description { get; }
- public System.Collections.Generic.IList<NUnit.Framework.Constraints.NUnitEqualityComparer.FailurePoint> FailurePoints { get; }
- public NUnit.Framework.Constraints.EqualConstraint Hours { get; }
- public NUnit.Framework.Constraints.EqualConstraint IgnoreCase { get; }
- public NUnit.Framework.Constraints.EqualConstraint Milliseconds { get; }
- public NUnit.Framework.Constraints.EqualConstraint Minutes { get; }
- public NUnit.Framework.Constraints.EqualConstraint NoClip { get; }
- public NUnit.Framework.Constraints.EqualConstraint Percent { get; }
- public NUnit.Framework.Constraints.EqualConstraint Seconds { get; }
- public NUnit.Framework.Constraints.EqualConstraint Ticks { get; }
- public NUnit.Framework.Constraints.Tolerance Tolerance { get; }
- public NUnit.Framework.Constraints.EqualConstraint Ulps { get; }
- public NUnit.Framework.Constraints.EqualConstraint WithSameOffset { get; }

#### Constructors
- public EqualConstraint(object expected)

#### Methods
- private void AdjustArgumentIfNeeded<T>(ref T arg)
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- public NUnit.Framework.Constraints.EqualConstraint Using(System.Collections.IComparer comparer)
- public NUnit.Framework.Constraints.EqualConstraint Using<T>(System.Collections.Generic.IComparer<T> comparer)
- public NUnit.Framework.Constraints.EqualConstraint Using<T>(System.Comparison<T> comparer)
- public NUnit.Framework.Constraints.EqualConstraint Using(System.Collections.IEqualityComparer comparer)
- public NUnit.Framework.Constraints.EqualConstraint Using<T>(System.Collections.Generic.IEqualityComparer<T> comparer)
- public NUnit.Framework.Constraints.EqualConstraint Within(object amount)

### public class NUnit.Framework.Constraints.EqualConstraintResult
- Base: NUnit.Framework.Constraints.ConstraintResult

#### Fields
- private bool caseInsensitive
- private bool clipStrings
- private static readonly string CollectionType_1
- private static readonly string CollectionType_2
- private object expectedValue
- private System.Collections.Generic.IList<NUnit.Framework.Constraints.NUnitEqualityComparer.FailurePoint> failurePoints
- private static readonly string StreamsDiffer_1
- private static readonly string StreamsDiffer_2
- private static readonly string StringsDiffer_1
- private static readonly string StringsDiffer_2
- private NUnit.Framework.Constraints.Tolerance tolerance
- private static readonly string ValuesDiffer_1
- private static readonly string ValuesDiffer_2

#### Constructors
- private static EqualConstraintResult()
- public EqualConstraintResult(NUnit.Framework.Constraints.EqualConstraint constraint, object actual, bool hasSucceeded)

#### Methods
- private void DisplayCollectionDifferences(NUnit.Framework.Constraints.MessageWriter writer, System.Collections.ICollection expected, System.Collections.ICollection actual, int depth)
- private void DisplayDifferences(NUnit.Framework.Constraints.MessageWriter writer, object expected, object actual, int depth)
- private void DisplayEnumerableDifferences(NUnit.Framework.Constraints.MessageWriter writer, System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, int depth)
- private void DisplayFailurePoint(NUnit.Framework.Constraints.MessageWriter writer, System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, NUnit.Framework.Constraints.NUnitEqualityComparer.FailurePoint failurePoint, int indent)
- private void DisplayStreamDifferences(NUnit.Framework.Constraints.MessageWriter writer, System.IO.Stream expected, System.IO.Stream actual, int depth)
- private void DisplayStringDifferences(NUnit.Framework.Constraints.MessageWriter writer, string expected, string actual)
- private void DisplayTypesAndSizes(NUnit.Framework.Constraints.MessageWriter writer, System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, int indent)
- private static object GetValueFromCollection(System.Collections.ICollection collection, int index)
- public override void WriteMessageTo(NUnit.Framework.Constraints.MessageWriter writer)

### public class NUnit.Framework.Constraints.EqualityAdapter

#### Constructors
- protected EqualityAdapter()

#### Methods
- public abstract bool AreEqual(object x, object y)
- public virtual bool CanCompare(object x, object y)
- public static NUnit.Framework.Constraints.EqualityAdapter For(System.Collections.IComparer comparer)
- public static NUnit.Framework.Constraints.EqualityAdapter For(System.Collections.IEqualityComparer comparer)
- public static NUnit.Framework.Constraints.EqualityAdapter For<TExpected, TActual>(System.Func<TExpected, TActual, bool> comparison)
- public static NUnit.Framework.Constraints.EqualityAdapter For<T>(System.Collections.Generic.IEqualityComparer<T> comparer)
- public static NUnit.Framework.Constraints.EqualityAdapter For<T>(System.Collections.Generic.IComparer<T> comparer)
- public static NUnit.Framework.Constraints.EqualityAdapter For<T>(System.Comparison<T> comparer)

### private class NUnit.Framework.Constraints.EqualityAdapter.EqualityComparerAdapter
- Base: NUnit.Framework.Constraints.EqualityAdapter

#### Fields
- private System.Collections.IEqualityComparer comparer

#### Constructors
- public EqualityAdapter.EqualityComparerAdapter(System.Collections.IEqualityComparer comparer)

#### Methods
- public override bool AreEqual(object x, object y)

### private class NUnit.Framework.Constraints.EqualityAdapter.EqualityComparerAdapter<T>
- Base: NUnit.Framework.Constraints.EqualityAdapter.GenericEqualityAdapter<T>

#### Fields
- private System.Collections.Generic.IEqualityComparer<T> comparer

#### Constructors
- public EqualityAdapter.EqualityComparerAdapter<T>(System.Collections.Generic.IEqualityComparer<T> comparer)

#### Methods
- public override bool AreEqual(object x, object y)

### public class NUnit.Framework.Constraints.ExactCountConstraint
- Base: NUnit.Framework.Constraints.PrefixConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private int expectedCount

#### Constructors
- public ExactCountConstraint(int expectedCount, NUnit.Framework.Constraints.IConstraint itemConstraint)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### public class NUnit.Framework.Constraints.ExactCountOperator
- Base: NUnit.Framework.Constraints.CollectionOperator

#### Fields
- private int expectedCount

#### Constructors
- public ExactCountOperator(int expectedCount)

#### Methods
- public override NUnit.Framework.Constraints.IConstraint ApplyPrefix(NUnit.Framework.Constraints.IConstraint constraint)

### public class NUnit.Framework.Constraints.ExactTypeConstraint
- Base: NUnit.Framework.Constraints.TypeConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string DisplayName { get; }

#### Constructors
- public ExactTypeConstraint(System.Type type)

#### Methods
- protected override bool Matches(object actual)

### internal class NUnit.Framework.Constraints.ThrowsConstraint.ExceptionInterceptor

#### Constructors
- private ThrowsConstraint.ExceptionInterceptor()

#### Methods
- private static NUnit.Framework.Constraints.ThrowsConstraint.IInvocationDescriptor GetInvocationDescriptor(object actual)
- internal static System.Exception Intercept(object invocation)

### internal class NUnit.Framework.Constraints.ExceptionNotThrownConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string Description { get; }

#### Constructors
- public ExceptionNotThrownConstraint()

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### public class NUnit.Framework.Constraints.ExceptionTypeConstraint
- Base: NUnit.Framework.Constraints.ExactTypeConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public ExceptionTypeConstraint(System.Type type)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### private class NUnit.Framework.Constraints.ExceptionTypeConstraint.ExceptionTypeConstraintResult
- Base: NUnit.Framework.Constraints.ConstraintResult

#### Fields
- private readonly object caughtException

#### Constructors
- public ExceptionTypeConstraint.ExceptionTypeConstraintResult(NUnit.Framework.Constraints.ExceptionTypeConstraint constraint, object caughtException, System.Type type, bool matches)

#### Methods
- public override void WriteActualValueTo(NUnit.Framework.Constraints.MessageWriter writer)

### public class NUnit.Framework.Constraints.NUnitEqualityComparer.FailurePoint

#### Fields
- public bool ActualHasData
- public object ActualValue
- public bool ExpectedHasData
- public object ExpectedValue
- public long Position

#### Constructors
- public NUnitEqualityComparer.FailurePoint()

### public class NUnit.Framework.Constraints.FalseConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public FalseConstraint()

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### public class NUnit.Framework.Constraints.FileExistsConstraint
- Base: NUnit.Framework.Constraints.FileOrDirectoryExistsConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string Description { get; }

#### Constructors
- public FileExistsConstraint()

### public class NUnit.Framework.Constraints.FileOrDirectoryExistsConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private bool _ignoreDirectories
- private bool _ignoreFiles

#### Properties
- public string Description { get; }
- private string ErrorSubstring { get; }
- public NUnit.Framework.Constraints.FileOrDirectoryExistsConstraint IgnoreDirectories { get; }
- public NUnit.Framework.Constraints.FileOrDirectoryExistsConstraint IgnoreFiles { get; }

#### Constructors
- public FileOrDirectoryExistsConstraint()
- public FileOrDirectoryExistsConstraint(bool ignoreDirectories)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- private NUnit.Framework.Constraints.ConstraintResult CheckString<TActual>(TActual actual)

### public class NUnit.Framework.Constraints.FloatingPointNumerics

#### Constructors
- private FloatingPointNumerics()

#### Methods
- public static bool AreAlmostEqualUlps(float left, float right, int maxUlps)
- public static bool AreAlmostEqualUlps(double left, double right, long maxUlps)
- public static double ReinterpretAsDouble(long value)
- public static float ReinterpretAsFloat(int value)
- public static int ReinterpretAsInt(float value)
- public static long ReinterpretAsLong(double value)

### private struct NUnit.Framework.Constraints.FloatingPointNumerics.FloatIntUnion

#### Fields
- public float Float
- public int Int
- public uint UInt

### private class NUnit.Framework.Constraints.EqualityAdapter.GenericEqualityAdapter<T>
- Base: NUnit.Framework.Constraints.EqualityAdapter

#### Constructors
- protected EqualityAdapter.GenericEqualityAdapter<T>()

#### Methods
- public override bool CanCompare(object x, object y)
- protected void ThrowIfNotCompatible(object x, object y)

### internal class NUnit.Framework.Constraints.ThrowsConstraint.GenericInvocationDescriptor<T>
- Interfaces: NUnit.Framework.Constraints.ThrowsConstraint.IInvocationDescriptor

#### Fields
- private readonly NUnit.Framework.Constraints.ActualValueDelegate<T> _del

#### Properties
- public System.Delegate Delegate { get; }

#### Constructors
- public ThrowsConstraint.GenericInvocationDescriptor<T>(NUnit.Framework.Constraints.ActualValueDelegate<T> del)

#### Methods
- public object Invoke()

### public class NUnit.Framework.Constraints.GreaterThanConstraint
- Base: NUnit.Framework.Constraints.ComparisonConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public GreaterThanConstraint(object expected)

### public class NUnit.Framework.Constraints.GreaterThanOrEqualConstraint
- Base: NUnit.Framework.Constraints.ComparisonConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public GreaterThanOrEqualConstraint(object expected)

### public interface NUnit.Framework.Constraints.IConstraint
- Interfaces: NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public object[] Arguments { get; }
- public NUnit.Framework.Constraints.ConstraintBuilder Builder { get; set; }
- public string Description { get; }
- public string DisplayName { get; }

#### Methods
- public NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- public NUnit.Framework.Constraints.ConstraintResult ApplyTo<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del)
- public NUnit.Framework.Constraints.ConstraintResult ApplyTo<TActual>(ref TActual actual)

### private interface NUnit.Framework.Constraints.ThrowsConstraint.IInvocationDescriptor

#### Properties
- public System.Delegate Delegate { get; }

#### Methods
- public object Invoke()

### public class NUnit.Framework.Constraints.InstanceOfTypeConstraint
- Base: NUnit.Framework.Constraints.TypeConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string DisplayName { get; }

#### Constructors
- public InstanceOfTypeConstraint(System.Type type)

#### Methods
- protected override bool Matches(object actual)

### public interface NUnit.Framework.Constraints.IResolveConstraint

#### Methods
- public NUnit.Framework.Constraints.IConstraint Resolve()

### public class NUnit.Framework.Constraints.LessThanConstraint
- Base: NUnit.Framework.Constraints.ComparisonConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public LessThanConstraint(object expected)

### public class NUnit.Framework.Constraints.LessThanOrEqualConstraint
- Base: NUnit.Framework.Constraints.ComparisonConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public LessThanOrEqualConstraint(object expected)

### public class NUnit.Framework.Constraints.MessageWriter
- Base: System.IO.StringWriter
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Properties
- public int MaxLineLength { get; set; }

#### Constructors
- protected MessageWriter()

#### Methods
- public abstract void DisplayDifferences(NUnit.Framework.Constraints.ConstraintResult result)
- public abstract void DisplayDifferences(object expected, object actual)
- public abstract void DisplayDifferences(object expected, object actual, NUnit.Framework.Constraints.Tolerance tolerance)
- public abstract void DisplayStringDifferences(string expected, string actual, int mismatch, bool ignoreCase, bool clipping)
- public abstract void WriteActualValue(object actual)
- public abstract void WriteCollectionElements(System.Collections.IEnumerable collection, long start, int max)
- public void WriteMessageLine(string message, params object[] args)
- public abstract void WriteMessageLine(int level, string message, params object[] args)
- public abstract void WriteValue(object val)

### internal static class NUnit.Framework.Constraints.MsgUtils

#### Fields
- private static NUnit.Framework.Constraints.ValueFormatter <DefaultValueFormatter>k__BackingField
- private static const string ELLIPSIS
- private static readonly string Fmt_Char
- private static readonly string Fmt_DateTime
- private static readonly string Fmt_DateTimeOffset
- private static readonly string Fmt_Default
- private static readonly string Fmt_EmptyCollection
- private static readonly string Fmt_EmptyString
- private static readonly string Fmt_Null
- private static readonly string Fmt_String
- private static readonly string Fmt_ValueType

#### Properties
- public static NUnit.Framework.Constraints.ValueFormatter DefaultValueFormatter { get; set; }

#### Constructors
- private static MsgUtils()

#### Methods
- public static void AddFormatter(NUnit.Framework.Constraints.ValueFormatterFactory formatterFactory)
- public static void ClipExpectedAndActual(ref string expected, ref string actual, int maxDisplayLength, int mismatch)
- public static string ClipString(string s, int maxStringLength, int clipStart)
- public static string EscapeControlChars(string s)
- public static string EscapeNullCharacters(string s)
- public static int FindMismatchPosition(string expected, string actual, int istart, bool ignoreCase)
- private static string FormatArray(System.Array array)
- public static string FormatCollection(System.Collections.IEnumerable collection, long start, int max)
- private static string FormatDateTime(System.DateTime dt)
- private static string FormatDateTimeOffset(System.DateTimeOffset dto)
- private static string FormatDecimal(decimal d)
- private static string FormatDouble(double d)
- private static string FormatFloat(float f)
- private static string FormatString(string s)
- public static string FormatValue(object val)
- public static string GetArrayIndicesAsString(int[] indices)
- public static int[] GetArrayIndicesFromCollectionIndex(System.Collections.IEnumerable collection, long index)
- public static string GetTypeRepresentation(object obj)

### public class NUnit.Framework.Constraints.NaNConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string Description { get; }

#### Constructors
- public NaNConstraint()

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### public class NUnit.Framework.Constraints.NoItemConstraint
- Base: NUnit.Framework.Constraints.PrefixConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string DisplayName { get; }

#### Constructors
- public NoItemConstraint(NUnit.Framework.Constraints.IConstraint itemConstraint)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### public class NUnit.Framework.Constraints.NoneOperator
- Base: NUnit.Framework.Constraints.CollectionOperator

#### Constructors
- public NoneOperator()

#### Methods
- public override NUnit.Framework.Constraints.IConstraint ApplyPrefix(NUnit.Framework.Constraints.IConstraint constraint)

### public class NUnit.Framework.Constraints.NotConstraint
- Base: NUnit.Framework.Constraints.PrefixConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public NotConstraint(NUnit.Framework.Constraints.IConstraint baseConstraint)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### public class NUnit.Framework.Constraints.NotOperator
- Base: NUnit.Framework.Constraints.PrefixOperator

#### Constructors
- public NotOperator()

#### Methods
- public override NUnit.Framework.Constraints.IConstraint ApplyPrefix(NUnit.Framework.Constraints.IConstraint constraint)

### public class NUnit.Framework.Constraints.NullConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public NullConstraint()

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### public class NUnit.Framework.Constraints.Numerics

#### Constructors
- private Numerics()

#### Methods
- public static bool AreEqual(object expected, object actual, ref NUnit.Framework.Constraints.Tolerance tolerance)
- private static bool AreEqual(double expected, double actual, ref NUnit.Framework.Constraints.Tolerance tolerance)
- private static bool AreEqual(float expected, float actual, ref NUnit.Framework.Constraints.Tolerance tolerance)
- private static bool AreEqual(decimal expected, decimal actual, NUnit.Framework.Constraints.Tolerance tolerance)
- private static bool AreEqual(ulong expected, ulong actual, NUnit.Framework.Constraints.Tolerance tolerance)
- private static bool AreEqual(long expected, long actual, NUnit.Framework.Constraints.Tolerance tolerance)
- private static bool AreEqual(uint expected, uint actual, NUnit.Framework.Constraints.Tolerance tolerance)
- private static bool AreEqual(int expected, int actual, NUnit.Framework.Constraints.Tolerance tolerance)
- public static int Compare(object expected, object actual)
- public static bool IsFixedPointNumeric(object obj)
- public static bool IsFloatingPointNumeric(object obj)
- public static bool IsNumericType(object obj)

### public class NUnit.Framework.Constraints.NUnitComparer
- Interfaces: System.Collections.IComparer

#### Properties
- public static NUnit.Framework.Constraints.NUnitComparer Default { get; }

#### Constructors
- public NUnitComparer()

#### Methods
- public int Compare(object x, object y)

### public class NUnit.Framework.Constraints.NUnitEqualityComparer

#### Fields
- private bool <WithSameOffset>k__BackingField
- private static readonly int BUFFER_SIZE
- private bool caseInsensitive
- private bool compareAsCollection
- private System.Collections.Generic.List<NUnit.Framework.Constraints.EqualityAdapter> externalComparers
- private System.Collections.Generic.List<NUnit.Framework.Constraints.NUnitEqualityComparer.FailurePoint> failurePoints
- private static readonly System.Type GameObjectType

#### Properties
- public bool CompareAsCollection { get; set; }
- public static NUnit.Framework.Constraints.NUnitEqualityComparer Default { get; }
- public System.Collections.Generic.IList<NUnit.Framework.Constraints.EqualityAdapter> ExternalComparers { get; }
- public System.Collections.Generic.IList<NUnit.Framework.Constraints.NUnitEqualityComparer.FailurePoint> FailurePoints { get; }
- public bool IgnoreCase { get; set; }
- public bool WithSameOffset { get; set; }

#### Constructors
- public NUnitEqualityComparer()
- private static NUnitEqualityComparer()

#### Methods
- public bool AreEqual(object x, object y, ref NUnit.Framework.Constraints.Tolerance tolerance)
- private bool ArraysEqual(System.Array x, System.Array y, ref NUnit.Framework.Constraints.Tolerance tolerance)
- private bool CharsEqual(char x, char y)
- internal static void CheckGameObjectReference<T>(ref T value)
- private bool CollectionsEqual(System.Collections.ICollection x, System.Collections.ICollection y, ref NUnit.Framework.Constraints.Tolerance tolerance)
- private bool DictionariesEqual(System.Collections.IDictionary x, System.Collections.IDictionary y, ref NUnit.Framework.Constraints.Tolerance tolerance)
- private bool DictionaryEntriesEqual(System.Collections.DictionaryEntry x, System.Collections.DictionaryEntry y, ref NUnit.Framework.Constraints.Tolerance tolerance)
- private static bool DirectoriesEqual(System.IO.DirectoryInfo x, System.IO.DirectoryInfo y)
- private bool EnumerablesEqual(System.Collections.IEnumerable x, System.Collections.IEnumerable y, ref NUnit.Framework.Constraints.Tolerance tolerance)
- private static System.Reflection.MethodInfo FirstImplementsIEquatableOfSecond(System.Type first, System.Type second)
- private static System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<System.Type, System.Reflection.MethodInfo>> GetEquatableGenericArguments(System.Type type)
- private NUnit.Framework.Constraints.EqualityAdapter GetExternalComparer(object x, object y)
- private static bool InvokeFirstIEquatableEqualsSecond(object first, object second, System.Reflection.MethodInfo equals)
- private bool StreamsEqual(System.IO.Stream x, System.IO.Stream y)
- private bool StringsEqual(string x, string y)

### public class NUnit.Framework.Constraints.ConstraintBuilder.OperatorStack

#### Fields
- private readonly System.Collections.Generic.Stack<NUnit.Framework.Constraints.ConstraintOperator> stack

#### Properties
- public bool Empty { get; }
- public NUnit.Framework.Constraints.ConstraintOperator Top { get; }

#### Constructors
- public ConstraintBuilder.OperatorStack(NUnit.Framework.Constraints.ConstraintBuilder builder)

#### Methods
- public NUnit.Framework.Constraints.ConstraintOperator Pop()
- public void Push(NUnit.Framework.Constraints.ConstraintOperator op)

### public class NUnit.Framework.Constraints.OrConstraint
- Base: NUnit.Framework.Constraints.BinaryConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string Description { get; }

#### Constructors
- public OrConstraint(NUnit.Framework.Constraints.IConstraint left, NUnit.Framework.Constraints.IConstraint right)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### private enum NUnit.Framework.Constraints.CollectionOrderedConstraint.OrderDirection
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Ascending = 1
- Descending = 2
- Unspecified = 0

### private class NUnit.Framework.Constraints.CollectionOrderedConstraint.OrderingStep

#### Fields
- private NUnit.Framework.Constraints.ComparisonAdapter <Comparer>k__BackingField
- private string <ComparerName>k__BackingField
- private NUnit.Framework.Constraints.CollectionOrderedConstraint.OrderDirection <Direction>k__BackingField
- private string <PropertyName>k__BackingField

#### Properties
- public NUnit.Framework.Constraints.ComparisonAdapter Comparer { get; set; }
- public string ComparerName { get; set; }
- public NUnit.Framework.Constraints.CollectionOrderedConstraint.OrderDirection Direction { get; set; }
- public string PropertyName { get; set; }

#### Constructors
- public CollectionOrderedConstraint.OrderingStep(string propertyName)

### public class NUnit.Framework.Constraints.OrOperator
- Base: NUnit.Framework.Constraints.BinaryOperator

#### Constructors
- public OrOperator()

#### Methods
- public override NUnit.Framework.Constraints.IConstraint ApplyOperator(NUnit.Framework.Constraints.IConstraint left, NUnit.Framework.Constraints.IConstraint right)

### public class NUnit.Framework.Constraints.PathConstraint
- Base: NUnit.Framework.Constraints.StringConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private static readonly char[] DirectorySeparatorChars
- private static const char NonWindowsDirectorySeparatorChar
- private static const char WindowsDirectorySeparatorChar

#### Properties
- public NUnit.Framework.Constraints.PathConstraint RespectCase { get; }

#### Constructors
- private static PathConstraint()
- protected PathConstraint(string expected)

#### Methods
- protected string Canonicalize(string path)
- protected override string GetStringRepresentation()
- protected bool IsSubPath(string path1, string path2)

### public class NUnit.Framework.Constraints.PredicateConstraint<T>
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private readonly System.Predicate<T> predicate

#### Properties
- public string Description { get; }

#### Constructors
- public PredicateConstraint<T>(System.Predicate<T> predicate)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### internal class NUnit.Framework.Constraints.EqualityAdapter.PredicateEqualityAdapter<TActual, TExpected>
- Base: NUnit.Framework.Constraints.EqualityAdapter

#### Fields
- private readonly System.Func<TActual, TExpected, bool> _comparison

#### Constructors
- public EqualityAdapter.PredicateEqualityAdapter<TActual, TExpected>(System.Func<TActual, TExpected, bool> comparison)

#### Methods
- public override bool AreEqual(object x, object y)
- public override bool CanCompare(object x, object y)

### public class NUnit.Framework.Constraints.PrefixConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private NUnit.Framework.Constraints.IConstraint <BaseConstraint>k__BackingField
- private string <DescriptionPrefix>k__BackingField

#### Properties
- protected NUnit.Framework.Constraints.IConstraint BaseConstraint { get; set; }
- public string Description { get; }
- protected string DescriptionPrefix { get; set; }

#### Constructors
- protected PrefixConstraint(NUnit.Framework.Constraints.IResolveConstraint baseConstraint)

### public class NUnit.Framework.Constraints.PrefixOperator
- Base: NUnit.Framework.Constraints.ConstraintOperator

#### Constructors
- protected PrefixOperator()

#### Methods
- public abstract NUnit.Framework.Constraints.IConstraint ApplyPrefix(NUnit.Framework.Constraints.IConstraint constraint)
- public override void Reduce(NUnit.Framework.Constraints.ConstraintBuilder.ConstraintStack stack)

### public class NUnit.Framework.Constraints.PropertyConstraint
- Base: NUnit.Framework.Constraints.PrefixConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private readonly string name
- private object propValue

#### Constructors
- public PropertyConstraint(string name, NUnit.Framework.Constraints.IConstraint baseConstraint)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- protected override string GetStringRepresentation()

### public class NUnit.Framework.Constraints.PropertyExistsConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private System.Type actualType
- private readonly string name

#### Properties
- public string Description { get; }

#### Constructors
- public PropertyExistsConstraint(string name)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- protected override string GetStringRepresentation()

### public class NUnit.Framework.Constraints.PropOperator
- Base: NUnit.Framework.Constraints.SelfResolvingOperator

#### Fields
- private readonly string name

#### Properties
- public string Name { get; }

#### Constructors
- public PropOperator(string name)

#### Methods
- public override void Reduce(NUnit.Framework.Constraints.ConstraintBuilder.ConstraintStack stack)

### public class NUnit.Framework.Constraints.RangeConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private NUnit.Framework.Constraints.ComparisonAdapter comparer
- private readonly System.IComparable from
- private readonly System.IComparable to

#### Properties
- public string Description { get; }

#### Constructors
- public RangeConstraint(System.IComparable from, System.IComparable to)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- public NUnit.Framework.Constraints.RangeConstraint Using(System.Collections.IComparer comparer)
- public NUnit.Framework.Constraints.RangeConstraint Using<T>(System.Collections.Generic.IComparer<T> comparer)
- public NUnit.Framework.Constraints.RangeConstraint Using<T>(System.Comparison<T> comparer)

### public class NUnit.Framework.Constraints.RegexConstraint
- Base: NUnit.Framework.Constraints.StringConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public RegexConstraint(string pattern)

#### Methods
- protected override bool Matches(string actual)

### public class NUnit.Framework.Constraints.ResolvableConstraintExpression
- Base: NUnit.Framework.Constraints.ConstraintExpression
- Interfaces: NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public NUnit.Framework.Constraints.ConstraintExpression And { get; }
- public NUnit.Framework.Constraints.ConstraintExpression Or { get; }

#### Constructors
- public ResolvableConstraintExpression()
- public ResolvableConstraintExpression(NUnit.Framework.Constraints.ConstraintBuilder builder)

#### Methods
- private NUnit.Framework.Constraints.IConstraint NUnit.Framework.Constraints.IResolveConstraint.Resolve()

### public class NUnit.Framework.Constraints.ReusableConstraint
- Interfaces: NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private readonly NUnit.Framework.Constraints.IConstraint constraint

#### Constructors
- public ReusableConstraint(NUnit.Framework.Constraints.IResolveConstraint c)

#### Methods
- public static NUnit.Framework.Constraints.ReusableConstraint op_Implicit(NUnit.Framework.Constraints.Constraint c)
- public NUnit.Framework.Constraints.IConstraint Resolve()
- public override string ToString()

### public class NUnit.Framework.Constraints.SameAsConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private readonly object expected

#### Properties
- public string Description { get; }

#### Constructors
- public SameAsConstraint(object expected)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### public class NUnit.Framework.Constraints.SamePathConstraint
- Base: NUnit.Framework.Constraints.PathConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string Description { get; }

#### Constructors
- public SamePathConstraint(string expected)

#### Methods
- protected override bool Matches(string actual)

### public class NUnit.Framework.Constraints.SamePathOrUnderConstraint
- Base: NUnit.Framework.Constraints.PathConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string Description { get; }

#### Constructors
- public SamePathOrUnderConstraint(string expected)

#### Methods
- protected override bool Matches(string actual)

### public class NUnit.Framework.Constraints.SelfResolvingOperator
- Base: NUnit.Framework.Constraints.ConstraintOperator

#### Constructors
- protected SelfResolvingOperator()

### public class NUnit.Framework.Constraints.SomeItemsConstraint
- Base: NUnit.Framework.Constraints.PrefixConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string DisplayName { get; }

#### Constructors
- public SomeItemsConstraint(NUnit.Framework.Constraints.IConstraint itemConstraint)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### public class NUnit.Framework.Constraints.SomeOperator
- Base: NUnit.Framework.Constraints.CollectionOperator

#### Constructors
- public SomeOperator()

#### Methods
- public override NUnit.Framework.Constraints.IConstraint ApplyPrefix(NUnit.Framework.Constraints.IConstraint constraint)

### public class NUnit.Framework.Constraints.StartsWithConstraint
- Base: NUnit.Framework.Constraints.StringConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public StartsWithConstraint(string expected)

#### Methods
- protected override bool Matches(string actual)

### public class NUnit.Framework.Constraints.StringConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- protected bool caseInsensitive
- protected string descriptionText
- protected string expected

#### Properties
- public string Description { get; }
- public NUnit.Framework.Constraints.StringConstraint IgnoreCase { get; }

#### Constructors
- protected StringConstraint()
- protected StringConstraint(string expected)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- protected abstract bool Matches(string actual)

### public class NUnit.Framework.Constraints.SubPathConstraint
- Base: NUnit.Framework.Constraints.PathConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string Description { get; }

#### Constructors
- public SubPathConstraint(string expected)

#### Methods
- protected override bool Matches(string actual)

### public class NUnit.Framework.Constraints.SubstringConstraint
- Base: NUnit.Framework.Constraints.StringConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public SubstringConstraint(string expected)

#### Methods
- protected override bool Matches(string actual)

### public class NUnit.Framework.Constraints.ThrowsConstraint
- Base: NUnit.Framework.Constraints.PrefixConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private System.Exception caughtException

#### Properties
- public System.Exception ActualException { get; }
- public string Description { get; }

#### Constructors
- public ThrowsConstraint(NUnit.Framework.Constraints.IConstraint baseConstraint)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del)

### private class NUnit.Framework.Constraints.ThrowsConstraint.ThrowsConstraintResult
- Base: NUnit.Framework.Constraints.ConstraintResult

#### Fields
- private readonly NUnit.Framework.Constraints.ConstraintResult baseResult

#### Constructors
- public ThrowsConstraint.ThrowsConstraintResult(NUnit.Framework.Constraints.ThrowsConstraint constraint, System.Exception caughtException, NUnit.Framework.Constraints.ConstraintResult baseResult)

#### Methods
- public override void WriteActualValueTo(NUnit.Framework.Constraints.MessageWriter writer)

### public class NUnit.Framework.Constraints.ThrowsExceptionConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string Description { get; }

#### Constructors
- public ThrowsExceptionConstraint()

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- protected override object GetTestObject<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del)

### private class NUnit.Framework.Constraints.ThrowsExceptionConstraint.ThrowsExceptionConstraintResult
- Base: NUnit.Framework.Constraints.ConstraintResult

#### Constructors
- public ThrowsExceptionConstraint.ThrowsExceptionConstraintResult(NUnit.Framework.Constraints.ThrowsExceptionConstraint constraint, System.Exception caughtException)

#### Methods
- public override void WriteActualValueTo(NUnit.Framework.Constraints.MessageWriter writer)

### public class NUnit.Framework.Constraints.ThrowsNothingConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private System.Exception caughtException

#### Properties
- public string Description { get; }

#### Constructors
- public ThrowsNothingConstraint()

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del)

### public class NUnit.Framework.Constraints.ThrowsOperator
- Base: NUnit.Framework.Constraints.SelfResolvingOperator

#### Constructors
- public ThrowsOperator()

#### Methods
- public override void Reduce(NUnit.Framework.Constraints.ConstraintBuilder.ConstraintStack stack)

### public class NUnit.Framework.Constraints.Tolerance

#### Fields
- private readonly object amount
- private readonly NUnit.Framework.Constraints.ToleranceMode mode
- private static const string ModeMustFollowTolerance
- private static const string MultipleToleranceModes
- private static const string NumericToleranceRequired

#### Properties
- public NUnit.Framework.Constraints.Tolerance Days { get; }
- public static NUnit.Framework.Constraints.Tolerance Default { get; }
- public static NUnit.Framework.Constraints.Tolerance Exact { get; }
- public NUnit.Framework.Constraints.Tolerance Hours { get; }
- public bool IsUnsetOrDefault { get; }
- public NUnit.Framework.Constraints.Tolerance Milliseconds { get; }
- public NUnit.Framework.Constraints.Tolerance Minutes { get; }
- public NUnit.Framework.Constraints.ToleranceMode Mode { get; }
- public NUnit.Framework.Constraints.Tolerance Percent { get; }
- public NUnit.Framework.Constraints.Tolerance Seconds { get; }
- public NUnit.Framework.Constraints.Tolerance Ticks { get; }
- public NUnit.Framework.Constraints.Tolerance Ulps { get; }
- public object Value { get; }

#### Constructors
- public Tolerance(object amount)
- private Tolerance(object amount, NUnit.Framework.Constraints.ToleranceMode mode)

#### Methods
- private void CheckLinearAndNumeric()

### public enum NUnit.Framework.Constraints.ToleranceMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Linear = 1
- Percent = 2
- Ulps = 3
- Unset = 0

### public class NUnit.Framework.Constraints.TrueConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Constructors
- public TrueConstraint()

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)

### public class NUnit.Framework.Constraints.TypeConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- protected System.Type actualType
- protected System.Type expectedType

#### Constructors
- protected TypeConstraint(System.Type type, string descriptionPrefix)

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- protected abstract bool Matches(object actual)

### public class NUnit.Framework.Constraints.UniqueItemsConstraint
- Base: NUnit.Framework.Constraints.CollectionItemsEqualConstraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Properties
- public string Description { get; }

#### Constructors
- public UniqueItemsConstraint()

#### Methods
- protected override bool Matches(System.Collections.IEnumerable actual)

### public delegate NUnit.Framework.Constraints.ValueFormatter
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ValueFormatter(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(object val, System.AsyncCallback callback, object object)
- public virtual string EndInvoke(System.IAsyncResult result)
- public virtual string Invoke(object val)

### public delegate NUnit.Framework.Constraints.ValueFormatterFactory
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ValueFormatterFactory(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(NUnit.Framework.Constraints.ValueFormatter next, System.AsyncCallback callback, object object)
- public virtual NUnit.Framework.Constraints.ValueFormatter EndInvoke(System.IAsyncResult result)
- public virtual NUnit.Framework.Constraints.ValueFormatter Invoke(NUnit.Framework.Constraints.ValueFormatter next)

### private class NUnit.Framework.Constraints.ThrowsConstraint.VoidInvocationDescriptor
- Interfaces: NUnit.Framework.Constraints.ThrowsConstraint.IInvocationDescriptor

#### Fields
- private readonly NUnit.Framework.TestDelegate _del

#### Properties
- public System.Delegate Delegate { get; }

#### Constructors
- public ThrowsConstraint.VoidInvocationDescriptor(NUnit.Framework.TestDelegate del)

#### Methods
- public object Invoke()

### public class NUnit.Framework.Constraints.WithOperator
- Base: NUnit.Framework.Constraints.PrefixOperator

#### Constructors
- public WithOperator()

#### Methods
- public override NUnit.Framework.Constraints.IConstraint ApplyPrefix(NUnit.Framework.Constraints.IConstraint constraint)

### public class NUnit.Framework.Constraints.XmlSerializableConstraint
- Base: NUnit.Framework.Constraints.Constraint
- Interfaces: NUnit.Framework.Constraints.IConstraint, NUnit.Framework.Constraints.IResolveConstraint

#### Fields
- private System.Xml.Serialization.XmlSerializer serializer

#### Properties
- public string Description { get; }

#### Constructors
- public XmlSerializableConstraint()

#### Methods
- public override NUnit.Framework.Constraints.ConstraintResult ApplyTo(object actual)
- protected override string GetStringRepresentation()

## Namespace: NUnit.Framework.Interfaces

### private class NUnit.Framework.Interfaces.TNode.<>c

#### Fields
- public static readonly NUnit.Framework.Interfaces.TNode.<>c <>9
- public static System.Text.RegularExpressions.MatchEvaluator <>9__38_0

#### Constructors
- private static TNode.<>c()
- public TNode.<>c()

#### Methods
- internal string <EscapeInvalidXmlCharacters>b__38_0(System.Text.RegularExpressions.Match match)

### public class NUnit.Framework.Interfaces.AttributeDictionary
- Base: System.Collections.Generic.Dictionary<string, string>
- Interfaces: System.Collections.Generic.IDictionary<string, string>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary<string, string>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<string, string>>, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback

#### Properties
- public string Item { get; }

#### Constructors
- public AttributeDictionary()

### public enum NUnit.Framework.Interfaces.FailureSite
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Child = 4
- Parent = 3
- SetUp = 1
- TearDown = 2
- Test = 0

### public interface NUnit.Framework.Interfaces.IApplyToContext

#### Methods
- public void ApplyToContext(NUnit.Framework.Internal.ITestExecutionContext context)

### public interface NUnit.Framework.Interfaces.IApplyToTest

#### Methods
- public void ApplyToTest(NUnit.Framework.Internal.Test test)

### public interface NUnit.Framework.Interfaces.ICombiningStrategy

#### Methods
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Interfaces.ITestCaseData> GetTestCases(System.Collections.IEnumerable[] sources)

### public interface NUnit.Framework.Interfaces.ICommandWrapper

#### Methods
- public NUnit.Framework.Internal.Commands.TestCommand Wrap(NUnit.Framework.Internal.Commands.TestCommand command)

### internal interface NUnit.Framework.Interfaces.IDisposableFixture

### public interface NUnit.Framework.Interfaces.IFixtureBuilder

#### Methods
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestSuite> BuildFrom(NUnit.Framework.Interfaces.ITypeInfo typeInfo)

### public interface NUnit.Framework.Interfaces.IImplyFixture

### public interface NUnit.Framework.Interfaces.IMethodInfo
- Interfaces: NUnit.Framework.Interfaces.IReflectionInfo

#### Properties
- public bool ContainsGenericParameters { get; }
- public bool IsAbstract { get; }
- public bool IsGenericMethod { get; }
- public bool IsGenericMethodDefinition { get; }
- public bool IsPublic { get; }
- public System.Reflection.MethodInfo MethodInfo { get; }
- public string Name { get; }
- public NUnit.Framework.Interfaces.ITypeInfo ReturnType { get; }
- public NUnit.Framework.Interfaces.ITypeInfo TypeInfo { get; }

#### Methods
- public System.Type[] GetGenericArguments()
- public NUnit.Framework.Interfaces.IParameterInfo[] GetParameters()
- public object Invoke(object fixture, params object[] args)
- public NUnit.Framework.Interfaces.IMethodInfo MakeGenericMethod(params System.Type[] typeArguments)

### public interface NUnit.Framework.Interfaces.IParameterDataProvider

#### Methods
- public System.Collections.IEnumerable GetDataFor(NUnit.Framework.Interfaces.IParameterInfo parameter)
- public bool HasDataFor(NUnit.Framework.Interfaces.IParameterInfo parameter)

### public interface NUnit.Framework.Interfaces.IParameterDataSource

#### Methods
- public System.Collections.IEnumerable GetData(NUnit.Framework.Interfaces.IParameterInfo parameter)

### public interface NUnit.Framework.Interfaces.IParameterInfo
- Interfaces: NUnit.Framework.Interfaces.IReflectionInfo

#### Properties
- public bool IsOptional { get; }
- public NUnit.Framework.Interfaces.IMethodInfo Method { get; }
- public System.Reflection.ParameterInfo ParameterInfo { get; }
- public System.Type ParameterType { get; }

### public interface NUnit.Framework.Interfaces.IPropertyBag
- Interfaces: NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Properties
- public System.Collections.IList Item { get; set; }
- public System.Collections.Generic.ICollection<string> Keys { get; }

#### Methods
- public void Add(string key, object value)
- public bool ContainsKey(string key)
- public object Get(string key)
- public void Set(string key, object value)

### public interface NUnit.Framework.Interfaces.IReflectionInfo

#### Methods
- public T[] GetCustomAttributes<T>(bool inherit)
- public bool IsDefined<T>(bool inherit)

### public interface NUnit.Framework.Interfaces.ISimpleTestBuilder

#### Methods
- public NUnit.Framework.Internal.TestMethod BuildFrom(NUnit.Framework.Interfaces.IMethodInfo method, NUnit.Framework.Internal.Test suite)

### public interface NUnit.Framework.Interfaces.ISuiteBuilder

#### Methods
- public NUnit.Framework.Internal.TestSuite BuildFrom(NUnit.Framework.Interfaces.ITypeInfo typeInfo)
- public bool CanBuildFrom(NUnit.Framework.Interfaces.ITypeInfo typeInfo)

### public interface NUnit.Framework.Interfaces.ITest
- Interfaces: NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Properties
- public string ClassName { get; }
- public object Fixture { get; }
- public string FullName { get; }
- public bool HasChildren { get; }
- public string Id { get; }
- public bool IsSuite { get; }
- public NUnit.Framework.Interfaces.IMethodInfo Method { get; }
- public string MethodName { get; }
- public string Name { get; }
- public NUnit.Framework.Interfaces.ITest Parent { get; }
- public NUnit.Framework.Interfaces.IPropertyBag Properties { get; }
- public NUnit.Framework.Interfaces.RunState RunState { get; }
- public int TestCaseCount { get; }
- public System.Collections.Generic.IList<NUnit.Framework.Interfaces.ITest> Tests { get; }
- public NUnit.Framework.Interfaces.ITypeInfo TypeInfo { get; }

### public interface NUnit.Framework.Interfaces.ITestBuilder

#### Methods
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestMethod> BuildFrom(NUnit.Framework.Interfaces.IMethodInfo method, NUnit.Framework.Internal.Test suite)

### public interface NUnit.Framework.Interfaces.ITestCaseBuilder

#### Methods
- public NUnit.Framework.Internal.Test BuildFrom(NUnit.Framework.Interfaces.IMethodInfo method, NUnit.Framework.Internal.Test suite)
- public bool CanBuildFrom(NUnit.Framework.Interfaces.IMethodInfo method, NUnit.Framework.Internal.Test suite)

### public interface NUnit.Framework.Interfaces.ITestCaseData
- Interfaces: NUnit.Framework.Interfaces.ITestData

#### Properties
- public object ExpectedResult { get; }
- public bool HasExpectedResult { get; }

### public interface NUnit.Framework.Interfaces.ITestData

#### Properties
- public object[] Arguments { get; }
- public NUnit.Framework.Interfaces.IPropertyBag Properties { get; }
- public NUnit.Framework.Interfaces.RunState RunState { get; }
- public string TestName { get; }

### public interface NUnit.Framework.Interfaces.ITestFilter
- Interfaces: NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Methods
- public bool IsExplicitMatch(NUnit.Framework.Interfaces.ITest test)
- public bool Pass(NUnit.Framework.Interfaces.ITest test)

### public interface NUnit.Framework.Interfaces.ITestFixtureData
- Interfaces: NUnit.Framework.Interfaces.ITestData

#### Properties
- public System.Type[] TypeArgs { get; }

### public interface NUnit.Framework.Interfaces.ITestListener

#### Methods
- public void TestFinished(NUnit.Framework.Interfaces.ITestResult result)
- public void TestOutput(NUnit.Framework.Interfaces.TestOutput output)
- public void TestStarted(NUnit.Framework.Interfaces.ITest test)

### public interface NUnit.Framework.Interfaces.ITestResult
- Interfaces: NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Properties
- public int AssertCount { get; }
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Interfaces.ITestResult> Children { get; }
- public double Duration { get; }
- public System.DateTime EndTime { get; }
- public int FailCount { get; }
- public string FullName { get; }
- public bool HasChildren { get; }
- public int InconclusiveCount { get; }
- public string Message { get; }
- public string Name { get; }
- public string Output { get; }
- public int PassCount { get; }
- public NUnit.Framework.Interfaces.ResultState ResultState { get; }
- public int SkipCount { get; }
- public string StackTrace { get; }
- public System.DateTime StartTime { get; }
- public NUnit.Framework.Interfaces.ITest Test { get; }

### public interface NUnit.Framework.Interfaces.ITypeInfo
- Interfaces: NUnit.Framework.Interfaces.IReflectionInfo

#### Properties
- public System.Reflection.Assembly Assembly { get; }
- public NUnit.Framework.Interfaces.ITypeInfo BaseType { get; }
- public bool ContainsGenericParameters { get; }
- public string FullName { get; }
- public bool IsAbstract { get; }
- public bool IsGenericType { get; }
- public bool IsGenericTypeDefinition { get; }
- public bool IsSealed { get; }
- public bool IsStaticClass { get; }
- public string Name { get; }
- public string Namespace { get; }
- public System.Type Type { get; }

#### Methods
- public object Construct(object[] args)
- public System.Reflection.ConstructorInfo GetConstructor(System.Type[] argTypes)
- public string GetDisplayName()
- public string GetDisplayName(object[] args)
- public System.Type GetGenericTypeDefinition()
- public NUnit.Framework.Interfaces.IMethodInfo[] GetMethods(System.Reflection.BindingFlags flags)
- public bool HasConstructor(System.Type[] argTypes)
- public bool HasMethodWithAttribute(System.Type attrType)
- public bool IsType(System.Type type)
- public NUnit.Framework.Interfaces.ITypeInfo MakeGenericType(System.Type[] typeArgs)

### public interface NUnit.Framework.Interfaces.IWrapSetUpTearDown
- Interfaces: NUnit.Framework.Interfaces.ICommandWrapper

### public interface NUnit.Framework.Interfaces.IWrapTestMethod
- Interfaces: NUnit.Framework.Interfaces.ICommandWrapper

### public interface NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Methods
- public NUnit.Framework.Interfaces.TNode AddToXml(NUnit.Framework.Interfaces.TNode parentNode, bool recursive)
- public NUnit.Framework.Interfaces.TNode ToXml(bool recursive)

### private class NUnit.Framework.Interfaces.TNode.NodeFilter

#### Fields
- private string _nodeName
- private string _propName
- private string _propValue

#### Constructors
- public TNode.NodeFilter(string xpath)

#### Methods
- public bool Pass(NUnit.Framework.Interfaces.TNode node)

### public class NUnit.Framework.Interfaces.NodeList
- Base: System.Collections.Generic.List<NUnit.Framework.Interfaces.TNode>
- Interfaces: System.Collections.Generic.IList<NUnit.Framework.Interfaces.TNode>, System.Collections.Generic.ICollection<NUnit.Framework.Interfaces.TNode>, System.Collections.Generic.IEnumerable<NUnit.Framework.Interfaces.TNode>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList<NUnit.Framework.Interfaces.TNode>, System.Collections.Generic.IReadOnlyCollection<NUnit.Framework.Interfaces.TNode>

#### Constructors
- public NodeList()

### public class NUnit.Framework.Interfaces.ResultState

#### Fields
- private string <Label>k__BackingField
- private NUnit.Framework.Interfaces.FailureSite <Site>k__BackingField
- private NUnit.Framework.Interfaces.TestStatus <Status>k__BackingField
- public static readonly NUnit.Framework.Interfaces.ResultState Cancelled
- public static readonly NUnit.Framework.Interfaces.ResultState ChildFailure
- public static readonly NUnit.Framework.Interfaces.ResultState Error
- public static readonly NUnit.Framework.Interfaces.ResultState Explicit
- public static readonly NUnit.Framework.Interfaces.ResultState Failure
- public static readonly NUnit.Framework.Interfaces.ResultState Ignored
- public static readonly NUnit.Framework.Interfaces.ResultState Inconclusive
- public static readonly NUnit.Framework.Interfaces.ResultState NotRunnable
- public static readonly NUnit.Framework.Interfaces.ResultState SetUpError
- public static readonly NUnit.Framework.Interfaces.ResultState SetUpFailure
- public static readonly NUnit.Framework.Interfaces.ResultState Skipped
- public static readonly NUnit.Framework.Interfaces.ResultState Success
- public static readonly NUnit.Framework.Interfaces.ResultState TearDownError

#### Properties
- public string Label { get; private set; }
- public NUnit.Framework.Interfaces.FailureSite Site { get; private set; }
- public NUnit.Framework.Interfaces.TestStatus Status { get; private set; }

#### Constructors
- private static ResultState()
- public ResultState(NUnit.Framework.Interfaces.TestStatus status)
- public ResultState(NUnit.Framework.Interfaces.TestStatus status, string label)
- public ResultState(NUnit.Framework.Interfaces.TestStatus status, NUnit.Framework.Interfaces.FailureSite site)
- public ResultState(NUnit.Framework.Interfaces.TestStatus status, string label, NUnit.Framework.Interfaces.FailureSite site)

#### Methods
- public override bool Equals(object obj)
- public override int GetHashCode()
- public override string ToString()
- public NUnit.Framework.Interfaces.ResultState WithSite(NUnit.Framework.Interfaces.FailureSite site)

### public enum NUnit.Framework.Interfaces.RunState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Explicit = 2
- Ignored = 4
- NotRunnable = 0
- Runnable = 1
- Skipped = 3

### public class NUnit.Framework.Interfaces.TestOutput

#### Fields
- private string <Stream>k__BackingField
- private string <TestName>k__BackingField
- private string <Text>k__BackingField

#### Properties
- public string Stream { get; private set; }
- public string TestName { get; private set; }
- public string Text { get; private set; }

#### Constructors
- public TestOutput(string text, string stream, string testName)

#### Methods
- public override string ToString()
- public string ToXml()

### public enum NUnit.Framework.Interfaces.TestStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Failed = 3
- Inconclusive = 0
- Passed = 2
- Skipped = 1

### public class NUnit.Framework.Interfaces.TNode

#### Fields
- private NUnit.Framework.Interfaces.AttributeDictionary <Attributes>k__BackingField
- private NUnit.Framework.Interfaces.NodeList <ChildNodes>k__BackingField
- private string <Name>k__BackingField
- private string <Value>k__BackingField
- private bool <ValueIsCDATA>k__BackingField
- private static readonly System.Text.RegularExpressions.Regex InvalidXmlCharactersRegex

#### Properties
- public NUnit.Framework.Interfaces.AttributeDictionary Attributes { get; private set; }
- public NUnit.Framework.Interfaces.NodeList ChildNodes { get; private set; }
- public NUnit.Framework.Interfaces.TNode FirstChild { get; }
- public string Name { get; private set; }
- public string OuterXml { get; }
- public string Value { get; set; }
- public bool ValueIsCDATA { get; private set; }

#### Constructors
- private static TNode()
- public TNode(string name)
- public TNode(string name, string value)
- public TNode(string name, string value, bool valueIsCDATA)

#### Methods
- public void AddAttribute(string name, string value)
- public NUnit.Framework.Interfaces.TNode AddElement(string name)
- public NUnit.Framework.Interfaces.TNode AddElement(string name, string value)
- public NUnit.Framework.Interfaces.TNode AddElementWithCDATA(string name, string value)
- private static NUnit.Framework.Interfaces.NodeList ApplySelection(NUnit.Framework.Interfaces.NodeList nodeList, string xpath)
- private static string CharToUnicodeSequence(char symbol)
- private static string EscapeInvalidXmlCharacters(string str)
- public static NUnit.Framework.Interfaces.TNode FromXml(string xmlText)
- private static NUnit.Framework.Interfaces.TNode FromXml(System.Xml.XmlNode xmlNode)
- public NUnit.Framework.Interfaces.NodeList SelectNodes(string xpath)
- public NUnit.Framework.Interfaces.TNode SelectSingleNode(string xpath)
- private void WriteCDataTo(System.Xml.XmlWriter writer)
- public void WriteTo(System.Xml.XmlWriter writer)

## Namespace: NUnit.Framework.Internal

### private class NUnit.Framework.Internal.ExceptionHelper.<>c

#### Fields
- public static readonly NUnit.Framework.Internal.ExceptionHelper.<>c <>9

#### Constructors
- private static ExceptionHelper.<>c()
- public ExceptionHelper.<>c()

#### Methods
- internal void <.cctor>b__1_0(System.Exception _)

### private class NUnit.Framework.Internal.OSPlatform.<>c

#### Fields
- public static readonly NUnit.Framework.Internal.OSPlatform.<>c <>9

#### Constructors
- private static OSPlatform.<>c()
- public OSPlatform.<>c()

#### Methods
- internal NUnit.Framework.Internal.OSPlatform <.cctor>b__92_0()

### private class NUnit.Framework.Internal.RuntimeFramework.<>c

#### Fields
- public static readonly NUnit.Framework.Internal.RuntimeFramework.<>c <>9

#### Constructors
- private static RuntimeFramework.<>c()
- public RuntimeFramework.<>c()

#### Methods
- internal NUnit.Framework.Internal.RuntimeFramework <.cctor>b__32_0()

### private class NUnit.Framework.Internal.TestExecutionContext.<>c

#### Fields
- public static readonly NUnit.Framework.Internal.TestExecutionContext.<>c <>9
- public static NUnit.Framework.Constraints.ValueFormatter <>9__9_0

#### Constructors
- private static TestExecutionContext.<>c()
- public TestExecutionContext.<>c()

#### Methods
- internal string <.ctor>b__9_0(object val)

### private class NUnit.Framework.Internal.RuntimeFramework.<>c__DisplayClass29_0

#### Fields
- public string name

#### Constructors
- public RuntimeFramework.<>c__DisplayClass29_0()

#### Methods
- internal bool <IsRuntimeTypeName>b__0(string item)

### private class NUnit.Framework.Internal.TypeWrapper.<>c__DisplayClass36_0

#### Fields
- public System.Type[] argTypes

#### Constructors
- public TypeWrapper.<>c__DisplayClass36_0()

#### Methods
- internal bool <GetConstructor>b__0(System.Reflection.ConstructorInfo c)

### private class NUnit.Framework.Internal.Reflect.<>c__DisplayClass9_0

#### Fields
- public object[] args
- public object fixture
- public System.Reflection.MethodInfo method

#### Constructors
- public Reflect.<>c__DisplayClass9_0()

#### Methods
- internal object <InvokeMethod>b__0()

### private enum NUnit.Framework.Internal.ActionsHelper.ActionPhase
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- After = 1
- Before = 0

### public class NUnit.Framework.Internal.ActionsHelper

#### Constructors
- public ActionsHelper()

#### Methods
- private static void ExecuteActions(NUnit.Framework.Internal.ActionsHelper.ActionPhase phase, System.Collections.Generic.IEnumerable<NUnit.Framework.ITestAction> actions, NUnit.Framework.Interfaces.ITest test)
- public static void ExecuteAfterActions(System.Collections.Generic.IEnumerable<NUnit.Framework.ITestAction> actions, NUnit.Framework.Interfaces.ITest test)
- public static void ExecuteBeforeActions(System.Collections.Generic.IEnumerable<NUnit.Framework.ITestAction> actions, NUnit.Framework.Interfaces.ITest test)
- public static NUnit.Framework.ITestAction[] GetActionsFromAttributeProvider(System.Reflection.ICustomAttributeProvider attributeProvider)
- public static NUnit.Framework.ITestAction[] GetActionsFromTestAssembly(NUnit.Framework.Internal.TestAssembly testAssembly)
- public static NUnit.Framework.ITestAction[] GetActionsFromTestMethodInfo(NUnit.Framework.Interfaces.IMethodInfo testAssembly)
- public static NUnit.Framework.ITestAction[] GetActionsFromTypesAttributes(System.Type type)
- private static System.Type[] GetDeclaredInterfaces(System.Type type)
- private static NUnit.Framework.ITestAction[] GetFilteredAndSortedActions(System.Collections.Generic.IEnumerable<NUnit.Framework.ITestAction> actions, NUnit.Framework.Internal.ActionsHelper.ActionPhase phase)
- private static int SortByTargetDescending(NUnit.Framework.ITestAction x, NUnit.Framework.ITestAction y)

### private class NUnit.Framework.Internal.TestNameGenerator.ArgListFragment
- Base: NUnit.Framework.Internal.TestNameGenerator.NameFragment

#### Fields
- private int _maxStringLength

#### Constructors
- public TestNameGenerator.ArgListFragment(int maxStringLength)

#### Methods
- public override string GetText(System.Reflection.MethodInfo method, object[] arglist)

### private class NUnit.Framework.Internal.TestNameGenerator.ArgumentFragment
- Base: NUnit.Framework.Internal.TestNameGenerator.NameFragment

#### Fields
- private int _index
- private int _maxStringLength

#### Constructors
- public TestNameGenerator.ArgumentFragment(int index, int maxStringLength)

#### Methods
- public override string GetText(System.Reflection.MethodInfo method, object[] args)

### public static class NUnit.Framework.Internal.AssemblyHelper

#### Methods
- public static System.Reflection.AssemblyName GetAssemblyName(System.Reflection.Assembly assembly)
- public static string GetAssemblyPath(System.Reflection.Assembly assembly)
- public static string GetAssemblyPathFromCodeBase(string codeBase)
- public static string GetDirectoryName(System.Reflection.Assembly assembly)
- private static bool IsFileUri(string uri)
- public static System.Reflection.Assembly Load(string nameOrPath)

### private class NUnit.Framework.Internal.Reflect.BaseTypesFirstComparer
- Interfaces: System.Collections.Generic.IComparer<System.Reflection.MethodInfo>

#### Constructors
- public Reflect.BaseTypesFirstComparer()

#### Methods
- public int Compare(System.Reflection.MethodInfo m1, System.Reflection.MethodInfo m2)

### private class NUnit.Framework.Internal.TestNameGenerator.ClassFullNameFragment
- Base: NUnit.Framework.Internal.TestNameGenerator.NameFragment

#### Constructors
- public TestNameGenerator.ClassFullNameFragment()

#### Methods
- public override string GetText(System.Reflection.MethodInfo method, object[] args)

### private class NUnit.Framework.Internal.TestNameGenerator.ClassNameFragment
- Base: NUnit.Framework.Internal.TestNameGenerator.NameFragment

#### Constructors
- public TestNameGenerator.ClassNameFragment()

#### Methods
- public override string GetText(System.Reflection.MethodInfo method, object[] args)

### public class NUnit.Framework.Internal.CultureDetector

#### Fields
- private System.Globalization.CultureInfo currentCulture
- private string reason

#### Properties
- public string Reason { get; }

#### Constructors
- public CultureDetector()
- public CultureDetector(string culture)

#### Methods
- public bool IsCultureSupported(string[] cultures)
- public bool IsCultureSupported(NUnit.Framework.CultureAttribute cultureAttribute)
- public bool IsCultureSupported(string culture)

### private class NUnit.Framework.Internal.TestFilter.EmptyFilter
- Base: NUnit.Framework.Internal.TestFilter
- Interfaces: NUnit.Framework.Interfaces.ITestFilter, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Constructors
- public TestFilter.EmptyFilter()

#### Methods
- public override NUnit.Framework.Interfaces.TNode AddToXml(NUnit.Framework.Interfaces.TNode parentNode, bool recursive)
- public override bool IsExplicitMatch(NUnit.Framework.Interfaces.ITest test)
- public override bool Match(NUnit.Framework.Interfaces.ITest test)
- public override bool Pass(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.ExceptionHelper

#### Fields
- private static readonly System.Action<System.Exception> PreserveStackTrace

#### Constructors
- private static ExceptionHelper()
- public ExceptionHelper()

#### Methods
- public static string BuildMessage(System.Exception exception)
- public static string BuildStackTrace(System.Exception exception)
- private static System.Collections.Generic.List<System.Exception> FlattenExceptionHierarchy(System.Exception exception)
- public static string GetStackTrace(System.Exception exception)
- public static void Rethrow(System.Exception exception)

### private class NUnit.Framework.Internal.TestNameGenerator.FixedTextFragment
- Base: NUnit.Framework.Internal.TestNameGenerator.NameFragment

#### Fields
- private string _text

#### Constructors
- public TestNameGenerator.FixedTextFragment(string text)

#### Methods
- public override string GetText(System.Reflection.MethodInfo method, object[] args)

### public class NUnit.Framework.Internal.GenericMethodHelper

#### Fields
- private System.Reflection.MethodInfo <Method>k__BackingField
- private System.Type[] <ParmTypes>k__BackingField
- private System.Type[] <TypeArgs>k__BackingField
- private System.Type[] <TypeParms>k__BackingField

#### Properties
- private System.Reflection.MethodInfo Method { get; set; }
- private System.Type[] ParmTypes { get; set; }
- private System.Type[] TypeArgs { get; set; }
- private System.Type[] TypeParms { get; set; }

#### Constructors
- public GenericMethodHelper(System.Reflection.MethodInfo method)

#### Methods
- private void ApplyArgType(System.Type parmType, System.Type argType)
- public System.Type[] GetTypeArguments(object[] argList)
- private bool IsAssignableToGenericType(System.Type givenType, System.Type genericType)
- private void TryApplyArgType(System.Type parmType, System.Type argType)

### public interface NUnit.Framework.Internal.ILogger

#### Methods
- public void Debug(string message)
- public void Debug(string message, params object[] args)
- public void Error(string message)
- public void Error(string message, params object[] args)
- public void Info(string message)
- public void Info(string message, params object[] args)
- public void Warning(string message)
- public void Warning(string message, params object[] args)

### public static class NUnit.Framework.Internal.InternalTrace

#### Fields
- private static bool <Initialized>k__BackingField
- private static NUnit.Framework.Internal.InternalTraceLevel traceLevel
- private static NUnit.Framework.Internal.InternalTraceWriter traceWriter

#### Properties
- public static bool Initialized { get; private set; }

#### Methods
- public static NUnit.Framework.Internal.Logger GetLogger(string name)
- public static NUnit.Framework.Internal.Logger GetLogger(System.Type type)
- public static void Initialize(string logName, NUnit.Framework.Internal.InternalTraceLevel level)
- public static void Initialize(System.IO.TextWriter writer, NUnit.Framework.Internal.InternalTraceLevel level)

### public enum NUnit.Framework.Internal.InternalTraceLevel
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Debug = 5
- Default = 0
- Error = 2
- Info = 4
- Off = 1
- Verbose = 5
- Warning = 3

### public class NUnit.Framework.Internal.InternalTraceWriter
- Base: System.IO.TextWriter
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private object myLock
- private System.IO.TextWriter writer

#### Properties
- public System.Text.Encoding Encoding { get; }

#### Constructors
- public InternalTraceWriter(string logPath)
- public InternalTraceWriter(System.IO.TextWriter writer)

#### Methods
- protected override void Dispose(bool disposing)
- public override void Flush()
- public override void Write(char value)
- public override void Write(string value)
- public override void WriteLine(string value)

### public class NUnit.Framework.Internal.InvalidDataSourceException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public InvalidDataSourceException()
- public InvalidDataSourceException(string message)
- public InvalidDataSourceException(string message, System.Exception inner)
- protected InvalidDataSourceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### public class NUnit.Framework.Internal.InvalidTestFixtureException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public InvalidTestFixtureException()
- public InvalidTestFixtureException(string message)
- public InvalidTestFixtureException(string message, System.Exception inner)
- protected InvalidTestFixtureException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### public interface NUnit.Framework.Internal.ITestExecutionContext

#### Properties
- public System.Globalization.CultureInfo CurrentCulture { get; set; }
- public NUnit.Framework.Internal.TestResult CurrentResult { get; set; }
- public NUnit.Framework.Internal.Test CurrentTest { get; set; }
- public System.Globalization.CultureInfo CurrentUICulture { get; set; }
- public NUnit.Framework.Constraints.ValueFormatter CurrentValueFormatter { get; }
- public NUnit.Framework.Internal.Execution.IWorkItemDispatcher Dispatcher { get; set; }
- public NUnit.Framework.Internal.TestExecutionStatus ExecutionStatus { get; set; }
- public bool IsSingleThreaded { get; set; }
- public System.IO.TextWriter OutWriter { get; }
- public NUnit.Framework.ParallelScope ParallelScope { get; set; }
- public NUnit.Framework.Internal.Randomizer RandomGenerator { get; }
- public long StartTicks { get; set; }
- public System.DateTime StartTime { get; set; }
- public bool StopOnError { get; set; }
- public int TestCaseTimeout { get; set; }
- public object TestObject { get; set; }
- public System.Collections.Generic.List<NUnit.Framework.ITestAction> UpstreamActions { get; }
- public string WorkDirectory { get; set; }
- public string WorkerId { get; }

#### Methods
- public void AddFormatter(NUnit.Framework.Constraints.ValueFormatterFactory formatterFactory)
- public void IncrementAssertCount()

### public class NUnit.Framework.Internal.Logger
- Interfaces: NUnit.Framework.Internal.ILogger

#### Fields
- private string fullname
- private NUnit.Framework.Internal.InternalTraceLevel maxLevel
- private string name
- private static readonly string TIME_FMT
- private static readonly string TRACE_FMT
- private System.IO.TextWriter writer

#### Constructors
- private static Logger()
- public Logger(string name, NUnit.Framework.Internal.InternalTraceLevel level, System.IO.TextWriter writer)

#### Methods
- public void Debug(string message)
- public void Debug(string message, params object[] args)
- public void Error(string message)
- public void Error(string message, params object[] args)
- public void Info(string message)
- public void Info(string message, params object[] args)
- private void Log(NUnit.Framework.Internal.InternalTraceLevel level, string message)
- private void Log(NUnit.Framework.Internal.InternalTraceLevel level, string format, params object[] args)
- public void Warning(string message)
- public void Warning(string message, params object[] args)
- private void WriteLog(NUnit.Framework.Internal.InternalTraceLevel level, string message)

### private class NUnit.Framework.Internal.TestNameGenerator.MethodFullNameFragment
- Base: NUnit.Framework.Internal.TestNameGenerator.NameFragment

#### Constructors
- public TestNameGenerator.MethodFullNameFragment()

#### Methods
- public override string GetText(System.Reflection.MethodInfo method, object[] args)

### private class NUnit.Framework.Internal.TestNameGenerator.MethodNameFragment
- Base: NUnit.Framework.Internal.TestNameGenerator.NameFragment

#### Constructors
- public TestNameGenerator.MethodNameFragment()

#### Methods
- public override string GetText(System.Reflection.MethodInfo method, object[] args)

### public class NUnit.Framework.Internal.MethodWrapper
- Interfaces: NUnit.Framework.Interfaces.IMethodInfo, NUnit.Framework.Interfaces.IReflectionInfo

#### Fields
- private System.Reflection.MethodInfo <MethodInfo>k__BackingField
- private NUnit.Framework.Interfaces.ITypeInfo <TypeInfo>k__BackingField

#### Properties
- public bool ContainsGenericParameters { get; }
- public bool IsAbstract { get; }
- public bool IsGenericMethod { get; }
- public bool IsGenericMethodDefinition { get; }
- public bool IsPublic { get; }
- public System.Reflection.MethodInfo MethodInfo { get; private set; }
- public string Name { get; }
- public NUnit.Framework.Interfaces.ITypeInfo ReturnType { get; }
- public NUnit.Framework.Interfaces.ITypeInfo TypeInfo { get; private set; }

#### Constructors
- public MethodWrapper(System.Type type, System.Reflection.MethodInfo method)
- public MethodWrapper(System.Type type, string methodName)

#### Methods
- public T[] GetCustomAttributes<T>(bool inherit)
- public System.Type[] GetGenericArguments()
- public NUnit.Framework.Interfaces.IParameterInfo[] GetParameters()
- public object Invoke(object fixture, params object[] args)
- public bool IsDefined<T>(bool inherit)
- public NUnit.Framework.Interfaces.IMethodInfo MakeGenericMethod(params System.Type[] typeArguments)
- public override string ToString()

### private class NUnit.Framework.Internal.TestNameGenerator.NameFragment

#### Fields
- private static const string THREE_DOTS

#### Constructors
- protected TestNameGenerator.NameFragment()

#### Methods
- protected static void AppendGenericTypeNames(System.Text.StringBuilder sb, System.Reflection.MethodInfo method)
- private static string EscapeCharInString(char c)
- private static string EscapeControlChar(char c)
- private static string EscapeSingleChar(char c)
- protected static string GetDisplayString(object arg, int stringMax)
- public virtual string GetText(NUnit.Framework.Internal.TestMethod testMethod, object[] args)
- public abstract string GetText(System.Reflection.MethodInfo method, object[] args)

### private class NUnit.Framework.Internal.TestNameGenerator.NamespaceFragment
- Base: NUnit.Framework.Internal.TestNameGenerator.NameFragment

#### Constructors
- public TestNameGenerator.NamespaceFragment()

#### Methods
- public override string GetText(System.Reflection.MethodInfo method, object[] args)

### internal class NUnit.Framework.Internal.TypeHelper.NonmatchingTypeClass

#### Constructors
- public TypeHelper.NonmatchingTypeClass()

### public class NUnit.Framework.Internal.NUnitException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public NUnitException()
- public NUnitException(string message)
- public NUnitException(string message, System.Exception inner)
- protected NUnitException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### public class NUnit.Framework.Internal.OSPlatform

#### Fields
- private static readonly System.Lazy<NUnit.Framework.Internal.OSPlatform> currentPlatform
- public static readonly System.PlatformID MacOSXPlatformID
- public static readonly System.PlatformID UnixPlatformID_Microsoft
- public static readonly System.PlatformID UnixPlatformID_Mono
- public static readonly System.PlatformID XBoxPlatformID
- private readonly System.PlatformID _platform
- private readonly NUnit.Framework.Internal.OSPlatform.ProductType _product
- private readonly System.Version _version

#### Properties
- public static NUnit.Framework.Internal.OSPlatform CurrentPlatform { get; }
- public bool IsMacOSX { get; }
- public bool IsNT3 { get; }
- public bool IsNT4 { get; }
- public bool IsNT5 { get; }
- public bool IsNT6 { get; }
- public bool IsNT60 { get; }
- public bool IsNT61 { get; }
- public bool IsNT62 { get; }
- public bool IsNT63 { get; }
- public bool IsUnix { get; }
- public bool IsVista { get; }
- public bool IsWin2003Server { get; }
- public bool IsWin2008Server { get; }
- public bool IsWin2008ServerR1 { get; }
- public bool IsWin2008ServerR2 { get; }
- public bool IsWin2012Server { get; }
- public bool IsWin2012ServerR1 { get; }
- public bool IsWin2012ServerR2 { get; }
- public bool IsWin2K { get; }
- public bool IsWin32NT { get; }
- public bool IsWin32S { get; }
- public bool IsWin32Windows { get; }
- public bool IsWin95 { get; }
- public bool IsWin98 { get; }
- public bool IsWinCE { get; }
- public bool IsWindows { get; }
- public bool IsWindows10 { get; }
- public bool IsWindows7 { get; }
- public bool IsWindows8 { get; }
- public bool IsWindows81 { get; }
- public bool IsWindowsServer10 { get; }
- public bool IsWinME { get; }
- public bool IsWinXP { get; }
- public bool IsXbox { get; }
- public System.PlatformID Platform { get; }
- public NUnit.Framework.Internal.OSPlatform.ProductType Product { get; }
- public System.Version Version { get; }

#### Constructors
- private static OSPlatform()
- public OSPlatform(System.PlatformID platform, System.Version version)
- public OSPlatform(System.PlatformID platform, System.Version version, NUnit.Framework.Internal.OSPlatform.ProductType product)

#### Methods
- private static bool CheckIfIsMacOSX(System.PlatformID platform)
- private static bool GetVersionEx(ref NUnit.Framework.Internal.OSPlatform.OSVERSIONINFOEX osvi)
- private static System.Version GetWindows81PlusVersion(System.Version version)
- private static int uname(System.IntPtr buf)

### private struct NUnit.Framework.Internal.OSPlatform.OSVERSIONINFOEX

#### Fields
- public readonly uint dwBuildNumber
- public readonly uint dwMajorVersion
- public readonly uint dwMinorVersion
- public uint dwOSVersionInfoSize
- public readonly uint dwPlatformId
- public readonly byte ProductType
- public readonly byte Reserved
- public readonly string szCSDVersion
- public readonly short wServicePackMajor
- public readonly short wServicePackMinor
- public readonly short wSuiteMask

### public class NUnit.Framework.Internal.ParameterizedFixtureSuite
- Base: NUnit.Framework.Internal.TestSuite
- Interfaces: NUnit.Framework.Interfaces.ITest, NUnit.Framework.Interfaces.IXmlNodeBuilder, System.IComparable

#### Fields
- private bool _genericFixture

#### Properties
- public string TestType { get; }

#### Constructors
- public ParameterizedFixtureSuite(NUnit.Framework.Interfaces.ITypeInfo typeInfo)

### public class NUnit.Framework.Internal.ParameterizedMethodSuite
- Base: NUnit.Framework.Internal.TestSuite
- Interfaces: NUnit.Framework.Interfaces.ITest, NUnit.Framework.Interfaces.IXmlNodeBuilder, System.IComparable

#### Fields
- private bool _isTheory

#### Properties
- public string TestType { get; }

#### Constructors
- public ParameterizedMethodSuite(NUnit.Framework.Interfaces.IMethodInfo method)

### public class NUnit.Framework.Internal.ParameterWrapper
- Interfaces: NUnit.Framework.Interfaces.IParameterInfo, NUnit.Framework.Interfaces.IReflectionInfo

#### Fields
- private NUnit.Framework.Interfaces.IMethodInfo <Method>k__BackingField
- private System.Reflection.ParameterInfo <ParameterInfo>k__BackingField

#### Properties
- public bool IsOptional { get; }
- public NUnit.Framework.Interfaces.IMethodInfo Method { get; private set; }
- public System.Reflection.ParameterInfo ParameterInfo { get; private set; }
- public System.Type ParameterType { get; }

#### Constructors
- public ParameterWrapper(NUnit.Framework.Interfaces.IMethodInfo method, System.Reflection.ParameterInfo parameterInfo)

#### Methods
- public T[] GetCustomAttributes<T>(bool inherit)
- public bool IsDefined<T>(bool inherit)

### public class NUnit.Framework.Internal.PlatformHelper

#### Fields
- private static const string CommonOSPlatforms
- public static const string OSPlatforms
- public static readonly string RuntimePlatforms
- private readonly NUnit.Framework.Internal.OSPlatform _os
- private string _reason
- private readonly NUnit.Framework.Internal.RuntimeFramework _rt

#### Properties
- public string Reason { get; }

#### Constructors
- public PlatformHelper()
- private static PlatformHelper()
- public PlatformHelper(NUnit.Framework.Internal.OSPlatform os, NUnit.Framework.Internal.RuntimeFramework rt)

#### Methods
- public bool IsPlatformSupported(string[] platforms)
- public bool IsPlatformSupported(NUnit.Framework.PlatformAttribute platformAttribute)
- public bool IsPlatformSupported(NUnit.Framework.TestCaseAttribute testCaseAttribute)
- private bool IsPlatformSupported(string include, string exclude)
- public bool IsPlatformSupported(string platform)
- private bool IsRuntimeSupported(string platformName)
- private bool IsRuntimeSupported(NUnit.Framework.Internal.RuntimeType runtime, string versionSpecification)

### public enum NUnit.Framework.Internal.OSPlatform.ProductType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DomainController = 2
- Server = 3
- Unknown = 0
- WorkStation = 1

### public class NUnit.Framework.Internal.PropertyBag
- Interfaces: NUnit.Framework.Interfaces.IPropertyBag, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Fields
- private System.Collections.Generic.Dictionary<string, System.Collections.IList> inner

#### Properties
- public System.Collections.IList Item { get; set; }
- public System.Collections.Generic.ICollection<string> Keys { get; }

#### Constructors
- public PropertyBag()

#### Methods
- public void Add(string key, object value)
- public NUnit.Framework.Interfaces.TNode AddToXml(NUnit.Framework.Interfaces.TNode parentNode, bool recursive)
- public bool ContainsKey(string key)
- public object Get(string key)
- public void Set(string key, object value)
- public NUnit.Framework.Interfaces.TNode ToXml(bool recursive)

### public class NUnit.Framework.Internal.PropertyNames

#### Fields
- public static const string ApartmentState
- public static const string AppDomain
- public static const string Author
- public static const string Category
- public static const string Description
- public static const string IgnoreUntilDate
- public static const string JoinType
- public static const string LevelOfParallelism
- public static const string MaxTime
- public static const string Order
- public static const string ParallelScope
- public static const string ProcessID
- public static const string ProviderStackTrace
- public static const string RepeatCount
- public static const string RequiresThread
- public static const string SetCulture
- public static const string SetUICulture
- public static const string SkipReason
- public static const string TestOf
- public static const string Timeout

#### Constructors
- public PropertyNames()

### public class NUnit.Framework.Internal.Randomizer
- Base: System.Random

#### Fields
- public static const string DefaultStringChars
- private static const int DefaultStringLength
- private static System.Collections.Generic.Dictionary<System.Reflection.MemberInfo, NUnit.Framework.Internal.Randomizer> Randomizers
- private static int _initialSeed
- private static System.Random _seedGenerator

#### Properties
- public static int InitialSeed { get; set; }

#### Constructors
- private static Randomizer()
- public Randomizer()
- public Randomizer(int seed)

#### Methods
- public static NUnit.Framework.Internal.Randomizer CreateRandomizer()
- public static NUnit.Framework.Internal.Randomizer GetRandomizer(System.Reflection.MemberInfo member)
- public static NUnit.Framework.Internal.Randomizer GetRandomizer(System.Reflection.ParameterInfo parameter)
- public string GetString(int outputLength, string allowedChars)
- public string GetString(int outputLength)
- public string GetString()
- public bool NextBool()
- public bool NextBool(double probability)
- public byte NextByte()
- public byte NextByte(byte max)
- public byte NextByte(byte min, byte max)
- public decimal NextDecimal()
- public decimal NextDecimal(decimal max)
- public decimal NextDecimal(decimal min, decimal max)
- public double NextDouble(double max)
- public double NextDouble(double min, double max)
- public object NextEnum(System.Type type)
- public T NextEnum<T>()
- public float NextFloat()
- public float NextFloat(float max)
- public float NextFloat(float min, float max)
- public long NextLong()
- public long NextLong(long max)
- public long NextLong(long min, long max)
- public sbyte NextSByte()
- public sbyte NextSByte(sbyte max)
- public sbyte NextSByte(sbyte min, sbyte max)
- public short NextShort()
- public short NextShort(short max)
- public short NextShort(short min, short max)
- public uint NextUInt()
- public uint NextUInt(uint max)
- public uint NextUInt(uint min, uint max)
- public ulong NextULong()
- public ulong NextULong(ulong max)
- public ulong NextULong(ulong min, ulong max)
- public ushort NextUShort()
- public ushort NextUShort(ushort max)
- public ushort NextUShort(ushort min, ushort max)
- private decimal RawDecimal()
- private long RawLong()
- private uint RawUInt()
- private ulong RawULong()
- private uint RawUShort()

### public static class NUnit.Framework.Internal.Reflect

#### Fields
- private static System.Func<System.Type, object[], object> <ConstructorCallWrapper>k__BackingField
- private static System.Func<System.Func<object>, object> <MethodCallWrapper>k__BackingField
- private static readonly System.Reflection.BindingFlags AllMembers
- private static readonly System.Type[] EmptyTypes

#### Properties
- public static System.Func<System.Type, object[], object> ConstructorCallWrapper { get; set; }
- public static System.Func<System.Func<object>, object> MethodCallWrapper { get; set; }

#### Constructors
- private static Reflect()

#### Methods
- public static object Construct(System.Type type)
- public static object Construct(System.Type type, object[] arguments)
- public static System.Reflection.MethodInfo[] GetMethodsWithAttribute(System.Type fixtureType, System.Type attributeType, bool inherit)
- internal static System.Type[] GetTypeArray(object[] objects)
- public static bool HasMethodWithAttribute(System.Type fixtureType, System.Type attributeType)
- public static object InvokeMethod(System.Reflection.MethodInfo method, object fixture)
- public static object InvokeMethod(System.Reflection.MethodInfo method, object fixture, params object[] args)

### public class NUnit.Framework.Internal.RuntimeFramework

#### Fields
- private System.Version <ClrVersion>k__BackingField
- private string <DisplayName>k__BackingField
- private System.Version <FrameworkVersion>k__BackingField
- private NUnit.Framework.Internal.RuntimeType <Runtime>k__BackingField
- private static readonly System.Lazy<NUnit.Framework.Internal.RuntimeFramework> currentFramework
- public static readonly System.Version DefaultVersion

#### Properties
- public bool AllowAnyVersion { get; }
- public System.Version ClrVersion { get; private set; }
- public static NUnit.Framework.Internal.RuntimeFramework CurrentFramework { get; }
- public string DisplayName { get; private set; }
- public System.Version FrameworkVersion { get; private set; }
- public NUnit.Framework.Internal.RuntimeType Runtime { get; private set; }

#### Constructors
- private static RuntimeFramework()
- public RuntimeFramework(NUnit.Framework.Internal.RuntimeType runtime, System.Version version)

#### Methods
- private static string GetDefaultDisplayName(NUnit.Framework.Internal.RuntimeType runtime, System.Version version)
- private void InitFromClrVersion(System.Version version)
- private void InitFromFrameworkVersion(System.Version version)
- private static bool IsRuntimeTypeName(string name)
- public static NUnit.Framework.Internal.RuntimeFramework Parse(string s)
- public bool Supports(NUnit.Framework.Internal.RuntimeFramework target)
- private static void ThrowInvalidFrameworkVersion(System.Version version)
- public override string ToString()
- private static bool VersionsMatch(System.Version v1, System.Version v2)

### public enum NUnit.Framework.Internal.RuntimeType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Any = 0
- Mono = 4
- MonoTouch = 6
- Net = 1
- NetCF = 2
- Silverlight = 5
- SSCLI = 3

### public class NUnit.Framework.Internal.SetUpFixture
- Base: NUnit.Framework.Internal.TestSuite
- Interfaces: NUnit.Framework.Interfaces.ITest, NUnit.Framework.Interfaces.IXmlNodeBuilder, System.IComparable, NUnit.Framework.Interfaces.IDisposableFixture

#### Constructors
- public SetUpFixture(NUnit.Framework.Interfaces.ITypeInfo type)

### public static class NUnit.Framework.Internal.StackFilter

#### Fields
- private static readonly System.Text.RegularExpressions.Regex assertOrAssumeRegex

#### Constructors
- private static StackFilter()

#### Methods
- public static string Filter(string rawTrace)

### public class NUnit.Framework.Internal.StringUtil

#### Constructors
- public StringUtil()

#### Methods
- public static int Compare(string strA, string strB, bool ignoreCase)
- public static bool StringsEqual(string strA, string strB, bool ignoreCase)

### public class NUnit.Framework.Internal.Test
- Interfaces: NUnit.Framework.Interfaces.ITest, NUnit.Framework.Interfaces.IXmlNodeBuilder, System.IComparable

#### Fields
- private object <Fixture>k__BackingField
- private string <FullName>k__BackingField
- private string <Id>k__BackingField
- private static string <IdPrefix>k__BackingField
- private string <Name>k__BackingField
- private NUnit.Framework.Interfaces.ITest <Parent>k__BackingField
- private NUnit.Framework.Interfaces.IPropertyBag <Properties>k__BackingField
- private bool <RequiresThread>k__BackingField
- private NUnit.Framework.Interfaces.RunState <RunState>k__BackingField
- private int <Seed>k__BackingField
- private NUnit.Framework.Interfaces.ITypeInfo <TypeInfo>k__BackingField
- protected NUnit.Framework.Interfaces.ITypeInfo DeclaringTypeInfo
- protected System.Reflection.MethodInfo[] setUpMethods
- protected System.Reflection.MethodInfo[] tearDownMethods
- private NUnit.Framework.Interfaces.IMethodInfo _method
- private static int _nextID

#### Properties
- public string ClassName { get; }
- public object Fixture { get; set; }
- public string FullName { get; set; }
- public bool HasChildren { get; }
- public string Id { get; set; }
- public static string IdPrefix { get; set; }
- public bool IsSuite { get; }
- public NUnit.Framework.Interfaces.IMethodInfo Method { get; set; }
- public string MethodName { get; }
- public string Name { get; set; }
- public NUnit.Framework.Interfaces.ITest Parent { get; set; }
- public NUnit.Framework.Interfaces.IPropertyBag Properties { get; private set; }
- internal bool RequiresThread { get; set; }
- public NUnit.Framework.Interfaces.RunState RunState { get; set; }
- public int Seed { get; set; }
- public int TestCaseCount { get; }
- public System.Collections.Generic.IList<NUnit.Framework.Interfaces.ITest> Tests { get; }
- public string TestType { get; }
- public NUnit.Framework.Interfaces.ITypeInfo TypeInfo { get; private set; }
- public string XmlElementName { get; }

#### Constructors
- private static Test()
- protected Test(string name)
- protected Test(NUnit.Framework.Interfaces.ITypeInfo typeInfo)
- protected Test(NUnit.Framework.Interfaces.IMethodInfo method)
- protected Test(string pathName, string name)

#### Methods
- public abstract NUnit.Framework.Interfaces.TNode AddToXml(NUnit.Framework.Interfaces.TNode parentNode, bool recursive)
- public void ApplyAttributesToTest(System.Reflection.ICustomAttributeProvider provider)
- public int CompareTo(object obj)
- private static string GetNextId()
- private void Initialize(string name)
- public abstract NUnit.Framework.Internal.TestResult MakeTestResult()
- protected void PopulateTestNode(NUnit.Framework.Interfaces.TNode thisNode, bool recursive)
- public NUnit.Framework.Interfaces.TNode ToXml(bool recursive)

### public class NUnit.Framework.Internal.TestAssembly
- Base: NUnit.Framework.Internal.TestSuite
- Interfaces: NUnit.Framework.Interfaces.ITest, NUnit.Framework.Interfaces.IXmlNodeBuilder, System.IComparable

#### Fields
- private System.Reflection.Assembly <Assembly>k__BackingField

#### Properties
- public System.Reflection.Assembly Assembly { get; private set; }
- public string TestType { get; }

#### Constructors
- public TestAssembly(string path)
- public TestAssembly(System.Reflection.Assembly assembly, string path)

### public class NUnit.Framework.Internal.TestCaseParameters
- Base: NUnit.Framework.Internal.TestParameters
- Interfaces: NUnit.Framework.Interfaces.ITestData, NUnit.Framework.Interfaces.IApplyToTest, NUnit.Framework.Interfaces.ITestCaseData

#### Fields
- private bool <HasExpectedResult>k__BackingField
- private object _expectedResult

#### Properties
- public object ExpectedResult { get; set; }
- public bool HasExpectedResult { get; set; }

#### Constructors
- public TestCaseParameters()
- public TestCaseParameters(System.Exception exception)
- public TestCaseParameters(object[] args)
- public TestCaseParameters(NUnit.Framework.Interfaces.ITestCaseData data)

### public class NUnit.Framework.Internal.TestCaseResult
- Base: NUnit.Framework.Internal.TestResult
- Interfaces: NUnit.Framework.Interfaces.ITestResult, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Properties
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Interfaces.ITestResult> Children { get; }
- public int FailCount { get; }
- public bool HasChildren { get; }
- public int InconclusiveCount { get; }
- public int PassCount { get; }
- public int SkipCount { get; }

#### Constructors
- public TestCaseResult(NUnit.Framework.Internal.TestMethod test)

### public class NUnit.Framework.Internal.TestExecutionContext
- Base: NUnit.Compatibility.LongLivedMarshalByRefObject
- Interfaces: NUnit.Framework.Internal.ITestExecutionContext

#### Fields
- private NUnit.Framework.Internal.Test <CurrentTest>k__BackingField
- private NUnit.Framework.Constraints.ValueFormatter <CurrentValueFormatter>k__BackingField
- private NUnit.Framework.Internal.Execution.IWorkItemDispatcher <Dispatcher>k__BackingField
- private bool <IsSingleThreaded>k__BackingField
- private System.IO.TextWriter <OutWriter>k__BackingField
- private NUnit.Framework.ParallelScope <ParallelScope>k__BackingField
- private long <StartTicks>k__BackingField
- private System.DateTime <StartTime>k__BackingField
- private bool <StopOnError>k__BackingField
- private int <TestCaseTimeout>k__BackingField
- private object <TestObject>k__BackingField
- private System.Collections.Generic.List<NUnit.Framework.ITestAction> <UpstreamActions>k__BackingField
- private string <WorkDirectory>k__BackingField
- private string <WorkerId>k__BackingField
- private static readonly string CONTEXT_KEY
- private int _assertCount
- private System.Globalization.CultureInfo _currentCulture
- private System.Security.Principal.IPrincipal _currentPrincipal
- private NUnit.Framework.Internal.TestResult _currentResult
- private System.Globalization.CultureInfo _currentUICulture
- private NUnit.Framework.Internal.TestExecutionStatus _executionStatus
- private NUnit.Framework.Interfaces.ITestListener _listener
- private NUnit.Framework.Internal.TestExecutionContext _priorContext
- private NUnit.Framework.Internal.Randomizer _randomGenerator

#### Properties
- internal int AssertCount { get; }
- public static NUnit.Framework.Internal.ITestExecutionContext CurrentContext { get; private set; }
- public System.Globalization.CultureInfo CurrentCulture { get; set; }
- public System.Security.Principal.IPrincipal CurrentPrincipal { get; set; }
- public NUnit.Framework.Internal.TestResult CurrentResult { get; set; }
- public NUnit.Framework.Internal.Test CurrentTest { get; set; }
- public System.Globalization.CultureInfo CurrentUICulture { get; set; }
- public NUnit.Framework.Constraints.ValueFormatter CurrentValueFormatter { get; private set; }
- public NUnit.Framework.Internal.Execution.IWorkItemDispatcher Dispatcher { get; set; }
- public NUnit.Framework.Internal.TestExecutionStatus ExecutionStatus { get; set; }
- public bool IsSingleThreaded { get; set; }
- internal NUnit.Framework.Interfaces.ITestListener Listener { get; set; }
- public System.IO.TextWriter OutWriter { get; private set; }
- public NUnit.Framework.ParallelScope ParallelScope { get; set; }
- public NUnit.Framework.Internal.Randomizer RandomGenerator { get; }
- public long StartTicks { get; set; }
- public System.DateTime StartTime { get; set; }
- public bool StopOnError { get; set; }
- public int TestCaseTimeout { get; set; }
- public object TestObject { get; set; }
- public System.Collections.Generic.List<NUnit.Framework.ITestAction> UpstreamActions { get; private set; }
- public string WorkDirectory { get; set; }
- public string WorkerId { get; internal set; }

#### Constructors
- public TestExecutionContext()
- private static TestExecutionContext()
- public TestExecutionContext(NUnit.Framework.Internal.TestExecutionContext other)

#### Methods
- public void AddFormatter(NUnit.Framework.Constraints.ValueFormatterFactory formatterFactory)
- public static void ClearCurrentContext()
- public void EstablishExecutionEnvironment()
- public static NUnit.Framework.Internal.TestExecutionContext GetTestExecutionContext()
- public void IncrementAssertCount()
- public void IncrementAssertCount(int count)
- public override object InitializeLifetimeService()
- public void UpdateContextFromEnvironment()

### public enum NUnit.Framework.Internal.TestExecutionStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AbortRequested = 2
- Running = 0
- StopRequested = 1

### public class NUnit.Framework.Internal.TestFilter
- Interfaces: NUnit.Framework.Interfaces.ITestFilter, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Fields
- private bool <TopLevel>k__BackingField
- public static readonly NUnit.Framework.Internal.TestFilter Empty

#### Properties
- public bool IsEmpty { get; }
- public bool TopLevel { get; set; }

#### Constructors
- protected TestFilter()
- private static TestFilter()

#### Methods
- public abstract NUnit.Framework.Interfaces.TNode AddToXml(NUnit.Framework.Interfaces.TNode parentNode, bool recursive)
- public static NUnit.Framework.Internal.TestFilter FromXml(string xmlText)
- public static NUnit.Framework.Internal.TestFilter FromXml(NUnit.Framework.Interfaces.TNode node)
- public virtual bool IsExplicitMatch(NUnit.Framework.Interfaces.ITest test)
- public abstract bool Match(NUnit.Framework.Interfaces.ITest test)
- protected virtual bool MatchDescendant(NUnit.Framework.Interfaces.ITest test)
- public bool MatchParent(NUnit.Framework.Interfaces.ITest test)
- public virtual bool Pass(NUnit.Framework.Interfaces.ITest test)
- public NUnit.Framework.Interfaces.TNode ToXml(bool recursive)

### public class NUnit.Framework.Internal.TestFixture
- Base: NUnit.Framework.Internal.TestSuite
- Interfaces: NUnit.Framework.Interfaces.ITest, NUnit.Framework.Interfaces.IXmlNodeBuilder, System.IComparable, NUnit.Framework.Interfaces.IDisposableFixture

#### Constructors
- public TestFixture(NUnit.Framework.Interfaces.ITypeInfo fixtureType)

### public class NUnit.Framework.Internal.TestFixtureParameters
- Base: NUnit.Framework.Internal.TestParameters
- Interfaces: NUnit.Framework.Interfaces.ITestData, NUnit.Framework.Interfaces.IApplyToTest, NUnit.Framework.Interfaces.ITestFixtureData

#### Fields
- private System.Type[] <TypeArgs>k__BackingField

#### Properties
- public System.Type[] TypeArgs { get; internal set; }

#### Constructors
- public TestFixtureParameters()
- public TestFixtureParameters(System.Exception exception)
- public TestFixtureParameters(params object[] args)
- public TestFixtureParameters(NUnit.Framework.Interfaces.ITestFixtureData data)

### private class NUnit.Framework.Internal.TestNameGenerator.TestIDFragment
- Base: NUnit.Framework.Internal.TestNameGenerator.NameFragment

#### Constructors
- public TestNameGenerator.TestIDFragment()

#### Methods
- public override string GetText(System.Reflection.MethodInfo method, object[] args)
- public override string GetText(NUnit.Framework.Internal.TestMethod testMethod, object[] args)

### public class NUnit.Framework.Internal.TestListener
- Interfaces: NUnit.Framework.Interfaces.ITestListener

#### Properties
- public static NUnit.Framework.Interfaces.ITestListener NULL { get; }

#### Constructors
- private TestListener()

#### Methods
- public void TestFinished(NUnit.Framework.Interfaces.ITestResult result)
- public void TestOutput(NUnit.Framework.Interfaces.TestOutput output)
- public void TestStarted(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.TestMethod
- Base: NUnit.Framework.Internal.Test
- Interfaces: NUnit.Framework.Interfaces.ITest, NUnit.Framework.Interfaces.IXmlNodeBuilder, System.IComparable

#### Fields
- public NUnit.Framework.Internal.TestCaseParameters parms

#### Properties
- internal object[] Arguments { get; }
- internal object ExpectedResult { get; }
- public bool HasChildren { get; }
- internal bool HasExpectedResult { get; }
- public string MethodName { get; }
- public System.Collections.Generic.IList<NUnit.Framework.Interfaces.ITest> Tests { get; }
- public string XmlElementName { get; }

#### Constructors
- public TestMethod(NUnit.Framework.Interfaces.IMethodInfo method)
- public TestMethod(NUnit.Framework.Interfaces.IMethodInfo method, NUnit.Framework.Internal.Test parentSuite)

#### Methods
- public override NUnit.Framework.Interfaces.TNode AddToXml(NUnit.Framework.Interfaces.TNode parentNode, bool recursive)
- public override NUnit.Framework.Internal.TestResult MakeTestResult()

### public class NUnit.Framework.Internal.TestNameGenerator

#### Fields
- public static string DefaultTestNamePattern
- private System.Collections.Generic.List<NUnit.Framework.Internal.TestNameGenerator.NameFragment> _fragments
- private string _pattern

#### Constructors
- public TestNameGenerator()
- private static TestNameGenerator()
- public TestNameGenerator(string pattern)

#### Methods
- private static System.Collections.Generic.List<NUnit.Framework.Internal.TestNameGenerator.NameFragment> BuildFragmentList(string pattern)
- public string GetDisplayName(NUnit.Framework.Internal.TestMethod testMethod)
- public string GetDisplayName(NUnit.Framework.Internal.TestMethod testMethod, object[] args)

### public class NUnit.Framework.Internal.TestParameters
- Interfaces: NUnit.Framework.Interfaces.ITestData, NUnit.Framework.Interfaces.IApplyToTest

#### Fields
- private object[] <Arguments>k__BackingField
- private object[] <OriginalArguments>k__BackingField
- private NUnit.Framework.Interfaces.IPropertyBag <Properties>k__BackingField
- private NUnit.Framework.Interfaces.RunState <RunState>k__BackingField
- private string <TestName>k__BackingField

#### Properties
- public object[] Arguments { get; internal set; }
- public object[] OriginalArguments { get; private set; }
- public NUnit.Framework.Interfaces.IPropertyBag Properties { get; private set; }
- public NUnit.Framework.Interfaces.RunState RunState { get; set; }
- public string TestName { get; set; }

#### Constructors
- public TestParameters()
- public TestParameters(object[] args)
- public TestParameters(System.Exception exception)
- public TestParameters(NUnit.Framework.Interfaces.ITestData data)

#### Methods
- public void ApplyToTest(NUnit.Framework.Internal.Test test)
- private void InitializeAguments(object[] args)

### public class NUnit.Framework.Internal.TestProgressReporter
- Interfaces: NUnit.Framework.Interfaces.ITestListener

#### Fields
- private System.Web.UI.ICallbackEventHandler handler
- private static NUnit.Framework.Internal.Logger log

#### Constructors
- private static TestProgressReporter()
- public TestProgressReporter(System.Web.UI.ICallbackEventHandler handler)

#### Methods
- private static string FormatAttributeValue(string original)
- private static NUnit.Framework.Interfaces.ITest GetParent(NUnit.Framework.Interfaces.ITest test)
- public void TestFinished(NUnit.Framework.Interfaces.ITestResult result)
- public void TestOutput(NUnit.Framework.Interfaces.TestOutput output)
- public void TestStarted(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.TestResult
- Interfaces: NUnit.Framework.Interfaces.ITestResult, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Fields
- private System.DateTime <EndTime>k__BackingField
- private System.IO.TextWriter <OutWriter>k__BackingField
- private System.DateTime <StartTime>k__BackingField
- private NUnit.Framework.Interfaces.ITest <Test>k__BackingField
- internal static readonly string CHILD_ERRORS_MESSAGE
- internal static readonly string CHILD_IGNORE_MESSAGE
- protected int InternalAssertCount
- internal static const double MIN_DURATION
- private double _duration
- private string _message
- private System.Text.StringBuilder _output
- private NUnit.Framework.Interfaces.ResultState _resultState
- private string _stackTrace

#### Properties
- public int AssertCount { get; internal set; }
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Interfaces.ITestResult> Children { get; }
- public double Duration { get; set; }
- public System.DateTime EndTime { get; set; }
- public int FailCount { get; }
- public string FullName { get; }
- public bool HasChildren { get; }
- public int InconclusiveCount { get; }
- public string Message { get; private set; }
- public string Name { get; }
- public string Output { get; }
- public System.IO.TextWriter OutWriter { get; private set; }
- public int PassCount { get; }
- public NUnit.Framework.Interfaces.ResultState ResultState { get; private set; }
- public int SkipCount { get; }
- public string StackTrace { get; private set; }
- public System.DateTime StartTime { get; set; }
- public NUnit.Framework.Interfaces.ITest Test { get; private set; }

#### Constructors
- private static TestResult()
- public TestResult(NUnit.Framework.Interfaces.ITest test)

#### Methods
- private NUnit.Framework.Interfaces.TNode AddFailureElement(NUnit.Framework.Interfaces.TNode targetNode)
- private NUnit.Framework.Interfaces.TNode AddOutputElement(NUnit.Framework.Interfaces.TNode targetNode)
- private NUnit.Framework.Interfaces.TNode AddReasonElement(NUnit.Framework.Interfaces.TNode targetNode)
- public virtual NUnit.Framework.Interfaces.TNode AddToXml(NUnit.Framework.Interfaces.TNode parentNode, bool recursive)
- public void RecordException(System.Exception ex)
- public void RecordException(System.Exception ex, NUnit.Framework.Interfaces.FailureSite site)
- public void RecordTearDownException(System.Exception ex)
- public void SetResult(NUnit.Framework.Interfaces.ResultState resultState)
- public void SetResult(NUnit.Framework.Interfaces.ResultState resultState, string message)
- public void SetResult(NUnit.Framework.Interfaces.ResultState resultState, string message, string stackTrace)
- public NUnit.Framework.Interfaces.TNode ToXml(bool recursive)

### public class NUnit.Framework.Internal.TestSuite
- Base: NUnit.Framework.Internal.Test
- Interfaces: NUnit.Framework.Interfaces.ITest, NUnit.Framework.Interfaces.IXmlNodeBuilder, System.IComparable

#### Fields
- private object[] <Arguments>k__BackingField
- private bool <MaintainTestOrder>k__BackingField
- private System.Collections.Generic.List<NUnit.Framework.Interfaces.ITest> tests

#### Properties
- public object[] Arguments { get; internal set; }
- public bool HasChildren { get; }
- protected bool MaintainTestOrder { get; set; }
- public int TestCaseCount { get; }
- public System.Collections.Generic.IList<NUnit.Framework.Interfaces.ITest> Tests { get; }
- public string XmlElementName { get; }

#### Constructors
- public TestSuite(string name)
- public TestSuite(NUnit.Framework.Interfaces.ITypeInfo fixtureType)
- public TestSuite(System.Type fixtureType)
- public TestSuite(string parentSuiteName, string name)

#### Methods
- public void Add(NUnit.Framework.Internal.Test test)
- public override NUnit.Framework.Interfaces.TNode AddToXml(NUnit.Framework.Interfaces.TNode parentNode, bool recursive)
- protected void CheckSetUpTearDownMethods(System.Type attrType)
- public override NUnit.Framework.Internal.TestResult MakeTestResult()
- public void Sort()

### public class NUnit.Framework.Internal.TestSuiteResult
- Base: NUnit.Framework.Internal.TestResult
- Interfaces: NUnit.Framework.Interfaces.ITestResult, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Fields
- private System.Collections.Generic.List<NUnit.Framework.Interfaces.ITestResult> _children
- private int _failCount
- private int _inconclusiveCount
- private int _passCount
- private int _skipCount

#### Properties
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Interfaces.ITestResult> Children { get; }
- public int FailCount { get; }
- public bool HasChildren { get; }
- public int InconclusiveCount { get; }
- public int PassCount { get; }
- public int SkipCount { get; }

#### Constructors
- public TestSuiteResult(NUnit.Framework.Internal.TestSuite suite)

#### Methods
- public virtual void AddResult(NUnit.Framework.Interfaces.ITestResult result)

### public class NUnit.Framework.Internal.TextMessageWriter
- Base: NUnit.Framework.Constraints.MessageWriter
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private static readonly int DEFAULT_LINE_LENGTH
- private int maxLineLength
- public static readonly string Pfx_Actual
- public static readonly string Pfx_Expected
- public static readonly int PrefixLength

#### Properties
- public int MaxLineLength { get; set; }

#### Constructors
- public TextMessageWriter()
- private static TextMessageWriter()
- public TextMessageWriter(string userMessage, params object[] args)

#### Methods
- public override void DisplayDifferences(NUnit.Framework.Constraints.ConstraintResult result)
- public override void DisplayDifferences(object expected, object actual)
- public override void DisplayDifferences(object expected, object actual, NUnit.Framework.Constraints.Tolerance tolerance)
- public override void DisplayStringDifferences(string expected, string actual, int mismatch, bool ignoreCase, bool clipping)
- private void WriteActualLine(NUnit.Framework.Constraints.ConstraintResult result)
- private void WriteActualLine(object actual)
- public override void WriteActualValue(object actual)
- private void WriteCaretLine(int mismatch)
- public override void WriteCollectionElements(System.Collections.IEnumerable collection, long start, int max)
- private void WriteExpectedLine(NUnit.Framework.Constraints.ConstraintResult result)
- private void WriteExpectedLine(object expected)
- private void WriteExpectedLine(object expected, NUnit.Framework.Constraints.Tolerance tolerance)
- public override void WriteMessageLine(int level, string message, params object[] args)
- public override void WriteValue(object val)

### public static class NUnit.Framework.Internal.ThreadUtility

#### Methods
- public static void Kill(System.Threading.Thread thread)
- public static void Kill(System.Threading.Thread thread, object stateInfo)

### public class NUnit.Framework.Internal.TypeHelper

#### Fields
- public static readonly System.Type NonmatchingType
- private static const int STRING_LIMIT
- private static const int STRING_MAX
- private static const string THREE_DOTS

#### Constructors
- public TypeHelper()
- private static TypeHelper()

#### Methods
- public static System.Type BestCommonType(System.Type type1, System.Type type2)
- public static bool CanDeduceTypeArgsFromArgs(System.Type type, object[] arglist, ref System.Type[] typeArgsOut)
- public static void ConvertArgumentList(object[] arglist, NUnit.Framework.Interfaces.IParameterInfo[] parameters)
- public static string GetDisplayName(System.Type type)
- public static string GetDisplayName(System.Type type, object[] arglist)
- public static string[] GetEnumNames(System.Type enumType)
- public static System.Array GetEnumValues(System.Type enumType)
- public static bool IsNumeric(System.Type type)

### public class NUnit.Framework.Internal.TypeWrapper
- Interfaces: NUnit.Framework.Interfaces.ITypeInfo, NUnit.Framework.Interfaces.IReflectionInfo

#### Fields
- private System.Type <Type>k__BackingField

#### Properties
- public System.Reflection.Assembly Assembly { get; }
- public NUnit.Framework.Interfaces.ITypeInfo BaseType { get; }
- public bool ContainsGenericParameters { get; }
- public string FullName { get; }
- public bool IsAbstract { get; }
- public bool IsGenericType { get; }
- public bool IsGenericTypeDefinition { get; }
- public bool IsSealed { get; }
- public bool IsStaticClass { get; }
- public string Name { get; }
- public string Namespace { get; }
- public System.Type Type { get; private set; }

#### Constructors
- public TypeWrapper(System.Type type)

#### Methods
- public object Construct(object[] args)
- public System.Reflection.ConstructorInfo GetConstructor(System.Type[] argTypes)
- public T[] GetCustomAttributes<T>(bool inherit)
- public string GetDisplayName()
- public string GetDisplayName(object[] args)
- public System.Type GetGenericTypeDefinition()
- public NUnit.Framework.Interfaces.IMethodInfo[] GetMethods(System.Reflection.BindingFlags flags)
- public bool HasConstructor(System.Type[] argTypes)
- public bool HasMethodWithAttribute(System.Type attributeType)
- public bool IsDefined<T>(bool inherit)
- public bool IsType(System.Type type)
- public NUnit.Framework.Interfaces.ITypeInfo MakeGenericType(System.Type[] typeArgs)
- public override string ToString()

## Namespace: NUnit.Framework.Internal.Builders

### private class NUnit.Framework.Internal.Builders.ParameterDataProvider.<GetDataFor>d__3
- Interfaces: System.Collections.Generic.IEnumerable<object>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public NUnit.Framework.Interfaces.IParameterInfo <>3__parameter
- public NUnit.Framework.Internal.Builders.ParameterDataProvider <>4__this
- private int <>l__initialThreadId
- private System.Collections.Generic.List<T>.Enumerator<NUnit.Framework.Interfaces.IParameterDataProvider> <>s__1
- private System.Collections.IEnumerator <>s__3
- private object <data>5__4
- private NUnit.Framework.Interfaces.IParameterDataProvider <provider>5__2
- private NUnit.Framework.Interfaces.IParameterInfo parameter

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public ParameterDataProvider.<GetDataFor>d__3(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private void <>m__Finally2()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class NUnit.Framework.Internal.Builders.ProviderCache.CacheEntry

#### Fields
- private System.Type providerType

#### Constructors
- public ProviderCache.CacheEntry(System.Type providerType, object[] providerArgs)

#### Methods
- public override bool Equals(object obj)
- public override int GetHashCode()

### public class NUnit.Framework.Internal.Builders.CombinatorialStrategy
- Interfaces: NUnit.Framework.Interfaces.ICombiningStrategy

#### Constructors
- public CombinatorialStrategy()

#### Methods
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Interfaces.ITestCaseData> GetTestCases(System.Collections.IEnumerable[] sources)

### public class NUnit.Framework.Internal.Builders.DatapointProvider
- Interfaces: NUnit.Framework.Interfaces.IParameterDataProvider

#### Constructors
- public DatapointProvider()

#### Methods
- public System.Collections.IEnumerable GetDataFor(NUnit.Framework.Interfaces.IParameterInfo parameter)
- private System.Type GetElementTypeFromMemberInfo(System.Reflection.MemberInfo member)
- private System.Type GetTypeFromMemberInfo(System.Reflection.MemberInfo member)
- public bool HasDataFor(NUnit.Framework.Interfaces.IParameterInfo parameter)

### public class NUnit.Framework.Internal.Builders.DefaultSuiteBuilder
- Interfaces: NUnit.Framework.Interfaces.ISuiteBuilder

#### Fields
- private NUnit.Framework.Internal.Builders.NUnitTestFixtureBuilder _defaultBuilder

#### Constructors
- public DefaultSuiteBuilder()

#### Methods
- public NUnit.Framework.Internal.TestSuite BuildFrom(NUnit.Framework.Interfaces.ITypeInfo typeInfo)
- private NUnit.Framework.Internal.TestSuite BuildMultipleFixtures(NUnit.Framework.Interfaces.ITypeInfo typeInfo, System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestSuite> fixtures)
- public bool CanBuildFrom(NUnit.Framework.Interfaces.ITypeInfo typeInfo)
- private NUnit.Framework.Interfaces.IFixtureBuilder[] GetFixtureBuilderAttributes(NUnit.Framework.Interfaces.ITypeInfo typeInfo)
- private bool HasArguments(NUnit.Framework.Interfaces.IFixtureBuilder attr)

### public class NUnit.Framework.Internal.Builders.DefaultTestCaseBuilder
- Interfaces: NUnit.Framework.Interfaces.ITestCaseBuilder

#### Fields
- private NUnit.Framework.Internal.Builders.NUnitTestCaseBuilder _nunitTestCaseBuilder

#### Constructors
- public DefaultTestCaseBuilder()

#### Methods
- public NUnit.Framework.Internal.Test BuildFrom(NUnit.Framework.Interfaces.IMethodInfo method)
- public NUnit.Framework.Internal.Test BuildFrom(NUnit.Framework.Interfaces.IMethodInfo method, NUnit.Framework.Internal.Test parentSuite)
- private NUnit.Framework.Internal.Test BuildParameterizedMethodSuite(NUnit.Framework.Interfaces.IMethodInfo method, System.Collections.Generic.IEnumerable<NUnit.Framework.Internal.TestMethod> tests)
- private NUnit.Framework.Internal.Test BuildSingleTestMethod(NUnit.Framework.Interfaces.IMethodInfo method, NUnit.Framework.Internal.Test suite)
- public bool CanBuildFrom(NUnit.Framework.Interfaces.IMethodInfo method)
- public bool CanBuildFrom(NUnit.Framework.Interfaces.IMethodInfo method, NUnit.Framework.Internal.Test parentSuite)

### internal class NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureInfo

#### Fields
- public readonly int Dimension
- public readonly int Feature

#### Constructors
- public PairwiseStrategy.FeatureInfo(int dimension, int feature)

### internal class NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureTuple

#### Fields
- private readonly NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureInfo[] _features

#### Properties
- public NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureInfo Item { get; }
- public int Length { get; }

#### Constructors
- public PairwiseStrategy.FeatureTuple(NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureInfo feature1)
- public PairwiseStrategy.FeatureTuple(NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureInfo feature1, NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureInfo feature2)

### internal class NUnit.Framework.Internal.Builders.PairwiseStrategy.FleaRand

#### Fields
- private uint _b
- private uint _c
- private uint _d
- private uint[] _m
- private uint _q
- private uint[] _r
- private uint _z

#### Constructors
- public PairwiseStrategy.FleaRand(uint seed)

#### Methods
- private void Batch()
- public uint Next()

### public class NUnit.Framework.Internal.Builders.NamespaceTreeBuilder

#### Fields
- private System.Collections.Generic.Dictionary<string, NUnit.Framework.Internal.TestSuite> namespaceSuites
- private NUnit.Framework.Internal.TestSuite rootSuite

#### Properties
- public NUnit.Framework.Internal.TestSuite RootSuite { get; }

#### Constructors
- public NamespaceTreeBuilder(NUnit.Framework.Internal.TestSuite rootSuite)

#### Methods
- public void Add(System.Collections.Generic.IList<NUnit.Framework.Internal.Test> fixtures)
- public void Add(NUnit.Framework.Internal.TestSuite fixture)
- private void AddSetUpFixture(NUnit.Framework.Internal.TestSuite newSetupFixture, NUnit.Framework.Internal.TestSuite containingSuite, string ns)
- private NUnit.Framework.Internal.TestSuite BuildFromNameSpace(string ns)
- private static string GetNamespaceForFixture(NUnit.Framework.Internal.TestSuite fixture)

### public class NUnit.Framework.Internal.Builders.NUnitTestCaseBuilder

#### Fields
- private readonly NUnit.Framework.Internal.TestNameGenerator _nameGenerator
- private readonly NUnit.Framework.Internal.Randomizer _randomizer

#### Constructors
- public NUnitTestCaseBuilder()

#### Methods
- public NUnit.Framework.Internal.TestMethod BuildTestMethod(NUnit.Framework.Interfaces.IMethodInfo method, NUnit.Framework.Internal.Test parentSuite, NUnit.Framework.Internal.TestCaseParameters parms)
- private static bool CheckTestMethodSignature(NUnit.Framework.Internal.TestMethod testMethod, NUnit.Framework.Internal.TestCaseParameters parms)
- private static bool MarkAsNotRunnable(NUnit.Framework.Internal.TestMethod testMethod, string reason)

### public class NUnit.Framework.Internal.Builders.NUnitTestFixtureBuilder

#### Fields
- private static readonly string NO_TYPE_ARGS_MSG
- private NUnit.Framework.Interfaces.ITestCaseBuilder _testBuilder

#### Constructors
- public NUnitTestFixtureBuilder()
- private static NUnitTestFixtureBuilder()

#### Methods
- private void AddTestCasesToFixture(NUnit.Framework.Internal.TestFixture fixture)
- public NUnit.Framework.Internal.TestSuite BuildFrom(NUnit.Framework.Interfaces.ITypeInfo typeInfo)
- public NUnit.Framework.Internal.TestSuite BuildFrom(NUnit.Framework.Interfaces.ITypeInfo typeInfo, NUnit.Framework.Interfaces.ITestFixtureData testFixtureData)
- private NUnit.Framework.Internal.Test BuildTestCase(NUnit.Framework.Interfaces.IMethodInfo method, NUnit.Framework.Internal.TestSuite suite)
- private static void CheckTestFixtureIsValid(NUnit.Framework.Internal.TestFixture fixture)
- private static bool IsStaticClass(System.Type type)

### public class NUnit.Framework.Internal.Builders.PairwiseStrategy
- Interfaces: NUnit.Framework.Interfaces.ICombiningStrategy

#### Constructors
- public PairwiseStrategy()

#### Methods
- private int[] CreateDimensions(System.Collections.Generic.List<object>[] valueSet)
- private System.Collections.Generic.List<object>[] CreateValueSet(System.Collections.IEnumerable[] sources)
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Interfaces.ITestCaseData> GetTestCases(System.Collections.IEnumerable[] sources)

### internal class NUnit.Framework.Internal.Builders.PairwiseStrategy.PairwiseTestCaseGenerator

#### Fields
- private int[] _dimensions
- private NUnit.Framework.Internal.Builders.PairwiseStrategy.FleaRand _prng
- private System.Collections.Generic.List<NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureTuple>[][] _uncoveredTuples

#### Constructors
- public PairwiseStrategy.PairwiseTestCaseGenerator()

#### Methods
- private int CountTuplesCoveredByTest(NUnit.Framework.Internal.Builders.PairwiseStrategy.TestCaseInfo testCase, int dimension, int feature)
- private void CreateAllTuples()
- private NUnit.Framework.Internal.Builders.PairwiseStrategy.TestCaseInfo CreateRandomTestCase(NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureTuple tuple)
- private NUnit.Framework.Internal.Builders.PairwiseStrategy.TestCaseInfo CreateTestCase(NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureTuple tuple)
- private System.Collections.Generic.List<NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureTuple> CreateTuples(int dimension, int feature)
- private int[] GetMutableDimensions(NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureTuple tuple)
- private int GetNextRandomNumber()
- private NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureTuple GetNextTuple()
- public System.Collections.IEnumerable GetTestCases(int[] dimensions)
- private bool IsTupleCovered(System.Collections.Generic.List<NUnit.Framework.Internal.Builders.PairwiseStrategy.TestCaseInfo> testCases, NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureTuple tuple)
- private int MaximizeCoverage(NUnit.Framework.Internal.Builders.PairwiseStrategy.TestCaseInfo testCase, NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureTuple tuple)
- private int MaximizeCoverageForDimension(NUnit.Framework.Internal.Builders.PairwiseStrategy.TestCaseInfo testCase, int dimension, int bestCoverage)
- private void RemoveTuplesCoveredByTest(NUnit.Framework.Internal.Builders.PairwiseStrategy.TestCaseInfo testCase)
- private void ScrambleDimensions(int[] dimensions)
- private void SelfTest(System.Collections.Generic.List<NUnit.Framework.Internal.Builders.PairwiseStrategy.TestCaseInfo> testCases)

### public class NUnit.Framework.Internal.Builders.ParameterDataProvider
- Interfaces: NUnit.Framework.Interfaces.IParameterDataProvider

#### Fields
- private System.Collections.Generic.List<NUnit.Framework.Interfaces.IParameterDataProvider> _providers

#### Constructors
- public ParameterDataProvider(params NUnit.Framework.Interfaces.IParameterDataProvider[] providers)

#### Methods
- public System.Collections.IEnumerable GetDataFor(NUnit.Framework.Interfaces.IParameterInfo parameter)
- public bool HasDataFor(NUnit.Framework.Interfaces.IParameterInfo parameter)

### public class NUnit.Framework.Internal.Builders.ParameterDataSourceProvider
- Interfaces: NUnit.Framework.Interfaces.IParameterDataProvider

#### Constructors
- public ParameterDataSourceProvider()

#### Methods
- public System.Collections.IEnumerable GetDataFor(NUnit.Framework.Interfaces.IParameterInfo parameter)
- public bool HasDataFor(NUnit.Framework.Interfaces.IParameterInfo parameter)

### internal class NUnit.Framework.Internal.Builders.ProviderCache

#### Fields
- private static System.Collections.Generic.Dictionary<NUnit.Framework.Internal.Builders.ProviderCache.CacheEntry, object> instances

#### Constructors
- public ProviderCache()
- private static ProviderCache()

#### Methods
- public static void Clear()
- public static object GetInstanceOf(System.Type providerType)
- public static object GetInstanceOf(System.Type providerType, object[] providerArgs)

### public class NUnit.Framework.Internal.Builders.SequentialStrategy
- Interfaces: NUnit.Framework.Interfaces.ICombiningStrategy

#### Constructors
- public SequentialStrategy()

#### Methods
- public System.Collections.Generic.IEnumerable<NUnit.Framework.Interfaces.ITestCaseData> GetTestCases(System.Collections.IEnumerable[] sources)

### internal class NUnit.Framework.Internal.Builders.PairwiseStrategy.TestCaseInfo

#### Fields
- public readonly int[] Features

#### Constructors
- public PairwiseStrategy.TestCaseInfo(int length)

#### Methods
- public bool IsTupleCovered(NUnit.Framework.Internal.Builders.PairwiseStrategy.FeatureTuple tuple)

## Namespace: NUnit.Framework.Internal.Commands

### private class NUnit.Framework.Internal.Commands.OneTimeTearDownCommand.<>c__DisplayClass3_0

#### Fields
- public System.IDisposable disposable

#### Constructors
- public OneTimeTearDownCommand.<>c__DisplayClass3_0()

#### Methods
- internal object <Execute>b__0()

### public class NUnit.Framework.Internal.Commands.ApplyChangesToContextCommand
- Base: NUnit.Framework.Internal.Commands.DelegatingTestCommand

#### Fields
- private System.Collections.Generic.IEnumerable<NUnit.Framework.Interfaces.IApplyToContext> _changes

#### Constructors
- public ApplyChangesToContextCommand(NUnit.Framework.Internal.Commands.TestCommand innerCommand, System.Collections.Generic.IEnumerable<NUnit.Framework.Interfaces.IApplyToContext> changes)

#### Methods
- public void ApplyChanges(NUnit.Framework.Internal.ITestExecutionContext context)
- public override NUnit.Framework.Internal.TestResult Execute(NUnit.Framework.Internal.ITestExecutionContext context)

### public enum NUnit.Framework.Internal.Commands.CommandStage
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AboveSetUpTearDown = 3
- BelowSetUpTearDown = 1
- Default = 0
- SetUpTearDown = 2

### public class NUnit.Framework.Internal.Commands.DelegatingTestCommand
- Base: NUnit.Framework.Internal.Commands.TestCommand

#### Fields
- protected NUnit.Framework.Internal.Commands.TestCommand innerCommand

#### Constructors
- protected DelegatingTestCommand(NUnit.Framework.Internal.Commands.TestCommand innerCommand)

#### Methods
- public NUnit.Framework.Internal.Commands.TestCommand GetInnerCommand()

### public class NUnit.Framework.Internal.Commands.MaxTimeCommand
- Base: NUnit.Framework.Internal.Commands.DelegatingTestCommand

#### Fields
- private int maxTime

#### Constructors
- public MaxTimeCommand(NUnit.Framework.Internal.Commands.TestCommand innerCommand, int maxTime)

#### Methods
- public override NUnit.Framework.Internal.TestResult Execute(NUnit.Framework.Internal.ITestExecutionContext context)

### public class NUnit.Framework.Internal.Commands.OneTimeSetUpCommand
- Base: NUnit.Framework.Internal.Commands.TestCommand

#### Fields
- private readonly System.Collections.Generic.List<NUnit.Framework.Internal.Commands.TestActionItem> _actions
- private readonly object[] _arguments
- private readonly System.Collections.Generic.List<NUnit.Framework.Internal.Commands.SetUpTearDownItem> _setUpTearDown
- private readonly NUnit.Framework.Internal.TestSuite _suite
- private readonly NUnit.Framework.Interfaces.ITypeInfo _typeInfo

#### Constructors
- public OneTimeSetUpCommand(NUnit.Framework.Internal.TestSuite suite, System.Collections.Generic.List<NUnit.Framework.Internal.Commands.SetUpTearDownItem> setUpTearDown, System.Collections.Generic.List<NUnit.Framework.Internal.Commands.TestActionItem> actions)

#### Methods
- public override NUnit.Framework.Internal.TestResult Execute(NUnit.Framework.Internal.ITestExecutionContext context)

### public class NUnit.Framework.Internal.Commands.OneTimeTearDownCommand
- Base: NUnit.Framework.Internal.Commands.TestCommand

#### Fields
- private System.Collections.Generic.List<NUnit.Framework.Internal.Commands.TestActionItem> _actions
- private System.Collections.Generic.List<NUnit.Framework.Internal.Commands.SetUpTearDownItem> _setUpTearDownItems

#### Constructors
- public OneTimeTearDownCommand(NUnit.Framework.Internal.TestSuite suite, System.Collections.Generic.List<NUnit.Framework.Internal.Commands.SetUpTearDownItem> setUpTearDownItems, System.Collections.Generic.List<NUnit.Framework.Internal.Commands.TestActionItem> actions)

#### Methods
- public override NUnit.Framework.Internal.TestResult Execute(NUnit.Framework.Internal.ITestExecutionContext context)

### public class NUnit.Framework.Internal.Commands.SetUpTearDownCommand
- Base: NUnit.Framework.Internal.Commands.DelegatingTestCommand

#### Fields
- private System.Collections.Generic.IList<NUnit.Framework.Internal.Commands.SetUpTearDownItem> _setUpTearDownItems

#### Constructors
- public SetUpTearDownCommand(NUnit.Framework.Internal.Commands.TestCommand innerCommand)

#### Methods
- public override NUnit.Framework.Internal.TestResult Execute(NUnit.Framework.Internal.ITestExecutionContext context)

### public class NUnit.Framework.Internal.Commands.SetUpTearDownItem

#### Fields
- private System.Collections.Generic.IList<System.Reflection.MethodInfo> _setUpMethods
- private bool _setUpWasRun
- private System.Collections.Generic.IList<System.Reflection.MethodInfo> _tearDownMethods

#### Properties
- public bool HasMethods { get; }

#### Constructors
- public SetUpTearDownItem(System.Collections.Generic.IList<System.Reflection.MethodInfo> setUpMethods, System.Collections.Generic.IList<System.Reflection.MethodInfo> tearDownMethods)

#### Methods
- private object RunNonAsyncMethod(System.Reflection.MethodInfo method, NUnit.Framework.Internal.ITestExecutionContext context)
- public void RunSetUp(NUnit.Framework.Internal.ITestExecutionContext context)
- private void RunSetUpOrTearDownMethod(NUnit.Framework.Internal.ITestExecutionContext context, System.Reflection.MethodInfo method)
- public void RunTearDown(NUnit.Framework.Internal.ITestExecutionContext context)

### public class NUnit.Framework.Internal.Commands.SkipCommand
- Base: NUnit.Framework.Internal.Commands.TestCommand

#### Constructors
- public SkipCommand(NUnit.Framework.Internal.Test test)

#### Methods
- public override NUnit.Framework.Internal.TestResult Execute(NUnit.Framework.Internal.ITestExecutionContext context)
- private string GetProviderStackTrace()
- private string GetSkipReason()

### public class NUnit.Framework.Internal.Commands.TestActionCommand
- Base: NUnit.Framework.Internal.Commands.DelegatingTestCommand

#### Fields
- private System.Collections.Generic.IList<NUnit.Framework.Internal.Commands.TestActionItem> _actions

#### Constructors
- public TestActionCommand(NUnit.Framework.Internal.Commands.TestCommand innerCommand)

#### Methods
- public override NUnit.Framework.Internal.TestResult Execute(NUnit.Framework.Internal.ITestExecutionContext context)

### public class NUnit.Framework.Internal.Commands.TestActionItem

#### Fields
- private readonly NUnit.Framework.ITestAction _action
- private bool _beforeTestWasRun

#### Constructors
- public TestActionItem(NUnit.Framework.ITestAction action)

#### Methods
- public void AfterTest(NUnit.Framework.Interfaces.ITest test)
- public void BeforeTest(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.Commands.TestCommand

#### Fields
- private NUnit.Framework.Internal.Test <Test>k__BackingField

#### Properties
- public NUnit.Framework.Internal.Test Test { get; private set; }

#### Constructors
- public TestCommand(NUnit.Framework.Internal.Test test)

#### Methods
- public abstract NUnit.Framework.Internal.TestResult Execute(NUnit.Framework.Internal.ITestExecutionContext context)

### public class NUnit.Framework.Internal.Commands.TestMethodCommand
- Base: NUnit.Framework.Internal.Commands.TestCommand

#### Fields
- private readonly object[] arguments
- private readonly NUnit.Framework.Internal.TestMethod testMethod

#### Constructors
- public TestMethodCommand(NUnit.Framework.Internal.TestMethod testMethod)

#### Methods
- public override NUnit.Framework.Internal.TestResult Execute(NUnit.Framework.Internal.ITestExecutionContext context)
- private object RunNonAsyncTestMethod(NUnit.Framework.Internal.ITestExecutionContext context)
- private object RunTestMethod(NUnit.Framework.Internal.ITestExecutionContext context)

### public class NUnit.Framework.Internal.Commands.TheoryResultCommand
- Base: NUnit.Framework.Internal.Commands.DelegatingTestCommand

#### Constructors
- public TheoryResultCommand(NUnit.Framework.Internal.Commands.TestCommand command)

#### Methods
- public override NUnit.Framework.Internal.TestResult Execute(NUnit.Framework.Internal.ITestExecutionContext context)

## Namespace: NUnit.Framework.Internal.Execution

### public static class NUnit.Framework.Internal.Execution.CommandBuilder

#### Methods
- private static NUnit.Framework.Internal.Commands.SetUpTearDownItem BuildNode(System.Type fixtureType, System.Collections.Generic.IList<System.Reflection.MethodInfo> setUpMethods, System.Collections.Generic.IList<System.Reflection.MethodInfo> tearDownMethods)
- public static System.Collections.Generic.List<NUnit.Framework.Internal.Commands.SetUpTearDownItem> BuildSetUpTearDownList(System.Type fixtureType, System.Type setUpType, System.Type tearDownType)
- public static NUnit.Framework.Internal.Commands.TestCommand MakeOneTimeSetUpCommand(NUnit.Framework.Internal.TestSuite suite, System.Collections.Generic.List<NUnit.Framework.Internal.Commands.SetUpTearDownItem> setUpTearDown, System.Collections.Generic.List<NUnit.Framework.Internal.Commands.TestActionItem> actions)
- public static NUnit.Framework.Internal.Commands.TestCommand MakeOneTimeTearDownCommand(NUnit.Framework.Internal.TestSuite suite, System.Collections.Generic.List<NUnit.Framework.Internal.Commands.SetUpTearDownItem> setUpTearDownItems, System.Collections.Generic.List<NUnit.Framework.Internal.Commands.TestActionItem> actions)
- public static NUnit.Framework.Internal.Commands.SkipCommand MakeSkipCommand(NUnit.Framework.Internal.Test test)
- public static NUnit.Framework.Internal.Commands.TestCommand MakeTestCommand(NUnit.Framework.Internal.TestMethod test)
- private static System.Collections.Generic.List<System.Reflection.MethodInfo> SelectMethodsByDeclaringType(System.Type type, System.Collections.Generic.IList<System.Reflection.MethodInfo> methods)

### public class NUnit.Framework.Internal.Execution.CompositeWorkItem
- Base: NUnit.Framework.Internal.Execution.WorkItem

#### Fields
- private object cancelLock
- private NUnit.Framework.Interfaces.ITestFilter _childFilter
- private System.Collections.Generic.List<NUnit.Framework.Internal.Execution.WorkItem> _children
- private NUnit.Framework.Internal.Execution.CountdownEvent _childTestCountdown
- private object _completionLock
- private int _countOrder
- private NUnit.Framework.Internal.Commands.TestCommand _setupCommand
- private NUnit.Framework.Internal.TestSuite _suite
- private NUnit.Framework.Internal.TestSuiteResult _suiteResult
- private NUnit.Framework.Internal.Commands.TestCommand _teardownCommand

#### Properties
- public System.Collections.Generic.List<NUnit.Framework.Internal.Execution.WorkItem> Children { get; private set; }

#### Constructors
- public CompositeWorkItem(NUnit.Framework.Internal.TestSuite suite, NUnit.Framework.Interfaces.ITestFilter childFilter)

#### Methods
- public override void Cancel(bool force)
- private bool CheckForCancellation()
- private void CountDownChildTest()
- private void CreateChildWorkItems()
- private string GetProviderStackTrace()
- private string GetSkipReason()
- private void InitializeSetUpAndTearDownCommands()
- private static bool IsStaticClass(System.Type type)
- private void OnChildCompleted(object sender, System.EventArgs e)
- private void PerformOneTimeSetUp()
- private void PerformOneTimeTearDown()
- protected override void PerformWork()
- private void RunChildren()
- private void SkipChildren(NUnit.Framework.Internal.TestSuite suite, NUnit.Framework.Interfaces.ResultState resultState, string message)
- private void SkipFixture(NUnit.Framework.Interfaces.ResultState resultState, string message, string stackTrace)
- private void SortChildren()

### public class NUnit.Framework.Internal.Execution.CountdownEvent

#### Fields
- private System.Threading.ManualResetEvent _event
- private int _initialCount
- private object _lock
- private int _remainingCount

#### Properties
- public int CurrentCount { get; }
- public int InitialCount { get; }

#### Constructors
- public CountdownEvent(int initialCount)

#### Methods
- public void Signal()
- public void Wait()

### public class NUnit.Framework.Internal.Execution.EventListenerTextWriter
- Base: System.IO.TextWriter
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private System.IO.TextWriter _defaultWriter
- private string _streamName

#### Properties
- public System.Text.Encoding Encoding { get; }

#### Constructors
- public EventListenerTextWriter(string streamName, System.IO.TextWriter defaultWriter)

#### Methods
- private bool TrySendToListener(string text)
- public override void Write(char aChar)
- public override void Write(string aString)
- public override void WriteLine(string aString)

### public interface NUnit.Framework.Internal.Execution.IWorkItemDispatcher

#### Methods
- public void CancelRun(bool force)
- public void Dispatch(NUnit.Framework.Internal.Execution.WorkItem work)

### private enum NUnit.Framework.Internal.Execution.WorkItem.OwnThreadReason
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DifferentApartment = 4
- NotNeeded = 0
- RequiresThread = 1
- Timeout = 2

### public class NUnit.Framework.Internal.Execution.SimpleWorkItem
- Base: NUnit.Framework.Internal.Execution.WorkItem

#### Fields
- private NUnit.Framework.Internal.Commands.TestCommand _command

#### Constructors
- public SimpleWorkItem(NUnit.Framework.Internal.TestMethod test, NUnit.Framework.Interfaces.ITestFilter filter)

#### Methods
- protected override void PerformWork()

### public class NUnit.Framework.Internal.Execution.SimpleWorkItemDispatcher
- Interfaces: NUnit.Framework.Internal.Execution.IWorkItemDispatcher

#### Fields
- private object cancelLock
- private System.Threading.Thread _runnerThread
- private NUnit.Framework.Internal.Execution.WorkItem _topLevelWorkItem

#### Constructors
- public SimpleWorkItemDispatcher()

#### Methods
- public void CancelRun(bool force)
- public void Dispatch(NUnit.Framework.Internal.Execution.WorkItem work)
- private void RunnerThreadProc()

### public class NUnit.Framework.Internal.Execution.TextCapture
- Base: System.IO.TextWriter
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private System.IO.TextWriter _defaultWriter

#### Properties
- public System.Text.Encoding Encoding { get; }

#### Constructors
- public TextCapture(System.IO.TextWriter defaultWriter)

#### Methods
- public override void Write(char value)
- public override void Write(string value)
- public override void WriteLine(string value)

### public class NUnit.Framework.Internal.Execution.WorkItem

#### Fields
- private System.Collections.Generic.List<NUnit.Framework.ITestAction> <Actions>k__BackingField
- private NUnit.Framework.Internal.TestExecutionContext <Context>k__BackingField
- private System.Threading.ApartmentState <CurrentApartment>k__BackingField
- private NUnit.Framework.Internal.TestResult <Result>k__BackingField
- private NUnit.Framework.Internal.Execution.WorkItemState <State>k__BackingField
- private System.Threading.ApartmentState <TargetApartment>k__BackingField
- private NUnit.Framework.Internal.Test <Test>k__BackingField
- private string <WorkerId>k__BackingField
- private System.EventHandler Completed
- private static NUnit.Framework.Internal.Logger log
- private System.Threading.Thread thread
- private object threadLock

#### Properties
- public System.Collections.Generic.List<NUnit.Framework.ITestAction> Actions { get; private set; }
- public NUnit.Framework.Internal.TestExecutionContext Context { get; private set; }
- private System.Threading.ApartmentState CurrentApartment { get; set; }
- public NUnit.Framework.Internal.TestResult Result { get; protected set; }
- public NUnit.Framework.Internal.Execution.WorkItemState State { get; private set; }
- internal System.Threading.ApartmentState TargetApartment { get; set; }
- public NUnit.Framework.Internal.Test Test { get; private set; }
- public string WorkerId { get; internal set; }

#### Events
- public event System.EventHandler Completed

#### Constructors
- private static WorkItem()
- public WorkItem(NUnit.Framework.Internal.Test test)

#### Methods
- public virtual void Cancel(bool force)
- public static NUnit.Framework.Internal.Execution.WorkItem CreateWorkItem(NUnit.Framework.Interfaces.ITest test, NUnit.Framework.Interfaces.ITestFilter filter)
- public virtual void Execute()
- public void InitializeContext(NUnit.Framework.Internal.TestExecutionContext context)
- protected abstract void PerformWork()
- private void RunTest()
- private void RunTestOnOwnThread(int timeout, System.Threading.ApartmentState apartment)
- private void RunThread(int timeout)
- protected void WorkItemComplete()

### private class NUnit.Framework.Internal.Execution.CompositeWorkItem.WorkItemOrderComparer
- Interfaces: System.Collections.Generic.IComparer<NUnit.Framework.Internal.Execution.WorkItem>

#### Constructors
- public CompositeWorkItem.WorkItemOrderComparer()

#### Methods
- public int Compare(NUnit.Framework.Internal.Execution.WorkItem x, NUnit.Framework.Internal.Execution.WorkItem y)

### public enum NUnit.Framework.Internal.Execution.WorkItemState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Complete = 2
- Ready = 0
- Running = 1

## Namespace: NUnit.Framework.Internal.Filters

### public class NUnit.Framework.Internal.Filters.AndFilter
- Base: NUnit.Framework.Internal.Filters.CompositeFilter
- Interfaces: NUnit.Framework.Interfaces.ITestFilter, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Properties
- protected string ElementName { get; }

#### Constructors
- public AndFilter()
- public AndFilter(params NUnit.Framework.Interfaces.ITestFilter[] filters)

#### Methods
- public override bool IsExplicitMatch(NUnit.Framework.Interfaces.ITest test)
- public override bool Match(NUnit.Framework.Interfaces.ITest test)
- public override bool Pass(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.Filters.CategoryFilter
- Base: NUnit.Framework.Internal.Filters.ValueMatchFilter
- Interfaces: NUnit.Framework.Interfaces.ITestFilter, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Properties
- protected string ElementName { get; }

#### Constructors
- public CategoryFilter(string name)

#### Methods
- public override bool Match(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.Filters.ClassNameFilter
- Base: NUnit.Framework.Internal.Filters.ValueMatchFilter
- Interfaces: NUnit.Framework.Interfaces.ITestFilter, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Properties
- protected string ElementName { get; }

#### Constructors
- public ClassNameFilter(string expectedValue)

#### Methods
- public override bool Match(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.Filters.CompositeFilter
- Base: NUnit.Framework.Internal.TestFilter
- Interfaces: NUnit.Framework.Interfaces.ITestFilter, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Fields
- private System.Collections.Generic.IList<NUnit.Framework.Interfaces.ITestFilter> <Filters>k__BackingField

#### Properties
- protected string ElementName { get; }
- public System.Collections.Generic.IList<NUnit.Framework.Interfaces.ITestFilter> Filters { get; private set; }

#### Constructors
- public CompositeFilter()
- public CompositeFilter(params NUnit.Framework.Interfaces.ITestFilter[] filters)

#### Methods
- public void Add(NUnit.Framework.Interfaces.ITestFilter filter)
- public override NUnit.Framework.Interfaces.TNode AddToXml(NUnit.Framework.Interfaces.TNode parentNode, bool recursive)
- public abstract bool IsExplicitMatch(NUnit.Framework.Interfaces.ITest test)
- public abstract bool Match(NUnit.Framework.Interfaces.ITest test)
- public abstract bool Pass(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.Filters.FullNameFilter
- Base: NUnit.Framework.Internal.Filters.ValueMatchFilter
- Interfaces: NUnit.Framework.Interfaces.ITestFilter, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Properties
- protected string ElementName { get; }

#### Constructors
- public FullNameFilter(string expectedValue)

#### Methods
- public override bool Match(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.Filters.IdFilter
- Base: NUnit.Framework.Internal.Filters.ValueMatchFilter
- Interfaces: NUnit.Framework.Interfaces.ITestFilter, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Properties
- protected string ElementName { get; }

#### Constructors
- public IdFilter(string id)

#### Methods
- public override bool Match(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.Filters.MethodNameFilter
- Base: NUnit.Framework.Internal.Filters.ValueMatchFilter
- Interfaces: NUnit.Framework.Interfaces.ITestFilter, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Properties
- protected string ElementName { get; }

#### Constructors
- public MethodNameFilter(string expectedValue)

#### Methods
- public override bool Match(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.Filters.NotFilter
- Base: NUnit.Framework.Internal.TestFilter
- Interfaces: NUnit.Framework.Interfaces.ITestFilter, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Fields
- private NUnit.Framework.Internal.TestFilter <BaseFilter>k__BackingField

#### Properties
- public NUnit.Framework.Internal.TestFilter BaseFilter { get; private set; }

#### Constructors
- public NotFilter(NUnit.Framework.Internal.TestFilter baseFilter)

#### Methods
- public override NUnit.Framework.Interfaces.TNode AddToXml(NUnit.Framework.Interfaces.TNode parentNode, bool recursive)
- public override bool IsExplicitMatch(NUnit.Framework.Interfaces.ITest test)
- public override bool Match(NUnit.Framework.Interfaces.ITest test)
- public override bool Pass(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.Filters.OrFilter
- Base: NUnit.Framework.Internal.Filters.CompositeFilter
- Interfaces: NUnit.Framework.Interfaces.ITestFilter, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Properties
- protected string ElementName { get; }

#### Constructors
- public OrFilter()
- public OrFilter(params NUnit.Framework.Interfaces.ITestFilter[] filters)

#### Methods
- public override bool IsExplicitMatch(NUnit.Framework.Interfaces.ITest test)
- public override bool Match(NUnit.Framework.Interfaces.ITest test)
- public override bool Pass(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.Filters.PropertyFilter
- Base: NUnit.Framework.Internal.Filters.ValueMatchFilter
- Interfaces: NUnit.Framework.Interfaces.ITestFilter, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Fields
- private string _propertyName

#### Properties
- protected string ElementName { get; }

#### Constructors
- public PropertyFilter(string propertyName, string expectedValue)

#### Methods
- public override NUnit.Framework.Interfaces.TNode AddToXml(NUnit.Framework.Interfaces.TNode parentNode, bool recursive)
- public override bool Match(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.Filters.TestNameFilter
- Base: NUnit.Framework.Internal.Filters.ValueMatchFilter
- Interfaces: NUnit.Framework.Interfaces.ITestFilter, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Properties
- protected string ElementName { get; }

#### Constructors
- public TestNameFilter(string expectedValue)

#### Methods
- public override bool Match(NUnit.Framework.Interfaces.ITest test)

### public class NUnit.Framework.Internal.Filters.ValueMatchFilter
- Base: NUnit.Framework.Internal.TestFilter
- Interfaces: NUnit.Framework.Interfaces.ITestFilter, NUnit.Framework.Interfaces.IXmlNodeBuilder

#### Fields
- private string <ExpectedValue>k__BackingField
- private bool <IsRegex>k__BackingField

#### Properties
- protected string ElementName { get; }
- public string ExpectedValue { get; private set; }
- public bool IsRegex { get; set; }

#### Constructors
- public ValueMatchFilter(string expectedValue)

#### Methods
- public override NUnit.Framework.Interfaces.TNode AddToXml(NUnit.Framework.Interfaces.TNode parentNode, bool recursive)
- protected bool Match(string input)

## Namespace: System

### internal class System.Lazy<T>

#### Fields
- private System.Exception exception
- private System.Func<T> factory
- private bool inited
- private System.Threading.LazyThreadSafetyMode mode
- private object monitor
- private T value

#### Properties
- public bool IsValueCreated { get; }
- public T Value { get; }

#### Constructors
- public Lazy<T>()
- public Lazy<T>(System.Func<T> valueFactory)
- public Lazy<T>(bool isThreadSafe)
- public Lazy<T>(System.Threading.LazyThreadSafetyMode mode)
- public Lazy<T>(System.Func<T> valueFactory, bool isThreadSafe)
- public Lazy<T>(System.Func<T> valueFactory, System.Threading.LazyThreadSafetyMode mode)

#### Methods
- private T InitValue()
- public override string ToString()

## Namespace: System.Collections.Concurrent

### private class System.Collections.Concurrent.ConcurrentQueue<T>.<InternalGetEnumerator>d__13<T>
- Interfaces: System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private T <>2__current
- public System.Collections.Concurrent.ConcurrentQueue<T> <>4__this
- private System.Collections.Concurrent.ConcurrentQueue<T>.Node<T> <my_head>5__1

#### Properties
- private T System.Collections.Generic.IEnumerator<T>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public ConcurrentQueue<T>.<InternalGetEnumerator>d__13<T>(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### internal class System.Collections.Concurrent.ConcurrentQueue<T>
- Interfaces: System.Collections.Concurrent.IProducerConsumerCollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection

#### Fields
- private int count
- private System.Collections.Concurrent.ConcurrentQueue<T>.Node<T> head
- private System.Collections.Concurrent.ConcurrentQueue<T>.Node<T> tail

#### Properties
- public int Count { get; }
- public bool IsEmpty { get; }
- private bool System.Collections.ICollection.IsSynchronized { get; }
- private object System.Collections.ICollection.SyncRoot { get; }

#### Constructors
- public ConcurrentQueue<T>()
- public ConcurrentQueue<T>(System.Collections.Generic.IEnumerable<T> collection)

#### Methods
- internal void Clear()
- public void CopyTo(T[] array, int index)
- public void Enqueue(T item)
- public System.Collections.Generic.IEnumerator<T> GetEnumerator()
- private System.Collections.Generic.IEnumerator<T> InternalGetEnumerator()
- private bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(T item)
- private bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(out T item)
- private void System.Collections.ICollection.CopyTo(System.Array array, int index)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- public T[] ToArray()
- public bool TryDequeue(out T result)
- public bool TryPeek(out T result)

### internal interface System.Collections.Concurrent.IProducerConsumerCollection<T>
- Interfaces: System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection

#### Methods
- public void CopyTo(T[] array, int index)
- public T[] ToArray()
- public bool TryAdd(T item)
- public bool TryTake(out T item)

### private class System.Collections.Concurrent.ConcurrentQueue<T>.Node<T>

#### Fields
- public System.Collections.Concurrent.ConcurrentQueue<T>.Node<T> Next
- public T Value

#### Constructors
- public ConcurrentQueue<T>.Node<T>()

## Namespace: System.Collections.Generic

### internal class System.Collections.Generic.CollectionDebuggerView<T>

#### Fields
- private readonly System.Collections.Generic.ICollection<T> c

#### Properties
- public T[] Items { get; }

#### Constructors
- public CollectionDebuggerView<T>(System.Collections.Generic.ICollection<T> col)

### internal class System.Collections.Generic.CollectionDebuggerView<T, U>

#### Fields
- private readonly System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<T, U>> c

#### Properties
- public System.Collections.Generic.KeyValuePair<T, U>[] Items { get; }

#### Constructors
- public CollectionDebuggerView<T, U>(System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<T, U>> col)

## Namespace: System.Threading

### internal enum System.Threading.LazyThreadSafetyMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ExecutionAndPublication = 2
- None = 0
- PublicationOnly = 1

### internal struct System.Threading.SpinWait

#### Fields
- private static readonly bool isSingleCpu
- private static const int maxTime
- private int ntime
- private static const int step

#### Properties
- public int Count { get; }
- public bool NextSpinWillYield { get; }

#### Constructors
- private static SpinWait()

#### Methods
- public void Reset()
- public void SpinOnce()
- public static void SpinUntil(System.Func<bool> condition)
- public static bool SpinUntil(System.Func<bool> condition, System.TimeSpan timeout)
- public static bool SpinUntil(System.Func<bool> condition, int millisecondsTimeout)

## Namespace: System.Web.UI

### public interface System.Web.UI.ICallbackEventHandler

#### Methods
- public string GetCallbackResult()
- public void RaiseCallbackEvent(string report)

