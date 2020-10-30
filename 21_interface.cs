// interface is same as the abstract. But abstract us used for the small content purpose while,
// interface is used for the large scale purpose.

// Interface only defines the structure of the methods content of the methods are define in the class in which it is inherited.
// We can inherit as many interface as we want.

// Interface is collection of properties, methods, and events as many as we want.
// Then we can inherit inetrface to use all its content.

// Exmple of interface is as below:

using System;
namespace Interface
{
    // defining the interface and its content methods
    public interface IAllMethods
    {
        void Show();
        void GetValues(int rollno, string name);
    }

    public class ExecuteAll : IAllMethods
    {
        int srno;
        string fullName;
        public void Show()
        {
            System.Console.WriteLine("{0} {1}", srno,fullName);
        }

        public void GetValues(int x, string y)
        {
            srno = x;
            fullName = y;
        }
        public static void Main(String[] args)
        {
            ExecuteAll e = new ExecuteAll();
            e.GetValues(1,"Shekhar Arya");
            e.Show();
        }
    }
}