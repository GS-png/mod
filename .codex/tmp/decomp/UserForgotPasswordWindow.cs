using UnityEngine;
using UnityEngine.UI;

public class UserForgotPasswordWindow : MonoBehaviour
{
	public Button forgotPasswordButton;

	public void Start()
	{
		if (Config.game_loaded)
		{
			forgotPasswordButton.gameObject.SetActive(value: true);
		}
	}

	private void OnEnable()
	{
		if (Config.game_loaded)
		{
			forgotPasswordButton.gameObject.SetActive(value: true);
		}
	}
}
