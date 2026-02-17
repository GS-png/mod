using UnityEngine;
using UnityEngine.UI;

public class UnfoldButton : MonoBehaviour
{
	[SerializeField]
	private Button _button;

	[SerializeField]
	private Text _text;

	private UnfoldAction _action;

	public int offset;

	private void Awake()
	{
		_button.onClick.AddListener(delegate
		{
			_action?.Invoke();
		});
	}

	public void setData(int pCount, int pOffset)
	{
		offset = pOffset;
		setText(pCount.ToString());
	}

	public void setCallback(UnfoldAction pCallback)
	{
		_action = pCallback;
	}

	public void setText(string pText)
	{
		_text.text = pText;
	}

	public void clear()
	{
		offset = 0;
	}

	public Button getButton()
	{
		return _button;
	}
}
