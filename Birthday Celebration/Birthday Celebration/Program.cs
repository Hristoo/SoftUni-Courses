using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Celebration
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] guests = Console.ReadLine()
				.Split().Select(int.Parse).ToArray();

			int[] food = Console.ReadLine()
				.Split().Select(int.Parse).ToArray();

			int wastedFood = 0;
			int n = 0;
			int foodPlate = 0;
			Stack<int> foodList = new Stack<int>(food);
			Queue<int> guestList = new Queue<int>(guests);

			

			if (guestList.Count < foodList.Count)
			{
				n = guestList.Count;
			}
			else
			{
				n = foodList.Count;
			}

			for (int i = 0; i < n; i++)
			{

				int guestFood = guestList.Peek();
				foodPlate += foodList.Pop();

				if (guestFood - foodPlate <= 0)
				{
					guestList.Dequeue();

					if (foodPlate - guestFood > 0)
					{
						wastedFood += foodPlate - guestFood;
					}			
					
				}
				else
				{
					foodPlate = guestFood - guestFood;
				}

				

			}

			if (guestList.Count > foodList.Count)
			{
				Console.Write("Guests: ");
				foreach (var q in guestList)
				{
					Console.Write(q + " ");
				}
				Console.WriteLine();
			}
			else
			{
				Console.Write("Plates: ");
				foreach (var q in foodList)
				{
					Console.Write(q);
				}
				Console.WriteLine();
			}

			Console.WriteLine($"Wasted grams of food: { wastedFood}");
		}
	}
}
