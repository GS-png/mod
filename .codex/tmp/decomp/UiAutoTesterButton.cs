using UnityEngine;
using UnityEngine.UI;

public class UiAutoTesterButton : MonoBehaviour
{
	public Sprite button_on;

	public Sprite button_off;

	public Text text;

	public Button button;

	private string _tester_name;

	public void Awake()
	{
		button.onClick.AddListener(click);
		_tester_name = base.gameObject.transform.name;
	}

	public void Start()
	{
		_tester_name = base.gameObject.transform.name;
		checkButtonGraphics();
	}

	private void OnEnable()
	{
		checkButtonGraphics();
	}

	private void OnValidate()
	{
		string obj = base.gameObject.transform.name;
		string text = "";
		int num = 0;
		bool flag = true;
		string text2 = obj;
		for (int i = 0; i < text2.Length; i++)
		{
			char c = text2[i];
			if (flag)
			{
				c = char.ToUpper(c);
				flag = false;
			}
			if (num == 0)
			{
				text += c;
			}
			else
			{
				if (c == '_')
				{
					c = ' ';
					flag = true;
				}
				text += c;
			}
			num++;
		}
		this.text.text = text;
	}

	public void click()
	{
		AssetManager.loadAutoTester();
		if (World.world.auto_tester.active_tester == _tester_name)
		{
			World.world.auto_tester.toggleAutoTester();
		}
		else
		{
			World.world.auto_tester.create(_tester_name);
			World.world.auto_tester.gameObject.SetActive(value: true);
		}
		checkButtonGraphics();
		ScrollWindow.hideAllEvent();
	}

	private void checkButtonGraphics()
	{
		if (World.world.auto_tester.active && World.world.auto_tester.active_tester == _tester_name)
		{
			button.GetComponent<Image>().sprite = button_on;
		}
		else
		{
			button.GetComponent<Image>().sprite = button_off;
		}
	}
}
