using System;

namespace Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = InitArray(20, -10000, 10000);
            StaticClass.FindPairs(array);
            Console.WriteLine();

            int[] array2 = StaticClass.ReadArray("..\\..\\test.txt");
            if (array2 != null)
                StaticClass.FindPairs(array2);

            Console.ReadKey();
        }
        static int[] InitArray(int size, int min, int max)
        {
            int[] arr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
                arr[i] = rnd.Next(min, max + 1);
            return arr;
        }
    }
}
