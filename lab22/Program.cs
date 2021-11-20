/*1.Используя ранее разработанные иерархии классов (Animal, Transport, Worker, Student…), 
 * создайте в программе общий контейнер (массив, вектор, список…) объектов различных типов.
 * 2.Сделайте обход контейнера, выполнив действия только с объектами нужных вам типов, 
 * применяя два способа -  RTTI и dynamic_cast.
 * 3.Напишите  функцию типа "фабрика объектов" и используйте ее для создания в 
 * цикле объектов разных типов. После создания объекта определите его реальный тип и выполните с ним  действия.*/

using System;
using System.Collections.Generic;
namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Product>();
            Pizza pizza1 = new Pizza("dough", "Ketchup", 120, "Pizza 1");
            Pizza pizza2 = new Pizza("dough", "Sauce", 200, "Pizza 2");
            Cocktail cocktail1 = new Cocktail("Strawberry", "small", 50, "Cocktail 1");
            Cocktail cocktail2 = new Cocktail("Melon", "small", 70, "Cocktail 2");
            Product product1 = new Product(120, "product");
            list.Add(product1);
            list.Add(pizza1);
            list.Add(cocktail1);
            int price = 100;
            foreach (var product in list)
            {
                if (product is Pizza student)
                {

                    //for pizza
                }
                else
                {
                    var cocktail = product as Cocktail;

                    {
                        Console.WriteLine(list.Find(cocktail => cocktail.Price == price));
                    }
                    //for cocktail  
                }

                Console.ReadLine();
            }
        }
    }
}
