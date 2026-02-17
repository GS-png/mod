using System;
using System.Collections.Generic;
using System.IO;
using Steamworks.Ugc;
using UnityEngine;

public class WorkshopMapListWindow : MonoBehaviour
{
	public WorkshopMapElement elementPrefab;

	private Dictionary<string, Sprite> cached_sprites = new Dictionary<string, Sprite>();

	private List<WorkshopMapElement> elements = new List<WorkshopMapElement>();

	public Transform transformContent;

	private float _timer;

	private bool _no_items;

	private Queue<Steamworks.Ugc.Item> _showQueue = new Queue<Steamworks.Ugc.Item>();

	private void OnEnable()
	{
		if (!Config.game_loaded)
		{
			return;
		}
		_timer = 0.3f;
		foreach (WorkshopMapElement element in elements)
		{
			UnityEngine.Object.Destroy(element.gameObject);
		}
		elements.Clear();
		SteamSDK.steamInitialized.Then(delegate
		{
			prepareList();
		}).Catch(delegate(Exception err)
		{
			Debug.LogError(err);
			ErrorWindow.errorMessage = "Error happened while connecting to Steam Workshop:\n" + err.Message.ToString();
			ScrollWindow.get("error_with_reason").clickShow();
		});
	}

	private void OnDisable()
	{
		_showQueue.Clear();
	}

	private void Update()
	{
		if (_timer > 0f)
		{
			_timer -= Time.deltaTime;
		}
		else
		{
			_timer = 0.015f;
			showNextItemFromQueue();
		}
		if (_no_items)
		{
			_no_items = false;
			ScrollWindow.showWindow("steam_workshop_empty");
		}
	}

	private async void prepareList()
	{
		List<Steamworks.Ugc.Item> list = await WorkshopMaps.listWorkshopMaps();
		if (list.Count > 0)
		{
			foreach (Steamworks.Ugc.Item item in list)
			{
				_showQueue.Enqueue(item);
			}
			AchievementLibrary.checkSteamMapDownloads(list.Count);
		}
		else
		{
			_no_items = true;
		}
	}

	private void showNextItemFromQueue()
	{
		if (_showQueue.Count != 0)
		{
			Steamworks.Ugc.Item pSteamworksItem = _showQueue.Dequeue();
			renderMapElement(pSteamworksItem);
		}
	}

	private WorkshopMapData loadMapDataFromStorage(Steamworks.Ugc.Item pSteamworksItem)
	{
		string text = SaveManager.generatePngSmallPreviewPath(pSteamworksItem.Directory);
		WorkshopMapData workshopMapData = new WorkshopMapData();
		workshopMapData.main_path = pSteamworksItem.Directory;
		workshopMapData.workshop_item = pSteamworksItem;
		if (!string.IsNullOrEmpty(text) && File.Exists(text))
		{
			if (cached_sprites.ContainsKey(text))
			{
				workshopMapData.sprite_small_preview = cached_sprites[text];
			}
			else
			{
				try
				{
					byte[] data = File.ReadAllBytes(text);
					Texture2D texture2D = new Texture2D(32, 32);
					texture2D.anisoLevel = 0;
					texture2D.filterMode = FilterMode.Point;
					if (texture2D.LoadImage(data))
					{
						workshopMapData.sprite_small_preview = Sprite.Create(texture2D, new Rect(0f, 0f, 32f, 32f), new Vector2(0.5f, 0.5f));
						cached_sprites.Add(text, workshopMapData.sprite_small_preview);
					}
				}
				catch (Exception)
				{
				}
			}
		}
		MapMetaData metaFor = SaveManager.getMetaFor(pSteamworksItem.Directory);
		bool flag = false;
		if (!string.IsNullOrWhiteSpace(pSteamworksItem.Title) && metaFor.mapStats.name != pSteamworksItem.Title)
		{
			metaFor.mapStats.name = pSteamworksItem.Title;
			flag = true;
		}
		if (metaFor.mapStats.description != pSteamworksItem.Description)
		{
			metaFor.mapStats.description = pSteamworksItem.Description;
			flag = true;
		}
		if (flag)
		{
			SaveManager.saveMetaIn(pSteamworksItem.Directory, metaFor);
		}
		workshopMapData.meta_data_map = metaFor;
		return workshopMapData;
	}

	private void renderMapElement(Steamworks.Ugc.Item pSteamworksItem)
	{
		WorkshopMapElement workshopMapElement = UnityEngine.Object.Instantiate(elementPrefab, transformContent);
		elements.Add(workshopMapElement);
		WorkshopMapData pData = loadMapDataFromStorage(pSteamworksItem);
		workshopMapElement.load(pData);
	}
}
