using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Make Pizza", "Chef Mario", 300);
        video1.AddComment(new Comment("Alice", "Looks delicious!"));
        video1.AddComment(new Comment("Bob", "Can't wait to try this."));
        video1.AddComment(new Comment("Charlie", "Simple and easy to follow."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("C# for Beginners", "Tech Guru", 600);
        video2.AddComment(new Comment("Dana", "Very helpful tutorial."));
        video2.AddComment(new Comment("Eli", "Clear explanation."));
        video2.AddComment(new Comment("Fiona", "Helped me a lot!"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Top 10 Travel Destinations", "Wanderlust", 420);
        video3.AddComment(new Comment("George", "Adding all to my bucket list."));
        video3.AddComment(new Comment("Hannah", "Beautiful places!"));
        video3.AddComment(new Comment("Ian", "Love your videos."));
        videos.Add(video3);

        // Display each video with its details and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }
            Console.WriteLine(); // Spacer between videos
        }
    }
}