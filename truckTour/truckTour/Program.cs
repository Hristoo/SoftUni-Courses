using System;
using System.Collections.Generic;
using System.Linq;

namespace truckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> truckTour = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();

                int petrol = input[0];
                int distance = input[1];

                truckTour.Enqueue(new int[] { petrol, distance });
            }
            int startIndex = 0;

            while (true)
            {
                int currenrPetrol = 0;

                foreach (var info in truckTour)
                {
                    int truckPetrol = info[0];
                    int truckDistance = info[1];

                    currenrPetrol += truckPetrol;
                    currenrPetrol -= truckDistance;

                    if (currenrPetrol < 0)
                    {
                        int[] element = truckTour.Dequeue();
                        truckTour.Enqueue(element);
                        startIndex++;
                        break;
                    }
                }

                if (currenrPetrol >= 0)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
        }
    }
}
