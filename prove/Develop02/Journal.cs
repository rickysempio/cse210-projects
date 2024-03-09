using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal
{
    //public List<Entry> _entries;
    public List<Entry> _entries = new();
    public PromptGenerator pgen = new();
        
    
    
    public void AddEntry()
    {
        // entry -> NEW Entry
        // entry._date -> DateTime.Now.ToShortDateString()
        // entry._promptText -> pgen.GetRandomPrompt()
        // entry._entryText -> GET

        // _entries.Add( entry )

        
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToShortDateString();
        entry._promptText = pgen.GetRandomPrompt();
        Console.Write("> ");
        entry._entryText = Console.ReadLine();
        
        

        _entries.Add(entry);

    
    }

    public void Displayall()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using(StreamWriter writer = new(file))
        {
            // FOREACH entry IN _entries
            //      PUT "entry._date|entry._promptText|entry._entryText"
        

        foreach (Entry entry in _entries)
            writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
        }
    }

    public void LoadFromFile(string file)
    {
        // _entries.CLEAR
        // string[] lines -> File.RealAllLines()
        // FOREACH line IN lines
        //      string[] parts -> line.Split("|")
        //      entry -> NEW Entry
        //      entry._date -> parts[0]
        //      entry._promptText -> parts[1]
        //      entry._entryText -> parts[2]
        //      _entries.ADD( entry )

        _entries.Clear();
        string[] lines = File.ReadAllLines(file);

        foreach (String line in lines)
        {
            string [] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }


        
    }
}