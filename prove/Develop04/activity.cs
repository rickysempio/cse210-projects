public class Activity
{
    private string _name;
    private string _description;
    private int _duration;



    public  Activity(string name, string description)
    {
        _name = name;
        _description = description;
        
    }

    public Activity(int seconds)
    {
        _duration = seconds;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_description);
        
    }


    public void DisplayEndingMessage()
    {
        
    }


    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);


        int i = 0;

        while (DateTime.Now < endTime)
        {
	        string s = animationStrings[i];
	        Console.Write("s");
	        Thread.Sleep(1000);
	        Console.Write("\b \b");
	
	        i++;

	        if (i >= animationStrings.Count)
	        {
		        i = 0;
	        }


	
        Console.WriteLine("Done");
        }
    }

    public void ShowCountDown(int seconds)

    
    {
        for (int _duration = 5; _duration > 0; _duration--)

	    Console.Write(_duration);
	    Thread.Sleep(6000);
	    Console.Write("\b \b");

	    Console.WriteLine("Done");
    }

}    


