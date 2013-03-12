using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _4.TestEqualNumber
{
    [TestClass]
    public class TestEqualNumber
    {
        [TestMethod]

        public void TestEqualTwoMembers()
        {
            int[] arr = { 5, 5, 5 };
            
            EqualNumberInArray.EqualMembersInArray(arr, 5);
            Assert.AreEqual(arr, 3);
        }

        [TestMethod]
        public void TestEqualMembers()
        {
            int[] arr = { 5, 5, 6, 7, 8, 9, 10, 11};
            EqualNumberInArray.EqualMembersInArray(arr, 5);
            Assert.AreEqual(arr, 2);
        }
    }
}
