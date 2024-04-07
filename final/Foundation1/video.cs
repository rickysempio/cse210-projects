using System.Runtime.InteropServices;

public class Video
{
    public string _title;
    public string _author;
    public int _lenght;
    public List <CommentList> _commentList = new List<CommentList>();
    public int _numberOfComments;


    public string DisplayVideoDetails()
    {
        return ($"Title:{_title}, Author:{_author}, Lenght(in seconds):{_lenght}");
    }

    public string DisplayNumberOfComments()
    {
       foreach (CommentList comment in _commentList)
       {
        

        Console.WriteLine(comment._commentText);
        _numberOfComments = 0;

            if (comment._commentText == "")
            {
                _numberOfComments ++;
            }

        }

     return ($"Total Number of Comments: {_numberOfComments}");
    }

}