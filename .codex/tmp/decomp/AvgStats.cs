public readonly struct AvgStats
{
	public readonly double avg;

	public readonly int count;

	public readonly string name;

	public AvgStats(double pAvg, int pCount, string pName)
	{
		avg = pAvg;
		count = pCount;
		name = pName;
	}

	public AvgStats add(double pValue)
	{
		double pAvg = (avg * (double)count + pValue) / (double)(count + 1);
		int pCount = count + 1;
		return new AvgStats(pAvg, pCount, name);
	}
}
