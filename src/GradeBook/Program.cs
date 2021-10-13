using System;
using System.Collections.Generic;


namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("scootts");
            book.AddGrade(20.5);
            book.AddGrade(25.5);
            book.AddGrade(10.5);
            book.ShowStatistics();
        }
    }
}
