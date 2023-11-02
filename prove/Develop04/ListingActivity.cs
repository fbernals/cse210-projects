using System.Diagnostics;

class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void StartListing()
    {
        Spinner spinner = new Spinner();
        Stopwatch stopwatch = new Stopwatch();
        StartActivity();
        Console.WriteLine("\nLet's start listing:");
        Random random = new Random();
        Console.WriteLine("\nThink about this: " + prompts[random.Next(prompts.Length)]);
        spinner.GetSpinner();

        int itemsCount = 0;
        stopwatch.Start();
        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Console.Write("Enter a response: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                itemsCount++;
            }
            
        }

        Console.WriteLine($"You listed {itemsCount} items.");
        stopwatch.Stop();
        EndActivity();
    }
}
