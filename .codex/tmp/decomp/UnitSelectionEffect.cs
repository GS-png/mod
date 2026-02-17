using UnityEngine;

public class UnitSelectionEffect : BaseAnimatedObject
{
	public static Actor last_actor;

	private bool _is_visible = true;

	internal override void create()
	{
		base.create();
		base.transform.parent = World.world.transform;
		base.transform.name = "unit_selector_effect";
	}

	public override void update(float pElapsed)
	{
		base.update(pElapsed);
		bool visible = visibleCheck();
		setVisible(visible);
	}

	public bool visibleCheck()
	{
		if (!MapBox.isRenderGameplay())
		{
			return false;
		}
		if (World.world.isAnyPowerSelected())
		{
			GodPower godPower = World.world.selected_buttons.selectedButton.godPower;
			if (!godPower.allow_unit_selection && !godPower.show_close_actor)
			{
				return false;
			}
		}
		if (World.world.isBusyWithUI())
		{
			return false;
		}
		Actor actor = World.world.getActorNearCursor();
		if (ControllableUnit.isControllingUnit())
		{
			actor = null;
		}
		setLastActor(actor);
		if (actor == null)
		{
			return false;
		}
		return true;
	}

	public void setVisible(bool pVisible)
	{
		if (pVisible != _is_visible)
		{
			base.gameObject.SetActive(pVisible);
			if (!pVisible)
			{
				base.transform.position = Globals.POINT_IN_VOID;
				base.transform.localScale = Vector3.one;
				setLastActor(null);
			}
		}
		if (pVisible)
		{
			base.transform.position = last_actor.current_position;
			base.transform.localScale = last_actor.current_scale;
		}
		_is_visible = pVisible;
	}

	public static void setLastActor(Actor pActor)
	{
		last_actor = pActor;
	}
}
