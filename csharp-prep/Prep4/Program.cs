using System;

class Program
{
    static List<int> populateList()
    {
        List<int> list = new List<int>();
        int input = 0;
        while(true) {
            try {
            Console.Write("Enter number:");
            input = int.Parse(Console.ReadLine());
            if(input == 0){break;}
            list.Add(input);
            }
            catch (System.Exception){
                Console.WriteLine("Error: Please enter a integer.");
            }
        };
        return list;
    }
    static void Main(string[] args)
    {
        int highNumber = 0;
        int sum = 0;
        int lowestPosNumber = 999999999;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> list = populateList();
        foreach (int value in list){
            sum += value;
            if(value > highNumber){ highNumber = value;}
            if(value < lowestPosNumber && value > 0){lowestPosNumber = value;}
        }
        float average = (float)sum/list.Count;
        Console.WriteLine($"\nThe sum is: {sum}\nThe average is: {(float)sum/list.Count}\nThe largest number is: {highNumber}\n"+
                          $"The smallest positive number is: {lowestPosNumber}\nThe sorted list is:");
        list.Sort();
        foreach (int value in list){Console.WriteLine(value);}
        
    }
}