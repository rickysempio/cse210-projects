public class CommentList
{
    public string _nameOfCommentator;
    public string _commentText;



    public string DisplayCommentDetails()
    {
        
        return ($"Commenter: {_nameOfCommentator} - {_commentText}");

    }
}