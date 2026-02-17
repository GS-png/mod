using System;
using UnityEngine;

public class TextureRotator
{
	public static Texture2D Rotate(Texture2D originTexture, int angle, Color32 pDefaultColor)
	{
		Texture2D texture2D = new Texture2D(originTexture.width, originTexture.height);
		texture2D.name = "rotated_" + originTexture.name;
		Color32[] pixels = texture2D.GetPixels32();
		Color32[] pixels2 = originTexture.GetPixels32();
		int width = originTexture.width;
		int height = originTexture.height;
		int num = 0;
		int num2 = 0;
		Color32[] array = rotateSquare(pixels2, Math.PI / 180.0 * (double)angle, originTexture, pDefaultColor);
		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
			{
				pixels[texture2D.width / 2 - width / 2 + num + j + texture2D.width * (texture2D.height / 2 - height / 2 + i + num2)] = array[j + i * width];
			}
		}
		texture2D.SetPixels32(pixels);
		texture2D.Apply();
		return texture2D;
	}

	private static Color32[] rotateSquare(Color32[] arr, double phi, Texture2D originTexture, Color32 pDefaultColor)
	{
		double num = Math.Sin(phi);
		double num2 = Math.Cos(phi);
		Color32[] pixels = originTexture.GetPixels32();
		int width = originTexture.width;
		int height = originTexture.height;
		int num3 = width / 2;
		int num4 = height / 2;
		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
			{
				pixels[i * width + j] = pDefaultColor;
				int num5 = (int)(num2 * (double)(j - num3) + num * (double)(i - num4) + (double)num3);
				int num6 = (int)((0.0 - num) * (double)(j - num3) + num2 * (double)(i - num4) + (double)num4);
				if (num5 > -1 && num5 < width && num6 > -1 && num6 < height)
				{
					pixels[i * width + j] = arr[num6 * width + num5];
				}
			}
		}
		return pixels;
	}
}
