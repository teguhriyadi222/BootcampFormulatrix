
namespace person
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Crud 
    {
        public Dictionary<int, Person> people;
        public Crud()
        {
            people = new Dictionary<int, Person>();
        }

        public void Add(int key, Person person)
        {
            people.TryAdd(key, person);
        }

        public void Remove(int key)
        {
            if (people.ContainsKey(key))
            {
                people.Remove(key);
            }
            else 
            {
                Console.WriteLine("Data Tidak Ditemukan");
            }

        }

        public void Update(int key, Person updated)
        {
            if (people.ContainsKey(key))
            {
                people[key] = updated;
            }
            else
            {
                Console.WriteLine("Data tidak ditemukan.");
            }
        }
    }

}