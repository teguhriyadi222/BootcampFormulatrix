

class Program
{
    static void Main(string[] args)
    {
        // Ekspresi Implisit
        int a = 10;
        double b = a; // Konversi implisit dari int ke double
        Console.WriteLine(b); // Output: 10.0

        float c = 5.5f;
        double d = c; // Konversi implisit dari float ke double
        Console.WriteLine(d); // Output: 5.5

        Console.WriteLine();

        // Ekspresi Eksplisit
        double x = 10.5;
        int y = (int)x; // Konversi eksplisit dari double ke int
        Console.WriteLine(y); // Output: 10

        float m = 4.7f;
        int n = Convert.ToInt32(m); // Konversi eksplisit dari float ke int menggunakan metode Convert.ToInt32()
        Console.WriteLine(n); // Output: 4

        Console.WriteLine();

        // Konversi Tipe Objek
        object obj = 20;
        int number = (int)obj; // Konversi eksplisit dari tipe objek ke int
        Console.WriteLine(number); // Output: 20

        object value = "42";
        int result = Int32.Parse(value.ToString()); // Konversi eksplisit dari string ke int menggunakan metode Parse()
        Console.WriteLine(result); // Output: 42

        Console.WriteLine();

        // Konversi Tipe Enum
        enum DayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

        int dayValue = 2;
        DayOfWeek day = (DayOfWeek)dayValue; // Konversi eksplisit dari int ke enum DayOfWeek
        Console.WriteLine(day); // Output: Tuesday

        DayOfWeek weekendDay = DayOfWeek.Saturday;
        int weekendValue = (int)weekendDay; // Konversi eksplisit dari enum DayOfWeek ke int
        Console.WriteLine(weekendValue); // Output: 6
    }
}
