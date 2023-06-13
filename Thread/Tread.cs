
// class Test
// {
//     static async Task Main()
//     {
//         int [] numbers = {1, 2, 3, 4, 5, 6, 7, 8};

//         Task<int>[] x = numbers.Select(n => Multyple(n)).ToArray();

//         int[] results = await Task.WhenAll(x);

//         Console.WriteLine(string.Join("\n", results));
//     }

//     static async Task<int> Multyple(int number)
//     {
//         await Task.Delay(100);
//         return number + 3;

//     }


// }