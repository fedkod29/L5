using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5
{
    internal class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppingList = new List<Topping>();


        public string Name
        {
            get { return name; }
            set
            {
                if (value == "" || value == " " || value.Length > 15)
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                name = value;
            }
        }

        public Pizza(string name)
        {
            Name = name;
        }

        public void setDough()
        {
            string flour, baking;
            int mass;

            Console.Write("Enter type of flour: ");
            flour = Console.ReadLine();

            Console.Write("Enter type of baking: ");
            baking = Console.ReadLine();

            Console.Write("Enter mass: ");
            mass = Convert.ToInt32(Console.ReadLine());

            dough = new Dough(flour, baking, mass);
        }

        public void setTopping()
        {
            Console.Write("Enter number of toppings: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 10) throw new Exception("Number of \r\ntoppings should be in range [0..10].");

            string name;
            int mass;
            Topping item;
            for(int i = 0; i < num; i++)
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();

                Console.Write("Enter mass: ");
                mass = Convert.ToInt32(Console.ReadLine());

                item = new Topping(name, mass);
                toppingList.Add(item);
            }
        }

       private double CalculateCalories()
        {
            double calories = 0;
            foreach(Topping item in toppingList)
            {
                calories += item.getCaloriesTopping();
            }

            calories += dough.getCaloriesOfDough();

            return calories;
        }


        public void result()
        {
            Console.WriteLine($"{Name} - {CalculateCalories()} Calories");
        }
    }
}
