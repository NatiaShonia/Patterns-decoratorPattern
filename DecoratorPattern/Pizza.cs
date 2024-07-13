using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //ConcreteImplementation
    internal class Pizza : Ipizza
    {
        public string GetPizzaType()
        {
            return "This is a Normal Pizza";
        }
    }
}
