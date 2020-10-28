using System;

namespace Task4
{
    // Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
    // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
    // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
    // программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
    //
    // Автор: Бутырская Е.Д.
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.Write("Введите логин >> ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль >> ");
                string password = Console.ReadLine();

                if (CheckUserData(login, password))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Добро пожаловать на сайт!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный логин или пароль!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                i++;
            } while (i < 3);

            Console.ReadKey();
        }
        static bool CheckUserData(string login, string password)
        {
            return login.Equals("root") && password.Equals("GeekBrains");
        }
    }
}
