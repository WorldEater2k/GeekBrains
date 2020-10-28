using System;

namespace Task5
{
    // а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
    // нужно ли человеку похудеть, набрать вес или всё в норме.
    // б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    //
    // Автор: Бутырская Е.Д.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш вес (кг) >> ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Введите ваш рост (см) >> ");
            double height = double.Parse(Console.ReadLine());

            double bmi = CalcBmi(weight, height / 100);

            QuickAnalysis(bmi);
            DetailedAnalysis(bmi, height / 100);

            Console.ReadKey();
        }
        static double CalcBmi(double weight, double height)
        {
            return weight / (height * height);
        }
        static void QuickAnalysis(double bmi)
        {
            Console.Write("А. Индекс массы тела = {0:f3}. ", bmi);
            if (bmi < 18)
                Console.WriteLine("Вам нужно набрать вес.");
            else if (bmi >= 25)
                Console.WriteLine("Вам нужно похудеть.");
            else
                Console.WriteLine("Всё в норме.");
        }
        static void DetailedAnalysis(double bmi, double height)
        {
            Console.Write("Б. Индекс массы тела = {0:f3}. ", bmi);
            if (bmi < 18)
            {
                double n = 18 * height * height - bmi * height * height;
                Console.WriteLine("Вам нужно набрать {0:f2} кг.", n);
            }
            else if (bmi >= 25)
            {
                double n = bmi * height * height - 24.9 * height * height;
                Console.WriteLine("Вам нужно похудеть на {0:f2} кг.", n);
            }
            else
                Console.WriteLine("Всё в норме.");
        }
    }
}
