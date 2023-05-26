using System;

class Calculator
{
    private double value;

    public Calculator(double x)
    {
        value = x;
    }
    public static Calculator operator +(Calculator calculator, double number)
    {
        return new Calculator(calculator.value + number);
    }

    public static Calculator operator -(Calculator calculator, double number)
    {
        return new Calculator(calculator.value - number);
    }

    public static Calculator operator *(Calculator calculator, double number)
    {
        return new Calculator(calculator.value * number);
    }

    public static Calculator operator /(Calculator calculator, double number)
    {
        if (number == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return new Calculator(calculator.value / number);
    }

    public override string ToString()
    {
        return value.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator(10);

        calculator = calculator + 5;
        Console.WriteLine($"Penjumplahan: {calculator}");

        calculator = calculator - 3;
        Console.WriteLine($"Pengurangan: {calculator}");

        calculator = calculator * 2;
        Console.WriteLine($"Perkalian: {calculator}");

        calculator = calculator / 4;
        Console.WriteLine($"Pembagian: {calculator}");
        
    }
}
