public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>(){

        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "When have you felt the Holy Ghost this month?",

    };

    public Random Rand = new Random();

    public ListingActivity(string name, string description, int count, List<string> prompts) : base (name, description)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {
        string randomSentence = _prompts[Rand.Next(_prompts.Count)];

        Console.WriteLine(randomSentence);

    }


    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}