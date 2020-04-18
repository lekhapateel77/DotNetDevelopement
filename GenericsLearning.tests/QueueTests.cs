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
    public class QueueTests
    {

        [TestMethod]
        public void Can_Peek_AT_Next_Item()
        {
            Queue<int> integers = new Queue<int>();
            integers.Enqueue(1);
            integers.Enqueue(2);
            integers.Enqueue(3);
            Assert.AreEqual(1, integers.Peek());

        }
        [TestMethod]
        public void Can_Search_With_Contains()
        {
            Queue<int> integers = new Queue<int> ();
            integers.Enqueue(1);
            integers.Enqueue(2);
            integers.Enqueue(3);
            Assert.IsTrue(integers.Contains(3));
        }
        [TestMethod]
        public void Can_Convert_Queue_To_Array()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var asArray = queue.ToArray();
            queue.Dequeue();
            Assert.AreEqual(1, asArray[0]);
            Assert.AreEqual(2, queue.Count);
        }
    }
}

