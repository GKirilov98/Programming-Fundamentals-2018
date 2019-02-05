using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_04._Average_Grades
{
    class AvarageGrade
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Student student = ReadStudent();
                if (student.Average>= 5.00)
                {
                    students.Add(student);
                }
            }
            foreach (var student in students.OrderBy(x => x.Name).ThenByDescending(x => x.Average))
            {
                Console.WriteLine($"{student.Name} -> {student.Average:f2}");
            }
        }

        static Student ReadStudent()
        {
            string[] tokens = Console.ReadLine().Split();
            string name = tokens[0];
            List<double> grades = new List<double>();
            for (int i = 1; i < tokens.Length ; i++)
            {
                grades.Add(double.Parse(tokens[i]));
            }

            Student student = new Student(name, grades);
            return student;
        }
    }

    class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double Average { get; set; }

        public Student(string name, List<double> grades)
        {
            this.Name = name;
            this.Grades = grades;
            double sum = 0;
            for (int i = 0; i < grades.Count; i++)
            {
                sum += grades[i];
            }

            this.Average = sum / grades.Count;
        }
    }
}
