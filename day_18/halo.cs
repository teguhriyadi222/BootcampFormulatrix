// using System;
// using System.Diagnostics;
// using System.Threading;

// enum Month
// {
//     // definisi enum Month
// }

// class Weather
// {
//     // definisi kelas Weather
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Welcome to the Weather Program");
//         // Menampilkan pilihan bulan ...

//         int monthNumber = int.Parse(Console.ReadLine());

//         if (monthNumber >= 1 && monthNumber <= 12)
//         {
//             Month selectedMonth = (Month)(monthNumber - 1);

//             Stopwatch stopwatch = new Stopwatch();

//             // Membuat thread pertama untuk mencetak teks selamat datang
//             Thread welcomeThread = new Thread(PrintWelcomeMessage);
//             stopwatch.Start();
//             welcomeThread.Start();

//             Weather weather = Weather.GetWeather(selectedMonth);

//             Console.WriteLine($"Weather in {selectedMonth}: {weather.Description}");

//             // Menunggu thread pertama selesai
//             welcomeThread.Join();

//             stopwatch.Stop();
//             TimeSpan welcomeThreadTime = stopwatch.Elapsed;
//             stopwatch.Reset();

//             // Membuat thread kedua untuk mencetak waktu eksekusi thread pertama
//             Thread timeThread = new Thread(() => PrintExecutionTime(welcomeThreadTime));
//             stopwatch.Start();
//             timeThread.Start();

//             // Menghitung waktu eksekusi thread kedua
//             stopwatch.Stop();
//             TimeSpan timeThreadTime = stopwatch.Elapsed;

//             Console.WriteLine($"Execution Time of Welcome Thread: {welcomeThreadTime}");
//             Console.WriteLine($"Execution Time of Time Thread: {timeThreadTime}");
//         }
//         else
//         {
//             Console.WriteLine("Invalid month number.");
//         }

//     }

//     static void PrintWelcomeMessage()
//     {
//         Console.WriteLine("Printing welcome message...");
//         Console.WriteLine("Welcome to the Weather Program");
//         Console.WriteLine();
//     }

//     static void PrintExecutionTime(TimeSpan time)
//     {
//         Console.WriteLine($"Execution Time: {time}");
//     }
// }
