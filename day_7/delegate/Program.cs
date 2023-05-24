delegate void CalculateTotal(int total);

class Kasir
{
    public void HitungTotal(int total)
    {
        int diskon = (int)(total * 0.1);
        int totalSemua = total - diskon;
        Console.WriteLine("Total pembayaran dengan diskon: Rp." + totalSemua);
    }

    public void HitungPajak(int total)
    {
        int pajak = (int)(total * 0.2);
        Console.WriteLine("Pajak: Rp." + pajak);
    }
}

class Program
{
    static void Main()
    {
        Kasir kasir = new Kasir();

        CalculateTotal calculateTotal = kasir.HitungTotal;
        calculateTotal += kasir.HitungPajak;

        Console.Write("Masukkan total semua belanjaan: Rp. ");
        int totalbelanjaan = int.Parse(Console.ReadLine());

        calculateTotal(totalbelanjaan);
    }
}
