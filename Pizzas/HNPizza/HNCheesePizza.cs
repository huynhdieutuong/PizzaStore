using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class HNCheesePizza : Pizza
    {
        internal HNCheesePizza ()
        {
            Name = "hn cheese pizza";
            Dough = "very thin";
            Sauce = "very spicy";
            Toppings = new List<string> { "Black olives", "Cheese" };
        }

        internal override void Box()
        {
            Console.WriteLine("Override boxing cheese pizza");
        }
    }
}
