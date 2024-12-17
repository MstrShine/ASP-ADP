namespace HAN.ASD.ADP.DataStructures.Deque
{
    public class Deque<T> : IDeque<T> where T : IComparable<T>
    {
        private T[] _array;
        private int _front;
        private int _rear;
        private int _count;

        public Deque(int capacity = 1)
        {
            _array = new T[capacity];
            _front = 0;
            _rear = -1;
            _count = 0;
        }

        public void InsertLeft(T item)
        {
            if (_count == _array.Length)
                Resize();

            if (_front == 0)
            {
                _front = _array.Length - 1;
            }
            else
            {
                _front--;
            }

            _array[_front] = item;
            _count++;
        }

        public void InsertRight(T item)
        {
            if (_count == _array.Length)
                Resize();

            _rear = (_rear + 1) % _array.Length;

            _array[_rear] = item;
            _count++;
        }

        public T DeleteLeft()
        {
            if (_count == 0)
                throw new InvalidOperationException("Deque is empty.");

            int index = _front;
            _front = (_front + 1) % _array.Length;
            _count--;
            return _array[index];
        }

        public T DeleteRight()
        {
            if (_count == 0)
                throw new InvalidOperationException("Deque is empty.");

            int index = _rear;
            if (_rear == -1)
                index = 0;

            _rear = (_rear - 1 + _array.Length) % _array.Length;
            _count--;
            return _array[index];
        }

        public int Size()
        {
            return _count;
        }

        private void Resize()
        {
            int oldCapacity = _array.Length;
            int newCapacity = oldCapacity * 2;
            T[] newItems = new T[newCapacity];

            for (int i = 0; i < _count; i++)
            {
                newItems[i] = _array[(_front + i) % oldCapacity];
            }

            _front = 0;
            _rear = _count - 1;
            _array = newItems;
        }
    }
}
