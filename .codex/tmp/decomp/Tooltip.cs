using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
	private static Dictionary<string, Tooltip> _dict_tooltips = new Dictionary<string, Tooltip>();

	private bool _sim_tooltip;

	private object _last_object;

	internal static float tweenTime = 0.08f;

	public Sprite tooltipTopGraphicsFlat;

	public Sprite tooltipTopGraphicsNormal;

	public Image topGraphics;

	private LayoutElement _headline;

	private VerticalLayoutGroup _layout_group;

	public Image background;

	public new Text name;

	public Text description;

	public Text description_2;

	public Text stats_description;

	public Text stats_values;

	public GameObject stats_container;

	private GameObject _description_container;

	private GameObject _description_2_container;

	internal List<TooltipOpinionInfo> opinion_list = new List<TooltipOpinionInfo>();

	internal ObjectPoolGenericMono<Image> pool_traits_actor;

	internal ObjectPoolGenericMono<TooltipOutlineItem> pool_equipments_actor;

	internal ObjectPoolGenericMono<Image> pool_traits_culture;

	internal ObjectPoolGenericMono<Image> pool_traits_language;

	internal ObjectPoolGenericMono<StatsIcon> pool_icons;

	internal ObjectPoolGenericMono<StatsIcon> pool_icons_2;

	[NonSerialized]
	public TooltipAsset asset;

	[NonSerialized]
	private string _type;

	public TooltipData data;

	private RectTransform _rect;

	private Coroutine _hide_tooltip_timer;

	private Vector2 _hide_pos;

	private float _last_height;

	private float _timeout;

	private float _timeout_animation;

	private float _clear_timeout;

	private const int TOOLTIP_WIDTH = 113;

	private const int CURSOR_MARGIN = 25;

	private bool _touch;

	private static Canvas _parent_canvas => CanvasMain.instance.canvas_tooltip;

	private void Awake()
	{
		_rect = GetComponent<RectTransform>();
		_description_container = description.transform.parent.gameObject;
		_layout_group = GetComponent<VerticalLayoutGroup>();
		_headline = topGraphics.transform.parent.GetComponent<LayoutElement>();
		if (description_2 != null)
		{
			_description_2_container = description_2.transform.parent.gameObject;
		}
	}

	public static Tooltip getTooltip(string pID)
	{
		Tooltip value = null;
		if (!_dict_tooltips.TryGetValue(pID, out value))
		{
			TooltipAsset tooltipAsset = AssetManager.tooltips.get(pID);
			if (tooltipAsset == null)
			{
				string message = "Tooltip Asset " + pID + " doesn't exist.";
				Debug.LogError(message);
				throw new Exception(message);
			}
			Tooltip tooltip = Resources.Load<Tooltip>(tooltipAsset.prefab_id);
			if (tooltip == null)
			{
				Debug.LogWarning("Tooltip prefab for " + tooltipAsset.prefab_id + " could not be found");
				tooltip = Resources.Load<Tooltip>("tooltips/tooltip_normal");
			}
			value = UnityEngine.Object.Instantiate(tooltip, _parent_canvas.transform);
			value.transform.name = tooltipAsset.id;
			value.asset = tooltipAsset;
			_dict_tooltips.Add(pID, value);
		}
		return value;
	}

	public static void checkClearAll()
	{
		foreach (Tooltip value in _dict_tooltips.Values)
		{
			value.checkClear();
		}
	}

	public void checkClear()
	{
		if (!base.gameObject.activeSelf && _last_object != null)
		{
			if (_clear_timeout < 0.2f)
			{
				_clear_timeout += Time.deltaTime;
			}
			else
			{
				_last_object = null;
			}
		}
	}

	public static bool isShowingFor(object pObject)
	{
		foreach (Tooltip value in _dict_tooltips.Values)
		{
			if (value._last_object == pObject)
			{
				return true;
			}
		}
		return false;
	}

	public static Tooltip findActive(Predicate<Tooltip> pMatch)
	{
		foreach (Tooltip value in _dict_tooltips.Values)
		{
			if (value.gameObject.activeSelf && pMatch(value))
			{
				return value;
			}
		}
		return null;
	}

	public static void show(object pObject, string pType, TooltipData pData)
	{
		if (CanvasMain.tooltip_show_timeout > 0f || ScrollWindow.isAnimationActive() || Config.isDraggingItem() || (InputHelpers.mouseSupported && (((Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetMouseButton(1)) && !Input.GetMouseButtonDown(0) && !Input.GetMouseButtonDown(1) && !Input.GetMouseButtonDown(2)) || Input.mouseScrollDelta.y != 0f)))
		{
			return;
		}
		hideTooltip(null, pOnlySimObjects: false, pType);
		Tooltip tooltip = getTooltip(pType);
		if (!(tooltip == null))
		{
			tooltip.clear();
			tooltip.data = pData;
			if (pObject != null)
			{
				tooltip.showTooltip(pObject, pType);
			}
		}
	}

	public void clearTextRows()
	{
		stats_description.text = "";
		stats_values.text = "";
	}

	private void clearStats()
	{
		clearTextRows();
		stats_container.SetActive(value: false);
		resetDescription();
		resetBottomDescription();
	}

	public void showTooltip(object pObject, string pType)
	{
		if (ScrollWindow.isAnimationActive())
		{
			return;
		}
		_touch = Input.touchCount > 0;
		bool flag = false;
		if (_last_object == pObject)
		{
			flag = true;
		}
		else if (_last_object != null)
		{
			Type type = _last_object.GetType();
			Type type2 = pObject.GetType();
			if (type == type2)
			{
				flag = true;
			}
		}
		_last_object = pObject;
		_sim_tooltip = data.is_sim_tooltip;
		if (!base.gameObject.activeSelf)
		{
			base.gameObject.SetActive(value: true);
		}
		_type = pType;
		asset = AssetManager.tooltips.get(_type);
		float tooltip_scale = data.tooltip_scale;
		float tooltip_scale2 = data.tooltip_scale;
		base.transform.localScale = new Vector3(tooltip_scale2, tooltip_scale, 1f);
		_timeout = 0.1f;
		clearStats();
		description.text = "";
		opinion_list.Clear();
		asset.callback?.Invoke(this, _type, data);
		checkBottomLineSeparator();
		showStatValues();
		LayoutRebuilder.ForceRebuildLayoutImmediate(_rect);
		reposition();
		name.GetComponent<LocalizedText>().checkSpecialLanguages(data.game_language_asset);
		description.GetComponent<LocalizedText>().checkSpecialLanguages(data.game_language_asset);
		description_2?.GetComponent<LocalizedText>().checkSpecialLanguages(data.game_language_asset);
		if (!flag)
		{
			_ = data.sound_allowed;
		}
	}

	private void checkBottomLineSeparator()
	{
		GameObject gameObject = base.transform.FindRecursive("Line Bottom Separator")?.gameObject;
		if (!(gameObject == null))
		{
			bool flag = description.gameObject.activeSelf && description.text.Length > 0;
			if (description_2.gameObject.activeSelf && description_2.text.Length > 0 && flag && stats_description.text.Length == 0)
			{
				gameObject.SetActive(value: true);
			}
			else
			{
				gameObject.SetActive(value: false);
			}
		}
	}

	public bool isTouchTooltip()
	{
		return _touch;
	}

	internal void reposition()
	{
		TooltipDirection direction = getDirection(Input.mousePosition);
		getPosition(direction, out var pPos);
		_rect.position = pPos;
		if (base.transform.localScale.x != data.tooltip_scale)
		{
			base.transform.localScale = new Vector3(data.tooltip_scale, data.tooltip_scale, 1f);
		}
		float y = background.rectTransform.sizeDelta.y;
		if (!y.Equals(_last_height))
		{
			if (y < 27f)
			{
				topGraphics.sprite = tooltipTopGraphicsNormal;
				_headline.preferredHeight = 17f;
			}
			else
			{
				topGraphics.sprite = tooltipTopGraphicsFlat;
				_headline.preferredHeight = 21.6f;
			}
			_last_height = y;
		}
	}

	internal bool nullCheck(object pObject)
	{
		if (data == null)
		{
			return true;
		}
		if (pObject == null)
		{
			return true;
		}
		if (!(pObject is NanoObject nanoObject))
		{
			if (!(pObject is GameObject gameObject))
			{
				if (pObject is MonoBehaviour monoBehaviour && (monoBehaviour == null || monoBehaviour.gameObject == null))
				{
					return true;
				}
			}
			else if (gameObject == null)
			{
				return true;
			}
		}
		else if (!nanoObject.isAlive())
		{
			return true;
		}
		return false;
	}

	internal void getPosition(TooltipDirection pDirection, out Vector2 pPos)
	{
		pPos = Input.mousePosition;
		float num = _parent_canvas.scaleFactor * data.tooltip_scale;
		_ = _rect.sizeDelta;
		_ = _rect.sizeDelta;
		Vector2 vector = new Vector2(0.5f, 0.5f);
		if (pDirection.HasFlag(TooltipDirection.Up))
		{
			vector.y = 0f;
		}
		if (pDirection.HasFlag(TooltipDirection.MagnetDown))
		{
			vector.y = 0f;
		}
		if (pDirection.HasFlag(TooltipDirection.Down))
		{
			vector.y = 1f;
		}
		if (pDirection.HasFlag(TooltipDirection.MagnetUp))
		{
			vector.y = 1f;
		}
		if (pDirection.HasFlag(TooltipDirection.Left))
		{
			vector.x = 1f;
		}
		if (pDirection.HasFlag(TooltipDirection.MagnetRight))
		{
			vector.x = 1f;
		}
		if (pDirection.HasFlag(TooltipDirection.Right))
		{
			vector.x = 0f;
		}
		if (pDirection.HasFlag(TooltipDirection.MagnetLeft))
		{
			vector.x = 0f;
		}
		if (pDirection.HasFlag(TooltipDirection.Up))
		{
			pPos.y += 25f;
		}
		if (pDirection.HasFlag(TooltipDirection.Down))
		{
			pPos.y -= 25f;
		}
		if (pDirection.HasFlag(TooltipDirection.Left))
		{
			pPos.x -= 25f;
		}
		if (pDirection.HasFlag(TooltipDirection.Right))
		{
			pPos.x += 25f;
		}
		if (pDirection.HasFlag(TooltipDirection.MagnetUp))
		{
			pPos.y = Screen.height;
		}
		if (pDirection.HasFlag(TooltipDirection.MagnetDown))
		{
			pPos.y = 0f;
		}
		if (pDirection.HasFlag(TooltipDirection.MagnetLeft))
		{
			pPos.x = 0f;
		}
		if (pDirection.HasFlag(TooltipDirection.MagnetRight))
		{
			pPos.x = Screen.width;
		}
		_rect.pivot = vector;
		_rect.anchorMin = vector;
		_rect.anchorMax = vector;
	}

	internal TooltipDirection getDirection(Vector2 pPos)
	{
		float x = pPos.x;
		float y = pPos.y;
		float num = _parent_canvas.scaleFactor * data.tooltip_scale;
		float num2 = _rect.sizeDelta.y * num + 25f;
		float num3 = _rect.sizeDelta.x * num + 25f;
		TooltipDirection tooltipDirection = TooltipDirection.None;
		bool flag = y - num2 <= 0f;
		_ = num2 / 2f;
		bool flag2 = y + num2 > (float)Screen.height;
		bool flag3 = y + num2 / 2f > (float)Screen.height;
		bool flag4 = x + num3 / 2f > (float)Screen.width;
		bool flag5 = x + num3 > (float)Screen.width;
		bool flag6 = x - num3 / 2f <= 0f;
		bool flag7 = x - num3 <= 0f;
		bool flag8 = flag6 && flag4;
		bool flag9 = flag7 && flag5;
		if (!isTouchTooltip())
		{
			tooltipDirection = (flag ? (tooltipDirection | TooltipDirection.MagnetDown) : ((!flag2) ? (tooltipDirection | TooltipDirection.Down) : (tooltipDirection | TooltipDirection.Down)));
			tooltipDirection = ((!flag5) ? (tooltipDirection | TooltipDirection.Right) : ((!flag) ? (tooltipDirection | TooltipDirection.MagnetRight) : (tooltipDirection | TooltipDirection.Left)));
		}
		else
		{
			if (flag2)
			{
				if (flag9)
				{
					tooltipDirection = ((!flag) ? (tooltipDirection | TooltipDirection.Down) : (tooltipDirection | TooltipDirection.MagnetUp));
				}
				else if (flag3)
				{
					tooltipDirection |= TooltipDirection.MagnetUp;
				}
			}
			else if (flag)
			{
				tooltipDirection |= TooltipDirection.Up;
			}
			else if (!flag8)
			{
				tooltipDirection |= TooltipDirection.Up;
			}
			if (flag6)
			{
				tooltipDirection = ((!flag7) ? (tooltipDirection | TooltipDirection.MagnetLeft) : (tooltipDirection | TooltipDirection.Right));
			}
			else if (flag4)
			{
				tooltipDirection = ((!flag5) ? (tooltipDirection | TooltipDirection.MagnetRight) : (tooltipDirection | TooltipDirection.Left));
			}
			else if (tooltipDirection == TooltipDirection.None || tooltipDirection == TooltipDirection.MagnetUp)
			{
				tooltipDirection = ((!flag7) ? (tooltipDirection | TooltipDirection.Left) : (tooltipDirection | TooltipDirection.Right));
			}
		}
		return tooltipDirection;
	}

	internal void setDescription(string pDescription, string pColor = null)
	{
		resetDescription();
		addDescription(pDescription, pColor);
	}

	internal void addDescription(string pDescription, string pColor = null)
	{
		if (pDescription != "")
		{
			if (!string.IsNullOrEmpty(pColor))
			{
				pDescription = Toolbox.coloredText(pDescription, pColor);
			}
			description.text += pDescription;
			_description_container.SetActive(value: true);
		}
	}

	internal void resetDescription()
	{
		description.text = "";
		description.font = LocalizedTextManager.current_font;
		_description_container.SetActive(value: false);
	}

	internal void setBottomDescription(string pDescription, string pColor = null)
	{
		resetBottomDescription();
		addBottomDescription(pDescription, pColor);
	}

	internal void addBottomDescription(string pDescription, string pColor = null)
	{
		if (pDescription != "")
		{
			if (!string.IsNullOrEmpty(pColor))
			{
				pDescription = Toolbox.coloredText(pDescription, pColor);
			}
			description_2.text += pDescription;
			_description_2_container.SetActive(value: true);
		}
	}

	internal void resetBottomDescription()
	{
		if (!(description_2 == null))
		{
			description_2.text = "";
			description_2.font = LocalizedTextManager.current_font;
			_description_2_container.SetActive(value: false);
		}
	}

	internal void addStatValues(string pStats, string pValues)
	{
		stats_description.text += pStats;
		stats_values.text += pValues;
		stats_container.SetActive(value: true);
	}

	internal void showOpinion(string pDescriptionString, string pValuesString, Text pTextDescription = null, Text pTextValues = null)
	{
		if (pTextDescription == null)
		{
			pTextDescription = stats_description;
			pTextValues = stats_values;
		}
		pTextDescription.text += pDescriptionString;
		pTextValues.text += pValuesString;
	}

	internal void showStatValues()
	{
		if (stats_description.text.Length > 0)
		{
			stats_container.SetActive(value: true);
			if (stats_values.TryGetComponent<LocalizedText>(out var component) && component.enabled)
			{
				component.checkSpecialLanguages();
			}
			if (stats_description.TryGetComponent<LocalizedText>(out var component2) && component2.enabled)
			{
				component2.checkSpecialLanguages();
			}
		}
	}

	internal void addItemText(string pID, float pValue, bool pPercent = false, bool pAddColor = true, bool pAddPlus = true, string pMainColor = "#43FF43", bool pForceZero = false)
	{
		if (pValue == 0f && !pForceZero)
		{
			return;
		}
		string text = pValue.ToText();
		if (pPercent)
		{
			text += "%";
		}
		if (!pAddColor)
		{
			addLineText(pID, text, "#FFFFFF", pPercent);
		}
		else if (pValue > 0f)
		{
			if (pAddPlus)
			{
				text = "+" + text;
			}
			addLineText(pID, text, pMainColor, pPercent);
		}
		else
		{
			addLineText(pID, text, "#FB2C21", pPercent);
		}
	}

	internal void addLineIntText(string pID, int pValue, string pColor = null, bool pLocalize = true)
	{
		addLineText(pID, pValue.ToText(), pColor, pPercent: false, pLocalize);
	}

	internal void addLineIntText(string pID, long pValue, string pColor = null, bool pLocalize = true, int pLimitValue = 21)
	{
		addLineLongText(pID, pValue, pColor, pLocalize, pLimitValue);
	}

	internal void addLineLongText(string pID, long pValue, string pColor = null, bool pLocalize = true, int pLimitValue = 21)
	{
		addLineText(pID, pValue.ToText(), pColor, pPercent: false, pLocalize, pLimitValue);
	}

	internal void addLineBreak()
	{
		if (stats_description.text.Length != 0)
		{
			stats_description.text += "\n";
			stats_values.text += "\n";
		}
	}

	public void tryShowBoolDebug(string pIO, bool pValue)
	{
		addLineText(pColor: (!pValue) ? "#FB2C21" : "#43FF43", pID: pIO, pValue: pValue.ToString(), pPercent: false, pLocalize: false);
	}

	internal void addLineText(string pID, string pValue, string pColor = null, bool pPercent = false, bool pLocalize = true, int pLimitValue = 21)
	{
		if (stats_description.text.Length > 0)
		{
			addLineBreak();
		}
		if (pValue != null && pValue.Length > pLimitValue)
		{
			pValue = pValue.Substring(0, pLimitValue - 1) + "...";
		}
		string text = (pLocalize ? pID.Localize() : pID);
		if (pPercent)
		{
			text += " %";
		}
		if (!string.IsNullOrEmpty(pColor))
		{
			stats_description.text += text;
			stats_values.text += Toolbox.coloredText(pValue, pColor);
		}
		else
		{
			stats_description.text += text;
			stats_values.text += pValue;
		}
	}

	internal void addOpinion(TooltipOpinionInfo pOpinion)
	{
		opinion_list.Add(pOpinion);
	}

	private void Update()
	{
		updateTextContentAnimation();
		if (_timeout > 0f)
		{
			_timeout -= Time.deltaTime;
		}
		else if (InputHelpers.GetAnyMouseButtonDown() || Input.mouseScrollDelta.y != 0f || ScrollRectExtended.isAnyDragged())
		{
			hide();
		}
	}

	private void LateUpdate()
	{
		if (_hide_tooltip_timer != null)
		{
			if (Vector2.Distance(Input.mousePosition, _hide_pos) > 10f)
			{
				hide();
			}
		}
		else
		{
			reposition();
		}
	}

	private void updateTextContentAnimation()
	{
		if (_timeout_animation > 0f)
		{
			_timeout_animation -= Time.deltaTime;
			return;
		}
		_timeout_animation = 0.08f;
		if (asset.callback_text_animated != null)
		{
			asset.callback_text_animated(this, _type, data);
		}
	}

	public void hide()
	{
		clearHideTimer();
		base.gameObject.SetActive(value: false);
		_clear_timeout = 0f;
		_sim_tooltip = false;
		data?.Dispose();
		data = null;
	}

	private void OnDisable()
	{
		clear();
	}

	private void clear()
	{
		pool_traits_actor?.clear();
		pool_equipments_actor?.clear();
		pool_traits_culture?.clear();
		pool_traits_language?.clear();
		pool_icons?.clear();
		pool_icons_2?.clear();
		clearHideTimer();
	}

	public static void hideTooltip(object pObjectToSkip, bool pOnlySimObjects, string pSkipType)
	{
		foreach (Tooltip value in _dict_tooltips.Values)
		{
			if ((pObjectToSkip == null || pObjectToSkip != value._last_object) && (!pOnlySimObjects || value._sim_tooltip) && (!(pSkipType != string.Empty) || !(value.asset.id == pSkipType)) && value.gameObject.activeSelf)
			{
				value.hide();
				value._last_object = null;
			}
		}
	}

	public static void blockTooltips(float pDuration = 0f)
	{
		hideTooltip(null, pOnlySimObjects: false, string.Empty);
		if (pDuration > 0f)
		{
			CanvasMain.addTooltipShowTimeout(pDuration);
		}
	}

	public static void hideTooltipNow()
	{
		hideTooltip(null, pOnlySimObjects: false, string.Empty);
	}

	public static void hideTooltip()
	{
		scheduledHide(0.08f);
	}

	public static bool anyActive()
	{
		foreach (Tooltip value in _dict_tooltips.Values)
		{
			if (value.gameObject.activeSelf)
			{
				return true;
			}
		}
		return false;
	}

	public static void scheduledHide(float pTimeout = 0.15f, bool pSkipTouch = false)
	{
		foreach (Tooltip value in _dict_tooltips.Values)
		{
			if (value.gameObject.activeSelf && (!pSkipTouch || !value.isTouchTooltip()))
			{
				value.scheduleHide(pTimeout);
			}
		}
	}

	public static void cancelHiding()
	{
		foreach (Tooltip value in _dict_tooltips.Values)
		{
			if (value.gameObject.activeSelf)
			{
				value.clearHideTimer();
			}
		}
	}

	private void scheduleHide(float pTimeout)
	{
		clearHideTimer();
		_hide_tooltip_timer = StartCoroutine(hideDelayed(pTimeout));
		_hide_pos = Input.mousePosition;
	}

	private void clearHideTimer()
	{
		if (_hide_tooltip_timer != null)
		{
			StopCoroutine(_hide_tooltip_timer);
		}
		_hide_tooltip_timer = null;
	}

	private IEnumerator hideDelayed(float pTimeout)
	{
		yield return new WaitForSecondsRealtime(pTimeout);
		hide();
	}

	public Image getRawIcon(string pName)
	{
		Transform obj = base.transform.FindRecursive(pName);
		if (obj == null)
		{
			Debug.LogError("Icon not found " + pName);
		}
		return obj.GetComponent<Image>();
	}

	public void setRawIcon(string pName, Sprite pSprite)
	{
		Image rawIcon = getRawIcon(pName);
		if (rawIcon == null)
		{
			Debug.LogError("Icon not found " + pName);
		}
		rawIcon.sprite = pSprite;
	}

	public void setTitle(string pMainText, string pSubText = "", string pColorHex = "#F3961F")
	{
		string text = Toolbox.coloredText(pMainText, pColorHex);
		if (pSubText != "")
		{
			string pColor = Toolbox.makeDarkerColor(pColorHex, 0.8f);
			string text2 = Toolbox.coloredText(LocalizedTextManager.getText(pSubText), pColor);
			text2 = "<size=7>" + text2 + "</size>";
			text = text + "\n" + text2;
		}
		name.text = text;
	}

	public Image getSpeciesIcon()
	{
		return getRawIcon("IconSpecies");
	}

	public void setSpeciesIcon(Sprite pSprite)
	{
		setRawIcon("IconSpecies", pSprite);
	}
}
