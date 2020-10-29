// Methosd is the block of code that executes when it is called.
// First define the method, then call it when and where you wabnt to use it.

// Syntax of defining the method:
/* <Access Specifier> <Return Type> <Method Name>(Parameter List) {
   Method Body
}*/

// types of methods are shown below:

using System;
namespace methods
{
    public class Example_of_methods 
    {
        // Defining No return type no parameters method
        public void Method_1()
        {
            System.Console.WriteLine("Hi How are you!");
        }

        // Defining no return type with parameter mehod
        public void Method_2(String x)
        {
            System.Console.WriteLine(x);
        }

        // Dfining return type with no parameter method
        public String Method_3()
        {
            return "Hey there!";
        }

        // Defining return type with parameter method
        public String Method_4(string y)
        {
            return y;
        }

        // Main method
        public static void Main(String[] args)
        {
            Example_of_methods meth = new Example_of_methods();
            meth.Method_1();
            meth.Method_2("abcd");
            System.Console.WriteLine(meth.Method_3());
            System.Console.WriteLine(meth.Method_4("mnop"));
        }

    }
}