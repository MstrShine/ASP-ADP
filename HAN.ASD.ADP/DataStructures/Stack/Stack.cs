namespace HAN.ASD.ADP.DataStructures.Stack
{
    public class Stack<T> : IStack<T> where T : IComparable<T>
    {
        private T[] _elements;
        private int _top;

        public Stack(int initialCapacity = 1)
        {
            _elements = new T[initialCapacity];
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

            var value = _elements[_top];
            _elements[_top--] = default(T);

            return value;
        }

        public void Push(T item)
        {
            if (_top == _elements.Length)
                Resize();

            _elements[_top++] = item;
        }

        public T Top()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return _elements[_top];
        }

        private void Resize()
        {
            var newCapacity = _elements.Length * 2;
            var temp = new T[newCapacity];
            Array.Copy(_elements, 0, temp, 0, _top + 1);
            _elements = temp;
        }
    }
}
