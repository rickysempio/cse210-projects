public class Scripture
{
    private  Reference _reference;
    private List<Word> _words = new List<Word>();


    
    public Scripture(Reference Reference, string text)
    {
       _reference = Reference;
            
        text = "Proverbs 3:5-6 Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

    }

    public Random Rand = new Random();

    void HideRandomWords(int numberToHide)

    {
        GetDisplayText();
        //Word wordDisplayText = new();
        //wordDisplayText.GetDisplayText();
        

        Word HideRandomWords = _words[Rand.Next(_words.Count)];




        

    }
    
    public String GetDisplayText()
    {
              
        return "";
    }
    public bool isCompletelyHidden()
    {
        return false;
    }
}