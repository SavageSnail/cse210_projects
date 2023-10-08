using System.Collections.Generic;
using System.Diagnostics.Contracts;
public class Journal 
// the overall class that I was thinking could hold variables from each if/else statement and move it to another.
{
    public string _openFile;

    public List<Write> _entries = new List<Write>();

    public void AddList()
    {
        _entries.Add(null);
    }

    public void SaveToFile(List<Write> entries) 
    {
        using (StreamWriter journalEntry = new StreamWriter(_openFile))
        {
            foreach (Write entry in _entries)
            {
             journalEntry.WriteLine($"{entry.theCurrentTime} - {entry._gennedprompt} \n {entry._userInput}");
            }
        }
    }



}