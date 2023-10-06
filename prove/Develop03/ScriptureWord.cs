// Class to represent a single word in the scripture
public class ScriptureWord
{
    public string Word { get; set; }
    public bool IsHidden { get; set; }

    public ScriptureWord(string word)
    {
        Word = word;
        IsHidden = false;
    }
}