using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя >> ");
            string name = Console.ReadLine();

            Console.Write("Введите вашу фамилию >> ");
            string surname = Console.ReadLine();

            Console.Write("Введите ваш возраст >> ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите ваш рост >> ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Введите ваш вес >> ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("А. Имя: " + name + ", фамилия: " + surname + ", возраст: " + age + ", рост: " + height + ", вес: " + weight + ".");
            Console.WriteLine("Б. Имя: {0}, фамилия: {1}, возраст: {2}, рост: {3}, вес: {4}.", name, surname, age, height, weight);
            Console.WriteLine($"В. Имя: {name}, фамилия: {surname}, возраст: {age}, рост: {height}, вес: {weight}.");

            Console.ReadKey();
        }
    }
}