using System;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Security;
using UnityEngine.UI;

public class WindowPremiumRestoreHelper : MonoBehaviour
{
	[SerializeField]
	private Text _text_console;

	private float _restore_timeout;

	private static string COLOR_LEFT_DARK = "#45B714";

	private const float RESTORE_TIMEOUT = 6f;

	private bool _show_caret = true;

	private readonly string[] _restore_phrases = new string[31]
	{
		"Restoring", "Verifying integrity", "Authenticating deities", "Decrypting receipts", "Syncing time", "Validating purpose", "Loading configs", "Rebuilding indexes", "Rechecking derps", "Clearing temps",
		"Allocating memory", "Running diagnostics", "Parsing metadata", "Linking modules", "Thinking", "Untangling", "Melting", "Cooking", "Resurrecting skeletons", "Negotiating with entropy",
		"Reattaching soul bindings", "Refreshing mythos", "Loading universal constants", "Aligning timelines", "Resetting divine counters", "Auditing reality logs", "Reinitializing worldframe", "Binding laws of physics", "Sealing causality breaches", "Decoding fate instructions",
		"Sanitizing memory cache"
	};

	private int _restore_index;

	private string user => "w:/box:".ColorHex(COLOR_LEFT_DARK);

	private void OnEnable()
	{
		updateConsoleText();
	}

	public void startRestoreTimeout()
	{
		_restore_timeout = 6f;
		_restore_index = 0;
		_restore_phrases.Shuffle();
		updateConsoleText();
	}

	private void Update()
	{
		if (_restore_timeout > 0f)
		{
			_restore_timeout -= Time.deltaTime;
			if (Time.frameCount % Randy.randomInt(15, 40) != 0)
			{
				return;
			}
		}
		else if (Time.frameCount % 30 != 0)
		{
			return;
		}
		updateConsoleText();
	}

	private void updateConsoleText()
	{
		_show_caret = !_show_caret;
		if (InAppManager.restore_ui_buffering || _restore_timeout > 0f)
		{
			showTerminalLoading();
		}
		else
		{
			showTerminalInfo();
		}
	}

	private void showTerminalLoading()
	{
		if (_restore_index < 14 && _restore_index < _restore_phrases.Length)
		{
			_restore_index++;
		}
		using StringBuilderPool stringBuilderPool = new StringBuilderPool();
		for (int i = 0; i < _restore_index; i++)
		{
			float num = Mathf.Clamp01((float)(i + 1) / (float)_restore_phrases.Length);
			int num2 = Mathf.RoundToInt(num * 100f);
			int num3 = Mathf.RoundToInt(num * 4f);
			int count = 4 - num3;
			string barColor = getBarColor(num);
			string pString = ("[" + new string('█', num3) + new string('░', count) + "]").ColorHex(barColor);
			string pString2 = _restore_phrases[i].ToLower().PadRight(27);
			string text = $"{num2,2}%".ColorHex("#FFFF66");
			string pColorHex = ((i < _restore_index - 3) ? "#558855" : COLOR_LEFT_DARK);
			string text2 = user.ColorHex(pColorHex);
			string text3 = pString2.ColorHex(pColorHex);
			string text4 = pString.ColorHex(pColorHex);
			stringBuilderPool.AppendLine(text2 + " " + text3 + " " + text4 + " " + text);
		}
		stringBuilderPool.AppendLine(">".ColorHex(COLOR_LEFT_DARK));
		_text_console.text = stringBuilderPool.ToString();
	}

	private void showTerminalInfo()
	{
		using StringBuilderPool stringBuilderPool = new StringBuilderPool();
		PlayerConfigData playerConfigData = PlayerConfig.instance?.data;
		if (!string.IsNullOrEmpty(InAppManager.restore_message))
		{
			stringBuilderPool.AppendLine((user + " " + InAppManager.restore_message).blue());
		}
		if (playerConfigData != null && playerConfigData.premiumDisabled)
		{
			stringBuilderPool.AppendLine((user + " Premium disabled in debug menu!").red());
		}
		stringBuilderPool.AppendLine(user + " Premium active: " + ((playerConfigData != null) ? playerConfigData.premium.blue() : null) + " / " + Config.hasPremium.blue());
		stringBuilderPool.AppendLine(user + " web_status: " + Application.internetReachability.ToString().blue());
		if (InAppManager.instance == null || InAppManager.instance.controller == null)
		{
			stringBuilderPool.AppendLine((user + " InAppManager not initialized").red());
		}
		else
		{
			stringBuilderPool.AppendLine((user + " InAppManager initialized").blue());
			if (!InAppManager.googleAccount)
			{
				stringBuilderPool.AppendLine((user + " Google account missing? Not logged in?").red());
			}
			if (InAppManager.validator == null)
			{
				if (!string.IsNullOrEmpty(InAppManager.validator_message))
				{
					stringBuilderPool.AppendLine((user + " Validator error " + InAppManager.validator_message).red());
				}
				else
				{
					stringBuilderPool.AppendLine((user + " Validator not initialized").red());
				}
			}
			else
			{
				stringBuilderPool.AppendLine((user + " Validator initialized").blue());
			}
			Product product = InAppManager.instance.controller.products.WithID("premium");
			if (product != null)
			{
				stringBuilderPool.AppendLine(user + " available: " + product.availableToPurchase.blue() + " has_receipt: " + product.hasReceipt.yellow());
				if (!product.hasReceipt)
				{
					stringBuilderPool.AppendLine((user + " current user doesn't have a receipt - product not owned").red());
				}
				else
				{
					stringBuilderPool.AppendLine((user + " current user has a receipt!").blue());
				}
				stringBuilderPool.AppendLine(user + " tx: " + (product.transactionID?.Truncate(26)).yellow());
				stringBuilderPool.AppendLine(user + " valid: " + InAppManager.last_tValidPurchase.blue() + " pending: " + InAppManager.last_tPurchasePending.blue());
				if (product.hasReceipt && InAppManager.validator != null)
				{
					try
					{
						IPurchaseReceipt[] array = InAppManager.validator.Validate(product.receipt);
						int num = 0;
						IPurchaseReceipt[] array2 = array;
						foreach (IPurchaseReceipt purchaseReceipt in array2)
						{
							num++;
							if (purchaseReceipt != null)
							{
								stringBuilderPool.AppendLine(string.Format("{0} {1} re: {2} {3}", user, num, purchaseReceipt.productID.yellow(), purchaseReceipt.purchaseDate.ToString("yyyy-MM-dd HH:mmzzz").blue()));
								stringBuilderPool.AppendLine($"{user} {num} tx: {purchaseReceipt.transactionID.yellow()}");
								if (purchaseReceipt is GooglePlayReceipt googlePlayReceipt)
								{
									stringBuilderPool.AppendLine($"{user} {num} re: {googlePlayReceipt.orderID.yellow()} {googlePlayReceipt.purchaseState.blue()}");
								}
								if (purchaseReceipt is AppleInAppPurchaseReceipt appleInAppPurchaseReceipt)
								{
									stringBuilderPool.AppendLine(string.Format("{0} {1} re: {2} {3}", user, num, appleInAppPurchaseReceipt.originalTransactionIdentifier.yellow(), appleInAppPurchaseReceipt.originalPurchaseDate.ToString("yyyy-MM-dd HH:mmzzz").blue()));
									stringBuilderPool.AppendLine(string.Format("{0} {1} re: {2}", user, num, appleInAppPurchaseReceipt.cancellationDate.ToString("yyyy-MM-dd HH:mmzzz").blue()));
									stringBuilderPool.AppendLine($"{user} {num} re: {appleInAppPurchaseReceipt.productType.ToString().yellow()}");
								}
							}
						}
					}
					catch (Exception arg)
					{
						stringBuilderPool.AppendLine($"{user} Exception: {arg}");
					}
				}
			}
			else
			{
				stringBuilderPool.AppendLine((user + " Product not found").red());
			}
		}
		stringBuilderPool.AppendLine(user + " op: " + ButtonEvent.premium_restore_opened.blue() + " res: " + ButtonEvent.premium_restore_action_pressed.blue() + " more: " + $"{ButtonEvent.premium_more_help_pressed}".blue());
		using ListPool<string> listPool = new ListPool<string>(6);
		if (!string.IsNullOrEmpty(Config.gs))
		{
			listPool.Add(Config.gs?.Truncate(11) ?? generateFakeMD5('G'));
		}
		if (playerConfigData != null && !playerConfigData.pPossible0507)
		{
			listPool.Add(generateFakeMD5('P'));
		}
		while (listPool.Count < 6)
		{
			listPool.Add(generateRandomMD5());
		}
		listPool.Shuffle();
		for (int j = 0; j < listPool.Count; j += 2)
		{
			stringBuilderPool.AppendLine(user + " " + listPool[j].blue() + " " + listPool[j + 1].blue());
		}
		stringBuilderPool.AppendLine(user + " OS: " + SystemInfo.operatingSystem.blue());
		stringBuilderPool.AppendLine(user + " device: " + SystemInfo.deviceModel.blue());
		stringBuilderPool.AppendLine(user + " type: " + SystemInfo.deviceType.ToString().ToUpper().Truncate(4)
			.blue() + " imode: " + Application.installMode.ToString().ToUpper().Truncate(4)
			.blue() + " sand: " + (Application.sandboxType.ToString().ToUpper().Truncate(4)
			.blue() ?? "").blue());
		stringBuilderPool.AppendLine(user + " v: " + Config.versionCodeText.blue() + " (" + Config.gitCodeText.blue() + ")");
		if (!Config.hasPremium)
		{
			stringBuilderPool.AppendLine(user + " " + "IF YOU HAVE ISSUES SHOW THIS TO DEVS".red());
		}
		else
		{
			stringBuilderPool.AppendLine(user + " " + "ALL GOOD! Enjoy WorldBox".yellow());
		}
		if (_show_caret)
		{
			stringBuilderPool.AppendLine("> █".ColorHex(COLOR_LEFT_DARK));
		}
		else
		{
			stringBuilderPool.AppendLine(">".ColorHex(COLOR_LEFT_DARK));
		}
		_text_console.text = stringBuilderPool.ToString();
	}

	private string generateRandomMD5(int pLength = 4)
	{
		if (pLength <= 0)
		{
			return string.Empty;
		}
		using StringBuilderPool stringBuilderPool = new StringBuilderPool();
		for (int i = 0; i < pLength; i++)
		{
			string value = Randy.randomInt(0, 256).ToString("X2");
			stringBuilderPool.Append(value);
			stringBuilderPool.Append(':');
		}
		return stringBuilderPool.ToString().TrimEnd(':');
	}

	private string generateFakeMD5(char pLetter, int pLength = 4)
	{
		if (pLength <= 0)
		{
			return string.Empty;
		}
		using StringBuilderPool stringBuilderPool = new StringBuilderPool();
		for (int i = 0; i < pLength; i++)
		{
			stringBuilderPool.Append(pLetter);
			stringBuilderPool.Append(pLetter);
			stringBuilderPool.Append(':');
		}
		return stringBuilderPool.ToString().TrimEnd(':');
	}

	private string getBarColor(float progress)
	{
		if (progress < 0.3f)
		{
			return "#FF5555";
		}
		if (progress < 0.7f)
		{
			return "#FFFF55";
		}
		return "#55FF55";
	}
}
