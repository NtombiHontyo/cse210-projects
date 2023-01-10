using System;

class Program
{
    static void Main(string[] args)
    {

        int digit = -1;
        List<int> words = new List<int>();
        do
        {
        Console.Write("enter a number: ");
        string entry = Console.ReadLine();
        digit = int.Parse(entry);
        words.Add(digit);
        }while (digit != 0);

        
        for (int i = 0; i < words.Count - 1; i++)
        {
            Console.WriteLine(words[i]);
        }

        
    }
}