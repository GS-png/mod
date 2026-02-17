using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEngine;

public static class Randy
{
	internal static System.Random rnd = new System.Random(123);

	internal static Unity.Mathematics.Random rand = new Unity.Mathematics.Random(123u);

	internal static Unity.Mathematics.Random debug_rand = new Unity.Mathematics.Random(123u);

	private static long _seed = 1L;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
	private static void OnBeforeSplashScreen()
	{
		fullReset();
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void OnBeforeSceneLoad()
	{
		fullReset();
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	private static void OnAfterSceneLoad()
	{
		fullReset();
	}

	internal static void fullReset()
	{
		int year = DateTime.Now.Year;
		int month = DateTime.Now.Month;
		int day = DateTime.Now.Day;
		int hour = DateTime.Now.Hour;
		_seed = year * 100000 + month * 1000 + day * 10 + hour / 3;
		nextSeed();
	}

	internal static void nextSeed()
	{
		_seed += 543L;
		resetSeed(_seed);
	}

	public static void resetSeed(long pLongValue)
	{
		if (pLongValue == 0L)
		{
			pLongValue = 1L;
		}
		int seed = (int)pLongValue;
		uint seed2 = (uint)pLongValue;
		UnityEngine.Random.InitState(seed);
		rnd = new System.Random(seed);
		rand = new Unity.Mathematics.Random(seed2);
		rand.NextBool();
	}

	public static void resetSeed(int pIntValue)
	{
		if (pIntValue == 0)
		{
			pIntValue = 1;
		}
		UnityEngine.Random.InitState(pIntValue);
		uint seed = (uint)pIntValue;
		rnd = new System.Random(pIntValue);
		rand = new Unity.Mathematics.Random(seed);
		rand.NextBool();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	public static int randomInt(int pMinInclusive, int pMaxExclusive)
	{
		return rand.NextInt(pMinInclusive, pMaxExclusive);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	public static bool randomBool()
	{
		return rand.NextBool();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	public static bool randomChance(float pVal)
	{
		float num = random();
		return pVal >= num;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	public static float random()
	{
		return rand.NextFloat();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	public static float randomFloat(float pMinInclusive, float pMaxExclusive)
	{
		return rand.NextFloat(pMinInclusive, pMaxExclusive);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	public static Vector2 randomPointOnCircle(float pRadiusMinInclusive, float pRadiusMaxExclusive)
	{
		return getRandomPointInUnitCircle().normalized * randomFloat(pRadiusMinInclusive, pRadiusMaxExclusive);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	public static Vector2 getRandomPointInUnitCircle()
	{
		float num = Mathf.Sqrt(random());
		float f = random() * 2f * MathF.PI;
		return new Vector2(num * Mathf.Cos(f), num * Mathf.Sin(f));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	public static T getRandom<T>(T[] pArray)
	{
		return pArray.GetRandom();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[CanBeNull]
	public static T getRandom<T>(List<T> pList)
	{
		if (pList.Count == 0)
		{
			return default(T);
		}
		return pList.GetRandom();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[CanBeNull]
	public static T getRandom<T>(ListPool<T> pList)
	{
		if (pList.Count == 0)
		{
			return default(T);
		}
		return pList.GetRandom();
	}

	[Pure]
	public static T RandomEnumValue<T>() where T : Enum
	{
		Array values = Enum.GetValues(typeof(T));
		return (T)values.GetValue(randomInt(0, values.Length));
	}

	[Pure]
	public static Color getRandomColor()
	{
		return new Color(random(), random(), random(), 1f);
	}

	[Pure]
	public static Color ColorHSV()
	{
		return ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 1f, 1f);
	}

	[Pure]
	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax)
	{
		float h = Mathf.Lerp(hueMin, hueMax, debug_rand.NextFloat());
		float s = Mathf.Lerp(saturationMin, saturationMax, debug_rand.NextFloat());
		float v = Mathf.Lerp(valueMin, valueMax, debug_rand.NextFloat());
		Color result = Color.HSVToRGB(h, s, v, hdr: true);
		result.a = Mathf.Lerp(alphaMin, alphaMax, debug_rand.NextFloat());
		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static IEnumerable<T> LoopRandom<T>(this List<T> list)
	{
		return new RandomListEnumerator<T>(list);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static IEnumerable<T> LoopRandom<T>(this List<T> list, int pMax)
	{
		return new RandomListEnumerator<T>(list, list.Count, pMax);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static IEnumerable<T> LoopRandom<T>(this T[] array)
	{
		return new RandomArrayEnumerator<T>(array);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static IEnumerable<T> LoopRandom<T>(this T[] array, int pLength)
	{
		return new RandomArrayEnumerator<T>(array, pLength);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static IEnumerable<T> LoopRandom<T>(this T[] array, int pLength, int pMax)
	{
		return new RandomArrayEnumerator<T>(array, pLength, pMax);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static IEnumerable<T> LoopRandom<T>(this ListPool<T> list)
	{
		return new RandomArrayEnumerator<T>(list.GetRawBuffer(), list.Count);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static IEnumerable<T> LoopRandom<T>(this ListPool<T> list, int pMax)
	{
		return new RandomArrayEnumerator<T>(list.GetRawBuffer(), list.Count, pMax);
	}

	public static IEnumerable<T> LoopRandom<T>(this IEnumerable<T> pEnumerable)
	{
		ListPool<T> tPool = null;
		IEnumerable<T> enumerable;
		if (!(pEnumerable is List<T> list))
		{
			if (!(pEnumerable is T[] array))
			{
				if (pEnumerable is ListPool<T> list2)
				{
					enumerable = list2.LoopRandom();
				}
				else
				{
					tPool = new ListPool<T>(pEnumerable);
					enumerable = tPool.LoopRandom();
				}
			}
			else
			{
				enumerable = array.LoopRandom(array.Length);
			}
		}
		else
		{
			enumerable = list.LoopRandom();
		}
		try
		{
			foreach (T item in enumerable)
			{
				yield return item;
			}
		}
		finally
		{
			tPool?.Dispose();
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static IEnumerable<T> LoopRandom<T>(this IEnumerable<T> pEnumerable, int pMax)
	{
		ListPool<T> tPool = null;
		IEnumerable<T> enumerable;
		if (!(pEnumerable is List<T> list))
		{
			if (!(pEnumerable is T[] array))
			{
				if (pEnumerable is ListPool<T> list2)
				{
					enumerable = list2.LoopRandom(pMax);
				}
				else
				{
					tPool = new ListPool<T>(pEnumerable);
					enumerable = tPool.LoopRandom(pMax);
				}
			}
			else
			{
				enumerable = array.LoopRandom(array.Length, pMax);
			}
		}
		else
		{
			enumerable = list.LoopRandom(pMax);
		}
		try
		{
			foreach (T item in enumerable)
			{
				yield return item;
			}
		}
		finally
		{
			tPool?.Dispose();
		}
	}
}
