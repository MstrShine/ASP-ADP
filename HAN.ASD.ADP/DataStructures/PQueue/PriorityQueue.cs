namespace HAN.ASD.ADP.DataStructures.PQueue
{
    public class PriorityQueue<T> : IPriorityQueue<T> where T : IComparable<T>
    {
        private List<T> _elements = new List<T>();

        public void Add(T item)
        {
            _elements.Add(item);
            _elements.Sort();
        }

        public T Peek()
        {
            if (_elements.Count == 0)
                throw new InvalidOperationException("PriorityQueue is empty.");

            return _elements[0];
        }

        public T Poll()
        {
            if (_elements.Count == 0)
                throw new InvalidOperationException("PriorityQueue is empty.");

            T item = _elements[0];
            _elements.RemoveAt(0);
            return item;
        }
    }
}
