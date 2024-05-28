using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
    public int NumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return new List<Comment>(comments);
    }

    public override string ToString()
    {
        int lengthMinutes = Length / 60;
        int lengthSeconds = Length % 60;
        return $"Title: {Title}\nAuthor: {Author}\nLength: {lengthMinutes}m {lengthSeconds}s\nNumber of Comments: {NumberOfComments()}";
    }
}