using UnityEngine;
using UnityEngine.UI;

public class UserRegisterWindow : MonoBehaviour
{
	public GameObject page1;

	public GameObject page2;

	public GameObject successPage;

	public GameObject creationPage;

	public Button usernameCheckButton;

	public Button emailCheckButton;

	public InputField inputTextUsername;

	public InputField inputTextEmail;

	public InputField inputTextPassword;

	public Text textMessage;

	private static string _email = "";

	private static string _password = "";

	private static string _username = "";

	public void Start()
	{
		checkState();
	}

	private void OnEnable()
	{
		checkState();
	}

	public void RegisterNewAccount(string username, string password, string email)
	{
		_username = username;
		_password = password;
		_email = email;
	}

	public void registerAccountCallback(string errorReason)
	{
		Config.lockGameControls = false;
	}

	public void checkState()
	{
		Debug.Log("Check Register Window State");
		if (Auth.isLoggedIn)
		{
			setSuccess();
			return;
		}
		setPage1();
		blockRegister1Button();
		blockRegister2Button();
	}

	public void setSuccess()
	{
		Config.lockGameControls = false;
		page2.SetActive(value: false);
		page1.SetActive(value: false);
		creationPage.SetActive(value: false);
		successPage.SetActive(value: true);
	}

	public void setPage2()
	{
		Config.lockGameControls = false;
		page1.SetActive(value: false);
		successPage.SetActive(value: false);
		creationPage.SetActive(value: false);
		page2.SetActive(value: true);
	}

	public void setPage1()
	{
		Config.lockGameControls = false;
		page2.SetActive(value: false);
		successPage.SetActive(value: false);
		creationPage.SetActive(value: false);
		page1.SetActive(value: true);
		if (!string.IsNullOrEmpty(inputTextUsername?.text))
		{
			RegisterUsername.runUsernameCheck(inputTextUsername);
		}
	}

	public void setCreation()
	{
		Config.lockGameControls = true;
		page1.SetActive(value: false);
		page2.SetActive(value: false);
		successPage.SetActive(value: false);
		creationPage.SetActive(value: true);
	}

	public void blockRegister1Button()
	{
		usernameCheckButton.GetComponent<CanvasGroup>().alpha = 0.2f;
		usernameCheckButton.interactable = false;
	}

	public void unblockRegister1Button()
	{
		usernameCheckButton.GetComponent<CanvasGroup>().alpha = 1f;
		usernameCheckButton.interactable = true;
	}

	public void blockRegister2Button()
	{
		emailCheckButton.GetComponent<CanvasGroup>().alpha = 0.2f;
		emailCheckButton.interactable = false;
	}

	public void unblockRegister2Button()
	{
		emailCheckButton.GetComponent<CanvasGroup>().alpha = 1f;
		emailCheckButton.interactable = true;
	}

	public void newStatus(string pMessage)
	{
		Debug.Log("new status " + pMessage);
		if (LocalizedTextManager.stringExists(pMessage))
		{
			textMessage.GetComponent<LocalizedText>().key = pMessage;
			textMessage.GetComponent<LocalizedText>().updateText();
		}
		else
		{
			textMessage.text = pMessage;
		}
	}

	public void clearStatus()
	{
		newStatus("");
	}

	public void blockRegisterButton()
	{
	}
}
