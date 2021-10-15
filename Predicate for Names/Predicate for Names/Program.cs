using System;
using System.Linq;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> nameLenght =
                (name, lenght) => name.Length <= lenght;

            int maxLenghtName = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split()
                .Where(x => nameLenght(x, maxLenghtName))
                .ToArray();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
