using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Spree
{
    class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;

            this.products = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value; 
            }
        }       

        public decimal Money
        {
            get { return money; }
            private set 
            {
                if (money - value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value; 
            }
        }

        public IReadOnlyCollection<Product> Products
            => this.Products;

        public void AddProduct(Product product)
        {
            this.money -= product.Cost;
            this.products.Add(product);
        }
    }
}
