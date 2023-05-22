namespace Namespace
{
	static class Program
	{
		static void Main()
		{
			const int a = 5;
			const string b = "Hello";
            const int c = 8;

			(int z, string d, int e) = MyMethod(a, b, c);
			Console.WriteLine($"c={z}, d={d}, e={e}");
			
			(int, string, int) tuple = MyMethod(a, b, c);
			Console.WriteLine($"tuple.Item1={tuple.Item1}, tuple.Item2={tuple.Item2}");

			int x = MyMethodInt(a);
			Console.WriteLine(x);
		}

		static (int, string, int) MyMethod(int a, string b, int c)
		{
			return (a, b, c);
		}
		static int MyMethodInt(int a)
		{
			return a;
		}
	}
}