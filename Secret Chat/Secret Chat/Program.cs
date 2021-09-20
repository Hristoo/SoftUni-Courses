using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {


        string input = Console.ReadLine();
        int greenCount = 0;
        int redCount = 0;
        int blueCount = 0;
        int purpleCount = 0;
        int yelowCount = 0;
        int brounCount = 0;



        Regex rx = new Regex(@"(#|@)+(?<color>[a-z]{3,})(@|#)+.*?(?<count>\/[0-9]+\/)",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);



        MatchCollection matches = rx.Matches(input);

        // Report on each match.
        foreach (Match match in matches)
        {
            GroupCollection groups = match.Groups;

            if (groups["color"].Value == "green")
            {
                string x = groups["count"].Value.Replace("/", "");
                greenCount += int.Parse(x);

                Console.WriteLine($"You found {greenCount} green eggs!");
                greenCount = 0;
            }
            else if (groups["color"].Value == "red")
            {
                string x = groups["count"].Value.Replace("/", "");
                redCount += int.Parse(x);
                Console.WriteLine($"You found {redCount} red eggs!");
                redCount = 0;
            }
            else if (groups["color"].Value == "blue")
            {
                string x = groups["count"].Value.Replace("/", "");
                blueCount += int.Parse(x);

                Console.WriteLine($"You found {blueCount} blue eggs!");
                blueCount = 0;
            }
            else if (groups["color"].Value == "purple")
            {
                string x = groups["count"].Value.Replace("/", "");
                purpleCount += int.Parse(x);

                Console.WriteLine($"You found {purpleCount} purple eggs!");
                purpleCount = 0;
            }
            else if (groups["color"].Value == "yelow")
            {
                string x = groups["count"].Value.Replace("/", "");
                yelowCount += int.Parse(x);

                Console.WriteLine($"You found {yelowCount} yelow eggs!");
                yelowCount = 0;
            }
            else if (groups["color"].Value == "orange")
            {
                string x = groups["count"].Value.Replace("/", "");
                brounCount += int.Parse(x);

                Console.WriteLine($"You found {brounCount} broun eggs!");
                brounCount = 0;
            }
           
        }
    }
}