using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        private string model;

        public Smartphone(string model)
        {
            this.model = model;
        }

        public string Browse(string url)
        {
            bool hasdigit = url.Any(char.IsDigit);
            if (hasdigit)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Invalid URL!");
                return sb.ToString();
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Browsing: {url}!");
                return sb.ToString();
            }
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
                sb.Append($"Calling... {number}");
                return sb.ToString();
            }
        }
    }
}
