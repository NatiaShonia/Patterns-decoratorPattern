using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Concrete Decorator
    internal class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(Ipizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += " with extra Onion";
            return type;
        }
    }
}
