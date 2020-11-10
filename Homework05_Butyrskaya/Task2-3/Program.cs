using System;
using System.Collections.Generic;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.PrintWords("Hello, I am a student at GeekBrains", 3);
            Console.WriteLine(Message.RemoveEnd("My dream is to become a game developer", 'e'));
            Console.WriteLine(Message.FindLongestWord("So I attend programming classes"));
            Console.WriteLine(Message.GetLongestWords("My hobbies are psychology and literature"));
            string[] words = { "mother", "father", "sister", "i" };
            Dictionary<string, int> freq = Message.CountWords(words, "I really love my mother and sister.");
            foreach (KeyValuePair<string, int> pair in freq)
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            Console.WriteLine(Message.IsReversed("qwerty", "ytrewq") + " " + Message.IsReversed("art", "try"));
            Console.ReadKey();
        }
    }
}
