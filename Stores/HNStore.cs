using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class HNStore : Store
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new HNCheesePizza();
                case PizzaType.Greek:
                    return new HNGreekPizza();
                case PizzaType.Pepperoni:
                    return new HNPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
