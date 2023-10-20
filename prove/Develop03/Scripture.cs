// Class to represent the scripture text
public class Scripture
{
    private readonly List<ScriptureWord> _words = new List<ScriptureWord>();
    private readonly ScriptureReference _reference;

    public Scripture(string reference, string text)
    {
        this._reference = new ScriptureReference(reference);

        // Split the text into words and initialize the ScriptureWords
        var textWords = text.Split(' ');
        foreach (var word in textWords)
        {
            _words.Add(new ScriptureWord(word));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"Scripture Reference: {_reference.Book} {_reference.Chapter}:{_reference.StartVerse}-{_reference.EndVerse}");
        foreach (var word in _words)
        {
            Console.Write(word.IsHidden ? "____ " : word.Word + " ");
        }
        Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
    }

    public void HideRandomWord()
    {
        var random = new Random();
        var hiddenWords = _words.Where(w => !w.IsHidden).ToList();
        if (hiddenWords.Any())
        {
            var randomWord = hiddenWords[random.Next(hiddenWords.Count)];
            randomWord.IsHidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden);
    }
}
