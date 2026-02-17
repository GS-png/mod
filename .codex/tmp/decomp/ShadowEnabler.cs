using UnityEngine;
using UnityEngine.UI;

public class ShadowEnabler : MonoBehaviour
{
	public Shadow[] shadowObjects = new Shadow[0];

	private bool isEnabled;

	private void Awake()
	{
		shadowObjects = GetComponentsInChildren<Shadow>(includeInactive: true);
	}

	private void Update()
	{
		bool flag = base.transform.localScale.y == 1f;
		if (isEnabled != flag)
		{
			isEnabled = flag;
			toggle();
		}
	}

	private void OnDisable()
	{
		isEnabled = false;
		toggle();
	}

	private void OnEnable()
	{
		isEnabled = false;
		toggle();
	}

	private void toggle()
	{
		for (int i = 0; i < shadowObjects.Length; i++)
		{
			Shadow shadow = shadowObjects[i];
			if (!(shadow == null))
			{
				shadow.enabled = isEnabled;
			}
		}
	}
}
