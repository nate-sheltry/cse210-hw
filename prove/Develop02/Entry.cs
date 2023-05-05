public class Entry {

    public string _date;
    public string _prompt;
    public string _entry;
    string input;

    public Entry() {
        retrieveDate();
        _prompt = Prompt.obtainPrompt();
    }

    void retrieveDate(){
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        _date = date;
    }

    public void ReceiveInput(){
        Console.WriteLine($"Date:{_date} - Prompt:{_prompt}");
        input = Console.ReadLine();
        _entry = input;
    }

    public void Display(){
        if(_entry == null){
            Console.WriteLine("Entry is empty.\n");
            return;
        }
        Console.WriteLine($"Date:{_date} - Prompt:{_prompt}\n{_entry}");
    }

}