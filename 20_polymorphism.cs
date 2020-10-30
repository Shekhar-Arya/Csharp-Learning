// Polymorphism meaning is having multiple form;
// Polymorphism is using of one method or content of the class in diferent class in differnt classes(something like this).
// two types of polymorphism 
// 1. Static polymorphism
// 2. Dynamic polymorphism

// Static polymorphism contains the function overloading
// Function overloading means having name of the function same but different paramteters passed in it,
// by which we can identify the methods

// Dynamic polymorphism contain the abstraction methos or virtual methods.
// Abstract class and its methods are only used by its derived class

 // Example as below for both:

 using System;
 namespace polymorphism
 {
     // This class is example of the static polymorphism with function overloading.
     public class FunctionOveroading
     {
         int x;
         double y;
         public void Get(int a)
         {
             x = a;
             System.Console.WriteLine(x);
         }
        public void Get(double b)
        {
            y = b;
            System.Console.WriteLine(y);
        }
    }

    // Dynamic Polymorphism
    // Using abstract class also we can have polymorphism as below class
    public abstract class AbstractExamplePolymorphism
    {
        public abstract void Display(string m);
    }

    public class ShowAbstractExamplePolymorphism : AbstractExamplePolymorphism
    {
        public override void Display(string m)
        {
            System.Console.WriteLine(m);
        }
    }

    public class ExecuteAll
    {
        public static void Main(String[] args)
        {
            // Functional overloading working
            FunctionOveroading f = new FunctionOveroading();
            f.Get(2);
            f.Get(2.2);

            // Static polymorphism working
            ShowAbstractExamplePolymorphism s = new ShowAbstractExamplePolymorphism();
            s.Display("Hi");
        }
    } 
 }