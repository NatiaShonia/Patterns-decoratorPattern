using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class PizzaDecorator : Ipizza
    {
        private Ipizza pizza;

        public PizzaDecorator(Ipizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual string GetPizzaType()
        {
            return pizza.GetPizzaType();
        } 
    }
}
