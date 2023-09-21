using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Functions sampler program.");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquaredNumber(number); 
        DisplayResult(name, squared);       

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome message.");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("What is you favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquaredNumber(int number)
        {
            return number*number;
        }
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"Hello, {name}. The square of your number is {number}.");
        }

    }
}