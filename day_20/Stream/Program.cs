using System;
using System.IO;
using System.Text;

class FileOperations
{
    private string FilePath;

    public FileOperations(string filePath)
    {
        FilePath = filePath;
    }

    public void WriteFile()
    {
        using (StreamWriter writer = new StreamWriter(FilePath, false))
        {
            string content = "This is a new file created in Create mode.";
            writer.Write(content);
            Console.WriteLine("File created successfully in Create mode.");
        }
    }

    public void OpenFile()
    {
        using (StreamReader reader = new StreamReader(FilePath))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine("File opened successfully in Open mode.");
            Console.WriteLine("Content: " + content);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string FilePath = "bootcamp.txt";
        FileOperations fileOperations = new FileOperations(FilePath);

        int choice;
        do
        {
            Console.WriteLine("File Operations Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Open");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    fileOperations.WriteFile();
                    break;
                case 2:
                    fileOperations.OpenFile();
                    break;
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue the program");
            Console.ReadLine();
        } while (choice != 0);
    }
}
