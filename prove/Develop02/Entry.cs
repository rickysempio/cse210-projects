public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        // PUT _date
        // PUT _promptText
        // PUT _entryText

        //DateTime.Now.ToShortDateString();

        //Console.Write("Date:");
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
        
    


    }
}