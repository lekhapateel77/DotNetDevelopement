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
    public class ListTests
    {
      
        [TestMethod]
        public void A_List_Can_Insert()
        {
            List<int> integers = new List<int> { 1, 2, 3 };
            integers.Insert(1, 6);
            Assert.AreEqual(6,integers[1]);

        }
        [TestMethod]
        public void A_List_Can_FindThings()
        {
            List<int> integers = new List<int> { 1, 2, 3 };
            Assert.AreEqual(integers.IndexOf(2),1);
        }
        [TestMethod]
        public void A_List_Can_Remove()
        {
            List<int> integers = new List<int> { 1, 2, 3 };
            integers.Remove(2);
            Assert.IsTrue(integers.SequenceEqual(new [] { 1, 3 }));
        }
    }
}

