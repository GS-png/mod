using System;
using Newtonsoft.Json;
using Proyecto26;
using UnityEngine;
using UnityEngine.Purchasing;

internal static class Discounts
{
	private static ProductMetadata localPriceData;

	private static string platform;

	internal static void checkDiscounts()
	{
		try
		{
			checkPlatform();
			if (InAppManager.instance != null && InAppManager.instance?.controller?.products != null)
			{
				Product product = InAppManager.instance.controller.products.WithID("premium");
				if (product != null)
				{
					discountRequest(product.metadata);
				}
				else
				{
					Debug.Log("DC:no req/prod");
				}
			}
			else
			{
				Debug.Log("DC:np");
			}
		}
		catch (Exception message)
		{
			Debug.Log("DC:err");
			Debug.Log(message);
		}
	}

	private static void discountRequest(ProductMetadata pProductMeta)
	{
		if (platform.Length < 2 || pProductMeta == null)
		{
			return;
		}
		string url = "https://currency.superworldbox.com/discounts/" + platform + ".json?" + Toolbox.cacheBuster();
		string text = JsonConvert.SerializeObject(pProductMeta, new JsonSerializerSettings
		{
			DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate
		});
		if (string.IsNullOrEmpty(text) || text == "{}")
		{
			return;
		}
		RestClient.Post(url, text).Then(delegate(ResponseHelper response)
		{
			string text2 = response.Text;
			if (!string.IsNullOrEmpty(text2) && !(text2 == "{}") && !(text2.Substring(0, 1) != "{"))
			{
				Debug.Log(text2);
				DiscountData discountData = JsonConvert.DeserializeObject<DiscountData>(text2);
				Debug.Log("DS:Setting");
				if (!string.IsNullOrEmpty(discountData.discount) && !string.IsNullOrEmpty(discountData.price_current) && !string.IsNullOrEmpty(discountData.price_old))
				{
					LocalizedTextPrice.discount = discountData.discount;
					LocalizedTextPrice.price_current = discountData.price_current;
					LocalizedTextPrice.price_old = discountData.price_old;
					Debug.Log("DS:Set");
				}
				else
				{
					Debug.Log("DS:NSet");
				}
			}
		}).Catch(delegate(Exception err)
		{
			Debug.Log("DS:err");
			Debug.Log(err.Message);
		});
	}

	private static void checkPlatform()
	{
		switch (Application.platform)
		{
		case RuntimePlatform.WindowsPlayer:
			platform = "pc";
			break;
		case RuntimePlatform.WindowsEditor:
			platform = "pc";
			break;
		case RuntimePlatform.LinuxPlayer:
			platform = "linux";
			break;
		case RuntimePlatform.LinuxEditor:
			platform = "linux";
			break;
		case RuntimePlatform.OSXEditor:
			platform = "mac";
			break;
		case RuntimePlatform.OSXPlayer:
			platform = "mac";
			break;
		case RuntimePlatform.IPhonePlayer:
			platform = "ios";
			break;
		case RuntimePlatform.Android:
			platform = "android";
			break;
		default:
			platform = "unknown";
			break;
		}
	}
}
