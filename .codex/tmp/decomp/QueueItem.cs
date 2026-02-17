using System;
using UnityEngine;

[Serializable]
public class QueueItem
{
	public object timestamp;

	public string salt = RequestHelper.salt;

	public string version = Application.version;

	public string identifier = Application.identifier;

	public string language = LocalizedTextManager.instance.language;

	public string platform = Application.platform.ToString();

	public int progress;
}
