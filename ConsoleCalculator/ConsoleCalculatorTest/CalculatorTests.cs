using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;

namespace ConsoleCalculatorTest
{
    [TestClass]
    public class CalculatorTests
    {
        // Calculation Tests:
        [TestMethod]
        public void TestEnsureICanAddTwoNumbers()
        {
            Assert.AreEqual(Calculation.Addition(3, 2), 5);
        }

        [TestMethod]
        public void TestEnsureICanSubstractTwoNumbers()
        {
            Assert.AreEqual(Calculation.Substraction(3, 2), 1);
        }

        [TestMethod]
        public void TestEnsureICanMultiplyTwoNumbers()
        {
            Assert.AreEqual(Calculation.Multiplication(3, 2), 6);
        }

        [TestMethod]
        public void TestEnsureICanDivideTwoNumbers()
        {
            Assert.AreEqual(Calculation.Division(3, 2), 1);
        }

        [TestMethod]
        public void TestEnsureICanModuloTwoNumbers()
        {
            Assert.AreEqual(Calculation.Modulus(3, 2), 1);
        }
    }
}
