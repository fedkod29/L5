using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace Problem_5
{
    internal class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int mass;


        //create Dictionary name - modifier
        private Dictionary<string, double> flourList = new Dictionary<string, double>()
        {
            {"White", 1.5},
            {"Wholegrain", 1.0}
        };
        private Dictionary<string, double> bakingList = new Dictionary<string, double>()
        {
            {"Crispy", 0.9},
            {"Chewy",  1.1},
            {"Homemade", 1.0}
        };



        public string FlourType
        {
            get
            {
                return flourType;
            }
            set
            {
                if (value == "" || value == " ")
                    throw new Exception("Invalid type of dough.");

                flourType = value;
            }
        }
        public string BakingTechnique
        {
            get
            {
                return bakingTechnique;
            }
            set
            {
                if (value == "" || value == " ")
                    throw new Exception("Invalid type of dough.");

                bakingTechnique = value;
            }
        }
        public int Mass
        {
            get { return mass; }
            set
            {
                if (value < 0 || value > 200)
                    throw new Exception("Dough weight should be in the range [1..200].");

                mass = value;
            }
        }
        public Dough(string flourType, string bakingTechnique, int mass)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Mass = mass;
        }


        //assing modifier
        private double searchFlourType()
        {
            foreach(var flourName in flourList)
            {
                if(flourType == flourName.Key)
                {
                    return flourName.Value;
                }
                
            }
            throw new Exception("Invalid type of dough.");
        }
        private double searchBakingType()
        {
            foreach (var bakingName in bakingList)
            {
                if (bakingTechnique == bakingName.Key)
                {
                    return bakingName.Value;
                }
                
            }
            throw new Exception("Invalid type of dough.");
        }

        public double getCaloriesOfDough()
        {
            return mass * 2 * searchBakingType() * searchFlourType();
        }
    }
}
