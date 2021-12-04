using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizen : IIdentifible, IBirthdate
    {
        public Citizen(string id, string name, int age, string birthdate)
        {
            Id = id;
            Name = name;
            Age = age;
            Birthdate = birthdate;
        }


        public string Id { get; }

        public string Name { get; set; }

        public int Age { get; set; }
        public string Birthdate { get ; set; }
    }
}
