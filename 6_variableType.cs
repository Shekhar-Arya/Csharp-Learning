/* 
Integral types	sbyte, byte, short, ushort, int, uint, long, ulong, and char
Floating point types	float and double
Decimal types	decimal
Boolean types	true or false values, as assigned
Nullable types	Nullable data types 
*/

namespace variableType
{
    public class DeclareAndInitialize
    {
        public static void Main()
        {
            // Declaring the varibale
            int x;
            double y;
            string z;

            //Assinging the value to the variable
            x = 10;
            y = 10.0;
            z = "Hi how you are?";

            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(z);

        }
    } 
}