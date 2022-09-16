using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class HNGreekPizza : Pizza
    {
        internal HNGreekPizza()
        {
            Name = "hn greek pizza";
            Dough = "thin";
            Sauce = "chilli";
            Toppings = new List<string> { "Potato" };
        }
    }
}
