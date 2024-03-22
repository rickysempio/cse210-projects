public class Scripture
{
    private  Reference _reference;
    private Random _ranGen = new Random();
    private List<Word> _words = new List<Word>();


    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        string[] wordAry = text.Split(" ");
            
            foreach ( string wordStr in wordAry)
            {
                Word wordObj  = new(wordStr);
                _words.Add(wordObj);
            }

    }


    public void HideRandomWords(int numberToHide)
    {

        for (int _ = 0; _ < numberToHide; _++)
        {
            int index;
            do 
            {
                index = _ranGen.Next(_words.Count);

            }
            while (_words[index].GetIsHidden());
                _words[index].Hide();
                if (IsCompletelyHidden())
                    break;

        }
    }
    

    public void GetDisplayText()
    {
  
        Console.WriteLine(_reference.GetDisplayText() + " ");
        {
            foreach (Word word in _words)
            Console.Write( word.GetDisplayText()  + "  ");
            Console.WriteLine();
        }

    }


    public bool IsCompletelyHidden()
    {
        

        foreach (Word word in _words)
        {
            if (!word.GetIsHidden())  
            {
                return false;
            }

        }
        return true;
    }   
}