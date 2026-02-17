using FMOD.Studio;
using UnityEngine;

public class DebugTextGroupSystem : SpriteGroupSystem<GroupSpriteObject>
{
	private Vector2 _pos;

	public override void create()
	{
		base.create();
		base.transform.name = "Debug Text";
		GameObject gameObject = (GameObject)Resources.Load("Prefabs/PrefabDebugText");
		prefab = gameObject.GetComponent<GroupSpriteObject>();
	}

	protected override GroupSpriteObject createNew()
	{
		GroupSpriteObject groupSpriteObject = base.createNew();
		groupSpriteObject.GetComponent<DebugWorldText>().create();
		return groupSpriteObject;
	}

	public override void update(float pElapsed)
	{
		prepare();
		checkSoundsAttached();
		checkSounds();
		checkSoundsPlaying();
		checkActors();
		checkBoats();
		checkBuildings();
		checkCitiesOverlay();
		checkCitiesTasksOverlay();
		checkKingdoms();
		checkArmies();
		checkZones();
		base.update(pElapsed);
	}

	private void checkSoundsPlaying()
	{
		if (!DebugConfig.isOn(DebugOption.OverlaySoundsActive) || MapBox.isRenderMiniMap())
		{
			return;
		}
		foreach (DebugMusicBoxData item in MusicBox.inst.debug_box.list)
		{
			if (item.isPlaying())
			{
				GroupSpriteObject next = getNext();
				_pos.x = item.x;
				_pos.y = item.y;
				next.GetComponent<DebugWorldText>().setTextFmodSound(item, Color.green);
				next.setPosOnly(ref _pos);
			}
		}
	}

	private void checkSounds()
	{
		if (!DebugConfig.isOn(DebugOption.OverlaySounds) || MapBox.isRenderMiniMap())
		{
			return;
		}
		foreach (DebugMusicBoxData item in MusicBox.inst.debug_box.list)
		{
			GroupSpriteObject next = getNext();
			_pos.x = item.x;
			_pos.y = item.y;
			next.GetComponent<DebugWorldText>().setTextFmodSound(item);
			next.setPosOnly(ref _pos);
		}
	}

	private void checkSoundsAttached()
	{
		if (!DebugConfig.isOn(DebugOption.OverlaySoundsAttached) || MapBox.isRenderMiniMap())
		{
			return;
		}
		foreach (EventInstance value in MusicBox.inst.idle.currentAttachedSounds.Values)
		{
			GroupSpriteObject next = getNext();
			value.get3DAttributes(out var attributes);
			_pos.x = attributes.position.x;
			_pos.y = attributes.position.y;
			next.GetComponent<DebugWorldText>().setTextFmodSound(value);
			next.setPosOnly(ref _pos);
		}
		foreach (QuantumSpriteAsset item in AssetManager.quantum_sprites.list)
		{
			int num = item.group_system.countActive();
			QuantumSprite[] all = item.group_system.getAll();
			for (int i = 0; i < num; i++)
			{
				QuantumSprite quantumSprite = all[i];
				if (quantumSprite.fmod_instance.isValid())
				{
					quantumSprite.fmod_instance.get3DAttributes(out var attributes2);
					_pos.x = attributes2.position.x;
					_pos.y = attributes2.position.y;
					GroupSpriteObject next2 = getNext();
					next2.GetComponent<DebugWorldText>().setTextFmodSound(quantumSprite.fmod_instance);
					next2.setPosOnly(ref _pos);
				}
			}
		}
		Actor[] array = World.world.units.visible_units.array;
		int count = World.world.units.visible_units.count;
		for (int j = 0; j < count; j++)
		{
			Actor actor = array[j];
			if (actor.idle_loop_sound != null && actor.idle_loop_sound.fmod_instance.isValid())
			{
				actor.idle_loop_sound.fmod_instance.get3DAttributes(out var attributes3);
				_pos.x = attributes3.position.x;
				_pos.y = attributes3.position.y;
				GroupSpriteObject next3 = getNext();
				next3.GetComponent<DebugWorldText>().setTextFmodSound(actor.idle_loop_sound.fmod_instance);
				next3.setPosOnly(ref _pos);
			}
		}
	}

	private void checkBoats()
	{
		if (!DebugConfig.isOn(DebugOption.OverlayBoatTransport))
		{
			return;
		}
		foreach (Actor unit in World.world.units)
		{
			bool flag = false;
			if (unit.asset.is_boat)
			{
				flag = true;
			}
			if (flag)
			{
				GroupSpriteObject next = getNext();
				_pos.x = unit.current_position.x;
				_pos.y = unit.current_position.y;
				next.GetComponent<DebugWorldText>().setTextBoat(unit);
				next.setPosOnly(ref _pos);
			}
		}
	}

	private void checkActors()
	{
		if ((!DebugConfig.isOn(DebugOption.OverlayActorCivs) && !DebugConfig.isOn(DebugOption.OverlayCursorActor) && !DebugConfig.isOn(DebugOption.OverlayActorGroupLeaderOnly) && !DebugConfig.isOn(DebugOption.OverlayActorFavoritesOnly) && !DebugConfig.isOn(DebugOption.OverlayActorMobs)) || MapBox.isRenderMiniMap())
		{
			return;
		}
		Actor[] array = World.world.units.visible_units.array;
		int count = World.world.units.visible_units.count;
		for (int i = 0; i < count; i++)
		{
			Actor actor = array[i];
			bool flag = false;
			if (DebugConfig.isOn(DebugOption.OverlayCursorActor) && UnitSelectionEffect.last_actor == actor)
			{
				flag = true;
			}
			if (DebugConfig.isOn(DebugOption.OverlayActorFavoritesOnly) && actor.isFavorite())
			{
				flag = true;
			}
			if (DebugConfig.isOn(DebugOption.OverlayActorGroupLeaderOnly) && actor.is_army_captain)
			{
				flag = true;
			}
			if (actor.isSapient() && DebugConfig.isOn(DebugOption.OverlayActorCivs))
			{
				flag = true;
			}
			if (!actor.isSapient() && DebugConfig.isOn(DebugOption.OverlayActorMobs))
			{
				flag = true;
			}
			if (flag)
			{
				GroupSpriteObject next = getNext();
				_pos.x = actor.current_position.x;
				_pos.y = actor.current_position.y;
				next.GetComponent<DebugWorldText>().setTextActor(actor);
				next.setPosOnly(ref _pos);
			}
		}
	}

	private void checkBuildings()
	{
		if ((!DebugConfig.isOn(DebugOption.OverlayTrees) && !DebugConfig.isOn(DebugOption.OverlayPlants) && !DebugConfig.isOn(DebugOption.OverlayCivBuildings) && !DebugConfig.isOn(DebugOption.OverlayOtherBuildings)) || MapBox.isRenderMiniMap())
		{
			return;
		}
		int num = World.world.buildings.countVisibleBuildings();
		Building[] visibleBuildings = World.world.buildings.getVisibleBuildings();
		for (int i = 0; i < num; i++)
		{
			Building building = visibleBuildings[i];
			if (building.asset.city_building)
			{
				if (!DebugConfig.isOn(DebugOption.OverlayCivBuildings))
				{
					continue;
				}
			}
			else if (building.asset.building_type == BuildingType.Building_Tree)
			{
				if (!DebugConfig.isOn(DebugOption.OverlayTrees))
				{
					continue;
				}
			}
			else if (building.asset.building_type == BuildingType.Building_Plant)
			{
				if (!DebugConfig.isOn(DebugOption.OverlayPlants))
				{
					continue;
				}
			}
			else if (!DebugConfig.isOn(DebugOption.OverlayOtherBuildings))
			{
				continue;
			}
			GroupSpriteObject next = getNext();
			_pos.x = building.current_position.x;
			_pos.y = building.current_position.y;
			next.GetComponent<DebugWorldText>().setTextBuilding(building);
			next.setPosOnly(ref _pos);
		}
	}

	private void checkZones()
	{
		if (!DebugConfig.isOn(DebugOption.DebugZones))
		{
			return;
		}
		foreach (TileZone zone in World.world.zone_calculator.zones)
		{
			if (zone.debug_show)
			{
				GroupSpriteObject next = getNext();
				_pos.x = zone.centerTile.pos.x;
				_pos.y = zone.centerTile.pos.y;
				next.GetComponent<DebugWorldText>().setTextZone(zone);
				next.setPosOnly(ref _pos);
			}
		}
	}

	private void checkArmies()
	{
		if (!DebugConfig.isOn(DebugOption.OverlayArmies) || MapBox.isRenderMiniMap())
		{
			return;
		}
		foreach (Army army in World.world.armies)
		{
			if (army.hasCaptain())
			{
				Actor captain = army.getCaptain();
				GroupSpriteObject next = getNext();
				_pos.x = captain.current_position.x;
				_pos.y = captain.current_position.y;
				next.GetComponent<DebugWorldText>().setTextArmy(army);
				next.setPosOnly(ref _pos);
			}
		}
	}

	private void checkCitiesOverlay()
	{
		if (!DebugConfig.isOn(DebugOption.OverlayCity))
		{
			return;
		}
		foreach (City city in World.world.cities)
		{
			GroupSpriteObject next = getNext();
			_pos.x = city.city_center.x;
			_pos.y = city.city_center.y;
			next.GetComponent<DebugWorldText>().setTextCity(city);
			next.setPosOnly(ref _pos);
		}
	}

	private void checkCitiesTasksOverlay()
	{
		if (!DebugConfig.isOn(DebugOption.OverlayCityTasks))
		{
			return;
		}
		foreach (City city in World.world.cities)
		{
			GroupSpriteObject next = getNext();
			_pos.x = city.city_center.x;
			_pos.y = city.city_center.y;
			next.GetComponent<DebugWorldText>().setTextCityTasks(city);
			next.setPosOnly(ref _pos);
		}
	}

	private void checkKingdoms()
	{
		if (!DebugConfig.isOn(DebugOption.OverlayKingdom))
		{
			return;
		}
		foreach (Kingdom kingdom in World.world.kingdoms)
		{
			if (kingdom.hasCapital())
			{
				GroupSpriteObject next = getNext();
				_pos.x = kingdom.capital.city_center.x;
				_pos.y = kingdom.capital.city_center.y;
				next.GetComponent<DebugWorldText>().setTextKingdom(kingdom);
				next.setPosOnly(ref _pos);
			}
		}
	}
}
