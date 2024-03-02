namespace solid.SRP;

// Separation of Concerns.
// JournalEntry has one resposibility: it stores entries.
public class Persistence
{
    public void Save(JournalEntry journal, string filename)
    {
        File.WriteAllText(filename, journal.ToString());
    }

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