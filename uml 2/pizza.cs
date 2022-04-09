using System;
using System.Collections.Generic;
using System.Text;

namespace uml_2
{
    public class Pizza
    {
        public int Number { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public Pizza()
        {

        }
        public Pizza(int number, string name, double price)
        {
            this.Number = number;
            this.Name = name;
            this.Price = price;
        }
        public override string ToString() { return $"nr. { Number} . { Name} pris: { Price } dkk"; }

    }
}