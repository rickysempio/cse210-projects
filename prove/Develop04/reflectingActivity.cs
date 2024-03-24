using Microsoft.VisualBasic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"


    };
    
    public Random promptsRand = new Random();


    public ReflectingActivity( List<string> prompts, List<string> questions, string name, string description) : base (name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
    string randomSentence = _prompts[promptsRand.Next(_prompts.Count)];

        Console.WriteLine(randomSentence);

    return randomSentence;


    }


    public string GetRandomQuestion()
    {
        string randomSentence = _questions[promptsRand.Next(_questions.Count)];

        //Console.WriteLine(randomSentence);

    return randomSentence;
    }


    public void DisplayPrompt()
    {
        Console.WriteLine(_prompts);
    }


    public void DisplayQuestions()
    {
        Console.WriteLine(_questions);
    }

}

