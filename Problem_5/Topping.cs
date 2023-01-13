using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5
{
    internal class Topping
    {
        private string toppingType;
        private double mass;

        private Dictionary<string, double> toppingList = new Dictionary<string, double>()
        {
            {"Meat", 1.2},
            {"Veggies", 0.8},
            {"Cheese", 1.1},
            {"Sauce", 0.9}
        };


        public string ToppingType
        {
            get { return toppingType; }
            set
            {
                if (value == "" || value == " ")
                    throw new Exception($"Cannot place {toppingType} on top of your pizza.");

                toppingType = value;
            }
        }
        public double Mass
        {
            get { return mass; }
            set
            {
                if (value < 1 || value > 50)
                    throw new Exception($"{toppingType} weight should be in the range [1..50].");

                mass = value;
            }
        }
        public Topping(string toppingType, double mass)
        {
            ToppingType = toppingType;
            Mass = mass;
        }


        private double SearchToppingModifiers()
        {
            foreach(var toppingName in toppingList)
            {
                if(toppingName.Key == toppingType)
                {
                    return toppingName.Value;
                }
            }
            throw new Exception($"Cannot place {toppingType} on top of your pizza.");
        }

        public double getCaloriesTopping()
        {
            return mass * 2 * SearchToppingModifiers();
        }
    }
}
