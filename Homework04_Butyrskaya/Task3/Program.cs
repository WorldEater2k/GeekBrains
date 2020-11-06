using System;
using System.Collections.Generic;
using MyArray;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Array1D arrayRand = new Array1D(7);
            Console.WriteLine("Случайные значения:");
            arrayRand.Print();

            Array1D arrayStep = new Array1D(5, 10, 2);
            Console.WriteLine("\nЗначения с шагом 2:");
            arrayStep.Print();

            Array1D arrayFile = new Array1D("..\\..\\test.txt");
            Console.WriteLine("\nЧтение из файла:");
            arrayFile.Print();

            Console.WriteLine($"\nМаксимальный элемент: {arrayFile.Max}, встречается {arrayFile.MaxCount} раз(а).");

            Console.WriteLine("\narray[3] был: " + arrayFile[3]);
            arrayFile[3] = 100500;
            Console.WriteLine("array[3] стал: " + arrayFile[3]);

            Console.WriteLine("\nСумма элементов: " + arrayFile.Sum);

            Console.WriteLine("\nИнвертированный массив:");
            Array1D inversed = arrayFile.Inverse();
            inversed.Print();

            Console.WriteLine("\nУмножение на 4:");
            Array1D multiplied = arrayFile.Multi(4);
            multiplied.Print();

            Console.WriteLine("\nЧастота вхождения элементов:");
            SortedDictionary<int, int> frequency = arrayFile.CalcFrequency();
            foreach (var pair in frequency)
                Console.WriteLine("{0,6} {1,6}", pair.Key, pair.Value);

            Console.ReadKey();
        }
    }
}
