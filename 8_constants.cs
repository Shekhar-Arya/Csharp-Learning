// There are different constants some of them are as below:
// character constants:
/*
Escape sequence	    Meaning
\\	                \ character
\'	                ' character
\"	                " character
\?	                ? character
\a	                Alert or bell
\b	                Backspace
\f	                Form feed
\n	                Newline
\r	                Carriage return
\t	                Horizontal tab
\v	                Vertical tab
\xhh . . .	        Hexadecimal number of one or more digits
*/

//Constant declaration Syntax:
// const <Data type> <Variable name> = Value;

using System;

    namespace constants
    {
        public class ConstantType
        {
            public static void Main(String[] args)
            {
                //character constant example..
                System.Console.WriteLine("This is chracter\'s \\ sequence Hello\tworld");

                // Example to create constant
                const double pi = 3.14;
                System.Console.WriteLine(pi);


            }
        }
    }
