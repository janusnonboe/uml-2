using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uml_2
{
    public class menucatalog
    {             
        public static Dictionary<int, Pizza> Pizzas { get { return pizzas; } }

        private static Dictionary<int, Pizza> pizzas = new Dictionary<int, Pizza>()
        {
            {1 , new Pizza(1, "cal", 90) },
            {2 , new Pizza(2, "cool", 100) },
            {3 , new Pizza(3, "magar", 80)}
        };        

        public static void createpizza(Pizza pizza) { pizzas.Add(pizza.Number, pizza); }

        public static void deletepizza(int num) { pizzas.Remove(num); }

        public static void updatepizza(int index, Pizza pizza)
        {
            pizzas[index] = pizza;
        }

        public static void ReadPizza()
        {
            Console.WriteLine("Choose a pizza");
            Console.Write("Pizza Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (pizzas.ContainsKey(number))
            {
                Console.WriteLine();
                Console.WriteLine($"printing Pizza {number}");
                Console.WriteLine(pizzas[number]);
            }
            else
            {
                Console.WriteLine($"Pizza Number {number}");
                Console.WriteLine("pizza not listed in menu");
            }
        }

        public static void PrintMenu()
        {
            foreach (var pizza in pizzas)
            {
                Console.WriteLine(pizza);
            }
        }
    }
}
