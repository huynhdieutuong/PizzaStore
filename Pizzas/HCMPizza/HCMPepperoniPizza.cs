using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class HCMPepperoniPizza : Pizza
    {
        internal HCMPepperoniPizza()
        {
            Name = "hcm pepperoni pizza";
            Dough = "thick";
            Sauce = "sweet";
            Toppings = new List<string> { "Tomamto" };
        }
    }
}
