using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class DNGreekPizza : Pizza
    {
        internal DNGreekPizza()
        {
            Name = "dn greek pizza";
            Dough = "thin";
            Sauce = "chilli";
            Toppings = new List<string> { "Potato" };
        }
    }
}
