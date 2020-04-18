using System;
using Xunit;
using Gradebook;

namespace Gradebook.Tests
{
    public delegate string WriteDelegateLog(string LogMessage);
    public class TypeTests
    {
        int count = 0;
        [Fact]
        public void WriteDelagateCanPointToMethod()
        {
            WriteDelegateLog log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount;
            var result = log("Hello!");
            Assert.Equal("hello!", result);
            Assert.Equal(3, count);

        }
        string ReturnMessage(string Message)
        {
            count++;
            return Message;
        }

        string IncrementCount(string Message)
        {
            count++;
            return Message.ToLower();
        }

        [Fact]
        public void StringsBehaveLikeVlaueTypes()
        {
            string name = "lekha";
            name = MakeUpperCase(name);

            Assert.Equal("LEKHA", name);

        }
        private string MakeUpperCase(string parameter)
        {
           return parameter.ToUpper();
        }

        [Fact]
        public void CSharpIsPassByRef()
        {
            //arrange
            var book1 = Getbook("Book 1");
            GetBookSetName( book1, "New Name");
            Assert.Equal("New Name", book1.Name);

        }

        //[Fact]
        //public void CSharpIsPassByValue()
        //{
        //    //arrange
        //    var book1 = Getbook("Book 1");
        //   GetBookSetName(ref book1, "New Name");

        //    Assert.Equal("New Name", book1.Name);

        //}
        private void GetBookSetName( InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);//by invoking we are creating a new reference for address book.if passed

        }

        [Fact]
        public void CanSetNameForReference()
        {
            //arrange
            var book1 = Getbook("Book 1");
            SetName(book1,"New Name");
            Assert.Equal("New Name", book1.Name);

        }
        
        private void SetName(InMemoryBook book1, string name)
        {
            //book1 = new Book(name);
            book1.Name= name;
        }

        [Fact]
        public void CanBookRetrunDifferentObjects()
        {
            //arrange
            var book1 = Getbook("Book 1");
            var book2 = Getbook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);

        }

        [Fact]
        public void Test1()
        {
            //arrange
            var book1 = Getbook("Book 1");
            var book2 = book1;

            Assert.Same(book1,book2);
            Assert.True(object.ReferenceEquals(book1,book2));

        }
        InMemoryBook Getbook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
