using System;

namespace Task6
{
    // *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
    // «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени
    // выполнения программы, используя структуру DateTime.
    //
    // Автор: Бутырская Е.Д.
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            DateTime start = DateTime.Now;

            for (int i = 1; i <= 1_000_000_000; i++) //результат получился 61574510
                if (isGood(i))
                    count++;

            DateTime finish = DateTime.Now;
            Console.WriteLine($"Кол-во \"хороших\" чисел: {count}. Время выполнения: {finish - start} мс.");
            Console.ReadKey();
        }
        static int DigitsSum(int a)
        {
            int sum = 0;
            while (a != 0)
            {
                sum += a % 10;
                a /= 10;
            }
            return sum;
        }
        static bool isGood(int a)
        {
            return a % DigitsSum(a) == 0;
        }
    }
}
