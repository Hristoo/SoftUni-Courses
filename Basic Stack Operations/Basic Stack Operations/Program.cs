using System;
using System.Linq;
using System.Collections.Generic;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] stackInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = input[0];
            int s = input[1];
            int x = input[2];

            int smallest = 0;

            bool isFund = false;


            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                    stack.Push(stackInput[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stack.TryPop(out stackInput[i]);
            }

            if (stack.Count > 0)
            {
                smallest = stack.Peek();
            }

            foreach (var item in stack)
            {
                if (x == item)
                {
                    isFund = true;
                    
                    break;
                }
                else 
                {
                    if (item < smallest)
                    { 
                        smallest = item; 
                    }
                      
                }
            }

            if (isFund)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(smallest);
            }
        }
    }
}
