using System;

namespace Task1
{
    // Написать метод, возвращающий минимальное из трёх чисел.
    //
    // Автор: Бутырская Е.Д.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 целых числа...");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Минимальное число: " + FindMin(a, b, c));
            Console.ReadKey();
        }

        static int FindMin(int a, int b, int c)
        {
            if (c < a && c < b)
                return c;
            else if (a < b)
                return a;
            else
                return b;
        }
    }
}
