using System;

class Consonant
{
    private string consonant { get; set; }

    public Consonant(string consonant)
    {
        this.consonant = consonant;
    }

    public bool IsConsonant(string consonant)
    {
        char[] cArr = consonant.ToLower().ToCharArray();

        foreach (char c in cArr)
        {
            if (!IsVowel(c))
            {
                return true;
            }
        }
        return false;
    }

    public bool IsVowel(char vowel)
    {
        return (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u');
    }
}

class Program
{
    static void Main()
    {
      
        Console.WriteLine("Masukkan sebuah string:");
        string input = Console.ReadLine();
        Console.WriteLine("Huruf konsonan dalam string:");

        Consonant consonant = new Consonant(input);

        if (consonant.IsConsonant(input))
        {
            foreach (char c in input)
            {
                if (consonant.IsConsonant(c.ToString()))
                {
                    Console.Write(c);
                }
            }
        }
        Console.ReadLine();
        
    }
}