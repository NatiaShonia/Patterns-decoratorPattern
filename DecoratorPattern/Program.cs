using System;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ipizza pica=new Ipizza();  იმიტოა ერორი რომ ინტერფეისს არ აქვს ინსტანსიიიი
            Pizza pica = new Pizza();

            //Ipizza pica=new Pizza();--ერთნაირად ბეჭდავს


            Ipizza Yvelit = new CheeseDecorator(pica);
            //Pizza Yvelit = new CheeseDecorator(pica);  ---რადგან მშოვლად cheesedecorator არ ყავს Pizza ამიტო ვერ სევქმნით, მშობლად ყავს Ipizza

            Ipizza Tomatit=new TomatoDecorator(pica);

            Ipizza Nivrit=new OnionDecorator(Tomatit);



            Console.WriteLine(Yvelit.GetPizzaType());     

            Console.WriteLine(pica.GetPizzaType());    

            Console.WriteLine(Yvelit.GetPizzaType());

            Console.WriteLine(Tomatit.GetPizzaType());

            Console.WriteLine(Nivrit.GetPizzaType());
        }
    }
}
