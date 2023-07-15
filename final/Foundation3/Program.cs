using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("324 address road", "Queencreek", "AZ", "USA");
        Address address2 = new Address("4793 Reagan Street", "Salt Lake City", "UT", "USA");
        Address address3 = new Address("5614 Boulevard of Streets", "Bakersfield", "CA", "USA");
        Event ev = new Lecture("Canadian Speaker Fest", "Hear a Canadian Speaker first hand in North America!", address1, "8/5/2023", "12:00pm", "Jordan Peterson");
        ev.SetCapacity(350);
        Event ef = new Reception("Brent and Julia's Wedding", "Come join Brent and Julia on their special day!", address2, "9/12/2024", "11:00am");
        Event eb = new Outdoor("Day of Belief", "Come join the local california residents in celebrating everyone's individual beliefs by spending the day with family and people of faith.", address3, "12/3/4", "5:00pm", "Cloudy");
        Console.WriteLine("Short Descriptions:");
        Console.WriteLine(ev.ShortDescription());
        Console.WriteLine(ef.ShortDescription());
        Console.WriteLine(eb.ShortDescription());
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(ev.StandardDetails()+"\n");
        Console.WriteLine(ef.StandardDetails()+"\n");
        Console.WriteLine(eb.StandardDetails()+"\n");
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(ev.FullDetails()+"\n");
        Console.WriteLine(eb.FullDetails()+"\n");
        Console.WriteLine(ef.FullDetails()+"\n");
    }
}