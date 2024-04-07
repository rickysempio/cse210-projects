using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Video video1 = new Video();
        video1._author = "James Dean";
        video1._title = "Revel Without A Cause";
        video1._lenght = 30;
        Console.WriteLine(video1.DisplayVideoDetails());
        
        Video video2 = new Video();
        video2._author = "Julia Roberts";
        video2._title = "Nothing Hill";
        video2._lenght = 25;
        Console.WriteLine(video2.DisplayVideoDetails());
        
        
        Video video3 = new Video();
        video3._author = "Jennifer Lawrence";
        video3._title = "Hunger Games";
        video3._lenght = 20;
        Console.WriteLine(video3.DisplayVideoDetails());
        
        
        CommentList comments1 = new CommentList();
        comments1._nameOfCommentator = "Michael";
        comments1._commentText = "Its an awesome video";
        Console.WriteLine(comments1.DisplayCommentDetails());
        
        video1._commentList.Add(comments1);
        
       
        CommentList comments2 = new CommentList();
        comments2._nameOfCommentator = "Jason";
        comments2._commentText = "Very inspiring story";
        Console.WriteLine(comments2.DisplayCommentDetails());

        video1._commentList.Add(comments2);
        

        CommentList comments3 = new CommentList();
        comments3._nameOfCommentator = "Michele";
        comments3._commentText = "Hope everyone learned something on this video";

        Console.WriteLine(comments3.DisplayCommentDetails());

        video1._commentList.Add(comments3);

        Console.WriteLine(video1.DisplayNumberOfComments());


    }
}