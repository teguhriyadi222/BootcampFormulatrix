using System;
using System.Diagnostics;
using System.Threading;

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
            Thread thread1 = new Thread(PrintWelcomeMessage);
            Console.WriteLine();
           
            thread1.Name = "thread1";
            
            Thread thread3 = new Thread(() =>
            {
                Month selectedMonth = (Month)(monthNumber - 1);
                Weather weather = Weather.GetWeather(selectedMonth);
                Console.WriteLine($"{Thread.CurrentThread.Name} started.");
                Console.WriteLine($"Weather in {selectedMonth}: {weather.Description}");
                Console.WriteLine($"{Thread.CurrentThread.Name} finished.");
                Console.WriteLine();
            }
            );

            
            thread3.Name = "thread3";
            
        
            stopwatch.Stop();
            TimeSpan ThreadTime = stopwatch.Elapsed;
            Thread thread2 = new Thread(() => PrintTime(ThreadTime));
            
            thread2.Name = "thread2";
                 
            thread1.Start();
            thread3.Start();
            thread2.Start();

            thread1.Join();
            thread3.Join();
            thread2.Join();

            Console.WriteLine($"Program complate. Elapse time : {stopwatch.ElapsedMilliseconds} ms");
        }
        else
        {
            Console.WriteLine("Invalid month number.");
        }

    }
    static void PrintWelcomeMessage()
    {
        
        Console.WriteLine($"{Thread.CurrentThread.Name} started.");
        Console.WriteLine("Welcome to the Weather Program");
		Thread.Sleep(2000);
		Console.WriteLine($"{Thread.CurrentThread.Name} finished.");
        Console.WriteLine();
    }
    static void PrintTime(TimeSpan time)
    {  
        Console.WriteLine($"{Thread.CurrentThread.Name} started.");
        Console.WriteLine($"Execution Time: {time}");
		Thread.Sleep(2000);
		Console.WriteLine($"{Thread.CurrentThread.Name} finished.");
    }
}
