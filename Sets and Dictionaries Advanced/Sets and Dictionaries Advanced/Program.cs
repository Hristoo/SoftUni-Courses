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

            HashSet<string> setUsers = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {

                setUsers.Add(Console.ReadLine());
            }

            foreach (var userName in setUsers)
            {
                Console.WriteLine(userName);
            }
            
        }
    }
}
