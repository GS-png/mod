using UnityEngine;
using UnityEngine.UI;

public class UserLoginWindow : MonoBehaviour
{
	public GameObject groupLogged;

	public GameObject groupLogin;

	public GameObject groupLoading;

	public Text usernameText;

	public Text windowTitle;

	public InputField inputTextUser;

	public InputField inputTextPassword;

	public Text textMessage;

	private bool isLoggedIn;

	public void Start()
	{
		checkState();
		if (PlayerConfig.dict["username"].stringVal != "")
		{
			inputTextUser.text = PlayerConfig.dict["username"].stringVal;
		}
	}

	public void checkState()
	{
		Debug.Log("Check Login Window State");
		if (Auth.isLoggedIn)
		{
			if (Auth.displayName != "" && Auth.displayName != null)
			{
				Debug.Log("displayName found");
				usernameText.text = Auth.displayName;
			}
			else if (Auth.userName != "" && Auth.userName != null)
			{
				Debug.Log("userName found");
				usernameText.text = Auth.userName;
			}
			else
			{
				Debug.Log("emailAddress found");
				usernameText.text = Auth.emailAddress;
			}
			setLogout();
		}
		else
		{
			setLogin();
		}
		isLoggedIn = Auth.isLoggedIn;
	}

	public void Update()
	{
		if (isLoggedIn != Auth.isLoggedIn)
		{
			checkState();
		}
	}

	public void setLoading()
	{
		windowTitle.GetComponent<LocalizedText>().key = "logging_in";
		windowTitle.GetComponent<LocalizedText>().updateText();
		groupLogin.SetActive(value: false);
		groupLogged.SetActive(value: false);
		groupLoading.SetActive(value: true);
	}

	public void setLogin()
	{
		windowTitle.GetComponent<LocalizedText>().key = "Login";
		windowTitle.GetComponent<LocalizedText>().updateText();
		groupLogged.SetActive(value: false);
		groupLoading.SetActive(value: false);
		groupLogin.SetActive(value: true);
	}

	public void setLogout()
	{
		windowTitle.GetComponent<LocalizedText>().key = "welcome_worldnet";
		windowTitle.GetComponent<LocalizedText>().updateText();
		groupLogin.SetActive(value: false);
		groupLoading.SetActive(value: false);
		groupLogged.SetActive(value: true);
	}

	public void clearWindow(string pMessage = "...")
	{
		textMessage.text = pMessage;
		inputTextPassword.text = "";
		inputTextUser.text = "";
	}

	public void clearCredentials()
	{
		inputTextPassword.text = "";
		inputTextUser.text = "";
		if (PlayerConfig.dict["username"].stringVal != "")
		{
			inputTextUser.text = PlayerConfig.dict["username"].stringVal;
		}
	}
}
