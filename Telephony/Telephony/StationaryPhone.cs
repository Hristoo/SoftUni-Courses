using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICall
    {
        private string model;

        public StationaryPhone(string model)
        {
            this.model = model;
        }

        public string Call(string number)
        {
            bool hasCharacter = number.Any(char.IsLetter);
            if (hasCharacter)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Invalid number!");
                return sb.ToString();
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Dialing... {number}");
                return sb.ToString();
            }
        }
    }
}
