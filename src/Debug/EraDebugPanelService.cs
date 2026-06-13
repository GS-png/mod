using EraWheel.Config;
using EraWheel.Core.Logging;
using NeoModLoader.General;
using UnityEngine;

namespace EraWheel.Debug;

public static class EraDebugPanelService
{
    private const string DebugButtonId = "ew_debug_button";

    private static PowerButton? _debugButton;
    private static bool _initialized;

    public static void Initialize()
    {
        if (_initialized)
        {
            ApplyDevelopmentMode();
            return;
        }

        _initialized = true;
        EraDebugWindow.Ensure();
        ApplyDevelopmentMode();
    }

    public static void ApplyDevelopmentMode()
    {
        if (!_initialized)
        {
            return;
        }

        if (EraConfig.DevelopmentMode)
        {
            EnsureDebugButton();
        }

        if (_debugButton != null)
        {
            _debugButton.gameObject.SetActive(EraConfig.DevelopmentMode);
        }

        EraDebugWindow.Instance?.RefreshView();
    }

    private static void EnsureDebugButton()
    {
        if (_debugButton != null)
        {
            return;
        }

        PowersTab? mainTab = PowerButtonCreator.GetTab("main");
        if (mainTab == null)
        {
            EraLog.Warning(EraLogCategory.Debug, "未找到 main 页签，调试按钮暂时无法挂载。");
            return;
        }

        Sprite icon = SpriteTextureLoader.getSprite("ui/icons/iconOptions");
        _debugButton = PowerButtonCreator.CreateWindowButton(DebugButtonId, EraDebugWindow.WindowId, icon);
        PowerButtonCreator.AddButtonToTab(_debugButton, mainTab, 23);
    }
}
