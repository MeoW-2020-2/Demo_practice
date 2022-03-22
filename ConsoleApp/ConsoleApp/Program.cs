using System;
using System.Collections.Generic;
using TestClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass.WriteTest();

            ListOfMarks.MarksList();

            Console.ReadKey();
        }
    }

    public class ListOfMarks
    {
        public static void MarksList()
        {
            //students
            Students student1 = new Students();
            student1.fio = "Иванов И. И.";

            Students student2 = new Students();
            student2.fio = "Петров П. П.";

            Students student3 = new Students();
            student3.fio = "Сидоров С. С.";

            List<string> students = new List<string>();
            students.Add(student1.fio);
            students.Add(student2.fio);
            students.Add(student3.fio);

            //marks
            Marks mark1 = new Marks();
            mark1.date = new DateTime(2022, 03, 23);
            mark1.student = "Иванов И. И.";
            mark1.Estimation = "5";

            List<Marks> marks = new List<Marks>();
            marks.Add(mark1);

            //datetime
            for (int i = 0; i < 10; i++)
            {
                DateTime currentDate = DateTime.Now;
                DateTime addDay = currentDate.AddDays(i);
                Console.WriteLine(addDay.ToString("dd/MM/yyyy"));
                for (int j = 0; j < students.Count; j++)
                {
                    Console.WriteLine($"ФИО: {students[j]}");
                }
                Console.WriteLine();
            }
        }
    }

    public class Students
    {
        public int year;
        public int group;
        public string fio;
    }

    public class Marks
    {
        public DateTime date;
        public string Estimation;
        public string student;
    }

}
