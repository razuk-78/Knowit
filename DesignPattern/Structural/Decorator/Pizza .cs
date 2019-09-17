using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    // Blueprint for classes that will have decorators

     interface Pizza
    {

         String GetDescription();

         double GetCost();

    }


    /* 
    public abstract class Pizza{


        public abstract void setDescription(String newDescription);
        public abstract String getDescription();

        public abstract void setCost(double newCost);
        public abstract double getCost();

        // I could use getter and setter methods for every 
        // potential Pizza topping

    }
    */

    // By going this route I'll have to create a new subclass
    // for an infinite number of pizza.
    // I'd also have to change prices in many classes 
    // when just 1 Pizza topping cost changes

    // Inheritance is static while composition is dynamic
    // Through composition I'll be able to add new functionality
    // by writing new code rather than by changing current code
}
