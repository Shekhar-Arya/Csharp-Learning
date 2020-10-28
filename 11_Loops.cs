/*
Different loops are as follow:
1 for loop
2 while loop
3 do while loop
4 nested loop
5 foreach used in array or lists, dictioneries
*/

using System;
namespace Loops
{
    public class LoopsExample
    {
        public static void Main(String[] args)
        {
            string[] weeks = {"Monday", "Tuesday", "Wednesday", "Thurseday", "Friday", "Saturday", "Sunday"};
            
            // For loop example
            for (int i = 0; i<weeks.Length; i++)
            {
                System.Console.WriteLine(weeks[i]);
            }
            System.Console.WriteLine("____________________________________________");

            // While loop example
            int b = weeks.Length-1;
            while(b>=0)
            {
                System.Console.WriteLine(weeks[b]);
                b--;
            }
            System.Console.WriteLine("____________________________________________");

            // Example of do while loop
            int a = 0;
            int range = weeks.Length -2;
            do{
                System.Console.WriteLine(weeks[a]);
                a++;
            } while (a<range);

            System.Console.WriteLine("____________________________________________");
            //Example of foreach loop
            foreach (var day in weeks)
            {
                System.Console.WriteLine(day);
            }
        }
    }
}