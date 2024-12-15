namespace HAN.ASD.ADP.DataStructures.DLList
{
    public class DoublyLinkedList<T> : IDoublyLinkedList<T> where T : IComparable<T>
    {
        private Node<T>? Head { get; set; }

        private Node<T>? Tail { get; set; }

        private int _size;

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            _size = 0;
        }

        public void Add(T element)
        {
            var node = new Node<T>(element);
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Prev = Tail;
                Tail.Next = node;
                Tail = node;
            }

            _size++;
        }

        public bool Contains(T element)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Value.CompareTo(element) == 0)
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            var current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Value;
        }

        public int IndexOf(T element)
        {
            var current = Head;
            var index = 0;
            while (current != null)
            {
                if (current.Value.CompareTo(element) == 0)
                {
                    return index;
                }

                current = current.Next;
                index++;
            }

            return -1;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            var current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            if (index == 0)
            {
                Head = current.Next;
                if (Head != null)
                {
                    Head.Prev = null;
                }
            }
            else if (index == _size - 1)
            {
                Tail = current.Prev;
                Tail.Next = null;
            }
            else
            {
                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;
            }

            _size--;
        }

        public void Remove(T element)
        {
            var index = IndexOf(element);
            Remove(index);
        }

        public void Set(int index, T element)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            var current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            current.Value = element;
        }
    }
}
