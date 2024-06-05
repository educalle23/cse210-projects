using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("7 VSCode extensions", "HolaMundo", 10250);
        Video video2 = new Video("Iphone 15 - Unboxing", "Tec-cuento", 8864);
        Video video3 = new Video("10 DIY Phone cases", "Yuya", 13870);

        Comment comment1 = new Comment("Robert", "Now i got prettier, tysm");
        Comment comment2 = new Comment("Luan", "Very informative.");
        Comment comment3 = new Comment("Mario", "Can you do a part 2?");

        Comment comment4 = new Comment("Ramiro", "Amazing camera");
        Comment comment5 = new Comment("Daniela", "Awesome rewiev, when the Iphone 15 ProMax?");
        Comment comment6 = new Comment("Cielo", "I love ypur content");

        Comment comment7 = new Comment("Grace", "Amazing");
        Comment comment8 = new Comment("Heidi", "U r so talented");
        Comment comment9 = new Comment("Ivan", "Definetley I'm going to try it!");

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

        foreach (var video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine(new string('-', 40));
        }
    }
    
    }
