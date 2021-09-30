using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(inputCups);
            Stack<int> bottles = new Stack<int>(inputBottles);

            int wastedLiters = 0;

            while (cups.Any() && bottles.Any())
            {
                int currentCup = cups.Peek();
                int currentBottle = bottles.Pop();

                if (currentCup - currentBottle <= 0)
                {
                    wastedLiters += currentCup - currentBottle;
                    cups.Dequeue();
                }
                else
                {
                    currentCup -= currentBottle;
                }
            }
            if (cups.Any())
            {
                Console.WriteLine($"Cuprs: {string.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedLiters}");
        }
    }
}
