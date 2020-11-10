using System;
using System.IO;

namespace Task4
{
    struct Account
    {
        public string Login;
        public string Password;
        public Account(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("..\\..\\accounts.txt");
            Account[] userData = new Account[3];
            int i = 0;

            while (!sr.EndOfStream && i < 3)
            {
                userData[i] = new Account(sr.ReadLine(), sr.ReadLine());
                if (CheckUserData(userData[i]))
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
            }

            sr.Close();
            Console.ReadKey();
        }
        static bool CheckUserData(Account account)
        {
            return account.Login.Equals("root") && account.Password.Equals("GeekBrains");
        }
    }
}
