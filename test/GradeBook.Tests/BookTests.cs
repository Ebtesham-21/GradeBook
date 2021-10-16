using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculateAnAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(39.1);
            book.AddGrade(69.1);



            //act
            var result = book.GetStatistics();

            //assert +  sesh perameter ta unitest frame work er feture, jeta dosomik er porer ghor koyta bojhay
            Assert.Equal(65.76, result.Avarage, 1);
            Assert.Equal(89.10, result.High, 1);
            Assert.Equal(39.10, result.Low, 1);
            Assert.Equal('B', result.Letter);

        }
    }
}
