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
    public class HashsetTests
    {
        [TestMethod]
        public void Intersect_Sets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };
            set1.IntersectWith(set2);
            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));
        }
        [TestMethod]
        public void Union_Sets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };
            set1.UnionWith(set2);
            Assert.IsTrue(set1.SetEquals(new[] {1, 2, 3, 4}));
        }
        [TestMethod]
        public void SymmetricExceptWith_Sets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };
            set1.SymmetricExceptWith(set2);
            Assert.IsTrue(set1.SetEquals(new[] { 1, 2, 3, 4 }));
        }
    }
}

