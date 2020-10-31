using System;

namespace Task7
{
    // a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
    // б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
    //
    // Автор: Бутырская Е.Д.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа (a < b)...");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("А. Рекурсивный вывод:");
            RecursiveOutput(a, b);
            Console.WriteLine("Б. Рекурсивная сумма: " + RecursiveSum(a, b));
            Console.ReadKey();
        }
        static void RecursiveOutput(int a, int b)
        {
            Console.WriteLine(a);
            if (a < b) 
                RecursiveOutput(a + 1, b);
        }
        static long RecursiveSum(int a, int b)
        {
            if (a == b)
                return a;
            else
                return a + RecursiveSum(a + 1, b);
        }
    }
}
