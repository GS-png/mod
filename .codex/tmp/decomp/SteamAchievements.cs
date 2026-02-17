using System;
using System.Collections.Generic;
using RSG;
using Steamworks;
using Steamworks.Data;
using UnityEngine;

internal static class SteamAchievements
{
	private static Promise initialized = new Promise();

	private static HashSet<string> achievements_hashset = new HashSet<string>();

	public static void InitAchievements()
	{
		SteamSDK.steamInitialized.Then(delegate
		{
			foreach (Steamworks.Data.Achievement achievement in SteamUserStats.Achievements)
			{
				if (achievement.State)
				{
					unlockAchievement(achievement.Identifier);
					if (!AchievementLibrary.isUnlocked(achievement.Identifier))
					{
						Debug.Log("Was unlocked in Steam already, unlocking in the game: " + achievement.Identifier);
						AchievementLibrary.unlock(achievement.Identifier);
					}
				}
				if (!achievement.State && AchievementLibrary.isUnlocked(achievement.Identifier))
				{
					Debug.Log("Was not unlocked in Steam yet, unlocking: " + achievement.Identifier);
					TriggerAchievement(achievement.Identifier);
				}
			}
			initialized.Resolve();
		}).Catch(delegate(Exception err)
		{
			Debug.Log("Error happened while getting Steam Achievement");
			Debug.Log(err);
			initialized.Reject(new Exception("Steam Achievements not available"));
		});
	}

	public static void TriggerAchievement(string id)
	{
		if (isSteamAchievementUnlocked(id))
		{
			return;
		}
		initialized.Then(delegate
		{
			if (!isSteamAchievementUnlocked(id))
			{
				Debug.Log("Unlocking in Steam: " + id);
				new Steamworks.Data.Achievement(id).Trigger();
				unlockAchievement(id);
			}
		});
	}

	public static void unlockAchievement(string pName)
	{
		achievements_hashset.Add(pName);
	}

	public static bool isSteamAchievementUnlocked(string pName)
	{
		return achievements_hashset.Contains(pName);
	}
}
