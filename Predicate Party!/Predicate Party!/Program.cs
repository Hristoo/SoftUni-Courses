﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] commandInfo = command.Split();

                Predicate<string> predivcate = Getpredicate(commandInfo[1], commandInfo[2]);

                if (commandInfo[0] == "Remove")
                {
                    names.RemoveAll(predivcate);
                }
                else if (commandInfo[0] == "Double")
                {
                    List<string> doubledNames = names.FindAll(predivcate);
                    if (doubledNames.Any())
                    {
                        int index = names.FindIndex(predivcate);
                        names.InsertRange(index, doubledNames);
                    }
                }

                command = Console.ReadLine();
            }

            if (names.Any())
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> Getpredicate(string commandInfo, string param)
        {
            if (commandInfo == "StartsWith")
            {
                return x => x.StartsWith(param);
            }

            if (commandInfo == "EndsWith")
            {
                return x => x.EndsWith(param);
            }

            int lenght = int.Parse(param);

            return x => x.Length == lenght;
        }
    }
}
