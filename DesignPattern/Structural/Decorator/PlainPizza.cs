using System;

namespace Structural.Decorator
{
    public class PlainPizza : Pizza
    {


        public String getDescription()
        {

            return "Thin dough";

        }

        public double getCost()
        {

            Console.WriteLine("Cost of Dough: " + 4.00);

            return 4.00;

        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public double GetCost()
        {
            throw new NotImplementedException();
        }
    }

    // Has a "Has a" relationship with Pizza. This is an
    // Aggregation Relationship
}
