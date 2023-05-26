using System;

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

    public static Weather operator +(Weather weather1, Weather weather2)
    {
        Month combinedMonth = weather1.Month;
        string combinedDescription = weather1.Description + " and " + weather2.Description;
        return new Weather(combinedMonth, combinedDescription);
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the number of a month (1-12):");
            int monthNumber = int.Parse(Console.ReadLine());

            if (monthNumber >= 1 && monthNumber <= 12)
            {
                Month selectedMonth = (Month)(monthNumber - 1);
                Weather weather1 = Weather.GetWeather(selectedMonth);
                Weather weather2 = Weather.GetWeather(selectedMonth + 1);

                if (weather1 != null && weather2 != null)
                {
                    Weather combinedWeather = weather1 + weather2;
                    Console.WriteLine($"Weather in {selectedMonth}: {combinedWeather.Description}");
                }
                else
                {
                    Console.WriteLine("No weather information available for the selected months.");
                }
            }
            else
            {
                Console.WriteLine("Invalid month number.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
