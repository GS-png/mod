using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using RSG;
using Steamworks;
using Steamworks.Data;
using Steamworks.Ugc;
using UnityEngine;

public static class WorkshopMaps
{
	internal static WorkshopUploadProgress uploadProgressTracker = new WorkshopUploadProgress();

	internal static float uploadProgress = 0f;

	public static PublishedFileId uploaded_file_id;

	internal static List<Steamworks.Ugc.Item> foundMaps = new List<Steamworks.Ugc.Item>();

	public static bool workshopAvailable()
	{
		if (SteamSDK.steamInitialized == null)
		{
			return false;
		}
		if (SteamSDK.steamInitialized.CurState == PromiseState.Resolved)
		{
			return true;
		}
		return false;
	}

	internal static Promise uploadMap()
	{
		Promise promise = new Promise();
		uploadProgress = 0f;
		WorkshopMapData workshopMapData = (SaveManager.currentWorkshopMapData = WorkshopMapData.currentMapToWorkshop());
		MapMetaData meta_data_map = workshopMapData.meta_data_map;
		if (SaveManager.currentWorkshopMapData == null)
		{
			promise.Reject(new Exception("Missing world data"));
			return promise;
		}
		if (!MapSizeLibrary.isSizeValid(meta_data_map.width))
		{
			promise.Reject(new Exception("Not a valid world size!"));
			return promise;
		}
		if (meta_data_map.width != meta_data_map.height)
		{
			promise.Reject(new Exception("Not a square world!"));
			return promise;
		}
		MapMetaData meta_data_map2 = workshopMapData.meta_data_map;
		string name = meta_data_map2.mapStats.name;
		string description = meta_data_map2.mapStats.description;
		if (string.IsNullOrWhiteSpace(name))
		{
			promise.Reject(new Exception("Give your world a name!"));
			return promise;
		}
		if (string.IsNullOrWhiteSpace(description))
		{
			promise.Reject(new Exception("Give your world a description!"));
			return promise;
		}
		string main_path = workshopMapData.main_path;
		string preview_image_path = workshopMapData.preview_image_path;
		Editor editor = Editor.NewCommunityFile.WithTag("World");
		if (!string.IsNullOrWhiteSpace(name))
		{
			editor = editor.WithTitle(name);
		}
		if (!string.IsNullOrWhiteSpace(description))
		{
			editor = editor.WithDescription(description);
		}
		if (!string.IsNullOrWhiteSpace(preview_image_path))
		{
			editor = editor.WithPreviewFile(preview_image_path);
		}
		if (!string.IsNullOrWhiteSpace(main_path))
		{
			editor = editor.WithContent(main_path);
		}
		editor = editor.WithFriendsOnlyVisibility();
		uploadProgressTracker = new WorkshopUploadProgress();
		editor.SubmitAsync(uploadProgressTracker).ContinueWith(delegate(Task<PublishResult> taskResult)
		{
			if (taskResult.Status == TaskStatus.RanToCompletion)
			{
				PublishResult result = taskResult.Result;
				if (!result.Success)
				{
					Debug.LogError("Error when uploading Workshop world");
				}
				if (result.NeedsWorkshopAgreement)
				{
					Debug.Log("w: Needs Workshop Agreement");
					WorkshopUploadingWorldWindow.needsWorkshopAgreement = true;
					WorkshopOpenSteamWorkshop.fileID = result.FileId.ToString();
				}
				if (result.Result != Result.OK)
				{
					Debug.LogError(result.Result);
					promise.Reject(new Exception("Something went wrong: " + result.Result));
				}
				else
				{
					uploaded_file_id = result.FileId;
					World.world.game_stats.data.workshopUploads++;
					WorkshopAchievements.checkAchievements();
					promise.Resolve();
				}
			}
			else
			{
				promise.Reject(taskResult.Exception.GetBaseException());
			}
		}, TaskScheduler.FromCurrentSynchronizationContext());
		return promise;
	}

	internal static async Task<List<Steamworks.Ugc.Item>> listWorkshopMaps(bool pOrder = false, bool pByFriends = false)
	{
		Query q = Query.ItemsReadyToUse.WhereUserSubscribed().WithTag("World");
		if (pByFriends)
		{
			q = q.CreatedByFriends();
		}
		q = ((!pOrder) ? q.SortByCreationDateAsc() : q.SortByCreationDate());
		foundMaps.Clear();
		int num = 1;
		int totalFound = 0;
		int tPage = 1;
		while (num > totalFound)
		{
			ResultPage? resultPage = await q.GetPageAsync(tPage++);
			if (!resultPage.HasValue)
			{
				break;
			}
			num = resultPage.Value.TotalCount;
			totalFound += resultPage.Value.ResultCount;
			Debug.Log($"w: This page has {resultPage.Value.ResultCount} results");
			foreach (Steamworks.Ugc.Item entry in resultPage.Value.Entries)
			{
				Debug.Log("w: Entry: " + entry.Title);
				if (entry.IsInstalled && !entry.IsDownloadPending && !entry.IsDownloading)
				{
					if (!filesPresent(entry))
					{
						Debug.Log("w: Incomplete files for Workshop Item, skipped");
					}
					else
					{
						foundMaps.Add(entry);
					}
				}
			}
			Debug.Log(resultPage.Value.ResultCount);
			Debug.Log(resultPage.Value.TotalCount);
		}
		return foundMaps;
	}

	internal static bool filesPresent(Steamworks.Ugc.Item pEntry)
	{
		if (!Directory.Exists(pEntry.Directory))
		{
			return false;
		}
		string[] files = Directory.GetFiles(pEntry.Directory);
		Debug.Log("w: " + pEntry.Directory + " with " + files.Length + " Files");
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		string[] array = files;
		foreach (string text in array)
		{
			if (text.Contains("map.wbox"))
			{
				flag = true;
			}
			else if (text.Contains("map.meta"))
			{
				flag4 = true;
			}
			else if (text.Contains("preview.png"))
			{
				flag2 = true;
			}
			else if (text.Contains("preview_small.png"))
			{
				flag3 = true;
			}
		}
		if (!flag)
		{
			Debug.Log("w: Missing Map");
		}
		if (!flag2)
		{
			Debug.Log("w: Missing Preview");
		}
		if (!flag3)
		{
			Debug.Log("w: Missing PreviewSmall");
		}
		if (!flag4)
		{
			Debug.Log("w: Missing Meta");
		}
		if (!flag4 || !flag || !flag2 || !flag3)
		{
			return false;
		}
		return true;
	}
}
