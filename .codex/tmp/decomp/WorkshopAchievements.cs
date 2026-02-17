using System;
using System.Threading.Tasks;
using Steamworks.Ugc;
using UnityEngine;

internal class WorkshopAchievements
{
	internal static void checkAchievements()
	{
		SteamSDK.steamInitialized.Then(delegate
		{
			countUsersWorkshopMaps();
		}).Catch(delegate(Exception err)
		{
			Debug.Log("Error happened while getting users maps");
			Debug.Log(err);
		});
	}

	internal static async Task countUsersWorkshopMaps()
	{
		Query tQuery = Query.ItemsReadyToUse.WhereUserPublished().WithTag("World");
		int tTotalVotes = 0;
		int tTotalCount = 1;
		int tTotalFound = 0;
		int tPage = 1;
		while (tTotalCount > tTotalFound)
		{
			ResultPage? resultPage = await tQuery.GetPageAsync(tPage++);
			if (!resultPage.HasValue)
			{
				continue;
			}
			tTotalCount = resultPage.Value.TotalCount;
			tTotalFound += resultPage.Value.ResultCount;
			foreach (Steamworks.Ugc.Item entry in resultPage.Value.Entries)
			{
				tTotalVotes += (int)entry.VotesUp;
			}
		}
		if (tTotalCount > World.world.game_stats.data.workshopUploads)
		{
			World.world.game_stats.data.workshopUploads = tTotalCount;
		}
		AchievementLibrary.checkSteamMapUploads();
	}
}
