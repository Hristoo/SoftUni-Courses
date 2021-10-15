using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Evens_or_Odds
{
	class Program
	{
		static void Main(string[] args)
		{
			Predicate<int> isEven = number => number % 2 == 0;
			Action<int[]> printNumbers = inpupNumbers
				=> Console.WriteLine(string.Join(" ", inpupNumbers)); ;

			List<int> numbers = new List<int>();

			int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();


			for (int i = range[0]; i <= range[1]; i++)
			{
				numbers.Add(i);
			}

			string evenOdd = Console.ReadLine();

			if (evenOdd == "even")
			{
				printNumbers(numbers.Where(x => isEven(x)).ToArray());
			}
			else
			{
				printNumbers(numbers.Where(x => !isEven(x)).ToArray());
			}
		}
	}
}
