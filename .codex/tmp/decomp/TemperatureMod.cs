internal readonly struct TemperatureMod
{
	public readonly Actor actor;

	public readonly int new_temperature;

	public TemperatureMod(Actor pActor, int pNewTemperature)
	{
		actor = pActor;
		new_temperature = pNewTemperature;
	}
}
