// Till now we are talking about the inbuilt exception,
// We will create our own exception known as exceptional handling

// creating user defined exception

using System;
namespace UserDefinedException
{
    public class throwException
    {
        int x;
        public void getvalue(int a)
        {
            if (a == 0)
            {
                // Throwing the user defind exception
                throw(new ValueIsZero("Entered value should not be zero"));
            }
            else
            {
                x = a;
            }   
        }
    }

    public class ValueIsZero : Exception
    {
        public ValueIsZero(string m) : base(m){}
    }

    public class ExecuteAllException
    {
        public static void Main(String[] args)
        {
            throwException th = new throwException();
            try{
                th.getvalue(0);
            }
            catch(ValueIsZero e)
            {
                System.Console.WriteLine(e.Message);
            }

            
        }
    }
}

// Some of the exceptional handling class
/*
1	
System.IO.IOException
Handles I/O errors.

2	
System.IndexOutOfRangeException
Handles errors generated when a method refers to an array index out of range.

3	
System.ArrayTypeMismatchException
Handles errors generated when type is mismatched with the array type.

4	
System.NullReferenceException
Handles errors generated from referencing a null object.

5	
System.DivideByZeroException
Handles errors generated from dividing a dividend with zero.

6	
System.InvalidCastException
Handles errors generated during typecasting.

7	
System.OutOfMemoryException
Handles errors generated from insufficient free memory.

8	
System.StackOverflowException
Handles errors generated from stack overflow.
*/