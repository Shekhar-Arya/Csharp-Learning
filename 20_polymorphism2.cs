// This module is for the polymorphism by using virtual keyword;
// Vitual keyword work same as abstract 

using System;
namespace Polymorphism2
{
    public class Animal
    {
        public virtual void Display()
        {
            System.Console.WriteLine("Im am Animal");
        }
    }

    public class Dog : Animal
    {
        public override void Display()
        {
            System.Console.WriteLine("I m Dog");
        }
    }

    public class Cow : Animal
    {
        public override void Display()
        {
            System.Console.WriteLine("I m Cow");
        }
    }

    public class Show
    {
        public void s(Animal a)
        {
            a.Display();
            System.Console.WriteLine("I m Animal");
        }
    }

    public class Execute
    {
        public static void Main(String[] args)
        {
            Show s = new Show();

            Dog d = new Dog();
            d.Display();

            Cow c = new Cow();
            c.Display();

            s.s(d);
            s.s(c);

        }
    }
}