using System;
using System.Collections.Generic;
using EraOfWheel.Core;
using UnityEngine;

namespace EraOfWheel.UI
{
    /// <summary>
    /// UI管理器 - 统一管理所有MOD UI面板
    /// </summary>
    public class UIManager : IModSystem
    {
        public static UIManager Instance { get; private set; }
        
        public string SystemName => "UIManager";
        public bool IsInitialized { get; private set; }

        private Dictionary<string, BasePanel> _panels = new Dictionary<string, BasePanel>();
        private Canvas _canvas;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            CreateCanvas();
            RegisterPanels();
            
            IsInitialized = true;
            Logger.Info(SystemName, "UI管理器初始化完成");
        }

        private void CreateCanvas()
        {
            var canvasGo = new GameObject("EraOfWheel_Canvas");
            _canvas = canvasGo.AddComponent<Canvas>();
            _canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            _canvas.sortingOrder = 100;
            
            canvasGo.AddComponent<UnityEngine.UI.CanvasScaler>();
            canvasGo.AddComponent<UnityEngine.UI.GraphicRaycaster>();
            
            UnityEngine.Object.DontDestroyOnLoad(canvasGo);
        }

        private void RegisterPanels()
        {
            // 注册各个面板
            Register("main", new MainControlPanel());
            Register("cycle", new CycleStatusPanel());
            Register("demon", new DemonLordPanel());
            Register("settings", new SettingsPanel());
        }

        public void Register(string id, BasePanel panel)
        {
            _panels[id] = panel;
            panel.Initialize(_canvas.transform);
        }

        public T GetPanel<T>(string id) where T : BasePanel
        {
            return _panels.TryGetValue(id, out var panel) ? panel as T : null;
        }

        public void ShowPanel(string id)
        {
            if (_panels.TryGetValue(id, out var panel))
            {
                panel.Show();
            }
        }

        public void HidePanel(string id)
        {
            if (_panels.TryGetValue(id, out var panel))
            {
                panel.Hide();
            }
        }

        public void TogglePanel(string id)
        {
            if (_panels.TryGetValue(id, out var panel))
            {
                if (panel.IsVisible) panel.Hide();
                else panel.Show();
            }
        }

        public void HideAll()
        {
            foreach (var panel in _panels.Values)
            {
                panel.Hide();
            }
        }

        public void Dispose()
        {
            foreach (var panel in _panels.Values)
            {
                panel.Dispose();
            }
            _panels.Clear();
            
            if (_canvas != null)
            {
                UnityEngine.Object.Destroy(_canvas.gameObject);
            }
            
            Instance = null;
            IsInitialized = false;
        }
    }

    /// <summary>
    /// 面板基类
    /// </summary>
    public abstract class BasePanel : IDisposable
    {
        public abstract string PanelId { get; }
        public bool IsVisible { get; protected set; }
        protected GameObject Root { get; set; }
        protected Transform Parent { get; set; }

        public virtual void Initialize(Transform parent)
        {
            Parent = parent;
            CreateUI();
        }

        protected abstract void CreateUI();

        public virtual void Show()
        {
            Root?.SetActive(true);
            IsVisible = true;
        }

        public virtual void Hide()
        {
            Root?.SetActive(false);
            IsVisible = false;
        }

        public virtual void Dispose()
        {
            if (Root != null)
            {
                UnityEngine.Object.Destroy(Root);
            }
        }
    }
}
