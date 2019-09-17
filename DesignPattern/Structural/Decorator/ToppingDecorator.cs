using System;

namespace Structural.Decorator
{
   public abstract class ToppingDecorator : Pizza
    {


        protected Pizza tempPizza;

        // Assigns the type instance to this attribute
        // of a Pizza

        // All decorators can dynamically customize the Pizza
        // instance PlainPizza because of this

        public ToppingDecorator(Pizza newPizza)
        {

            tempPizza = newPizza;

        }

        public String GettDescription()
        {

            return tempPizza.GetDescription();

        }

        public double getCost()
        {

            return tempPizza.GetCost();

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

   
}