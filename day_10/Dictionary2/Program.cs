using System;
using System.Collections;
using System.Collections.Generic;

namespace PersonNamespace
{
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

            ArrayList peopleList = new ArrayList();

            for (int i = 0; i < jumlah; i++)
            {
                Console.WriteLine($"Data ke-{i + 1}");

                Console.Write("Nama: ");
                string name = Console.ReadLine();

                Console.Write("Umur: ");
                int age = int.Parse(Console.ReadLine());

                Person person = new Person { Name = name, Age = age };

                peopleList.Add(person);
            }

            Console.WriteLine("\nData sebelum diurutkan (ArrayList):");

            foreach (Person person in peopleList)
            {
                Console.WriteLine($"Nama: {person.Name}, Umur: {person.Age}");
            }

            List<Person> people = new List<Person>(peopleList.Count);
            foreach (Person person in peopleList)
            {
                people.Add(person);
            }

            people.Sort((x, y) => x.Name.CompareTo(y.Name));

            Console.WriteLine("\nData setelah diurutkan (ArrayList):");

            foreach (Person person in people)
            {
                Console.WriteLine($"Nama: {person.Name}, Umur: {person.Age}");
            }
        }
    }
}
