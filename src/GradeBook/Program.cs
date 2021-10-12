using System;
using System.Collections.Generic;


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {



            var grades = new List<double>() { 12.7, 10.3, 6.11 };
            grades.Add(57.1);


            var results = 0.0;
            foreach (var number in grades)
            {
                results += number;
            }
            results /= grades.Count;
            Console.WriteLine($"avarage grade is {results:N2}");




            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }

        }
    }
}
