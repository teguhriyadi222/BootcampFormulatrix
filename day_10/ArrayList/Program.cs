
using System.Collections;

class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person data)
    {
        return Age.CompareTo(data.Age);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Masukkan jumlah data: ");
        int jumlah = int.Parse(Console.ReadLine());

        ArrayList peopleList = new ArrayList();
        Dictionary<int, Person> peopleDictionary = new Dictionary<int, Person>();

        for (int i = 0; i < jumlah; i++)
        {
            Console.WriteLine($"Data ke-{i + 1}");

            Console.Write("Nama: ");
            string name = Console.ReadLine();

            Console.Write("Umur: ");
            int age = int.Parse(Console.ReadLine());

            Person person = new Person { Name = name, Age = age };

            peopleList.Add(person);
            peopleDictionary.Add(i + 1, person);
        }

        Console.WriteLine("\nData yang telah dimasukkan (ArrayList):");

        // Mengurutkan data dalam ArrayList berdasarkan umur
        peopleList.Sort();

        foreach (Person person in peopleList)
        {
            Console.WriteLine($"Nama: {person.Name}, Umur: {person.Age}");
        }

        Console.WriteLine("\nData yang telah dimasukkan (Dictionary):");

        // Mengurutkan data dalam Dictionary berdasarkan umur
        List<Person> sortedPeople = new List<Person>(peopleDictionary.Values);
        sortedPeople.Sort();

        foreach (Person person in sortedPeople)
        {
            Console.WriteLine($"Nama: {person.Name}, Umur: {person.Age}");
        }
    }
}
