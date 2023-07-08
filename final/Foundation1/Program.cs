using System;

class Program{
    static void InitializeProgram(List<Video> videoList)
    {
        Comment comment1;Comment comment2;Comment comment3;
        Video video;List<Comment> commentList;

        comment1 = new Comment("JohnBaringer", "I really hate this video, it just rubbed me the wrong way.");
        comment2 = new Comment("Tims Hardware", "If you found this video helpful check out website for mechanic tutorials!");
        comment3 = new Comment("Alicia Downing", "Thank you so much!");
        commentList = new List<Comment>{comment1,comment2,comment3};
        video = new Video("John's Tutorials",
        "How to change your brakes.", 600, commentList);
        videoList.Add(video);

        comment1 = new Comment("AlecHarding", "Beautiful cover, thank you so much!");
        comment2 = new Comment("Garet'im", "Not the worst things I've heard...");
        comment3 = new Comment("JohnBaringer", "At least try bro...");
        commentList = new List<Comment>{comment1,comment2,comment3};
        video = new Video("Bobby Drake Sings",
        "Silent Night - Cover.", 240, commentList);
        videoList.Add(video);

        comment1 = new Comment("GoogleSpecs", "Thanks man, I was really struggling with getting my page to load fast!");
        comment2 = new Comment("Not An Apple Buyer", "Could you do something similar but with Python?");
        comment3 = new Comment("JSisNotGreat", "I appreciate the video, but I think the program idea presented would be better if it was done in C#.");
        commentList = new List<Comment>{comment1,comment2,comment3};
        video = new Video("Emanuel Codes",
        "JavaScript Tutorials - Using IntersectionObserver to minimize CSS Load Times", 480, commentList);
        videoList.Add(video);
    }
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>{};
        InitializeProgram(videoList);
        foreach(Video video in videoList)
        {
            video.Display();
            Console.WriteLine();
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}