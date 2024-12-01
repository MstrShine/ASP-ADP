namespace HAN.ASD.ADP.DataStructures.Deque
{
    public interface IDeque<T>
    {
        void InsertLeft(T item);

        void InsertRight(T item);

        T DeleteLeft(T item);

        T DeleteRight(T item);

        int Size();
    }
}
