using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
	public Sprite icon_default;

	public Sprite icon_bear;

	public Sprite icon_ivilizations;

	public Sprite icon_nuke;

	public Sprite icon_dragon;

	public Sprite icon_tornado;

	public Sprite icon_saveBox;

	public Sprite icon_customWorld;

	public Sprite icon_worldLaws;

	public Sprite icon_greyGoo;

	public Sprite icon_ufo;

	public Sprite icon_heart;

	public Sprite icon_finger;

	public GameObject bear;

	public GameObject centerObject;

	public GameObject brushSize;

	public GameObject adButton;

	public GameObject saveButton;

	public GameObject customMapButton;

	public GameObject worldRules;

	public GameObject tabDrawing;

	public GameObject tabCivs;

	public GameObject tabCreatures;

	public GameObject tabNature;

	public GameObject tabBombs;

	public GameObject tabOther;

	public GameObject settingsButton;

	public Text text;

	public Image attentionBox;

	public Text pressAnywhere;

	private int curPage;

	private List<TutorialPage> pages;

	private float waitTimer;

	private Color color_red;

	private Color color_white;

	private Color color_yellow;

	private Color color_yellow_transparent;

	private Tweener textTypeTween;

	private void create()
	{
		pages = new List<TutorialPage>();
		color_red = Toolbox.makeColor("#FF3700");
		color_red.a = 0.4f;
		color_white = Toolbox.makeColor("#4AA5FF");
		color_white.a = 0.4f;
		color_yellow = Toolbox.makeColor("#FEFE00");
		color_yellow_transparent = Toolbox.makeColor("#FEFE00");
		color_yellow_transparent.a = 0f;
		add(new TutorialPage
		{
			text = "tut_page1",
			wait = 1f
		});
		add(new TutorialPage
		{
			text = "tut_page2",
			wait = 0.3f
		});
		add(new TutorialPage
		{
			text = "tut_page3_mobile",
			mobileOnly = true,
			centerImage = icon_finger,
			wait = 1f
		});
		add(new TutorialPage
		{
			text = "tut_page3_pc",
			pcOnly = true,
			wait = 1f
		});
		add(new TutorialPage
		{
			text = "tut_page4"
		});
		add(new TutorialPage
		{
			text = "tut_page5",
			object1 = saveButton,
			centerImage = icon_saveBox,
			wait = 1.5f
		});
		add(new TutorialPage
		{
			text = "tut_page6",
			object1 = customMapButton,
			centerImage = icon_customWorld,
			wait = 1.5f
		});
		add(new TutorialPage
		{
			text = "tut_page7",
			object1 = worldRules,
			centerImage = icon_worldLaws
		});
		add(new TutorialPage
		{
			text = "tut_page8",
			object1 = tabDrawing
		});
		add(new TutorialPage
		{
			text = "tut_page9",
			icon = "brush"
		});
		add(new TutorialPage
		{
			text = "tut_page10",
			object1 = tabCivs,
			centerImage = icon_ivilizations
		});
		add(new TutorialPage
		{
			text = "tut_page11",
			object1 = tabCreatures,
			centerImage = icon_dragon
		});
		add(new TutorialPage
		{
			text = "tut_page12",
			object1 = tabNature,
			centerImage = icon_tornado
		});
		add(new TutorialPage
		{
			text = "tut_page13",
			object1 = tabBombs,
			centerImage = icon_nuke
		});
		add(new TutorialPage
		{
			text = "tut_page14",
			object1 = tabOther,
			centerImage = icon_greyGoo
		});
		add(new TutorialPage
		{
			text = "tut_page15",
			centerImage = icon_ufo
		});
		add(new TutorialPage
		{
			text = "tut_page16",
			mobileOnly = true,
			icon = "reward",
			wait = 1.5f
		});
		add(new TutorialPage
		{
			text = "tut_page17",
			centerImage = icon_heart,
			wait = 0.5f
		});
	}

	public void startTutorial()
	{
		if (pages == null)
		{
			create();
		}
		base.gameObject.SetActive(value: true);
		curPage = -1;
		PowerButtonSelector.instance.unselectAll();
		PowerButtonSelector.instance.unselectTabs();
		attentionBox.gameObject.SetActive(value: false);
		nextPage();
	}

	private void nextPage()
	{
		curPage++;
		if (curPage >= pages.Count)
		{
			endTutorial();
			return;
		}
		pressAnywhere.GetComponent<LocalizedText>().updateText();
		TutorialPage tutorialPage = pages[curPage];
		if (!Config.isMobile && tutorialPage.mobileOnly)
		{
			nextPage();
			return;
		}
		if (Config.isMobile && tutorialPage.pcOnly)
		{
			nextPage();
			return;
		}
		if (tutorialPage.object1 == null)
		{
			attentionBox.gameObject.SetActive(value: false);
		}
		else
		{
			attentionBox.gameObject.SetActive(value: true);
			Vector3 position = tutorialPage.object1.transform.position;
			Vector2 sizeDelta = tutorialPage.object1.GetComponent<RectTransform>().sizeDelta;
			sizeDelta.x += 10f;
			sizeDelta.y += 10f;
			attentionBox.transform.position = position;
			attentionBox.rectTransform.sizeDelta = sizeDelta;
			attentionBox.DOKill();
			attentionBox.transform.localScale = new Vector3(0.5f, 0.5f);
			attentionBox.transform.DOScale(new Vector3(1f, 1f, 1f), 0.3f).SetEase(Ease.OutBack);
			attentionBox.color = color_white;
		}
		if (tutorialPage.centerImage == null)
		{
			tutorialPage.centerImage = icon_default;
		}
		centerObject.GetComponent<Image>().sprite = tutorialPage.centerImage;
		centerObject.gameObject.SetActive(value: false);
		adButton.gameObject.SetActive(value: false);
		brushSize.gameObject.SetActive(value: false);
		this.text.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
		this.text.DOKill();
		this.text.text = "";
		string text = LocalizedTextManager.getText(tutorialPage.text);
		float num = text.Length / 25;
		if (num <= 1f)
		{
			num = 1f;
		}
		this.text.text = text;
		this.text.GetComponent<LocalizedText>().checkTextFont();
		this.text.GetComponent<LocalizedText>().checkSpecialLanguages();
		text = this.text.text;
		this.text.text = "";
		textTypeTween = this.text.DOText(text, num, richTextEnabled: false);
		this.text.transform.DOScale(new Vector3(1f, 1f, 1f), 0.3f).SetEase(Ease.InBack);
		waitTimer = tutorialPage.wait;
		if (canSkipTutorial())
		{
			waitTimer = 0f;
		}
		if (waitTimer > 0f)
		{
			pressAnywhere.gameObject.SetActive(value: false);
		}
		bear.transform.DOKill();
		bear.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
		bear.transform.DOShakeRotation(num);
		if (tutorialPage.icon == "default")
		{
			centerObject.SetActive(value: true);
			centerObject.transform.DOKill();
			centerObject.transform.localScale = new Vector3(1.4f, 1.4f, 1.4f);
			centerObject.transform.DOScale(new Vector3(1f, 1f, 1f), 0.5f).SetEase(Ease.InBack);
		}
		else if (tutorialPage.icon == "reward")
		{
			adButton.SetActive(value: true);
			adButton.transform.DOKill();
			adButton.transform.localScale = new Vector3(1.4f, 1.4f, 1.4f);
			adButton.transform.DOScale(new Vector3(1f, 1f, 1f), 0.5f).SetEase(Ease.InBack);
		}
		else if (tutorialPage.icon == "brush")
		{
			brushSize.SetActive(value: true);
			brushSize.transform.DOKill();
			brushSize.transform.localScale = new Vector3(1.4f, 1.4f, 1.4f);
			brushSize.transform.DOScale(new Vector3(1f, 1f, 1f), 0.5f).SetEase(Ease.InBack);
		}
	}

	internal void completeText()
	{
	}

	private bool canSkipTutorial()
	{
		return true;
	}

	public static void restartTutorial()
	{
		PlayerConfig.instance.data.tutorialFinished = false;
		PlayerConfig.saveData();
	}

	internal bool isActive()
	{
		return base.gameObject.activeSelf;
	}

	internal void endTutorial()
	{
		base.gameObject.SetActive(value: false);
		PlayerConfig.instance.data.tutorialFinished = true;
		PlayerConfig.saveData();
		ScrollWindow.clearQueue();
	}

	private void LateUpdate()
	{
		if (attentionBox.gameObject.activeSelf)
		{
			if (attentionBox.color == color_red)
			{
				attentionBox.DOColor(color_white, 1f);
			}
			else if (attentionBox.color == color_white)
			{
				attentionBox.DOColor(color_red, 1f);
			}
		}
		if (canSkipTutorial())
		{
			if (textTypeTween.IsActive() && Input.GetMouseButtonUp(0))
			{
				textTypeTween.Kill(complete: true);
				return;
			}
		}
		else if (textTypeTween.IsActive())
		{
			return;
		}
		if (waitTimer > 0f)
		{
			waitTimer -= Time.deltaTime;
			return;
		}
		if (!pressAnywhere.gameObject.activeSelf)
		{
			pressAnywhere.gameObject.SetActive(value: true);
			pressAnywhere.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
			pressAnywhere.transform.DOScale(new Vector3(1f, 1f, 1f), 1f).SetEase(Ease.OutBack);
			pressAnywhere.color = color_yellow_transparent;
			pressAnywhere.DOColor(color_yellow, 1f);
		}
		if (Input.GetMouseButtonUp(0))
		{
			nextPage();
		}
	}

	private void add(TutorialPage pPage)
	{
		pages.Add(pPage);
	}
}
