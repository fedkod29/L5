using System;
using System.Linq.Expressions;
using System.Threading;
class kvadrat
{
    private double a;
    public double A
    {
        get
        {
            return a;
        }
        set
        {
            try (value != 0)
            {
                a = value;
            }

            catch (Exception ex)
            {

            }



            if (value != 0)
            {
                a = value;
            }
            else
            {
                throw new Exception("a cannot be zero");
            }
        }
    }

    private double b;
    public double B
    {
        get
        {
            return b;
        }
        set
        {
            b = value;
        }
    }

    private double c;
    public double C
    {
        get
        {
            return c;
        }
        set
        {
            c = value;
        }
    }

    public kvadrat(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public void rishena()
    {
        double D = (Math.Pow(b,2)-4*a*c);

        if (D < 0)
        {

            throw new Exception("Koreniv nemae.");
        }
        else
        {
            Console.WriteLine($"D={D}");

            if (D == 0)
            {
                double x = (-b / 2 * a);
                Console.WriteLine($"x={x}");
            }
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D) / 2 * a);
                double x2 = (-b - Math.Sqrt(D) / 2 * a);

                Console.WriteLine($"x1={x1}, x2={x2} ");
            }

        }
    }
}

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a, b, c: ");

        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        kvadrat Rivna = new kvadrat(a, b, c);
        Rivna.rishena();
    }
}
