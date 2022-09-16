using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class HCMGreekPizza : Pizza
    {
        internal HCMGreekPizza()
        {
            Name = "hcm greek pizza";
            Dough = "thin";
            Sauce = "chilli";
            Toppings = new List<string> { "Potato" };
        }
    }
}
