class JournalEntry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - Prompt: {Prompt}\nResponse: {Response}\n";
    }
}
