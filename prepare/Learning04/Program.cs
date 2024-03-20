using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment homework = new Assignment("Samuel Bennett","Multiplication");
        //homework.SetStudentName("Samuel Smith");
        //homework.SetTopic("Multiplication");
        Console.WriteLine(homework.GetSummary());


        Math myHomework = new Math("Roberto Rodriguez", "Fraction","7.3","8-19");
        //myHomework.SetStudentName("Roberto Roderiguez");
        //myHomework.SetTopic("Fractions");
        //myHomework.SetTextSection("Section 7.3");
        //myHomework.SetProblems("Problems 8-19");
        Console.WriteLine(myHomework.GetSummary());
        Console.WriteLine(myHomework.GetHomeworkList());


        Writing myWriting = new Writing("Mary Waters", "European History", "The Cause of World War II");
        Console.WriteLine(myWriting.GetSummary());
        Console.WriteLine(myWriting.GetWritingInformation());

    
    }
}