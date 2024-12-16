namespace HAN.ASD.ADP.DataStructures.DArray
{
    public interface IDynamicArray<T> where T : IComparable<T>
    {
        public T this[int index] { get; set; }

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
