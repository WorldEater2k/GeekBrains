using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые числа. В конце последовательности введите \"0\".");
            string s = Console.ReadLine();
            List<int> list = new List<int>();
            while (!s.Equals("0"))
            {
                int i;
                bool flag = int.TryParse(s, out i);
                if (flag && i > 0 && i % 2 != 0)
                    list.Add(i);
                else if (!flag)
                    Console.WriteLine("Вы ввели не целое число. Попробуйте ещё раз.");
                s = Console.ReadLine();
            }

            Console.WriteLine("Нечётные положительные числа: ");
            foreach (int a in list)
                Console.Write(a + " ");
            Console.WriteLine("\nСумма: " + list.Sum());
            Console.ReadKey();
        }
    }
}
