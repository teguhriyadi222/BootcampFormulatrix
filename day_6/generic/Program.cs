

class Program
{
    static void Main()
    {
        Calculator<int> calculator = new Calculator<int>();
        int a = 5;
        int b = 10;
        int sum = calculator.penjumplahan(a, b);
        Console.WriteLine("Hasil penjumlahan: " + sum);

    }
}

class Calculator<T> where T : struct
{
    private T sum;
    public T penjumplahan(T x, T y)
    {
        dynamic dx = x;
        dynamic dy = y;
        return dx + dy;
    }
}

// class gabungkata<T> where T : class
// {
//     public string gabungkata2(T x, T y)
//     {
//         dynamic dx = x;
//         dynamic dy = y;
//         return dx.ToString() + dy.ToString();
//     }
// }
