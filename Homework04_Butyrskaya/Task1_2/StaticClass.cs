using System;
using System.IO;

namespace Task1_2
{
    public static class StaticClass
    {
        public static void FindPairs(int[] arr)
        {
            Console.WriteLine("Массив:");
            foreach (int n in arr)
                Console.Write(n + " ");

            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
                if (arr[i] % 3 == 0 ^ arr[i + 1] % 3 == 0)
                    count++;

            Console.WriteLine("\nКол-во пар: " + count);
        }
        public static int[] ReadArray(string filename)
        {
            if (File.Exists(filename))
            {
                string[] data = File.ReadAllLines(filename);
                int[] arr = new int[data.Length];
                for (int i = 0; i < data.Length; i++)
                    arr[i] = int.Parse(data[i]);
                return arr;
            }
            else
            {
                Console.WriteLine("Ошибка: файл не найден!");
                return null;
            }
        }
    }
}