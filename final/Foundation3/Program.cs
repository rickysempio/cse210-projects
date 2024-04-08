using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");


        //LECTURES
        Address address= new Address("Lectures","How to manage your finances", "Training literacy", "01 May 2024", "7:00PM","456 Park Avenue New York USA");


        Address addressReception = new Address("Lectures","How to manage your finances", "Training literacy", "01 May 2024", "7:00PM","Garden Wedding at San Diego Califorina USA");


        Address addressGatherings = new Address("Lectures","How to manage your finances", "Training literacy", "01 May 2024", "7:00PM","Outdoor gatherings at San Diego Beach");

        
        Lectures lectures= new Lectures("Lectures","How to manage your finances", "Training literacy", "01 May 2024", "7:00PM","Nick Vujucic", 100);
        

        Console.WriteLine();
        Event lecture = new Event("Lectures","How to manage your finances", "Training literacy", "01 May 2024", "7:00PM");
        Console.WriteLine();
        Console.WriteLine("Event Standard Details:");
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine(address.EventAddress());


        Console.WriteLine();
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine(lectures.LecturesEventDetails());
        Console.WriteLine(address.EventAddress());
        

        Console.WriteLine();
        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine();
    

        //RECEPTIONS
        Receptions reception = new Receptions("Receptions","Just the Two of Us", "Wedding ceremony of Edna and Orlando", "19 June 2024", "10:00AM","emailForRSVP@hotmail.com", "registration beforehand @ googledocs");
        Console.WriteLine();
        Console.WriteLine("Event Standard Details:");
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine(addressReception.EventAddress());


        Console.WriteLine();
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine(reception.Reservation());
        Console.WriteLine(addressReception.EventAddress());
        

        Console.WriteLine();
        Console.WriteLine(reception.ShortDescription());
        Console.WriteLine();


        //OURDOOR GATHERINGS
        OutdoorGatherings outdoorGatherings = new OutdoorGatherings("Outdoor Gatherings","Together Stronger!","Company Team Building Activities","01 May 2024", "6:00AM","Weather foreast: sunny");


        Console.WriteLine();
        Console.WriteLine("Event Standard Details:");
        Console.WriteLine(outdoorGatherings.StandardDetails());
        Console.WriteLine(addressGatherings.EventAddress());


        Console.WriteLine();
        Console.WriteLine(outdoorGatherings.FullDetails());
        Console.WriteLine(outdoorGatherings.StatementOfWeather());
        Console.WriteLine(addressGatherings.EventAddress());


        Console.WriteLine();
        Console.WriteLine(outdoorGatherings.ShortDescription());
        Console.WriteLine();
   
    }
}