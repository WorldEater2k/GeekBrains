using System;
using System.Collections.Generic;
using System.IO;

namespace Task3
{
    /* Переделать программу Пример использования коллекций для решения следующих задач:
    а) Подсчитать количество студентов, учащихся на 5 и 6 курсах;
    б) Подсчитать, сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
    в) Отсортировать список по возрасту студента;
    г) *Отсортировать список по курсу и возрасту студента.

    Автор: Бутырская Е. */
    class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }
        public string Department { get; set; }
        public int Group { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            LastName = lastName;
            FirstName = firstName;
            University = university;
            Faculty = faculty;
            Department = department;
            Course = course;
            Age = age;
            Group = group;
            City = city;
        }
    }
    class Program
    {
        static int CompareByAge(Student s1, Student s2)
        {
            return s1.Age == s2.Age ? 0 : s1.Age > s2.Age ? 1 : -1;
        }
        static int CompareByCourseAndAge(Student s1, Student s2)
        {
            if (s1.Course == s2.Course)
            {
                return CompareByAge(s1, s2);
            }
            else
                return s1.Course > s2.Course ? 1 : -1;
        }
        static void Main(string[] args)
        {
            int course5 = 0;
            int course6 = 0;
            List<Student> list = new List<Student>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            StreamReader sr = new StreamReader("students_6.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    // Считываем данные, добавляем студента в список.
                    string[] s = sr.ReadLine().Split(',');
                    int course = int.Parse(s[5]);
                    int age = int.Parse(s[6]);
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], course, age, int.Parse(s[7]), s[8]));

                    // Считаем кол-во студентов 5 и 6 курса.
                    if (course == 5)
                        course5++;
                    else if (course == 6)
                        course6++;

                    // Заносим студентов от 18 до 20 лет в частотный массив.
                    if (age >= 18 && age <= 20)
                    {
                        if (!dic.ContainsKey(course))
                            dic.Add(course, 1);
                        else
                            dic[course] += 1;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка! ESC - прекратить выполнение программы");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                        return;
                }
            }
            sr.Close();

            Console.WriteLine("Всего студентов: " + list.Count);
            Console.WriteLine("На 5 курсе учатся: " + course5);
            Console.WriteLine("На 6 курсе учатся: " + course6);
            foreach (var pair in dic)
                Console.WriteLine($"На {pair.Key} курсе учатся {pair.Value} студентов от 18 до 20 лет.");

            list.Sort(new Comparison<Student>(CompareByAge));
            Console.WriteLine("Сортировка по возрасту: ");
            foreach (Student s in list)
                Console.WriteLine($"{s.FirstName} {s.LastName}, {s.Age}");

            list.Sort(new Comparison<Student>(CompareByCourseAndAge));
            Console.WriteLine("Сортировка по курсу и возрасту: ");
            foreach (Student s in list)
                Console.WriteLine($"{s.FirstName} {s.LastName}, {s.Age}, {s.Course} курс");

            Console.ReadKey();
        }
    }
}
