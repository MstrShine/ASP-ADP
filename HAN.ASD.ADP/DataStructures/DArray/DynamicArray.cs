namespace HAN.ASD.ADP.DataStructures.DArray
{
    public class DynamicArray<T> : IDynamicArray<T> where T : IComparable<T>
    {
        private T[] _array;
        private int _size;
        private int _capacity;

        public DynamicArray(int initialCapacity = 1)
        {
            _array = new T[initialCapacity];
            _size = 0;
            _capacity = initialCapacity;
        }

        public T this[int index]
        {
            get
            {
                return Get(index);
            }
            set
            {
                Set(index, value);
            }
        }

        public void Add(T element)
        {
            if (_size == _capacity)
            {
                Resize();
            }

            _array[_size] = element;
            _size++;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < _size; i++)
            {
                if (element.CompareTo(_array[i]) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException();
            }

            return _array[index];
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_array[i].CompareTo(element) == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < _size - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            _size--;
        }

        public void Remove(T element)
        {
            var index = IndexOf(element);
            Remove(index);
        }

        public void Set(int index, T element)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException();
            }

            _array[index] = element;
        }

        public int Size() => _size;

        private void Resize()
        {
            _capacity = (_capacity * 2) + 1;
            var temp = new T[_capacity];
            for (int i = 0; i < _size; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
    }
}
