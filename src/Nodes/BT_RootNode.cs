﻿namespace Common.BehaviourTrees
{
    /// <summary>
    /// <see cref="BT_ANode"/> serving as a root of the tree
    /// </summary>
    public sealed class BT_RootNode : BT_ANode
    {
        public BT_RootNode() :
            this("Root")
        {
        }

        public BT_RootNode(string name) :
            base(name)
        {
        }

        protected override BT_EStatus OnUpdate()
        {
            return Current.Update();
        }
    }
}
