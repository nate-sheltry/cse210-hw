
public class Activity{

    private string _startingMessage;
    private string _endingMessage;
    private string _name;
    private string _description;
    private int _time;

    public Activity(){

    }

    public void StartMessage(){
        Console.WriteLine(_startingMessage);
    }
    public string GetStartMessage(){
        return _startingMessage;
    }
    public void EndMessage(){
        Console.WriteLine(_endingMessage);
    }
    public string GetEndMessage(){
        return _endingMessage;
    }
    public void DisplayDescription(){
        Console.WriteLine(_description);
    }
    public string GetDescription(){
        return _description;
    }
}

public class Breathing : Activity{
        public Breathing(){
            
        }
    }