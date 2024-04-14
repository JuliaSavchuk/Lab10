namespace Lab10
{
    public class Task1_3
    {
        //Iнтерфейс IComparable<T> дозволяє порівнювати об'єкти типу T. Метод повертає найбільше з трьох значень, використовуючи порівняння через CompareTo.
        public static T MaxNum<T>(T a, T b, T c) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                return a;
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                return b;
            else
                return c;
        }

        public static T MinNum<T>(T a, T b, T c) where T : IComparable<T>
        {
            if (a.CompareTo(b) < 0 && a.CompareTo(c) < 0)
                return a;
            else if (b.CompareTo(a) < 0 && b.CompareTo(c) < 0)
                return b;
            else
                return c;
        }

        public static T SumArray<T>(T[] array)
        {
            dynamic sum = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
