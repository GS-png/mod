using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ToggleObjects : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> _elements;

	private void Awake()
	{
		GetComponent<Button>().onClick.AddListener(toggle);
	}

	private void toggle()
	{
		if (_elements == null)
		{
			return;
		}
		foreach (GameObject element in _elements)
		{
			element.SetActive(!element.activeSelf);
		}
	}
}
