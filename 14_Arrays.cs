// Arrays is collection of data of same type with the fixed length of the size.

// Declare array, then initialize it, then Assign the value to the array,then access the value.

// Eg as below:

using System;
namespace Array
{
    public class ArraysExample
    {
        public static void Main(String[] args)
        {
            //Declaring the array
            int[] numbers;

            // Initializing the array, here 3 represesnts size of the array
            numbers = new int[3];

            // Assining the value
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            // Accessing the value of the array
            System.Console.WriteLine(numbers[0]);

            // All togather
            String[] weeks = {"Monday", "Tuesday"};
            //Or
            String[] x = new String[3];

            //Foreach loop
            foreach(var q in weeks)
            {
                System.Console.WriteLine(q);
            }

            // Multi-Dimensional Array
            int[,] a = new int[2,2]{
                {1,2},
                {3,4}
            };

            // Jagged array is the array of arrays eg. as below:
            int[][] b = new int[2][]{new int[]{1,2}, new int[]{3,4}};
            for(int i = 0; i<b.Length; i++)
            {
                foreach(var e in b[i])
                {
                    System.Console.WriteLine(e);
                }
            }

        }
    }
}

/*
Properties of the Array Class
1	
IsFixedSize
Gets a value indicating whether the Array has a fixed size.

2	
IsReadOnly
Gets a value indicating whether the Array is read-only.

3	
Length
Gets a 32-bit integer that represents the total number of elements in all the dimensions of the Array.

4	
LongLength
Gets a 64-bit integer that represents the total number of elements in all the dimensions of the Array.

5	
Rank
Gets the rank (number of dimensions) of the Array.


-->Methods of the Array Class
1	
Clear
Sets a range of elements in the Array to zero, to false, or to null, depending on the element type.

2	
Copy(Array, Array, Int32)
Copies a range of elements from an Array starting at the first element and pastes them into another Array starting at the first element. The length is specified as a 32-bit integer.

3	
CopyTo(Array, Int32)
Copies all the elements of the current one-dimensional Array to the specified one-dimensional Array starting at the specified destination Array index. The index is specified as a 32-bit integer.

4	
GetLength
Gets a 32-bit integer that represents the number of elements in the specified dimension of the Array.

5	
GetLongLength
Gets a 64-bit integer that represents the number of elements in the specified dimension of the Array.

6	
GetLowerBound
Gets the lower bound of the specified dimension in the Array.

7	
GetType
Gets the Type of the current instance. (Inherited from Object.)

8	
GetUpperBound
Gets the upper bound of the specified dimension in the Array.

9	
GetValue(Int32)
Gets the value at the specified position in the one-dimensional Array. The index is specified as a 32-bit integer.

10	
IndexOf(Array, Object)
Searches for the specified object and returns the index of the first occurrence within the entire one-dimensional Array.

11	
Reverse(Array)
Reverses the sequence of the elements in the entire one-dimensional Array.

12	
SetValue(Object, Int32)
Sets a value to the element at the specified position in the one-dimensional Array. The index is specified as a 32-bit integer.

13	
Sort(Array)
Sorts the elements in an entire one-dimensional Array using the IComparable implementation of each element of the Array.

14	
ToString
Returns a string that represents the current object. (Inherited from Object.)
*/