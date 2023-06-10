
public class Activity{

    protected string _startingMessage;
    protected string _endingMessage;
    protected string _name;
    protected string _description;
    protected int? _time;
    protected List<string> _prompts;
    protected Random randNum = new Random();
    protected List<int> _usedIndexes = new List<int>();

    public Activity(){
        this._name = "Activity";
        _startingMessage = SetStartMessage();
        _endingMessage = SetEndMessage();

    }
    protected int GetRandomNum(List<string> array){
        int number;
        while(true){
            number = randNum.Next(0, array.Count);
            if(!this._usedIndexes.Contains(number)){
                this._usedIndexes.Add(number);
                return number;
            }
            if(this._usedIndexes.Count == array.Count){
                var lastValue = this._usedIndexes[this._usedIndexes.Count - 1];
                this._usedIndexes.Clear(); this._usedIndexes.Add(lastValue);
            }
            continue;
        }
    }
    protected int? GetTime(){
        int? time = null;
        while(time == null){
            try{
                Console.Write("How long, in seconds, would you like your session to be?");
                time = int.Parse(Console.ReadLine());
            }catch (FormatException){
                Console.WriteLine("Error, please enter a valid integer.\n");
                continue;
            }
        }
        return time;
    }
    protected void StartMessage(){
        Console.WriteLine(_startingMessage);
    }
    public string SetStartMessage(){
        return $"Welcome to the {this._name}.";
    }
    public string GetStartMessage(){
        return _startingMessage;
    }
    protected void EndMessage(){
        Console.WriteLine("Well done!!");
        Spinner(2);
        Console.WriteLine(_endingMessage);
    }
    public string SetEndMessage(){
        return $"You have completed another {this._time} seconds of the {this._name}.";
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
    protected void StartActivity(){
        StartMessage();
        Console.WriteLine();
        DisplayDescription();
        Console.WriteLine();
        this._time = GetTime();
        this._endingMessage = SetEndMessage();
    }

    protected int Countdown(int time){
        int timePassed = time;
        Console.Write("\b.");
        for(int i = time; i >= 0; i--){
            Console.Write($"\b{i}");
            Thread.Sleep(1000);
        }
        Thread.Sleep(100);
        Console.Write("\b.\b\n");
        return timePassed;
    }

    protected int Spinner(int time){
        int timePassed = 0;
        for(int i = 0; i <= time; i+=1){
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            timePassed += 1;
        }
        Console.Write("\b.\b\n");
        return timePassed;
    }
}

public class Breathing : Activity{
    public void Display(){
        StartActivity();
        int time = 0;
        while(time < this._time){
            Console.Write($"{this._prompts[0]}");
            time += Countdown(4);
            Console.Write($"{this._prompts[1]}");
            time += Countdown(8);
        }
        EndMessage();
    }
    public Breathing(): base(){
        this._name = "Breathing Activity";
        this._startingMessage = SetStartMessage();
        this._prompts = new List<string>{"Breath in. . .", "Breath out. . ."};
        this._description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }
}

public class Reflecting : Activity {
    private List<string> _reflectionList;
    public Reflecting() : base(){
        this._name = "Reflection Activity";
        this._prompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you helped someone in need.",
                                        "Think of a time when you did something really difficult.", "Think of a time when you did something truly selfless."};
        this._description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        this._reflectionList = new List<string>{"Why was this experience meaningful to you?","How did you get started?",
        "Have you ever done anything like this before?", "How did you feel when it was complete?", "What is your favorite thing about this experience?",
        "What made this time different than other times when you were not as successful?", "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
        
    }
    public List<string> GetReflectionList(){
        return new List<string>{};
    }
    public void SetReflectionList(List<string> newList){
        List<string> list = new List<string>{};
        list.AddRange(this._reflectionList);
        list.AddRange(newList);
    }
    public void ResetList(){
        this._reflectionList.Clear();
    }
    public void Display(){
        StartActivity();
        var randNum = new Random();
        int time = 0;
        Console.WriteLine("Loading...");
        Spinner(2);
        Console.WriteLine("Consider the following prompt:\n");

        Console.WriteLine($" --- {this._prompts[GetRandomNum(this._prompts)]} --- \n");
        Console.WriteLine("When ready, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Ponder the following questions.");
        Console.Write("Loading..."); Countdown(4);
        while(time < this._time){
            Console.Write($" > {this._reflectionList[GetRandomNum(this._reflectionList)]}");
            time += Spinner(6);
        }
        EndMessage();
    }
}

public class Listing : Activity {
    private List<string> _list;
    public Listing(): base(){
        this._name = "Listing Activity";
        this._prompts = new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?",
                                        "Who are people that you have helped this week?","When have you felt the Holy Ghost this month?",
                                        "Who are some of your personal heroes?"};
        this._description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        this._list = new List<string>();
        
    }
    public void Display(){
        StartActivity();
        var randNum = new Random();
        DateTime currentTime = DateTime.Now;
        Console.WriteLine("Loading...");
        Spinner(2);
        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        Console.WriteLine($" --- {this._prompts[GetRandomNum(this._prompts)]} --- \n");
        Console.Write("Begins in:");Countdown(6);Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds((double)this._time);
        while(currentTime < endTime){
            Console.Write(" > ");
            var input = Console.ReadLine();
            this._list.Add(input);
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {this._list.Count} items!\n");
        EndMessage();
    }
}