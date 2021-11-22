using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInfo = Console.ReadLine().Split();
                string[] doughInfo = Console.ReadLine().Split();

                string pizzaName = pizzaInfo[1];
                string doughFlourType = doughInfo[1];
                string bakinTechnique = doughInfo[2];
                double dougthWeight = double.Parse(doughInfo[3]);

                Dough dough = new Dough(doughFlourType, bakinTechnique, dougthWeight);
                Pizza pizza = new Pizza(pizzaName, dough);

                string toppingType = Console.ReadLine();

                while (toppingType != "END")
                {
                    string[] toppingInfo = toppingType.Split();
                    string type = toppingInfo[1];
                    double weight = double.Parse(toppingInfo[2]);

                    Topping topping = new Topping(type, weight);
                    pizza.AddTopping(topping);

                    toppingType = Console.ReadLine();
                }

                Console.WriteLine($"{pizzaName} - {pizza.CalculateTotalCalories():F2} Calories.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
