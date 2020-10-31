using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(4, 20);
            Fraction b = new Fraction(5, 7);
            Console.WriteLine("Дробь 1: " + a);
            Console.WriteLine("Дробь 2: " + b);
            Console.WriteLine("Сумма дробей: " + a.Plus(b));
            Console.WriteLine("Разность дробей: " + a.Minus(b));
            Console.WriteLine("Произведение дробей: " + a.Multiply(b));
            Console.WriteLine("Частное дробей: " + a.Divide(b));
            Console.ReadKey();
        }
    }
}
