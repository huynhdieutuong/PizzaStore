using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal abstract class Pizza
    {
        protected string? Name { get; set; }
        protected string? Dough { get; set; }
        protected string? Sauce { get; set; }
        protected List<string>? Toppings { get; set; }

        internal void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine($"Tossing {Dough} dough");
            Console.WriteLine($"Adding {Name} sauce");
            Console.WriteLine($"Adding toppings:");
            Toppings?.ForEach(topping => Console.WriteLine(topping));
        }

        internal void Bake()
        {
            Console.WriteLine($"Baking {Name} in 30 mins");
        }

        internal void Cut()
        {
            Console.WriteLine($"Cutting {Name}");
        }

        internal virtual void Box()
        {
            Console.WriteLine($"Boxing {Name}");
        }
    }
}
