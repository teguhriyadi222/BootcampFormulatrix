using System;

// Contoh kelas (class)
public struct Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void SayHello()
    {
        Console.WriteLine("Hello, my name is " + Name + " and I'm " + Age + " years old.");
    }
}

// Contoh struktur (struct)
public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void DisplayCoordinates()
    {
        Console.WriteLine("Coordinates: (" + X + ", " + Y + ")");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Penggunaan kelas
        Person person = new Person();
        person.Name = "John";
        person.Age = 25;
        person.SayHello();

        // Penggunaan struktur
        Point point = new Point(10, 20);
        point.DisplayCoordinates();
    }
}
