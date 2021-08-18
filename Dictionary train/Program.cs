using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        // New follower: George
        Dictionary<string, int> followers = new Dictionary<string, int>();

        string input = Console.ReadLine();

        while (input != "Log out")
        {
            string[] commandInfo = input.Split(":");

            for (int i = 0; i < commandInfo.Length; i++)
            {
                commandInfo[i] = commandInfo[i].Trim();
            }

            if (commandInfo[0] == "New follower")
            {
                if (!followers.ContainsKey(commandInfo[1]))
                {
                    followers.Add(commandInfo[1].ToString(), 0);
                }
            }
            else if (commandInfo[0] == "Like")
            {
                if (!followers.ContainsKey(commandInfo[1]))
                {
                    followers.Add(commandInfo[1].ToString(), 1);
                }

                followers[commandInfo[1]] = int.Parse(commandInfo[2]);
            }

            else if (commandInfo[0] == "Comment")
            {
                if (!followers.ContainsKey(commandInfo[1]))
                {
                    followers.Add(commandInfo[1].ToString(), 1);
                }
                else
                {
                    followers[commandInfo[1]]++;
                }
            }
            else if (commandInfo[0] == "Blocked")
            {
                if (followers.ContainsKey(commandInfo[1]))
                {
                    followers.Remove(commandInfo[1]);
                }
                else
                {
                    Console.WriteLine($"{commandInfo[1]} doesn't exist.");
                }
            }

            input = Console.ReadLine();
        }
        Console.WriteLine($"{followers.Count} followers");
        foreach (var f in followers.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{f.Key.Trim()}: {f.Value}");
        }

    }
}