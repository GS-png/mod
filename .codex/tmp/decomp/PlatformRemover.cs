using UnityEngine;

public class PlatformRemover : MonoBehaviour
{
	public bool removeOnIOS;

	public bool removeOnAndroid;

	public bool removeOnPC;

	public bool removeOnEditor;

	public bool removeOnGlobalVersion;

	public bool removeOnChineseVersion;

	public bool removeOnNonPremiumVersion;

	private void Awake()
	{
		if (removeOnGlobalVersion)
		{
			Object.Destroy(base.gameObject);
		}
		else if (removeOnEditor && Config.isEditor)
		{
			Object.Destroy(base.gameObject);
		}
		else if (removeOnPC && Config.isComputer)
		{
			Object.Destroy(base.gameObject);
		}
		else if (removeOnAndroid && Config.isAndroid)
		{
			Object.Destroy(base.gameObject);
		}
		else if (removeOnIOS && Config.isIos)
		{
			Object.Destroy(base.gameObject);
		}
	}
}
