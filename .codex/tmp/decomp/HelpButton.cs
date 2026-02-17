using UnityEngine;

public class HelpButton : MonoBehaviour
{
	public void clickHelp()
	{
		string stringVal = PlayerConfig.dict["language"].stringVal;
		Analytics.LogEvent("open_help");
		string text = "";
		text = ((Application.platform != RuntimePlatform.Android) ? ("https://support.apple.com/" + stringVal + "-" + stringVal + "/HT203005") : ("https://support.google.com/googleplay/answer/1050566?hl=" + stringVal));
		Application.OpenURL(text);
	}
}
