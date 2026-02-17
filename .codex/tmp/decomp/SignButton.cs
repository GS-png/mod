using UnityEngine;
using UnityEngine.UI;

public class SignButton : MonoBehaviour
{
	public UserLoginWindow userLoginWindow;

	public InputField textName;

	public InputField textPassword;

	public Text textStatusMessage;

	private string loginEmail;

	private string loginPassword;

	private string loginUsername;

	public void tryLogin()
	{
		clearStatus();
		loginEmail = textName.text;
		loginPassword = textPassword.text;
		loginUsername = "";
		if (loginEmail == "" || loginPassword == "")
		{
			errorStatus("EmailPasswordEmpty");
		}
		else if (!Auth.isValidEmail(loginEmail))
		{
			loginUsername = textName.text;
			loginEmail = "";
			if (!Username.isValid(loginUsername))
			{
				errorStatus("InvalidUsername");
				return;
			}
			PlayerConfig.dict["username"].stringVal = loginUsername;
			PlayerConfig.saveData();
			Login.GetEmailForUsername(loginUsername, loginPassword, emailLoginCallback);
			userLoginWindow.setLoading();
		}
		else
		{
			userLoginWindow.setLoading();
			continueLogin();
		}
	}

	public void continueLogin()
	{
	}

	public void emailLoginCallback(string returnedEmail, string errorReason)
	{
		if (errorReason != "")
		{
			userLoginWindow.setLogin();
			errorStatus(errorReason);
		}
		else
		{
			loginEmail = returnedEmail;
			continueLogin();
		}
	}

	private void errorStatus(string pMessage)
	{
		if (LocalizedTextManager.stringExists(pMessage))
		{
			textStatusMessage.GetComponent<LocalizedText>().key = pMessage;
			textStatusMessage.GetComponent<LocalizedText>().updateText();
		}
		else
		{
			textStatusMessage.text = pMessage;
		}
		textStatusMessage.color = Toolbox.makeColor("#FF8686");
	}

	private void goodStatus(string pMessage)
	{
		if (LocalizedTextManager.stringExists(pMessage))
		{
			textStatusMessage.GetComponent<LocalizedText>().key = pMessage;
			textStatusMessage.GetComponent<LocalizedText>().updateText();
		}
		else
		{
			textStatusMessage.text = pMessage;
		}
		textStatusMessage.color = Toolbox.makeColor("#95DD5D");
	}

	private void clearStatus()
	{
		textStatusMessage.text = "";
	}
}
