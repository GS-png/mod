using UnityEngine;
using UnityEngine.UI;
using db;

public static class WorldLogMessageExtensions
{
	public static void clear(this WorldLogMessage pMessage)
	{
		pMessage.unit = null;
	}

	public static void add(this WorldLogMessage pMessage)
	{
		HistoryHud.instance.newHistory(pMessage);
		DBInserter.insertLog(pMessage);
	}

	public static string getFormatedText(this WorldLogMessage pMessage, Text pTextField)
	{
		WorldLogAsset asset = pMessage.getAsset();
		string localeID;
		if (asset.random_ids > 0)
		{
			int pIndex = pMessage.timestamp % asset.random_ids + 1;
			localeID = asset.getLocaleID(pIndex);
		}
		else
		{
			localeID = asset.getLocaleID();
		}
		string pText = LocalizedTextManager.getText(localeID);
		if (asset.text_replacer != null)
		{
			asset.text_replacer(pMessage, ref pText);
		}
		pTextField.color = asset.color;
		return pText;
	}

	public static bool followLocation(this WorldLogMessage pMessage)
	{
		if (pMessage.hasFollowLocation())
		{
			WorldLog.locationFollow(pMessage.unit);
			return true;
		}
		return false;
	}

	public static void jumpToLocation(this WorldLogMessage pMessage)
	{
		if (!pMessage.followLocation())
		{
			Vector3 pPoint = pMessage.getLocation();
			if (pPoint != Vector3.zero && Toolbox.inMapBorder(ref pPoint))
			{
				WorldLog.locationJump(pPoint);
			}
		}
	}

	public static bool hasLocation(this WorldLogMessage pMessage)
	{
		return pMessage.getLocation() != Vector3.zero;
	}

	public static bool hasFollowLocation(this WorldLogMessage pMessage)
	{
		if (pMessage.unit != null && pMessage.unit.isAlive())
		{
			return true;
		}
		return false;
	}

	public static Vector3 getLocation(this WorldLogMessage pMessage)
	{
		if (pMessage.unit != null && pMessage.unit.isAlive())
		{
			return pMessage.unit.current_position;
		}
		if (pMessage.x != -1 && pMessage.y != -1)
		{
			Vector2 pPoint = pMessage.location;
			if (Toolbox.inMapBorder(ref pPoint))
			{
				return pMessage.location;
			}
		}
		return Vector3.zero;
	}

	public static WorldLogAsset getAsset(this WorldLogMessage pMessage)
	{
		return AssetManager.world_log_library.get(pMessage.asset_id);
	}

	public static string getSpecial(this WorldLogMessage pMessage, int pSpecialId)
	{
		return pSpecialId switch
		{
			1 => Toolbox.coloredText(pMessage.special1, pMessage.color_special_1), 
			2 => Toolbox.coloredText(pMessage.special2, pMessage.color_special_2), 
			3 => Toolbox.coloredText(pMessage.special3, pMessage.color_special_3), 
			_ => "", 
		};
	}
}
