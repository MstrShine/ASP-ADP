namespace HAN.ASD.ADP.DataStructures.Stack
{
    public interface IStack<T>
    {
        void Push(T item);

        T Pop();

        T Top();

        bool IsEmpty();

        int Size();
    }
}
