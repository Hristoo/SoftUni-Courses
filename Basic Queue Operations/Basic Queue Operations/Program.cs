using System;
using System.Linq;
using System.Collections.Generic;

namespace Basic_Queue_Operations
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


            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(stackInput[i]);
            }
            for (int i = 0; i < s; i++)
            {
                queue.TryDequeue(out stackInput[i]);
            }

            if (queue.Count > 0)
            {
                smallest = queue.Peek();
            }

            foreach (var item in queue)
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
