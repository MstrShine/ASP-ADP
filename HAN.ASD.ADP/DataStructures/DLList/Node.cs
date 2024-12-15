namespace HAN.ASD.ADP.DataStructures.DLList
{
    public class Node<T> where T : IComparable<T>
    {
        public T Value { get; set; }

        public Node<T>? Prev { get; set; }

        public Node<T>? Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Prev = null;
            Next = null;
        }
    }
}
