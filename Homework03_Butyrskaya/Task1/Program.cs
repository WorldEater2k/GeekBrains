using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(4.34, 2.9);
            Complex b = new Complex(6.666, -5);
            Console.WriteLine($"Число 1: {a}");
            Console.WriteLine($"Число 2: {b}");
            Console.WriteLine("Что вы хотите сделать с числами? Введите +, -, * или /. Чтобы закрыть программу, введите exit.");
            string s = Console.ReadLine();
            while (!s.Equals("exit"))
            {
                switch (s)
                {
                    case "+":
                        Console.WriteLine($"Сумма чисел: {a.Plus(b)}");
                        break;
                    case "-":
                        Console.WriteLine($"Разность чисел: {a.Minus(b)}");
                        break;
                    case "*":
                        Console.WriteLine($"Произведение чисел: {a.Multiply(b)}");
                        break;
                    case "/":
                        Console.WriteLine($"Частное чисел: {a.Divide(b)}");
                        break;
                    default:
                        Console.WriteLine($"Ошибка ввода. Попробуйте ещё раз.");
                        break;
                }
                s = Console.ReadLine();
            }
        }
    }
}
