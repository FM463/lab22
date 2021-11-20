using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class Cocktail : Product
    {
        protected string taste;
        protected string size;
        public Cocktail()
        {
            Console.WriteLine($"Please enter taste of cocktail:\n");
            taste = Console.ReadLine();
            Console.WriteLine($"Please eneter the size of cocktail.We have 3 sizes in menu: S(100 ml),M(300ml),L(500ml):\n");
            size = Console.ReadLine();
            Random randomPrice = new Random();
            price = randomPrice.Next(100, 150);
        }
        public Cocktail(string taste, string size, int price, string name) : base(price, name)
        {
            this.taste = taste;
            this.size = size;
        }
        public string Taste
        {
            get { return taste; }
            set { taste = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}