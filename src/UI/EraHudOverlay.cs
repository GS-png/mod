using System;
using System.Collections.Generic;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Core.Constants;
using EraWheel.Save.Models;
using NeoModLoader.ui;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EraWheel.UI;

public static class EraHudOverlay
{
    private const float RefreshInterval = 0.5f;

    private static readonly Vector2 DefaultPosition = new(12f, -128f);
    private static readonly Vector2 BoardSize = new(640f, 360f);
    private static readonly string[] StageShortLabels = { "预发", "预兆", "苏醒", "降临", "重建" };
    private static readonly float[] StageCenterXs = { 104f, 212f, 320f, 428f, 536f };
    private const float MaxScreenWidthRatio = 0.42f;
    private const float MaxScreenHeightRatio = 0.34f;
    private const float MaxHudPixelWidth = 760f;
    private const float MaxHudPixelHeight = 430f;
    private const float MinHudScale = 0.40f;

    private static readonly Color OuterEdgeFill = Rgb(10, 18, 25, 0.28f);
    private static readonly Color OuterEdgeStroke = Rgb(104, 130, 154, 0.78f);
    private static readonly Color InnerSlabFill = Rgb(17, 27, 36, 0.48f);
    private static readonly Color InnerSlabStroke = Rgb(91, 112, 131, 0.84f);
    private static readonly Color TopSheenColor = Rgb(141, 183, 214, 0.05f);
    private static readonly Color WatermarkColor = Rgb(131, 160, 184, 0.08f);
    private static readonly Color TitleBandFill = Rgb(24, 36, 48, 0.58f);
    private static readonly Color TitleBandStroke = Rgb(111, 138, 162, 0.84f);
    private static readonly Color TitleNotchColor = Rgb(62, 78, 94, 0.95f);
    private static readonly Color TextPrimary = Rgb(239, 244, 250);
    private static readonly Color TextSecondary = Rgb(183, 195, 207);
    private static readonly Color TierPillFill = Rgb(16, 24, 32, 0.52f);
    private static readonly Color TierPillStroke = Rgb(119, 145, 167, 0.86f);
    private static readonly Color TierTextColor = Rgb(217, 227, 236);
    private static readonly Color StageBaseLineColor = Rgb(51, 65, 77, 0.72f);
    private static readonly Color StageLinkDimColor = Rgb(67, 85, 101, 0.90f);
    private static readonly Color StageLinkBrightColor = Rgb(118, 175, 255, 0.98f);
    private static readonly Color StageRingColor = Rgb(90, 107, 121, 0.80f);
    private static readonly Color StageGemColor = Rgb(113, 136, 158, 0.92f);
    private static readonly Color StageCurrentGemColor = Rgb(156, 200, 255);
    private static readonly Color StageTextColor = Rgb(167, 181, 193);
    private static readonly Color StageCurrentTextColor = Rgb(238, 246, 255);
    private static readonly Color SealBlockFill = Rgb(16, 24, 33, 0.50f);
    private static readonly Color SealBlockStroke = Rgb(83, 103, 122, 0.84f);
    private static readonly Color SealTrackFill = Rgb(10, 15, 20);
    private static readonly Color SealTrackStroke = Rgb(54, 67, 77);
    private static readonly Color GeneralFillColor = Rgb(114, 205, 168, 0.96f);
    private static readonly Color DemonFillColor = Rgb(228, 141, 104, 0.96f);
    private static readonly Color CardFill = Rgb(24, 34, 44, 0.46f);
    private static readonly Color CardStroke = Rgb(92, 111, 129, 0.86f);
    private static readonly Color CardLabelColor = Rgb(169, 183, 195);
    private static readonly Color CardValueColor = Rgb(238, 243, 248);
    private static readonly Color[] CardAccentColors =
    {
        Rgb(228, 141, 104),
        Rgb(240, 191, 103),
        Rgb(126, 175, 255),
        Rgb(151, 214, 122),
    };

    private static bool _initialized;
    private static bool _visible = true;
    private static bool _dragging;
    private static GameObject? _root;
    private static RectTransform? _rect;
    private static Canvas? _parentCanvas;
    private static Font? _font;
    private static Sprite? _flatSprite;
    private static readonly Dictionary<string, Sprite> GeneratedSprites = new(StringComparer.Ordinal);
    private static Vector2 _cachedPosition = DefaultPosition;
    private static Vector2 _dragStartPointer;
    private static Vector2 _dragStartAnchor;
    private static float _nextRefreshTime;
    private static float _nextInitializeAttemptTime;

    private static Image? _crestImage;
    private static Text? _titleText;
    private static Text? _subtitleText;
    private static Text? _worldTierText;
    private static readonly Image[] StageLinks = new Image[4];
    private static readonly StageNodeView[] StageNodes = new StageNodeView[5];
    private static readonly SealRowView[] SealRows = new SealRowView[2];
    private static readonly HudCardView[] Cards = new HudCardView[4];

    public static bool IsVisible => _visible;
    public static Vector2 CachedPosition => _cachedPosition;

    public static void Initialize()
    {
        if (_initialized)
        {
            Refresh();
            ApplyVisibility();
            return;
        }

        CanvasMain canvasMain = CanvasMain.instance;
        if (canvasMain == null)
        {
            return;
        }

        _parentCanvas = canvasMain.canvas_ui;
        if (_parentCanvas == null)
        {
            return;
        }

        EnsureSharedResources();
        BuildHud();
        ApplyHudScale();
        _initialized = true;
        _nextRefreshTime = Time.realtimeSinceStartup;
        Refresh();
        ApplyVisibility();
    }

    public static void Update()
    {
        if (!_initialized)
        {
            float retryNow = Time.realtimeSinceStartup;
            if (retryNow >= _nextInitializeAttemptTime)
            {
                _nextInitializeAttemptTime = retryNow + 1f;
                Initialize();
            }

            return;
        }

        float now = Time.realtimeSinceStartup;
        if (now >= _nextRefreshTime)
        {
            ApplyHudScale();
            Refresh();
        }
    }

    public static void Refresh()
    {
        if (!_initialized)
        {
            return;
        }

        EraWorldRuntimeState? state = EraRuntimeBootstrap.RuntimeSave?.CurrentState;
        if (state == null)
        {
            ApplyUnavailableState();
        }
        else
        {
            ApplyState(state);
        }

        ApplyCrestSprite();
        _nextRefreshTime = Time.realtimeSinceStartup + RefreshInterval;
    }

    public static void SetVisible(bool visible)
    {
        _visible = visible;
        ApplyVisibility();
    }

    public static void ToggleVisibility()
    {
        SetVisible(!_visible);
    }

    private static void EnsureSharedResources()
    {
        _font ??= Resources.GetBuiltinResource<Font>("Arial.ttf");
        if (_font == null)
        {
            _font = Font.CreateDynamicFontFromOSFont("Arial", 14);
        }

        if (_flatSprite == null)
        {
            _flatSprite = Sprite.Create(
                Texture2D.whiteTexture,
                new Rect(0f, 0f, 1f, 1f),
                new Vector2(0.5f, 0.5f),
                1f
            );
            _flatSprite.name = "ew_hud_flat_sprite";
        }
    }

    private static void BuildHud()
    {
        if (_parentCanvas == null)
        {
            throw new InvalidOperationException("HUD 初始化失败：父级 Canvas 缺失。");
        }

        _root = new GameObject("ew_hud_overlay", typeof(RectTransform));
        _root.transform.SetParent(_parentCanvas.transform, false);
        _rect = _root.GetComponent<RectTransform>();
        _rect.anchorMin = new Vector2(0f, 1f);
        _rect.anchorMax = new Vector2(0f, 1f);
        _rect.pivot = new Vector2(0f, 1f);
        _rect.anchoredPosition = _cachedPosition;
        _rect.sizeDelta = BoardSize;

        Image outerEdge = CreateRoundedPanel(
            "OuterEdgeGlow",
            _root.transform,
            new Vector2(18f, -20f),
            new Vector2(604f, 327f),
            22f,
            OuterEdgeFill,
            OuterEdgeStroke,
            true
        );
        RegisterDragEvents(outerEdge.gameObject);

        CreateRoundedPanel(
            "InnerSlab",
            _root.transform,
            new Vector2(32f, -34f),
            new Vector2(576f, 302f),
            18f,
            InnerSlabFill,
            InnerSlabStroke,
            false
        );
        CreateRoundedPanel(
            "TopSheen",
            _root.transform,
            new Vector2(32f, -34f),
            new Vector2(576f, 46f),
            18f,
            TopSheenColor,
            Color.clear,
            false
        );

        BuildWatermark();

        Image titleBand = CreateRoundedPanel(
            "TitleBand",
            _root.transform,
            new Vector2(144f, -50f),
            new Vector2(300f, 80f),
            18f,
            TitleBandFill,
            TitleBandStroke,
            false
        );
        CreateCenterDiamond("TitleNotchLeft", _root.transform, new Vector2(138f, 86f), 14f, TitleNotchColor);
        CreateCenterDiamond("TitleNotchRight", _root.transform, new Vector2(444f, 86f), 14f, TitleNotchColor);

        _crestImage = CreateImage(
            "CrestLocalArtwork",
            _root.transform,
            new Vector2(58f, -58f),
            new Vector2(64f, 64f),
            _flatSprite!,
            Color.white,
            false
        );
        _crestImage.preserveAspect = true;

        _titleText = CreateText(
            "TitleMain",
            titleBand.rectTransform,
            new Vector2(0f, -14f),
            new Vector2(300f, 34f),
            28,
            FontStyle.Bold,
            TextPrimary,
            TextAnchor.MiddleCenter,
            false
        );
        _subtitleText = CreateText(
            "TitleSub",
            titleBand.rectTransform,
            new Vector2(0f, -49f),
            new Vector2(300f, 16f),
            13,
            FontStyle.Normal,
            TextSecondary,
            TextAnchor.MiddleCenter,
            false
        );

        Image tierPill = CreateRoundedPanel(
            "WorldTierPill",
            _root.transform,
            new Vector2(462f, -68f),
            new Vector2(124f, 47f),
            22f,
            TierPillFill,
            TierPillStroke,
            false
        );
        _worldTierText = CreateText(
            "WorldTierText",
            tierPill.rectTransform,
            new Vector2(0f, -13f),
            new Vector2(124f, 17f),
            14,
            FontStyle.Bold,
            TierTextColor,
            TextAnchor.MiddleCenter,
            false
        );

        BuildStageChain();

        Image sealBlock = CreateRoundedPanel(
            "SealBlock",
            _root.transform,
            new Vector2(54f, -193f),
            new Vector2(532f, 72f),
            16f,
            SealBlockFill,
            SealBlockStroke,
            false
        );
        BuildSealBlock(sealBlock.rectTransform);
        BuildCards();
    }

    private static void BuildWatermark()
    {
        CreateCenterImage(
            "WatermarkOuter",
            _root!.transform,
            new Vector2(319f, 173f),
            new Vector2(210f, 210f),
            GetRingSprite(210, 2f),
            WatermarkColor,
            false
        );
        CreateCenterImage(
            "WatermarkInner",
            _root.transform,
            new Vector2(319f, 173f),
            new Vector2(150f, 150f),
            GetRingSprite(150, 2f),
            WatermarkColor,
            false
        );
        CreateImage(
            "WatermarkVertical",
            _root.transform,
            new Vector2(318f, -88f),
            new Vector2(2f, 170f),
            _flatSprite!,
            WatermarkColor,
            false
        );
        CreateImage(
            "WatermarkHorizontal",
            _root.transform,
            new Vector2(234f, -172f),
            new Vector2(170f, 2f),
            _flatSprite!,
            WatermarkColor,
            false
        );
        CreateCenterImage(
            "WatermarkDiagA",
            _root.transform,
            new Vector2(337f, 67f),
            new Vector2(126f, 2f),
            _flatSprite!,
            WatermarkColor,
            false,
            45f
        );
        CreateCenterImage(
            "WatermarkDiagB",
            _root.transform,
            new Vector2(337f, 193f),
            new Vector2(126f, 2f),
            _flatSprite!,
            WatermarkColor,
            false,
            315f
        );
    }

    private static void BuildStageChain()
    {
        CreateImage(
            "StageBaseLine",
            _root!.transform,
            new Vector2(68f, -152f),
            new Vector2(504f, 2f),
            _flatSprite!,
            StageBaseLineColor,
            false
        );

        for (int index = 0; index < StageLinks.Length; index++)
        {
            StageLinks[index] = CreateImage(
                $"StageLink{index}",
                _root.transform,
                new Vector2(104f + (108f * index), -152f),
                new Vector2(108f, 2f),
                _flatSprite!,
                StageLinkDimColor,
                false
            );
        }

        for (int index = 0; index < StageNodes.Length; index++)
        {
            Image ring = CreateCenterImage(
                $"StageRing{index}",
                _root.transform,
                new Vector2(StageCenterXs[index], 153f),
                new Vector2(18f, 18f),
                GetRingSprite(18, 1f),
                StageRingColor,
                false
            );
            Image gem = CreateCenterImage(
                $"StageGem{index}",
                _root.transform,
                new Vector2(StageCenterXs[index], 153f),
                new Vector2(8f, 8f),
                _flatSprite!,
                StageGemColor,
                false,
                45f
            );
            Text label = CreateText(
                $"StageText{index}",
                _root.transform,
                new Vector2(StageCenterXs[index] - 26f, -166f),
                new Vector2(52f, 14f),
                11,
                FontStyle.Normal,
                StageTextColor,
                TextAnchor.MiddleCenter,
                false
            );
            label.text = StageShortLabels[index];
            StageNodes[index] = new StageNodeView(StageCenterXs[index], 153f, ring, gem, label);
        }
    }

    private static void BuildSealBlock(RectTransform parent)
    {
        SealRows[0] = CreateSealRow(parent, "将领封印", 11f, "GeneralSeal", GeneralFillColor);
        SealRows[1] = CreateSealRow(parent, "魔王封印", 48f, "DemonSeal", DemonFillColor);
    }

    private static SealRowView CreateSealRow(
        RectTransform parent,
        string labelText,
        float top,
        string namePrefix,
        Color fillColor)
    {
        Text label = CreateText(
            $"{namePrefix}Label",
            parent,
            new Vector2(21f, -top),
            new Vector2(48f, 18f),
            11,
            FontStyle.Normal,
            TextSecondary,
            TextAnchor.MiddleLeft,
            false
        );
        label.text = labelText;

        Image track = CreateRoundedPanel(
            $"{namePrefix}Track",
            parent,
            new Vector2(85f, -(top + 2f)),
            new Vector2(338f, 14f),
            7f,
            SealTrackFill,
            SealTrackStroke,
            false
        );
        Image fill = CreateImage(
            $"{namePrefix}Fill",
            track.rectTransform,
            Vector2.zero,
            new Vector2(338f, 14f),
            GetRoundedRectSprite(338, 14, 7f),
            fillColor,
            false
        );
        fill.rectTransform.anchorMin = new Vector2(0f, 1f);
        fill.rectTransform.anchorMax = new Vector2(0f, 1f);
        fill.rectTransform.pivot = new Vector2(0f, 1f);
        fill.rectTransform.anchoredPosition = Vector2.zero;

        Text status = CreateText(
            $"{namePrefix}Status",
            parent,
            new Vector2(439f, -top),
            new Vector2(72f, 18f),
            11,
            FontStyle.Normal,
            TextSecondary,
            TextAnchor.MiddleLeft,
            false
        );

        return new SealRowView(label, track, fill, status, fillColor);
    }

    private static void BuildCards()
    {
        string[] labels = { "魔王态势", "将领态势", "军团态势", "王国英雄" };
        float[] cardXs = { 54f, 190f, 326f, 462f };

        for (int index = 0; index < labels.Length; index++)
        {
            Image card = CreateRoundedPanel(
                $"HudCard{index}",
                _root!.transform,
                new Vector2(cardXs[index], -278f),
                new Vector2(124f, 58f),
                14f,
                CardFill,
                CardStroke,
                false
            );

            CreateImage(
                $"HudCardAccent{index}",
                card.rectTransform,
                new Vector2(10f, -9f),
                new Vector2(5f, 40f),
                _flatSprite!,
                CardAccentColors[index],
                false
            );

            Text label = CreateText(
                $"HudCardLabel{index}",
                card.rectTransform,
                new Vector2(20f, -10f),
                new Vector2(94f, 12f),
                10,
                FontStyle.Bold,
                CardLabelColor,
                TextAnchor.MiddleLeft,
                false
            );
            label.text = labels[index];

            Text value = CreateText(
                $"HudCardValue{index}",
                card.rectTransform,
                new Vector2(20f, -28f),
                new Vector2(94f, 20f),
                18,
                FontStyle.Bold,
                CardValueColor,
                TextAnchor.MiddleLeft,
                false
            );

            Cards[index] = new HudCardView(label, value);
        }
    }

    private static void ApplyUnavailableState()
    {
        if (_titleText != null)
        {
            _titleText.text = "第 -- 轮 • 运行态未就绪";
        }

        if (_subtitleText != null)
        {
            _subtitleText.text = "名单未锁定 / 等待世界绑定";
        }

        if (_worldTierText != null)
        {
            _worldTierText.text = "世界档位 --";
        }

        UpdateStageChain(EraStage.PreDevelopment);
        UpdateSealRow(SealRows[0], 0f, "等待数据", false);
        UpdateSealRow(SealRows[1], 0f, "等待数据", false);
        UpdateCard(Cards[0], "--");
        UpdateCard(Cards[1], "--");
        UpdateCard(Cards[2], "--");
        UpdateCard(Cards[3], "--");
    }

    private static void ApplyState(EraWorldRuntimeState state)
    {
        if (_titleText != null)
        {
            _titleText.text = $"第 {state.CompletedCycles + 1:00} 轮 • {GetStageLabel(state.Stage)}";
        }

        if (_subtitleText != null)
        {
            _subtitleText.text = $"{BuildRelationshipSummary(state)} / {BuildStageSummary(state.Stage)}";
        }

        if (_worldTierText != null)
        {
            _worldTierText.text = $"世界档位 T{state.WorldTier}";
        }

        UpdateStageChain(state.Stage);

        SealDisplayState generalSeal = GetGeneralSealDisplay(state);
        UpdateSealRow(SealRows[0], generalSeal.Progress, generalSeal.StatusText, generalSeal.IsUnlocked);

        SealDisplayState demonSeal = GetDemonSealDisplay(state);
        UpdateSealRow(SealRows[1], demonSeal.Progress, demonSeal.StatusText, demonSeal.IsUnlocked);

        UpdateCard(Cards[0], $"{state.CurrentDemonIds.Count} {GetDemonRelationShortLabel(state)}");
        UpdateCard(Cards[1], $"{state.SpawnedGenerals.Count} / {Math.Max(0, state.CurrentDemonIds.Count * 5)}");
        UpdateCard(Cards[2], $"{state.SpawnedLegions.Count} / {EraConfig.Parameters.Legions.ConcurrentLimit}");
        UpdateCard(Cards[3], $"{state.HeroArchives.Count} / {EraConfig.Parameters.Heroes.HeroesWorldLimit}");
    }

    private static void ApplyCrestSprite()
    {
        if (_crestImage == null)
        {
            return;
        }

        Sprite? sprite = EraRuntimeBootstrap.SpriteCatalog.HudBranch9Crest?.Sprite;
        _crestImage.sprite = sprite ?? _flatSprite;
        _crestImage.color = sprite == null ? new Color(1f, 1f, 1f, 0f) : Color.white;
    }

    private static void UpdateStageChain(EraStage currentStage)
    {
        int currentIndex = Mathf.Clamp((int)currentStage, 0, StageNodes.Length - 1);

        for (int index = 0; index < StageLinks.Length; index++)
        {
            bool isAdjacent = index == currentIndex || index == currentIndex - 1;
            StageLinks[index].color = isAdjacent ? StageLinkBrightColor : StageLinkDimColor;
        }

        for (int index = 0; index < StageNodes.Length; index++)
        {
            StageNodeView? node = StageNodes[index];
            if (node == null)
            {
                continue;
            }

            bool isCurrent = index == currentIndex;
            float ringSize = isCurrent ? 22f : 18f;
            float ringThickness = isCurrent ? 1.5f : 1f;
            float gemSize = isCurrent ? 10f : 8f;

            SetCenteredRect(node.Ring.rectTransform, node.Center, new Vector2(ringSize, ringSize), 0f);
            node.Ring.sprite = GetRingSprite(Mathf.RoundToInt(ringSize), ringThickness);
            node.Ring.color = isCurrent ? StageLinkBrightColor : StageRingColor;

            SetCenteredRect(node.Gem.rectTransform, node.Center, new Vector2(gemSize, gemSize), 45f);
            node.Gem.color = isCurrent ? StageCurrentGemColor : StageGemColor;

            node.Label.color = isCurrent ? StageCurrentTextColor : StageTextColor;
            node.Label.fontStyle = isCurrent ? FontStyle.Bold : FontStyle.Normal;
        }
    }

    private static SealDisplayState GetGeneralSealDisplay(EraWorldRuntimeState state)
    {
        if (state.Stage == EraStage.PreDevelopment)
        {
            return new SealDisplayState(0f, "未开始", false);
        }

        if (state.Stage >= EraStage.Awakening || state.GeneralSealPercent <= 0f)
        {
            return new SealDisplayState(1f, "已解封", true);
        }

        float unlockProgress = GetUnlockProgress(state.GeneralSealPercent);
        return new SealDisplayState(unlockProgress, FormatPercent(unlockProgress * 100f), false);
    }

    private static SealDisplayState GetDemonSealDisplay(EraWorldRuntimeState state)
    {
        if (state.Stage < EraStage.Awakening)
        {
            return new SealDisplayState(0f, "未开始", false);
        }

        if (state.Stage >= EraStage.Advent || state.DemonSealPercent <= 0f)
        {
            return new SealDisplayState(1f, "已降临", true);
        }

        float unlockProgress = GetUnlockProgress(state.DemonSealPercent);
        return new SealDisplayState(unlockProgress, FormatPercent(unlockProgress * 100f), false);
    }

    private static float GetUnlockProgress(float remainingSealPercent)
    {
        return 1f - Mathf.Clamp01(remainingSealPercent / 100f);
    }

    private static void UpdateSealRow(
        SealRowView? row,
        float progress,
        string statusText,
        bool isUnlocked)
    {
        if (row == null)
        {
            return;
        }

        float clamped = Mathf.Clamp01(progress);
        float width = 338f * clamped;
        row.Fill.enabled = width > 0.01f;
        row.Fill.rectTransform.sizeDelta = new Vector2(width, 14f);
        row.Fill.color = isUnlocked ? row.FillColor : new Color(row.FillColor.r, row.FillColor.g, row.FillColor.b, row.FillColor.a);
        row.Status.text = statusText;
        row.Status.color = isUnlocked ? TextPrimary : TextSecondary;
    }

    private static void UpdateCard(HudCardView? card, string value)
    {
        if (card == null)
        {
            return;
        }

        card.Value.text = value;
    }

    private static void ApplyVisibility()
    {
        if (_root == null)
        {
            return;
        }

        _root.SetActive(_visible);
    }

    private static void ApplyHudScale()
    {
        if (_rect == null || _parentCanvas == null)
        {
            return;
        }

        float canvasScale = Mathf.Max(0.01f, _parentCanvas.scaleFactor);
        float targetWidth = Mathf.Min(Screen.width * MaxScreenWidthRatio, MaxHudPixelWidth);
        float targetHeight = Mathf.Min(Screen.height * MaxScreenHeightRatio, MaxHudPixelHeight);
        float widthScale = targetWidth / (BoardSize.x * canvasScale);
        float heightScale = targetHeight / (BoardSize.y * canvasScale);
        float visualScale = Mathf.Clamp(Mathf.Min(widthScale, heightScale), MinHudScale, 1f);
        _rect.localScale = new Vector3(visualScale, visualScale, 1f);
    }

    private static void RegisterDragEvents(GameObject target)
    {
        EventTrigger trigger = target.AddComponent<EventTrigger>();
        trigger.triggers ??= new List<EventTrigger.Entry>();

        AddTrigger(trigger, EventTriggerType.PointerDown, OnPointerDown);
        AddTrigger(trigger, EventTriggerType.Drag, OnDrag);
        AddTrigger(trigger, EventTriggerType.PointerUp, OnPointerUp);
        AddTrigger(trigger, EventTriggerType.PointerExit, OnPointerUp);
    }

    private static void AddTrigger(
        EventTrigger trigger,
        EventTriggerType type,
        UnityEngine.Events.UnityAction<BaseEventData> callback)
    {
        EventTrigger.Entry entry = new()
        {
            eventID = type,
            callback = new EventTrigger.TriggerEvent()
        };
        entry.callback.AddListener(callback);
        trigger.triggers.Add(entry);
    }

    private static void OnPointerDown(BaseEventData data)
    {
        if (_rect == null || data is not PointerEventData pointer)
        {
            return;
        }

        _dragging = true;
        _dragStartPointer = pointer.position;
        _dragStartAnchor = _rect.anchoredPosition;
    }

    private static void OnDrag(BaseEventData data)
    {
        if (!_dragging || _rect == null || _parentCanvas == null || data is not PointerEventData pointer)
        {
            return;
        }

        Vector2 delta = pointer.position - _dragStartPointer;
        float scale = Mathf.Max(0.1f, _parentCanvas.scaleFactor);
        _rect.anchoredPosition = _dragStartAnchor + delta / scale;
        CachePosition();
    }

    private static void OnPointerUp(BaseEventData data)
    {
        if (_dragging)
        {
            _dragging = false;
        }
    }

    private static void CachePosition()
    {
        if (_rect != null)
        {
            _cachedPosition = _rect.anchoredPosition;
        }
    }

    private static Image CreateRoundedPanel(
        string name,
        Transform parent,
        Vector2 anchoredPosition,
        Vector2 size,
        float radius,
        Color fillColor,
        Color strokeColor,
        bool raycastTarget)
    {
        Image image = CreateImage(
            name,
            parent,
            anchoredPosition,
            size,
            GetRoundedRectSprite(Mathf.RoundToInt(size.x), Mathf.RoundToInt(size.y), radius),
            fillColor,
            raycastTarget
        );
        if (strokeColor.a > 0.001f)
        {
            AddOutline(image.gameObject, strokeColor, new Vector2(1f, 1f));
        }

        return image;
    }

    private static void AddOutline(GameObject target, Color color, Vector2 distance)
    {
        Outline outline = target.AddComponent<Outline>();
        outline.effectColor = color;
        outline.effectDistance = distance;
        outline.useGraphicAlpha = true;
    }

    private static Image CreateImage(
        string name,
        Transform parent,
        Vector2 anchoredPosition,
        Vector2 size,
        Sprite sprite,
        Color color,
        bool raycastTarget)
    {
        GameObject go = new(name, typeof(RectTransform));
        go.transform.SetParent(parent, false);
        RectTransform rect = go.GetComponent<RectTransform>();
        rect.anchorMin = new Vector2(0f, 1f);
        rect.anchorMax = new Vector2(0f, 1f);
        rect.pivot = new Vector2(0f, 1f);
        rect.anchoredPosition = anchoredPosition;
        rect.sizeDelta = size;

        Image image = go.AddComponent<Image>();
        image.sprite = sprite;
        image.color = color;
        image.raycastTarget = raycastTarget;
        return image;
    }

    private static Image CreateCenterImage(
        string name,
        Transform parent,
        Vector2 center,
        Vector2 size,
        Sprite sprite,
        Color color,
        bool raycastTarget,
        float rotationZ = 0f)
    {
        GameObject go = new(name, typeof(RectTransform));
        go.transform.SetParent(parent, false);
        RectTransform rect = go.GetComponent<RectTransform>();
        rect.anchorMin = new Vector2(0f, 1f);
        rect.anchorMax = new Vector2(0f, 1f);
        rect.pivot = new Vector2(0.5f, 0.5f);
        rect.anchoredPosition = new Vector2(center.x, -center.y);
        rect.sizeDelta = size;
        rect.localRotation = Quaternion.Euler(0f, 0f, rotationZ);

        Image image = go.AddComponent<Image>();
        image.sprite = sprite;
        image.color = color;
        image.raycastTarget = raycastTarget;
        return image;
    }

    private static void SetCenteredRect(RectTransform rect, Vector2 center, Vector2 size, float rotationZ)
    {
        rect.anchorMin = new Vector2(0f, 1f);
        rect.anchorMax = new Vector2(0f, 1f);
        rect.pivot = new Vector2(0.5f, 0.5f);
        rect.anchoredPosition = new Vector2(center.x, -center.y);
        rect.sizeDelta = size;
        rect.localRotation = Quaternion.Euler(0f, 0f, rotationZ);
    }

    private static void CreateCenterDiamond(
        string name,
        Transform parent,
        Vector2 center,
        float size,
        Color color)
    {
        CreateCenterImage(name, parent, center, new Vector2(size, size), _flatSprite!, color, false, 45f);
    }

    private static Text CreateText(
        string name,
        Transform parent,
        Vector2 anchoredPosition,
        Vector2 size,
        int fontSize,
        FontStyle style,
        Color color,
        TextAnchor alignment,
        bool raycastTarget)
    {
        if (_font == null)
        {
            throw new InvalidOperationException("HUD 字体尚未初始化。");
        }

        GameObject go = new(name, typeof(RectTransform));
        go.transform.SetParent(parent, false);
        RectTransform rect = go.GetComponent<RectTransform>();
        rect.anchorMin = new Vector2(0f, 1f);
        rect.anchorMax = new Vector2(0f, 1f);
        rect.pivot = new Vector2(0f, 1f);
        rect.anchoredPosition = anchoredPosition;
        rect.sizeDelta = size;

        Text text = go.AddComponent<Text>();
        text.font = _font;
        text.fontSize = fontSize;
        text.fontStyle = style;
        text.color = color;
        text.alignment = alignment;
        text.raycastTarget = raycastTarget;
        text.supportRichText = false;
        text.horizontalOverflow = HorizontalWrapMode.Overflow;
        text.verticalOverflow = VerticalWrapMode.Overflow;
        return text;
    }

    private static Sprite GetRoundedRectSprite(int width, int height, float radius)
    {
        string key = $"rounded_{width}x{height}_r{radius:0.##}";
        if (GeneratedSprites.TryGetValue(key, out Sprite? cached))
        {
            return cached;
        }

        int textureWidth = Math.Max(2, width);
        int textureHeight = Math.Max(2, height);
        float clampedRadius = Mathf.Min(radius, Mathf.Min(textureWidth, textureHeight) * 0.5f);
        Texture2D texture = new(textureWidth, textureHeight, TextureFormat.ARGB32, false)
        {
            name = key,
            wrapMode = TextureWrapMode.Clamp,
            filterMode = FilterMode.Bilinear
        };

        Color32[] pixels = new Color32[textureWidth * textureHeight];
        Vector2 halfSize = new(textureWidth * 0.5f, textureHeight * 0.5f);
        Vector2 corner = halfSize - new Vector2(clampedRadius, clampedRadius);

        for (int y = 0; y < textureHeight; y++)
        {
            for (int x = 0; x < textureWidth; x++)
            {
                Vector2 point = new(x + 0.5f - halfSize.x, y + 0.5f - halfSize.y);
                Vector2 q = new Vector2(Mathf.Abs(point.x), Mathf.Abs(point.y)) - corner;
                float outside = new Vector2(Mathf.Max(q.x, 0f), Mathf.Max(q.y, 0f)).magnitude;
                float inside = Mathf.Min(Mathf.Max(q.x, q.y), 0f);
                float distance = outside + inside - clampedRadius;
                float alpha = Mathf.Clamp01(0.5f - distance);
                byte alphaByte = (byte)Mathf.RoundToInt(alpha * 255f);
                pixels[(y * textureWidth) + x] = new Color32(255, 255, 255, alphaByte);
            }
        }

        texture.SetPixels32(pixels);
        texture.Apply(false, false);

        Sprite sprite = Sprite.Create(
            texture,
            new Rect(0f, 0f, textureWidth, textureHeight),
            new Vector2(0.5f, 0.5f),
            1f
        );
        sprite.name = key;
        GeneratedSprites[key] = sprite;
        return sprite;
    }

    private static Sprite GetRingSprite(int size, float thickness)
    {
        string key = $"ring_{size}_t{thickness:0.##}";
        if (GeneratedSprites.TryGetValue(key, out Sprite? cached))
        {
            return cached;
        }

        int textureSize = Math.Max(2, size);
        float outerRadius = (textureSize * 0.5f) - 1f;
        float innerRadius = Mathf.Max(0f, outerRadius - thickness);
        Texture2D texture = new(textureSize, textureSize, TextureFormat.ARGB32, false)
        {
            name = key,
            wrapMode = TextureWrapMode.Clamp,
            filterMode = FilterMode.Bilinear
        };

        Color32[] pixels = new Color32[textureSize * textureSize];
        Vector2 center = new((textureSize - 1) * 0.5f, (textureSize - 1) * 0.5f);
        for (int y = 0; y < textureSize; y++)
        {
            for (int x = 0; x < textureSize; x++)
            {
                float distance = Vector2.Distance(new Vector2(x, y), center);
                float outerAlpha = Mathf.Clamp01((outerRadius + 0.5f) - distance);
                float innerAlpha = Mathf.Clamp01(distance - (innerRadius - 0.5f));
                float alpha = outerAlpha * innerAlpha;
                byte alphaByte = (byte)Mathf.RoundToInt(alpha * 255f);
                pixels[(y * textureSize) + x] = new Color32(255, 255, 255, alphaByte);
            }
        }

        texture.SetPixels32(pixels);
        texture.Apply(false, false);

        Sprite sprite = Sprite.Create(
            texture,
            new Rect(0f, 0f, textureSize, textureSize),
            new Vector2(0.5f, 0.5f),
            1f
        );
        sprite.name = key;
        GeneratedSprites[key] = sprite;
        return sprite;
    }

    private static Color Rgb(byte r, byte g, byte b, float alpha = 1f)
    {
        return new Color(r / 255f, g / 255f, b / 255f, alpha);
    }

    private static string GetStageLabel(EraStage stage)
    {
        return stage switch
        {
            EraStage.PreDevelopment => "预发展",
            EraStage.Omen => "预兆",
            EraStage.Awakening => "苏醒",
            EraStage.Advent => "降临",
            EraStage.Reconstruction => "战后重建",
            _ => stage.ToString()
        };
    }

    private static string BuildStageSummary(EraStage stage)
    {
        return stage switch
        {
            EraStage.PreDevelopment => "世界仍在积蓄",
            EraStage.Omen => "阴影已近前线",
            EraStage.Awakening => "战线已点燃",
            EraStage.Advent => "决战已经降临",
            EraStage.Reconstruction => "世界正在重建",
            _ => "世界状态更新中",
        };
    }

    private static string BuildRelationshipSummary(EraWorldRuntimeState state)
    {
        int plannedDemons = state.CurrentDemonIds.Count;
        if (plannedDemons == 0)
        {
            return "名单未锁定";
        }

        if (plannedDemons == 1)
        {
            return "单魔王轮回";
        }

        if (!state.DemonInteraction.Active)
        {
            return $"{plannedDemons}魔王待定";
        }

        if (state.DemonInteraction.UsesRandomRoll || state.DemonInteraction.Mode == EraDemonInteractionMode.Random)
        {
            return $"{plannedDemons}魔王随机关系";
        }

        return state.DemonInteraction.Mode switch
        {
            EraDemonInteractionMode.Alliance => $"{plannedDemons}魔王联盟",
            EraDemonInteractionMode.CivilWar => $"{plannedDemons}魔王内战",
            _ => $"{plannedDemons}魔王待定",
        };
    }

    private static string GetDemonRelationShortLabel(EraWorldRuntimeState state)
    {
        int plannedDemons = state.CurrentDemonIds.Count;
        if (plannedDemons == 0)
        {
            return "未定";
        }

        if (plannedDemons == 1)
        {
            return "单体";
        }

        if (!state.DemonInteraction.Active)
        {
            return "未定";
        }

        if (state.DemonInteraction.UsesRandomRoll || state.DemonInteraction.Mode == EraDemonInteractionMode.Random)
        {
            return "随机";
        }

        return state.DemonInteraction.Mode switch
        {
            EraDemonInteractionMode.Alliance => "联盟",
            EraDemonInteractionMode.CivilWar => "内战",
            _ => "未定",
        };
    }

    private static string FormatPercent(float percent)
    {
        float rounded = Mathf.Round(percent);
        if (Mathf.Abs(percent - rounded) < 0.05f)
        {
            return $"{rounded:0}%";
        }

        return $"{percent:0.#}%";
    }

    private sealed class StageNodeView
    {
        public Vector2 Center { get; }
        public Image Ring { get; }
        public Image Gem { get; }
        public Text Label { get; }

        public StageNodeView(float centerX, float centerY, Image ring, Image gem, Text label)
        {
            Center = new Vector2(centerX, centerY);
            Ring = ring;
            Gem = gem;
            Label = label;
        }
    }

    private sealed class SealRowView
    {
        public Text Label { get; }
        public Image Track { get; }
        public Image Fill { get; }
        public Text Status { get; }
        public Color FillColor { get; }

        public SealRowView(Text label, Image track, Image fill, Text status, Color fillColor)
        {
            Label = label;
            Track = track;
            Fill = fill;
            Status = status;
            FillColor = fillColor;
        }
    }

    private sealed class HudCardView
    {
        public Text Label { get; }
        public Text Value { get; }

        public HudCardView(Text label, Text value)
        {
            Label = label;
            Value = value;
        }
    }

    private readonly struct SealDisplayState
    {
        public float Progress { get; }
        public string StatusText { get; }
        public bool IsUnlocked { get; }

        public SealDisplayState(float progress, string statusText, bool isUnlocked)
        {
            Progress = progress;
            StatusText = statusText;
            IsUnlocked = isUnlocked;
        }
    }
}
