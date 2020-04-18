using System;
using Xunit;
using Gradebook;

namespace Gradebook.Tests
{
    public class Booktests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new InMemoryBook("");
            book.Addgrade(91.2);
            book.Addgrade(93.2);
            book.Addgrade(98.2);
           // book.Addgrade(105);

            //act
            var result = book.Getstatistics();
            //assert
            Assert.Equal(91.2, result.lowgrade);
            Assert.Equal(98.2, result.highgrade, 1);
            Assert.Equal(94.2, result.average, 1);
            Assert.Equal('A', result.letter);

            //Assert.Equal("Invalid Grade", result.average);


        }
    }
}
