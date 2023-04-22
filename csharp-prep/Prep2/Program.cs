using System;

class Program
{
    static string returnInt(int number)
    {
        if(number > 92 || number < 60){
            return "";
        }

        int remainder = number % 10;

        if(remainder >= 7){
            return "+";
        }
        if(remainder < 3){
            return "-";
        }
        return "";
    } 
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        string letterGrade; int numGrade;

        Console.Write("What is your grade percentage? ");
        numGrade = int.Parse(Console.ReadLine());

        if(numGrade >= 90){
            letterGrade = "A";
        }
        else if(numGrade >= 80){
            letterGrade = "B";
        }
        else if(numGrade >= 70){
            letterGrade = "C";
        }
        else if(numGrade >= 60){
            letterGrade = "D";
        }
        else{
            letterGrade = "F";
        }
        
        Console.WriteLine($"Your Grade: {letterGrade}{returnInt(numGrade)}");

        if (numGrade >= 70){Console.WriteLine("Congratulations! You've Passed!");}
        else{
            Console.WriteLine("You'll do better next time!");
        }


    }
}