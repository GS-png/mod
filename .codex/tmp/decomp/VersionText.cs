using UnityEngine;
using UnityEngine.UI;

public class VersionText : MonoBehaviour
{
	internal Text text;

	private void Awake()
	{
		text = GetComponent<Text>();
	}

	private void OnEnable()
	{
		if (Config.game_loaded)
		{
			text.GetComponent<LocalizedText>().updateText();
		}
	}

	private void Update()
	{
		if (!(text == null))
		{
			text.text = text.text.Replace("$old_version$", oldText(Config.gv));
			text.text = text.text.Replace("$new_version$", newText(VersionCheck.onlineVersion));
		}
	}

	private string oldText(string pText)
	{
		return "<color=#FF0000>" + pText + "</color>";
	}

	private string newText(string pText)
	{
		return "<color=#00FF00>" + pText + "</color>";
	}
}
