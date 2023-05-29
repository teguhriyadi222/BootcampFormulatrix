

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Masukkan jumlah data: ");
        int jumlah = int.Parse(Console.ReadLine());

        ArrayList people = new ArrayList();

        for (int i = 0; i < jumlah; i++)
        {
            Console.WriteLine($"Data ke-{i + 1}");

            Console.Write("Nama: ");
            string name = Console.ReadLine();

            Console.Write("Umur: ");
            int age = int.Parse(Console.ReadLine());

            Person person = new Person { Name = name, Age = age };
            people.Add(person);
        }

        Console.WriteLine("\nData:");

        foreach (Person person in people)
        {
            Console.WriteLine($"Nama: {person.Name}, Umur: {person.Age}");
        }

        Console.WriteLine("jumlah" + people.Count);
        Console.WriteLine(" index ke 1" + people[1]);
    }
}
