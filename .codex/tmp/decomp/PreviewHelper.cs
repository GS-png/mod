using System.IO;
using UnityEngine;

public static class PreviewHelper
{
	public static Sprite loadWorkshopMapPreview()
	{
		string text = SaveManager.generatePngPreviewPath(SaveManager.currentWorkshopMapData.main_path);
		if (string.IsNullOrEmpty(text) || !File.Exists(text))
		{
			return null;
		}
		byte[] data = File.ReadAllBytes(text);
		Texture2D texture2D = new Texture2D(64, 64);
		if (texture2D.LoadImage(data))
		{
			return Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));
		}
		return null;
	}

	public static Sprite getCurrentWorldPreview()
	{
		World.world.redrawMiniMap(pForce: true);
		Texture2D texture2D = Toolbox.ScaleTexture(World.world.world_layer.texture, 512, 512);
		return Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0f, 0f));
	}

	public static Texture2D convertMapToTexture()
	{
		Texture2D texture = World.world.world_layer.texture;
		Texture2D texture2D = new Texture2D(texture.width, texture.height);
		Color32[] pixels = texture.GetPixels32();
		texture2D.SetPixels32(pixels);
		texture2D.Apply();
		return texture2D;
	}

	public static int getMaxAdSlots()
	{
		int num = 1;
		if (World.world.game_stats.data.gameLaunches > 10 && World.world.game_stats.data.gameTime > 36000.0)
		{
			num = 3;
		}
		if (World.world.game_stats.data.gameLaunches > 30 && World.world.game_stats.data.gameTime > 72000.0)
		{
			num = 6;
		}
		for (int i = num + 1; i <= 6; i++)
		{
			if (SaveManager.slotExists(i))
			{
				return 6;
			}
		}
		return num;
	}
}
