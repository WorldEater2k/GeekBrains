using System;

namespace Task4
{
     /* *Задача ЕГЭ.
     На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
     В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100,
     каждая из следующих N строк имеет следующий формат: <Фамилия> <Имя> <оценки>,
     где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем
     из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.
     <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
     Иванов Петр 4 5 3
     Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и
     имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики, набравшие тот же средний балл,
     что и один из трёх худших, следует вывести и их фамилии и имена.
     
     Автор: Бутырская Е.Д. */

    class Student
    {
        public string Name { get; }
        public string Surname { get; }

        int[] grades = new int[3];
        public Student(string name, string surname, int grade1, int grade2, int grade3)
        {
            Name = name;
            Surname = surname;
            grades[0] = grade1;
            grades[1] = grade2;
            grades[2] = grade3;
        }
        public double Average
        {
            get
            {
                return (grades[0] + grades[1] + grades[2]) / 3.0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество учеников: ");
            int n = int.Parse(Console.ReadLine());
            Student[] students = new Student[n];
            double[] minGrades = { 5.0, 5.0, 5.0 };
            Console.WriteLine("Введите ФИО и оценки учеников:");

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ');
                students[i] = new Student(info[0], info[1], int.Parse(info[2]),
                                          int.Parse(info[3]), int.Parse(info[4]));
                double average = students[i].Average;
                if (average < minGrades[0])
                {
                    minGrades[1] = minGrades[0];
                    minGrades[0] = average;
                }
                else if (average < minGrades[1])
                {
                    minGrades[2] = minGrades[1];
                    minGrades[1] = average;
                }
                else if (average < minGrades[2])
                    minGrades[2] = average;
            }

            Console.WriteLine("Ученики с самым низким средним баллом:");
            if (minGrades[0] != minGrades[1])
            {
                for (int i = 0; i < n; i++)
                    if (students[i].Average == minGrades[0])
                        Console.WriteLine(students[i].Name + " " + students[i].Surname);
            }

            if (minGrades[1] != minGrades[2])
            {
                for (int i = 0; i < n; i++)
                    if (students[i].Average == minGrades[1])
                        Console.WriteLine(students[i].Name + " " + students[i].Surname);
            }

            for (int i = 0; i < n; i++)
                if (students[i].Average == minGrades[2])
                    Console.WriteLine(students[i].Name + " " + students[i].Surname);

            Console.ReadKey();
        }
    }
}
