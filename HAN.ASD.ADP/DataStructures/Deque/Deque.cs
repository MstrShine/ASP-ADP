namespace HAN.ASD.ADP.DataStructures.Deque
{
    public class Deque<T> : IDeque<T> where T : IComparable<T>
    {
        private T[] items;
        private int front;
        private int rear;
        private int count;

        public Deque(int capacity = 1)
        {
            items = new T[capacity];
            front = 0;
            rear = -1;
            count = 0;
        }

        public void InsertLeft(T item)
        {
            if (count == items.Length)
                Resize();

            if (front == 0)
            {
                front = items.Length - 1;
            }
            else
            {
                front--;
            }

            items[front] = item;
            count++;
        }

        public void InsertRight(T item)
        {
            if (count == items.Length)
                Resize();

            rear = (rear + 1) % items.Length;

            items[rear] = item;
            count++;
        }

        public T DeleteLeft()
        {
            if (count == 0)
                throw new InvalidOperationException("Deque is empty.");

            int index = front;
            front = (front + 1) % items.Length;
            count--;
            return items[index];
        }

        public T DeleteRight()
        {
            if (count == 0)
                throw new InvalidOperationException("Deque is empty.");

            int index = rear;
            if (rear == -1)
                index = 0;

            rear = (rear - 1 + items.Length) % items.Length;
            count--;
            return items[index];
        }

        public int Size()
        {
            return count;
        }

        private void Resize()
        {
            int oldCapacity = items.Length;
            int newCapacity = oldCapacity * 2;
            T[] newItems = new T[newCapacity];

            for (int i = 0; i < count; i++)
            {
                newItems[i] = items[(front + i) % oldCapacity];
            }

            front = 0;
            rear = count - 1;
            items = newItems;
        }
    }
}
