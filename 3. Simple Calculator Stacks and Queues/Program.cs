using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Simple_Calculator_Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine().Split();
            var stack = new Stack<string>(expression.Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string action = stack.Pop();
                int second = int.Parse(stack.Pop());

                var tempResult = 0;

                if (action == "+") tempResult = first + second;

                else if (action == "-") tempResult = first - second;

                stack.Push(tempResult.ToString());
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
