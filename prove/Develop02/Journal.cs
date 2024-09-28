using System.Transactions;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
        }
        }   
    }



    public void LoadFromFile(string file)
    {
        foreach (var line in File.ReadLines(file))
        {
            string[] parts = line.Split('|');
            
            string date = parts[0];
            string prompt = parts[1];
            string entryText = parts[2];

            Entry entry = new Entry
            {
                _date = date,
                _promptText = prompt,
                _entryText = entryText
            };
            _entries.Add(entry);
        }
    }


}