using UnityEngine;

public class EffectsCamera : MonoBehaviour
{
	private Camera _mainCamera;

	private Camera _effectsCamera;

	internal RenderTexture renderTexture;

	private void Awake()
	{
		_effectsCamera = GetComponent<Camera>();
	}

	private void Start()
	{
		_mainCamera = World.world.camera;
	}

	private void LateUpdate()
	{
		_effectsCamera.orthographicSize = _mainCamera.orthographicSize;
		int num = Screen.width / 3;
		int num2 = Screen.height / 3;
		if (renderTexture == null || renderTexture.width != num || renderTexture.height != num2)
		{
			renderTexture = new RenderTexture(num, num2, 0);
			renderTexture.filterMode = FilterMode.Point;
			renderTexture.wrapMode = TextureWrapMode.Clamp;
			_effectsCamera.targetTexture = renderTexture;
		}
	}
}
