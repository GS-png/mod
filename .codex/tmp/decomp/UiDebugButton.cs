using System;
using UnityEngine;
using UnityEngine.UI;

public class UiDebugButton : MonoBehaviour
{
	public Sprite button_on;

	public Sprite button_off;

	public Text text;

	public Image iconOn;

	public Button button;

	private DebugOption _debug_option;

	public void Awake()
	{
		string text = base.gameObject.transform.name;
		try
		{
			_debug_option = (DebugOption)Enum.Parse(typeof(DebugOption), text);
		}
		catch (Exception)
		{
			Debug.LogError("THERE'S NO DEBUG OPTION CALLED " + text);
			throw;
		}
		button.onClick.AddListener(click);
	}

	public void Start()
	{
		text.text = base.transform.gameObject.name;
		checkButtonGraphics();
	}

	private void OnEnable()
	{
		checkButtonGraphics();
	}

	private void OnValidate()
	{
		string obj = base.gameObject.transform.name;
		string text = "";
		int num = 0;
		string text2 = obj;
		for (int i = 0; i < text2.Length; i++)
		{
			char c = text2[i];
			if (num == 0)
			{
				text += c;
			}
			else
			{
				if (char.IsUpper(c))
				{
					text += " ";
				}
				text += c;
			}
			num++;
		}
		this.text.text = text;
	}

	public void click()
	{
		DebugConfig.switchOption(_debug_option);
		checkButtonGraphics();
	}

	private void checkButtonGraphics()
	{
		if (DebugConfig.isOn(_debug_option))
		{
			button.GetComponent<Image>().sprite = button_on;
		}
		else
		{
			button.GetComponent<Image>().sprite = button_off;
		}
	}
}
