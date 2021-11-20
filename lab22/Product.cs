using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    abstract class Product
    {
        protected int price;
        protected string name;
        public Product(int price, string name)
        {
            this.price = price;
            this.name = name;
        }
        public Product()
        {
            Console.WriteLine("Enter price of product:");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name of product:");
            name = Console.ReadLine();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}