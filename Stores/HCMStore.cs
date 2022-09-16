using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class HCMStore : Store
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new HCMCheesePizza();
                case PizzaType.Greek:
                    return new HCMGreekPizza();
                case PizzaType.Pepperoni:
                    return new HCMPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
