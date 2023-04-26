using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int answer;
        string loop;
        do{
            int guesses = 0;
            magicNumber = new Random().Next(1, 100);
            do{
                Console.Write("What is your guess?");
                answer = int.Parse(Console.ReadLine());
                guesses += 1;
                if(answer < magicNumber){Console.WriteLine("Higher");}
                else if(answer > magicNumber){Console.WriteLine("Lower");}
            } while (answer != magicNumber);
            Console.WriteLine($"You made: {guesses} guesses.");

            Console.Write("Would you like to play again?(y/n) ");
            loop = Console.ReadLine();
        } while (loop == "y");
    }
}