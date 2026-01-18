using System;
using System.Collections.Generic;

namespace EraOfWheel.DemonLords.General.AI
{
    public enum NodeStatus
    {
        Success,
        Failure,
        Running
    }

    public class Blackboard
    {
        private readonly Dictionary<string, object> _values = new Dictionary<string, object>();

        public void Set<T>(string key, T value)
        {
            if (string.IsNullOrEmpty(key)) return;
            _values[key] = value;
        }

        public bool TryGet<T>(string key, out T value)
        {
            value = default(T);
            if (string.IsNullOrEmpty(key)) return false;

            if (!_values.TryGetValue(key, out var obj) || obj == null) return false;
            if (obj is T v)
            {
                value = v;
                return true;
            }

            return false;
        }
    }

    public interface IBehaviorNode
    {
        NodeStatus Tick(Blackboard bb);
    }

    public class SelectorNode : IBehaviorNode
    {
        private readonly List<IBehaviorNode> _children;

        public SelectorNode(List<IBehaviorNode> children)
        {
            _children = children ?? new List<IBehaviorNode>();
        }

        public NodeStatus Tick(Blackboard bb)
        {
            for (int i = 0; i < _children.Count; i++)
            {
                var c = _children[i];
                if (c == null) continue;

                var r = c.Tick(bb);
                if (r == NodeStatus.Success) return NodeStatus.Success;
                if (r == NodeStatus.Running) return NodeStatus.Running;
            }

            return NodeStatus.Failure;
        }
    }

    public class SequenceNode : IBehaviorNode
    {
        private readonly List<IBehaviorNode> _children;

        public SequenceNode(List<IBehaviorNode> children)
        {
            _children = children ?? new List<IBehaviorNode>();
        }

        public NodeStatus Tick(Blackboard bb)
        {
            for (int i = 0; i < _children.Count; i++)
            {
                var c = _children[i];
                if (c == null) continue;

                var r = c.Tick(bb);
                if (r == NodeStatus.Failure) return NodeStatus.Failure;
                if (r == NodeStatus.Running) return NodeStatus.Running;
            }

            return NodeStatus.Success;
        }
    }

    public class ConditionNode : IBehaviorNode
    {
        private readonly Func<Blackboard, bool> _condition;

        public ConditionNode(Func<Blackboard, bool> condition)
        {
            _condition = condition;
        }

        public NodeStatus Tick(Blackboard bb)
        {
            if (_condition == null) return NodeStatus.Failure;

            try
            {
                return _condition(bb) ? NodeStatus.Success : NodeStatus.Failure;
            }
            catch
            {
                return NodeStatus.Failure;
            }
        }
    }

    public class ActionNode : IBehaviorNode
    {
        private readonly Func<Blackboard, NodeStatus> _action;

        public ActionNode(Func<Blackboard, NodeStatus> action)
        {
            _action = action;
        }

        public NodeStatus Tick(Blackboard bb)
        {
            if (_action == null) return NodeStatus.Failure;

            try
            {
                return _action(bb);
            }
            catch
            {
                return NodeStatus.Failure;
            }
        }
    }
}
