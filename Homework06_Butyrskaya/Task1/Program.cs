using System;

namespace Task1
{
    /* Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
    Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

    Автор: Бутырская Е. */

    public delegate double SomeFunction(double a, double x);

    class Program
    {
        public static void Table(SomeFunction F, double a, double x, double end)
        {
            Console.WriteLine("----- A -------- X -------- Y ----");
            while (x <= end)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("----------------------------------");
        }
        public static double Func1(double a, double x)
        {
            return a * x * x;
        }
        public static double Func2(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main()
        {
            Console.WriteLine("Таблица функции a*x^2:");
            Table(Func1, 4, -3, 3);
            Console.WriteLine("Таблица функции a*sin(x):");
            Table(Func2, 5.5, -3, 3);
            Console.ReadKey();
        }
    }
}
