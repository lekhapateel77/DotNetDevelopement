using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericsLearning.tests
{
    [TestClass]
    public class StackTests
    {

        [TestMethod]
        public void Can_Peek_AT_Next_Item()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(1, stack.Peek());

        }
        [TestMethod]
        public void Can_Search_With_Contains()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.IsTrue(stack.Contains(3));
        }
        [TestMethod]
        public void Can_Convert_Queue_To_Array()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var asArray = stack.ToArray();
            stack.Pop();
            Assert.AreEqual(1, asArray[0]);
            Assert.AreEqual(2, stack.Count);
        }
    }
}

