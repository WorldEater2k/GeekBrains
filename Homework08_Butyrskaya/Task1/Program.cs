using System;
using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        PropertyInfo[] info = typeof(DateTime).GetProperties();
        foreach (PropertyInfo p in info)
            Console.WriteLine(p);
        Console.ReadKey();
    }
}