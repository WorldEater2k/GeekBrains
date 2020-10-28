using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Меня зовут Лиза, мне 19 лет, и я из Москвы.";
            Console.Write("А. " + msg);

            Console.SetCursorPosition(35, 13);
            Console.Write("Б. " + msg);

            Console.SetCursorPosition(0, 15);
            Console.Write("Нажмите любую клавишу, чтобы опробовать вариант с вызовом методов...");
            Console.ReadKey();
            Console.Clear();

            int x = FindCenterX(msg.Length + 3);
            int y = FindCenterY();
            Print("В. " + msg, x, y);

            Console.ReadKey();
        }

        static int FindCenterX(int msgLength)
        {
            return (Console.WindowWidth - msgLength) / 2;
        }
        static int FindCenterY()
        {
            return Console.WindowHeight / 2;
        }
        static void Print(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(message);
        }
    }
}
