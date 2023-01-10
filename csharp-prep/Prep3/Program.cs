using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please guess a number between 1 - 100.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1 , 100);

        
        
        int y;
        do
        {
            
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            y = int.Parse(guessNumber);
            if (y > number)
            {
            Console.WriteLine("Lower");
            }
            else if (y < number)
            {
            Console.WriteLine("Higher");
            }
        }while (y != number);
        
        
        
        Console.WriteLine("You guessed it!");
        
    }
}