// namespace is the giving a different block to the code,
// so that class of the same name of two namespace does not match.

// Example is given as below:
// We can also have nested namespace

using System;
namespace FirstNamespace
{
    public class Display
    {
        public void Show()
        {
            System.Console.WriteLine("Hi");
        }
    }
}

namespace SecondNamspace
{
    public class Display
    {
        public void Show()
        {
            System.Console.WriteLine("How Are You");
        }
    }
}

public class Execute
{
    public static void Main(String[] args)
    {
        FirstNamespace.Display fd = new FirstNamespace.Display();
        SecondNamspace.Display sd = new SecondNamspace.Display();

        fd.Show();
        sd.Show();

    }
}