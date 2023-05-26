using System;

class DateTimeManipulator
{
    private DateTime dateTime;

    public DateTimeManipulator(DateTime inputDateTime)
    {
        dateTime = inputDateTime;
    }

    public string GetCurrentDateTime()
    {
        return dateTime.ToString();
    }

    public string GetFormattedDateTime(string format)
    {
        return dateTime.ToString(format);
    }

    public DateTime AddDays(int days)
    {
        return dateTime.AddDays(days);
    }

    public DateTime AddHours(int hours)
    {
        return dateTime.AddHours(hours);
    }

    public DateTime AddMinutes(int minutes)
    {
        return dateTime.AddMinutes(minutes);
    }

    public DateTime AddSeconds(int seconds)
    {
        return dateTime.AddSeconds(seconds);
    }

    public DateTime SubtractDays(int days)
    {
        return dateTime.AddDays(-days);
    }

    public DateTime SubtractHours(int hours)
    {
        return dateTime.AddHours(-hours);
    }

    public DateTime SubtractMinutes(int minutes)
    {
        return dateTime.AddMinutes(-minutes);
    }

    public DateTime SubtractSeconds(int seconds)
    {
        return dateTime.AddSeconds(-seconds);
    }
}

class Program
{
    static void Main()
    {
        DateTime currentDateTime = DateTime.Now;

        DateTimeManipulator manipulator = new DateTimeManipulator(currentDateTime);

        // Menampilkan waktu saat ini
        Console.WriteLine("Waktu saat ini:");
        string currentDateTimeStr = manipulator.GetCurrentDateTime();
        Console.WriteLine(currentDateTimeStr);
        Console.WriteLine();

        // Menambahkan waktu
        DateTime futureDateTime = manipulator.AddDays(5);
        Console.WriteLine("Waktu setelah ditambah 5 hari:");
        Console.WriteLine(futureDateTime.ToString());
        Console.WriteLine();

        // Mengurangi waktu
        DateTime pastDateTime = manipulator.SubtractHours(3);
        Console.WriteLine("Waktu sebelum dikurangi 3 jam:");
        Console.WriteLine(pastDateTime.ToString());
        Console.WriteLine();

        // Format waktu
        string formattedDateTime = manipulator.GetFormattedDateTime("yyyy-MM-dd HH:mm:ss");
        Console.WriteLine("Waktu dengan format khusus (yyyy-MM-dd HH:mm:ss):");
        Console.WriteLine(formattedDateTime);
        Console.WriteLine();

        // Tunggu hingga pengguna menekan tombol untuk keluar dari program
        Console.WriteLine("Tekan tombol apapun untuk keluar...");
        Console.ReadKey();
    }
}
