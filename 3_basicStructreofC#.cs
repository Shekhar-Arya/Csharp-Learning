/* This program shows the basic structure
of the c# how does the class and
the method of the program goes.*/

using System;
namespace basicStructreofC
{
    public class Rectangle
    {
        double length = 0.0;
        double breadth = 0.0;

        public void ExceptValue()
        {
            length = 10.0;
            breadth = 10.0;
        }

        public double CalculateArea()
        {
            return length*breadth;
        }

        public void DisplayValues()
        {
            System.Console.WriteLine($"The length is:{length}");
            System.Console.WriteLine($"The breadth is:{breadth}");
            System.Console.WriteLine($"The Area is: {CalculateArea()}");
        }

    }

    public class Execute
    {
        public static void Main(String[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.ExceptValue();
            rectangle.CalculateArea();
            rectangle.DisplayValues();
        }
    }
}