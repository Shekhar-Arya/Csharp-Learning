// Exceptional handling is used for any type of the error.
// It works like try{} block if it doesnt excute than run catch{} block or in last run finally{}.

// There are already some inbuilt class of the exception which we use to write the code
// Example as below:

using System;
namespace ExceptionalHandling
{
    public class InbuiltExceptionExample
    {
        int x;
        int y;

        public double devideandAnswer(int a, int b)
        {
            x = a;
            y = b;
            return x/y;
        }
        public static void Main(String[] args)
        {
            double result = 0.0;
            InbuiltExceptionExample i = new InbuiltExceptionExample();
            try
            {
                result = i.devideandAnswer(10,0);
            }
            catch(DivideByZeroException e)
            {
                System.Console.WriteLine(e);
            }
            finally
            {
                System.Console.WriteLine(result);
            }
        }
    }
}


