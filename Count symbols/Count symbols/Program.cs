using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dictionaries_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charArr = input.ToCharArray();

            SortedDictionary<char, int> chars= new SortedDictionary<char, int>();


            foreach (char ch in charArr)
            {
                if (!chars.ContainsKey(ch))
                {
                    chars.Add(ch, 0);
                }
                chars[ch]++;
            }
            
            foreach (var ch in chars)

                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
        }
    }
}
