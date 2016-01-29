using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public static class Calculation
    {
        public static int Answer;

        public static int Addition(int firstNumber, int secondNumber)
        {
            Answer = firstNumber + secondNumber;
            Stack.LastAnswer = Answer;
            return Answer;
        }

        public static int Substraction(int firstNumber, int secondNumber)
        {
            Answer = firstNumber - secondNumber;
            Stack.LastAnswer = Answer;
            return Answer;
        }

        public static int Multiplication(int firstNumber, int secondNumber)
        {
            Answer = firstNumber * secondNumber;
            Stack.LastAnswer = Answer;
            return Answer;
        }

        public static int Division(int firstNumber, int secondNumber)
        {
            Answer = firstNumber / secondNumber;
            Stack.LastAnswer = Answer;
            return Answer;
        }

        public static int Modulus(int firstName, int secondName)
        {
            Answer = firstName % secondName;
            Stack.LastAnswer = Answer;
            return Answer;
        }
    }
}
