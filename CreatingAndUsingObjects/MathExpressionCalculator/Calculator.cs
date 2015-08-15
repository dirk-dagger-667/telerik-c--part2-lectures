using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressionCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            string inputEpxpression = "3 + 4 * 2 / pow(pow(( 1 - 5 ), 2), 3)";
            inputEpxpression = inputEpxpression.Trim(new Char[] { ' ', '*', '+', '-', '/', '=' });
            Queue<string> outputQueue = new Queue<string>();
            Stack<string> operatorStack = new Stack<string>();
            string currentToken = "";
            int precedence = 0;

            for (int i = 0; i < inputEpxpression.Length; i++)
            {
                string currentSymbol = inputEpxpression[i].ToString();

                if (IsDigit(currentSymbol) == true || currentSymbol == "l" || currentSymbol == "n" || currentSymbol == "s" ||
                    currentSymbol == "q" || currentSymbol == "r" || currentSymbol == "t" || currentSymbol == "p" ||
                    currentSymbol == "o" || currentSymbol == "w")
                {
                    currentToken += currentSymbol;
                }
                else if (currentSymbol == "." && IsDigit(inputEpxpression[i - 1].ToString()) == true && IsDigit(inputEpxpression[i + 1].ToString()))
                {
                    currentToken += currentSymbol;
                }
                else if (currentSymbol == ",")
                {
                    for (int k = 0; k < operatorStack.Count; k++)
                    {
                        if (operatorStack.Peek() != "(")
                        {
                            outputQueue.Enqueue(operatorStack.Pop());
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if (currentSymbol == " ")
                {
                    continue;
                }
                else if (IsOperator(currentSymbol) == true)
                {
                    precedence = EvaluatingPrecedence(currentSymbol);
                    outputQueue.Enqueue(currentToken);
                    currentToken = currentSymbol;

                    if (operatorStack.Count > 0)
                    {
                        for (int j = 0; j < operatorStack.Count; j++)
                        {
                            if (precedence <= EvaluatingPrecedence(operatorStack.Peek()))
                            {
                                outputQueue.Enqueue(operatorStack.Pop());
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    operatorStack.Push(currentToken);
                    currentToken = "";
                }
                else if (currentSymbol == "(")
                {
                    operatorStack.Push(currentSymbol);
                    currentToken = "";
                }
                else if (currentSymbol == ")")
                {
                    outputQueue.Enqueue(currentToken);

                    for (int m = 0; m < operatorStack.Count; m++)
                    {
                        if (operatorStack.Peek() == "(")
                        {
                            operatorStack.Pop();
                            break;
                        }
                        else
                        {
                            outputQueue.Enqueue(operatorStack.Pop());
                        }
                    }

                    currentToken = "";
                }

                if (IsFunction(currentToken) == true)
                {
                    operatorStack.Push(currentToken);
                    currentToken = "";
                }

                if (i == inputEpxpression.Length - 1)
                {
                    for (int l = 0; l < operatorStack.Count; l++)
                    {
                        if (operatorStack.Peek() == "(")
                        {
                            Console.WriteLine("mismached parenthesis");
                            return;
                        }
                        else
                        {
                            outputQueue.Enqueue(operatorStack.Pop());
                        }
                    }

                    outputQueue.Enqueue(operatorStack.Pop());
                }
            }

            /*for (int i = 0; i < queueToArray.Length; i++)
            {
                Console.WriteLine(i);
            }*/

            string[] queueToArray = outputQueue.ToArray();

            if (queueToArray.Length > 2)
            {
                for (int i = 0; i < queueToArray.Length; i++)
                {
                    switch (queueToArray[i])
                    {
                        case "+":
                            queueToArray[i - 2] = Addition(double.Parse(queueToArray[i - 2]), double.Parse(queueToArray[i - 1])).ToString();
                            RearrangingArray(queueToArray, i, queueToArray[i]);
                            i = 0;
                            break;
                        case "-":
                            queueToArray[i - 2] = Substraction(double.Parse(queueToArray[i - 2]), double.Parse(queueToArray[i - 1])).ToString();
                            RearrangingArray(queueToArray, i, queueToArray[i]);
                            i = 0;
                            break;
                        case "/":
                            queueToArray[i - 2] = Division(double.Parse(queueToArray[i - 2]), double.Parse(queueToArray[i - 1])).ToString();
                            RearrangingArray(queueToArray, i, queueToArray[i]);
                            i = 0;
                            break;
                        case "*":
                            queueToArray[i - 2] = Multiplication(double.Parse(queueToArray[i - 2]), double.Parse(queueToArray[i - 1])).ToString();
                            RearrangingArray(queueToArray, i, queueToArray[i]);
                            i = 0;
                            break;
                        case "ln":
                            queueToArray[i - 1] = Math.Log(double.Parse(queueToArray[i - 1])).ToString();
                            RearrangingArray(queueToArray, i, queueToArray[i]);
                            i = 0;
                            break;
                        case "pow":
                            queueToArray[i - 2] = Math.Pow(double.Parse(queueToArray[i - 2]), double.Parse(queueToArray[i - 1])).ToString();
                            RearrangingArray(queueToArray, i, queueToArray[i]);
                            i = 0;
                            break;
                        case "sqrt":
                            queueToArray[i - 1] = Math.Sqrt(double.Parse(queueToArray[i - 1])).ToString();
                            RearrangingArray(queueToArray, i, queueToArray[i]);
                            i = 0;
                            break;
                    }
                }
            }
            else if (queueToArray.Length == 2)
            {
                Console.WriteLine("Error, no operators!!!");
            }
            else
            {
                Console.WriteLine(queueToArray[0]);
            }

            if (queueToArray[1] == "")
            {
                Console.WriteLine("The answer is : {0}", queueToArray[0]);
            }
            else
            {
                Console.WriteLine("There's soemthing wrong!!!");
            }
        }

        public static bool IsDigit(string currentToken)
        {
            int n;
            bool isNumeric = int.TryParse(currentToken, out n);
            return isNumeric;
        }

        public static bool IsOperator(string currentToken)
        {
            switch (currentToken)
            {
                case "+":
                    return true;
                case "-":
                    return true;
                case "*":
                    return true;
                case "/":
                    return true;
                default:
                    return false;
            }
        }

        public static int EvaluatingPrecedence(string operatorString)
        {
            switch (operatorString)
            {
                case "+":
                    return 2;
                case "-":
                    return 2;
                case "*":
                    return 3;
                case "/":
                    return 3;
                default:
                    return 0;
            }
        }

        public static bool IsFunction(string function)
        {
            switch (function)
            {
                case "ln":
                    return true;
                case "sqrt":
                    return true;
                case "pow":
                    return true;
                default:
                    return false;
            }
        }

        public static double Addition(double op1, double op2)
        {
            return op1 + op2;
        }

        public static double Substraction(double op1, double op2)
        {
            return op1 - op2;
        }

        public static double Multiplication(double op1, double op2)
        {
            return op1 * op2;
        }

        public static double Division(double op1, double op2)
        {
            return op1 / op2;
        }

        public static string[] RearrangingArray(string[] arrayForRearranging, int counter, string function)
        {
            if (function == "sqrt" || function == "ln")
            {
                for (int i = counter + 1; i < arrayForRearranging.Length - 1; i++)
                {
                    arrayForRearranging[i] = arrayForRearranging[i + 1];
                }

                arrayForRearranging[arrayForRearranging.Length - 1] = "";
            }
            else
            {
                for (int i = counter; i < arrayForRearranging.Length - 2; i++)
                {
                    arrayForRearranging[i - 1] = arrayForRearranging[i + 1];
                }
            }

            arrayForRearranging[arrayForRearranging.Length - 3] = arrayForRearranging[arrayForRearranging.Length - 1];
            arrayForRearranging[arrayForRearranging.Length - 2] = "";
            arrayForRearranging[arrayForRearranging.Length - 1] = "";
            return arrayForRearranging;
        }
    }
}
