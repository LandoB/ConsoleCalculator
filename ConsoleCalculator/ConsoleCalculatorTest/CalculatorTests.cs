using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;

namespace ConsoleCalculatorTest
{
    [TestClass]
    public class CalculatorTests
    {
        private Stack addToStack;
        private Evaluate myEvaluations;

        [TestInitialize]
        public void Initialize()
        {
            addToStack = new Stack();
            myEvaluations = new Evaluate();
        }

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

        // Parse tests:
        [TestMethod] 
         public void TestEnsureICanParseTermsFromExpression()
         { 
             BasicTasks doSomething = new BasicTasks(); 
             doSomething.IdentifyOperator("3+2"); 
             Assert.AreEqual(doSomething.firstNumber, 3); 
             Assert.AreEqual(doSomething.secondNumber, 2); 
             Assert.AreEqual(doSomething.myDelimeter, '+'); 
         } 
 
 
         [TestMethod] 
         [ExpectedException(typeof(ArgumentException))] 
         public void TestEnsureItWillThrowErrorForIncorrectExpression()
         { 
             BasicTasks doSomething = new BasicTasks(); 
             doSomething.IdentifyOperator("3+"); 
         }

        // Dictionary tests:
        [TestMethod]
        public void TestEnsureICanSuccessfullyAddConstantsToDictionary()
        {
            addToStack.SetTheConstant("x", 3);
            Assert.IsTrue(addToStack.ConstantHolder.ContainsKey("x"));
            Assert.IsTrue(addToStack.ConstantHolder.ContainsValue("3"));
        }

        [TestMethod]
        public void TestEnsureICanSuccessfullyRetrieveConstantsFromDictionary()
        {
            addToStack.SetTheConstant("y", 2);
            string firstNumber = "y";
            string expected = "2";
            string actual = addToStack.RetrievingConstant(firstNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEnsureItWillThrowErrorForNotFoundValue()
        {
            addToStack.RetrievingConstant("y");
        }

        // Evaluation tests:
        [TestMethod]
        public void TestEnsureICanGetCorrectAnswersFromInput()
        {
            Assert.AreEqual(myEvaluations.EvaluateThis("3+2"), 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEnsureItWillThrowErrorForIncorrectEvaluationExpression()
        {
            myEvaluations.EvaluateThis("3+");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEnsureItWillThrowErrorForDifferentIncorrectEvaluationExpression()
        {
            myEvaluations.EvaluateThis("/3");
        }


        }
    }
