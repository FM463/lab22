using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class Pizza : Product
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected string[] toppings;
        public Pizza(string dough, string sauce, string[] toppings, int price, string name) : base(price, name)
        {
            this.dough = dough;
            this.sauce = sauce;
            this.toppings = toppings;
        }
        public Pizza()
        {
            Console.WriteLine("Please enter dough pizza:\n");
            dough = Console.ReadLine();
            Console.WriteLine("Please enter which sauce you want in pizza:\n");
            sauce = Console.ReadLine();
            Console.WriteLine("Please enter toppings in your pizza:\n");
            Console.WriteLine("Enter num of toppings:");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adding toppings:");
            string[] toppings = new string[n];
            for (int i = 0; i < toppings.Length; i++)
            {
                toppings[i] = Console.ReadLine();
            }
            Random randomPrice = new Random();
            price = randomPrice.Next(100, 150);
        }
        public void Prepare()
        {
            Console.WriteLine($"Prepating pizza {name}\n");
            Console.WriteLine($"Adding sauce {sauce} to pizza\n");
            Console.WriteLine($"Adding toppings to pizza\n");
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 degrees");
        }
        public void Box()
        {
            Console.WriteLine("Your pizza is boxing.\n");
        }
        public void Ready()
        {
            Console.WriteLine("Your pizza is ready!Thank you choosing us!\n");
        }
        public string Dough
        {
            get { return dough; }
            set { dough = value; }
        }
        public string Sauce
        {
            get { return sauce; }
            set { sauce = value; }
        }
    }
}