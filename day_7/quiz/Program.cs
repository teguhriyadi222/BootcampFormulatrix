
class FooBar {

    public int Jumlah {get; set; }

    public FooBar(int n) {
        Jumlah = n;
    }

    public void Perintah() 
    {
         Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {1, "foo"},
                {2, "bar"},
            };


        for (int i = 1; i <= Jumlah; i++) 
        {
            string output = "";

            foreach (var item in dict)
            {
                if (i % item.key == 0)
                {
                    output += item.value;
                }
                if (string.IsNullOrEmpty(output))
                {
                    output = i.ToString();
                }
            }
        }

    }
}

class Program {

    static void Main() {

    
        Console.WriteLine("masukan nilai n : ");
        int n = int.Parse(Console.ReadLine());
        FooBar bar = new FooBar(n);
        bar.Perintah();

    }


}