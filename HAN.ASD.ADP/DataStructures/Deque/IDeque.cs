namespace HAN.ASD.ADP.DataStructures.Deque
{
    public interface IDeque<T> where T : IComparable<T>
    {
        void InsertLeft(T item);

        void InsertRight(T item);

        T DeleteLeft();

        T DeleteRight();

        int Size();
    }
}
