using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
	public InputField inputField;

	public Text textField;

	private string LastValue;

	public bool can_be_empty;

	public bool is_onomastics;

	private Outline _outline;

	private void Start()
	{
		textField.horizontalOverflow = HorizontalWrapMode.Wrap;
		if (is_onomastics)
		{
			inputField.onValidateInput = validateOnomastics;
		}
		else
		{
			inputField.onValidateInput = validate;
		}
	}

	private char validate(string pText, int pCharIndex, char pAddedChar)
	{
		if (pAddedChar == '<' || pAddedChar == '>')
		{
			return '\0';
		}
		return pAddedChar;
	}

	private char validateOnomastics(string pText, int pCharIndex, char pAddedChar)
	{
		char c = pAddedChar;
		bool flag = char.IsLetter(c);
		bool flag2 = char.IsWhiteSpace(c);
		bool flag3 = c == '\'';
		bool flag4 = pText.Length == 0;
		if (!(flag || flag2 || flag3))
		{
			return '\0';
		}
		if (flag4)
		{
			return char.ToUpper(c);
		}
		char num = pText[pText.Length - 1];
		bool flag5 = char.IsLetter(num);
		bool flag6 = char.IsWhiteSpace(num);
		bool flag7 = num == '\'';
		if (flag)
		{
			if (flag5)
			{
				c = char.ToLower(c);
			}
			else if (flag6)
			{
				c = char.ToUpper(c);
			}
		}
		else if (flag2)
		{
			if (flag6)
			{
				return '\0';
			}
		}
		else if (flag3 && flag7)
		{
			return '\0';
		}
		return c;
	}

	public void addListener(UnityAction<string> pAction)
	{
		inputField.onValueChanged.AddListener(pAction);
	}

	private void OnEnable()
	{
		inputField.onEndEdit.AddListener(checkInput);
	}

	private void OnDisable()
	{
		inputField.onEndEdit.RemoveAllListeners();
		if (_outline != null)
		{
			_outline.enabled = false;
		}
	}

	public void SetOutline()
	{
		if (_outline == null)
		{
			_outline = inputField.gameObject.AddOrGetComponent<Outline>();
		}
		_outline.enabled = true;
		Color color = textField.color;
		Color effectColor = new Color(color.r, color.g, color.b, 0.2f);
		_outline.effectColor = effectColor;
	}

	private void checkInput(string pInput)
	{
		if (string.IsNullOrWhiteSpace(pInput) && !can_be_empty)
		{
			inputField.text = LastValue;
		}
		else
		{
			LastValue = pInput;
		}
	}

	public void setText(string pText)
	{
		textField.text = pText;
		inputField.text = pText;
		LastValue = pText;
	}
}
