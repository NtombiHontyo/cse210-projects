using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbersToWorkWith = new List<int>();
        int numbers = -1;
        double numberSum = 0;
        double average = 0;
        int maxNumber = 0;
        do{
            Console.Write("Enter a number: ");
            string answer = Console.ReadLine();
            numbers = int.Parse(answer);

            numbersToWorkWith.Add(numbers);
        } while(numbers != 0);
        numbersToWorkWith.RemoveAt(numbersToWorkWith.Count - 1);
        foreach (int number in numbersToWorkWith)
        {
            numberSum += number;
            average = numberSum / numbersToWorkWith.Count;
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The sum is: {numberSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        
    }
}