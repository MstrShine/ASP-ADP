namespace HAN.ASD.ADP.DataStructures.BinaryTree
{
    public interface IBinaryTree<T> where T : IComparable<T>
    {
        void Insert(T value);
        T Min();
        T Max();
        T Find(T value);
        void Remove(T value);

        void Print();
    }
}
