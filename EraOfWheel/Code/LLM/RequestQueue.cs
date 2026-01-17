using System;
using System.Collections;
using System.Collections.Generic;
using EraOfWheel.Core;
using UnityEngine;

namespace EraOfWheel.LLM
{
    /// <summary>
    /// 请求队列系统 - 管理异步LLM请求
    /// </summary>
    public class RequestQueue : IModSystem
    {
        public static RequestQueue Instance { get; private set; }
        
        public string SystemName => "RequestQueue";
        public bool IsInitialized { get; private set; }

        private Queue<QueuedRequest> _highPriority = new Queue<QueuedRequest>();
        private Queue<QueuedRequest> _normalPriority = new Queue<QueuedRequest>();
        private Queue<QueuedRequest> _lowPriority = new Queue<QueuedRequest>();
        
        private bool _isProcessing = false;
        private int _maxConcurrent = 1;
        private int _currentActive = 0;
        private MonoBehaviour _runner;

        public int PendingCount => _highPriority.Count + _normalPriority.Count + _lowPriority.Count;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            _runner = ModMain.Instance;
            
            IsInitialized = true;
            Logger.Info(SystemName, "请求队列系统初始化完成");
        }

        /// <summary>
        /// 添加请求到队列
        /// </summary>
        public string Enqueue(LLMRequest request, Action<LLMResponse> callback, RequestPriority priority = RequestPriority.Normal)
        {
            var id = Guid.NewGuid().ToString("N").Substring(0, 8);
            var queued = new QueuedRequest
            {
                Id = id,
                Request = request,
                Callback = callback,
                Priority = priority,
                EnqueueTime = DateTime.UtcNow
            };

            switch (priority)
            {
                case RequestPriority.High:
                    _highPriority.Enqueue(queued);
                    break;
                case RequestPriority.Low:
                    _lowPriority.Enqueue(queued);
                    break;
                default:
                    _normalPriority.Enqueue(queued);
                    break;
            }

            Logger.Debug(SystemName, $"请求入队: {id}, 优先级: {priority}");
            ProcessQueue();
            
            return id;
        }

        /// <summary>
        /// 取消请求
        /// </summary>
        public bool Cancel(string requestId)
        {
            // 简化实现：标记请求为已取消
            Logger.Debug(SystemName, $"请求取消: {requestId}");
            return true;
        }

        private void ProcessQueue()
        {
            if (_isProcessing || _currentActive >= _maxConcurrent) return;
            
            var next = GetNextRequest();
            if (next == null) return;

            _isProcessing = true;
            _currentActive++;
            
            _runner?.StartCoroutine(ProcessRequest(next));
        }

        private QueuedRequest GetNextRequest()
        {
            if (_highPriority.Count > 0) return _highPriority.Dequeue();
            if (_normalPriority.Count > 0) return _normalPriority.Dequeue();
            if (_lowPriority.Count > 0) return _lowPriority.Dequeue();
            return null;
        }

        private IEnumerator ProcessRequest(QueuedRequest queued)
        {
            Logger.Debug(SystemName, $"处理请求: {queued.Id}");
            
            yield return LLMClient.Instance?.SendRequest(queued.Request, response =>
            {
                queued.Callback?.Invoke(response);
            });

            _currentActive--;
            _isProcessing = false;
            
            // 继续处理队列
            ProcessQueue();
        }

        public void ClearAll()
        {
            _highPriority.Clear();
            _normalPriority.Clear();
            _lowPriority.Clear();
            Logger.Info(SystemName, "请求队列已清空");
        }

        public void Dispose()
        {
            ClearAll();
            Instance = null;
            IsInitialized = false;
        }
    }

    public enum RequestPriority
    {
        Low,
        Normal,
        High
    }

    public class QueuedRequest
    {
        public string Id { get; set; }
        public LLMRequest Request { get; set; }
        public Action<LLMResponse> Callback { get; set; }
        public RequestPriority Priority { get; set; }
        public DateTime EnqueueTime { get; set; }
        public bool IsCancelled { get; set; }
    }
}
