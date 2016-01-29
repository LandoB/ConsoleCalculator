using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Calculation
    {
        public static int Answer;

        public static int Addition(int firstNumber, int secondNumber)
        {
            Answer = firstNumber + secondNumber;
            Stack.LastAnswer = Answer;
            return Answer;
        }


    }
}
