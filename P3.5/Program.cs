using System;
using System.Collections.Generic;

namespace P3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a progrm to sort a stack
            var random = new Random();
            //The stack should contain at least one element
            Stack<int> originalStack = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                var element = random.Next(100);
                Console.Write($",{element}");
                originalStack.Push(element);
            }
            Console.Write("\n");
            OrderStack(originalStack);
        }

        static void OrderStack(Stack<int> originalStack)
        {
            Stack<int> auxStack = new Stack<int>();
            int temp;
            auxStack.Push(originalStack.Pop());

            while (originalStack.Count > 0)
            {
                temp = originalStack.Pop();

                while (auxStack.Count > 0 && temp > auxStack.Peek())
                {
                    originalStack.Push(auxStack.Pop());
                }

                auxStack.Push(temp);
            }

            //check
            while (auxStack.Count > 0)
            {
                Console.WriteLine(auxStack.Pop());
            }
        }
    }
}
