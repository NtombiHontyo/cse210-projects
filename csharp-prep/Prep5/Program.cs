using System;

class Program
{
    static void Main(string[] args)
    {
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName; 
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favourite number? ");
            string answer = Console.ReadLine();
            int favNumber = int.Parse(answer);
            return favNumber;
        }
        static int SquareNumber(int number1)
        {
            int product = number1 * number1;
            return product;
        }

        static void DisplaySquareAndName( string userName, int favNumber)
        {
            
            int sqaredNumber = SquareNumber(favNumber);
            Console.WriteLine($"{userName}, the square of your number is {sqaredNumber}.");
        }
        
        
        static void Main()
        {
            DisplayWelcome();
            DisplaySquareAndName(PromptUserName(), PromptUserNumber() );
            
            

        }
        Main();

    }
}