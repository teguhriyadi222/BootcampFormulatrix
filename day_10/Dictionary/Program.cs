using System.Collections;
namespace person;
class Program
{
    static void Main()
    {
        Console.WriteLine("Masukkan jumlah data: ");
        int jumlah = int.Parse(Console.ReadLine());
        ArrayList peopleList = new ArrayList();

        Crud crud = new Crud();

        for (int i = 0; i < jumlah; i++)
        {
            Console.WriteLine($"Data ke-{i + 1}");

            Console.Write("Nama: ");
            string name = Console.ReadLine();

            Console.Write("Umur: ");
            int age = int.Parse(Console.ReadLine());

            Person person1 = new Person { Name = name, Age = age };

            peopleList.Add(person1);
            crud.Add(i + 1, person1);
        }

        Console.WriteLine("panjang data " + peopleList.Count);

        Console.WriteLine("\nData dalam ArrayList:");

        foreach (Person x in peopleList)
        {
            Console.WriteLine($"Nama: {x.Name}, Umur: {x.Age}");
        }

        Console.WriteLine("\nData dalam Dictionary:");

        foreach (KeyValuePair<int, Person> kvp in crud.people)
        {
            Console.WriteLine($"Key= {kvp.Key}, Value = (Nama: {kvp.Value.Name}, Umur: {kvp.Value.Age})");
        }

        Person person = new Person{Name = "naruto", Age = 30};
        crud.Update(2,person);

        Console.WriteLine("\nData dalam Dictionary setelah diupdate:");

            foreach (KeyValuePair<int, Person> kvp in crud.people)
            {
                Console.WriteLine($"Key= {kvp.Key}, Value = (Nama: {kvp.Value.Name}, Umur: {kvp.Value.Age})");
            }

        crud.Remove(1);

        Console.WriteLine("\nData Dictionary setelah dihapus");
        foreach ( KeyValuePair<int, Person> kvp in crud.people )
        {
            Console.WriteLine($"Key= {kvp.Key}, Value = (Nama: {kvp.Value.Name}, Umur: {kvp.Value.Age})");
        }


            ArrayList myClones = (ArrayList)peopleList.Clone();

            Console.WriteLine("\nData clone dari array list:");

            foreach (Person y in myClones)
            {
                Console.WriteLine($"Nama: {y.Name}, Umur: {y.Age}");
            }

        

    }
}
