using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        // heVVodar!gniV
        string input = Console.ReadLine();
        string command = Console.ReadLine();

        while (command != "Reveal")
        {
            // ChangeAll:|:{substring}:|:{replacement} 
            string[] commandInfo = command.Split(":|:");
            string action = commandInfo[0];
            string substring = commandInfo[1];

            if (action == "ChangeAll")
            {
                string replacement = commandInfo[2];

                input = input.Replace(substring, replacement);
                Console.WriteLine(input);
            }
            else if (action == "Reverse")
            {

                if (input.Contains(substring))
                {
                    while (input.Contains(substring))
                    {
                        input = input.Replace(substring, string.Empty);

                        char[] sub = substring.ToCharArray();
                        Array.Reverse(sub);
                        string substr = new string(sub);
                        input = input + "" + substr;
                        Console.WriteLine($"{input}");

                    }
                    Console.WriteLine($"{input}");

                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (action == "InsertSpace")
            {// InsertSpace:|:{index}
                input = input.Insert(int.Parse(substring), " ");
                Console.WriteLine($"{input}");
            }
            command = Console.ReadLine();
        }
        Console.WriteLine($"You have a new text message: {input}");
    }
}