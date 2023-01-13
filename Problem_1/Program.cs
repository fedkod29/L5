using System;
using System.Threading;
    class Box
    {
        private double length;
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    throw new Exception("Length cannot be zero or negative");
                }
            }
        }

        private double width;
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new Exception("Width cannot be zero or negative.");
                }
            }
        }

        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if(value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new Exception("Height cannot be zero or negative.");
                }
            }
        }

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        private double SurfaceArea()
        {
            return (2 * Length * Width) + (2 * Length * Height) + (2 * Width * Height);
        }

        private double LateralSurfaceArea()
        {
            return (2 * Length * Height) + (2 * Width * Height);
        }

        private double Volume()
        {
            return Length * Height * Width;
        }

        public void Result()
        {
            Console.WriteLine($"Surface Area == " + SurfaceArea());
            Console.WriteLine($"Lateral Surface Area == { LateralSurfaceArea() }");
            Console.WriteLine($"Volume == { Volume() }");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter length, width, height: ");

            double length = Convert.ToDouble(Console.ReadLine());
            double heigth = Convert.ToDouble(Console.ReadLine());
            double width = Convert.ToDouble(Console.ReadLine());
            
            Box box = new Box(length, heigth, width);
            box.Result();
        }
    }
