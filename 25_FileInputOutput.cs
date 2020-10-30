// File is a collection of data which stored in particualr path with specific name
// When file is open for writing or reading, it is called stream;
// input stram is for reading the file.
// out stream is for writing the file.

// FileStream class is used to read and write the class from any path.
// Example as below:

using System;
using System.IO;
namespace FileInputOutput
{
    public class WriteAndReadFile
    {
        public static void Main(String[] args)
        {
            FileStream F = new FileStream("sample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            for(int i = 0; i<5;i++)
            {
                F.WriteByte((byte)i);
            }
            for(int j=0; j<5; j++)
            {
            System.Console.WriteLine(F.ReadByte());
            }

            F.Close();
        }
    }
}
// Try to get better knowledge from other site(Its OK-OK)