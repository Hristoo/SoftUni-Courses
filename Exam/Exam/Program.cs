using System;
using System.Collections.Generic;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>();
            Stack<char> consonants = new Stack<char>();

            string inputVowels = Console.ReadLine();

            char[] chV = new char[inputVowels.Length];

            for (int i = 0; i < inputVowels.Length; i++)
            {
                chV[i] = inputVowels[i];
            }


        }
    }
}
