using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task2_3
{
    /* 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    а) Вывести только те слова сообщения,  которые содержат не более n букв.
    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    в) Найти самое длинное слово сообщения.
    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    д) ***Создать метод, который производит частотный анализ текста.
    В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает,
    сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.

     3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    
    Автор: Бутырская Е.Д. */

    static class Message
    {
        static public void PrintWords(string msg, int maxLetters)
        {
            StringBuilder sb = new StringBuilder(msg);
            for (int i = 0; i < sb.Length;)
            {
                if (char.IsPunctuation(sb[i]))
                    sb.Replace(sb[i].ToString(), "");
                else
                    i++;
            }
            string[] ss = Convert.ToString(sb).Split(' ');
            foreach (string s in ss)
                if (s.Length <= maxLetters)
                    Console.Write(s + " ");
            Console.WriteLine();
        }

        static private int FindMaxLength(string[] ss)
        {
            int max = ss[0].Length;
            for (int i = 1; i < ss.Length; i++)
                if (ss[i].Length > max)
                    max = ss[i].Length;
            return max;
        }
        static public string RemoveEnd(string msg, char c)
        {
            string pattern = String.Format(@"[^{0}]$", c);
            Regex reg = new Regex(pattern);

            string[] ss = msg.Split(' ');

            List<string> list = new List<string>();
            foreach (string s in ss)
                if (reg.IsMatch(s))
                    list.Add(s + " ");

            string result = "";
            foreach (string s in list)
                result += s;
            result = result.TrimEnd(' ');
            return result;
        }
        static public string FindLongestWord(string msg)
        {
            string[] ss = msg.Split(' ');

            int max = FindMaxLength(ss);

            for (int i = 0; i < ss.Length; i++)
                if (ss[i].Length == max)
                    return ss[i];

            return ss[0];
        }

        static public StringBuilder GetLongestWords(string msg)
        {
            string[] ss = msg.Split(' ');
            StringBuilder sb = new StringBuilder();

            int max = FindMaxLength(ss);

            for (int i = 0; i < ss.Length; i++)
                if (ss[i].Length == max)
                    sb.Append(ss[i] + " ");

            sb.Remove(sb.Length - 1, 1);
            return sb;
        }
        static public Dictionary<string, int> CountWords(string[] words, string text)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string pattern = String.Format(@"{0}\b", word);
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                dic.Add(word, (regex.Matches(text)).Count);
            }
            return dic;
        }
        static public bool IsReversed(string s1, string s2)
        {
            char[] chars1 = s1.ToLower().ToCharArray();
            char[] chars2 = s2.ToLower().ToCharArray();
            Array.Reverse(chars1);
            if (chars1.Length == chars2.Length)
            {
                for (int i = 0; i < chars1.Length; i++)
                    if (chars1[i] != chars2[i])
                        return false;
            }
            else
                return false;
            return true;
        }
    }
}
