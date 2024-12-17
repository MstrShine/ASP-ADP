namespace HAN.ASD.ADP.DataStructures.Stack
{
    public class ADPStack<T> : IADPStack<T> where T : IComparable<T>
    {
        private T[] _array;
        private int _top;

        public ADPStack(int initialCapacity = 1)
        {
            _array = new T[initialCapacity];
            _top = -1;
        }

        public bool IsEmpty() => _top == -1;

        public int Size() => _top + 1;

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            var value = _array[_top];
            _array[_top--] = default(T);

            return value;
        }

        public void Push(T item)
        {
            if (_top + 1 == _array.Length)
                Resize();
            _top++;
            _array[_top] = item;
        }

        public T Top()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return _array[_top];
        }

        private void Resize()
        {
            var newCapacity = _array.Length * 2;
            var temp = new T[newCapacity];
            for (int i = 0; i <= _top; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
    }
}
