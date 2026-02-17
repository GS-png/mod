using UnityEngine;
using ai.behaviours;

public class TesterBehSpawnPower : BehaviourActionTester
{
	protected string _power;

	public TesterBehSpawnPower(string pPower = null)
	{
		_power = pPower;
	}

	public override BehResult execute(AutoTesterBot pObject)
	{
		string power = _power;
		int x = Randy.randomInt(0, MapBox.width);
		int y = Randy.randomInt(0, MapBox.height);
		if (!AssetManager.powers.dict.ContainsKey(power))
		{
			Debug.LogError("TESTER ERROR... " + power);
			return BehResult.Continue;
		}
		GodPower pPower = AssetManager.powers.get(power);
		string current_brush = Config.current_brush;
		Config.current_brush = Brush.getRandom();
		pObject.debugString = "rand_power_" + power;
		BehaviourActionBase<AutoTesterBot>.world.player_control.clickedFinal(new Vector2Int(x, y), pPower);
		Config.current_brush = current_brush;
		return base.execute(pObject);
	}
}
