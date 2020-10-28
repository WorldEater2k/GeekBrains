using System;

namespace Task2
{
    // Написать метод подсчета количества цифр числа.
    //
    // Автор: Бутырская Е.Д.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число >> ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Кол-во цифр в числе: " + DigitsCount(a));
            Console.ReadKey();
        }
        static int DigitsCount(int number)
        {
            int count = 0;
            do
            {
                count++;
                number /= 10;
            } while (number != 0);
            return count;
        }
    }
}
