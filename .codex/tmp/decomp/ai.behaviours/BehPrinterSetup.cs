namespace ai.behaviours;

public class BehPrinterSetup : BehaviourActionActor
{
	public override BehResult execute(Actor pActor)
	{
		pActor.data.get("step", out var pResult, -1);
		if (pResult < 0)
		{
			pActor.data.set("origin_x", pActor.current_tile.pos.x);
			pActor.data.set("origin_y", pActor.current_tile.pos.y);
			pActor.data.get("template", out var pResult2, null);
			PrintTemplate template = PrintLibrary.getTemplate(pResult2);
			pActor.data.set("steps", template.steps.Length);
			pActor.data.set("step", 0);
		}
		pActor.data.get("steps", out var pResult3, -1);
		if (pResult >= pResult3)
		{
			pActor.dieSimpleNone();
			return BehResult.Stop;
		}
		return BehResult.Continue;
	}
}
