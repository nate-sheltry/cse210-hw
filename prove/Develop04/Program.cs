using System;

class Program
{
    static void WriteString(string value, bool newLine = false, int speed = 10){
        foreach(char character in value){
            Console.Write(character);
            Thread.Sleep(speed);
        }
        if(newLine == true){Console.Write("\n");}
    }

    static void Main(string[] args)
    {
        Listing listing = new Listing();


        int input;
        while(true){

            Console.WriteLine("1. Breathing Activity\n"
                             +"2. Reflecting Activity\n"
                             +"3. Listing Activity\n"
                             +"4. Quit\n");
            try {
                input = int.Parse(Console.ReadLine());
            }catch(FormatException){
                WriteString("Please enter a valid integer value.");
                Thread.Sleep(1000);
                Console.Clear();
                continue;
            }
            switch(input){
                case 1:
                Breathing breathing = new Breathing();
                breathing.Display();
                breathing = null;
                    break;
                case 2:
                Reflecting reflection = new Reflecting();
                reflection.Display();
                reflection = null;
                    break;
                case 3:
                listing.Display();
                listing = null;
                    break;
                case 4:
                    return;
                case 6:
                    break;
            }

        }
    }
}