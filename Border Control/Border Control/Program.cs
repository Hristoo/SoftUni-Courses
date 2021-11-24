using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifible> identifiables = new List<IIdentifible>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputInfo = input.Split();

                IIdentifible identifible = null;

                if (inputInfo.Length == 2)
                {
                    string model = inputInfo[0];
                    string id = inputInfo[1];

                    identifible = new Robot(id, model);
                }
                else if (inputInfo.Length == 3)
                {
                    string name = inputInfo[0];
                    int age = int.Parse(inputInfo[1]);
                    string id = inputInfo[2];

                    identifible = new Citizen(id, name, age);
                }

                identifiables.Add(identifible);

                input = Console.ReadLine();
            }

            string endDigits = Console.ReadLine();

            foreach (var item in identifiables)
            {
                if (item.Id.EndsWith(endDigits))
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
    }
}
