using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class Stack
    {
        private static int lastanswer;

        public static int LastAnswer
        {
            get { return lastanswer; }
            set { lastanswer = value; }
        }

        private static string lastCommand = "My Command";

        public static string LastCommand
        {
            get { return lastCommand; }

            set { lastCommand = value; }
        }

        public Dictionary<string, string> ConstantHolder = new Dictionary<string, string>();

        public void SetTheConstant(string firstNumber, int secondNumber)
        {
            string secondString = secondNumber.ToString();
            ConstantHolder.Add(firstNumber, secondString);
            return;
        }

        public static string WeFoundValue;
        public string ValNotFound = "Value not found";

        // Retrieving value from dictionary
        public string RetrievingConstant(string firstNumber)
        {
            if (ConstantHolder.TryGetValue(firstNumber, out WeFoundValue))
            {
                return WeFoundValue;
            }
            else
            {
                throw new ArgumentException();
            }
        }

    }
}
