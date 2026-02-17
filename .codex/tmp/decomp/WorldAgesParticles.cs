using UnityEngine;

public class WorldAgesParticles : MonoBehaviour
{
	public static bool effects_enabled = true;

	private ParticleSystem _system_rain;

	private Material _mat_rain;

	private ParticleSystem _system_snow;

	private Material _mat_snow;

	private ParticleSystem _system_magic;

	private Material _mat_magic;

	private ParticleSystem _system_ash;

	private Material _mat_ash;

	private ParticleSystem _system_sun_blobs;

	private Material _mat_sun_blobs;

	private ParticleSystem _system_sun_rays;

	private Material _mat_sun_ray;

	private Camera _camera;

	private void Awake()
	{
		setSystem("Rain", out _system_rain, out _mat_rain);
		setSystem("Snow", out _system_snow, out _mat_snow);
		setSystem("Magic", out _system_magic, out _mat_magic);
		setSystem("Ash", out _system_ash, out _mat_ash);
		setSystem("Sun Blobs", out _system_sun_blobs, out _mat_sun_blobs);
		setSystem("Sun Rays", out _system_sun_rays, out _mat_sun_ray);
	}

	private void setSystem(string pID, out ParticleSystem pSystem, out Material pMat)
	{
		pSystem = base.transform.Find(pID).GetComponent<ParticleSystem>();
		pMat = pSystem.GetComponent<Renderer>().material;
		pSystem.Stop(withChildren: false, ParticleSystemStopBehavior.StopEmittingAndClear);
		Color color = pMat.color;
		color.a = 0f;
		pMat.color = color;
	}

	private void Update()
	{
		if (!(World.world == null) && World.world_era != null)
		{
			_camera = World.world.camera;
			updateParticles(_system_rain, _mat_rain, World.world_era.particles_rain);
			updateParticles(_system_snow, _mat_snow, World.world_era.particles_snow);
			updateParticles(_system_magic, _mat_magic, World.world_era.particles_magic);
			updateParticles(_system_ash, _mat_ash, World.world_era.particles_ash);
			updateParticles(_system_sun_blobs, _mat_sun_blobs, World.world_era.particles_sun);
			updateParticles(_system_sun_rays, _mat_sun_ray, World.world_era.particles_sun);
		}
	}

	private void updateParticles(ParticleSystem pSystem, Material pMaterial, bool pEnabled)
	{
		if (!effects_enabled)
		{
			pEnabled = false;
		}
		Color color = pMaterial.color;
		bool flag = MapBox.isRenderGameplay() && pEnabled;
		if (color.a != 0f && !flag && !pSystem.isPlaying)
		{
			return;
		}
		int width = MapBox.width;
		int height = MapBox.height;
		Vector3 localPosition = new Vector3(width / 2, height / 2);
		pSystem.transform.localPosition = localPosition;
		ParticleSystem.ShapeModule shape = pSystem.shape;
		shape.scale = new Vector3((float)width * 1.5f, (float)height * 1.5f, 1f);
		if (!flag)
		{
			if (color.a > 0f)
			{
				color.a -= World.world.delta_time * 0.1f;
			}
		}
		else if (color.a < 1f)
		{
			color.a += World.world.delta_time * 0.1f;
			if (color.a > 1f)
			{
				color.a = 1f;
			}
		}
		if (color.a <= 0f)
		{
			color.a = 0f;
			pSystem.Stop(withChildren: false, ParticleSystemStopBehavior.StopEmittingAndClear);
		}
		else if (!pSystem.isPlaying)
		{
			pSystem.Play();
		}
		pMaterial.color = color;
	}
}
