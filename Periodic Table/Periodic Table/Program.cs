using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dictionaries_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> setUsers = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split().ToArray();

                foreach (var element in elements)
                {
                    setUsers.Add(element);
                }
                
            }


                Console.WriteLine(string.Join(" ", setUsers));


        }
    }
}
