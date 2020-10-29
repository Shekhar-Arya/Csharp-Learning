// Inheritance means we can inherit one class or instance to other class,
// So that we use the content of the class or instance.

// Only one class can be inherited and multi instance can be inherited

// Inheritance is a concept of the IS-A like mammal IS A animal, dog IS A mammal,
// Hence dog IS A animal.

// Syntax is:
/*
<acess-specifier> class <base_class> {
   ...
}

class <derived_class> : <base_class> {
   ...
}
*/

// If having same name of the function or variable in the base class and inherited class then we can use 'base' keyword,
// to diffrentiate between name. 

// Example is as below:
// Simple inheritance concept
using System;
namespace inheritance
{
    public class Shape
    {
        public int width = 10;
        public int height = 10;
    }

    public class Rectangle : Shape
    {
        public void Display()
        {
            System.Console.WriteLine(width*height);
        }
    }

    // How to deal when we have constructor in base class
    public class circle
    {
        protected int radius;
        public circle(int r)
        {
            radius = r;
        }
        public void Show()
        {
            System.Console.WriteLine(radius);
        }
    }

    public class GiveCircleValue : circle
    {
        public GiveCircleValue(int r) : base(r){}
    }

    public class ExecuteAllClass
    {
        public static void Main(String[] args)
        {
            // working with Rectangle class
            Rectangle a = new Rectangle();
            a.Display();

            // Working with circle class
            GiveCircleValue b = new GiveCircleValue(20);
            b.Show();
        }
    }
}

