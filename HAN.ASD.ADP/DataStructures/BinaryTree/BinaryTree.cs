namespace HAN.ASD.ADP.DataStructures.BinaryTree
{
    public class BinaryTree<T> : IBinaryTree<T> where T : IComparable<T>
    {
        private TreeNode<T> _root;

        public BinaryTree()
        {
            _root = null;
        }

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

            return node;
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

        private TreeNode<T> RemoveRecursive(TreeNode<T> node, T value)
        {
            if (node == null)
            {
                return null;
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
                else if (node.Right == null)
                {
                    return node.Left;
                }

                node.Value = MinBelowNode(node.Right);
                node.Right = RemoveRecursive(node.Right, node.Value);
            }

            return node;
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
    }
}
