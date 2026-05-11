using System.Reflection;
using NeoModLoader.General;
using NeoModLoader.General.UI.Prefabs;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace EraWheel.UI;

internal enum EraUiButtonStyle
{
    Neutral = 0,
    Danger = 1
}

internal static class EraUiLayoutPrimitives
{
    public const int WindowTitleFontSize = 28;
    public const int SectionTitleFontSize = 28;
    public const int BodyFontSize = 20;
    public const int ParameterLabelFontSize = 20;
    public const int ControlValueFontSize = 18;
    public const int DescriptionFontSize = 16;
    public const int SecondaryButtonFontSize = 16;
    public const float BodyLineSpacing = 1.22f;
    public const float DescriptionLineSpacing = 1.12f;
    public const float SeparatorWidth = 576f;
    public const float SeparatorHeight = 2f;

    public static readonly Color TitleColor = new Color32(0xE7, 0xB8, 0x5B, 0xFF);
    public static readonly Color SectionTitleColor = new Color32(0xE5, 0xB9, 0x60, 0xFF);
    public static readonly Color BodyColor = new Color32(0xDD, 0xD4, 0xBB, 0xFF);
    public static readonly Color DescriptionColor = new Color32(0xD8, 0xD0, 0xB6, 0xFF);
    public static readonly Color ControlValueColor = new Color32(0xF1, 0xD9, 0x87, 0xFF);
    public static readonly Color SeparatorColor = new Color32(0x5D, 0x64, 0x54, 0xFF);

    public static float ResolveBodyWidth(ScrollWindow scrollWindow, float horizontalMargin = 12f)
    {
        if (scrollWindow.transform_viewport != null)
        {
            float viewportWidth = scrollWindow.transform_viewport.rect.width;
            if (viewportWidth > 0f)
            {
                return Mathf.Max(156f, viewportWidth - horizontalMargin);
            }
        }

        if (scrollWindow.transform_scrollRect != null)
        {
            float fallback = scrollWindow.transform_scrollRect.rect.width;
            if (fallback > 0f)
            {
                return Mathf.Max(156f, fallback - horizontalMargin);
            }
        }

        return 220f;
    }

    public static Text CreateAutoHeightLabel(
        Transform parent,
        string name,
        int fontSize,
        FontStyle fontStyle,
        string text,
        float width,
        float lineSpacing = 1f,
        TextAnchor alignment = TextAnchor.UpperLeft,
        Color? color = null)
    {
        GameObject labelObject = new(name, typeof(RectTransform), typeof(Text), typeof(ContentSizeFitter), typeof(LayoutElement));
        labelObject.transform.SetParent(parent, false);

        RectTransform labelRect = labelObject.GetComponent<RectTransform>();
        labelRect.sizeDelta = new Vector2(width, 0f);

        ContentSizeFitter fitter = labelObject.GetComponent<ContentSizeFitter>();
        fitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
        fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

        LayoutElement layout = labelObject.GetComponent<LayoutElement>();
        layout.preferredWidth = width;
        layout.minWidth = width;
        layout.minHeight = fontSize + 4f;
        layout.flexibleWidth = 0f;
        layout.flexibleHeight = 0f;

        Text label = labelObject.GetComponent<Text>();
        OT.InitializeCommonText(label);
        label.text = text;
        label.fontSize = fontSize;
        label.fontStyle = fontStyle;
        label.lineSpacing = lineSpacing;
        label.color = color ?? Color.white;
        label.alignment = alignment;
        label.horizontalOverflow = HorizontalWrapMode.Wrap;
        label.verticalOverflow = VerticalWrapMode.Overflow;
        label.resizeTextForBestFit = false;
        return label;
    }

    public static SimpleButton CreateStyledActionButton(
        Transform parent,
        string name,
        string text,
        Sprite icon,
        Vector2 size,
        EraUiButtonStyle style,
        System.Action click)
    {
        SimpleButton button = Object.Instantiate(APrefab<SimpleButton>.Prefab, parent);
        button.name = name;
        button.transform.localScale = Vector3.one;
        button.Setup(() => click(), icon, text, size);
        button.Text.resizeTextForBestFit = true;
        button.Text.resizeTextMinSize = 12;
        button.Text.resizeTextMaxSize = ControlValueFontSize;
        button.Text.fontSize = ControlValueFontSize;
        button.Text.fontStyle = FontStyle.Bold;
        button.Text.lineSpacing = 1f;
        button.Text.color = ControlValueColor;
        button.Text.alignment = TextAnchor.MiddleCenter;
        ApplyButtonStyle(button, style);
        return button;
    }

    public static void ApplyTextInputValueStyle(TextInput input)
    {
        if (input == null)
        {
            return;
        }

        ApplyControlValueText(input.text);
        if (input.input != null)
        {
            ApplyControlValueText(input.input.textComponent);
        }
    }

    public static void ApplySwitchTextStyle(NeoModLoader.General.UI.Prefabs.SwitchButton switchButton)
    {
        if (switchButton == null)
        {
            return;
        }

        ApplyControlValueText(switchButton.text);
    }

    private static void ApplyControlValueText(Text text)
    {
        if (text == null)
        {
            return;
        }

        text.fontSize = ControlValueFontSize;
        text.fontStyle = FontStyle.Bold;
        text.lineSpacing = 1f;
        text.color = ControlValueColor;
        text.alignment = TextAnchor.MiddleCenter;
        text.resizeTextForBestFit = true;
        text.resizeTextMinSize = 12;
        text.resizeTextMaxSize = ControlValueFontSize;
    }

    public static WindowMetaTab CreateResponsiveTabButton(
        Transform parent,
        string name,
        string tabId,
        string labelKey,
        float width,
        FieldInfo? tabCanvasGroupField)
    {
        GameObject buttonObject = new(name, typeof(RectTransform), typeof(LayoutElement));
        buttonObject.SetActive(false);
        buttonObject.transform.SetParent(parent, false);

        RectTransform rect = buttonObject.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(width, 28f);

        LayoutElement layout = buttonObject.GetComponent<LayoutElement>();
        layout.preferredWidth = width;
        layout.minWidth = 48f;
        layout.preferredHeight = 28f;

        Image image = buttonObject.AddComponent<Image>();
        image.sprite = SpriteTextureLoader.getSprite("ui/tab_button_vertical");
        image.type = Image.Type.Sliced;
        image.raycastTarget = true;

        Button button = buttonObject.AddComponent<Button>();
        button.targetGraphic = image;

        CanvasGroup canvasGroup = buttonObject.AddComponent<CanvasGroup>();
        canvasGroup.alpha = 1f;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;

        TipButton tipButton = buttonObject.AddComponent<TipButton>();
        tipButton.textOnClick = labelKey;
        tipButton.textOnClickDescription = string.Empty;
        tipButton.type = "tip";

        WindowMetaTab tab = buttonObject.AddComponent<WindowMetaTab>();
        tab.name = tabId;
        tab.tab_action = new WindowMetaTabEvent();
        tabCanvasGroupField?.SetValue(tab, canvasGroup);

        GameObject textObject = new("Label", typeof(RectTransform), typeof(Text));
        textObject.transform.SetParent(buttonObject.transform, false);
        RectTransform textRect = textObject.GetComponent<RectTransform>();
        textRect.anchorMin = Vector2.zero;
        textRect.anchorMax = Vector2.one;
        textRect.offsetMin = new Vector2(6f, 3f);
        textRect.offsetMax = new Vector2(-6f, -3f);

        Text textComponent = textObject.GetComponent<Text>();
        OT.InitializeCommonText(textComponent);
        textComponent.text = LM.Get(labelKey);
        textComponent.fontSize = SecondaryButtonFontSize;
        textComponent.fontStyle = FontStyle.Bold;
        textComponent.alignment = TextAnchor.MiddleCenter;
        textComponent.color = ControlValueColor;
        textComponent.horizontalOverflow = HorizontalWrapMode.Overflow;
        textComponent.verticalOverflow = VerticalWrapMode.Truncate;
        textComponent.resizeTextForBestFit = true;
        textComponent.resizeTextMinSize = 12;
        textComponent.resizeTextMaxSize = SecondaryButtonFontSize;
        textComponent.raycastTarget = false;

        buttonObject.SetActive(true);
        return tab;
    }

    private static void ApplyButtonStyle(SimpleButton button, EraUiButtonStyle style)
    {
        string spritePath = style == EraUiButtonStyle.Danger
            ? "ui/special/special_buttonRed"
            : "ui/special/special_buttonGray";

        Sprite styleSprite = SpriteTextureLoader.getSprite(spritePath);
        if (styleSprite == null)
        {
            styleSprite = SpriteTextureLoader.getSprite("ui/special/special_buttonRed");
        }

        if (styleSprite != null)
        {
            button.Background.sprite = styleSprite;
            button.Background.type = Image.Type.Sliced;
        }
    }
}
