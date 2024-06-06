using System;


public class Program
{
    public static void Main()
    {
        Video video1 = new Video("Cool Gadgets Review", "TechGuru", 305);
        Video video2 = new Video("DIY Home Decor", "HomeLover", 613);
        Video video3 = new Video("Cooking Pasta", "ChefAlex", 429);
        Video video4 = new Video("Yoga for Beginners", "FitLife", 393);

        List<Comment> comments1 = new List<Comment> {
            new Comment("Alice", "Great video!"),
            new Comment("Bob", "Thanks for the review."),
            new Comment("Charlie", "Very Informative.")
        };
        List<Comment> comments2 = new List<Comment> {
            new Comment("Dave", "Loved the ideas!"),
            new Comment("Eve", "Will try these at home."),
            new Comment("Faythe", "Awesome tips!")
        };
        List<Comment> comments3 = new List<Comment> {
            new Comment("Grace", "Can't wait to try this recipe."),
            new Comment("Heidi", "Looks delicious!"),
            new Comment("Ivan", "Yummy!")
        };
        List<Comment> comments4 = new List<Comment> {
            new Comment("Judy", "Perfect for beginners."),
            new Comment("Mallory", "Very helpful."),
            new Comment("Niaj", "Great session.")
        };
        
        comments1.ForEach(comment => video1.AddComment(comment));
        comments2.ForEach(comment => video2.AddComment(comment));
        comments3.ForEach(comment => video3.AddComment(comment));
        comments4.ForEach(comment => video4.AddComment(comment));

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach (Video video in videos)
        {
            Console.WriteLine(video);
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment);
            }
            Console.WriteLine();
        }
    }
}