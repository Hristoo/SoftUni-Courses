using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int inpuntNumber = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(inpuntNumber))
                {
                    numbers.Add(inpuntNumber, 0);
                }
                numbers[inpuntNumber]++;
            }

            foreach (var (key, value) in numbers)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(key);
                    break;
                }
            }
        }
    }
}
