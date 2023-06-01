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
        Console.WriteLine("Hello Develop04 World!");
        int input;

        while(true){

            Console.WriteLine("1. Menu Items\n"
                             +"2. Menu Items\n"
                             +"3. Menu Items\n"
                             +"4. Menu Items\n"
                             +"5. Menu Items\n"
                             +"6. Menu Items\n");
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
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }

        }
    }
}