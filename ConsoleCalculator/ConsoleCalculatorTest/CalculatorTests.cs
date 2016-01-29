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
    }
}
