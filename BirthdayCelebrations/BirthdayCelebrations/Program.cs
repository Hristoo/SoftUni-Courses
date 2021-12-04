using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifible> identifiables = new List<IIdentifible>();
            List<IBirthdate> ibirthdables = new List<IBirthdate>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputInfo = input.Split();

                IBirthdate ibirthdable = null;


                if (inputInfo.Length == 3 && inputInfo[0] == "Pet")
                {
                    string name = inputInfo[1];
                    string birthdate = inputInfo[2];

                    ibirthdable = new Pet(name, birthdate);

                    ibirthdables.Add(ibirthdable);
                }
                else if (inputInfo.Length == 5)
                {
                    string name = inputInfo[1];
                    int age = int.Parse(inputInfo[2]);
                    string id = inputInfo[3];
                    string birthdate = inputInfo[4];

                    ibirthdable = new Citizen(id, name, age, birthdate);

                    ibirthdables.Add(ibirthdable);
                }

                

                input = Console.ReadLine();
            }

            string endDigits = Console.ReadLine();

            foreach (var item in ibirthdables)
            {
                if (item.Birthdate.EndsWith(endDigits))
                {
                    Console.WriteLine(item.Birthdate);
                }
            }
        }
    }
}
