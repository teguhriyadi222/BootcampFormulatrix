

class Program
{
    static void Main()
    {
        string str1 = "Teguh";
        string str2 = "Riyadi";
        string result1 = str1 + " " + str2; 
        string result2 = string.Concat(str1, " ", str2); 

        Console.WriteLine("Hasil penggabungan string:");
        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine();

        // Mengubah Huruf Besar dan Kecil
        string str3 = "Hello World";
        string lowerCaseStr = str3.ToLower(); // Mengubah ke huruf kecil
        string upperCaseStr = str3.ToUpper(); // Mengubah ke huruf besar

        Console.WriteLine("Hasil perubahan huruf:");
        Console.WriteLine(lowerCaseStr);
        Console.WriteLine(upperCaseStr);
        Console.WriteLine();

        // Accessing characters
        string x = "saya ganteng";
        Console.WriteLine("Hasil Cetak Posisisi Karakter :");
        Console.WriteLine(x[2]);

        //string lenght 
        Console.WriteLine("Hasil Cetak Panjang string :");
        Console.WriteLine(x.Length);

        //Substring
        string substring = x.Substring(1,4);
        Console.WriteLine(substring);


        // Memeriksa Tipe Karakter
        char character = 'A';
        bool isControlChar = char.IsControl(character);
        bool isDigitChar = char.IsDigit(character);
        bool isLetterChar = char.IsLetter(character);
        bool isLowerChar = char.IsLower(character);
        bool isPunctuationChar = char.IsPunctuation(character);
        bool isSeparatorChar = char.IsSeparator(character);
        bool isUpperChar = char.IsUpper(character);
        bool isWhiteSpaceChar = char.IsWhiteSpace(character);

        Console.WriteLine("Hasil pengecekan tipe karakter:");
        Console.WriteLine($"Is Control: {isControlChar}");
        Console.WriteLine($"Is Digit: {isDigitChar}");
        Console.WriteLine($"Is Letter: {isLetterChar}");
        Console.WriteLine($"Is Lower: {isLowerChar}");
        Console.WriteLine($"Is Punctuation: {isPunctuationChar}");
        Console.WriteLine($"Is Separator: {isSeparatorChar}");
        Console.WriteLine($"Is Upper: {isUpperChar}");
        Console.WriteLine($"Is WhiteSpace: {isWhiteSpaceChar}");
        Console.WriteLine();

        string strNumber = "10";
        int number = int.Parse(strNumber); 
        string strConverted = number.ToString(); 

        Console.WriteLine("Hasil parsing string dan perubahan tipe data:");
        Console.WriteLine($"Parsed Number: {number}");
        Console.WriteLine($"Converted String: {strConverted}");

        // Tunggu hingga pengguna menekan tombol untuk keluar dari program
        Console.WriteLine("Tekan tombol apapun untuk keluar...");
        Console.ReadKey();
    }
}
