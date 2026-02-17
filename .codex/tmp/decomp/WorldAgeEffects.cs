using System.Collections.Generic;
using UnityEngine;

public class WorldAgeEffects : MonoBehaviour
{
	internal Dictionary<string, SpriteRenderer> dict_effects = new Dictionary<string, SpriteRenderer>();

	public static WorldAgeEffects instance;

	public bool override_night;

	[Range(0f, 1f)]
	public float night_value_top;

	[Range(0f, 1f)]
	public float night_value_mat;

	public void Awake()
	{
		instance = this;
		for (int i = 0; i < base.transform.childCount; i++)
		{
			SpriteRenderer component = base.transform.GetChild(i).GetComponent<SpriteRenderer>();
			Color color = component.color;
			color.a = 0f;
			component.color = color;
			dict_effects.Add(component.name, component);
		}
	}

	public void update(float pElapsed)
	{
		fitTheCamera();
		updateEffects(pElapsed);
	}

	private void updateEffects(float pElapsed)
	{
		updateLayer(World.world_era.overlay_chaos, "chaos", pElapsed);
		updateLayer(World.world_era.overlay_moon, "moon", pElapsed);
		updateLayer(World.world_era.overlay_magic, "magic", pElapsed);
		updateLayer(World.world_era.overlay_sun, "sun", pElapsed);
		updateLayer(World.world_era.overlay_rain_darkness, "rain_darkness", pElapsed);
		updateLayer(World.world_era.overlay_winter, "winter", pElapsed);
		updateLayer(World.world_era.overlay_ash, "ash", pElapsed);
		updateLayer(World.world_era.overlay_night, "night", pElapsed);
		updateLayer(World.world_era.overlay_rain, "rain", pElapsed);
	}

	private void updateLayer(bool pEnabled, string pID, float pElapsed)
	{
		SpriteRenderer value = null;
		if (!dict_effects.TryGetValue(pID, out value))
		{
			Debug.LogError("NO ERA EFFECT " + pID);
			return;
		}
		Color color = value.color;
		if (override_night)
		{
			color.a = night_value_top;
			value.color = color;
			return;
		}
		if (pEnabled)
		{
			float num = PlayerConfig.getIntValue("age_overlay_effect");
			float num2 = World.world_era.era_effect_overlay_alpha * (num / 100f);
			value.enabled = num > 0f;
			if (color.a < num2)
			{
				color.a += pElapsed * 0.2f;
				if (color.a > num2)
				{
					color.a = num2;
				}
				value.color = color;
			}
			if (color.a > num2)
			{
				color.a -= pElapsed * 0.7f;
				if (color.a < num2)
				{
					color.a = num2;
				}
				value.color = color;
			}
		}
		if (!pEnabled && value.enabled && color.a > 0f)
		{
			color.a -= pElapsed * 0.2f;
			if (color.a <= 0f)
			{
				value.enabled = false;
			}
			value.color = color;
		}
	}

	private void fitTheCamera()
	{
		base.transform.localScale = new Vector3(1f, 1f, 1f);
		float num = World.world.camera.orthographicSize * 2f;
		float x = num / (float)Screen.height * (float)Screen.width;
		base.transform.localScale = new Vector3(x, num);
	}
}
