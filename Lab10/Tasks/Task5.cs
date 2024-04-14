namespace Lab10
{
    public class Queue<T>
    {
        private T[] items;
        private int head;
        private int tail;

        public Queue(int capacity)
        {
            items = new T[capacity];
            head = 0;
            tail = -1;
        }

        public void Enqueue(T item)
        {
            if (tail == items.Length - 1)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[++tail] = item;
        }

        public T Dequeue()
        {
            T dequeuedItem = items[head];
            items[head++] = default(T);
            return dequeuedItem;
        }

        public T Peek()
        {
            return items[head];
        }

        public int Count
        {
            get { return tail - head + 1; }
        }
    }
}
