namespace solid.SRP;

public class JournalEntry
{
    private readonly List<string> _entries = new List<string>();
    private static int _count = 0;

    public int AddEntry(string entry)
    {
        _count++;
        _entries.Add(entry);
        return _count; // memento pattern
    }

    public void RemoveEntry(int index)
    {
        _entries.RemoveAt(index);
    }

    override public string ToString()
    {
        return string.Join(Environment.NewLine, _entries);
    }

    // Break SRP. Should be in a separate class, for instance Persistence.
    public void Save(string filename)
    {
        File.WriteAllText(filename, ToString());
    }

    // Break SRP. Should be in a separate class, for instance Persistence.
    public JournalEntry Load(string filename)
    {
        var journal = new JournalEntry();
        var fileContent = File.ReadAllText(filename);
        var fileEntries = fileContent.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        foreach (var entry in fileEntries)
        {
            journal.AddEntry(entry);
        }

        return journal;
    }
}
