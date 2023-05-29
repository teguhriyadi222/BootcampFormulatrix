Console.WriteLine("Masukkan jumlah data: ");
int jumlah = int.Parse(Console.ReadLine());
int[] data = new int[jumlah];

for (int i = 0; i < jumlah; i++)
{
    Console.Write($"Masukkan data ke-{i}: ");
    data[i] = int.Parse(Console.ReadLine());
}



foreach (var item in data)
{
    Console.WriteLine($"data = {item}");
    
}

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine($"data ke {i + 1} = {data[i]}");
}

int [] y = new int[data.Length];
Array.Copy(data, y, data.Length);

int [] x =new int[data.Length];
Array.Clone(data,x,data.Length);
foreach (var item in X)
{
    Console.Write($"data = {item},"); 
}

