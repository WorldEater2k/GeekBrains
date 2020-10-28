using System;

namespace Task3
{
    class Program
    {
        // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        //
        // Автор: Бутырская Е.Д.
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Введите числа. В конце последовательности введите \"0\".");

            int a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                if (a > 0 && a % 2 != 0)
                    sum += a;
                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Сумма нечётных положительных чисел: " + sum);
            Console.ReadKey();
        }
    }
}
