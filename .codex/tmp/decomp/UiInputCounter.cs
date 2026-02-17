using UnityEngine;
using UnityEngine.UI;

public class UiInputCounter : MonoBehaviour
{
	public InputField nameText;

	private void Start()
	{
		nameText.onValueChanged.AddListener(delegate
		{
			textChanged();
		});
	}

	private void OnEnable()
	{
		if (Config.game_loaded)
		{
			textChanged();
		}
	}

	public void textChanged()
	{
		GetComponent<Text>().text = nameText.text.Length + " / " + nameText.characterLimit;
	}
}
