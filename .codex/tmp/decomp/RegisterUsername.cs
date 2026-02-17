using System;
using UnityEngine;
using UnityEngine.UI;

public class RegisterUsername : MonoBehaviour
{
	private static bool usernameOK;

	private static bool termsOK;

	private void OnEnable()
	{
		usernameOK = false;
		termsOK = false;
	}

	public void usernameCheck(InputField pUsername)
	{
		runUsernameCheck(pUsername);
	}

	public static async void runUsernameCheck(InputField pUsername)
	{
		clearStatus();
		blockRegisterButton();
		usernameOK = false;
		string text = pUsername.text;
		Debug.Log("Name: " + text);
		if (!Username.isValid(text))
		{
			newStatus("InvalidUsernameLong");
			blockRegisterButton();
			Debug.Log("Not valid");
			return;
		}
		Debug.Log("Check if taken : " + text);
		try
		{
			if (await Username.isTaken(text))
			{
				newStatus("UsernameTaken");
				blockRegisterButton();
				return;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError(ex);
			newStatus(ex.Message.ToString());
			blockRegisterButton();
			return;
		}
		Debug.Log("not taken?");
		usernameOK = true;
		unblockRegisterButton();
	}

	public void termsCheck(bool pTermsEnabled)
	{
		termsOK = pTermsEnabled;
		unblockRegisterButton();
	}

	private static void blockRegisterButton()
	{
		if (registerWindowExists())
		{
			ScrollWindow.get("register").GetComponent<UserRegisterWindow>().blockRegister1Button();
		}
	}

	private static void unblockRegisterButton()
	{
		if (!usernameOK || !termsOK)
		{
			blockRegisterButton();
		}
		else if (registerWindowExists())
		{
			ScrollWindow.get("register").GetComponent<UserRegisterWindow>().unblockRegister1Button();
		}
	}

	private static void newStatus(string pMessage)
	{
		if (registerWindowExists())
		{
			ScrollWindow.get("register").GetComponent<UserRegisterWindow>().newStatus(pMessage);
		}
	}

	private static bool registerWindowExists()
	{
		if (ScrollWindow.get("register") != null)
		{
			return ScrollWindow.get("register").GetComponent<UserRegisterWindow>() != null;
		}
		return false;
	}

	private static void clearStatus()
	{
		newStatus("");
	}
}
