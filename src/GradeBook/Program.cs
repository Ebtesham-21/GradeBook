using System;
using System.Collections.Generic;


namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("scootts");



            while (true)
            {
                Console.WriteLine("Enter a grade or 'q to quit")
                 var input = Console.ReadLine();
                if (input == "q")
                {
                    break;

                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);

                }



            }




            var stats = book.GetStatistics();
            System.Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"avarage grade is {stats.Avarage:N2}");
            Console.WriteLine($"avarage grade is {stats.Letter}");
        }
    }
}
