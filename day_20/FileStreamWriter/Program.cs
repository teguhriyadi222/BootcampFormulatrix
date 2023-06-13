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

    public void CreateNewFile()
    {
        try
        {
            using (FileStream fileStream = new FileStream(FilePath, FileMode.CreateNew))
            {
                string content = "This is a new file created in CreateNew mode.";
                byte[] bytes = Encoding.UTF8.GetBytes(content);
                fileStream.Write(bytes, 0, bytes.Length);
                Console.WriteLine("File created successfully in CreateNew mode.");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error creating file: " + ex.Message);
        }
    }

    public void CreateFile()
    {
        using (FileStream fileStream = new FileStream(FilePath, FileMode.Create))
        {
            string content = "This is a new file created in Create mode.";
            byte[] bytes = Encoding.UTF8.GetBytes(content);
            fileStream.Write(bytes, 0, bytes.Length);
            Console.WriteLine("File created successfully in Create mode.");
        }
    }

    public void OpenFile()
    {
        using (FileStream fileStream = new FileStream(FilePath, FileMode.Open))
        {
            byte[] buffer = new byte[fileStream.Length];
            fileStream.Read(buffer, 0, buffer.Length);
            string content = Encoding.UTF8.GetString(buffer);
            Console.WriteLine("File opened successfully in Open mode.");
            Console.WriteLine("Content: " + content);
        }
    }

    public void OpenOrCreateFile()
    {
        using (FileStream fileStream = new FileStream(FilePath, FileMode.OpenOrCreate))
        {
            byte[] buffer = new byte[fileStream.Length];
            fileStream.Read(buffer, 0, buffer.Length);
            string content = Encoding.UTF8.GetString(buffer);
            Console.WriteLine("File opened or created successfully in OpenOrCreate mode.");
            Console.WriteLine("Content: " + content);
        }
    }

    public void TruncateFile()
    {
        using (FileStream fileStream = new FileStream(FilePath, FileMode.Truncate))
        {
            Console.WriteLine("File truncated successfully in Truncate mode.");
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
            Console.WriteLine("1. CreateNew");
            Console.WriteLine("2. Create");
            Console.WriteLine("3. Open");
            Console.WriteLine("4. OpenOrCreate");
            Console.WriteLine("5. Truncate");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    fileOperations.CreateNewFile();
                    break;
                case 2:
                    fileOperations.CreateFile();
                    break;
                case 3:
                    fileOperations.OpenFile();
                    break;
                case 4:
                    fileOperations.OpenOrCreateFile();
                    break;
                case 5:
                    fileOperations.TruncateFile();
                    break;
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("klik enter to continue the program");
            Console.ReadLine();
        } while (choice != 0);
    }
}

