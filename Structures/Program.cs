using System;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = new DConnectedList<int>();
            list.Insert(0, 1);
            list.Insert(1, 3);
            list.Insert(2, 4);
            list.Insert(3, 5);
            list.Insert(3, 6);
            list.Insert(1, 7);
            Console.Write(list.Retrive(0));
            Console.Write(list.Retrive(1));
            Console.Write(list.Retrive(2));
            Console.Write(list.Retrive(3));
            Console.Write(list.Retrive(4));
            Console.Write(list.Retrive(5));
            Console.Write(list.Find(6));
            Console.WriteLine();
            
            IQueue<string> queue = new ArrayQueue<string>();
            queue.EnQueue("s");
            queue.EnQueue("v");
            queue.EnQueue("c");

            Console.Write(queue.DeQueue());
            Console.Write(queue.DeQueue());
            queue.EnQueue("d");
            Console.Write(queue.DeQueue());
            Console.Write(queue.DeQueue());
            Console.WriteLine();


            IStack<string> stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            Console.Write(stack.Pop());
            Console.Write(stack.Pop());
            stack.Push("d");
            Console.WriteLine(stack.GetTop());
            Console.WriteLine(stack.GetTop());
            Console.Write(stack.Pop());
            Console.Write(stack.Pop());
            Console.WriteLine();
            IQueue<string> q_queue =  Parser.Parse(" 5*6+(2-9)");
            Console.WriteLine();
            try
            {
                string input;
                Console.Write("Enter calculation query: ");
                input = Console.ReadLine();
                Console.Write("Answer: ");
                Console.WriteLine(Calculator.calculate(input));
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
