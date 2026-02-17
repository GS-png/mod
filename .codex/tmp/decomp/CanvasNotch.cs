using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class CanvasNotch : MonoBehaviour
{
	private bool screenChangeVarsInitialized;

	private bool ranFirstTime;

	private ScreenOrientation lastOrientation = ScreenOrientation.AutoRotation;

	private Vector2 lastResolution = Vector2.zero;

	private Rect lastSafeArea = Rect.zero;

	private Rect lastCanvasRect = Rect.zero;

	private RectTransform safeAreaTransform;

	private Canvas _canvas;

	private void Awake()
	{
		_canvas = base.gameObject.transform.GetComponentInParent<Canvas>();
		safeAreaTransform = GetComponent<RectTransform>();
		if (!screenChangeVarsInitialized)
		{
			lastOrientation = Screen.orientation;
			lastResolution.x = Screen.width;
			lastResolution.y = Screen.height;
			lastSafeArea = Screen.safeArea;
			screenChangeVarsInitialized = true;
		}
	}

	private void Start()
	{
		ApplySafeArea();
	}

	private void Update()
	{
		if (Application.isMobilePlatform && Screen.orientation != lastOrientation)
		{
			OrientationChanged();
		}
		if (Screen.safeArea != lastSafeArea)
		{
			SafeAreaChanged();
		}
		if (_canvas != null && _canvas.pixelRect != lastCanvasRect)
		{
			CanvasChanged();
		}
		if ((float)Screen.width != lastResolution.x || (float)Screen.height != lastResolution.y)
		{
			ResolutionChanged();
		}
		if (!ranFirstTime)
		{
			ApplySafeArea();
		}
	}

	private void ApplySafeArea()
	{
		if (!(_canvas == null) && !(safeAreaTransform == null))
		{
			ranFirstTime = true;
			Rect safeArea = Screen.safeArea;
			Rect rect = new Rect(0f, 0f, Screen.width, Screen.height);
			Vector2 vector = safeArea.min - rect.min;
			Vector2 vector2 = safeArea.max - rect.max;
			safeArea.min -= vector2;
			safeArea.max -= vector;
			Vector2 position = safeArea.position;
			Vector2 anchorMax = safeArea.position + safeArea.size;
			position.x /= _canvas.pixelRect.width;
			position.y /= _canvas.pixelRect.height;
			anchorMax.x /= _canvas.pixelRect.width;
			anchorMax.y /= _canvas.pixelRect.height;
			safeAreaTransform.anchorMin = position;
			safeAreaTransform.anchorMax = anchorMax;
		}
	}

	private void OrientationChanged()
	{
		lastOrientation = Screen.orientation;
		lastResolution.x = Screen.width;
		lastResolution.y = Screen.height;
		ApplySafeArea();
	}

	private void ResolutionChanged()
	{
		lastResolution.x = Screen.width;
		lastResolution.y = Screen.height;
		ApplySafeArea();
	}

	private void SafeAreaChanged()
	{
		lastSafeArea = Screen.safeArea;
		ApplySafeArea();
	}

	private void CanvasChanged()
	{
		lastCanvasRect = _canvas.pixelRect;
		ApplySafeArea();
	}

	private void debugConsole()
	{
		Dictionary<string, Rect> dictionary = new Dictionary<string, Rect>();
		Debug.Log("amount of cutouts: " + Screen.cutouts.Length);
		dictionary["screen"] = new Rect(0f, 0f, Screen.width, Screen.height);
		dictionary["safearea"] = Screen.safeArea;
		foreach (string key in dictionary.Keys)
		{
			Debug.Log("[o] " + key + ": x:" + dictionary[key].x + ", y:" + dictionary[key].y + ", w:" + dictionary[key].width + ", h:" + dictionary[key].height);
		}
		if (_canvas == null)
		{
			Debug.Log("canvas not ready");
			return;
		}
		foreach (string key2 in dictionary.Keys)
		{
			Debug.Log("[c] " + key2 + ": x:" + dictionary[key2].x / _canvas.scaleFactor + ", y:" + dictionary[key2].y / _canvas.scaleFactor + ", w:" + dictionary[key2].width / _canvas.scaleFactor + ", h:" + dictionary[key2].height / _canvas.scaleFactor);
		}
	}
}
