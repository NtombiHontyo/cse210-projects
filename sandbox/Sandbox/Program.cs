using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
        int y = 2;
        if (x > y)
        {
            Console.WriteLine("Greater than 2");
        }
        else if (x < y)
        {
            Console.WriteLine("Smaller than 2");
        }
        else
        {
            Console.WriteLine("Equal to 2");
        }
    }
}