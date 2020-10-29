// Class is like the model of the thing which encloses all the material and design. 
//which we can use many times by creating its object.

// Classes have access specifier which gives the behaviour of the class as discussed in the access specifier module.

// Class content should have public access specifier so that we can access it outside the class from another class.

// If the class is static then we cannot create different object of the class.
// we just have one object that is its basic constructer and by using class name we can access the content.
// And same woerk for the contant of the class, if they are too static than we cannot access with the diffrent object.


using System;
namespace Classes
{   
    // Simple way of the object creating and working with it
    // Defining the class for the variables
    public class Information
    {
        public int rollnumber;
        public string name;
        public double percentage;
    }

    // Defining the class to get value and Display it. 
    public class Display
    {
        public static void Main(String[] args)
        {
            // Information Class working
            Information info = new Information();
            info.rollnumber = 1;
            info.name = "Shekhar";
            info.percentage = 30.1;       
            System.Console.WriteLine("{0} {1} {2}", info.rollnumber, info.name, info.percentage);

            // GetAndDisplay Class working
            GetAndDisplay second = new GetAndDisplay();
            second.getValues(1, "hi", 3.3);
            second.show();

            //Working for  passing value in Constructor
            ConstructorValuePassing con = new ConstructorValuePassing(10,20);
            con.popup();

        } 
        
    }

    // Creating a class with the private access specifier variable and working with it
    public class GetAndDisplay
    {
        private int x;
        private string y;
        private double z;

        public void getValues(int a, string b, double c)
        {
            x = a;
            y = b;
            z = c;
        }

        public void show()
        {
            System.Console.WriteLine("{0} {1} {2}", x, y, z);
        }        
    }

    // Passing values through the constructer
    public class ConstructorValuePassing
    {
        int m;
        int n;

        public ConstructorValuePassing(int m, int n)
        {
            this.m = m;
            this.n = n;
        }

        public void popup()
        {
            System.Console.WriteLine("{0} {1}", m,n);
        }
    }
}
