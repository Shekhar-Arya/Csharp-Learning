//There are two types of the Type conversion in C#
// 1 Implicit conversion
// 2 Explicit conversion

// Implicit conversion is done by assiging int variable to double varibale like eg as follow:
// Explicit conversion is done by the Functions that convert the variable from one type to another eg as below in Explicit class.
using System;

namespace typeConversion
{
    public class ImplicitFunc
    {
        public static void Main(String[] args)
        {
            //Implicit
            int x = 10;
            double y = x;
            System.Console.WriteLine(x);
            System.Console.WriteLine(y);

            // Explicit
            System.Console.WriteLine(x.ToString());
            int z = (int)y;
            System.Console.WriteLine(z);

        }
    }
}

/* Main Conversion functions are:
1	
ToBoolean

Converts a type to a Boolean value, where possible.

2	
ToByte

Converts a type to a byte.

3	
ToChar

Converts a type to a single Unicode character, where possible.

4	
ToDateTime

Converts a type (integer or string type) to date-time structures.

5	
ToDecimal

Converts a floating point or integer type to a decimal type.

6	
ToDouble

Converts a type to a double type.

7	
ToInt16

Converts a type to a 16-bit integer.

8	
ToInt32

Converts a type to a 32-bit integer.

9	
ToInt64

Converts a type to a 64-bit integer.

10	
ToSbyte

Converts a type to a signed byte type.

11	
ToSingle

Converts a type to a small floating point number.

12	
ToString

Converts a type to a string.

13	
ToType

Converts a type to a specified type.

14	
ToUInt16

Converts a type to an unsigned int type.

15	
ToUInt32

Converts a type to an unsigned long type.

16	
ToUInt64

Converts a type to an unsigned big integer. */