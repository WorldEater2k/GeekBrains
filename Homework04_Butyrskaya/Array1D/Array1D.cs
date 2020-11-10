using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace MyArray
{
    public class Array1D
    {
        private int[] arr;
        Random rnd = new Random();
        public Array1D(int n)
        {
            arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(1, 101);
        }
        public Array1D(int size, int start, int step)
        {
            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = start;
                start += step;
            }
        }
        public Array1D(string filename)
        {
            if (File.Exists(filename))
            {
                string[] data = File.ReadAllLines(filename);
                arr = new int[data.Length];
                for (int i = 0; i < data.Length; i++)
                    arr[i] = int.Parse(data[i]);
            }
            else
            {
                Console.WriteLine("Ошибка: файл не найден!");
                arr = null;
            }
        }
        public Array1D(int[] array)
        {
            arr = array;
        }
        public int Max
        {
            get
            {
                return arr.Max();
            }
        }
        public int MaxCount
        {
            get
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] == Max)
                        count++;
                return count;
            }
        }
        public int Sum
        {
            get
            {
                return arr.Sum();
            }
        }
        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        public void Print()
        {
            foreach (int el in arr)
                Console.Write(el + " ");
            Console.WriteLine();
        }
        public Array1D Inverse()
        {
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                arr2[i] = -arr[i];
            return new Array1D(arr2);
        }
        public Array1D Multi(int coeff)
        {
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                arr2[i] = arr[i] * coeff;
            return new Array1D(arr2);
        }
        public SortedDictionary<int, int> CalcFrequency()
        {
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                    dic[arr[i]]++;
                else
                    dic.Add(arr[i], 1);
            }
            return dic;
        }
    }
}