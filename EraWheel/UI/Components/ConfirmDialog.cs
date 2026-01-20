using System;
using EraWheel.Core;

namespace EraWheel.UI.Components
{
    public class ConfirmDialog
    {
        private static ConfirmDialog _instance;
        public static ConfirmDialog Instance => _instance ?? (_instance = new ConfirmDialog());

        private bool _isOpen;
        private string _title;
        private string _message;
        private Action _onConfirm;
        private Action _onCancel;

        public bool IsOpen => _isOpen;

        public void Show(string title, string message, Action onConfirm, Action onCancel = null)
        {
            _isOpen = true;
            _title = title ?? "确认";
            _message = message ?? "";
            _onConfirm = onConfirm;
            _onCancel = onCancel;
        }

        public void Close()
        {
            _isOpen = false;
            _onConfirm = null;
            _onCancel = null;
        }

        public void OnGUI()
        {
            if (!_isOpen) return;

            DrawOverlay();
            DrawDialog();
        }

        private void DrawOverlay()
        {
            var screenWidth = UnityCompat.GetScreenWidth();
            var screenHeight = UnityCompat.GetScreenHeight();

            var overlayColor = new UnityEngine.Color(0, 0, 0, 0.5f);
            var origColor = UnityEngine.GUI.color;
            UnityEngine.GUI.color = overlayColor;
            UnityEngine.GUI.DrawTexture(new UnityEngine.Rect(0, 0, screenWidth, screenHeight), UnityEngine.Texture2D.whiteTexture);
            UnityEngine.GUI.color = origColor;
        }

        private void DrawDialog()
        {
            var dialogWidth = 300f;
            var dialogHeight = 150f;
            var screenWidth = UnityCompat.GetScreenWidth();
            var screenHeight = UnityCompat.GetScreenHeight();

            var x = (screenWidth - dialogWidth) / 2f;
            var y = (screenHeight - dialogHeight) / 2f;

            var dialogRect = new UnityEngine.Rect(x, y, dialogWidth, dialogHeight);

            UnityEngine.GUI.Box(dialogRect, "");

            UnityEngine.GUILayout.BeginArea(dialogRect);
            UnityEngine.GUILayout.BeginVertical();

            UnityEngine.GUILayout.Space(10);
            UnityEngine.GUILayout.Label(_title, UnityEngine.GUI.skin.label);
            UnityEngine.GUILayout.Space(10);

            UnityEngine.GUILayout.Label(_message);

            UnityEngine.GUILayout.FlexibleSpace();

            UnityEngine.GUILayout.BeginHorizontal();

            if (UnityEngine.GUILayout.Button("确认", UnityEngine.GUILayout.Width(100)))
            {
                try
                {
                    _onConfirm?.Invoke();
                }
                catch (Exception ex)
                {
                    Core.Log.Error("[EraWheel] ConfirmDialog onConfirm error: " + ex.Message);
                }
                Close();
            }

            UnityEngine.GUILayout.FlexibleSpace();

            if (UnityEngine.GUILayout.Button("取消", UnityEngine.GUILayout.Width(100)))
            {
                try
                {
                    _onCancel?.Invoke();
                }
                catch { }
                Close();
            }

            UnityEngine.GUILayout.EndHorizontal();

            UnityEngine.GUILayout.Space(10);
            UnityEngine.GUILayout.EndVertical();
            UnityEngine.GUILayout.EndArea();
        }
    }
}
