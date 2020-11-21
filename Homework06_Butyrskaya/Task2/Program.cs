using System;
using System.IO;

namespace Task2
{
    /* Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
    а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
    Использовать массив (или список) делегатов, в котором хранятся различные функции.
    б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум
    через параметр (с использованием модификатора out).
    
    Автор: Бутырская Е. */
    class Program
    {
        public delegate double MyDelegate(double x);
        public static double MyFunc1(double x)
        {
            return Math.Sin(x);
        }
        public static double MyFunc2(double x)
        {
            return Math.Cos(x);
        }
        public static double MyFunc3(double x)
        {
            return x + 100;
        }
        public static double MyFunc4(double x)
        {
            return x * x * x;
        }
        public static double MyFunc5(double x)
        {
            return (x * 9 + 5) / 11;
        }

        public static void SaveFunc(string fileName, MyDelegate F, double start, double end, double step)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = start;
            while (x <= end)
            {
                bw.Write(F(x));
                x += step;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double[] values = new double[fs.Length / sizeof(double)];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = bw.ReadDouble();
                if (values[i] < min)
                    min = values[i];
            }
            bw.Close();
            fs.Close();
            return values;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите функцию:");
            Console.WriteLine("1 - sin(x)");
            Console.WriteLine("2 - cos(x)");
            Console.WriteLine("3 - x+100");
            Console.WriteLine("4 - x^3");
            Console.WriteLine("5 - (x*9+5)/11");
            int option = 0;
            MyDelegate func = MyFunc1;

            // Пользователь выбирает функцию из списка.
            do
            {
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            break;
                        case 2:
                            func = MyFunc2;
                            break;
                        case 3:
                            func = MyFunc3;
                            break;
                        case 4:
                            func = MyFunc4;
                            break;
                        case 5:
                            func = MyFunc5;
                            break;
                        default:
                            Console.WriteLine("Такой опции нет. Введите число от 1 до 5.");
                            break;
                    }
                }
                else
                    Console.WriteLine("Вы должны ввести число от 1 до 5. Попробуйте ещё раз.");
            } while (option < 1 || option > 5);

            // Пользователь задаёт начало и конец отрезка, шаг функции.
            Console.WriteLine("Введите начало отрезка:");
            double start;
            bool flag = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out start))
                    flag = true;
                else
                    Console.WriteLine("Вы должны ввести значение типа double. Попробуйте ещё раз.");
            }
            while (!flag);

            Console.WriteLine("Введите конец отрезка:");
            double end;
            flag = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out end))
                    flag = true;
                else
                    Console.WriteLine("Вы должны ввести значение типа double. Попробуйте ещё раз.");
            }
            while (!flag);

            Console.WriteLine("Введите шаг функции:");
            double step;
            flag = false;
            do
            {
                if (double.TryParse(Console.ReadLine(), out step))
                    flag = true;
                else
                    Console.WriteLine("Вы должны ввести значение типа double. Попробуйте ещё раз.");
            }
            while (!flag);

            // Сохраняем результат работы функции в бинарный файл.
            SaveFunc("data.bin", func, start, end, step);

            // Выводим в консоль значения и минимум функции.
            double min;
            Console.WriteLine("Значения F(x):");
            foreach(double d in Load("data.bin", out min))
                Console.Write(d + " ");
            Console.WriteLine($"\nМинимум:\n{min}");
            Console.ReadKey();
        }
    }
}
