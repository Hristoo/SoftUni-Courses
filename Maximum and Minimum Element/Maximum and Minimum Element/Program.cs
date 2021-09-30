using System;
using System.Linq;
using System.Collections.Generic;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] qInput;

            int command = 0;
            int element = 0;

            int smallest = 109;
            int biggest = 0;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string t = Console.ReadLine();
                bool isNumeric = int.TryParse(t, out _);

                if (!isNumeric)
                {
                    qInput = t.Split().Select(int.Parse).ToArray();

                    command = qInput[0];
                    if (qInput.Length > 1)
                    {
                        element = qInput[1];
                    }
                }
                else
                {
                    command = int.Parse(t);
                }

                if (command == 1)
                {
                    stack.Push(element);
                }
                else if (command == 2)
                {
                    stack.TryPop(out element);
                }
                else if (stack.Count > 0 && command == 3)
                {
                    foreach (var item in stack)
                    {

                        if (item > biggest)
                        {
                            biggest = item;
                        }
                    }
                    Console.WriteLine(biggest);
                }
                else if (stack.Count > 0 && command == 4)
                {
                    foreach (var item in stack)
                    {
                        if (item < smallest)
                        {
                            smallest = item;
                        }
                    }
                    Console.WriteLine(smallest);
                }
            }

                Console.Write(string.Join(", ", stack));
            
        }
    }
}


