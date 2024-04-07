using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine();

        Console.WriteLine("Video:");
        Video video1 = new Video();
        video1._author = "James Dean";
        video1._title = "Revel Without A Cause";
        video1._lenght = 30;
        Console.WriteLine(video1.DisplayVideoDetails());

        Console.WriteLine("Comments:");
        CommentList comments1 = new CommentList();
        comments1._nameOfCommentator = "Michael";
        comments1._commentText = "Its an awesome video";

        Console.WriteLine(comments1.DisplayCommentDetails());
        video1._commentList.Add(comments1);

        CommentList comments2 = new CommentList();
        comments2._nameOfCommentator = "Bryan";
        comments2._commentText = "Its a great story!";

        Console.WriteLine(comments2.DisplayCommentDetails());
        video1._commentList.Add(comments2);

       
        Console.WriteLine();
        Console.WriteLine("Video:");
        Video video2 = new Video();
        video2._author = "Julia Roberts";
        video2._title = "Nothing Hill";
        video2._lenght = 25;
        Console.WriteLine(video2.DisplayVideoDetails());

        Console.WriteLine("Comments:");
        CommentList comments3 = new CommentList();
        comments3._nameOfCommentator = "Jason";
        comments3._commentText = "Very inspiring story";

        Console.WriteLine(comments3.DisplayCommentDetails());
        video1._commentList.Add(comments3);

        CommentList comments4 = new CommentList();
        comments4._nameOfCommentator = "Mary";
        comments4._commentText = "Thay have done a great job...";

        Console.WriteLine(comments4.DisplayCommentDetails());
        video1._commentList.Add(comments4);


        Console.WriteLine();
        Console.WriteLine("Video:");
        Video video3 = new Video();
        video3._author = "Jennifer Lawrence";
        video3._title = "Hunger Games";
        video3._lenght = 20;
        Console.WriteLine(video3.DisplayVideoDetails());
    
        Console.WriteLine("Comments:");
        CommentList comments5 = new CommentList();
        comments5._nameOfCommentator = "Michele";
        comments5._commentText = "Hope everyone learned something on this video";

        Console.WriteLine(comments5.DisplayCommentDetails());
        video1._commentList.Add(comments5);

        CommentList comments6 = new CommentList();
        comments6._nameOfCommentator = "Steven";
        comments6._commentText = "Determination is the key to victory..";

        Console.WriteLine(comments6.DisplayCommentDetails());
        video1._commentList.Add(comments6);

        CommentList comments7 = new CommentList();
        comments7._nameOfCommentator = "David";
        comments7._commentText = "keep fighting!";

        Console.WriteLine(comments7.DisplayCommentDetails());
        video1._commentList.Add(comments7);
        Console.WriteLine();


        Console.WriteLine(video1.DisplayNumberOfComments());
        Console.WriteLine();
    }
}