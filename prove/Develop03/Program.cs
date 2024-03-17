using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        //string answer = "";
        //string quit = "";

        //while ( answer != quit)
        //

        Console.WriteLine(" Proverbs 3:5-6 Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");


        Console.WriteLine("Press enter to constinue or type 'quit' to finish:");


        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Proverbs 3:5-6 ___ in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");


        Console.WriteLine("Press enter to constinue or type 'quit' to finish:");
        Console.ReadLine();


        Reference scriptureReference = new("Proverbs", 3, 5);
        Console.WriteLine(scriptureReference.GetDisplayText2());


        Reference scriptureReference2 = new("Proverbs", 3, 5, 6);
        Console.WriteLine(scriptureReference2.GetDisplayText());




        //hide a few words
        

        //hiding more words until all words are hidden

        //when all words are all hidden the proram shoul end. 

        //}
        

        //Scripture myScripture = new Scripture();
        //myScripture.GetDisplayText();
       
       
        
        

        
    }
}