using System;

/*Things this Program does to exceed requirements.
 *  - Display's a singular Entry by using the Entry's date.
 *  - Puts Entries that share a date into one Entry object in the Journal.
 *    The other entries read Additional Entry containing the prompt as well.
 *  - Uses an end symbol "||" to read multiple lines before loading the entry.
 *  - Made Prompt a static class and had the Entry class obtain one randomly whenever
 *    an instance of the Entry class is created. This is done using a function inside
 *    the Prompt class.
 */
class Program
{
    static void Main(string[] args)
    {
        //Declare needed class instances/variables.
        Journal myJournal = new Journal();
        Entry newEntry;
        Boolean running = true;
        string filename;
        string input;
        int answer = 0;
        
        while(running){
            Console.WriteLine("Please select one of the following choices:\n"
                            + "1. Write\n2. Display\n3. Display Entry\n4. Load\n5. Save\n6. Quit\n"
                            + "What would you like to do? ");
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch(answer){
                case 1:
                    newEntry = new Entry(); newEntry.ReceiveInput();
                    myJournal.AddEntry(newEntry);
                    break;
                case 2:
                    myJournal.Display();
                    break;
                case 3:
                    Console.WriteLine("Please enter the date of the entry (mm/dd/yyyy) or hit enter for todays entry.");
                    input = Console.ReadLine();
                    myJournal.DisplayEntry(input);
                    break;
                case 4:
                    Console.WriteLine("Please enter the file's name. (Or Enter for default filename.)");
                    filename = Console.ReadLine();
                    myJournal.LoadJournal(filename);
                    break;
                case 5:
                    Console.WriteLine("Please enter the name of your journal file. (Or enter for default name.)");
                    filename = Console.ReadLine();
                    myJournal.SaveJournal(filename);
                    break;
                case 6:
                Console.WriteLine("Thank you for using the program.");
                    running = false;
                    break;
            }
        }
    }
}