using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Parser
    {
        private static char[] brackets = { '(', ')' };
        private static char[] operatorChars = { '+', '-', '*', '/'};
        public static bool IsOperator(char op)
        {
            return operatorChars.Contains(op);
        }
        public static bool IsBracket(char op)
        {
            return brackets.Contains(op);
        }
        public static ArrayQueue<string> Parse(string query)
        {
            string currentNumer = "";
            ArrayQueue<string> queue = new ArrayQueue<string>();
            foreach (char ch in query)
            {
                if (char.IsDigit(ch))
                {
                    currentNumer += ch;
                    continue;
                }
                else
                {
                    if (currentNumer != "")
                    {
                        queue.EnQueue(currentNumer);
                        currentNumer = "";
                    }
                }

                if (IsOperator(ch))
                {
                    queue.EnQueue(ch.ToString());
                }

                else if (ch == ' ') { }

                else if (IsBracket(ch)) { queue.EnQueue(ch.ToString()); }

                else { throw new Exception("Wrong char " + ch); }

            }
            if (currentNumer != "")
                queue.EnQueue(currentNumer);
            return queue;
        }
    }
}
