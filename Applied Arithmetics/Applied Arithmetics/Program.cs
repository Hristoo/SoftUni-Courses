using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applied_Arithmetics
{
	class Program
	{
		static void Main(string[] args)
		{
			Action<int[]> add = numbers =>
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					numbers[i] += 1;
				}
			};

			Action<int[]> substract = numbers =>
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					numbers[i] -= 1;
				}
			};

			Action<int[]> multiply = numbers =>
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					numbers[i] *= 2;
				}
			};

			Action<int[]> printNumbers = numbers
				=> Console.WriteLine(string.Join(" ", numbers));

			int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			string command = Console.ReadLine();

			while (command != "end")
			{
				if (command == "add")
				{
					add(inputNumbers);
				}
				else if (command == "multiply")
				{
					multiply(inputNumbers);
				}
				else if (command == "subtract")
				{

						substract(inputNumbers);

				}
				else if (command == "print")
				{
					printNumbers(inputNumbers);
				}

				command = Console.ReadLine();
			}
		}
	}
}
