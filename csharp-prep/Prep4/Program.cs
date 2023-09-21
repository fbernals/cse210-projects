using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers to append to a list.");
        List<int> numbersList = new List<int>();
        int number = 1;

        //If entered number is not 0, it will convert it to integer and append it to the list.
        while (number != 0){
            Console.WriteLine("Enter a number to append: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0){
                numbersList.Add(number);
            }
        }
        //Iterates thourgh the list and prints every single item in it.
        Console.WriteLine("This is your list of numbers:");
        foreach (int item in numbersList){
            Console.WriteLine(item);
        }

        int sum = numbersList.Sum();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"This is the sum of your list: {sum}");

        double avg = numbersList.Average();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"This is the average of your list: {avg}");

        int max = numbersList.Max();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"This is the maximum number of your list: {max}");
        
        //Gets the minimum number in the list and sets text color
        int min = numbersList.Min();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"This is the minimum number of your list: {min}");

        int minPositive = numbersList
            .Where(x => x > 0) //Reads: where x is greater than 0
            .DefaultIfEmpty(0) //If x is empty assign 0 as value
            .Min(); //Get the minimum number that complies with the requirements.
        Console.WriteLine($"Minimum positive: {minPositive}");

        numbersList.Sort();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("This is your sorted list:");
        foreach (int item in numbersList){
            Console.Write(item + ", ");
        }

        Console.ForegroundColor = ConsoleColor.White;
    }
}