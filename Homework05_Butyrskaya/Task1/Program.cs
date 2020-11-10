using System;
using System.Text.RegularExpressions;
class Program
{
    /* Создать программу, которая будет проверять корректность ввода логина.
    Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой.
    а) без использования регулярных выражений;
    б) **с использованием регулярных выражений.
    
    Автор: Бутырская Е.Д. */

    static void Main(string[] args)
    {
        Console.Write("Введите логин >> ");
        string login = Console.ReadLine();

        // без использования регулярных выражений
        if (login.Length >= 2 && login.Length <= 10)
        {
            if (login[0] >= '0' && login[0] <= '9')
                Console.WriteLine("А. Ошибка! Логин не может начинаться с цифры.");
            else
            {
                bool correct = true;
                foreach (char ch in login)
                    if (!(ch >= 'a' && ch <= 'z'
                        || ch >= 'A' && ch <= 'Z'
                        || ch >= '0' && ch <= '9'))
                        correct = false;
                if (correct)
                    Console.WriteLine("А. Логин корректный.");
                else
                    Console.WriteLine("А. Ошибка! Логин может содержать только латинские буквы и цифры.");
            }
        }
        else
            Console.WriteLine("А. Ошибка! Логин должен содержать от 2 до 10 символов.");

        // с использованием регулярных выражений
        Regex reg = new Regex(@"\b[a-zA-Z]{1}[a-zA-Z0-9]{1,9}\b");
        if (reg.IsMatch(login) && !login.Contains("(") && !login.Contains(")"))
            Console.WriteLine("Б. Логин корректный.");
        else
            Console.WriteLine("Б. Логин некорректный.");

        Console.ReadKey();
    }
}