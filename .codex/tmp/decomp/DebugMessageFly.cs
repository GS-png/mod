using System.Collections.Generic;
using UnityEngine;

public class DebugMessageFly : MonoBehaviour
{
	private List<string> listString = new List<string>();

	public Transform originTransform;

	private TextMesh textMesh;

	private void Awake()
	{
		textMesh = GetComponent<TextMesh>();
	}

	public void addString(string pText)
	{
		if (textMesh.color.a < 0.3f)
		{
			listString.Clear();
		}
		else if (listString.Count > 20)
		{
			listString.RemoveAt(0);
		}
		listString.Add(pText);
		Vector3 localPosition = new Vector3(originTransform.localPosition.x, originTransform.localPosition.y);
		base.transform.localPosition = localPosition;
		string text = "";
		foreach (string item in listString)
		{
			text = text + item + "\n";
		}
		textMesh.text = text;
		Color color = textMesh.color;
		color.a = 1f;
		textMesh.color = color;
	}

	public void moveUp()
	{
		Vector3 localPosition = base.transform.localPosition;
		localPosition.y += 3f;
		base.transform.localPosition = localPosition;
	}

	private void Update()
	{
		Vector3 localScale = base.transform.localScale;
		localScale.x += 2f * Time.deltaTime;
		if (localScale.x > 1f)
		{
			localScale.x = 1f;
		}
		base.transform.localScale = localScale;
		Vector3 localPosition = base.transform.localPosition;
		localPosition.y += 0.5f * Time.deltaTime;
		base.transform.localPosition = localPosition;
		Color color = textMesh.color;
		color.a -= 0.3f * Time.deltaTime;
		textMesh.color = color;
		if (color.a <= 0f)
		{
			Object.Destroy(base.gameObject);
			DebugMessage.instance.list.Remove(this);
		}
	}
}
