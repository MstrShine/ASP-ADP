namespace HAN.ASD.ADP.DataStructures.Deque
{
    public class Deque<T> : IDeque<T>
    {
        private T[] _items;
        private int _leftIndex;
        private int _rightIndex;

        public Deque(int initialCapacity = 1)
        {
            _items = new T[initialCapacity];
            _leftIndex = 0;
            _rightIndex = -1;
        }

        public T DeleteLeft(T item)
        {
            if (_rightIndex == -1)
            {
                throw new InvalidOperationException("Deque is empty.");
            }

            var result = _items[_leftIndex];
            if (_leftIndex == _rightIndex)
            {
                _leftIndex = 0;
                _rightIndex = -1;
            }
            else
            {
                _leftIndex++;
                if (_leftIndex > _items.Length)
                {
                    _leftIndex = 0;
                }
            }

            return result;
        }

        public T DeleteRight(T item)
        {
            if (_rightIndex == -1)
            {
                throw new InvalidOperationException("Deque is empty.");
            }

            var result = _items[_rightIndex];
            if (_leftIndex == _rightIndex)
            {
                _leftIndex = 0;
                _rightIndex = -1;
            }
            else
            {
                _rightIndex--;
                if (_rightIndex < 0)
                {
                    _rightIndex = _items.Length - 1;
                }
            }

            return result;
        }

        public void InsertLeft(T item)
        {
            if (_rightIndex + 1 > _items.Length)
            {
                Resize();
            }

            _rightIndex++;
            if (_leftIndex > _rightIndex)
            {
                _leftIndex = 0;
            }
            _items[_leftIndex] = item;
        }

        public void InsertRight(T item)
        {
            if (_rightIndex + 1 == _items.Length)
            {
                Resize();
            }

            _rightIndex++;
            if (_leftIndex > _rightIndex)
            {
                _leftIndex = 0;
            }
            _items[_rightIndex] = item;
        }

        public int Size()
        {
            return _items.Length;
        }

        private void Resize()
        {
            throw new NotImplementedException();
        }
    }
}
