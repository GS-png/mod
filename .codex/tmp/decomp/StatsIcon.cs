using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class StatsIcon : MonoBehaviour
{
	private const float TWEEN_DURATION = 0.45f;

	private const float SCALE = 1.2f;

	public Text text;

	private float _value = -1f;

	private float? _max_value;

	private char _separator = '/';

	private string _ending = "";

	private string _color = "";

	private bool _is_float;

	private Tweener _cur_tween;

	private Tweener _text_scale_anim;

	private bool _is_counter_enabled;

	internal bool enable_animation = true;

	private TipButton _tip_button;

	private Vector2 _default_text_scale;

	private void Awake()
	{
		if (!(text == null))
		{
			_default_text_scale = text.transform.localScale;
			if (TryGetComponent<TipButton>(out _tip_button) && _tip_button.type == "tip")
			{
				_tip_button.setHoverAction(tooltipAction);
			}
			base.gameObject.AddOrGetComponent<Button>().onClick.AddListener(restartCounter);
		}
	}

	private void tooltipAction()
	{
		if (!(_tip_button.textOnClick == "") || !(_tip_button.textOnClickDescription == ""))
		{
			CustomDataContainer<string> customDataContainer = new CustomDataContainer<string>();
			customDataContainer["value"] = _value.ToText();
			if (_max_value.HasValue)
			{
				customDataContainer["max_value"] = _max_value.Value.ToText();
			}
			TooltipData pData = new TooltipData
			{
				tip_name = _tip_button.textOnClick,
				tip_description = _tip_button.textOnClickDescription,
				tip_description_2 = _tip_button.text_description_2,
				custom_data_string = customDataContainer
			};
			Tooltip.show(base.gameObject, "stats_icon", pData);
		}
	}

	public Image getIcon()
	{
		return base.transform.Find("Icon").GetComponent<Image>();
	}

	private void restartCounter()
	{
		if (_is_counter_enabled && enable_animation)
		{
			setValue(_value, _max_value, _color, _is_float, _ending, _separator, pFromZero: true);
		}
	}

	public void setValue(float pValue)
	{
		setValue(pValue, null, "", pFloat: false, "", '/', pFromZero: false);
	}

	public bool areValuesTooClose(float pNewValue)
	{
		if (Mathf.Approximately(getValue(), pNewValue))
		{
			return true;
		}
		return false;
	}

	public void setValue(float pValue, float? pMax = null, string pColor = "", bool pFloat = false, string pEnding = "", char pSeparator = '/', bool pFromZero = false)
	{
		_is_counter_enabled = true;
		float num = (pFromZero ? 0f : _value);
		_value = pValue;
		_max_value = pMax;
		_color = pColor;
		_ending = pEnding;
		_is_float = pFloat;
		_separator = pSeparator;
		Color color = text.color;
		if (pValue == 0f)
		{
			color.a = 0.5f;
		}
		else
		{
			color.a = 1f;
		}
		text.color = color;
		if (!enable_animation)
		{
			text.text = getFinalText();
			return;
		}
		checkDestroyTween();
		string ending = getEnding();
		if (pFloat)
		{
			_cur_tween = text.DOUpCounter(num, _value, 0.45f, ending, pColor);
		}
		else
		{
			_cur_tween = text.DOUpCounter((int)num, (int)_value, 0.45f, ending, pColor);
		}
	}

	private string getEnding()
	{
		string text = "";
		if (_max_value.HasValue)
		{
			text += _separator;
			text = ((!_is_float || _max_value % 1f == 0f) ? (text + Toolbox.formatNumber((long)_max_value.Value, 4)) : (text + _max_value.Value.ToText()));
		}
		if (!string.IsNullOrEmpty(_ending))
		{
			text += _ending;
		}
		return text;
	}

	private string getFinalText()
	{
		string text = ((!_is_float || _value % 1f == 0f) ? Toolbox.formatNumber((long)_value, 4) : _value.ToText());
		text += getEnding();
		if (_color != "")
		{
			return Toolbox.coloredText(text, _color);
		}
		return text;
	}

	public float getValue()
	{
		return _value;
	}

	private void OnEnable()
	{
		restartCounter();
	}

	private void OnDisable()
	{
		checkDestroyTween();
	}

	public void checkDestroyTween()
	{
		_cur_tween.Kill(complete: true);
		_cur_tween = null;
		_text_scale_anim?.Kill(complete: true);
		_text_scale_anim = null;
	}

	public void textScaleAnimation()
	{
		text.transform.localScale = _default_text_scale * 1.2f;
		_text_scale_anim?.Kill(complete: true);
		_text_scale_anim = text.transform.DOScale(_default_text_scale, 0.1f).SetEase(Ease.InBack);
	}
}
