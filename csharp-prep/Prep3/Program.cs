using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int guessedNumber = 0;
        string playAgain = null;

        do{
            Random randomNumber = new Random();
            number = randomNumber.Next(1,11);
            while (guessedNumber != number){
                Console.WriteLine("Guess the number: ");
                guessedNumber = int.Parse(Console.ReadLine());
                        
                if (guessedNumber < number){
                    Console.WriteLine("Higher.");
                }
                else if (guessedNumber > number){
                    Console.WriteLine("Lower");
                }
                else if (guessedNumber == number){
                    Console.WriteLine("You guessed it!");
                }
                
            }
            Console.WriteLine("Do you want to play again? (y/n)");
            playAgain = (Console.ReadLine());
           
        } while (playAgain != "n");
        Console.Write("Good bye!");

    }
}