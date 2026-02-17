using System;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class GameStats : MonoBehaviour
{
	internal GameStatsData data;

	private string dataPath;

	private WorldTimer saveTimer;

	private void Start()
	{
		dataPath = Application.persistentDataPath + "/stats.json";
		loadData();
		if (data == null)
		{
			data = new GameStatsData();
		}
		else
		{
			checkDataForErrors();
		}
		saveTimer = new WorldTimer(30f, saveData);
		data.gameLaunches++;
	}

	internal bool goodForAds()
	{
		return true;
	}

	private void saveData()
	{
		string text = "Stats";
		bool flag = false;
		string pNewPath = dataPath;
		string text2 = dataPath + ".tmp";
		try
		{
			if (!Directory.Exists(Application.persistentDataPath))
			{
				Directory.CreateDirectory(Application.persistentDataPath);
			}
		}
		catch (Exception message)
		{
			WorldTip.showNow("Error creating directory to save stats in! Check console for details", pTranslate: false, "top");
			Debug.Log("Error creating directory: " + Application.persistentDataPath);
			Debug.Log(message);
		}
		try
		{
			using FileStream stream = new FileStream(text2, FileMode.Create, FileAccess.Write);
			using StreamWriter textWriter = new StreamWriter(stream);
			using JsonWriter jsonWriter = new JsonTextWriter(textWriter);
			new JsonSerializer().Serialize(jsonWriter, data);
		}
		catch (IOException ex)
		{
			if (Toolbox.IsDiskFull(ex))
			{
				WorldTip.showNow("Error saving " + text + " : Disk full!", pTranslate: false, "top");
			}
			else
			{
				Debug.Log("Could not save " + text + " due to hard drive / IO Error : ");
				Debug.Log(ex);
				WorldTip.showNow("Error saving " + text + " due to IOError! Check console for details", pTranslate: false, "top");
			}
			flag = true;
		}
		catch (Exception message2)
		{
			Debug.Log("Could not save " + text + " due to error : ");
			Debug.Log(message2);
			WorldTip.showNow("Error saving " + text + "! Check console for errors", pTranslate: false, "top");
			flag = true;
		}
		if (flag)
		{
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
		}
		else
		{
			Toolbox.MoveSafely(text2, pNewPath);
		}
		AchievementLibrary.life_is_a_sim.check();
	}

	private void checkDataForErrors()
	{
		if (double.IsNaN(data.gameTime) || double.IsInfinity(data.gameTime) || data.gameTime < 0.0)
		{
			Debug.Log(data.gameTime);
			Debug.LogError("Game time is NaN or Infinity! Resetting to 0");
			data.gameTime = 0.0;
		}
		if (data.creaturesBorn < 0)
		{
			data.creaturesBorn = Math.Max(0L, data.creaturesDied - data.creaturesCreated);
		}
	}

	private void loadData()
	{
		if (!File.Exists(dataPath))
		{
			return;
		}
		try
		{
			using FileStream stream = new FileStream(dataPath, FileMode.Open, FileAccess.Read);
			using StreamReader reader = new StreamReader(stream);
			using JsonReader reader2 = new JsonTextReader(reader);
			JsonSerializer jsonSerializer = new JsonSerializer();
			data = jsonSerializer.Deserialize<GameStatsData>(reader2);
		}
		catch (Exception message)
		{
			Debug.Log("exception caught when loading stats");
			Debug.LogError(message);
		}
		if (data == null)
		{
			Debug.LogError("(!) stats not has been loaded");
		}
	}

	public void updateStats(float pTime)
	{
		data.gameTime += pTime;
		saveTimer.update();
	}
}
