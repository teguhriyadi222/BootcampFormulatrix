using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

enum Month
{
    January,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}

class Weather
{
    public Month Month { get; set; }
    public string Description { get; set; }

    public Weather(Month month, string description)
    {
        Month = month;
        Description = description;
    }

    public Weather()
    {

    }

    public static Weather GetWeather(Month month)
    {
        switch (month)
        {
            case Month.January:
            case Month.February:
                return new Weather(month, "Summer.");
            case Month.March:
            case Month.April:
            case Month.May:
                return new Weather(month, "Winter.");
            case Month.June:
            case Month.July:
            case Month.August:
                return new Weather(month, "Sunny.");
            case Month.September:
            case Month.October:
            case Month.November:
            case Month.December:
                return new Weather(month, "Spring.");
            default:
                return null;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Weather Program");
        Console.WriteLine("1.January");
        Console.WriteLine("2.February");
        Console.WriteLine("3.March");
        Console.WriteLine("4.April");
        Console.WriteLine("5.May");
        Console.WriteLine("6.June");
        Console.WriteLine("7.July");
        Console.WriteLine("8.August");
        Console.WriteLine("9.September");
        Console.WriteLine("10.October");
        Console.WriteLine("11.November");
        Console.WriteLine("12.December");
        Console.WriteLine("Enter the number of a month (1-12):");

        int monthNumber = int.Parse(Console.ReadLine());

        if (monthNumber >= 1 && monthNumber <= 12)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Task task1 = Task.Run(() => PrintWelcomeMessage());
            Task task2 = Task.Run(() => PrintTime(stopwatch.Elapsed));

            Month selectedMonth = (Month)(monthNumber - 1);
            Weather weather = Weather.GetWeather(selectedMonth);
            Console.WriteLine($"Weather in {selectedMonth}: {weather.Description}");

            Task.WaitAll(task1, task2);

            stopwatch.Stop();

            Console.WriteLine($"IsCompleted: {task1.IsCompleted}");
            Console.WriteLine($"IsFaulted: {task1.IsFaulted}");
            Console.WriteLine($"IsCanceled: {task1.IsCanceled}");
            Console.WriteLine($"Program complete. Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
        }
        else
        {
            Console.WriteLine("Invalid month number.");
        }
    }

    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Weather Program");
        Console.WriteLine();
    }

    static void PrintTime(TimeSpan time)
    {
        Console.WriteLine($"Execution Time: {time}");
    }
}
