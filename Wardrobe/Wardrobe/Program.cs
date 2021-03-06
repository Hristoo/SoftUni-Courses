using System;
using System.Linq;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split(" -> ");
                string color = inputArgs[0];
                string[] clothes = inputArgs[1].Split(',');

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                    }

                    wardrobe[color][item]++;
                }
            }

            string[] targetClothe = Console.ReadLine().Split();

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var (clothes, value) in color.Value)
                {
                    if (clothes == targetClothe[1] && color.Key == targetClothe[0])
                    {
                        Console.WriteLine($"* {clothes} - {value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes} - {value}");
                    }
                }
            }
        }
    }
}
