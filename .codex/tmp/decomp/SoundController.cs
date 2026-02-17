using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
	public List<AudioClip> clips;

	public bool soundEnabled = true;

	public bool ambientSound;

	internal int curCopies;

	public int copies;

	public float randomizePitch;

	internal float timeout;

	public float timeoutInterval;

	public float originPitch = 1f;

	internal AudioSource s;

	private MoveCamera _camera;

	private float originVolume = 1f;

	private Vector3 sfxPos;

	private Vector3 sfxPosCamera;

	private void Awake()
	{
		s = GetComponent<AudioSource>();
		_camera = Camera.main.GetComponent<MoveCamera>();
		originVolume = s.volume;
		if (ambientSound)
		{
			s.spatialBlend = 1f;
			s.dopplerLevel = 0f;
			s.rolloffMode = AudioRolloffMode.Logarithmic;
		}
	}

	internal void play(float pX = 0f, float pY = 0f)
	{
		float num = 1f;
		if (ambientSound)
		{
			sfxPos = new Vector3(pX, pY, 0f);
			sfxPosCamera = _camera.main_camera.WorldToViewportPoint(sfxPos);
			if (sfxPosCamera.x > 0f && sfxPosCamera.x < 1f && sfxPosCamera.y > 0f)
			{
				_ = sfxPosCamera.y;
				_ = 1f;
			}
			if (pX != 0f && pY != 0f)
			{
				num = 1f - _camera.main_camera.orthographicSize / _camera.orthographic_size_max * 0.7f;
				num = Mathf.Clamp01(num);
			}
		}
		if (clips != null && clips.Count > 0)
		{
			s.clip = Randy.getRandom(clips);
		}
		base.gameObject.SetActive(value: true);
		s.volume = originVolume * num;
		s.pitch = originPitch + Randy.randomFloat(0f - randomizePitch, randomizePitch);
		s.transform.position = new Vector3(pX, pY);
		s.Play();
	}

	internal void update(float pElapsed)
	{
		if (timeout > 0f)
		{
			timeout -= pElapsed;
		}
		if (ambientSound)
		{
			sfxPosCamera = _camera.main_camera.WorldToViewportPoint(sfxPos);
			float num = 1f;
			if (!(sfxPosCamera.x > 0f) || !(sfxPosCamera.x < 1f) || !(sfxPosCamera.y > 0f) || !(sfxPosCamera.y < 1f))
			{
				num = 0f;
			}
			num = 1f - _camera.main_camera.orthographicSize / _camera.orthographic_size_max * 0.7f;
			num = Mathf.Clamp01(num);
			s.volume = originVolume * num;
		}
	}
}
