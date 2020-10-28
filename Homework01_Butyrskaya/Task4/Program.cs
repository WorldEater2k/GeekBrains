using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число A >> ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите целое число B >> ");
            int b = int.Parse(Console.ReadLine());

            // Обмен с использованием 3-ей переменной
            int c = a; 
            a = b;
            b = c;

            Console.WriteLine($"\nА. Переменные после обмена значениями: A = {a}, B = {b}");

            // Обмен без использования 3-ей переменной
            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine($"Б. Переменные после второго обмена значениями: A = {a}, B = {b}");
            Console.ReadKey();
        }
    }
}
