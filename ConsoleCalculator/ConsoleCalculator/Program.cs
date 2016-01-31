using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            var propeller = true;
            BasicTasks myOperation = new BasicTasks();


            while (propeller)
            {

                string prompt = "[" + counter + "]" + "> ";

                // Saving user's input expression into a variable
                Console.Write(prompt);
                string theExpression = Console.ReadLine();

                switch (theExpression)
                {
                    // Keyword for exiting application
                    case "quit":
                        Console.WriteLine("Bye!");
                        Environment.Exit(1);
                        return;

                    // Keyword for exiting the application
                    case "exit":
                        Console.WriteLine("Bye!");
                        Environment.Exit(1);
                        return;

                    // User entered "last" command
                    case "last":
                        Console.WriteLine(Stack.LastAnswer);
                        break;

                    // User entered "lastq" command
                    case "lastq":
                        Console.WriteLine(Stack.LastCommand);
                        break;

                    // User entered an expression to be evaluated
                    default:

                        // Stashing this away so it's ready if user enters "lastq" command
                        if (theExpression != "lastq" || theExpression != "last")
                        {
                            Stack.LastCommand = theExpression;
                        }

                        // Finding delimeter
                        myOperation.IdentifyOperator(theExpression);
                        Evaluate evaluating = new Evaluate(myOperation);

                        // Determine if we need to send this on for calculation or constant setting
                        switch (myOperation.myDelimeter)
                        {
                            // Will get set as a constant
                            case '=':
                                myOperation.calcStack.SetTheConstant(myOperation.ifItIsChar, myOperation.secondNumber);
                                break;

                            default:
                                evaluating.EvaluateThis(theExpression);

                                // Increment counter with each round
                                counter = counter + 1;
                                Console.WriteLine("= " + Calculation.Answer);
                                break;
                        }
                        break;
                }
            }
        }
    }
}
