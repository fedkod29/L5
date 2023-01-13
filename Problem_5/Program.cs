using System;

namespace Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter pizza name: ");
            string name = Console.ReadLine();

            Pizza pizza = new Pizza(name);
            pizza.setDough();
            pizza.setTopping();
            pizza.result();
        }
    }
}
