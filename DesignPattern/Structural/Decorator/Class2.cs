using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    public class TomatoSauce : ToppingDecorator
    {


    public TomatoSauce(Pizza newPizza): ToppingDecorator(newPizza)
    {
        base(newPizza);

        Console.WriteLine("Adding Sauce");
    }

    // Returns the result of calling getDescription() for
    // PlainPizza, Mozzarella and then TomatoSauce

    public String GetDescription()
    {

        return tempPizza.getDescription() + ", tomato sauce";

    }

    public double GetCost()
    {

        Console.WriteLine("Cost of Sauce: " + .35);

        return tempPizza.getCost() + .35;

    }

    }
}
