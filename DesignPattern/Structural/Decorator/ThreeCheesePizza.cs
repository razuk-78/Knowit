using System;

namespace Structural.Decorator
{
    public class ThreeCheesePizza : Pizza
    {


        private String description = "Mozzarella, Fontina, Parmesan Cheese Pizza";
        private double cost = 10.50;

        public void SetDescription(String newDescription)
        {

            description = newDescription;

        }

        public String GetDescription()
        {

            return description;

        }

        public void SetCost(double newCost)
        {

            cost = newCost;

        }

        public double GetCost()
        {

            return cost;

        }
    }



    // Implements the Pizza interface with only the required
    // methods from the interface

    // Every Pizza made will start as a PlainPizza
}