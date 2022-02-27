using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void RomanNumberTest()
        {
            RomanNumber num1 = new(14);
            string expected = "XIV";
            string result = num1.ToString();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void RomanNumberZeroTest()
        {
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(0));
        }
        [TestMethod()]
        public void SumTest()
        {
            RomanNumber num1 = new(10), num2 = new(4);
            string expected = "XIV";
            string result = (num1 + num2).ToString();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void SubTest()
        {
            RomanNumber num1 = new(10), num2 = new(4);
            string expected = "VI";
            string result = (num1 - num2).ToString();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void SubExTest()
        {
            RomanNumber num1 = new(10), num2 = new(10);
            Assert.ThrowsException<RomanNumberException>(() => num1 - num2);
        }
        [TestMethod()]
        public void MultTest()
        {
            RomanNumber num1 = new(10), num2 = new(4);
            string expected = "XL";
            string result = (num1 * num2).ToString();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void DivTest()
        {
            RomanNumber num1 = new(10), num2 = new(4);
            string expected = "II";
            string result = (num1 / num2).ToString();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber num1 = new(10);
            RomanNumber num2 = (RomanNumber)num1.Clone();
            string expected = "X";
            Assert.AreEqual(expected, num2.ToString());
        }
        [TestMethod()]
        public void CompareTest()
        {
            RomanNumber num1 = new(10), num2 = new(10);
            int expected = 0;
            int result = num1.CompareTo(num2);
            Assert.AreEqual(expected, result);
        }
    }
}