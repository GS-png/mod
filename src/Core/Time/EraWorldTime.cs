namespace EraWheel.Core.Time;

public static class EraWorldTime
{
    public static float MonthToWorldTime(float months)
    {
        return months * GetMonthWorldTime();
    }

    public static float YearsToWorldTime(float years)
    {
        return years * GetYearWorldTime();
    }

    public static float GetMonthWorldTime()
    {
        return global::Date.getMonthTime();
    }

    public static float GetYearWorldTime()
    {
        return GetMonthWorldTime() * 12f;
    }

    public static int GetMonth(float worldTime)
    {
        return global::Date.getMonth(worldTime);
    }

    public static int GetYear(float worldTime)
    {
        return global::Date.getYear(worldTime);
    }

    public static string GetYearDate(float worldTime)
    {
        return global::Date.getYearDate(worldTime);
    }

    public static float GetElapsedYears(float worldTimeDelta)
    {
        return worldTimeDelta / GetYearWorldTime();
    }

    public static float GetDeltaByPercentPerYear(float percentPerYear, float worldTimeDelta)
    {
        return percentPerYear * GetElapsedYears(worldTimeDelta);
    }
}
