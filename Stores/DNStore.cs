using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class DNStore : Store
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new DNCheesePizza();
                case PizzaType.Greek:
                    return new DNGreekPizza();
                case PizzaType.Pepperoni:
                    return new DNPepperoniPizza();
                default:
                    return null;
            }
        }

    }
}
