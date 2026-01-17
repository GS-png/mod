using System;
using UnityEngine;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;

namespace EraOfWheel.UI
{
    public class UIManager : IModSystem
    {
        public static UIManager Instance { get; private set; }
        
        public string SystemName => "UIManager";
        public bool IsInitialized { get; private set; }
        
        public bool IsPanelVisible { get; private set; } = false;
        
        private UIConfig _config;
        private KeyCode _hotkey = KeyCode.F8;
        private GameObject _mainPanel;

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            _config = ConfigManager.Instance?.Config?.ui ?? new UIConfig();
            
            ParseHotkey(_config.hotkey);
            CreateUI();
            
            IsInitialized = true;
            Logger.Info(SystemName, $"UIManager initialized, hotkey: {_hotkey}");
        }

        private void ParseHotkey(string keyName)
        {
            if (Enum.TryParse<KeyCode>(keyName, true, out var key))
            {
                _hotkey = key;
            }
        }

        private void CreateUI()
        {
            if (!_config.enabled) return;
            
            // Note: Full implementation would create NeoModLoader UI elements
            Logger.Debug(SystemName, "UI elements created (placeholder)");
        }

        public void Update()
        {
            if (!IsInitialized || !_config.enabled) return;
            
            if (Input.GetKeyDown(_hotkey))
            {
                TogglePanel();
            }
        }

        public void TogglePanel()
        {
            IsPanelVisible = !IsPanelVisible;
            
            if (_mainPanel != null)
            {
                _mainPanel.SetActive(IsPanelVisible);
            }
            
            Logger.Debug(SystemName, $"Panel visibility: {IsPanelVisible}");
        }

        public void ShowPanel()
        {
            IsPanelVisible = true;
            if (_mainPanel != null)
            {
                _mainPanel.SetActive(true);
            }
        }

        public void HidePanel()
        {
            IsPanelVisible = false;
            if (_mainPanel != null)
            {
                _mainPanel.SetActive(false);
            }
        }

        public void Dispose()
        {
            if (_mainPanel != null)
            {
                UnityEngine.Object.Destroy(_mainPanel);
                _mainPanel = null;
            }
            
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "UIManager disposed");
        }
    }
}
