using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты 1-ой точки");
            Console.Write("X = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты 2-ой точки");
            Console.Write("X = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nА. Расстояние между точками: {0:f2}", Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine("Б. Расстояние между точками: {0:f2}", CalcDistance(x1, y1, x2, y2));

            Console.ReadKey();
        }

        static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
