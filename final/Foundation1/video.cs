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
        int count = _commentList.Count;

     return ($"Total Number of Comments: {count}");
    }

}