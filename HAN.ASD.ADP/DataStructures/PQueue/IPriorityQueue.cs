namespace HAN.ASD.ADP.DataStructures.PQueue
{
    public interface IPriorityQueue<T> where T : IComparable
    {
        void Add(T item);

        T Peek();

        T Poll();
    }
}
