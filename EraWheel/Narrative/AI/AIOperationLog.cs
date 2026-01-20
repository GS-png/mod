using System;
using System.Collections.Generic;
using EraWheel.Core;

namespace EraWheel.Narrative.AI
{
    [Serializable]
    public class AIOperation
    {
        public string Id;
        public string RequestType;
        public string Content;
        public string ErrorMessage;
        public bool Success;
        public int TokensUsed;
        public long WorldAge;
        public long Timestamp;
        public bool CanUndo;
        public string UndoData;
    }

    public class AIOperationLog
    {
        private readonly List<AIOperation> _operations = new List<AIOperation>();
        private readonly int _maxOperations = 100;

        public IReadOnlyList<AIOperation> Operations => _operations;
        public int Count => _operations.Count;

        public int TotalTokensUsed
        {
            get
            {
                var total = 0;
                foreach (var op in _operations)
                {
                    total += op.TokensUsed;
                }
                return total;
            }
        }

        public int SuccessCount
        {
            get
            {
                var count = 0;
                foreach (var op in _operations)
                {
                    if (op.Success) count++;
                }
                return count;
            }
        }

        public int FailureCount => Count - SuccessCount;

        public void LogOperation(AIOperation operation)
        {
            if (operation == null) return;

            operation.Id = Guid.NewGuid().ToString("N").Substring(0, 8);
            operation.Timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            _operations.Add(operation);

            while (_operations.Count > _maxOperations)
            {
                _operations.RemoveAt(0);
            }

            Log.Info($"[AIOperationLog] 记录操作: {operation.RequestType} - {(operation.Success ? "成功" : "失败")}");
        }

        public AIOperation GetById(string id)
        {
            if (string.IsNullOrEmpty(id)) return null;

            foreach (var op in _operations)
            {
                if (op.Id == id) return op;
            }

            return null;
        }

        public AIOperation GetLatest()
        {
            if (_operations.Count == 0) return null;
            return _operations[_operations.Count - 1];
        }

        public List<AIOperation> GetRecent(int count)
        {
            var result = new List<AIOperation>();
            var start = Math.Max(0, _operations.Count - count);

            for (var i = _operations.Count - 1; i >= start; i--)
            {
                result.Add(_operations[i]);
            }

            return result;
        }

        public bool TryUndo(string operationId)
        {
            var op = GetById(operationId);
            if (op == null || !op.CanUndo)
            {
                Log.Warning($"[AIOperationLog] 无法撤销操作: {operationId}");
                return false;
            }

            Log.Info($"[AIOperationLog] 撤销操作: {operationId}");
            return true;
        }

        public void Clear()
        {
            _operations.Clear();
            Log.Info("[AIOperationLog] 日志已清空");
        }

        public AIOperationLogSaveData GetSaveData()
        {
            return new AIOperationLogSaveData
            {
                Operations = _operations.ToArray()
            };
        }

        public void LoadSaveData(AIOperationLogSaveData data)
        {
            _operations.Clear();
            if (data?.Operations != null)
            {
                _operations.AddRange(data.Operations);
            }
        }
    }

    [Serializable]
    public class AIOperationLogSaveData
    {
        public AIOperation[] Operations;
    }
}
