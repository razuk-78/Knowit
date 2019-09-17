using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    public class Mozzarella : ToppingDecorator
    {


    public Mozzarella(Pizza newPizza)
    {

        super(newPizza);

        Console.WriteLine("Adding Dough");

        Console.WriteLine("Adding Moz");
    }

    // Returns the result of calling getDescription() for
    // PlainPizza and adds " mozzarella" to it

    public String getDescription()
    {

        return tempPizza.getDescription() + ", mozzarella";

    }

    public double getCost()
    {

        System.out.println("Cost of Moz: " + .50);

        return tempPizza.getCost() + .50;

    }

    }
}
