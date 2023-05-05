using System.IO;
public class Journal {
    public List<Entry> _entries = new List<Entry>();
    int lastEntry;
    string[] lines;
    string[] parts;
    Entry newEntry;
    public Journal(List<Entry> entries = null) {
        if(entries == null){return;}
        Entry previous = new Entry();
        previous._date = "";
        foreach(Entry value in entries){
            AddEntry(value);
            previous = value;
        }
    }

    public void AddEntry(Entry value){
        if(_entries.Count == 0){
            _entries.Add(value);
            return;
        }
        lastEntry = _entries.Count - 1;
        if(_entries[lastEntry]._date == value._date){
            _entries[lastEntry]._entry += $"\n\nAdditional Entry - Prompt:{value._prompt}\n{value._entry}";
            return;
        }
        _entries.Add(value);
    }

    public void DisplayEntry(string date = "."){
        if(date == "." | date == ""){date = DateTime.Now.ToString("MM/dd/yyyy");}
        foreach(Entry value in _entries){
            if(value._date == date){
                value.Display();
            }
        }
    }

    public void Display(){
        if(_entries == null){
            Console.WriteLine("Nothing is in your journal yet.\n");
            return;
            }
        foreach(Entry value in _entries){
            value.Display();
            Console.WriteLine();
        }
    }

    public void LoadJournal(string filename = "myJournal.txt"){
        if(filename == ""){filename = "myJournal.txt";}
        if(filename.Contains(".txt") == false){filename += ".txt";}
        lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines){
            if(!line.Contains("||") && !line.Contains("~")){
                newEntry._entry += $"\n{line}";
                continue;
            }
            if(line.Contains("||")&&!line.Contains("~")){
                newEntry._entry += $"\n{line.Replace("||", "")}";
                AddEntry(newEntry);
                continue;
            }
            parts = line.Split("~");
            newEntry = new Entry(); newEntry._date = parts[0];
            newEntry._prompt = parts[1]; newEntry._entry = parts[2];

        }

    }

    public void SaveJournal(string filename = "myJournal.txt"){
        if(filename == ""){filename = "myJournal.txt";}
        if(filename.Contains(".txt") == false){filename += ".txt";}
        using (StreamWriter outputFile = new StreamWriter(filename)){
            foreach(Entry value in _entries){
                outputFile.WriteLine($"{value._date}~{value._prompt}~{value._entry}||");
            }
        }
    }
}