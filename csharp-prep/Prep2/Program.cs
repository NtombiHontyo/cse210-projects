using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int x = int.Parse(gradePercentage);

        
        string result = "";
        if (x >= 90)
        {
            result =  "Your symbol is 'A'. ";
        }
        else if (x >= 80 && x < 90)
        {
            result = "Your symbol is 'B'. ";
        }
        else if (x >= 70 && x < 80)
        {
            result = "Your symbol is 'C'. ";
        }
        else if (x >= 60 && x < 70)
        {
            result = "Your symbol is 'D'. ";
        }
        else
        {
            result = "Your symbol is 'F'. ";
        }
        Console.WriteLine(result);
        
        if ((x >= 90) || (x >= 80 && x < 90) || (x >= 70 && x < 80))
        {
            Console.WriteLine("Congratulations, you have passed the class!");
        }
        else
        {
            Console.WriteLine("Unfortunately you did not pass the class, please try harder next time.");
        }

        
    }
}