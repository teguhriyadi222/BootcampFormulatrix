using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        int c;

        AddNumbers(a, b, out c);
        Console.WriteLine("Hasil penjumlahan: " + c);

        MultiplyNumbers(ref a, ref b);
        Console.WriteLine("Hasil perkalian: " + a + " dan " + b);

        DivideNumbers(in a, in b);
        Console.WriteLine("Hasil pembagian:" + a + " dan " + b);

        string numberAsString = "saya";
        int number;
        if (Int32.TryParse(numberAsString, out number))
            Console.WriteLine($"Converted '{numberAsString}' to {number}");
        else
            Console.WriteLine($"Unable to convert '{numberAsString}'");

        int panjang, lebar, tinggi;

        string input ;

        Console.WriteLine("masukkan panjang: ");
        input = Console.ReadLine();
        int.TryParse(input, out panjang);

        Console.WriteLine("masukkan lebar: ");





    }

    static void AddNumbers(int x, int y, out int result)
    {
        result = x + y + 30;
    }

    static void MultiplyNumbers(ref int x, ref int y)
    {
        x = x * 2;
        y = x * 3;
    }

    static int DivideNumbers(in int x, in int y)
    {
        return (x / y);
    }
}
