using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Calculator
    {
        private static string[] operatorChars = { "+", "-", "*", "/" };

        private static bool IsOperator(string op)
        {
            return operatorChars.Contains(op);
        }
        private static bool IsNumber(string op)
        {
            try
            {
                float.Parse(op);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private static string Sum(string num1, string num2)
        {
            return (float.Parse(num1) + float.Parse(num2)).ToString();
        }
        private static string Multiply(string num1, string num2)
        {
            return (float.Parse(num1) * float.Parse(num2)).ToString();
        }
        private static string Devide(string num1, string num2)
        {
            return (float.Parse(num2) / float.Parse(num1)).ToString();
        }
        private static string Subtraction(string num1, string num2)
        {
            return (float.Parse(num2) - float.Parse(num1)).ToString();
        }
        private static string operate(string num1, string num2, string op)
        {
            switch (op)
            {
                case "+":
                    return Sum(num1, num2);
                case "-":
                    return Subtraction(num1, num2);
                case "*":
                    return Multiply(num1, num2);
                case "/":
                    return Devide(num1, num2);
                default:
                    return num1;
            }
        }
        private static float calculatleFromPostFixRecord(IQueue<string> postFixQueue)
        {
            Stack<string> stack = new Stack<string>();
            string value;
            while (!postFixQueue.IsEmpty())
            {
                value = postFixQueue.DeQueue();
                if (IsNumber(value))
                {
                    stack.Push(value);
                }
                else if (IsOperator(value))
                {
                    stack.Push(operate(stack.Pop(), stack.Pop(), value));
                }

            }
            return float.Parse(stack.GetTop());
        }
        public static float calculate(string query)
        {
            IQueue<string> inFixQueue = Parser.Parse(query);
            IQueue<string> postFixQueue = PostFixMaker.FromInFix(inFixQueue);

            return calculatleFromPostFixRecord(postFixQueue);
        }
    }
}
