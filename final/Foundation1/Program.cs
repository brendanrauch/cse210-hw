using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("MineCraft Mods", "Neo", 630);
        Video video2 = new Video("How To Get Rich", "Macs Aton", 1283);
        Video video3 = new Video("How I was a Judge on the biggest Cooking Show", "Speed", 1367);

        video1.AddComment(new Comment("Big Fan", "Great video!"));
        video1.AddComment(new Comment("Tim", "Your the best"));
        video1.AddComment(new Comment("Chase", "Where can I get that one at the end?"));
        video1.AddComment(new Comment("Steve", "Thanks for sharing!"));


        video2.AddComment(new Comment("Toba ton", "Free BitCoin"));
        video2.AddComment(new Comment("RealPerson28", "It really works"));
        video2.AddComment(new Comment("Dan", "Umm I think this is fake"));

        video3.AddComment(new Comment("Jake", "It was not rigged"));
        video3.AddComment(new Comment("Luddynumber01", "Hmmm I think he was hidding something"));
        video3.AddComment(new Comment("Theoryguy", "Man he caved so quick"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        Console.Clear();

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"Comment by {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}