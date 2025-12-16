using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videoList = new List<Video>();

        Video firstVideo = new Video("Stake Conference", "Klein Stake", 7200);
        firstVideo.AddComment(new Comment("Mary", "Best Conference Ever!!"));
        firstVideo.AddComment(new Comment("Ryan", "Had a general authority come, really cool experience."));
        firstVideo.AddComment(new Comment("John", "10/10"));
        firstVideo.AddComment(new Comment("Sophia", " Such a powerful meeting"));
        _videoList.Add(firstVideo);

        Video secondVideo = new Video("SpongeBob", "Nickolodeon", 600);
        secondVideo.AddComment(new Comment("Squidward","ehh spongebob was annoyting"));
        secondVideo.AddComment(new Comment("SpongeBob", "BEST VIDEO I HAVE EVER SEEN!!!!!! REPEAT FOREVER!!!"));
        secondVideo.AddComment(new Comment("Patrick","What's for lunch? oh... what did I like the video, I thought it was my real life."));
        secondVideo.AddComment(new Comment("Crab","Sponsored by the Krusty Krab, make sure to stop by."));
        _videoList.Add(secondVideo);

        Video thirdVideo = new Video("Karens getting Karma","Jake from StateFarm", 60);
        thirdVideo.AddComment(new Comment("Karen","Not true, you shouldn't buy chocolate because sugar."));
        thirdVideo.AddComment(new Comment("Jane", "The amount of karens in the comments agreeing about this lady's rude behavior is unbelievable."));
        thirdVideo.AddComment(new Comment("Jake", "Wow that was crazy"));
        _videoList.Add(thirdVideo);
    
        foreach (Video video in _videoList)
        {
            Console.WriteLine($"Title: {video.GetTitle()} | Author: {video.GetAuthor()} | Length: {video.GetLength()} | Number of Comments: {video.GetCount()}");
            foreach (Comment comment in video.GetComment())
            {
                Console.WriteLine($"Comment: {comment.GetText()} | {comment.GetName()}");
            }
        }
    }
}