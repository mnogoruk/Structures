using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class PostFixMaker
    {
        private static string[] operatorChars = { "+", "-", "*", "/" };

        public static bool IsOperator(string op)
        {
            return operatorChars.Contains(op);
        }
        public static bool IsNumber(string op)
        {
            try
            {
                int.Parse(op);
                return true;
            } catch (FormatException)
            {
                return false;
            }
        }
        public static int OpRang(string op)
        {
            switch (op)
            {
                case "+":
                    return 1;
                case "-":
                    return 1;
                case "*":
                    return 2;
                case "/":
                    return 2;
                default:
                    return -1;
            }
        }

        private static void UnloadStackByRang(IStack<string> stack, IQueue<string> queue, string value)
        {
            string top;
            while (OpRang(value) <= OpRang(stack.GetTop())){
                top = stack.Pop();
                queue.EnQueue(top);
                if (stack.IsEmpty())
                    break;
            }

        }
        private static void UnloadWhileNotLeftBracket(IStack<string> stack, IQueue<string> queue)
        {
            string top;
            while(stack.GetTop() != "(")
            {
                top = stack.Pop();
                queue.EnQueue(top);
            }
            stack.Pop();
        }
        private static void UnloadStack(IStack<string> stack, IQueue<string> queue)
        {
            string top;
            while (!stack.IsEmpty())
            {
                top = stack.Pop();
                queue.EnQueue(top);
            }
        }
        public static ArrayQueue<string> FromInFix(IQueue<string> queryQueue)
        {
            Stack<string> stack = new Stack<string>();
            ArrayQueue<string> queue = new ArrayQueue<string>();

            string value;
            while (!queryQueue.IsEmpty())
            {
                value = queryQueue.DeQueue();
                if (IsNumber(value))
                {
                    queue.EnQueue(value);
                } else if (IsOperator(value))
                {
                    if (stack.IsEmpty())
                    {
                        stack.Push(value);
                    }
                    else if (stack.GetTop() == "(")
                    {
                        stack.Push(value);
                    }
                    else if (OpRang(value) > OpRang(stack.GetTop()))
                    {
                        stack.Push(value);
                    } else
                    {
                        UnloadStackByRang(stack, queue, value);
                        stack.Push(value);
                    }
                }
                else if (value == "(")
                {
                    stack.Push(value);
                }
                else if (value == ")")
                {
                    UnloadWhileNotLeftBracket(stack, queue);
                }
            }

            UnloadStack(stack, queue);
            return queue;
        }


    }
}
