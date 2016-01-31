using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

 
namespace ConsoleCalculator
{   
    public class BasicTasks
    { 
        public int firstNumber; 
        public int secondNumber; 
        public char myDelimeter; 
        public string ifItIsChar;
        public Stack calcStack { get; set; }

        public BasicTasks()
        {
            calcStack = new Stack();
        }

        public void IdentifyOperator(string expression)
        {
            var theOperators = new[] { '+', '-', '*', '/', '%', '=' };
            string myCalc = expression;

            string[] parsedInfo = myCalc.Split(theOperators);

            string firstPart = "this";
            string secondPart = "that";

            var founded = myCalc.IndexOfAny(theOperators);
            myDelimeter = myCalc[founded];
            firstPart = parsedInfo[0];
            secondPart = parsedInfo[1];

            
            if (myDelimeter == '=')
            {
                ifItIsChar = firstPart;
                secondNumber = Convert.ToInt32(secondPart);
                return;
            }

            else
            {
                int i = 0;
                bool result = int.TryParse(parsedInfo[0], out i); 
                if (i == 0)
                {
                    //Retrieve the constant's value from the dictionary
                    string getValue = firstPart;
                    string gotValue = calcStack.RetrievingConstant(getValue);
                    firstNumber = Convert.ToInt32(gotValue);

                }
                else
                {
                    firstNumber = Convert.ToInt32(parsedInfo[0]);
                }

                int j = 0;
                bool result2 = int.TryParse(parsedInfo[1], out j); //j will be false if char
                if (j == 0)
                {
                    //Retrieve the constant's value from the dictionary
                    string nextValue = secondPart;
                    string foundValue = calcStack.RetrievingConstant(nextValue);
                    secondNumber = Convert.ToInt32(foundValue);
                }
                else
                {
                    secondNumber = Convert.ToInt32(parsedInfo[1]);
                }
            }
        }

    } 
} 

