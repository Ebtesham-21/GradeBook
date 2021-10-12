using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {


            var numbers = new[] { 12.7, 10.3, 6.11 };


            var results = numbers[0];
            results = results + numbers[1];
            results = results + numbers[2];
            Console.WriteLine(results);


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
