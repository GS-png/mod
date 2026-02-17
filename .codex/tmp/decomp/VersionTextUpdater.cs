using System;
using UnityEngine;
using UnityEngine.UI;
using WorldBoxConsole;

public class VersionTextUpdater : MonoBehaviour
{
	public bool addText = true;

	public Text text;

	private bool errored;

	private bool modded;

	private void Start()
	{
		if (addText)
		{
			this.text.text = "version: " + Application.version + "-" + Config.versionCodeText;
			if (!string.IsNullOrEmpty(Config.gitCodeText))
			{
				Text obj = this.text;
				obj.text = obj.text + "@" + Config.gitCodeText;
			}
			return;
		}
		string text = Application.platform.ToString().ToLower();
		text = text.Replace("player", "");
		this.text.text = text + " " + Application.version + "-" + Config.versionCodeText;
		if (!string.IsNullOrEmpty(Config.gitCodeText))
		{
			Text obj2 = this.text;
			obj2.text = obj2.text + "@" + Config.gitCodeText;
		}
		try
		{
			if (!string.IsNullOrEmpty(RequestHelper.salt) && RequestHelper.salt != "err")
			{
				Text obj3 = this.text;
				obj3.text = obj3.text + " (" + RequestHelper.salt.Substring(0, 2) + ")";
			}
		}
		catch (Exception ex)
		{
			Debug.LogError(ex.ToString());
		}
	}

	private void Update()
	{
		if (errored)
		{
			return;
		}
		if (!modded && Config.MODDED)
		{
			text.color = Color.yellow;
			modded = true;
		}
		if (LogHandler.errorNum > 0 || WorldBoxConsole.Console.hasErrors())
		{
			if (modded)
			{
				text.color = Color.cyan;
			}
			else
			{
				text.color = Color.red;
			}
			errored = true;
		}
	}
}
