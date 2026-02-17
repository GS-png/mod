using UnityEngine;

public class QuantumSpriteWithText : QuantumSprite
{
	public TextMesh text;

	public void initText()
	{
		text = base.transform.Find("Text")?.GetComponent<TextMesh>();
	}
}
