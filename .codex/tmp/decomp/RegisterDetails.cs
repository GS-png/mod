using UnityEngine;
using UnityEngine.UI;

public class RegisterDetails : MonoBehaviour
{
	private static bool emailValid;

	private static bool passwordValid;

	private void OnEnable()
	{
		checkButton();
	}

	public void emailCheck(InputField pEmail)
	{
		runEmailCheck(pEmail);
	}

	public static void runEmailCheck(InputField pEmail)
	{
		string text = pEmail.text;
		emailValid = false;
		Debug.Log("Name: " + text);
		if (!Auth.isValidEmail(text))
		{
			newStatus("InvalidEmail");
			checkButton();
			Debug.Log("Not valid");
		}
		else
		{
			clearStatus();
			emailValid = true;
			checkButton();
		}
	}

	public void passwordCheck(InputField pEmail)
	{
		runPasswordCheck(pEmail);
	}

	public static void runPasswordCheck(InputField pPassword)
	{
		string text = pPassword.text;
		passwordValid = false;
		Debug.Log("Pass: " + text);
		if (text.Length < 6)
		{
			newStatus("ShortPassword");
			checkButton();
			Debug.Log("Not valid");
		}
		else
		{
			clearStatus();
			passwordValid = true;
			checkButton();
		}
	}

	private static void checkButton()
	{
		if (emailValid && passwordValid)
		{
			unblockRegisterButton();
		}
		else
		{
			blockRegisterButton();
		}
	}

	private static void blockRegisterButton()
	{
		if (registerWindowExists())
		{
			ScrollWindow.get("register").GetComponent<UserRegisterWindow>().blockRegister2Button();
		}
	}

	private static void unblockRegisterButton()
	{
		if (registerWindowExists())
		{
			ScrollWindow.get("register").GetComponent<UserRegisterWindow>().unblockRegister2Button();
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
