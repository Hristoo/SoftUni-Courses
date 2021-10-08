using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int inputQ = int.Parse(Console.ReadLine());
            int counterR = 0;
            int counterS = 0;
            int res = 0;

            Stack<int> racks = new Stack<int>(input);

            while (racks.Any())
            {
                int current = racks.Peek();
                counterS += current;
                if (counterS < inputQ)
                {
                    res += current;
                    racks.Pop();
                    continue;
                }
                else if (counterS == inputQ)
                {
                    counterS = 0;
                    counterR++;
                    racks.Pop();
                }
                else if (counterS > inputQ)
                {
                        counterS = 0;
                        counterS += current;
                        counterR++;
                    racks.Pop();
                }
                
            }
            if (res > 0)
            {
                counterR++;
                Console.WriteLine(counterR);
            }
            else
            {
                Console.WriteLine(counterR);
            }
        }
    }
}
