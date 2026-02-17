using UnityEngine;

public static class TextureExtensions
{
	public static Texture2D getAsReadable(this Texture2D pSourceTexture)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture temporary = RenderTexture.GetTemporary(pSourceTexture.width, pSourceTexture.height, 0, RenderTextureFormat.Default, (!pSourceTexture.isDataSRGB) ? RenderTextureReadWrite.Linear : RenderTextureReadWrite.sRGB);
		Graphics.Blit(pSourceTexture, temporary);
		RenderTexture.active = temporary;
		Texture2D texture2D = new Texture2D(pSourceTexture.width, pSourceTexture.height);
		texture2D.ReadPixels(new Rect(0f, 0f, temporary.width, temporary.height), 0, 0);
		texture2D.Apply();
		RenderTexture.active = active;
		RenderTexture.ReleaseTemporary(temporary);
		return texture2D;
	}
}
