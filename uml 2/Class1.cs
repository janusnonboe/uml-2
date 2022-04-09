using System;
using System.Collections.Generic;
using System.Text;

namespace uml_2
{
    public class store
    {
        static int MainMenuChoice(List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("-------------------");
            Console.WriteLine("| Pizza store |");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("Options:");
            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);

            }

            Console.Write("Enter option#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            return -1;
        }
        public void start() { test(); }

        public void test() 
        {
            bool proceed = true;
            List<string> mainMenulist = new List<string>()
            {
                "0. Quit",
                "1. Show Menu",
                "2. Createpizza",
                "3. Deletepizza",
                "4. Updatepizza"
            };
            while (proceed)
            {
                int MenuChoice = MainMenuChoice(mainMenulist);
                Console.WriteLine();
                switch (MenuChoice)
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine();
                        break;
                    case 1:
                        menucatalog.PrintMenu();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("skriv navnet på din pizza");
                        string name = Console.ReadLine();
                        Console.WriteLine("skriv prisen på pizzaen");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("nummeret på pizzaen");
                        int number = 0;
                        string input = Console.ReadLine();
                        try
                        {
                            number = int.Parse(input);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine($" '{input}' was in wrong format. Has to be a number");
                        }
                        if (menucatalog.Pizzas.ContainsKey(number) == false)
                        {
                            Pizza newPizza = new Pizza(number, name, price);
                            menucatalog.createpizza(newPizza);
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("skriv nummeret på den pizza du ville have slettet");
                        int num = 0;
                        try
                        {
                             num = Convert.ToInt32(Console.ReadLine());

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine($" '{num}' was in wrong format. Has to be a number");
                        }
                        if (menucatalog.Pizzas.ContainsKey(num -1))
                        {
                            menucatalog.deletepizza(num);                            
                        }
                        Console.ReadKey();                        
                        break;
                    case 4:

                        int index = 0;
                        Console.WriteLine("vælg pizza");
                        index = Convert.ToInt32(Console.ReadLine());
                        Pizza pizza = new Pizza();
                        pizza.Number = index;
                        Console.WriteLine("navn på pizzaen");
                        pizza.Name = Console.ReadLine();
                        Console.WriteLine("ny pris");
                        pizza.Price = Convert.ToInt32(Console.ReadLine());
                        menucatalog.updatepizza(index, pizza);
                        break;
                    default:
                        continue;
                }
            }                       
        }
    }
}
