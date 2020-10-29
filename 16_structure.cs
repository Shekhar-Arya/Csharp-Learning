// Structre is the value type data type.
// It means that it is collection of different variable with diffirent data type.
// it can be made by struct keyword.

using System;
namespace structure
{
    // Defining Structure of the name Book:
    struct Book
    {
        public int srno;
        public string book_name;
        public double price;
    }
    public class StructureDefining
    {
        public static void Main(String[] args)
        {
            // Creating object of the book:
            Book book1;
            Book book2;
            
            // Assining the values to the book1 object
            book1.srno = 1;
            book1.book_name = "Gravity";
            book1.price = 10.2;

            // Assining the values to the book2 object
            book2.srno = 2;
            book2.book_name = "Universe";
            book2.price = 20.3;

            // Printing out the both objects.
            System.Console.WriteLine("{0} {1} {2}", book1.srno, book1.book_name, book1.price);
            System.Console.WriteLine("{0} {1} {2}", book2.srno, book2.book_name, book2.price);
        }
    }
}

//Important note to be come to eye

/*
classes are reference types and structs are value types
structures do not support inheritance
structures cannot have default constructor
*/

