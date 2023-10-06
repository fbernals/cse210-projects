// Class to represent the scripture text
public class Scripture
{
    private readonly List<ScriptureWord> words = new List<ScriptureWord>();
    private readonly ScriptureReference reference;

    public Scripture(string reference, string text)
    {
        this.reference = new ScriptureReference(reference);

        // Split the text into words and initialize the ScriptureWords
        var textWords = text.Split(' ');
        foreach (var word in textWords)
        {
            words.Add(new ScriptureWord(word));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"Scripture Reference: {reference.Book} {reference.Chapter}:{reference.StartVerse}-{reference.EndVerse}");
        foreach (var word in words)
        {
            Console.Write(word.IsHidden ? "____ " : word.Word + " ");
        }
        Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
    }

    public void HideRandomWord()
    {
        var random = new Random();
        var hiddenWords = words.Where(w => !w.IsHidden).ToList();
        if (hiddenWords.Any())
        {
            var randomWord = hiddenWords[random.Next(hiddenWords.Count)];
            randomWord.IsHidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden);
    }
}
