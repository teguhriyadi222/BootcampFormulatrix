
using System;
using System.IO;
using System.Text;

class Program 
{
    static void Main(string[] args)
    {
        string FilePath = "bootcamp.txt";
        FileStream fileStream = new FileStream(FilePath,FileMode.Create);

        fileStream.Close();
        Console.Write("Success!");
    }
}