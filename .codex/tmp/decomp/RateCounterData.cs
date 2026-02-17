internal struct RateCounterData
{
	public double timestamp;

	public double value;

	public RateCounterData(double pTimestamp, double pValue = 0.0)
	{
		timestamp = pTimestamp;
		value = pValue;
	}
}
