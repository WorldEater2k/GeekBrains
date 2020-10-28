using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш вес (кг) >> ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Введите ваш рост (см) >> ");
            double height = double.Parse(Console.ReadLine());
            height /= 100;

            Console.WriteLine("Индекс массы тела = {0:f3}", weight / (height * height));
            Console.ReadKey();
        }
    }
}
