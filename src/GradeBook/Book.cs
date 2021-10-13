using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;

        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public void ShowStatistics()
        {
            var results = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var number in grades)
            {
                lowGrade = System.Math.Min(number, lowGrade);
                highGrade = System.Math.Max(number, highGrade);
                results += number;
            }
            results /= grades.Count;
            System.Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"avarage grade is {results:N2}");

        }

        private List<double> grades;
        private string name;




    }
}
