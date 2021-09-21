using System;
using System.Collections.Generic;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> parantheses = new Stack<char>();
            bool isBalanced = true;

            foreach (var symbol in input)
            {
                if (symbol == '{' || symbol == '[' || symbol == '(')
                {
                    parantheses.Push(symbol);
                }
                else
                {
                    if (parantheses.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    if(symbol == '}' && parantheses.Peek() == '{')
                    {
                        parantheses.Pop();
                    }
                    else if (symbol == ']' && parantheses.Peek() == '[')
                    {
                        parantheses.Pop();
                    }
                    else if (symbol == ')' && parantheses.Peek() == '(')
                    {
                        parantheses.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }

            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
