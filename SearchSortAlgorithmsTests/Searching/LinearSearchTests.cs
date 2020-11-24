using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchSortAlgorithms.Searching;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchSortAlgorithms.Searching.Tests
{
    [TestClass()]
    public class LinearSearchTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 3, 2, 5, 8 }, 5, 2, DisplayName = "Simple search")]
        [DataRow(new int[] { 6, 2, 753, 51, 653, 86545 }, 653, 4, DisplayName = "Longer search")]
        [DataRow(new int[] { 3, 2, 5, 8 }, 55, -1, DisplayName = "Fail search")]
        public void LinearSearchIntTest(int[] arr, int elem, int pos)
        {
            var result = arr.LinearSearch(elem);

            Assert.AreEqual(pos, result);
        }

        [DataTestMethod]
        [DataRow(new string[] { "a", "b", "ab", "ba" }, "ab", 2, DisplayName = "Simple search")]
        [DataRow(new string[] { "a", "b", "ab", "ba" }, "abc", -1, DisplayName = "Fail search")]
        public void LinearSearchStringTest(string[] arr, string elem, int pos)
        {
            var result = arr.LinearSearch(elem);

            Assert.AreEqual(pos, result);
        }
    }
}