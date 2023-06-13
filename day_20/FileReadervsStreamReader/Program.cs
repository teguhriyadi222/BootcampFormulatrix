using System;
using System.Diagnostics;
using System.IO;

class FileReader
{
    private string filePath;

    public FileReader(string filePath)
    {
        this.filePath = filePath;
    }

    public void ReadFile()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        using (StreamReader reader = new StreamReader(fs))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        stopwatch.Stop();
        Console.WriteLine("FileReader - Time: " + stopwatch.ElapsedMilliseconds);
    }
}

class StreamReader
{
    private string filePath;

    public StreamReader(string filePath)
    {
        this.filePath = filePath;
    }

    public void ReadFile()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        StreamReader streamReader = new StreamReader(filePath);

        Console.WriteLine("Content of the File");

        streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

        string strData = streamReader.ReadLine();

        while (strData != null)
        {
            Console.WriteLine(strData);
            strData = streamReader.ReadLine();
        }

        streamReader.Close();

        stopwatch.Stop();
        Console.WriteLine("StreamReader - Time: " + stopwatch.ElapsedMilliseconds);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string filePath = "sample.txt";

        FileReader fileReader = new FileReader(filePath);
        fileReader.ReadFile();

        Console.ReadKey();
        Console.Clear();

        StreamReader streamReader = new StreamReader(filePath);
        streamReader.ReadFile();

        Console.ReadKey();
    }
}
