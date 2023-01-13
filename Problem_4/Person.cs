using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Problem_4
{
    internal class Person
    {
        private string name;
        private int money;
        private List<Products> bagOfProducts = new List<Products>();


        public string Name
        {
            get { return name; }

            set
            {
                if(value == "" || value == " ")
                    throw new ArgumentException("Name cannot be empty");

                name = value;
            }
        }

        public int Money
        {
            get { return money; }

            set
            {
                if (value <= 0)
                    throw new ArgumentException("Money cannot be negative or zero");

               money = value;
            }
        }
    }
}
