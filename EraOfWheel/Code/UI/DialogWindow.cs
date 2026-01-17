using System;
using System.Collections;
using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.LLM;
using UnityEngine;
using UnityEngine.UI;

namespace EraOfWheel.UI
{
    /// <summary>
    /// 对话窗口 - 与魔王/神谕的对话界面
    /// </summary>
    public class DialogWindow : BasePanel
    {
        public override string PanelId => "dialog";

        private Text _dialogText;
        private InputField _inputField;
        private ScrollRect _scrollRect;
        private Button _sendButton;
        
        private List<string> _displayedMessages = new List<string>();
        private Coroutine _typewriterCoroutine;
        private float _typewriterSpeed = 0.03f;

        public event Action<int> OnChoiceSelected;

        protected override void CreateUI()
        {
            Root = new GameObject("DialogWindow");
            Root.transform.SetParent(Parent, false);
            
            var rect = Root.AddComponent<RectTransform>();
            rect.anchorMin = new Vector2(0.5f, 0.5f);
            rect.anchorMax = new Vector2(0.5f, 0.5f);
            rect.sizeDelta = new Vector2(600, 450);

            var bg = Root.AddComponent<Image>();
            bg.color = new Color(0.08f, 0.06f, 0.12f, 0.95f);

            CreateHeader();
            CreateDialogArea();
            CreateInputArea();
            
            Hide();
        }

        private void CreateHeader()
        {
            // 标题和关闭按钮
            var header = new GameObject("Header");
            header.transform.SetParent(Root.transform, false);
            
            var headerRect = header.AddComponent<RectTransform>();
            headerRect.anchorMin = new Vector2(0, 1);
            headerRect.anchorMax = new Vector2(1, 1);
            headerRect.pivot = new Vector2(0.5f, 1);
            headerRect.sizeDelta = new Vector2(0, 40);
        }

        private void CreateDialogArea()
        {
            // 对话内容区域
            var dialogArea = new GameObject("DialogArea");
            dialogArea.transform.SetParent(Root.transform, false);
            
            _scrollRect = dialogArea.AddComponent<ScrollRect>();
        }

        private void CreateInputArea()
        {
            // 输入区域
            var inputArea = new GameObject("InputArea");
            inputArea.transform.SetParent(Root.transform, false);
        }

        /// <summary>
        /// 显示对话
        /// </summary>
        public void ShowDialog(string speaker, string message, bool typewriter = true)
        {
            var formattedMessage = $"【{speaker}】\n{message}";
            
            if (typewriter)
            {
                StartTypewriter(formattedMessage);
            }
            else
            {
                AppendMessage(formattedMessage);
            }
        }

        /// <summary>
        /// 显示选项
        /// </summary>
        public void ShowChoices(List<string> choices)
        {
            // TODO: 创建选项按钮
            for (int i = 0; i < choices.Count; i++)
            {
                Logger.Debug("DialogWindow", $"选项{i + 1}: {choices[i]}");
            }
        }

        /// <summary>
        /// 打字机效果
        /// </summary>
        private void StartTypewriter(string message)
        {
            if (_typewriterCoroutine != null)
            {
                ModMain.Instance?.StopCoroutine(_typewriterCoroutine);
            }
            
            _typewriterCoroutine = ModMain.Instance?.StartCoroutine(TypewriterEffect(message));
        }

        private IEnumerator TypewriterEffect(string message)
        {
            var displayed = "";
            
            foreach (char c in message)
            {
                displayed += c;
                UpdateDisplayText(displayed);
                yield return new WaitForSeconds(_typewriterSpeed);
            }
            
            _displayedMessages.Add(message);
            _typewriterCoroutine = null;
        }

        private void AppendMessage(string message)
        {
            _displayedMessages.Add(message);
            UpdateDisplayText(string.Join("\n\n", _displayedMessages));
        }

        private void UpdateDisplayText(string text)
        {
            if (_dialogText != null)
            {
                _dialogText.text = text;
            }
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        public void SendMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message)) return;

            ShowDialog("你", message, false);
            
            OracleDialog.Instance?.SendMessage(message, response =>
            {
                ShowDialog("神谕", response, true);
            });
        }

        /// <summary>
        /// 清空对话
        /// </summary>
        public void ClearDialog()
        {
            _displayedMessages.Clear();
            UpdateDisplayText("");
        }

        public override void Dispose()
        {
            if (_typewriterCoroutine != null)
            {
                ModMain.Instance?.StopCoroutine(_typewriterCoroutine);
            }
            base.Dispose();
        }
    }
}
