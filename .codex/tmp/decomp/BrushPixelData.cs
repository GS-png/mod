using System;
using Newtonsoft.Json;

[Serializable]
[JsonConverter(typeof(BrushPixelDataConverter))]
public readonly struct BrushPixelData : IEquatable<BrushPixelData>
{
	public readonly int x;

	public readonly int y;

	public readonly int dist;

	public BrushPixelData(int pX, int pY, int pDist)
	{
		x = pX;
		y = pY;
		dist = pDist;
	}

	public bool Equals(BrushPixelData pOther)
	{
		if (x == pOther.x)
		{
			return y == pOther.y;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return x * 100000 + y;
	}
}
