using Microsoft.VisualStudio.TestTools.UnitTesting;
using pratice1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest_5_10()
        {
            // arrange
            Calculator target = new Calculator();  // TODO 初始化
            int firsrNumber = 5;
            int secondNumber = 10;
            int expect = 15;
            int actual;
            // act
            actual = target.Add(firsrNumber, secondNumber);
            // assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void MinusTest_50_10()
        {
            // arrange
            Calculator target = new Calculator();  // TODO 初始化
            int firsrNumber = 50;
            int secondNumber = 10;
            int expect = 40;
            int actual;
            // act
            actual = target.Minus(firsrNumber, secondNumber);
            // assert
            Assert.AreEqual(expect, actual);
        }
    }
}