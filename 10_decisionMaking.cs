// 1 if - else
// 2 switch case
// 3 conditional operator ?:

// Example as below:

using System;
namespace decisionMaking
{
    public class DesicionsExample
    {
        public static void Main(String[] args)
        {
            int a = 10;
            int b = 20;
            // Example of if-else
            if (a>b)
            {
                System.Console.WriteLine(a);
            }
            else
            {
                System.Console.WriteLine(b);
            }

            // switch case Example
            switch (a)
            {
                case 10:
                System.Console.WriteLine("Hello");
                break;

                case 30:
                System.Console.WriteLine("Bye");
                break;
                
                default:
                System.Console.WriteLine("Nothing");
                break;
            }

            //Conditional Operator Example
            string x = a<b?"Hi":"Bye";
            System.Console.WriteLine(x);
        }
        
    }
    
}