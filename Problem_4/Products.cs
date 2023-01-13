using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_4
{
    internal class Products
    {
        private string name;
        private int cost;


        public string Name
        {
            get { return name; }

            set
            {
                if (value == "" || value == " ")
                    throw new ArgumentException("Name cannot be empty");

                name = value;
            }
        }
        public int Cost
        {
            get { return cost; }

            set
            {
                if (value <= 0)
                    throw new ArgumentException("Cost cannot be negative or zero");

                cost = value;
            }
        }

        public Products(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }



    }
}
