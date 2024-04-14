namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n_____Task 1_____\n");
            int maxInt = Task1_3.MaxNum<int>(-3, 7, 1);
            double maxDouble = Task1_3.MaxNum<double>(-5.6, 2.8, 9.1);

            Console.WriteLine($"Max int num: {maxInt}");
            Console.WriteLine($"Max fractional num: {maxDouble}");

            Console.WriteLine("\n_____Task 2_____\n");
            int minInt = Task1_3.MinNum<int>(-3, 7, 1);
            double minDouble = Task1_3.MinNum<double>(-5.6, 2.8, 9.1);

            Console.WriteLine($"Min int num: {minInt}");
            Console.WriteLine($"Mmin fractional num: {minDouble}");

            Console.WriteLine("\n_____Task 3_____\n");
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.5, 2.5, 3.5, 4.5 };

            int sumInt = Task1_3.SumArray(intArray);
            double sumDouble = Task1_3.SumArray(doubleArray);

            Console.WriteLine($"Sum of integers: {sumInt}");
            Console.WriteLine($"Sum of doubles: {sumDouble}");

            Console.WriteLine("\n_____Task 4_____\n");
            Stack<int> stack = new Stack<int>(4);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("Count: " + stack.Count);
            Console.WriteLine("Peek: " + stack.Peek());

            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Count: " + stack.Count);

            Console.WriteLine("\n_____Task 5_____\n");
            Queue<int> queue = new Queue<int>(5);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);

            Console.WriteLine("Count: " + queue.Count);
            Console.WriteLine("Peek: " + queue.Peek());

            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Count: " + queue.Count);

        }
    }
}