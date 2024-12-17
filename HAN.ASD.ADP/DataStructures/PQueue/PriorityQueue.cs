namespace HAN.ASD.ADP.DataStructures.PQueue
{
    public class PriorityQueue<T> : IPriorityQueue<T> where T : IComparable<T>
    {
        private T[] _array;
        private int _size;

        public PriorityQueue(int initialSize = 1)
        {
            _array = new T[initialSize];
            _size = 0;
        }

        public void Add(T item)
        {
            if (_size == _array.Length)
            {
                Resize();
            }

            _array[_size++] = item;
        }

        public T Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("The priority queue is empty.");
            }

            int highestPriorityIndex = GetHighestPriorityIndex();
            return _array[highestPriorityIndex];
        }

        public T Poll()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("The priority queue is empty.");
            }

            int highestPriorityIndex = GetHighestPriorityIndex();
            T highestPriorityItem = _array[highestPriorityIndex];

            _array[highestPriorityIndex] = _array[--_size];

            return highestPriorityItem;
        }

        public int Size() => _size;

        private int GetHighestPriorityIndex()
        {
            int highestPriorityIndex = 0;
            for (int i = 1; i < _size; i++)
            {
                if (_array[i].CompareTo(_array[highestPriorityIndex]) < 0)
                {
                    highestPriorityIndex = i;
                }
            }
            return highestPriorityIndex;
        }

        private void Resize()
        {
            var newSize = _size * 2;
            var temp = new T[newSize];
            for (int i = 0; i < _size; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
    }
}
