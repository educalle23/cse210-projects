using System;

class Program
{
    public static void Main()
    {
        // Creating instances and populating data
        Video video1 = new Video("Cool Gadgets Review", "Tech Guru", 1200);
        Video video2 = new Video("Unboxing New Smartphone", "Mobile Man", 900);
        Video video3 = new Video("DIY Craft Ideas", "Crafty Lady", 1500);

        Comment comment1 = new Comment("Alice", "Great video!");
        Comment comment2 = new Comment("Bob", "Very informative.");
        Comment comment3 = new Comment("Charlie", "I love this!");

        Comment comment4 = new Comment("Dave", "Amazing unboxing!");
        Comment comment5 = new Comment("Eve", "Can’t wait to try this phone.");
        Comment comment6 = new Comment("Frank", "Looks awesome!");

        Comment comment7 = new Comment("Grace", "Wonderful ideas!");
        Comment comment8 = new Comment("Heidi", "I will definitely try this.");
        Comment comment9 = new Comment("Ivan", "So creative!");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying the videos and their comments
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine(new string('-', 40));
        }
    }
    public class Comment
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public Comment(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public override string ToString()
        {
            return $"{Name}: {Text}";
        }
    }

    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; }
        private List<Comment> Comments { get; set; }

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            Comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return Comments.Count;
        }

        public override string ToString()
        {
            string commentsStr = string.Join("\n", Comments);
            return $"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\nNumber of Comments: {GetCommentCount()}\nComments:\n{commentsStr}";
        }
    }

}