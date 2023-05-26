
class Program {

    public static void Main()
    {
        int x = 0;
        int y = 0;
        try
        {
            y = 100 / x;
            Console.WriteLine("Not executed line");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("DivideByZeroException");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception");
        }
        finally
        {
            Console.WriteLine("Finally Block");
        }
        Console.WriteLine($"Result is {y}");
    }
}