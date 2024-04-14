namespace Lab10
{
    public class Stack<T>
    {
        private T[] items;
        private int top;

        public Stack(int capacity)
        {
            items = new T[capacity];
            top = -1;
        }

        public void Push(T item)
        {
            if (top == items.Length - 1)
            {
                //Resize використовується для зміни розміру масиву у разі, якщо він заповнений до максимальної ємності.
                Array.Resize(ref items, items.Length * 2);
            }
            items[++top] = item;
        }

        public T Pop()
        {
            T poppedItem = items[top];
            items[top--] = default(T);
            return poppedItem;
        }

        public T Peek()
        {
            return items[top];
        }

        public int Count
        {
            get { return top + 1; }
        }
    }

}
