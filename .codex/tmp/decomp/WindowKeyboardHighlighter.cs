using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

internal class WindowKeyboardHighlighter : MonoBehaviour
{
	private static List<InputField> inputFields = new List<InputField>();

	private bool rescan;

	private int noInputs;

	private bool anyFocused;

	private void OnEnable()
	{
		if (!TouchScreenKeyboard.isSupported)
		{
			Object.Destroy(GetComponent<WindowKeyboardHighlighter>());
		}
		else
		{
			findInputFields();
		}
	}

	private void findInputFields()
	{
		noInputs = 0;
		rescan = false;
		inputFields.Clear();
		Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
		foreach (Transform transform in componentsInChildren)
		{
			if (transform.HasComponent<InputField>())
			{
				inputFields.Add(transform.GetComponent<InputField>());
			}
		}
	}

	private void OnDisable()
	{
		inputFields.Clear();
	}

	private void up(InputField pInput)
	{
		int num = Screen.height / 4 * 3;
		if (!(pInput.transform.position.y >= (float)num))
		{
			Vector3 localPosition = base.gameObject.transform.localPosition;
			localPosition.y += 10f;
			base.transform.localPosition = localPosition;
		}
	}

	private void down()
	{
		if (!(base.gameObject.transform.localPosition.y <= 10f))
		{
			Vector3 localPosition = base.gameObject.transform.localPosition;
			localPosition.y -= 5f;
			base.transform.localPosition = localPosition;
		}
	}

	private void Update()
	{
		anyFocused = false;
		if (inputFields.Count == 0)
		{
			noInputs++;
		}
		foreach (InputField inputField in inputFields)
		{
			if (!inputField.gameObject.activeInHierarchy)
			{
				rescan = true;
			}
			if (inputField.isFocused)
			{
				up(inputField);
				anyFocused = true;
			}
		}
		if (!anyFocused)
		{
			down();
		}
		if (rescan || noInputs > 60)
		{
			findInputFields();
		}
	}
}
