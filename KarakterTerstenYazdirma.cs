using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir string giriniz: ");
        string input = Console.ReadLine();
        
        string son = StringIndex(input);
        
        Console.WriteLine($"String son hali: {son}");
    }
    
    static string StringIndex(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length == 1)
        {
            return input;
        }
        
        return input.Substring(1) + input[0];
    }
}