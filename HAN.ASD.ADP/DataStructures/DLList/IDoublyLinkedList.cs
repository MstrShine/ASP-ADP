namespace HAN.ASD.ADP.DataStructures.DLList
{
    public interface IDoublyLinkedList<T> where T : IComparable<T>
    {
        public void Add(T element);

        public T Get(int index);

        public void Set(int index, T element);

        public void Remove(int index);

        public void Remove(T element);

        public bool Contains(T element);

        public int IndexOf(T element);

        public int Size();
    }
}
