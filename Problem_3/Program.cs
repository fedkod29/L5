using System;

namespace Problem_3
{
    class Chicken
    {
        private string name;
        private int age;
        public string Name
        {
            get 
            {
                return name;
            }
            set 
            {
                if (value == "" || value == " ")
                { 
                    throw new Exception("Name cannot be empty!");
                }
                name = value;
            }
        }

        public int Age
        {
            get
            { 
                return age;
            }
            set
            {
                if (value < 0 || value > 15)
                { 
                    throw new Exception("Age should be between 0 and 15");
                }
                age = value; 
            }
        }

        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

       private int calculateProductPerDay()
        {
            Random random = new Random();
            int rand = random.Next(0, 4);

            return Convert.ToInt32(rand); 
        }

        public void ProductPerDay()
        {
            Console.WriteLine($"Chicken {Name}, age: {Age} can produce: {calculateProductPerDay()} eggs per day.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter chicken name: ");
            string name = Console.ReadLine();

            Console.Write("Enter chicken age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Chicken chicken = new Chicken(name, age);
            chicken.ProductPerDay();
        }
    }
}
