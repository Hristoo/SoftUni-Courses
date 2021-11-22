using System;
using System.Collections.Generic;
using System.Linq;

public class StaksAndQueues
{
    public static void Main(string[] args)
    {


        string pear = "pear";
        char[] arrayPear = pear.ToCharArray();
        string p = "";

        string flour = "flour";
        char[] arrayFlour = flour.ToCharArray();
        string f = "";

        string pork = "pork";
        char[] arrayPork = pork.ToCharArray();

        string olive = "olive";
        char[] arrayOlive = olive.ToCharArray();

        Stack<string> words = new Stack<string>();

        Queue<char> vowels = new Queue<char>();
        Stack<char> consonants = new Stack<char>();

        string v = Console.ReadLine();
        string c = Console.ReadLine();

        char[] arrayV = v.ToCharArray();
        char[] arrayC = c.ToCharArray();

        bool resetLoop = false;

        for (int i = 0; i < arrayV.Length; i++)
        {
            if (!Char.IsWhiteSpace(arrayV[i]))
            {
                vowels.Enqueue(arrayV[i]);
            }
           
        }

        for (int i = 0; i < arrayC.Length; i++)
        {
            if (!Char.IsWhiteSpace(arrayC[i]))
            {
                consonants.Push(arrayC[i]);
            }
        }

        for (int i = 0; i < consonants.Count; i++)
        {
            char chC = consonants.Pop();
            char chV = vowels.Dequeue();
            vowels.Enqueue(chV);

            foreach (var item in arrayFlour)
            {
                if (item == chC || item == chV && !words.Contains("flour"))
                {

                    f += item;
                   if (f == "flour")
                    {
                        words.Push("flour");
                        break;
                    }
                    
                }
            }

            foreach (var item in arrayPear)
            {
                if (item == chC || item == chV && !words.Contains("pear"))
                {
                    p += item;
                    if (p == "pear")
                    {
                        words.Push("pear");
                        break;
                    }
                }
            }


            foreach (var item in arrayPork)
            {
                if (item == chC || item == chV && !words.Contains("pork"))
                {
                    words.Push("pork");
                    break;
                }
            }
            if (resetLoop) break;

            foreach (var item in arrayOlive)
            {
                if (item == chC || item == chV && !words.Contains("olive"))
                {
                    words.Push("olive");
                    break;
                }
            }
        }

        Console.WriteLine($"Worrds found: {words.Count}");

        foreach (var item in words)
        {
            Console.Write(item);
            Console.WriteLine();
        }





        }
}
