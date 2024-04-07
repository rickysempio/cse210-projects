public class CommentList
{
    public string _nameOfCommentator;
    public string _commentText;

    //public List <Video> _commentList = new List<Video>();
    //public int _numberOfComments;

    public string DisplayCommentDetails()
    {
        
        return ($"Commentator : {_nameOfCommentator} - {_commentText}");

    }
}