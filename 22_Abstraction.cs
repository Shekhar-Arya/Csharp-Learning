// Abstraction class is also collection of the methods or properties.
// The abstracted class methods are just defined methods same as interface methods.
// Body of the methods are written in the class which is inherited.

// Example as below:

using System;
namespace Abstraction
{
    public abstract class LengthBreadth
    {
        public abstract void Length(int l);
        public abstract void Breadth(int b);
    }

    public class ExecuteLengthBreadth : LengthBreadth
    {
        int length;
        int breadth;
        public override void Length(int l)
        {
            length = l;
            System.Console.WriteLine(l);
        }
        public override void Breadth(int b)
        {
            breadth = b;
            System.Console.WriteLine(b);
        }

        public static void Main(String[] args)
        {
            ExecuteLengthBreadth e = new ExecuteLengthBreadth();
            e.Length(35);
            e.Breadth(15);
        }
    }
}