
namespace Date;

class Program 
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        DateTimeCurrent time = new DateTimeCurrent(date);
        string x = time.CurrentDatetime();
        Console.WriteLine("tanggal dan waktu saat ini adalah :");
        Console.WriteLine(x);

        //add days

        DateTime days = time.AddDays(5);
        Console.WriteLine("waktu setelah ditambahkan:"); 
        Console.WriteLine(days);

        // remove days

        DateTime remove = time.SubtractDays(2);
        Console.WriteLine("waktu setelah dikurangi"); 
        Console.WriteLine(remove);

        DateTime dt1 = new DateTime (2010, 1, 1, 1, 1, 1, TimeSpan.FromHours(8));
        DateTime dt2 = new DateTime (2010, 2, 1, 1, 1, 1, TimeSpan.FromHours(6));

        TimeSpan dt3 = dt1 + dt2;
        
    }
}