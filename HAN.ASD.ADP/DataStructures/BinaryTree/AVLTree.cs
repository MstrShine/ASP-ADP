namespace HAN.ASD.ADP.DataStructures.BinaryTree
{
    public class AVLTree<T> : IBinaryTree<T> where T : IComparable<T>
    {
        private TreeNode<T> _root;

        public T Find(T value)
        {
            var node = FindRecursive(_root, value);
            if (node == null)
            {
                throw new InvalidOperationException("Value not found.");
            }
            return node.Value;
        }

        public void Insert(T value)
        {
            _root = InsertRecursive(_root, value);
        }

        public T Max()
        {
            if (_root == null)
            {
                throw new InvalidOperationException("Tree is empty.");
            }

            TreeNode<T> node = _root;
            while (node.Right != null)
            {
                node = node.Right;
            }

            return node.Value;
        }

        public T Min()
        {
            if (_root == null)
            {
                throw new InvalidOperationException("Tree is empty.");
            }

            TreeNode<T> node = _root;
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node.Value;
        }

        public void Remove(T value)
        {
            _root = RemoveRecursive(_root, value);
        }

        public void Print()
        {
            Print(_root, string.Empty, true);
        }

        private void Print(TreeNode<T> node, string indent, bool last)
        {
            if (node != null)
            {
                Console.WriteLine(indent + (last ? "└─" : "├─") + node.Value);
                indent += last ? "   " : "│  ";

                Print(node.Left, indent, false);
                Print(node.Right, indent, true);
            }
        }

        private TreeNode<T> InsertRecursive(TreeNode<T> node, T value)
        {
            if (node == null)
            {
                return new TreeNode<T>(value);
            }

            var comparison = value.CompareTo(node.Value);
            if (comparison < 0)
            {
                node.Left = InsertRecursive(node.Left, value);
            }
            else if (comparison > 0)
            {
                node.Right = InsertRecursive(node.Right, value);
            }
            else
            {
                throw new InvalidOperationException("Duplicate values are not allowed.");
            }

            UpdateHeight(node);

            return Balance(node);
        }

        private TreeNode<T> RemoveRecursive(TreeNode<T> node, T value)
        {
            if (node == null)
            {
                throw new InvalidOperationException("Value not found.");
            }

            var comparison = value.CompareTo(node.Value);
            if (comparison < 0)
            {
                node.Left = RemoveRecursive(node.Left, value);
            }
            else if (comparison > 0)
            {
                node.Right = RemoveRecursive(node.Right, value);
            }
            else
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                if (node.Right == null)
                {
                    return node.Left;
                }

                node.Value = MinBelowNode(node.Right);
                node.Right = RemoveRecursive(node.Right, node.Value);
            }

            UpdateHeight(node);

            return Balance(node);
        }

        private TreeNode<T> FindRecursive(TreeNode<T> node, T value)
        {
            if (node == null)
            {
                return null;
            }

            var comparison = value.CompareTo(node.Value);

            if (comparison == 0)
            {
                return node;
            }
            else if (comparison < 0)
            {
                return FindRecursive(node.Left, value);
            }
            else
            {
                return FindRecursive(node.Right, value);
            }
        }

        private T MinBelowNode(TreeNode<T> node)
        {
            var current = node;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current.Value;
        }

        private TreeNode<T> Balance(TreeNode<T> node)
        {
            var balanceFactor = GetBalanceFactor(node);

            if (balanceFactor > 1)
            {
                if (GetBalanceFactor(node.Left) < 0)
                {
                    node.Left = RotateLeft(node.Left);
                }
                return RotateRight(node);
            }

            if (balanceFactor < -1)
            {
                if (GetBalanceFactor(node.Right) > 0)
                {
                    node.Right = RotateRight(node.Right);
                }
                return RotateLeft(node);
            }

            return node;
        }

        private void UpdateHeight(TreeNode<T> node)
        {
            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
        }

        private int GetHeight(TreeNode<T> node)
        {
            return node?.Height ?? 0;
        }

        private int GetBalanceFactor(TreeNode<T> node)
        {
            return GetHeight(node.Left) - GetHeight(node.Right);
        }

        private TreeNode<T> RotateRight(TreeNode<T> x)
        {
            var y = x.Left;
            var z = y.Right;

            y.Right = x;
            x.Left = z;

            UpdateHeight(x);
            UpdateHeight(y);

            return y;
        }

        private TreeNode<T> RotateLeft(TreeNode<T> x)
        {
            var y = x.Right;
            var z = y.Left;

            y.Left = x;
            x.Right = z;

            UpdateHeight(x);
            UpdateHeight(y);

            return y;
        }
    }
}
