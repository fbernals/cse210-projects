class Journal
{
    public List<JournalEntry> Entries { get; private set; }

    public Journal()
    {
        Entries = new List<JournalEntry>();
    }

    public void AddEntry(JournalEntry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = File.CreateText(fileName))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        Entries.Clear(); // Clears existing entries before loading from file

        using (StreamReader reader = File.OpenText(fileName))
        {
            //string line;
            while (!reader.EndOfStream)
            {
                string loadedInput = reader.ReadLine();
                Console.WriteLine(loadedInput);
                
            }
        }
    }
}
