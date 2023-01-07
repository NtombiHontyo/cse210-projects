using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("Let's kill this C#!!");
        Console.Write("What is your desired mark for C#? ");
        string color = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"You will get {color} if you work hard.");
    }
}