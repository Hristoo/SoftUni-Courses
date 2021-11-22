using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> isLargerOrEqualToNameASCII = (name, asciiSum)
                 => name.Sum(x => x) >= asciiSum;

            Func<List<string>, Func<string, int, bool>, string> desiredName = (allNames, func)
                => allNames.FirstOrDefault(x => func(x, n));

            Console.WriteLine(desiredName(names, isLargerOrEqualToNameASCII));
        }
    }
}
