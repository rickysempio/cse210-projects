using System.Runtime.CompilerServices;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>(){
    "Have I made feel someone glad today?",
    "what was the best thing that happened to me today?",
    "How did the reading scriptures helped me today?",
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    };
    
    public Random Rand = new Random();
    

    
    public string GetRandomPrompt() 
    {
        string randomSentence = _prompts[Rand.Next(_prompts.Count)];

        Console.WriteLine(randomSentence);

        return randomSentence;
    }

}



