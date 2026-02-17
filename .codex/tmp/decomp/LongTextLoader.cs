using System;
using UnityEngine;
using UnityEngine.UI;

public class LongTextLoader : MonoBehaviour
{
	public TextAsset textAsset;

	protected Text m_text;

	private void Start()
	{
		m_text = GetComponent<Text>();
		create();
		finish();
	}

	private void finish()
	{
		RectTransform component = m_text.GetComponent<RectTransform>();
		component.sizeDelta = new Vector2(component.sizeDelta.x, m_text.preferredHeight + 10f);
		RectTransform component2 = base.transform.parent.GetComponent<RectTransform>();
		component2.sizeDelta = new Vector2(component2.sizeDelta.x, component.sizeDelta.y);
		float num = 0f - component2.transform.localPosition.y;
		component2.parent.GetComponent<RectTransform>().sizeDelta = new Vector2(0f, component.sizeDelta.y + 20f + num);
	}

	public virtual void create()
	{
		try
		{
			m_text.text = textAsset.text;
		}
		catch (Exception)
		{
			Debug.LogError("LongTextLoader: Text File is too long");
		}
	}
}
