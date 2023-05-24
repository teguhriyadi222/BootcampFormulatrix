
class FooBar {

    public int N {get; set; }

    public FooBar(int n) {
        N = n;
    }

    public void Perintah() {

        for (int i = 1; i <= N; i++) {

            if (i % 3 == 0 && i % 5 == 0) {
                Console.Write("Foobar");
            } else if (i % 5 == 0) {

                Console.Write("Bar");

            } else if(i % 3 == 0) {

                Console.Write("Foo");

            } else {

                Console.Write(i);
            }

            Console.Write(",");

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