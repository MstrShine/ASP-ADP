﻿namespace HAN.ASD.ADP.DataStructures.BinaryTree
{
    public class TreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }

        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }

        public int Height { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;

            Height = 1;
        }
    }
}
