using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class HNPepperoniPizza : Pizza
    {
        internal HNPepperoniPizza()
        {
            Name = "hn pepperoni pizza";
            Dough = "thick";
            Sauce = "sweet";
            Toppings = new List<string> { "Tomamto" };
        }
    }
}
