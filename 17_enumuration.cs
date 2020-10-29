// Enumuration is a type of data type which stores the data and works like tuple as in python(Maybe)

//Syntax; enum weekDays {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};

// Enum must be declared in the class outside of the main method or any method.

using System;
namespace enumuration
{
    public class EnumurationExample
    {
        enum weeks
            {
                Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
            }

        public static void Main(String[] args)
        {
            int first = (int)weeks.Monday;
            int last = (int)weeks.Sunday;
            System.Console.WriteLine("Monday is {0}\nTuesday is {1}", first,last);
        }
    }
}